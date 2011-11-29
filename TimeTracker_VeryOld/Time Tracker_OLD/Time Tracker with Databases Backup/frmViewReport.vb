Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmViewReport

    Dim ReportStartDate As Date
    Dim ReportEndDate As Date

    Private Sub frmViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim ThisWeekReport As MsgBoxResult

        ThisWeekReport = MsgBox("Would you like to run the time report for this week?", MsgBoxStyle.YesNoCancel)

        If ThisWeekReport = MsgBoxResult.Yes Then
            ReportEndDate = Now.Date
            ReportStartDate = ReportEndDate.AddDays(-6) 'the day before this day in the previous week
        ElseIf ThisWeekReport = MsgBoxResult.Cancel Then
            'do nothing
        ElseIf ThisWeekReport = MsgBoxResult.No Then
            'pick the start date and end date of the report
            frmGetDate.lblReason.Text = "Select the date to start the report"
            If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ReportStartDate = frmGetDate.cldDate.SelectionStart
            End If

            frmGetDate.lblReason.Text = "Select the date to end the report"
            If frmGetDate.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ReportEndDate = frmGetDate.cldDate.SelectionStart
            End If

            

        End If

        Dim DateCounter As Integer = 0
        Dim DaysInReport As TimeSpan

        'MsgBox(ReportStartDate)
        'MsgBox(ReportEndDate)

        DaysInReport = ReportEndDate.Subtract(ReportStartDate)

        'MsgBox(DaysInReport.Days)

        Dim ReportDates(DaysInReport.Days) As Date

        For DateCounter = 0 To DaysInReport.Days
            ReportDates(DateCounter) = ReportStartDate.AddDays(DateCounter)
        Next


        '*****************Timed Report***************
        ' Declare variables needed to pass the parameters
        ' to the viewer control.
        Dim ParamFields As New ParameterFields()
        Dim TimedParamField As New ParameterField()
        Dim TimedDiscreteVal As New ParameterDiscreteValue()
        Dim TimedAssociate As New Associate()
        Dim TimedAssociateList As ArrayList = GetAssociateList("Timed", "associatename")

        Dim CurrentTimedAssociateName As String
        Dim CurrentDay As Date
        Dim TotalHours As Double = 0
        Dim HoursInCurrentDay As Double = 0
        Dim NormalHours As Double = 0
        Dim OverTimeHours As Double = 0

        For Each CurrentTimedAssociateName In TimedAssociateList
            TimedAssociate = GetAssociateData(CurrentTimedAssociateName)

            TimedDiscreteVal.Value = TimedDiscreteVal.Value + vbCrLf + TimedAssociate.Name.ToString + vbCrLf

            For Each CurrentDay In ReportDates
                HoursInCurrentDay = CalculateHoursInDay(CurrentDay, TimedAssociate.Name)
                If HoursInCurrentDay > 0 Then
                    TimedDiscreteVal.Value = TimedDiscreteVal.Value + CurrentDay.DayOfWeek.ToString + ":" + HoursInCurrentDay.ToString + " "
                End If
            Next

            TotalHours = CalculateHoursInWeek(ReportDates(0), ReportDates(DaysInReport.Days), TimedAssociate.Name)

            If TotalHours > 40 Then
                NormalHours = 40
                OverTimeHours = TotalHours - 40
            Else
                NormalHours = TotalHours
            End If
            NormalHours = FormatNumber(NormalHours, 2)
            OverTimeHours = FormatNumber(OverTimeHours, 2)

            TimedDiscreteVal.Value = TimedDiscreteVal.Value + vbCrLf + "Normal Time: " + NormalHours.ToString + vbCrLf
            TimedDiscreteVal.Value = TimedDiscreteVal.Value + "Over Time: " + OverTimeHours.ToString + vbCrLf

        Next
        ' Set the field in the report we will write to
        TimedParamField.ParameterFieldName = "TimedReport"


        ' Add the parameter to the parameter fields collection.
        TimedParamField.CurrentValues.Add(TimedDiscreteVal)
        ParamFields.Add(TimedParamField)

        If EC = True Then
            MsgBox("Timed Report Created!")
        End If

        '*****************End Timed Report***************




        '*****************Commissioned Report***************
        ' Declare variables needed to pass the parameters
        ' to the viewer control.

        Dim CommissionedParamField As New ParameterField()
        Dim CommissionedDiscreteVal As New ParameterDiscreteValue()
        Dim CommissionedAssociate As New Associate

        Dim CommissionedAssociateList As ArrayList = GetAssociateList("commissioned", "associatename")
        ' Set the field in the report we will write to
        CommissionedParamField.ParameterFieldName = "CommissionedReport"

        Dim CommissionedCounter As Integer = 0
        For CommissionedCounter = 0 To CommissionedAssociateList.Count - 1
            CommissionedAssociate = GetAssociateData(CommissionedAssociateList(CommissionedCounter))

            CommissionedDiscreteVal.Value = CommissionedDiscreteVal.Value + vbCrLf + CommissionedAssociate.Name + vbCrLf + CommissionedAssociate.Social + vbCrLf + "Commission:"
        Next


        CommissionedParamField.CurrentValues.Add(CommissionedDiscreteVal)

        ' Add the parameter to the parameter fields collection.
        ParamFields.Add(CommissionedParamField)

        '*****************End Commissioned Report***************




        '*****************Manager Report***************
        ' Declare variables needed to pass the parameters
        ' to the viewer control.

        Dim ManagerParamField As New ParameterField()
        Dim ManagerDiscreteVal As New ParameterDiscreteValue()
        Dim ManagerAssociate As New Associate

        Dim ManagerAssociateList As ArrayList = GetAssociateList("manager", "associatename")

        ManagerParamField.ParameterFieldName = "ManagerReport"

        Dim ManagerCounter As Integer = 0

        For ManagerCounter = 0 To ManagerAssociateList.Count - 1
            ManagerAssociate = GetAssociateData(ManagerAssociateList(ManagerCounter))
            ManagerDiscreteVal.Value = ManagerDiscreteVal.Value + vbCrLf + ManagerAssociate.Name + vbCrLf + ManagerAssociate.Social

        Next

        ' Add the parameter to the parameter fields collection.
        ManagerParamField.CurrentValues.Add(ManagerDiscreteVal)
        ParamFields.Add(ManagerParamField)


        '*****************End Manager Report***************





        '***************SETUP REPORT*****************
        ' Set the parameter fields collection into the viewer control.
        CrystalReportViewer1.ParameterFieldInfo = ParamFields

        CrystalReportViewer1.ReportSource = WeeklyReport
        '****************END REPORT*******************
    End Sub

  
End Class