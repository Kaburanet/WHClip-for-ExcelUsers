<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeClipboard
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
        Me.ClipboardRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ClipChangeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClipboardRichTextBox
        '
        Me.ClipboardRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClipboardRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.ClipboardRichTextBox.Name = "ClipboardRichTextBox"
        Me.ClipboardRichTextBox.Size = New System.Drawing.Size(744, 429)
        Me.ClipboardRichTextBox.TabIndex = 0
        Me.ClipboardRichTextBox.Text = ""
        '
        'ClipChangeButton
        '
        Me.ClipChangeButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClipChangeButton.Location = New System.Drawing.Point(0, 429)
        Me.ClipChangeButton.Name = "ClipChangeButton"
        Me.ClipChangeButton.Size = New System.Drawing.Size(744, 41)
        Me.ClipChangeButton.TabIndex = 1
        Me.ClipChangeButton.Text = "変更を反映"
        Me.ClipChangeButton.UseVisualStyleBackColor = True
        '
        'ChangeClipboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(744, 470)
        Me.Controls.Add(Me.ClipboardRichTextBox)
        Me.Controls.Add(Me.ClipChangeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ChangeClipboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "クリップボードを変更"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClipboardRichTextBox As RichTextBox
    Friend WithEvents ClipChangeButton As Button
End Class
