
Public Class FFile
    Private Sub FFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Desktop As System.Drawing.Rectangle = Screen.GetWorkingArea(Desktop)
        Me.DesktopLocation = New Point(Desktop.Width - Me.Width - 10, Desktop.Height - Me.Height - 30)
        Me.TopMost = True
    End Sub

    Private Sub TimerLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLoad.Tick
        If Me.Opacity <> 1.0 Then Me.Opacity = Me.Opacity + 0.1 Else TimerLoad.Enabled = False
    End Sub

    Private Sub TimerUnload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUnload.Tick
        Static i%
        i += 1
        If i > 80 Then
            If Me.Opacity <> 0 Then Me.Opacity -= 0.1
        End If
        If i = 100 Then Close()
    End Sub

    Private Sub TimerScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerScroll.Tick
        If LFile.Location.X > -(LFile.Width) Then
            LFile.Location = New Point(LFile.Location.X - 1, LFile.Location.Y)
        Else : LFile.Location = New Point(Me.Width, LFile.Location.Y)
        End If
    End Sub
End Class
