Module Module_for_globals

    Public DatabaseSource = "C:\Time Tracker\timetracker.mdb" 'location of the database
    Public MOTD As String 'used to store MOTD
    Public AssociateLoggedIn As Associate 'used to determine who is sitting at the computer

    Public LoginFormID As frmLogin 'used to globaly ID the login form

    'error checking variables
    Public EC As Boolean = False
    Public PrintON As Boolean = True

    Public AddEditMode As String

    Public Function TestPass(ByVal temptext As ListBox)
        temptext.Items.Add("WOHO!")
    End Function

    Public Function LoadNameListBox(ByVal ListBoxToLoad As ListBox, ByVal TypeToLoad As String)
        Dim AssociateData As New DataSet
        Dim DatabaseConnection As New OleDb.OleDbConnection
        Dim AssociateDataAdapter As OleDb.OleDbDataAdapter

        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        'get all employees and add them to the list
        'Dim AssociateQuery As String = "SELECT AssociateName FROM associate where type='" & TypeToLoad & "'"
        Dim AssociateQuery As String = "SELECT AssociateName FROM associate"

        Dim AssociateList As New DataSet

        AssociateDataAdapter = New OleDb.OleDbDataAdapter(AssociateQuery, DatabaseConnection)
        AssociateDataAdapter.Fill(AssociateList, "Associate")

        Dim i As Integer = 0
        'since we start at 0, we must go to length-1
        For i = 0 To AssociateList.Tables("associate").Rows.Count - 1
            ListBoxToLoad.Items.Add(AssociateList.Tables("associate").Rows(i).Item("AssociateName"))
        Next i

    End Function
    Public Function WriteAssociateData(ByVal WhichAssociate As Associate) As Boolean
        'open the database
        Dim AssociateDataSet As New DataSet
        Dim AssociateDatabaseConnection As New OleDb.OleDbConnection
        Dim AssociateDA As OleDb.OleDbDataAdapter

        AssociateDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource
        AssociateDatabaseConnection.Open()

        Dim AssociateQuery As String = "SELECT * FROM associate"
        AssociateDA = New OleDb.OleDbDataAdapter(AssociateQuery, AssociateDatabaseConnection)
        AssociateDA.Fill(AssociateDataSet, "associate")

        'deleted the "old" associate if they already exist
        Try
            AssociateQuery = "SELECT * FROM associate where associatename='" & WhichAssociate.Name & "'"
            AssociateDA.Fill(AssociateDataSet, "AssociateToDelete")
            AssociateDataSet.Tables("associate").Rows(0).Delete()
        Catch ex As Exception
            'if the deletion worked, do nothing
        End Try

        'write the new associate to the database
        Dim AssociateNewRow As DataRow
        AssociateNewRow = AssociateDataSet.Tables("event").NewRow()
        'add all the attributes to the new row
        AssociateNewRow.Item("associatename") = WhichAssociate.Name
        AssociateNewRow.Item("socialsecuritynumber") = WhichAssociate.Social
        AssociateNewRow.Item("startingdate") = WhichAssociate.StartDate
        AssociateNewRow.Item("vacationhours") = WhichAssociate.VacationHours
        AssociateNewRow.Item("type") = WhichAssociate.Type
        AssociateNewRow.Item("sickhours") = WhichAssociate.SickHours
        AssociateNewRow.Item("pin") = WhichAssociate.Pin

        AssociateDataSet.Tables("associate").Rows.Add(AssociateNewRow)
        AssociateDA.Update(AssociateDataSet)

        AssociateDatabaseConnection.Close()

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
        End If

        Return ShortReason
    End Function

    Public Function CalculateHoursInDay(ByVal DateToCalculate As System.DateTime, ByVal PersonToCalculate As String) As Double
        'Input 1: A date (5/6/04)
        'Input 2: A person ("david")
        'Output: The number of hours that person worked on that date

        Dim TempTimeSpan As System.TimeSpan
        Dim TempHours As Double

        'make a connection to the database
        Dim DatabaseConnection As New OleDb.OleDbConnection
        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource
        DatabaseConnection.Open()

        Dim GetTimeDataSet As New DataSet
        Dim GetTimeDataAdapter As OleDb.OleDbDataAdapter

        Dim Query As String = "SELECT * FROM Associate where AssociateName='" & PersonToCalculate & "' and date='" & DateToCalculate & "' and EventNumber='1'"
        GetTimeDataAdapter = New OleDb.OleDbDataAdapter(Query, DatabaseConnection)
        GetTimeDataAdapter.Fill(GetTimeDataSet, "event")

        DatabaseConnection.Close()

        Dim NumberOfEvents As Integer = GetTimeDataSet.Tables("event").Rows.Count

        'check to see if there is a valid number of events
        If (NumberOfEvents Mod 2 = 1) Then 'number of events in day is odd
            MsgBox("You can't have an odd number of events!")
            Return -1 'return an error
        End If

        Dim i As Integer = 0
        Dim Time1 As System.DateTime
        Dim Time2 As System.DateTime

        While i < NumberOfEvents
            Time1 = GetTimeDataSet.Tables("event").Rows(i).Item("date")
            Time2 = GetTimeDataSet.Tables("event").Rows(i + 1).Item("date")
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

        DatabaseConnection.Close()

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

        Return NewAssociate

    End Function

End Module
