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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbHr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMin As System.Windows.Forms.ComboBox
    Friend WithEvents lstInOut As System.Windows.Forms.ListBox
    Friend WithEvents lstReason As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstAMPM As System.Windows.Forms.ListBox
    Friend WithEvents lstEvents As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteEvent As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstBeforeAfter As System.Windows.Forms.ListBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnZeroTime As System.Windows.Forms.Button
    Friend WithEvents lstZero As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.lstNameSelect = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbHr = New System.Windows.Forms.ComboBox()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstInOut = New System.Windows.Forms.ListBox()
        Me.lstReason = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstAMPM = New System.Windows.Forms.ListBox()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.btnDeleteEvent = New System.Windows.Forms.Button()
        Me.lstBeforeAfter = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnZeroTime = New System.Windows.Forms.Button()
        Me.lstZero = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(496, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Return To Manager's Area"
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.Lime
        Me.btnAssign.Location = New System.Drawing.Point(504, 24)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(88, 40)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.TabStop = False
        Me.btnAssign.Text = "Assign Event"
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Location = New System.Drawing.Point(16, 48)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(200, 212)
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Assign an Event"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select a date:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(160, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Select a Time:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'cmbHr
        '
        Me.cmbHr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbHr.Location = New System.Drawing.Point(168, 80)
        Me.cmbHr.Name = "cmbHr"
        Me.cmbHr.Size = New System.Drawing.Size(48, 21)
        Me.cmbHr.TabIndex = 12
        Me.cmbHr.TabStop = False
        Me.cmbHr.Text = "hr"
        '
        'cmbMin
        '
        Me.cmbMin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMin.Location = New System.Drawing.Point(248, 80)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(56, 21)
        Me.cmbMin.TabIndex = 13
        Me.cmbMin.TabStop = False
        Me.cmbMin.Text = "min"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(352, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Select a Reason:"
        '
        'lstInOut
        '
        Me.lstInOut.Items.AddRange(New Object() {"IN", "OUT"})
        Me.lstInOut.Location = New System.Drawing.Point(352, 72)
        Me.lstInOut.Name = "lstInOut"
        Me.lstInOut.Size = New System.Drawing.Size(32, 30)
        Me.lstInOut.TabIndex = 15
        Me.lstInOut.TabStop = False
        '
        'lstReason
        '
        Me.lstReason.Items.AddRange(New Object() {"DAY", "LUNCH", "MISC"})
        Me.lstReason.Location = New System.Drawing.Point(400, 72)
        Me.lstReason.Name = "lstReason"
        Me.lstReason.Size = New System.Drawing.Size(96, 43)
        Me.lstReason.TabIndex = 16
        Me.lstReason.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(304, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "AM/PM:"
        '
        'lstAMPM
        '
        Me.lstAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.lstAMPM.Location = New System.Drawing.Point(312, 72)
        Me.lstAMPM.Name = "lstAMPM"
        Me.lstAMPM.Size = New System.Drawing.Size(32, 30)
        Me.lstAMPM.TabIndex = 18
        '
        'lstEvents
        '
        Me.lstEvents.Location = New System.Drawing.Point(224, 48)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(264, 212)
        Me.lstEvents.TabIndex = 19
        '
        'btnDeleteEvent
        '
        Me.btnDeleteEvent.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.btnDeleteEvent.Location = New System.Drawing.Point(512, 200)
        Me.btnDeleteEvent.Name = "btnDeleteEvent"
        Me.btnDeleteEvent.Size = New System.Drawing.Size(96, 40)
        Me.btnDeleteEvent.TabIndex = 20
        Me.btnDeleteEvent.Text = "Delete Selected Event"
        '
        'lstBeforeAfter
        '
        Me.lstBeforeAfter.Items.AddRange(New Object() {"Before", "After"})
        Me.lstBeforeAfter.Location = New System.Drawing.Point(176, 24)
        Me.lstBeforeAfter.Name = "lstBeforeAfter"
        Me.lstBeforeAfter.Size = New System.Drawing.Size(48, 30)
        Me.lstBeforeAfter.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(232, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "the selected event"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCheck.ForeColor = System.Drawing.Color.Black
        Me.btnCheck.Location = New System.Drawing.Point(512, 120)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(96, 40)
        Me.btnCheck.TabIndex = 24
        Me.btnCheck.Text = "Check Data for Errors"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Magenta
        Me.btnEdit.Location = New System.Drawing.Point(504, 72)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 40)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit Event"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(48, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 23)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Assign a zero time after the selected event"
        '
        'btnZeroTime
        '
        Me.btnZeroTime.BackColor = System.Drawing.Color.Aqua
        Me.btnZeroTime.Location = New System.Drawing.Point(368, 16)
        Me.btnZeroTime.Name = "btnZeroTime"
        Me.btnZeroTime.Size = New System.Drawing.Size(75, 32)
        Me.btnZeroTime.TabIndex = 27
        Me.btnZeroTime.Text = "Assign Zero Time Event!"
        '
        'lstZero
        '
        Me.lstZero.Items.AddRange(New Object() {"LUNCH", "MISC"})
        Me.lstZero.Location = New System.Drawing.Point(288, 16)
        Me.lstZero.Name = "lstZero"
        Me.lstZero.Size = New System.Drawing.Size(56, 30)
        Me.lstZero.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.cmbHr, Me.Label4, Me.lstAMPM, Me.lstBeforeAfter, Me.DateTimePicker1, Me.Label3, Me.Label9, Me.lstInOut, Me.cmbMin, Me.Label5, Me.lstReason, Me.Label6, Me.btnEdit, Me.btnAssign, Me.Label7})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 120)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assign/Edit Event"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnZeroTime, Me.Label10, Me.lstZero})
        Me.GroupBox2.Location = New System.Drawing.Point(32, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zero Time Assignment"
        '
        'frmFixFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(622, 459)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnCheck, Me.btnDeleteEvent, Me.lstEvents, Me.Label2, Me.Label1, Me.lstNameSelect, Me.btnClose, Me.GroupBox2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFixFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix an Associates File"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmFixFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim TempString(2) As String
        Dim AssociateToAdd As String

        For Each AssociateToAdd In GetListOfNames("timed")
            lstNameSelect.Items.Add(AssociateToAdd)
        Next

    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        lstEvents.Items.Clear()

        If lstNameSelect.SelectedIndex <> -1 Then
            Dim EditStream As New System.IO.FileStream("c:\Time Tracker\associates\" & lstNameSelect.SelectedItem & ".txt", System.IO.FileMode.Open)
            Dim EditReader As New System.IO.StreamReader(EditStream)

            Dim CurrentLine As String

            CurrentLine = EditReader.ReadLine

            Do While Not CurrentLine Is Nothing
                lstEvents.Items.Add(CurrentLine)
                CurrentLine = EditReader.ReadLine
            Loop

            EditReader.Close()
            EditStream.Close()


        End If
    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        Dim CorrectionFactor As String
        If lstBeforeAfter.SelectedIndex = 0 Then
            CorrectionFactor = 0
        ElseIf lstBeforeAfter.SelectedIndex = 1 Then
            CorrectionFactor = 1
        Else
            GoTo BlankField
        End If

        'if all the fields have been selected
        If cmbHr.SelectedIndex <> -1 And cmbMin.SelectedIndex <> -1 And lstInOut.SelectedIndex <> -1 And lstReason.SelectedIndex <> -1 And lstNameSelect.SelectedIndex <> -1 Then

            Dim EditWriteStream As New System.IO.FileStream("c:\Time Tracker\associates\" & lstNameSelect.SelectedItem & ".txt", System.IO.FileMode.Create)
            Dim EditWriteWriter As New System.IO.StreamWriter(EditWriteStream)
            Dim NewLine As String
            NewLine = DateTimePicker1.Value.ToShortDateString & " " & cmbHr.SelectedItem & ":" & cmbMin.SelectedItem & " " & lstAMPM.SelectedItem & " PUNCH " & lstInOut.SelectedItem & " " & lstReason.SelectedItem

            lstEvents.Items.Insert(lstEvents.SelectedIndex + CorrectionFactor, NewLine)

            Dim index As Integer = 0

            Do While index < lstEvents.Items.Count
                EditWriteWriter.WriteLine(lstEvents.Items.Item(index))
                index = index + 1
            Loop

            EditWriteWriter.Close()
            EditWriteStream.Close()
        Else
BlankField:
            MsgBox("Please fill out all the requsted fields.")
        End If
        lstEvents.SelectedIndex = -1

    End Sub

    Private Sub btnDeleteEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteEvent.Click

        lstEvents.Items.RemoveAt(lstEvents.SelectedIndex)

        Dim EditWriteStream As New System.IO.FileStream("c:\Time Tracker\associates\" & lstNameSelect.SelectedItem & ".txt", System.IO.FileMode.Create)
        Dim EditWriteWriter As New System.IO.StreamWriter(EditWriteStream)

        Dim index As Integer = 0

        Do While index < lstEvents.Items.Count
            EditWriteWriter.WriteLine(lstEvents.Items.Item(index))
            index = index + 1
        Loop

        EditWriteWriter.Close()
        EditWriteStream.Close()

    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        Dim Counter As Integer = 0
        Dim CurrentLine As String
        Dim StringSplitter(2) As String
        Dim NumLines As Integer

        NumLines = lstEvents.Items.Count
        Dim SetOfEvents(NumLines) As String
        For Counter = 0 To NumLines - 1
            CurrentLine = lstEvents.Items.Item(Counter)
            StringSplitter = Split(CurrentLine, " PUNCH ")
            SetOfEvents(Counter) = StringSplitter(1)
        Next

        If EC = True Then
            For Counter = 0 To NumLines - 1
                MsgBox(SetOfEvents(Counter))
            Next
        End If

        Dim ProblemLine As Integer
        ProblemLine = CheckTimeFile(SetOfEvents, NumLines)

        If EC = True Then
            MsgBox("Problem line is: " & ProblemLine)
        End If

        If Not ProblemLine = 100 Then
            Dim i As Integer = 0
            For i = ProblemLine To NumLines - 1

                lstEvents.SelectedIndex = ProblemLine

            Next
        Else
            MsgBox("The file appears to have no errors!")
        End If

    End Sub

    Private Sub lstEvents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEvents.SelectedIndexChanged
        If lstEvents.SelectedIndex >= 0 Then
            Dim FullLine As String
            FullLine = lstEvents.SelectedItem
            Dim SplitString(6) As String

            Dim LineDate As String
            Dim LineTime As String
            Dim LineAMPM As String
            Dim LinePUNCH As String
            Dim LineINOUT As String
            Dim LineREASON As String

            SplitString = Split(FullLine, " ")
            LineDate = SplitString(0)
            LineTime = SplitString(1)
            LineAMPM = SplitString(2)
            LinePUNCH = SplitString(3)
            LineINOUT = SplitString(4)
            LineREASON = SplitString(5)

            Dim ConvertDate As System.DateTime
            ConvertDate = LineDate

            DateTimePicker1.Value = ConvertDate

            Dim TimeSplitString(2) As String
            TimeSplitString = Split(LineTime, ":")

            cmbHr.SelectedItem = TimeSplitString(0)
            cmbMin.SelectedItem = TimeSplitString(1)

            lstAMPM.SelectedItem = LineAMPM

            lstInOut.SelectedItem = LineINOUT
            lstReason.SelectedItem = LineREASON
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If cmbHr.SelectedIndex <> -1 And cmbMin.SelectedIndex <> -1 And lstInOut.SelectedIndex <> -1 And lstReason.SelectedIndex <> -1 And lstNameSelect.SelectedIndex <> -1 Then

            Dim LineToReplace As Integer
            LineToReplace = lstEvents.SelectedIndex
            lstEvents.Items.RemoveAt(LineToReplace)
            lstEvents.Update()

            Dim EditWriteStream As New System.IO.FileStream("c:\Time Tracker\associates\" & lstNameSelect.SelectedItem & ".txt", System.IO.FileMode.Create)
            Dim EditWriteWriter As New System.IO.StreamWriter(EditWriteStream)

            Dim UpdatedLine As String
            UpdatedLine = DateTimePicker1.Value.ToShortDateString & " " & cmbHr.SelectedItem & ":" & cmbMin.SelectedItem & " " & lstAMPM.SelectedItem & " PUNCH " & lstInOut.SelectedItem & " " & lstReason.SelectedItem

            lstEvents.Items.Insert(LineToReplace, UpdatedLine)

            Dim index As Integer = 0

            Do While index < lstEvents.Items.Count
                EditWriteWriter.WriteLine(lstEvents.Items.Item(index))
                index = index + 1
            Loop

            EditWriteWriter.Close()
            EditWriteStream.Close()
        Else
            MsgBox("Please fill out all the requsted fields.")
        End If

    End Sub

    Private Sub btnZeroTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZeroTime.Click
        If lstZero.SelectedIndex = -1 Then
            MsgBox("Please select which event to add zero time for.")
        Else
            Dim CorrectionFactor As String = 1 'to add the zero event AFTER the selected event

            Dim GetSelectedDate As String = lstEvents.SelectedItem
            Dim StringSplit(6) As String
            StringSplit = Split(GetSelectedDate, " ")
            Dim SelectedDate As System.DateTime = StringSplit(0)
            CorrectionFactor = 1

            Dim EditWriteStream As New System.IO.FileStream("c:\Time Tracker\associates\" & lstNameSelect.SelectedItem & ".txt", System.IO.FileMode.Create)
            Dim EditWriteWriter As New System.IO.StreamWriter(EditWriteStream)
            Dim NewLine1 As String = SelectedDate.ToShortDateString & " " & "11:00 AM PUNCH OUT " & lstZero.SelectedItem
            Dim NewLine2 As String = SelectedDate.ToShortDateString & " " & "11:00 AM PUNCH IN " & lstZero.SelectedItem
            lstEvents.Items.Insert(lstEvents.SelectedIndex + CorrectionFactor, NewLine1)
            lstEvents.Items.Insert(lstEvents.SelectedIndex + CorrectionFactor + 1, NewLine2)

            Dim index As Integer = 0

            Do While index < lstEvents.Items.Count
                EditWriteWriter.WriteLine(lstEvents.Items.Item(index))
                index = index + 1
            Loop

            EditWriteWriter.Close()
            EditWriteStream.Close()

            lstZero.SelectedIndex = -1

        End If
    End Sub
End Class
