Public Class frmGetPIN
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
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPIN = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.White
        Me.txtPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.Location = New System.Drawing.Point(112, 44)
        Me.txtPIN.MaximumSize = New System.Drawing.Size(128, 56)
        Me.txtPIN.MaxLength = 3
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(128, 56)
        Me.txtPIN.TabIndex = 0
        Me.txtPIN.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LimeGreen
        Me.btnLogin.Location = New System.Drawing.Point(69, 114)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 32)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login!"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(4, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(338, 32)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Name"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.Red
        Me.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGoBack.Location = New System.Drawing.Point(184, 114)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(96, 34)
        Me.btnGoBack.TabIndex = 3
        Me.btnGoBack.Text = "Go Back!"
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'frmGetPIN
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btnGoBack
        Me.ClientSize = New System.Drawing.Size(344, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGetPIN"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIN Verification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub frmGetPIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        txtPIN.Focus()
    End Sub

    Private Sub frmGetPIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = BackgroundColor

        lblWelcome.Text = "Welcome " & AssociateLoggedIn.Name & "!"

        txtPIN.Text = ""
        txtPIN.Focus()

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        LogClick(sender)
        If txtPIN.Text = AssociateLoggedIn.Pin Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        Me.Dispose()
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        LogClick(sender)
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Dispose()
    End Sub

    Private Sub lblWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWelcome.Click

    End Sub
End Class
