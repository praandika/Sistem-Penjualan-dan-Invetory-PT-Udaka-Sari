<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanReturPenjualan
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
        Me.CRViewLaporanReturJual = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportReturPenjualan1 = New ProgramUdaka.ReportReturPenjualan()
        Me.SuspendLayout()
        '
        'CRViewLaporanReturJual
        '
        Me.CRViewLaporanReturJual.ActiveViewIndex = 0
        Me.CRViewLaporanReturJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewLaporanReturJual.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewLaporanReturJual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewLaporanReturJual.Location = New System.Drawing.Point(0, 0)
        Me.CRViewLaporanReturJual.Name = "CRViewLaporanReturJual"
        Me.CRViewLaporanReturJual.ReportSource = Me.ReportReturPenjualan1
        Me.CRViewLaporanReturJual.Size = New System.Drawing.Size(837, 261)
        Me.CRViewLaporanReturJual.TabIndex = 0
        '
        'FormLaporanReturPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 261)
        Me.Controls.Add(Me.CRViewLaporanReturJual)
        Me.Name = "FormLaporanReturPenjualan"
        Me.Text = "FormLaporanReturPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewLaporanReturJual As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportReturPenjualan1 As ProgramUdaka.ReportReturPenjualan
End Class
