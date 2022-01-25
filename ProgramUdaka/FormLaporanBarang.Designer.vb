<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBarang
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
        Me.CRViewBarang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewBarang
        '
        Me.CRViewBarang.ActiveViewIndex = -1
        Me.CRViewBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewBarang.Location = New System.Drawing.Point(0, 0)
        Me.CRViewBarang.Name = "CRViewBarang"
        Me.CRViewBarang.Size = New System.Drawing.Size(886, 261)
        Me.CRViewBarang.TabIndex = 0
        '
        'FormLaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 261)
        Me.Controls.Add(Me.CRViewBarang)
        Me.Name = "FormLaporanBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewBarang As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
