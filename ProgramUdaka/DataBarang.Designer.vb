<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataBarang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Rb_Kode = New System.Windows.Forms.RadioButton()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.Rb_Nama = New System.Windows.Forms.RadioButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.TextKodeUbah = New System.Windows.Forms.TextBox()
        Me.BtnBrgDetail = New System.Windows.Forms.Button()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnUbah.FlatAppearance.BorderSize = 0
        Me.BtnUbah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUbah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.ForeColor = System.Drawing.Color.White
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(145, 51)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(120, 35)
        Me.BtnUbah.TabIndex = 20
        Me.BtnUbah.Text = "    UBAH"
        Me.BtnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(9, 51)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(120, 35)
        Me.BtnTambah.TabIndex = 19
        Me.BtnTambah.Text = "   TAMBAH"
        Me.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Rb_Kode
        '
        Me.Rb_Kode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rb_Kode.AutoSize = True
        Me.Rb_Kode.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Kode.Location = New System.Drawing.Point(679, 28)
        Me.Rb_Kode.Name = "Rb_Kode"
        Me.Rb_Kode.Size = New System.Drawing.Size(111, 20)
        Me.Rb_Kode.TabIndex = 22
        Me.Rb_Kode.TabStop = True
        Me.Rb_Kode.Text = "Kode Barang"
        Me.Rb_Kode.UseVisualStyleBackColor = True
        '
        'TextCari
        '
        Me.TextCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(659, 63)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(388, 23)
        Me.TextCari.TabIndex = 17
        '
        'Rb_Nama
        '
        Me.Rb_Nama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rb_Nama.AutoSize = True
        Me.Rb_Nama.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Nama.Location = New System.Drawing.Point(555, 28)
        Me.Rb_Nama.Name = "Rb_Nama"
        Me.Rb_Nama.Size = New System.Drawing.Size(118, 20)
        Me.Rb_Nama.TabIndex = 21
        Me.Rb_Nama.TabStop = True
        Me.Rb_Nama.Text = "Nama Barang"
        Me.Rb_Nama.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGBarang.BackgroundColor = System.Drawing.Color.White
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBarang.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarang.Location = New System.Drawing.Point(9, 118)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(1040, 488)
        Me.DGBarang.TabIndex = 18
        '
        'TextKodeUbah
        '
        Me.TextKodeUbah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextKodeUbah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeUbah.ForeColor = System.Drawing.Color.Teal
        Me.TextKodeUbah.Location = New System.Drawing.Point(555, 63)
        Me.TextKodeUbah.Name = "TextKodeUbah"
        Me.TextKodeUbah.Size = New System.Drawing.Size(100, 23)
        Me.TextKodeUbah.TabIndex = 24
        '
        'BtnBrgDetail
        '
        Me.BtnBrgDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnBrgDetail.FlatAppearance.BorderSize = 0
        Me.BtnBrgDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnBrgDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnBrgDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrgDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrgDetail.ForeColor = System.Drawing.Color.White
        Me.BtnBrgDetail.Image = CType(resources.GetObject("BtnBrgDetail.Image"), System.Drawing.Image)
        Me.BtnBrgDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrgDetail.Location = New System.Drawing.Point(281, 51)
        Me.BtnBrgDetail.Name = "BtnBrgDetail"
        Me.BtnBrgDetail.Size = New System.Drawing.Size(120, 35)
        Me.BtnBrgDetail.TabIndex = 111
        Me.BtnBrgDetail.Text = "    DETAIL"
        Me.BtnBrgDetail.UseVisualStyleBackColor = False
        '
        'TextBrg
        '
        Me.TextBrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrg.ForeColor = System.Drawing.Color.Teal
        Me.TextBrg.Location = New System.Drawing.Point(145, 26)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(256, 22)
        Me.TextBrg.TabIndex = 112
        Me.TextBrg.Visible = False
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.Color.Teal
        Me.BtnCetak.FlatAppearance.BorderSize = 0
        Me.BtnCetak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCetak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.ForeColor = System.Drawing.Color.White
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetak.Location = New System.Drawing.Point(417, 51)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(120, 35)
        Me.BtnCetak.TabIndex = 133
        Me.BtnCetak.Text = "  CETAK"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1024, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 134
        Me.PictureBox1.TabStop = False
        '
        'DataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.BtnBrgDetail)
        Me.Controls.Add(Me.TextKodeUbah)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Rb_Kode)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.Rb_Nama)
        Me.Controls.Add(Me.DGBarang)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents Rb_Kode As System.Windows.Forms.RadioButton
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents Rb_Nama As System.Windows.Forms.RadioButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents TextKodeUbah As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrgDetail As System.Windows.Forms.Button
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
