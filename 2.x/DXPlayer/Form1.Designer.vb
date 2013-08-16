<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MForm))
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Проигрывается")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Музыка")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Видео")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Файлы", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Playlists")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CD/DVD дисководы")
        Me.OpenDlg = New System.Windows.Forms.OpenFileDialog
        Me.ContextPlaylist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmdDel = New System.Windows.Forms.ToolStripMenuItem
        Me.CProperties = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.CPLUp = New System.Windows.Forms.ToolStripMenuItem
        Me.CPLDown = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdOpenFile = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdOpenFolder = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdOpenPL = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdOpenFromURL = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CmdExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdTabs = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdStatus = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdFilePanel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CmdCompact = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdSkins = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdInt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LCurFileMain = New System.Windows.Forms.Label
        Me.GrpExtras = New System.Windows.Forms.GroupBox
        Me.CVolDown = New System.Windows.Forms.PictureBox
        Me.LPercent = New System.Windows.Forms.Label
        Me.LVolume = New System.Windows.Forms.Label
        Me.CVolUp = New System.Windows.Forms.PictureBox
        Me.PicVolume = New System.Windows.Forms.PictureBox
        Me.LBitrate = New System.Windows.Forms.Label
        Me.CmdRepeat = New System.Windows.Forms.PictureBox
        Me.CmdShuffle = New System.Windows.Forms.PictureBox
        Me.GrpCur = New System.Windows.Forms.GroupBox
        Me.LCurrentPos = New System.Windows.Forms.Label
        Me.CmdEject = New System.Windows.Forms.PictureBox
        Me.CmdNext = New System.Windows.Forms.PictureBox
        Me.CmdStop = New System.Windows.Forms.PictureBox
        Me.CmdPlay = New System.Windows.Forms.PictureBox
        Me.CmdPrev = New System.Windows.Forms.PictureBox
        Me.LDuration = New System.Windows.Forms.Label
        Me.TmrDuration = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStatus = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.CmdAddFiles = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.COpenPL = New System.Windows.Forms.ToolStripMenuItem
        Me.CSavePL = New System.Windows.Forms.ToolStripMenuItem
        Me.CNewPL = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.СортироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CSortByName = New System.Windows.Forms.ToolStripMenuItem
        Me.CLastPL = New System.Windows.Forms.ToolStripMenuItem
        Me.LCurFile = New System.Windows.Forms.ToolStripLabel
        Me.OpenPLDlg = New System.Windows.Forms.OpenFileDialog
        Me.SavePLDlg = New System.Windows.Forms.SaveFileDialog
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TPlay = New System.Windows.Forms.ToolStripMenuItem
        Me.TPause = New System.Windows.Forms.ToolStripMenuItem
        Me.TStop = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TPrev = New System.Windows.Forms.ToolStripMenuItem
        Me.TNext = New System.Windows.Forms.ToolStripMenuItem
        Me.TOpenFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.TExit = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.PanelTop = New System.Windows.Forms.Panel
        Me.PIcon = New System.Windows.Forms.PictureBox
        Me.CMainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.COpen = New System.Windows.Forms.ToolStripMenuItem
        Me.COpenFiles = New System.Windows.Forms.ToolStripMenuItem
        Me.COpenFolder = New System.Windows.Forms.ToolStripMenuItem
        Me.COpenPlaylist = New System.Windows.Forms.ToolStripMenuItem
        Me.COpenFromURL = New System.Windows.Forms.ToolStripMenuItem
        Me.CView = New System.Windows.Forms.ToolStripMenuItem
        Me.CTabs = New System.Windows.Forms.ToolStripMenuItem
        Me.CStatus = New System.Windows.Forms.ToolStripMenuItem
        Me.CTrackBars = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.CCompact = New System.Windows.Forms.ToolStripMenuItem
        Me.CSkins = New System.Windows.Forms.ToolStripMenuItem
        Me.CIntegr = New System.Windows.Forms.ToolStripMenuItem
        Me.CSets = New System.Windows.Forms.ToolStripMenuItem
        Me.CAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.CExit = New System.Windows.Forms.ToolStripMenuItem
        Me.PLCurFile = New System.Windows.Forms.Label
        Me.PNext = New System.Windows.Forms.PictureBox
        Me.PPlay = New System.Windows.Forms.PictureBox
        Me.PPrev = New System.Windows.Forms.PictureBox
        Me.PCompact = New System.Windows.Forms.PictureBox
        Me.PMin = New System.Windows.Forms.PictureBox
        Me.PClose = New System.Windows.Forms.PictureBox
        Me.TabVideo = New System.Windows.Forms.TabPage
        Me.PanelVideo = New System.Windows.Forms.Panel
        Me.PicVideoPrev = New System.Windows.Forms.PictureBox
        Me.PicVideoNext = New System.Windows.Forms.PictureBox
        Me.PicVideoPlay = New System.Windows.Forms.PictureBox
        Me.PicVideo = New System.Windows.Forms.PictureBox
        Me.ContextFullscreen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmdFullScr = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPlaylist = New System.Windows.Forms.TabPage
        Me.Playlist = New System.Windows.Forms.ListBox
        Me.Tabs = New System.Windows.Forms.TabControl
        Me.TabLibrary = New System.Windows.Forms.TabPage
        Me.Library = New System.Windows.Forms.TreeView
        Me.ToolLib = New System.Windows.Forms.ToolStrip
        Me.CLibrary = New System.Windows.Forms.ToolStripDropDownButton
        Me.CRfrshLib = New System.Windows.Forms.ToolStripMenuItem
        Me.TimerScroll = New System.Windows.Forms.Timer(Me.components)
        Me.ContextCDDVD = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmdPlayCD = New System.Windows.Forms.ToolStripMenuItem
        Me.CmdEjectCD = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerCursor = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVolume = New System.Windows.Forms.Timer(Me.components)
        Me.ContextPlaylist.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpExtras.SuspendLayout()
        CType(Me.CVolDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CVolUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdShuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCur.SuspendLayout()
        CType(Me.CmdEject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStatus.SuspendLayout()
        Me.ContextTray.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.PIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMainMenu.SuspendLayout()
        CType(Me.PNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCompact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVideo.SuspendLayout()
        Me.PanelVideo.SuspendLayout()
        CType(Me.PicVideoPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVideoNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVideoPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextFullscreen.SuspendLayout()
        Me.TabPlaylist.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.TabLibrary.SuspendLayout()
        Me.ToolLib.SuspendLayout()
        Me.ContextCDDVD.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenDlg
        '
        Me.OpenDlg.Filter = "Все файлы (*.*)|*.*"
        Me.OpenDlg.Multiselect = True
        Me.OpenDlg.Title = "Открыть файл..."
        '
        'ContextPlaylist
        '
        Me.ContextPlaylist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdDel, Me.CProperties, Me.ToolStripSeparator8, Me.CPLUp, Me.CPLDown})
        Me.ContextPlaylist.Name = "ContextPlaylist"
        Me.ContextPlaylist.Size = New System.Drawing.Size(168, 98)
        '
        'CmdDel
        '
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.CmdDel.Size = New System.Drawing.Size(167, 22)
        Me.CmdDel.Text = "Удалить"
        '
        'CProperties
        '
        Me.CProperties.Name = "CProperties"
        Me.CProperties.Size = New System.Drawing.Size(167, 22)
        Me.CProperties.Text = "Свойства..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(164, 6)
        '
        'CPLUp
        '
        Me.CPLUp.Name = "CPLUp"
        Me.CPLUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.CPLUp.Size = New System.Drawing.Size(167, 22)
        Me.CPLUp.Text = "Вверх"
        '
        'CPLDown
        '
        Me.CPLDown.Name = "CPLDown"
        Me.CPLDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.CPLDown.Size = New System.Drawing.Size(167, 22)
        Me.CPLDown.Text = "Вниз"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdOpen, Me.ToolStripSeparator1, Me.CmdExit})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(48, 20)
        Me.FileMenu.Text = "Файл"
        '
        'CmdOpen
        '
        Me.CmdOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdOpenFile, Me.CmdOpenFolder, Me.CmdOpenPL, Me.CmdOpenFromURL})
        Me.CmdOpen.Name = "CmdOpen"
        Me.CmdOpen.Size = New System.Drawing.Size(137, 22)
        Me.CmdOpen.Text = "Открыть..."
        '
        'CmdOpenFile
        '
        Me.CmdOpenFile.Name = "CmdOpenFile"
        Me.CmdOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.CmdOpenFile.Size = New System.Drawing.Size(180, 22)
        Me.CmdOpenFile.Text = "Файлы..."
        '
        'CmdOpenFolder
        '
        Me.CmdOpenFolder.Name = "CmdOpenFolder"
        Me.CmdOpenFolder.Size = New System.Drawing.Size(180, 22)
        Me.CmdOpenFolder.Text = "Файлы из папки..."
        '
        'CmdOpenPL
        '
        Me.CmdOpenPL.Name = "CmdOpenPL"
        Me.CmdOpenPL.Size = New System.Drawing.Size(180, 22)
        Me.CmdOpenPL.Text = "Плейлист..."
        '
        'CmdOpenFromURL
        '
        Me.CmdOpenFromURL.Name = "CmdOpenFromURL"
        Me.CmdOpenFromURL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CmdOpenFromURL.Size = New System.Drawing.Size(180, 22)
        Me.CmdOpenFromURL.Text = "Из URL..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'CmdExit
        '
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(137, 22)
        Me.CmdExit.Text = "Выход"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 21)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdTabs, Me.CmdStatus, Me.CmdFilePanel, Me.ToolStripSeparator4, Me.CmdCompact, Me.CmdSkins})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem1.Text = "Вид"
        '
        'CmdTabs
        '
        Me.CmdTabs.Checked = True
        Me.CmdTabs.CheckOnClick = True
        Me.CmdTabs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CmdTabs.Name = "CmdTabs"
        Me.CmdTabs.Size = New System.Drawing.Size(192, 22)
        Me.CmdTabs.Text = "Вкладки"
        '
        'CmdStatus
        '
        Me.CmdStatus.Checked = True
        Me.CmdStatus.CheckOnClick = True
        Me.CmdStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CmdStatus.Name = "CmdStatus"
        Me.CmdStatus.Size = New System.Drawing.Size(192, 22)
        Me.CmdStatus.Text = "Строка состояния"
        '
        'CmdFilePanel
        '
        Me.CmdFilePanel.Checked = True
        Me.CmdFilePanel.CheckOnClick = True
        Me.CmdFilePanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CmdFilePanel.Name = "CmdFilePanel"
        Me.CmdFilePanel.Size = New System.Drawing.Size(192, 22)
        Me.CmdFilePanel.Text = "Панель трека"
        Me.CmdFilePanel.ToolTipText = "Панель с текущей позицией, громкостью и балансом файла"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
        '
        'CmdCompact
        '
        Me.CmdCompact.Name = "CmdCompact"
        Me.CmdCompact.Size = New System.Drawing.Size(192, 22)
        Me.CmdCompact.Text = "Компактный режим"
        '
        'CmdSkins
        '
        Me.CmdSkins.Name = "CmdSkins"
        Me.CmdSkins.Size = New System.Drawing.Size(192, 22)
        Me.CmdSkins.Text = "Скины"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdInt})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem3.Text = "Сервис"
        '
        'CmdInt
        '
        Me.CmdInt.Name = "CmdInt"
        Me.CmdInt.Size = New System.Drawing.Size(155, 22)
        Me.CmdInt.Text = "Интеграция..."
        Me.CmdInt.ToolTipText = "Интеграция с Проводником и ассоциациии с файлами"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdAbout})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem4.Text = "Справка"
        '
        'CmdAbout
        '
        Me.CmdAbout.Name = "CmdAbout"
        Me.CmdAbout.Size = New System.Drawing.Size(155, 22)
        Me.CmdAbout.Text = "О программе"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LCurFileMain)
        Me.Panel1.Controls.Add(Me.GrpExtras)
        Me.Panel1.Controls.Add(Me.GrpCur)
        Me.Panel1.Controls.Add(Me.CmdEject)
        Me.Panel1.Controls.Add(Me.CmdNext)
        Me.Panel1.Controls.Add(Me.CmdStop)
        Me.Panel1.Controls.Add(Me.CmdPlay)
        Me.Panel1.Controls.Add(Me.CmdPrev)
        Me.Panel1.Controls.Add(Me.LDuration)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 100)
        Me.Panel1.TabIndex = 7
        '
        'LCurFileMain
        '
        Me.LCurFileMain.BackColor = System.Drawing.Color.Transparent
        Me.LCurFileMain.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LCurFileMain.ForeColor = System.Drawing.Color.White
        Me.LCurFileMain.Location = New System.Drawing.Point(0, 39)
        Me.LCurFileMain.Name = "LCurFileMain"
        Me.LCurFileMain.Size = New System.Drawing.Size(280, 13)
        Me.LCurFileMain.TabIndex = 19
        Me.LCurFileMain.Text = "CurrentFile"
        '
        'GrpExtras
        '
        Me.GrpExtras.BackColor = System.Drawing.Color.Transparent
        Me.GrpExtras.Controls.Add(Me.CVolDown)
        Me.GrpExtras.Controls.Add(Me.LPercent)
        Me.GrpExtras.Controls.Add(Me.LVolume)
        Me.GrpExtras.Controls.Add(Me.CVolUp)
        Me.GrpExtras.Controls.Add(Me.PicVolume)
        Me.GrpExtras.Controls.Add(Me.LBitrate)
        Me.GrpExtras.Controls.Add(Me.CmdRepeat)
        Me.GrpExtras.Controls.Add(Me.CmdShuffle)
        Me.GrpExtras.Location = New System.Drawing.Point(78, 0)
        Me.GrpExtras.Name = "GrpExtras"
        Me.GrpExtras.Size = New System.Drawing.Size(240, 36)
        Me.GrpExtras.TabIndex = 18
        Me.GrpExtras.TabStop = False
        '
        'CVolDown
        '
        Me.CVolDown.BackColor = System.Drawing.Color.Transparent
        Me.CVolDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CVolDown.Location = New System.Drawing.Point(97, 11)
        Me.CVolDown.Name = "CVolDown"
        Me.CVolDown.Size = New System.Drawing.Size(16, 16)
        Me.CVolDown.TabIndex = 20
        Me.CVolDown.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CVolDown, "Громкость -2%")
        '
        'LPercent
        '
        Me.LPercent.AutoSize = True
        Me.LPercent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LPercent.ForeColor = System.Drawing.Color.White
        Me.LPercent.Location = New System.Drawing.Point(134, 12)
        Me.LPercent.Name = "LPercent"
        Me.LPercent.Size = New System.Drawing.Size(16, 14)
        Me.LPercent.TabIndex = 24
        Me.LPercent.Text = "%"
        '
        'LVolume
        '
        Me.LVolume.AutoSize = True
        Me.LVolume.BackColor = System.Drawing.Color.Transparent
        Me.LVolume.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LVolume.ForeColor = System.Drawing.Color.White
        Me.LVolume.Location = New System.Drawing.Point(113, 12)
        Me.LVolume.Name = "LVolume"
        Me.LVolume.Size = New System.Drawing.Size(25, 14)
        Me.LVolume.TabIndex = 22
        Me.LVolume.Text = "100"
        Me.LVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LVolume, "Громкость")
        '
        'CVolUp
        '
        Me.CVolUp.BackColor = System.Drawing.Color.Transparent
        Me.CVolUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CVolUp.Location = New System.Drawing.Point(151, 11)
        Me.CVolUp.Name = "CVolUp"
        Me.CVolUp.Size = New System.Drawing.Size(16, 16)
        Me.CVolUp.TabIndex = 21
        Me.CVolUp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CVolUp, "Громкость +2%")
        '
        'PicVolume
        '
        Me.PicVolume.BackColor = System.Drawing.Color.Transparent
        Me.PicVolume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicVolume.Location = New System.Drawing.Point(75, 11)
        Me.PicVolume.Name = "PicVolume"
        Me.PicVolume.Size = New System.Drawing.Size(16, 16)
        Me.PicVolume.TabIndex = 23
        Me.PicVolume.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicVolume, "Громкость (выкл)")
        '
        'LBitrate
        '
        Me.LBitrate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LBitrate.ForeColor = System.Drawing.Color.White
        Me.LBitrate.Location = New System.Drawing.Point(169, 11)
        Me.LBitrate.Name = "LBitrate"
        Me.LBitrate.Size = New System.Drawing.Size(66, 16)
        Me.LBitrate.TabIndex = 17
        Me.LBitrate.Text = "Bitrate"
        Me.LBitrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdRepeat
        '
        Me.CmdRepeat.BackColor = System.Drawing.Color.Transparent
        Me.CmdRepeat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdRepeat.Location = New System.Drawing.Point(12, 11)
        Me.CmdRepeat.Name = "CmdRepeat"
        Me.CmdRepeat.Size = New System.Drawing.Size(24, 16)
        Me.CmdRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdRepeat.TabIndex = 15
        Me.CmdRepeat.TabStop = False
        Me.CmdRepeat.Tag = "False"
        Me.ToolTip1.SetToolTip(Me.CmdRepeat, "Повтор")
        '
        'CmdShuffle
        '
        Me.CmdShuffle.BackColor = System.Drawing.Color.Transparent
        Me.CmdShuffle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdShuffle.Location = New System.Drawing.Point(45, 11)
        Me.CmdShuffle.Name = "CmdShuffle"
        Me.CmdShuffle.Size = New System.Drawing.Size(24, 16)
        Me.CmdShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdShuffle.TabIndex = 16
        Me.CmdShuffle.TabStop = False
        Me.CmdShuffle.Tag = "False"
        Me.ToolTip1.SetToolTip(Me.CmdShuffle, "Случайный порядок")
        '
        'GrpCur
        '
        Me.GrpCur.BackColor = System.Drawing.Color.Transparent
        Me.GrpCur.Controls.Add(Me.LCurrentPos)
        Me.GrpCur.Location = New System.Drawing.Point(4, 0)
        Me.GrpCur.Name = "GrpCur"
        Me.GrpCur.Size = New System.Drawing.Size(68, 36)
        Me.GrpCur.TabIndex = 17
        Me.GrpCur.TabStop = False
        '
        'LCurrentPos
        '
        Me.LCurrentPos.AutoSize = True
        Me.LCurrentPos.BackColor = System.Drawing.Color.Transparent
        Me.LCurrentPos.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LCurrentPos.ForeColor = System.Drawing.Color.White
        Me.LCurrentPos.Location = New System.Drawing.Point(8, 11)
        Me.LCurrentPos.Name = "LCurrentPos"
        Me.LCurrentPos.Size = New System.Drawing.Size(51, 22)
        Me.LCurrentPos.TabIndex = 8
        Me.LCurrentPos.Text = "00:00"
        '
        'CmdEject
        '
        Me.CmdEject.BackColor = System.Drawing.Color.Transparent
        Me.CmdEject.Location = New System.Drawing.Point(123, 70)
        Me.CmdEject.Name = "CmdEject"
        Me.CmdEject.Size = New System.Drawing.Size(24, 24)
        Me.CmdEject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdEject.TabIndex = 14
        Me.CmdEject.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CmdEject, "Открыть файлы...")
        '
        'CmdNext
        '
        Me.CmdNext.BackColor = System.Drawing.Color.Transparent
        Me.CmdNext.Location = New System.Drawing.Point(93, 70)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(24, 24)
        Me.CmdNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdNext.TabIndex = 13
        Me.CmdNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CmdNext, "Следующий")
        '
        'CmdStop
        '
        Me.CmdStop.BackColor = System.Drawing.Color.Transparent
        Me.CmdStop.Location = New System.Drawing.Point(63, 70)
        Me.CmdStop.Name = "CmdStop"
        Me.CmdStop.Size = New System.Drawing.Size(24, 24)
        Me.CmdStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdStop.TabIndex = 12
        Me.CmdStop.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CmdStop, "Стоп")
        '
        'CmdPlay
        '
        Me.CmdPlay.BackColor = System.Drawing.Color.Transparent
        Me.CmdPlay.Location = New System.Drawing.Point(33, 70)
        Me.CmdPlay.Name = "CmdPlay"
        Me.CmdPlay.Size = New System.Drawing.Size(24, 24)
        Me.CmdPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdPlay.TabIndex = 10
        Me.CmdPlay.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CmdPlay, "Воспроизведение")
        '
        'CmdPrev
        '
        Me.CmdPrev.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrev.Location = New System.Drawing.Point(3, 70)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(24, 24)
        Me.CmdPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CmdPrev.TabIndex = 9
        Me.CmdPrev.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CmdPrev, "Предыдущий")
        '
        'LDuration
        '
        Me.LDuration.AutoSize = True
        Me.LDuration.BackColor = System.Drawing.Color.Transparent
        Me.LDuration.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LDuration.ForeColor = System.Drawing.Color.White
        Me.LDuration.Location = New System.Drawing.Point(283, 39)
        Me.LDuration.Name = "LDuration"
        Me.LDuration.Size = New System.Drawing.Size(35, 13)
        Me.LDuration.TabIndex = 7
        Me.LDuration.Text = "00:00"
        '
        'TmrDuration
        '
        Me.TmrDuration.Enabled = True
        Me.TmrDuration.Interval = 1000
        '
        'ToolStatus
        '
        Me.ToolStatus.BackColor = System.Drawing.Color.Black
        Me.ToolStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ToolStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.LCurFile})
        Me.ToolStatus.Location = New System.Drawing.Point(0, 425)
        Me.ToolStatus.Name = "ToolStatus"
        Me.ToolStatus.Size = New System.Drawing.Size(325, 25)
        Me.ToolStatus.TabIndex = 8
        Me.ToolStatus.Text = "ToolStrip2"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdAddFiles, Me.ToolStripSeparator6, Me.COpenPL, Me.CSavePL, Me.CNewPL, Me.ToolStripSeparator5, Me.СортироватьToolStripMenuItem, Me.CLastPL})
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripDropDownButton1.Text = "Playlist"
        '
        'CmdAddFiles
        '
        Me.CmdAddFiles.Name = "CmdAddFiles"
        Me.CmdAddFiles.Size = New System.Drawing.Size(190, 22)
        Me.CmdAddFiles.Text = "Добавить файлы..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(187, 6)
        '
        'COpenPL
        '
        Me.COpenPL.Name = "COpenPL"
        Me.COpenPL.Size = New System.Drawing.Size(190, 22)
        Me.COpenPL.Text = "Открыть..."
        '
        'CSavePL
        '
        Me.CSavePL.Name = "CSavePL"
        Me.CSavePL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.CSavePL.Size = New System.Drawing.Size(190, 22)
        Me.CSavePL.Text = "Сохранить..."
        '
        'CNewPL
        '
        Me.CNewPL.Name = "CNewPL"
        Me.CNewPL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.CNewPL.Size = New System.Drawing.Size(190, 22)
        Me.CNewPL.Text = "Создать"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(187, 6)
        '
        'СортироватьToolStripMenuItem
        '
        Me.СортироватьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSortByName})
        Me.СортироватьToolStripMenuItem.Name = "СортироватьToolStripMenuItem"
        Me.СортироватьToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.СортироватьToolStripMenuItem.Text = "Сортировать..."
        '
        'CSortByName
        '
        Me.CSortByName.Name = "CSortByName"
        Me.CSortByName.Size = New System.Drawing.Size(174, 22)
        Me.CSortByName.Text = "По имени файла"
        '
        'CLastPL
        '
        Me.CLastPL.Enabled = False
        Me.CLastPL.Name = "CLastPL"
        Me.CLastPL.Size = New System.Drawing.Size(190, 22)
        Me.CLastPL.Text = "Последний список"
        Me.CLastPL.ToolTipText = "Воспроизвести последний список воспроизведения"
        '
        'LCurFile
        '
        Me.LCurFile.ForeColor = System.Drawing.Color.White
        Me.LCurFile.Name = "LCurFile"
        Me.LCurFile.Size = New System.Drawing.Size(69, 22)
        Me.LCurFile.Text = "CurrentFile"
        '
        'OpenPLDlg
        '
        Me.OpenPLDlg.DefaultExt = "pl"
        Me.OpenPLDlg.Filter = "Списки воспроизведения|*.m3u"
        Me.OpenPLDlg.Title = "Открыть плейлист..."
        '
        'SavePLDlg
        '
        Me.SavePLDlg.Filter = "Списки воспроизведения|*.m3u"
        Me.SavePLDlg.Title = "Сохранить плейлист..."
        '
        'Tray
        '
        Me.Tray.BalloonTipTitle = "ProXPlayer"
        Me.Tray.ContextMenuStrip = Me.ContextTray
        Me.Tray.Text = "ProXPlayer"
        Me.Tray.Visible = True
        '
        'ContextTray
        '
        Me.ContextTray.BackColor = System.Drawing.Color.White
        Me.ContextTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.TOpenFile, Me.ToolStripSeparator2, Me.TAbout, Me.TExit})
        Me.ContextTray.Name = "ContextTray"
        Me.ContextTray.Size = New System.Drawing.Size(181, 98)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TPlay, Me.TPause, Me.TStop, Me.ToolStripSeparator3, Me.TPrev, Me.TNext})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Воспроизведение"
        '
        'TPlay
        '
        Me.TPlay.Name = "TPlay"
        Me.TPlay.Size = New System.Drawing.Size(180, 22)
        Me.TPlay.Text = "Воспроизвести"
        '
        'TPause
        '
        Me.TPause.Name = "TPause"
        Me.TPause.Size = New System.Drawing.Size(180, 22)
        Me.TPause.Text = "Пауза"
        '
        'TStop
        '
        Me.TStop.Name = "TStop"
        Me.TStop.Size = New System.Drawing.Size(180, 22)
        Me.TStop.Text = "Стоп"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'TPrev
        '
        Me.TPrev.Name = "TPrev"
        Me.TPrev.Size = New System.Drawing.Size(180, 22)
        Me.TPrev.Text = "Предыдущий трек"
        '
        'TNext
        '
        Me.TNext.Name = "TNext"
        Me.TNext.Size = New System.Drawing.Size(180, 22)
        Me.TNext.Text = "Следующий трек"
        '
        'TOpenFile
        '
        Me.TOpenFile.Name = "TOpenFile"
        Me.TOpenFile.Size = New System.Drawing.Size(180, 22)
        Me.TOpenFile.Text = "Открыть файлы..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'TAbout
        '
        Me.TAbout.Name = "TAbout"
        Me.TAbout.Size = New System.Drawing.Size(180, 22)
        Me.TAbout.Text = "О программе"
        '
        'TExit
        '
        Me.TExit.Name = "TExit"
        Me.TExit.Size = New System.Drawing.Size(180, 22)
        Me.TExit.Text = "Выход"
        '
        'OpenFolder
        '
        Me.OpenFolder.ShowNewFolderButton = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Transparent
        Me.PanelTop.Controls.Add(Me.PIcon)
        Me.PanelTop.Controls.Add(Me.PLCurFile)
        Me.PanelTop.Controls.Add(Me.PNext)
        Me.PanelTop.Controls.Add(Me.PPlay)
        Me.PanelTop.Controls.Add(Me.PPrev)
        Me.PanelTop.Controls.Add(Me.PCompact)
        Me.PanelTop.Controls.Add(Me.PMin)
        Me.PanelTop.Controls.Add(Me.PClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(325, 21)
        Me.PanelTop.TabIndex = 9
        '
        'PIcon
        '
        Me.PIcon.ContextMenuStrip = Me.CMainMenu
        Me.PIcon.Location = New System.Drawing.Point(3, 3)
        Me.PIcon.Name = "PIcon"
        Me.PIcon.Size = New System.Drawing.Size(16, 16)
        Me.PIcon.TabIndex = 15
        Me.PIcon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PIcon, "Главное меню")
        '
        'CMainMenu
        '
        Me.CMainMenu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COpen, Me.CView, Me.CIntegr, Me.CSets, Me.CAbout, Me.CExit})
        Me.CMainMenu.Name = "CMainMenu"
        Me.CMainMenu.Size = New System.Drawing.Size(165, 136)
        '
        'COpen
        '
        Me.COpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COpenFiles, Me.COpenFolder, Me.COpenPlaylist, Me.COpenFromURL})
        Me.COpen.Name = "COpen"
        Me.COpen.Size = New System.Drawing.Size(164, 22)
        Me.COpen.Text = "Открыть"
        '
        'COpenFiles
        '
        Me.COpenFiles.Name = "COpenFiles"
        Me.COpenFiles.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.COpenFiles.Size = New System.Drawing.Size(180, 22)
        Me.COpenFiles.Text = "Файлы..."
        '
        'COpenFolder
        '
        Me.COpenFolder.Name = "COpenFolder"
        Me.COpenFolder.Size = New System.Drawing.Size(180, 22)
        Me.COpenFolder.Text = "Файлы из папки..."
        '
        'COpenPlaylist
        '
        Me.COpenPlaylist.Name = "COpenPlaylist"
        Me.COpenPlaylist.Size = New System.Drawing.Size(180, 22)
        Me.COpenPlaylist.Text = "Плейлист..."
        '
        'COpenFromURL
        '
        Me.COpenFromURL.Name = "COpenFromURL"
        Me.COpenFromURL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.COpenFromURL.Size = New System.Drawing.Size(180, 22)
        Me.COpenFromURL.Text = "Из URL..."
        '
        'CView
        '
        Me.CView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTabs, Me.CStatus, Me.CTrackBars, Me.ToolStripSeparator7, Me.CCompact, Me.CSkins})
        Me.CView.Name = "CView"
        Me.CView.Size = New System.Drawing.Size(164, 22)
        Me.CView.Text = "Вид"
        '
        'CTabs
        '
        Me.CTabs.Checked = True
        Me.CTabs.CheckOnClick = True
        Me.CTabs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CTabs.Name = "CTabs"
        Me.CTabs.Size = New System.Drawing.Size(192, 22)
        Me.CTabs.Text = "Вкладки"
        '
        'CStatus
        '
        Me.CStatus.Checked = True
        Me.CStatus.CheckOnClick = True
        Me.CStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CStatus.Name = "CStatus"
        Me.CStatus.Size = New System.Drawing.Size(192, 22)
        Me.CStatus.Text = "Строка состояния"
        '
        'CTrackBars
        '
        Me.CTrackBars.Checked = True
        Me.CTrackBars.CheckOnClick = True
        Me.CTrackBars.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CTrackBars.Name = "CTrackBars"
        Me.CTrackBars.Size = New System.Drawing.Size(192, 22)
        Me.CTrackBars.Text = "Панель трека"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(189, 6)
        '
        'CCompact
        '
        Me.CCompact.Name = "CCompact"
        Me.CCompact.Size = New System.Drawing.Size(192, 22)
        Me.CCompact.Text = "Компактный режим"
        '
        'CSkins
        '
        Me.CSkins.Name = "CSkins"
        Me.CSkins.Size = New System.Drawing.Size(192, 22)
        Me.CSkins.Text = "Скины..."
        '
        'CIntegr
        '
        Me.CIntegr.Name = "CIntegr"
        Me.CIntegr.Size = New System.Drawing.Size(164, 22)
        Me.CIntegr.Text = "Интеграция... "
        '
        'CSets
        '
        Me.CSets.Name = "CSets"
        Me.CSets.Size = New System.Drawing.Size(164, 22)
        Me.CSets.Text = "Настройки..."
        '
        'CAbout
        '
        Me.CAbout.Name = "CAbout"
        Me.CAbout.Size = New System.Drawing.Size(164, 22)
        Me.CAbout.Text = "О программе..."
        '
        'CExit
        '
        Me.CExit.Name = "CExit"
        Me.CExit.Size = New System.Drawing.Size(164, 22)
        Me.CExit.Text = "Выход"
        '
        'PLCurFile
        '
        Me.PLCurFile.BackColor = System.Drawing.Color.Transparent
        Me.PLCurFile.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PLCurFile.ForeColor = System.Drawing.Color.White
        Me.PLCurFile.Location = New System.Drawing.Point(90, 3)
        Me.PLCurFile.Name = "PLCurFile"
        Me.PLCurFile.Size = New System.Drawing.Size(162, 14)
        Me.PLCurFile.TabIndex = 14
        Me.PLCurFile.Text = "CurrentFile"
        Me.PLCurFile.Visible = False
        '
        'PNext
        '
        Me.PNext.BackColor = System.Drawing.Color.Transparent
        Me.PNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PNext.Location = New System.Drawing.Point(68, 3)
        Me.PNext.Name = "PNext"
        Me.PNext.Size = New System.Drawing.Size(16, 16)
        Me.PNext.TabIndex = 11
        Me.PNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PNext, "Следующий")
        Me.PNext.Visible = False
        '
        'PPlay
        '
        Me.PPlay.BackColor = System.Drawing.Color.Transparent
        Me.PPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PPlay.Location = New System.Drawing.Point(47, 3)
        Me.PPlay.Name = "PPlay"
        Me.PPlay.Size = New System.Drawing.Size(16, 16)
        Me.PPlay.TabIndex = 6
        Me.PPlay.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PPlay, "Воспроизвести/Пауза")
        Me.PPlay.Visible = False
        '
        'PPrev
        '
        Me.PPrev.BackColor = System.Drawing.Color.Transparent
        Me.PPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PPrev.Location = New System.Drawing.Point(24, 3)
        Me.PPrev.Name = "PPrev"
        Me.PPrev.Size = New System.Drawing.Size(16, 16)
        Me.PPrev.TabIndex = 5
        Me.PPrev.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PPrev, "Предыдущий")
        Me.PPrev.Visible = False
        '
        'PCompact
        '
        Me.PCompact.BackColor = System.Drawing.Color.Transparent
        Me.PCompact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PCompact.Location = New System.Drawing.Point(280, 3)
        Me.PCompact.Name = "PCompact"
        Me.PCompact.Size = New System.Drawing.Size(16, 16)
        Me.PCompact.TabIndex = 3
        Me.PCompact.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PCompact, "Компактный режим")
        '
        'PMin
        '
        Me.PMin.BackColor = System.Drawing.Color.Transparent
        Me.PMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PMin.Location = New System.Drawing.Point(258, 3)
        Me.PMin.Name = "PMin"
        Me.PMin.Size = New System.Drawing.Size(16, 16)
        Me.PMin.TabIndex = 2
        Me.PMin.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PMin, "Свернуть")
        '
        'PClose
        '
        Me.PClose.BackColor = System.Drawing.Color.Transparent
        Me.PClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PClose.Location = New System.Drawing.Point(302, 3)
        Me.PClose.Name = "PClose"
        Me.PClose.Size = New System.Drawing.Size(16, 16)
        Me.PClose.TabIndex = 0
        Me.PClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PClose, "Закрыть")
        '
        'TabVideo
        '
        Me.TabVideo.BackColor = System.Drawing.Color.Transparent
        Me.TabVideo.Controls.Add(Me.PanelVideo)
        Me.TabVideo.Controls.Add(Me.PicVideo)
        Me.TabVideo.Location = New System.Drawing.Point(4, 22)
        Me.TabVideo.Name = "TabVideo"
        Me.TabVideo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVideo.Size = New System.Drawing.Size(317, 278)
        Me.TabVideo.TabIndex = 2
        Me.TabVideo.Text = "Видео"
        '
        'PanelVideo
        '
        Me.PanelVideo.BackColor = System.Drawing.Color.Black
        Me.PanelVideo.Controls.Add(Me.PicVideoPrev)
        Me.PanelVideo.Controls.Add(Me.PicVideoNext)
        Me.PanelVideo.Controls.Add(Me.PicVideoPlay)
        Me.PanelVideo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelVideo.Location = New System.Drawing.Point(3, 205)
        Me.PanelVideo.Name = "PanelVideo"
        Me.PanelVideo.Size = New System.Drawing.Size(311, 70)
        Me.PanelVideo.TabIndex = 17
        '
        'PicVideoPrev
        '
        Me.PicVideoPrev.Location = New System.Drawing.Point(85, 30)
        Me.PicVideoPrev.Name = "PicVideoPrev"
        Me.PicVideoPrev.Size = New System.Drawing.Size(40, 40)
        Me.PicVideoPrev.TabIndex = 2
        Me.PicVideoPrev.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicVideoPrev, "Предыдущий")
        '
        'PicVideoNext
        '
        Me.PicVideoNext.Location = New System.Drawing.Point(185, 30)
        Me.PicVideoNext.Name = "PicVideoNext"
        Me.PicVideoNext.Size = New System.Drawing.Size(40, 40)
        Me.PicVideoNext.TabIndex = 1
        Me.PicVideoNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicVideoNext, "Следующий")
        '
        'PicVideoPlay
        '
        Me.PicVideoPlay.BackColor = System.Drawing.Color.Transparent
        Me.PicVideoPlay.Location = New System.Drawing.Point(131, 22)
        Me.PicVideoPlay.Name = "PicVideoPlay"
        Me.PicVideoPlay.Size = New System.Drawing.Size(48, 48)
        Me.PicVideoPlay.TabIndex = 3
        Me.PicVideoPlay.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicVideoPlay, "Воспроизвести")
        '
        'PicVideo
        '
        Me.PicVideo.BackColor = System.Drawing.Color.Black
        Me.PicVideo.ContextMenuStrip = Me.ContextFullscreen
        Me.PicVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicVideo.Location = New System.Drawing.Point(3, 3)
        Me.PicVideo.Name = "PicVideo"
        Me.PicVideo.Size = New System.Drawing.Size(311, 272)
        Me.PicVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicVideo.TabIndex = 16
        Me.PicVideo.TabStop = False
        '
        'ContextFullscreen
        '
        Me.ContextFullscreen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdFullScr})
        Me.ContextFullscreen.Name = "ContextMenuStrip1"
        Me.ContextFullscreen.Size = New System.Drawing.Size(201, 26)
        '
        'CmdFullScr
        '
        Me.CmdFullScr.CheckOnClick = True
        Me.CmdFullScr.Name = "CmdFullScr"
        Me.CmdFullScr.Size = New System.Drawing.Size(200, 22)
        Me.CmdFullScr.Text = "Полноэкранный режим"
        '
        'TabPlaylist
        '
        Me.TabPlaylist.BackColor = System.Drawing.Color.Transparent
        Me.TabPlaylist.Controls.Add(Me.Playlist)
        Me.TabPlaylist.Location = New System.Drawing.Point(4, 22)
        Me.TabPlaylist.Name = "TabPlaylist"
        Me.TabPlaylist.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPlaylist.Size = New System.Drawing.Size(317, 278)
        Me.TabPlaylist.TabIndex = 1
        Me.TabPlaylist.Text = "Playlist"
        '
        'Playlist
        '
        Me.Playlist.AllowDrop = True
        Me.Playlist.BackColor = System.Drawing.Color.Black
        Me.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Playlist.ContextMenuStrip = Me.ContextPlaylist
        Me.Playlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Playlist.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Playlist.ForeColor = System.Drawing.Color.White
        Me.Playlist.FormattingEnabled = True
        Me.Playlist.HorizontalScrollbar = True
        Me.Playlist.ItemHeight = 14
        Me.Playlist.Location = New System.Drawing.Point(3, 3)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Size = New System.Drawing.Size(311, 268)
        Me.Playlist.TabIndex = 15
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabLibrary)
        Me.Tabs.Controls.Add(Me.TabPlaylist)
        Me.Tabs.Controls.Add(Me.TabVideo)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 121)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(325, 304)
        Me.Tabs.TabIndex = 10
        '
        'TabLibrary
        '
        Me.TabLibrary.BackColor = System.Drawing.Color.Transparent
        Me.TabLibrary.Controls.Add(Me.Library)
        Me.TabLibrary.Controls.Add(Me.ToolLib)
        Me.TabLibrary.Location = New System.Drawing.Point(4, 22)
        Me.TabLibrary.Name = "TabLibrary"
        Me.TabLibrary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLibrary.Size = New System.Drawing.Size(317, 278)
        Me.TabLibrary.TabIndex = 3
        Me.TabLibrary.Text = "Библиотека"
        '
        'Library
        '
        Me.Library.BackColor = System.Drawing.Color.Black
        Me.Library.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Library.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Library.ForeColor = System.Drawing.Color.White
        Me.Library.FullRowSelect = True
        Me.Library.HotTracking = True
        Me.Library.Location = New System.Drawing.Point(3, 3)
        Me.Library.Name = "Library"
        TreeNode13.Name = "CPlaying"
        TreeNode13.NodeFont = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TreeNode13.Text = "Проигрывается"
        TreeNode14.Name = "NodeMusic"
        TreeNode14.Text = "Музыка"
        TreeNode15.Name = "NodeVideo"
        TreeNode15.Text = "Видео"
        TreeNode16.Name = "NodeFiles"
        TreeNode16.NodeFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TreeNode16.Text = "Файлы"
        TreeNode17.Name = "Playlists"
        TreeNode17.NodeFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TreeNode17.Text = "Playlists"
        TreeNode17.ToolTipText = "Списки воспроизведения"
        TreeNode18.Name = "CDDVD"
        TreeNode18.NodeFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        TreeNode18.Text = "CD/DVD дисководы"
        Me.Library.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode16, TreeNode17, TreeNode18})
        Me.Library.Size = New System.Drawing.Size(311, 247)
        Me.Library.TabIndex = 1
        '
        'ToolLib
        '
        Me.ToolLib.BackColor = System.Drawing.Color.Black
        Me.ToolLib.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolLib.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolLib.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLibrary})
        Me.ToolLib.Location = New System.Drawing.Point(3, 250)
        Me.ToolLib.Name = "ToolLib"
        Me.ToolLib.Size = New System.Drawing.Size(311, 25)
        Me.ToolLib.TabIndex = 0
        Me.ToolLib.Text = "ToolStrip2"
        '
        'CLibrary
        '
        Me.CLibrary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CLibrary.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRfrshLib})
        Me.CLibrary.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CLibrary.ForeColor = System.Drawing.Color.White
        Me.CLibrary.Image = CType(resources.GetObject("CLibrary.Image"), System.Drawing.Image)
        Me.CLibrary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CLibrary.Name = "CLibrary"
        Me.CLibrary.Size = New System.Drawing.Size(87, 22)
        Me.CLibrary.Text = "Библиотека"
        '
        'CRfrshLib
        '
        Me.CRfrshLib.Name = "CRfrshLib"
        Me.CRfrshLib.Size = New System.Drawing.Size(136, 22)
        Me.CRfrshLib.Text = "Обновить"
        Me.CRfrshLib.ToolTipText = "Обновить библиотеку"
        '
        'TimerScroll
        '
        Me.TimerScroll.Enabled = True
        Me.TimerScroll.Interval = 200
        '
        'ContextCDDVD
        '
        Me.ContextCDDVD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdPlayCD, Me.CmdEjectCD})
        Me.ContextCDDVD.Name = "ContextCDDVD"
        Me.ContextCDDVD.Size = New System.Drawing.Size(161, 48)
        '
        'CmdPlayCD
        '
        Me.CmdPlayCD.Name = "CmdPlayCD"
        Me.CmdPlayCD.Size = New System.Drawing.Size(160, 22)
        Me.CmdPlayCD.Text = "Воспроизвести"
        '
        'CmdEjectCD
        '
        Me.CmdEjectCD.Name = "CmdEjectCD"
        Me.CmdEjectCD.Size = New System.Drawing.Size(160, 22)
        Me.CmdEjectCD.Text = "Извлечь"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        '
        'TimerCursor
        '
        Me.TimerCursor.Interval = 2000
        '
        'TimerVolume
        '
        Me.TimerVolume.Enabled = True
        '
        'MForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(325, 450)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.ToolStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProXPlayer"
        Me.ContextPlaylist.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GrpExtras.ResumeLayout(False)
        Me.GrpExtras.PerformLayout()
        CType(Me.CVolDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CVolUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdShuffle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCur.ResumeLayout(False)
        Me.GrpCur.PerformLayout()
        CType(Me.CmdEject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStatus.ResumeLayout(False)
        Me.ToolStatus.PerformLayout()
        Me.ContextTray.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        CType(Me.PIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMainMenu.ResumeLayout(False)
        CType(Me.PNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCompact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVideo.ResumeLayout(False)
        Me.PanelVideo.ResumeLayout(False)
        CType(Me.PicVideoPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVideoNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVideoPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextFullscreen.ResumeLayout(False)
        Me.TabPlaylist.ResumeLayout(False)
        Me.Tabs.ResumeLayout(False)
        Me.TabLibrary.ResumeLayout(False)
        Me.TabLibrary.PerformLayout()
        Me.ToolLib.ResumeLayout(False)
        Me.ToolLib.PerformLayout()
        Me.ContextCDDVD.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LCurrentPos As System.Windows.Forms.Label
    Friend WithEvents LDuration As System.Windows.Forms.Label
    Friend WithEvents TmrDuration As System.Windows.Forms.Timer
    Friend WithEvents ToolStatus As System.Windows.Forms.ToolStrip
    Friend WithEvents LCurFile As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdTabs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CSavePL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COpenPL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenPLDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SavePLDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CmdOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdOpenPL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TPrev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CNewPL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdOpenFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CmdFilePanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextPlaylist As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CmdDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents PCompact As System.Windows.Forms.PictureBox
    Friend WithEvents PMin As System.Windows.Forms.PictureBox
    Friend WithEvents PClose As System.Windows.Forms.PictureBox
    Friend WithEvents PPrev As System.Windows.Forms.PictureBox
    Friend WithEvents PPlay As System.Windows.Forms.PictureBox
    Friend WithEvents PNext As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmdCompact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdAddFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabVideo As System.Windows.Forms.TabPage
    Friend WithEvents PicVideo As System.Windows.Forms.PictureBox
    Friend WithEvents TabPlaylist As System.Windows.Forms.TabPage
    Friend WithEvents Playlist As System.Windows.Forms.ListBox
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TimerScroll As System.Windows.Forms.Timer
    Friend WithEvents PLCurFile As System.Windows.Forms.Label
    Friend WithEvents CmdOpenFromURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabLibrary As System.Windows.Forms.TabPage
    Friend WithEvents Library As System.Windows.Forms.TreeView
    Friend WithEvents ToolLib As System.Windows.Forms.ToolStrip
    Friend WithEvents CLibrary As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CRfrshLib As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextCDDVD As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CmdPlayCD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdEjectCD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextFullscreen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CmdFullScr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CmdSkins As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdInt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PIcon As System.Windows.Forms.PictureBox
    Friend WithEvents CMainMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents COpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COpenFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COpenFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COpenPlaylist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COpenFromURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTabs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTrackBars As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CCompact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSkins As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CIntegr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdPrev As System.Windows.Forms.PictureBox
    Friend WithEvents CmdPlay As System.Windows.Forms.PictureBox
    Friend WithEvents CmdStop As System.Windows.Forms.PictureBox
    Friend WithEvents CmdEject As System.Windows.Forms.PictureBox
    Friend WithEvents CmdRepeat As System.Windows.Forms.PictureBox
    Friend WithEvents CmdShuffle As System.Windows.Forms.PictureBox
    Friend WithEvents CmdNext As System.Windows.Forms.PictureBox
    Friend WithEvents GrpCur As System.Windows.Forms.GroupBox
    Friend WithEvents LCurFileMain As System.Windows.Forms.Label
    Friend WithEvents GrpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents CProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBitrate As System.Windows.Forms.Label
    Friend WithEvents TimerCursor As System.Windows.Forms.Timer
    Friend WithEvents PanelVideo As System.Windows.Forms.Panel
    Friend WithEvents PicVideoPrev As System.Windows.Forms.PictureBox
    Friend WithEvents PicVideoNext As System.Windows.Forms.PictureBox
    Friend WithEvents PicVideoPlay As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents СортироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSortByName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CPLUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CPLDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLastPL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CVolUp As System.Windows.Forms.PictureBox
    Friend WithEvents CVolDown As System.Windows.Forms.PictureBox
    Friend WithEvents LVolume As System.Windows.Forms.Label
    Friend WithEvents PicVolume As System.Windows.Forms.PictureBox
    Friend WithEvents TimerVolume As System.Windows.Forms.Timer
    Friend WithEvents CSets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LPercent As System.Windows.Forms.Label

End Class
