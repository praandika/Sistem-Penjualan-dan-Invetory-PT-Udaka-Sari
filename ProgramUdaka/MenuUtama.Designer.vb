<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SideBar = New System.Windows.Forms.Panel()
        Me.LblChart = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.BtnBarangMasuk = New System.Windows.Forms.Button()
        Me.BtnDataPembelian = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.SideButton = New System.Windows.Forms.Panel()
        Me.BtnStokOpname = New System.Windows.Forms.Button()
        Me.BtnRetur = New System.Windows.Forms.Button()
        Me.BtnCatatanPembayaran = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.BtnDataPendapatan = New System.Windows.Forms.Button()
        Me.BtnDataPenjualan = New System.Windows.Forms.Button()
        Me.BtnDataSupplier = New System.Windows.Forms.Button()
        Me.BtnDataPelanggan = New System.Windows.Forms.Button()
        Me.BtnDataBarang = New System.Windows.Forms.Button()
        Me.BtnStatus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelHakAkses = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BtnHamburger = New System.Windows.Forms.Button()
        Me.TopNav = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLeft = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnMaximize = New System.Windows.Forms.Button()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.BtnNormal = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnAkunSetting = New System.Windows.Forms.Button()
        Me.Content = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SideBar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer.SuspendLayout()
        Me.TopNav.SuspendLayout()
        Me.FlowLeft.SuspendLayout()
        Me.PanelRight.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Content.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SideBar.Controls.Add(Me.LblChart)
        Me.SideBar.Controls.Add(Me.LabelUsername)
        Me.SideBar.Controls.Add(Me.BtnBarangMasuk)
        Me.SideBar.Controls.Add(Me.BtnDataPembelian)
        Me.SideBar.Controls.Add(Me.Panel1)
        Me.SideBar.Controls.Add(Me.PictureBox3)
        Me.SideBar.Controls.Add(Me.LabelNama)
        Me.SideBar.Controls.Add(Me.SideButton)
        Me.SideBar.Controls.Add(Me.BtnStokOpname)
        Me.SideBar.Controls.Add(Me.BtnRetur)
        Me.SideBar.Controls.Add(Me.BtnCatatanPembayaran)
        Me.SideBar.Controls.Add(Me.BtnPembelian)
        Me.SideBar.Controls.Add(Me.BtnPenjualan)
        Me.SideBar.Controls.Add(Me.BtnDataPendapatan)
        Me.SideBar.Controls.Add(Me.BtnDataPenjualan)
        Me.SideBar.Controls.Add(Me.BtnDataSupplier)
        Me.SideBar.Controls.Add(Me.BtnDataPelanggan)
        Me.SideBar.Controls.Add(Me.BtnDataBarang)
        Me.SideBar.Controls.Add(Me.BtnStatus)
        Me.SideBar.Controls.Add(Me.PictureBox1)
        Me.SideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar.Location = New System.Drawing.Point(0, 0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(250, 700)
        Me.SideBar.TabIndex = 0
        '
        'LblChart
        '
        Me.LblChart.AutoSize = True
        Me.LblChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LblChart.Location = New System.Drawing.Point(201, 111)
        Me.LblChart.Name = "LblChart"
        Me.LblChart.Size = New System.Drawing.Size(43, 14)
        Me.LblChart.TabIndex = 7
        Me.LblChart.Text = "Label1"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.White
        Me.LabelUsername.Location = New System.Drawing.Point(87, 110)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(35, 15)
        Me.LabelUsername.TabIndex = 4
        Me.LabelUsername.Text = "Nama"
        '
        'BtnBarangMasuk
        '
        Me.BtnBarangMasuk.FlatAppearance.BorderSize = 0
        Me.BtnBarangMasuk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnBarangMasuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarangMasuk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarangMasuk.ForeColor = System.Drawing.Color.White
        Me.BtnBarangMasuk.Image = CType(resources.GetObject("BtnBarangMasuk.Image"), System.Drawing.Image)
        Me.BtnBarangMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarangMasuk.Location = New System.Drawing.Point(21, 525)
        Me.BtnBarangMasuk.Name = "BtnBarangMasuk"
        Me.BtnBarangMasuk.Size = New System.Drawing.Size(228, 40)
        Me.BtnBarangMasuk.TabIndex = 1
        Me.BtnBarangMasuk.Text = "        Barang Masuk / Keluar"
        Me.BtnBarangMasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBarangMasuk.UseVisualStyleBackColor = True
        '
        'BtnDataPembelian
        '
        Me.BtnDataPembelian.FlatAppearance.BorderSize = 0
        Me.BtnDataPembelian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataPembelian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataPembelian.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataPembelian.ForeColor = System.Drawing.Color.White
        Me.BtnDataPembelian.Image = CType(resources.GetObject("BtnDataPembelian.Image"), System.Drawing.Image)
        Me.BtnDataPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataPembelian.Location = New System.Drawing.Point(21, 353)
        Me.BtnDataPembelian.Name = "BtnDataPembelian"
        Me.BtnDataPembelian.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataPembelian.TabIndex = 2
        Me.BtnDataPembelian.Text = "        Data Purchase Order"
        Me.BtnDataPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataPembelian.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 3)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(23, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.BackColor = System.Drawing.Color.Transparent
        Me.LabelNama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelNama.Font = New System.Drawing.Font("Exotc350 Bd BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.ForeColor = System.Drawing.Color.White
        Me.LabelNama.Location = New System.Drawing.Point(84, 85)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(56, 25)
        Me.LabelNama.TabIndex = 2
        Me.LabelNama.Text = "Nama"
        '
        'SideButton
        '
        Me.SideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SideButton.Location = New System.Drawing.Point(3, 138)
        Me.SideButton.Name = "SideButton"
        Me.SideButton.Size = New System.Drawing.Size(15, 40)
        Me.SideButton.TabIndex = 0
        '
        'BtnStokOpname
        '
        Me.BtnStokOpname.FlatAppearance.BorderSize = 0
        Me.BtnStokOpname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnStokOpname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnStokOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStokOpname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStokOpname.ForeColor = System.Drawing.Color.White
        Me.BtnStokOpname.Image = CType(resources.GetObject("BtnStokOpname.Image"), System.Drawing.Image)
        Me.BtnStokOpname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStokOpname.Location = New System.Drawing.Point(21, 654)
        Me.BtnStokOpname.Name = "BtnStokOpname"
        Me.BtnStokOpname.Size = New System.Drawing.Size(228, 40)
        Me.BtnStokOpname.TabIndex = 1
        Me.BtnStokOpname.Text = "        Stok Opname"
        Me.BtnStokOpname.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStokOpname.UseVisualStyleBackColor = True
        '
        'BtnRetur
        '
        Me.BtnRetur.FlatAppearance.BorderSize = 0
        Me.BtnRetur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnRetur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetur.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetur.ForeColor = System.Drawing.Color.White
        Me.BtnRetur.Image = CType(resources.GetObject("BtnRetur.Image"), System.Drawing.Image)
        Me.BtnRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRetur.Location = New System.Drawing.Point(21, 611)
        Me.BtnRetur.Name = "BtnRetur"
        Me.BtnRetur.Size = New System.Drawing.Size(228, 40)
        Me.BtnRetur.TabIndex = 1
        Me.BtnRetur.Text = "        Retur"
        Me.BtnRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRetur.UseVisualStyleBackColor = True
        '
        'BtnCatatanPembayaran
        '
        Me.BtnCatatanPembayaran.FlatAppearance.BorderSize = 0
        Me.BtnCatatanPembayaran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCatatanPembayaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnCatatanPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatatanPembayaran.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatatanPembayaran.ForeColor = System.Drawing.Color.White
        Me.BtnCatatanPembayaran.Image = CType(resources.GetObject("BtnCatatanPembayaran.Image"), System.Drawing.Image)
        Me.BtnCatatanPembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatatanPembayaran.Location = New System.Drawing.Point(21, 568)
        Me.BtnCatatanPembayaran.Name = "BtnCatatanPembayaran"
        Me.BtnCatatanPembayaran.Size = New System.Drawing.Size(228, 40)
        Me.BtnCatatanPembayaran.TabIndex = 1
        Me.BtnCatatanPembayaran.Text = "        Catatan Pembayaran"
        Me.BtnCatatanPembayaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCatatanPembayaran.UseVisualStyleBackColor = True
        '
        'BtnPembelian
        '
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnPembelian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPembelian.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPembelian.ForeColor = System.Drawing.Color.White
        Me.BtnPembelian.Image = CType(resources.GetObject("BtnPembelian.Image"), System.Drawing.Image)
        Me.BtnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPembelian.Location = New System.Drawing.Point(21, 482)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(228, 40)
        Me.BtnPembelian.TabIndex = 1
        Me.BtnPembelian.Text = "        Purchase Order"
        Me.BtnPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPembelian.UseVisualStyleBackColor = True
        '
        'BtnPenjualan
        '
        Me.BtnPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnPenjualan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPenjualan.ForeColor = System.Drawing.Color.White
        Me.BtnPenjualan.Image = CType(resources.GetObject("BtnPenjualan.Image"), System.Drawing.Image)
        Me.BtnPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPenjualan.Location = New System.Drawing.Point(21, 439)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Size = New System.Drawing.Size(228, 40)
        Me.BtnPenjualan.TabIndex = 1
        Me.BtnPenjualan.Text = "        Penjualan"
        Me.BtnPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPenjualan.UseVisualStyleBackColor = True
        '
        'BtnDataPendapatan
        '
        Me.BtnDataPendapatan.FlatAppearance.BorderSize = 0
        Me.BtnDataPendapatan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataPendapatan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataPendapatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataPendapatan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataPendapatan.ForeColor = System.Drawing.Color.White
        Me.BtnDataPendapatan.Image = CType(resources.GetObject("BtnDataPendapatan.Image"), System.Drawing.Image)
        Me.BtnDataPendapatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataPendapatan.Location = New System.Drawing.Point(21, 396)
        Me.BtnDataPendapatan.Name = "BtnDataPendapatan"
        Me.BtnDataPendapatan.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataPendapatan.TabIndex = 1
        Me.BtnDataPendapatan.Text = "        Data Pendapatan"
        Me.BtnDataPendapatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataPendapatan.UseVisualStyleBackColor = True
        '
        'BtnDataPenjualan
        '
        Me.BtnDataPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnDataPenjualan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataPenjualan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataPenjualan.ForeColor = System.Drawing.Color.White
        Me.BtnDataPenjualan.Image = CType(resources.GetObject("BtnDataPenjualan.Image"), System.Drawing.Image)
        Me.BtnDataPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataPenjualan.Location = New System.Drawing.Point(21, 310)
        Me.BtnDataPenjualan.Name = "BtnDataPenjualan"
        Me.BtnDataPenjualan.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataPenjualan.TabIndex = 1
        Me.BtnDataPenjualan.Text = "        Data Penjualan"
        Me.BtnDataPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataPenjualan.UseVisualStyleBackColor = True
        '
        'BtnDataSupplier
        '
        Me.BtnDataSupplier.FlatAppearance.BorderSize = 0
        Me.BtnDataSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataSupplier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataSupplier.ForeColor = System.Drawing.Color.White
        Me.BtnDataSupplier.Image = CType(resources.GetObject("BtnDataSupplier.Image"), System.Drawing.Image)
        Me.BtnDataSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataSupplier.Location = New System.Drawing.Point(21, 267)
        Me.BtnDataSupplier.Name = "BtnDataSupplier"
        Me.BtnDataSupplier.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataSupplier.TabIndex = 1
        Me.BtnDataSupplier.Text = "        Data Supplier"
        Me.BtnDataSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataSupplier.UseVisualStyleBackColor = True
        '
        'BtnDataPelanggan
        '
        Me.BtnDataPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnDataPelanggan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataPelanggan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataPelanggan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataPelanggan.ForeColor = System.Drawing.Color.White
        Me.BtnDataPelanggan.Image = CType(resources.GetObject("BtnDataPelanggan.Image"), System.Drawing.Image)
        Me.BtnDataPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataPelanggan.Location = New System.Drawing.Point(21, 224)
        Me.BtnDataPelanggan.Name = "BtnDataPelanggan"
        Me.BtnDataPelanggan.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataPelanggan.TabIndex = 1
        Me.BtnDataPelanggan.Text = "        Data Pelanggan"
        Me.BtnDataPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataPelanggan.UseVisualStyleBackColor = True
        '
        'BtnDataBarang
        '
        Me.BtnDataBarang.FlatAppearance.BorderSize = 0
        Me.BtnDataBarang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnDataBarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDataBarang.ForeColor = System.Drawing.Color.White
        Me.BtnDataBarang.Image = CType(resources.GetObject("BtnDataBarang.Image"), System.Drawing.Image)
        Me.BtnDataBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataBarang.Location = New System.Drawing.Point(21, 181)
        Me.BtnDataBarang.Name = "BtnDataBarang"
        Me.BtnDataBarang.Size = New System.Drawing.Size(228, 40)
        Me.BtnDataBarang.TabIndex = 1
        Me.BtnDataBarang.Text = "        Data Barang"
        Me.BtnDataBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDataBarang.UseVisualStyleBackColor = True
        '
        'BtnStatus
        '
        Me.BtnStatus.FlatAppearance.BorderSize = 0
        Me.BtnStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatus.ForeColor = System.Drawing.Color.White
        Me.BtnStatus.Image = CType(resources.GetObject("BtnStatus.Image"), System.Drawing.Image)
        Me.BtnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStatus.Location = New System.Drawing.Point(21, 138)
        Me.BtnStatus.Name = "BtnStatus"
        Me.BtnStatus.Size = New System.Drawing.Size(228, 40)
        Me.BtnStatus.TabIndex = 1
        Me.BtnStatus.Text = "        Informasi"
        Me.BtnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStatus.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Footer
        '
        Me.Footer.BackColor = System.Drawing.Color.White
        Me.Footer.Controls.Add(Me.Label1)
        Me.Footer.Controls.Add(Me.DateTimePicker1)
        Me.Footer.Controls.Add(Me.LabelHakAkses)
        Me.Footer.Controls.Add(Me.ToolStripStatusLabel2)
        Me.Footer.Controls.Add(Me.ToolStripStatusLabel1)
        Me.Footer.Controls.Add(Me.StatusStrip1)
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.Location = New System.Drawing.Point(250, 675)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(1059, 25)
        Me.Footer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(882, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hak Akses :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(641, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'LabelHakAkses
        '
        Me.LabelHakAkses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHakAkses.AutoSize = True
        Me.LabelHakAkses.BackColor = System.Drawing.Color.Transparent
        Me.LabelHakAkses.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHakAkses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelHakAkses.Location = New System.Drawing.Point(938, 4)
        Me.LabelHakAkses.Name = "LabelHakAkses"
        Me.LabelHakAkses.Size = New System.Drawing.Size(53, 15)
        Me.LabelHakAkses.TabIndex = 3
        Me.LabelHakAkses.Text = "Hak Akses"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = True
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ToolStripStatusLabel2.Location = New System.Drawing.Point(197, 4)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(140, 16)
        Me.ToolStripStatusLabel2.TabIndex = 2
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = True
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ToolStripStatusLabel1.Location = New System.Drawing.Point(6, 4)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 16)
        Me.ToolStripStatusLabel1.TabIndex = 1
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 3)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1059, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BtnHamburger
        '
        Me.BtnHamburger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHamburger.FlatAppearance.BorderSize = 0
        Me.BtnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue
        Me.BtnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHamburger.Image = CType(resources.GetObject("BtnHamburger.Image"), System.Drawing.Image)
        Me.BtnHamburger.Location = New System.Drawing.Point(3, 3)
        Me.BtnHamburger.Name = "BtnHamburger"
        Me.BtnHamburger.Size = New System.Drawing.Size(39, 33)
        Me.BtnHamburger.TabIndex = 0
        Me.BtnHamburger.UseVisualStyleBackColor = True
        '
        'TopNav
        '
        Me.TopNav.ColumnCount = 2
        Me.TopNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TopNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TopNav.Controls.Add(Me.FlowLeft, 0, 0)
        Me.TopNav.Controls.Add(Me.PanelRight, 1, 0)
        Me.TopNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopNav.Location = New System.Drawing.Point(250, 0)
        Me.TopNav.Margin = New System.Windows.Forms.Padding(0)
        Me.TopNav.Name = "TopNav"
        Me.TopNav.RowCount = 1
        Me.TopNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopNav.Size = New System.Drawing.Size(1059, 40)
        Me.TopNav.TabIndex = 2
        '
        'FlowLeft
        '
        Me.FlowLeft.BackColor = System.Drawing.Color.CadetBlue
        Me.FlowLeft.Controls.Add(Me.BtnHamburger)
        Me.FlowLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLeft.Location = New System.Drawing.Point(0, 0)
        Me.FlowLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLeft.Name = "FlowLeft"
        Me.FlowLeft.Size = New System.Drawing.Size(317, 40)
        Me.FlowLeft.TabIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRight.BackColor = System.Drawing.Color.Teal
        Me.PanelRight.Controls.Add(Me.PictureBox4)
        Me.PanelRight.Controls.Add(Me.BtnMaximize)
        Me.PanelRight.Controls.Add(Me.LblHeader)
        Me.PanelRight.Controls.Add(Me.BtnNormal)
        Me.PanelRight.Controls.Add(Me.BtnLogout)
        Me.PanelRight.Controls.Add(Me.BtnMinimize)
        Me.PanelRight.Controls.Add(Me.BtnAkunSetting)
        Me.PanelRight.Location = New System.Drawing.Point(317, 0)
        Me.PanelRight.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(742, 40)
        Me.PanelRight.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'BtnMaximize
        '
        Me.BtnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximize.FlatAppearance.BorderSize = 0
        Me.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximize.Image = CType(resources.GetObject("BtnMaximize.Image"), System.Drawing.Image)
        Me.BtnMaximize.Location = New System.Drawing.Point(666, 3)
        Me.BtnMaximize.Name = "BtnMaximize"
        Me.BtnMaximize.Size = New System.Drawing.Size(29, 35)
        Me.BtnMaximize.TabIndex = 1
        Me.BtnMaximize.UseVisualStyleBackColor = True
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(32, 8)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(67, 25)
        Me.LblHeader.TabIndex = 7
        Me.LblHeader.Text = "Label"
        '
        'BtnNormal
        '
        Me.BtnNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNormal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNormal.FlatAppearance.BorderSize = 0
        Me.BtnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BtnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BtnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNormal.Image = CType(resources.GetObject("BtnNormal.Image"), System.Drawing.Image)
        Me.BtnNormal.Location = New System.Drawing.Point(666, 3)
        Me.BtnNormal.Name = "BtnNormal"
        Me.BtnNormal.Size = New System.Drawing.Size(30, 35)
        Me.BtnNormal.TabIndex = 6
        Me.BtnNormal.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink
        Me.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.Location = New System.Drawing.Point(702, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(35, 35)
        Me.BtnLogout.TabIndex = 0
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(630, 3)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(30, 35)
        Me.BtnMinimize.TabIndex = 5
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnAkunSetting
        '
        Me.BtnAkunSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAkunSetting.BackColor = System.Drawing.Color.Transparent
        Me.BtnAkunSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAkunSetting.FlatAppearance.BorderSize = 0
        Me.BtnAkunSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.BtnAkunSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.BtnAkunSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAkunSetting.Image = CType(resources.GetObject("BtnAkunSetting.Image"), System.Drawing.Image)
        Me.BtnAkunSetting.Location = New System.Drawing.Point(589, 2)
        Me.BtnAkunSetting.Name = "BtnAkunSetting"
        Me.BtnAkunSetting.Size = New System.Drawing.Size(35, 35)
        Me.BtnAkunSetting.TabIndex = 0
        Me.BtnAkunSetting.UseVisualStyleBackColor = False
        '
        'Content
        '
        Me.Content.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Content.Controls.Add(Me.PictureBox2)
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Content.Location = New System.Drawing.Point(250, 40)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1059, 635)
        Me.Content.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(279, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1309, 700)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.TopNav)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.SideBar)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideBar.ResumeLayout(False)
        Me.SideBar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        Me.TopNav.ResumeLayout(False)
        Me.FlowLeft.ResumeLayout(False)
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Content.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SideBar As System.Windows.Forms.Panel
    Friend WithEvents Footer As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SideButton As System.Windows.Forms.Panel
    Friend WithEvents BtnStokOpname As System.Windows.Forms.Button
    Friend WithEvents BtnRetur As System.Windows.Forms.Button
    Friend WithEvents BtnCatatanPembayaran As System.Windows.Forms.Button
    Friend WithEvents BtnPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnPenjualan As System.Windows.Forms.Button
    Friend WithEvents BtnDataPendapatan As System.Windows.Forms.Button
    Friend WithEvents BtnDataPenjualan As System.Windows.Forms.Button
    Friend WithEvents BtnDataSupplier As System.Windows.Forms.Button
    Friend WithEvents BtnDataPelanggan As System.Windows.Forms.Button
    Friend WithEvents BtnDataBarang As System.Windows.Forms.Button
    Friend WithEvents BtnStatus As System.Windows.Forms.Button
    Friend WithEvents BtnHamburger As System.Windows.Forms.Button
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents TopNav As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLeft As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Content As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents BtnAkunSetting As System.Windows.Forms.Button
    Friend WithEvents LabelHakAkses As System.Windows.Forms.Label
    Friend WithEvents BtnMaximize As System.Windows.Forms.Button
    Friend WithEvents BtnNormal As System.Windows.Forms.Button
    Friend WithEvents BtnDataPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnBarangMasuk As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents LblChart As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
