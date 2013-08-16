Module MMain
    Public SkinPath$ = My.Application.Info.DirectoryPath & "\Skins\"
    Public LastPlaylistFile$ = My.Application.Info.DirectoryPath & "\Last.m3u"
    Public MediaFile As CMediaFile
    Public PlaylistFiles As ListBox
    Public bCOMPACTMODE As Boolean, bFULLSCREENMODE As Boolean, IsFileFromURL As Boolean, IsLibUpdated As Boolean
    Public Effect As Effects, LastPLSI%
    Public MouseDownPoint As Point
    Public SharedMethods As player.CShared
    Public Tags As player.CTags
    Declare Function mciSendString% Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand$, ByVal lpstrReturnString$, ByVal uReturnLength%, ByVal hwndCallback%)

    Sub MFormLoad()
        SharedMethods = New player.CShared
        Tags = New player.CTags
        PlaylistFiles = New ListBox
        MediaFile = New CMediaFile
        DrawTrackBars()
        LoadSkin(Skin)
        If Dir(My.Application.Info.DirectoryPath & "\Settings.dat") = "" Then Shell(My.Application.Info.DirectoryPath & "\defaultsets.exe", AppWinStyle.MinimizedFocus, True)
        Effect = SharedMethods.EffectSetting
        If Dir(LastPlaylistFile) <> "" AndAlso SharedMethods.LoadPlaylistOnStart Then
            LoadPlaylist(LastPlaylistFile, True)
            If Not SharedMethods.StartPlayingOnStart Then MediaFile.StopPlaying()
        End If
        With MForm
            .OpenDlg.Filter = "Мультимедиа файлы|*.mp3;*.wav;*.mid;*.wma;*.m4a;*.aac;*.ogg;*.flac;*.avi;*.wmv;*.mp4;*.mpg;*.mpeg;*.m4v;*.3gp;*.flv;*.mkv;*.mov|Все файлы|*.*"
            .LCurrentPos.Text = ""
            .LDuration.Text = ""
            .LBitrate.Text = ""
            .LCurFile.Text = ""
            .LCurFileMain.Text = "ProXPlayer " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
            .LCurFile.Text = ""
            .LCurFile.ToolTipText = ""
            .PLCurFile.Text = ""
            .Tabs.SelectTab(1)
            .Library.ExpandAll()
            .Tray.Icon = .Icon
            .KeyPreview = True
            .PanelVideo.Parent = .PicVideo
            If Not Dir(LastPlaylistFile) = "" Then .CLastPL.Enabled = True
        End With
    End Sub

    Sub DrawTrackBars()
        With MForm
            .TrackBarFile = New ColorTrackBar.CTrackBar
            .TrackBarFile.Parent = .Panel1
            .TrackBarFile.Left = 6
            .TrackBarFile.Top = 55
            .TrackBarFile.Width = 314

            .TrackBarVideoFile = New ColorTrackBar.CTrackBar
            .TrackBarVideoFile.Parent = .PanelVideo
            .TrackBarVideoFile.Left = 4
            .TrackBarVideoFile.Top = 4
            .TrackBarVideoFile.Width = 302
        End With
    End Sub

    Sub ItemMoveDown()
        With MForm.Playlist
            Dim SI% = .SelectedIndex
            Dim FSI% = PlaylistFiles.SelectedIndex
            If SI <> -1 And SI < .Items.Count - 1 Then
                Dim Name$ = .SelectedItem.ToString
                Dim File$ = PlaylistFiles.Items(SI).ToString
                .Items.RemoveAt(SI)
                .Items.Insert(SI + 1, Name)
                .SelectedIndex = SI + 1
                PlaylistFiles.Items.RemoveAt(SI)
                PlaylistFiles.Items.Insert(SI + 1, File)
                SelectPlayingIndex()
            End If
        End With
    End Sub

    Sub ItemMoveUp()
        With MForm.Playlist
            Dim SI% = .SelectedIndex
            Dim FSI% = PlaylistFiles.SelectedIndex
            If SI > 0 Then
                Dim Name$ = .SelectedItem.ToString
                Dim File$ = PlaylistFiles.Items(SI).ToString
                .Items.RemoveAt(SI)
                .Items.Insert(SI - 1, Name)
                .SelectedIndex = SI - 1
                PlaylistFiles.Items.RemoveAt(SI)
                PlaylistFiles.Items.Insert(SI - 1, File)
                SelectPlayingIndex()
            End If
        End With
    End Sub

    Sub MoveButtons()
        With MForm
            .PicVideoPlay.Location = New Point(.PanelVideo.Width / 2 - 24, 22)
            .PicVideoPrev.Location = New Point(.PicVideoPlay.Location.X - 42, 30)
            .PicVideoNext.Location = New Point(.PicVideoPlay.Location.X + 50, 30)
        End With
    End Sub

    Sub MFormResized()
        With MForm
            .GrpExtras.Width = .Width - .GrpExtras.Left - 4
            .LBitrate.Left = .GrpExtras.Width - .LBitrate.Width - 4
            .LDuration.Left = .Width - .LDuration.Width - 4
            .LCurFileMain.Width = .Width - .LDuration.Width - 4
            .TrackBarFile.Width = .Width - 4
            .TrackBarVideoFile.Width = .Width - 22
        End With
        MoveButtons()
    End Sub
End Module
