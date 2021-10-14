<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Spare_Parts_Vendor
    Inherits System.Windows.Forms.Form

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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lv_Vendor = New System.Windows.Forms.ListView()
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.registered = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.branchcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lv_Branch = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lv_Vendor
        '
        Me.lv_Vendor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.vendor, Me.address, Me.contact, Me.registered, Me.vendort, Me.branchcode})
        Me.lv_Vendor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Vendor.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lv_Vendor.FullRowSelect = True
        Me.lv_Vendor.GridLines = True
        Me.lv_Vendor.Location = New System.Drawing.Point(12, 12)
        Me.lv_Vendor.Name = "lv_Vendor"
        Me.lv_Vendor.Size = New System.Drawing.Size(623, 280)
        Me.lv_Vendor.TabIndex = 0
        Me.lv_Vendor.UseCompatibleStateImageBehavior = False
        Me.lv_Vendor.View = System.Windows.Forms.View.Details
        '
        'vendor
        '
        Me.vendor.Text = "VENDOR"
        Me.vendor.Width = 150
        '
        'address
        '
        Me.address.Text = "ADDRESS"
        Me.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.address.Width = 150
        '
        'contact
        '
        Me.contact.Text = "CONTACT #"
        Me.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.contact.Width = 150
        '
        'registered
        '
        Me.registered.Text = "REGISTERED"
        Me.registered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.registered.Width = 150
        '
        'vendort
        '
        Me.vendort.Text = "VENDOR TYPE"
        Me.vendort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vendort.Width = 150
        '
        'branchcode
        '
        Me.branchcode.Text = "BRANCH CODE"
        Me.branchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.branchcode.Width = 150
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(463, 123)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(111, 20)
        Me.txt_Search.TabIndex = 1
        '
        'lv_Branch
        '
        Me.lv_Branch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_Branch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Branch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lv_Branch.FullRowSelect = True
        Me.lv_Branch.GridLines = True
        Me.lv_Branch.Location = New System.Drawing.Point(12, 12)
        Me.lv_Branch.Name = "lv_Branch"
        Me.lv_Branch.Size = New System.Drawing.Size(623, 280)
        Me.lv_Branch.TabIndex = 2
        Me.lv_Branch.UseCompatibleStateImageBehavior = False
        Me.lv_Branch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Branch Code"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Branch"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ZIP CODE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'Spare_Parts_Vendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 304)
        Me.Controls.Add(Me.lv_Branch)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.lv_Vendor)
        Me.Name = "Spare_Parts_Vendor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_Vendor As ListView
    Friend WithEvents vendor As ColumnHeader
    Friend WithEvents address As ColumnHeader
    Friend WithEvents contact As ColumnHeader
    Friend WithEvents registered As ColumnHeader
    Friend WithEvents vendort As ColumnHeader
    Friend WithEvents branchcode As ColumnHeader
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lv_Branch As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
