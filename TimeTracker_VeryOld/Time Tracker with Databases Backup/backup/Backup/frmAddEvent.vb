Public Class frmAddEvent
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbHr As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstAMPM As System.Windows.Forms.ListBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstInOut As System.Windows.Forms.ListBox
    Friend WithEvents cmbMin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstReason As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbHr = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstAMPM = New System.Windows.Forms.ListBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lstInOut = New System.Windows.Forms.ListBox
        Me.cmbMin = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstReason = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAssign = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(328, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "AM/PM:"
        '
        'cmbHr
        '
        Me.cmbHr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbHr.Location = New System.Drawing.Point(160, 48)
        Me.cmbHr.Name = "cmbHr"
        Me.cmbHr.Size = New System.Drawing.Size(48, 21)
        Me.cmbHr.TabIndex = 12
        Me.cmbHr.TabStop = False
        Me.cmbHr.Text = "hr"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select a date:"
        '
        'lstAMPM
        '
        Me.lstAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.lstAMPM.Location = New System.Drawing.Point(336, 40)
        Me.lstAMPM.Name = "lstAMPM"
        Me.lstAMPM.Size = New System.Drawing.Size(32, 30)
        Me.lstAMPM.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.TabStop = False
        '
        'lstInOut
        '
        Me.lstInOut.Items.AddRange(New Object() {"IN", "OUT"})
        Me.lstInOut.Location = New System.Drawing.Point(392, 40)
        Me.lstInOut.Name = "lstInOut"
        Me.lstInOut.Size = New System.Drawing.Size(32, 30)
        Me.lstInOut.TabIndex = 15
        Me.lstInOut.TabStop = False
        '
        'cmbMin
        '
        Me.cmbMin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMin.Location = New System.Drawing.Point(240, 48)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(56, 21)
        Me.cmbMin.TabIndex = 13
        Me.cmbMin.TabStop = False
        Me.cmbMin.Text = "min"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(160, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Select a Time:"
        '
        'lstReason
        '
        Me.lstReason.Items.AddRange(New Object() {"DAY", "LUNCH", "MISC", "SMOKE"})
        Me.lstReason.Location = New System.Drawing.Point(440, 40)
        Me.lstReason.Name = "lstReason"
        Me.lstReason.Size = New System.Drawing.Size(96, 56)
        Me.lstReason.TabIndex = 16
        Me.lstReason.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Magenta
        Me.btnEdit.Location = New System.Drawing.Point(272, 112)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 40)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit Event"
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.Lime
        Me.btnAssign.Location = New System.Drawing.Point(160, 112)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(88, 40)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.TabStop = False
        Me.btnAssign.Text = "Assign Event"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(392, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Select a Reason:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(384, 112)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 40)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Do Nothing and Go Back"
        '
        'frmAddEvent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstAMPM)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lstInOut)
        Me.Controls.Add(Me.cmbMin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstReason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbHr)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmAddEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign/Edit Event"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub frmAddEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If AddEditMode = "EDIT" Then
            'fill out form
            Dim newfrmFixFile As New frmFixFile
            DateTimePicker1.Value = newfrmFixFile.dgAssociateData.Item(newfrmFixFile.dgAssociateData.CurrentRowIndex, "date")


            Dim TempTime As System.DateTime

            TempTime = newfrmFixFile.dgAssociateData.Item(newfrmFixFile.dgAssociateData.CurrentRowIndex, "time")
            cmbHr.SelectedItem = TempTime.Hour
            cmbMin.SelectedItem = TempTime.Minute
            MsgBox(TempTime.ToShortTimeString.Format("tt"))



        Else
            'do nothing
        End If
    End Sub
End Class
