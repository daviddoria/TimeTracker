<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Me.components = New System.ComponentModel.Container
        Me.lblEvent = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpInformation = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblBreakOverage = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTodayHours = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOvertimeHours = New System.Windows.Forms.Label
        Me.lblHoursInWeek = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.AssociateNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeFieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PunchEventTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTDataSet = New TimeTracker.TTDataSet
        Me.PunchEventTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.PunchEventTableTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grpInformation.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PunchEventTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEvent
        '
        Me.lblEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(6, 16)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(508, 59)
        Me.lblEvent.TabIndex = 0
        Me.lblEvent.Text = "You have been"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(175, 85)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(75, 29)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "TIME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Time:"
        '
        'grpInformation
        '
        Me.grpInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpInformation.Controls.Add(Me.Label3)
        Me.grpInformation.Controls.Add(Me.lblBreakOverage)
        Me.grpInformation.Controls.Add(Me.Label2)
        Me.grpInformation.Controls.Add(Me.lblTodayHours)
        Me.grpInformation.Controls.Add(Me.Label1)
        Me.grpInformation.Controls.Add(Me.lblOvertimeHours)
        Me.grpInformation.Controls.Add(Me.lblHoursInWeek)
        Me.grpInformation.Controls.Add(Me.Label5)
        Me.grpInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInformation.ForeColor = System.Drawing.Color.Black
        Me.grpInformation.Location = New System.Drawing.Point(12, 325)
        Me.grpInformation.Name = "grpInformation"
        Me.grpInformation.Size = New System.Drawing.Size(512, 144)
        Me.grpInformation.TabIndex = 36
        Me.grpInformation.TabStop = False
        Me.grpInformation.Text = "Information"
        Me.grpInformation.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 35)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Break overage:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBreakOverage
        '
        Me.lblBreakOverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBreakOverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakOverage.Location = New System.Drawing.Point(323, 57)
        Me.lblBreakOverage.Name = "lblBreakOverage"
        Me.lblBreakOverage.Size = New System.Drawing.Size(103, 24)
        Me.lblBreakOverage.TabIndex = 35
        Me.lblBreakOverage.Text = "Break Mins"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 23)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Hours worked today:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTodayHours
        '
        Me.lblTodayHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTodayHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayHours.Location = New System.Drawing.Point(323, 27)
        Me.lblTodayHours.Name = "lblTodayHours"
        Me.lblTodayHours.Size = New System.Drawing.Size(119, 24)
        Me.lblTodayHours.TabIndex = 33
        Me.lblTodayHours.Text = "Today Hours"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Location = New System.Drawing.Point(15, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 30)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Overtime hours this week:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOvertimeHours
        '
        Me.lblOvertimeHours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOvertimeHours.Location = New System.Drawing.Point(322, 117)
        Me.lblOvertimeHours.Name = "lblOvertimeHours"
        Me.lblOvertimeHours.Size = New System.Drawing.Size(161, 25)
        Me.lblOvertimeHours.TabIndex = 31
        Me.lblOvertimeHours.Text = "Overtime Hours"
        '
        'lblHoursInWeek
        '
        Me.lblHoursInWeek.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursInWeek.Location = New System.Drawing.Point(323, 86)
        Me.lblHoursInWeek.Name = "lblHoursInWeek"
        Me.lblHoursInWeek.Size = New System.Drawing.Size(130, 25)
        Me.lblHoursInWeek.TabIndex = 29
        Me.lblHoursInWeek.Text = "Week Hours"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Location = New System.Drawing.Point(10, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Hours worked this week:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.LimeGreen
        Me.btnOK.Location = New System.Drawing.Point(219, 475)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 34)
        Me.btnOK.TabIndex = 37
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(17, 142)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(503, 29)
        Me.lblDate.TabIndex = 39
        Me.lblDate.Text = "DATE"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeColumns = False
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AssociateNameDataGridViewTextBoxColumn, Me.TimeFieldDataGridViewTextBoxColumn, Me.InOutDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.KeyDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.PunchEventTableBindingSource
        Me.dgvData.Location = New System.Drawing.Point(115, 174)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(308, 150)
        Me.dgvData.TabIndex = 40
        '
        'AssociateNameDataGridViewTextBoxColumn
        '
        Me.AssociateNameDataGridViewTextBoxColumn.DataPropertyName = "AssociateName"
        Me.AssociateNameDataGridViewTextBoxColumn.HeaderText = "AssociateName"
        Me.AssociateNameDataGridViewTextBoxColumn.Name = "AssociateNameDataGridViewTextBoxColumn"
        Me.AssociateNameDataGridViewTextBoxColumn.Visible = False
        '
        'TimeFieldDataGridViewTextBoxColumn
        '
        Me.TimeFieldDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TimeFieldDataGridViewTextBoxColumn.DataPropertyName = "TimeField"
        Me.TimeFieldDataGridViewTextBoxColumn.HeaderText = "TimeField"
        Me.TimeFieldDataGridViewTextBoxColumn.Name = "TimeFieldDataGridViewTextBoxColumn"
        Me.TimeFieldDataGridViewTextBoxColumn.Width = 77
        '
        'InOutDataGridViewTextBoxColumn
        '
        Me.InOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InOutDataGridViewTextBoxColumn.DataPropertyName = "InOut"
        Me.InOutDataGridViewTextBoxColumn.HeaderText = "InOut"
        Me.InOutDataGridViewTextBoxColumn.Name = "InOutDataGridViewTextBoxColumn"
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "Key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.Visible = False
        '
        'PunchEventTableBindingSource
        '
        Me.PunchEventTableBindingSource.DataMember = "PunchEventTable"
        Me.PunchEventTableBindingSource.DataSource = Me.TTDataSet
        '
        'TTDataSet
        '
        Me.TTDataSet.DataSetName = "TTDataSet"
        Me.TTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PunchEventTableTableAdapter
        '
        Me.PunchEventTableTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEvent)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 127)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Information"
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(547, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpInformation)
        Me.Name = "frmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        Me.grpInformation.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PunchEventTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpInformation As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBreakOverage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTodayHours As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOvertimeHours As System.Windows.Forms.Label
    Friend WithEvents lblHoursInWeek As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents AssociateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents TTDataSet As TimeTracker.TTDataSet
    Friend WithEvents PunchEventTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PunchEventTableTableAdapter As TimeTracker.TTDataSetTableAdapters.PunchEventTableTableAdapter
    Friend WithEvents AssociateNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
