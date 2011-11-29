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
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.Location = New System.Drawing.Point(120, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(24, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtSocial.BackColor = System.Drawing.Color.LightGray
        Me.txtSocial.Location = New System.Drawing.Point(120, 32)
        Me.txtSocial.MaxLength = 9
        Me.txtSocial.Name = "txtSocial"
        Me.txtSocial.Size = New System.Drawing.Size(88, 20)
        Me.txtSocial.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.AutoEllipsis = True
        Me.btnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(48, 139)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 45)
        Me.btnSave.TabIndex = 14
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPIN
        '
        Me.lblPIN.Location = New System.Drawing.Point(24, 61)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(90, 17)
        Me.lblPIN.TabIndex = 15
        Me.lblPIN.Text = "PIN:"
        Me.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.LightGray
        Me.txtPIN.Location = New System.Drawing.Point(120, 58)
        Me.txtPIN.MaxLength = 3
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(56, 20)
        Me.txtPIN.TabIndex = 2
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(177, 139)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 45)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quit Without Saving"
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
        Me.lstType.BackColor = System.Drawing.Color.LightGray
        Me.lstType.Items.AddRange(New Object() {"Manager", "Timed", "Commissioned"})
        Me.lstType.Location = New System.Drawing.Point(120, 80)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(128, 43)
        Me.lstType.TabIndex = 3
        '
        'frmAddAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(319, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSocial)
        Me.Controls.Add(Me.lblSocial)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmAddAssociate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'so the form cannot be moved
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        LogClick(sender)

        'if there is a blank field, generate an error message
        If txtName.Text = "" Or txtSocial.Text = "" Or txtPIN.Text = "" Or lstType.SelectedIndex = -1 Then
            MsgBox("Please fill in all the data fields.")
            Exit Sub
        End If

        'construct a new Associate and set the appropriate values
        Dim SaveAssociate As New Associate
        SaveAssociate.Name = txtName.Text
        SaveAssociate.Social = txtSocial.Text
        SaveAssociate.Type = lstType.SelectedItem.ToString.GetAssociateType
        SaveAssociate.Pin = txtPIN.Text

        'write the new associate to the database
        SaveAssociate.WriteData()

        'everything went ok, so return an "OK" 
        Me.DialogResult = Windows.Forms.DialogResult.OK

        'close the form
        Me.Dispose()

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        LogClick(sender)
        'close the form
        Me.Dispose()
    End Sub


End Class
