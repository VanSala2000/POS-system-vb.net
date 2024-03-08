Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmLogin As New Form2()
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim frmLogin As New Form3()
        frmLogin.ShowDialog()
    End Sub
End Class
