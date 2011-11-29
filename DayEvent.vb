Imports System.Collections.Generic

Public Class DayEvent

    'This class stores the first and last event of a day ("IN DAY" and "OUT DAY")
    Private InEvent As PunchEvent 'the "in" event
    Private OutEvent As New PunchEvent 'the "out" event
    Private Valid As Boolean 'if everything is ok, this should be true
    Private Empty As Boolean 'if there are no events, this should be true

    'constructor from a list of events
    Public Sub New(ByVal DayEvents As List(Of PunchEvent))
        'Inputs: A sorted list of DAY events

        If DayEvents.Count = 0 Then
            Valid = True
            Empty = True
            Exit Sub
        End If

        'The DAY event is reversed from other events, the IN event comes first,
        'followed by the OUT event.
        If DayEvents.Count = 2 Then
            If DayEvents.Item(0).Reason = EventReason.DAY And _
            DayEvents.Item(1).Reason = EventReason.DAY And _
            DayEvents.Item(0).Direction = EventDirection.DirectionIn And _
            DayEvents.Item(1).Direction = EventDirection.DirectionOut Then

                Valid = True
                Empty = False
                InEvent = DayEvents.Item(0)
                OutEvent = DayEvents.Item(1)
            Else
                Valid = False
                Exit Sub
            End If
        Else
            Valid = False
            Exit Sub
        End If

    End Sub

    'Valid accessor
    Public ReadOnly Property IsValid() As Boolean
        Get
            Return Me.Valid
        End Get

    End Property

    'A function to compute the amount of time between "IN DAY" and "OUT DAY"
    Public Function CalculateTime() As ValidDouble
        Dim DayTime As New ValidDouble

        If Valid = False Then
            DayTime.Valid = False
            Return DayTime
        End If

        If Empty = True Then
            DayTime.Valid = True
            DayTime.Value = 0
            Return DayTime
        End If

        Dim InTime As DateTime = InEvent.PunchTime
        Dim OutTime As DateTime = OutEvent.PunchTime

        DayTime.Value = OutTime.Subtract(InTime).TotalHours
        DayTime.Valid = True

        Return DayTime

    End Function

End Class
