Public Class frmGetDate

    Private Sub frmGetDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cldDate.SetDate(Now.Date)
    End Sub
End Class