Imports MySql.Data.MySqlClient

Public Class CashierDailySales
    Private Sub CashierDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "yyyy/MM/dd"
        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "yyyy/MM/dd"

        AddHandler d1.ValueChanged, AddressOf DateValueChanged
        AddHandler d2.ValueChanged, AddressOf DateValueChanged

        ' Call DateTimeFilter initially with the default date values
        DateTimeFilter(d1.Text, d2.Text)
    End Sub

    Private Sub DateValueChanged(sender As Object, e As EventArgs)
        DateTimeFilter(d1.Text, d2.Text)
    End Sub

    Public Sub DateTimeFilter(ByVal start_date As String, ByVal end_date As String)
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllDailySales"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("start_date", start_date)
                .Parameters.AddWithValue("end_date", end_date)
                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)
            End With

            grdDailySales.DataSource = Nothing
            grdDailySales.DataSource = datProducts

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class