Public Class Form3
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If ValidateAdminAndUpdatePassword(username, password) Then
            MessageBox.Show("Login Successfully")
            AdminDashboard.Show()
            Me.Close()
            Form1.Close()

        ElseIf ValidateAdminAndUpdatePassword(username, password) Then
            MessageBox.Show("Login Successfully")
            AdminDashboard.Show()
            Me.Close()
            Form1.Close()

        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

End Class