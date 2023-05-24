Public Class MenuAdmin
    Private Sub LihatJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatJadwalToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New LihatJadwal
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub BuatJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatJadwalToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New TambahJadwal
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub UbahJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahJadwalToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New UbahJadwal
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub HapusJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusJadwalToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New HapusJadwal
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub DataPengajuanJanjiTemuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPengajuanJanjiTemuToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New JanjiTemu
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Login.tbUsername.Clear()
        Login.tbPassword.Clear()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub DataDokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDokterToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim form = New DataDokter
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click

    End Sub
End Class