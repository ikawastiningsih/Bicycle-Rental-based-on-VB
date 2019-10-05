Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class pengembalianm
    Dim sql, Sqltambah, id, idpemesanan, tape, tabadi, labadi, denda, ladi, total, noken, petugaspengembalian As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Sub clear()
        ComboBox1.Items.Clear()
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO pengmotor(id, idpemesanan, tape, tabadi, labadi, denda, total, ladi, petugaspengembalian) values ('""', '" & ComboBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "','" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox4.Text & "', '" & TextBox3.Text & "', '" & home.tsnama.Text & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()

        Dim sqledit As String = "update stockmotor set status='" & 0 & "' where noken ='" & noken & "'"
        cmd = New MySqlCommand(sqledit, koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil")

    End Sub

    Sub tampil()
        ComboBox1.Items.Clear()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM pmotor", koneksi)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            ComboBox1.Items.Add(rdr("idpemesanan"))
        End While
    End Sub

    Sub interval()
        Dim selisih As String
        selisih = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)
        TextBox1.Text = selisih

    End Sub

    Private Sub pengembalianm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM pmotor where idpemesanan='" & ComboBox1.Text & "'", koneksi)
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            DateTimePicker1.Value = rdr.Item("tgl")
            TextBox3.Text = rdr.Item("lamap")
            noken = rdr.Item("noken")
        End If
        interval()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim a, b As Integer
        If TextBox1.Text = "" Then
            TextBox1.Focus()
        Else
            If TextBox1.Text >= TextBox3.Text Then
                a = (TextBox1.Text - TextBox3.Text) * 30000
                TextBox2.Text = a
            Else
                TextBox2.Text = "0"
            End If
            b = (TextBox3.Text * 75000) + TextBox2.Text
            TextBox4.Text = b
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
        Me.Close()
        home.tampilsep()
    End Sub
End Class