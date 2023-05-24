Imports MySql.Data.MySqlClient

Public Class Login

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsername.Focus()

        tbUsername.Clear()
        tbPassword.Clear()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Koneksi()

        If tbUsername.Text = "admin" And tbPassword.Text = "admin" Then
            MenuAdmin.Show()
            Me.Hide()
        Else
            CMD = New MySqlCommand("select * from tbakun where username = '" & tbUsername.Text & "' and password = '" & tbPassword.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MessageBox.Show("Berhasil Masuk!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                globalId = RD.GetString(0)
                MenuPasien.Show()
                Me.Hide()
                RD.Close()
            Else
                RD.Close()
                MessageBox.Show("Login Failed! Username atau Pasword Salah! Masukkan data login dengan benar! ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbUsername.Clear()
                tbPassword.Clear()
                tbUsername.Focus()
            End If
        End If
    End Sub

    Private Sub lblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSignUp.LinkClicked
        Me.Hide()
        regis.Show()
    End Sub
End Class
