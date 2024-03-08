Imports MySql.Data.MySqlClient
Public Class Form2

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Validate the user
        If ValidateUser(username, password) Then
            MessageBox.Show("Login Successfully")
            CashierDashboard.Show()
            Me.Close()
            Form1.Hide()
        ElseIf ValidateUser(username, password) Then
            MessageBox.Show("Login Successfully")
            CashierDashboard.Show()
            Me.Close()
            Form1.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

End Class