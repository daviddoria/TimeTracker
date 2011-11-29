Public Class frmSick
    Inherits System.Windows.Forms.Form

    Public PTO_Mode As String
    Public SelectedAssociate As New Associate

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
    Friend WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblSickHours As System.Windows.Forms.Label
    Friend WithEvents cmbPTO As System.Windows.Forms.ComboBox
    Friend WithEvents lblVacationHours As System.Windows.Forms.Label
    Friend WithEvents lblSelectMode As System.Windows.Forms.Label
    Friend WithEvents btnAssignPTO As System.Windows.Forms.Button
    Friend WithEvents lblHolidayDate As System.Windows.Forms.Label
    Friend WithEvents DatePicker As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lbl5 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.lblSickHours = New System.Windows.Forms.Label
        Me.lblVacationHours = New System.Windows.Forms.Label
        Me.DatePicker = New System.Windows.Forms.DateTimePicker
        Me.btnAssignPTO = New System.Windows.Forms.Button
        Me.cmbPTO = New System.Windows.Forms.ComboBox
        Me.lblSelectMode = New System.Windows.Forms.Label
        Me.lblHolidayDate = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstNameSelect
        '
        Me.lstNameSelect.BackColor = System.Drawing.Color.LightGray
        Me.lstNameSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNameSelect.ItemHeight = 25
        Me.lstNameSelect.Location = New System.Drawing.Point(16, 48)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(248, 379)
        Me.lstNameSelect.TabIndex = 0
        Me.lstNameSelect.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select an Associate:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(488, 400)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Back to Managers Area"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(280, 72)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(232, 32)
        Me.lbl5.TabIndex = 11
        Me.lbl5.Text = "Sick Hours Remaining: "
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(280, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(280, 32)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Vacation Hours Remaining: "
        '
        'lblSickHours
        '
        Me.lblSickHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSickHours.Location = New System.Drawing.Point(528, 72)
        Me.lblSickHours.Name = "lblSickHours"
        Me.lblSickHours.Size = New System.Drawing.Size(40, 32)
        Me.lblSickHours.TabIndex = 13
        '
        'lblVacationHours
        '
        Me.lblVacationHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacationHours.Location = New System.Drawing.Point(560, 104)
        Me.lblVacationHours.Name = "lblVacationHours"
        Me.lblVacationHours.Size = New System.Drawing.Size(40, 40)
        Me.lblVacationHours.TabIndex = 14
        '
        'DatePicker
        '
        Me.DatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.Location = New System.Drawing.Point(288, 192)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(152, 31)
        Me.DatePicker.TabIndex = 15
        Me.DatePicker.Visible = False
        '
        'btnAssignPTO
        '
        Me.btnAssignPTO.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAssignPTO.Enabled = False
        Me.btnAssignPTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignPTO.Location = New System.Drawing.Point(472, 224)
        Me.btnAssignPTO.Name = "btnAssignPTO"
        Me.btnAssignPTO.Size = New System.Drawing.Size(152, 40)
        Me.btnAssignPTO.TabIndex = 17
        Me.btnAssignPTO.Text = "Assign PTO"
        Me.btnAssignPTO.UseVisualStyleBackColor = False
        '
        'cmbPTO
        '
        Me.cmbPTO.BackColor = System.Drawing.Color.LightGray
        Me.cmbPTO.Items.AddRange(New Object() {"Sick Time", "Vacation Time", "Holiday Assignment"})
        Me.cmbPTO.Location = New System.Drawing.Point(488, 24)
        Me.cmbPTO.Name = "cmbPTO"
        Me.cmbPTO.Size = New System.Drawing.Size(121, 21)
        Me.cmbPTO.TabIndex = 22
        Me.cmbPTO.Text = "Select a PTO Mode"
        '
        'lblSelectMode
        '
        Me.lblSelectMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectMode.Location = New System.Drawing.Point(280, 16)
        Me.lblSelectMode.Name = "lblSelectMode"
        Me.lblSelectMode.Size = New System.Drawing.Size(208, 32)
        Me.lblSelectMode.TabIndex = 23
        Me.lblSelectMode.Text = "Select a PTO Mode"
        '
        'lblHolidayDate
        '
        Me.lblHolidayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayDate.Location = New System.Drawing.Point(288, 160)
        Me.lblHolidayDate.Name = "lblHolidayDate"
        Me.lblHolidayDate.Size = New System.Drawing.Size(360, 32)
        Me.lblHolidayDate.TabIndex = 24
        Me.lblHolidayDate.Text = "Select a date to assign time:"
        Me.lblHolidayDate.Visible = False
        '
        'frmSick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHolidayDate)
        Me.Controls.Add(Me.lblSelectMode)
        Me.Controls.Add(Me.cmbPTO)
        Me.Controls.Add(Me.btnAssignPTO)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.lblVacationHours)
        Me.Controls.Add(Me.lblSickHours)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Name = "frmSick"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paid Time Off Assignment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "*")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        If Not lstNameSelect.SelectedItem Is Nothing Then
            SelectedAssociate = GetAssociateData(lstNameSelect.SelectedItem)
            lblSickHours.Text = SelectedAssociate.SickHours
            lblVacationHours.Text = SelectedAssociate.VacationHours
        End If
    End Sub

  
    Private Sub cmbPTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPTO.SelectedIndexChanged
        If cmbPTO.SelectedItem = "Holiday" Then
            lstNameSelect.Enabled = False
            PTO_Mode = cmbPTO.SelectedItem
        ElseIf cmbPTO.SelectedItem = "Vacation" Then
            PTO_Mode = cmbPTO.SelectedItem
            lstNameSelect.Enabled = True
        ElseIf cmbPTO.SelectedItem = "Sick" Then
            PTO_Mode = cmbPTO.SelectedItem
            lstNameSelect.Enabled = True
        End If
    End Sub

    Private Sub btnAssignPTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignPTO.Click
        Dim PTODataSet As New DataSet
        Dim PTODatabaseConnection As New OleDb.OleDbConnection
        Dim PTODataAdapter As OleDb.OleDbDataAdapter

        PTODatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource
        PTODatabaseConnection.Open()

        Dim PTOQuery As String = "SELECT * FROM PTO"
        PTODataAdapter = New OleDb.OleDbDataAdapter(PTOQuery, PTODatabaseConnection)

        PTODataAdapter.Fill(PTODataSet, "PTO")

        Dim DateToAssign As System.DateTime
        DateToAssign = DatePicker.Value.ToShortDateString
      
        '--------------------------------------------------------------
        
        If PTO_Mode = "Holiday" Then
            'get the value from the date/time picker
            

            'get list of timed associates
            PTOQuery = "SELECT * FROM associate where type='Timed'"
            PTODataAdapter.Fill(PTODataSet, "TimedAssociates")

            'get whole list of events
            PTOQuery = "SELECT * FROM event"
            PTODataAdapter.Fill(PTODataSet, "event")

            'declare row object
            Dim HolidayNewRow As DataRow

            'write 8 hours to everyone events (only if they are timed)
            Dim i As Integer = 0
            Dim k As Integer = 1
            While i < PTODataSet.Tables("associate").Rows.Count
                While k <= 2
                    HolidayNewRow = PTODataSet.Tables("event").NewRow() 'create space for new row
                    HolidayNewRow.Item("associate") = PTODataSet.Tables("associate").Rows(i).Item("associatename")
                    HolidayNewRow.Item("date") = DateToAssign
                    If k = 1 Then
                        HolidayNewRow.Item("time") = System.DateTime.Now.ToShortTimeString
                    Else
                        HolidayNewRow.Item("time") = System.DateTime.Now.AddHours(8).ToShortTimeString
                    End If

                    HolidayNewRow.Item("eventnumber") = k
                    HolidayNewRow.Item("reason") = "Holiday"
                    PTODataSet.Tables("event").Rows.Add(HolidayNewRow)
                    k += 1
                End While
                i += 1
            End While

            PTODataAdapter.Update(PTODataSet) 'update the table


        ElseIf PTO_Mode = "Vacation" Then
            Dim RequestedHours As Integer = InputBox("How many hours? (4 or 8)", "Requested Hours", "8")

            Dim VacationNewRow As DataRow

            If SelectedAssociate.VacationHours < RequestedHours Then
                MsgBox("This associate doesn't have enough hours left to take this amount of time off.  Nothing will be subtracted.")
                Exit Sub
            End If

            SelectedAssociate.VacationHours = SelectedAssociate.VacationHours - requestedhours

            WriteAssociateData(SelectedAssociate)

            Dim h As Integer = 1
            While h <= 2
                VacationNewRow = PTODataSet.Tables("event").NewRow() 'create space for new row
                VacationNewRow.Item("associate") = SelectedAssociate.Name
                VacationNewRow.Item("date") = DateToAssign
                If h = 1 Then
                    VacationNewRow.Item("time") = System.DateTime.Now.ToShortTimeString
                Else
                    VacationNewRow.Item("time") = System.DateTime.Now.AddHours(requestedhours).ToShortTimeString
                End If

                VacationNewRow.Item("eventnumber") = h
                VacationNewRow.Item("reason") = "Vacation"
                PTODataSet.Tables("event").Rows.Add(VacationNewRow)
                h += 1
            End While

        ElseIf PTO_Mode = "Sick" Then

            Dim SickNewRow As DataRow

            Dim RequestedHours As Integer = InputBox("How many hours? (4 or 8)", "Requested Hours", "8")

            If SelectedAssociate.SickHours < RequestedHours Then
                MsgBox("This associate doesn't have enough hours left to take this amount of time off.  Nothing will be subtracted.")
            End If

            SelectedAssociate.SickHours = SelectedAssociate.SickHours - requestedhours

            Dim j As Integer = 1
            While j <= 2
                SickNewRow = PTODataSet.Tables("event").NewRow() 'create space for new row
                SickNewRow.Item("associate") = SelectedAssociate.Name
                SickNewRow.Item("date") = DateToAssign
                If j = 1 Then
                    SickNewRow.Item("time") = System.DateTime.Now.ToShortTimeString
                Else
                    SickNewRow.Item("time") = System.DateTime.Now.AddHours(requestedhours).ToShortTimeString
                End If

                SickNewRow.Item("eventnumber") = j
                SickNewRow.Item("reason") = "Vacation"
                PTODataSet.Tables("event").Rows.Add(SickNewRow)
                j += 1
            End While

            WriteAssociateData(SelectedAssociate)
        End If


        'close database
        PTODatabaseConnection.Close()

        Me.Close()

    End Sub
End Class
