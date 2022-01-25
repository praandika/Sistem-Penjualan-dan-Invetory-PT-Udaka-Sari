<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBarangKeluarDetail
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
        Me.CRViewBarangKeluarDetail = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportBarangKeluarDetail1 = New ProgramUdaka.ReportBarangKeluarDetail()
        Me.SuspendLayout()
        '
        'CRViewBarangKeluarDetail
        '
        Me.CRViewBarangKeluarDetail.ActiveViewIndex = 0
        Me.CRViewBarangKeluarDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewBarangKeluarDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewBarangKeluarDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewBarangKeluarDetail.Location = New System.Drawing.Point(0, 0)
        Me.CRViewBarangKeluarDetail.Name = "CRViewBarangKeluarDetail"
        Me.CRViewBarangKeluarDetail.ReportSource = Me.ReportBarangKeluarDetail1
        Me.CRViewBarangKeluarDetail.Size = New System.Drawing.Size(836, 261)
        Me.CRViewBarangKeluarDetail.TabIndex = 0
        '
        'FormLaporanBarangKeluarDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 261)
        Me.Controls.Add(Me.CRViewBarangKeluarDetail)
        Me.Name = "FormLaporanBarangKeluarDetail"
        Me.Text = "FormLaporanBarangKeluarDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewBarangKeluarDetail As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportBarangKeluarDetail1 As ProgramUdaka.ReportBarangKeluarDetail
End Class
