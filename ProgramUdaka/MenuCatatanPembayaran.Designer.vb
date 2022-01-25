<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCatatanPembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCatatanPembayaran))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCatatKirimPembayaran = New System.Windows.Forms.Button()
        Me.BtnCatatTerima = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(271, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BtnCatatKirimPembayaran
        '
        Me.BtnCatatKirimPembayaran.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCatatKirimPembayaran.BackColor = System.Drawing.Color.Transparent
        Me.BtnCatatKirimPembayaran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCatatKirimPembayaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnCatatKirimPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatatKirimPembayaran.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatatKirimPembayaran.ForeColor = System.Drawing.Color.White
        Me.BtnCatatKirimPembayaran.Image = CType(resources.GetObject("BtnCatatKirimPembayaran.Image"), System.Drawing.Image)
        Me.BtnCatatKirimPembayaran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCatatKirimPembayaran.Location = New System.Drawing.Point(557, 258)
        Me.BtnCatatKirimPembayaran.Name = "BtnCatatKirimPembayaran"
        Me.BtnCatatKirimPembayaran.Size = New System.Drawing.Size(153, 140)
        Me.BtnCatatKirimPembayaran.TabIndex = 5
        Me.BtnCatatKirimPembayaran.Text = "Catat Kirim Pembayaran"
        Me.BtnCatatKirimPembayaran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCatatKirimPembayaran.UseVisualStyleBackColor = False
        '
        'BtnCatatTerima
        '
        Me.BtnCatatTerima.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCatatTerima.BackColor = System.Drawing.Color.Transparent
        Me.BtnCatatTerima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCatatTerima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnCatatTerima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatatTerima.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatatTerima.ForeColor = System.Drawing.Color.White
        Me.BtnCatatTerima.Image = CType(resources.GetObject("BtnCatatTerima.Image"), System.Drawing.Image)
        Me.BtnCatatTerima.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCatatTerima.Location = New System.Drawing.Point(348, 258)
        Me.BtnCatatTerima.Name = "BtnCatatTerima"
        Me.BtnCatatTerima.Size = New System.Drawing.Size(153, 140)
        Me.BtnCatatTerima.TabIndex = 4
        Me.BtnCatatTerima.Text = "Catat Terima Pembayaran"
        Me.BtnCatatTerima.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCatatTerima.UseVisualStyleBackColor = False
        '
        'MenuCatatanPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 635)
        Me.Controls.Add(Me.BtnCatatKirimPembayaran)
        Me.Controls.Add(Me.BtnCatatTerima)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuCatatanPembayaran"
        Me.Text = "Menu Catatan Pembayaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCatatKirimPembayaran As System.Windows.Forms.Button
    Friend WithEvents BtnCatatTerima As System.Windows.Forms.Button
End Class
