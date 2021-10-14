<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_vendor_add
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
        Me.LViewVendor = New System.Windows.Forms.ListView()
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contactno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateReg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ventype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.branchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eventFrom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LViewVendor
        '
        Me.LViewVendor.BackColor = System.Drawing.Color.White
        Me.LViewVendor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.vendor, Me.vaddress, Me.contactno, Me.dateReg, Me.ventype, Me.branchCode})
        Me.LViewVendor.ForeColor = System.Drawing.Color.Blue
        Me.LViewVendor.FullRowSelect = True
        Me.LViewVendor.GridLines = True
        Me.LViewVendor.Location = New System.Drawing.Point(16, 18)
        Me.LViewVendor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LViewVendor.Name = "LViewVendor"
        Me.LViewVendor.Size = New System.Drawing.Size(860, 362)
        Me.LViewVendor.TabIndex = 0
        Me.LViewVendor.UseCompatibleStateImageBehavior = False
        Me.LViewVendor.View = System.Windows.Forms.View.Details
        '
        'vendor
        '
        Me.vendor.Text = "VENDOR"
        Me.vendor.Width = 155
        '
        'vaddress
        '
        Me.vaddress.Text = "ADDRESS"
        Me.vaddress.Width = 214
        '
        'contactno
        '
        Me.contactno.Text = "CONTACT #"
        Me.contactno.Width = 152
        '
        'dateReg
        '
        Me.dateReg.Text = "REGISTERED"
        Me.dateReg.Width = 117
        '
        'ventype
        '
        Me.ventype.Text = "VENDOR TYPE"
        Me.ventype.Width = 106
        '
        'branchCode
        '
        Me.branchCode.Text = "BranchCode"
        Me.branchCode.Width = 104
        '
        'eventFrom
        '
        Me.eventFrom.Location = New System.Drawing.Point(345, 397)
        Me.eventFrom.Name = "eventFrom"
        Me.eventFrom.Size = New System.Drawing.Size(100, 26)
        Me.eventFrom.TabIndex = 1
        Me.eventFrom.Text = "EventFrom"
        '
        'IS_vendor_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 387)
        Me.Controls.Add(Me.eventFrom)
        Me.Controls.Add(Me.LViewVendor)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_vendor_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewVendor As System.Windows.Forms.ListView
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents vaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents contactno As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateReg As System.Windows.Forms.ColumnHeader
    Friend WithEvents ventype As System.Windows.Forms.ColumnHeader
    Friend WithEvents eventFrom As System.Windows.Forms.TextBox
    Friend WithEvents branchCode As System.Windows.Forms.ColumnHeader
End Class
