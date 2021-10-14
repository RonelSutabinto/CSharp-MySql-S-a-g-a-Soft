Namespace Forms.Information.Account
    Partial Class frm_Account_Payments
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.xuc_Grid_Collection = New SagaClassLibrary.Controls.Accounting.xuc_Grid_Collection()
            Me.SuspendLayout()
            '
            'xuc_Grid_Collection
            '
            Me.xuc_Grid_Collection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Collection.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Collection.Name = "xuc_Grid_Collection"
            Me.xuc_Grid_Collection.Size = New System.Drawing.Size(617, 286)
            Me.xuc_Grid_Collection.TabIndex = 0
            '
            'frm_Account_Payments
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(617, 286)
            Me.Controls.Add(Me.xuc_Grid_Collection)
            Me.Name = "frm_Account_Payments"
            Me.Text = "List of Account Payments"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents xuc_Grid_Collection As Controls.Accounting.xuc_Grid_Collection
    End Class
End Namespace