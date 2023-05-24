<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class regis
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
        Me.btnRegister = New Guna.UI.WinForms.GunaButton()
        Me.cbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.dtTanggal = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cbPassword = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAddress = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambahGambar = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnKembali = New Guna.UI.WinForms.GunaCircleButton()
        Me.picture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.tbFullName = New Guna.UI.WinForms.GunaTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.AnimationHoverSpeed = 0.07!
        Me.btnRegister.AnimationSpeed = 0.03!
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BaseColor = System.Drawing.Color.White
        Me.btnRegister.BorderColor = System.Drawing.Color.Black
        Me.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegister.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegister.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnRegister.Image = Nothing
        Me.btnRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRegister.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegister.Location = New System.Drawing.Point(85, 325)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegister.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegister.OnHoverImage = Nothing
        Me.btnRegister.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegister.Radius = 20
        Me.btnRegister.Size = New System.Drawing.Size(120, 34)
        Me.btnRegister.TabIndex = 72
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.BaseColor = System.Drawing.SystemColors.Menu
        Me.cbGender.BorderColor = System.Drawing.Color.Silver
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbGender.ForeColor = System.Drawing.Color.Black
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(162, 230)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbGender.Size = New System.Drawing.Size(120, 26)
        Me.cbGender.TabIndex = 71
        '
        'dtTanggal
        '
        Me.dtTanggal.BackColor = System.Drawing.Color.Transparent
        Me.dtTanggal.BaseColor = System.Drawing.SystemColors.Menu
        Me.dtTanggal.BorderColor = System.Drawing.Color.Silver
        Me.dtTanggal.CustomFormat = Nothing
        Me.dtTanggal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtTanggal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTanggal.ForeColor = System.Drawing.Color.Black
        Me.dtTanggal.Location = New System.Drawing.Point(14, 230)
        Me.dtTanggal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTanggal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTanggal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtTanggal.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTanggal.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTanggal.OnPressedColor = System.Drawing.Color.Black
        Me.dtTanggal.Radius = 5
        Me.dtTanggal.Size = New System.Drawing.Size(118, 26)
        Me.dtTanggal.TabIndex = 70
        Me.dtTanggal.Text = "Thursday, May 18, 2023"
        Me.dtTanggal.Value = New Date(2023, 5, 18, 7, 46, 11, 936)
        '
        'cbPassword
        '
        Me.cbPassword.AutoSize = True
        Me.cbPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.cbPassword.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPassword.ForeColor = System.Drawing.Color.Silver
        Me.cbPassword.Location = New System.Drawing.Point(260, 289)
        Me.cbPassword.Name = "cbPassword"
        Me.cbPassword.Size = New System.Drawing.Size(15, 14)
        Me.cbPassword.TabIndex = 69
        Me.cbPassword.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 263)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Username"
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.Transparent
        Me.tbUsername.BaseColor = System.Drawing.SystemColors.Menu
        Me.tbUsername.BorderColor = System.Drawing.Color.Silver
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.tbUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUsername.Location = New System.Drawing.Point(14, 282)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.Radius = 5
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(118, 30)
        Me.tbUsername.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(159, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Transparent
        Me.tbPassword.BaseColor = System.Drawing.SystemColors.Menu
        Me.tbPassword.BorderColor = System.Drawing.Color.Silver
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.tbPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPassword.Location = New System.Drawing.Point(162, 282)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPassword.Radius = 5
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(118, 30)
        Me.tbPassword.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(159, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(159, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Address"
        '
        'tbAddress
        '
        Me.tbAddress.BackColor = System.Drawing.Color.Transparent
        Me.tbAddress.BaseColor = System.Drawing.SystemColors.Menu
        Me.tbAddress.BorderColor = System.Drawing.Color.Silver
        Me.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAddress.FocusedBaseColor = System.Drawing.Color.White
        Me.tbAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbAddress.Location = New System.Drawing.Point(162, 182)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAddress.Radius = 5
        Me.tbAddress.SelectedText = ""
        Me.tbAddress.Size = New System.Drawing.Size(118, 30)
        Me.tbAddress.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 163)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Full Name"
        '
        'btnTambahGambar
        '
        Me.btnTambahGambar.AnimationHoverSpeed = 0.07!
        Me.btnTambahGambar.AnimationSpeed = 0.03!
        Me.btnTambahGambar.BackColor = System.Drawing.Color.Transparent
        Me.btnTambahGambar.BaseColor = System.Drawing.Color.White
        Me.btnTambahGambar.BorderColor = System.Drawing.Color.Black
        Me.btnTambahGambar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnTambahGambar.FocusedColor = System.Drawing.Color.Empty
        Me.btnTambahGambar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahGambar.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnTambahGambar.Image = Nothing
        Me.btnTambahGambar.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnTambahGambar.Location = New System.Drawing.Point(153, 131)
        Me.btnTambahGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambahGambar.Name = "btnTambahGambar"
        Me.btnTambahGambar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTambahGambar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnTambahGambar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnTambahGambar.OnHoverImage = Nothing
        Me.btnTambahGambar.OnPressedColor = System.Drawing.Color.Black
        Me.btnTambahGambar.Size = New System.Drawing.Size(19, 20)
        Me.btnTambahGambar.TabIndex = 59
        Me.btnTambahGambar.Text = "+"
        '
        'btnKembali
        '
        Me.btnKembali.AnimationHoverSpeed = 0.07!
        Me.btnKembali.AnimationSpeed = 0.03!
        Me.btnKembali.BackColor = System.Drawing.Color.Transparent
        Me.btnKembali.BaseColor = System.Drawing.Color.White
        Me.btnKembali.BorderColor = System.Drawing.Color.Black
        Me.btnKembali.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnKembali.FocusedColor = System.Drawing.Color.Empty
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnKembali.Image = Nothing
        Me.btnKembali.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnKembali.Location = New System.Drawing.Point(8, 13)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKembali.OnHoverImage = Nothing
        Me.btnKembali.OnPressedColor = System.Drawing.Color.Black
        Me.btnKembali.Size = New System.Drawing.Size(19, 20)
        Me.btnKembali.TabIndex = 58
        Me.btnKembali.Text = "<"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.Transparent
        Me.picture.BaseColor = System.Drawing.Color.White
        Me.picture.Image = Global.ProjectAkhir.My.Resources.Resources.PPP
        Me.picture.Location = New System.Drawing.Point(97, 70)
        Me.picture.Margin = New System.Windows.Forms.Padding(2)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(75, 81)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 57
        Me.picture.TabStop = False
        Me.picture.UseTransfarantBackground = False
        '
        'tbFullName
        '
        Me.tbFullName.BackColor = System.Drawing.Color.Transparent
        Me.tbFullName.BaseColor = System.Drawing.SystemColors.Menu
        Me.tbFullName.BorderColor = System.Drawing.Color.Silver
        Me.tbFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFullName.FocusedBaseColor = System.Drawing.Color.White
        Me.tbFullName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFullName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbFullName.Location = New System.Drawing.Point(14, 182)
        Me.tbFullName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbFullName.Name = "tbFullName"
        Me.tbFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFullName.Radius = 5
        Me.tbFullName.SelectedText = ""
        Me.tbFullName.Size = New System.Drawing.Size(118, 30)
        Me.tbFullName.TabIndex = 56
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'regis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.HI
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.cbPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTambahGambar)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.picture)
        Me.Controls.Add(Me.tbFullName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "regis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "regis"
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegister As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbGender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dtTanggal As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cbPassword As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAddress As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambahGambar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnKembali As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents picture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents tbFullName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
