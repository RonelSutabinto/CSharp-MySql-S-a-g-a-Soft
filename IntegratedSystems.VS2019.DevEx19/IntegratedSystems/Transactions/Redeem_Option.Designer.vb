<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Redeem_Option
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Me.txt_pulloutInv = New System.Windows.Forms.RadioButton()
        Me.txt_pulloutInvNot = New System.Windows.Forms.RadioButton()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_pulloutInv
        '
        Me.txt_pulloutInv.AutoSize = True
        Me.txt_pulloutInv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pulloutInv.ForeColor = System.Drawing.Color.White
        Me.txt_pulloutInv.Location = New System.Drawing.Point(69, 49)
        Me.txt_pulloutInv.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pulloutInv.Name = "txt_pulloutInv"
        Me.txt_pulloutInv.Size = New System.Drawing.Size(84, 23)
        Me.txt_pulloutInv.TabIndex = 0
        Me.txt_pulloutInv.Text = "REDEEM"
        Me.txt_pulloutInv.UseVisualStyleBackColor = True
        '
        'txt_pulloutInvNot
        '
        Me.txt_pulloutInvNot.AutoSize = True
        Me.txt_pulloutInvNot.Checked = True
        Me.txt_pulloutInvNot.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pulloutInvNot.ForeColor = System.Drawing.Color.White
        Me.txt_pulloutInvNot.Location = New System.Drawing.Point(198, 49)
        Me.txt_pulloutInvNot.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pulloutInvNot.Name = "txt_pulloutInvNot"
        Me.txt_pulloutInvNot.Size = New System.Drawing.Size(118, 23)
        Me.txt_pulloutInvNot.TabIndex = 1
        Me.txt_pulloutInvNot.TabStop = True
        Me.txt_pulloutInvNot.Text = "NOT REDEEM"
        Me.txt_pulloutInvNot.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Location = New System.Drawing.Point(69, 90)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(247, 45)
        Me.cmd_ok.TabIndex = 2
        Me.cmd_ok.Text = "OK"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'IS_Sales_RedeemOrNot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(389, 147)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.txt_pulloutInvNot)
        Me.Controls.Add(Me.txt_pulloutInv)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_RedeemOrNot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REDEEM OR NOT REDEEM?"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_pulloutInv As System.Windows.Forms.RadioButton
    Friend WithEvents txt_pulloutInvNot As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
End Class
