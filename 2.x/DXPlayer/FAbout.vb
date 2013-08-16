Public Class FAbout

    Private Sub FAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LVer.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Me.Close()
    End Sub

End Class
