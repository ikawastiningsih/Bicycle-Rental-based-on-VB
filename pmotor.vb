Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class pmotor
    Dim sql, id, idpemesanan, noktp, nama, nohp, tgl, tglp, lamap, noken, total, pesan, hsl, petugaspeminjaman As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub tampilkan()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("Select * from pmotor", koneksi)
        da.Fill(ds, "pmotor")
        DataGridView1.DataSource = ds.Tables("pmotor")
        DataGridView1.ReadOnly = True
    End Sub

    Sub auto()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("Select * from pmotor order by idpemesanan DESC", koneksi)
        da.Fill(ds, "pmotor")
        DataGridView1.DataSource = ds.Tables("pmotor")
        DataGridView1.ReadOnly = True

        Dim hsl As String
        If DataGridView1.Rows(0).Cells(1).Value = "" Then
            TextBox1.Text = "PM-001"
        Else
            idpemesanan = DataGridView1.Rows(0).Cells(1).Value
            pesan = Strings.Right(idpemesanan, 1)
            hsl = pesan + 1
            TextBox1.Text = "PM-00" + hsl
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO pmotor(id, idpemesanan, jeken, noktp, nama, nohp, tgl, tglp, lamap, noken, total, petugaspeminjaman) values ('""','" & TextBox1.Text & "', '" & Label21.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "','" & TextBox4.Text & "', '" & ComboBox1.Text & "','" & TextBox6.Text & "', '" & home.tsnama.Text & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()

        Dim stts As Integer
        stts = 1
        cmd = New MySqlCommand("update stockmotor set status='" & stts & "' where noken='" & ComboBox1.Text & "'", koneksi)
        cmd.ExecuteNonQuery()

        MsgBox("Pemesanan Berhasil")
        clear()
        auto()
        tampilkan()

    End Sub

    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub pmotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auto()
        tampilkan()
        Label21.Text = "Sepeda Motor"
        ComboBox1.Items.Clear()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM stockmotor WHERE status = 0", koneksi)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            ComboBox1.Items.Add(rdr("noken"))
        End While
    End Sub

    Sub interval()
        Dim selisih As String
        selisih = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)
        TextBox4.Text = selisih
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.Focus()
            TextBox6.Text = ""
        Else
            TextBox6.Text = 75000 * TextBox4.Text
            If TextBox4.Text >= 5 Then
                TextBox6.Text = 375000
            End If

        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        interval()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
        home.tampilmot()
        Me.Close()
    End Sub
End Class