<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OpenAndCloseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.履歴消去ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.定型文追加ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.定型文削除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.色の変更ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.クリップボードの変更ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.隠すToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最大化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.常に手前に表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.HistoryTabPage = New System.Windows.Forms.TabPage()
        Me.HistoryListBox = New System.Windows.Forms.ListBox()
        Me.FixedTextTabPage = New System.Windows.Forms.TabPage()
        Me.FixedTextListBox = New System.Windows.Forms.ListBox()
        Me.AddTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolColorChangeColorDialog = New System.Windows.Forms.ColorDialog()
        Me.WHClipNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.HelpToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SHIFTALTA表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIFTALTH非表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIFTALTC折りたたむToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ソフトのショートカット一覧ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainToolStrip.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.HistoryTabPage.SuspendLayout()
        Me.FixedTextTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainToolStrip
        '
        Me.MainToolStrip.AutoSize = False
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAndCloseToolStripButton, Me.ToolStripSeparator1, Me.SettingsToolStripDropDownButton, Me.ToolStripSeparator2, Me.ToolsToolStripDropDownButton, Me.ToolStripSeparator3, Me.ViewToolStripDropDownButton, Me.ToolStripSeparator4, Me.HelpToolStripDropDownButton, Me.ToolStripSeparator5, Me.ExitToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(550, 40)
        Me.MainToolStrip.TabIndex = 0
        Me.MainToolStrip.Text = "WHClip"
        '
        'OpenAndCloseToolStripButton
        '
        Me.OpenAndCloseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenAndCloseToolStripButton.Image = CType(resources.GetObject("OpenAndCloseToolStripButton.Image"), System.Drawing.Image)
        Me.OpenAndCloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenAndCloseToolStripButton.Name = "OpenAndCloseToolStripButton"
        Me.OpenAndCloseToolStripButton.Size = New System.Drawing.Size(64, 37)
        Me.OpenAndCloseToolStripButton.Text = "WHClip"
        Me.OpenAndCloseToolStripButton.ToolTipText = "Open&Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'SettingsToolStripDropDownButton
        '
        Me.SettingsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SettingsToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.履歴消去ToolStripMenuItem, Me.定型文追加ToolStripMenuItem, Me.定型文削除ToolStripMenuItem, Me.ToolStripMenuItem1, Me.色の変更ToolStripMenuItem})
        Me.SettingsToolStripDropDownButton.Image = CType(resources.GetObject("SettingsToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.SettingsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SettingsToolStripDropDownButton.Name = "SettingsToolStripDropDownButton"
        Me.SettingsToolStripDropDownButton.Size = New System.Drawing.Size(53, 37)
        Me.SettingsToolStripDropDownButton.Text = "設定"
        Me.SettingsToolStripDropDownButton.ToolTipText = "設定"
        '
        '履歴消去ToolStripMenuItem
        '
        Me.履歴消去ToolStripMenuItem.Name = "履歴消去ToolStripMenuItem"
        Me.履歴消去ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.履歴消去ToolStripMenuItem.Text = "履歴消去(&H)"
        '
        '定型文追加ToolStripMenuItem
        '
        Me.定型文追加ToolStripMenuItem.Name = "定型文追加ToolStripMenuItem"
        Me.定型文追加ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.定型文追加ToolStripMenuItem.Text = "定型文追加(&A)"
        '
        '定型文削除ToolStripMenuItem
        '
        Me.定型文削除ToolStripMenuItem.Name = "定型文削除ToolStripMenuItem"
        Me.定型文削除ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.定型文削除ToolStripMenuItem.Text = "定型文削除(&D)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        '色の変更ToolStripMenuItem
        '
        Me.色の変更ToolStripMenuItem.Name = "色の変更ToolStripMenuItem"
        Me.色の変更ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.色の変更ToolStripMenuItem.Text = "色の変更(&C)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ToolsToolStripDropDownButton
        '
        Me.ToolsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolsToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.クリップボードの変更ToolStripMenuItem})
        Me.ToolsToolStripDropDownButton.Image = CType(resources.GetObject("ToolsToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.ToolsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsToolStripDropDownButton.Name = "ToolsToolStripDropDownButton"
        Me.ToolsToolStripDropDownButton.Size = New System.Drawing.Size(56, 37)
        Me.ToolsToolStripDropDownButton.Text = "ツール"
        Me.ToolsToolStripDropDownButton.ToolTipText = "ツール"
        '
        'クリップボードの変更ToolStripMenuItem
        '
        Me.クリップボードの変更ToolStripMenuItem.Name = "クリップボードの変更ToolStripMenuItem"
        Me.クリップボードの変更ToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.クリップボードの変更ToolStripMenuItem.Text = "クリップボードの変更(&C)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'ViewToolStripDropDownButton
        '
        Me.ViewToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.隠すToolStripMenuItem, Me.最大化ToolStripMenuItem, Me.ToolStripMenuItem3, Me.常に手前に表示ToolStripMenuItem})
        Me.ViewToolStripDropDownButton.Image = CType(resources.GetObject("ViewToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.ViewToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewToolStripDropDownButton.Name = "ViewToolStripDropDownButton"
        Me.ViewToolStripDropDownButton.Size = New System.Drawing.Size(53, 37)
        Me.ViewToolStripDropDownButton.Text = "表示"
        Me.ViewToolStripDropDownButton.ToolTipText = "表示設定"
        '
        '隠すToolStripMenuItem
        '
        Me.隠すToolStripMenuItem.Name = "隠すToolStripMenuItem"
        Me.隠すToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.隠すToolStripMenuItem.Text = "隠す(&H)"
        '
        '最大化ToolStripMenuItem
        '
        Me.最大化ToolStripMenuItem.Name = "最大化ToolStripMenuItem"
        Me.最大化ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.最大化ToolStripMenuItem.Text = "最大化(&M)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(221, 6)
        '
        '常に手前に表示ToolStripMenuItem
        '
        Me.常に手前に表示ToolStripMenuItem.Name = "常に手前に表示ToolStripMenuItem"
        Me.常に手前に表示ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.常に手前に表示ToolStripMenuItem.Text = "常に手前に表示(&T)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'ExitToolStripButton
        '
        Me.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExitToolStripButton.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripButton.Image = CType(resources.GetObject("ExitToolStripButton.Image"), System.Drawing.Image)
        Me.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolStripButton.Name = "ExitToolStripButton"
        Me.ExitToolStripButton.Size = New System.Drawing.Size(43, 37)
        Me.ExitToolStripButton.Text = "終了"
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.HistoryTabPage)
        Me.MainTabControl.Controls.Add(Me.FixedTextTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 40)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(550, 430)
        Me.MainTabControl.TabIndex = 1
        '
        'HistoryTabPage
        '
        Me.HistoryTabPage.Controls.Add(Me.HistoryListBox)
        Me.HistoryTabPage.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HistoryTabPage.Location = New System.Drawing.Point(4, 25)
        Me.HistoryTabPage.Name = "HistoryTabPage"
        Me.HistoryTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HistoryTabPage.Size = New System.Drawing.Size(542, 401)
        Me.HistoryTabPage.TabIndex = 0
        Me.HistoryTabPage.Text = "履歴"
        Me.HistoryTabPage.UseVisualStyleBackColor = True
        '
        'HistoryListBox
        '
        Me.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryListBox.FormattingEnabled = True
        Me.HistoryListBox.HorizontalScrollbar = True
        Me.HistoryListBox.ItemHeight = 19
        Me.HistoryListBox.Location = New System.Drawing.Point(3, 3)
        Me.HistoryListBox.Name = "HistoryListBox"
        Me.HistoryListBox.Size = New System.Drawing.Size(536, 395)
        Me.HistoryListBox.TabIndex = 0
        '
        'FixedTextTabPage
        '
        Me.FixedTextTabPage.Controls.Add(Me.FixedTextListBox)
        Me.FixedTextTabPage.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FixedTextTabPage.Location = New System.Drawing.Point(4, 25)
        Me.FixedTextTabPage.Name = "FixedTextTabPage"
        Me.FixedTextTabPage.Size = New System.Drawing.Size(542, 401)
        Me.FixedTextTabPage.TabIndex = 2
        Me.FixedTextTabPage.Text = "定型文"
        Me.FixedTextTabPage.UseVisualStyleBackColor = True
        '
        'FixedTextListBox
        '
        Me.FixedTextListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FixedTextListBox.FormattingEnabled = True
        Me.FixedTextListBox.ItemHeight = 19
        Me.FixedTextListBox.Location = New System.Drawing.Point(0, 0)
        Me.FixedTextListBox.Name = "FixedTextListBox"
        Me.FixedTextListBox.Size = New System.Drawing.Size(542, 401)
        Me.FixedTextListBox.TabIndex = 0
        '
        'AddTimer
        '
        '
        'WHClipNotifyIcon
        '
        Me.WHClipNotifyIcon.Text = "WHClip"
        Me.WHClipNotifyIcon.Visible = True
        '
        'HelpToolStripDropDownButton
        '
        Me.HelpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ソフトのショートカット一覧ToolStripMenuItem, Me.ToolStripMenuItem4, Me.SHIFTALTA表示ToolStripMenuItem, Me.SHIFTALTH非表示ToolStripMenuItem, Me.SHIFTALTC折りたたむToolStripMenuItem, Me.SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem})
        Me.HelpToolStripDropDownButton.Image = CType(resources.GetObject("HelpToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.HelpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripDropDownButton.Name = "HelpToolStripDropDownButton"
        Me.HelpToolStripDropDownButton.Size = New System.Drawing.Size(58, 37)
        Me.HelpToolStripDropDownButton.Text = "ヘルプ"
        '
        'SHIFTALTA表示ToolStripMenuItem
        '
        Me.SHIFTALTA表示ToolStripMenuItem.Name = "SHIFTALTA表示ToolStripMenuItem"
        Me.SHIFTALTA表示ToolStripMenuItem.Size = New System.Drawing.Size(370, 26)
        Me.SHIFTALTA表示ToolStripMenuItem.Text = "SHIFT+ALT+A(表示)"
        '
        'SHIFTALTH非表示ToolStripMenuItem
        '
        Me.SHIFTALTH非表示ToolStripMenuItem.Name = "SHIFTALTH非表示ToolStripMenuItem"
        Me.SHIFTALTH非表示ToolStripMenuItem.Size = New System.Drawing.Size(370, 26)
        Me.SHIFTALTH非表示ToolStripMenuItem.Text = "SHIFT+ALT+H(非表示)"
        '
        'SHIFTALTC折りたたむToolStripMenuItem
        '
        Me.SHIFTALTC折りたたむToolStripMenuItem.Name = "SHIFTALTC折りたたむToolStripMenuItem"
        Me.SHIFTALTC折りたたむToolStripMenuItem.Size = New System.Drawing.Size(370, 26)
        Me.SHIFTALTC折りたたむToolStripMenuItem.Text = "SHIFT+ALT+C(折りたたむ)"
        '
        'SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem
        '
        Me.SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem.Name = "SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem"
        Me.SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem.Size = New System.Drawing.Size(370, 26)
        Me.SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem.Text = "SHIFT+ALT+S(Excelショートカット一覧の表示)"
        '
        'ソフトのショートカット一覧ToolStripMenuItem
        '
        Me.ソフトのショートカット一覧ToolStripMenuItem.Name = "ソフトのショートカット一覧ToolStripMenuItem"
        Me.ソフトのショートカット一覧ToolStripMenuItem.Size = New System.Drawing.Size(370, 26)
        Me.ソフトのショートカット一覧ToolStripMenuItem.Text = "ソフトのショートカット一覧"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(367, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 40)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(550, 470)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.MainToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Clipboard"
        Me.TransparencyKey = System.Drawing.SystemColors.Info
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.MainTabControl.ResumeLayout(False)
        Me.HistoryTabPage.ResumeLayout(False)
        Me.FixedTextTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents OpenAndCloseToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SettingsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents 履歴消去ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 定型文追加ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 定型文削除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 色の変更ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents クリップボードの変更ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ViewToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents 隠すToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 最大化ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents 常に手前に表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExitToolStripButton As ToolStripButton
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents HistoryTabPage As TabPage
    Friend WithEvents HistoryListBox As ListBox
    Friend WithEvents FixedTextTabPage As TabPage
    Friend WithEvents FixedTextListBox As ListBox
    Friend WithEvents AddTimer As Timer
    Friend WithEvents ToolColorChangeColorDialog As ColorDialog
    Friend WithEvents WHClipNotifyIcon As NotifyIcon
    Friend WithEvents HelpToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents ソフトのショートカット一覧ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents SHIFTALTA表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHIFTALTH非表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHIFTALTC折りたたむToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHIFTALTSExcelショートカット一覧の表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
