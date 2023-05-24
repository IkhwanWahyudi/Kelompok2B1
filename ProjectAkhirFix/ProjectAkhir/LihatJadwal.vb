Imports MySql.Data.MySqlClient

Public Class LihatJadwal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbRS", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbRS")
        dgvJadwal.DataSource = DS.Tables("tbRS")
        dgvJadwal.Refresh()
    End Sub
    Sub TampilanDGV()
        dgvJadwal.Columns(0).Width = 30
        dgvJadwal.Columns(1).Width = 215
        dgvJadwal.Columns(2).Width = 84
        dgvJadwal.Columns(3).Width = 80
        dgvJadwal.Columns(4).Width = 400

        dgvJadwal.Columns(0).HeaderText = "ID"
        dgvJadwal.Columns(1).HeaderText = "POLIKLINIK"
        dgvJadwal.Columns(2).HeaderText = "TANGGAL"
        dgvJadwal.Columns(3).HeaderText = "JAM"
        dgvJadwal.Columns(4).HeaderText = "DOKTER"
        dgvJadwal.Columns(5).HeaderText = "STATUS"
    End Sub

    Private Sub dgvJadwal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvJadwal.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If e.ColumnIndex Mod 2 = 0 Then
                ' Kolom genap
                e.CellStyle.BackColor = Color.LightGray
            Else
                ' Kolom ganjil
                e.CellStyle.BackColor = Color.LightBlue
            End If
        End If
    End Sub

    Private Sub LihatJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
        Call TampilanDGV()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuAdmin.Panel1.Controls.Clear()
    End Sub
End Class