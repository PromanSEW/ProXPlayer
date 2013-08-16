Namespace My

    ' Для MyApplication имеются следующие события:
    ' 
    ' Startup: возникает при запуске приложения перед созданием начальной формы.
    ' Shutdown: возникает после закрытия всех форм приложения. Это событие не происходит при прерывании работы приложения из-за ошибки.
    ' UnhandledException: возникает, если в приложение обнаруживает необработанное исключение.
    ' StartupNextInstance: возникает при запуске приложения, допускающего одновременное выполнение только одной копии, если это приложение уже активно. 
    ' NetworkAvailabilityChanged: возникает при изменении состояния подключения: при подключении или отключении.
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If e.CommandLine.Count <> 0 Then
                If e.CommandLine.Item(0).StartsWith("/path=") Then
                    CreatePlaylistFromFolder(e.CommandLine.Item(0).Remove(0, 6))
                ElseIf e.CommandLine.Item(0).EndsWith(".pl") Then
                    LoadPlaylist(e.CommandLine.Item(0))
                ElseIf e.CommandLine.Item(0) = "/skin" Then
                    Select Case e.CommandLine.Item(1)
                        Case "-set" : Skin = e.CommandLine.Item(2)
                        Case "-load" : LoadSkin(e.CommandLine.Item(2))
                    End Select
                Else
                    For i = 0 To e.CommandLine.Count - 1
                        PlaylistFiles.Items.Add(e.CommandLine.Item(i))
                        MForm.Playlist.Items.Add(IO.Path.GetFileNameWithoutExtension(e.CommandLine.Item(i)))
                    Next
                End If
            End If
        End Sub
    End Class

End Namespace
