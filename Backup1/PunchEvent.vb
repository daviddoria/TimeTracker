'Imports System.Collections.Generic

Public Enum EventDirection
    DirectionIn
    DirectionOut
End Enum

Public Enum EventReason
    DAY
    LUNCH
    BREAK
    ALL
End Enum


Public Class PunchEvent

    'Member variables
    Private Reason_ As EventReason
    Private Direction_ As EventDirection
    Private PunchTime_ As Date
    Private Valid_ As Boolean = False

    'Constructor for a punch at a specified time
    Public Sub New(ByVal paramReason As EventReason, ByVal paramDirection As EventDirection, ByVal paramPunchTime As Date)
        Reason_ = paramReason
        Direction_ = paramDirection
        PunchTime_ = paramPunchTime
        Valid_ = True
    End Sub

    Function GetString() As String
        Dim EventString As String = Direction_.GetString + " " + Reason_.GetString + " " + PunchTime_.ToShortDateString + " " + PunchTime_.ToShortTimeString
        Return EventString
    End Function

    'Constructor for a punch at the current time
    Public Sub PunchOut(ByVal paramReason As EventReason)
        Dim LastEvent As PunchEvent = AssociateLoggedIn.GetLastEvent()
        Reason_ = paramReason

        Direction_ = EventDirection.DirectionOut

        PunchTime_ = Now
        Valid_ = True
    End Sub

    Public Sub AutoPunchIn(ByVal LastEvent As PunchEvent)

        If LastEvent.Valid.Equals(False) Then
            Reason_ = EventReason.DAY
        Else
            Reason_ = LastEvent.Reason_
        End If

        Direction_ = EventDirection.DirectionIn
        PunchTime_ = Now
        Valid_ = True

    End Sub

    Public Function GetEventString() As String
        Dim EventString As String
        EventString = Direction_.GetString + " " + Reason_.GetString + " " + PunchTime_.ToString
        Return EventString

    End Function


    'default constructor
    Public Sub New()
        'do nothing
    End Sub

    'Properties (accessors and mutators)
    '-------------------------------
    Public Property Reason() As EventReason
        Get
            Return Reason_
        End Get

        Set(ByVal Value As EventReason)
            Reason_ = Value
        End Set
    End Property


    Public Property Direction() As EventDirection
        Get
            Return Direction_
        End Get

        Set(ByVal Value As EventDirection)
            Direction_ = Value
        End Set
    End Property

    Public Property PunchTime() As Date
        Get
            Return PunchTime_
        End Get

        Set(ByVal Value As Date)
            PunchTime_ = Value
        End Set
    End Property

    Public Property Valid() As Boolean
        Get
            Return Valid_
        End Get

        Set(ByVal Value As Boolean)
            Valid_ = Value
        End Set
    End Property


End Class



