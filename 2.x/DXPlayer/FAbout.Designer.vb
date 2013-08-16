<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAbout
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
        Me.CmdOk = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVer = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PLogo = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(242, 135)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(70, 22)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "OK"
        Me.CmdOk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(214, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Версия:"
        '
        'LVer
        '
        Me.LVer.AutoSize = True
        Me.LVer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LVer.ForeColor = System.Drawing.Color.White
        Me.LVer.Location = New System.Drawing.Point(270, 111)
        Me.LVer.Name = "LVer"
        Me.LVer.Size = New System.Drawing.Size(51, 14)
        Me.LVer.TabIndex = 3
        Me.LVer.Text = "Version"
        Me.LVer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Автор: Proman SEW."
        '
        'PLogo
        '
        Me.PLogo.Location = New System.Drawing.Point(12, 7)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(300, 90)
        Me.PLogo.TabIndex = 6
        Me.PLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Дизайнер: mailman"
        '
        'FAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(323, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PLogo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LVer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "О программе"
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
