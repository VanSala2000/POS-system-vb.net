Imports MySql.Data.MySqlClient
Module modVariables
    ' mao ni ang variable nag mag handle sa mga mysql
    ' information
    Public servername As String
    Public username As String
    Public password As String
    Public port As String
    Public dbname As String
    Public strConnection As String 'connectionstring variable
    'variable sa mysql connection
    Public conInventorySystem As New MySqlConnection
    'variable na mag handle sa sql command/statement
    Public command As New MySqlCommand
    Public StudentSQLAdapter As New MySqlDataAdapter 'mao ni mag fetch sa record gikan sa database
    Public datProducts As New DataTable 'dre ibutang ang gi fetch ni mysqlDataAdapter
    Public row As Integer
    Public id As Integer
    Public action As String
End Module
