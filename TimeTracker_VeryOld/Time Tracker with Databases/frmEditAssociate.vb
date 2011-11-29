Public Class frmEditAssociate
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
    Friend WithEvents lblSocial As System.Windows.Forms.Label
    Friend WithEvents txtSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblSick As System.Windows.Forms.Label
    Friend WithEvents txtSick As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVacation As System.Windows.Forms.TextBox
    Friend WithEvents txtStartingDate As System.Windows.Forms.TextBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lstType As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblNameTag As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblNameTag = New System.Windows.Forms.Label
        Me.lblSocial = New System.Windows.Forms.Label
        Me.txtSocial = New System.Windows.Forms.TextBox
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.txtStartingDate = New System.Windows.Forms.TextBox
        Me.lblSick = New System.Windows.Forms.Label
        Me.txtSick = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtVacation = New System.Windows.Forms.TextBox
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.lblSelect = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblPIN = New System.Windows.Forms.Label
        Me.txtPIN = New System.Windows.Forms.TextBox
        Me.btnQuit = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.lstType = New System.Windows.Forms.ListBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNameTag
        '
        Me.lblNameTag.AutoSize = True
        Me.lblNameTag.Location = New System.Drawing.Point(232, 24)
        Me.lblNameTag.Name = "lblNameTag"
        Me.lblNameTag.Size = New System.Drawing.Size(38, 13)
        Me.lblNameTag.TabIndex = 1
        Me.lblNameTag.Text = "Name:"
        Me.lblNameTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSocial
        '
        Me.lblSocial.AutoSize = True
        Me.lblSocial.Location = New System.Drawing.Point(232, 48)
        Me.lblSocial.Name = "lblSocial"
        Me.lblSocial.Size = New System.Drawing.Size(90, 13)
        Me.lblSocial.TabIndex = 2
        Me.lblSocial.Text = "Social Security #:"
        Me.lblSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSocial
        '
        Me.txtSocial.BackColor = System.Drawing.Color.LightGray
        Me.txtSocial.Location = New System.Drawing.Point(328, 48)
        Me.txtSocial.MaxLength = 9
        Me.txtSocial.Name = "txtSocial"
        Me.txtSocial.Size = New System.Drawing.Size(88, 20)
        Me.txtSocial.TabIndex = 1
        Me.txtSocial.TabStop = False
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(232, 152)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(80, 16)
        Me.lblStartDate.TabIndex = 4
        Me.lblStartDate.Text = "Starting Date:"
        Me.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStartingDate
        '
        Me.txtStartingDate.BackColor = System.Drawing.Color.LightGray
        Me.txtStartingDate.Location = New System.Drawing.Point(320, 152)
        Me.txtStartingDate.Name = "txtStartingDate"
        Me.txtStartingDate.Size = New System.Drawing.Size(80, 20)
        Me.txtStartingDate.TabIndex = 4
        Me.txtStartingDate.TabStop = False
        '
        'lblSick
        '
        Me.lblSick.AutoSize = True
        Me.lblSick.Location = New System.Drawing.Point(232, 176)
        Me.lblSick.Name = "lblSick"
        Me.lblSick.Size = New System.Drawing.Size(115, 13)
        Me.lblSick.TabIndex = 8
        Me.lblSick.Text = "Sick Hours Remaining:"
        Me.lblSick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSick
        '
        Me.txtSick.BackColor = System.Drawing.Color.LightGray
        Me.txtSick.Location = New System.Drawing.Point(352, 176)
        Me.txtSick.Name = "txtSick"
        Me.txtSick.Size = New System.Drawing.Size(32, 20)
        Me.txtSick.TabIndex = 5
        Me.txtSick.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Vacation Hours Remaining:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVacation
        '
        Me.txtVacation.BackColor = System.Drawing.Color.LightGray
        Me.txtVacation.Location = New System.Drawing.Point(376, 200)
        Me.txtVacation.Name = "txtVacation"
        Me.txtVacation.Size = New System.Drawing.Size(32, 20)
        Me.txtVacation.TabIndex = 6
        Me.txtVacation.TabStop = False
        '
        'lstNameSelect
        '
        Me.lstNameSelect.BackColor = System.Drawing.Color.LightGray
        Me.lstNameSelect.Location = New System.Drawing.Point(40, 24)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(152, 212)
        Me.lstNameSelect.Sorted = True
        Me.lstNameSelect.TabIndex = 12
        Me.lstNameSelect.TabStop = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(16, 8)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(123, 13)
        Me.lblSelect.TabIndex = 13
        Me.lblSelect.Text = "Select an associate:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(240, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 60)
        Me.btnSave.TabIndex = 14
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Update Associate Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Location = New System.Drawing.Point(232, 80)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(28, 13)
        Me.lblPIN.TabIndex = 15
        Me.lblPIN.Text = "PIN:"
        Me.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.LightGray
        Me.txtPIN.Location = New System.Drawing.Point(272, 72)
        Me.txtPIN.MaxLength = 3
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(56, 20)
        Me.txtPIN.TabIndex = 2
        Me.txtPIN.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(472, 224)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 60)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Back To Managers Area"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(232, 96)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(96, 16)
        Me.lblType.TabIndex = 18
        Me.lblType.Text = "Associate's Type:"
        '
        'lstType
        '
        Me.lstType.BackColor = System.Drawing.Color.LightGray
        Me.lstType.Items.AddRange(New Object() {"Manager", "Timed", "Commissioned"})
        Me.lstType.Location = New System.Drawing.Point(328, 96)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(128, 43)
        Me.lstType.TabIndex = 3
        Me.lstType.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Yellow
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(360, 224)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 60)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete Associate"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(272, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 23)
        Me.lblName.TabIndex = 22
        '
        'frmEditAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Controls.Add(Me.txtVacation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSick)
        Me.Controls.Add(Me.lblSick)
        Me.Controls.Add(Me.txtStartingDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.txtSocial)
        Me.Controls.Add(Me.lblSocial)
        Me.Controls.Add(Me.lblNameTag)
        Me.Name = "frmEditAssociate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Associate Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim EditAssociate As New Associate
    Dim AssociateSelected As Boolean = False

    Private Sub frmEditAssociate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "*")
    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged
        AssociateSelected = True

        If Not lstNameSelect.SelectedIndex = -1 Then
            EditAssociate = GetAssociateData(lstNameSelect.SelectedItem)
            lblName.Text = EditAssociate.Name
            txtSocial.Text = EditAssociate.Social
            txtPIN.Text = EditAssociate.Pin
            lstType.SelectedItem = EditAssociate.Type
            txtStartingDate.Text = EditAssociate.StartDate
            txtSick.Text = Convert.ToString(EditAssociate.SickHours)
            txtVacation.Text = EditAssociate.VacationHours

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SavePerson()
        AssociateSelected = False
    End Sub

    Private Function SavePerson() As Boolean
        Dim AssociateToUpdate As New Associate()

        AssociateToUpdate.Name = lblName.Text
        AssociateToUpdate.Social = txtSocial.Text
        AssociateToUpdate.Pin = txtPIN.Text
        AssociateToUpdate.Type = lstType.SelectedItem
        AssociateToUpdate.SickHours = txtSick.Text
        AssociateToUpdate.VacationHours = txtVacation.Text
        AssociateToUpdate.StartDate = txtStartingDate.Text

        WriteAssociateData(AssociateToUpdate)

        'clear boxes
        lblName.Text = ""
        txtSocial.Text = ""
        txtPIN.Text = ""
        lstType.SelectedIndex = -1
        txtStartingDate.Text = ""
        txtSick.Text = ""
        txtVacation.Text = ""
        lstNameSelect.SelectedIndex = -1

        Return True

    End Function

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        If AssociateSelected = True Then

            If txtSocial.Text <> EditAssociate.Social Or _
                txtPIN.Text <> EditAssociate.Pin Or _
                lstType.SelectedItem <> EditAssociate.Type Or _
                txtStartingDate.Text <> EditAssociate.StartDate.ToShortDateString Or _
                txtSick.Text <> EditAssociate.SickHours.ToString Or _
                txtVacation.Text <> EditAssociate.VacationHours.ToString Then
                If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                    SavePerson()
                End If
                'MsgBox("Changes made!")
                'With EditAssociate
                '    MsgBox(.Social)
                '    MsgBox(.Pin)
                '    MsgBox(.Type)
                '    MsgBox(.StartDate.ToString)
                '    MsgBox(.SickHours.ToString)
                '    MsgBox(.VacationHours.ToString)
                'End With
            End If

        End If

        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        
        Dim DeleteDataSet As DataSet = GetDataSet("associate", "*", "associatename='" & lblName.Text & "'", "")

        DeleteDataSet.Tables("associate").Rows(0).Delete()

        PutDataSet(DeleteDataSet, "associate")

        MsgBox("Deletion Successful!")

        'refresh list of names
        LoadNameListBox(lstNameSelect, "*")

        'clear whole form
        lblName.Text = ""
        txtSocial.Text = ""
        txtPIN.Text = ""
        lstType.SelectedIndex = -1
        txtStartingDate.Text = ""
        txtSick.Text = ""
        txtVacation.Text = ""

        AssociateSelected = False

    End Sub
End Class
