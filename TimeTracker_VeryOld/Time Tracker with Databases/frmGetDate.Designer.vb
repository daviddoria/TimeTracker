<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetDate
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
        Me.cldDate = New System.Windows.Forms.MonthCalendar
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lblReason = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cldDate
        '
        Me.cldDate.BackColor = System.Drawing.Color.LightGray
        Me.cldDate.Location = New System.Drawing.Point(18, 32)
        Me.cldDate.Name = "cldDate"
        Me.cldDate.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSelect.Location = New System.Drawing.Point(75, 199)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblReason
        '
        Me.lblReason.Location = New System.Drawing.Point(12, 9)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(184, 14)
        Me.lblReason.TabIndex = 2
        Me.lblReason.Text = "Label1"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGetDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(208, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cldDate)
        Me.Name = "frmGetDate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select A Date"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cldDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblReason As System.Windows.Forms.Label
End Class
