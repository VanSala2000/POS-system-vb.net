Imports MySql.Data.MySqlClient
Public Class UpdateProducts
    Private Sub UpdateProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        cmbModelItems()
        cmbColorwaysItems()
        cmbBrandItems()
    End Sub
    Public Sub cmbBrandItems()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBrandComboBox"
                .CommandType = CommandType.StoredProcedure

                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Do not clear existing items, only add new ones
                    While reader.Read()
                        Dim brand As String = reader("brand").ToString()
                        If Not cmbBrand.Items.Contains(brand) Then
                            cmbBrand.Items.Add(brand)
                        End If
                    End While
                End Using
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub cmbModelItems()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayModelComboBox"
                .CommandType = CommandType.StoredProcedure

                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Do not clear existing items, only add new ones
                    While reader.Read()
                        Dim model As String = reader("model").ToString()
                        If Not cmbModel.Items.Contains(model) Then
                            cmbModel.Items.Add(model)
                        End If
                    End While
                End Using
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cmbColorwaysItems()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayColorwaysComboBox"
                .CommandType = CommandType.StoredProcedure

                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Do not clear existing items, only add new ones
                    While reader.Read()
                        Dim colorway As String = reader("colorways").ToString()
                        If Not cmbColorways.Items.Contains(colorway) Then
                            cmbColorways.Items.Add(colorway)
                        End If
                    End While
                End Using
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateProductById"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_prod_brand", cmbBrand.Text)
                .Parameters.AddWithValue("@p_prod_model", cmbModel.Text)
                .Parameters.AddWithValue("@p_prod_size", txtSize.Text)
                .Parameters.AddWithValue("@p_prod_colorways", cmbColorways.Text)
                .Parameters.AddWithValue("@p_prod_description", txtDescription.Text)
                .Parameters.AddWithValue("@p_prod_qty", txtQuantity.Text)
                .Parameters.AddWithValue("@p_prod_price", txtPrice.Text)
                .Parameters.AddWithValue("@p_prod_date", DateTime.Now)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Product Successfully Update", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbBrand.SelectedIndex = -1
            cmbModel.SelectedIndex = -1
            txtSize.Clear()
            cmbColorways.SelectedIndex = -1
            txtDescription.Clear()
            txtQuantity.Clear()
            txtPrice.Clear()

            CriticalItems.DisplayQuantityItems()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class