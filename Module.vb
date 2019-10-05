Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Module Module1

    Dim myconn As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader

    Public Function koneksi() As MySqlConnection
        myconn = New MySqlConnection("server='localhost';user id='root';password='';database='sepeda'")
        myconn.Open()
        Return myconn
    End Function

End Module


