Imports System.Drawing.Printing
Public Class frmManager
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
    Friend WithEvents btnCreateReport As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAssignDays As System.Windows.Forms.Button
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents btnEditAssociate As System.Windows.Forms.Button
    Friend WithEvents btnMOTD As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TextToPrintTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAssociate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmManager))
        Me.btnCreateReport = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnFix = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAssignDays = New System.Windows.Forms.Button()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.btnEditAssociate = New System.Windows.Forms.Button()
        Me.btnMOTD = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextToPrintTextBox = New System.Windows.Forms.TextBox()
        Me.btnAddAssociate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateReport
        '
        Me.btnCreateReport.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.btnCreateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateReport.Location = New System.Drawing.Point(56, 88)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(152, 32)
        Me.btnCreateReport.TabIndex = 4
        Me.btnCreateReport.TabStop = False
        Me.btnCreateReport.Text = "Print Time Report"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(56, 40)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 32)
        Me.btnReset.TabIndex = 5
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset All Associate Data"
        '
        'btnFix
        '
        Me.btnFix.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.btnFix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFix.Location = New System.Drawing.Point(48, 40)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(152, 32)
        Me.btnFix.TabIndex = 6
        Me.btnFix.TabStop = False
        Me.btnFix.Text = "View/Fix an Associates File"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(240, 376)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(152, 32)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        '
        'btnAssignDays
        '
        Me.btnAssignDays.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.btnAssignDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignDays.Location = New System.Drawing.Point(48, 88)
        Me.btnAssignDays.Name = "btnAssignDays"
        Me.btnAssignDays.Size = New System.Drawing.Size(152, 32)
        Me.btnAssignDays.TabIndex = 9
        Me.btnAssignDays.TabStop = False
        Me.btnAssignDays.Text = "Assign Sick/Vacation/Holiday"
        '
        'btnComment
        '
        Me.btnComment.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.btnComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.Location = New System.Drawing.Point(48, 136)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(152, 32)
        Me.btnComment.TabIndex = 10
        Me.btnComment.TabStop = False
        Me.btnComment.Text = "Enter a Managers Comment"
        '
        'btnEditAssociate
        '
        Me.btnEditAssociate.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.btnEditAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAssociate.Location = New System.Drawing.Point(56, 32)
        Me.btnEditAssociate.Name = "btnEditAssociate"
        Me.btnEditAssociate.Size = New System.Drawing.Size(152, 32)
        Me.btnEditAssociate.TabIndex = 11
        Me.btnEditAssociate.TabStop = False
        Me.btnEditAssociate.Text = "Edit/Delete an Associate"
        '
        'btnMOTD
        '
        Me.btnMOTD.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.btnMOTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTD.Location = New System.Drawing.Point(48, 184)
        Me.btnMOTD.Name = "btnMOTD"
        Me.btnMOTD.Size = New System.Drawing.Size(152, 32)
        Me.btnMOTD.TabIndex = 12
        Me.btnMOTD.TabStop = False
        Me.btnMOTD.Text = "Set/Delete Message of the Day"
        '
        'TextToPrintTextBox
        '
        Me.TextToPrintTextBox.Location = New System.Drawing.Point(8, 32)
        Me.TextToPrintTextBox.Name = "TextToPrintTextBox"
        Me.TextToPrintTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TextToPrintTextBox.TabIndex = 14
        Me.TextToPrintTextBox.Text = "TextBox for printing"
        Me.TextToPrintTextBox.Visible = False
        '
        'btnAddAssociate
        '
        Me.btnAddAssociate.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.btnAddAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAssociate.Location = New System.Drawing.Point(56, 80)
        Me.btnAddAssociate.Name = "btnAddAssociate"
        Me.btnAddAssociate.Size = New System.Drawing.Size(152, 32)
        Me.btnAddAssociate.TabIndex = 15
        Me.btnAddAssociate.TabStop = False
        Me.btnAddAssociate.Text = "Add a New Associate"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnReset, Me.btnCreateReport})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(320, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 128)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weekly Functions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnFix, Me.btnAssignDays, Me.btnComment, Me.btnMOTD})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 224)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Functions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnEditAssociate, Me.btnAddAssociate})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(320, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 120)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rarely Used Functions"
        '
        'frmManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 446)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnLogout, Me.TextToPrintTextBox})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManager"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager's Area"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub btnCreateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport.Click

        Dim StringFields(2) As String
        Dim NormalTime As Double = 0
        Dim OverTime As Double = 0
        Dim ErrorInTimeFile As Boolean = False
        Dim ErrorInReport As Boolean = False
        Dim ErrorInAssociates As New ArrayList(0)

        Dim CurrentAssociate As New Associate()

        Dim HoursInWeek As Double = 0

        'get list of timed employees
        Dim TimedAssociatesList As ArrayList = GetListOfNames("timed")

        'get list of commissioned employees
        Dim CommissionedAssociatesList As ArrayList = GetListOfNames("commissioned")

        'get list of manager employees
        Dim ManagerAssociatesList As ArrayList = GetListOfNames("manager")

        'open main output file
        Dim OutputFileStream As New System.IO.FileStream("c:\Time Tracker\TIME TRACKING REPORT.txt", System.IO.FileMode.Create)
        Dim OutputWriter As New System.IO.StreamWriter(OutputFileStream)

        'put the fax info at the top of the output file
        Dim FaxInfoStream As New System.IO.FileStream("c:\time tracker\fax.txt", IO.FileMode.Open)
        Dim FaxInfoReader As New System.IO.StreamReader(FaxInfoStream)

        OutputWriter.Write(FaxInfoReader.ReadToEnd)

        FaxInfoReader.Close()
        FaxInfoStream.Close()

        'main loop, go through all the associates in TimedAssociatesList
        Dim TempTimedAssociate As String
        For Each TempTimedAssociate In TimedAssociatesList
            'sofar, everything is ok
            ErrorInTimeFile = False

            'get the associates personal data
            If GetAssociateData(TempTimedAssociate, CurrentAssociate) = False Then
                MsgBox("There was a problem with " & CurrentAssociate.Name & "'s data file.")
            End If

            If EC = True Then
                MsgBox("Got the associates personal data!")
            End If

            'if everything is ok with personal, output to time.txt the persons name and social
            OutputWriter.WriteLine(CurrentAssociate.Name)
            OutputWriter.WriteLine(CurrentAssociate.Social)

            'veryify the associates time file is complete
            If CheckTimeFile("c:\time tracker\associates\" & CurrentAssociate.FileName) <> 100 Then
                ErrorInTimeFile = True
                ErrorInReport = True
                ErrorInAssociates.Add(TempTimedAssociate)
                GoTo WriteError
                'WRITE ERROR
            End If

            If EC = True Then
                MsgBox("Got the associates time file!")
            End If

            'see how many days we will be going through
            Dim NumberOfDays As Integer = GetNumberOfLines("c:\time tracker\associates\" & CurrentAssociate.FileName) / 6

            'open the time file for reading six lines at a time
            Dim CurrentAssociateStream As New System.IO.FileStream("c:\time tracker\associates\" & CurrentAssociate.FileName, System.IO.FileMode.Open)
            Dim CurrentAssociateReader As New System.IO.StreamReader(CurrentAssociateStream)

            Dim DayCounter As Integer = 0

            For DayCounter = 0 To NumberOfDays - 1
                If EC = True Then
                    MsgBox("Currentday is: " & DayCounter)
                End If
                'get six events for the day

                Dim Day(6) As String

                Dim DayEventCounter As Integer = 0
                Dim TimeSix(6) As System.DateTime
                Dim ReasonSix(6) As String
                For DayEventCounter = 0 To 5

                    Day(DayEventCounter) = CurrentAssociateReader.ReadLine
                    If EC = True Then
                        MsgBox(Day(DayEventCounter))
                    End If

                    StringFields = Split(Day(DayEventCounter), " PUNCH ")
                    TimeSix(DayEventCounter) = DateTime.Parse(StringFields(0))
                    ReasonSix(DayEventCounter) = StringFields(1)
                Next

                DayEventCounter = 0

                Dim HoursInCurrentDay As Double = CalculateHoursInDay(TimeSix)

                If EC = True Then
                    MsgBox("HoursInCurrentDay: " & HoursInCurrentDay)
                End If

                HoursInWeek = HoursInWeek + HoursInCurrentDay

                OutputWriter.Write(TimeSix(1).ToString("ddd") & ": " & HoursInCurrentDay & " ")
                HoursInCurrentDay = 0

            Next

            'close the particular associates file
            CurrentAssociateReader.Close()
            CurrentAssociateStream.Close()

WriteError:
            If ErrorInTimeFile = True Then
                OutputWriter.Write("ERROR!")
            End If


            'check for overtime
            If HoursInWeek > 40 Then
                OverTime = HoursInWeek - 40
                NormalTime = 40
            Else
                OverTime = 0
                NormalTime = HoursInWeek
            End If

            NormalTime = FormatNumber(NormalTime, 2)
            OverTime = FormatNumber(OverTime, 2)

            If EC = True Then
                MsgBox("normal time: " & NormalTime)
                MsgBox("over time: " & OverTime)
            End If

            'end the line since we used mywriter.write()
            OutputWriter.WriteLine()

            OutputWriter.WriteLine("Normal Hours: " & NormalTime)
            OutputWriter.WriteLine("Overtime Hours: " & OverTime)

            'clear variables
            HoursInWeek = 0
            NormalTime = 0
            OverTime = 0

            'reset variables
            NormalTime = 0
            OverTime = 0
            OutputWriter.WriteLine() 'skip a line
        Next

        OutputWriter.WriteLine()
        OutputWriter.WriteLine("COMMISSIONED ASSOCIATES")
        OutputWriter.WriteLine()


        'output commissioned people
        
        Dim TempCommissioned As String
        Dim CommissionedList As ArrayList = GetListOfNames("commissioned")

        For Each TempCommissioned In CommissionedList
            GetAssociateData(TempCommissioned, CurrentAssociate)
            OutputWriter.WriteLine(CurrentAssociate.Name)
            OutputWriter.WriteLine(CurrentAssociate.Social)
            OutputWriter.WriteLine("SALARY")
            OutputWriter.WriteLine("COMMISSION")
            OutputWriter.WriteLine()
        Next


        OutputWriter.WriteLine()
        OutputWriter.WriteLine("MANAGER ASSOCIATES")
        OutputWriter.WriteLine()

        'output manager associates
        Dim TempManager As String
        Dim ManagerList As ArrayList = GetListOfNames("manager")

        For Each TempManager In ManagerList
            GetAssociateData(TempManager, CurrentAssociate)
            OutputWriter.WriteLine(CurrentAssociate.Name)
            OutputWriter.WriteLine(CurrentAssociate.Social)
            OutputWriter.WriteLine("SALARY")
            OutputWriter.WriteLine()
        Next

        'close output file
        OutputWriter.Close()
        OutputFileStream.Close()

        'print main report
        Dim typeStreamReader As New System.IO.StreamReader("c:\time tracker\TIME TRACKING REPORT.txt")
        Me.TextToPrintTextBox.Text = typeStreamReader.ReadToEnd
        typeStreamReader.Close()


        AddHandler PrintDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf PrintPage)

        If PrintON = True Then
            PrintDocument1.Print()
        End If

        'clear text box
        TextToPrintTextBox.Text = ""

        'print managers comments
        Dim ManagerReader As New System.IO.StreamReader("c:\time tracker\managers comments.txt")
        Me.TextToPrintTextBox.Text = "Managers Comments" & vbCrLf & vbCrLf & ManagerReader.ReadToEnd
        ManagerReader.Close()

        AddHandler PrintDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf PrintPage)
        If PrintON = True Then
            PrintDocument1.Print()
        End If
        'clear text box
        TextToPrintTextBox.Text = ""

        'print MISC comments
        Dim MISCReader As New System.IO.StreamReader("c:\time tracker\MISC comments.txt")
        Me.TextToPrintTextBox.Text = "MISC Comments" & vbCrLf & vbCrLf & MISCReader.ReadToEnd
        MISCReader.Close()

        AddHandler PrintDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf PrintPage)
        If PrintON = True Then
            PrintDocument1.Print()
        End If
        'clear text box
        TextToPrintTextBox.Text = ""


        If ErrorInReport = False Then
            MsgBox("Report created successfully!")
        Else
            MsgBox("Report created, but with errors!")
            Dim TempError As String
            For Each TempError In ErrorInAssociates
                MsgBox("Error in " & TempError)
            Next
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim Response As String

        Dim CurrentAssociate As String

        Response = MsgBox("This will clear ALL data?  Do you want to proceed?", MsgBoxStyle.YesNo)
        If Response = vbYes Then
            'open list of employee files to clear
            Dim TimedAssociatesStream As New System.IO.FileStream("c:\time tracker\timed associates.txt", System.IO.FileMode.Open)
            Dim TimedAssociatesReader As New System.IO.StreamReader(TimedAssociatesStream)

            CurrentAssociate = TimedAssociatesReader.ReadLine
            While Not CurrentAssociate Is Nothing
                'clear the file
                Dim AssociateFileToClear As New System.IO.FileStream("c:\time tracker\associates\" & CurrentAssociate & ".txt", System.IO.FileMode.Truncate)
                Dim AssociateFileWriter As New System.IO.StreamReader(AssociateFileToClear)
                'close the cleared file
                AssociateFileWriter.Close()
                AssociateFileToClear.Close()
                CurrentAssociate = TimedAssociatesReader.ReadLine

            End While

            'clear managers comments
            'clear the file
            Dim FileToClear As New System.IO.FileStream("c:\time tracker\managers comments.txt", System.IO.FileMode.Truncate)
            Dim FileWriter As New System.IO.StreamReader(FileToClear)
            'close the cleared file
            FileWriter.Close()
            FileToClear.Close()

            'clear output

            'clear the file
            Dim OutputFileToClear As New System.IO.FileStream("c:\time tracker\time tracking report.txt", System.IO.FileMode.Truncate)
            Dim OutputFileWriter As New System.IO.StreamReader(OutputFileToClear)
            'close the cleared file
            OutputFileWriter.Close()
            OutputFileToClear.Close()

            'clear misc comments
            Dim MiscFileToClear As New System.IO.FileStream("c:\time tracker\misc comments.txt", System.IO.FileMode.Truncate)
            Dim MiscFileWriter As New System.IO.StreamReader(MiscFileToClear)
            'close the cleared file
            MiscFileWriter.Close()
            MiscFileToClear.Close()
            MsgBox("Data sucessfully cleared.")
        Else
            MsgBox("You chose not to clear the data.")
        End If

    End Sub

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        'Process.Start("c:\time tracker\associates")
        Dim newfrmFixFile As New frmFixFile()
        newfrmFixFile.Show()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100
        Me.Close()

    End Sub


    Private Sub btnComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComment.Click
        Dim myFileStream As New System.IO.FileStream("c:\time tracker\managers comments.txt", System.IO.FileMode.Append)
        Dim myWriter As New System.IO.StreamWriter(myFileStream)

        Dim Comment As String
        Comment = InputBox("What is your comment?", "Managers Comment")
        If Not Comment Is Nothing Then
            myWriter.WriteLine(AssociateSittingAtComputer.Name & " " & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & vbNewLine & Comment & vbNewLine)
        End If

        myWriter.Close()
        myFileStream.Close()
    End Sub

    Private Sub btnAssignDays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDays.Click
        Dim newfrmSick As New frmSick()
        newfrmSick.Show()
    End Sub

    Private Sub btnEditAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAssociate.Click
        Dim newfrmEditAssociate As New frmEditAssociate()
        newfrmEditAssociate.ShowDialog(Me)
    End Sub

    Private Sub btnMOTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMOTD.Click

        Dim MOTD As String
        MOTD = InputBox("Enter the message of the day. (To have no message, leave this blank)", "Daily Message")

        Dim myFileStream As New System.IO.FileStream("c:\time tracker\MOTD.txt", System.IO.FileMode.Truncate)
        Dim myWriter As New System.IO.StreamWriter(myFileStream)
        If MOTD Is Nothing Then
            GoTo Skip
        End If
        myWriter.Write(MOTD)
Skip:


        myWriter.Close()
        myFileStream.Close()
    End Sub



    Public Sub PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Static lastCharacterPrinted As Int32
        Dim printFont As New Font("Microsoft Sans Serif", 12)

        Dim PrintAreaHeight, PrintAreaWidth, LeftMargin, TopMargin As Int32
        With PrintDocument1.DefaultPageSettings
            PrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            PrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            LeftMargin = .Margins.Left
            TopMargin = .Margins.Top
        End With

        Dim lineCount As Integer = CInt(PrintAreaHeight / Font.Height)
        Dim printArea As New RectangleF(LeftMargin, TopMargin, PrintAreaWidth, PrintAreaHeight)


        Dim printFormat As New StringFormat(StringFormatFlags.LineLimit)

        Dim linesFittedToPage As Integer
        Dim charactersFittedToPage As Integer

        e.Graphics.MeasureString(Mid(Me.TextToPrintTextBox.Text, lastCharacterPrinted + 1), printFont, _
                    New SizeF(PrintAreaWidth, PrintAreaHeight), printFormat, _
                    charactersFittedToPage, linesFittedToPage)

        e.Graphics.DrawString(Mid(Me.TextToPrintTextBox.Text, lastCharacterPrinted + 1), printFont, _
            Brushes.Black, printArea, printFormat)

        lastCharacterPrinted += charactersFittedToPage


        If lastCharacterPrinted < Me.TextToPrintTextBox.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            lastCharacterPrinted = 0
        End If
    End Sub




    Private Sub btnAddAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAssociate.Click
        Dim newfrmAddAssociate As New frmAddAssociate()
        newfrmAddAssociate.ShowDialog(Me)
    End Sub

End Class
