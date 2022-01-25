<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanReturPembelian
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
        Me.CRViewLaporanReturBeli = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportReturPembelian1 = New ProgramUdaka.ReportReturPembelian()
        Me.SuspendLayout()
        '
        'CRViewLaporanReturBeli
        '
        Me.CRViewLaporanReturBeli.ActiveViewIndex = 0
        Me.CRViewLaporanReturBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewLaporanReturBeli.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewLaporanReturBeli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewLaporanReturBeli.Location = New System.Drawing.Point(0, 0)
        Me.CRViewLaporanReturBeli.Name = "CRViewLaporanReturBeli"
        Me.CRViewLaporanReturBeli.ReportSource = Me.ReportReturPembelian1
        Me.CRViewLaporanReturBeli.Size = New System.Drawing.Size(841, 261)
        Me.CRViewLaporanReturBeli.TabIndex = 0
        '
        'FormLaporanReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 261)
        Me.Controls.Add(Me.CRViewLaporanReturBeli)
        Me.Name = "FormLaporanReturPembelian"
        Me.Text = "FormLaporanReturPembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewLaporanReturBeli As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportReturPembelian1 As ProgramUdaka.ReportReturPembelian
End Class
