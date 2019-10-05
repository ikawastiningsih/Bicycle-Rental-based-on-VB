Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class rekapsepeda
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub tampilkan()
        Dim ds, dss As New DataSet
        Dim da As New MySqlDataAdapter("Select psepeda.id,psepeda.idpemesanan,psepeda.jeken,psepeda.noktp,psepeda.nama,psepeda.nohp,psepeda.tgl,psepeda.jam,psepeda.lamap,psepeda.noken,psepeda.total,psepeda.petugaspeminjaman,pengsepeda.petugaspengembalian from psepeda left join pengsepeda on psepeda.idpemesanan = pengsepeda.idpemesanan", koneksi)
        da.Fill(ds, "psepeda")
        DataGridView1.DataSource = ds.Tables("psepeda")
        DataGridView1.ReadOnly = True
    End Sub
    Sub rekap()
        koneksi()
        Dim bulan As Integer
        Try

            Select Case ComboBox1.Text
                Case "Januari"
                    bulan = 1
                Case "Februari"
                    bulan = 2
                Case "Maret"
                    bulan = 3
                Case "April"
                    bulan = 4
                Case "Mei"
                    bulan = 5
                Case "Juni"
                    bulan = 6
                Case "Juli"
                    bulan = 7
                Case "Agustus"
                    bulan = 8
                Case "September"
                    bulan = 9
                Case "Oktober"
                    bulan = 10
                Case "November"
                    bulan = 11
                Case "Desember"
                    bulan = 12
            End Select
            If ComboBox1.Text = "" Then
                MsgBox("Pilih Bulan")
            Else
                Dim rb As New MySqlDataAdapter("select * from psepeda where Month(tgl)='" & bulan & "'", koneksi)
                Dim tb As New DataTable
                rb.Fill(tb)
                DataGridView1.DataSource = tb
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub totalrekap()
        Dim subtotal As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            subtotal += Val(DataGridView1.Rows(i).Cells(10).Value)
            TextBox1.Text = subtotal
        Next
    End Sub

    Private Sub rekapb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilkan()
        totalrekap()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        rekap()
        totalrekap()

    End Sub
End Class