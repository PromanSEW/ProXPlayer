<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFileInfo
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
        Me.Table = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.LName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LSize = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBitrate = New System.Windows.Forms.Label
        Me.LDuration = New System.Windows.Forms.Label
        Me.LPath = New System.Windows.Forms.LinkLabel
        Me.Label6 = New System.Windows.Forms.Label
        Me.LVideoSize = New System.Windows.Forms.Label
        Me.Table.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Table.ColumnCount = 2
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.Table.Controls.Add(Me.Label5, 0, 3)
        Me.Table.Controls.Add(Me.LName, 1, 0)
        Me.Table.Controls.Add(Me.Label1, 0, 0)
        Me.Table.Controls.Add(Me.Label2, 0, 1)
        Me.Table.Controls.Add(Me.Label3, 0, 2)
        Me.Table.Controls.Add(Me.LSize, 1, 2)
        Me.Table.Controls.Add(Me.Label4, 0, 4)
        Me.Table.Controls.Add(Me.LBitrate, 1, 4)
        Me.Table.Controls.Add(Me.LDuration, 1, 3)
        Me.Table.Controls.Add(Me.LPath, 1, 1)
        Me.Table.Controls.Add(Me.Label6, 0, 5)
        Me.Table.Controls.Add(Me.LVideoSize, 1, 5)
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(0, 0)
        Me.Table.Name = "Table"
        Me.Table.RowCount = 6
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Table.Size = New System.Drawing.Size(304, 169)
        Me.Table.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Длина:"
        '
        'LName
        '
        Me.LName.AutoEllipsis = True
        Me.LName.AutoSize = True
        Me.LName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LName.ForeColor = System.Drawing.Color.White
        Me.LName.Location = New System.Drawing.Point(75, 0)
        Me.LName.MaximumSize = New System.Drawing.Size(250, 0)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(226, 14)
        Me.LName.TabIndex = 1
        Me.LName.Text = "Current File"
        Me.LName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Имя:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Путь:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Размер:"
        '
        'LSize
        '
        Me.LSize.AutoSize = True
        Me.LSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LSize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LSize.ForeColor = System.Drawing.Color.White
        Me.LSize.Location = New System.Drawing.Point(75, 27)
        Me.LSize.Name = "LSize"
        Me.LSize.Size = New System.Drawing.Size(226, 14)
        Me.LSize.TabIndex = 6
        Me.LSize.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Битрейт:"
        '
        'LBitrate
        '
        Me.LBitrate.AutoSize = True
        Me.LBitrate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBitrate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LBitrate.ForeColor = System.Drawing.Color.White
        Me.LBitrate.Location = New System.Drawing.Point(75, 55)
        Me.LBitrate.Name = "LBitrate"
        Me.LBitrate.Size = New System.Drawing.Size(226, 14)
        Me.LBitrate.TabIndex = 8
        Me.LBitrate.Text = "Bitrate"
        '
        'LDuration
        '
        Me.LDuration.AutoSize = True
        Me.LDuration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LDuration.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDuration.ForeColor = System.Drawing.Color.White
        Me.LDuration.Location = New System.Drawing.Point(75, 41)
        Me.LDuration.Name = "LDuration"
        Me.LDuration.Size = New System.Drawing.Size(226, 14)
        Me.LDuration.TabIndex = 11
        Me.LDuration.Text = "Duration"
        '
        'LPath
        '
        Me.LPath.AutoSize = True
        Me.LPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LPath.LinkColor = System.Drawing.Color.White
        Me.LPath.Location = New System.Drawing.Point(75, 14)
        Me.LPath.Name = "LPath"
        Me.LPath.Size = New System.Drawing.Size(226, 13)
        Me.LPath.TabIndex = 12
        Me.LPath.TabStop = True
        Me.LPath.Text = "Path"
        Me.LPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 100)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Видео:"
        '
        'LVideoSize
        '
        Me.LVideoSize.AutoSize = True
        Me.LVideoSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVideoSize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVideoSize.ForeColor = System.Drawing.Color.White
        Me.LVideoSize.Location = New System.Drawing.Point(75, 69)
        Me.LVideoSize.Name = "LVideoSize"
        Me.LVideoSize.Size = New System.Drawing.Size(226, 100)
        Me.LVideoSize.TabIndex = 14
        Me.LVideoSize.Text = "VideoSize"
        '
        'FFileInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(304, 169)
        Me.Controls.Add(Me.Table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFileInfo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Свойства медиафайла"
        Me.Table.ResumeLayout(False)
        Me.Table.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LSize As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBitrate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LDuration As System.Windows.Forms.Label
    Friend WithEvents LPath As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LVideoSize As System.Windows.Forms.Label
End Class
