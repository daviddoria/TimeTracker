Public Class InitialConfig

    Public Sub FirstRun()
        'This function is only run if the database has not yet been configured

        MsgBox("Welcome to Time Tracker! The next few prompts will collect necessary information about your company. Click OK to continue.")
        Company.Name = InputBox("What is your company's name?") 'stored as global, needed for report
        Dim PayrollDay As String = InputBox("What day does your pay week end? (please use Mon, Tue, Wed, etc.")
        Company.FaxNumber = InputBox("What is your payroll office's fax number?") 'stored as global, needed for report
        Company.PayrollContact = InputBox("Who is your payroll contact?") 'stored as global, needed for report

        CompanyData.Tables("companyTable").Rows(0).Item("companyname") = Company.Name
        CompanyData.Tables("companyTable").Rows(0).Item("payday") = PayrollDay
        CompanyData.Tables("companyTable").Rows(0).Item("payrollfaxnumber") = Company.FaxNumber
        CompanyData.Tables("companyTable").Rows(0).Item("payrollcontact") = Company.PayrollContact

        PutDataSet(CompanyData, "companyTable")

        MsgBox("On the next screen, you will create your first account!  You can then login using this account to continue setting up the program.")

        Dim newfrmAddAssociate As New frmAddAssociate
        'newfrmAddAssociate.Show()
        If Not newfrmAddAssociate.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MsgBox("There was an error creating your first account")
        Else
            MsgBox("The program must be restarted for your new settings to take effect.")
            End
        End If
    End Sub

End Class