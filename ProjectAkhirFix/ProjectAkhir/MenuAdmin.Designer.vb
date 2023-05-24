<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JadwalDokterKlinikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPengajuanJanjiTemuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JadwalDokterKlinikToolStripMenuItem, Me.DataPengajuanJanjiTemuToolStripMenuItem, Me.KembaliToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 24)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JadwalDokterKlinikToolStripMenuItem
        '
        Me.JadwalDokterKlinikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatJadwalToolStripMenuItem, Me.BuatJadwalToolStripMenuItem, Me.UbahJadwalToolStripMenuItem, Me.HapusJadwalToolStripMenuItem, Me.DataDokterToolStripMenuItem})
        Me.JadwalDokterKlinikToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JadwalDokterKlinikToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.JadwalDokterKlinikToolStripMenuItem.Name = "JadwalDokterKlinikToolStripMenuItem"
        Me.JadwalDokterKlinikToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.JadwalDokterKlinikToolStripMenuItem.Text = "Manajemen Klinik"
        '
        'LihatJadwalToolStripMenuItem
        '
        Me.LihatJadwalToolStripMenuItem.Name = "LihatJadwalToolStripMenuItem"
        Me.LihatJadwalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LihatJadwalToolStripMenuItem.Text = "Lihat Jadwal"
        '
        'BuatJadwalToolStripMenuItem
        '
        Me.BuatJadwalToolStripMenuItem.Name = "BuatJadwalToolStripMenuItem"
        Me.BuatJadwalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BuatJadwalToolStripMenuItem.Text = "Tambah Jadwal"
        '
        'UbahJadwalToolStripMenuItem
        '
        Me.UbahJadwalToolStripMenuItem.Name = "UbahJadwalToolStripMenuItem"
        Me.UbahJadwalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UbahJadwalToolStripMenuItem.Text = "Ubah Jadwal"
        '
        'HapusJadwalToolStripMenuItem
        '
        Me.HapusJadwalToolStripMenuItem.Name = "HapusJadwalToolStripMenuItem"
        Me.HapusJadwalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HapusJadwalToolStripMenuItem.Text = "Hapus Jadwal"
        '
        'DataDokterToolStripMenuItem
        '
        Me.DataDokterToolStripMenuItem.Name = "DataDokterToolStripMenuItem"
        Me.DataDokterToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DataDokterToolStripMenuItem.Text = "Data Dokter"
        '
        'DataPengajuanJanjiTemuToolStripMenuItem
        '
        Me.DataPengajuanJanjiTemuToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPengajuanJanjiTemuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataPengajuanJanjiTemuToolStripMenuItem.Name = "DataPengajuanJanjiTemuToolStripMenuItem"
        Me.DataPengajuanJanjiTemuToolStripMenuItem.Size = New System.Drawing.Size(200, 20)
        Me.DataPengajuanJanjiTemuToolStripMenuItem.Text = "Data Pengajuan Janji Temu"
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KembaliToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.KembaliToolStripMenuItem.Text = "Log Out"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.admin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.GunaButton4)
        Me.Panel1.Controls.Add(Me.GunaButton3)
        Me.Panel1.Controls.Add(Me.GunaButton2)
        Me.Panel1.Controls.Add(Me.GunaButton1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 530)
        Me.Panel1.TabIndex = 70
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.AnimationHoverSpeed = 0.07!
        Me.btnSimpan.AnimationSpeed = 0.03!
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.BaseColor = System.Drawing.Color.SkyBlue
        Me.btnSimpan.BorderColor = System.Drawing.Color.Black
        Me.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.btnSimpan.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Nothing
        Me.btnSimpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSimpan.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSimpan.Location = New System.Drawing.Point(-20, 383)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSimpan.OnHoverImage = Nothing
        Me.btnSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.btnSimpan.Radius = 20
        Me.btnSimpan.Size = New System.Drawing.Size(956, 37)
        Me.btnSimpan.TabIndex = 68
        Me.btnSimpan.Text = "Dokter "
        Me.btnSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Global.ProjectAkhir.My.Resources.Resources.ikhwan
        Me.GunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton4.ImageSize = New System.Drawing.Size(250, 250)
        Me.GunaButton4.Location = New System.Drawing.Point(682, 144)
        Me.GunaButton4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(190, 206)
        Me.GunaButton4.TabIndex = 67
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Global.ProjectAkhir.My.Resources.Resources.harlin
        Me.GunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton3.ImageSize = New System.Drawing.Size(250, 250)
        Me.GunaButton3.Location = New System.Drawing.Point(472, 144)
        Me.GunaButton3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(190, 206)
        Me.GunaButton3.TabIndex = 66
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Global.ProjectAkhir.My.Resources.Resources.aldy
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.ImageSize = New System.Drawing.Size(250, 250)
        Me.GunaButton2.Location = New System.Drawing.Point(258, 144)
        Me.GunaButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(189, 206)
        Me.GunaButton2.TabIndex = 65
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.ProjectAkhir.My.Resources.Resources.viona
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.ImageSize = New System.Drawing.Size(250, 250)
        Me.GunaButton1.Location = New System.Drawing.Point(40, 144)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(190, 206)
        Me.GunaButton1.TabIndex = 64
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 56
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(914, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JadwalDokterKlinikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatJadwalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatJadwalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahJadwalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusJadwalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPengajuanJanjiTemuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KembaliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSimpan As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
