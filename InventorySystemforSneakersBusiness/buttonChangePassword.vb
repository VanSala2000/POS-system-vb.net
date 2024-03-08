Imports MySql.Data.MySqlClient

Public Class buttonChangePassword
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using connection As New MySqlConnection("Server=localhost;Database=db_inventory;User ID=root;Password=umtc;Port=3307;")
                connection.Open()

                Using command As New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "procAdminChangePassword"
                    command.CommandType = CommandType.StoredProcedure

                    'Replace these values with your actual data
                    Dim username As String = txtUsername.Text
                    Dim currentPassword As String = txtCurrentPassword.Text
                    Dim newPassword As String = txtNewPassword.Text
                    Dim confirmedPassword As String = txtConfirmPassword.Text

                    ' Check if the new password is at least 7 characters long
                    If newPassword.Length >= 7 Then
                        If newPassword = confirmedPassword Then
                            'Add parameters
                            command.Parameters.AddWithValue("@p_username", username)
                            command.Parameters.AddWithValue("@p_current_password", currentPassword)
                            command.Parameters.AddWithValue("@p_new_password", newPassword)

                            'OUT parameter for result
                            Dim resultParameter As New MySqlParameter("@p_result", MySqlDbType.Int32)
                            resultParameter.Direction = ParameterDirection.Output
                            command.Parameters.Add(resultParameter)

                            ' Execute the stored procedure
                            command.ExecuteNonQuery()

                            ' Check the result
                            Dim result As Integer = Convert.ToInt32(resultParameter.Value)

                            If result > 0 Then
                                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtUsername.Clear()
                                txtCurrentPassword.Clear()
                                txtNewPassword.Clear()
                                txtConfirmPassword.Clear()
                            Else
                                MessageBox.Show("Current password is incorrect or an error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("New password and confirmed password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("New password must be at least 7 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

End Class