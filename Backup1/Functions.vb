Imports System.Data
Imports System.Collections.Generic



Module Functions

    Public BackgroundColor As Color = Color.LightSteelBlue

    Public Company As New CompanyClass
    Public AssociateLoggedIn As Associate 'used to determine who is sitting at the computer

    Public Function IsPayrollSubmission(ByVal InDate As Date) As Boolean

    End Function

    Public Function GetTwoWeekStart(ByVal InDate As Date) As Date
        'Find the first day of the company week that InDate belongs to.
        'The day before that belongs to the previous week - find the first day of that week.
        'This is the starting day of the 2 week period that this day belongs to.
        Dim tempDate As Date = GetWeekStart(InDate).AddDays(-1)

        Return GetWeekStart(tempDate)
    End Function

    Public Function GetPayperiodHours(ByVal CurrentAssociate As Associate, ByVal EndDate As Date) As PayperiodHours

        'first week
        Dim tempDate As Date
        tempDate = GetWeekStart(EndDate).AddDays(-1)
        Dim Week1Dates As List(Of Date) = GetDaysInWeek(GetWeekStart(tempDate), tempDate)
        Dim Week1Hours As WeeklyHours = CurrentAssociate.CalculateTimeInWeek(Week1Dates)

        'second week
        Dim Week2Dates As List(Of Date) = GetDaysInWeek(GetWeekStart(EndDate), EndDate)
        Dim Week2Hours As WeeklyHours = CurrentAssociate.CalculateTimeInWeek(Week2Dates)

        Dim Payperiod As New PayperiodHours(Week1Hours, Week2Hours)
        Return Payperiod

    End Function

    Public Function GetDaysInWeek(ByVal StartDate As Date, ByVal EndDate As Date) As List(Of Date)
        Dim NumberOfDays As Integer = EndDate.Subtract(StartDate).Days
        Dim ListOfDates As New List(Of Date)

        Dim CurrentDate As Date = StartDate

        While Not CurrentDate.ToShortDateString = EndDate.AddDays(1).ToShortDateString
            ListOfDates.Add(CurrentDate)
            CurrentDate = CurrentDate.AddDays(1)
        End While

        Return ListOfDates
    End Function

    Public Function GetWeekStart(ByVal CurrentDay As Date) As Date

        'the corner case is we are already at the payday
        If CurrentDay.DayOfWeek.ToString.ToUpper = Company.PayDay.ToUpper Then
            Return CurrentDay.Date.AddDays(-6)
        End If

        'for all days not the pay day, look for the previous week start date
        While Not CurrentDay.DayOfWeek.ToString.ToUpper = Company.PayDay.ToUpper
            CurrentDay = CurrentDay.AddDays(-1)
        End While

        Return CurrentDay.Date.AddDays(1)

    End Function

    Public Sub LoadNameListBox(ByVal ListBoxToLoad As ListBox, ByVal TypeToLoad As AssociateType)
        'populate a list box with a particular type of associate names
        ListBoxToLoad.Items.Clear()

        Dim AssociateList As List(Of String) = GetAssociateNames(TypeToLoad)

        If AssociateList Is Nothing Then
            MessageBox.Show("No names to load into listbox!")
        End If

        For Each AssociateName As String In AssociateList
            ListBoxToLoad.Items.Add(AssociateName)
        Next

    End Sub


    Public Function ExtractEvents(ByVal AllEvents As List(Of PunchEvent), ByVal Reason As EventReason) As List(Of PunchEvent)

        'Inputs: A list of events.
        'Outputs: A list of events that match the specified type.

        Dim ExtractedEvents As New List(Of PunchEvent)

        For Each TempEvent As PunchEvent In AllEvents
            If TempEvent.Reason = Reason Then
                ExtractedEvents.Add(TempEvent)
            End If
        Next

        Return ExtractedEvents

    End Function

    Public Function GetAssociateNames(ByVal TypeToLoad As AssociateType) As List(Of String)
        Dim daAssociate As New TTDataSetTableAdapters.AssociateTableTableAdapter
        Dim dtAssociate As New TTDataSet.AssociateTableDataTable
        daAssociate.FillByType(dtAssociate, TypeToLoad.GetString)

        Dim NameList As New List(Of String)

        For Each AssociateRow As TTDataSet.AssociateTableRow In dtAssociate.Rows
            NameList.Add(AssociateRow.AssociateName)
        Next

        Return NameList

    End Function

    Public Function GetAssociates(ByVal TypeToLoad As AssociateType) As List(Of Associate)
        Dim daAssociate As New TTDataSetTableAdapters.AssociateTableTableAdapter
        Dim dtAssociate As New TTDataSet.AssociateTableDataTable
        daAssociate.FillByType(dtAssociate, TypeToLoad.GetString)

        Dim AssociateList As New List(Of Associate)

        For Each AssociateRow As TTDataSet.AssociateTableRow In dtAssociate.Rows
            AssociateList.Add(New Associate(AssociateRow.AssociateName))
        Next

        Return AssociateList

    End Function

    Public Function CombineDateAndTime(ByVal InDate As Date, ByVal InTime As DateTime) As DateTime
        Return New DateTime(InDate.Year, InDate.Month, InDate.Day, InTime.Hour, InTime.Minute, InTime.Second)
    End Function

    Public Function GetVersionNumber() As Date
        Dim ver As String = frmLogin.GetType.Assembly.GetName.Version.ToString

        Dim strStrings() As String = ver.Split(Convert.ToChar("."))

        Dim Days As Integer = Convert.ToInt16(strStrings(2))

        Dim Start As New Date(2000, 1, 1)
        Return Start.AddDays(Days)
    End Function
End Module

