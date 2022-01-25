<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanStokOpname
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
        Me.CRViewStokOpname = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewStokOpname
        '
        Me.CRViewStokOpname.ActiveViewIndex = -1
        Me.CRViewStokOpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewStokOpname.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewStokOpname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewStokOpname.Location = New System.Drawing.Point(0, 0)
        Me.CRViewStokOpname.Name = "CRViewStokOpname"
        Me.CRViewStokOpname.Size = New System.Drawing.Size(834, 261)
        Me.CRViewStokOpname.TabIndex = 0
        '
        'FormLaporanStokOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 261)
        Me.Controls.Add(Me.CRViewStokOpname)
        Me.Name = "FormLaporanStokOpname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Stok Opname"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewStokOpname As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
