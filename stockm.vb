Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class stockm
    Dim sql, noken, jenis, merk, type, tglmskm, status As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Sub opentable()
        Dim myadapter As New MySqlDataAdapter("select * from stockmotor", koneksi)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub
    Sub tersedia()
        For brs As Integer = 0 To DataGridView1.RowCount.ToString - 2
            If DataGridView1.Rows(brs).Cells(5).Value = 0 Then
                DataGridView1.Rows(brs).Cells(5).Value = "Tersedia"
            Else
                DataGridView1.Rows(brs).Cells(5).Value = "Dipinjam"
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO stockmotor(noken, jenis, merk, type, tglmskm, status) values ('" & TextBox1.Text & "','" & ComboBox1.Text & "', '" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & 0 & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        opentable()
        clear()
    End Sub

    Sub clear()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""


    End Sub

    Private Sub stockm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opentable()
        tersedia()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.Text = "Motor Matic" And ComboBox2.Text = "Honda" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Vario")
            ComboBox3.Items.Add("Beat")
        End If

        If ComboBox1.Text = "Motor Bebek" And ComboBox2.Text = "Honda" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Revo")
            ComboBox3.Items.Add("Blade")
        End If

        If ComboBox1.Text = "Motor Matic" And ComboBox2.Text = "Yamaha" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Mio")
            ComboBox3.Items.Add("Fino")
            ComboBox3.Items.Add("N-MAX")
        End If

        If ComboBox1.Text = "Motor Bebek" And ComboBox2.Text = "Yamaha" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Vixion")
            ComboBox3.Items.Add("Jupiter")
        End If

        If ComboBox1.Text = "Motor Matic" And ComboBox2.Text = "Suzuki" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Brugman")
        End If

        If ComboBox1.Text = "Motor Bebek" And ComboBox2.Text = "Suzuki" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Smash")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        cmd = New MySqlCommand("delete from stockmotor where noken='" & TextBox1.Text & "'", koneksi)
        cmd.ExecuteNonQuery()
        opentable()
        clear()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.OkOnly, "Pemberitahuan")
        opentable()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            TextBox1.Text = .Cells(0).Value
        End With
    End Sub
End Class