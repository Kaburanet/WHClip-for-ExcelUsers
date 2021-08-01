Public Class ChangeClipboard
    Private Sub ChangeClipboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = FormAlwaysTop
        Dim Clip As String = Clipboard.GetText()
        ClipboardRichTextBox.Text = Clip
        ClipChangeButton.Enabled = False
    End Sub

    Private Sub ClipChangeButton_Click(sender As Object, e As EventArgs) Handles ClipChangeButton.Click
        If ClipboardRichTextBox.Text = "" Then
            'クリップボードをクリアする
            Clipboard.SetDataObject(New DataObject())
        Else
            'クリップボードに文字列をコピーする
            My.Computer.Clipboard.SetText(ClipboardRichTextBox.Text)
        End If
        Me.Close()
    End Sub

    Private Sub ClipboardRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClipboardRichTextBox.TextChanged
        ClipChangeButton.Enabled = True
    End Sub
End Class