Public Class PayperiodHours
    Private Week1_ As WeeklyHours
    Private Week2_ As WeeklyHours

    Private Valid_ As Boolean

    Public Sub New()
        Valid_ = False
    End Sub

    Public Sub New(ByVal Week1 As WeeklyHours, ByVal Week2 As WeeklyHours)
        If Week1.Valid = True And Week2.Valid = True Then
            Week1_ = Week1
            Week2_ = Week2

            Valid_ = True
        Else
            Valid_ = False
        End If
    End Sub

    Public Property Valid() As Boolean
        Get
            Return Valid_
        End Get

        Set(ByVal Value As Boolean)
            Valid_ = Value
        End Set
    End Property

    Public ReadOnly Property TotalTime() As Double
        Get
            If Valid_ = True Then
                Dim Week1 As Double = Week1_.TotalTime
                Dim Week2 As Double = Week2_.TotalTime
                Return Convert.ToDouble(FormatNumber(Week1, 2)) + Convert.ToDouble(FormatNumber(Week2, 2))
            Else
                Return 0
            End If
        End Get

    End Property

    Public ReadOnly Property OverTime() As Double
        Get
            If Valid_ = True Then
                Return Week1_.OverTime + Week2_.OverTime
            Else
                Return 0
            End If
        End Get

    End Property

    Public ReadOnly Property NormalTime() As Double
        Get
            If Valid_ = True Then
                Return Week1_.NormalTime + Week2_.NormalTime
            Else
                Return 0
            End If
        End Get

    End Property
End Class
