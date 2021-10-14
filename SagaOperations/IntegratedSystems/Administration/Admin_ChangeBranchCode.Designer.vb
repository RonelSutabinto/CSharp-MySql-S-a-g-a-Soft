<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_ChangeBranchCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_ChangeBranchCode))
        Me.txt_brCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txt_brCode
        '
        Me.txt_brCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brCode.ForeColor = System.Drawing.Color.Teal
        Me.txt_brCode.Location = New System.Drawing.Point(387, 52)
        Me.txt_brCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brCode.Name = "txt_brCode"
        Me.txt_brCode.ReadOnly = True
        Me.txt_brCode.Size = New System.Drawing.Size(128, 27)
        Me.txt_brCode.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(27, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "BRANCH CODE"
        '
        'cmb_Branch
        '
        Me.cmb_Branch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Branch.ForeColor = System.Drawing.Color.Teal
        Me.cmb_Branch.FormattingEnabled = True
        Me.cmb_Branch.Location = New System.Drawing.Point(142, 52)
        Me.cmb_Branch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Branch.Name = "cmb_Branch"
        Me.cmb_Branch.Size = New System.Drawing.Size(237, 27)
        Me.cmb_Branch.TabIndex = 15
        '
        'Admin_ChangeBranchCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 125)
        Me.Controls.Add(Me.txt_brCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_Branch)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_ChangeBranchCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE BRANCHCODE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_brCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_Branch As ComboBox
End Class
