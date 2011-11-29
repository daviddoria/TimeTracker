Public Class frmWorking

    Private immobiliser As New FormImmobiliser(Me)

    Private Sub frmWorking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Style = ProgressBarStyle.Marquee
        'ProgressBar1.Value = 5
    End Sub
End Class