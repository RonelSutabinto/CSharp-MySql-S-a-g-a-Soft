Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Collection
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'xuc_Grid_Collection
            '
            Me.xuc_Grid_Collection = New Controls.Accounting.xuc_Grid_Collection()
            Me.xuc_Grid_Collection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Collection.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Collection.Name = "xuc_Grid_Collection"
            Me.xuc_Grid_Collection.Size = New System.Drawing.Size(533, 297)
            Me.xuc_Grid_Collection.TabIndex = 0
            '
            'frm_Collection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(533, 297)
            Me.Controls.Add(Me.xuc_Grid_Collection)
            Me.Name = "frm_Collection"
            Me.Text = "Collection"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents xuc_Grid_Collection As Controls.Accounting.xuc_Grid_Collection
    End Class
End Namespace