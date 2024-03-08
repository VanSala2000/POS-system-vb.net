Public Class BrandForm
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If action = "Add" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "procInsertBrand"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_brand", txtBrand.Text)
                    .Parameters.AddWithValue("@p_created_at", DateTime.Now)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Product Successfully Added", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBrand.Clear()
            Else
                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateBrandByID"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", id)
                    .Parameters.AddWithValue("@p_brand", txtBrand.Text)
                    .Parameters.AddWithValue("@p_created_at", DateTime.Now)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Product Successfully Update", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBrand.Clear()
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class