Public Class DailyHours
    'This class keeps track of an associates punches for a single day

    Private BreakTime_ As New ValidDouble 'The total amount of time between all of the "OUT BREAK" and "IN BREAK" pairs
    Private LunchTime_ As New ValidDouble 'The amount of time between "OUT LUNCH" and "IN LUNCH"
    Private DayTime_ As New ValidDouble 'The amount of time between "IN DAY" and "OUT DAY"
    Private Valid_ As Boolean 'If the events are correct in number and order, this should be true.
    Private Empty As Boolean 'If there are no events, this should be true

    'DayTime is (PunchOut - PunchIn).  To get the total time, subtract BreakTime and LunchTime from DayTime

    'Default constructor
    Public Sub New()
        BreakTime_.Value = 0.0
        BreakTime_.Valid = False
        LunchTime_.Value = 0.0
        LunchTime_.Valid = False
        DayTime_.Value = 0.0
        DayTime_.Valid = False
        Valid_ = False
    End Sub

    'Constructor from values
    Public Sub New(ByVal Break As ValidDouble, ByVal Lunch As ValidDouble, ByVal DayHours As ValidDouble)

        Me.BreakTime_ = Break
        Me.LunchTime_ = Lunch
        Me.DayTime_ = DayHours

        Me.Valid_ = True
    End Sub

    Public Function ToString() As String
        'If everything is valid, return a string of all of the times, else return "invalid"
        Dim HoursString As String
        If Me.Valid_ = True Then
            HoursString = "Break: " + " " + FormatNumber(BreakTime_.Value, 2) + " Lunch: " + FormatNumber(LunchTime_.Value, 2) + " Day: " + FormatNumber(DayTime_.Value, 2)
        Else
            HoursString = "invalid"
        End If

        Return HoursString

    End Function

    'Valid accessor/mutator
    Public Property Valid() As Boolean
        Get
            Return Valid_
        End Get

        Set(ByVal Value As Boolean)
            Valid_ = Value
        End Set
    End Property

    'BreakTime accessor/mutator
    Public Property BreakTime() As ValidDouble
        Get
            Return BreakTime_
        End Get

        Set(ByVal Value As ValidDouble)
            BreakTime_ = Value
        End Set
    End Property

    'LunchTime accessor/mutator
    Public Property LunchTime() As ValidDouble
        Get
            Return LunchTime_
        End Get

        Set(ByVal Value As ValidDouble)
            LunchTime_ = Value
        End Set
    End Property

    'DayTime accessor/mutator
    Public Property DayTime() As ValidDouble
        Get
            Return DayTime_
        End Get

        Set(ByVal Value As ValidDouble)
            DayTime_ = Value
        End Set
    End Property

    'A function to compute the number of hours the associate should be paid for the day
    Public ReadOnly Property TotalTime() As Double 'maybe this should be a ValidDouble? !!!
        Get
            If Valid_ = False Then
                Return 0 'maybe this should be a negative number? or an Invalid Double ? !!!
            End If

            'compute the amount of break time (in hours) the associate used that is over the allowance
            'should probably call BreakOverage() here? !!!
            Dim CountedBreak As Double = BreakTime_.Value - Company.BreakMinutes / 60.0

            'If the associate has not used more than the allowed break, set the used break to zero
            If CountedBreak < 0 Then
                CountedBreak = 0
            End If

            'Subtract the break time (over allowance) and lunch time from the day time and return the result as the amount of time they should be paid for for the day
            Return DayTime_.Value - (CountedBreak + LunchTime_.Value)
            'Return FormatNumber(TotalHours, 2) 'truncate to 2 decimal points
        End Get
    End Property

    'A function to compute how much time over the allowance an associate spent on break
    Public ReadOnly Property BreakOverage() As Double
        Get
            If Valid_ = False Then
                Return 0
            End If
            Dim CountedBreak As Double = BreakTime_.Value - Company.BreakMinutes / 60.0
            If CountedBreak < 0 Then
                CountedBreak = 0
            End If

            Return CountedBreak
            'Return FormatNumber(TotalHours, 2) 'truncate to 2 decimal points
        End Get
    End Property

End Class
