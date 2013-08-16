Public Class FFileInfo
    Dim CurrentFile$ = PlaylistFiles.Items.Item(MForm.Playlist.SelectedIndex)

    Private Sub FFileInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FFileInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Info$() = GetFileInfo(CurrentFile)
        If Not Info Is Nothing Then
            LName.Text = Info(MediaFileInfo.FileName)
            LPath.Text = IO.Path.GetDirectoryName(CurrentFile)
            LSize.Text = Info(MediaFileInfo.Size)
            LDuration.Text = Info(MediaFileInfo.Duration)
            LBitrate.Text = Info(MediaFileInfo.Bitrate)
            LVideoSize.Text = Info(MediaFileInfo.VideoSize)
            If LVideoSize.Text = "" Then
                Label6.Visible = False
                LVideoSize.Visible = False
            End If
        Else : MsgBox("Файл не найден") : Me.Close()
        End If
        Info = Nothing
    End Sub

    Private Sub LPath_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LPath.LinkClicked
        Shell("explorer " & LPath.Text, AppWinStyle.NormalFocus)
    End Sub
End Class