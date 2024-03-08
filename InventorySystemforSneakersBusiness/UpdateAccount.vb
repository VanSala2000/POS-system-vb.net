Public Class UpdateAccount
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With command
            .Parameters.Clear()
            .CommandText = "procUpdateCashierAccountById"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", id)
            .Parameters.AddWithValue("@p_fname", txtFirstname.Text)
            .Parameters.AddWithValue("@p_lname", txtLastname.Text)
            .Parameters.AddWithValue("@p_gender", cmbGender.Text)
            .Parameters.AddWithValue("@p_address", txtAddress.Text)
            .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
            .Parameters.AddWithValue("@p_username", txtUsername.Text)
            .Parameters.AddWithValue("@p_password", txtPassword.Text)
            .Parameters.AddWithValue("@p_created_at", DateTime.Now)
            .ExecuteNonQuery()
        End With
        MessageBox.Show("Account Successfully Update", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtFirstname.Clear()
        txtLastname.Clear()
        cmbGender.SelectedIndex = -1
        txtAddress.Clear()
        txtContactNo.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Close()
    End Sub
End Class