Imports MySql.Data.MySqlClient

Public Class CashierSearchProduct
    Private Sub CashierSearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllProducts()
    End Sub

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
                    grdSearchProduct.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdSearchProduct.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("prod_id").ToString
                        grdSearchProduct.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("prod_brand").ToString
                        grdSearchProduct.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("prod_model").ToString
                        grdSearchProduct.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("prod_size").ToString
                        grdSearchProduct.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("prod_colorways").ToString
                        grdSearchProduct.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("prod_description").ToString
                        grdSearchProduct.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("prod_qty").ToString
                        grdSearchProduct.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("prod_price").ToString
                        Dim quantity As Integer
                        If Integer.TryParse(datProducts.Rows(row).Item("prod_qty").ToString, quantity) Then
                            Dim price As Decimal
                            If Decimal.TryParse(datProducts.Rows(row).Item("prod_price").ToString, price) Then
                                totalPrice += quantity * price
                            End If
                        End If
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
                    grdSearchProduct.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdSearchProduct.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("prod_id").ToString
                        grdSearchProduct.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("prod_brand").ToString
                        grdSearchProduct.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("prod_model").ToString
                        grdSearchProduct.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("prod_size").ToString
                        grdSearchProduct.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("prod_colorways").ToString
                        grdSearchProduct.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("prod_description").ToString
                        grdSearchProduct.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("prod_qty").ToString
                        grdSearchProduct.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("prod_price").ToString
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

    Private Sub grdSearchProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSearchProduct.CellContentClick
        Dim result As DialogResult = MessageBox.Show("Are you sure you want add this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If e.ColumnIndex = grdSearchProduct.Columns("btnColumn").Index AndAlso e.RowIndex >= 0 Then
                Try
                    Dim productId As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column1").Value.ToString()
                    Dim prodBrand As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column2").Value.ToString()
                    Dim prodModel As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column3").Value.ToString()
                    Dim prodSize As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column4").Value.ToString()
                    Dim prodColorways As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column5").Value.ToString()
                    Dim prodDescription As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column6").Value.ToString()
                    Dim prodQuantity As String = "1"
                    Dim prodPrice As String = grdSearchProduct.Rows(e.RowIndex).Cells("Column8").Value.ToString()

                    If TypeOf CashierDashboard Is CashierDashboard Then
                        Dim CashierDashboardInstance As CashierDashboard = DirectCast(CashierDashboard, CashierDashboard)
                        CashierDashboardInstance.AddDataToGrid(productId, prodBrand, prodModel, prodSize, prodColorways, prodDescription, prodQuantity, prodPrice)
                    End If
                    CashierDashboard.ComputeSubtotalAndVATAndTotalAmount()
                    buttonView.DisplayAllProducts()
                    buttonDashboard.DisplayOverallQuantity()
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DisplayProductByFilter(txtSearch.Text, cmbSearch.Text)
    End Sub
End Class