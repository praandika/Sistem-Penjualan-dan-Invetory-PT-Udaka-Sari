<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPembelian
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
        Me.CRViewPembelian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewPembelian
        '
        Me.CRViewPembelian.ActiveViewIndex = -1
        Me.CRViewPembelian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewPembelian.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewPembelian.Location = New System.Drawing.Point(0, 0)
        Me.CRViewPembelian.Name = "CRViewPembelian"
        Me.CRViewPembelian.Size = New System.Drawing.Size(870, 295)
        Me.CRViewPembelian.TabIndex = 0
        '
        'FormLaporanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 295)
        Me.Controls.Add(Me.CRViewPembelian)
        Me.Name = "FormLaporanPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewPembelian As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
