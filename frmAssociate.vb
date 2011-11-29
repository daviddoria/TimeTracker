Imports System.Collections.Generic

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
    Friend WithEvents btnPunchOut As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTimeIs As System.Windows.Forms.Label
    Friend WithEvents lstReasonOut As System.Windows.Forms.ListBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastEventType As System.Windows.Forms.Label
    Friend WithEvents lblLastEventTime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLastEventDirection As System.Windows.Forms.Label
    Friend WithEvents grpReasonOut As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssociate))
        Me.btnPunchOut = New System.Windows.Forms.Button
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblTimeIs = New System.Windows.Forms.Label
        Me.lstReasonOut = New System.Windows.Forms.ListBox
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.grpReasonOut = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastEventType = New System.Windows.Forms.Label
        Me.lblLastEventTime = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblLastEventDirection = New System.Windows.Forms.Label
        Me.grpReasonOut.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPunchOut
        '
        Me.btnPunchOut.BackColor = System.Drawing.Color.Red
        Me.btnPunchOut.Enabled = False
        Me.btnPunchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunchOut.ForeColor = System.Drawing.Color.Black
        Me.btnPunchOut.Location = New System.Drawing.Point(54, 130)
        Me.btnPunchOut.Name = "btnPunchOut"
        Me.btnPunchOut.Size = New System.Drawing.Size(101, 49)
        Me.btnPunchOut.TabIndex = 17
        Me.btnPunchOut.TabStop = False
        Me.btnPunchOut.Text = "Punch Out"
        Me.btnPunchOut.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(248, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(144, 24)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "Current time"
        '
        'lblTimeIs
        '
        Me.lblTimeIs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIs.Location = New System.Drawing.Point(25, 9)
        Me.lblTimeIs.Name = "lblTimeIs"
        Me.lblTimeIs.Size = New System.Drawing.Size(221, 25)
        Me.lblTimeIs.TabIndex = 15
        Me.lblTimeIs.Text = "Current Time:"
        Me.lblTimeIs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstReasonOut
        '
        Me.lstReasonOut.BackColor = System.Drawing.Color.White
        Me.lstReasonOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReasonOut.ItemHeight = 24
        Me.lstReasonOut.Items.AddRange(New Object() {"Day", "Lunch", "Break"})
        Me.lstReasonOut.Location = New System.Drawing.Point(34, 34)
        Me.lstReasonOut.Name = "lstReasonOut"
        Me.lstReasonOut.Size = New System.Drawing.Size(150, 76)
        Me.lstReasonOut.TabIndex = 21
        Me.lstReasonOut.TabStop = False
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGoBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.Black
        Me.btnGoBack.Location = New System.Drawing.Point(270, 306)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(114, 32)
        Me.btnGoBack.TabIndex = 24
        Me.btnGoBack.TabStop = False
        Me.btnGoBack.Text = "Back to login."
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'grpReasonOut
        '
        Me.grpReasonOut.Controls.Add(Me.lstReasonOut)
        Me.grpReasonOut.Controls.Add(Me.btnPunchOut)
        Me.grpReasonOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReasonOut.ForeColor = System.Drawing.Color.Red
        Me.grpReasonOut.Location = New System.Drawing.Point(83, 96)
        Me.grpReasonOut.Name = "grpReasonOut"
        Me.grpReasonOut.Size = New System.Drawing.Size(216, 204)
        Me.grpReasonOut.TabIndex = 26
        Me.grpReasonOut.TabStop = False
        Me.grpReasonOut.Text = "Reason Out:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Last Event:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastEventType
        '
        Me.lblLastEventType.AutoSize = True
        Me.lblLastEventType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastEventType.Location = New System.Drawing.Point(298, 34)
        Me.lblLastEventType.Name = "lblLastEventType"
        Me.lblLastEventType.Size = New System.Drawing.Size(68, 29)
        Me.lblLastEventType.TabIndex = 28
        Me.lblLastEventType.Text = "Type"
        '
        'lblLastEventTime
        '
        Me.lblLastEventTime.AutoSize = True
        Me.lblLastEventTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastEventTime.Location = New System.Drawing.Point(248, 63)
        Me.lblLastEventTime.Name = "lblLastEventTime"
        Me.lblLastEventTime.Size = New System.Drawing.Size(69, 29)
        Me.lblLastEventTime.TabIndex = 29
        Me.lblLastEventTime.Text = "Time"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 29)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Time of Last Event:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastEventDirection
        '
        Me.lblLastEventDirection.AutoSize = True
        Me.lblLastEventDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastEventDirection.Location = New System.Drawing.Point(248, 34)
        Me.lblLastEventDirection.Name = "lblLastEventDirection"
        Me.lblLastEventDirection.Size = New System.Drawing.Size(44, 29)
        Me.lblLastEventDirection.TabIndex = 31
        Me.lblLastEventDirection.Text = "Dir"
        '
        'frmAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(408, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLastEventDirection)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLastEventTime)
        Me.Controls.Add(Me.lblLastEventType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.grpReasonOut)
        Me.Controls.Add(Me.lblTimeIs)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAssociate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate's Area"
        Me.grpReasonOut.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'This is so the form cannot be moved.
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub btnPunchOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchOut.Click
        LogClick(sender)

        'Disable the buttons
        btnGoBack.Enabled = False
        btnPunchOut.Enabled = False

        'if nothing is selected...
        If lstReasonOut.SelectedIndex.Equals(-1) Then
            MsgBox("No reason selected!")
            End
        End If

        'make a new event object from the selected event
        Dim ReasonOUT As String = lstReasonOut.SelectedItem.ToString

        Dim CurrentEvent As New PunchEvent
        CurrentEvent.PunchOut(ReasonOUT.GetEventReason)

        'save the event in the database
        AssociateLoggedIn.WriteEvent(CurrentEvent)

        'display the associate's information from the day/week
        frmInfo.ShowDialog()

        'close the Associates Area
        Me.Dispose()

    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        LogClick(sender)
        'close the Associates Area
        Me.Dispose()

    End Sub


    Private Sub frmAssociate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'size the group box
        grpReasonOut.SetBounds(Convert.ToInt32(Me.Size.Width / 2 - grpReasonOut.Size.Width / 2), grpReasonOut.Location.Y, grpReasonOut.Size.Width, grpReasonOut.Size.Height)

        'unselect everything
        lstReasonOut.SelectedIndex = -1

        'display the current time on the form
        lblTime.Text = Now.ToShortTimeString

        'retrieve the associate's last event
        Dim LastEvent As PunchEvent = AssociateLoggedIn.GetLastEvent()

        'display information from the last event on the form
        lblLastEventType.Text = LastEvent.Reason.GetString
        lblLastEventDirection.Text = LastEvent.Direction.GetString
        lblLastEventTime.Text = LastEvent.PunchTime.ToShortTimeString

        'if they have already gone to lunch, do not give that option
        Dim LunchEvents As List(Of PunchEvent) = AssociateLoggedIn.GetEvents(LastEvent.PunchTime.Date, EventReason.LUNCH)
        If LunchEvents.Count = 2 Then
            lstReasonOut.Items.RemoveAt(1)
            'can you remove this by name instead of arbitary "1"?
        End If

    End Sub


    Private Sub lstReasonOut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReasonOut.SelectedIndexChanged
        'when something is selected, enable the PunchOut button
        btnPunchOut.Enabled = True
    End Sub
End Class
