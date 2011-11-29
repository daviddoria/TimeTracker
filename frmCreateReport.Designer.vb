<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.radDetailed = New System.Windows.Forms.RadioButton
        Me.radOverview = New System.Windows.Forms.RadioButton
        Me.lblStandard = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnEmail = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Enabled = False
        Me.dtpStart.Location = New System.Drawing.Point(121, 102)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PayPeriod Start"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Location = New System.Drawing.Point(59, 170)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 38)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'radDetailed
        '
        Me.radDetailed.AutoSize = True
        Me.radDetailed.Location = New System.Drawing.Point(6, 19)
        Me.radDetailed.Name = "radDetailed"
        Me.radDetailed.Size = New System.Drawing.Size(132, 17)
        Me.radDetailed.TabIndex = 0
        Me.radDetailed.Text = "Detailed (Every Week)"
        Me.radDetailed.UseVisualStyleBackColor = True
        '
        'radOverview
        '
        Me.radOverview.AutoSize = True
        Me.radOverview.Location = New System.Drawing.Point(6, 42)
        Me.radOverview.Name = "radOverview"
        Me.radOverview.Size = New System.Drawing.Size(152, 17)
        Me.radOverview.TabIndex = 0
        Me.radOverview.Text = "Overview (Every 2 Weeks)"
        Me.radOverview.UseVisualStyleBackColor = True
        '
        'lblStandard
        '
        Me.lblStandard.AutoSize = True
        Me.lblStandard.Location = New System.Drawing.Point(103, 136)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(97, 13)
        Me.lblStandard.TabIndex = 7
        Me.lblStandard.Text = "No Dates Selected"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDetailed)
        Me.GroupBox1.Controls.Add(Me.radOverview)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(62, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 68)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Type"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(181, 170)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 38)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Go Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.Yellow
        Me.btnEmail.Location = New System.Drawing.Point(265, 31)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(75, 40)
        Me.btnEmail.TabIndex = 10
        Me.btnEmail.Text = "Email Latest Reports"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'frmCreateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(369, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStandard)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCreateReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents radDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents radOverview As System.Windows.Forms.RadioButton
    Friend WithEvents lblStandard As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
End Class
