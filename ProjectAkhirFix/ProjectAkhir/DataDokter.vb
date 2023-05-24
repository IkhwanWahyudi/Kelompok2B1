Imports System.IO
Imports MySql.Data.MySqlClient

Public Class DataDokter
    Dim dataTable As New DataTable()
    Private Sub TambahDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil()
        Call TampilanDGV()
    End Sub

    Private Sub tampil()
        Dim data As String = "SELECT * FROM tbDokter"
        DA = New MySqlDataAdapter(data, CONN)
        DataTable.Clear()
        DA.Fill(DataTable)
        dgvData.DataSource = DataTable
    End Sub

    Sub TampilanDGV()
        dgvData.Columns(0).Width = 130
        dgvData.Columns(1).Width = 190
        dgvData.Columns(2).Width = 79

        dgvData.Columns(0).HeaderText = "NAMA"
        dgvData.Columns(1).HeaderText = "RIWAYAT PENDIDIKAN"
        dgvData.Columns(2).HeaderText = "PENGALAMAN"
        dgvData.Columns(3).Visible = False 'kolom foto

        Dim buttonHapus As New DataGridViewButtonColumn()
        buttonHapus.Text = "Hapus" ' Teks tombol
        buttonHapus.UseColumnTextForButtonValue = True ' Gunakan teks sebagai nilai tombol
        dgvData.Columns.Add(buttonHapus)
    End Sub

    Sub kosong()
        txtNama.Text = ""
        txtAlumni.Text = ""
        txtPengalaman.Text = ""
        PictureBox1.Image = Nothing
        txtNama.Focus()
    End Sub

    Private Function CekDataKosong()
        If txtNama.Text = "" Then
            MessageBox.Show("Nama masih kosong")
            txtNama.Focus()
        ElseIf txtAlumni.Text = "" Then
            MessageBox.Show("Riwayat pendidikan masih kosong")
            txtAlumni.Focus()
        ElseIf txtPengalaman.Text = "" Then
            MessageBox.Show("Alamat masih kosong")
            txtPengalaman.Focus()
        ElseIf PictureBox1.Image Is Nothing Or Img = "" Then
            MsgBox("Pilih gambar!")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If CekDataKosong() Then
            Dim cek As String = "select nama from tbDokter where nama='" & txtNama.Text & "'"
            CMD = New MySqlCommand(cek, CONN)
            RD = CMD.ExecuteReader()
            RD.Close()
            If RD.HasRows Then
                ' Data ditemukan di database, maka batalkan operasi simpan
                MessageBox.Show("Data sudah ada di database. Operasi simpan dibatalkan.")
            Else
                Dim Simpan As String = "insert into tbDokter(nama, riwayatPendidikan, pengalaman, foto) values ('" & txtNama.Text & "' , '" & txtAlumni.Text & "' , '" & txtPengalaman.Text & "', '" & Img & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan Data Berhasil!", MsgBoxStyle.Information, "PERHATIAN!")
            End If
            RD.Close()
        End If
        tampil()
    End Sub

    Public Img As String
    Public image As Image
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        openFileDialog1.Title = "Select an Image"
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName

            ' Membaca gambar dari file
            image = Image.FromFile(imagePath)

            If imagePath = "" Then
                MsgBox("Foto profil tidak ada!")
                Exit Sub
            Else
                Dim directori As String = Application.StartupPath & "\Resources\Gambar\dokter\"

                Dim namaFileTujuan As String = Path.GetFileName(imagePath)
                File.Copy(imagePath, Path.Combine(directori, namaFileTujuan), True)
                image.Save(directori & namaFileTujuan)

                PictureBox1.Image = image
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Img = Path.GetFileName(imagePath)
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If CekDataKosong() Then
            Dim Ubah As String = "update tbDokter set foto ='" & Img & "' where Nama='" & txtNama.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Ubah Data Berhasil!", MsgBoxStyle.Information, "PERHATIAN!")
        End If
        kosong()
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim i As Integer
        i = Me.dgvData.CurrentRow.Index
        With dgvData.Rows.Item(i)
            Me.txtNama.Text = .Cells(1).Value
            Me.txtAlumni.Text = .Cells(2).Value
            Me.txtPengalaman.Text = .Cells(3).Value
            Dim path As String = Application.StartupPath & "\Resources\Gambar\dokter\"
            Me.PictureBox1.Image = Image.FromFile(path & .Cells(4).Value)
        End With
        If e.ColumnIndex = 0 Then
            CMD = New MySqlCommand("delete from tbdokter where Nama = '" & txtNama.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil!", MsgBoxStyle.Information, "PERHATIAN!")
        End If
        Call tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        MenuAdmin.Panel1.Controls.Clear()
    End Sub
End Class