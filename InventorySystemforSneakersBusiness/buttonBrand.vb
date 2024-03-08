Imports MySql.Data.MySqlClient

Public Class buttonBrand
    Private Sub buttonBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayAllBrand()
        DisplayAllModel()
        DisplayAllColorways()
    End Sub
    Public Sub DisplayAllBrand()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBrand"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)
                lblTotalBrands.Text = datProducts.Rows.Count

                If datProducts.Rows.Count > 0 Then
                    grdBrand.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdBrand.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("id").ToString
                        grdBrand.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("brand").ToString
                        grdBrand.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("created_at").ToString
                        row = row + 1
                    End While
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Public Sub DisplayAllModel()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayModel"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)
                lblTotalModels.Text = datProducts.Rows.Count

                If datProducts.Rows.Count > 0 Then
                    grdModel.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdModel.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("id").ToString
                        grdModel.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("model").ToString
                        grdModel.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("created_at").ToString
                        row = row + 1
                    End While
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Public Sub DisplayAllColorways()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayColorways"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)
                lblTotalColorways.Text = datProducts.Rows.Count

                If datProducts.Rows.Count > 0 Then
                    grdColorways.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdColorways.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("id").ToString
                        grdColorways.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("colorways").ToString
                        grdColorways.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("created_at").ToString
                        row = row + 1
                    End While
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        action = "Add"
        BrandForm.ShowDialog()
        DisplayAllBrand()

    End Sub

    Private Sub btnBrandUpdate_Click(sender As Object, e As EventArgs) Handles btnBrandUpdate.Click
        Try
            If grdBrand.SelectedRows.Count > 0 Then
                action = "Update"
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdBrand.CurrentRow.Cells(0).Value)

                    With BrandForm
                        .txtBrand.Text = grdBrand.CurrentRow.Cells(1).Value
                        .ShowDialog()
                    End With
                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayAllBrand()

    End Sub

    Private Sub btnBrandDelete_Click(sender As Object, e As EventArgs) Handles btnBrandDelete.Click
        Try
            If grdBrand.SelectedRows.Count > 0 Then
                Dim productId As Integer = CInt(grdBrand.CurrentRow.Cells(0).Value)

                Dim isLastRow As Boolean = (grdBrand.Rows.Count = 1)

                Dim result As DialogResult
                If isLastRow Then
                    result = MessageBox.Show("Are you sure you want to delete this product? This is the last remaining product, and the table will be cleared.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If result = DialogResult.Yes Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteBrandById"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", productId)
                        .ExecuteNonQuery()
                    End With

                    DisplayAllBrand()


                    If isLastRow Then
                        grdBrand.Rows.Clear()
                    End If

                End If
            Else
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAddModel_Click(sender As Object, e As EventArgs) Handles btnAddModel.Click
        action = "Add"
        ModelForm.ShowDialog()
        DisplayAllModel()

    End Sub

    Private Sub btnModelUpdate_Click(sender As Object, e As EventArgs) Handles btnModelUpdate.Click
        Try
            If grdModel.SelectedRows.Count > 0 Then
                action = "Update"
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdModel.CurrentRow.Cells(0).Value)

                    With ModelForm
                        .txtModel.Text = grdModel.CurrentRow.Cells(1).Value
                        .ShowDialog()
                    End With
                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayAllModel()

    End Sub

    Private Sub btnModelDelete_Click(sender As Object, e As EventArgs) Handles btnModelDelete.Click
        Try
            If grdModel.SelectedRows.Count > 0 Then
                Dim productId As Integer = CInt(grdModel.CurrentRow.Cells(0).Value)

                Dim isLastRow As Boolean = (grdModel.Rows.Count = 1)

                Dim result As DialogResult
                If isLastRow Then
                    result = MessageBox.Show("Are you sure you want to delete this product? This is the last remaining product, and the table will be cleared.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If result = DialogResult.Yes Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteModeById"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", productId)
                        .ExecuteNonQuery()
                    End With

                    DisplayAllModel()


                    If isLastRow Then
                        grdModel.Rows.Clear()
                    End If

                End If
            Else
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAddColorways_Click(sender As Object, e As EventArgs) Handles btnAddColorways.Click
        action = "Add"
        ColorwaysForm.ShowDialog()
        DisplayAllColorways()

    End Sub

    Private Sub btnColorwaysUpdate_Click(sender As Object, e As EventArgs) Handles btnColorwaysUpdate.Click
        Try
            If grdColorways.SelectedRows.Count > 0 Then
                action = "Update"
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdColorways.CurrentRow.Cells(0).Value)

                    With ColorwaysForm
                        .txtColorways.Text = grdColorways.CurrentRow.Cells(1).Value
                        .ShowDialog()
                    End With
                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayAllColorways()

    End Sub

    Private Sub btnColorwaysDelete_Click(sender As Object, e As EventArgs) Handles btnColorwaysDelete.Click
        Try
            If grdColorways.SelectedRows.Count > 0 Then
                Dim productId As Integer = CInt(grdColorways.CurrentRow.Cells(0).Value)

                Dim isLastRow As Boolean = (grdColorways.Rows.Count = 1)

                Dim result As DialogResult
                If isLastRow Then
                    result = MessageBox.Show("Are you sure you want to delete this product? This is the last remaining product, and the table will be cleared.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If result = DialogResult.Yes Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteColorwaysById"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", productId)
                        .ExecuteNonQuery()
                    End With

                    DisplayAllColorways()


                    If isLastRow Then
                        grdColorways.Rows.Clear()
                    End If

                End If
            Else
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class