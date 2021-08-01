Public Class SelectForm
    Private Sub SelectClearButton_Click(sender As Object, e As EventArgs) Handles SelectClearButton.Click
        AllOrSelectClear = "選択削除"
        Me.Close()
    End Sub

    Private Sub AllClearButton_Click(sender As Object, e As EventArgs) Handles AllClearButton.Click
        AllOrSelectClear = "すべて削除"
        Me.Close()
    End Sub

    Private Sub SelectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = FormAlwaysTop
    End Sub
End Class