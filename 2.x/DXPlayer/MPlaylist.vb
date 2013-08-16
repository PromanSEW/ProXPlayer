Imports System.IO.Path

Module MPlaylist
    Sub LoadPlaylist(ByVal File$, Optional ByVal LastPL As Boolean = False, Optional ByVal Ignore As Boolean = False)
        With MForm
            PlaylistFiles.Items.Clear()
            .Playlist.Items.Clear()
            FileOpen(2, File, OpenMode.Input)
            Try
                Dim CurPosition#, CurFile$
                If LastPL Then
                    LastPLSI = Val(LineInput(2))
                    CurPosition = Val(LineInput(2))
                End If
                Do Until EOF(2)
                    CurFile = LineInput(2)
                    If Dir(CurFile) <> "" Then
                        PlaylistFiles.Items.Add(GetFullPath(CurFile))
                        .Playlist.Items.Add(GetFileNameWithoutExtension(PlaylistFiles.Items.Item(PlaylistFiles.Items.Count - 1)))
                    End If
                Loop
                If LastPLSI > -1 Then
                    .Playlist.SelectedIndex = LastPLSI
                    PlaylistFiles.SelectedIndex = LastPLSI
                    If LastPL AndAlso Ignore OrElse StartPlayingOnStart Then
                        PlayFile(PlaylistFiles.SelectedItem.ToString)
                        MediaFile.CurrentPosition = CurPosition
                        MediaFile.Volume = 100
                    End If
                Else
                    MsgBox("Список воспроизведения пуст", vbInformation, "Ошибка")
                End If
            Catch ex As IO.EndOfStreamException : MsgBox("Список воспроизведения пуст", vbInformation, "Ошибка")
            End Try
            FileClose(2)
            LastPLSI = 0
        End With
    End Sub

    Sub CreatePlaylistFromFolder(ByVal Folder$)
        For Each File$ In My.Computer.FileSystem.GetFiles(Folder, FileIO.SearchOption.SearchAllSubDirectories)
            Select Case IO.Path.GetExtension(File)
                Case ".mp3", ".wav", ".mid", ".wma", "m4a", ".aac", ".ogg", ".avi", ".wmv", ".mp4", ".mpg", ".mpeg", ".3gp", ".flv", ".mkv", ".mov", ".vob"
                    PlaylistFiles.Items.Add(File)
                    MForm.Playlist.Items.Add(GetFileName(File))
            End Select
        Next
    End Sub

    Sub SavePlaylist(ByVal File$, Optional ByVal LastPL As Boolean = False)
        FileOpen(1, File, OpenMode.Output)
        If LastPL Then
            PrintLine(1, PlaylistFiles.SelectedIndex)
            PrintLine(1, MediaFile.CurrentPosition)
        End If
        For i = 0 To PlaylistFiles.Items.Count - 1
            PrintLine(1, PlaylistFiles.Items.Item(i).ToString)
        Next
        FileClose(1)
    End Sub

    Sub SortPlaylistByName()
        Dim Files$(PlaylistFiles.Items.Count - 1)
        PlaylistFiles.Items.CopyTo(Files, 0)
        PlaylistFiles.Items.Clear()
        With MForm.Playlist
            .Sorted = True : .Sorted = False
            For i = 0 To .Items.Count - 1
                For a = 0 To .Items.Count - 1
                    If Files(a).Contains(.Items(i)) Then : PlaylistFiles.Items.Add(Files(a)) : Exit For : End If
                Next
            Next
        End With
        Files = Nothing
    End Sub

    Sub SelectPlayingIndex()
        For i = 0 To PlaylistFiles.Items.Count - 1
            If PlaylistFiles.Items(i).EndsWith(MForm.LCurFile.ToolTipText) Then : PlaylistFiles.SelectedIndex = i : Exit For : End If
        Next
    End Sub
End Module
