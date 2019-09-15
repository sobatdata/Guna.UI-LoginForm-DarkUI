Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        pnLogin.BringToFront()
        GunaTransition1.Hide(pnLogin)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        pnLogin.BringToFront()
        GunaTransition1.Show(pnLogin)
    End Sub
End Class
