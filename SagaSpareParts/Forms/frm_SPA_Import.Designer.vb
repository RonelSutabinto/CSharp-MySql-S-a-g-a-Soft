Imports SagaSpareParts.SagaSpareParts

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SPA_Import
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Xuc_SPA_Import = New xuc_SPA_Import()
        Me.SuspendLayout()
        '
        'Xuc_SPA_Import
        '
        Me.Xuc_SPA_Import.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_SPA_Import.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_SPA_Import.Name = "Xuc_SPA_Import"
        Me.Xuc_SPA_Import.Size = New System.Drawing.Size(547, 356)
        Me.Xuc_SPA_Import.TabIndex = 0
        '
        'frm_SPA_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 356)
        Me.Controls.Add(Me.Xuc_SPA_Import)
        Me.Name = "frm_SPA_Import"
        Me.Text = "frm_SPA_Import"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xuc_SPA_Import As xuc_SPA_Import
End Class
