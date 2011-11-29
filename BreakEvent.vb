Imports System.Collections.Generic

Public Class BreakEvent
    'This class represents all of the break events of a day.
    'There should be an "in" event for every "out" event

    Private InEvents As New List(Of PunchEvent) ' a list of the "in" events
    Private OutEvents As New List(Of PunchEvent) ' a list of the "out" events
    Private Valid As Boolean ' is the set of break events valid? (i.e. is there an "in" event for every "out" event?
    Private Empty As Boolean ' are both lists of events empty? (maybe this should be a function instead!!!?)

    'constructor from a list of PunchEvent's
    Public Sub New(ByVal BreakEvents As List(Of PunchEvent))

        'If there are no events in the list that was passed, set a few variables and quit
        If BreakEvents.Count = 0 Then
            Valid = True
            Empty = True
            Exit Sub
        End If

        'if the number of events is wrong, quit
        If BreakEvents.Count Mod 2 = 1 Then
            Valid = False
            Exit Sub
        End If

        'make sure the events in the list are all break events
        For Each TempEvent As PunchEvent In BreakEvents
            If Not TempEvent.Reason = EventReason.BREAK Then
                Valid = False
                Exit Sub
            End If
        Next

        'Parse the events. They should (must) be in order.
        For i As Integer = 0 To BreakEvents.Count - 1 Step 2

            If BreakEvents.Item(i).Direction = EventDirection.DirectionOut And BreakEvents.Item(i + 1).Direction = EventDirection.DirectionIn Then
                OutEvents.Add(BreakEvents.Item(i))
                InEvents.Add(BreakEvents.Item(i + 1))
            Else
                Valid = False
                Exit Sub
            End If

        Next

        'if we get to here, everything went well
        Valid = True

    End Sub

    'Valid accessor
    Public ReadOnly Property IsValid() As Boolean
        Get
            Return Valid
        End Get

    End Property

    'Compute the amount of time the associate spend on breaks
    Public Function CalculateTime() As ValidDouble

        Dim BreakHours As New ValidDouble

        'if the current instance of the BreakEvent class is invalid, the time computed cannot possibly be valid
        If Me.Valid = False Then
            BreakHours.Valid = False
            Return BreakHours
        End If

        'if there are no events in the BreakEvent class, there was clearly no time spent on breaks
        If Empty = True Then
            BreakHours.Valid = True
            BreakHours.Value = 0
            Return BreakHours
        End If

        'declare some variables
        Dim InTime As DateTime
        Dim OutTime As DateTime
        Dim TotalBreakTime As New System.TimeSpan(0) ' initialize to 0 ticks (the units are not important at this point)

        'compute the amount of time between the punch out to break and back in from break
        For BreakNumber As Integer = 0 To InEvents.Count - 1

            InTime = InEvents(BreakNumber).PunchTime
            OutTime = OutEvents(BreakNumber).PunchTime
            Dim CurrentBreakTime As System.TimeSpan = InTime.Subtract(OutTime)
            If CurrentBreakTime < System.TimeSpan.FromSeconds(0) Then
                MessageBox.Show("Breaks cannot have negative time! The times are: out: " + OutTime.ToString + " in: " + InTime.ToString + " time: " + CurrentBreakTime.TotalHours.ToString + " hours")
                End
            End If

            TotalBreakTime = TotalBreakTime + CurrentBreakTime
        Next

        'if we got to here, everything was ok
        BreakHours.Valid = True
        BreakHours.Value = TotalBreakTime.TotalHours

        Return BreakHours

    End Function
End Class
