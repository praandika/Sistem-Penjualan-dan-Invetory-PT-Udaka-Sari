<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarReturPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarReturPembelian))
        Me.DGdatapembelian = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.ComboxCari = New System.Windows.Forms.ComboBox()
        Me.BtnRetur = New System.Windows.Forms.Button()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.TextDetail = New System.Windows.Forms.TextBox()
        Me.TextSisa = New System.Windows.Forms.TextBox()
        Me.TextBayar = New System.Windows.Forms.TextBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextKodeSup = New System.Windows.Forms.TextBox()
        Me.TextKodePembelian = New System.Windows.Forms.TextBox()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGdatapembelian.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGdatapembelian.Location = New System.Drawing.Point(9, 118)
        Me.DGdatapembelian.Name = "DGdatapembelian"
        Me.DGdatapembelian.Size = New System.Drawing.Size(1040, 488)
        Me.DGdatapembelian.TabIndex = 2
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
        Me.BtnClose.TabIndex = 126
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(225, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker2.TabIndex = 123
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(183, 22)
        Me.DateTimePicker1.TabIndex = 122
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
        Me.BtnCari.TabIndex = 121
        Me.BtnCari.Text = "   CARI"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'ComboxCari
        '
        Me.ComboxCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboxCari.FormattingEnabled = True
        Me.ComboxCari.Items.AddRange(New Object() {"No Nota", "Jenis Pembayaran", "Nama Supplier"})
        Me.ComboxCari.Location = New System.Drawing.Point(578, 29)
        Me.ComboxCari.Name = "ComboxCari"
        Me.ComboxCari.Size = New System.Drawing.Size(183, 22)
        Me.ComboxCari.TabIndex = 118
        '
        'BtnRetur
        '
        Me.BtnRetur.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnRetur.FlatAppearance.BorderSize = 0
        Me.BtnRetur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.BtnRetur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.BtnRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetur.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetur.ForeColor = System.Drawing.Color.White
        Me.BtnRetur.Image = CType(resources.GetObject("BtnRetur.Image"), System.Drawing.Image)
        Me.BtnRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRetur.Location = New System.Drawing.Point(433, 63)
        Me.BtnRetur.Name = "BtnRetur"
        Me.BtnRetur.Size = New System.Drawing.Size(120, 35)
        Me.BtnRetur.TabIndex = 120
        Me.BtnRetur.Text = "    RETUR"
        Me.BtnRetur.UseVisualStyleBackColor = False
        '
        'TextCari
        '
        Me.TextCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(578, 75)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(470, 23)
        Me.TextCari.TabIndex = 117
        '
        'TextDetail
        '
        Me.TextDetail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextDetail.Location = New System.Drawing.Point(433, 29)
        Me.TextDetail.Name = "TextDetail"
        Me.TextDetail.Size = New System.Drawing.Size(120, 22)
        Me.TextDetail.TabIndex = 119
        '
        'TextSisa
        '
        Me.TextSisa.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextSisa.Location = New System.Drawing.Point(764, 29)
        Me.TextSisa.Name = "TextSisa"
        Me.TextSisa.Size = New System.Drawing.Size(120, 22)
        Me.TextSisa.TabIndex = 131
        Me.TextSisa.Visible = False
        '
        'TextBayar
        '
        Me.TextBayar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextBayar.Location = New System.Drawing.Point(830, 4)
        Me.TextBayar.Name = "TextBayar"
        Me.TextBayar.Size = New System.Drawing.Size(120, 22)
        Me.TextBayar.TabIndex = 130
        Me.TextBayar.Visible = False
        '
        'TextTotal
        '
        Me.TextTotal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextTotal.Location = New System.Drawing.Point(704, 4)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(120, 22)
        Me.TextTotal.TabIndex = 129
        Me.TextTotal.Visible = False
        '
        'TextKodeSup
        '
        Me.TextKodeSup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextKodeSup.Location = New System.Drawing.Point(578, 4)
        Me.TextKodeSup.Name = "TextKodeSup"
        Me.TextKodeSup.Size = New System.Drawing.Size(120, 22)
        Me.TextKodeSup.TabIndex = 128
        Me.TextKodeSup.Visible = False
        '
        'TextKodePembelian
        '
        Me.TextKodePembelian.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodePembelian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.TextKodePembelian.Location = New System.Drawing.Point(433, 4)
        Me.TextKodePembelian.Name = "TextKodePembelian"
        Me.TextKodePembelian.Size = New System.Drawing.Size(120, 22)
        Me.TextKodePembelian.TabIndex = 127
        Me.TextKodePembelian.Visible = False
        '
        'DaftarReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.TextSisa)
        Me.Controls.Add(Me.TextBayar)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.TextKodeSup)
        Me.Controls.Add(Me.TextKodePembelian)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.ComboxCari)
        Me.Controls.Add(Me.BtnRetur)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.TextDetail)
        Me.Controls.Add(Me.DGdatapembelian)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DaftarReturPembelian"
        Me.Text = "DaftarReturPembelian"
        CType(Me.DGdatapembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGdatapembelian As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents ComboxCari As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRetur As System.Windows.Forms.Button
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents TextDetail As System.Windows.Forms.TextBox
    Friend WithEvents TextSisa As System.Windows.Forms.TextBox
    Friend WithEvents TextBayar As System.Windows.Forms.TextBox
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeSup As System.Windows.Forms.TextBox
    Friend WithEvents TextKodePembelian As System.Windows.Forms.TextBox
End Class
