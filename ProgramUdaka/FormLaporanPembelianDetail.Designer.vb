<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPembelianDetail
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
        Me.CRViewPembelianDetail = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewPembelianDetail
        '
        Me.CRViewPembelianDetail.ActiveViewIndex = -1
        Me.CRViewPembelianDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewPembelianDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewPembelianDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewPembelianDetail.Location = New System.Drawing.Point(0, 0)
        Me.CRViewPembelianDetail.Name = "CRViewPembelianDetail"
        Me.CRViewPembelianDetail.Size = New System.Drawing.Size(848, 261)
        Me.CRViewPembelianDetail.TabIndex = 0
        '
        'FormLaporanPembelianDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 261)
        Me.Controls.Add(Me.CRViewPembelianDetail)
        Me.Name = "FormLaporanPembelianDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Pembelian Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewPembelianDetail As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
