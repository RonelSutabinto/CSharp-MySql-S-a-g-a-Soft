Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class WaitForm1
        Inherits DevExpress.XtraWaitForm.WaitForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.progressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'progressPanel
            '
            Me.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.progressPanel.Appearance.Options.UseBackColor = True
            Me.progressPanel.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
            Me.progressPanel.AppearanceCaption.Options.UseFont = True
            Me.progressPanel.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.progressPanel.AppearanceDescription.Options.UseFont = True
            Me.progressPanel.BarAnimationElementThickness = 2
            Me.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.progressPanel.ImageHorzOffset = 20
            Me.progressPanel.Location = New System.Drawing.Point(0, 17)
            Me.progressPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
            Me.progressPanel.Name = "progressPanel"
            Me.progressPanel.Size = New System.Drawing.Size(300, 39)
            Me.progressPanel.TabIndex = 0
            Me.progressPanel.Text = "progressPanel"
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.AutoSize = True
            Me.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.progressPanel, 0, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 14, 0, 14)
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(300, 73)
            Me.tableLayoutPanel1.TabIndex = 1
            '
            'WaitForm1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.ClientSize = New System.Drawing.Size(300, 73)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "WaitForm1"
            Me.ShowOnTopMode = DevExpress.XtraWaitForm.ShowFormOnTopMode.AboveAll
            Me.Text = "xtraForm1"
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents progressPanel As DevExpress.XtraWaitForm.ProgressPanel
    End Class
End Namespace