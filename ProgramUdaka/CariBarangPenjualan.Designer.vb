<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariBarangPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariBarangPenjualan))
        Me.Rb_Namabrg = New System.Windows.Forms.RadioButton()
        Me.Rb_IDbrg = New System.Windows.Forms.RadioButton()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.TextKodeBrg = New System.Windows.Forms.TextBox()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.DGCariBarang = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHrgJual = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        CType(Me.DGCariBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rb_Namabrg
        '
        Me.Rb_Namabrg.AutoSize = True
        Me.Rb_Namabrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Namabrg.Location = New System.Drawing.Point(110, 58)
        Me.Rb_Namabrg.Name = "Rb_Namabrg"
        Me.Rb_Namabrg.Size = New System.Drawing.Size(118, 20)
        Me.Rb_Namabrg.TabIndex = 64
        Me.Rb_Namabrg.TabStop = True
        Me.Rb_Namabrg.Text = "Nama Barang"
        Me.Rb_Namabrg.UseVisualStyleBackColor = True
        '
        'Rb_IDbrg
        '
        Me.Rb_IDbrg.AutoSize = True
        Me.Rb_IDbrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_IDbrg.Location = New System.Drawing.Point(13, 57)
        Me.Rb_IDbrg.Name = "Rb_IDbrg"
        Me.Rb_IDbrg.Size = New System.Drawing.Size(91, 20)
        Me.Rb_IDbrg.TabIndex = 63
        Me.Rb_IDbrg.TabStop = True
        Me.Rb_IDbrg.Text = "ID Barang"
        Me.Rb_IDbrg.UseVisualStyleBackColor = True
        '
        'TextBrg
        '
        Me.TextBrg.Location = New System.Drawing.Point(473, 33)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(90, 23)
        Me.TextBrg.TabIndex = 62
        Me.TextBrg.Visible = False
        '
        'TextKodeBrg
        '
        Me.TextKodeBrg.Location = New System.Drawing.Point(383, 33)
        Me.TextKodeBrg.Name = "TextKodeBrg"
        Me.TextKodeBrg.Size = New System.Drawing.Size(90, 23)
        Me.TextKodeBrg.TabIndex = 60
        Me.TextKodeBrg.Visible = False
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(234, 59)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(328, 23)
        Me.TextCari.TabIndex = 61
        '
        'DGCariBarang
        '
        Me.DGCariBarang.BackgroundColor = System.Drawing.Color.White
        Me.DGCariBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCariBarang.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCariBarang.Location = New System.Drawing.Point(12, 91)
        Me.DGCariBarang.Name = "DGCariBarang"
        Me.DGCariBarang.Size = New System.Drawing.Size(551, 301)
        Me.DGCariBarang.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 372)
        Me.Panel3.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(573, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 372)
        Me.Panel2.TabIndex = 57
        '
        'BtnMinimize
        '
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.ForeColor = System.Drawing.Color.White
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMinimize.Location = New System.Drawing.Point(520, 4)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(23, 23)
        Me.BtnMinimize.TabIndex = 0
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 2)
        Me.Panel1.TabIndex = 56
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
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(549, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(23, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.BtnMinimize)
        Me.PanelHeader.Controls.Add(Me.Picudakadatabarang)
        Me.PanelHeader.Controls.Add(Me.BtnClose)
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(575, 30)
        Me.PanelHeader.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(231, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CARI BARANG"
        '
        'TxtHrgJual
        '
        Me.TxtHrgJual.Location = New System.Drawing.Point(293, 33)
        Me.TxtHrgJual.Name = "TxtHrgJual"
        Me.TxtHrgJual.Size = New System.Drawing.Size(90, 23)
        Me.TxtHrgJual.TabIndex = 65
        Me.TxtHrgJual.Visible = False
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(203, 33)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(90, 23)
        Me.TxtStok.TabIndex = 66
        Me.TxtStok.Visible = False
        '
        'CariBarangPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 404)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtHrgJual)
        Me.Controls.Add(Me.Rb_Namabrg)
        Me.Controls.Add(Me.Rb_IDbrg)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.TextKodeBrg)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.DGCariBarang)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CariBarangPenjualan"
        Me.Text = "CariBarangPenjualan"
        CType(Me.DGCariBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rb_Namabrg As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_IDbrg As System.Windows.Forms.RadioButton
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents DGCariBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtHrgJual As System.Windows.Forms.TextBox
    Friend WithEvents TxtStok As System.Windows.Forms.TextBox
End Class
