<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPenjualan
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
        Me.CRViewPenjualan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewPenjualan
        '
        Me.CRViewPenjualan.ActiveViewIndex = -1
        Me.CRViewPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewPenjualan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.CRViewPenjualan.Name = "CRViewPenjualan"
        Me.CRViewPenjualan.Size = New System.Drawing.Size(877, 327)
        Me.CRViewPenjualan.TabIndex = 3
        '
        'FormLaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 327)
        Me.Controls.Add(Me.CRViewPenjualan)
        Me.Name = "FormLaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewPenjualan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
