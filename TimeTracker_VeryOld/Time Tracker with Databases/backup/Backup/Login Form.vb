Imports System.IO

Public Class frmLogin
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
    Public WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pboxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.pboxLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNameSelect.ItemHeight = 25
        Me.lstNameSelect.Location = New System.Drawing.Point(224, 168)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(224, 229)
        Me.lstNameSelect.Sorted = True
        Me.lstNameSelect.TabIndex = 2
        Me.lstNameSelect.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(8, 424)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(192, 16)
        Me.lblCopyright.TabIndex = 17
        Me.lblCopyright.Text = "Copyright © 2004, by David Doria"
        '
        'pboxLogo
        '
        Me.pboxLogo.Location = New System.Drawing.Point(408, 8)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(96, 72)
        Me.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxLogo.TabIndex = 19
        Me.pboxLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(24, 80)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(568, 40)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Associate Time Tracking System"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(104, 24)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(360, 40)
        Me.lblCompanyName.TabIndex = 25
        Me.lblCompanyName.Text = "Company Name"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(224, 408)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(224, 32)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "Time:"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 40)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Click your name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(496, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Version 3"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Exit"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(616, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstNameSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate Time Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim Currently As System.DateTime

        Currently = DateTime.Now

        lblTime.Text = "Time: " & Currently.ToShortTimeString

        'auto report

        'If Currently.ToString("ddd") = "Wed" And Currently.ToLongTimeString = "11:59:00 PM" Then
        '    'test line for current time instead of wednesday midnight
        ''   '    If Currently.ToString("ddd") = "Thu" And Currently.ToLongTimeString = "1:52:00 PM" Then
        '    Dim newfrmManager As New frmManager()
        '    newfrmManager.btnCreateReport_Click(Me, Nothing)
        '    MsgBox("Automatic report finished sucessfully!")

        'End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "*")

        'if they dont have the database file, this means they've never run the program

        'If File.Exists("timetracker.mdb") = False Then
        '    Directory.CreateDirectory("c:\windows\ttdata")
        '    CoName = InputBox("What is your company's name?")
        '    ThreeCharDay = InputBox("What day does your pay week end? (please use Mon, Tue, Wed, etc.")
        '    Dim CoStream As New System.IO.FileStream("c:\time tracker\company info.txt.bak", System.IO.FileMode.Create)
        '    Dim CoWriter As New System.IO.StreamWriter(CoStream)
        '    CoWriter.WriteLine(CoName)
        '    CoWriter.Write(ThreeCharDay.ToUpper)
        '    CoWriter.Close()
        '    CoStream.Close()

        '    'create blank files
        '    Dim AllStream As New System.IO.FileStream("c:\time tracker\All Associates.txt", System.IO.FileMode.Create)
        '    Dim AllWriter As New System.IO.StreamWriter(AllStream)
        '    'blank file
        '    AllWriter.Close()
        '    AllStream.Close()
        '    Dim TimedStream As New System.IO.FileStream("c:\time tracker\Timed Associates.txt", System.IO.FileMode.Create)
        '    Dim TimedWriter As New System.IO.StreamWriter(TimedStream)
        '    'blank file
        '    TimedWriter.Close()
        '    TimedStream.Close()


        '    MsgBox("On the next screen, you will create your first account!  You can then login using this account to continue setting up the program.")

        '    Dim newfrmAddAssociate As New frmAddAssociate
        '    newfrmAddAssociate.Show()

        'End If


        'open the database to read company data
        Dim CompanyData As New DataSet
        Dim CompanyDatabaseConnection As New OleDb.OleDbConnection
        Dim CompanyDA As OleDb.OleDbDataAdapter

        CompanyDatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        CompanyDatabaseConnection.Open()
        
        Dim CompanyQuery As String
        CompanyQuery = "SELECT * FROM company"
        CompanyDA = New OleDb.OleDbDataAdapter(CompanyQuery, CompanyDatabaseConnection)
        CompanyDA.Fill(CompanyData, "company")

        'my way
        LoginFormID = Me

        Dim CoName As String = CompanyData.Tables("company").Rows(0).Item("CompanyName")

        Dim PayDay As String = CompanyData.Tables("company").Rows(0).Item("PayDay")

        If MOTD Is Nothing Then
            'do nothing
        Else
            MOTD = CompanyData.Tables("company").Rows(0).Item("MOTD") 'stored as a global
        End If

        CompanyDatabaseConnection.Close() 'close database



        'load logo.gif if they have one
        If File.Exists("c:\time tracker\logo.gif") = True Then
            pboxLogo.Image = System.Drawing.Image.FromFile("c:\Time Tracker\logo.gif")
        End If

    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        'fade window
        Me.Enabled = False
        Me.Opacity = 10
        Me.BackColor = BackColor.Gray

        pboxLogo.Visible = False

        If lstNameSelect.SelectedIndex > -1 Then 'if someone was selected
            AssociateLoggedIn = GetAssociateData(lstNameSelect.SelectedItem)


            Dim newfrmGetPIN As New frmGetPIN

            If Not newfrmGetPIN.ShowDialog() = DialogResult.OK Then
                MsgBox("Invalid PIN")
            Else
                'if someone logged in correctly, show them the MOTD of there is one
                If MOTD Is Nothing Then
                    'do nothing
                Else
                    MsgBox(MOTD, , "Message of the day")
                End If

                If AssociateLoggedIn.Type = "Manager" Then 'show the managers area
                    Dim newfrmManager As New frmManager
                    newfrmManager.Show()
                ElseIf AssociateLoggedIn.Type = "Timed" Then ' otherwise show the associates area
                    Dim newfrmAssociate As New frmAssociate
                    newfrmAssociate.Show()
                Else
                    MsgBox("This associate should not need to login.")
                    Exit Sub

                End If
            End If
        End If



        'unfade form
        lstNameSelect.ClearSelected()
        Me.Opacity = 100
        Me.Enabled = True
        Me.BackColor = BackColor.LightBlue

        pboxLogo.Visible = True

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        End
    End Sub
End Class