Public Class ShowImageForm

    Public Is_MouseOver As Boolean  'マウスがかぶさっているか
    Public Timer_Count As Long

    Private Sub ShowImageForm_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.Opacity = 100
        CountTimer.Stop()
        Timer_Count = 0
    End Sub

    Private Sub ShowImageForm_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Timer_Count = 0
        CountTimer.Interval = 50
        CountTimer.Start()
    End Sub
    Private Sub CountTimer_Tick(sender As Object, e As EventArgs) Handles CountTimer.Tick

        'マウスが離れたらウィンドウを徐々に透過して閉じる
        If Timer_Count >= 20 Then
            Me.Opacity -= 0.05
        End If

        If Me.Opacity <= 0 Then
            Me.Close()
        End If

        Timer_Count += 1
    End Sub

    Private Sub ShowImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        'マウスポインタの位置を取得する
        'X座標を取得する
        Dim x As Integer = Cursor.Position.X
        'Y座標を取得する
        Dim y As Integer = Cursor.Position.Y

        Me.Location = New Point(x + 50, y)


        Me.BackgroundImage = Image.FromFile(Application.StartupPath + "/Data/Image/sugoi_kaizen.jpg")
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Me.Opacity = 50
        Timer_Count = 0

        CountTimer.Interval = 50
        CountTimer.Start()
    End Sub


End Class