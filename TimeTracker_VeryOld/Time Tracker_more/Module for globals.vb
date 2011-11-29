Module Module_for_globals

    'error checking variables
    Public EC As Boolean = False
    Public PrintON As Boolean = True

    Public EditAssociate As New Associate()

    Public Function GetAssociateType(ByVal AssociateName As String) As String
        Dim TempAssociate As New Associate()
        GetAssociateData(AssociateName, TempAssociate)
        Return TempAssociate.Type
    End Function

    Public Function GetListOfNames(ByVal WhichList As String) As ArrayList

        Dim EmployeeList As New ArrayList(0)

        Dim currentDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo("c:\windows\ttdata\")
        Dim TempFile As System.IO.FileInfo

        Dim TempString(2) As String
        Dim TempType As String

        For Each TempFile In currentDirectory.GetFiles()
            TempString = Split(TempFile.Name, ".")
            TempType = GetAssociateType(TempString(0))
            If TempType = "t" And (WhichList = "all" Or WhichList = "timed") Then
                EmployeeList.Add(TempString(0))
            ElseIf TempType = "m" And (WhichList = "all" Or WhichList = "manager") Then
                EmployeeList.Add(TempString(0))
            ElseIf TempType = "c" And (WhichList = "all" Or WhichList = "commissioned") Then
                EmployeeList.Add(TempString(0))
            End If
        Next

        Return EmployeeList

    End Function

    Public Function GetNumberOfLines(ByVal FileName As String) As Integer

        If EC = True Then
            MsgBox("Start GetNumberOfLines with filename: " & FileName)
        End If
        Dim CountLinesStream As New System.IO.FileStream(FileName, System.IO.FileMode.Open)
        Dim CountLinesReader As New System.IO.StreamReader(CountLinesStream)

        Dim Lines As Integer = 0
        Dim TempLine As String

        Do Until CountLinesReader.Peek = -1
            TempLine = CountLinesReader.ReadLine
            Lines = Lines + 1
        Loop

        CountLinesReader.Close()
        CountLinesStream.Close()

        If EC = True Then
            MsgBox("End GetNumberOfLines")
        End If

        Return Lines
    End Function

    Public Function CalculateHoursInDay(ByVal TimeList() As System.DateTime) As Double

        Dim TotalTime As System.TimeSpan
        Dim LunchTime As System.TimeSpan
        Dim PaidTime As System.TimeSpan
        Dim MiscTime As System.TimeSpan

        TotalTime = TimeList(5).Subtract(TimeList(0)) 'time OUT for day - time IN for day

        If EC = True Then
            MsgBox(TimeList(5).ToShortTimeString & " : " & TimeList(0).ToShortTimeString)
            MsgBox("In calchrsinday, totaltime is : " & TotalTime.TotalHours)
        End If

        If TotalTime.Hours < 0 Then
            MsgBox("Total time is < 0! Error!")
            Return 0
        End If

        LunchTime = TimeList(2).Subtract(TimeList(1)) 'time IN from lunch - time OUT to lunch

        If LunchTime.Hours < 0 Then
            MsgBox("Lunch time is < 0! Error!")
            Return 0
        End If

        MiscTime = TimeList(4).Subtract(TimeList(3)) 'time IN from misc - time OUT to misc

        If MiscTime.Hours < 0 Then
            MsgBox("misc time is < 0! Error!")
            Return 0
        End If

        PaidTime = TotalTime.Subtract(LunchTime)
        PaidTime = PaidTime.Subtract(MiscTime)

        If EC = True Then
            MsgBox("At end of calchrsinday function, time is: " & FormatNumber(PaidTime.TotalHours, 2))
        End If

        Return FormatNumber(PaidTime.TotalHours, 2)
    End Function

    Public Function CheckTimeFile(ByVal FileName As String) As Integer
        Dim CheckFileStream As New System.IO.FileStream(FileName, System.IO.FileMode.Open)
        Dim CheckFileReader As New System.IO.StreamReader(CheckFileStream)

        Dim FileData() As String = Split(CheckFileReader.ReadToEnd, vbCrLf)

        CheckFileReader.Close()
        CheckFileStream.Close()

        Dim SplitString(2) As String

        Dim Length As Integer = GetNumberOfLines(FileName)
        Dim TimeData(Length) As String
        Dim ReasonData(Length) As String
        Dim LineSplitterCounter As Integer = 0

        For LineSplitterCounter = 0 To Length - 1
            SplitString = Split(FileData(LineSplitterCounter), " PUNCH ")
            TimeData(LineSplitterCounter) = SplitString(0)
            ReasonData(LineSplitterCounter) = SplitString(1)
        Next


        Dim Counter As Integer = 0

        'first line must be IN DAY, if not, the problem is at the beginning of the file
        If ReasonData(0) <> "IN DAY" Then
            If EC = True Then
                MsgBox("The first line of the file is not IN DAY, it is " & FileData(0))
            End If
            Return 0
        End If


        For Counter = 0 To Length - 1

            If EC = True Then
                MsgBox("Event(counter) is: " & ReasonData(Counter) & " and Event(counter+1) is: " & ReasonData(Counter + 1))
            End If

            If ReasonData(Counter) = "IN DAY" Then
                If (Not ReasonData(Counter + 1) = "OUT LUNCH") And (Not ReasonData(Counter + 1) = "OUT MISC") Then
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "OUT LUNCH" Then
                If Not ReasonData(Counter + 1) = "IN LUNCH" Then
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "OUT MISC" Then
                If Not ReasonData(Counter + 1) = "IN MISC" Then
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "IN MISC" Then
                If (Not ReasonData(Counter + 1) = "OUT DAY") And (Not ReasonData(Counter + 1) = "OUT LUNCH") Then
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "IN LUNCH" Then
                If (Not ReasonData(Counter + 1) = "OUT DAY") And (Not ReasonData(Counter + 1) = "OUT MISC") Then
                    Return Counter + 1
                End If
            End If
        Next

        'if we get to here, there were no errors
        Return 100

    End Function

    Public Function CheckTimeFile(ByVal ReasonData() As String, ByVal Length As Integer) As Integer


        Dim Counter As Integer = 0

        'first line must be IN DAY, if not, the problem is at the beginning of the file
        If ReasonData(0) <> "IN DAY" Then
            If EC = True Then
                MsgBox("The first line of the file is not IN DAY, it is " & ReasonData(0))
            End If
            MsgBox("The error is probably that the first line of the file is not IN DAY")
            Return 0
        End If


        For Counter = 0 To Length - 1

            If EC = True Then
                MsgBox("Event(counter) is: " & ReasonData(Counter) & " and Event(counter+1) is: " & ReasonData(Counter + 1))
            End If

            If ReasonData(Counter) = "IN DAY" Then
                If (Not ReasonData(Counter + 1) = "OUT LUNCH") And (Not ReasonData(Counter + 1) = "OUT MISC") Then
                    MsgBox("The event after IN DAY is not OUT LUNCH or OUT MISC")
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "OUT LUNCH" Then
                If Not ReasonData(Counter + 1) = "IN LUNCH" Then
                    MsgBox("The event after OUT LUNCH is not IN LUNCH")
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "OUT MISC" Then
                If Not ReasonData(Counter + 1) = "IN MISC" Then
                    MsgBox("The event after OUT MISC is not IN MISC")
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "IN MISC" Then
                If (Not ReasonData(Counter + 1) = "OUT DAY") And (Not ReasonData(Counter + 1) = "OUT LUNCH") Then
                    MsgBox("The event after IN MISC is not OUT DAY or OUT LUNCH")
                    Return Counter + 1
                End If
            End If
            If ReasonData(Counter) = "IN LUNCH" Then
                If (Not ReasonData(Counter + 1) = "OUT DAY") And (Not ReasonData(Counter + 1) = "OUT MISC") Then
                    MsgBox("The event after IN LUNCH is not OUT DAY or OUT MISC")
                    Return Counter + 1
                End If
            End If
        Next

        'if we get to here, there were no errors
        Return 100

    End Function

    'associate sitting at computer
    Public AssociateSittingAtComputer As New Associate()

    'used to globaly ID the login form
    Public LoginFormID As frmLogin

    'used to display name on frmGetPIN
    Public strAssociateToLogin As String


    Public Function UpdateDataFile(ByVal AssociateToUpdate As Associate)
        Dim OutputStream As New System.IO.FileStream("c:\windows\ttdata\" & AssociateToUpdate.FileName, System.IO.FileMode.Truncate)
        Dim OutputWriter As New System.IO.StreamWriter(OutputStream)

        OutputWriter.WriteLine(AssociateToUpdate.Name)
        OutputWriter.WriteLine(AssociateToUpdate.Social)
        OutputWriter.WriteLine(AssociateToUpdate.Pin)
        OutputWriter.WriteLine(AssociateToUpdate.Type)
        OutputWriter.WriteLine(AssociateToUpdate.StartDate)
        OutputWriter.WriteLine(AssociateToUpdate.SickHours)
        OutputWriter.Write(AssociateToUpdate.VacationHours)

        OutputWriter.Close()
        OutputStream.Close()
    End Function



    Public Function GetAssociateData(ByVal AssociateName As String, ByRef AssociateToFill As Associate) As Boolean

        If EC = True Then
            MsgBox("Start of GetAssociateData")
        End If

        Dim PersonStream As New System.IO.FileStream("c:\windows\ttdata\" & AssociateName & ".txt", System.IO.FileMode.Open)
        Dim PersonReader As New System.IO.StreamReader(PersonStream)

        Dim CurrentLine As String

        'get name
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.Name = CurrentLine
        End If

        'get social
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.Social = CurrentLine
        End If

        'get PIN
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.Pin = CurrentLine
        End If

        'get associate type
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.Type = CurrentLine
        End If

        'get starting date
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.StartDate = CurrentLine
        End If

        'get sick hours
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.SickHours = CurrentLine
        End If

        'get vacation days
        CurrentLine = PersonReader.ReadLine
        If CurrentLine Is Nothing Then
            Return False
        Else
            AssociateToFill.VacationHours = CurrentLine
        End If

        PersonReader.Close()
        PersonStream.Close()

        'if we got to here, then everything went well
        If EC = True Then
            MsgBox("End of GetAssociateData")
        End If

        Return True
    End Function

End Module
