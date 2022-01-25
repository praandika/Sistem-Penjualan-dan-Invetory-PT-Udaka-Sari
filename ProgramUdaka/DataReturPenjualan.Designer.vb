<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataReturPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataReturPenjualan))
        Me.DGdatareturpenjualan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.ComboxCari = New System.Windows.Forms.ComboBox()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.TextDetail = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TextKdBrg = New System.Windows.Forms.TextBox()
        Me.TextQTYBrg = New System.Windows.Forms.TextBox()
        Me.TextQTYRetur = New System.Windows.Forms.TextBox()
        Me.TextQTYHasil = New System.Windows.Forms.TextBox()
        Me.TextBrg = New System.Windows.Forms.TextBox()
        Me.BtnCetak1 = New System.Windows.Forms.Button()
        CType(Me.DGdatareturpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGdatareturpenjualan
        '
        Me.DGdatareturpenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGdatareturpenjualan.BackgroundColor = System.Drawing.Color.White
        Me.DGdatareturpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGdatareturpenjualan.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGdatareturpenjualan.Location = New System.Drawing.Point(9, 118)
        Me.DGdatareturpenjualan.Name = "DGdatareturpenjualan"
        Me.DGdatareturpenjualan.Size = New System.Drawing.Size(1040, 488)
        Me.DGdatareturpenjualan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(225, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker2.TabIndex = 119
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker1.TabIndex = 118
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
        Me.BtnCari.TabIndex = 117
        Me.BtnCari.Text = "   CARI"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'ComboxCari
        '
        Me.ComboxCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboxCari.FormattingEnabled = True
        Me.ComboxCari.Items.AddRange(New Object() {"Nama Barang", "Nama Pelanggan"})
        Me.ComboxCari.Location = New System.Drawing.Point(704, 29)
        Me.ComboxCari.Name = "ComboxCari"
        Me.ComboxCari.Size = New System.Drawing.Size(179, 22)
        Me.ComboxCari.TabIndex = 116
        '
        'TextCari
        '
        Me.TextCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(704, 75)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(344, 23)
        Me.TextCari.TabIndex = 115
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
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
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
        Me.BtnSelesai.TabIndex = 123
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
        Me.TextDetail.TabIndex = 122
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
        Me.BtnClose.TabIndex = 124
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TextKdBrg
        '
        Me.TextKdBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKdBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextKdBrg.Location = New System.Drawing.Point(433, 3)
        Me.TextKdBrg.Name = "TextKdBrg"
        Me.TextKdBrg.Size = New System.Drawing.Size(120, 22)
        Me.TextKdBrg.TabIndex = 125
        Me.TextKdBrg.Visible = False
        '
        'TextQTYBrg
        '
        Me.TextQTYBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYBrg.Location = New System.Drawing.Point(578, 3)
        Me.TextQTYBrg.Name = "TextQTYBrg"
        Me.TextQTYBrg.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYBrg.TabIndex = 126
        Me.TextQTYBrg.Visible = False
        '
        'TextQTYRetur
        '
        Me.TextQTYRetur.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYRetur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYRetur.Location = New System.Drawing.Point(704, 3)
        Me.TextQTYRetur.Name = "TextQTYRetur"
        Me.TextQTYRetur.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYRetur.TabIndex = 127
        Me.TextQTYRetur.Visible = False
        '
        'TextQTYHasil
        '
        Me.TextQTYHasil.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYHasil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextQTYHasil.Location = New System.Drawing.Point(830, 3)
        Me.TextQTYHasil.Name = "TextQTYHasil"
        Me.TextQTYHasil.Size = New System.Drawing.Size(120, 22)
        Me.TextQTYHasil.TabIndex = 128
        Me.TextQTYHasil.Visible = False
        '
        'TextBrg
        '
        Me.TextBrg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextBrg.Location = New System.Drawing.Point(889, 29)
        Me.TextBrg.Name = "TextBrg"
        Me.TextBrg.Size = New System.Drawing.Size(120, 22)
        Me.TextBrg.TabIndex = 129
        Me.TextBrg.Visible = False
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
        Me.BtnCetak1.Location = New System.Drawing.Point(569, 63)
        Me.BtnCetak1.Name = "BtnCetak1"
        Me.BtnCetak1.Size = New System.Drawing.Size(120, 35)
        Me.BtnCetak1.TabIndex = 145
        Me.BtnCetak1.Text = "  CETAK"
        Me.BtnCetak1.UseVisualStyleBackColor = False
        '
        'DataReturPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.BtnCetak1)
        Me.Controls.Add(Me.TextBrg)
        Me.Controls.Add(Me.TextQTYHasil)
        Me.Controls.Add(Me.TextQTYRetur)
        Me.Controls.Add(Me.TextQTYBrg)
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
        Me.Controls.Add(Me.DGdatareturpenjualan)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataReturPenjualan"
        Me.Text = "DataReturPenjualan"
        CType(Me.DGdatareturpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGdatareturpenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents ComboxCari As System.Windows.Forms.ComboBox
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSelesai As System.Windows.Forms.Button
    Friend WithEvents TextDetail As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TextKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYRetur As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYHasil As System.Windows.Forms.TextBox
    Friend WithEvents TextBrg As System.Windows.Forms.TextBox
    Friend WithEvents BtnCetak1 As System.Windows.Forms.Button
End Class
