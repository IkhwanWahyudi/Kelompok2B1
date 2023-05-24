Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Public Class TambahJadwal
    'Dim PPD As Integer = 0 'Poliklinik Penyakit Dalam
    'Dim PKK As Integer = 0 'Poliklinik Kebidanan dan Kandungan
    'Dim PA As Integer = 0 'Poliklinik Anak
    'Dim PBS As Integer = 0 'Poliklinik Bedah Saraf
    'Dim PTH As Integer = 0 'Poliklinik THT-KL
    'Dim PKJ As Integer = 0 'Poliklinik Kedokteran Jiwa
    'Dim PGM As Integer = 0 'Poliklinik Gigi dan Mulut
    'Dim Jam As String = ""

    Dim Gelar As String = ""
    Sub Kosong()
        txtID.Clear()
        cbPoliklinik.Text = Nothing
        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next
        cbDokter.Text = Nothing
    End Sub

    Sub Tampil()
        DA = New MySqlDataAdapter("Select * From tbRS", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "RS")
        dgvJadwal.DataSource = DS.Tables("RS")
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
    Sub TampilDokter()
        cbDokter.Items.Clear()
        CMD = New MySqlCommand("Select Nama From tbdokter where Nama LIKE '%" & Gelar & "%'", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbDokter.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub
    Function PilihJam()
        If RadioButton1.Checked = True Then
            Jam = RadioButton1.Text
            Return True
        ElseIf RadioButton2.Checked = True Then
            Jam = RadioButton2.Text
            Return True
        ElseIf RadioButton3.Checked = True Then
            Jam = RadioButton3.Text
            Return True
        ElseIf RadioButton4.Checked = True Then
            Jam = RadioButton4.Text
            Return True
        ElseIf RadioButton5.Checked = True Then
            Jam = RadioButton5.Text
            Return True
        ElseIf RadioButton6.Checked = True Then
            Jam = RadioButton6.Text
            Return True
        End If
        Return False
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim tanggal As Date = dtpTanggal.Value
        Dim formatTanggalWaktu As String = tanggal.ToString("yyyy-MM-dd")

        If CekDataKosong() And PilihJam() Then
            CMD = New MySqlCommand("Select * From tbRS where Tanggal = '" &
                                   formatTanggalWaktu & "' and Jam = '" & Jam &
                                   "' and Dokter = '" & cbDokter.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbrs(ID, Poliklinik, Tanggal, Jam, Dokter, Status) Values ('" &
                txtID.Text & "' , '" & cbPoliklinik.Text & "' , '" & formatTanggalWaktu & "', '" &
                Jam & "' , '" & cbDokter.Text & "', 'Available')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan Data Berhasil!", MsgBoxStyle.Information, "PERHATIAN!")
                Call Tampil()
                Call TampilanDGV()
                Call Kosong()
            ElseIf RD.HasRows Then
                RD.Close()
                MsgBox("Dokter " & cbDokter.Text & "Sudah memiliki jadwal di Jam/Tanggal yang sama!", MsgBoxStyle.Information, "PERHATIAN!")
            Else
                RD.Close()
                Call Kosong()
            End If
        Else
            MsgBox("Data belum lengkap")
            Exit Sub
        End If
        Call Kosong()
    End Sub
    Private Sub dgvJadwal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvJadwal.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If e.ColumnIndex Mod 2 = 0 Then
                ' Kolom genap (indeks kolom dimulai dari 0)
                e.CellStyle.BackColor = Color.LightGray
            Else
                ' Kolom ganjil (indeks kolom dimulai dari 0)
                e.CellStyle.BackColor = Color.Blue
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub TambahJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPoliklinik.DropDownStyle = ComboBoxStyle.DropDownList
        cbDokter.DropDownStyle = ComboBoxStyle.DropDownList
        txtID.Enabled = False
        dtpTanggal.MinDate = DateTime.Today
        Call Kosong()
        Call Tampil()
        Call TampilanDGV()
        dtpTanggal.CustomFormat = "yyyy-mm-dd"
        For Each row As DataGridViewRow In dgvJadwal.Rows
            If row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Penyakit Dalam" Then
                PPD += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Kebidanan dan Kandungan" Then
                PKK += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Anak" Then
                PA += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Bedah Saraf" Then
                PBS += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik THT-KL" Then
                PTH += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Kedokteran Jiwa" Then
                PKJ += 1
            ElseIf row.Cells("POLIKLINIK").Value IsNot Nothing AndAlso
                row.Cells("POLIKLINIK").Value.ToString() = "Poliklinik Gigi dan Mulut" Then
                PGM += 1
            End If
        Next
    End Sub

    Function CekDataKosong()
        If cbPoliklinik.Text = "" Then
            cbPoliklinik.Focus()
        ElseIf dtpTanggal.Text = "" Then
            dtpTanggal.Focus()
        ElseIf cbDokter.Text = "" Then
            cbDokter.Focus()
        ElseIf RadioButton1.Checked = True AndAlso (RadioButton2.Checked = True OrElse
            RadioButton3.Checked = True OrElse RadioButton4.Checked = True OrElse
            RadioButton5.Checked = True OrElse RadioButton6.Checked = True) Then
            RadioButton1.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub cbPoliklinik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPoliklinik.SelectedIndexChanged
        If cbPoliklinik.Text = "Poliklinik Penyakit Dalam" Then
            txtID.Text = "PD" & PPD
            Gelar = "Sp.PD"
        ElseIf cbPoliklinik.Text = "Poliklinik Kebidanan dan Kandungan" Then
            txtID.Text = "KK" & PKK
            Gelar = "Sp.OG"
        ElseIf cbPoliklinik.Text = "Poliklinik Anak" Then
            txtID.Text = "A" & PA
            Gelar = "Sp.A"
        ElseIf cbPoliklinik.Text = "Poliklinik Bedah Saraf" Then
            txtID.Text = "BS" & PBS
            Gelar = "Sp.BS"
        ElseIf cbPoliklinik.Text = "Poliklinik THT-KL" Then
            txtID.Text = "TH" & PTH
            Gelar = "Sp.T.H.T.K.L"
        ElseIf cbPoliklinik.Text = "Poliklinik Kedokteran Jiwa" Then
            txtID.Text = "KJ" & PKJ
            Gelar = "Sp.KJ"
        ElseIf cbPoliklinik.Text = "Poliklinik Gigi dan Mulut" Then
            txtID.Text = "GM" & PGM
            Gelar = "Sp.KG"
        End If
        Call TampilDokter()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuAdmin.Panel1.Controls.Clear()
    End Sub
End Class