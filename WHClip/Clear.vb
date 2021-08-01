Public Class ClearForm
    Public PictureFolder As String = (Application.StartupPath + "/Data/Image/") '画像フォルダのパス
    Public HistoryFilePath As String = Application.StartupPath + "/Data/Clip.ini"
    Public FixedTextFilePath As String = Application.StartupPath + "/Data/FixedText.ini"

    Private Sub OpenLoad()
        ClearListBox.Items.Clear()
        Dim FilePath As String = String.Empty
        '保存先を決定する
        If ClearMode = "履歴" Then
            FilePath = HistoryFilePath
        ElseIf ClearMode = "定型文" Then
            FilePath = FixedTextFilePath
        End If

        Dim Str As New System.IO.StreamReader(FilePath, System.Text.Encoding.Default)
        'ファイルの最後までループ
        Do Until Str.Peek = -1
            '１行づつ読込む
            ClearListBox.Items.Add(Str.ReadLine)
        Loop
        Str.Close()     'ファイルを閉じる
    End Sub

    Private Sub ClearForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = FormAlwaysTop
        OpenLoad()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If ClearListBox.Text = "" Or ClearMode = String.Empty Then
            Exit Sub
        End If

        With ClearListBox
            Do While .SelectedIndex > -1
                .Items.RemoveAt(.SelectedIndex)
            Loop
        End With


        Dim FilePath As String = String.Empty
        '保存先を決定する
        If ClearMode = "履歴" Then
            FilePath = HistoryFilePath
        ElseIf ClearMode = "定型文" Then
            FilePath = FixedTextFilePath
        End If

        'テキストファイルを上書きモードで開く(True で追加書込み)
        Using Str1 As New IO.StreamWriter(FilePath, False, System.Text.Encoding.Default)
            For i As Integer = 0 To ClearListBox.Items.Count - 1
                'ファイルへ書込み
                Str1.WriteLine(ClearListBox.Items(i).ToString())
            Next
            'ファイル閉じる
        End Using

        If ClearMode = "履歴" Then
            MainForm.HistoryListBox.Items.Clear()
        ElseIf ClearMode = "定型文" Then
            MainForm.FixedTextListBox.Items.Clear()
        End If

        Dim Str2 As New IO.StreamReader(FilePath, System.Text.Encoding.Default)
        'ファイルの最後までループ
        Do Until Str2.Peek = -1
            '１行づつ読込む
            If ClearMode = "履歴" Then
                MainForm.HistoryListBox.Items.Add(Str2.ReadLine)
            ElseIf ClearMode = "定型文" Then
                MainForm.FixedTextListBox.Items.Add(Str2.ReadLine)
            End If
        Loop
        Str2.Close()     'ファイルを閉じる

        ClearListBox.Items.Clear()
        OpenLoad()
    End Sub
End Class