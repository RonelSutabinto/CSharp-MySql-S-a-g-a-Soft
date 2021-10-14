<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_SQLJobsHistory
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
        Me.GCJobHistory = New DevExpress.XtraGrid.GridControl()
        Me.GViewJobHistory = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GCJobHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewJobHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCJobHistory
        '
        Me.GCJobHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCJobHistory.Location = New System.Drawing.Point(0, 0)
        Me.GCJobHistory.MainView = Me.GViewJobHistory
        Me.GCJobHistory.Name = "GCJobHistory"
        Me.GCJobHistory.Size = New System.Drawing.Size(862, 447)
        Me.GCJobHistory.TabIndex = 0
        Me.GCJobHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewJobHistory})
        '
        'GViewJobHistory
        '
        Me.GViewJobHistory.GridControl = Me.GCJobHistory
        Me.GViewJobHistory.Name = "GViewJobHistory"
        Me.GViewJobHistory.OptionsBehavior.Editable = False
        Me.GViewJobHistory.OptionsView.ColumnAutoWidth = False
        '
        'Admin_SQLJobsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 447)
        Me.Controls.Add(Me.GCJobHistory)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_SQLJobsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SQL Jobs History"
        CType(Me.GCJobHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewJobHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCJobHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewJobHistory As DevExpress.XtraGrid.Views.Grid.GridView
End Class
