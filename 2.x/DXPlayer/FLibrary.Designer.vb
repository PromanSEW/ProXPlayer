<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLibrary
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.COtmena = New System.Windows.Forms.Button
        Me.LFiles = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Идёт обновление библиотеки..."
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(9, 32)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(330, 18)
        Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progress.TabIndex = 1
        '
        'COtmena
        '
        Me.COtmena.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.COtmena.Location = New System.Drawing.Point(269, 56)
        Me.COtmena.Name = "COtmena"
        Me.COtmena.Size = New System.Drawing.Size(70, 22)
        Me.COtmena.TabIndex = 2
        Me.COtmena.Text = "Отмена"
        Me.COtmena.UseVisualStyleBackColor = True
        '
        'LFiles
        '
        Me.LFiles.AutoSize = True
        Me.LFiles.Location = New System.Drawing.Point(12, 61)
        Me.LFiles.Name = "LFiles"
        Me.LFiles.Size = New System.Drawing.Size(117, 13)
        Me.LFiles.TabIndex = 3
        Me.LFiles.Text = "Добавлено файлов: 0"
        '
        'FLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.COtmena
        Me.ClientSize = New System.Drawing.Size(344, 83)
        Me.Controls.Add(Me.LFiles)
        Me.Controls.Add(Me.COtmena)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FLibrary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Обновление Библиотеки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents COtmena As System.Windows.Forms.Button
    Friend WithEvents LFiles As System.Windows.Forms.Label

End Class
