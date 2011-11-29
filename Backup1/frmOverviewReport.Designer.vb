<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverviewReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.TimedOverviewReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTDataSet = New TimeTracker.TTDataSet
        Me.NonTimedReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TimedOverviewReportTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.TimedOverviewReportTableTableAdapter
        Me.NonTimedReportTableTableAdapter = New TimeTracker.TTDataSetTableAdapters.NonTimedReportTableTableAdapter
        CType(Me.TimedOverviewReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonTimedReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimedOverviewReportTableBindingSource
        '
        Me.TimedOverviewReportTableBindingSource.DataMember = "TimedOverviewReportTable"
        Me.TimedOverviewReportTableBindingSource.DataSource = Me.TTDataSet
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "timetrackerDataSet_TimedOverview"
        ReportDataSource1.Value = Me.TimedOverviewReportTableBindingSource
        ReportDataSource2.Name = "timetrackerDataSet_NonTimed"
        ReportDataSource2.Value = Me.NonTimedReportTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TimeTracker.Overview.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(541, 432)
        Me.ReportViewer1.TabIndex = 0
        '
        'TimedOverviewReportTableTableAdapter
        '
        Me.TimedOverviewReportTableTableAdapter.ClearBeforeFill = True
        '
        'NonTimedReportTableTableAdapter
        '
        Me.NonTimedReportTableTableAdapter.ClearBeforeFill = True
        '
        'frmOverviewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 432)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOverviewReport"
        Me.Text = "Overview Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TimedOverviewReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonTimedReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TTDataSet As TimeTracker.TTDataSet
    Friend WithEvents TimedOverviewReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimedOverviewReportTableTableAdapter As TimeTracker.TTDataSetTableAdapters.TimedOverviewReportTableTableAdapter
    Friend WithEvents NonTimedReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NonTimedReportTableTableAdapter As TimeTracker.TTDataSetTableAdapters.NonTimedReportTableTableAdapter
End Class
