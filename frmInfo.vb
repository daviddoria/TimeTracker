Imports System.Collections.Generic

Public Class frmInfo
    Private immobiliser As New FormImmobiliser(Me)

    Private Sub EndOfDayInfo()

        'calculate week hours
        Dim DaysInWeek As List(Of Date) = GetDaysInWeek(GetWeekStart(Now), Now)
        Dim WeekHours As WeeklyHours = AssociateLoggedIn.CalculateTimeInWeek(DaysInWeek)
        If WeekHours.Valid = True Then
            lblHoursInWeek.Text = FormatNumber(WeekHours.NormalTime, 2)
            lblOvertimeHours.Text = FormatNumber(WeekHours.OverTime, 2)
        Else
            lblHoursInWeek.Text = "Incomplete"
            lblOvertimeHours.Text = "Incomplete"
        End If

        'calculate hours at the end of the day
        Dim EventsInDay As List(Of PunchEvent) = AssociateLoggedIn.GetEvents(Now, EventReason.ALL)
        Dim Hours As DailyHours = AssociateLoggedIn.CalculateDailyHours(EventsInDay)

        If Hours.Valid = True Then
            lblTodayHours.Text = FormatNumber(Hours.TotalTime, 2)
            lblBreakOverage.Text = FormatNumber(Hours.BreakOverage, 2)
            grpInformation.Enabled = True
        Else
            lblTodayHours.Text = "Incomplete"
            lblBreakOverage.Text = ""
            grpInformation.Enabled = False
        End If

        grpInformation.Visible = True

    End Sub

    Private Sub frmInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PunchEventTableTableAdapter.FillByAssociateDateReason(Me.TTDataSet.PunchEventTable, AssociateLoggedIn.Name, "%", Now.Date.ToShortDateString)

        dgvData.ClearSelection()
        'so the clicked cell/row is not highlighted blue, but this makes the text white too !!!
        'dgvData.DefaultCellStyle.SelectionBackColor = Color.White 

        lblTime.Text = Now.ToShortTimeString
        lblDate.Text = "Summary of " + Now.ToShortDateString

        Dim LastEvent As PunchEvent = AssociateLoggedIn.GetLastEvent()

        'Explain the event
        If LastEvent.Direction = EventDirection.DirectionIn Then
            If LastEvent.Reason = EventReason.DAY Then
                lblEvent.Text = "You have been automatically logged in for the day."
            ElseIf LastEvent.Reason = EventReason.LUNCH Then
                lblEvent.Text = "You have been automatically logged in from lunch."
            ElseIf LastEvent.Reason = EventReason.BREAK Then
                lblEvent.Text = "You have been automatically logged in from a break."
            End If

        ElseIf LastEvent.Direction = EventDirection.DirectionOut Then
            If LastEvent.Reason = EventReason.DAY Then
                lblEvent.Text = "You have logged out for the day."
                EndOfDayInfo()
            ElseIf LastEvent.Reason = EventReason.LUNCH Then
                lblEvent.Text = "You have logged out for lunch."
            ElseIf LastEvent.Reason = EventReason.BREAK Then
                lblEvent.Text = "You have logged out for a break."
            End If
        Else
            MessageBox.Show("Problem with time (info page)!")
            End
        End If



    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        LogClick(sender)
        Me.Dispose()
    End Sub
End Class