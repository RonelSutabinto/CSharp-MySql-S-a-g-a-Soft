Public Class frm_Account_Ledgers
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.xuc_Grid_Ledger = New Controls.Information.Account.xuc_Grid_Ledger()
        Me.SuspendLayout()
        Me.xuc_Grid_Ledger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Grid_Ledger.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Grid_Ledger.Name = "xuc_Grid_Ledger"
        Me.xuc_Grid_Ledger.Size = New System.Drawing.Size(656, 270)
        Me.xuc_Grid_Ledger.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 270)
        Me.Controls.Add(Me.xuc_Grid_Ledger)
        Me.Name = "frm_Account_Ledger"
        Me.Text = "Account Ledger"
        
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents xuc_Grid_Ledger As Controls.Information.Account.xuc_Grid_Ledger

End Class

