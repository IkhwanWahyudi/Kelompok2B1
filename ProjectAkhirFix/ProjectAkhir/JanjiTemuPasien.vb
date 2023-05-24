Imports System.IO
Imports MySql.Data.MySqlClient

Public Class JanjiTemuPasien
    Dim id As Integer = globalId
    Dim dataTable As New DataTable()

    Sub tampil()
        Dim data As String = "SELECT * FROM tbRS"
        If cbDokter.Text <> "" Then
            data &= " WHERE Dokter = '" & cbDokter.SelectedItem.ToString() & "'"
            cbPoli.Text = ""
        ElseIf cbPoli.Text <> "" Then
            data &= " WHERE Poliklinik = '" & cbPoli.SelectedItem.ToString() & "'"
            cbDokter.Text = ""
        End If
        DA = New MySqlDataAdapter(data, CONN)
        dataTable.Clear()
        DA.Fill(dataTable)
        dgvDokter.DataSource = dataTable
        'DA = New MySqlDataAdapter("Select * From tbRS", CONN)
        'DS = New DataSet
        'DS.Clear()
        'DA.Fill(DS, "tbRS")
        'dgvDokter.DataSource = DS.Tables("tbRS")
        dgvDokter.Refresh()
    End Sub

    Sub aturDgv()
        dgvDokter.Columns(0).Visible = False
        'dgvDokter.Columns(6).Visible = False

        Dim buttonDetail As New DataGridViewButtonColumn()
        buttonDetail.HeaderText = "" ' Judul kolom
        buttonDetail.Name = "Bio" ' Nama kolom
        buttonDetail.Text = "Detail" ' Teks tombol
        buttonDetail.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvDokter.Columns.Add(buttonDetail)

        Dim buttonAjukan As New DataGridViewButtonColumn()
        buttonAjukan.HeaderText = "" ' Judul kolom
        buttonAjukan.Name = "JanjiTemu" ' Nama kolom
        buttonAjukan.Text = "Ajukan" ' Teks tombol
        buttonAjukan.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvDokter.Columns.Add(buttonAjukan)
    End Sub

    Sub poliklinik()
        CMD = New MySqlCommand("select * from tbrs", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        While RD.Read
            If Not cbPoli.Items.Contains(RD.GetString(1)) Then
                cbPoli.Items.Add(RD.GetString(1))
            End If
        End While
        RD.Close()
        CONN.Close()
    End Sub

    Sub dokter()
        CONN.Open()
        CMD = New MySqlCommand("select * from tbrs", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        While RD.Read
            If Not cbDokter.Items.Contains(RD.GetString(4)) Then
                cbDokter.Items.Add(RD.GetString(4))
            End If
        End While
        RD.Close()
        CONN.Close()
    End Sub

    Private Sub JanjiTemuPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil()
        Call aturDgv()
        Call poliklinik()
        Call dokter()
    End Sub


    Private Sub dgvDokter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDokter.CellClick
        Koneksi()
        If e.ColumnIndex = 1 Then
            ' Mendapatkan data dari DataGridView
            Dim dt As DataTable = CType(dgvDokter.DataSource, DataTable)
            Dim row As DataRow = dt.Rows(e.RowIndex)

            Dim ids As String = row.Field(Of String)("ID")

            Dim query As String = "INSERT INTO tbpasien (idAkun, idRs, status) values (@idAkun, @idRs, 'Menunggu')"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@idAkun", id)
            cmd.Parameters.AddWithValue("@idRs", ids)

            cmd.ExecuteNonQuery()

            ' Menampilkan pesan berhasil
            MessageBox.Show("Berhasil Ajukan Janji Temu")
        ElseIf e.ColumnIndex = 0 Then
            Dim dokter As String = dgvDokter.Rows(e.RowIndex).Cells("Dokter").Value.ToString()
            DetailDokter.nama.Text = dokter
            Dim sql As String = "SELECT * FROM tbDokter WHERE nama = @nama"
            Dim CMD As New MySqlCommand(sql, CONN)
            CMD.Parameters.AddWithValue("@nama", dokter)

            RD = CMD.ExecuteReader()
            If RD.Read Then
                DetailDokter.nama.Text = RD.GetString(0)
                DetailDokter.alumni.Text = RD.GetString(1)
                DetailDokter.tahun.Text = RD.GetString(2)
            End If
            RD.Close()
            DetailDokter.Show()
        End If
    End Sub

    Private Sub cbDokter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDokter.SelectedIndexChanged
        tampil()
        cbPoli.Enabled = False
    End Sub

    Private Sub cbPoli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPoli.SelectedIndexChanged
        tampil()
        cbDokter.Enabled = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuPasien.mainPanel.Controls.Clear()
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim Data = "SELECT * FROM tbRS"
        DA = New MySqlDataAdapter(Data, CONN)
        dataTable.Clear()
        DA.Fill(dataTable)
        dgvDokter.DataSource = dataTable
        cbDokter.SelectedIndex = -1
        cbPoli.SelectedIndex = -1
        cbPoli.Enabled = True
        cbDokter.Enabled = True
    End Sub
End Class