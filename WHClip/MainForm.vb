Imports System.IO
Imports System.Text

Public Class MainForm

    Public PictureFolder As String = (Application.StartupPath + "/Data/Image/") '画像フォルダのパス
    Public HistoryFilePath As String = Application.StartupPath + "/Data/Clip.ini"
    Public FixedTextFilePath As String = Application.StartupPath + "/Data/FixedText.ini"
    Public Status_OC As Boolean = False 'Falseで閉じてTrueで開く
    Public MeHeight As Integer = 550
    Public MeHideHight As Integer = 40

    Private Sub LoadSettings()

        '*******************************履歴を読み込む**************************
        Dim HistoryStr As New StreamReader(HistoryFilePath, Encoding.Default)

        'ファイルの最後までループ
        Do Until HistoryStr.Peek = -1
            '1行ずつ読み込む
            HistoryListBox.Items.Add(HistoryStr.ReadLine)
        Loop

        HistoryStr.Close() 'ファイルを閉じる

        '************************************************************************

        '***************************定型文を読み込む*****************************
        Dim FixedTextStr As New StreamReader(FixedTextFilePath, Encoding.Default)
        'ファイルの最後までループ
        Do Until FixedTextStr.Peek = -1
            '１行づつ読込む
            FixedTextListBox.Items.Add(FixedTextStr.ReadLine)
        Loop
        FixedTextStr.Close()     'ファイルを閉じる

        '************************************************************************


        'クリップボードの監視をスタート
        AddTimer.Interval = 1000
        AddTimer.Enabled = True

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.TopMost = True

            '常に手前に表示するかしないかの設定
            If Me.TopMost = False Then
                常に手前に表示ToolStripMenuItem.Checked = False
                FormAlwaysTop = False
            Else
                常に手前に表示ToolStripMenuItem.Checked = True
                FormAlwaysTop = True
            End If


            Status_OC = False

            Me.Height = MeHideHight



            'データを読み込む
            LoadSettings()

            'ホットキーの登録
            Register_HotKey()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'ホットキーの解除
        Unregister_HotKey()
    End Sub

    Private Sub AddTimer_Tick(sender As Object, e As EventArgs) Handles AddTimer.Tick
        Dim ClipboardGet As String = Clipboard.GetText()
        If ClipboardGet = Nothing Then
            Exit Sub
        End If

        'リストボックスの選択解除
        HistoryListBox.ClearSelected()

        '改行を別の文字で置き換える
        ClipboardGet = ClipboardGet.Replace(vbCrLf, "| |").Replace(vbLf, "| |")

        'リストボックスを検索する
        Dim x As Integer = -1
        x = HistoryListBox.FindString(ClipboardGet, x)
        '見つからなかったらリストボックスに項目を追加
        If x = -1 Then
            HistoryListBox.Items.Insert(0, ClipboardGet)

            'テキストファイルを上書きモードで開く(True で追加書込み)
            Using Str As New StreamWriter(HistoryFilePath, False, Encoding.Default)
                For i As Integer = 0 To HistoryListBox.Items.Count - 1
                    'ファイルへ書込み
                    Str.WriteLine(HistoryListBox.Items(i).ToString())
                Next
                'ファイル閉じる
            End Using
        End If


    End Sub

    Private Sub HistoryListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HistoryListBox.SelectedIndexChanged
        Try
            If HistoryListBox.Text = "" Then
                Exit Sub
            End If

            '改行文字の再設定
            Dim tmp As String
            tmp = HistoryListBox.SelectedItem
            '改行文字に置き換える
            tmp = tmp.Replace("|  |", vbCrLf)

            'クリップボードに再設定した文字列をコピーする
            My.Computer.Clipboard.SetText(tmp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenAndCloseToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenAndCloseToolStripButton.Click
        If Status_OC = False Then
            Status_OC = True
            Me.Height = MeHeight

        ElseIf Status_OC = True Then
            Status_OC = False
            Me.Height = MeHideHight
        End If

    End Sub

    Private Sub ExitToolStripButton_Click(sender As Object, e As EventArgs) Handles ExitToolStripButton.Click
        Application.Exit()
    End Sub

    Private Sub 履歴消去ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 履歴消去ToolStripMenuItem.Click

        ClearMode = "履歴"
        Dim AllOrSelect As New SelectForm
        AllOrSelect.ShowDialog()

        If AllOrSelectClear = "選択削除" Then
            Dim SelectClear As New ClearForm
            SelectClear.ShowDialog()

        ElseIf AllOrSelectClear = "すべて削除" Then

            Dim Warning As DialogResult
            Warning = MessageBox.Show("本当に履歴を消去しますか？", "WHClip", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Warning = Windows.Forms.DialogResult.Yes Then
                HistoryListBox.Items.Clear()
                'テキストファイルを上書きモードで開く(True で追加書込み)
                Using Str As New StreamWriter(HistoryFilePath, False, Encoding.Default)
                    For i As Integer = 0 To HistoryListBox.Items.Count - 1
                        'ファイルへ書込み
                        Str.WriteLine(HistoryListBox.Items(i).ToString())
                    Next
                    'ファイル閉じる
                End Using
            End If
        End If

        ClearMode = String.Empty
    End Sub

    Private Sub 定型文追加ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 定型文追加ToolStripMenuItem.Click
        Me.TopMost = False

        Dim InputStr As String
        InputStr = InputBox("追加する定型文を入力してください。", "WHClip")

        Me.TopMost = FormAlwaysTop

        If InputStr = Nothing Then
            Exit Sub
        End If

        FixedTextListBox.Items.Add(InputStr)
        'ListBoxの項目を別名でファイルへの保存
        'テキストファイルを上書きモードで開く(True で追加書込み)
        Using Str As New StreamWriter(FixedTextFilePath, False, Encoding.Default)
            For i As Integer = 0 To FixedTextListBox.Items.Count - 1
                'ファイルへ書込み
                Str.WriteLine(FixedTextListBox.Items(i).ToString())
            Next
            'ファイル閉じる
        End Using
    End Sub

    Private Sub 定型文削除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 定型文削除ToolStripMenuItem.Click

        ClearMode = "定型文"
        Dim AllOrSelect As New SelectForm
        AllOrSelect.ShowDialog()

        If AllOrSelectClear = "選択削除" Then
            Dim SelectClear As New ClearForm
            SelectClear.ShowDialog()

        ElseIf AllOrSelectClear = "すべて削除" Then
            Dim Warning As DialogResult
            Warning = MessageBox.Show("本当に消去しますか？", "WHClip", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Warning = Windows.Forms.DialogResult.Yes Then
                FixedTextListBox.Items.Clear()
                'ListBoxの項目を別名でファイルへの保存
                'テキストファイルを上書きモードで開く(True で追加書込み)
                Using st As New StreamWriter(FixedTextFilePath, False, Encoding.Default)
                    For i As Integer = 0 To FixedTextListBox.Items.Count - 1
                        'ファイルへ書込み
                        st.WriteLine(FixedTextListBox.Items(i).ToString())
                    Next
                    'ファイル閉じる
                End Using

            End If

            'Form1のListBoxを再読み込み
            FixedTextListBox.Items.Clear()
            Dim cReader As New StreamReader(FixedTextFilePath, Encoding.Default)
            Dim stResult As String = String.Empty
            While (cReader.Peek() >= 0)
                Dim stBuffer As String = cReader.ReadLine()
                FixedTextListBox.Items.Add(stBuffer)
                stResult &= stBuffer & Environment.NewLine
            End While

            cReader.Close()
        End If

        ClearMode = String.Empty
    End Sub

    Private Sub 色の変更ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 色の変更ToolStripMenuItem.Click
        Dim Ret As DialogResult
        ToolColorChangeColorDialog.AllowFullOpen = True
        Ret = ToolColorChangeColorDialog.ShowDialog()
        If Ret = Windows.Forms.DialogResult.OK Then
            MainToolStrip.BackColor = ToolColorChangeColorDialog.Color
        End If
    End Sub

    Private Sub クリップボードの変更ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles クリップボードの変更ToolStripMenuItem.Click
        Dim Clip As New ChangeClipboard
        Clip.ShowDialog()
    End Sub

    Private Sub 隠すToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 隠すToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Visible = False
            WHClipNotifyIcon.ShowBalloonTip(2000, "WHClip", "EClipboardを隠しました。", ToolTipIcon.Info)
        Else
            MessageBox.Show("すでに隠されています。", "WHClip")
        End If
    End Sub

    Private Sub 最大化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最大化ToolStripMenuItem.Click
        If 最大化ToolStripMenuItem.Text = "最大化(&M)" Then
            Me.WindowState = FormWindowState.Maximized
            最大化ToolStripMenuItem.Text = "元に戻す(&R)"
            Me.BackColor = Color.White
        Else
            Me.WindowState = FormWindowState.Normal
            最大化ToolStripMenuItem.Text = "最大化(&M)"
            Me.BackColor = SystemColors.Info
        End If
    End Sub

    Private Sub 常に手前に表示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 常に手前に表示ToolStripMenuItem.Click
        If 常に手前に表示ToolStripMenuItem.Checked = True Then
            Me.TopMost = False
            FormAlwaysTop = False
            常に手前に表示ToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            FormAlwaysTop = True
            常に手前に表示ToolStripMenuItem.Checked = True
        End If
    End Sub




#Region "移動"
    Private MousePoint As Point

    Private Sub MainToolStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles MainToolStrip.MouseDown
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            MousePoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub MainToolStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles MainToolStrip.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            Me.Left += e.X - MousePoint.X
            Me.Top += e.Y - MousePoint.Y
        End If
    End Sub

    Private Sub FixedTextListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FixedTextListBox.SelectedIndexChanged
        Try
            If FixedTextListBox.Text = "" Then
                Exit Sub
            End If
            'クリップボードに文字列をコピーする
            My.Computer.Clipboard.SetText(FixedTextListBox.SelectedItem)
            FixedTextListBox.ClearSelected()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region


#Region "ホットキー"
    'APIの定義
    Public Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Keys) As Integer

    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Public Declare Function GlobalAddAtom Lib "kernel32" Alias "GlobalAddAtomA" (ByVal lpString As String) As Short

    Public Declare Function GlobalDeleteAtom Lib "kernel32" (ByVal nAtom As Short) As Short

    Public Const MOD_ALT As Integer = &H1

    Public Const MOD_CONTROL As Integer = &H2

    Public Const MOD_SHIFT As Integer = &H4

    Public Const MOD_WIN As Integer = &H8

    Public Const WM_HOTKEY As Integer = &H312


    Public hotkeyID_A As Short '(Shift + A )用
    Public hotkeyID_Hide As Short 'フォームを隠す用(Shift + H)
    Public hotkeyID_C As Short 'フォームの見た目を小さくする(Shift + C)
    Public hotkeyID_S As Short 'ショートカットの画像表示用


    'ホットキーのIDを作成
    Public Sub Register_HotKey()
        '開いてアクティブにする
        hotkeyID_A = GlobalAddAtom("GlobalHotKey_A" & Me.GetHashCode().ToString())
        'レジスターに登録
        RegisterHotKey(Me.Handle, hotkeyID_A, MOD_SHIFT Or MOD_ALT, Keys.A)

        '隠す
        hotkeyID_Hide = GlobalAddAtom("GlobalHotKey_Hide" & Me.GetHashCode().ToString())
        'レジスターに登録
        RegisterHotKey(Me.Handle, hotkeyID_Hide, MOD_SHIFT Or MOD_ALT, Keys.H)

        '見た目を小さくする
        hotkeyID_C = GlobalAddAtom("GlobalHotKey_C" & Me.GetHashCode().ToString())
        'レジスターに登録
        RegisterHotKey(Me.Handle, hotkeyID_C, MOD_SHIFT Or MOD_ALT, Keys.C)

        'ショートカット一覧画像の表示
        hotkeyID_S = GlobalAddAtom("GlobalHotKey_S" & Me.GetHashCode().ToString())
        'レジスターに登録
        RegisterHotKey(Me.Handle, hotkeyID_S, MOD_SHIFT Or MOD_ALT, Keys.S)

    End Sub

    Public Sub Unregister_HotKey()
        UnregisterHotKey(Me.Handle, hotkeyID_A)
        GlobalDeleteAtom(hotkeyID_A)

        UnregisterHotKey(Me.Handle, hotkeyID_Hide)
        GlobalDeleteAtom(hotkeyID_Hide)

        UnregisterHotKey(Me.Handle, hotkeyID_C)
        GlobalDeleteAtom(hotkeyID_C)
    End Sub


    'ホットキーが押されたときの処理
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_HOTKEY Then
            Select Case m.WParam
                Case hotkeyID_A
                    'フォームをアクティブにする
                    Me.Activate()

                    'マウスカーソルのところに持ってくる
                    If Screen.PrimaryScreen.Bounds.Bottom < Cursor.Position.Y + MeHeight + 10 Then
                        Me.Top = Cursor.Position.Y - 400
                    Else
                        Me.Top = Cursor.Position.Y + 10
                    End If

                    If Screen.PrimaryScreen.Bounds.Right < Cursor.Position.X + Me.Width + 30 Then
                        Me.Left = Cursor.Position.X - 400
                    Else
                        Me.Left = Cursor.Position.X + 30

                    End If

                    If Me.Visible = False Then
                        Me.Visible = True
                    End If

                    If Status_OC = False Then
                        Status_OC = True
                        Me.Height = MeHeight
                    End If

                    '履歴タブを選択
                    MainTabControl.SelectedTab = HistoryTabPage
                Case hotkeyID_Hide
                    If Me.Visible = True Then
                        Me.Visible = False
                    End If

                Case hotkeyID_C
                    If Status_OC = True Then
                        Status_OC = False
                        Me.Height = MeHideHight
                    End If

                Case hotkeyID_S
                    Dim shortcut As New ShowImageForm
                    shortcut.Show()
            End Select
        End If
    End Sub


#End Region

End Class
