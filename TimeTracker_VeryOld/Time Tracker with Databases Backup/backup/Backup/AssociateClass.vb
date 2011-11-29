Public Class Associate

    Private _name As String
    Private _social As String
    Private _pin As String
    Private _type As String
    Private _startdate As Date
    Private _sickhours As Integer
    Private _vacationhours As Integer


    Public Sub New()
        _name = "NAME"
        _social = "123456789"
        _pin = "123"
        _type = "TYPE"
        _startdate = "1/1/01"
        _sickhours = 0
        _vacationhours = 0
    End Sub

    Public Sub New(ByVal pName As String)
        Me.New()
        _name = pName
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    Public Property Social() As String
        Get
            Return _social
        End Get
        Set(ByVal Value As String)
            _social = Value
        End Set
    End Property

    Public Property Pin() As String
        Get
            Return _pin
        End Get
        Set(ByVal Value As String)
            _pin = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal Value As String)
            _type = Value
        End Set
    End Property

    Public Property StartDate() As System.DateTime
        Get
            Return _startdate
        End Get
        Set(ByVal Value As System.DateTime)
            _startdate = Value
        End Set
    End Property

    Public Property SickHours() As Integer
        Get
            Return _sickhours
        End Get
        Set(ByVal Value As Integer)
            If Value > 0 Then
                _sickhours = Value
            End If
        End Set
    End Property

    Public Property VacationHours() As Integer
        Get
            Return _vacationhours
        End Get
        Set(ByVal Value As Integer)
            If Value > 0 Then
                _vacationhours = Value
            End If
        End Set
    End Property

End Class