<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Me.TextKodePem = New System.Windows.Forms.TextBox()
        Me.TextKodeBrg = New System.Windows.Forms.TextBox()
        Me.TextQTYBeli = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextKodeSup = New System.Windows.Forms.TextBox()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.TextNoPem = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TextIDPemDetail = New System.Windows.Forms.TextBox()
        Me.TextBrgBeli = New System.Windows.Forms.TextBox()
        Me.TextSup = New System.Windows.Forms.TextBox()
        Me.BtnCariSup = New System.Windows.Forms.Button()
        Me.BtnCariBrg = New System.Windows.Forms.Button()
        Me.TextIDPemDetailVisible = New System.Windows.Forms.TextBox()
        Me.Beli = New System.Windows.Forms.GroupBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BeliBarang = New System.Windows.Forms.GroupBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TextHrgBrgVisible = New System.Windows.Forms.TextBox()
        Me.TextIn = New System.Windows.Forms.TextBox()
        Me.TextTotalBeli = New System.Windows.Forms.TextBox()
        Me.TextStokBrg = New System.Windows.Forms.TextBox()
        Me.TextHargaBeli = New System.Windows.Forms.TextBox()
        Me.PembayaranBeli = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnHitungDiskon = New System.Windows.Forms.Button()
        Me.TextDisc = New System.Windows.Forms.TextBox()
        Me.CBPajak = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.ComboxJenisBayar = New System.Windows.Forms.ComboBox()
        Me.TextTagihan = New System.Windows.Forms.TextBox()
        Me.TextSttsPem = New System.Windows.Forms.TextBox()
        Me.TextBayar = New System.Windows.Forms.TextBox()
        Me.TextGrandTotalBeli = New System.Windows.Forms.TextBox()
        Me.TextHargaVisible = New System.Windows.Forms.TextBox()
        Me.TextGrandVisible = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextHasilPPN = New System.Windows.Forms.TextBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.TextTotalQTY = New System.Windows.Forms.TextBox()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Beli.SuspendLayout()
        Me.BeliBarang.SuspendLayout()
        Me.PembayaranBeli.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextKodePem
        '
        Me.TextKodePem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextKodePem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodePem.Location = New System.Drawing.Point(142, 21)
        Me.TextKodePem.Name = "TextKodePem"
        Me.TextKodePem.Size = New System.Drawing.Size(196, 23)
        Me.TextKodePem.TabIndex = 0
        '
        'TextKodeBrg
        '
        Me.TextKodeBrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextKodeBrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeBrg.Location = New System.Drawing.Point(488, 18)
        Me.TextKodeBrg.Name = "TextKodeBrg"
        Me.TextKodeBrg.Size = New System.Drawing.Size(80, 23)
        Me.TextKodeBrg.TabIndex = 0
        '
        'TextQTYBeli
        '
        Me.TextQTYBeli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextQTYBeli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextQTYBeli.Location = New System.Drawing.Point(418, 100)
        Me.TextQTYBeli.Name = "TextQTYBeli"
        Me.TextQTYBeli.Size = New System.Drawing.Size(196, 23)
        Me.TextQTYBeli.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Location = New System.Drawing.Point(407, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TextKodeSup
        '
        Me.TextKodeSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextKodeSup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKodeSup.Location = New System.Drawing.Point(488, 93)
        Me.TextKodeSup.Name = "TextKodeSup"
        Me.TextKodeSup.Size = New System.Drawing.Size(80, 23)
        Me.TextKodeSup.TabIndex = 0
        '
        'DGPembelian
        '
        Me.DGPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPembelian.BackgroundColor = System.Drawing.Color.White
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPembelian.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGPembelian.Location = New System.Drawing.Point(13, 397)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.Size = New System.Drawing.Size(1034, 226)
        Me.DGPembelian.TabIndex = 3
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(933, 325)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(114, 36)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "    SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHapus.BackColor = System.Drawing.Color.DarkRed
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(789, 325)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(114, 36)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "    HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'TextNoPem
        '
        Me.TextNoPem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNoPem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNoPem.Location = New System.Drawing.Point(142, 58)
        Me.TextNoPem.Name = "TextNoPem"
        Me.TextNoPem.Size = New System.Drawing.Size(196, 23)
        Me.TextNoPem.TabIndex = 0
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(645, 325)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(114, 36)
        Me.BtnTambah.TabIndex = 6
        Me.BtnTambah.Text = "    PILIH"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'TextIDPemDetail
        '
        Me.TextIDPemDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextIDPemDetail.Location = New System.Drawing.Point(348, 21)
        Me.TextIDPemDetail.Name = "TextIDPemDetail"
        Me.TextIDPemDetail.Size = New System.Drawing.Size(134, 23)
        Me.TextIDPemDetail.TabIndex = 108
        Me.TextIDPemDetail.Visible = False
        '
        'TextBrgBeli
        '
        Me.TextBrgBeli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBrgBeli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrgBeli.Location = New System.Drawing.Point(142, 18)
        Me.TextBrgBeli.Name = "TextBrgBeli"
        Me.TextBrgBeli.Size = New System.Drawing.Size(340, 23)
        Me.TextBrgBeli.TabIndex = 0
        '
        'TextSup
        '
        Me.TextSup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSup.Location = New System.Drawing.Point(142, 93)
        Me.TextSup.Name = "TextSup"
        Me.TextSup.Size = New System.Drawing.Size(340, 23)
        Me.TextSup.TabIndex = 0
        '
        'BtnCariSup
        '
        Me.BtnCariSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCariSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCariSup.FlatAppearance.BorderSize = 0
        Me.BtnCariSup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCariSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnCariSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCariSup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariSup.ForeColor = System.Drawing.Color.White
        Me.BtnCariSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCariSup.Location = New System.Drawing.Point(573, 93)
        Me.BtnCariSup.Name = "BtnCariSup"
        Me.BtnCariSup.Size = New System.Drawing.Size(50, 26)
        Me.BtnCariSup.TabIndex = 109
        Me.BtnCariSup.Text = "..."
        Me.BtnCariSup.UseVisualStyleBackColor = False
        '
        'BtnCariBrg
        '
        Me.BtnCariBrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCariBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCariBrg.FlatAppearance.BorderSize = 0
        Me.BtnCariBrg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCariBrg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnCariBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCariBrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariBrg.ForeColor = System.Drawing.Color.White
        Me.BtnCariBrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCariBrg.Location = New System.Drawing.Point(572, 18)
        Me.BtnCariBrg.Name = "BtnCariBrg"
        Me.BtnCariBrg.Size = New System.Drawing.Size(50, 26)
        Me.BtnCariBrg.TabIndex = 109
        Me.BtnCariBrg.Text = "..."
        Me.BtnCariBrg.UseVisualStyleBackColor = False
        '
        'TextIDPemDetailVisible
        '
        Me.TextIDPemDetailVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextIDPemDetailVisible.Location = New System.Drawing.Point(348, 58)
        Me.TextIDPemDetailVisible.Name = "TextIDPemDetailVisible"
        Me.TextIDPemDetailVisible.Size = New System.Drawing.Size(134, 23)
        Me.TextIDPemDetailVisible.TabIndex = 108
        '
        'Beli
        '
        Me.Beli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Beli.Controls.Add(Me.Panel18)
        Me.Beli.Controls.Add(Me.Panel17)
        Me.Beli.Controls.Add(Me.Panel10)
        Me.Beli.Controls.Add(Me.Panel9)
        Me.Beli.Controls.Add(Me.Panel8)
        Me.Beli.Controls.Add(Me.Button9)
        Me.Beli.Controls.Add(Me.Panel7)
        Me.Beli.Controls.Add(Me.Button8)
        Me.Beli.Controls.Add(Me.Button7)
        Me.Beli.Controls.Add(Me.BtnCariSup)
        Me.Beli.Controls.Add(Me.TextKodePem)
        Me.Beli.Controls.Add(Me.TextIDPemDetailVisible)
        Me.Beli.Controls.Add(Me.TextNoPem)
        Me.Beli.Controls.Add(Me.TextIDPemDetail)
        Me.Beli.Controls.Add(Me.TextSup)
        Me.Beli.Controls.Add(Me.TextKodeSup)
        Me.Beli.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beli.Location = New System.Drawing.Point(5, 32)
        Me.Beli.Name = "Beli"
        Me.Beli.Size = New System.Drawing.Size(631, 125)
        Me.Beli.TabIndex = 110
        Me.Beli.TabStop = False
        Me.Beli.Text = "PURCHASE ORDER"
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.Color.Black
        Me.Panel18.Location = New System.Drawing.Point(348, 81)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(134, 3)
        Me.Panel18.TabIndex = 126
        Me.Panel18.Visible = False
        '
        'Panel17
        '
        Me.Panel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel17.BackColor = System.Drawing.Color.Black
        Me.Panel17.Location = New System.Drawing.Point(348, 44)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(134, 3)
        Me.Panel17.TabIndex = 125
        Me.Panel17.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Location = New System.Drawing.Point(488, 116)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(80, 3)
        Me.Panel10.TabIndex = 122
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(142, 116)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(340, 3)
        Me.Panel9.TabIndex = 123
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(142, 81)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(196, 3)
        Me.Panel8.TabIndex = 120
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(4, 93)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(139, 26)
        Me.Button9.TabIndex = 124
        Me.Button9.Text = "Supplier"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(142, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(196, 3)
        Me.Panel7.TabIndex = 118
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(4, 58)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 26)
        Me.Button8.TabIndex = 121
        Me.Button8.Text = "Nota PO"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(4, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 26)
        Me.Button7.TabIndex = 119
        Me.Button7.Text = "Kode PO"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BeliBarang
        '
        Me.BeliBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BeliBarang.Controls.Add(Me.Panel16)
        Me.BeliBarang.Controls.Add(Me.Panel15)
        Me.BeliBarang.Controls.Add(Me.Button13)
        Me.BeliBarang.Controls.Add(Me.Panel14)
        Me.BeliBarang.Controls.Add(Me.Button14)
        Me.BeliBarang.Controls.Add(Me.Panel13)
        Me.BeliBarang.Controls.Add(Me.Button12)
        Me.BeliBarang.Controls.Add(Me.Button11)
        Me.BeliBarang.Controls.Add(Me.Button10)
        Me.BeliBarang.Controls.Add(Me.Panel11)
        Me.BeliBarang.Controls.Add(Me.Panel12)
        Me.BeliBarang.Controls.Add(Me.TextHrgBrgVisible)
        Me.BeliBarang.Controls.Add(Me.TextIn)
        Me.BeliBarang.Controls.Add(Me.TextTotalBeli)
        Me.BeliBarang.Controls.Add(Me.TextStokBrg)
        Me.BeliBarang.Controls.Add(Me.TextHargaBeli)
        Me.BeliBarang.Controls.Add(Me.BtnCariBrg)
        Me.BeliBarang.Controls.Add(Me.TextBrgBeli)
        Me.BeliBarang.Controls.Add(Me.TextKodeBrg)
        Me.BeliBarang.Controls.Add(Me.TextQTYBeli)
        Me.BeliBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeliBarang.Location = New System.Drawing.Point(5, 163)
        Me.BeliBarang.Name = "BeliBarang"
        Me.BeliBarang.Size = New System.Drawing.Size(631, 132)
        Me.BeliBarang.TabIndex = 111
        Me.BeliBarang.TabStop = False
        Me.BeliBarang.Text = "BARANG"
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.Color.Black
        Me.Panel16.Location = New System.Drawing.Point(142, 123)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(196, 3)
        Me.Panel16.TabIndex = 130
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.Color.Black
        Me.Panel15.Location = New System.Drawing.Point(418, 123)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(196, 3)
        Me.Panel15.TabIndex = 129
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Gainsboro
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(348, 100)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(71, 26)
        Me.Button13.TabIndex = 132
        Me.Button13.Text = "QTY"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel14.BackColor = System.Drawing.Color.Black
        Me.Panel14.Location = New System.Drawing.Point(418, 82)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(196, 3)
        Me.Panel14.TabIndex = 127
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Gainsboro
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button14.Location = New System.Drawing.Point(4, 100)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(139, 26)
        Me.Button14.TabIndex = 131
        Me.Button14.Text = "Total"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.Black
        Me.Panel13.Location = New System.Drawing.Point(142, 82)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(196, 3)
        Me.Panel13.TabIndex = 125
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.BackColor = System.Drawing.Color.Gainsboro
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(348, 59)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(71, 26)
        Me.Button12.TabIndex = 128
        Me.Button12.Text = "Stok"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gainsboro
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(4, 59)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(139, 26)
        Me.Button11.TabIndex = 126
        Me.Button11.Text = "Harga"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(4, 18)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(139, 26)
        Me.Button10.TabIndex = 124
        Me.Button10.Text = "Nama Barang"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.Location = New System.Drawing.Point(488, 41)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(80, 3)
        Me.Panel11.TabIndex = 122
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.Location = New System.Drawing.Point(142, 41)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(340, 3)
        Me.Panel12.TabIndex = 123
        '
        'TextHrgBrgVisible
        '
        Me.TextHrgBrgVisible.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextHrgBrgVisible.Location = New System.Drawing.Point(300, 59)
        Me.TextHrgBrgVisible.Name = "TextHrgBrgVisible"
        Me.TextHrgBrgVisible.Size = New System.Drawing.Size(38, 23)
        Me.TextHrgBrgVisible.TabIndex = 116
        '
        'TextIn
        '
        Me.TextIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextIn.Location = New System.Drawing.Point(512, 59)
        Me.TextIn.Name = "TextIn"
        Me.TextIn.Size = New System.Drawing.Size(102, 23)
        Me.TextIn.TabIndex = 112
        '
        'TextTotalBeli
        '
        Me.TextTotalBeli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTotalBeli.Location = New System.Drawing.Point(142, 100)
        Me.TextTotalBeli.Name = "TextTotalBeli"
        Me.TextTotalBeli.Size = New System.Drawing.Size(196, 23)
        Me.TextTotalBeli.TabIndex = 112
        '
        'TextStokBrg
        '
        Me.TextStokBrg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextStokBrg.Location = New System.Drawing.Point(418, 59)
        Me.TextStokBrg.Name = "TextStokBrg"
        Me.TextStokBrg.Size = New System.Drawing.Size(196, 23)
        Me.TextStokBrg.TabIndex = 113
        '
        'TextHargaBeli
        '
        Me.TextHargaBeli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextHargaBeli.Location = New System.Drawing.Point(142, 59)
        Me.TextHargaBeli.Name = "TextHargaBeli"
        Me.TextHargaBeli.Size = New System.Drawing.Size(196, 23)
        Me.TextHargaBeli.TabIndex = 112
        '
        'PembayaranBeli
        '
        Me.PembayaranBeli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PembayaranBeli.Controls.Add(Me.Button5)
        Me.PembayaranBeli.Controls.Add(Me.BtnHitungDiskon)
        Me.PembayaranBeli.Controls.Add(Me.TextDisc)
        Me.PembayaranBeli.Controls.Add(Me.CBPajak)
        Me.PembayaranBeli.Controls.Add(Me.Panel6)
        Me.PembayaranBeli.Controls.Add(Me.Button6)
        Me.PembayaranBeli.Controls.Add(Me.Panel4)
        Me.PembayaranBeli.Controls.Add(Me.Panel3)
        Me.PembayaranBeli.Controls.Add(Me.Button4)
        Me.PembayaranBeli.Controls.Add(Me.Panel2)
        Me.PembayaranBeli.Controls.Add(Me.Button3)
        Me.PembayaranBeli.Controls.Add(Me.Button1)
        Me.PembayaranBeli.Controls.Add(Me.Panel5)
        Me.PembayaranBeli.Controls.Add(Me.BtnReset)
        Me.PembayaranBeli.Controls.Add(Me.ComboxJenisBayar)
        Me.PembayaranBeli.Controls.Add(Me.TextTagihan)
        Me.PembayaranBeli.Controls.Add(Me.TextSttsPem)
        Me.PembayaranBeli.Controls.Add(Me.TextBayar)
        Me.PembayaranBeli.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PembayaranBeli.Location = New System.Drawing.Point(642, 32)
        Me.PembayaranBeli.Name = "PembayaranBeli"
        Me.PembayaranBeli.Size = New System.Drawing.Size(412, 263)
        Me.PembayaranBeli.TabIndex = 112
        Me.PembayaranBeli.TabStop = False
        Me.PembayaranBeli.Text = "INFORMASI TAGIHAN"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(4, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 26)
        Me.Button5.TabIndex = 127
        Me.Button5.Text = "Diskon (%)"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'BtnHitungDiskon
        '
        Me.BtnHitungDiskon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHitungDiskon.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnHitungDiskon.FlatAppearance.BorderSize = 0
        Me.BtnHitungDiskon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnHitungDiskon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnHitungDiskon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHitungDiskon.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitungDiskon.ForeColor = System.Drawing.Color.White
        Me.BtnHitungDiskon.Image = CType(resources.GetObject("BtnHitungDiskon.Image"), System.Drawing.Image)
        Me.BtnHitungDiskon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHitungDiskon.Location = New System.Drawing.Point(239, 129)
        Me.BtnHitungDiskon.Name = "BtnHitungDiskon"
        Me.BtnHitungDiskon.Size = New System.Drawing.Size(95, 26)
        Me.BtnHitungDiskon.TabIndex = 119
        Me.BtnHitungDiskon.Text = "      HITUNG"
        Me.BtnHitungDiskon.UseVisualStyleBackColor = False
        '
        'TextDisc
        '
        Me.TextDisc.Location = New System.Drawing.Point(142, 129)
        Me.TextDisc.Name = "TextDisc"
        Me.TextDisc.Size = New System.Drawing.Size(192, 23)
        Me.TextDisc.TabIndex = 131
        '
        'CBPajak
        '
        Me.CBPajak.AutoSize = True
        Me.CBPajak.Location = New System.Drawing.Point(142, 204)
        Me.CBPajak.Name = "CBPajak"
        Me.CBPajak.Size = New System.Drawing.Size(51, 20)
        Me.CBPajak.TabIndex = 130
        Me.CBPajak.Text = "PPN"
        Me.CBPajak.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(142, 195)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(234, 3)
        Me.Panel6.TabIndex = 128
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(4, 165)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 33)
        Me.Button6.TabIndex = 129
        Me.Button6.Text = "Bayar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(142, 152)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 3)
        Me.Panel4.TabIndex = 126
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(142, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(192, 3)
        Me.Panel3.TabIndex = 124
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(4, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 26)
        Me.Button4.TabIndex = 125
        Me.Button4.Text = "Status Transaksi"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(142, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 3)
        Me.Panel2.TabIndex = 122
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(4, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 26)
        Me.Button3.TabIndex = 123
        Me.Button3.Text = "Sisa Tagihan"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(4, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 26)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "Jenis Pembayaran"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(142, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(192, 3)
        Me.Panel5.TabIndex = 118
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackColor = System.Drawing.Color.DarkRed
        Me.BtnReset.FlatAppearance.BorderSize = 0
        Me.BtnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Image = CType(resources.GetObject("BtnReset.Image"), System.Drawing.Image)
        Me.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReset.Location = New System.Drawing.Point(333, 165)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(43, 33)
        Me.BtnReset.TabIndex = 118
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'ComboxJenisBayar
        '
        Me.ComboxJenisBayar.FormattingEnabled = True
        Me.ComboxJenisBayar.Items.AddRange(New Object() {"CASH", "ANGSURAN"})
        Me.ComboxJenisBayar.Location = New System.Drawing.Point(142, 20)
        Me.ComboxJenisBayar.Name = "ComboxJenisBayar"
        Me.ComboxJenisBayar.Size = New System.Drawing.Size(192, 24)
        Me.ComboxJenisBayar.TabIndex = 29
        '
        'TextTagihan
        '
        Me.TextTagihan.Location = New System.Drawing.Point(142, 57)
        Me.TextTagihan.Name = "TextTagihan"
        Me.TextTagihan.Size = New System.Drawing.Size(192, 23)
        Me.TextTagihan.TabIndex = 28
        '
        'TextSttsPem
        '
        Me.TextSttsPem.Location = New System.Drawing.Point(142, 93)
        Me.TextSttsPem.Name = "TextSttsPem"
        Me.TextSttsPem.Size = New System.Drawing.Size(192, 23)
        Me.TextSttsPem.TabIndex = 23
        '
        'TextBayar
        '
        Me.TextBayar.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBayar.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBayar.Location = New System.Drawing.Point(142, 165)
        Me.TextBayar.Name = "TextBayar"
        Me.TextBayar.Size = New System.Drawing.Size(192, 33)
        Me.TextBayar.TabIndex = 0
        '
        'TextGrandTotalBeli
        '
        Me.TextGrandTotalBeli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextGrandTotalBeli.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextGrandTotalBeli.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextGrandTotalBeli.ForeColor = System.Drawing.Color.Teal
        Me.TextGrandTotalBeli.Location = New System.Drawing.Point(13, 325)
        Me.TextGrandTotalBeli.Name = "TextGrandTotalBeli"
        Me.TextGrandTotalBeli.Size = New System.Drawing.Size(474, 66)
        Me.TextGrandTotalBeli.TabIndex = 34
        '
        'TextHargaVisible
        '
        Me.TextHargaVisible.Location = New System.Drawing.Point(226, 297)
        Me.TextHargaVisible.Name = "TextHargaVisible"
        Me.TextHargaVisible.Size = New System.Drawing.Size(110, 22)
        Me.TextHargaVisible.TabIndex = 115
        '
        'TextGrandVisible
        '
        Me.TextGrandVisible.Location = New System.Drawing.Point(342, 297)
        Me.TextGrandVisible.Name = "TextGrandVisible"
        Me.TextGrandVisible.Size = New System.Drawing.Size(145, 22)
        Me.TextGrandVisible.TabIndex = 114
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 23)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "GRAND TOTAL (RP)"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(604, 375)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(443, 16)
        Me.Label19.TabIndex = 116
        Me.Label19.Text = "*Sebelum klik tombol HAPUS, pastikan Anda telah memilih barang"
        '
        'TextHasilPPN
        '
        Me.TextHasilPPN.Location = New System.Drawing.Point(493, 297)
        Me.TextHasilPPN.Name = "TextHasilPPN"
        Me.TextHasilPPN.Size = New System.Drawing.Size(145, 22)
        Me.TextHasilPPN.TabIndex = 117
        '
        'Panel19
        '
        Me.Panel19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel19.BackColor = System.Drawing.Color.Black
        Me.Panel19.Location = New System.Drawing.Point(407, 26)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(244, 3)
        Me.Panel19.TabIndex = 127
        '
        'TextTotalQTY
        '
        Me.TextTotalQTY.Location = New System.Drawing.Point(493, 325)
        Me.TextTotalQTY.Name = "TextTotalQTY"
        Me.TextTotalQTY.Size = New System.Drawing.Size(36, 22)
        Me.TextTotalQTY.TabIndex = 128
        Me.TextTotalQTY.Visible = False
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.TextTotalQTY)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.TextHasilPPN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextHargaVisible)
        Me.Controls.Add(Me.TextGrandVisible)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextGrandTotalBeli)
        Me.Controls.Add(Me.PembayaranBeli)
        Me.Controls.Add(Me.BeliBarang)
        Me.Controls.Add(Me.Beli)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DGPembelian)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pembelian"
        Me.Text = "Pembelian"
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Beli.ResumeLayout(False)
        Me.Beli.PerformLayout()
        Me.BeliBarang.ResumeLayout(False)
        Me.BeliBarang.PerformLayout()
        Me.PembayaranBeli.ResumeLayout(False)
        Me.PembayaranBeli.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextKodePem As System.Windows.Forms.TextBox
    Friend WithEvents TextKodeBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextQTYBeli As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextKodeSup As System.Windows.Forms.TextBox
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents TextNoPem As System.Windows.Forms.TextBox
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TextIDPemDetail As System.Windows.Forms.TextBox
    Friend WithEvents TextBrgBeli As System.Windows.Forms.TextBox
    Friend WithEvents TextSup As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariSup As System.Windows.Forms.Button
    Friend WithEvents BtnCariBrg As System.Windows.Forms.Button
    Friend WithEvents TextIDPemDetailVisible As System.Windows.Forms.TextBox
    Friend WithEvents Beli As System.Windows.Forms.GroupBox
    Friend WithEvents BeliBarang As System.Windows.Forms.GroupBox
    Friend WithEvents TextHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents TextStokBrg As System.Windows.Forms.TextBox
    Friend WithEvents TextTotalBeli As System.Windows.Forms.TextBox
    Friend WithEvents PembayaranBeli As System.Windows.Forms.GroupBox
    Friend WithEvents TextSttsPem As System.Windows.Forms.TextBox
    Friend WithEvents TextBayar As System.Windows.Forms.TextBox
    Friend WithEvents TextGrandTotalBeli As System.Windows.Forms.TextBox
    Friend WithEvents TextHargaVisible As System.Windows.Forms.TextBox
    Friend WithEvents TextGrandVisible As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextIn As System.Windows.Forms.TextBox
    Friend WithEvents TextHrgBrgVisible As System.Windows.Forms.TextBox
    Friend WithEvents TextTagihan As System.Windows.Forms.TextBox
    Friend WithEvents ComboxJenisBayar As System.Windows.Forms.ComboBox
    Friend WithEvents BtnHitungDiskon As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TextHasilPPN As System.Windows.Forms.TextBox
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents CBPajak As System.Windows.Forms.CheckBox
    Friend WithEvents TextDisc As System.Windows.Forms.TextBox
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents TextTotalQTY As System.Windows.Forms.TextBox
End Class
