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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddEvent As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAddEvent = New System.Windows.Forms.Button
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(618, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 50)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Return To Manager's Area"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstNameSelect
        '
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Associate's Data:"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddEvent.Location = New System.Drawing.Point(375, 383)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(88, 40)
        Me.btnAddEvent.TabIndex = 33
        Me.btnAddEvent.Text = "Add New Event"
        Me.btnAddEvent.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(235, 48)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(560, 329)
        Me.dgvData.TabIndex = 37
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(472, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmFixFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(838, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFixFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix an Associates File"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim AssociateToEdit As Associate
    Dim EventData As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            PutDataSet(EventData, "event")
        End If

        Me.Close()
    End Sub

    Private Sub frmFixFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "Timed")
    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged

        AssociateToEdit = GetAssociateData(lstNameSelect.SelectedItem)
        EventData = GetDataSet("event", "*", "associate='" & AssociateToEdit.Name & "'", "date ASC,time")

        dgvData.DataSource = EventData.Tables("event")

        Dim CurrentColumnIndex As Integer

        'setup InOut Column
        CurrentColumnIndex = dgvData.Columns("InOut").Index
        Dim InOutCombo As New DataGridViewComboBoxColumn
        InOutCombo.Items.Add("In")
        InOutCombo.Items.Add("Out")
        InOutCombo.HeaderText = "InOut"
        InOutCombo.DataSource = EventData.Tables("event")
        InOutCombo.DisplayMember = "InOut"
        dgvData.Columns.Remove("InOut")
        dgvData.Columns.Insert(CurrentColumnIndex, InOutCombo)

        'setup Reason Column
        CurrentColumnIndex = dgvData.Columns("Reason").Index
        Dim ReasonCombo As New DataGridViewComboBoxColumn
        ReasonCombo.Items.Add("BREAK")
        ReasonCombo.Items.Add("LUNCH")
        ReasonCombo.Items.Add("MISC")
        ReasonCombo.Items.Add("DAY")
        ReasonCombo.HeaderText = "Reason"
        ReasonCombo.DataSource = EventData.Tables("event")
        ReasonCombo.DisplayMember = "Reason"
        dgvData.Columns.Remove("Reason")
        dgvData.Columns.Insert(CurrentColumnIndex, ReasonCombo)


    End Sub

    
    Private Sub btnAddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEvent.Click

    End Sub

    
End Class
