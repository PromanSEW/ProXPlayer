Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.IO

Public Class MForm
    Dim x!, y!
    Friend WithEvents TrackBarFile As ColorTrackBar.CTrackBar
    Friend WithEvents TrackBarVideoFile As ColorTrackBar.CTrackBar

    Private Sub MForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = Keys.Enter) Or (e.KeyCode = Keys.Escape And bFULLSCREENMODE) Then CmdFullScr_Click(sender, New EventArgs)
        Select Case e.KeyCode
            Case Keys.MediaPlayPause : CmdPlay_Click(sender, New EventArgs)
            Case Keys.MediaStop : CmdStop_Click(sender, New EventArgs)
            Case Keys.MediaPreviousTrack : CmdPrev_Click(sender, New EventArgs)
            Case Keys.MediaNextTrack : CmdNext_Click(sender, New EventArgs)
        End Select
    End Sub

    Private Sub MForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MFormLoad()
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs.Item(0).ToLower.StartsWith("/path=") Then
                Dim Folder$ = My.Application.CommandLineArgs.Item(0).Remove(0, 6)
                CreatePlaylistFromFolder(Folder)
            ElseIf Path.GetExtension(My.Application.CommandLineArgs.Item(0)) = ".pl" Then
                LoadPlaylist(My.Application.CommandLineArgs.Item(0))
            Else
                For i = 0 To My.Application.CommandLineArgs.Count - 1
                    PlaylistFiles.Items.Add(My.Application.CommandLineArgs.Item(i))
                    Playlist.Items.Add(Path.GetFileNameWithoutExtension(My.Application.CommandLineArgs.Item(i)))
                    PlayFile(PlaylistFiles.Items.Item(i))
                Next
            End If
            If Playlist.Items.Count <> 0 Then
                PlayFile(PlaylistFiles.Items.Item(0).ToString)
                PlaylistFiles.SelectedIndex = 0
                Playlist.SelectedIndex = 0
            Else : MsgBox("Доступные для воспроизведения файлы не найдены")
            End If
        End If
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        SavePlaylist(LastPlaylistFile, True)
        End
    End Sub

    Private Sub CmdEject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEject.Click
        CmdOpenFile_Click(sender, e)
    End Sub

    Private Sub CmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStop.Click
        MediaFile.StopPlaying()
    End Sub

    Private Sub CmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPlay.Click
        MediaFile.Play()
    End Sub

    Private Sub CmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbout.Click
        FAbout.ShowDialog()
    End Sub

    Private Sub TmrDuration_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrDuration.Tick
        Try
            If Not MediaFile.Disposed Then
                If MediaFile.State = StateFlags.Running Then
                    TrackBarFile.Value = MediaFile.CurrentPosition
                    LCurrentPos.Text = String.Format("{0:00}:{1:00}", MediaFile.CurrentPosition \ 60, MediaFile.CurrentPosition Mod 60).ToString
                    If LCurrentPos.Text.EndsWith("60") Then LCurrentPos.Text = LCurrentPos.Text.Substring(0, 3) & "00"
                End If
            End If
        Catch : GoTo errt
        End Try
        If LCurrentPos.Text = LDuration.Text AndAlso LDuration.Text <> "00:00" AndAlso (MediaFile.Playing OrElse SharedMethods.StartPlayingOnStart) Then
            If PlaylistFiles.SelectedIndex <> PlaylistFiles.Items.Count - 1 Then
                If Repeat = False And Shuffle = False Then
                    PlaylistFiles.SelectedIndex = PlaylistFiles.SelectedIndex + 1
                    Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
                    PlayFile(PlaylistFiles.SelectedItem)
                End If
                If Repeat Then PlayFile(PlaylistFiles.SelectedItem)
                If Shuffle Then
                    Randomize()
                    PlaylistFiles.SelectedIndex = Rnd() * PlaylistFiles.Items.Count - 1
                    Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
                    PlayFile(PlaylistFiles.SelectedItem)
                End If
                FFile.Show()
                FFile.LFile.Text = Path.GetFileNameWithoutExtension(LCurFile.ToolTipText) & " (" & LDuration.Text & ")"
                FFile.LNum.Text = Playlist.SelectedIndex + 1 & " из " & Playlist.Items.Count
                Focus()
            End If
        End If
        If LCurFile.Text <> "" Then
            If LCurFile.Text.Length < 52 Then
                Tray.Text = "ProXPlayer" & vbNewLine & LCurFile.Text
            Else : Tray.Text = "ProXPlayer" & vbNewLine & LCurFile.Text.Substring(0, 48) & "..."
            End If
            If WindowState = FormWindowState.Maximized Or WindowState = FormWindowState.Normal Then
                If LCurFile.Text.Length < 39 Then LCurFile.Text = LCurFile.ToolTipText Else LCurFile.Text = LCurFile.ToolTipText.Substring(0, 39) & "..."
            End If
        End If
errt:
    End Sub

    Private Sub TrackBarFile_TrackBarScroll() Handles TrackBarFile.TrackBarScroll
        On Error Resume Next
        If VideoFile.State = StateFlags.Running Then
            VideoFile.CurrentPosition = TrackBarFile.Value
            LCurrentPos.Text = String.Format("{0:00}:{1:00}", VideoFile.CurrentPosition / 60, VideoFile.CurrentPosition Mod 60)
        End If
        If AudioFile.State = StateFlags.Running Then
            AudioFile.CurrentPosition = TrackBarFile.Value
            LCurrentPos.Text = String.Format("{0:00}:{1:00}", AudioFile.CurrentPosition / 60, AudioFile.CurrentPosition Mod 60)
        End If
        MediaFile.Volume = Val(LVolume.Text)
    End Sub

    Private Sub CmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrev.Click
        On Error GoTo startpl
        If Not Shuffle Then
            PlaylistFiles.SelectedIndex = PlaylistFiles.SelectedIndex - 1
            Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
        Else : Randomize()
            PlaylistFiles.SelectedIndex = Rnd() * PlaylistFiles.Items.Count - 1
            Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
        End If
        PlayFile(PlaylistFiles.SelectedItem)
        FFile.Show()
        FFile.LFile.Text = Path.GetFileNameWithoutExtension(LCurFile.ToolTipText) & " (" & LDuration.Text & ")"
        FFile.LNum.Text = Playlist.SelectedIndex + 1 & " из " & Playlist.Items.Count
        Focus()
startpl:
    End Sub

    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click
        On Error GoTo endpl
        If Not Shuffle Then
            PlaylistFiles.SelectedIndex = PlaylistFiles.SelectedIndex + 1
            Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
        Else : Randomize()
            PlaylistFiles.SelectedIndex = Rnd() * PlaylistFiles.Items.Count - 1
            Playlist.SelectedIndex = PlaylistFiles.SelectedIndex
        End If
        PlayFile(PlaylistFiles.SelectedItem)
        FFile.Show()
        FFile.LFile.Text = Path.GetFileNameWithoutExtension(LCurFile.ToolTipText) & " (" & LDuration.Text & ")"
        FFile.LNum.Text = Playlist.SelectedIndex + 1 & " из " & Playlist.Items.Count
        Focus()
endpl:
    End Sub

    Private Sub CmdTabs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTabs.Click
        Tabs.Visible = Not Tabs.Visible
        If Tabs.Visible Then Me.Height = 500 Else Me.Height = 140
        CTabs.Checked = CmdTabs.Checked
    End Sub

    Private Sub CmdStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStatus.Click
        ToolStatus.Visible = Not ToolStatus.Visible
        CStatus.Checked = CmdStatus.Checked
    End Sub

    Private Sub COpenPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpenPL.Click
        If OpenPLDlg.ShowDialog = Windows.Forms.DialogResult.OK Then LoadPlaylist(OpenPLDlg.FileName)
    End Sub

    Private Sub CSavePL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSavePL.Click
        If SavePLDlg.ShowDialog = Windows.Forms.DialogResult.OK Then SavePlaylist(SavePLDlg.FileName)
    End Sub

    Private Sub CmdOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOpenFile.Click
        If OpenDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i = 0 To OpenDlg.FileNames.Length - 1
                PlaylistFiles.Items.Add(OpenDlg.FileNames(i))
                Playlist.Items.Add(Path.GetFileNameWithoutExtension(PlaylistFiles.Items.Item(PlaylistFiles.Items.Count - 1)))
            Next i
            If PlaylistFiles.SelectedIndex = -1 Then
                PlaylistFiles.SelectedIndex = 0
                Playlist.SelectedIndex = 0
            Else
                PlaylistFiles.SelectedIndex = PlaylistFiles.Items.Count - OpenDlg.FileNames.Length
                Playlist.SelectedIndex = PlaylistFiles.Items.Count - OpenDlg.FileNames.Length
            End If
            PlayFile(PlaylistFiles.SelectedItem)
        End If
    End Sub

    Private Sub CmdOpenPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOpenPL.Click
        COpenPL_Click(sender, e)
    End Sub

    Private Sub MForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PClose.Location = New Point(Me.Width - 19, 3)
        PCompact.Location = New Point(PClose.Location.X - 19, 3)
        PMin.Location = New Point(PCompact.Location.X - 19, 3)
    End Sub

    Private Sub MForm_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then Me.ShowInTaskbar = False
        If Me.WindowState = FormWindowState.Normal Then
            If bCOMPACTMODE = True Then Me.ShowInTaskbar = False Else Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub Tray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tray.MouseDoubleClick
        On Error GoTo errwnd
        Dim CurPos% = VideoFile.CurrentPosition
        VideoFile.Stop() : VideoFile.Dispose() : VideoFile = Nothing
        Me.WindowState = FormWindowState.Normal
        PlayFile(PlaylistFiles.SelectedItem)
        VideoFile.CurrentPosition = CurPos
        VideoFile.Play()
        Exit Sub
errwnd:
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TExit.Click
        CmdExit_Click(sender, e)
    End Sub

    Private Sub TAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAbout.Click
        FAbout.Show()
    End Sub

    Private Sub TPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPlay.Click
        CmdPlay_Click(sender, e)
    End Sub

    Private Sub TPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPause.Click
        CmdPlay_Click(sender, e)
    End Sub

    Private Sub TStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TStop.Click
        CmdStop_Click(sender, e)
    End Sub

    Private Sub TPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPrev.Click
        CmdPrev_Click(sender, e)
    End Sub

    Private Sub TNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNext.Click
        CmdNext_Click(sender, e)
    End Sub

    Private Sub TOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOpenFile.Click
        CmdOpenFile_Click(sender, e)
    End Sub

    Private Sub CNewPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CNewPL.Click
        CmdStop_Click(sender, e)
        LCurFileMain.Text = "ProXPlayer " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        LCurFile.Text = ""
        LCurFile.ToolTipText = ""
        LCurrentPos.Text = "00:00"
        LDuration.Text = "00:00"
        PlaylistFiles.Items.Clear()
        Playlist.Items.Clear()
    End Sub

    Private Sub CmdOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOpenFolder.Click
        If OpenFolder.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim Files As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            If MsgBox("Добавить файлы из подпапок этой папки?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Добавление файлов") = MsgBoxResult.Yes Then
                Files = My.Computer.FileSystem.GetFiles(OpenFolder.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories)
            Else : Files = My.Computer.FileSystem.GetFiles(OpenFolder.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly)
            End If
            For i = 0 To Files.Count - 1
                If Not SharedMethods.GetTypeOfFile(Files(i)) = "Error" Then
                    PlaylistFiles.Items.Add(Files.Item(i))
                    Playlist.Items.Add(Path.GetFileName(Files.Item(i)))
                End If
            Next
        End If
    End Sub

    Private Sub CmdFilePanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFilePanel.Click
        Panel1.Visible = Not Panel1.Visible
        CTrackBars.Checked = CmdFilePanel.Checked
    End Sub

    Private Sub CmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDel.Click
        On Error GoTo sinull
        PlaylistFiles.Items.RemoveAt(Playlist.SelectedIndex)
        Playlist.Items.RemoveAt(Playlist.SelectedIndex)
sinull:
    End Sub

    Private Sub PClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PClose.Click
        CmdExit_Click(sender, e)
    End Sub

    Private Sub PMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PCompact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCompact.Click
        bCOMPACTMODE = Not bCOMPACTMODE
        If bCOMPACTMODE = True Then
            Me.WindowState = FormWindowState.Normal
            For Each ctrl As Control In Me.Controls : ctrl.Visible = False : Next ctrl
            PanelTop.Visible = True
            For Each ctrl As Control In PanelTop.Controls : ctrl.Visible = True : Next ctrl
            CView.Enabled = False
            Me.Width = 325
            Me.Height = 21
            Me.TopMost = True
        Else
            For Each ctrl As Control In Me.Controls : ctrl.Visible = True : Next
            MenuStrip1.Visible = False
            For i = 0 To 4 : PanelTop.Controls.Item(i).Visible = False : Next
            PIcon.Visible = True
            Me.Width = 325
            Me.Height = 450
            Me.TopMost = False
            CView.Enabled = True
        End If
    End Sub

    Private Sub CmdCompact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCompact.Click
        PCompact_Click(sender, e)
        CCompact.Checked = CmdCompact.Checked
    End Sub

    Private Sub PPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPrev.Click
        CmdPrev_Click(sender, e)
    End Sub

    Private Sub PPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPlay.Click
        CmdPlay_Click(sender, e)
    End Sub

    Private Sub PNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNext.Click
        CmdNext_Click(sender, e)
    End Sub

    Private Sub PanelTop_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelTop.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            If bCOMPACTMODE = True Then
                Dim scr As Rectangle = Screen.GetWorkingArea(scr)
                Me.Location = New Point(0, 0)
                Me.Width = scr.Width
            Else : Me.WindowState = FormWindowState.Maximized
            End If
        Else
            Me.WindowState = FormWindowState.Normal
            Me.Width = 325
            Me.Height = 450
        End If
        MFormResized()
    End Sub

    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseDown
        MouseDownPoint = New Point(-e.X, -e.Y)
    End Sub

    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelTop.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseDownPoint.X, MouseDownPoint.Y)
            Me.Location = MousePos
        End If
    End Sub

    Private Sub CmdRepeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRepeat.Click
        Repeat = Not Repeat
    End Sub

    Private Sub CmdShuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdShuffle.Click
        Shuffle = Not Shuffle
    End Sub

    Private Sub CmdAddFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddFiles.Click
        CmdOpenFile_Click(sender, e)
    End Sub

    Private Sub Playlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Playlist.DoubleClick
        On Error Resume Next
        PlayFile(PlaylistFiles.Items.Item(Playlist.SelectedIndex))
        PlaylistFiles.SelectedIndex = Playlist.SelectedIndex
    End Sub

    Private Sub TimerScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerScroll.Tick
        Static i%
        If Not AudioFile Is Nothing Or Not VideoFile Is Nothing Then
            If i < LCurFile.ToolTipText.Length Then
                PLCurFile.Text = LCurFile.ToolTipText.Substring(i, LCurFile.ToolTipText.Length - i)
                LCurFileMain.Text = LCurFile.ToolTipText.Substring(i, LCurFile.ToolTipText.Length - i)
            Else : i = -1
            End If
            i = i + 1
        End If
    End Sub

    Private Sub PLCurFile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PLCurFile.MouseDown
        MouseDownPoint = New Point(-e.X, -e.Y)
    End Sub

    Private Sub PLCurFile_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PLCurFile.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim MousePos As Point = New Point(Control.MousePosition.X - PLCurFile.Location.X, Control.MousePosition.Y - PLCurFile.Location.Y)
            MousePos.Offset(MouseDownPoint.X, MouseDownPoint.Y)
            Me.Location = MousePos
        End If
    End Sub

    Private Sub CmdOpenFromURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOpenFromURL.Click
        Dim URL$ = InputBox("Введите URL файла:", "Открыть файл из URL")
        If URL <> "" Then PlayFileFromURL(URL)
    End Sub

    Private Sub Library_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles Library.NodeMouseClick
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            If drive.IsReady AndAlso drive.VolumeLabel = e.Node.Text Then e.Node.ContextMenuStrip = ContextCDDVD
        Next
    End Sub

    Private Sub Library_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles Library.NodeMouseDoubleClick
        If e.Node.Text = "Проигрывается" Then Tabs.SelectTab(1)
        If e.Node.Text.Contains(".m3u") Then
            LoadPlaylist(e.Node.ToolTipText)
            PlayFile(PlaylistFiles.Items(0))
        ElseIf e.Node.Text.Contains(".") Then
            PlaylistFiles.Items.Add(e.Node.ToolTipText)
            Playlist.Items.Add(e.Node.Text)
            PlayFile(e.Node.ToolTipText)
            Tabs.SelectTab(0)
        End If
    End Sub

    Private Sub CRfrshLib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRfrshLib.Click
        FLibrary.ShowDialog()
    End Sub

    Private Sub CmdEjectCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEjectCD.Click
        mciSendString("Set cdaudio door open wait", 0, 0, 0)
    End Sub

    Private Sub CmdPlayCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPlayCD.Click
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            If drive.DriveType = DriveType.CDRom And drive.IsReady Then
                If Not Library.SelectedNode Is Nothing AndAlso drive.VolumeLabel = Library.SelectedNode.Text Then
                    PlaylistFiles.Items.Clear()
                    Playlist.Items.Clear()
                    Select Case SharedMethods.GetTypeOfDisc(drive)
                        Case "CD"
                            MsgBox("Компакт-диски не поддерживаются для воспроизведения", MsgBoxStyle.Critical)
                            Exit Sub
                        Case "DVD"
                            MsgBox("DVD-диски не поддерживаются для воспроизведения", MsgBoxStyle.Critical)
                            Exit Sub
                        Case "Other"
                            For Each SMediaFile In My.Computer.FileSystem.GetFiles(drive.Name, FileIO.SearchOption.SearchAllSubDirectories)
                                If Not SharedMethods.GetTypeOfFile(SMediaFile) = "Error" Then
                                    PlaylistFiles.Items.Add(SMediaFile)
                                    Playlist.Items.Add(Path.GetFileNameWithoutExtension(SMediaFile))
                                End If
                            Next
                    End Select
                    PlayFile(PlaylistFiles.Items(0))
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub Tabs_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles Tabs.Selected
        If e.TabPage Is TabLibrary AndAlso Not IsLibUpdated Then FLibrary.ShowDialog()
    End Sub

    Private Sub PicVideo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicVideo.DoubleClick
        bFULLSCREENMODE = Not bFULLSCREENMODE
        If bFULLSCREENMODE Then
            For Each ctrl As Control In Me.Controls
                If Not ctrl Is Tabs Then ctrl.Visible = False
            Next
            Me.WindowState = FormWindowState.Maximized
        Else
            For Each ctrl As Control In Me.Controls
                ctrl.Visible = True
                Me.WindowState = FormWindowState.Normal
                MenuStrip1.Visible = False
            Next
        End If
        MFormResized()
        CmdFullScr.Checked = bFULLSCREENMODE
    End Sub

    Private Sub CmdFullScr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFullScr.Click
        PicVideo_DoubleClick(sender, e) : MoveButtons()
    End Sub

    Private Sub CmdSkins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSkins.Click
        Shell(My.Application.Info.DirectoryPath & "\skins.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub CmdInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInt.Click
        Shell(My.Application.Info.DirectoryPath & "\regplayer.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub COpenFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpenFiles.Click
        CmdOpenFile_Click(sender, e)
    End Sub

    Private Sub COpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpenFolder.Click
        CmdOpenFolder_Click(sender, e)
    End Sub

    Private Sub COpenPlaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpenPlaylist.Click
        CmdOpenPL_Click(sender, e)
    End Sub

    Private Sub COpenFromURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COpenFromURL.Click
        CmdOpenFromURL_Click(sender, e)
    End Sub

    Private Sub CTabs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTabs.Click
        CmdTabs_Click(sender, e)
        CmdTabs.Checked = Not CmdTabs.Checked
        CTabs.Checked = CmdTabs.Checked
    End Sub

    Private Sub CStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CStatus.Click
        CmdStatus_Click(sender, e)
        CmdStatus.Checked = Not CmdStatus.Checked
        CStatus.Checked = CmdStatus.Checked
    End Sub

    Private Sub CTrackBars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTrackBars.Click
        CmdFilePanel_Click(sender, e)
        CmdFilePanel.Checked = Not CmdFilePanel.Checked
        CTrackBars.Checked = CmdFilePanel.Checked
    End Sub

    Private Sub CIntegr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CIntegr.Click
        CmdInt_Click(sender, e)
    End Sub

    Private Sub CAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAbout.Click
        CmdAbout_Click(sender, e)
    End Sub

    Private Sub CSkins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSkins.Click
        CmdSkins_Click(sender, e)
    End Sub

    Private Sub CProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CProperties.Click
        If Playlist.SelectedIndex <> -1 Then FFileInfo.ShowDialog()
    End Sub

    Private Sub TimerCursor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCursor.Tick
        Static oldX!, oldY!
        If Not VideoFile Is Nothing Then
            If oldX = x And oldY = y Then
                PanelVideo.Parent = TabVideo
                VideoFile.HideCursor()
                PanelVideo.Visible = False
            Else
                VideoFile.ShowCursor()
                PanelVideo.Visible = True
                MoveButtons()
            End If
        Else : PanelVideo.Visible = True : MoveButtons()
        End If
        oldX = x : oldY = y
    End Sub

    Private Sub PicVideo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicVideo.MouseMove
        x = e.X : y = e.Y
    End Sub

    Private Sub PicVideoPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVideoPlay.Click
        CmdPlay_Click(sender, e)
    End Sub

    Private Sub PicVideoPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVideoPrev.Click
        CmdPrev_Click(sender, e)
    End Sub

    Private Sub PicVideoNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVideoNext.Click
        CmdNext_Click(sender, e)
    End Sub

    Private Sub PanelVideo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelVideo.MouseLeave
        TimerCursor.Enabled = True
    End Sub

    Private Sub PanelVideo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelVideo.MouseMove
        TimerCursor.Enabled = False
    End Sub

    Private Sub CSortByName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSortByName.Click
        SortPlaylistByName()
    End Sub

    Private Sub CPLUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPLUp.Click
        ItemMoveUp()
    End Sub

    Private Sub CPLDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPLDown.Click
        ItemMoveDown()
    End Sub

    Private Sub TrackBarFile_ValueChanged() Handles TrackBarFile.ValueChanged
        TrackBarVideoFile.Value = TrackBarFile.Value
    End Sub

    Private Sub TrackBarVideoFile_TrackBarScroll() Handles TrackBarVideoFile.TrackBarScroll
        On Error Resume Next
        If MediaFile.State = StateFlags.Running Then
            MediaFile.CurrentPosition = TrackBarVideoFile.Value
            LCurrentPos.Text = String.Format("{0:00}:{1:00}", MediaFile.CurrentPosition / 60, MediaFile.CurrentPosition Mod 60)
        End If
    End Sub

    Private Sub CLastPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLastPL.Click
        LoadPlaylist(LastPlaylistFile, True, True)
    End Sub

    Private Sub CVolDown_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CVolDown.MouseDown
        If MediaFile.Volume > 0 Then MediaFile.Volume -= 1
        LVolume.Text = MediaFile.Volume
    End Sub

    Private Sub CVolUp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CVolUp.MouseDown
        If MediaFile.Volume < 100 Then MediaFile.Volume += 1
        LVolume.Text = MediaFile.Volume
    End Sub

    Private Sub TimerVolume_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerVolume.Tick
        If Effect = Effects.Fading Then
            If MediaFile.Duration - MediaFile.CurrentPosition < 3 AndAlso MediaFile.Volume > 0 Then MediaFile.Volume -= 2
            If MediaFile.CurrentPosition < 3 And MediaFile.Volume < Val(LVolume.Text) Then MediaFile.Volume += 2
        End If
    End Sub

    Private Sub CSets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSets.Click
        FSets.ShowDialog()
    End Sub

    Private Sub CExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CExit.Click
        CmdExit_Click(sender, e)
    End Sub

    Private Sub PicVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVolume.Click
        SwapVolume()
        If ToolTip1.GetToolTip(PicVolume) = "Громкость (вкл)" Then MediaFile.Volume = 0 Else MediaFile.Volume = CInt(LVolume.Text)
    End Sub
End Class
