Public Class WeeklyHours
    Private TotalTime_ As Double
    Private Valid_ As Boolean

    Public Sub New()
        TotalTime_ = 0.0
        Valid_ = False
    End Sub

    Public Sub New(ByVal TotalTime As Double)
        TotalTime_ = TotalTime
        Valid_ = True
    End Sub

    Public Function ToString() As String
        Dim HoursString As String
        If Valid = True Then
            HoursString = "Total: " + TotalTime.ToString + _
            " Normal: " + FormatNumber(NormalTime, 2) _
             + " Overtime: " + FormatNumber(OverTime, 2)
        Else
            HoursString = "invalid"
        End If

        Return HoursString

    End Function

    Public Property Valid() As Boolean
        Get
            Return Valid_
        End Get

        Set(ByVal Value As Boolean)
            Valid_ = Value
        End Set
    End Property

    Public Property TotalTime() As Double
        Get
            If Valid_ = True Then
                Return TotalTime_
            Else
                Return 0
            End If
        End Get

        Set(ByVal Value As Double)
            TotalTime_ = Value
        End Set
    End Property

    Public ReadOnly Property OverTime() As Double
        Get
            If Valid_ = True Then
                If TotalTime_ > 40 Then
                    Return TotalTime_ - 40
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Get

    End Property

    Public ReadOnly Property NormalTime() As Double
        Get
            If Valid_ = True Then
                If TotalTime_ > 40 Then
                    Return 40
                Else
                    Return TotalTime_
                End If
            Else
                Return 0
            End If
        End Get

    End Property
End Class
