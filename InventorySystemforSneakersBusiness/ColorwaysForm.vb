Public Class ColorwaysForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If action = "Add" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "procInsertColorways"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_colorways", txtColorways.Text)
                    .Parameters.AddWithValue("@p_created_at", DateTime.Now)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Product Successfully Added", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtColorways.Clear()
            Else
                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateColorwaysById"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", id)
                    .Parameters.AddWithValue("@p_colorways", txtColorways.Text)
                    .Parameters.AddWithValue("@p_created_at", DateTime.Now)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Product Successfully Update", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtColorways.Clear()
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Close()
    End Sub
End Class