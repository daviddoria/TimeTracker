Module Logging

    'set this to False to turn off logging
    Public bTrace As Boolean = True

    Public Sub LogClick(ByVal sender As System.Object)

        Dim CallingButton As String = DirectCast(sender, Button).Name ' get the name of the button that was clicked to trigger this event

        Trace.WriteLineIf(bTrace, Now.ToShortDateString + " " + Now.ToShortTimeString + " Clicked " + CallingButton)
        Trace.Flush()

    End Sub

    Public Sub LogMenuClick(ByVal sender As System.Object)

        'not sure the difference between MenuItem instead of ToolStripMenuItem
        'Dim CallingMenu As String = DirectCast(sender, ToolStripMenuItem).Name ' get the name of the menu item that was clicked to trigger this event

        'not sure why .Name is returning ""
        ' Dim CallingMenu As String = DirectCast(sender, MenuItem).Name.ToString ' get the name of the menu item that was clicked to trigger this event
        Dim CallingMenu As String = DirectCast(sender, MenuItem).Text ' get the name of the menu item that was clicked to trigger this event

        Trace.WriteLineIf(bTrace, Now.ToShortDateString + " " + Now.ToShortTimeString + " Clicked " + CallingMenu)

        Trace.Flush()

    End Sub

    Public Sub LogListBoxSelection(ByVal sender As System.Object)

        Dim CallingItem As String = DirectCast(sender, ListBox).Name + " " + DirectCast(sender, ListBox).SelectedItem.ToString ' get the name of the button that was clicked to trigger this event

        Trace.WriteLineIf(bTrace, Now.ToShortDateString + " " + Now.ToShortTimeString + " Clicked " + CallingItem)

        Trace.Flush()

    End Sub

End Module
