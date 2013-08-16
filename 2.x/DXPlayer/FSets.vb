Public Class FSets

    Private Sub Otmena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Otmena.Click
        Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ROff.Checked Then Effect = Effects.Off
        If RFading.Checked Then Effect = Effects.Fading
        If RCrossfading.Checked Then Effect = Effects.Crossfading
        If ChkLoadPL.Checked Then LoadPlaylistOnStart = True Else LoadPlaylistOnStart = False
        If ChkStartPlay.Checked Then StartPlayingOnStart = True Else StartPlayingOnStart = False
        Close()
    End Sub

    Private Sub FSets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Effect = Effects.Off Then ROff.Checked = True
        If Effect = Effects.Fading Then RFading.Checked = True
        If Effect = Effects.Crossfading Then RCrossfading.Checked = True
        If LoadPlaylistOnStart Then ChkLoadPL.Checked = True Else ChkLoadPL.Checked = False
        If StartPlayingOnStart Then ChkStartPlay.Checked = True Else ChkStartPlay.Checked = False
    End Sub
End Class