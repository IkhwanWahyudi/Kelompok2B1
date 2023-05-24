Imports MySql.Data.MySqlClient

Public Class TambahCatatan
    Private Sub TambahCatatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Simpan As String = "Update tbpasien set Catatan = '" & TextBox1.Text & "' where id = '" & IDPasien & "'"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil!!")
        Me.Dispose()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Dispose()
    End Sub
End Class