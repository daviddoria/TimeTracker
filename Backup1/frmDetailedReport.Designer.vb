<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailedReport
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TimedDetailedReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTDataSet = New TimeTracker.TTDataSet
        Me.NonTimedReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimedDetailedReportTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.TimedDetailedReportTableTableAdapter
        Me.NonTimedReportTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.NonTimedReportTableTableAdapter
        CType(Me.TimedDetailedReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonTimedReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "TTDataSet_TimedDetailedReportTable"
        ReportDataSource3.Value = Me.TimedDetailedReportTableBindingSource
        ReportDataSource4.Name = "TTDataSet_NonTimedReportTable"
        ReportDataSource4.Value = Me.NonTimedReportTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TimeTracker.Detailed.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(504, 404)
        Me.ReportViewer1.TabIndex = 0
        '
        'TimedDetailedReportTableBindingSource
        '
        Me.TimedDetailedReportTableBindingSource.DataMember = "TimedDetailedReportTable"
        Me.TimedDetailedReportTableBindingSource.DataSource = Me.TTDataSet
        '
        'TTDataSet
        '
        Me.TTDataSet.DataSetName = "TTDataSet"
        Me.TTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NonTimedReportTableBindingSource
        '
        Me.NonTimedReportTableBindingSource.DataMember = "NonTimedReportTable"
        Me.NonTimedReportTableBindingSource.DataSource = Me.TTDataSet
        '
        'TimedDetailedReportTableTableAdapter
        '
        Me.TimedDetailedReportTableTableAdapter.ClearBeforeFill = True
        '
        'NonTimedReportTableTableAdapter
        '
        Me.NonTimedReportTableTableAdapter.ClearBeforeFill = True
        '
        'frmDetailedReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 404)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailedReport"
        Me.Text = "Detailed Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TimedDetailedReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonTimedReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TTDataSet As TimeTracker.TTDataSet
    Friend WithEvents TimedDetailedReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimedDetailedReportTableTableAdapter As TimeTracker.TTDataSetTableAdapters.TimedDetailedReportTableTableAdapter
    Friend WithEvents NonTimedReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NonTimedReportTableTableAdapter As TimeTracker.TTDataSetTableAdapters.NonTimedReportTableTableAdapter
End Class
