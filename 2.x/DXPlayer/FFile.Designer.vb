<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFile
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
        Me.TimerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUnload = New System.Windows.Forms.Timer(Me.components)
        Me.LFile = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TimerScroll = New System.Windows.Forms.Timer(Me.components)
        Me.LNum = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TimerLoad
        '
        Me.TimerLoad.Enabled = True
        Me.TimerLoad.Interval = 50
        '
        'TimerUnload
        '
        Me.TimerUnload.Enabled = True
        Me.TimerUnload.Interval = 50
        '
        'LFile
        '
        Me.LFile.AutoSize = True
        Me.LFile.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LFile.Location = New System.Drawing.Point(5, 57)
        Me.LFile.Name = "LFile"
        Me.LFile.Size = New System.Drawing.Size(50, 18)
        Me.LFile.TabIndex = 0
        Me.LFile.Text = "Файл"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ProXPlayer"
        '
        'TimerScroll
        '
        Me.TimerScroll.Enabled = True
        '
        'LNum
        '
        Me.LNum.AutoSize = True
        Me.LNum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LNum.Location = New System.Drawing.Point(5, 33)
        Me.LNum.Name = "LNum"
        Me.LNum.Size = New System.Drawing.Size(68, 15)
        Me.LNum.TabIndex = 2
        Me.LNum.Text = "000 из 000"
        '
        'FFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(298, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.LNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFile"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerLoad As System.Windows.Forms.Timer
    Friend WithEvents TimerUnload As System.Windows.Forms.Timer
    Friend WithEvents LFile As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerScroll As System.Windows.Forms.Timer
    Friend WithEvents LNum As System.Windows.Forms.Label

End Class
