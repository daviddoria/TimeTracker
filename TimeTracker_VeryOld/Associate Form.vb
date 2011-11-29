
Public Class frmAssociate
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPunchOut As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTimeIs As System.Windows.Forms.Label
    Friend WithEvents btnPunchIn As System.Windows.Forms.Button
    Friend WithEvents lstReasonIn As System.Windows.Forms.ListBox
    Friend WithEvents lstReasonOut As System.Windows.Forms.ListBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLastEvent As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssociate))
        Me.btnPunchOut = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimeIs = New System.Windows.Forms.Label()
        Me.btnPunchIn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstReasonIn = New System.Windows.Forms.ListBox()
        Me.lstReasonOut = New System.Windows.Forms.ListBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLastEvent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPunchOut
        '
        Me.btnPunchOut.BackColor = System.Drawing.Color.Red
        Me.btnPunchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunchOut.ForeColor = System.Drawing.Color.Black
        Me.btnPunchOut.Location = New System.Drawing.Point(24, 88)
        Me.btnPunchOut.Name = "btnPunchOut"
        Me.btnPunchOut.Size = New System.Drawing.Size(80, 23)
        Me.btnPunchOut.TabIndex = 17
        Me.btnPunchOut.TabStop = False
        Me.btnPunchOut.Text = "Punch Out"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(224, 88)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(144, 24)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "Current time"
        '
        'lblTimeIs
        '
        Me.lblTimeIs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIs.Location = New System.Drawing.Point(8, 88)
        Me.lblTimeIs.Name = "lblTimeIs"
        Me.lblTimeIs.Size = New System.Drawing.Size(216, 23)
        Me.lblTimeIs.TabIndex = 15
        Me.lblTimeIs.Text = "The current time is "
        '
        'btnPunchIn
        '
        Me.btnPunchIn.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.btnPunchIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunchIn.ForeColor = System.Drawing.Color.Black
        Me.btnPunchIn.Location = New System.Drawing.Point(24, 88)
        Me.btnPunchIn.Name = "btnPunchIn"
        Me.btnPunchIn.Size = New System.Drawing.Size(88, 23)
        Me.btnPunchIn.TabIndex = 18
        Me.btnPunchIn.TabStop = False
        Me.btnPunchIn.Text = "Punch In"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lstReasonIn
        '
        Me.lstReasonIn.ItemHeight = 18
        Me.lstReasonIn.Items.AddRange(New Object() {"For the day", "From lunch", "From a misc."})
        Me.lstReasonIn.Location = New System.Drawing.Point(16, 24)
        Me.lstReasonIn.Name = "lstReasonIn"
        Me.lstReasonIn.Size = New System.Drawing.Size(104, 58)
        Me.lstReasonIn.TabIndex = 20
        Me.lstReasonIn.TabStop = False
        '
        'lstReasonOut
        '
        Me.lstReasonOut.ItemHeight = 16
        Me.lstReasonOut.Items.AddRange(New Object() {"For the day", "To lunch", "To a misc."})
        Me.lstReasonOut.Location = New System.Drawing.Point(16, 24)
        Me.lstReasonOut.Name = "lstReasonOut"
        Me.lstReasonOut.Size = New System.Drawing.Size(96, 52)
        Me.lstReasonOut.TabIndex = 21
        Me.lstReasonOut.TabStop = False
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.LightBlue
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(368, 224)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(176, 48)
        Me.btnGoBack.TabIndex = 24
        Me.btnGoBack.TabStop = False
        Me.btnGoBack.Text = "Do nothing and go back to login."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstReasonOut, Me.btnPunchOut})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(72, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 120)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reason Out:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstReasonIn, Me.btnPunchIn})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(80, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 120)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reason In:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Are you coming to work?"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 32)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Are you leaving work?"
        '
        'Panel1
        '
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.GroupBox2})
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 176)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label2})
        Me.Panel2.Location = New System.Drawing.Point(336, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 176)
        Me.Panel2.TabIndex = 32
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.lblLastEvent, Me.lblTimeIs, Me.lblTime})
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 304)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(608, 120)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Helpful Information"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Your last event was: "
        '
        'lblLastEvent
        '
        Me.lblLastEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastEvent.Location = New System.Drawing.Point(192, 40)
        Me.lblLastEvent.Name = "lblLastEvent"
        Me.lblLastEvent.Size = New System.Drawing.Size(408, 23)
        Me.lblLastEvent.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 80)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Do you want to return to the previous screen without logging an event?"
        '
        'frmAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 444)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Panel1, Me.Panel2, Me.GroupBox5, Me.btnGoBack})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAssociate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate's Area"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnPunchIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchIn.Click

        Dim ReasonIN As String
        If lstReasonIn.SelectedIndex = -1 Then
            MsgBox("Please select a reason.")
            GoTo SkipWrite
        End If

        If lstReasonIn.SelectedItem = "For the day" Then
            ReasonIN = "DAY"
        End If

        If lstReasonIn.SelectedItem = "From lunch" Then
            ReasonIN = "LUNCH"
        End If

        If lstReasonIn.SelectedItem = "From a misc." Then
            ReasonIN = "MISC"
        End If

        Dim SplitString As String()
        Dim LastLine As String
        Dim currentline As String
        Dim LastReason As String
        Dim CurrentDateTime As System.DateTime

        'open the file to read previous events
        Dim AssociatesStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.filename, System.IO.FileMode.Open)
        Dim AssociatesReader As New System.IO.StreamReader(AssociatesStream)

        'get the first line
        currentline = AssociatesReader.ReadLine

        'if the first line is blank and they are logging in for the day
        If currentline = Nothing And ReasonIN = "DAY" Then
            AssociatesReader.Close()
            AssociatesStream.Close()
            GoTo BlankFile
            'if the first line is blank and they are not logging in for the day, that is wrong
        ElseIf currentline = Nothing And Not ReasonIN = "DAY" Then
            MsgBox("Your first punch for the payperiod must be in for the day.  Please see a manager.")
            GoTo skipwrite
        End If

        'Start Loop to get last line of file
        Do While currentline <> Nothing

            'Store current line to the last line read variable 
            LastLine = currentline
            'Read the next line 
            currentline = AssociatesReader.ReadLine
        Loop

        AssociatesReader.Close()
        AssociatesStream.Close()

        Dim EmptyFile As Boolean

        'get relevant data
        SplitString = Split(LastLine, " PUNCH ")

        'must use SplitString 0 before can use 1 (the only one we are interested in)
        CurrentDateTime = DateTime.Parse(SplitString(0))
        LastReason = SplitString(1)

        'determine if the file is empty
        If LastReason = Nothing Then
            EmptyFile = True
        Else
            EmptyFile = False
        End If

        If ReasonIN = "LUNCH" Then
            If Not LastReason = "OUT LUNCH" Then
                MsgBox("You didn't punch out to lunch!  Please get a manager!")
                lstReasonIn.SelectedIndex = -1
                GoTo skipwrite
            End If
        End If

        If ReasonIN = "DAY" Then
            If Not LastReason = "OUT DAY" And EmptyFile = False Then
                MsgBox("You didn't punch out for the day yesterday!  Please get a manager!")
                lstReasonIn.SelectedIndex = -1
                GoTo skipwrite
            End If
        End If

        Dim MISCStream As New System.IO.FileStream("c:\time tracker\MISC comments.txt", System.IO.FileMode.Append)
        Dim MISCWriter As New System.IO.StreamWriter(MISCStream)

        If ReasonIN = "MISC" Then
            If Not LastReason = "OUT MISC" Then
                MsgBox("You didn't punch out to a misc. task!  Please get a manager!")
                lstReasonIn.SelectedIndex = -1
                GoTo skipwrite
            Else
                MISCWriter.WriteLine(AssociateSittingAtComputer.Name & " IN MISC " & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & vbNewLine)
            End If
        End If
        MISCWriter.Close()
        MISCStream.Close()



BlankFile:
        Dim myFileStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Append)
        Dim myWriter As New System.IO.StreamWriter(myFileStream)

        myWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & " PUNCH IN " & ReasonIN)

        myWriter.Close()
        myFileStream.Close()

        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100

SkipWrite:
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblTime.Text() = DateTime.Now.ToShortTimeString()

    End Sub

    Private Sub btnPunchOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchOut.Click

        Dim ReasonOUT As String

        'if nothing selected
        If lstReasonOut.SelectedIndex = -1 Then
            MsgBox("Please select a reason.")
            GoTo EndOfOutButton
        End If

        'assign 1 word to ReasonOUT
        If lstReasonOut.SelectedItem = "For the day" Then
            ReasonOUT = "DAY"
        End If

        If lstReasonOut.SelectedItem = "To lunch" Then
            ReasonOUT = "LUNCH"
        End If

        If lstReasonOut.SelectedItem = "To a misc." Then
            ReasonOUT = "MISC"
        End If

        Dim SplitString As String()
        Dim LastLine As String
        Dim currentline As String
        Dim LastReason As String
        Dim CurrentDateTime As System.DateTime

        'open associates file
        Dim AssociatesStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Open)
        Dim AssociatesReader As New System.IO.StreamReader(AssociatesStream)

        'read first line
        currentline = AssociatesReader.ReadLine
        'if the first line is blank they cant be going OUT
        If currentline = Nothing Then
            MsgBox("You have not punched any events this payperiod.  Please see a manager.")
            GoTo EndOfOutButton
        End If

        Dim EventDate As String
        Dim ReasonCount As Integer = 0
        Dim LastReasonNumber As Integer = 0
        Dim ReasonList(6) As String
        Dim DateOfEvent As System.DateTime

        'Start Loop to get all the events of the current day
        Do While Not currentline Is Nothing

            'get the first part of the line in the file
            SplitString = Split(currentline, " PUNCH ")

            'put it into a datetime variable
            DateOfEvent = DateTime.Parse(SplitString(0)).ToShortDateString

            If DateOfEvent = DateTime.Now.ToShortDateString() Then
                ReasonCount = ReasonCount + 1

                If EC = True Then
                    MsgBox("reason count incremented to " & ReasonCount)
                End If

                ReasonList(ReasonCount) = SplitString(1)
                LastReasonNumber = ReasonCount
            End If

            'Read the next line 
            currentline = AssociatesReader.ReadLine
        Loop

        'now that we have the data for the day, close the file
        AssociatesReader.Close()
        AssociatesStream.Close()

        'get the last reason
        LastReason = ReasonList(LastReasonNumber)

        If EC = True Then
            MsgBox("last reason is: " & LastReason)
        End If

        If ReasonOUT = "LUNCH" Then
            If Not LastReason = "IN DAY" And Not LastReason = "IN MISC" Then
                MsgBox("You are already clocked out!  Please get a manager!")
                lstReasonOut.SelectedIndex = -1
                GoTo EndOfOutButton
            End If
        End If

        'things used in punch out for the day
        Dim SkipLunch As String
        Dim AutoCorrectStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Append)
        Dim AutoCorrectWriter As New System.IO.StreamWriter(AutoCorrectStream)

        If ReasonOUT = "DAY" Then

            If ReasonCount = 5 Then ' we need 5 events before we can punch out for the day
                'do nothing, all events are full
                If EC = True Then
                    MsgBox("all events full!")
                End If

            ElseIf ReasonCount = 4 And LastReason = "OUT LUNCH" Then
                If EC = True Then
                    MsgBox("4 and out to lunch")
                End If

                MsgBox("You didn't punch in from lunch! Please get a manager!")
                GoTo EndOfOutButton

            ElseIf ReasonCount = 4 And LastReason = "OUT MISC" Then
                If EC = True Then
                    MsgBox("4 and out misc")
                End If

                MsgBox("You didn't punch in from your misc. activity! Please get a manager!")
                GoTo EndOfOutButton

            ElseIf ReasonCount = 3 And LastReason = "IN LUNCH" Then 'auto add 0 time misc
                If EC = True Then
                    MsgBox("3 and auto add misc")
                End If

                AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:30 AM PUNCH OUT MISC")
                AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:30 AM PUNCH IN MISC")

            ElseIf ReasonCount = 3 And LastReason = "IN MISC" Then
                If EC = True Then
                    MsgBox("3 and ask about lunch")
                End If

                SkipLunch = MsgBox("You didn't take a lunch! Did you skip lunch?", MsgBoxStyle.YesNo)
                If SkipLunch = vbYes Then 'auto add 0 time lunch
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:00 AM PUNCH OUT LUNCH")
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:00 AM PUNCH IN LUNCH")
                Else 'if they didn't want to skip lunch, quit
                    GoTo EndOfOutButton
                End If

            ElseIf ReasonCount = 2 And LastReason = "OUT LUNCH" Then
                If EC = True Then
                    MsgBox("2 and at lunch")
                End If

                MsgBox("You didn't punch in from lunch! Please get a manager!")
                GoTo EndOfOutButton

            ElseIf ReasonCount = 2 And LastReason = "OUT MISC" Then
                If EC = True Then
                    MsgBox("2 and at misc")
                End If

                MsgBox("You didn't punch in from your misc. task! Please get a manager!")
                GoTo EndOfOutButton

            ElseIf ReasonCount = 1 And LastReason = "IN DAY" Then 'auto add 0 time lunch and 0 time misc
                If EC = True Then
                    MsgBox("1 and skipped lunch and misc")
                End If

                SkipLunch = MsgBox("You didn't take a lunch! Did you skip lunch?", MsgBoxStyle.YesNo)
                If SkipLunch = vbYes Then
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:00 AM PUNCH OUT LUNCH")
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:00 AM PUNCH IN LUNCH")
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:30 AM PUNCH OUT MISC")
                    AutoCorrectWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & "11:30 AM PUNCH IN MISC")
                Else
                    MsgBox("Please explain the problem to a manager.")
                    GoTo EndOfOutButton
                End If

            End If ' end if for reason count options


        End If ' end if for punch out for day

        'close stream used in punch out for the day
        AutoCorrectWriter.Close()
        AutoCorrectStream.Close()

        Dim MISCStream As New System.IO.FileStream("c:\time tracker\MISC comments.txt", System.IO.FileMode.Append)
        Dim MISCWriter As New System.IO.StreamWriter(MISCStream)

        Dim MISCReason As String

        If ReasonOUT = "MISC" Then
            If Not LastReason = "IN DAY" And Not LastReason = "IN LUNCH" Then
                MsgBox("You are either clocked out to lunch or you haven't clocked in for the day!  Please get a manager!")
                lstReasonOut.SelectedIndex = -1
                GoTo EndOfOutButton
            Else 'they want to log a misc event
                MISCReason = InputBox("What is the MISC event you are leaving for?", "MISC Event")
                MISCWriter.WriteLine(AssociateSittingAtComputer.Name & " OUT MISC " & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & vbNewLine & MISCReason & vbNewLine)
            End If
        End If
        MISCWriter.Close()
        MISCStream.Close()


        'unselect list box
        lstReasonOut.SelectedIndex = -1

        'open the associates file to output an event
        Dim myFileStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Append)
        Dim myWriter As New System.IO.StreamWriter(myFileStream)

        myWriter.WriteLine(DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & " PUNCH OUT " & ReasonOUT)

        myWriter.Close()
        myFileStream.Close()

        'when they logout for the day give them their stats
        If ReasonOUT = "DAY" Then
            If EC = True Then
                MsgBox("reason out is day! time for stats!")
            End If

            'reopen their file
            Dim EndOfDayStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Open)
            Dim EndOfDayReader As New System.IO.StreamReader(EndOfDayStream)

            Dim EventsInDayCounter As Integer = 0
            Dim TimeOfEvent As System.DateTime
            Dim TimeList(6) As System.DateTime


            Do While Not EndOfDayReader.Peek = -1
                currentline = EndOfDayReader.ReadLine

                SplitString = Split(currentline, " PUNCH ")

                EventDate = SplitString(0)

                'put it into a datetime variable
                DateOfEvent = DateTime.Parse(EventDate).ToShortDateString
                TimeOfEvent = DateTime.Parse(EventDate).ToShortTimeString
                If EC = True Then
                    MsgBox("DateOfEvent is " & DateOfEvent)
                    MsgBox("now is : " & System.DateTime.Now.ToShortDateString)
                End If

                If DateOfEvent = DateTime.Now.ToShortDateString() Then

                    TimeList(EventsInDayCounter) = TimeOfEvent
                    EventsInDayCounter = EventsInDayCounter + 1
                    If EC = True Then
                        MsgBox("TimeList(EventsInDayCounter)=" & TimeOfEvent)
                    End If

                End If

            Loop



            EndOfDayReader.Close()
            EndOfDayStream.Close()

            If EC = True Then
                MsgBox("should have last 6 events")
            End If

            MsgBox("Today you worked " & CalculateHoursInDay(TimeList) & " hours.  If this is not correct please see a manager.")


        End If

        'tell them their time at the end of the week
        Dim WeekEndStream As New System.IO.FileStream("c:\Time Tracker\company info.txt", System.IO.FileMode.Open)
        Dim WeekEndReader As New System.IO.StreamReader(WeekEndStream)
        Dim DayWeekEnds As String
        DayWeekEnds = WeekEndReader.ReadLine 'firstline is company name
        DayWeekEnds = WeekEndReader.ReadLine.ToUpper
        WeekEndReader.Close()
        WeekEndStream.Close()

        If EC = True Then
            MsgBox("Start check if its the end of the week")
        End If

        If DateTime.Now.ToString("ddd").ToUpper = DayWeekEnds And ReasonOUT = "DAY" Then
            If EC = True Then
                MsgBox("its the end of the week!")
            End If
            Dim CurrentLineFromFile As String
            Dim CurrentPunchLine(5) As String
            Dim CurrentEOWDateTime(5) As System.DateTime
            Dim CurrentReason(5) As String

            Dim counter As Integer = 0
            Dim StringFields As String()
            Dim NormalTime As Double = 0
            Dim OverTime As Double = 0
            Dim NumDays As Integer = 0
            Dim NumLines As Integer = GetNumberOfLines("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName)
            If EC = True Then
                MsgBox("There are " & NumLines & " lines and there should be " & NumLines / 6 & " days")
            End If
            Dim DayCounter As Integer
            'open their file
            Dim EndOfWeekStream As New System.IO.FileStream("c:\Time Tracker\associates\" & AssociateSittingAtComputer.FileName, System.IO.FileMode.Open)
            Dim EndOfWeekReader As New System.IO.StreamReader(EndOfWeekStream)

BeginningOfDay:
            For DayCounter = 1 To NumLines / 6

                'read in 6 events
                For counter = 0 To 5
                    If EndOfWeekReader.Peek = -1 Then
                        MsgBox("An error occured when calculuating your time for the week.")
                        GoTo EndOfOutButton
                    End If
                    CurrentLineFromFile = EndOfWeekReader.ReadLine
                    If CurrentLineFromFile = Nothing Then
                        MsgBox("There is something wrong, check with a manager.")
                        GoTo EndOfOutButton
                    End If
                    CurrentPunchLine(counter) = CurrentLineFromFile
                    StringFields = Split(CurrentPunchLine(counter), " PUNCH ")
                    CurrentEOWDateTime(counter) = DateTime.Parse(StringFields(0))
                    CurrentReason(counter) = StringFields(1)

                Next
                NormalTime = NormalTime + CalculateHoursInDay(CurrentEOWDateTime)
                If EC = True Then
                    MsgBox("total is " & NormalTime)
                End If

            Next

            'check for overtime
            If NormalTime > 40 Then
                OverTime = FormatNumber(NormalTime - 40, 2)
                NormalTime = 40
            Else
                OverTime = 0
                NormalTime = FormatNumber(NormalTime, 2)
            End If

            'close the particular associates file
            EndOfWeekReader.Close()
            EndOfWeekStream.Close()

            MsgBox("This week you worked " & NormalTime & " normal hours and " & OverTime & " overtime hours.")

        End If

EndOfOutButton:

        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100
        Me.Close()

    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100
        Me.Close()
    End Sub


    Private Sub frmAssociate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LastLine As String
        Dim CurrentLine As String

        'open associates file
        Dim AssociatesStream As New System.IO.FileStream("c:\time tracker\associates\" & AssociateSittingAtComputer.filename, System.IO.FileMode.Open)
        Dim AssociatesReader As New System.IO.StreamReader(AssociatesStream)

        'get first line
        CurrentLine = AssociatesReader.ReadLine

        'Start Loop to get last line
        Do While CurrentLine <> Nothing

            'Store current line to the last line read variable 
            LastLine = CurrentLine
            'Read the next line 
            CurrentLine = AssociatesReader.ReadLine
        Loop

        AssociatesReader.Close()
        AssociatesStream.Close()

        If Not LastLine Is Nothing Then
            lblLastEvent.Text = LastLine
        Else
            lblLastEvent.Text = "This will be the first event of the payperiod."
        End If

    End Sub


End Class
