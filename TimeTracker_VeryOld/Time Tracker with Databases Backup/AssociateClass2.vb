Public Class Associate

    Private _name As String
    Private _social As String
    Private _pin As String
    Private _type As String
    Private _startdate As Date
    Private _sickhours As Integer
    Private _vacationhours As Integer
    Private _filename As String

    Public Sub New()
        _name = "NAME"
        _social = "SOCIAL"
        _pin = "PIN"
        _type = "TYPE"
        _startdate = "1/1/01"
        _sickhours = 0
        _vacationhours = 0
        _filename = "FILENAME"
    End Sub

    Public Sub New(ByVal pName As String)
        Me.New()
        _name = pName
        _filename = pName & ".txt"
    End Sub

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _name = Value
            _filename = Value & ".txt"
        End Set
    End Property

    Public Property Social() As String
        Get
            Return _Social
        End Get
        Set(ByVal Value As String)
            _Social = Value
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

    Public Property FileName() As String
        Get
            Return _filename
        End Get
        Set(ByVal Value As String)
            If Value.Length > 0 Then
                _filename = Value & ".txt"
            End If
        End Set
    End Property
End Class