Imports System.ComponentModel

Public Class frmCreateReport

    'so the form cannot be moved
    Private immobiliser As New FormImmobiliser(Me)

    Dim WithEvents backgroundWorker1 As New BackgroundWorker

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        'A background worker is used so that a marquee progress bar can be used to indicate
        'that some processing is taking place at the same time as (in parallel with) the actual processing

        'MessageBox.Show("doWork()")

        Dim StartDate As System.DateTime = DirectCast(e.Argument, System.DateTime())(0)
        'MessageBox.Show("StartDate fixed: " + StartDate.ToShortDateString)

        'declare a variable to get the result of the operation
        Dim ReportSuccessful As Boolean

        'generate and display a different report based on the radio button selection
        If radDetailed.Checked = True Then
            'MessageBox.Show("Running detailed DoWork() " + StartDate.ToString + " " + StartDate.AddDays(6).ToString)
            Try
                ReportSuccessful = CreateDetailedReport(StartDate, StartDate.AddDays(6)) 'to get to the day before the next payday
            Catch ex As Exception
                MsgBox("CreateDetailedReport() threw an exception!" & vbCrLf & ex.Message)
            End Try
            'MessageBox.Show("Created detailed report.")
            frmDetailedReport.ShowDialog()
        ElseIf radOverview.Checked = True Then
            'MessageBox.Show("Running overview...")
            Try
                ReportSuccessful = CreateTwoWeekReport(StartDate, StartDate.AddDays(13)) 'to get to the day before the next payday
            Catch ex As Exception
                MsgBox("CreateDetailedReport() threw an exception!" & vbCrLf & ex.Message)
            End Try
            
            frmOverviewReport.ShowDialog()
        End If

        'display the result of the operation
        If ReportSuccessful = True Then
            'MessageBox.Show("Report successful!")
        Else
            MessageBox.Show("Report failed!")
        End If

    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        'This is triggered when backgroundWorker1_DoWork is done

        'close the progress bar form
        frmWorking.Dispose()

        're-enable the Generate Reports form
        btnGenerate.Text = "Generate"
        btnGenerate.Enabled = True
        btnBack.Enabled = True

        'MessageBox.Show("Worker completed.")
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        LogClick(sender)
        'disable the Generate Reports form
        btnGenerate.Text = "Generating..."
        btnGenerate.Enabled = False
        btnBack.Enabled = False

        'display the form with the marquee progress bar
        frmWorking.Show(Me)

        'MessageBox.Show("Starting worker.")
        Dim Arguments() As System.DateTime = {dtpStart.Value}
        backgroundWorker1.RunWorkerAsync(Arguments)


    End Sub

    Private Sub radDetailed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDetailed.CheckedChanged

        'If the "detailed" radio button is checked, then set the date/time picker to the beginning of the current payroll week
        If radDetailed.Checked = True Then
            dtpStart.Value = GetWeekStart(Now.Date)
        End If


        DisplayCurrentPayperiod()

    End Sub

    Private Sub radOverview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOverview.CheckedChanged

        'If the "overview" radio button is checked, then set the date/time picker to the beginning of the current payroll period (2 weeks)
        If radOverview.Checked = True Then
            dtpStart.Value = GetTwoWeekStart(Now.Date)
        End If

        DisplayCurrentPayperiod()

    End Sub

    Private Sub DisplayCurrentPayperiod()
        btnGenerate.Enabled = True

        lblStandard.Text = "Current PayPeriod"
        lblStandard.ForeColor = Color.Green

        dtpStart.Enabled = True

    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        If Not dtpStart.Value.Date.DayOfWeek = DayOfWeek.Thursday Then
            'snap to the closest PayDay before the selected day

            dtpStart.Value = GetWeekStart(dtpStart.Value)

            Exit Sub
        End If

        lblStandard.Text = "Previous PayPeriod"
        lblStandard.ForeColor = Color.Red
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        LogClick(sender)
        'close the form
        Me.Dispose()
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        LogClick(sender)
        'show the form to send an email with the reports
        btnEmail.Enabled = False

        frmEmailReports.ShowDialog()
        btnEmail.Enabled = True

    End Sub
End Class
