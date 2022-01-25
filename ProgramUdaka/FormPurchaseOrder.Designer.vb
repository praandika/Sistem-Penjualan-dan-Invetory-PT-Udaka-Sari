<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPurchaseOrder
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
        Me.CRViewPO = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewPO
        '
        Me.CRViewPO.ActiveViewIndex = -1
        Me.CRViewPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewPO.Location = New System.Drawing.Point(0, 0)
        Me.CRViewPO.Name = "CRViewPO"
        Me.CRViewPO.Size = New System.Drawing.Size(834, 261)
        Me.CRViewPO.TabIndex = 0
        '
        'FormPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 261)
        Me.Controls.Add(Me.CRViewPO)
        Me.Name = "FormPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Purchase Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewPO As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
