Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class signup
    Dim sql, nama, jk, nohp, alamat, username, password As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        If RadioButton1.Checked = True Then
            jk = "L"
        ElseIf RadioButton2.Checked = True Then
            jk = "P"
        End If
        Dim Sqltambah As String = "INSERT INTO pegawai(nama, jk, nohp, alamat, username, password) values ('" & TextBox1.Text & "','" & jk & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()

        MsgBox("Sign Up Berhasil")
        clear()

    End Sub

    Private Sub signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()

    End Sub
End Class