Public Class frmPayroll

    Private immobiliser As New FormImmobiliser(Me)

    Private Sub frmPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtName.Text = Company.PayrollContact
        txtFax.text = Company.FaxNumber

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        LogClick(sender)

        Company.PayrollContact = txtName.Text
        Company.FaxNumber = txtFax.Text
        Company.WriteCompany()

        Me.Dispose()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        LogClick(sender)
        Me.Dispose()
    End Sub
End Class