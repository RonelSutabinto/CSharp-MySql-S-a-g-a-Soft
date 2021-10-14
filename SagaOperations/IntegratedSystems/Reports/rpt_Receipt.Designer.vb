<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_Receipt
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
        Me.cr_Receipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cr_Receipt
        '
        Me.cr_Receipt.ActiveViewIndex = -1
        Me.cr_Receipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cr_Receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr_Receipt.Cursor = System.Windows.Forms.Cursors.Default
        Me.cr_Receipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cr_Receipt.Location = New System.Drawing.Point(0, 0)
        Me.cr_Receipt.Name = "cr_Receipt"
        Me.cr_Receipt.Size = New System.Drawing.Size(564, 430)
        Me.cr_Receipt.TabIndex = 1
        Me.cr_Receipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rpt_Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 430)
        Me.cr_Receipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Controls.Add(Me.cr_Receipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rpt_Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIPT"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cr_Receipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
