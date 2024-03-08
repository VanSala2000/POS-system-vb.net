Imports MySql.Data.MySqlClient

Public Class buttonDashboard
    Private Sub buttonDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayOverallQuantity()
        DisplayOverallProductsRow()
        DisplayCriticalItems()
        DisplayDailySales()
        chartSales()
    End Sub
    Public Sub DisplayOverallQuantity()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayTotalQuantity"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)

                Dim totalQuantity As Integer = 0
                For Each row As DataRow In datProducts.Rows
                    totalQuantity += Convert.ToInt32(row("prod_qty"))
                Next
                lblStockOnHand.Text = totalQuantity.ToString("")
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub DisplayOverallProductsRow()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllProducts"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)
                lblProductLine.Text = datProducts.Rows.Count
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Public Sub DisplayCriticalItems()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayCriticalItems"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)

                Dim countBelow5 As Integer = 0

                For Each row As DataRow In datProducts.Rows
                    Dim quantity As Integer = Convert.ToInt32(row("prod_qty"))

                    If quantity < 6 Then
                        countBelow5 += 1
                    End If
                Next

                lblCriticalItems.Text = countBelow5.ToString("")
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private currentDay As Integer = -1 ' Variable to store the current day

    Public Sub DisplayDailySales()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDailySales"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)

                Dim totalSales As Decimal = 0

                For Each row As DataRow In datProducts.Rows
                    Dim dailySales As Decimal = Convert.ToDecimal(row("total_price"))
                    totalSales += dailySales
                Next

                lblDailySales.Text = totalSales.ToString("C") ' Assuming you want to display it as currency
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub btnCriticalItems_Click(sender As Object, e As EventArgs) Handles btnCriticalItems.Click
        CriticalItems.ShowDialog()
    End Sub

    Public Sub chartSales()
        Try
            StudentSQLAdapter = New MySqlDataAdapter()
            datProducts = New DataTable()

            With command
                .Parameters.Clear()
                .CommandText = "procYearlySales"
                .CommandType = CommandType.StoredProcedure

                StudentSQLAdapter.SelectCommand = command
                StudentSQLAdapter.Fill(datProducts)

                ' Clear existing series in the chart
                yearlyChart.Series.Clear()

                ' Add a new series to the chart
                Dim series As New DataVisualization.Charting.Series("YearlySales")

                ' Set X and Y values for the chart
                series.XValueMember = "sales_year"
                series.YValueMembers = "total_yearly_sales"

                ' Bind the data to the chart
                yearlyChart.DataSource = datProducts

                ' Set the chart type (e.g., Column, Bar, Line)
                series.ChartType = DataVisualization.Charting.SeriesChartType.Column

                ' Add the series to the chart
                yearlyChart.Series.Add(series)

                ' Display text on the bars (Data Point Labels)
                series.IsValueShownAsLabel = True
                series.LabelFormat = "{0:C}" ' Adjust the label format as needed

                ' Refresh the chart
                yearlyChart.DataBind()
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class