Imports System.IO

Public Class frmEmailReports

    Private immobiliser As New FormImmobiliser(Me)

    Dim LatestOverview As String
    Dim LatestDetailed As String

    Private Function GetDateStringFromString(ByVal DateString As String) As String
        Dim Parts() As String
        Parts = DateString.Split(Convert.ToChar("_"))
        Dim FileType As String = Parts(0)

        Dim DateExtension As String = Parts(1)

        Dim Parts2() As String
        Parts2 = DateExtension.Split(Convert.ToChar("."))
        Dim ReturnDateString As String = Parts2(0)

        Return ReturnDateString
    End Function

    Private Function GetFileType(ByVal FileString As String) As String
        Dim Parts() As String
        Parts = FileString.Split(Convert.ToChar("_"))
        Dim FileType As String = Parts(0)
        Return FileType
    End Function

    Private Function GetLatestFile(ByVal TypeToGet As String) As String
        Dim di As New IO.DirectoryInfo("C:\Time Tracker\Reports")
        Dim PDFArray As IO.FileInfo() = di.GetFiles("*.pdf")
        Dim PDFs As New List(Of IO.FileInfo)(PDFArray)

        Dim ReportDates As New List(Of Date)
        Dim ReportDateStrings As New List(Of String)

        For Each PDF As IO.FileInfo In PDFs
            Dim FileString As String = PDF.Name
            If GetFileType(FileString) <> TypeToGet Then
                Continue For
            End If
            Dim FileDateString As String = GetDateStringFromString(FileString)
            ReportDates.Add(Convert.ToDateTime(FileDateString))
            ReportDateStrings.Add(FileDateString)
        Next

        If ReportDates.Count = 0 Then
            Return ""
        End If


        ReportDates.Sort()

        For i As Integer = 0 To ReportDates.Count
            If Convert.ToDateTime(ReportDateStrings(i)) = ReportDates(ReportDates.Count - 1) Then
                Return TypeToGet + "_" + ReportDateStrings(i) + ".pdf"
            End If
        Next

    End Function

    Private Sub frmEmailReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txtTo.Text = "daviddoria@gmail.com"
        txtTo.Text = "nick@kwikkopy.com"
        txtSubject.Text = "Time Reports " + Now.ToShortDateString

        LatestOverview = GetLatestFile("overview")
        LatestDetailed = GetLatestFile("detailed")

        If LatestDetailed = "" Then
            cbxDetailed.Text = "Detailed: NONE"
        Else
            cbxDetailed.Text = "Detailed " + GetDateStringFromString(LatestDetailed)

            'this doesn't work correctly !!!
            'If GetDateStringFromString(LatestDetailed) <> Now.ToShortDateString Then
            '    MessageBox.Show("Warning: you did not run this report today.")
            'End If
        End If

        If LatestOverview = "" Then
            cbxOverview.Text = "Overview: NONE"
        Else
            cbxOverview.Text = "Overview " + GetDateStringFromString(LatestOverview)
            If GetDateStringFromString(LatestOverview) <> Now.ToShortDateString Then
                MessageBox.Show("Warning: you did not run this report today.")
            End If
        End If


    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        LogClick(sender)
        btnSend.Enabled = False
        btnBack.Enabled = False

        Dim SendDetailed As Boolean = cbxDetailed.Checked
        Dim SendOverview As Boolean = cbxOverview.Checked

        If SendOverview = False And SendDetailed = False Then
            MessageBox.Show("Please select a report!")
            ResetForm()
            Exit Sub
        End If

        '
        SendReportEmail(txtTo.Text, SendDetailed, SendOverview)
        SendReportEmail("daviddoria@gmail.com", SendDetailed, SendOverview)

        If SendOverview = True And SendDetailed = False Then
            MessageBox.Show("Sent Overview Report!")
        End If

        If SendOverview = False And SendDetailed = True Then
            MessageBox.Show("Sent Detailed Report!")
        End If

        If SendOverview = True And SendDetailed = True Then
            MessageBox.Show("Sent Detailed and Overview Report!")
        End If

        ResetForm()

    End Sub

    Private Sub SendReportEmail(ByVal strToAddress As String, ByVal SendDetailed As Boolean, ByVal SendOverview As Boolean)

        ' Load credentials from file

        Dim EmailCredentialsFilename As String = "c:\Time Tracker\EmailCredentials.txt"
        If Not File.Exists(EmailCredentialsFilename) Then
            Throw New System.Exception(EmailCredentialsFilename + " does not exist!")
        End If

        Dim EmailCredentialsLines() As String = File.ReadAllLines(EmailCredentialsFilename)

        Dim EmailUsername As String = EmailCredentialsLines(0)
        Dim EmailPassword As String = EmailCredentialsLines(1)
        Dim EmailSMTPServer As String = EmailCredentialsLines(2)
        Dim EmailSMTPPort As Integer = Convert.ToInt32(EmailCredentialsLines(3))

        'MsgBox("Username: " + EmailUsername + " pw: " + EmailPassword)

        Dim EmailFrom As String = "service@kwikkopy.com"
        Dim EmailTo As String = strToAddress
        Dim EmailSubject As String = txtSubject.Text
        Dim EmailBody As String = "Time Tracker Reports Email"

        Dim email As New Net.Mail.MailMessage(EmailFrom, EmailTo, EmailSubject, EmailBody)

        Dim OverviewFile As String = "c:\Time Tracker\Reports\" + LatestOverview
        If (System.IO.File.Exists(OverviewFile) = True) And cbxOverview.Checked = True Then
            email.Attachments.Add(New Net.Mail.Attachment(OverviewFile))
        End If

        Dim DetailedFile As String = "c:\Time Tracker\Reports\" + LatestDetailed
        If (System.IO.File.Exists(DetailedFile) = True) And cbxDetailed.Checked = True Then
            email.Attachments.Add(New Net.Mail.Attachment(DetailedFile))
        End If

        '** Overriding the certificate validation check.
        Net.ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True

        Dim emailClient As New Net.Mail.SmtpClient(EmailSMTPServer, EmailSMTPPort)
        emailClient.EnableSsl = True
        emailClient.Credentials = New Net.NetworkCredential(EmailUsername, EmailPassword)

        emailClient.Send(email)
    End Sub

    Private Sub ResetForm()
        btnSend.Enabled = True
        btnBack.Enabled = True
    End Sub
    Private Sub cbxDetailed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDetailed.CheckedChanged
        If cbxDetailed.Checked = True Or cbxOverview.Checked = True Then
            btnSend.Enabled = True
        Else
            btnSend.Enabled = False
        End If
    End Sub

    Private Sub cbxOverview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOverview.CheckedChanged
        If cbxDetailed.Checked = True Or cbxOverview.Checked = True Then
            btnSend.Enabled = True
        Else
            btnSend.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        LogClick(sender)
        Me.Dispose()
    End Sub
End Class