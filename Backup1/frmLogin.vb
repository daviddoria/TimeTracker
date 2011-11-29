Imports System.IO

'Note: Active(Release) mode is for distribution

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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pboxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnRunTest As System.Windows.Forms.Button
    Friend WithEvents about_menu As System.Windows.Forms.MenuItem

    Friend WithEvents exit_menu As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.exit_menu = New System.Windows.Forms.MenuItem
        Me.about_menu = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.pboxLogo = New System.Windows.Forms.PictureBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Label5 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblTime = New System.Windows.Forms.Label
        Me.btnRunTest = New System.Windows.Forms.Button
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTitle, 2)
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(163, 160)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(520, 39)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Associate Time Tracking System '09"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.exit_menu, Me.about_menu})
        Me.MenuItem1.Text = "File"
        '
        'exit_menu
        '
        Me.exit_menu.Index = 0
        Me.exit_menu.Text = "Exit"
        '
        'about_menu
        '
        Me.about_menu.Index = 1
        Me.about_menu.Text = "About"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Today is:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(196, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 37)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Click your name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(136, 17)
        Me.ToolStripStatusLabel1.Text = "Written by David Doria"
        '
        'pboxLogo
        '
        Me.pboxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.pboxLogo, 2)
        Me.pboxLogo.Image = Global.TimeTracker.My.Resources.Resources.logo
        Me.pboxLogo.Location = New System.Drawing.Point(352, 39)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(142, 65)
        Me.pboxLogo.TabIndex = 37
        Me.pboxLogo.TabStop = False
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(12, 427)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 38
        Me.btnTest.Text = "Run Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Label2"
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNameSelect.BackColor = System.Drawing.Color.White
        Me.lstNameSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNameSelect.ItemHeight = 25
        Me.lstNameSelect.Location = New System.Drawing.Point(196, 291)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(224, 354)
        Me.lstNameSelect.Sorted = True
        Me.lstNameSelect.TabIndex = 2
        Me.lstNameSelect.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Enabled = False
        Me.MonthCalendar1.Location = New System.Drawing.Point(432, 297)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 650)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Time:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstNameSelect, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pboxLogo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTime, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(846, 724)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(426, 650)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(159, 29)
        Me.lblTime.TabIndex = 40
        Me.lblTime.Text = "CurrentTime"
        '
        'btnRunTest
        '
        Me.btnRunTest.Location = New System.Drawing.Point(0, 0)
        Me.btnRunTest.Name = "btnRunTest"
        Me.btnRunTest.Size = New System.Drawing.Size(75, 23)
        Me.btnRunTest.TabIndex = 42
        Me.btnRunTest.Text = "Run Test"
        Me.btnRunTest.UseVisualStyleBackColor = True
        Me.btnRunTest.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(846, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRunTest)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate Time Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'this is used to make the form un-moveable (written by jmchilley)
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Updates the time on the login form every second
        lblTime.Text = Now.ToShortTimeString

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Start logging, if enabled
        Trace.Listeners.Add(New TextWriterTraceListener("log.txt"))
        Trace.WriteLineIf(bTrace, vbCrLf + Now.ToShortDateString + " " + Now.ToShortTimeString + " Started Program.")
        Trace.Flush()

        'check screen resolution
        If Screen.PrimaryScreen.Bounds.Width < 1024 Or Screen.PrimaryScreen.Bounds.Height < 768 Then
            MessageBox.Show("Screen resolution must be at least 1024x768")
            End

        End If

        'don't continue if the folder doesn't exist
        If System.IO.Directory.Exists("C:\Time Tracker") = False Then
            MessageBox.Show("C:\Time Tracker does not exist!")
            End
        End If

        'Don't continue if the database doesn't exist. All of the information about 
        'employees and their time cards are stored in this database.
        If System.IO.File.Exists("C:\Time Tracker\timetracker.mdb") = False Then
            MessageBox.Show("C:\Time Tracker\timetracker.mdb does not exist!")
            End
        End If

        'Create the reports directory if it doesn't exist. The reports are archived
        'in this directory
        Dim ReportDirectory As String = "C:\Time Tracker\Reports"
        If System.IO.Directory.Exists(ReportDirectory) = False Then
            Directory.CreateDirectory(ReportDirectory)
        End If

        'display the time on the form
        lblTime.Text = Now.ToShortTimeString

        'populate the listbox to select login name
        LoadNameListBox(lstNameSelect, AssociateType.ALL)

        'get the company data
        Company = New CompanyClass("Kwik Kopy Printing")

    End Sub

    Private Sub lstNameSelect_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstNameSelect.MouseClick
        LogListBoxSelection(sender)

        'if nothing is selected, don't do anything
        If lstNameSelect.SelectedIndex = -1 Then
            Return
        End If

        'dim the form so the login box will be more prominent
        Fade()

        'set a global variable to the person who is logging in
        AssociateLoggedIn = New Associate(lstNameSelect.SelectedItem.ToString)

        'ask for login info (PIN)
        Dim PinResult As DialogResult = frmGetPIN.ShowDialog

        'if the PIN was correct, bring the associate to the appropriate place
        'if not, return to the login screen
        If PinResult = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Invalid PIN")
        ElseIf PinResult = Windows.Forms.DialogResult.Abort Then
            'do nothing and go back
        ElseIf PinResult = Windows.Forms.DialogResult.OK Then

            'show the message of the day if there is one
            If Company.MOTD <> "" Then
                MessageBox.Show(Company.MOTD, "Message of the Day")
            End If

            'Take managers to the manager's area
            If AssociateLoggedIn.Type = AssociateType.MANAGER Then
                AssociateLoggedIn.ShowArea()
            Else
                'check what the last event was
                Dim LastEvent As PunchEvent = AssociateLoggedIn.GetLastEvent()

                'from breaks and lunch, there is no decision to be made about what should be done, so to help prevent errors
                'the associate is automatically logged back in from the event they are out to
                If LastEvent.Direction = EventDirection.DirectionOut Or LastEvent.Valid.Equals(False) Then
                    'auto login
                    Dim InEvent As New PunchEvent
                    InEvent.AutoPunchIn(LastEvent)

                    AssociateLoggedIn.WriteEvent(InEvent)

                    'display the associates information for the day/week
                    frmInfo.ShowDialog()

                Else
                    AssociateLoggedIn.ShowArea()
                End If 'end Auto Punch In

            End If ' end associate type

        End If 'end PIN Result

        'return "focus" to the login form
        Unfade()

        'refresh the listbox to select login name
        LoadNameListBox(lstNameSelect, AssociateType.ALL)

    End Sub

    Private Sub Fade()
        'fade window
        Me.Enabled = False
        Me.Opacity = 10
        Me.BackColor = Color.Gray
        Me.lblTitle.BackColor = Color.Gray
        pboxLogo.Visible = False
    End Sub

    Public Sub Unfade()
        'unfade form
        lstNameSelect.ClearSelected()
        Me.Opacity = 100
        Me.Enabled = True
        Me.BackColor = BackgroundColor
        lblTitle.BackColor = BackgroundColor
        pboxLogo.Visible = True
    End Sub


    Private Sub btnRunTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunTest.Click
        'This button should generally be invisible.
        'It is a convenient way to run unit tests.

        'TestGetWeekStart()
        'TestGetLastEvent()

        'TestCalculateDayTime_Valid()
        'TestCalculateDayTime_InValid()


        'TestCalculateLunchTime_Valid()
        'testCalculateLunchTime_InValid()

        'TestCalculateBreakTime_SingleValidBreak()
        'TestCalculateBreakTime_TwoValidBreaks()
        'TestCalculateBreakTime_Invalid()

        'TestGetEvents()

        'TestAssociateConstructor()

        'TestCalculateDailyHours()

        'TestWeekTime()

        TestCalculateDayBreakTime_Valid()
        'TestCalculateDayLunchTime_Valid()
    End Sub


    Private Sub exit_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_menu.Click
        LogMenuClick(sender)
        'quit the program
        End
    End Sub

    Private Sub about_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles about_menu.Click
        LogMenuClick(sender)

        'get the version number from AssemblyInfo.vb and display a message box with the title, author, and version number (actually, the date of the build)
        Dim BuildDate As Date = GetVersionNumber()
        MessageBox.Show("Time Tracker" + Environment.NewLine + "David Doria" + Environment.NewLine + "(Built on " + BuildDate.ToShortDateString + ")", "About")
    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        'don't do anything here, it causes problems when nothing is selected

    End Sub

End Class
