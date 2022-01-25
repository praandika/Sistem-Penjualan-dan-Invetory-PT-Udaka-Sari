<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataReturPembelian
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataReturPembelian))
        Me.DGdatapembelian = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.TextDetail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.ComboxCari = New System.Windows.Forms.ComboBox()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.TextKdBrg = New System.Windows.Forms.TextBox()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.TextQTYRetur = New System.Windows.Forms.TextBox()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.ComboBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.TextQTYBrg = New System.Windows.Forms.TextBox()
        Me.TextQTYHasil = New System.Windows.Forms.TextBox()
        Me.BtnCetak1 = New System.Windows.Forms.Button()
        CType(Me.DGdatapembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGdatapembelian
        '
        Me.DGdatapembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGdatapembelian.BackgroundColor = System.Drawing.Color.White
        Me.DGdatapembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGdatapembelian.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGdatapembelian.Location = New System.Drawing.Point(9, 118)
        Me.DGdatapembelian.Name = "DGdatapembelian"
        Me.DGdatapembelian.Size = New System.Drawing.Size(1040, 488)
        Me.DGdatapembelian.TabIndex = 3
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
        Me.BtnClose.TabIndex = 134
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSelesai
        '
        Me.BtnSelesai.BackColor = System.Drawing.Color.Purple
        Me.BtnSelesai.FlatAppearance.BorderSize = 0
        Me.BtnSelesai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.BtnSelesai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelesai.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesai.ForeColor = System.Drawing.Color.White
        Me.BtnSelesai.Image = CType(resources.GetObject("BtnSelesai.Image"), System.Drawing.Image)
        Me.BtnSelesai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelesai.Location = New System.Drawing.Point(433, 63)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(120, 35)
        Me.BtnSelesai.TabIndex = 133
        Me.BtnSelesai.Text = "    SELESAI"
        Me.BtnSelesai.UseVisualStyleBackColor = False
        '
        'TextDetail
        '
        Me.TextDetail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextDetail.Location = New System.Drawing.Point(433, 29)
        Me.TextDetail.Name = "TextDetail"
        Me.TextDetail.Size = New System.Drawing.Size(120, 22)
        Me.TextDetail.TabIndex = 132
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1026, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 131
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(225, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker2.TabIndex = 129
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker1.TabIndex = 128
        '
        'BtnCari
        '
        Me.BtnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCari.FlatAppearance.BorderSize = 0
        Me.BtnCari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.BtnCari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.ForeColor = System.Drawing.Color.White
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(9, 63)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(399, 35)
        Me.BtnCari.TabIndex = 127
        Me.BtnCari.Text = "   CARI"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'ComboxCari
        '
        Me.ComboxCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboxCari.FormattingEnabled = True
        Me.ComboxCari.Items.AddRange(New Object() {"Nama Barang", "Nama Supplier"})
        Me.ComboxCari.Location = New System.Drawing.Point(819, 47)
        Me.ComboxCari.Name = "ComboxCari"
        Me.ComboxCari.Size = New System.Drawing.Size(145, 22)
        Me.ComboxCari.TabIndex = 126
        '
        'TextCari
        '
        Me.TextCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(819, 75)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(229, 23)
        Me.TextCari.TabIndex = 125
        '
        'TextKdBrg
        '
        Me.TextKdBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKdBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextKdBrg.Location = New System.Drawing.Point(433, 4)
        Me.TextKdBrg.Name = "TextKdBrg"
        Me.TextKdBrg.Size = New System.Drawing.Size(120, 22)
        Me.TextKdBrg.TabIndex = 135
        Me.TextKdBrg.Visible = False
        '
        'TextBrg
        '
        Me.TextBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextBrg.Location = New System.Drawing.Point(970, 47)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(77, 22)
        Me.TextBrg.TabIndex = 139
        Me.TextBrg.Visible = False
        '
        'TextQTYRetur
        '
        Me.TextQTYRetur.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYRetur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYRetur.Location = New System.Drawing.Point(567, 4)
        Me.TextQTYRetur.Name = "TextQTYRetur"
        Me.TextQTYRetur.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYRetur.TabIndex = 137
        Me.TextQTYRetur.Visible = False
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnCetak.FlatAppearance.BorderSize = 0
        Me.BtnCetak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCetak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.ForeColor = System.Drawing.Color.White
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetak.Location = New System.Drawing.Point(567, 63)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(120, 35)
        Me.BtnCetak.TabIndex = 140
        Me.BtnCetak.Text = "  NOTA"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'ComboBoxSupplier
        '
        Me.ComboBoxSupplier.FormattingEnabled = True
        Me.ComboBoxSupplier.Location = New System.Drawing.Point(566, 29)
        Me.ComboBoxSupplier.Name = "ComboBoxSupplier"
        Me.ComboBoxSupplier.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxSupplier.TabIndex = 141
        '
        'TextQTYBrg
        '
        Me.TextQTYBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYBrg.Location = New System.Drawing.Point(693, 4)
        Me.TextQTYBrg.Name = "TextQTYBrg"
        Me.TextQTYBrg.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYBrg.TabIndex = 142
        Me.TextQTYBrg.Visible = False
        '
        'TextQTYHasil
        '
        Me.TextQTYHasil.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYHasil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYHasil.Location = New System.Drawing.Point(819, 4)
        Me.TextQTYHasil.Name = "TextQTYHasil"
        Me.TextQTYHasil.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYHasil.TabIndex = 143
        Me.TextQTYHasil.Visible = False
        '
        'BtnCetak1
        '
        Me.BtnCetak1.BackColor = System.Drawing.Color.Teal
        Me.BtnCetak1.FlatAppearance.BorderSize = 0
        Me.BtnCetak1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCetak1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCetak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak1.ForeColor = System.Drawing.Color.White
        Me.BtnCetak1.Image = CType(resources.GetObject("BtnCetak1.Image"), System.Drawing.Image)
        Me.BtnCetak1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetak1.Location = New System.Drawing.Point(693, 63)
        Me.BtnCetak1.Name = "BtnCetak1"
        Me.BtnCetak1.Size = New System.Drawing.Size(120, 35)
        Me.BtnCetak1.TabIndex = 144
        Me.BtnCetak1.Text = "  CETAK"
        Me.BtnCetak1.UseVisualStyleBackColor = False
        '
        'DataReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.BtnCetak1)
        Me.Controls.Add(Me.TextQTYHasil)
        Me.Controls.Add(Me.TextQTYBrg)
        Me.Controls.Add(Me.ComboBoxSupplier)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.TextQTYRetur)
        Me.Controls.Add(Me.TextKdBrg)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSelesai)
        Me.Controls.Add(Me.TextDetail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.ComboxCari)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.DGdatapembelian)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataReturPembelian"
        Me.Text = "DataReturPembelian"
        CType(Me.DGdatapembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGdatapembelian As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSelesai As System.Windows.Forms.Button
    Friend WithEvents TextDetail As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents ComboxCari As System.Windows.Forms.ComboBox
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents TextKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYRetur As System.Windows.Forms.TextBox
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents TextQTYBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnCetak1 As System.Windows.Forms.Button
End Class
