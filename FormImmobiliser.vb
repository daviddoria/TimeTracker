Imports System.Runtime.InteropServices

'This class creates a form that cannot be moved.
'This is useful for form which are not fullscreen, but you would like to have 
'stay centered.

Public Class FormImmobiliser
    Inherits NativeWindow

    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer

        Public Sub New(ByVal r As Rectangle)
            Me.Left = r.Left
            Me.Top = r.Top
            Me.Right = r.Right
            Me.Bottom = r.Bottom
        End Sub
    End Structure

    Private Const WM_MOVING As Integer = &H216
    Private Const [TRUE] As Integer = 1

    Private WithEvents target As Form

    Public Sub New(ByVal target As Form)
        Me.target = target
    End Sub

    Private Sub target_HandleCreated(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles target.HandleCreated
        Me.AssignHandle(Me.target.Handle)
    End Sub

    Private Sub target_HandleDestroyed(ByVal sender As Object, _
                                       ByVal e As EventArgs) Handles target.HandleDestroyed
        Me.ReleaseHandle()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_MOVING Then
            Marshal.StructureToPtr(New RECT(Me.target.Bounds), _
                                   m.LParam, _
                                   False)
            m.Result = New IntPtr([TRUE])
        End If

        MyBase.WndProc(m)
    End Sub

End Class
