Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class home

    Sub tampilsep()
        Dim ds, dd As New DataSet
        Dim da As New MySqlDataAdapter("Select * from stocksepeda where status = 1", koneksi)
        da.Fill(ds, "stocksepeda")
        DataGridView1.DataSource = ds.Tables("stocksepeda")
        DataGridView1.ReadOnly = True
    End Sub
    Sub tampilmot()
        Dim ds, dd As New DataSet
        Dim da As New MySqlDataAdapter("Select * from stockmotor where status = 1", koneksi)
        da.Fill(ds, "stockmotor")
        DataGridView2.DataSource = ds.Tables("stockmotor")
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub SignUpAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignUpAdminToolStripMenuItem.Click
        signup.ShowDialog()
    End Sub

    Private Sub SepedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaToolStripMenuItem.Click
        psepeda.ShowDialog()
    End Sub

    Private Sub SepedaMotorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaMotorToolStripMenuItem.Click
        pmotor.ShowDialog()
    End Sub

    Private Sub StockSepedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockSepedaToolStripMenuItem.Click
        stock.ShowDialog()
    End Sub

    Private Sub StockMotorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMotorToolStripMenuItem.Click
        stockm.ShowDialog()
    End Sub

    Private Sub SepedaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaToolStripMenuItem1.Click
        pengembalian.ShowDialog()
    End Sub

    Private Sub SepedaMotorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaMotorToolStripMenuItem1.Click
        pengembalianm.ShowDialog()
    End Sub

    Private Sub home_Load(ByVal ender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilsep()
        tampilmot()
    End Sub

    Private Sub SepedaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaToolStripMenuItem2.Click
        rekapsepeda.ShowDialog()
    End Sub

    Private Sub SepedaMotorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepedaMotorToolStripMenuItem2.Click
        rekapmotor.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim logout As Integer
        logout = MsgBox("Anda Yakin ingin logout?", MsgBoxStyle.YesNo, "Peringatan")
        If logout = MsgBoxResult.Yes Then
            Me.Close()
            login.Show()
        End If

    End Sub

End Class