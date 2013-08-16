<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSets
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
        Me.GrpEffects = New System.Windows.Forms.GroupBox
        Me.RCrossfading = New System.Windows.Forms.RadioButton
        Me.RFading = New System.Windows.Forms.RadioButton
        Me.ROff = New System.Windows.Forms.RadioButton
        Me.OK = New System.Windows.Forms.Button
        Me.Otmena = New System.Windows.Forms.Button
        Me.ChkLoadPL = New System.Windows.Forms.CheckBox
        Me.ChkStartPlay = New System.Windows.Forms.CheckBox
        Me.GrpEffects.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpEffects
        '
        Me.GrpEffects.Controls.Add(Me.RCrossfading)
        Me.GrpEffects.Controls.Add(Me.RFading)
        Me.GrpEffects.Controls.Add(Me.ROff)
        Me.GrpEffects.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GrpEffects.ForeColor = System.Drawing.Color.White
        Me.GrpEffects.Location = New System.Drawing.Point(12, 3)
        Me.GrpEffects.Name = "GrpEffects"
        Me.GrpEffects.Size = New System.Drawing.Size(151, 90)
        Me.GrpEffects.TabIndex = 0
        Me.GrpEffects.TabStop = False
        Me.GrpEffects.Text = "Звуковые эффекты"
        '
        'RCrossfading
        '
        Me.RCrossfading.AutoSize = True
        Me.RCrossfading.Enabled = False
        Me.RCrossfading.Location = New System.Drawing.Point(6, 65)
        Me.RCrossfading.Name = "RCrossfading"
        Me.RCrossfading.Size = New System.Drawing.Size(82, 18)
        Me.RCrossfading.TabIndex = 2
        Me.RCrossfading.Text = "Наложение"
        Me.RCrossfading.UseVisualStyleBackColor = True
        '
        'RFading
        '
        Me.RFading.AutoSize = True
        Me.RFading.Checked = True
        Me.RFading.Location = New System.Drawing.Point(6, 42)
        Me.RFading.Name = "RFading"
        Me.RFading.Size = New System.Drawing.Size(138, 18)
        Me.RFading.TabIndex = 1
        Me.RFading.TabStop = True
        Me.RFading.Text = "Затухание/появление"
        Me.RFading.UseVisualStyleBackColor = True
        '
        'ROff
        '
        Me.ROff.AutoSize = True
        Me.ROff.Location = New System.Drawing.Point(6, 19)
        Me.ROff.Name = "ROff"
        Me.ROff.Size = New System.Drawing.Size(82, 18)
        Me.ROff.TabIndex = 0
        Me.ROff.Text = "Отключить"
        Me.ROff.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(12, 160)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(72, 22)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Otmena
        '
        Me.Otmena.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Otmena.Location = New System.Drawing.Point(90, 160)
        Me.Otmena.Name = "Otmena"
        Me.Otmena.Size = New System.Drawing.Size(72, 22)
        Me.Otmena.TabIndex = 2
        Me.Otmena.Text = "Отмена"
        Me.Otmena.UseVisualStyleBackColor = True
        '
        'ChkLoadPL
        '
        Me.ChkLoadPL.AutoSize = True
        Me.ChkLoadPL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChkLoadPL.ForeColor = System.Drawing.Color.White
        Me.ChkLoadPL.Location = New System.Drawing.Point(12, 99)
        Me.ChkLoadPL.Name = "ChkLoadPL"
        Me.ChkLoadPL.Size = New System.Drawing.Size(138, 32)
        Me.ChkLoadPL.TabIndex = 3
        Me.ChkLoadPL.Text = "Загружать последний" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "список при запуске"
        Me.ChkLoadPL.UseVisualStyleBackColor = True
        '
        'ChkStartPlay
        '
        Me.ChkStartPlay.AutoSize = True
        Me.ChkStartPlay.ForeColor = System.Drawing.Color.White
        Me.ChkStartPlay.Location = New System.Drawing.Point(18, 137)
        Me.ChkStartPlay.Name = "ChkStartPlay"
        Me.ChkStartPlay.Size = New System.Drawing.Size(155, 17)
        Me.ChkStartPlay.TabIndex = 4
        Me.ChkStartPlay.Text = "Начать воспроизведение"
        Me.ChkStartPlay.UseVisualStyleBackColor = True
        '
        'FSets
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.Otmena
        Me.ClientSize = New System.Drawing.Size(174, 195)
        Me.Controls.Add(Me.ChkStartPlay)
        Me.Controls.Add(Me.ChkLoadPL)
        Me.Controls.Add(Me.Otmena)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.GrpEffects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSets"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Настройки"
        Me.GrpEffects.ResumeLayout(False)
        Me.GrpEffects.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpEffects As System.Windows.Forms.GroupBox
    Friend WithEvents RFading As System.Windows.Forms.RadioButton
    Friend WithEvents ROff As System.Windows.Forms.RadioButton
    Friend WithEvents RCrossfading As System.Windows.Forms.RadioButton
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Otmena As System.Windows.Forms.Button
    Friend WithEvents ChkLoadPL As System.Windows.Forms.CheckBox
    Friend WithEvents ChkStartPlay As System.Windows.Forms.CheckBox
End Class
