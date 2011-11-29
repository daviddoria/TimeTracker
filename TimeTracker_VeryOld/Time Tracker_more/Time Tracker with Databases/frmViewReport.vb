Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmViewReport

    Private Sub frmViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '***************SETUP REPORT*****************
        ' Set the parameter fields collection into the viewer control.
        CrystalReportViewer1.ParameterFieldInfo = frmManager.ParamFields

        CrystalReportViewer1.ReportSource = WeeklyReport
        '****************END REPORT*******************

    End Sub

End Class