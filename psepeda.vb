Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class psepeda
    Dim sql, id, idpemesanan, jeken, noktp, nama, nohp, tgl, jam, lamap, noken, pms, pesan, total, hsl, petugaspeminjaman As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub tampilkan()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("Select * from psepeda", koneksi)
        da.Fill(ds, "psepeda")
        DataGridView1.DataSource = ds.Tables("psepeda")
        DataGridView1.ReadOnly = True
    End Sub

    Sub auto()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("Select * from psepeda order by idpemesanan DESC", koneksi)
        da.Fill(ds, "psepeda")
        DataGridView1.DataSource = ds.Tables("psepeda")
        DataGridView1.ReadOnly = True

        Dim hsl As String
        If DataGridView1.Rows(0).Cells(1).Value = "" Then
            TextBox1.Text = "PS-001"

            Else
                idpemesanan = DataGridView1.Rows(0).Cells(1).Value
                pesan = Strings.Right(idpemesanan, 1)
                hsl = pesan + 1
                TextBox1.Text = "PS-00" + hsl
            End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO psepeda(id, idpemesanan, jeken, noktp, nama, nohp, tgl, jam, lamap, noken, total, petugaspeminjaman) values ('""', '" & TextBox1.Text & "','" & Label22.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "','" & TextBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Label6.Text & "','" & TextBox4.Text & "' , '" & ComboBox1.Text & "', '" & TextBox6.Text & "', '" & home.tsnama.Text & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()

        Dim stts As Integer
        stts = 1
        cmd = New MySqlCommand("update stocksepeda set status='" & stts & "' where noken='" & ComboBox1.Text & "'", koneksi)
        cmd.ExecuteNonQuery()

        MsgBox("Pemesanan Berhasil")
        clear()
        auto()
        tampilkan()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
    End Sub
    Sub clear()

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""

    End Sub

    Private Sub psepeda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilkan()
        auto()
        Label22.Text = "Sepeda"
        ComboBox1.Items.Clear()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM stocksepeda WHERE status = '0'", koneksi)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            ComboBox1.Items.Add(rdr("noken"))
        End While

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.Focus()
        Else
            TextBox6.Text = 10000 * TextBox4.Text
            If TextBox4.Text >= 5 Then
                TextBox6.Text = 50000
            End If

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
        home.tampilsep()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class