Imports Microsoft.DirectX.AudioVideoPlayback
Public Class CMediaFile
    Sub Dispose()
        If Not AudioFile Is Nothing Then AudioFile.Dispose()
        If Not VideoFile Is Nothing Then VideoFile.Dispose()
    End Sub
#Region "Properties"
    ReadOnly Property Duration#()
        Get
            If Not AudioFile Is Nothing Then Return AudioFile.Duration
            If Not VideoFile Is Nothing Then Return VideoFile.Duration
            Return 0
        End Get
    End Property
    ReadOnly Property Playing() As Boolean
        Get
            If Not AudioFile Is Nothing Then Return AudioFile.Playing
            If Not VideoFile Is Nothing Then Return VideoFile.Playing
            Return False
        End Get
    End Property
    ReadOnly Property State() As StateFlags
        Get
            If Not AudioFile Is Nothing Then Return AudioFile.State
            If Not VideoFile Is Nothing Then Return VideoFile.State
        End Get
    End Property
    Property CurrentPosition#()
        Get
            If Not AudioFile Is Nothing Then Return AudioFile.CurrentPosition
            If Not VideoFile Is Nothing Then Return VideoFile.CurrentPosition
            Return 0
        End Get
        Set(ByVal value#)
            If Not AudioFile Is Nothing Then AudioFile.CurrentPosition = value
            If Not VideoFile Is Nothing Then VideoFile.CurrentPosition = value
        End Set
    End Property
    Property Volume%()
        Get
            If Not AudioFile Is Nothing Then Return 100 + AudioFile.Volume / 100
            If Not VideoFile Is Nothing Then Return 100 + VideoFile.Audio.Volume / 100
            Return 100
        End Get
        Set(ByVal value%)
            If Not AudioFile Is Nothing Then AudioFile.Volume = (value - 100) * 100
            If Not VideoFile Is Nothing Then VideoFile.Audio.Volume = (value - 100) * 100
        End Set
    End Property
#End Region
    Sub Play()
        If Not AudioFile Is Nothing Then
            If AudioFile.Paused Or AudioFile.Stopped Then AudioFile.Play() Else AudioFile.Pause()
            SwapPlayPause()
        End If
        If Not VideoFile Is Nothing Then
            If VideoFile.Paused Or VideoFile.Stopped Then VideoFile.Play() Else VideoFile.Pause()
            SwapPlayPause()
        End If
    End Sub
    Sub StopPlaying()
        If Not VideoFile Is Nothing Then
            If Not VideoFile.Paused Then SwapPlayPause()
            VideoFile.Stop()
        End If
        If Not AudioFile Is Nothing Then
            If Not AudioFile.Paused Then SwapPlayPause()
            AudioFile.Stop()
        End If
        MForm.TrackBarFile.Value = 0
    End Sub
End Class