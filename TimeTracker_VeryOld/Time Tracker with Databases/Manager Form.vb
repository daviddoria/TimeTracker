Imports CrystalDecisions.Shared
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
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAssignDays As System.Windows.Forms.Button
    Friend WithEvents btnEditAssociate As System.Windows.Forms.Button
    Friend WithEvents btnMOTD As System.Windows.Forms.Button
    Friend WithEvents btnAddAssociate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTimeOverview As System.Windows.Forms.Button
    Friend WithEvents btnViewTime As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.btnCreateReport = New System.Windows.Forms.Button
        Me.btnFix = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnAssignDays = New System.Windows.Forms.Button
        Me.btnEditAssociate = New System.Windows.Forms.Button
        Me.btnMOTD = New System.Windows.Forms.Button
        Me.btnAddAssociate = New System.Windows.Forms.Button
        Me.btnViewTime = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTimeOverview = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateReport
        '
        Me.btnCreateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCreateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateReport.Location = New System.Drawing.Point(6, 139)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(150, 45)
        Me.btnCreateReport.TabIndex = 4
        Me.btnCreateReport.TabStop = False
        Me.btnCreateReport.Text = "Print Detailed Time Report"
        Me.btnCreateReport.UseVisualStyleBackColor = False
        '
        'btnFix
        '
        Me.btnFix.BackColor = System.Drawing.Color.SkyBlue
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
        Me.btnLogout.Location = New System.Drawing.Point(208, 292)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAssignDays
        '
        Me.btnAssignDays.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAssignDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignDays.Location = New System.Drawing.Point(6, 79)
        Me.btnAssignDays.Name = "btnAssignDays"
        Me.btnAssignDays.Size = New System.Drawing.Size(150, 45)
        Me.btnAssignDays.TabIndex = 9
        Me.btnAssignDays.TabStop = False
        Me.btnAssignDays.Text = "Assign Sick/Vacation/Holiday"
        Me.btnAssignDays.UseVisualStyleBackColor = False
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
        Me.btnMOTD.BackColor = System.Drawing.Color.SkyBlue
        Me.btnMOTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTD.Location = New System.Drawing.Point(6, 19)
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
        Me.btnViewTime.BackColor = System.Drawing.Color.SkyBlue
        Me.btnViewTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTime.Location = New System.Drawing.Point(5, 79)
        Me.btnViewTime.Name = "btnViewTime"
        Me.btnViewTime.Size = New System.Drawing.Size(150, 45)
        Me.btnViewTime.TabIndex = 13
        Me.btnViewTime.TabStop = False
        Me.btnViewTime.Text = "View An Associates Time"
        Me.btnViewTime.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditAssociate)
        Me.GroupBox1.Controls.Add(Me.btnAddAssociate)
        Me.GroupBox1.Location = New System.Drawing.Point(395, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 133)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Associate Functions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTimeOverview)
        Me.GroupBox2.Controls.Add(Me.btnFix)
        Me.GroupBox2.Controls.Add(Me.btnViewTime)
        Me.GroupBox2.Controls.Add(Me.btnCreateReport)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 249)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Functions"
        '
        'btnTimeOverview
        '
        Me.btnTimeOverview.BackColor = System.Drawing.Color.LightGreen
        Me.btnTimeOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOverview.Location = New System.Drawing.Point(6, 198)
        Me.btnTimeOverview.Name = "btnTimeOverview"
        Me.btnTimeOverview.Size = New System.Drawing.Size(150, 45)
        Me.btnTimeOverview.TabIndex = 14
        Me.btnTimeOverview.Text = "Print Overview Time Report"
        Me.btnTimeOverview.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnMOTD)
        Me.GroupBox3.Controls.Add(Me.btnAssignDays)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 133)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc. Functions"
        '
        'frmManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ParamFields As ParameterFields

    Public Sub btnCreateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport.Click
        paramfields = CreateTimeReport("detailed")
        frmViewReport.ShowDialog()
    End Sub

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        frmFixFile.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        LoginFormID.Enabled = True
        LoginFormID.Opacity = 100
        Me.Close()
    End Sub


    Private Sub btnAssignDays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDays.Click
        frmSick.ShowDialog()
    End Sub

    Private Sub btnEditAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAssociate.Click
        frmEditAssociate.ShowDialog()
    End Sub

    Private Sub btnMOTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMOTD.Click

        MOTD = InputBox("Enter the message of the day. (To have no message, leave this blank)", "Daily Message")

        Dim MOTDDataSet As DataSet = GetDataSet("companyTable", "*", "", "")

        MOTDDataSet.Tables("companyTable").Rows(0).Item("MOTD") = MOTD

        Try
            PutDataSet(MOTDDataSet, "companyTable")
        Catch ex As Exception
            MsgBox("There was an error setting the MOTD.")
        End Try


    End Sub


    Private Sub btnAddAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAssociate.Click
        Dim newfrmAddAssociate As New frmAddAssociate()
        newfrmAddAssociate.ShowDialog(Me)
    End Sub


    Private Sub btnViewTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTime.Click
        frmViewAssociateTime.ShowDialog()
    End Sub

    Private Sub btnTimeOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOverview.Click

        ParamFields = CreateTimeReport("overview")
        If ReportSuccessful = True Then
            frmViewReport.ShowDialog()
        End If

    End Sub
End Class
