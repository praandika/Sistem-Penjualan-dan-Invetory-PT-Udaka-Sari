<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariNotaPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariNotaPenjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.DGCariNota = New System.Windows.Forms.DataGridView()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        CType(Me.DGCariNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(199, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CARI NOTA PENJUALAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Pelanggan"
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(549, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(23, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(378, 33)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(184, 22)
        Me.TxtNota.TabIndex = 76
        Me.TxtNota.Visible = False
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(12, 59)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(550, 22)
        Me.TextCari.TabIndex = 75
        '
        'DGCariNota
        '
        Me.DGCariNota.BackgroundColor = System.Drawing.Color.White
        Me.DGCariNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCariNota.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCariNota.Location = New System.Drawing.Point(12, 91)
        Me.DGCariNota.Name = "DGCariNota"
        Me.DGCariNota.Size = New System.Drawing.Size(551, 301)
        Me.DGCariNota.TabIndex = 74
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 372)
        Me.Panel3.TabIndex = 73
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(573, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 372)
        Me.Panel2.TabIndex = 72
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 2)
        Me.Panel1.TabIndex = 71
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
        Me.PanelHeader.TabIndex = 70
        '
        'CariNotaPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 404)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.DGCariNota)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CariNotaPenjualan"
        Me.Text = "CariNotaPenjualan"
        CType(Me.DGCariNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtNota As System.Windows.Forms.TextBox
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents DGCariNota As System.Windows.Forms.DataGridView
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
End Class
