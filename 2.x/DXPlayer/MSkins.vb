Imports System.Drawing.Bitmap

Module MSkins
    Sub LoadSkin(ByVal Skin$)
        On Error Resume Next
        With MForm
            .PanelTop.BackgroundImage = FromFile(SkinPath & Skin & "\top.png")
            .Panel1.BackgroundImage = FromFile(SkinPath & Skin & "\bgplayer.png")
            .ToolStatus.BackgroundImage = FromFile(SkinPath & Skin & "\status.png")
            .MenuStrip1.BackgroundImage = FromFile(SkinPath & Skin & "\menu.png")
            .ToolLib.BackgroundImage = FromFile(SkinPath & Skin & "\libmenu.png")
            .PicVideo.BackgroundImage = FromFile(SkinPath & Skin & "\video.png")

            .PicVideoPlay.Image = FromFile(SkinPath & Skin & "\videoplay.png")
            .PicVideoPrev.Image = FromFile(SkinPath & Skin & "\videoprev.png")
            .PicVideoNext.Image = FromFile(SkinPath & Skin & "\videonext.png")

            .GrpCur.BackgroundImage = FromFile(SkinPath & Skin & "\curtime.png")
            .GrpExtras.BackgroundImage = FromFile(SkinPath & Skin & "\setspanel.png")

            .CmdPrev.Image = FromFile(SkinPath & Skin & "\prev.png")
            .CmdPlay.Image = FromFile(SkinPath & Skin & "\play.png")
            .CmdStop.Image = FromFile(SkinPath & Skin & "\stop.png")
            .CmdNext.Image = FromFile(SkinPath & Skin & "\next.png")
            .CmdEject.Image = FromFile(SkinPath & Skin & "\eject.png")
            .CmdShuffle.Image = FromFile(SkinPath & Skin & "\shuffle.png")
            .CmdRepeat.Image = FromFile(SkinPath & Skin & "\repeat.png")

            .PicVolume.Image = FromFile(SkinPath & Skin & "\volume.png")
            .CVolDown.Image = FromFile(SkinPath & Skin & "\volumedown.png")
            .CVolUp.Image = FromFile(SkinPath & Skin & "\volumeup.png")

            .PIcon.Image = FromFile(SkinPath & Skin & "\icon.png")
            .PPrev.Image = FromFile(SkinPath & Skin & "\mprev.png")
            .PPlay.Image = FromFile(SkinPath & Skin & "\mplay.png")
            .PNext.Image = FromFile(SkinPath & Skin & "\mnext.png")

            .PCompact.Image = FromFile(SkinPath & Skin & "\compact.png")
            .PMin.Image = FromFile(SkinPath & Skin & "\min.png")
            .PClose.Image = FromFile(SkinPath & Skin & "\close.png")
            If Dir(SkinPath & Skin & "\Skin.xml") <> "" Then LoadSkinInfo(SkinPath & Skin & "\Skin.xml")
        End With
    End Sub

    Property Skin$()
        Get
            Dim StrSkin$ = "Default"
            If Dir(SkinPath & "\Skin.dat") = "" Then
                FileOpen(1, SkinPath & "\Skin.dat", OpenMode.Output)
                Print(1, "Default")
                FileClose(1)
            End If
            FileOpen(1, SkinPath & "\Skin.dat", OpenMode.Input)
            Input(1, StrSkin)
            FileClose(1)
            Return StrSkin
        End Get
        Set(ByVal value$)
            FileOpen(1, SkinPath & "\Skin.dat", OpenMode.Output)
            Print(1, value)
            FileClose(1)
        End Set
    End Property

    Sub SwapPlayPause()
        With MForm
            If .ToolTip1.GetToolTip(.PicVideoPlay) = "Воспроизвести" Then
                .ToolTip1.SetToolTip(.PicVideoPlay, "Пауза")
                .ToolTip1.SetToolTip(.CmdPlay, "Пауза")
            Else
                .ToolTip1.SetToolTip(.PicVideoPlay, "Воспроизвести")
                .ToolTip1.SetToolTip(.CmdPlay, "Воспроизведение")
            End If
            Select Case .ToolTip1.GetToolTip(.PicVideoPlay)
                Case "Воспроизвести"
                    .PicVideoPlay.Image = FromFile(SkinPath & Skin & "\videoplay.png")
                    .CmdPlay.Image = FromFile(SkinPath & Skin & "\play.png")
                Case "Пауза"
                    .PicVideoPlay.Image = FromFile(SkinPath & Skin & "\videopause.png")
                    .CmdPlay.Image = FromFile(SkinPath & Skin & "\pause.png")
            End Select
        End With
    End Sub

    Sub SwapVolume()
        With MForm
            If .ToolTip1.GetToolTip(.PicVolume) = "Громкость (выкл)" Then
                .ToolTip1.SetToolTip(.PicVolume, "Громкость (вкл)")
            Else : .ToolTip1.SetToolTip(.PicVolume, "Громкость (выкл)")
            End If
            Select Case .ToolTip1.GetToolTip(.PicVolume)
                Case "Громкость (вкл)"
                    .PicVolume.Image = FromFile(SkinPath & Skin & "\volumeoff.png")
                Case "Громкость (выкл)"
                    .PicVolume.Image = FromFile(SkinPath & Skin & "\volume.png")
            End Select
        End With
    End Sub

    Sub LoadSkinInfo(ByVal SkinConfigFile$)
        Dim myXml As New System.Xml.XPath.XPathDocument(SkinConfigFile), fontStyle As FontStyle, tmp$ = "", fontsize!
        With MForm
            ' <TopPanel>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/toppanel/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .PanelTop.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .PanelTop.BackColor = Color.FromName(tmp)
            End If
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/toppanel/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/toppanel/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/toppanel/font/@style").Value)
            .PLCurFile.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/toppanel/font/@color").Value
            If tmp.StartsWith("#") Then .PLCurFile.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .PLCurFile.ForeColor = Color.FromName(tmp)
            '</TopPanel>
            '<MenuStrip1>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/menu/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .MenuStrip1.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .MenuStrip1.BackColor = Color.FromName(tmp)
            End If
            '</MenuStrip1>
            '<Panel1>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .Panel1.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .Panel1.BackColor = Color.FromName(tmp)
            End If
            '<GrpCur>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentseconds/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentseconds/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentsettings/font/@style").Value)
            .LCurrentPos.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentseconds/font/@color").Value
            If tmp.StartsWith("#") Then .LCurrentPos.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LCurrentPos.ForeColor = Color.FromName(tmp)
            '</GrpCur>
            '<GrpExtras>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/settingspanel/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .GrpExtras.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .GrpExtras.BackColor = Color.FromName(tmp)
            End If
            '<LBitrate>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/settingspanel/bitrate/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .LBitrate.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LBitrate.BackColor = Color.FromName(tmp)
            End If
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/settingspanel/bitrate/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/settingspanel/bitrate/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/settingspanel/bitrate/font/@style").Value)
            .LBitrate.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanelsettingspanel/bitrate/font/@color").Value
            If tmp.StartsWith("#") Then .LBitrate.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LBitrate.ForeColor = Color.FromName(tmp)
            '</LBitrate>
            '</GrpExtras>
            '<TrackBarFile>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/trackbar/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .TrackBarFile.BackTrackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .TrackBarFile.BackTrackColor = Color.FromName(tmp)
            End If
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/trackbar/@color").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then
                    .TrackBarFile.TrackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp))
                    .TrackBarFile.BackTrackColorFull = Color.FromArgb(SharedMethods.HexToRGB(tmp))
                Else
                    .TrackBarFile.TrackColor = Color.FromName(tmp)
                    .TrackBarFile.BackTrackColorFull = Color.FromName(tmp)
                End If
            End If
            '</TrackBarFile>
            '<LCurFileMain>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentfile/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentfile/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentfile/font/@style").Value)
            .LCurrentPos.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/currentfile/font/@color").Value
            If tmp.StartsWith("#") Then .LCurFileMain.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LCurFileMain.ForeColor = Color.FromName(tmp)
            '</LCurFileMain>
            '<LDuration>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/duration/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/duration/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/duration/font/@style").Value)
            .LCurrentPos.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/playerpanel/duration/font/@color").Value
            If tmp.StartsWith("#") Then .LDuration.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LDuration.ForeColor = Color.FromName(tmp)
            '</LDuration>
            '</Panel1>
            '<Tabs>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/@background").Value
            If tmp.StartsWith("#") Then .BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .BackColor = Color.FromName(tmp)
            '<Library>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/library/@background").Value
            If tmp.StartsWith("#") Then .Library.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .Library.BackColor = Color.FromName(tmp)
            '</Library>
            '<Playlist>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/playlist/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/playlist/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/tabs/playlist/font/@style").Value)
            .LCurrentPos.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/playlist/font/@color").Value
            If tmp.StartsWith("#") Then .Playlist.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .Playlist.ForeColor = Color.FromName(tmp)
            '</Playlist>
            '<Video>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/tabs/video/@background").Value
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .PicVideo.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .PicVideo.BackColor = Color.FromName(tmp)
            End If
            '</Video>
            '</Tabs>
            '<ToolStatus>
            If tmp <> "image" Then
                If tmp.StartsWith("#") Then .ToolStatus.BackColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .ToolStatus.BackColor = Color.FromName(tmp)
            End If
            '<LCurFile>
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/statusbar/currentfile/font/@name").Value
            fontsize = myXml.CreateNavigator.SelectSingleNode("/skin/statusbar/currentfile/font/@size").Value
            fontStyle = SharedMethods.GetFontStyle(myXml.CreateNavigator.SelectSingleNode("/skin/statusbar/currentfile/font/@style").Value)
            .LCurrentPos.Font = New Font(tmp, fontsize, fontStyle)
            tmp = myXml.CreateNavigator.SelectSingleNode("/skin/statusbar/currentfile/font/@color").Value
            If tmp.StartsWith("#") Then .LCurFile.ForeColor = Color.FromArgb(SharedMethods.HexToRGB(tmp)) Else .LCurFile.ForeColor = Color.FromName(tmp)
            '</LCurFile>
            '</ToolStatus>
        End With
    End Sub
End Module
