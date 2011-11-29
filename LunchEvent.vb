Imports System.Collections.Generic

Public Class LunchEvent

    Private InEvent As PunchEvent
    Private OutEvent As New PunchEvent
    Private Valid As Boolean
    Private Empty As Boolean

    Public Sub New(ByVal LunchEvents As List(Of PunchEvent))
        'Inputs: A sorted list of LUNCH events

        If LunchEvents.Count = 0 Then
            Empty = True
            Valid = True
            Exit Sub
        ElseIf LunchEvents.Count = 2 Then
            If LunchEvents.Item(0).Reason = EventReason.LUNCH And _
            LunchEvents.Item(1).Reason = EventReason.LUNCH And _
            LunchEvents.Item(0).Direction = EventDirection.DirectionOut And _
            LunchEvents.Item(1).Direction = EventDirection.DirectionIn Then

                Valid = True
                OutEvent = LunchEvents.Item(0)
                InEvent = LunchEvents.Item(1)
            Else
                Valid = False
                Exit Sub
            End If
        Else
            Valid = False
            Exit Sub
        End If

    End Sub


    Public ReadOnly Property IsValid() As Boolean
        Get
            Return Valid
        End Get

    End Property

    Public Function CalculateTime() As ValidDouble
        Dim LunchTime As New ValidDouble

        If Valid = False Then
            LunchTime.Valid = False
            Return LunchTime
        End If

        If Empty = True Then
            LunchTime.Valid = True
            LunchTime.Value = 0
            Return LunchTime
        End If

        Dim InTime As DateTime = InEvent.PunchTime
        Dim OutTime As DateTime = OutEvent.PunchTime

        LunchTime.Value = InTime.Subtract(OutTime).TotalHours
        LunchTime.Valid = True

        Return LunchTime

    End Function

End Class
