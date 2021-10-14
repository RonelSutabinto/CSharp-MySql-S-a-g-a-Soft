<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_BranchParameter
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_BranchParameter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.lvBranchParam = New System.Windows.Forms.ListView()
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PRE_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Branch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DatabaseDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ZipCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LTOPayable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Insurance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NotarialFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Notes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolNew = New System.Windows.Forms.ToolStripButton()
        Me.toolregister = New System.Windows.Forms.ToolStripButton()
        Me.toolFind = New System.Windows.Forms.ToolStripButton()
        Me.toolmodify = New System.Windows.Forms.ToolStripButton()
        Me.toolDelete = New System.Windows.Forms.ToolStripButton()
        Me.txt_PreCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_BranchName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_BM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NotarialFee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Insurance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_LTOPayable = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ZipCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Notes = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_DatabaseDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BranchCode"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_BranchCode.Location = New System.Drawing.Point(146, 34)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(180, 23)
        Me.txt_BranchCode.TabIndex = 1
        '
        'lvBranchParam
        '
        Me.lvBranchParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lvBranchParam.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.PRE_Code, Me.Branch, Me.Address, Me.BM, Me.DatabaseDate, Me.ZipCode, Me.LTOPayable, Me.Insurance, Me.NotarialFee, Me.Notes})
        Me.lvBranchParam.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvBranchParam.FullRowSelect = True
        Me.lvBranchParam.GridLines = True
        Me.lvBranchParam.Location = New System.Drawing.Point(333, 29)
        Me.lvBranchParam.Margin = New System.Windows.Forms.Padding(4)
        Me.lvBranchParam.Name = "lvBranchParam"
        Me.lvBranchParam.Size = New System.Drawing.Size(660, 324)
        Me.lvBranchParam.TabIndex = 2
        Me.lvBranchParam.UseCompatibleStateImageBehavior = False
        Me.lvBranchParam.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BranchCode"
        Me.BranchCode.Width = 98
        '
        'PRE_Code
        '
        Me.PRE_Code.Text = "PRE_Code"
        Me.PRE_Code.Width = 85
        '
        'Branch
        '
        Me.Branch.Text = "Branch"
        Me.Branch.Width = 115
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 169
        '
        'BM
        '
        Me.BM.Text = "BM"
        Me.BM.Width = 150
        '
        'DatabaseDate
        '
        Me.DatabaseDate.Text = "DatabaseDate"
        Me.DatabaseDate.Width = 100
        '
        'ZipCode
        '
        Me.ZipCode.Text = "ZipCode"
        '
        'LTOPayable
        '
        Me.LTOPayable.Text = "LTOPayable"
        '
        'Insurance
        '
        Me.Insurance.Text = "Insurance"
        '
        'NotarialFee
        '
        Me.NotarialFee.Text = "NotarialFee"
        '
        'Notes
        '
        Me.Notes.Text = "Notes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNew, Me.toolregister, Me.toolFind, Me.toolmodify, Me.toolDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(998, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolNew
        '
        Me.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNew.Image = CType(resources.GetObject("toolNew.Image"), System.Drawing.Image)
        Me.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNew.Name = "toolNew"
        Me.toolNew.Size = New System.Drawing.Size(23, 22)
        Me.toolNew.Text = "NEW"
        '
        'toolregister
        '
        Me.toolregister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolregister.Image = CType(resources.GetObject("toolregister.Image"), System.Drawing.Image)
        Me.toolregister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolregister.Name = "toolregister"
        Me.toolregister.Size = New System.Drawing.Size(23, 22)
        Me.toolregister.Text = "SAVE"
        '
        'toolFind
        '
        Me.toolFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolFind.Image = CType(resources.GetObject("toolFind.Image"), System.Drawing.Image)
        Me.toolFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolFind.Name = "toolFind"
        Me.toolFind.Size = New System.Drawing.Size(23, 22)
        Me.toolFind.Text = "FIND"
        '
        'toolmodify
        '
        Me.toolmodify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolmodify.Image = CType(resources.GetObject("toolmodify.Image"), System.Drawing.Image)
        Me.toolmodify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolmodify.Name = "toolmodify"
        Me.toolmodify.Size = New System.Drawing.Size(23, 22)
        Me.toolmodify.Text = "UPDATE"
        '
        'toolDelete
        '
        Me.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolDelete.Image = CType(resources.GetObject("toolDelete.Image"), System.Drawing.Image)
        Me.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolDelete.Name = "toolDelete"
        Me.toolDelete.Size = New System.Drawing.Size(23, 22)
        Me.toolDelete.Text = "DELETE"
        '
        'txt_PreCode
        '
        Me.txt_PreCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_PreCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PreCode.Location = New System.Drawing.Point(146, 63)
        Me.txt_PreCode.Name = "txt_PreCode"
        Me.txt_PreCode.Size = New System.Drawing.Size(180, 23)
        Me.txt_PreCode.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Location = New System.Drawing.Point(5, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 26)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Prefix Code"
        '
        'txt_BranchName
        '
        Me.txt_BranchName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_BranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BranchName.Location = New System.Drawing.Point(146, 92)
        Me.txt_BranchName.Name = "txt_BranchName"
        Me.txt_BranchName.Size = New System.Drawing.Size(180, 23)
        Me.txt_BranchName.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.Location = New System.Drawing.Point(5, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "BranchName"
        '
        'txt_Address
        '
        Me.txt_Address.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Address.Location = New System.Drawing.Point(146, 121)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(180, 23)
        Me.txt_Address.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.Location = New System.Drawing.Point(5, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Address"
        '
        'txt_BM
        '
        Me.txt_BM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_BM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BM.Location = New System.Drawing.Point(146, 150)
        Me.txt_BM.Name = "txt_BM"
        Me.txt_BM.Size = New System.Drawing.Size(180, 23)
        Me.txt_BM.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.Location = New System.Drawing.Point(5, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "BM"
        '
        'txt_NotarialFee
        '
        Me.txt_NotarialFee.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_NotarialFee.Location = New System.Drawing.Point(146, 295)
        Me.txt_NotarialFee.Name = "txt_NotarialFee"
        Me.txt_NotarialFee.Size = New System.Drawing.Size(180, 23)
        Me.txt_NotarialFee.TabIndex = 45
        Me.txt_NotarialFee.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.Location = New System.Drawing.Point(5, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Notarial Fee"
        '
        'txt_Insurance
        '
        Me.txt_Insurance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Insurance.Location = New System.Drawing.Point(146, 266)
        Me.txt_Insurance.Name = "txt_Insurance"
        Me.txt_Insurance.Size = New System.Drawing.Size(180, 23)
        Me.txt_Insurance.TabIndex = 43
        Me.txt_Insurance.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.Location = New System.Drawing.Point(5, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 26)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Insurance"
        '
        'txt_LTOPayable
        '
        Me.txt_LTOPayable.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_LTOPayable.Location = New System.Drawing.Point(146, 237)
        Me.txt_LTOPayable.Name = "txt_LTOPayable"
        Me.txt_LTOPayable.Size = New System.Drawing.Size(180, 23)
        Me.txt_LTOPayable.TabIndex = 41
        Me.txt_LTOPayable.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.Location = New System.Drawing.Point(5, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 26)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "LTO Payable"
        '
        'txt_ZipCode
        '
        Me.txt_ZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_ZipCode.Location = New System.Drawing.Point(146, 208)
        Me.txt_ZipCode.Name = "txt_ZipCode"
        Me.txt_ZipCode.Size = New System.Drawing.Size(180, 23)
        Me.txt_ZipCode.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.Location = New System.Drawing.Point(5, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 26)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "ZIP Code"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Location = New System.Drawing.Point(5, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 26)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "DatabaseDate"
        '
        'txt_Notes
        '
        Me.txt_Notes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Notes.Location = New System.Drawing.Point(146, 324)
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.Size = New System.Drawing.Size(180, 23)
        Me.txt_Notes.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.Location = New System.Drawing.Point(5, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 20)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Notes"
        '
        'txt_DatabaseDate
        '
        Me.txt_DatabaseDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_DatabaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_DatabaseDate.Location = New System.Drawing.Point(146, 180)
        Me.txt_DatabaseDate.Name = "txt_DatabaseDate"
        Me.txt_DatabaseDate.Size = New System.Drawing.Size(180, 23)
        Me.txt_DatabaseDate.TabIndex = 48
        '
        'Admin_BranchParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(998, 360)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_DatabaseDate)
        Me.Controls.Add(Me.txt_Notes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_NotarialFee)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Insurance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_LTOPayable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_ZipCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_BM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_BranchName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_PreCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lvBranchParam)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_BranchParameter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BRANCH PARAMETER"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_BranchCode As TextBox
    Friend WithEvents lvBranchParam As ListView
    Friend WithEvents BranchCode As ColumnHeader
    Friend WithEvents PRE_Code As ColumnHeader
    Friend WithEvents Branch As ColumnHeader
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents BM As ColumnHeader
    Friend WithEvents DatabaseDate As ColumnHeader
    Friend WithEvents ZipCode As ColumnHeader
    Friend WithEvents LTOPayable As ColumnHeader
    Friend WithEvents Insurance As ColumnHeader
    Friend WithEvents NotarialFee As ColumnHeader
    Friend WithEvents Notes As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolNew As ToolStripButton
    Friend WithEvents toolregister As ToolStripButton
    Friend WithEvents toolFind As ToolStripButton
    Friend WithEvents toolmodify As ToolStripButton
    Friend WithEvents toolDelete As ToolStripButton
    Friend WithEvents txt_PreCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_BranchName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_BM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_NotarialFee As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Insurance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_LTOPayable As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ZipCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_Notes As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_DatabaseDate As DateTimePicker
End Class
