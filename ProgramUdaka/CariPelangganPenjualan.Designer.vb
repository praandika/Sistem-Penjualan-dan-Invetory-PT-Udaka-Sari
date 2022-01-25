<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariPelangganPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariPelangganPenjualan))
        Me.Rb_Namapel = New System.Windows.Forms.RadioButton()
        Me.Rb_IDpel = New System.Windows.Forms.RadioButton()
        Me.TextPel = New System.Windows.Forms.TextBox()
        Me.TextKodePel = New System.Windows.Forms.TextBox()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.DGCariPelanggan = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGCariPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rb_Namapel
        '
        Me.Rb_Namapel.AutoSize = True
        Me.Rb_Namapel.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Namapel.Location = New System.Drawing.Point(131, 38)
        Me.Rb_Namapel.Name = "Rb_Namapel"
        Me.Rb_Namapel.Size = New System.Drawing.Size(140, 20)
        Me.Rb_Namapel.TabIndex = 58
        Me.Rb_Namapel.TabStop = True
        Me.Rb_Namapel.Text = "Nama Pelanggan"
        Me.Rb_Namapel.UseVisualStyleBackColor = True
        '
        'Rb_IDpel
        '
        Me.Rb_IDpel.AutoSize = True
        Me.Rb_IDpel.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_IDpel.Location = New System.Drawing.Point(12, 38)
        Me.Rb_IDpel.Name = "Rb_IDpel"
        Me.Rb_IDpel.Size = New System.Drawing.Size(113, 20)
        Me.Rb_IDpel.TabIndex = 57
        Me.Rb_IDpel.TabStop = True
        Me.Rb_IDpel.Text = "ID Pelanggan"
        Me.Rb_IDpel.UseVisualStyleBackColor = True
        '
        'TextPel
        '
        Me.TextPel.Location = New System.Drawing.Point(422, 36)
        Me.TextPel.Name = "TextPel"
        Me.TextPel.Size = New System.Drawing.Size(140, 22)
        Me.TextPel.TabIndex = 54
        Me.TextPel.Visible = False
        '
        'TextKodePel
        '
        Me.TextKodePel.Location = New System.Drawing.Point(277, 36)
        Me.TextKodePel.Name = "TextKodePel"
        Me.TextKodePel.Size = New System.Drawing.Size(139, 22)
        Me.TextKodePel.TabIndex = 55
        Me.TextKodePel.Visible = False
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(12, 64)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(550, 22)
        Me.TextCari.TabIndex = 56
        '
        'DGCariPelanggan
        '
        Me.DGCariPelanggan.BackgroundColor = System.Drawing.Color.White
        Me.DGCariPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCariPelanggan.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCariPelanggan.Location = New System.Drawing.Point(12, 91)
        Me.DGCariPelanggan.Name = "DGCariPelanggan"
        Me.DGCariPelanggan.Size = New System.Drawing.Size(551, 301)
        Me.DGCariPelanggan.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 372)
        Me.Panel3.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(573, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 372)
        Me.Panel2.TabIndex = 51
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
        Me.Panel1.TabIndex = 50
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
        Me.PanelHeader.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(232, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CARI PELANGGAN"
        '
        'CariPelangganPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 404)
        Me.Controls.Add(Me.Rb_Namapel)
        Me.Controls.Add(Me.Rb_IDpel)
        Me.Controls.Add(Me.TextPel)
        Me.Controls.Add(Me.TextKodePel)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.DGCariPelanggan)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CariPelangganPenjualan"
        Me.Text = "CariPelangganPenjualan"
        CType(Me.DGCariPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rb_Namapel As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_IDpel As System.Windows.Forms.RadioButton
    Friend WithEvents TextPel As System.Windows.Forms.TextBox
    Friend WithEvents TextKodePel As System.Windows.Forms.TextBox
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents DGCariPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
