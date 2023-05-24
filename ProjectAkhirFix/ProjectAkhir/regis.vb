Imports MySql.Data.MySqlClient
Imports System.IO

Public Class regis
    Dim Img As String = ""

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function cek()
        If tbUsername.Text = "" Then
            MsgBox("username kosong!")
            tbUsername.Focus()
        ElseIf tbPassword.Text = "" Then
            MsgBox("password tidak boleh kosong!")
        ElseIf tbAddress.Text = "" Then
            MsgBox("alamat tidak boleh kosong!")
        ElseIf cbGender.Text = "" Then
            MsgBox("Gender tidak boleh kosong!")
        ElseIf picture.Image Is Nothing Or Img = "" Then
            MsgBox("Pilih gambar!")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub regis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        dtTanggal.MaxDate = Today
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If cek() Then
            Call Koneksi()
            CMD = New MySqlCommand("Select * From tbakun Where username='" & tbUsername.Text & "'", CONN)

            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()
            If Not RD.HasRows Then
                Dim Simpan As String = "INSERT INTO `tbakun`(`fullname`, `address`, `date`, `gender`, `username`, `password`, `gambar` ) VALUES('" & tbFullName.Text &
                    "','" & tbAddress.Text & "','" & dtTanggal.Text &
                    "','" & cbGender.Text & "','" & tbUsername.Text &
                    "','" & tbPassword.Text & "','" & Img & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Berhasil membuat Akun!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            tbAddress.Text = ""
            tbPassword.Text = ""
            tbUsername.Text = ""
            tbFullName.Text = ""
            cbGender.Text = ""
            Img = " "

            cbGender.Text = False
            cbPassword.Checked = False
            Me.Dispose()
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub btnTambahGambar_Click(sender As Object, e As EventArgs) Handles btnTambahGambar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Images|*.Jpg;*.png;*.bmp"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog1.FileName

            ' Membaca gambar dari file
            Dim image As Image = Image.FromFile(imagePath)

            If imagePath = "" Then
                Exit Sub
            Else
                picture.Image = image
                Img = Path.GetFileName(imagePath)

                Dim directori As String = Application.StartupPath & "\Resources\Gambar\pasien\"

                If Not Directory.Exists(directori) Then
                    Directory.CreateDirectory(directori)
                End If

                Dim namaFileTujuan As String = Path.GetFileName(imagePath)
                File.Copy(imagePath, Path.Combine(directori, namaFileTujuan), True)
                image.Save(directori & namaFileTujuan)
            End If
        End If

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Dispose()
        Login.Show()
    End Sub
End Class