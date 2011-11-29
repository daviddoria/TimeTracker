Public Class frmFixFile
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstNameSelect As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteEvent As System.Windows.Forms.Button
    Friend WithEvents dgAssociateData As System.Windows.Forms.DataGrid
    Friend WithEvents btnEditEvent As System.Windows.Forms.Button
    Friend WithEvents btnAddEvent As System.Windows.Forms.Button
    Friend WithEvents cmbInOut As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReason As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAssociate As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.lstNameSelect = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDeleteEvent = New System.Windows.Forms.Button
        Me.dgAssociateData = New System.Windows.Forms.DataGrid
        Me.btnEditEvent = New System.Windows.Forms.Button
        Me.btnAddEvent = New System.Windows.Forms.Button
        Me.cmbInOut = New System.Windows.Forms.ComboBox
        Me.cmbReason = New System.Windows.Forms.ComboBox
        Me.cmbAssociate = New System.Windows.Forms.ComboBox
        CType(Me.dgAssociateData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(504, 416)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Return To Manager's Area"
        '
        'lstNameSelect
        '
        Me.lstNameSelect.Location = New System.Drawing.Point(16, 48)
        Me.lstNameSelect.Name = "lstNameSelect"
        Me.lstNameSelect.Size = New System.Drawing.Size(200, 329)
        Me.lstNameSelect.Sorted = True
        Me.lstNameSelect.TabIndex = 3
        Me.lstNameSelect.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an Associate:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Associate's Data:"
        '
        'btnDeleteEvent
        '
        Me.btnDeleteEvent.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.btnDeleteEvent.Location = New System.Drawing.Point(312, 392)
        Me.btnDeleteEvent.Name = "btnDeleteEvent"
        Me.btnDeleteEvent.Size = New System.Drawing.Size(96, 40)
        Me.btnDeleteEvent.TabIndex = 20
        Me.btnDeleteEvent.Text = "Delete Selected Event"
        '
        'dgAssociateData
        '
        Me.dgAssociateData.DataMember = ""
        Me.dgAssociateData.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAssociateData.Location = New System.Drawing.Point(224, 48)
        Me.dgAssociateData.Name = "dgAssociateData"
        Me.dgAssociateData.Size = New System.Drawing.Size(392, 328)
        Me.dgAssociateData.TabIndex = 30
        '
        'btnEditEvent
        '
        Me.btnEditEvent.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.btnEditEvent.Location = New System.Drawing.Point(208, 392)
        Me.btnEditEvent.Name = "btnEditEvent"
        Me.btnEditEvent.Size = New System.Drawing.Size(88, 40)
        Me.btnEditEvent.TabIndex = 32
        Me.btnEditEvent.Text = "Edit Selected Event"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.btnAddEvent.Location = New System.Drawing.Point(112, 392)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(88, 40)
        Me.btnAddEvent.TabIndex = 33
        Me.btnAddEvent.Text = "Add Selected Event"
        '
        'cmbInOut
        '
        Me.cmbInOut.Items.AddRange(New Object() {"In", "Out"})
        Me.cmbInOut.Location = New System.Drawing.Point(192, 440)
        Me.cmbInOut.Name = "cmbInOut"
        Me.cmbInOut.Size = New System.Drawing.Size(121, 21)
        Me.cmbInOut.TabIndex = 34
        Me.cmbInOut.Text = "Select In/Out"
        '
        'cmbReason
        '
        Me.cmbReason.Items.AddRange(New Object() {"DAY", "SMOKE", "LUNCH", "MISC"})
        Me.cmbReason.Location = New System.Drawing.Point(320, 440)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(121, 21)
        Me.cmbReason.TabIndex = 35
        Me.cmbReason.Text = "Select Reason"
        '
        'cmbAssociate
        '
        Me.cmbAssociate.Location = New System.Drawing.Point(64, 440)
        Me.cmbAssociate.Name = "cmbAssociate"
        Me.cmbAssociate.Size = New System.Drawing.Size(121, 21)
        Me.cmbAssociate.TabIndex = 36
        Me.cmbAssociate.Text = "Select Associate"
        '
        'frmFixFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(622, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbAssociate)
        Me.Controls.Add(Me.cmbReason)
        Me.Controls.Add(Me.cmbInOut)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.btnEditEvent)
        Me.Controls.Add(Me.dgAssociateData)
        Me.Controls.Add(Me.btnDeleteEvent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNameSelect)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFixFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix an Associates File"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgAssociateData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim AssociateToEdit As Associate
    Public EventData As New DataSet
    Public DatabaseConnection As New OleDb.OleDbConnection
    Public EventDataAdapter As OleDb.OleDbDataAdapter

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            Dim MyCommandBuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(EventDataAdapter)

            Try
                EventDataAdapter.Update(EventData, "event")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            EventData.AcceptChanges()

        End If

        Me.Close()
    End Sub

    Private Sub frmFixFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstNameSelect, "Timed")

        Dim i As Integer
        For i = 0 To lstNameSelect.Items.Count - 1
            cmbAssociate.Items.Add(lstNameSelect.Items.Item(i))
        Next

        dgAssociateData.Controls.Add(cmbReason)
        dgAssociateData.Controls.Add(cmbInOut)
        dgAssociateData.Controls.Add(cmbAssociate)

        Dim AssociateColumn As New DataColumn
        Dim InOutColumn As New DataColumn
        Dim ReasonColumn As New DataColumn

        Dim MyTable As New DataGridTableStyle
        'mytable.GridColumnStyles(0)=associatecolumn.
        'Associatecolumn.
        'dgAssociateData.TableStyles(0).GridColumnStyles.Item(0).Width = 20

        'dgAssociateData.TableStyles.Add(MyTable)


    End Sub

    Private Sub lstNameSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNameSelect.SelectedIndexChanged


        AssociateToEdit = GetAssociateData(lstNameSelect.SelectedItem)

        DatabaseConnection.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = " & DatabaseSource

        Dim AssociateQuery As String = "SELECT * FROM event where associate='" & AssociateToEdit.Name & "' order by date"

        EventDataAdapter = New OleDb.OleDbDataAdapter(AssociateQuery, DatabaseConnection)
        EventData.Clear()
        EventDataAdapter.Fill(EventData, "event")

        dgAssociateData.SetDataBinding(EventData, "event")



    End Sub

    Private Sub btnDeleteEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteEvent.Click

        EventData.Tables("event").Rows(dgAssociateData.CurrentRowIndex).Delete()

    End Sub

    Private Sub btnEditEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEvent.Click
        AddEditMode = "EDIT"
        Dim newfrmAddEvent As New frmAddEvent
        newfrmAddEvent.Show()
    End Sub

    Private Sub btnAddEvent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEvent.Click
        AddEditMode = "ADD"
        Dim newfrmAddEvent As New frmAddEvent
        newfrmAddEvent.Show()

    End Sub
#Region "ComboBoxes"
    Private Sub dgassociatedata_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAssociateData.CurrentCellChanged

        If dgAssociateData.CurrentCell.ColumnNumber = 5 Then
            cmbInOut.Visible = False
            'cmbInOut.Width = dgAssociateData.TableStyles("event").GridColumnStyles(0).Width
            cmbInOut.Width = 70
            'dg.TableStyles("customers").GridColumnStyles(col).Width = CType(Width, Integer)()
            cmbInOut.Left = dgAssociateData.GetCurrentCellBounds.Left
            cmbInOut.Top = dgAssociateData.GetCurrentCellBounds.Top
            'cmbInOut.Text = dgAssociateData.Item(dgAssociateData.CurrentCell) & ""
            cmbInOut.SelectedItem = dgAssociateData.Item(dgAssociateData.CurrentCell)
            cmbInOut.DroppedDown = True
            cmbInOut.Visible = True
        Else
            cmbInOut.Visible = False
            'cmbInOut.Width = 0
        End If


    End Sub
#End Region


    Private Sub cmbInOut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInOut.SelectedIndexChanged
        dgAssociateData.Item(dgAssociateData.CurrentRowIndex, 5) = cmbInOut.SelectedItem

    End Sub

End Class
