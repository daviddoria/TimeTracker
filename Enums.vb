
Module Enums

    'some functions to convert between strings and enums

    <Extension()> Function GetEventReason(ByVal ReasonString As String) As EventReason
        'converts long reason to short reason
        'Inputs: A LongReason (ex. for the day)
        'Outputs: A ShortReason (ex. DAY)

        ReasonString = ReasonString.ToUpper

        Dim ShortReason As EventReason

        If ReasonString = "FOR THE DAY" Or ReasonString = "DAY" Then
            ShortReason = EventReason.DAY
        ElseIf ReasonString = "FROM LUNCH" Or ReasonString = "LUNCH" Then
            ShortReason = EventReason.LUNCH
        ElseIf ReasonString = "FROM BREAK" Or ReasonString = "BREAK" Then
            ShortReason = EventReason.BREAK
        Else
            MessageBox.Show("Error getting short reason " + ReasonString + "!")
            End
        End If

        Return ShortReason
    End Function

    <Extension()> Function GetString(ByVal Reason As EventReason) As String

        Dim ReasonString As String

        Select Case Reason
            Case EventReason.DAY
                'ReasonString = "FOR THE DAY"
                ReasonString = "DAY"
            Case EventReason.LUNCH
                'ReasonString = "FROM LUNCH"
                ReasonString = "LUNCH"
            Case EventReason.BREAK
                'ReasonString = "FROM BREAK"
                ReasonString = "BREAK"
            Case EventReason.ALL
                ReasonString = "%"
            Case Else
                MessageBox.Show("Invalid Reason String!")
                End
        End Select

        Return ReasonString
    End Function


    <Extension()> Function GetString(ByVal Direction As EventDirection) As String
        'Public Shared Function DirectionToString(ByVal Direction As EventDirection) As String

        Dim DirectionString As String

        Select Case Direction
            Case EventDirection.DirectionIn
                DirectionString = "IN"
            Case EventDirection.DirectionOut
                DirectionString = "OUT"
            Case Else
                '   MessageBox.Show("Invalid Reason String!")
                End
        End Select

        Return DirectionString
    End Function

    <Extension()> Function GetEventDirection(ByVal DirectionString As String) As EventDirection
        DirectionString = DirectionString.ToUpper
        Dim Direction As EventDirection

        Select Case DirectionString
            Case "IN"
                Direction = EventDirection.DirectionIn
            Case "OUT"
                Direction = EventDirection.DirectionOut
            Case Else
                End
        End Select

        Return Direction
    End Function



    <Extension()> Function GetAssociateType(ByVal TypeString As String) As AssociateType
        'Inputs: A string of the type of associate.
        'Outputs: An AssociateType of the type of associate.
        If TypeString = Nothing Then
            Return AssociateType.INVALID
        End If

        TypeString = TypeString.ToUpper

        Dim Type As AssociateType

        Select Case TypeString
            Case "*"
                Type = AssociateType.ALL
            Case "%"
                Type = AssociateType.ALL
            Case "MANAGER"
                Type = AssociateType.MANAGER
            Case "COMMISSIONED"
                Type = AssociateType.COMMISSIONED
            Case "TIMED"
                Type = AssociateType.TIMED
            Case Else
                Type = AssociateType.INVALID

        End Select

        Return Type
    End Function

    <Extension()> Function GetString(ByVal Type As AssociateType) As String
        'Inputs: An AssociateType of the type of associate.
        'Outputs: A string of the type of associate.

        Dim TypeString As String

        Select Case Type
            Case AssociateType.ALL
                'TypeString = "*"
                TypeString = "%"
            Case AssociateType.MANAGER
                TypeString = "MANAGER"
            Case AssociateType.COMMISSIONED
                TypeString = "COMMISSIONED"
            Case AssociateType.TIMED
                TypeString = "TIMED"
            Case Else
                TypeString = "INVALID"
                End
        End Select

        Return TypeString
    End Function
End Module

