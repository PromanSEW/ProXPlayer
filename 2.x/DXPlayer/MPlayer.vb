Imports Microsoft.DirectX.AudioVideoPlayback
Imports System.Drawing.Bitmap

Module MPlayer
    Dim bRepeat As Boolean, bShuffle As Boolean
    Public AudioFile As Audio = Nothing
    Public VideoFile As Video = Nothing
#Region "Enums"
    Enum MediaFileInfo
        Bitrate = 0
        Duration = 1
        FileName = 2
        Size = 3
        VideoSize = 4
    End Enum

    Enum Effects
        Off = 0
        Crossfading = 1
        Fading = 2
    End Enum
#End Region

#Region "Properties"
    Property Repeat() As Boolean
        Get
            Return bRepeat
        End Get
        Set(ByVal value As Boolean)
            bRepeat = value
            If value Then
                MForm.CmdRepeat.Image = FromFile(SkinPath & Skin & "\repeaton.png")
            Else : MForm.CmdRepeat.Image = FromFile(SkinPath & Skin & "\repeat.png")
            End If
        End Set
    End Property

    Property Shuffle() As Boolean
        Get
            Return bShuffle
        End Get
        Set(ByVal value As Boolean)
            bShuffle = value
            If value Then
                MForm.CmdShuffle.Image = FromFile(SkinPath & Skin & "\shuffleon.png")
            Else : MForm.CmdShuffle.Image = FromFile(SkinPath & Skin & "\shuffle.png")
            End If
        End Set
    End Property
#End Region

#Region "PlayFile Functions"
    Private Sub PlayAudioFile(ByVal File$, Optional ByVal IsFromURL As Boolean = False)
        VideoFile = Nothing
        If IsFromURL = True Then
            Dim URL As New System.Uri(File)
            AudioFile = Audio.FromUrl(URL)
        Else : AudioFile = Audio.FromFile(File)
        End If
        AudioFile.Volume = -100 * (100 - MediaFile.Volume)
        If Effect = Effects.Fading Then
            Dim vol% = CInt(MForm.LVolume.Text)
            Select Case vol
                Case Is > 39 : AudioFile.Volume = -100 * (160 - vol)
                Case Is < 39 : AudioFile.Volume = -10000
            End Select
        End If
            AudioFile.Play()
            With MForm
            .TrackBarFile.Maximum = Convert.ToInt32(AudioFile.StopPosition / 10000000)
            .TrackBarVideoFile.Maximum = Convert.ToInt32(AudioFile.StopPosition / 10000000)
            .LDuration.Text = String.Format("{0:00}:{1:00}", .TrackBarFile.Maximum \ 60, .TrackBarFile.Maximum Mod 60)
            .LBitrate.Text = SharedMethods.GetAroundBitrate(Fix(FileLen(File) * 8 / Convert.ToInt32(AudioFile.Duration) / 1024)).ToString & " kbps"
            .LCurFile.Text = IO.Path.GetFileName(File)
            .LCurFile.ToolTipText = IO.Path.GetFileName(File)
            .LCurFileMain.Text = IO.Path.GetFileName(File)
            .PanelVideo.Parent = .PicVideo
            .TimerCursor.Enabled = False
        End With
    End Sub

    Private Sub PlayVideoFile(ByVal File$, Optional ByVal IsFromURL As Boolean = False)
        AudioFile = Nothing
        If IsFromURL = True Then
            Dim URL As New System.Uri(File)
            VideoFile = Video.FromUrl(URL)
        Else : VideoFile = Video.FromFile(File)
        End If
        VideoFile.Owner = MForm.PicVideo
        VideoFile.Play()
        With MForm
            .Tabs.SelectTab(2)
            .TrackBarFile.Maximum = Convert.ToInt32(VideoFile.StopPosition / 10000000)
            .LDuration.Text = String.Format("{0:00}:{1:00}", MForm.TrackBarFile.Maximum \ 60, MForm.TrackBarFile.Maximum Mod 60)
            .LBitrate.Text = Fix(FileLen(File) * 8 / Convert.ToInt32(VideoFile.Duration) / 1024).ToString & " kbps"
            .LCurFile.Text = IO.Path.GetFileName(File)
            .LCurFile.ToolTipText = IO.Path.GetFileName(File)
            .LCurFileMain.Text = IO.Path.GetFileName(File)
            .TimerCursor.Enabled = True
        End With
    End Sub

    Sub PlayFile(ByVal File$)
        If Not MediaFile.Playing Then SwapPlayPause()
        If Not VideoFile Is Nothing Then VideoFile.Owner = Nothing
        MediaFile.Dispose()
        Select Case SharedMethods.GetTypeOfFile(File)
            Case "Video" : PlayVideoFile(File)
            Case "Audio" : PlayAudioFile(File)
            Case "Error" : MsgBox("Неизвестный тип файла или файл отсутствует на диске", MsgBoxStyle.Critical, "Ошибка воспроизведения")
        End Select
        MForm.Text = "ProXPlayer - " & MForm.LCurFile.ToolTipText
    End Sub

    Sub PlayFileFromURL(ByVal File$)
        On Error Resume Next
        VideoFile.Owner = Nothing
        MediaFile.Dispose()
        Select Case SharedMethods.GetTypeOfFile(File)
            Case "Video" : PlayVideoFile(File, True)
            Case "Audio" : PlayAudioFile(File, True)
            Case "Error" : MsgBox("Неизвестный тип файла или файл недоступен", MsgBoxStyle.Critical, "Ошибка воспроизведения")
        End Select
        MForm.Text = "ProXPlayer - " & MForm.LCurFile.ToolTipText
    End Sub
#End Region

    Function GetFileInfo(ByVal File$) As String()
        Dim Info$(4)
        Dim CurFileInfo As New IO.FileInfo(File)
        If CurFileInfo.Exists Then
            Select Case SharedMethods.GetTypeOfFile(File)
                Case "Audio"
                    Dim AFile As Audio = New Audio(File)
                    Info(MediaFileInfo.Bitrate) = SharedMethods.GetAroundBitrate(Fix(CurFileInfo.Length * 8 / Convert.ToInt32(AFile.Duration) / 1024)).ToString & " кбит/сек"
                    Info(MediaFileInfo.Duration) = String.Format("{0:00}:{1:00}", Convert.ToInt32(AFile.Duration) \ 60, Convert.ToInt32(AFile.Duration) Mod 60)
                    AFile.Dispose() : AFile = Nothing
                Case "Video"
                    Dim VFile As Video = New Video(File)
                    Info(MediaFileInfo.Bitrate) = (Fix(CurFileInfo.Length * 8 / Convert.ToInt32(VFile.Duration) / 1024)).ToString & " кбит/сек"
                    Info(MediaFileInfo.Duration) = String.Format("{0:00}:{1:00}", Convert.ToInt32(VFile.Duration) \ 60, Convert.ToInt32(VFile.Duration) Mod 60)
                    Info(MediaFileInfo.VideoSize) = VFile.Size.Width.ToString & "x" & VFile.Size.Height
                    VFile.Dispose() : VFile = Nothing
            End Select
            Info(MediaFileInfo.FileName) = CurFileInfo.Name
            Info(MediaFileInfo.Size) = (CurFileInfo.Length / (1024 * 1024)).ToString.Substring(0, 4) & " Мб (" & CurFileInfo.Length & " байт)"
            Return Info
        Else : Return Nothing
        End If
    End Function
End Module
