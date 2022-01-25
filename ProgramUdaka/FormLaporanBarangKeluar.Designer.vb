<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBarangKeluar
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
        Me.CRViewBarangKeluar = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportBarangKeluar1 = New ProgramUdaka.ReportBarangKeluar()
        Me.SuspendLayout()
        '
        'CRViewBarangKeluar
        '
        Me.CRViewBarangKeluar.ActiveViewIndex = 0
        Me.CRViewBarangKeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewBarangKeluar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewBarangKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewBarangKeluar.Location = New System.Drawing.Point(0, 0)
        Me.CRViewBarangKeluar.Name = "CRViewBarangKeluar"
        Me.CRViewBarangKeluar.ReportSource = Me.ReportBarangKeluar1
        Me.CRViewBarangKeluar.Size = New System.Drawing.Size(836, 261)
        Me.CRViewBarangKeluar.TabIndex = 0
        '
        'FormLaporanBarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 261)
        Me.Controls.Add(Me.CRViewBarangKeluar)
        Me.Name = "FormLaporanBarangKeluar"
        Me.Text = "FormLaporanBarangKeluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewBarangKeluar As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportBarangKeluar1 As ProgramUdaka.ReportBarangKeluar
End Class
