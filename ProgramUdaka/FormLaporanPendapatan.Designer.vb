<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPendapatan
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
        Me.CRViewPendapatan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewPendapatan
        '
        Me.CRViewPendapatan.ActiveViewIndex = -1
        Me.CRViewPendapatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewPendapatan.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewPendapatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewPendapatan.Location = New System.Drawing.Point(0, 0)
        Me.CRViewPendapatan.Name = "CRViewPendapatan"
        Me.CRViewPendapatan.Size = New System.Drawing.Size(844, 261)
        Me.CRViewPendapatan.TabIndex = 0
        '
        'FormLaporanPendapatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 261)
        Me.Controls.Add(Me.CRViewPendapatan)
        Me.Name = "FormLaporanPendapatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Pendapatan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewPendapatan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
