Imports System.Collections.Generic
Imports System.ComponentModel

Public Class frmViewAssociateTime
    Private immobiliser As New FormImmobiliser(Me)

    Public strDayTime As String = "INVALID"
    Public strNormalHours As String = "INVALID"
    Public strOvertimeHours As String = "INVALID"
    Public SelectedDate As Date
    Public SelectedAssociateName As String

    Dim WithEvents backgroundWorker1 As New BackgroundWorker

    Private Sub CallUpdateForm()
        frmWorking.Show(Me)
        backgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        UpdateForm()
    End Sub

    Private Sub frmViewAssociateTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstAssociates, AssociateType.TIMED)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        LogClick(sender)
        Me.Dispose()
    End Sub

    Private Sub lstAssociates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAssociates.SelectedIndexChanged
        LogListBoxSelection(sender)
        MonthCalendar1.Visible = True

        Dim NewName As String = lstAssociates.SelectedItem.ToString()
        If NewName = SelectedAssociateName Then
            Exit Sub
        Else
            SelectedAssociateName = NewName
        End If


        SelectedDate = MonthCalendar1.SelectionRange.Start
        CallUpdateForm()
        'Dim NewDate As Date = MonthCalendar1.SelectionRange.Start

        'If SelectedDate = NewDate Then
        '    Exit Sub
        'Else
        '    SelectedDate = NewDate
        '    CallUpdateForm()
        'End If

    End Sub

    Private Sub UpdateForm()

        Dim SelectedAssociate As New Associate(SelectedAssociateName)

        'Day hours
        Dim EventsOnDay As List(Of PunchEvent) = SelectedAssociate.GetEvents(SelectedDate, EventReason.ALL)

        Dim Hours As DailyHours = SelectedAssociate.CalculateDailyHours(EventsOnDay)
        If Hours.Valid = True Then
            strDayTime = FormatNumber(Hours.TotalTime, 2)
        Else
            'strDayTime = "DAY INVALID"
            strDayTime = "INVALID"
        End If


        'Week hours
        Dim DaysInWeek As List(Of Date) = GetDaysInWeek(GetWeekStart(SelectedDate), SelectedDate)
        Dim WeekHours As WeeklyHours = SelectedAssociate.CalculateTimeInWeek(DaysInWeek)

        If WeekHours.Valid = True Then
            strNormalHours = FormatNumber(WeekHours.NormalTime, 2)
            strOvertimeHours = FormatNumber(WeekHours.OverTime, 2)
        Else
            'strNormalHours = "NORMAL INVALID"
            'strOvertimeHours = "OVERTIME INVALID"
            strNormalHours = "INVALID"
            strOvertimeHours = "INVALID"
        End If

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim NewDate As Date = MonthCalendar1.SelectionRange.Start

        If SelectedDate = NewDate Then
            Exit Sub
        Else
            SelectedDate = NewDate
            CallUpdateForm()
        End If

    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        frmWorking.Dispose()

        lblDayTime.Text = strDayTime
        lblWeekNormalHours.Text = strNormalHours
        lblWeekOvertimeHours.Text = strOvertimeHours

    End Sub
End Class