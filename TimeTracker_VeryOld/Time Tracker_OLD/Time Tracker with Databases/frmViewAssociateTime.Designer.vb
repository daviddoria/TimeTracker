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
        Me.btnPreviousDay = New System.Windows.Forms.Button
        Me.btnCurrentWeek = New System.Windows.Forms.Button
        Me.btnPreviousWeek = New System.Windows.Forms.Button
        Me.btnCurrentDay = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
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
        'btnPreviousDay
        '
        Me.btnPreviousDay.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPreviousDay.Enabled = False
        Me.btnPreviousDay.Location = New System.Drawing.Point(165, 118)
        Me.btnPreviousDay.Name = "btnPreviousDay"
        Me.btnPreviousDay.Size = New System.Drawing.Size(104, 37)
        Me.btnPreviousDay.TabIndex = 2
        Me.btnPreviousDay.Text = "Calculate Time in a Previous Day"
        Me.btnPreviousDay.UseVisualStyleBackColor = False
        '
        'btnCurrentWeek
        '
        Me.btnCurrentWeek.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCurrentWeek.Enabled = False
        Me.btnCurrentWeek.Location = New System.Drawing.Point(165, 77)
        Me.btnCurrentWeek.Name = "btnCurrentWeek"
        Me.btnCurrentWeek.Size = New System.Drawing.Size(104, 35)
        Me.btnCurrentWeek.TabIndex = 3
        Me.btnCurrentWeek.Text = "Calculate Time in Current Week"
        Me.btnCurrentWeek.UseVisualStyleBackColor = False
        '
        'btnPreviousWeek
        '
        Me.btnPreviousWeek.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPreviousWeek.Enabled = False
        Me.btnPreviousWeek.Location = New System.Drawing.Point(165, 162)
        Me.btnPreviousWeek.Name = "btnPreviousWeek"
        Me.btnPreviousWeek.Size = New System.Drawing.Size(104, 37)
        Me.btnPreviousWeek.TabIndex = 4
        Me.btnPreviousWeek.Text = "Calculate Time in a Previous Week"
        Me.btnPreviousWeek.UseVisualStyleBackColor = False
        '
        'btnCurrentDay
        '
        Me.btnCurrentDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCurrentDay.Enabled = False
        Me.btnCurrentDay.Location = New System.Drawing.Point(165, 34)
        Me.btnCurrentDay.Name = "btnCurrentDay"
        Me.btnCurrentDay.Size = New System.Drawing.Size(104, 37)
        Me.btnCurrentDay.TabIndex = 5
        Me.btnCurrentDay.Text = "Calculate Time in Current Day"
        Me.btnCurrentDay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(165, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Back To Managers Area"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmViewAssociateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(287, 253)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCurrentDay)
        Me.Controls.Add(Me.btnPreviousWeek)
        Me.Controls.Add(Me.btnCurrentWeek)
        Me.Controls.Add(Me.btnPreviousDay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssociates)
        Me.Name = "frmViewAssociateTime"
        Me.ShowInTaskbar = False
        Me.Text = "frmViewAssociateTime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAssociates As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreviousDay As System.Windows.Forms.Button
    Friend WithEvents btnCurrentWeek As System.Windows.Forms.Button
    Friend WithEvents btnPreviousWeek As System.Windows.Forms.Button
    Friend WithEvents btnCurrentDay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
