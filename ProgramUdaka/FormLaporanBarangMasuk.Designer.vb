﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBarangMasuk
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
        Me.CRViewBarangMasuk = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportBarangMasuk1 = New ProgramUdaka.ReportBarangMasuk()
        Me.SuspendLayout()
        '
        'CRViewBarangMasuk
        '
        Me.CRViewBarangMasuk.ActiveViewIndex = 0
        Me.CRViewBarangMasuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewBarangMasuk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewBarangMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewBarangMasuk.Location = New System.Drawing.Point(0, 0)
        Me.CRViewBarangMasuk.Name = "CRViewBarangMasuk"
        Me.CRViewBarangMasuk.ReportSource = Me.ReportBarangMasuk1
        Me.CRViewBarangMasuk.Size = New System.Drawing.Size(883, 261)
        Me.CRViewBarangMasuk.TabIndex = 0
        '
        'FormLaporanBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 261)
        Me.Controls.Add(Me.CRViewBarangMasuk)
        Me.Name = "FormLaporanBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Barang Masuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewBarangMasuk As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportBarangMasuk1 As ProgramUdaka.ReportBarangMasuk
End Class
