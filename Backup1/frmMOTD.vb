Public Class frmMOTD
    'don't allow the form to move
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub frmMOTD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'if there is no message of the day in the database, check the "no message" box
        'otherwise, put the message of the day in the text box
        If Company.MOTD = "" Then
            cbxNoMessage.CheckState = CheckState.Checked
        Else
            txtMessage.Text = Company.MOTD
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        LogClick(sender)
        'if the "no message" check box is checked, set the message to an empty string
        'else, set the message to the contents of the textbox
        If cbxNoMessage.CheckState = CheckState.Checked Then
            Company.MOTD = ""
        Else
            Company.MOTD = txtMessage.Text
        End If

        'save the company (all that should have changed is the message of the day) to the database
        Company.WriteCompany()

        'close the "message of the day" form
        Me.Dispose()

    End Sub

    Private Sub cbxNoMessage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNoMessage.CheckedChanged
        'when the "no message" check box is checked, disable the text box
        'when it is unchecked, re-enable the textbox
        If cbxNoMessage.CheckState = CheckState.Checked Then
            txtMessage.Enabled = False
        Else
            txtMessage.Enabled = True
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        LogClick(sender)
        'close the message of the day form
        Me.Dispose()
    End Sub
End Class