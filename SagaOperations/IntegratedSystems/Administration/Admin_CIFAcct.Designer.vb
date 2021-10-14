<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_CIFAcct
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
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("BranchCode", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("CIFKey", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("FullName", System.Windows.Forms.HorizontalAlignment.Left)
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvCIF = New System.Windows.Forms.ListView()
        Me.branchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cifKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblcifKey = New System.Windows.Forms.Label()
        Me.lblBranchCode = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(181, 14)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(689, 27)
        Me.txtFullName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Full Name :"
        '
        'lvCIF
        '
        Me.lvCIF.AllowColumnReorder = True
        Me.lvCIF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.branchCode, Me.fullName, Me.cifKey})
        Me.lvCIF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCIF.FullRowSelect = True
        Me.lvCIF.GridLines = True
        ListViewGroup4.Header = "BranchCode"
        ListViewGroup4.Name = "branchCode"
        ListViewGroup5.Header = "CIFKey"
        ListViewGroup5.Name = "cifKey"
        ListViewGroup6.Header = "FullName"
        ListViewGroup6.Name = "fullName"
        Me.lvCIF.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup4, ListViewGroup5, ListViewGroup6})
        Me.lvCIF.Location = New System.Drawing.Point(14, 52)
        Me.lvCIF.MultiSelect = False
        Me.lvCIF.Name = "lvCIF"
        Me.lvCIF.Size = New System.Drawing.Size(856, 445)
        Me.lvCIF.TabIndex = 2
        Me.lvCIF.UseCompatibleStateImageBehavior = False
        Me.lvCIF.View = System.Windows.Forms.View.Details
        '
        'branchCode
        '
        Me.branchCode.Text = "Branch Code"
        Me.branchCode.Width = 200
        '
        'fullName
        '
        Me.fullName.Text = "Full Name"
        Me.fullName.Width = 241
        '
        'cifKey
        '
        Me.cifKey.Text = "CIF Key"
        Me.cifKey.Width = 260
        '
        'lblcifKey
        '
        Me.lblcifKey.AutoSize = True
        Me.lblcifKey.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcifKey.Location = New System.Drawing.Point(358, 245)
        Me.lblcifKey.Name = "lblcifKey"
        Me.lblcifKey.Size = New System.Drawing.Size(67, 19)
        Me.lblcifKey.TabIndex = 3
        Me.lblcifKey.Text = "lblcifKey"
        '
        'lblBranchCode
        '
        Me.lblBranchCode.AutoSize = True
        Me.lblBranchCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranchCode.Location = New System.Drawing.Point(358, 197)
        Me.lblBranchCode.Name = "lblBranchCode"
        Me.lblBranchCode.Size = New System.Drawing.Size(110, 19)
        Me.lblBranchCode.TabIndex = 4
        Me.lblBranchCode.Text = "lblBranchCode"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(358, 290)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(55, 19)
        Me.lblFullName.TabIndex = 5
        Me.lblFullName.Text = "Label2"
        '
        'Admin_CIFAcct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 511)
        Me.Controls.Add(Me.lvCIF)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblBranchCode)
        Me.Controls.Add(Me.lblcifKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFullName)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Admin_CIFAcct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELETE CIF KEY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvCIF As System.Windows.Forms.ListView
    Friend WithEvents branchCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents fullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cifKey As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcifKey As System.Windows.Forms.Label
    Friend WithEvents lblBranchCode As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label

End Class
