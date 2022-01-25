<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariSupplierPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariSupplierPembelian))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGCariSupplier = New System.Windows.Forms.DataGridView()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.Rb_IDsup = New System.Windows.Forms.RadioButton()
        Me.Rb_Namasup = New System.Windows.Forms.RadioButton()
        Me.TextKodeSup = New System.Windows.Forms.TextBox()
        Me.TextSup = New System.Windows.Forms.TextBox()
        Me.PanelHeader.SuspendLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCariSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 372)
        Me.Panel3.TabIndex = 44
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(573, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 372)
        Me.Panel2.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 2)
        Me.Panel1.TabIndex = 42
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
        Me.PanelHeader.TabIndex = 41
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(232, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CARI SUPPLIER"
        '
        'DGCariSupplier
        '
        Me.DGCariSupplier.BackgroundColor = System.Drawing.Color.White
        Me.DGCariSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCariSupplier.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCariSupplier.Location = New System.Drawing.Point(12, 91)
        Me.DGCariSupplier.Name = "DGCariSupplier"
        Me.DGCariSupplier.Size = New System.Drawing.Size(551, 301)
        Me.DGCariSupplier.TabIndex = 45
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(234, 59)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(328, 22)
        Me.TextCari.TabIndex = 46
        '
        'Rb_IDsup
        '
        Me.Rb_IDsup.AutoSize = True
        Me.Rb_IDsup.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_IDsup.Location = New System.Drawing.Point(13, 57)
        Me.Rb_IDsup.Name = "Rb_IDsup"
        Me.Rb_IDsup.Size = New System.Drawing.Size(95, 20)
        Me.Rb_IDsup.TabIndex = 47
        Me.Rb_IDsup.TabStop = True
        Me.Rb_IDsup.Text = "ID Supplier"
        Me.Rb_IDsup.UseVisualStyleBackColor = True
        '
        'Rb_Namasup
        '
        Me.Rb_Namasup.AutoSize = True
        Me.Rb_Namasup.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Namasup.Location = New System.Drawing.Point(110, 58)
        Me.Rb_Namasup.Name = "Rb_Namasup"
        Me.Rb_Namasup.Size = New System.Drawing.Size(122, 20)
        Me.Rb_Namasup.TabIndex = 48
        Me.Rb_Namasup.TabStop = True
        Me.Rb_Namasup.Text = "Nama Supplier"
        Me.Rb_Namasup.UseVisualStyleBackColor = True
        '
        'TextKodeSup
        '
        Me.TextKodeSup.Location = New System.Drawing.Point(235, 36)
        Me.TextKodeSup.Name = "TextKodeSup"
        Me.TextKodeSup.Size = New System.Drawing.Size(149, 22)
        Me.TextKodeSup.TabIndex = 46
        Me.TextKodeSup.Visible = False
        '
        'TextSup
        '
        Me.TextSup.Location = New System.Drawing.Point(412, 36)
        Me.TextSup.Name = "TextSup"
        Me.TextSup.Size = New System.Drawing.Size(150, 22)
        Me.TextSup.TabIndex = 46
        Me.TextSup.Visible = False
        '
        'CariSupplierPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 404)
        Me.Controls.Add(Me.Rb_Namasup)
        Me.Controls.Add(Me.Rb_IDsup)
        Me.Controls.Add(Me.TextSup)
        Me.Controls.Add(Me.TextKodeSup)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.DGCariSupplier)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CariSupplierPembelian"
        Me.Text = "CariSupplierPembelian"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCariSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGCariSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents Rb_IDsup As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Namasup As System.Windows.Forms.RadioButton
    Friend WithEvents TextKodeSup As System.Windows.Forms.TextBox
    Friend WithEvents TextSup As System.Windows.Forms.TextBox
End Class
