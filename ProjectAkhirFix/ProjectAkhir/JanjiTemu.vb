Imports System.Globalization
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient

Public Class JanjiTemu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbpasien join tbrs on(tbpasien.idRS = tbrs.ID) ORDER BY `tbpasien`.`id` DESC", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbpasien")
        dgvJadwal.DataSource = DS.Tables("tbpasien")
        dgvJadwal.Refresh()
    End Sub

    Sub TampilanDGV()
        dgvJadwal.Columns(5).Width = 30
        dgvJadwal.Columns(6).Width = 150
        dgvJadwal.Columns(7).Width = 80
        dgvJadwal.Columns(8).Width = 80
        dgvJadwal.Columns(9).Width = 219

        dgvJadwal.Columns(5).HeaderText = "ID"
        dgvJadwal.Columns(6).HeaderText = "POLIKLINIK"
        dgvJadwal.Columns(7).HeaderText = "TANGGAL"
        dgvJadwal.Columns(8).HeaderText = "JAM"
        dgvJadwal.Columns(9).HeaderText = "DOKTER"
        dgvJadwal.Columns(3).HeaderText = "STATUS"
        dgvJadwal.Columns(10).Visible = False 'status dari tbrs
        dgvJadwal.Columns(0).Visible = False 'id dari tbPasien
        dgvJadwal.Columns(1).Visible = False 'idAkun dari tbPasien
        dgvJadwal.Columns(2).Visible = False 'idRS dari tbPasien
        dgvJadwal.Columns(4).Visible = False 'catatan

        Dim buttonDetail As New DataGridViewButtonColumn()
        'buttonDetail.HeaderText = "" ' Judul kolom
        'buttonDetail.Name = "btnDetail" ' Nama kolom
        buttonDetail.Text = "Detail" ' Teks tombol
        buttonDetail.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvJadwal.Columns.Add(buttonDetail)

        Dim buttonAcc As New DataGridViewButtonColumn()
        'buttonAcc.HeaderText = "" ' Judul kolom
        'buttonAcc.Name = "btnTerima" ' Nama kolom
        buttonAcc.Text = "Terima" ' Teks tombol
        buttonAcc.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvJadwal.Columns.Add(buttonAcc)

        Dim buttonColumn As New DataGridViewButtonColumn()
        'buttonColumn.HeaderText = "" ' Judul kolom
        'buttonColumn.Name = "btnTolak" ' Nama kolom
        buttonColumn.Text = "Tolak" ' Teks tombol
        buttonColumn.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvJadwal.Columns.Add(buttonColumn)

        Dim buttonCatatan As New DataGridViewButtonColumn()
        buttonCatatan.Text = "Catatan" ' Teks tombol
        buttonCatatan.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvJadwal.Columns.Add(buttonCatatan)

    End Sub

    Private Sub JanjiTemu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampil()
        Call TampilanDGV()
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

    Private Sub dgvJadwal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJadwal.CellClick
        If e.ColumnIndex = 0 Then ' Kolom tombol pertama (Button Detail)
            Dim id As String = dgvJadwal.Rows(e.RowIndex).Cells(4).Value
            Dim tgl As DateTime = dgvJadwal.Rows(e.RowIndex).Cells(11).Value.ToString()
            CMD = New MySqlCommand("SELECT * FROM tbpasien JOIN tbakun ON tbpasien.idAkun = tbakun.id JOIN tbrs ON tbpasien.idRs = tbrs.ID WHERE tbpasien.id = '" & id & "'", CONN)
            RD = CMD.ExecuteReader()
            If RD.Read() Then
                detailPengajuan.lblNama.Text = RD("fullname").ToString
                detailPengajuan.lblJk.Text = RD("gender").ToString
                detailPengajuan.lblstatus.Text = RD("status").ToString
                detailPengajuan.lblAlamat.Text = RD("address").ToString
                detailPengajuan.lbllahir.Text = RD("date").ToString
                detailPengajuan.lbldokter.Text = RD("Dokter").ToString
                detailPengajuan.lbltgl.Text = RD("Tanggal").ToString
                detailPengajuan.lblpoli.Text = RD("Poliklinik").ToString
            End If

            RD.Close()
            detailPengajuan.Show()
        ElseIf e.ColumnIndex = 1 Then ' Kolom tombol kedua (Button Terima)
            Dim Stat As String = dgvJadwal.Rows(e.RowIndex).Cells(7).Value
            Dim id As String = dgvJadwal.Rows(e.RowIndex).Cells(4).Value
            Dim poli As String = dgvJadwal.Rows(e.RowIndex).Cells(10).Value.ToString()
            Dim tgl As DateTime = dgvJadwal.Rows(e.RowIndex).Cells(11).Value.ToString()
            Dim jam As String = dgvJadwal.Rows(e.RowIndex).Cells(12).Value.ToString()
            Dim dokter As String = dgvJadwal.Rows(e.RowIndex).Cells(13).Value.ToString()
            If Stat = "Menunggu" Then
                CMD = New MySqlCommand("update tbpasien set status = 'Diterima' where id ='" & id & "'", CONN)
                CMD.ExecuteNonQuery()

                CMD = New MySqlCommand("update tbrs set Status = 'Not Available' where Poliklinik ='" & poli &
                                   "' and Tanggal ='" & tgl & "' and Jam ='" & jam & "' and Dokter ='" & dokter & "'", CONN)
                CMD.ExecuteNonQuery()
            Else
                MsgBox("Ini udah " & Stat)
            End If

        ElseIf e.ColumnIndex = 2 Then ' Kolom tombol ketiga (Button Tolak)
            Dim Stat As String = dgvJadwal.Rows(e.RowIndex).Cells(7).Value
            Dim id As String = dgvJadwal.Rows(e.RowIndex).Cells(4).Value
            Dim poli As String = dgvJadwal.Rows(e.RowIndex).Cells(10).Value.ToString()
            Dim tgl As DateTime = dgvJadwal.Rows(e.RowIndex).Cells(11).Value.ToString()
            Dim jam As String = dgvJadwal.Rows(e.RowIndex).Cells(12).Value.ToString()
            Dim dokter As String = dgvJadwal.Rows(e.RowIndex).Cells(13).Value.ToString()
            If Stat = "Menunggu" Or Stat = "Diterima" Then
                CMD = New MySqlCommand("update tbpasien set status = 'Ditolak' where id ='" & id & "'", CONN)
                CMD.ExecuteNonQuery()

                CMD = New MySqlCommand("update tbrs set Status = 'Available' where Poliklinik ='" & poli &
                                   "' and Tanggal ='" & tgl & "' and Jam ='" & jam & "' and Dokter ='" & dokter & "'", CONN)
                CMD.ExecuteNonQuery()
            Else
                MsgBox("Janji Temu Sudah " & Stat, MsgBoxStyle.Information, "Perhatian!")
            End If

        ElseIf e.ColumnIndex = 3 Then ' Kolom tombol keempat (Button Catatan)
            Me.Hide()
            IDPasien = dgvJadwal.Rows(e.RowIndex).Cells(4).Value
            TambahCatatan.Show()
        End If
        Call Tampil()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        MenuAdmin.Show()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuAdmin.Panel1.Controls.Clear()
    End Sub
End Class