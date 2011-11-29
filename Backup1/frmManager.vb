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
    Friend WithEvents btnTimeReport As System.Windows.Forms.Button
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnEditAssociate As System.Windows.Forms.Button
    Friend WithEvents btnMOTD As System.Windows.Forms.Button
    Friend WithEvents btnAddAssociate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangePayrollInfo As System.Windows.Forms.Button
    Friend WithEvents btnViewTime As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.btnTimeReport = New System.Windows.Forms.Button
        Me.btnFix = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnEditAssociate = New System.Windows.Forms.Button
        Me.btnMOTD = New System.Windows.Forms.Button
        Me.btnAddAssociate = New System.Windows.Forms.Button
        Me.btnViewTime = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnChangePayrollInfo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimeReport
        '
        Me.btnTimeReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTimeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeReport.Location = New System.Drawing.Point(6, 139)
        Me.btnTimeReport.Name = "btnTimeReport"
        Me.btnTimeReport.Size = New System.Drawing.Size(150, 45)
        Me.btnTimeReport.TabIndex = 4
        Me.btnTimeReport.TabStop = False
        Me.btnTimeReport.Text = "Print Time Report"
        Me.btnTimeReport.UseVisualStyleBackColor = False
        '
        'btnFix
        '
        Me.btnFix.BackColor = System.Drawing.Color.Yellow
        Me.btnFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFix.Location = New System.Drawing.Point(5, 19)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(150, 45)
        Me.btnFix.TabIndex = 6
        Me.btnFix.TabStop = False
        Me.btnFix.Text = "Fix an Associates File"
        Me.btnFix.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnFix.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(116, 289)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnEditAssociate
        '
        Me.btnEditAssociate.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEditAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAssociate.Location = New System.Drawing.Point(6, 19)
        Me.btnEditAssociate.Name = "btnEditAssociate"
        Me.btnEditAssociate.Size = New System.Drawing.Size(150, 45)
        Me.btnEditAssociate.TabIndex = 11
        Me.btnEditAssociate.TabStop = False
        Me.btnEditAssociate.Text = "Edit/Delete an Associate"
        Me.btnEditAssociate.UseVisualStyleBackColor = False
        '
        'btnMOTD
        '
        Me.btnMOTD.BackColor = System.Drawing.Color.Orchid
        Me.btnMOTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTD.Location = New System.Drawing.Point(7, 139)
        Me.btnMOTD.Name = "btnMOTD"
        Me.btnMOTD.Size = New System.Drawing.Size(150, 45)
        Me.btnMOTD.TabIndex = 12
        Me.btnMOTD.TabStop = False
        Me.btnMOTD.Text = "Set/Delete Message of the Day"
        Me.btnMOTD.UseVisualStyleBackColor = False
        '
        'btnAddAssociate
        '
        Me.btnAddAssociate.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAssociate.Location = New System.Drawing.Point(6, 79)
        Me.btnAddAssociate.Name = "btnAddAssociate"
        Me.btnAddAssociate.Size = New System.Drawing.Size(150, 45)
        Me.btnAddAssociate.TabIndex = 15
        Me.btnAddAssociate.TabStop = False
        Me.btnAddAssociate.Text = "Add a New Associate"
        Me.btnAddAssociate.UseVisualStyleBackColor = False
        '
        'btnViewTime
        '
        Me.btnViewTime.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTime.Location = New System.Drawing.Point(5, 79)
        Me.btnViewTime.Name = "btnViewTime"
        Me.btnViewTime.Size = New System.Drawing.Size(150, 45)
        Me.btnViewTime.TabIndex = 13
        Me.btnViewTime.TabStop = False
        Me.btnViewTime.Text = "View an Associates Time"
        Me.btnViewTime.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangePayrollInfo)
        Me.GroupBox1.Controls.Add(Me.btnEditAssociate)
        Me.GroupBox1.Controls.Add(Me.btnMOTD)
        Me.GroupBox1.Controls.Add(Me.btnAddAssociate)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 249)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Associate Functions"
        '
        'btnChangePayrollInfo
        '
        Me.btnChangePayrollInfo.BackColor = System.Drawing.Color.Orchid
        Me.btnChangePayrollInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePayrollInfo.Location = New System.Drawing.Point(7, 198)
        Me.btnChangePayrollInfo.Name = "btnChangePayrollInfo"
        Me.btnChangePayrollInfo.Size = New System.Drawing.Size(150, 45)
        Me.btnChangePayrollInfo.TabIndex = 13
        Me.btnChangePayrollInfo.TabStop = False
        Me.btnChangePayrollInfo.Text = "Change Payroll Company Info"
        Me.btnChangePayrollInfo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFix)
        Me.GroupBox2.Controls.Add(Me.btnViewTime)
        Me.GroupBox2.Controls.Add(Me.btnTimeReport)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 198)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Functions"
        '
        'frmManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(387, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManager"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager's Area"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'so the form cannot be moved
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub GrayForm()
        ' disable the form
        btnLogout.Enabled = False
    End Sub

    Private Sub ResetForm()
        ' re-enable the form
        btnLogout.Enabled = True
    End Sub

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the "Fix an associate's file" form
        frmFixFile.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        LogClick(sender)
        'close the Managers area
        Me.Dispose()
    End Sub

    Private Sub btnEditAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAssociate.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to edit associates personal information (ssn, pin, etc)
        frmEditAssociate.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnMOTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMOTD.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to edit the message of the day
        frmMOTD.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnAddAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAssociate.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to add a new associate
        frmAddAssociate.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnViewTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTime.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to look at the time an associate has logged on any given day
        frmViewAssociateTime.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnChangePayrollInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePayrollInfo.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to edit the payroll company name and fax number
        frmPayroll.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

    Private Sub btnTimeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeReport.Click
        LogClick(sender)
        'disable the form
        GrayForm()

        'show the form to generate the payroll reports
        frmCreateReport.ShowDialog()

        're-enable the form
        ResetForm()
    End Sub

End Class
