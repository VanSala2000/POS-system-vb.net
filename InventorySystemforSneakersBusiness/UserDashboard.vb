Public Class UserDashboard
    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Logging out...")
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class