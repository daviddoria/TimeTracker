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
        Me.lblNameTag.Location = New System.Drawing.Point(198, 22)
        Me.lblNameTag.Name = "lblNameTag"
        Me.lblNameTag.Size = New System.Drawing.Size(90, 24)
        Me.lblNameTag.TabIndex = 1
        Me.lblNameTag.Text = "Name:"
        Me.lblNameTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSocial
        '
        Me.lblSocial.Location = New System.Drawing.Point(206, 48)
        Me.lblSocial.Name = "lblSocial"
        Me.lblSocial.Size = New System.Drawing.Size(90, 13)
        Me.lblSocial.TabIndex = 2
        Me.lblSocial.Text = "Social Security #:"
        Me.lblSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSocial
        '
        Me.txtSocial.BackColor = System.Drawing.Color.LightGray
        Me.txtSocial.Location = New System.Drawing.Point(302, 48)
        Me.txtSocial.MaxLength = 9
        Me.txtSocial.Name = "txtSocial"
        Me.txtSocial.Size = New System.Drawing.Size(88, 20)
        Me.txtSocial.TabIndex = 1
        Me.txtSocial.TabStop = False
        '
        'lstNameSelect
        '
        Me.lstNameSelect.BackColor = System.Drawing.Color.LightGray
        Me.lstNameSelect.Location = New System.Drawing.Point(19, 24)
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
        Me.btnSave.Location = New System.Drawing.Point(184, 162)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 39)
        Me.btnSave.TabIndex = 14
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Update Associate Data"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblPIN
        '
        Me.lblPIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPIN.Location = New System.Drawing.Point(206, 80)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(82, 13)
        Me.lblPIN.TabIndex = 15
        Me.lblPIN.Text = "PIN:"
        Me.lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.LightGray
        Me.txtPIN.Location = New System.Drawing.Point(302, 73)
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
        Me.btnQuit.Location = New System.Drawing.Point(416, 162)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(102, 39)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Back To Managers Area"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblType
        '
        Me.lblType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblType.Location = New System.Drawing.Point(206, 96)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(96, 16)
        Me.lblType.TabIndex = 18
        Me.lblType.Text = "Associate's Type:"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstType
        '
        Me.lstType.BackColor = System.Drawing.Color.LightGray
        Me.lstType.Items.AddRange(New Object() {"Manager", "Timed", "Commissioned"})
        Me.lstType.Location = New System.Drawing.Point(302, 99)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(128, 43)
        Me.lstType.TabIndex = 3
        Me.lstType.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Yellow
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(304, 162)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 39)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete Associate"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(302, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 23)
        Me.lblName.TabIndex = 22
        Me.lblName.Text = "Associate Name"
        '
        'frmEditAssociate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(530, 254)
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
    'don't allow the form to move
    Private immobiliser As New FormImmobiliser(Me)

    'global (local) variables to keep track of the selected associate (how would you do this without these? !!!)
    Dim EditAssociate As Associate
    Dim AssociateSelected As Boolean = False

    Private Sub frmEditAssociate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, AssociateType.ALL)
    End Sub

    Private Sub lstNameSelect_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstNameSelect.MouseClick
        If lstNameSelect.SelectedIndex = -1 Then
            Return
        End If

        If CheckForChanges() = True Then
            AskForChanges()
        End If

        AssociateSelected = True
        EditAssociate = New Associate(lstNameSelect.SelectedItem.ToString)
        lblName.Text = EditAssociate.Name
        txtSocial.Text = EditAssociate.Social
        txtPIN.Text = EditAssociate.Pin

        Dim SelectedType As String = StrConv(EditAssociate.Type.GetString, VbStrConv.ProperCase, 0)
        lstType.SelectedItem = SelectedType
        
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        LogClick(sender)
        SavePerson()
    End Sub

    Private Sub SavePerson()
        Dim AssociateToUpdate As New Associate(EditAssociate.Name)
        AssociateToUpdate.Social = txtSocial.Text
        AssociateToUpdate.Pin = txtPIN.Text
        AssociateToUpdate.Type = lstType.SelectedItem.ToString.GetAssociateType

        AssociateToUpdate.WriteData()

    End Sub

    Sub ClearForm()
        lblName.Text = ""
        txtSocial.Text = ""
        txtPIN.Text = ""
        lstType.SelectedIndex = -1
        lstNameSelect.SelectedIndex = -1
        AssociateSelected = False
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        LogClick(sender)
        AskForChanges()

        Me.Dispose()
    End Sub

    Sub AskForChanges()
        If CheckForChanges() = True Then
            If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                SavePerson()
            End If
        End If
    End Sub

    Function CheckForChanges() As Boolean
        If AssociateSelected = False Then
            Return False
        End If

        If Not (txtSocial.Text = EditAssociate.Social And _
            txtPIN.Text = EditAssociate.Pin And _
            lstType.SelectedItem.ToString.GetAssociateType = EditAssociate.Type) Then

            Return True
        End If

    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        LogClick(sender)

        Dim daAssociate As New TTDataSetTableAdapters.AssociateTableTableAdapter
        Dim AssociateTable As New TTDataSet.AssociateTableDataTable
        daAssociate.Fill(AssociateTable)

        'find the associate's row
        Dim SelectString As String = "AssociateName='" + lblName.Text + "'"
        'Dim dv As New DataView(AssociateTable, "AssociateName='" + lblName.Text + "'", "", DataViewRowState.CurrentRows)
        Dim OldAssociateRow As TTDataSet.AssociateTableRow() = DirectCast(AssociateTable.Select(SelectString), TTDataSet.AssociateTableRow())

        'delete the associate
        If OldAssociateRow.Length = 1 Then
            OldAssociateRow(0).Delete()
        Else
            MessageBox.Show("There was a problem deleting the associate!")
            End
        End If

        daAssociate.Update(AssociateTable)

        'refresh list of names
        LoadNameListBox(lstNameSelect, AssociateType.ALL)

        ClearForm()

    End Sub
End Class
