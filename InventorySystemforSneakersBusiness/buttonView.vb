Imports MySql.Data.MySqlClient
Public Class buttonView
    Public Sub DisplayAllProducts()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllProducts"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)

                Dim totalPrice As Decimal = 0

                If datProducts.Rows.Count > 0 Then
                    grdProducts.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdProducts.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("prod_id").ToString
                        grdProducts.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("prod_brand").ToString
                        grdProducts.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("prod_model").ToString
                        grdProducts.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("prod_size").ToString
                        grdProducts.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("prod_colorways").ToString
                        grdProducts.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("prod_description").ToString
                        grdProducts.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("prod_qty").ToString
                        grdProducts.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("prod_price").ToString
                        grdProducts.Rows(row).Cells(8).Value = datProducts.Rows(row).Item("prod_date").ToString

                        Dim quantity As Integer
                        If Integer.TryParse(datProducts.Rows(row).Item("prod_qty").ToString, quantity) Then
                            Dim price As Decimal
                            If Decimal.TryParse(datProducts.Rows(row).Item("prod_price").ToString, price) Then
                                totalPrice += quantity * price
                            End If
                        End If
                        row = row + 1
                    End While

                    lblTotalPrice.Text = totalPrice.ToString("0.00")
                Else
                    MessageBox.Show("No Record(s) found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub DisplayProductByFilter(ByVal v_search As String, ByVal v_filter As String)
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procSearchProductbyFilterWithAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", v_filter)
                .Parameters.AddWithValue("@p_search", v_search)
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)
                If datProducts.Rows.Count > 0 Then
                    grdProducts.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdProducts.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("prod_id").ToString
                        grdProducts.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("prod_brand").ToString
                        grdProducts.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("prod_model").ToString
                        grdProducts.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("prod_size").ToString
                        grdProducts.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("prod_colorways").ToString
                        grdProducts.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("prod_description").ToString
                        grdProducts.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("prod_qty").ToString
                        grdProducts.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("prod_price").ToString
                        row = row + 1
                    End While

                Else
                    MessageBox.Show("No Record(s) found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub buttonView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayAllProducts()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        action = "Add"
        AddProducts.ShowDialog()
        DisplayAllProducts()
        buttonDashboard.DisplayOverallQuantity()
        buttonDashboard.DisplayOverallProductsRow()
        buttonDashboard.DisplayCriticalItems()
        buttonBrand.DisplayAllBrand()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If grdProducts.SelectedRows.Count > 0 Then
                action = "Update"
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdProducts.CurrentRow.Cells(0).Value)

                    With AddProducts
                        .cmbBrand.Text = grdProducts.CurrentRow.Cells(1).Value
                        .cmbModel.Text = grdProducts.CurrentRow.Cells(2).Value
                        .txtSize.Text = grdProducts.CurrentRow.Cells(3).Value
                        .cmbColorways.Text = grdProducts.CurrentRow.Cells(4).Value
                        .txtDescription.Text = grdProducts.CurrentRow.Cells(5).Value
                        .txtQuantity.Text = grdProducts.CurrentRow.Cells(6).Value
                        .txtPrice.Text = grdProducts.CurrentRow.Cells(7).Value
                        .ShowDialog()
                    End With
                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayAllProducts()
        buttonDashboard.DisplayOverallQuantity()
        buttonDashboard.DisplayOverallProductsRow()
        buttonDashboard.DisplayCriticalItems()
        buttonBrand.DisplayAllBrand()
        AddProducts.cmbBrandItems()
        AddProducts.cmbColorwaysItems()
        AddProducts.cmbModelItems()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If grdProducts.SelectedRows.Count > 0 Then
                Dim productId As Integer = CInt(grdProducts.CurrentRow.Cells(0).Value)

                Dim isLastRow As Boolean = (grdProducts.Rows.Count = 1)

                Dim result As DialogResult
                If isLastRow Then
                    result = MessageBox.Show("Are you sure you want to delete this product? This is the last remaining product, and the table will be cleared.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If result = DialogResult.Yes Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteProductById"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", productId)
                        .ExecuteNonQuery()
                    End With

                    DisplayAllProducts()
                    buttonDashboard.DisplayOverallQuantity()
                    buttonDashboard.DisplayOverallProductsRow()
                    buttonDashboard.DisplayCriticalItems()
                    buttonBrand.DisplayAllBrand()

                    If isLastRow Then
                        grdProducts.Rows.Clear()
                    End If

                End If
            Else
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DisplayProductByFilter(txtSearch.Text, cmbSearch.Text)
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        action = "Add"
        AddProducts.ShowDialog()
        DisplayAllProducts()
        buttonDashboard.DisplayOverallQuantity()
        buttonDashboard.DisplayOverallProductsRow()
        buttonDashboard.DisplayCriticalItems()
        buttonBrand.DisplayAllBrand()
    End Sub

End Class