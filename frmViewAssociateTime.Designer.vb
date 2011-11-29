<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAssociateTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstAssociates = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblWeekNormalHours = New System.Windows.Forms.Label
        Me.lblDayTime = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.lblWeekOvertimeHours = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstAssociates
        '
        Me.lstAssociates.BackColor = System.Drawing.Color.LightGray
        Me.lstAssociates.FormattingEnabled = True
        Me.lstAssociates.Location = New System.Drawing.Point(15, 34)
        Me.lstAssociates.Name = "lstAssociates"
        Me.lstAssociates.Size = New System.Drawing.Size(120, 199)
        Me.lstAssociates.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select an Associate:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(123, 259)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Back To Managers Area"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Selected Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Selected Week"
        '
        'lblWeekNormalHours
        '
        Me.lblWeekNormalHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWeekNormalHours.Location = New System.Drawing.Point(322, 221)
        Me.lblWeekNormalHours.Name = "lblWeekNormalHours"
        Me.lblWeekNormalHours.Size = New System.Drawing.Size(79, 20)
        Me.lblWeekNormalHours.TabIndex = 9
        Me.lblWeekNormalHours.Text = "0"
        '
        'lblDayTime
        '
        Me.lblDayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDayTime.Location = New System.Drawing.Point(152, 221)
        Me.lblDayTime.Name = "lblDayTime"
        Me.lblDayTime.Size = New System.Drawing.Size(80, 20)
        Me.lblDayTime.TabIndex = 10
        Me.lblDayTime.Text = "0"
        Me.lblDayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(177, 13)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 11
        Me.MonthCalendar1.Visible = False
        '
        'lblWeekOvertimeHours
        '
        Me.lblWeekOvertimeHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWeekOvertimeHours.Location = New System.Drawing.Point(322, 241)
        Me.lblWeekOvertimeHours.Name = "lblWeekOvertimeHours"
        Me.lblWeekOvertimeHours.Size = New System.Drawing.Size(79, 20)
        Me.lblWeekOvertimeHours.TabIndex = 12
        Me.lblWeekOvertimeHours.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(245, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Overtime:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(245, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Normal:"
        '
        'frmViewAssociateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWeekOvertimeHours)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblDayTime)
        Me.Controls.Add(Me.lblWeekNormalHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssociates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmViewAssociateTime"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Associate Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAssociates As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblWeekNormalHours As System.Windows.Forms.Label
    Friend WithEvents lblDayTime As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblWeekOvertimeHours As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
