Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Public Class pengembalian
    Dim sql, id, idpemesanan, tabadi, labadi, denda, ladi, total, petugaspengembalian As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim noken As String
    Sub jam()
        Dim jam1 As Date = Convert.ToDateTime(Label5.Text)
        Dim jam2 As Date = Convert.ToDateTime(Label13.Text)
        Dim hitung As TimeSpan = jam1.Subtract(jam2)
        TextBox1.Text = hitung.TotalHours
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO pengsepeda(id, idpemesanan, tabadi, labadi, denda, ladi, total, petugaspengembalian) values ('""', '" & ComboBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & home.tsnama.Text & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()

        Dim sqledit As String = "update stocksepeda set status='" & 0 & "' where noken ='" & noken & "'"
        cmd = New MySqlCommand(sqledit, koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay
    End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub
    Sub tampil()
        ComboBox1.Items.Clear()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM psepeda", koneksi)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            ComboBox1.Items.Add(rdr("idpemesanan"))
        End While
    End Sub
    Private Sub pengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM psepeda where idpemesanan='" & ComboBox1.Text & "'", koneksi)
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            Label13.Text = rdr.Item("jam")
            TextBox3.Text = rdr.Item("lamap")
            noken = rdr.Item("noken")
        End If
        jam()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            TextBox1.Focus()
        Else
            If TextBox1.Text >= TextBox3.Text Then
                a = (TextBox1.Text - TextBox3.Text) * 10000
                TextBox2.Text = a
            Else
                TextBox2.Text = "0"
                b = (TextBox3.Text * 10000) + TextBox2.Text
                TextBox4.Text = b
            End If
        End If
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
        Me.Close()
        home.tampilsep()
    End Sub
End Class