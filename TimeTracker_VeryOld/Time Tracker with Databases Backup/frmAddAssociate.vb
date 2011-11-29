Public Class frmAddAssociate
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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSocial As System.Windows.Forms.Label
    Friend WithEvents txtSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblSick As System.Windows.Forms.Label
    Friend WithEvents txtSick As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVacation As System.Windows.Forms.TextBox
    Friend WithEvents txtStartingDate As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lstType As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblSocial = New System.Windows.Forms.Label
        Me.txtSocial = New System.Windows.Forms.TextBox
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.txtStartingDate = New System.Windows.Forms.TextBox
        Me.lblSick = New System.Windows.Forms.Label
        Me.txtSick = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtVacation = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblPIN = New System.Windows.Forms.Label
        Me.txtPIN = New System.Windows.Forms.TextBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.lstType = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(64, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(24, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSocial
        '
        Me.lblSocial.AutoSize = True
        Me.lblSocial.Location = New System.Drawing.Point(24, 32)
        Me.lblSocial.Name = "lblSocial"
        Me.lblSocial.Size = New System.Drawing.Size(90, 13)
        Me.lblSocial.TabIndex = 2
        Me.lblSocial.Text = "Social Security #:"
        Me.lblSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSocial
        '
        Me.txtSocial.Location = New System.Drawing.Point(120, 32)
        Me.txtSocial.MaxLength = 9
        Me.txtSocial.Name = "txtSocial"
        Me.txtSocial.Size = New System.Drawing.Size(88, 20)
        Me.txtSocial.TabIndex = 1
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(24, 136)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(80, 16)
        Me.lblStartDate.TabIndex = 4
        Me.lblStartDate.Text = "Starting Date:"
        Me.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStartingDate
        '
        Me.txtStartingDate.Location = New System.Drawing.Point(112, 136)
        Me.txtStartingDate.Name = "txtStartingDate"
        Me.txtStartingDate.Size = New System.Drawing.Size(80, 20)
        Me.txtStartingDate.TabIndex = 4
        '
        'lblSick
        '
        Me.lblSick.AutoSize = True
        Me.lblSick.Location = New System.Drawing.Point(24, 160)
        Me.lblSick.Name = "lblSick"
        Me.lblSick.Size = New System.Drawing.Size(115, 13)
        Me.lblSick.TabIndex = 8
        Me.lblSick.Text = "Sick Hours Remaining:"
        Me.lblSick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSick
        '
        Me.txtSick.Location = New System.Drawing.Point(144, 160)
        Me.txtSick.Name = "txtSick"
        Me.txtSick.Size = New System.Drawing.Size(32, 20)
        Me.txtSick.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Vacation Hours Remaining:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVacation
        '
        Me.txtVacation.Location = New System.Drawing.Point(168, 184)
        Me.txtVacation.Name = "txtVacation"
        Me.txtVacation.Size = New System.Drawing.Size(32, 20)
        Me.txtVacation.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(32, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 45)
        Me.btnSave.TabIndex = 14
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Location = New System.Drawing.Point(24, 64)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(28, 13)
        Me.lblPIN.TabIndex = 15
        Me.lblPIN.Text = "PIN:"
        Me.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(64, 56)
        Me.txtPIN.MaxLength = 3
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(56, 20)
        Me.txtPIN.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(192, 216)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 45)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quit without saving"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(24, 80)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(96, 16)
        Me.lblType.TabIndex = 18
        Me.lblType.Text = "Associate's Type:"
        '
        'lstType
        '
        Me.lstType.Items.AddRange(New Object() {"Manager", "Timed", "Commissioned"})
        Me.lstType.Location = New System.Drawing.Point(120, 80)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(128, 43)
        Me.lstType.TabIndex = 3
        '
        'frmAddAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtVacation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSick)
        Me.Controls.Add(Me.lblSick)
        Me.Controls.Add(Me.txtStartingDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.txtSocial)
        Me.Controls.Add(Me.lblSocial)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmAddAssociate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'if there is a blank field
        If txtName.Text = "" Or txtSocial.Text = "" Or txtPIN.Text = "" Or lstType.SelectedIndex = -1 Or txtStartingDate.Text = "" Or txtSick.Text = "" Or txtVacation.Text = "" Then
            MsgBox("Please fill in all the data fields.")
            Exit Sub
        Else
            Dim SaveAssociate As New Associate

            SaveAssociate.Name = txtName.Text
            SaveAssociate.Social = txtSocial.Text
            SaveAssociate.StartDate = txtStartingDate.Text
            SaveAssociate.VacationHours = txtVacation.Text
            SaveAssociate.Type = lstType.SelectedItem
            SaveAssociate.SickHours = txtSick.Text
            SaveAssociate.Pin = txtPIN.Text

            WriteAssociateData(SaveAssociate) 'write the new associate to the database

            'add the new name to the login screen
            LoginFormID.lstNameSelect.Items.Add(txtName.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.Close()

        End If ' end if there is a blank field or not

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

 
End Class
