Imports MySql.Data.MySqlClient

Public Class MenuPasien
    Sub showAkun()
        CMD = New MySqlCommand("Select * From tbakun where id ='" & globalId & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            lblUsername.Text = RD.GetString(5)
            lblIDuser.Text = "Account ID : " & RD.GetString(0)
            Dim path As String = Application.StartupPath & "\Resources\Gambar\pasien\"
            picture.Image = Image.FromFile(path & RD.GetString(7))
        End If
        RD.Close()
    End Sub

    Private Sub MenuPas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call showAkun()
        mainPanel.Controls.Clear()
        Dim form = New Home
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btnJadwal_Click(sender As Object, e As EventArgs) Handles btnJadwal.Click
        btnHome.BackColor = Color.SkyBlue
        btnHome.ForeColor = Color.White
        btnJadwal.BackColor = Color.White
        btnJadwal.ForeColor = Color.SkyBlue
        btnCatatan.BackColor = Color.SkyBlue
        btnCatatan.ForeColor = Color.White

        mainPanel.Controls.Clear()
        Dim form = New JanjiTemuPasien
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BackColor = Color.White
        btnHome.ForeColor = Color.SkyBlue
        btnJadwal.BackColor = Color.SkyBlue
        btnJadwal.ForeColor = Color.White
        btnCatatan.BackColor = Color.SkyBlue
        btnCatatan.ForeColor = Color.White

        mainPanel.Controls.Clear()
        Dim form = New Home
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCatatan_Click(sender As Object, e As EventArgs) Handles btnCatatan.Click
        btnHome.BackColor = Color.SkyBlue
        btnHome.ForeColor = Color.White
        btnJadwal.BackColor = Color.SkyBlue
        btnJadwal.ForeColor = Color.White
        btnCatatan.BackColor = Color.White
        btnCatatan.ForeColor = Color.SkyBlue

        mainPanel.Controls.Clear()
        Dim form = New LihatCatatan
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.tbUsername.Text = ""
        Login.tbPassword.Text = ""
        Login.Show()
    End Sub

End Class