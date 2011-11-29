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
    Friend WithEvents btnViewTime As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.btnCreateReport = New System.Windows.Forms.Button
        Me.btnFix = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnAssignDays = New System.Windows.Forms.Button
        Me.btnEditAssociate = New System.Windows.Forms.Button
        Me.btnMOTD = New System.Windows.Forms.Button
        Me.btnAddAssociate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnViewTime = New System.Windows.Forms.Button
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
        Me.btnCreateReport.Location = New System.Drawing.Point(56, 64)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(152, 32)
        Me.btnCreateReport.TabIndex = 4
        Me.btnCreateReport.TabStop = False
        Me.btnCreateReport.Text = "Print Time Report"
        Me.btnCreateReport.UseVisualStyleBackColor = False
        '
        'btnFix
        '
        Me.btnFix.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFix.Location = New System.Drawing.Point(48, 30)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(152, 42)
        Me.btnFix.TabIndex = 6
        Me.btnFix.TabStop = False
        Me.btnFix.Text = "View/Fix an Associates File"
        Me.btnFix.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(240, 376)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(152, 32)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAssignDays
        '
        Me.btnAssignDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAssignDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignDays.Location = New System.Drawing.Point(48, 78)
        Me.btnAssignDays.Name = "btnAssignDays"
        Me.btnAssignDays.Size = New System.Drawing.Size(152, 42)
        Me.btnAssignDays.TabIndex = 9
        Me.btnAssignDays.TabStop = False
        Me.btnAssignDays.Text = "Assign Sick/Vacation/Holiday"
        Me.btnAssignDays.UseVisualStyleBackColor = False
        '
        'btnEditAssociate
        '
        Me.btnEditAssociate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEditAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAssociate.Location = New System.Drawing.Point(56, 32)
        Me.btnEditAssociate.Name = "btnEditAssociate"
        Me.btnEditAssociate.Size = New System.Drawing.Size(152, 42)
        Me.btnEditAssociate.TabIndex = 11
        Me.btnEditAssociate.TabStop = False
        Me.btnEditAssociate.Text = "Edit/Delete an Associate"
        Me.btnEditAssociate.UseVisualStyleBackColor = False
        '
        'btnMOTD
        '
        Me.btnMOTD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMOTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOTD.Location = New System.Drawing.Point(48, 126)
        Me.btnMOTD.Name = "btnMOTD"
        Me.btnMOTD.Size = New System.Drawing.Size(152, 42)
        Me.btnMOTD.TabIndex = 12
        Me.btnMOTD.TabStop = False
        Me.btnMOTD.Text = "Set/Delete Message of the Day"
        Me.btnMOTD.UseVisualStyleBackColor = False
        '
        'btnAddAssociate
        '
        Me.btnAddAssociate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddAssociate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAssociate.Location = New System.Drawing.Point(56, 80)
        Me.btnAddAssociate.Name = "btnAddAssociate"
        Me.btnAddAssociate.Size = New System.Drawing.Size(152, 32)
        Me.btnAddAssociate.TabIndex = 15
        Me.btnAddAssociate.TabStop = False
        Me.btnAddAssociate.Text = "Add a New Associate"
        Me.btnAddAssociate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCreateReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(320, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 128)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weekly Functions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewTime)
        Me.GroupBox2.Controls.Add(Me.btnFix)
        Me.GroupBox2.Controls.Add(Me.btnAssignDays)
        Me.GroupBox2.Controls.Add(Me.btnMOTD)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 248)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Functions"
        '
        'btnViewTime
        '
        Me.btnViewTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTime.Location = New System.Drawing.Point(48, 174)
        Me.btnViewTime.Name = "btnViewTime"
        Me.btnViewTime.Size = New System.Drawing.Size(152, 42)
        Me.btnViewTime.TabIndex = 13
        Me.btnViewTime.TabStop = False
        Me.btnViewTime.Text = "View An Associates Time"
        Me.btnViewTime.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEditAssociate)
        Me.GroupBox3.Controls.Add(Me.btnAddAssociate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(320, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 120)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rarely Used Functions"
        '
        'frmManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 507)
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
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub btnCreateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport.Click
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

        Dim MOTD As String
        MOTD = InputBox("Enter the message of the day. (To have no message, leave this blank)", "Daily Message")

        Dim MOTDDataSet As DataSet = GetDataSet("company", "MOTD", "", "")

        MOTDDataSet.Tables("company").Rows(0).Item("MOTD") = MOTD

        PutDataSet(MOTDDataSet, "company")

    End Sub


    Private Sub btnAddAssociate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAssociate.Click
        Dim newfrmAddAssociate As New frmAddAssociate()
        newfrmAddAssociate.ShowDialog(Me)
    End Sub


    Private Sub btnViewTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewTime.Click
        frmViewAssociateTime.ShowDialog()
    End Sub
End Class
