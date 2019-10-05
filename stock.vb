Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Public Class stock
    Dim sql, noken, merk, jenis, tglmasuk, status As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub opentable()
        Dim myadapter As New MySqlDataAdapter("select * from stocksepeda", koneksi)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub

    Sub auto()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("Select * from stocksepeda order by noken DESC", koneksi)
        da.Fill(ds, "stocksepeda")
        DataGridView1.DataSource = ds.Tables("stocksepeda")
        DataGridView1.ReadOnly = True

        Dim plat, hsl As String
        If DataGridView1.Rows(0).Cells(0).Value = "" Then
            TextBox1.Text = "SPD-001"
        Else
            noken = DataGridView1.Rows(0).Cells(0).Value
            plat = Strings.Right(noken, 1)
            hsl = plat + 1
            TextBox1.Text = "SPD-00" + hsl
        End If
    End Sub
    Sub tersedia()
        For brs As Integer = 0 To DataGridView1.RowCount.ToString - 2
            If DataGridView1.Rows(brs).Cells(4).Value = 0 Then
                DataGridView1.Rows(brs).Cells(4).Value = "Tersedia"
            Else
                DataGridView1.Rows(brs).Cells(4).Value = "Dipinjam"
            End If
        Next
    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        Dim Sqltambah As String = "INSERT INTO stocksepeda(noken, merk, jenis, tglmasuk, status) values ('" & TextBox1.Text & "','" & ComboBox1.Text & "', '" & ComboBox2.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & 0 & "')"
        cmd = New MySqlCommand(Sqltambah, koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        opentable()
        auto()
        clear()
    End Sub

    Private Sub stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opentable()
        auto()
        tersedia()


    End Sub

    Sub clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        cmd = New MySqlCommand("delete from stocksepeda where noken='" & TextBox1.Text & "'", koneksi)
        cmd.ExecuteNonQuery()
        opentable()
        clear()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.OkOnly, "Pemberitahuan")
        opentable()
        auto()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            TextBox1.Text = .Cells(0).Value
        End With
    End Sub
End Class