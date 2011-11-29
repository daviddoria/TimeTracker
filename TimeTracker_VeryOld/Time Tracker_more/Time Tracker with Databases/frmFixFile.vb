Public Class frmFixFile
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents btnChangeDateRange As System.Windows.Forms.Button
    Friend WithEvents btnDeleteRow As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnChangeDateRange = New System.Windows.Forms.Button
        Me.btnDeleteRow = New System.Windows.Forms.Button
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(550, 529)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 50)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Return To Manager's Area"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstNameSelect
        '
        Me.lstNameSelect.BackColor = System.Drawing.Color.LightGray
        Me.lstNameSelect.Location = New System.Drawing.Point(16, 48)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(200, 329)
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
        Me.lblTitle.Location = New System.Drawing.Point(232, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 14)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Associate's Data:"
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvData.Location = New System.Drawing.Point(235, 48)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(446, 475)
        Me.dgvData.TabIndex = 37
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.Location = New System.Drawing.Point(398, 529)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 50)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnChangeDateRange
        '
        Me.btnChangeDateRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChangeDateRange.Location = New System.Drawing.Point(602, 6)
        Me.btnChangeDateRange.Name = "btnChangeDateRange"
        Me.btnChangeDateRange.Size = New System.Drawing.Size(91, 37)
        Me.btnChangeDateRange.TabIndex = 39
        Me.btnChangeDateRange.Text = "Change Date Range"
        Me.btnChangeDateRange.UseVisualStyleBackColor = False
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteRow.Location = New System.Drawing.Point(245, 529)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(131, 50)
        Me.btnDeleteRow.TabIndex = 40
        Me.btnDeleteRow.Text = "Delete Selected Row"
        Me.btnDeleteRow.UseVisualStyleBackColor = False
        '
        'frmFixFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(705, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDeleteRow)
        Me.Controls.Add(Me.btnChangeDateRange)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFixFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix an Associates File"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim AssociateToEdit As Associate
    Dim EventData As DataSet
    Dim ChangesMade As Boolean = False


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If ChangesMade = True Then
            If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                PutDataSet(EventData, "eventTable")
            End If
            ChangesMade = False
        End If

        dgvData.DataSource = ""
        Me.Close()

    End Sub

    Private Sub frmFixFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "Timed")

    End Sub

    Private Sub dataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellValueChanged
        ChangesMade = True
    End Sub

    Private Sub UserAddedRow(ByVal sender As Object, ByVal e As DataGridViewRowEventArgs) Handles dgvData.UserAddedRow
        dgvData.Rows(e.Row.Index - 1).Cells("Associate").Value = AssociateToEdit.Name
    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged

        If ChangesMade = True Then
            If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                PutDataSet(EventData, "eventTable")
            End If
        End If

        AssociateToEdit = GetAssociateData(lstNameSelect.SelectedItem)
        If EC = True Then
            MsgBox(GetWeekStart(Now.ToShortDateString))
        End If

        EventData = GetDataSet("eventTable", "*", "associate='" & AssociateToEdit.Name & "' and DateField>=#" & GetWeekStart(Now.ToShortDateString) & "#", "datefield ASC,timefield ASC")


        dgvData.DataSource = EventData.Tables("eventTable")

        dgvData.Columns("Associate").Visible = False
        dgvData.Columns("Comments").Visible = False
        dgvData.Columns("EventNumber").HeaderText = "#"
        dgvData.Columns("TimeField").DefaultCellStyle.Format = "h:mm tt"

        Dim CurrentColumnIndex As Integer

        'setup InOut Column
        CurrentColumnIndex = dgvData.Columns("InOut").Index

        Dim InOutCombo As New DataGridViewComboBoxColumn

        With InOutCombo
            .Name = "InOut"
            .Items.Add("IN")
            .Items.Add("OUT")
            .DataPropertyName = "InOut"
            .HeaderText = "IN/OUT"
            .MinimumWidth = 70

        End With

        dgvData.Columns.Remove("InOut")
        dgvData.Columns.Insert(CurrentColumnIndex, InOutCombo)

        'setup Reason Column
        CurrentColumnIndex = dgvData.Columns("Reason").Index
        Dim ReasonCombo As New DataGridViewComboBoxColumn
        With ReasonCombo
            .Name = "Reason"
            .Items.Add("BREAK")
            .Items.Add("LUNCH")
            .Items.Add("MISC")
            .Items.Add("DAY")
            .MinimumWidth = 100
            .DataPropertyName = "Reason"
            .HeaderText = "Reason"
        End With

        dgvData.Columns.Remove("Reason")
        dgvData.Columns.Insert(CurrentColumnIndex, ReasonCombo)

        lblTitle.Text = "Associate Data from " + GetWeekStart(Now.ToShortDateString).ToShortDateString + " to " + Now.ToShortDateString

        ChangesMade = False
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        PutDataSet(EventData, "eventTable")
        ChangesMade = False
    End Sub

    Private Sub btnChangeDateRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDateRange.Click
        Dim StartDate As Date
        Dim EndDate As Date

        frmGetDate.lblReason.Text = "Select the date to start the report"
        If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StartDate = frmGetDate.cldDate.SelectionStart
        End If

        frmGetDate.lblReason.Text = "Select the date to end the report"
        If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
            EndDate = frmGetDate.cldDate.SelectionStart
        End If

        EventData = GetDataSet("eventTable", "*", "associate='" & AssociateToEdit.Name & "' and DateField>=#" & StartDate & "# and DateField<=#" & EndDate & "#", "datefield ASC,timefield ASC")
        dgvData.DataSource = EventData.Tables("eventTable")

        lblTitle.Text = "Associate Data from " + StartDate.ToShortDateString + " to " + EndDate.ToShortDateString
    End Sub

    Private Sub dgvData_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvData.DataError
        MsgBox("The data you just entered is not valid")
    End Sub

    Private Sub btnDeleteRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRow.Click
        dgvData.Rows.RemoveAt(dgvData.SelectedRows(0).Index)

    End Sub
End Class
