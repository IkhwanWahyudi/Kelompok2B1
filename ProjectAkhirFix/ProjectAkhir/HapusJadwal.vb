Imports MySql.Data.MySqlClient

Public Class HapusJadwal
    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbRS Where Status = 'Available'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbRS")
        dgvJadwal.DataSource = DS.Tables("tbRS")
        dgvJadwal.Refresh()
    End Sub
    Sub TampilanDGV()
        dgvJadwal.Columns(0).Width = 30
        dgvJadwal.Columns(1).Width = 190
        dgvJadwal.Columns(2).Width = 79
        dgvJadwal.Columns(3).Width = 79
        dgvJadwal.Columns(4).Width = 200

        dgvJadwal.Columns(0).HeaderText = "ID"
        dgvJadwal.Columns(1).HeaderText = "POLIKLINIK"
        dgvJadwal.Columns(2).HeaderText = "TANGGAL"
        dgvJadwal.Columns(3).HeaderText = "JAM"
        dgvJadwal.Columns(4).HeaderText = "DOKTER"
    End Sub
    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        Dim i As Integer
        i = Me.dgvJadwal.CurrentRow.Index
        With dgvJadwal.Rows.Item(i)
            Me.txtID.Text = .Cells(0).Value
        End With
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then
            MessageBox.Show("ID Belum Diisi", "PERINGATAN", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            txtID.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus jadwal dengan kode = " & txtID.Text &
                               " ?", "PERHATIAN!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbrs where ID = '" & txtID.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                txtID.Clear()
                Call Tampil()
                MsgBox("Jadwal Telah Dihapus!", MsgBoxStyle.Information, "PERHATIAN!")
            Else
                txtID.Clear()
            End If
        End If
    End Sub

    Private Sub dgvJadwal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvJadwal.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If e.ColumnIndex Mod 2 = 0 Then
                ' Kolom genap (indeks kolom dimulai dari 0)
                e.CellStyle.BackColor = Color.LightGray
            Else
                ' Kolom ganjil (indeks kolom dimulai dari 0)
                e.CellStyle.BackColor = Color.LightBlue
            End If
        End If
    End Sub

    Private Sub HapusJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
        Call TampilanDGV()
        txtID.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtID.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuAdmin.Panel1.Controls.Clear()
    End Sub
End Class