<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_IPReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_IPReg))
        Me.txt_ipadd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.cmd_reg = New System.Windows.Forms.Button()
        Me.txt_brCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_ipadd
        '
        Me.txt_ipadd.Location = New System.Drawing.Point(118, 64)
        Me.txt_ipadd.Name = "txt_ipadd"
        Me.txt_ipadd.Size = New System.Drawing.Size(212, 26)
        Me.txt_ipadd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP ADDRESS"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BRANCH CODE"
        '
        'cmb_Branch
        '
        Me.cmb_Branch.FormattingEnabled = True
        Me.cmb_Branch.Location = New System.Drawing.Point(118, 30)
        Me.cmb_Branch.Name = "cmb_Branch"
        Me.cmb_Branch.Size = New System.Drawing.Size(132, 26)
        Me.cmb_Branch.TabIndex = 4
        '
        'cmd_reg
        '
        Me.cmd_reg.BackgroundImage = CType(resources.GetObject("cmd_reg.BackgroundImage"), System.Drawing.Image)
        Me.cmd_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_reg.Location = New System.Drawing.Point(336, 30)
        Me.cmd_reg.Name = "cmd_reg"
        Me.cmd_reg.Size = New System.Drawing.Size(71, 59)
        Me.cmd_reg.TabIndex = 5
        Me.cmd_reg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_reg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_reg.UseVisualStyleBackColor = True
        '
        'txt_brCode
        '
        Me.txt_brCode.Location = New System.Drawing.Point(256, 31)
        Me.txt_brCode.Name = "txt_brCode"
        Me.txt_brCode.Size = New System.Drawing.Size(74, 26)
        Me.txt_brCode.TabIndex = 6
        '
        'Admin_IPReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 120)
        Me.Controls.Add(Me.txt_brCode)
        Me.Controls.Add(Me.cmd_reg)
        Me.Controls.Add(Me.cmb_Branch)
        Me.Controls.Add(Me.txt_ipadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_IPReg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTER IP ADDRESS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_ipadd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Branch As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_reg As System.Windows.Forms.Button
    Friend WithEvents txt_brCode As System.Windows.Forms.TextBox
End Class
