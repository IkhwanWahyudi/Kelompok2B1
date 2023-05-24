Imports MySql.Data.MySqlClient

Public Class Home
    Dim id As Integer = globalId
    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbpasien join tbakun on(tbpasien.idAkun = tbakun.id) join tbrs on(tbpasien.idRs = tbrs.ID) where idAkun =" & id & " and tbpasien.status = 'Menunggu'  order by tbpasien.id desc", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbpasien")
        dgvJanjiTemu.DataSource = DS.Tables("tbpasien")
    End Sub

    Sub aturDgv()
        dgvJanjiTemu.Columns(3).Width = 65
        dgvJanjiTemu.Columns(14).Width = 100
        dgvJanjiTemu.Columns(15).Width = 80
        dgvJanjiTemu.Columns(16).Width = 47
        dgvJanjiTemu.Columns(17).Width = 340

        'hide
        dgvJanjiTemu.Columns(0).Visible = False 'id
        dgvJanjiTemu.Columns(1).Visible = False 'idAkun
        dgvJanjiTemu.Columns(2).Visible = False 'idRs
        dgvJanjiTemu.Columns(4).Visible = False 'catatan
        dgvJanjiTemu.Columns(5).Visible = False 'id
        dgvJanjiTemu.Columns(6).Visible = False 'Fullname
        dgvJanjiTemu.Columns(7).Visible = False 'address
        dgvJanjiTemu.Columns(8).Visible = False 'date
        dgvJanjiTemu.Columns(9).Visible = False 'gender
        dgvJanjiTemu.Columns(10).Visible = False 'username
        dgvJanjiTemu.Columns(11).Visible = False 'password
        dgvJanjiTemu.Columns(12).Visible = False 'gambar
        dgvJanjiTemu.Columns(13).Visible = False 'ID
        dgvJanjiTemu.Columns(18).Visible = False 'StatusDok

        dgvJanjiTemu.Columns(3).HeaderText = "STATUS"
        dgvJanjiTemu.Columns(14).HeaderText = "POLIKLINIK"
        dgvJanjiTemu.Columns(15).HeaderText = "TANGGAL"
        dgvJanjiTemu.Columns(16).HeaderText = "JAM"
        dgvJanjiTemu.Columns(17).HeaderText = "DOKTER"

        dgvJanjiTemu.Columns(3).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")
        dgvJanjiTemu.Columns(14).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#94dde5")
        dgvJanjiTemu.Columns(15).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")
        dgvJanjiTemu.Columns(16).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#94dde5")
        dgvJanjiTemu.Columns(17).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampil()
        Call aturDgv()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuPasien.mainPanel.Controls.Clear()
    End Sub
End Class