<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPasien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.btnJadwal = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblIDuser = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCatatan = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExit = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Location = New System.Drawing.Point(226, 51)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(664, 433)
        Me.mainPanel.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnJadwal)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblIDuser)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.picture)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnCatatan)
        Me.Panel1.Location = New System.Drawing.Point(-12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 485)
        Me.Panel1.TabIndex = 49
        '
        'btnLogout
        '
        Me.btnLogout.AnimationHoverSpeed = 0.07!
        Me.btnLogout.AnimationSpeed = 0.03!
        Me.btnLogout.BaseColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.ProjectAkhir.My.Resources.Resources.keluarr
        Me.btnLogout.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnLogout.Location = New System.Drawing.Point(10, 429)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(63, 56)
        Me.btnLogout.TabIndex = 47
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnJadwal
        '
        Me.btnJadwal.BackColor = System.Drawing.Color.SkyBlue
        Me.btnJadwal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJadwal.FlatAppearance.BorderSize = 0
        Me.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJadwal.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwal.ForeColor = System.Drawing.Color.White
        Me.btnJadwal.Location = New System.Drawing.Point(10, 205)
        Me.btnJadwal.Name = "btnJadwal"
        Me.btnJadwal.Size = New System.Drawing.Size(250, 49)
        Me.btnJadwal.TabIndex = 44
        Me.btnJadwal.Text = "Janji Temu"
        Me.btnJadwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJadwal.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-8, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 10)
        Me.Panel2.TabIndex = 43
        '
        'lblIDuser
        '
        Me.lblIDuser.AutoSize = True
        Me.lblIDuser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblIDuser.Location = New System.Drawing.Point(103, 49)
        Me.lblIDuser.Name = "lblIDuser"
        Me.lblIDuser.Size = New System.Drawing.Size(67, 14)
        Me.lblIDuser.TabIndex = 42
        Me.lblIDuser.Text = "Fullname"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsername.Location = New System.Drawing.Point(104, 25)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(118, 23)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.Transparent
        Me.picture.BaseColor = System.Drawing.Color.White
        Me.picture.Image = Global.ProjectAkhir.My.Resources.Resources.PPP
        Me.picture.Location = New System.Drawing.Point(23, 10)
        Me.picture.Margin = New System.Windows.Forms.Padding(2)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(75, 81)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 41
        Me.picture.TabStop = False
        Me.picture.UseTransfarantBackground = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.White
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnHome.Location = New System.Drawing.Point(10, 131)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(250, 49)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnCatatan
        '
        Me.btnCatatan.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCatatan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCatatan.FlatAppearance.BorderSize = 0
        Me.btnCatatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatatan.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatatan.ForeColor = System.Drawing.Color.White
        Me.btnCatatan.Location = New System.Drawing.Point(10, 278)
        Me.btnCatatan.Name = "btnCatatan"
        Me.btnCatatan.Size = New System.Drawing.Size(250, 49)
        Me.btnCatatan.TabIndex = 45
        Me.btnCatatan.Text = "Catatan"
        Me.btnCatatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatatan.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Location = New System.Drawing.Point(226, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(685, 49)
        Me.Panel3.TabIndex = 50
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BaseColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderColor = System.Drawing.Color.Black
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExit.Location = New System.Drawing.Point(617, 10)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Black
        Me.btnExit.Radius = 20
        Me.btnExit.Size = New System.Drawing.Size(30, 34)
        Me.btnExit.TabIndex = 48
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "R U M A H  S A K I T  S E H A T  S E L A L U"
        '
        'MenuPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 488)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPasien"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnJadwal As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblIDuser As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents picture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCatatan As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
End Class
