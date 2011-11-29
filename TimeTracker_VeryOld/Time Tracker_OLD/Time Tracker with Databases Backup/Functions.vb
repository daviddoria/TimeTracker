Module Functions

    Public DatabaseSource As String = "C:\Time Tracker\timetracker.mdb" 'location of the database

    Public CompanysName As String
    Public PayDay As String
    Public FaxNumber As String
    Public MOTD As String
    Public PayrollContact As String


    Public AssociateLoggedIn As Associate 'used to determine who is sitting at the computer

    Public LoginFormID As frmLogin 'used to globaly ID the login form

    'error checking variables
    Public EC As Boolean = True

    Public Function GetWeekStart(ByVal CurrentDay As Date) As Date
        Dim Counter As Integer

        For Counter = 0 To 6
            If CurrentDay.DayOfWeek.ToString = PayDay Then
                Return CurrentDay.Date
            Else
                CurrentDay = CurrentDay.AddDays(-Counter)
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

        'MsgBox(AssociateQuery)

        Dim MyDataAdapter As New OleDb.OleDbDataAdapter(AssociateQuery, MyDatabaseConnection)
        MyDataAdapter.Fill(MyDataSet, TableName)

        Return MyDataSet
    End Function

    Public Function PutDataSet(ByVal DataToPut As DataSet, ByVal TableName As String) As Boolean
        'Dim MyDataSet As New DataSet
        'Dim MyDatabaseConnection As New OleDb.OleDbConnection
        'Dim MyDataAdapter As OleDb.OleDbDataAdapter

        'MyDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        ''get all employees and add them to the list
        ''Dim AssociateQuery As String = "SELECT AssociateName FROM associate where type='" & TypeToLoad & "'"
        'Dim MyQuery As String = "SELECT * FROM " & TableName

        'MyDataAdapter = New OleDb.OleDbDataAdapter(MyQuery, MyDatabaseConnection)
        'MyDataAdapter.Fill(MyDataSet, TableName)

        'Dim MyBuilder As New OleDb.OleDbCommandBuilder
        'MyBuilder.DataAdapter = MyDataAdapter

        'MyDataAdapter.UpdateCommand = MyBuilder.GetUpdateCommand

        'MyDataAdapter.Update(DataToPut, TableName)

        'Return True

        Dim MyDatabaseConnection As New OleDb.OleDbConnection
        Dim MyDataAdapter As OleDb.OleDbDataAdapter

        MyDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        'MyDataAdapter = New OleDb.OleDbDataAdapter(MyQuery, MyDatabaseConnection)
        'MyDataAdapter.Fill(MyDataSet, TableName)
        MyDataAdapter.Update(DataToPut, TableName)

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
        Dim AssociateToDeleteDataSet As DataSet = GetDataSet("associate", "*", "associatename='" & WhichAssociate.Name & "'", "")
        'deleted the "old" associate if they already exist
        Try
            AssociateToDeleteDataSet.Tables("associate").Rows(0).Delete()
        Catch ex As Exception
            'if the deletion worked, do nothing
        End Try


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
        PutDataSet(AssociateToDeleteDataSet, "associate")
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

    Public Function CalculateHoursInWeek(ByVal StartDate As System.DateTime, ByVal EndDate As System.DateTime, ByVal PersonToCalculate As String) As Double
        Dim DayCounter As Integer
        Dim NumberOfDays As Integer
        NumberOfDays = EndDate.Subtract(StartDate).Days

        Dim TotalHours As Double = 0
        For DayCounter = 0 To NumberOfDays
            TotalHours = TotalHours + CalculateHoursInDay(StartDate.AddDays(DayCounter), PersonToCalculate)
        Next

        Return TotalHours
    End Function


    Public Function CalculateHoursInDay(ByVal DateToCalculate As System.DateTime, ByVal PersonToCalculate As String) As Double
        'Input 1: A date (5/6/04)
        'Input 2: A person ("david")
        'Output: The number of hours that person worked on that date

        Dim TempTimeSpan As System.TimeSpan
        Dim TempHours As Double

        'Dim GetTimeDataSet As DataSet = GetDataSet("event", "*", "associate='" & PersonToCalculate & "' and date='" & DateToCalculate & "'", "time")
        Dim GetTimeDataSet As DataSet = GetDataSet("event", "*", "associate='" & PersonToCalculate & "' and date=#" & DateToCalculate & "#", "time")

        Dim NumberOfEvents As Integer = GetTimeDataSet.Tables("event").Rows.Count

        'MsgBox(PersonToCalculate.ToString + " has " + NumberOfEvents.ToString + " events.")

        'check to see if there is a valid number of events
        If (NumberOfEvents Mod 2 = 1) Then 'number of events in day is odd
            MsgBox(PersonToCalculate + " has an odd number of events on " & DateToCalculate & "!")
            Return -1 'return an error
        End If

        Dim i As Integer = 0
        Dim Time1 As System.DateTime
        Dim Time2 As System.DateTime

        While i < NumberOfEvents - 1 'since events start with #0
            Time1 = GetTimeDataSet.Tables("event").Rows(i).Item("time")
            Time2 = GetTimeDataSet.Tables("event").Rows(i + 1).Item("time")
            TempTimeSpan = Time2.Subtract(Time1)
            TempHours += TempTimeSpan.TotalHours
            i += 2
        End While

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
