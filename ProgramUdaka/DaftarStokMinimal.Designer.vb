<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarStokMinimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarStokMinimal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Picudakadatabarang = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGStokMinimal = New System.Windows.Forms.DataGridView()
        Me.PanelHeader.SuspendLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGStokMinimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 289)
        Me.Panel3.TabIndex = 93
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(749, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 289)
        Me.Panel2.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 2)
        Me.Panel1.TabIndex = 91
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.BtnMinimize)
        Me.PanelHeader.Controls.Add(Me.Picudakadatabarang)
        Me.PanelHeader.Controls.Add(Me.BtnClose)
        Me.PanelHeader.Controls.Add(Me.Label7)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(751, 30)
        Me.PanelHeader.TabIndex = 90
        '
        'BtnMinimize
        '
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.ForeColor = System.Drawing.Color.White
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMinimize.Location = New System.Drawing.Point(696, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(725, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(23, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(294, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DAFTAR STOK MINIMAL"
        '
        'DGStokMinimal
        '
        Me.DGStokMinimal.BackgroundColor = System.Drawing.Color.White
        Me.DGStokMinimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGStokMinimal.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGStokMinimal.Location = New System.Drawing.Point(3, 59)
        Me.DGStokMinimal.Name = "DGStokMinimal"
        Me.DGStokMinimal.Size = New System.Drawing.Size(745, 259)
        Me.DGStokMinimal.TabIndex = 94
        '
        'DaftarStokMinimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(751, 321)
        Me.Controls.Add(Me.DGStokMinimal)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DaftarStokMinimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DaftarStokMinimal"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.Picudakadatabarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGStokMinimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnMinimize As System.Windows.Forms.Button
    Friend WithEvents Picudakadatabarang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGStokMinimal As System.Windows.Forms.DataGridView
End Class
