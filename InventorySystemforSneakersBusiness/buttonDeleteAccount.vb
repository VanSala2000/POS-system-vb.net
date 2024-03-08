Imports MySql.Data.MySqlClient

Public Class buttonDeleteAccount
    Private Sub buttonDeleteAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DisplayAllAccounts()
    End Sub
    Public Sub DisplayAllAccounts()
        Try
            StudentSQLAdapter = New MySqlDataAdapter
            datProducts = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayCashierAccounts"
                .CommandType = CommandType.StoredProcedure
                StudentSQLAdapter.SelectCommand = command
                datProducts.Clear()
                StudentSQLAdapter.Fill(datProducts)
                lblTotalAccounts.Text = datProducts.Rows.Count

                If datProducts.Rows.Count > 0 Then
                    grdCashierAccounts.RowCount = datProducts.Rows.Count
                    row = 0
                    While Not datProducts.Rows.Count - 1 < row
                        grdCashierAccounts.Rows(row).Cells(0).Value = datProducts.Rows(row).Item("id").ToString
                        grdCashierAccounts.Rows(row).Cells(1).Value = datProducts.Rows(row).Item("fname").ToString
                        grdCashierAccounts.Rows(row).Cells(2).Value = datProducts.Rows(row).Item("lname").ToString
                        grdCashierAccounts.Rows(row).Cells(3).Value = datProducts.Rows(row).Item("gender").ToString
                        grdCashierAccounts.Rows(row).Cells(4).Value = datProducts.Rows(row).Item("address").ToString
                        grdCashierAccounts.Rows(row).Cells(5).Value = datProducts.Rows(row).Item("contact_no").ToString
                        grdCashierAccounts.Rows(row).Cells(6).Value = datProducts.Rows(row).Item("username").ToString
                        grdCashierAccounts.Rows(row).Cells(7).Value = datProducts.Rows(row).Item("password").ToString
                        grdCashierAccounts.Rows(row).Cells(8).Value = datProducts.Rows(row).Item("created_at").ToString
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If grdCashierAccounts.SelectedRows.Count > 0 Then
                Dim accountId As Integer = CInt(grdCashierAccounts.CurrentRow.Cells(0).Value)

                Dim isLastRow As Boolean = (grdCashierAccounts.Rows.Count = 1)

                Dim result As DialogResult
                If isLastRow Then
                    result = MessageBox.Show("Are you sure you want to delete this account? This is the last remaining account, and the table will be cleared.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Else
                    result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If

                If result = DialogResult.Yes Then
                    With command
                        .Parameters.Clear()
                        .CommandText = "procDeleteAccount"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_id", accountId)
                        .ExecuteNonQuery()
                    End With

                    DisplayAllAccounts()

                    If isLastRow Then
                        grdCashierAccounts.Rows.Clear()
                    End If

                End If
            Else
                MessageBox.Show("Please select a account to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If grdCashierAccounts.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    id = CInt(grdCashierAccounts.CurrentRow.Cells(0).Value)

                    With UpdateAccount
                        .txtFirstname.Text = grdCashierAccounts.CurrentRow.Cells(1).Value
                        .txtLastname.Text = grdCashierAccounts.CurrentRow.Cells(2).Value
                        .cmbGender.Text = grdCashierAccounts.CurrentRow.Cells(3).Value
                        .txtAddress.Text = grdCashierAccounts.CurrentRow.Cells(4).Value
                        .txtContactNo.Text = grdCashierAccounts.CurrentRow.Cells(5).Value
                        .txtUsername.Text = grdCashierAccounts.CurrentRow.Cells(6).Value
                        .txtPassword.Text = grdCashierAccounts.CurrentRow.Cells(7).Value
                        .ShowDialog()
                    End With
                End If
            Else
                MessageBox.Show("Please select data to update", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid approach: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DisplayAllAccounts()
    End Sub
End Class