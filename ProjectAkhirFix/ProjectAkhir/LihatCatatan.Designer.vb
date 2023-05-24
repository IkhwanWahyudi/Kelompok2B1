<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LihatCatatan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLihat = New System.Windows.Forms.DataGridView()
        Me.btnKembali = New Guna.UI.WinForms.GunaCircleButton()
        CType(Me.dgvLihat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLihat
        '
        Me.dgvLihat.AllowUserToAddRows = False
        Me.dgvLihat.AllowUserToDeleteRows = False
        Me.dgvLihat.AllowUserToResizeColumns = False
        Me.dgvLihat.AllowUserToResizeRows = False
        Me.dgvLihat.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.dgvLihat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLihat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLihat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLihat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLihat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLihat.GridColor = System.Drawing.SystemColors.Control
        Me.dgvLihat.Location = New System.Drawing.Point(284, 89)
        Me.dgvLihat.MultiSelect = False
        Me.dgvLihat.Name = "dgvLihat"
        Me.dgvLihat.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLihat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLihat.RowHeadersVisible = False
        Me.dgvLihat.RowHeadersWidth = 51
        Me.dgvLihat.Size = New System.Drawing.Size(340, 276)
        Me.dgvLihat.TabIndex = 53
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
        Me.btnKembali.TabIndex = 68
        Me.btnKembali.Text = "<"
        '
        'LihatCatatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectAkhir.My.Resources.Resources.catatanlihat
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 422)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.dgvLihat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatCatatan"
        Me.Text = "LihatCatatan"
        CType(Me.dgvLihat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgvLihat As DataGridView
    Friend WithEvents btnKembali As Guna.UI.WinForms.GunaCircleButton
End Class
