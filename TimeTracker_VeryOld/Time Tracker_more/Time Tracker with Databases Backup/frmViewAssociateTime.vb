Public Class frmViewAssociateTime

    Private Sub frmViewAssociateTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNameListBox(lstAssociates, "timed")
    End Sub

    Private Sub lstAssociates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAssociates.SelectedIndexChanged
        If lstAssociates.SelectedIndex > -1 Then
            btnCurrentDay.Enabled = True
            btnCurrentWeek.Enabled = True
            btnPreviousDay.Enabled = True
            btnPreviousWeek.Enabled = True

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCurrentDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentDay.Click
        MsgBox(lstAssociates.SelectedItem & " has worked " & CalculateHoursInDay(Now.Date, lstAssociates.SelectedItem) & " today.")
    End Sub

    Private Sub btnPreviousDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousDay.Click
        Dim PreviousDay As Date

        frmGetDate.lblReason.Text = "Select a date:"

        If frmGetDate.ShowDialog = Windows.Forms.DialogResult.OK Then
            PreviousDay = frmGetDate.cldDate.SelectionStart
        End If
        MsgBox(lstAssociates.SelectedItem & " has worked " & CalculateHoursInDay(PreviousDay, lstAssociates.SelectedItem) & " today.")

    End Sub

    Private Sub btnCurrentWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentWeek.Click
        Dim StartDay As Date = GetWeekStart(Now.Date)
        Dim HoursWorked As Double = CalculateHoursInWeek(StartDay, StartDay.AddDays(6), lstAssociates.SelectedItem)
        MsgBox(lstAssociates.SelectedItem & " worked " & HoursWorked & " hours this week.")
    End Sub

    Private Sub btnPreviousWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousWeek.Click
        Dim StartingDate As Date
        Dim HoursWorked As Double

        frmGetDate.lblReason.Text = "Select starting date:"

        If frmGetDate.ShowDialog = Windows.Forms.DialogResult.OK Then
            StartingDate = frmGetDate.cldDate.SelectionStart
        End If

        HoursWorked = CalculateHoursInWeek(StartingDate, StartingDate.AddDays(6), lstAssociates.SelectedItem)

        MsgBox(lstAssociates.SelectedItem & " worked " & HoursWorked & " hours in that week.")


    End Sub
End Class