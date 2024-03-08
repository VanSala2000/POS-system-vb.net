
Imports MySql.Data.MySqlClient
Public Class CashierDashboard

    Private discountForm As AddDiscount
    Private Sub CashierDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private transactionCode As String = String.Empty
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Logging out...")
            Me.Close()

            Dim frmShow As New Form1
            Form1.Show()
        End If
    End Sub

    Private Sub GenerateTransactionCode()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "procRandomNumberWithDate"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)

                If datProducts.Rows.Count > 0 Then
                    Dim currentDate As Date = Convert.ToDateTime(datProducts.Rows(0)("generated_current_date"))
                    transactionCode = datProducts.Rows(0)("transaction_code").ToString()

                    txtDate.Text = currentDate.ToString("yyyy-MM-dd")
                    txttransactionId.Text = transactionCode
                End If
            End With

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNewTransaction_KeyUp(sender As Object, e As KeyEventArgs) Handles btnNewTransaction.KeyUp
        Try
            If e.KeyCode = Keys.N Then
                ResetDataGridView()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SearchID(ByVal v_search As String)
        Try
            If String.IsNullOrEmpty(transactionCode) Then
                MessageBox.Show("Generate a transaction code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "procSelectId"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", v_search)
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)

                If datProducts.Rows.Count > 0 Then
                    Dim productId As String = datProducts.Rows(0).Item("prod_id").ToString
                    Dim rowIndex As Integer = FindRowIndexByProductId(productId)

                    If rowIndex = -1 Then
                        ' Product not found in the grid, add a new row
                        Dim prodBrand As String = datProducts.Rows(0).Item("prod_brand").ToString
                        Dim prodModel As String = datProducts.Rows(0).Item("prod_model").ToString
                        Dim prodSize As String = datProducts.Rows(0).Item("prod_size").ToString
                        Dim prodColorways As String = datProducts.Rows(0).Item("prod_colorways").ToString
                        Dim prodDescription As String = datProducts.Rows(0).Item("prod_description").ToString
                        Dim prodPrice As Decimal = Convert.ToDecimal(datProducts.Rows(0).Item("prod_price"))

                        grdProductPayment.Rows.Add(
                        productId,
                        prodBrand,
                        prodModel,
                        prodSize,
                        prodColorways,
                        prodDescription,
                        1, ' Initial quantity set to 1
                        prodPrice
                    )
                    Else
                        ' Product found in the grid, increment the quantity by 1
                        Dim currentQuantity As Integer
                        If Integer.TryParse(grdProductPayment.Rows(rowIndex).Cells(6).Value.ToString(), currentQuantity) Then
                            grdProductPayment.Rows(rowIndex).Cells(6).Value = currentQuantity + 1
                        End If

                        ' Update the price based on the new quantity
                        Dim newQuantity As Integer = currentQuantity + 1
                        Dim updatedPrice As Decimal = newQuantity * Convert.ToDecimal(datProducts.Rows(0).Item("prod_price"))
                        grdProductPayment.Rows(rowIndex).Cells(7).Value = updatedPrice
                    End If

                    UpdateProductByEnter(v_search)
                    buttonView.DisplayAllProducts()
                    buttonDashboard.DisplayOverallQuantity()
                    CashierSearchProduct.DisplayAllProducts()
                    ComputeSubtotalAndVATAndTotalAmount()
                Else
                    MessageBox.Show("Unknown Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                txtSearchID.Clear()
            End With
        Catch ex As Exception
            MessageBox.Show("Error processing Product ID. Please enter a valid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function ComputeSubtotalAndVATAndTotalAmount()
        Dim totalPrice As Decimal = 0
        Dim subtotal As Decimal = 0
        Dim vatRate As Decimal = 0.02 ' Assuming a VAT rate of 12%, adjust as needed
        Dim vat As Decimal
        Dim totalAmount As Decimal

        ' Iterate through the rows and calculate the subtotal
        For Each row As DataGridViewRow In grdProductPayment.Rows
            Dim quantity As Integer = CInt(row.Cells(6).Value)
            Dim price As Decimal = CDec(row.Cells(7).Value)
            totalPrice += quantity * price
            txtProductPrice.Text = $" {totalPrice:C}"
            subtotal += quantity * price
        Next

        ' Calculate VAT based on the subtotal
        vat = subtotal * vatRate

        ' Calculate the total amount
        totalAmount = subtotal + vat

        ' Update labels with computed values
        txtSubtotal.Text = $" {subtotal:C}"
        txtVat.Text = $" {vat:C}"
        txtTotalAmount.Text = $" {totalAmount:C}"

        Return totalAmount

    End Function

    Public Sub AddDataToGrid(productId As String, prodBrand As String, prodModel As String, prodSize As String, prodColorways As String, prodDescription As String, prodQuantity As String, prodPrice As String)
        If String.IsNullOrEmpty(transactionCode) Then
            MessageBox.Show("Generate a transaction code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rowIndex As Integer = FindRowIndexByProductId(productId)

        If rowIndex = -1 Then
            ' Product not found in the grid, add a new row
            grdProductPayment.Rows.Add(productId, prodBrand, prodModel, prodSize, prodColorways, prodDescription, prodQuantity, prodPrice)
        Else
            ' Product found in the grid, update the quantity and total price
            Dim currentQuantity As Integer = CInt(grdProductPayment.Rows(rowIndex).Cells(6).Value)
            Dim newQuantity As Integer = CInt(prodQuantity)
            grdProductPayment.Rows(rowIndex).Cells(6).Value = currentQuantity + newQuantity

            ' Update the total price based on the new quantity
            Dim unitPrice As Decimal = CDec(prodPrice)
            Dim totalPrice As Decimal = (currentQuantity + newQuantity) * unitPrice
            grdProductPayment.Rows(rowIndex).Cells(7).Value = totalPrice
        End If

        UpdateProductQuantity(productId, CInt(prodQuantity))
        CashierSearchProduct.DisplayAllProducts()
        ComputeSubtotalAndVATAndTotalAmount()
    End Sub

    Private Sub UpdateProductQuantity(productId As String, quantity As Integer)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateQuantityById"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("p_id", productId)
                .Parameters.AddWithValue("p_qty", quantity)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show($"Error updating product quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateProductByEnter(productId As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateQuantityByEnter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("p_id", productId)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show($"Error updating product quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function FindRowIndexByProductId(productId As String) As Integer
        For Each row As DataGridViewRow In grdProductPayment.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = productId Then
                Return row.Index
            End If
        Next
        Return -1 ' Product not found in the grid
    End Function

    Private Sub txtSearchID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchID.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchID(txtSearchID.Text)
        End If
    End Sub

    Private Sub btnNewTransaction_Click(sender As Object, e As EventArgs) Handles btnNewTransaction.Click
        ResetDataGridView()
    End Sub

    Public Sub ResetDataGridView()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to create new transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                grdProductPayment.Rows.Clear()
                txtProductPrice.Text = "0"
                lblDiscount.Text = "0"
                txtTotalAmount.Text = "0"
                txtSubtotal.Text = "0"
                txtVat.Text = "0"
                GenerateTransactionCode()
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        CashierSearchProduct.ShowDialog()

    End Sub

    Private Sub grdProductPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductPayment.CellContentClick
        If e.ColumnIndex = grdProductPayment.Columns("btnDelete").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to void this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then ' Check if the user clicked "Void"
                AdminVoidValidation.ShowDialog()

                If grdProductPayment.SelectedRows.Count > 0 Then
                    ' Get the selected row
                    Dim selectedRow As DataGridViewRow = grdProductPayment.SelectedRows(0)

                    Dim productId As Integer = CInt(selectedRow.Cells("ColumnId").Value.ToString())
                    Dim prodBrand As String = selectedRow.Cells("ColumnBrand").Value.ToString()
                    Dim prodModel As String = selectedRow.Cells("ColumnModel").Value.ToString()
                    Dim prodSize As Integer = CInt(selectedRow.Cells("ColumnSize").Value.ToString())
                    Dim prodColorways As String = selectedRow.Cells("ColumnColorways").Value.ToString()
                    Dim prodDescription As String = selectedRow.Cells("ColumnDescription").Value.ToString()
                    Dim prodQuantity As Integer = CInt(selectedRow.Cells("ColumnQty").Value.ToString())
                    Dim prodPrice As Integer = CInt(selectedRow.Cells("ColumnPrice").Value.ToString())

                    checkDatabaseConnection()

                    ' Call the stored procedure to save voided product data to tblCancelProducts
                    SaveToCancelProducts(productId, prodBrand, prodModel, prodSize, prodColorways, prodDescription, prodQuantity, prodPrice)

                    ' Decrement the quantity
                    Dim currentQuantity As Integer = CInt(selectedRow.Cells("ColumnQty").Value)
                    If currentQuantity > 1 Then
                        ' If quantity is more than 1, decrement by 1
                        selectedRow.Cells("ColumnQty").Value = currentQuantity - 1
                    Else
                        ' If quantity is 1, remove the entire row
                        grdProductPayment.Rows.Remove(selectedRow)
                        txtProductPrice.Text = "0"
                    End If

                    ComputeSubtotalAndVATAndTotalAmount()
                Else
                    MessageBox.Show("Select a product to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub SaveToCancelProducts(productId As Integer, prodBrand As String, prodModel As String, prodSize As Integer, prodColorways As String, prodDescription As String, prodQuantity As Integer, prodPrice As Integer)
        Try
            With command
                .CommandText = "procCancelProducts"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Clear()
                .Parameters.AddWithValue("@p_prod_id", productId)
                .Parameters.AddWithValue("@p_prod_brand", prodBrand)
                .Parameters.AddWithValue("@p_prod_model", prodModel)
                .Parameters.AddWithValue("@p_prod_size", prodSize)
                .Parameters.AddWithValue("@p_prod_colorways", prodColorways)
                .Parameters.AddWithValue("@p_prod_description", prodDescription)
                .Parameters.AddWithValue("@p_prod_qty", prodQuantity)
                .Parameters.AddWithValue("@p_prod_price", prodPrice)
                .Parameters.AddWithValue("@p_prod_date", DateTime.Now)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelProducts_Click(sender As Object, e As EventArgs) Handles btnCancelProducts.Click
        CancelProducts.ShowDialog()
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs) Handles btnAddDiscount.Click
        Dim discountForm As New AddDiscount(Me)
        AddHandler discountForm.DiscountEntered, AddressOf HandleDiscountEntered
        discountForm.ShowDialog()
    End Sub

    Private Sub HandleDiscountEntered(ByVal discountAmount As Decimal)

        If discountAmount Mod 1 = 0 Then
            lblDiscount.Text = $"{discountAmount:0}%"
        Else
            lblDiscount.Text = $"{discountAmount:P}"
        End If

        Dim totalAmount As Decimal = ComputeSubtotalAndVATAndTotalAmount()


        For Each row As DataGridViewRow In grdProductPayment.Rows
            Dim quantity As Integer = CInt(row.Cells(6).Value)
            Dim unitPrice As Decimal = CDec(row.Cells(7).Value)

            ' Apply the discount to the unit price
            Dim discountedUnitPrice As Decimal = unitPrice * discountAmount

            ' Update the cell value with the discounted unit price
            UpdateUIWithDiscountedPrice(totalAmount - discountedUnitPrice)

        Next
    End Sub
    Private Sub UpdateUIWithDiscountedPrice(discountedPrice As Decimal)

        txtTotalAmount.Text = $" {discountedPrice:C}"

    End Sub

    Public Function GetProductPaymentData() As List(Of ProductPayment)
        Dim productPaymentData As New List(Of ProductPayment)

        For Each row As DataGridViewRow In grdProductPayment.Rows
            If Not row.IsNewRow Then
                Dim prodBrand As String = row.Cells("ColumnBrand").Value.ToString()
                Dim prodModel As String = row.Cells("ColumnModel").Value.ToString()
                Dim prodSize As String = row.Cells("ColumnSize").Value.ToString()
                Dim prodColorways As String = row.Cells("ColumnColorways").Value.ToString()
                Dim prodQuantity As Integer = CInt(row.Cells("ColumnQty").Value)
                Dim prodPrice As Decimal = CDec(row.Cells("ColumnPrice").Value)

                Dim productDetails As New ProductPayment(prodBrand, prodModel, prodSize, prodColorways, prodQuantity, prodPrice)
                productPaymentData.Add(productDetails)
            End If
        Next

        Return productPaymentData
    End Function

    Private Sub btnSettlePayment_Click(sender As Object, e As EventArgs) Handles btnSettlePayment.Click
        Dim settlePaymentForm As New SettlePaymentForm()

        ' Pass the total amount to SettlePaymentForm
        settlePaymentForm.TotalAmount = ComputeSubtotalAndVATAndTotalAmount()

        ' Get the product payment data from CashierDashboard
        Dim productPaymentData As List(Of ProductPayment) = GetProductPaymentData()

        ' Display product payment data in SettlePaymentForm
        settlePaymentForm.DisplayProductPaymentData(productPaymentData)

        ' Show the SettlePaymentForm
        settlePaymentForm.ShowDialog()
    End Sub

    Private Sub btnDailySales_Click(sender As Object, e As EventArgs) Handles btnDailySales.Click
        CashierDailySales.ShowDialog()
    End Sub



    Public ReadOnly Property TotalAmount As Decimal
        Get
            Return ComputeSubtotalAndVATAndTotalAmount()
        End Get
    End Property

End Class

Public Class ProductPayment
    Public Property ProdBrand As String
    Public Property ProdModel As String
    Public Property ProdSize As String
    Public Property ProdColorways As String
    Public Property ProdQuantity As Integer
    Public Property ProdPrice As Decimal

    Public Sub New(prodBrand As String, prodModel As String, prodSize As String, prodColorways As String, prodQuantity As Integer, prodPrice As Decimal)
        Me.ProdBrand = prodBrand
        Me.ProdModel = prodModel
        Me.ProdSize = prodSize
        Me.ProdColorways = prodColorways
        Me.ProdQuantity = prodQuantity
        Me.ProdPrice = prodPrice
    End Sub
End Class