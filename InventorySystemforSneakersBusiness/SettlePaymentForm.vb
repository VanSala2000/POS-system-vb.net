Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class SettlePaymentForm
    Private _totalAmount As Decimal = 0
    Private printDocument As New PrintDocument
    Private productDetails As ProductPayment
    Private cashierDashboard As CashierDashboard
    Public Property TotalAmount As Decimal
        Get
            Return _totalAmount
        End Get
        Set(value As Decimal)
            _totalAmount = value

            txtTotalAmountProduct.Text = $"{_totalAmount:C}"
        End Set
    End Property

    Public Sub DisplayProductPaymentData(productPaymentData As List(Of ProductPayment))
        ' Assuming dgvOther is the name of your second DataGridView in SettlePaymentForm

        ' Clear existing data
        grdSettlePayment.Rows.Clear()

        ' Add the product payment data to the other DataGridView
        For Each details As ProductPayment In productPaymentData
            grdSettlePayment.Rows.Add(
                details.ProdBrand,
                details.ProdModel,
                details.ProdSize,
                details.ProdColorways,
                details.ProdQuantity,
                details.ProdPrice
            )
        Next

        ' Set class-level productDetails to the first item in the list
        If productPaymentData.Count > 0 Then
            productDetails = productPaymentData(0)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Check if txtEnterAmount is not empty and is a valid decimal
            If Not String.IsNullOrEmpty(txtEnterAmount.Text) AndAlso Decimal.TryParse(txtEnterAmount.Text, Nothing) Then
                If productDetails IsNot Nothing Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procInsertProductPayment"
                        .CommandType = CommandType.StoredProcedure
                        ' Pass the parameters to the stored procedure
                        .Parameters.AddWithValue("p_prod_brand", productDetails.ProdBrand)
                        .Parameters.AddWithValue("p_prod_model", productDetails.ProdModel)
                        .Parameters.AddWithValue("p_prod_size", productDetails.ProdSize)
                        .Parameters.AddWithValue("p_prod_colorways", productDetails.ProdColorways)
                        .Parameters.AddWithValue("p_prod_quantity", productDetails.ProdQuantity)
                        .Parameters.AddWithValue("p_prod_price", productDetails.ProdPrice)
                        .Parameters.AddWithValue("p_total_amount", TotalAmount)
                        .Parameters.AddWithValue("p_prod_date", DateTime.Now)
                        .ExecuteNonQuery()
                    End With

                    MessageBox.Show("Product Purchase!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear the form and go back to CashierDashboard
                    ClearFormAndNavigateToCashierDashboard()
                    buttonDashboard.chartSales()
                    buttonDashboard.DisplayDailySales()

                Else
                    MessageBox.Show("Product details are not available.")
                End If
            Else
                MessageBox.Show("Please enter a receive amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
    End Sub


    ' Function to clear the form and navigate back to CashierDashboard
    Private Sub ClearFormAndNavigateToCashierDashboard()
        ' Clear any necessary controls or data in the form
        grdSettlePayment.Rows.Clear()
        Me.Close()

        ' Navigate back to CashierDashboard
        If cashierDashboard IsNot Nothing Then '
            cashierDashboard.Show() ' or .BringToFront(), depending on your requirements
        End If
    End Sub



    Private Sub txtEnterAmount_TextChanged(sender As Object, e As EventArgs) Handles txtEnterAmount.TextChanged, txtTotalAmountProduct.TextChanged
        Try
            ' Validate if the entered amount is a valid decimal
            If Decimal.TryParse(txtEnterAmount.Text, Nothing) Then
                Dim receivedAmount As Decimal = Decimal.Parse(txtEnterAmount.Text)
                Dim changeAmount As Decimal = receivedAmount - TotalAmount

                ' Update the change textbox with the calculated change amount
                txtChangeAmount.Text = $"{changeAmount:C}"
            Else
                ' Clear the change textbox if the entered amount is not valid
                txtChangeAmount.Text = ""
            End If
        Catch ex As Exception
            ' Clear the change textbox if an exception occurs
            txtChangeAmount.Text = ""
            ' Optionally, you can log the exception or display an error message
        End Try
    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim totalPriceAmount As Decimal
    Dim receivedAmount As Decimal
    Dim change As Decimal

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = grdSettlePayment.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("A4", 827, 1169) ' 827 pixels x 1169 pixels
        PD.DefaultPageSettings = pagesetup
    End Sub

    Dim t_qty As Decimal ' Declare t_qty as Decimal

    Sub sumprice()
        Dim countprice As Decimal = 0
        For rowitem As Long = 0 To grdSettlePayment.RowCount - 1
            countprice = countprice + Val(grdSettlePayment.Rows(rowitem).Cells("ColumnQTY").Value) * Val(grdSettlePayment.Rows(rowitem).Cells("ColumnPrice").Value)
        Next
        TotalAmount = countprice

        Dim countqty As Decimal = 0
        For rowitem As Long = 0 To grdSettlePayment.RowCount - 1
            countqty = countqty + Val(grdSettlePayment.Rows(rowitem).Cells("ColumnQTY").Value)
        Next
        t_qty = countqty
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"

        e.Graphics.DrawString("New York Street 15 Avenue", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Tel +1763545473", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("DRW8555RE", f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("Steve Jobs", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("08/17/2021 | 15.34", f8, Brushes.Black, 0, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 110)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 180, 110, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, 110, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer 'DGV Position

        grdSettlePayment.AllowUserToAddRows = False

        For row As Integer = 0 To grdSettlePayment.RowCount - 1
            height += 15
            e.Graphics.DrawString(grdSettlePayment.Rows(row).Cells("ColumnQTY").Value.ToString, f8, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(grdSettlePayment.Rows(row).Cells("ColumnBrand").Value.ToString, f8, Brushes.Black, 25, 115 + height)
            e.Graphics.DrawString(grdSettlePayment.Rows(row).Cells("ColumnPrice").Value.ToString, f8, Brushes.Black, 180, 115 + height, right)

            'totalprice
            Dim totalprice As Decimal
            totalprice = Val(grdSettlePayment.Rows(row).Cells("ColumnQTY").Value) * Val(grdSettlePayment.Rows(row).Cells("ColumnPrice").Value)
            e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 115 + height, right)
            '
        Next

        Dim height2 As Integer
        height2 = 145 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & Format(totalPriceAmount, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("Received: " & Format(receivedAmount, "##,##0"), f10b, Brushes.Black, 0, 20 + height2)
        e.Graphics.DrawString("Change: " & Format(change, "##,##0"), f10b, Brushes.Black, 0, 30 + height2)
        e.Graphics.DrawString("t_qty: " & Format(t_qty, "##,##0"), f10b, Brushes.Black, 0, 40 + height2)

    End Sub




End Class
