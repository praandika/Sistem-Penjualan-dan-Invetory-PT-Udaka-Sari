<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangMasuk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarangMasuk))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextNotaBrgMsk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextTotalStokMsk = New System.Windows.Forms.TextBox()
        Me.TextStok = New System.Windows.Forms.TextBox()
        Me.TextQTY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextKode = New System.Windows.Forms.TextBox()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.TextSup = New System.Windows.Forms.TextBox()
        Me.TextKodeSup = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextKdBrgMasuk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGbrgmasuk = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.TextIDDetail = New System.Windows.Forms.TextBox()
        Me.TextMasuk = New System.Windows.Forms.TextBox()
        Me.TextQTYBeli = New System.Windows.Forms.TextBox()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.TextNotaPembelian = New System.Windows.Forms.TextBox()
        Me.TextKodeMskDetail = New System.Windows.Forms.TextBox()
        Me.BtnCariNotaBeli = New System.Windows.Forms.Button()
        Me.TextKodeMskDetailVisible = New System.Windows.Forms.TextBox()
        Me.TextQTYVisible = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.DGbrgmasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Stok"
        '
        'TextNotaBrgMsk
        '
        Me.TextNotaBrgMsk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNotaBrgMsk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNotaBrgMsk.Location = New System.Drawing.Point(707, 56)
        Me.TextNotaBrgMsk.Name = "TextNotaBrgMsk"
        Me.TextNotaBrgMsk.Size = New System.Drawing.Size(234, 23)
        Me.TextNotaBrgMsk.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Total Stok Masuk"
        '
        'TextTotalStokMsk
        '
        Me.TextTotalStokMsk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextTotalStokMsk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalStokMsk.Location = New System.Drawing.Point(391, 244)
        Me.TextTotalStokMsk.Name = "TextTotalStokMsk"
        Me.TextTotalStokMsk.Size = New System.Drawing.Size(100, 23)
        Me.TextTotalStokMsk.TabIndex = 94
        '
        'TextStok
        '
        Me.TextStok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStok.Location = New System.Drawing.Point(121, 243)
        Me.TextStok.Name = "TextStok"
        Me.TextStok.Size = New System.Drawing.Size(100, 23)
        Me.TextStok.TabIndex = 90
        '
        'TextQTY
        '
        Me.TextQTY.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextQTY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTY.Location = New System.Drawing.Point(256, 244)
        Me.TextQTY.Name = "TextQTY"
        Me.TextQTY.Size = New System.Drawing.Size(100, 23)
        Me.TextQTY.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(704, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Nota Barang Masuk"
        '
        'TextKode
        '
        Me.TextKode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKode.Location = New System.Drawing.Point(841, 181)
        Me.TextKode.Name = "TextKode"
        Me.TextKode.Size = New System.Drawing.Size(100, 23)
        Me.TextKode.TabIndex = 86
        '
        'TextBrg
        '
        Me.TextBrg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrg.Location = New System.Drawing.Point(118, 181)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(717, 23)
        Me.TextBrg.TabIndex = 96
        '
        'TextSup
        '
        Me.TextSup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextSup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSup.Location = New System.Drawing.Point(118, 119)
        Me.TextSup.Name = "TextSup"
        Me.TextSup.Size = New System.Drawing.Size(717, 23)
        Me.TextSup.TabIndex = 97
        '
        'TextKodeSup
        '
        Me.TextKodeSup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeSup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeSup.Location = New System.Drawing.Point(841, 119)
        Me.TextKodeSup.Name = "TextKodeSup"
        Me.TextKodeSup.Size = New System.Drawing.Size(100, 23)
        Me.TextKodeSup.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "QTY"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Supplier"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Nama Barang"
        '
        'TextKdBrgMasuk
        '
        Me.TextKdBrgMasuk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKdBrgMasuk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKdBrgMasuk.Location = New System.Drawing.Point(414, 56)
        Me.TextKdBrgMasuk.Name = "TextKdBrgMasuk"
        Me.TextKdBrgMasuk.Size = New System.Drawing.Size(234, 23)
        Me.TextKdBrgMasuk.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "ID Barang Masuk"
        '
        'DGbrgmasuk
        '
        Me.DGbrgmasuk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGbrgmasuk.BackgroundColor = System.Drawing.Color.White
        Me.DGbrgmasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGbrgmasuk.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGbrgmasuk.Location = New System.Drawing.Point(12, 454)
        Me.DGbrgmasuk.Name = "DGbrgmasuk"
        Me.DGbrgmasuk.Size = New System.Drawing.Size(1035, 170)
        Me.DGbrgmasuk.TabIndex = 88
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(429, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Pilih Nota PO :"
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
        Me.BtnTambah.TabIndex = 105
        Me.BtnTambah.Text = "    MASUK"
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
        Me.BtnSimpan.TabIndex = 104
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
        Me.BtnHapus.TabIndex = 103
        Me.BtnHapus.Text = "    HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'DGPembelian
        '
        Me.DGPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPembelian.BackgroundColor = System.Drawing.Color.White
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPembelian.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGPembelian.Location = New System.Drawing.Point(12, 275)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.Size = New System.Drawing.Size(1035, 170)
        Me.DGPembelian.TabIndex = 106
        '
        'TextIDDetail
        '
        Me.TextIDDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextIDDetail.Location = New System.Drawing.Point(414, 85)
        Me.TextIDDetail.Name = "TextIDDetail"
        Me.TextIDDetail.Size = New System.Drawing.Size(234, 22)
        Me.TextIDDetail.TabIndex = 109
        '
        'TextMasuk
        '
        Me.TextMasuk.Location = New System.Drawing.Point(12, 243)
        Me.TextMasuk.Name = "TextMasuk"
        Me.TextMasuk.Size = New System.Drawing.Size(100, 22)
        Me.TextMasuk.TabIndex = 110
        '
        'TextQTYBeli
        '
        Me.TextQTYBeli.Location = New System.Drawing.Point(12, 181)
        Me.TextQTYBeli.Name = "TextQTYBeli"
        Me.TextQTYBeli.Size = New System.Drawing.Size(100, 22)
        Me.TextQTYBeli.TabIndex = 110
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(12, 121)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(100, 22)
        Me.TextJumlah.TabIndex = 111
        '
        'TextNotaPembelian
        '
        Me.TextNotaPembelian.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNotaPembelian.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNotaPembelian.Location = New System.Drawing.Point(118, 56)
        Me.TextNotaPembelian.Name = "TextNotaPembelian"
        Me.TextNotaPembelian.Size = New System.Drawing.Size(234, 23)
        Me.TextNotaPembelian.TabIndex = 112
        '
        'TextKodeMskDetail
        '
        Me.TextKodeMskDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeMskDetail.Location = New System.Drawing.Point(707, 85)
        Me.TextKodeMskDetail.Name = "TextKodeMskDetail"
        Me.TextKodeMskDetail.Size = New System.Drawing.Size(234, 22)
        Me.TextKodeMskDetail.TabIndex = 113
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
        Me.BtnCariNotaBeli.TabIndex = 115
        Me.BtnCariNotaBeli.Text = "..."
        Me.BtnCariNotaBeli.UseVisualStyleBackColor = False
        '
        'TextKodeMskDetailVisible
        '
        Me.TextKodeMskDetailVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextKodeMskDetailVisible.Location = New System.Drawing.Point(947, 85)
        Me.TextKodeMskDetailVisible.Name = "TextKodeMskDetailVisible"
        Me.TextKodeMskDetailVisible.Size = New System.Drawing.Size(100, 22)
        Me.TextKodeMskDetailVisible.TabIndex = 114
        '
        'TextQTYVisible
        '
        Me.TextQTYVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextQTYVisible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYVisible.Location = New System.Drawing.Point(12, 56)
        Me.TextQTYVisible.Name = "TextQTYVisible"
        Me.TextQTYVisible.Size = New System.Drawing.Size(100, 23)
        Me.TextQTYVisible.TabIndex = 116
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
        Me.BtnClose.TabIndex = 135
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TextQTYVisible)
        Me.Controls.Add(Me.BtnCariNotaBeli)
        Me.Controls.Add(Me.TextKodeMskDetailVisible)
        Me.Controls.Add(Me.TextKodeMskDetail)
        Me.Controls.Add(Me.TextNotaPembelian)
        Me.Controls.Add(Me.TextJumlah)
        Me.Controls.Add(Me.TextQTYBeli)
        Me.Controls.Add(Me.TextMasuk)
        Me.Controls.Add(Me.TextIDDetail)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextNotaBrgMsk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextTotalStokMsk)
        Me.Controls.Add(Me.TextStok)
        Me.Controls.Add(Me.TextQTY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextKode)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.TextSup)
        Me.Controls.Add(Me.TextKodeSup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextKdBrgMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGbrgmasuk)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BarangMasuk"
        Me.Text = "BarangMasuk"
        CType(Me.DGbrgmasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextNotaBrgMsk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextTotalStokMsk As System.Windows.Forms.TextBox
    Friend WithEvents TextStok As System.Windows.Forms.TextBox
    Friend WithEvents TextQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextKode As System.Windows.Forms.TextBox
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextSup As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeSup As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextKdBrgMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGbrgmasuk As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents TextIDDetail As System.Windows.Forms.TextBox
    Friend WithEvents TextMasuk As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYBeli As System.Windows.Forms.TextBox
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TextNotaPembelian As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeMskDetail As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariNotaBeli As System.Windows.Forms.Button
    Friend WithEvents TextKodeMskDetailVisible As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYVisible As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
