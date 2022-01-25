<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarangKeluar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TextQTYVisible = New System.Windows.Forms.TextBox()
        Me.BtnCariNotaBeli = New System.Windows.Forms.Button()
        Me.TextKodeKlrDetailVisible = New System.Windows.Forms.TextBox()
        Me.TextKodeKlrDetail = New System.Windows.Forms.TextBox()
        Me.TextNotaPenjualan = New System.Windows.Forms.TextBox()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.TextQTYJual = New System.Windows.Forms.TextBox()
        Me.TextKeluar = New System.Windows.Forms.TextBox()
        Me.TextIDDetail = New System.Windows.Forms.TextBox()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextNotaBrgKlr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextTotalStokKlr = New System.Windows.Forms.TextBox()
        Me.TextStok = New System.Windows.Forms.TextBox()
        Me.TextQTY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextKode = New System.Windows.Forms.TextBox()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.TextCus = New System.Windows.Forms.TextBox()
        Me.TextKodeCus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextKdBrgKeluar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGbrgkeluar = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGbrgkeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.DarkRed
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1012, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(37, 23)
        Me.BtnClose.TabIndex = 168
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TextQTYVisible
        '
        Me.TextQTYVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextQTYVisible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYVisible.Location = New System.Drawing.Point(12, 56)
        Me.TextQTYVisible.Name = "TextQTYVisible"
        Me.TextQTYVisible.Size = New System.Drawing.Size(100, 23)
        Me.TextQTYVisible.TabIndex = 167
        '
        'BtnCariNotaBeli
        '
        Me.BtnCariNotaBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCariNotaBeli.FlatAppearance.BorderSize = 0
        Me.BtnCariNotaBeli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCariNotaBeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnCariNotaBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCariNotaBeli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariNotaBeli.ForeColor = System.Drawing.Color.White
        Me.BtnCariNotaBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCariNotaBeli.Location = New System.Drawing.Point(358, 56)
        Me.BtnCariNotaBeli.Name = "BtnCariNotaBeli"
        Me.BtnCariNotaBeli.Size = New System.Drawing.Size(50, 23)
        Me.BtnCariNotaBeli.TabIndex = 166
        Me.BtnCariNotaBeli.Text = "..."
        Me.BtnCariNotaBeli.UseVisualStyleBackColor = False
        '
        'TextKodeKlrDetailVisible
        '
        Me.TextKodeKlrDetailVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeKlrDetailVisible.Location = New System.Drawing.Point(947, 85)
        Me.TextKodeKlrDetailVisible.Name = "TextKodeKlrDetailVisible"
        Me.TextKodeKlrDetailVisible.Size = New System.Drawing.Size(100, 22)
        Me.TextKodeKlrDetailVisible.TabIndex = 165
        '
        'TextKodeKlrDetail
        '
        Me.TextKodeKlrDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeKlrDetail.Location = New System.Drawing.Point(707, 85)
        Me.TextKodeKlrDetail.Name = "TextKodeKlrDetail"
        Me.TextKodeKlrDetail.Size = New System.Drawing.Size(234, 22)
        Me.TextKodeKlrDetail.TabIndex = 164
        '
        'TextNotaPenjualan
        '
        Me.TextNotaPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNotaPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNotaPenjualan.Location = New System.Drawing.Point(118, 56)
        Me.TextNotaPenjualan.Name = "TextNotaPenjualan"
        Me.TextNotaPenjualan.Size = New System.Drawing.Size(234, 23)
        Me.TextNotaPenjualan.TabIndex = 163
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(12, 121)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(100, 22)
        Me.TextJumlah.TabIndex = 162
        '
        'TextQTYJual
        '
        Me.TextQTYJual.Location = New System.Drawing.Point(12, 181)
        Me.TextQTYJual.Name = "TextQTYJual"
        Me.TextQTYJual.Size = New System.Drawing.Size(100, 22)
        Me.TextQTYJual.TabIndex = 160
        '
        'TextKeluar
        '
        Me.TextKeluar.Location = New System.Drawing.Point(12, 243)
        Me.TextKeluar.Name = "TextKeluar"
        Me.TextKeluar.Size = New System.Drawing.Size(100, 22)
        Me.TextKeluar.TabIndex = 161
        '
        'TextIDDetail
        '
        Me.TextIDDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextIDDetail.Location = New System.Drawing.Point(414, 85)
        Me.TextIDDetail.Name = "TextIDDetail"
        Me.TextIDDetail.Size = New System.Drawing.Size(234, 22)
        Me.TextIDDetail.TabIndex = 159
        '
        'DGPenjualan
        '
        Me.DGPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPenjualan.BackgroundColor = System.Drawing.Color.White
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPenjualan.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGPenjualan.Location = New System.Drawing.Point(12, 275)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.Size = New System.Drawing.Size(1035, 170)
        Me.DGPenjualan.TabIndex = 158
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(539, 231)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(114, 36)
        Me.BtnTambah.TabIndex = 157
        Me.BtnTambah.Text = "    KELUAR"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(827, 231)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(114, 36)
        Me.BtnSimpan.TabIndex = 156
        Me.BtnSimpan.Text = "    SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHapus.BackColor = System.Drawing.Color.DarkRed
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(683, 231)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(114, 36)
        Me.BtnHapus.TabIndex = 155
        Me.BtnHapus.Text = "    HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Stok"
        '
        'TextNotaBrgKlr
        '
        Me.TextNotaBrgKlr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNotaBrgKlr.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNotaBrgKlr.Location = New System.Drawing.Point(707, 56)
        Me.TextNotaBrgKlr.Name = "TextNotaBrgKlr"
        Me.TextNotaBrgKlr.Size = New System.Drawing.Size(234, 23)
        Me.TextNotaBrgKlr.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Total Stok Keluar"
        '
        'TextTotalStokKlr
        '
        Me.TextTotalStokKlr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextTotalStokKlr.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalStokKlr.Location = New System.Drawing.Point(391, 244)
        Me.TextTotalStokKlr.Name = "TextTotalStokKlr"
        Me.TextTotalStokKlr.Size = New System.Drawing.Size(100, 23)
        Me.TextTotalStokKlr.TabIndex = 148
        '
        'TextStok
        '
        Me.TextStok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStok.Location = New System.Drawing.Point(121, 243)
        Me.TextStok.Name = "TextStok"
        Me.TextStok.Size = New System.Drawing.Size(100, 23)
        Me.TextStok.TabIndex = 144
        '
        'TextQTY
        '
        Me.TextQTY.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextQTY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTY.Location = New System.Drawing.Point(256, 244)
        Me.TextQTY.Name = "TextQTY"
        Me.TextQTY.Size = New System.Drawing.Size(100, 23)
        Me.TextQTY.TabIndex = 141
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(704, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Nota Barang Keluar"
        '
        'TextKode
        '
        Me.TextKode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKode.Location = New System.Drawing.Point(841, 181)
        Me.TextKode.Name = "TextKode"
        Me.TextKode.Size = New System.Drawing.Size(100, 23)
        Me.TextKode.TabIndex = 140
        '
        'TextBrg
        '
        Me.TextBrg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrg.Location = New System.Drawing.Point(118, 181)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(717, 23)
        Me.TextBrg.TabIndex = 150
        '
        'TextCus
        '
        Me.TextCus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextCus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCus.Location = New System.Drawing.Point(118, 119)
        Me.TextCus.Name = "TextCus"
        Me.TextCus.Size = New System.Drawing.Size(717, 23)
        Me.TextCus.TabIndex = 151
        '
        'TextKodeCus
        '
        Me.TextKodeCus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeCus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeCus.Location = New System.Drawing.Point(841, 119)
        Me.TextKodeCus.Name = "TextKodeCus"
        Me.TextKodeCus.Size = New System.Drawing.Size(100, 23)
        Me.TextKodeCus.TabIndex = 152
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "QTY"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Pelanggan"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Nama Barang"
        '
        'TextKdBrgKeluar
        '
        Me.TextKdBrgKeluar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKdBrgKeluar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKdBrgKeluar.Location = New System.Drawing.Point(414, 56)
        Me.TextKdBrgKeluar.Name = "TextKdBrgKeluar"
        Me.TextKdBrgKeluar.Size = New System.Drawing.Size(234, 23)
        Me.TextKdBrgKeluar.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "ID Barang Keluar"
        '
        'DGbrgkeluar
        '
        Me.DGbrgkeluar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGbrgkeluar.BackgroundColor = System.Drawing.Color.White
        Me.DGbrgkeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGbrgkeluar.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGbrgkeluar.Location = New System.Drawing.Point(12, 454)
        Me.DGbrgkeluar.Name = "DGbrgkeluar"
        Me.DGbrgkeluar.Size = New System.Drawing.Size(1035, 170)
        Me.DGbrgkeluar.TabIndex = 142
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(429, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 137
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 16)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Pilih Nota Penjualan:"
        '
        'BarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TextQTYVisible)
        Me.Controls.Add(Me.BtnCariNotaBeli)
        Me.Controls.Add(Me.TextKodeKlrDetailVisible)
        Me.Controls.Add(Me.TextKodeKlrDetail)
        Me.Controls.Add(Me.TextNotaPenjualan)
        Me.Controls.Add(Me.TextJumlah)
        Me.Controls.Add(Me.TextQTYJual)
        Me.Controls.Add(Me.TextKeluar)
        Me.Controls.Add(Me.TextIDDetail)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextNotaBrgKlr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextTotalStokKlr)
        Me.Controls.Add(Me.TextStok)
        Me.Controls.Add(Me.TextQTY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextKode)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.TextCus)
        Me.Controls.Add(Me.TextKodeCus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextKdBrgKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGbrgkeluar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BarangKeluar"
        Me.Text = "BarangKeluar"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGbrgkeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TextQTYVisible As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariNotaBeli As System.Windows.Forms.Button
    Friend WithEvents TextKodeKlrDetailVisible As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeKlrDetail As System.Windows.Forms.TextBox
    Friend WithEvents TextNotaPenjualan As System.Windows.Forms.TextBox
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYJual As System.Windows.Forms.TextBox
    Friend WithEvents TextKeluar As System.Windows.Forms.TextBox
    Friend WithEvents TextIDDetail As System.Windows.Forms.TextBox
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextNotaBrgKlr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextTotalStokKlr As System.Windows.Forms.TextBox
    Friend WithEvents TextStok As System.Windows.Forms.TextBox
    Friend WithEvents TextQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextKode As System.Windows.Forms.TextBox
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextCus As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeCus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextKdBrgKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGbrgkeluar As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
