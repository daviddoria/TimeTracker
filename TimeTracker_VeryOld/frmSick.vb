Public Class frmSick
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
    Friend WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents btnSick As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVacation As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnHoliday As System.Windows.Forms.Button
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblSickHours As System.Windows.Forms.Label
    Friend WithEvents lblVacHours As System.Windows.Forms.Label
    Friend WithEvents HolidayPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHolidaySelect As System.Windows.Forms.Label
    Friend WithEvents btnHolidayAssign As System.Windows.Forms.Button
    Friend WithEvents lstHalfWhole As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectHours As System.Windows.Forms.Label
    Friend WithEvents btnAssignSick As System.Windows.Forms.Button
    Friend WithEvents btnAssignVacation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstNameSelect = New System.Windows.Forms.ListBox()
        Me.btnSick = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVacation = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblSickHours = New System.Windows.Forms.Label()
        Me.lblVacHours = New System.Windows.Forms.Label()
        Me.HolidayPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblHolidaySelect = New System.Windows.Forms.Label()
        Me.btnHolidayAssign = New System.Windows.Forms.Button()
        Me.lstHalfWhole = New System.Windows.Forms.ListBox()
        Me.lblSelectHours = New System.Windows.Forms.Label()
        Me.btnAssignSick = New System.Windows.Forms.Button()
        Me.btnAssignVacation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNameSelect.ItemHeight = 25
        Me.lstNameSelect.Location = New System.Drawing.Point(16, 48)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(248, 379)
        Me.lstNameSelect.TabIndex = 0
        Me.lstNameSelect.TabStop = False
        '
        'btnSick
        '
        Me.btnSick.BackColor = System.Drawing.Color.Lime
        Me.btnSick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSick.Location = New System.Drawing.Point(464, 304)
        Me.btnSick.Name = "btnSick"
        Me.btnSick.Size = New System.Drawing.Size(128, 40)
        Me.btnSick.TabIndex = 1
        Me.btnSick.TabStop = False
        Me.btnSick.Text = "Assign Sick Hours"
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
        'btnVacation
        '
        Me.btnVacation.BackColor = System.Drawing.Color.Aqua
        Me.btnVacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVacation.Location = New System.Drawing.Point(464, 352)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(128, 40)
        Me.btnVacation.TabIndex = 3
        Me.btnVacation.TabStop = False
        Me.btnVacation.Text = "Assign Vacation Hours"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(480, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Back to Managers Area"
        '
        'btnHoliday
        '
        Me.btnHoliday.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.btnHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoliday.Location = New System.Drawing.Point(464, 400)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(128, 40)
        Me.btnHoliday.TabIndex = 8
        Me.btnHoliday.TabStop = False
        Me.btnHoliday.Text = "Assign Everyone a Paid Holiday"
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(272, 64)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(232, 32)
        Me.lbl5.TabIndex = 11
        Me.lbl5.Text = "Sick Hours Remaining: "
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(272, 104)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(280, 32)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Vacation Hours Remaining: "
        '
        'lblSickHours
        '
        Me.lblSickHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSickHours.Location = New System.Drawing.Point(504, 64)
        Me.lblSickHours.Name = "lblSickHours"
        Me.lblSickHours.Size = New System.Drawing.Size(40, 32)
        Me.lblSickHours.TabIndex = 13
        '
        'lblVacHours
        '
        Me.lblVacHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacHours.Location = New System.Drawing.Point(552, 104)
        Me.lblVacHours.Name = "lblVacHours"
        Me.lblVacHours.Size = New System.Drawing.Size(40, 40)
        Me.lblVacHours.TabIndex = 14
        '
        'HolidayPicker
        '
        Me.HolidayPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HolidayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.HolidayPicker.Location = New System.Drawing.Point(448, 176)
        Me.HolidayPicker.Name = "HolidayPicker"
        Me.HolidayPicker.Size = New System.Drawing.Size(152, 31)
        Me.HolidayPicker.TabIndex = 15
        Me.HolidayPicker.Visible = False
        '
        'lblHolidaySelect
        '
        Me.lblHolidaySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidaySelect.Location = New System.Drawing.Point(272, 152)
        Me.lblHolidaySelect.Name = "lblHolidaySelect"
        Me.lblHolidaySelect.Size = New System.Drawing.Size(168, 96)
        Me.lblHolidaySelect.TabIndex = 16
        Me.lblHolidaySelect.Text = "Select a date to assign everyone a holiday:"
        Me.lblHolidaySelect.Visible = False
        '
        'btnHolidayAssign
        '
        Me.btnHolidayAssign.BackColor = System.Drawing.Color.Magenta
        Me.btnHolidayAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHolidayAssign.Location = New System.Drawing.Point(448, 216)
        Me.btnHolidayAssign.Name = "btnHolidayAssign"
        Me.btnHolidayAssign.Size = New System.Drawing.Size(152, 40)
        Me.btnHolidayAssign.TabIndex = 17
        Me.btnHolidayAssign.Text = "Assign Holiday!"
        Me.btnHolidayAssign.Visible = False
        '
        'lstHalfWhole
        '
        Me.lstHalfWhole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHalfWhole.ItemHeight = 25
        Me.lstHalfWhole.Items.AddRange(New Object() {"4", "8"})
        Me.lstHalfWhole.Location = New System.Drawing.Point(496, 160)
        Me.lstHalfWhole.Name = "lstHalfWhole"
        Me.lstHalfWhole.Size = New System.Drawing.Size(40, 54)
        Me.lstHalfWhole.TabIndex = 18
        Me.lstHalfWhole.Visible = False
        '
        'lblSelectHours
        '
        Me.lblSelectHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectHours.Location = New System.Drawing.Point(304, 152)
        Me.lblSelectHours.Name = "lblSelectHours"
        Me.lblSelectHours.Size = New System.Drawing.Size(160, 80)
        Me.lblSelectHours.TabIndex = 19
        Me.lblSelectHours.Text = "Select the number of hours:"
        Me.lblSelectHours.Visible = False
        '
        'btnAssignSick
        '
        Me.btnAssignSick.BackColor = System.Drawing.Color.Magenta
        Me.btnAssignSick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignSick.Location = New System.Drawing.Point(448, 224)
        Me.btnAssignSick.Name = "btnAssignSick"
        Me.btnAssignSick.Size = New System.Drawing.Size(152, 40)
        Me.btnAssignSick.TabIndex = 20
        Me.btnAssignSick.Text = "Assign Sick Time"
        Me.btnAssignSick.Visible = False
        '
        'btnAssignVacation
        '
        Me.btnAssignVacation.BackColor = System.Drawing.Color.Magenta
        Me.btnAssignVacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignVacation.Location = New System.Drawing.Point(448, 232)
        Me.btnAssignVacation.Name = "btnAssignVacation"
        Me.btnAssignVacation.Size = New System.Drawing.Size(152, 40)
        Me.btnAssignVacation.TabIndex = 21
        Me.btnAssignVacation.Text = "Assign Vacation Time!"
        Me.btnAssignVacation.Visible = False
        '
        'frmSick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 446)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAssignVacation, Me.btnAssignSick, Me.lstHalfWhole, Me.btnHolidayAssign, Me.HolidayPicker, Me.lblVacHours, Me.lblSickHours, Me.label6, Me.lbl5, Me.btnHoliday, Me.btnClose, Me.btnVacation, Me.Label1, Me.btnSick, Me.lstNameSelect, Me.lblSelectHours, Me.lblHolidaySelect})
        Me.Name = "frmSick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sick/Vacation/Holiday Assignment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AssociateToAdd As String

        For Each AssociateToAdd In GetListOfNames("all")
            lstNameSelect.Items.Add(AssociateToAdd)
        Next

    End Sub

    Private Sub btnSick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSick.Click
        'show stuff we want
        lblSelectHours.Visible = True
        lstHalfWhole.Visible = True
        btnAssignSick.Visible = True

        'hide everything else
        lblHolidaySelect.Visible = False
        HolidayPicker.Visible = False
        btnAssignVacation.Visible = False
        btnHolidayAssign.Visible = False
    End Sub



    Private Sub btnVacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVacation.Click
        'show what we want
        lblSelectHours.Visible = True
        lstHalfWhole.Visible = True
        btnAssignVacation.Visible = True

        'hide everything else
        lblHolidaySelect.Visible = False
        HolidayPicker.Visible = False
        btnAssignSick.Visible = False
        btnHolidayAssign.Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnHoliday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoliday.Click
        'show what we want
        HolidayPicker.Visible = True
        lblHolidaySelect.Visible = True
        btnHolidayAssign.Visible = True

        'hide everything else
        lblSelectHours.Visible = False
        lstHalfWhole.Visible = False
        btnAssignVacation.Visible = False
        btnAssignSick.Visible = False

    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        If Not lstNameSelect.SelectedItem Is Nothing Then

            If GetAssociateData(lstNameSelect.SelectedItem, EditAssociate) = False Then
                MsgBox("There was an error in the associates data file.")
            End If

        End If

    End Sub

    Private Sub btnHolidayAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHolidayAssign.Click

        Dim HolidayDate As System.DateTime
        HolidayDate = HolidayPicker.Value.ToShortDateString

        Dim HolidayAssociatesStream As New System.IO.FileStream("c:\time tracker\timed associates.txt", System.IO.FileMode.Open)
        Dim HolidayAssociatesReader As New System.IO.StreamReader(HolidayAssociatesStream)
        Dim CurrentAssociate As String


        CurrentAssociate = HolidayAssociatesReader.ReadLine
        While Not CurrentAssociate Is Nothing
            'clear the file
            Dim HolidayStream As New System.IO.FileStream("c:\time tracker\associates\" & CurrentAssociate & ".txt", System.IO.FileMode.Append)
            Dim HolidayWriter As New System.IO.StreamWriter(HolidayStream)
            HolidayWriter.WriteLine(HolidayDate & " 8:00 AM PUNCH IN DAY")
            HolidayWriter.WriteLine(HolidayDate & " 11:00 AM PUNCH OUT LUNCH")
            HolidayWriter.WriteLine(HolidayDate & " 11:00 AM PUNCH IN LUCNH")
            HolidayWriter.WriteLine(HolidayDate & " 11:30 AM PUNCH OUT MISC")
            HolidayWriter.WriteLine(HolidayDate & " 12:30 PM PUNCH IN MISC")
            HolidayWriter.WriteLine(HolidayDate & " 5:00 PM PUNCH OUT DAY")
            HolidayWriter.Close()
            HolidayStream.Close()
            CurrentAssociate = HolidayAssociatesReader.ReadLine

        End While

        MsgBox("Holiday has been assigned successfully!")
        HolidayPicker.Visible = False
        lblHolidaySelect.Visible = False
        btnHolidayAssign.Visible = False
    End Sub

    Private Sub btnAssignVacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignVacation.Click

        If lstHalfWhole.SelectedIndex = -1 Then
            MsgBox("Please select the number of hours.")
            GoTo EndOfAssignVacation
        End If

        Dim SelectedNumber As Integer = 0

        SelectedNumber = lstHalfWhole.SelectedItem

        EditAssociate.VacationHours = EditAssociate.VacationHours - SelectedNumber

        If EditAssociate.VacationHours < 0 Then
            MsgBox("This associate doesn't have enough hours left to take this amount of time off.  Nothing will be subtracted.")
            EditAssociate.VacationHours = EditAssociate.VacationHours + SelectedNumber
            GoTo NoChange
        End If

        'if we get to here they have enough time left to take the assigned time away

        If SelectedNumber = 8 Then

            Dim myFileStream As New System.IO.FileStream("c:\Time Tracker\associates\" & EditAssociate.FileName, System.IO.FileMode.Append)
            Dim myWriter As New System.IO.StreamWriter(myFileStream)

            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 8:00 AM PUNCH IN DAY")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:00 AM PUNCH OUT LUNCH")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:00 AM PUNCH IN LUNCH")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:30 AM PUNCH OUT MISC")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:30 AM PUNCH IN MISC")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 4:00 PM PUNCH OUT DAY")

            myWriter.Close()
            myFileStream.Close()

            MsgBox("A full day of vacation time has been assigned.")

        End If

        If SelectedNumber = 4 Then 'write this in the managers log

            Dim myFileStream As New System.IO.FileStream("c:\time tracker\managers comments.txt", System.IO.FileMode.Append)
            Dim myWriter As New System.IO.StreamWriter(myFileStream)

            myWriter.WriteLine(EditAssociate.Name & " " & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & vbNewLine & lstNameSelect.SelectedItem & " took 4 hours of sick time" & vbNewLine)

            myWriter.Close()
            myFileStream.Close()

            MsgBox("A half day of vacation time has been assigned.")

        End If

        'update their file
        UpdateDataFile(EditAssociate)

NoChange:

        lblSelectHours.Visible = False
        lstHalfWhole.Visible = False
        btnAssignVacation.Visible = False

EndOfAssignVacation:
    End Sub

    Private Sub btnAssignSick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignSick.Click

        If lstHalfWhole.SelectedIndex = -1 Then
            MsgBox("Please select the number of hours.")
            GoTo EndOfAssignSick
        End If

        Dim SelectedNumber As Integer = 0

        SelectedNumber = lstHalfWhole.SelectedItem

        EditAssociate.SickHours = EditAssociate.SickHours - SelectedNumber

        If EditAssociate.SickHours < 0 Then
            MsgBox("This associate doesn't have enough hours left to take this amount of time off.  Nothing will be subtracted.")
            EditAssociate.SickHours = EditAssociate.SickHours + SelectedNumber
            GoTo NoChange
        End If

        'if we get to here they have enough time left to take the assigned time away

        If SelectedNumber = 8 Then

            Dim myFileStream As New System.IO.FileStream("c:\Time Tracker\associates\" & EditAssociate.FileName, System.IO.FileMode.Append)
            Dim myWriter As New System.IO.StreamWriter(myFileStream)

            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 8:00 AM PUNCH IN DAY")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:00 AM PUNCH OUT LUNCH")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:00 AM PUNCH IN LUNCH")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:30 AM PUNCH OUT MISC")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 11:30 AM PUNCH IN MISC")
            myWriter.WriteLine(DateTime.Now.ToShortDateString() & " 4:00 PM PUNCH OUT DAY")

            myWriter.Close()
            myFileStream.Close()

            MsgBox("A full day of sick time has been assigned.")

        End If

        If SelectedNumber = 4 Then 'write this in the managers log

            Dim myFileStream As New System.IO.FileStream("c:\time tracker\managers comments.txt", System.IO.FileMode.Append)
            Dim myWriter As New System.IO.StreamWriter(myFileStream)

            myWriter.WriteLine(EditAssociate.Name & " " & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & vbNewLine & lstNameSelect.SelectedItem & " took 4 hours of sick time" & vbNewLine)

            myWriter.Close()
            myFileStream.Close()

            MsgBox("A half day of sick time has been assigned.")

        End If

        'update their file
        UpdateDataFile(EditAssociate)

NoChange:

        lblSelectHours.Visible = False
        lstHalfWhole.Visible = False
        btnAssignSick.Visible = False

EndOfAssignSick:


    End Sub
End Class
