<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AllClearButton = New System.Windows.Forms.Button()
        Me.SelectClearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AllClearButton
        '
        Me.AllClearButton.Location = New System.Drawing.Point(184, 52)
        Me.AllClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AllClearButton.Name = "AllClearButton"
        Me.AllClearButton.Size = New System.Drawing.Size(104, 54)
        Me.AllClearButton.TabIndex = 5
        Me.AllClearButton.Text = "すべて削除"
        Me.AllClearButton.UseVisualStyleBackColor = True
        '
        'SelectClearButton
        '
        Me.SelectClearButton.Location = New System.Drawing.Point(32, 52)
        Me.SelectClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectClearButton.Name = "SelectClearButton"
        Me.SelectClearButton.Size = New System.Drawing.Size(104, 54)
        Me.SelectClearButton.TabIndex = 4
        Me.SelectClearButton.Text = "選択削除"
        Me.SelectClearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "履歴を削除する方法を選んでください。"
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(318, 127)
        Me.Controls.Add(Me.AllClearButton)
        Me.Controls.Add(Me.SelectClearButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "消去"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllClearButton As Button
    Friend WithEvents SelectClearButton As Button
    Friend WithEvents Label1 As Label
End Class
