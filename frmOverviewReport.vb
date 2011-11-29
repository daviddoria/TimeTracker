Public Class frmOverviewReport
    'this form displays the overview report and saves it to a pdf

    Private Sub frmOverviewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TTDataSet.NonTimedReportTable' table. You can move, or remove it, as needed.
        Me.NonTimedReportTableTableAdapter.Fill(Me.TTDataSet.NonTimedReportTable)
        'TODO: This line of code loads data into the 'TTDataSet.TimedOverviewReportTable' table. You can move, or remove it, as needed.
        Me.TimedOverviewReportTableTableAdapter.Fill(Me.TTDataSet.TimedOverviewReportTable)

        Me.ReportViewer1.RefreshReport()

        Dim bytes As Byte()

        bytes = ReportViewer1.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim fs As New IO.FileStream("c:\Time Tracker\Reports\overview_" + Now.ToString("MM-dd-yy") + ".pdf", IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()

    End Sub
End Class