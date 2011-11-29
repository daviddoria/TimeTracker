Imports System.Collections.Generic

Module Legacy


    '    Public Function GetTableOfPreviousEvents() As List(Of TTDataSet.PunchEventTableRow)

    ''get a table of all of the previous events ever logged by the associate.
    ''Dim SelectString As String = "associate='" + AssociateLoggedIn.Name + "'"
    'Dim SelectString As String = "associate='" + _name + "'"
    'Dim SortString As String = "timefield asc"

    ''get the entire PunchEvent table
    'Dim daTypedEvent As New TTDataSetTableAdapters.PunchEventTableTableAdapter
    ''Dim daEvent As New SqlClient.SqlDataAdapter
    'Dim daEvent As New OleDb.OleDbDataAdapter
    ''daEvent.SelectCommand = New SqlClient.SqlCommand(SelectString, daTypedEvent.Connection)
    'daEvent.SelectCommand = New OleDb.OleDbCommand(SelectString, daTypedEvent.Connection)
    ''daEvent.f
    'Dim EventTable As New TTDataSet.PunchEventTableDataTable
    'daEvent.Fill(EventTable)

    ''setup the select and sort strings


    ''Dim PreviousEvents As New DataView(TTData.PunchEventTable, , , DataViewRowState.CurrentRows)
    ''filter the PunchEvent table to get the records of this associate
    'Dim PreviousEvents As TTDataSet.PunchEventTableRow() = DirectCast(EventTable.Select(SelectString, SortString), TTDataSet.PunchEventTableRow())
    'Return PreviousEvents

    'End Function

    'Public Function GetLastEvent() As PunchEvent
    '    'get the most recent event of the associate

    '    'get the entire list of previous events
    '    Dim PreviousEvents As TTDataSet.PunchEventTableRow() = GetTableOfPreviousEvents()

    '    Dim LastEvent As New PunchEvent

    '    'see how many events there are
    '    Dim NumPreviousEvents As Integer = PreviousEvents.Length

    '    'if there are no events, this is either an error or a new associate.
    '    'if there are events, extract the data and create a PunchEvent object to return
    '    If NumPreviousEvents = 0 Then
    '        MsgBox("Could not get previous event. If this is not your first day, please see a manager.")
    '        LastEvent.Valid = False
    '    Else
    '        Dim LastEventRow As TTDataSet.PunchEventTableRow = PreviousEvents(NumPreviousEvents - 1)
    '        LastEvent.Reason = PunchEvent.StringToReason(LastEventRow.Reason) '-1 is to account for starting at 0
    '        LastEvent.PunchTime = LastEventRow.TimeField
    '        LastEvent.Direction = PunchEvent.StringToDirection(LastEventRow.InOut)
    '        LastEvent.Valid = True
    '    End If

    '    Return LastEvent

    'End Function


    Private Sub cleartable()
        'Clear Table
        ' !!! fix this!
        'Dim cmd As New OleDb.OleDbCommand("Delete * From TimedDetailed", DatabaseConnection)
        'DatabaseConnection.Open()
        'cmd.ExecuteNonQuery()
        'DatabaseConnection.Close()
        'TTData.Tables("timeddetailed").Clear()
    End Sub

    Private Sub AskForChanges()
        'If Changes = True Then
        '    If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
        '        SaveData()
        '    Else
        '        'EventBindingSource.CancelEdit()
        '        'Me.EventTableAdapter.Fill(Me.TimeTrackerData._Event)
        '    End If
        'End If
    End Sub
    Private Sub SaveData()

        'EventBindingSource.EndEdit() 'apply changes to underlying datasource
        'EventTableAdapter.Update(TimeTrackerData)
        'daPunchEvent.Update(TTData.PunchEventTable)
        'Changes = False

    End Sub
    Private Sub debuggingstuff()

        ' Debug.WriteLineIf(verbosity >= 1, "weekstart= " + WeekStart)

    End Sub
    Private Sub DatabaseStuff()

        'Public dtCompany As New DataTable
        'Public dtAssociate As New DataTable
        'Public dtEvent As New DataTable
        'Public dtTimedOverview As New DataTable
        'Public dtTimedDetailed As New DataTable
        'Public dtNonTimed As New DataTable

        'Public daCompany As OleDb.OleDbDataAdapter
        'Public daAssociate As OleDb.OleDbDataAdapter
        'Public daEvent As OleDb.OleDbDataAdapter
        'Public daTimedOverview As OleDb.OleDbDataAdapter
        'Public daTimedDetailed As OleDb.OleDbDataAdapter
        'Public daNonTimed As OleDb.OleDbDataAdapter

        'Public DatabaseSource As String = "C:\Time Tracker\timetracker.mdb" 'location of the database
        'Public DatabaseConnection As New OleDb.OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource)


        'open the database to read company data
        'Dim CompanyQuery As String = "SELECT * FROM Company"
        'Dim AssociateQuery As String = "SELECT * FROM Associate"
        'Dim EventQuery As String = "SELECT * FROM Event"
        'Dim TimedDetailedQuery As String = "SELECT * FROM TimedDetailed"
        'Dim TimedOverviewQuery As String = "SELECT * FROM TimedOverview"
        'Dim NonTimedQuery As String = "SELECT * FROM NonTimed"

        'daCompany = New OleDb.OleDbDataAdapter(CompanyQuery, DatabaseConnection)
        'daCompany.Fill(dtCompany)
        'Dim cbCompany As New System.Data.OleDb.OleDbCommandBuilder(daCompany)

        'daAssociate = New OleDb.OleDbDataAdapter(AssociateQuery, DatabaseConnection)
        'daAssociate.Fill(dtAssociate)
        'Dim cbAssociate As New System.Data.OleDb.OleDbCommandBuilder(daAssociate)

        'daEvent = New OleDb.OleDbDataAdapter(EventQuery, DatabaseConnection)
        'daEvent.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'daEvent.Fill(dtEvent)
        'Dim cbEvent As New System.Data.OleDb.OleDbCommandBuilder(daEvent)

        'daTimedDetailed = New OleDb.OleDbDataAdapter(TimedDetailedQuery, DatabaseConnection)
        'daTimedDetailed.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'daTimedDetailed.Fill(dtTimedDetailed)
        'Dim cbDetailed As New System.Data.OleDb.OleDbCommandBuilder(daTimedDetailed)

        'daTimedOverview = New OleDb.OleDbDataAdapter(TimedOverviewQuery, DatabaseConnection)
        'daTimedOverview.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'daTimedOverview.Fill(dtTimedOverview)
        'Dim cbOverview As New System.Data.OleDb.OleDbCommandBuilder(daTimedOverview)

        'daNonTimed = New OleDb.OleDbDataAdapter(NonTimedQuery, DatabaseConnection)
        'daNonTimed.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'daNonTimed.Fill(dtNonTimed)
        'Dim cbNonTimed As New System.Data.OleDb.OleDbCommandBuilder(daNonTimed)

    End Sub

    Private Sub LoadData() 'from frmFixFile

        'If AssociateToEdit Is Nothing Then
        '    Exit Sub
        'End If

        'Dim FilterString As String = "associate='" & AssociateToEdit.Name & _
        '    "' and TimeField>=#" & StartDate & "# and TimeField<#" & EndDate.AddDays(1) & "#"

        'Dim SortString As String = "TimeField ASC"
        'EventData = New DataView(dtEvent, FilterString, SortString, DataViewRowState.CurrentRows)

        'dgvData.DataSource = EventData

        'dgvData.Columns("Associate").Visible = False
        'dgvData.Columns("Key").Visible = False '!!!
        'dgvData.Columns("TimeField").HeaderText = "Time"
        'dgvData.Columns("TimeField").DefaultCellStyle.Format = "G"

        'Dim CurrentColumnIndex As Integer = CurrentColumnIndex = dgvData.Columns("InOut").Index

        'Dim InOutCombo As New DataGridViewComboBoxColumn

        'With InOutCombo
        '    .Name = "InOut"
        '    .Items.Add("IN")
        '    .Items.Add("OUT")
        '    .DataPropertyName = "InOut"
        '    .HeaderText = "IN/OUT"
        '    .MinimumWidth = 70
        'End With

        'dgvData.Columns.Remove("InOut")
        'dgvData.Columns.Insert(CurrentColumnIndex, InOutCombo)

        ''setup Reason Column
        'CurrentColumnIndex = dgvData.Columns("Reason").Index
        'Dim ReasonCombo As New DataGridViewComboBoxColumn
        'With ReasonCombo
        '    .Name = "Reason"
        '    .Items.Add("BREAK")
        '    .Items.Add("LUNCH")
        '    .Items.Add("DAY")
        '    .MinimumWidth = 100
        '    .DataPropertyName = "Reason"
        '    .HeaderText = "Reason"
        'End With

        'dgvData.Columns.Remove("Reason")
        'dgvData.Columns.Insert(CurrentColumnIndex, ReasonCombo)



        'lblTitle.Text = "Data for " + AssociateToEdit.Name + " from " + StartDate.ToShortDateString + " to " + EndDate.ToShortDateString

        'Dim CurrentColumnIndex As Integer = CurrentColumnIndex = dgvData.Columns("InOut").Index

        'Dim InOutCombo As New DataGridViewComboBoxColumn

        'With InOutCombo
        '    .Name = "InOut"
        '    .Items.Add("IN")
        '    .Items.Add("OUT")
        '    .DataPropertyName = "InOut"
        '    .HeaderText = "IN/OUT"
        '    .MinimumWidth = 70
        'End With

        'dgvData.Columns.Remove("InOut")
        'dgvData.Columns.Insert(CurrentColumnIndex, InOutCombo)

        ''setup Reason Column
        'CurrentColumnIndex = dgvData.Columns("Reason").Index
        'Dim ReasonCombo As New DataGridViewComboBoxColumn
        'With ReasonCombo
        '    .Name = "Reason"
        '    .Items.Add("BREAK")
        '    .Items.Add("LUNCH")
        '    .Items.Add("DAY")
        '    .MinimumWidth = 100
        '    .DataPropertyName = "Reason"
        '    .HeaderText = "Reason"
        'End With

        'dgvData.Columns.Remove("Reason")
        'dgvData.Columns.Insert(CurrentColumnIndex, ReasonCombo)

    End Sub
End Module
