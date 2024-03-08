Public Class AddDiscount
    Public Event DiscountEntered(ByVal discountAmount As Decimal)
    Private _mainForm As CashierDashboard ' Replace 'MainForm' with the actual class name of your main form

    ' Constructor to receive the reference to the main form
    Public Sub New(mainForm As CashierDashboard) ' Replace 'MainForm' with the actual class name of your main form
        InitializeComponent()
        _mainForm = mainForm
    End Sub

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            ApplyDiscount()
            Me.Close()
        End If
    End Sub

    Private Sub ApplyDiscount()
        ' Parse the entered text as a decimal
        Dim discountAmount As Decimal
        If Decimal.TryParse(txtDiscount.Text, discountAmount) Then
            ' Raise the DiscountEntered event with the discount amount
            RaiseEvent DiscountEntered(discountAmount)

            ' Clear the discount TextBox after applying the discount
            txtDiscount.Clear()
        Else
            MessageBox.Show("Invalid discount amount. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class