<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LihatJadwal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnKembali = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJadwal
        '
        Me.dgvJadwal.AllowUserToAddRows = False
        Me.dgvJadwal.AllowUserToResizeColumns = False
        Me.dgvJadwal.AllowUserToResizeRows = False
        Me.dgvJadwal.BackgroundColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJadwal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvJadwal.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvJadwal.Location = New System.Drawing.Point(43, 141)
        Me.dgvJadwal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.ReadOnly = True
        Me.dgvJadwal.RowHeadersVisible = False
        Me.dgvJadwal.RowHeadersWidth = 51
        Me.dgvJadwal.RowTemplate.Height = 24
        Me.dgvJadwal.Size = New System.Drawing.Size(759, 497)
        Me.dgvJadwal.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(1149, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 26)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnKembali.Location = New System.Drawing.Point(2, 10)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnKembali.OnHoverForeColor = System.Drawing.Color.White
        Me.btnKembali.OnHoverImage = Nothing
        Me.btnKembali.OnPressedColor = System.Drawing.Color.Black
        Me.btnKembali.Size = New System.Drawing.Size(49, 49)
        Me.btnKembali.TabIndex = 67
        Me.btnKembali.Text = "<"
        '
        'LihatJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.jadwal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1219, 649)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.dgvJadwal)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LihatJadwal"
        Me.Text = "Form8"
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnKembali As Guna.UI.WinForms.GunaCircleButton
End Class
