Imports System.Collections.Generic

Module ReportCreation


    Public Function GetReportDates(ByVal StartDate As Date, ByVal EndDate As Date) As Date()
        Dim DaysInReport As TimeSpan = EndDate.Subtract(StartDate)

        Dim ReportDates(DaysInReport.Days) As Date

        For DateCounter As Integer = 0 To DaysInReport.Days
            ReportDates(DateCounter) = StartDate.AddDays(DateCounter)
        Next

        Return ReportDates
    End Function

    Public Function CreateTwoWeekReport(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean 'overview

        'create parameter list
        Dim paramList As New Generic.List(Of Microsoft.Reporting.WinForms.ReportParameter)

        'set the dates of the report
        Dim ReportDates As Date() = GetReportDates(StartDate, EndDate)

        Dim strDates As String = ReportDates(0).ToShortDateString + " to " + _
                                ReportDates(ReportDates.Length - 1).ToShortDateString
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDates", strDates))


        'setup the report header

        Dim strSubject As String = "Kwik Kopy Payroll"
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmSubject", strSubject))

        Dim strTo As String = Company.PayrollContact + ", Fax: " + Company.FaxNumber
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmTo", strTo))

        Dim strFrom As String = Company.OwnerName + " , Phone: " + Company.Phone + " , Client #: " + Company.PayrollClientNumber
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmFrom", strFrom))

        'assign the parameter list to the report
        frmOverviewReport.ReportViewer1.LocalReport.SetParameters(paramList) '!!! does not exist

        CreateTimedOverviewTable(ReportDates)
        CreateNonTimedTable()

        Return True

    End Function

    Public Function CreateDetailedReport(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
        
        'Create list of parameters
        Dim paramList As New Generic.List(Of Microsoft.Reporting.WinForms.ReportParameter)

        
        'Set report dates on the report
        Dim ReportDates As Date() = GetReportDates(StartDate, EndDate)
        Dim strDates As String = ReportDates(0).ToShortDateString + " to " + _
                                ReportDates(ReportDates.Length - 1).ToShortDateString
        paramList.Add(New Microsoft.Reporting.WinForms.ReportParameter("prmDates", strDates))

        'assign the parameter list to the report
        frmDetailedReport.ReportViewer1.LocalReport.SetParameters(paramList)


        CreateTimedDetailedTable(ReportDates)
        CreateNonTimedTable()

        Return True

    End Function

    Public Sub CreateTimedDetailedTable(ByVal ReportDates As Date())
        Dim dtTimedDetailed As New TTDataSet.TimedDetailedReportTableDataTable
        Dim daTimedDetailed As New TTDataSetTableAdapters.TimedDetailedReportTableTableAdapter

        Dim cmd As New OleDb.OleDbCommand("Delete * From TimedDetailedReportTable", daTimedDetailed.Connection)
        daTimedDetailed.Connection.Open()
        cmd.ExecuteNonQuery()
        daTimedDetailed.Connection.Close()

        Dim TimedAssociates As List(Of Associate) = GetAssociates(AssociateType.TIMED)

        For Each TimedAssociate As Associate In TimedAssociates

            'create a new row

            Dim NewRow As TTDataSet.TimedDetailedReportTableRow = DirectCast(dtTimedDetailed.NewRow, TTDataSet.TimedDetailedReportTableRow)

            'add all the attributes to the new row
            NewRow.Name = TimedAssociate.Name
            NewRow.Social = TimedAssociate.Social.ToString

            Dim HasHours As Boolean = False

            For Each CurrentDay As Date In ReportDates
                Dim AllEventsOnDay As List(Of PunchEvent) = TimedAssociate.GetEvents(CurrentDay, EventReason.ALL)

                Dim HoursInCurrentDay As DailyHours = TimedAssociate.CalculateDailyHours(AllEventsOnDay)
                If HoursInCurrentDay.Valid = True Then
                    NewRow.Item(CurrentDay.DayOfWeek.ToString) = Convert.ToDouble(FormatNumber(HoursInCurrentDay.TotalTime, 2))
                Else
                    'the magic number for invalid on the report is -1
                    NewRow.Item(CurrentDay.DayOfWeek.ToString) = -1
                End If
            Next

            'MessageBox.Show("ReportStart: " + ReportDates(0))
            'MessageBox.Show("ReportEnd: " + ReportDates(ReportDates.Length - 1))

            Dim DaysInWeek As List(Of Date) = GetDaysInWeek(ReportDates(0), ReportDates(ReportDates.Length - 1))
            Dim WeekHours As WeeklyHours = TimedAssociate.CalculateTimeInWeek(DaysInWeek)

            If WeekHours.Valid = True Then
                NewRow.Normal = Convert.ToDouble(FormatNumber(WeekHours.NormalTime, 2))
                NewRow.Overtime = Convert.ToDouble(FormatNumber(WeekHours.OverTime, 2))
            Else
                'the magic number for invalid on the report is -1
                NewRow.Normal = -1
                NewRow.Overtime = -1
            End If

            dtTimedDetailed.Rows.Add(NewRow)

        Next 'next associate

        'update the database
        daTimedDetailed.Update(dtTimedDetailed)

    End Sub

    Public Sub CreateNonTimedTable()

        Dim dtNonTimed As New TTDataSet.NonTimedReportTableDataTable
        Dim daNonTimed As New TTDataSetTableAdapters.NonTimedReportTableTableAdapter

        Dim cmd As New OleDb.OleDbCommand("Delete * From NonTimedReportTable", daNonTimed.Connection)
        daNonTimed.Connection.Open()
        cmd.ExecuteNonQuery()
        daNonTimed.Connection.Close()


        Dim ManagerAssociates As List(Of Associate) = GetAssociates(AssociateType.MANAGER)
        Dim CommissionedAssociates As List(Of Associate) = GetAssociates(AssociateType.COMMISSIONED)

        'combine the managers and commissioned associates into one list
        Dim NonTimedAssociates As List(Of Associate) = ManagerAssociates
        NonTimedAssociates.AddRange(CommissionedAssociates)
        
        For Each NonTimedAssociate As Associate In NonTimedAssociates

            'create a new row
            Dim NewRow As TTDataSet.NonTimedReportTableRow = DirectCast(dtNonTimed.NewRow, TTDataSet.NonTimedReportTableRow)
            NewRow.Name = NonTimedAssociate.Name
            NewRow.Social = NonTimedAssociate.Social.ToString

            dtNonTimed.Rows.Add(NewRow)
        Next

        daNonTimed.Update(dtNonTimed)

    End Sub

    Public Sub CreateTimedOverviewTable(ByVal ReportDates As Date())

        Dim dtTimedOverview As New TTDataSet.TimedOverviewReportTableDataTable
        Dim daTimedOverview As New TTDataSetTableAdapters.TimedOverviewReportTableTableAdapter

        Dim cmd As New OleDb.OleDbCommand("Delete * From TimedOverviewReportTable", daTimedOverview.Connection)
        daTimedOverview.Connection.Open()
        cmd.ExecuteNonQuery()
        daTimedOverview.Connection.Close()

        Dim TimedAssociates As List(Of Associate) = GetAssociates(AssociateType.TIMED)

        For Each TimedAssociate As Associate In TimedAssociates

            'create a new row
            Dim NewRow As TTDataSet.TimedOverviewReportTableRow = DirectCast(dtTimedOverview.NewRow, TTDataSet.TimedOverviewReportTableRow)

            NewRow.Name = TimedAssociate.Name
            NewRow.Social = TimedAssociate.Social.ToString

            Dim Payperiod As PayperiodHours = GetPayperiodHours(TimedAssociate, ReportDates(ReportDates.Length - 1))

            If Payperiod.Valid = True Then
                NewRow.Normal = Convert.ToDouble(FormatNumber(Payperiod.NormalTime, 2))
                NewRow.Overtime = Convert.ToDouble(FormatNumber(Payperiod.OverTime, 2))
            End If

            dtTimedOverview.Rows.Add(NewRow)

        Next

        daTimedOverview.Update(dtTimedOverview)

    End Sub

End Module
