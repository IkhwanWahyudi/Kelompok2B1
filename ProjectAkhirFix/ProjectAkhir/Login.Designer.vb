<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblSignUp = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPassword = New System.Windows.Forms.CheckBox()
        Me.tbUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.btnExit = New Guna.UI.WinForms.GunaButton()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSignUp
        '
        Me.lblSignUp.ActiveLinkColor = System.Drawing.Color.Black
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.LinkColor = System.Drawing.Color.White
        Me.lblSignUp.Location = New System.Drawing.Point(113, 402)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(77, 20)
        Me.lblSignUp.TabIndex = 32
        Me.lblSignUp.TabStop = True
        Me.lblSignUp.Text = "Sign Up"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "New Here?"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.Transparent
        Me.picture.BaseColor = System.Drawing.Color.White
        Me.picture.Image = Global.ProjectAkhir.My.Resources.Resources.PICTURE
        Me.picture.Location = New System.Drawing.Point(559, 80)
        Me.picture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(100, 100)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 30
        Me.picture.TabStop = False
        Me.picture.UseTransfarantBackground = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.SkyBlue
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(529, 398)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 20
        Me.btnLogin.Size = New System.Drawing.Size(160, 42)
        Me.btnLogin.TabIndex = 29
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(487, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Transparent
        Me.tbPassword.BaseColor = System.Drawing.Color.White
        Me.tbPassword.BorderColor = System.Drawing.Color.Silver
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.FocusedBaseColor = System.Drawing.Color.SkyBlue
        Me.tbPassword.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.tbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(476, 287)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPassword.Radius = 20
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(268, 42)
        Me.tbPassword.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(487, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Username"
        '
        'cbPassword
        '
        Me.cbPassword.AutoSize = True
        Me.cbPassword.BackColor = System.Drawing.Color.Transparent
        Me.cbPassword.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPassword.ForeColor = System.Drawing.Color.Silver
        Me.cbPassword.Location = New System.Drawing.Point(491, 336)
        Me.cbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPassword.Name = "cbPassword"
        Me.cbPassword.Size = New System.Drawing.Size(132, 20)
        Me.cbPassword.TabIndex = 25
        Me.cbPassword.Text = "Show Password"
        Me.cbPassword.UseVisualStyleBackColor = False
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.Transparent
        Me.tbUsername.BaseColor = System.Drawing.Color.White
        Me.tbUsername.BorderColor = System.Drawing.Color.Silver
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.FocusedBaseColor = System.Drawing.Color.SkyBlue
        Me.tbUsername.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.tbUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbUsername.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(476, 213)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.Radius = 20
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(268, 42)
        Me.tbUsername.TabIndex = 24
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BaseColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderColor = System.Drawing.Color.Black
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExit.Location = New System.Drawing.Point(744, 12)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Black
        Me.btnExit.Radius = 20
        Me.btnExit.Size = New System.Drawing.Size(40, 42)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.r
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picture)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSignUp As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents picture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPassword As CheckBox
    Friend WithEvents tbUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaButton
End Class
