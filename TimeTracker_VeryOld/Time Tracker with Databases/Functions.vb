
Imports CrystalDecisions.Shared

Module Functions

    Public DatabaseSource As String = "C:\Time Tracker\timetracker.mdb" 'location of the database

    Public CompanysName As String
    Public PayDay As String
    Public FaxNumber As String
    Public MOTD As String
    Public PayrollContact As String
    Public OwnerName As String
    Public CompanyPhone As String

    Public AssociateLoggedIn As Associate 'used to determine who is sitting at the computer

    Public LoginFormID As frmLogin 'used to globaly ID the login form

    'error checking variables
    Public EC As Boolean = False
    Public ReportSuccessful As Boolean = True

    Public Function GetTwoWeekStart() As Date
        Dim tempDate As Date
        tempDate = GetWeekStart(Now.Date).AddDays(-1)
        Return GetWeekStart(tempDate).ToShortDateString
    End Function

    Public Function GetTwoWeekHours(ByVal TypeOfHours As String, ByVal Person As String) As Double

        'this function should only be run on the last day of the payperiod
        If Now.DayOfWeek.ToString <> PayDay Then
            MsgBox("It is not currently " & PayDay)
            Return -1 'Exit Function with an error value
        End If

        Dim TempHours As Double = 0
        Dim NormalHours As Double = 0
        Dim OverTimeHours As Double = 0

        'first week
        TempHours = CalculateHoursInWeek(GetWeekStart(Now.Date), Now.Date, Person, False)
        If TempHours > 40 Then
            NormalHours = 40
            OverTimeHours = TempHours - 40
        Else
            NormalHours = TempHours
        End If

        Dim tempDate As Date
        tempDate = GetWeekStart(Now.Date).AddDays(-1)

        TempHours = CalculateHoursInWeek(GetWeekStart(tempDate), tempDate, Person, False)
        If TempHours > 40 Then
            NormalHours = NormalHours + 40
            OverTimeHours = OverTimeHours + (TempHours - 40)
        Else
            NormalHours = NormalHours + TempHours
        End If

        If TypeOfHours = "overtime" Then
            Return OverTimeHours
        Else
            Return NormalHours
        End If

    End Function

    Public Function CreateTimeReport(ByVal TypeOfReport As String) As ParameterFields

        ReportSuccessful = True

        Dim ThisWeekReport As MsgBoxResult
        Dim ReportStartDate As Date
        Dim ReportEndDate As Date

        If TypeOfReport = "detailed" Then
            ThisWeekReport = MsgBox("Would you like to run the time report for this week?", MsgBoxStyle.YesNoCancel)
            If ThisWeekReport = MsgBoxResult.Yes Then
                ReportEndDate = Now.Date
                ReportStartDate = GetWeekStart(Now.Date)
            ElseIf ThisWeekReport = MsgBoxResult.Cancel Then
                'do nothing
            ElseIf ThisWeekReport = MsgBoxResult.No Then
                'pick the start date and end date of the report
                frmGetDate.lblReason.Text = "Select the date to start the report"
                If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ReportStartDate = frmGetDate.cldDate.SelectionStart
                End If

                frmGetDate.lblReason.Text = "Select the date to end the report"
                If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ReportEndDate = frmGetDate.cldDate.SelectionStart
                End If

            End If
        End If

        If TypeOfReport = "overview" Then
            ReportStartDate = GetTwoWeekStart()
            ReportEndDate = Now.Date
        End If

        Dim DateCounter As Integer = 0
        Dim DaysInReport As TimeSpan

        DaysInReport = ReportEndDate.Subtract(ReportStartDate)

        Dim ReportDates(DaysInReport.Days) As Date

        For DateCounter = 0 To DaysInReport.Days
            ReportDates(DateCounter) = ReportStartDate.AddDays(DateCounter)
        Next

        'crystal reports thing
        Dim ParamFields As New ParameterFields()

        '********SETUP Header**************
        Dim TitleParamField As New ParameterField()
        Dim TitleDiscreteVal As New ParameterDiscreteValue()
        TitleParamField.ParameterFieldName = "Title"
        If TypeOfReport = "overview" Then
            TitleDiscreteVal.Value = "Time Report Summary"
        Else
            TitleDiscreteVal.Value = "Detailed Time Report"
        End If
        TitleParamField.CurrentValues.Add(TitleDiscreteVal)
        ParamFields.Add(TitleParamField)


        Dim DatesParamField As New ParameterField()
        Dim DatesDiscreteVal As New ParameterDiscreteValue()
        DatesParamField.ParameterFieldName = "Dates"
        If TypeOfReport = "overview" Then
            DatesDiscreteVal.Value = ""
        Else
            DatesDiscreteVal.Value = ReportStartDate.ToShortDateString + " to " + ReportEndDate.ToShortDateString
        End If

        DatesParamField.CurrentValues.Add(DatesDiscreteVal)
        ParamFields.Add(DatesParamField)

        Dim SubjectParamField As New ParameterField()
        Dim SubjectDiscreteVal As New ParameterDiscreteValue()
        SubjectParamField.ParameterFieldName = "Subject"
        If TypeOfReport = "overview" Then
            SubjectDiscreteVal.Value = "Payroll Period: " + ReportStartDate.ToShortDateString + " to " + ReportEndDate.ToShortDateString
        Else
            SubjectDiscreteVal.Value = ""
        End If
        SubjectParamField.CurrentValues.Add(SubjectDiscreteVal)
        ParamFields.Add(SubjectParamField)

        Dim ToParamField As New ParameterField()
        Dim ToDiscreteVal As New ParameterDiscreteValue()
        ToParamField.ParameterFieldName = "To"
        If TypeOfReport = "overview" Then
            ToDiscreteVal.Value = "To: " + PayrollContact + ", FAX " + FaxNumber
        Else
            ToDiscreteVal.Value = ""
        End If
        ToParamField.CurrentValues.Add(ToDiscreteVal)
        ParamFields.Add(ToParamField)

        Dim FromParamField As New ParameterField()
        Dim FromDiscreteVal As New ParameterDiscreteValue()
        FromParamField.ParameterFieldName = "From"
        If TypeOfReport = "overview" Then
            FromDiscreteVal.Value = "From: " + OwnerName + " , PHONE " + CompanyPhone
        Else
            FromDiscreteVal.Value = ""
        End If
        FromParamField.CurrentValues.Add(FromDiscreteVal)
        ParamFields.Add(FromParamField)

        '**********END SETUP Header**********

        '*****************Timed Report***************
        Dim TimedParamField As New ParameterField()
        Dim TimedDiscreteVal As New ParameterDiscreteValue()
        Dim TimedAssociate As New Associate()
        Dim TimedAssociateList As ArrayList = GetAssociateList("Timed", "associatename")

        Dim CurrentTimedAssociateName As String
        Dim CurrentDay As Date
        Dim TotalHours As Double = 0
        Dim HoursInCurrentDay As Double = 0
        Dim NormalHours As Double = 0
        Dim OverTimeHours As Double = 0

        For Each CurrentTimedAssociateName In TimedAssociateList
            TimedAssociate = GetAssociateData(CurrentTimedAssociateName)

            TimedDiscreteVal.Value = TimedDiscreteVal.Value + vbCrLf + TimedAssociate.Name.ToString + vbCrLf + TimedAssociate.Social.ToString + vbCrLf

            If TypeOfReport = "detailed" Then
                Dim HasHours As Boolean = False
                For Each CurrentDay In ReportDates
                    HoursInCurrentDay = CalculateHoursInDay(CurrentDay, TimedAssociate.Name, True)
                    If HoursInCurrentDay > 0 Then
                        HasHours = True
                        TimedDiscreteVal.Value = TimedDiscreteVal.Value + CurrentDay.DayOfWeek.ToString + ":" + HoursInCurrentDay.ToString + " "
                    End If
                Next
                If HasHours = True Then
                    TimedDiscreteVal.Value = TimedDiscreteVal.Value + vbCrLf
                End If
            End If

            If TypeOfReport = "detailed" Then
                TotalHours = CalculateHoursInWeek(ReportDates(0), ReportDates(DaysInReport.Days), TimedAssociate.Name, False)

                If TotalHours > 40 Then
                    NormalHours = 40
                    OverTimeHours = TotalHours - 40
                Else
                    NormalHours = TotalHours
                    OverTimeHours = 0
                End If
                NormalHours = FormatNumber(NormalHours, 2)
                OverTimeHours = FormatNumber(OverTimeHours, 2)

            Else 'TypeOfReport="overview"
                NormalHours = GetTwoWeekHours("normal", TimedAssociate.Name)
                If NormalHours = -1 Then 'getTwoWeekHours decided it was not the correct day to run the report
                    ReportSuccessful = False
                    Return ParamFields
                    Exit Function
                End If
                OverTimeHours = FormatNumber(GetTwoWeekHours("overtime", TimedAssociate.Name), 2)
            End If

            TimedDiscreteVal.Value = TimedDiscreteVal.Value + "Normal Time: " + NormalHours.ToString + vbCrLf
            TimedDiscreteVal.Value = TimedDiscreteVal.Value + "Over Time: " + OverTimeHours.ToString + vbCrLf

        Next
        ' Set the field in the report we will write to
        TimedParamField.ParameterFieldName = "TimedReport"

        ' Add the parameter to the parameter fields collection.
        TimedParamField.CurrentValues.Add(TimedDiscreteVal)
        ParamFields.Add(TimedParamField)

        If EC = True Then
            MsgBox("Timed Report Created!")
        End If

        '*****************End Timed Report***************


        '*****************Non-Timed Report***************
        ' Declare variables needed to pass the parameters
        ' to the viewer control.

        Dim NonTimedParamField As New ParameterField()
        Dim NonTimedDiscreteVal As New ParameterDiscreteValue()
        Dim NonTimedAssociate As New Associate
        Dim ManagerAssociateList As ArrayList = GetAssociateList("manager", "associatename")
        Dim CommissionedAssociateList As ArrayList = GetAssociateList("commissioned", "associatename")
        NonTimedParamField.ParameterFieldName = "NonTimedReport"
        Dim NonTimedAssociateList As New ArrayList

        Dim i As Integer
        For i = 0 To ManagerAssociateList.Count - 1
            NonTimedAssociateList.Add(ManagerAssociateList(i).ToString)
        Next
        Dim j As Integer
        For j = 0 To CommissionedAssociateList.Count - 1
            NonTimedAssociateList.Add(CommissionedAssociateList(j).ToString)
        Next

        Dim NonTimedCounter As Integer = 0
        For NonTimedCounter = 0 To NonTimedAssociateList.Count - 1
            NonTimedAssociate = GetAssociateData(NonTimedAssociateList(NonTimedCounter))
            NonTimedDiscreteVal.Value = NonTimedDiscreteVal.Value + vbCrLf + NonTimedAssociate.Name + vbCrLf + NonTimedAssociate.Social + vbCrLf + "Commission:" + vbCrLf + "Salary:" + vbCrLf
        Next

        ' Set the field in the report we will write to
        NonTimedParamField.ParameterFieldName = "NonTimedReport"
        NonTimedParamField.CurrentValues.Add(NonTimedDiscreteVal)

        ' Add the parameter to the parameter fields collection.
        ParamFields.Add(NonTimedParamField)

        '*****************End Non-Timed Report***************

        Return ParamFields
    End Function

    Public Function GetWeekStart(ByVal CurrentDay As Date) As Date
        Dim Counter As Integer

        Dim WeekStart As String = ""

        For Counter = 1 To 7
            If WeekdayName(Counter) = PayDay Then
                If Counter < 7 Then
                    WeekStart = WeekdayName(Counter + 1)
                Else
                    WeekStart = WeekdayName(1)
                End If

            End If
        Next

        If EC = True Then
            MsgBox("weekstart= " + WeekStart)
        End If

        For Counter = 0 To 6

            If CurrentDay.DayOfWeek.ToString = WeekStart Then
                If EC = True Then
                    MsgBox(CurrentDay.Date.ToShortDateString)
                End If
                Return CurrentDay.Date.ToShortDateString 'the next day after payday is the first day of the week
            Else
                CurrentDay = CurrentDay.AddDays(-1)
            End If

        Next


    End Function

    Public Function GetDataSet(ByVal TableName As String, ByVal FieldName As String, ByVal WhereString As String, ByVal OrderByString As String) As DataSet
        Dim MyDataSet As New DataSet
        Dim MyDatabaseConnection As New OleDb.OleDbConnection


        MyDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        Dim MyWhereString As String
        If WhereString = "" Then
            MyWhereString = ""
        Else
            MyWhereString = " WHERE " & WhereString
        End If

        Dim MyOrderByString As String
        If OrderByString = "" Then
            MyOrderByString = ""
        Else
            MyOrderByString = " order by " & OrderByString
        End If

        Dim AssociateQuery As String = "SELECT " & FieldName & " FROM " & TableName & MyWhereString & MyOrderByString

        Dim MyDataAdapter As New OleDb.OleDbDataAdapter(AssociateQuery, MyDatabaseConnection)
        MyDataAdapter.Fill(MyDataSet, TableName)

        Return MyDataSet
    End Function

    Public Function PutDataSet(ByVal DataToPut As DataSet, ByVal TableName As String) As Boolean

        Dim MyDataSet As New DataSet
        Dim MyDatabaseConnection As New OleDb.OleDbConnection
        MyDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource
        Dim AssociateQuery As String = "SELECT * FROM " & TableName

        Dim MyDataAdapter As New OleDb.OleDbDataAdapter(AssociateQuery, MyDatabaseConnection)
        MyDataAdapter.Fill(MyDataSet, TableName)

        MyDataSet = DataToPut

        Dim MyCmdBuilder As New System.Data.OleDb.OleDbCommandBuilder(MyDataAdapter)
        MyDataAdapter.Update(MyDataSet.GetChanges, TableName)

        MyDatabaseConnection.Close()

        Return True
    End Function

    Public Function LoadNameListBox(ByVal ListBoxToLoad As ListBox, ByVal TypeToLoad As String) As Boolean
        ListBoxToLoad.Items.Clear()
        Dim AssociateList As New ArrayList
        AssociateList = GetAssociateList(TypeToLoad, "")
        Dim i As Integer

        For i = 0 To AssociateList.Count - 1
            ListBoxToLoad.Items.Add(AssociateList(i))
        Next i

        Return True

    End Function

    Public Function GetAssociateList(ByVal TypeToLoad As String, ByVal OrderBy As String) As ArrayList

        Dim ListDataSet As DataSet
        If TypeToLoad = "*" Then
            ListDataSet = GetDataSet("associate", "associatename", "", OrderBy)
        Else
            ListDataSet = GetDataSet("associate", "associatename", "type='" & TypeToLoad & "'", OrderBy)
        End If

        Dim ListString As New ArrayList

        Dim i As Integer = 0
        'since we start at 0, we must go to length-1
        For i = 0 To ListDataSet.Tables("associate").Rows.Count - 1
            ListString.Add(ListDataSet.Tables("associate").Rows(i).Item("AssociateName").ToString)
        Next i

        Return ListString
    End Function

    Public Function WriteAssociateData(ByVal WhichAssociate As Associate) As Boolean
        'open the database
        Dim AssociateDataSet As DataSet = GetDataSet("associate", "*", "", "")
        '        Dim AssociateToDeleteDataSet As DataSet = GetDataSet("associate", "*", "associatename='" & WhichAssociate.Name & "'", "")

        'find which row, if any, the associate previously existed in
        Dim RowCounter As Integer
        Dim RowToDelete As Integer = -1

        For RowCounter = 0 To AssociateDataSet.Tables("associate").Rows.Count - 1
            If AssociateDataSet.Tables("associate").Rows(RowCounter).Item("associatename") = WhichAssociate.Name Then
                RowToDelete = RowCounter
            End If
        Next


        'delete the "old" associate if they already exist
        Try
            If RowToDelete > -1 Then
                AssociateDataSet.Tables("associate").Rows(RowToDelete).Delete()
            End If
        Catch ex As Exception
            'if the deletion worked, do nothing
        End Try

        'create a new row
        Dim AssociateNewRow As System.Data.DataRow
        AssociateNewRow = AssociateDataSet.Tables("associate").NewRow

        'add all the attributes to the new row
        AssociateNewRow.Item("associatename") = WhichAssociate.Name
        AssociateNewRow.Item("socialsecuritynumber") = WhichAssociate.Social
        AssociateNewRow.Item("startingdate") = WhichAssociate.StartDate
        AssociateNewRow.Item("vacationhours") = WhichAssociate.VacationHours
        AssociateNewRow.Item("type") = WhichAssociate.Type
        AssociateNewRow.Item("sickhours") = WhichAssociate.SickHours
        AssociateNewRow.Item("pin") = WhichAssociate.Pin

        AssociateDataSet.Tables("associate").Rows.Add(AssociateNewRow)

        PutDataSet(AssociateDataSet, "associate")

    End Function

    Public Function ToShortReason(ByVal LongReason As String) As String
        'converts long reason to short reason
        'Inputs: A LongReason (ex. for the day)
        'Outputs: A ShortReason (ex. DAY)
        Dim ShortReason As String

        If LongReason = "For the day" Then
            ShortReason = "DAY"
        ElseIf LongReason = "From lunch" Then
            ShortReason = "LUNCH"
        ElseIf LongReason = "From a misc." Then
            ShortReason = "MISC"
        ElseIf LongReason = "From Smoking" Then
            ShortReason = "SMOKE"
        Else
            ShortReason = "ERROR"
        End If

        Return ShortReason
    End Function

    Public Function CalculateHoursInWeek(ByVal StartDate As System.DateTime, ByVal EndDate As System.DateTime, ByVal PersonToCalculate As String, ByVal DisplayErrors As Boolean) As Double
        Dim DayCounter As Integer
        Dim NumberOfDays As Integer

        If EC = True Then
            MsgBox("Start date: " & StartDate.ToShortDateString)
            MsgBox("End date: " & EndDate.ToShortDateString)
        End If

        NumberOfDays = EndDate.Subtract(StartDate).Days

        If EC = True Then
            MsgBox("number of days = " & NumberOfDays.ToString)
        End If

        Dim TotalHours As Double = 0

        For DayCounter = 0 To NumberOfDays
            TotalHours = TotalHours + CalculateHoursInDay(StartDate.AddDays(DayCounter), PersonToCalculate, DisplayErrors)
        Next

        Return TotalHours
    End Function


    Public Function CalculateHoursInDay(ByVal DateToCalculate As System.DateTime, ByVal PersonToCalculate As String, ByVal DisplayErrors As Boolean) As Double
        Dim TempTimeSpan As System.TimeSpan
        Dim TempHours As Double

        Dim GetTimeDataSet As DataSet = GetDataSet("eventTable", "*", "associate='" & PersonToCalculate & "' and datefield=#" & DateToCalculate & "#", "timeField")

        Dim NumberOfEvents As Integer = GetTimeDataSet.Tables("eventTable").Rows.Count

        If EC = True Then
            MsgBox(PersonToCalculate.ToString + " has " + NumberOfEvents.ToString + " events on " & DateToCalculate.ToShortDateString)
        End If
        'check to see if there is a valid number of events
        If (NumberOfEvents Mod 2 = 1) Then 'number of events in day is odd
            If DisplayErrors = True Then
                MsgBox(PersonToCalculate + " has an odd number of events on " & DateToCalculate.ToShortDateString & "!")
            End If

            Return 0 'return an error
        End If

        If NumberOfEvents = 0 Then
            Return 0
        End If

        Dim i As Integer = 0
        Dim Time1 As DateTime
        Dim Time2 As DateTime
        Dim Date1 As Date
        Dim Date2 As Date


        While i < NumberOfEvents - 1 'since events start with #0
            Time1 = GetTimeDataSet.Tables("eventTable").Rows(i).Item("TimeField")
            Date1 = GetTimeDataSet.Tables("eventTable").Rows(i).Item("DateField")
            Time2 = GetTimeDataSet.Tables("eventTable").Rows(i + 1).Item("TimeField")
            Date2 = GetTimeDataSet.Tables("eventTable").Rows(i + 1).Item("DateField")
            Dim Event1 As New DateTime(Date1.Year, Date1.Month, Date1.Day, Time1.Hour, Time1.Minute, Time1.Second)
            Dim Event2 As New DateTime(Date2.Year, Date2.Month, Date2.Day, Time2.Hour, Time2.Minute, Time2.Second)

            TempTimeSpan = Event2.Subtract(Event1)
            TempHours = TempHours + TempTimeSpan.TotalHours
            If EC = True Then
                MsgBox("Event " & i.ToString & " has " & TempTimeSpan.TotalHours.ToString)
            End If
            i += 2
        End While

        If EC = True Then
            MsgBox(DateToCalculate.ToShortDateString & " : " & FormatNumber(TempHours, 2))
        End If

        Return FormatNumber(TempHours, 2)
    End Function

    Public Function GetAssociateData(ByVal AssociateName As String) As Associate
        'make a connection to the database
        Dim DatabaseConnection As New OleDb.OleDbConnection
        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource
        Try
            DatabaseConnection.Open()
        Catch ex As Exception
            MsgBox("Couldn't open database.")
        End Try


        Dim GetAssociateDataDataSet As New DataSet
        Dim GetAssociateDataAdapter As OleDb.OleDbDataAdapter

        Dim Query As String = "SELECT * FROM Associate where AssociateName='" & AssociateName & "'"
        GetAssociateDataAdapter = New OleDb.OleDbDataAdapter(Query, DatabaseConnection)
        Try
            GetAssociateDataAdapter.Fill(GetAssociateDataDataSet, "Associate")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'create new associate
        Dim NewAssociate As New Associate

        'get name
        NewAssociate.Name = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("AssociateName")
        'get social
        NewAssociate.Social = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("SocialSecurityNumber")
        'get PIN
        NewAssociate.Pin = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("PIN")
        'get associate type
        NewAssociate.Type = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("Type")
        'get starting date
        NewAssociate.StartDate = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("StartingDate")
        'get sick hours
        NewAssociate.SickHours = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("SickHours")
        'get vacation days
        NewAssociate.VacationHours = GetAssociateDataDataSet.Tables("associate").Rows(0).Item("VacationHours")



        DatabaseConnection.Close()

        Return NewAssociate

    End Function

End Module
