<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPenjualanDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPenjualanDetail))
        Me.DGPenjualanDetail = New System.Windows.Forms.DataGridView()
        Me.TextDetail = New System.Windows.Forms.TextBox()
        Me.TextTgl = New System.Windows.Forms.TextBox()
        Me.TextJenisPembayaran = New System.Windows.Forms.TextBox()
        Me.TextGrandTotal = New System.Windows.Forms.TextBox()
        Me.TextJatuhTempo = New System.Windows.Forms.TextBox()
        Me.TextSttsTransaksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextCus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextPiutang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGPenjualanDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGPenjualanDetail
        '
        Me.DGPenjualanDetail.BackgroundColor = System.Drawing.Color.White
        Me.DGPenjualanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPenjualanDetail.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGPenjualanDetail.Location = New System.Drawing.Point(12, 340)
        Me.DGPenjualanDetail.Name = "DGPenjualanDetail"
        Me.DGPenjualanDetail.Size = New System.Drawing.Size(625, 228)
        Me.DGPenjualanDetail.TabIndex = 0
        '
        'TextDetail
        '
        Me.TextDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDetail.Location = New System.Drawing.Point(12, 63)
        Me.TextDetail.Name = "TextDetail"
        Me.TextDetail.Size = New System.Drawing.Size(232, 23)
        Me.TextDetail.TabIndex = 67
        '
        'TextTgl
        '
        Me.TextTgl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTgl.Location = New System.Drawing.Point(12, 120)
        Me.TextTgl.Name = "TextTgl"
        Me.TextTgl.Size = New System.Drawing.Size(232, 23)
        Me.TextTgl.TabIndex = 68
        '
        'TextJenisPembayaran
        '
        Me.TextJenisPembayaran.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJenisPembayaran.Location = New System.Drawing.Point(12, 242)
        Me.TextJenisPembayaran.Name = "TextJenisPembayaran"
        Me.TextJenisPembayaran.Size = New System.Drawing.Size(232, 23)
        Me.TextJenisPembayaran.TabIndex = 69
        '
        'TextGrandTotal
        '
        Me.TextGrandTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextGrandTotal.Location = New System.Drawing.Point(12, 180)
        Me.TextGrandTotal.Name = "TextGrandTotal"
        Me.TextGrandTotal.Size = New System.Drawing.Size(232, 23)
        Me.TextGrandTotal.TabIndex = 70
        '
        'TextJatuhTempo
        '
        Me.TextJatuhTempo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJatuhTempo.Location = New System.Drawing.Point(404, 120)
        Me.TextJatuhTempo.Name = "TextJatuhTempo"
        Me.TextJatuhTempo.Size = New System.Drawing.Size(232, 23)
        Me.TextJatuhTempo.TabIndex = 72
        '
        'TextSttsTransaksi
        '
        Me.TextSttsTransaksi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSttsTransaksi.Location = New System.Drawing.Point(404, 180)
        Me.TextSttsTransaksi.Name = "TextSttsTransaksi"
        Me.TextSttsTransaksi.Size = New System.Drawing.Size(232, 23)
        Me.TextSttsTransaksi.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "No. Nota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Tanggal Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Grand Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Jenis Pembayaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Jatuh Tempo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(402, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Status Transaksi"
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
        Me.BtnCetak.Location = New System.Drawing.Point(404, 290)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(232, 35)
        Me.BtnCetak.TabIndex = 82
        Me.BtnCetak.Text = "  CETAK"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 548)
        Me.Panel3.TabIndex = 86
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(647, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 548)
        Me.Panel2.TabIndex = 85
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 578)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 2)
        Me.Panel1.TabIndex = 84
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.BtnMinimize)
        Me.PanelHeader.Controls.Add(Me.Picudakadatabarang)
        Me.PanelHeader.Controls.Add(Me.BtnClose)
        Me.PanelHeader.Controls.Add(Me.Label8)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(649, 30)
        Me.PanelHeader.TabIndex = 83
        '
        'BtnMinimize
        '
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.ForeColor = System.Drawing.Color.White
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMinimize.Location = New System.Drawing.Point(592, 3)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(23, 23)
        Me.BtnMinimize.TabIndex = 0
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'Picudakadatabarang
        '
        Me.Picudakadatabarang.BackColor = System.Drawing.Color.Transparent
        Me.Picudakadatabarang.Image = CType(resources.GetObject("Picudakadatabarang.Image"), System.Drawing.Image)
        Me.Picudakadatabarang.Location = New System.Drawing.Point(3, 1)
        Me.Picudakadatabarang.Name = "Picudakadatabarang"
        Me.Picudakadatabarang.Size = New System.Drawing.Size(21, 26)
        Me.Picudakadatabarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picudakadatabarang.TabIndex = 36
        Me.Picudakadatabarang.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(621, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(23, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(253, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "DETAIL PENJUALAN"
        '
        'TextCus
        '
        Me.TextCus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCus.Location = New System.Drawing.Point(404, 63)
        Me.TextCus.Name = "TextCus"
        Me.TextCus.Size = New System.Drawing.Size(232, 23)
        Me.TextCus.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(404, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Pelanggan"
        '
        'TextPiutang
        '
        Me.TextPiutang.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPiutang.Location = New System.Drawing.Point(404, 242)
        Me.TextPiutang.Name = "TextPiutang"
        Me.TextPiutang.Size = New System.Drawing.Size(232, 23)
        Me.TextPiutang.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(404, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Sisa Kredit"
        '
        'DataPenjualanDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(649, 580)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextSttsTransaksi)
        Me.Controls.Add(Me.TextJatuhTempo)
        Me.Controls.Add(Me.TextGrandTotal)
        Me.Controls.Add(Me.TextPiutang)
        Me.Controls.Add(Me.TextCus)
        Me.Controls.Add(Me.TextJenisPembayaran)
        Me.Controls.Add(Me.TextTgl)
        Me.Controls.Add(Me.TextDetail)
        Me.Controls.Add(Me.DGPenjualanDetail)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataPenjualanDetail"
        Me.Text = "Detail Penjualan"
        CType(Me.DGPenjualanDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGPenjualanDetail As System.Windows.Forms.DataGridView
    Friend WithEvents TextDetail As System.Windows.Forms.TextBox
    Friend WithEvents TextTgl As System.Windows.Forms.TextBox
    Friend WithEvents TextJenisPembayaran As System.Windows.Forms.TextBox
    Friend WithEvents TextGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextJatuhTempo As System.Windows.Forms.TextBox
    Friend WithEvents TextSttsTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextCus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextPiutang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
