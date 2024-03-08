Public Class AdminVoidValidation
    Private Sub AdminVoidValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If ValidateAdminAndUpdatePassword(username, password) Then
            MessageBox.Show("OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        ElseIf ValidateAdminAndUpdatePassword(username, password) Then
            MessageBox.Show("OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            CashierDashboard.ComputeSubtotalAndVATAndTotalAmount()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

End Class