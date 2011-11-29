Imports System.Collections.Generic

Module Tests
    Public Sub TestGetWeekStart()
        'should be 3/5
        MessageBox.Show(GetWeekStart(New Date(2009, 3, 10)).ToShortDateString)
        'should be 3/5
        MessageBox.Show(GetWeekStart(New Date(2009, 3, 11)).ToShortDateString)
        'should be 3/12
        MessageBox.Show(GetWeekStart(New Date(2009, 3, 12)).ToShortDateString)
    End Sub

    Public Sub TestGetLastEvent()
        Dim Rick As New Associate("Rick Purvis")
        Dim RickLastEvent As PunchEvent = Rick.GetLastEvent()
        MessageBox.Show(RickLastEvent.PunchTime.ToShortDateString)
    End Sub

    Public Sub TestCalculateDayBreakTime_Valid()
        Dim Event1 As New PunchEvent(EventReason.DAY, EventDirection.DirectionIn, New Date(2009, 3, 10, 7, 21, 0))
        Dim Event2 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 45, 0))
        Dim Event3 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 43, 0))
        Dim Event4 As New PunchEvent(EventReason.DAY, EventDirection.DirectionOut, New Date(2009, 3, 10, 15, 30, 0))

        Dim DayEvents As New List(Of PunchEvent)
        DayEvents.Add(Event1)
        DayEvents.Add(Event4)

        Dim BreakEvents As New List(Of PunchEvent)
        BreakEvents.Add(Event2)
        BreakEvents.Add(Event3)

        Dim TempDay As New DayEvent(DayEvents)
        Dim TempBreak As New BreakEvent(BreakEvents)

        Dim DayHours As ValidDouble = TempDay.CalculateTime
        MessageBox.Show("Day: " + DayHours.Valid.ToString + " Hours: " + DayHours.Value.ToString)

        Dim BreakHours As ValidDouble = TempBreak.CalculateTime
        MessageBox.Show("Break: " + BreakHours.Valid.ToString + " Hours: " + BreakHours.Value.ToString)

        Dim Zero As New ValidDouble
        Zero.Value = 0

        Dim D As New DailyHours(BreakHours, Zero, DayHours)
        Dim totaltime As Double = D.TotalTime()

        MessageBox.Show("Total: " + totaltime.ToString)
    End Sub

    Public Sub TestCalculateDayLunchTime_Valid()
        Dim Event1 As New PunchEvent(EventReason.DAY, EventDirection.DirectionIn, New Date(2009, 3, 10, 7, 21, 0))
        Dim Event2 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 45, 0))
        Dim Event3 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 43, 0))
        Dim Event4 As New PunchEvent(EventReason.DAY, EventDirection.DirectionOut, New Date(2009, 3, 10, 15, 30, 0))

        Dim DayEvents As New List(Of PunchEvent)
        DayEvents.Add(Event1)
        DayEvents.Add(Event4)

        Dim LunchEvents As New List(Of PunchEvent)
        LunchEvents.Add(Event2)
        LunchEvents.Add(Event3)

        Dim TempDay As New DayEvent(DayEvents)
        Dim TempLunch As New LunchEvent(LunchEvents)

        Dim DayHours As ValidDouble = TempDay.CalculateTime
        MessageBox.Show("Day: " + DayHours.Valid.ToString + " Hours: " + DayHours.Value.ToString)

        Dim LunchHours As ValidDouble = TempLunch.CalculateTime
        MessageBox.Show("Lunch: " + LunchHours.Valid.ToString + " Hours: " + LunchHours.Value.ToString)

        Dim Zero As New ValidDouble
        Zero.Value = 0

        Dim D As New DailyHours(Zero, LunchHours, DayHours)
        Dim totaltime As Double = D.TotalTime()

        MessageBox.Show("Total: " + totaltime.ToString)
    End Sub

    Public Sub TestCalculateDayTime_Valid()
        Dim Event1 As New PunchEvent(EventReason.DAY, EventDirection.DirectionIn, New Date(2009, 3, 10, 10, 30, 0))
        Dim Event2 As New PunchEvent(EventReason.DAY, EventDirection.DirectionOut, New Date(2009, 3, 10, 11, 30, 0))

        Dim DayEvents As New List(Of PunchEvent)
        DayEvents.Add(Event1)
        DayEvents.Add(Event2)

        Dim TempDay As New DayEvent(DayEvents)

        Dim DayHours As ValidDouble = TempDay.CalculateTime
        MessageBox.Show("Valid: " + DayHours.Valid.ToString + " Hours: " + DayHours.Value.ToString)

    End Sub

    Public Sub TestCalculateDayTime_InValid()
        Dim Event1 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionIn, New Date(2009, 3, 10, 10, 30, 0))

        'this event is broken (break instead of day)
        Dim Event2 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 11, 30, 0))

        Dim DayEvents As New List(Of PunchEvent)
        DayEvents.Add(Event1)
        DayEvents.Add(Event2)

        Dim TempDay As New LunchEvent(DayEvents)

        Dim DayHours As ValidDouble = TempDay.CalculateTime
        MessageBox.Show("Valid: " + DayHours.Valid.ToString + " Hours: " + DayHours.Value.ToString)

    End Sub

    Public Sub TestCalculateLunchTime_Valid()
        Dim Event1 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 30, 0))
        Dim Event2 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 30, 0))

        Dim LunchEvents As New List(Of PunchEvent)
        LunchEvents.Add(Event1)
        LunchEvents.Add(Event2)

        Dim Lunch As New LunchEvent(LunchEvents)

        Dim LunchHours As ValidDouble = Lunch.CalculateTime
        MessageBox.Show("Valid: " + LunchHours.Valid.ToString + " Hours: " + LunchHours.Value.ToString)

    End Sub

    Public Sub TestCalculateLunchTime_InValid()
        Dim Event1 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionIn, New Date(2009, 3, 10, 10, 30, 0))

        'this event is broken (break instead of lunch)
        Dim Event2 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 30, 0))

        Dim LunchEvents As New List(Of PunchEvent)
        LunchEvents.Add(Event1)
        LunchEvents.Add(Event2)

        Dim Lunch As New LunchEvent(LunchEvents)

        Dim LunchHours As ValidDouble = Lunch.CalculateTime
        MessageBox.Show("Valid: " + LunchHours.Valid.ToString + " Hours: " + LunchHours.Value.ToString)

    End Sub

    Public Sub TestCalculateBreakTime_SingleValidBreak()

        'a single valid break
        Dim Event0 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 30, 0))
        Dim Event1 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 30, 0))

        Dim BreakEvents As New List(Of PunchEvent)
        BreakEvents.Add(Event0)
        BreakEvents.Add(Event1)

        Dim Break As New BreakEvent(BreakEvents)

        Dim BreakHours As ValidDouble = Break.CalculateTime
        MessageBox.Show("Valid: " + BreakHours.Valid.ToString + " Hours: " + BreakHours.Value.ToString)

    End Sub

    Public Sub TestCalculateBreakTime_TwoValidBreaks()

        'a single valid break
        Dim Event0 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 30, 0))
        Dim Event1 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 30, 0))
        Dim Event2 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 1, 30, 0))
        Dim Event3 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 1, 40, 0))

        Dim BreakEvents As New List(Of PunchEvent)
        BreakEvents.Add(Event0)
        BreakEvents.Add(Event1)
        BreakEvents.Add(Event2)
        BreakEvents.Add(Event3)

        Dim Break As New BreakEvent(BreakEvents)

        Dim BreakHours As ValidDouble = Break.CalculateTime
        MessageBox.Show("Valid: " + BreakHours.Valid.ToString + " Hours: " + BreakHours.Value.ToString)

    End Sub

    Public Sub TestCalculateBreakTime_Invalid()

        'a single valid break
        Dim Event0 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 10, 30, 0))
        Dim Event1 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionIn, New Date(2009, 3, 10, 11, 30, 0))
        Dim Event2 As New PunchEvent(EventReason.BREAK, EventDirection.DirectionOut, New Date(2009, 3, 10, 1, 30, 0))

        'this event is broken (lunch instead of break)
        Dim Event3 As New PunchEvent(EventReason.LUNCH, EventDirection.DirectionIn, New Date(2009, 3, 10, 1, 40, 0))

        Dim BreakEvents As New List(Of PunchEvent)
        BreakEvents.Add(Event0)
        BreakEvents.Add(Event1)
        BreakEvents.Add(Event2)
        BreakEvents.Add(Event3)

        Dim Break As New BreakEvent(BreakEvents)

        Dim BreakHours As ValidDouble = Break.CalculateTime
        MessageBox.Show("Valid: " + BreakHours.Valid.ToString + " Hours: " + BreakHours.Value.ToString)

    End Sub

    Public Sub TestGetEvents()
        Dim Rick As New Associate("Rick Purvis", "123", "123", AssociateType.TIMED)
        Dim EventList As List(Of PunchEvent) = Rick.GetEvents(New Date(2009, 2, 11), EventReason.ALL)

        For Each TempEvent As PunchEvent In EventList
            MessageBox.Show(TempEvent.GetString)
        Next
    End Sub

    Public Sub TestAssociateConstructor()
        Dim Rick As New Associate("Rick Purvis")
        MessageBox.Show(Rick.ToString)
    End Sub

    Public Sub TestCalculateDailyHours()
        Dim Rick As New Associate("Rick Purvis")

        'Dim RickEvents As List(Of PunchEvent) = Rick.GetEvents(New Date(2009, 2, 11), EventReason.ALL)
        Dim RickEvents As List(Of PunchEvent) = Rick.GetEvents(New Date(2009, 2, 7), EventReason.ALL)
        Dim RickHours As DailyHours = Rick.CalculateDailyHours(RickEvents)

        MessageBox.Show(RickHours.ToString)

    End Sub

    Public Sub TestWeekTime()
        Dim Rick As New Associate("Rick Purvis")

        Dim WeekDates As List(Of Date) = GetDaysInWeek(New Date(2009, 2, 5), New Date(2009, 2, 11))
        Dim RickHours As WeeklyHours = Rick.CalculateTimeInWeek(WeekDates)

        MessageBox.Show(RickHours.ToString)

    End Sub


    Public Sub TestTwoWeekTime()

    End Sub
End Module
