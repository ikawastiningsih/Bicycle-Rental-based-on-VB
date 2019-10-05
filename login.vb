Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class login

    Dim koneksi As MySqlConnection
    Dim sql, username, password As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan Username dan Password")
        Else
            username = TextBox1.Text
            password = TextBox2.Text
            sql = "Select * from pegawai where username='" + username + "'and password='" + password + "'"
            cmd = New MySqlCommand(sql, koneksi)
            rd = cmd.ExecuteReader()
            rd.Read()
            If rd.HasRows Then
                MsgBox("Selamat Anda Berhasil Login")
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                home.tsnama.Text = rd("nama")
                home.ShowDialog()
                rd.Close()
            Else
                MsgBox("Silahkan masukkan Username dan Password dengan benar")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
                rd.Close()
            End If

        End If


    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strkoneksi As String
        strkoneksi = "server='localhost';user id='root';password='';database='sepeda'"
        koneksi = New MySqlConnection(strkoneksi)
        Try
            koneksi.Open()
        Catch ex As Exception


        End Try

    End Sub
End Class


