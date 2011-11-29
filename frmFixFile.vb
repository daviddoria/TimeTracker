Public Class frmFixFile
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.BackColor = BackgroundColor

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteRow As System.Windows.Forms.Button
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbInOutAdd As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReasonAdd As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateAdd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeAdd As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpEdit As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbInOutEdit As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTimeEdit As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbReasonEdit As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateEdit As System.Windows.Forms.DateTimePicker
    Friend WithEvents TTDataSet As TimeTracker.TTDataSet
    Friend WithEvents PunchEventTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PunchEventTableTableAdapter As TimeTracker.TTDataSetTableAdapters.PunchEventTableTableAdapter
    Friend WithEvents AssociateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    '    Friend WithEvents PunchEventTableAdapter As vb_test.TimeTrackerDataTableAdapters.PunchEventTableAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnClose = New System.Windows.Forms.Button
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDeleteRow = New System.Windows.Forms.Button
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbInOutAdd = New System.Windows.Forms.ComboBox
        Me.cmbReasonAdd = New System.Windows.Forms.ComboBox
        Me.dtpDateAdd = New System.Windows.Forms.DateTimePicker
        Me.dtpTimeAdd = New System.Windows.Forms.DateTimePicker
        Me.grpAdd = New System.Windows.Forms.GroupBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpEdit = New System.Windows.Forms.GroupBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbInOutEdit = New System.Windows.Forms.ComboBox
        Me.dtpTimeEdit = New System.Windows.Forms.DateTimePicker
        Me.cmbReasonEdit = New System.Windows.Forms.ComboBox
        Me.dtpDateEdit = New System.Windows.Forms.DateTimePicker
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.TimeFieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PunchEventTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTDataSet = New TimeTracker.TTDataSet
        Me.PunchEventTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.PunchEventTableTableAdapter
        Me.grpAdd.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PunchEventTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(443, 615)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 50)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Return To Manager's Area"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstNameSelect.BackColor = System.Drawing.Color.White
        Me.lstNameSelect.Location = New System.Drawing.Point(22, 89)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(200, 368)
        Me.lstNameSelect.Sorted = True
        Me.lstNameSelect.TabIndex = 3
        Me.lstNameSelect.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an Associate:"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(232, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(52, 22)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Data for:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(291, 615)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 50)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteRow.Location = New System.Drawing.Point(138, 615)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(131, 50)
        Me.btnDeleteRow.TabIndex = 40
        Me.btnDeleteRow.Text = "Delete Selected Row"
        Me.btnDeleteRow.UseVisualStyleBackColor = False
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(284, 14)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(186, 20)
        Me.dtpStart.TabIndex = 42
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(498, 14)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(183, 20)
        Me.dtpEnd.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "to"
        '
        'cmbInOutAdd
        '
        Me.cmbInOutAdd.FormattingEnabled = True
        Me.cmbInOutAdd.Items.AddRange(New Object() {"IN", "OUT"})
        Me.cmbInOutAdd.Location = New System.Drawing.Point(36, 42)
        Me.cmbInOutAdd.Name = "cmbInOutAdd"
        Me.cmbInOutAdd.Size = New System.Drawing.Size(67, 21)
        Me.cmbInOutAdd.TabIndex = 46
        '
        'cmbReasonAdd
        '
        Me.cmbReasonAdd.FormattingEnabled = True
        Me.cmbReasonAdd.Items.AddRange(New Object() {"DAY", "LUNCH", "BREAK"})
        Me.cmbReasonAdd.Location = New System.Drawing.Point(122, 42)
        Me.cmbReasonAdd.Name = "cmbReasonAdd"
        Me.cmbReasonAdd.Size = New System.Drawing.Size(121, 21)
        Me.cmbReasonAdd.TabIndex = 47
        '
        'dtpDateAdd
        '
        Me.dtpDateAdd.Location = New System.Drawing.Point(258, 43)
        Me.dtpDateAdd.Name = "dtpDateAdd"
        Me.dtpDateAdd.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateAdd.TabIndex = 48
        '
        'dtpTimeAdd
        '
        Me.dtpTimeAdd.CustomFormat = "h:mm tt"
        Me.dtpTimeAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeAdd.Location = New System.Drawing.Point(464, 43)
        Me.dtpTimeAdd.Name = "dtpTimeAdd"
        Me.dtpTimeAdd.ShowUpDown = True
        Me.dtpTimeAdd.Size = New System.Drawing.Size(88, 20)
        Me.dtpTimeAdd.TabIndex = 49
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.btnAdd)
        Me.grpAdd.Controls.Add(Me.Label6)
        Me.grpAdd.Controls.Add(Me.Label5)
        Me.grpAdd.Controls.Add(Me.Label4)
        Me.grpAdd.Controls.Add(Me.Label3)
        Me.grpAdd.Controls.Add(Me.cmbInOutAdd)
        Me.grpAdd.Controls.Add(Me.dtpTimeAdd)
        Me.grpAdd.Controls.Add(Me.cmbReasonAdd)
        Me.grpAdd.Controls.Add(Me.dtpDateAdd)
        Me.grpAdd.Enabled = False
        Me.grpAdd.Location = New System.Drawing.Point(22, 535)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(647, 74)
        Me.grpAdd.TabIndex = 50
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Add An Event"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(565, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Reason"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "In/Out"
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.btnEdit)
        Me.grpEdit.Controls.Add(Me.Label7)
        Me.grpEdit.Controls.Add(Me.Label8)
        Me.grpEdit.Controls.Add(Me.Label9)
        Me.grpEdit.Controls.Add(Me.Label10)
        Me.grpEdit.Controls.Add(Me.cmbInOutEdit)
        Me.grpEdit.Controls.Add(Me.dtpTimeEdit)
        Me.grpEdit.Controls.Add(Me.cmbReasonEdit)
        Me.grpEdit.Controls.Add(Me.dtpDateEdit)
        Me.grpEdit.Enabled = False
        Me.grpEdit.Location = New System.Drawing.Point(22, 455)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(647, 74)
        Me.grpEdit.TabIndex = 51
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit the Selected Event"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(565, 40)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 54
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Reason"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "In/Out"
        '
        'cmbInOutEdit
        '
        Me.cmbInOutEdit.FormattingEnabled = True
        Me.cmbInOutEdit.Items.AddRange(New Object() {"IN", "OUT"})
        Me.cmbInOutEdit.Location = New System.Drawing.Point(36, 42)
        Me.cmbInOutEdit.Name = "cmbInOutEdit"
        Me.cmbInOutEdit.Size = New System.Drawing.Size(67, 21)
        Me.cmbInOutEdit.TabIndex = 46
        '
        'dtpTimeEdit
        '
        Me.dtpTimeEdit.CustomFormat = "h:mm tt"
        Me.dtpTimeEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEdit.Location = New System.Drawing.Point(464, 43)
        Me.dtpTimeEdit.Name = "dtpTimeEdit"
        Me.dtpTimeEdit.ShowUpDown = True
        Me.dtpTimeEdit.Size = New System.Drawing.Size(88, 20)
        Me.dtpTimeEdit.TabIndex = 49
        '
        'cmbReasonEdit
        '
        Me.cmbReasonEdit.FormattingEnabled = True
        Me.cmbReasonEdit.Items.AddRange(New Object() {"DAY", "LUNCH", "BREAK"})
        Me.cmbReasonEdit.Location = New System.Drawing.Point(122, 42)
        Me.cmbReasonEdit.Name = "cmbReasonEdit"
        Me.cmbReasonEdit.Size = New System.Drawing.Size(121, 21)
        Me.cmbReasonEdit.TabIndex = 47
        '
        'dtpDateEdit
        '
        Me.dtpDateEdit.Location = New System.Drawing.Point(258, 43)
        Me.dtpDateEdit.Name = "dtpDateEdit"
        Me.dtpDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateEdit.TabIndex = 48
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeFieldDataGridViewTextBoxColumn, Me.InOutDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.KeyDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.PunchEventTableBindingSource
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvData.Location = New System.Drawing.Point(240, 76)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(441, 319)
        Me.dgvData.TabIndex = 51
        '
        'TimeFieldDataGridViewTextBoxColumn
        '
        Me.TimeFieldDataGridViewTextBoxColumn.DataPropertyName = "TimeField"
        Me.TimeFieldDataGridViewTextBoxColumn.HeaderText = "TimeField"
        Me.TimeFieldDataGridViewTextBoxColumn.Name = "TimeFieldDataGridViewTextBoxColumn"
        '
        'InOutDataGridViewTextBoxColumn
        '
        Me.InOutDataGridViewTextBoxColumn.DataPropertyName = "InOut"
        Me.InOutDataGridViewTextBoxColumn.HeaderText = "InOut"
        Me.InOutDataGridViewTextBoxColumn.Name = "InOutDataGridViewTextBoxColumn"
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "Key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.Visible = False
        '
        'PunchEventTableBindingSource
        '
        Me.PunchEventTableBindingSource.DataMember = "PunchEventTable"
        Me.PunchEventTableBindingSource.DataSource = Me.TTDataSet
        '
        'TTDataSet
        '
        Me.TTDataSet.DataSetName = "TTDataSet"
        Me.TTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PunchEventTableTableAdapter
        '
        Me.PunchEventTableTableAdapter.ClearBeforeFill = True
        '
        'frmFixFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(701, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.grpAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.btnDeleteRow)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFixFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix an Associates File"
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PunchEventTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private immobiliser As New FormImmobiliser(Me)

    Dim AssociateToEdit As Associate
    Dim Changes As Boolean

    Dim StartDate As Date
    Dim EndDate As Date

    Private Sub AskForChanges()
        If Changes = True Then
            If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                SaveData()
            Else
                'do nothing
            End If
        End If
    End Sub

    Private Sub SaveData()

        PunchEventTableTableAdapter.Update(Me.TTDataSet.PunchEventTable)
        Changes = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        LogClick(sender)
        AskForChanges()
        Me.Dispose()
    End Sub

    Private Sub frmFixFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TTDataSet.PunchEventTable' table. You can move, or remove it, as needed.
        Me.PunchEventTableTableAdapter.Fill(Me.TTDataSet.PunchEventTable)

        'dgvData.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.AllCells ' actually makes the table longer
        dgvData.RowHeadersVisible = False ' hide the blank column on the left
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'select a row at a time instead of a single cell
        dgvData.MultiSelect = False ' don't allow more than 1 row at a time to be selected

        'initialize the global "have we made any changes?" variable
        Changes = False

        StartDate = GetWeekStart(Now).Date
        EndDate = Now.Date

        dtpStart.Value = StartDate
        dtpEnd.Value = EndDate

        LoadNameListBox(lstNameSelect, AssociateType.TIMED)

        cmbInOutAdd.SelectedIndex = 0
        cmbReasonAdd.SelectedIndex = 0

        LoadData()

    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        LogListBoxSelection(sender)

        AskForChanges()

        AssociateToEdit = New Associate(lstNameSelect.SelectedItem.ToString)

        LoadData()

        grpAdd.Enabled = True

    End Sub

    Private Sub LoadData()

        If AssociateToEdit Is Nothing Then
            'MessageBox.Show("No associate selected.")
            PunchEventTableBindingSource.Filter = "associatename='NOTHING'"
            Exit Sub
        End If

        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim FilterString As String = "associatename='" & AssociateToEdit.Name & _
            "' and TimeField>=#" & StartDate & "# and TimeField<#" & EndDate.AddDays(1) & "#"

        Dim SortString As String = "TimeField ASC"

        PunchEventTableBindingSource.Filter = FilterString
        PunchEventTableBindingSource.Sort = SortString

        dgvData.ClearSelection()

        Changes = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        LogClick(sender)
        SaveData()

    End Sub

    Private Sub DeleteSelectedRow()
        'if nothing is selected, don't do anything
        If dgvData.SelectedRows().Count = 0 Then
            'MessageBox.Show("Nothing selected.")
            Exit Sub
        End If

        'You must DELETE the row (which MARKS it for deletion). 
        'If you REMOVE the row, it is no longer there to be processed by the update command.
        DirectCast(PunchEventTableBindingSource.Current, DataRowView).Delete()

        dgvData.ClearSelection()

        Changes = True
    End Sub
    Private Sub btnDeleteRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRow.Click
        LogClick(sender)
        DeleteSelectedRow()
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        StartDate = dtpStart.Value.Date
        LoadData()
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        EndDate = dtpEnd.Value.Date
        LoadData()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        LogClick(sender)
        'create a new row
        Dim NewEvent As TTDataSet.PunchEventTableRow = DirectCast(TTDataSet.PunchEventTable.NewRow, TTDataSet.PunchEventTableRow)

        'add all the attributes to the new row
        NewEvent.AssociateName = AssociateToEdit.Name.ToString
        NewEvent.InOut = cmbInOutAdd.SelectedItem.ToString
        NewEvent.Reason = cmbReasonAdd.SelectedItem.ToString

        Dim EventTime As New DateTime(dtpDateAdd.Value.Year, dtpDateAdd.Value.Month, dtpDateAdd.Value.Day, dtpTimeAdd.Value.Hour, dtpTimeAdd.Value.Minute, dtpTimeAdd.Value.Second)

        NewEvent.TimeField = EventTime

        'add the new row to the table
        TTDataSet.PunchEventTable.Rows.Add(NewEvent)

        UnselectEverything()

        'set a global variable to indicate we have made a change
        Changes = True

    End Sub

    Private Sub UnselectEverything()
        'unselect everything
        dgvData.ClearSelection()
        dgvData.FirstDisplayedScrollingRowIndex = 0
        dgvData.ClearSelection()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        LogClick(sender)
        If dgvData.SelectedRows().Count = 0 Then
            Exit Sub
        End If

        'get the contents of the selected row
        Dim SelectedIndex As Integer = dgvData.SelectedRows(0).Index

        'Save data from form
        Dim strEventName As String = AssociateToEdit.Name.ToString
        Dim strEventDirection As String = cmbInOutEdit.SelectedItem.ToString
        Dim strEventReason As String = cmbReasonEdit.SelectedItem.ToString
        Dim datEventDate As Date = dtpDateEdit.Value
        Dim datEventTime As Date = dtpTimeEdit.Value

        'delete the selected row
        DeleteSelectedRow()

        'create a new row
        Dim NewEventRow As TTDataSet.PunchEventTableRow = DirectCast(TTDataSet.PunchEventTable.NewRow, TTDataSet.PunchEventTableRow)

        'add all the attributes to the new row
        NewEventRow.AssociateName = strEventName
        NewEventRow.InOut = strEventDirection
        NewEventRow.Reason = strEventReason

        'Dim EventTime As New DateTime(dtpDateAdd.Value.Year, dtpDateAdd.Value.Month, dtpDateAdd.Value.Day, dtpTimeAdd.Value.Hour, dtpTimeAdd.Value.Minute, dtpTimeAdd.Value.Second)
        Dim EventTime As DateTime = CombineDateAndTime(datEventDate, datEventTime)
        NewEventRow.TimeField = EventTime

        'add the new row to the table
        TTDataSet.PunchEventTable.Rows.Add(NewEventRow)

        UnselectEverything()

        'set a global variable to indicate we have made a change
        Changes = True

        grpEdit.Enabled = False

    End Sub

    Private Sub dgvData_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvData.MouseClick

        If dgvData.SelectedRows().Count = 0 Then
            grpEdit.Enabled = False
            Exit Sub
        End If

        grpEdit.Enabled = True

        'get the contents of the selected row
        Dim view As DataRowView = DirectCast(PunchEventTableBindingSource.Current, DataRowView)
        Dim SelectedRow As TTDataSet.PunchEventTableRow = DirectCast(view.Row, TTDataSet.PunchEventTableRow)

        'populate the edit group box
        cmbInOutEdit.SelectedItem = SelectedRow.InOut
        cmbReasonEdit.SelectedItem = SelectedRow.Reason
        dtpDateEdit.Value = SelectedRow.TimeField
        dtpTimeEdit.Value = SelectedRow.TimeField

    End Sub


End Class
