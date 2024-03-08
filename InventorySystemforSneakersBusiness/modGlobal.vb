Imports MySql.Data.MySqlClient

Module modGlobal
    Public Function fncConnectToDatabase() As Boolean
        Try
            'database credentials
            servername = "localhost"
            dbname = "db_inventory"
            username = "root"
            password = "umtc"
            port = "3307"
            If conInventorySystem.State = ConnectionState.Closed Then
                conInventorySystem = New MySqlConnection

                strConnection = "SERVER=" & servername & ";" _
                              & "DATABASE=" & dbname & ";" _
                              & "USERNAME=" & username & ";" _
                              & "PASSWORD=" & password & ";" _
                              & "PORT=" & port & ";" _
                              & "DEFAULT COMMAND TIMEOUT =" & 20 * 60
                conInventorySystem.ConnectionString = strConnection
                conInventorySystem.Open()
                command.Connection = conInventorySystem
                Return True
            Else
                conInventorySystem.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return False
    End Function

    Public Function ValidateUser(username As String, password As String) As Boolean
        If fncConnectToDatabase() Then
            Try
                ' Call the stored procedure for user validation
                Dim cmd As MySqlCommand = New MySqlCommand("procUserValidation", conInventorySystem)
                cmd.CommandType = CommandType.StoredProcedure

                ' Add parameters
                cmd.Parameters.AddWithValue("@p_username", username)
                cmd.Parameters.AddWithValue("@p_password", password)
                cmd.Parameters.Add("@p_valid", MySqlDbType.Int32).Direction = ParameterDirection.Output

                cmd.ExecuteNonQuery()

                ' Get the result from the stored procedure
                Dim isValid As Integer = Convert.ToInt32(cmd.Parameters("@p_valid").Value)

                ' Return True if the user is valid, False otherwise
                Return isValid > 0
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            Finally
                ' Close the database connection
                conInventorySystem.Close()
            End Try
        End If

        Return False
    End Function

    Public Function ValidateAdminAndUpdatePassword(username As String, password As String) As Boolean
        If fncConnectToDatabase() Then
            Try
                ' Call the stored procedure for user validation and password update
                Dim cmd As MySqlCommand = New MySqlCommand("procAdminValidation", conInventorySystem)
                cmd.CommandType = CommandType.StoredProcedure

                ' Add parameters
                cmd.Parameters.AddWithValue("@p_username", username)
                cmd.Parameters.AddWithValue("@p_password", password)
                cmd.Parameters.Add("@p_valid", MySqlDbType.Int32).Direction = ParameterDirection.Output

                cmd.ExecuteNonQuery()

                ' Get the result from the stored procedure
                Dim isValid As Integer = Convert.ToInt32(cmd.Parameters("@p_valid").Value)

                ' Return True if the user is valid, False otherwise
                Return isValid > 0
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            Finally
                ' Close the database connection
                conInventorySystem.Close()
            End Try
        End If

        Return False
    End Function

    Public Sub checkDatabaseConnection()
        If fncConnectToDatabase() = True Then

        Else
            conInventorySystem.Open()
        End If
    End Sub

End Module
