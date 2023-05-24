<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JanjiTemuPasien
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
        Me.cbPoli = New Guna.UI.WinForms.GunaComboBox()
        Me.cbDokter = New Guna.UI.WinForms.GunaComboBox()
        Me.dgvDokter = New System.Windows.Forms.DataGridView()
        Me.btnKembali = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgvDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPoli
        '
        Me.cbPoli.BackColor = System.Drawing.Color.Transparent
        Me.cbPoli.BaseColor = System.Drawing.Color.White
        Me.cbPoli.BorderColor = System.Drawing.Color.Silver
        Me.cbPoli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPoli.FocusedColor = System.Drawing.Color.Empty
        Me.cbPoli.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbPoli.ForeColor = System.Drawing.Color.Black
        Me.cbPoli.FormattingEnabled = True
        Me.cbPoli.Location = New System.Drawing.Point(140, 394)
        Me.cbPoli.Name = "cbPoli"
        Me.cbPoli.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbPoli.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbPoli.Size = New System.Drawing.Size(139, 26)
        Me.cbPoli.TabIndex = 84
        '
        'cbDokter
        '
        Me.cbDokter.BackColor = System.Drawing.Color.Transparent
        Me.cbDokter.BaseColor = System.Drawing.Color.White
        Me.cbDokter.BorderColor = System.Drawing.Color.Silver
        Me.cbDokter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDokter.FocusedColor = System.Drawing.Color.Empty
        Me.cbDokter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbDokter.ForeColor = System.Drawing.Color.Black
        Me.cbDokter.FormattingEnabled = True
        Me.cbDokter.Location = New System.Drawing.Point(376, 390)
        Me.cbDokter.Name = "cbDokter"
        Me.cbDokter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDokter.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbDokter.Size = New System.Drawing.Size(139, 26)
        Me.cbDokter.TabIndex = 83
        '
        'dgvDokter
        '
        Me.dgvDokter.AllowUserToAddRows = False
        Me.dgvDokter.AllowUserToDeleteRows = False
        Me.dgvDokter.AllowUserToResizeColumns = False
        Me.dgvDokter.AllowUserToResizeRows = False
        Me.dgvDokter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDokter.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgvDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDokter.Location = New System.Drawing.Point(20, 81)
        Me.dgvDokter.Name = "dgvDokter"
        Me.dgvDokter.ReadOnly = True
        Me.dgvDokter.RowHeadersVisible = False
        Me.dgvDokter.RowHeadersWidth = 51
        Me.dgvDokter.Size = New System.Drawing.Size(619, 272)
        Me.dgvDokter.TabIndex = 77
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
        Me.btnKembali.Location = New System.Drawing.Point(11, 11)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKembali.OnHoverImage = Nothing
        Me.btnKembali.OnPressedColor = System.Drawing.Color.Black
        Me.btnKembali.Size = New System.Drawing.Size(37, 40)
        Me.btnKembali.TabIndex = 89
        Me.btnKembali.Text = "<"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label2.Location = New System.Drawing.Point(31, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Poliklinik"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label1.Location = New System.Drawing.Point(25, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Filter :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label5.Location = New System.Drawing.Point(304, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Dokter"
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.AnimationHoverSpeed = 0.07!
        Me.btnReset.AnimationSpeed = 0.03!
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BaseColor = System.Drawing.Color.SkyBlue
        Me.btnReset.BorderColor = System.Drawing.Color.Black
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReset.FocusedColor = System.Drawing.Color.Empty
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Image = Nothing
        Me.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnReset.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReset.Location = New System.Drawing.Point(528, 388)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.OnHoverBaseColor = System.Drawing.Color.SkyBlue
        Me.btnReset.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReset.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReset.OnHoverImage = Nothing
        Me.btnReset.OnPressedColor = System.Drawing.Color.Black
        Me.btnReset.Radius = 20
        Me.btnReset.Size = New System.Drawing.Size(120, 58)
        Me.btnReset.TabIndex = 93
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'JanjiTemuPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.buatjanji
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 457)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.cbPoli)
        Me.Controls.Add(Me.cbDokter)
        Me.Controls.Add(Me.dgvDokter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JanjiTemuPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JanjiTemuPasien"
        CType(Me.dgvDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPoli As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbDokter As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents dgvDokter As DataGridView
    Friend WithEvents btnKembali As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReset As Guna.UI.WinForms.GunaButton
End Class
