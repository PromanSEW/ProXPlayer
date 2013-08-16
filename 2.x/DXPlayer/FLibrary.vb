Public Class FLibrary

    Private Sub FLibrary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        With MForm
            '<Music>
            Label1.Text = "Сканирование аудиофайлов..."
            Dim Files As Collections.ObjectModel.ReadOnlyCollection(Of String)
            Files = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyMusic, FileIO.SearchOption.SearchAllSubDirectories)
            Progress.Value = 0
            Progress.Maximum = Files.Count
            .Library.Nodes.Item(1).Nodes.Item(0).Nodes.Clear()
            .Library.Nodes.Item(2).Nodes.Clear()
            Dim count%
            For i = 0 To Files.Count - 1
                Application.DoEvents()
                Select Case IO.Path.GetExtension(Files.Item(i))
                    Case ".mp3", ".wav", ".mid", ".wma", "m4a", ".aac", ".ogg", ".flac"
                        .Library.BeginUpdate()
                        .Library.Nodes.Item(1).Nodes.Item(0).Nodes.Add(IO.Path.GetFileName(Files.Item(i)))
                        .Library.Nodes.Item(1).Nodes.Item(0).Nodes.Item(.Library.Nodes.Item(1).Nodes.Item(0).Nodes.Count - 1).ToolTipText = Files.Item(i).ToString
                        .Library.EndUpdate()
                        count += 1
                        LFiles.Text = "Добавлено файлов: " & count
                    Case ".m3u"
                        .Library.BeginUpdate()
                        .Library.Nodes.Item(2).Nodes.Add(IO.Path.GetFileName(Files.Item(i)))
                        .Library.Nodes.Item(2).Nodes.Item(.Library.Nodes.Item(2).Nodes.Count - 1).ToolTipText = Files.Item(i).ToString
                        .Library.EndUpdate()
                End Select
                Progress.Value = Progress.Value + 1
            Next
            Files = Nothing
            '</Music>
            '<Video>
            Label1.Text = "Сканирование видеофайлов..."
            Dim MyVideosPath$
            MyVideosPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "My Video", Nothing)
            If Not MyVideosPath = "" Then
                Files = My.Computer.FileSystem.GetFiles(MyVideosPath, FileIO.SearchOption.SearchAllSubDirectories)
                Progress.Value = 0
                Progress.Maximum = Files.Count
                .Library.Nodes.Item(1).Nodes.Item(1).Nodes.Clear()
                For i = 0 To Files.Count - 1
                    Application.DoEvents()
                    Select Case IO.Path.GetExtension(Files.Item(i))
                        Case ".avi", ".wmv", ".mp4", ".mpg", ".mpeg", ".3gp", ".flv", ".mkv", ".mov", ".vob"
                            .Library.BeginUpdate()
                            .Library.Nodes.Item(1).Nodes.Item(1).Nodes.Add(IO.Path.GetFileName(Files.Item(i)))
                            .Library.Nodes.Item(1).Nodes.Item(1).Nodes.Item(.Library.Nodes.Item(1).Nodes.Item(1).Nodes.Count - 1).ToolTipText = Files.Item(i).ToString
                            .Library.EndUpdate()
                            count += 1
                            LFiles.Text = "Добавлено файлов: " & count
                        Case ".m3u"
                            .Library.BeginUpdate()
                            .Library.Nodes.Item(2).Nodes.Add(IO.Path.GetFileName(Files.Item(i)))
                            .Library.Nodes.Item(2).Nodes.Item(.Library.Nodes.Item(2).Nodes.Count - 1).ToolTipText = Files.Item(i).ToString
                            .Library.EndUpdate()
                    End Select
                    Progress.Value = Progress.Value + 1
                Next
                Files = Nothing
            End If
            '</Video>
            '<CD/DVD>
            Label1.Text = "Сканирование дисководов..."
            .Library.Nodes.Item(3).Nodes.Clear()
            For Each drive As IO.DriveInfo In My.Computer.FileSystem.Drives
                If drive.DriveType = IO.DriveType.CDRom Then
                    .Library.BeginUpdate()
                    If drive.IsReady Then
                        .Library.Nodes.Item(3).Nodes.Add(drive.VolumeLabel)
                    Else : .Library.Nodes.Item(3).Nodes.Add(drive.Name)
                    End If
                    .Library.EndUpdate()
                End If
            Next
            '</CD/DVD>
        End With
        Label1.Text = "Сканирование завершено"
        IsLibUpdated = True
        COtmena.Text = "OK"
    End Sub

    Private Sub COtmena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COtmena.Click
        Dispose()
        Close()
    End Sub
End Class
