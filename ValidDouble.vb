Public Class ValidDouble
    Public Value_ As Double
    Public Valid As Boolean

    Public Property Value() As Double
        Get
            If Valid = True Then
                Return Value_
            Else
                'MessageBox.Show("Tried to get value of invalid ValidDouble!")
                'End
                Debug.WriteLine("Tried to get value of invalid ValidDouble!")
            End If
        End Get

        Set(ByVal Value As Double)
            Value_ = Value
        End Set
    End Property
End Class