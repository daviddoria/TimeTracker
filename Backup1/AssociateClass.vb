Imports System.Collections.Generic

'This class is to store information about an associate.

Public Enum AssociateType
    ALL
    TIMED
    COMMISSIONED
    MANAGER
    INVALID
End Enum

Public Class Associate

    Private _name As String ' The associate's name
    Private _social As String ' The associate's social security number
    Private _pin As String ' The associates PIN for Time Tracker
    Private _type As AssociateType ' The associate's "type" (either TIMED COMMISSIONED, or MANAGER)

    'default constructor
    Public Sub New()
        _name = "NAME"
        _social = "123456789"
        _pin = "123"
        _type = AssociateType.INVALID
    End Sub

    Public Function ToString() As String
        'create a string with all of the associate's information
        Dim AssociateString As String = _name + " " + _social + " " + _pin + " " + _type.GetString
        Return AssociateString
    End Function

    'constructor from data
    Public Sub New(ByVal Name As String, ByVal Social As String, ByVal Pin As String, ByVal Type As AssociateType)
        _name = Name
        _social = Social
        _pin = Pin
        _type = Type
    End Sub

    'constructor from database
    Public Sub New(ByVal Name As String)
        'get the row of the associate
        Dim daAssociate As New TTDataSetTableAdapters.AssociateTableTableAdapter
        Dim dtAssociate As New TTDataSet.AssociateTableDataTable
        daAssociate.FillByName(dtAssociate, Name)

        If dtAssociate.Rows.Count = 0 Then
            MessageBox.Show("There is no associate named " + Name)
            End
        End If

        Dim AssociateRow As TTDataSet.AssociateTableRow = DirectCast(dtAssociate.Rows(0), TTDataSet.AssociateTableRow)

        'construct the Associate object
        _name = Name
        _social = AssociateRow.SocialSecurityNumber
        _pin = AssociateRow.PIN
        _type = AssociateRow.Type.GetAssociateType

    End Sub

    'Associate name accessor/mutator
    Public Property Name() As String
        Get
            Return _name
        End Get

        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    'Associate social sectury number accessor/mutator
    Public Property Social() As String
        Get
            Return _social
        End Get

        Set(ByVal Value As String)
            _social = Value
        End Set
    End Property

    'Associate pin accessor/mutator
    Public Property Pin() As String
        Get
            Return _pin
        End Get

        Set(ByVal Value As String)
            _pin = Value
        End Set
    End Property

    'Associate type accessor/mutator
    Public Property Type() As AssociateType
        Get
            Return _type
        End Get

        Set(ByVal Value As AssociateType)
            _type = Value
        End Set
    End Property

    Public Function WriteData() As Boolean
        'This function writes the associates information to the database.
        'If the associate already exists in the database, the old entry is deleted, and the new one is added.

        Dim daAssociate As New TTDataSetTableAdapters.AssociateTableTableAdapter
        Dim dtAssociate As New TTDataSet.AssociateTableDataTable
        daAssociate.FillByName(dtAssociate, Name)

        'delete the "old" associate if they already exist
        If dtAssociate.Rows.Count = 1 Then
            dtAssociate.Rows(0).Delete()
        End If

        'create a new row
        Dim AssociateNewRow As TTDataSet.AssociateTableRow = DirectCast(dtAssociate.NewRow, TTDataSet.AssociateTableRow)

        'add all the attributes to the new row
        AssociateNewRow.AssociateName = _name
        AssociateNewRow.SocialSecurityNumber = _social
        AssociateNewRow.Type = _type.GetString
        AssociateNewRow.PIN = _pin

        'add the new row to the table in memory
        dtAssociate.Rows.Add(AssociateNewRow)

        'commit the changes to the database
        daAssociate.Update(dtAssociate)

    End Function

    Public Sub WriteEvent(ByVal CurrentEvent As PunchEvent)
        'write a punch event for this associate to the database

        Dim daEvent As New TTDataSetTableAdapters.PunchEventTableTableAdapter
        Dim EventTable As New TTDataSet.PunchEventTableDataTable

        'do you need to do this?
        'daEvent.Fill(EventTable)

        'setup new row and add it

        Dim PunchInNewRow As TTDataSet.PunchEventTableRow = EventTable.NewPunchEventTableRow

        'add all the attributes to the new row
        PunchInNewRow.AssociateName = _name
        PunchInNewRow.TimeField = CurrentEvent.PunchTime
        PunchInNewRow.InOut = CurrentEvent.Direction.GetString
        PunchInNewRow.Reason = CurrentEvent.Reason.GetString
        'PunchInNewRow.Reason = ReasonToString(CurrentEvent.Reason)

        EventTable.Rows.Add(PunchInNewRow)

        daEvent.Update(EventTable)

    End Sub

    Public Sub ShowArea()
        'Display the correct form after login based on the type of associate.

        If Type = AssociateType.MANAGER Then
            frmManager.ShowDialog()
        ElseIf Type = AssociateType.TIMED Then
            frmAssociate.ShowDialog()
        Else
            MsgBox("This associate type cannot login.")
            Exit Sub
        End If
    End Sub

    Public Function GetLastEvent() As PunchEvent
        'get the most recent event of the associate

        'uses fancy subquery
        'SELECT  Associate, TimeField, InOut, Reason, [Key]
        'FROM(PunchEventTable)
        'WHERE  (TimeField =
        '(SELECT  MAX(TimeField) AS Expr1
        'FROM     PunchEventTable PunchEventTable_1
        'WHERE  (Associate LIKE ?))) AND (Associate LIKE ?)

        Dim daEvent As New TTDataSetTableAdapters.PunchEventTableTableAdapter
        Dim dtEvent As New TTDataSet.PunchEventTableDataTable
        daEvent.FillByLast(dtEvent, Name)

        Dim LastEvent As New PunchEvent

        'if there are no events, this is either an error or a new associate.
        'if there are events, extract the data and create a PunchEvent object to return
        If dtEvent.Rows.Count = 0 Then
            MsgBox("Could not get previous event. If this is not your first day, please see a manager.")
            LastEvent.Valid = False
        Else
            Dim LastEventRow As TTDataSet.PunchEventTableRow = DirectCast(dtEvent.Rows(0), TTDataSet.PunchEventTableRow)
            LastEvent.Reason = LastEventRow.Reason.GetEventReason
            LastEvent.PunchTime = LastEventRow.TimeField
            LastEvent.Direction = LastEventRow.InOut.GetEventDirection
            LastEvent.Valid = True
        End If

        Return LastEvent

    End Function

    Public Function CalculateDailyHours(ByVal DailyEvents As List(Of PunchEvent)) As DailyHours
        'This function works by finding the total time the associate was at work (OUT DAY - IN DAY),
        'the total time they were on break, and the time they were at lunch. These values are stored in the DailyHours class
        'which computes more useful quantities.

        'Dim DayHours As ValidDouble
        'Dim LunchHours As ValidDouble
        'Dim BreakHours As ValidDouble

        Dim DayEvents As New DayEvent(ExtractEvents(DailyEvents, EventReason.DAY))
        Dim LunchEvents As New LunchEvent(ExtractEvents(DailyEvents, EventReason.LUNCH))
        Dim BreakEvents As New BreakEvent(ExtractEvents(DailyEvents, EventReason.BREAK))

        Dim DayHours As ValidDouble = DayEvents.CalculateTime
        Dim LunchHours As ValidDouble = LunchEvents.CalculateTime
        Dim BreakHours As ValidDouble = BreakEvents.CalculateTime

        If DayHours.Valid = True And LunchHours.Valid = True And BreakHours.Valid = True Then
            Dim Hours As New DailyHours(BreakHours, LunchHours, DayHours)
            Hours.Valid = True
            Return Hours
        Else
            Dim InvalidHours As New DailyHours
            InvalidHours.Valid = False
            Return InvalidHours
        End If
     
    End Function

    Public Function GetEvents(ByVal DateOfEvents As DateTime, ByVal TypeOfEvent As EventReason) As List(Of PunchEvent)

        Dim daEvent As New TTDataSetTableAdapters.PunchEventTableTableAdapter
        Dim dtEvent As New TTDataSet.PunchEventTableDataTable
        daEvent.FillByAssociateDateReason(dtEvent, Name, TypeOfEvent.GetString, DateOfEvents.ToShortDateString)

        Dim EventList As New List(Of PunchEvent)

        For Each EventRow As TTDataSet.PunchEventTableRow In dtEvent.Rows
            Dim TempEvent As New PunchEvent(EventRow.Reason.GetEventReason, EventRow.InOut.GetEventDirection, EventRow.TimeField)
            EventList.Add(TempEvent)
        Next

        Return EventList

    End Function


    'Public Function NumLunchEvents(ByVal AllEvents As List(Of PunchEvent)) As Double
    '    Dim LunchEvents As List(Of PunchEvent) = ExtractEvents(AllEvents, EventReason.LUNCH)
    '    Return LunchEvents.Count
    'End Function


    Public Function CalculateTimeInWeek(ByVal DaysInWeek As List(Of Date)) As WeeklyHours
        'Inputs: A list of Date's to calculate the times for.
        'Outputs: A WeeklyHours containing the total number of hours worked in the week.

        Dim Weekly As New WeeklyHours
        Dim TotalHours As Double = 0

        For Each CurrentDate As Date In DaysInWeek
            Dim DateEvents As List(Of PunchEvent) = GetEvents(CurrentDate, EventReason.ALL)
            Dim DayHours As DailyHours = CalculateDailyHours(DateEvents)
            If DayHours.Valid = True Then
                TotalHours = TotalHours + DayHours.TotalTime
            Else
                Weekly.Valid = False
                Return Weekly
            End If
        Next

        Weekly.TotalTime = TotalHours
        Weekly.Valid = True
        Return Weekly

    End Function


End Class