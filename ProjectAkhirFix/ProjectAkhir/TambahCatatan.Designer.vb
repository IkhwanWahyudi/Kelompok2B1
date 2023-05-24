<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahCatatan
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnKembali = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnSimpan = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.TextBox1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-R", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(24, 96)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 310)
        Me.TextBox1.TabIndex = 56
        '
        'btnKembali
        '
        Me.btnKembali.AnimationHoverSpeed = 0.07!
        Me.btnKembali.AnimationSpeed = 0.03!
        Me.btnKembali.BackColor = System.Drawing.Color.Transparent
        Me.btnKembali.BaseColor = System.Drawing.Color.SkyBlue
        Me.btnKembali.BorderColor = System.Drawing.Color.Black
        Me.btnKembali.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnKembali.FocusedColor = System.Drawing.Color.Empty
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Image = Nothing
        Me.btnKembali.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnKembali.Location = New System.Drawing.Point(9, 9)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKembali.OnHoverImage = Nothing
        Me.btnKembali.OnPressedColor = System.Drawing.Color.Black
        Me.btnKembali.Size = New System.Drawing.Size(37, 40)
        Me.btnKembali.TabIndex = 66
        Me.btnKembali.Text = "<"
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
        Me.btnSimpan.Location = New System.Drawing.Point(24, 422)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSimpan.OnHoverImage = Nothing
        Me.btnSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.btnSimpan.Radius = 20
        Me.btnSimpan.Size = New System.Drawing.Size(120, 34)
        Me.btnSimpan.TabIndex = 67
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TambahCatatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.catatan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 475)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TambahCatatan"
        Me.Text = "TambahCatatan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnKembali As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnSimpan As Guna.UI.WinForms.GunaButton
End Class
