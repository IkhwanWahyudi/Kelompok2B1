Imports MySql.Data.MySqlClient

Public Class LihatCatatan
    Dim id As Integer = globalId
    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbpasien join tbakun on(tbpasien.idAkun = tbakun.id) join tbrs on(tbpasien.idRs = tbrs.ID) where idAkun =" & id & " and tbpasien.status in ('Diterima','Ditolak') order by tbpasien.id desc", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbpasien")
        dgvLihat.DataSource = DS.Tables("tbpasien")
    End Sub

    Sub aturDgv()
        dgvLihat.Columns(3).Width = 65
        dgvLihat.Columns(14).Width = 100
        dgvLihat.Columns(15).Width = 80
        dgvLihat.Columns(16).Width = 47
        dgvLihat.Columns(17).Width = 340

        'hide
        dgvLihat.Columns(0).Visible = False 'id
        dgvLihat.Columns(1).Visible = False 'idAkun
        dgvLihat.Columns(2).Visible = False 'idRs
        dgvLihat.Columns(4).Visible = False 'catatan
        dgvLihat.Columns(5).Visible = False 'id
        dgvLihat.Columns(6).Visible = False 'Fullname
        dgvLihat.Columns(7).Visible = False 'address
        dgvLihat.Columns(8).Visible = False 'date
        dgvLihat.Columns(9).Visible = False 'gender
        dgvLihat.Columns(10).Visible = False 'username
        dgvLihat.Columns(11).Visible = False 'password
        dgvLihat.Columns(12).Visible = False 'gambar
        dgvLihat.Columns(13).Visible = False 'ID
        dgvLihat.Columns(18).Visible = False 'StatusDok

        dgvLihat.Columns(3).HeaderText = "STATUS"
        dgvLihat.Columns(14).HeaderText = "POLIKLINIK"
        dgvLihat.Columns(15).HeaderText = "TANGGAL"
        dgvLihat.Columns(16).HeaderText = "JAM"
        dgvLihat.Columns(17).HeaderText = "DOKTER"

        dgvLihat.Columns(3).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")
        dgvLihat.Columns(14).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#94dde5")
        dgvLihat.Columns(15).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")
        dgvLihat.Columns(16).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#94dde5")
        dgvLihat.Columns(17).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#98b9c9")

        Dim buttonLihatCatatan As New DataGridViewButtonColumn()
        buttonLihatCatatan.HeaderText = "" ' Judul kolom
        buttonLihatCatatan.Name = "Lihat" ' Nama kolom
        buttonLihatCatatan.Text = "Catatan" ' Teks tombol
        buttonLihatCatatan.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvLihat.Columns.Add(buttonLihatCatatan)
    End Sub

    Private Sub LihatCatatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
        Call aturDgv()
    End Sub

    Private Sub dgvLihat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLihat.CellClick
        Koneksi()
        If e.ColumnIndex = 0 Then
            Dim id As Integer = dgvLihat.Rows(e.RowIndex).Cells(1).Value
            MsgBox(id)
            CMD = New MySqlCommand("SELECT catatan from tbpasien WHERE id = '" & id & "'", CONN)
            RD = CMD.ExecuteReader()
            If RD.Read() Then
                Catatan.textCatatan.Text = RD("Catatan").ToString
            End If
            RD.Close()
            Catatan.Show()
        End If
    End Sub

    Private Sub dgvLihat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLihat.CellContentClick

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuPasien.mainPanel.Controls.Clear()
    End Sub
End Class