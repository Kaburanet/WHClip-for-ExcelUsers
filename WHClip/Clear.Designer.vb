<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClearForm
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
        Me.ClearListBox = New System.Windows.Forms.ListBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClearListBox
        '
        Me.ClearListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClearListBox.FormattingEnabled = True
        Me.ClearListBox.ItemHeight = 15
        Me.ClearListBox.Location = New System.Drawing.Point(0, 0)
        Me.ClearListBox.Name = "ClearListBox"
        Me.ClearListBox.Size = New System.Drawing.Size(524, 399)
        Me.ClearListBox.TabIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClearButton.Location = New System.Drawing.Point(0, 399)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(524, 40)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "消去"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ClearForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(524, 439)
        Me.Controls.Add(Me.ClearListBox)
        Me.Controls.Add(Me.ClearButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ClearForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "消去"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClearListBox As ListBox
    Friend WithEvents ClearButton As Button
End Class
