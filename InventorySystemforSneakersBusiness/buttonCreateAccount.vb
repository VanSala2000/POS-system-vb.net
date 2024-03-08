Public Class buttonCreateAccount
    Private Sub buttonCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CreateAccount()
        buttonDeleteAccount.DisplayAllAccounts()
    End Sub
    Public Sub CreateAccount()

        Dim password As String = txtPassword.Text
        Dim confirmpassword As String = txtConfirmPassword.Text

        Try
            If password.Length >= 7 Then
                If password = confirmpassword Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procCreateAccount"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_fname", txtFirstname.Text)
                        .Parameters.AddWithValue("@p_lname", txtLastname.Text)
                        .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                        .Parameters.AddWithValue("@p_address", txtAddress.Text)
                        .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                        .Parameters.AddWithValue("@p_username", txtUsername.Text)
                        .Parameters.AddWithValue("@p_password", txtPassword.Text)
                        .Parameters.AddWithValue("@p_created_at", DateTime.Now)

                        Dim result As String = Convert.ToString(command.ExecuteScalar())

                        If result = "Account created successfully" Then
                            MessageBox.Show("Account created successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtFirstname.Clear()
                            txtLastname.Clear()
                            cmbGender.SelectedIndex = -1
                            txtAddress.Clear()
                            txtContactNo.Clear()
                            txtUsername.Clear()
                            txtPassword.Clear()
                            txtConfirmPassword.Clear()
                        ElseIf result = "Duplicate username. Account creation failed." Then
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("An error occurred while creating the account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End With
                Else
                    MessageBox.Show("New password and confirmed password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Password must be at least 7 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirstname.Clear()
        txtLastname.Clear()
        cmbGender.SelectedIndex = -1
        txtAddress.Clear()
        txtContactNo.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

End Class