
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssociate))
        Me.btnPunchOut = New System.Windows.Forms.Button
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblTimeIs = New System.Windows.Forms.Label
        Me.btnPunchIn = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstReasonIn = New System.Windows.Forms.ListBox
        Me.lstReasonOut = New System.Windows.Forms.ListBox
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblLastEvent = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.btnPunchOut.Location = New System.Drawing.Point(24, 104)
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
        Me.btnPunchIn.Location = New System.Drawing.Point(24, 104)
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
        Me.lstReasonIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReasonIn.ItemHeight = 16
        Me.lstReasonIn.Items.AddRange(New Object() {"For the day", "From lunch", "From a misc.", "From Smoking"})
        Me.lstReasonIn.Location = New System.Drawing.Point(8, 24)
        Me.lstReasonIn.Name = "lstReasonIn"
        Me.lstReasonIn.Size = New System.Drawing.Size(112, 68)
        Me.lstReasonIn.TabIndex = 20
        Me.lstReasonIn.TabStop = False
        '
        'lstReasonOut
        '
        Me.lstReasonOut.ItemHeight = 16
        Me.lstReasonOut.Items.AddRange(New Object() {"For the day", "To lunch", "To a misc.", "To Smoke"})
        Me.lstReasonOut.Location = New System.Drawing.Point(16, 24)
        Me.lstReasonOut.Name = "lstReasonOut"
        Me.lstReasonOut.Size = New System.Drawing.Size(96, 68)
        Me.lstReasonOut.TabIndex = 21
        Me.lstReasonOut.TabStop = False
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.LightBlue
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(360, 256)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(176, 48)
        Me.btnGoBack.TabIndex = 24
        Me.btnGoBack.TabStop = False
        Me.btnGoBack.Text = "Do nothing and go back to login."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstReasonOut)
        Me.GroupBox1.Controls.Add(Me.btnPunchOut)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(72, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 136)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reason Out:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstReasonIn)
        Me.GroupBox2.Controls.Add(Me.btnPunchIn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(80, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 136)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reason In:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 32)
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 192)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(312, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 192)
        Me.Panel2.TabIndex = 32
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lblLastEvent)
        Me.GroupBox5.Controls.Add(Me.lblTimeIs)
        Me.GroupBox5.Controls.Add(Me.lblTime)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 336)
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
        Me.Label4.Location = New System.Drawing.Point(80, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 80)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Do you want to return to the previous screen without logging an event?"
        '
        'frmAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnGoBack)
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
    Public LastReason As String
    Public LastEventNumber As Integer
    Public NumPreviousEvents As Integer
    Public PreviousEvents As New DataSet
    Public DatabaseConnection As New OleDb.OleDbConnection
    Public MyDA As OleDb.OleDbDataAdapter

    Private Sub btnPunchIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchIn.Click

        Dim ReasonIN As String ' used to decide which event is happening

        'make sure they selected a reason
        If lstReasonIn.SelectedIndex = -1 Then 'if nothing is selected
            MsgBox("Please select a reason.") ' show an error
            Me.Close() 'quit
        End If

        'convert reason to one word reason
        ReasonIN = ToShortReason(lstReasonIn.SelectedItem)

        'make sure they punched out to whatever they are punching in from
        If Not ReasonIN = LastReason Then
            MsgBox("You didn't punch out to " + ReasonIN + "!  Please get a manager!")
            lstReasonIn.SelectedIndex = -1
            Exit Sub
        End If

        Dim CurrentEventNumber As Integer
        If ReasonIN = "DAY" Then
            CurrentEventNumber = 1
        Else
            CurrentEventNumber = LastEventNumber + 1
        End If

        'if we get to here, then open the database and write to it
        'declare database
        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource
        DatabaseConnection.Open()
        Dim PunchInDataSet As New DataSet
        Dim PunchInDataAdapter As OleDb.OleDbDataAdapter

        'create dataset
        Dim Query As String
        Query = "SELECT * FROM event"

        'setup new row and add it
        Dim PunchInNewRow As DataRow
        PunchInNewRow = PunchInDataSet.Tables("event").NewRow()
        'add all the attributes to the new row
        PunchInNewRow.Item("associate") = AssociateLoggedIn.Name
        PunchInNewRow.Item("Date") = System.DateTime.Now.ToShortDateString
        PunchInNewRow.Item("time") = System.DateTime.Now.ToShortTimeString
        PunchInNewRow.Item("eventNumber") = CurrentEventNumber
        PunchInNewRow.Item("reason") = ReasonIN
        PunchInDataSet.Tables("event").Rows.Add(PunchInNewRow)
        PunchInDataAdapter.Update(PunchInDataSet)
        'close the database
        DatabaseConnection.Close()


        'handle visual effects
        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100

        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'update the clock displayed
        lblTime.Text() = DateTime.Now.ToShortTimeString()

    End Sub

    Private Sub btnPunchOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchOut.Click

        Dim ReasonOUT As String

        'if nothing selected
        If lstReasonOut.SelectedIndex = -1 Then
            MsgBox("Please select a reason.")
            Exit Sub
        End If

        'convert reason to one word reason
        ReasonOUT = ToShortReason(lstReasonOut.SelectedItem)

        If LastEventNumber Mod 2 = 0 And LastEventNumber >= 1 Then
            MsgBox("You cannot punch out while you are already out!")
            Exit Sub
        End If

        'when they logout for the day give them their stats
        If ReasonOUT = "DAY" Then
            MsgBox("Today you worked " & CalculateHoursInDay(System.DateTime.Now.ToShortDateString, AssociateLoggedIn.Name) & " hours.  If this is not correct please see a manager.")
        End If

        'if we get to here, then open the database and write to it
        'declare database
        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource
        DatabaseConnection.Open()
        Dim PunchInDataSet As New DataSet
        Dim PunchInDataAdapter As OleDb.OleDbDataAdapter

        'create dataset
        Dim Query As String
        Query = "SELECT * FROM event"

        'setup new row and add it
        Dim PunchInNewRow As DataRow
        PunchInNewRow = PunchInDataSet.Tables("event").NewRow()
        'add all the attributes to the new row
        PunchInNewRow.Item("associate") = AssociateLoggedIn.Name
        PunchInNewRow.Item("Date") = System.DateTime.Now.ToShortDateString
        PunchInNewRow.Item("time") = System.DateTime.Now.ToShortTimeString
        PunchInNewRow.Item("eventNumber") = LastEventNumber + 1
        PunchInNewRow.Item("reason") = ReasonOUT
        PunchInDataSet.Tables("event").Rows.Add(PunchInNewRow)
        PunchInDataAdapter.Update(PunchInDataSet)
        DatabaseConnection.Close() 'close the database

        'tell them their time at the end of the week

        Dim i As Integer = -6
        Dim WeekHours As Double = 0
        Dim Overtime As Double = 0

        While i < 1 ' go until current day
            WeekHours += CalculateHoursInDay(System.DateTime.Now.AddDays(-6).ToShortDateString(), AssociateLoggedIn.Name)
            i = i + 1
        End While


        'check for overtime
        If WeekHours > 40 Then
            Overtime = FormatNumber(WeekHours - 40, 2)
            WeekHours = 40
        Else
            Overtime = 0
            WeekHours = FormatNumber(WeekHours, 2)
        End If


        MsgBox("This week you worked " & WeekHours & " normal hours and " & Overtime & " overtime hours.")

        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100
        Me.Close()

    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click

        'handle form appearances
        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100

        Me.Close() '"quit"
    End Sub


    Private Sub frmAssociate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'open the database and read previous events
        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " + DatabaseSource
        DatabaseConnection.Open()

        'prepare to read from database
        Dim Query As String
        Query = "SELECT * FROM event where associate='" + AssociateLoggedIn.Name + "' order by date"
        MyDA = New OleDb.OleDbDataAdapter(Query, DatabaseConnection)
        MyDA.Fill(PreviousEvents, "event")

        'get last event
        NumPreviousEvents = PreviousEvents.Tables("event").Rows.Count() 'see how many events there are

        LastReason = PreviousEvents.Tables("event").Rows(NumPreviousEvents - 1).Item("reason") '-1 is to account for starting at 0
        LastEventNumber = PreviousEvents.Tables("event").Rows(NumPreviousEvents - 1).Item("eventnumber") '-1 is to account for starting at 0

        DatabaseConnection.Close() 'close the database


    End Sub


End Class
