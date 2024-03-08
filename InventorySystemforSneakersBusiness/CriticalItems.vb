Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class CriticalItems
    Private Sub CriticalItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayQuantityItems()
    End Sub

    Public Sub DisplayQuantityItems()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procCriticalItems"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)

                Dim totalPrice As Decimal = 0

                If datProducts.Rows.Count > 0 Then
                    grdCriticalItems.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdCriticalItems.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("prod_id").ToString
                        grdCriticalItems.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("prod_brand").ToString
                        grdCriticalItems.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("prod_model").ToString
                        grdCriticalItems.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("prod_size").ToString
                        grdCriticalItems.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("prod_colorways").ToString
                        grdCriticalItems.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("prod_description").ToString
                        grdCriticalItems.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("prod_qty").ToString
                        grdCriticalItems.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("prod_price").ToString
                        grdCriticalItems.Rows(row).Cells(8).Value = datProducts.Rows(row).Item("prod_date").ToString

                        Dim quantity As Integer
                        If Integer.TryParse(datProducts.Rows(row).Item("prod_qty").ToString, quantity) Then
                            Dim price As Decimal
                            If Decimal.TryParse(datProducts.Rows(row).Item("prod_price").ToString, price) Then
                                totalPrice += quantity * price
                            End If
                        End If

                        row = row + 1
                    End While

                    lblTotalProductPrice.Text = totalPrice.ToString("0.00")
                Else
                    MessageBox.Show("No Record(s) found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If grdCriticalItems.SelectedRows.Count > 0 Then

                Dim isLastRow As Boolean = (grdCriticalItems.Rows.Count = 1)

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdCriticalItems.CurrentRow.Cells(0).Value)

                    With UpdateProducts
                        .cmbBrand.Text = grdCriticalItems.CurrentRow.Cells(1).Value
                        .cmbModel.Text = grdCriticalItems.CurrentRow.Cells(2).Value
                        .txtSize.Text = grdCriticalItems.CurrentRow.Cells(3).Value
                        .cmbColorways.Text = grdCriticalItems.CurrentRow.Cells(4).Value
                        .txtDescription.Text = grdCriticalItems.CurrentRow.Cells(5).Value
                        .txtQuantity.Text = grdCriticalItems.CurrentRow.Cells(6).Value
                        .txtPrice.Text = grdCriticalItems.CurrentRow.Cells(7).Value
                        .ShowDialog()
                    End With

                    If isLastRow Then
                        grdCriticalItems.Rows.Clear()
                        lblTotalProductPrice.Text = "0.00"
                    End If

                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayQuantityItems()
        buttonView.DisplayAllProducts()
        buttonDashboard.DisplayOverallQuantity()
        buttonDashboard.DisplayOverallProductsRow()
        buttonDashboard.DisplayCriticalItems()
        buttonBrand.DisplayAllBrand()
        AddProducts.cmbBrandItems()
        AddProducts.cmbColorwaysItems()
        AddProducts.cmbModelItems()
    End Sub

End Class