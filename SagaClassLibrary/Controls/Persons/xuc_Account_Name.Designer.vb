Namespace Controls.Persons
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Account_Name
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Account_Mobile = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Account_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Account_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Account_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Account_Address = New DevExpress.XtraEditors.MemoEdit()
            Me.Account_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.Notesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Mobileitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IDitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Codeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Descriptionitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Nameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Addressitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Typeitem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.Account_Mobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notesitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Mobileitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Codeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Descriptionitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Nameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Addressitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Typeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Account_Mobile
            '
            Me.Account_Mobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Mobile.Location = New System.Drawing.Point(77, 138)
            Me.Account_Mobile.Name = "Account_Mobile"
            Me.Account_Mobile.Size = New System.Drawing.Size(211, 20)
            Me.Account_Mobile.StyleController = Me.layoutControl
            Me.Account_Mobile.TabIndex = 5
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Account_Mobile)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Account_Code)
            Me.layoutControl.Controls.Add(Me.Account_Description)
            Me.layoutControl.Controls.Add(Me.Account_Name)
            Me.layoutControl.Controls.Add(Me.Account_Address)
            Me.layoutControl.Controls.Add(Me.Account_Type)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(300, 355)
            Me.layoutControl.TabIndex = 0
            '
            'Notes
            '
            Me.Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Notes.Location = New System.Drawing.Point(77, 216)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(211, 127)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 7
            '
            'ID
            '
            Me.ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(71, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Account_Code
            '
            Me.Account_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Code.Enabled = False
            Me.Account_Code.Location = New System.Drawing.Point(217, 12)
            Me.Account_Code.Name = "Account_Code"
            Me.Account_Code.Size = New System.Drawing.Size(71, 20)
            Me.Account_Code.StyleController = Me.layoutControl
            Me.Account_Code.TabIndex = 1
            '
            'Account_Description
            '
            Me.Account_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Description.Location = New System.Drawing.Point(77, 162)
            Me.Account_Description.Name = "Account_Description"
            Me.Account_Description.Size = New System.Drawing.Size(211, 50)
            Me.Account_Description.StyleController = Me.layoutControl
            Me.Account_Description.TabIndex = 6
            '
            'Account_Name
            '
            Me.Account_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Name.Location = New System.Drawing.Point(77, 36)
            Me.Account_Name.Name = "Account_Name"
            Me.Account_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Account_Name.Size = New System.Drawing.Size(211, 20)
            Me.Account_Name.StyleController = Me.layoutControl
            Me.Account_Name.TabIndex = 2
            '
            'Account_Address
            '
            Me.Account_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Address.Location = New System.Drawing.Point(77, 84)
            Me.Account_Address.Name = "Account_Address"
            Me.Account_Address.Size = New System.Drawing.Size(211, 50)
            Me.Account_Address.StyleController = Me.layoutControl
            Me.Account_Address.TabIndex = 4
            '
            'Account_Type
            '
            Me.Account_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Type.Location = New System.Drawing.Point(77, 60)
            Me.Account_Type.Name = "Account_Type"
            Me.Account_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Account_Type.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Account_Type.Size = New System.Drawing.Size(211, 20)
            Me.Account_Type.StyleController = Me.layoutControl
            Me.Account_Type.TabIndex = 3
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Notesitem, Me.Account_Mobileitem, Me.IDitem, Me.Account_Descriptionitem, Me.Account_Nameitem, Me.Account_Addressitem, Me.Account_Typeitem, Me.Account_Codeitem})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(300, 355)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'Notesitem
            '
            Me.Notesitem.Control = Me.Notes
            Me.Notesitem.Location = New System.Drawing.Point(0, 204)
            Me.Notesitem.Name = "Notesitem"
            Me.Notesitem.Size = New System.Drawing.Size(280, 131)
            Me.Notesitem.Text = "Notes"
            Me.Notesitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Notesitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Mobileitem
            '
            Me.Account_Mobileitem.Control = Me.Account_Mobile
            Me.Account_Mobileitem.Location = New System.Drawing.Point(0, 126)
            Me.Account_Mobileitem.Name = "Account_Mobileitem"
            Me.Account_Mobileitem.Size = New System.Drawing.Size(280, 24)
            Me.Account_Mobileitem.Text = "Mobile"
            Me.Account_Mobileitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Mobileitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'IDitem
            '
            Me.IDitem.Control = Me.ID
            Me.IDitem.Location = New System.Drawing.Point(0, 0)
            Me.IDitem.Name = "IDitem"
            Me.IDitem.Size = New System.Drawing.Size(140, 24)
            Me.IDitem.Text = "ID"
            Me.IDitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.IDitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Codeitem
            '
            Me.Account_Codeitem.Control = Me.Account_Code
            Me.Account_Codeitem.Location = New System.Drawing.Point(140, 0)
            Me.Account_Codeitem.Name = "Account_Codeitem"
            Me.Account_Codeitem.Size = New System.Drawing.Size(140, 24)
            Me.Account_Codeitem.Text = "Code"
            Me.Account_Codeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Codeitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Descriptionitem
            '
            Me.Account_Descriptionitem.Control = Me.Account_Description
            Me.Account_Descriptionitem.Location = New System.Drawing.Point(0, 150)
            Me.Account_Descriptionitem.MaxSize = New System.Drawing.Size(0, 54)
            Me.Account_Descriptionitem.MinSize = New System.Drawing.Size(76, 54)
            Me.Account_Descriptionitem.Name = "Account_Descriptionitem"
            Me.Account_Descriptionitem.Size = New System.Drawing.Size(280, 54)
            Me.Account_Descriptionitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.Account_Descriptionitem.Text = "Description"
            Me.Account_Descriptionitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Descriptionitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Nameitem
            '
            Me.Account_Nameitem.Control = Me.Account_Name
            Me.Account_Nameitem.Location = New System.Drawing.Point(0, 24)
            Me.Account_Nameitem.Name = "Account_Nameitem"
            Me.Account_Nameitem.Size = New System.Drawing.Size(280, 24)
            Me.Account_Nameitem.Text = "Name"
            Me.Account_Nameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Nameitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Addressitem
            '
            Me.Account_Addressitem.Control = Me.Account_Address
            Me.Account_Addressitem.Location = New System.Drawing.Point(0, 72)
            Me.Account_Addressitem.MaxSize = New System.Drawing.Size(0, 54)
            Me.Account_Addressitem.MinSize = New System.Drawing.Size(76, 54)
            Me.Account_Addressitem.Name = "Account_Addressitem"
            Me.Account_Addressitem.Size = New System.Drawing.Size(280, 54)
            Me.Account_Addressitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.Account_Addressitem.Text = "Address"
            Me.Account_Addressitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Addressitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'Account_Typeitem
            '
            Me.Account_Typeitem.Control = Me.Account_Type
            Me.Account_Typeitem.Location = New System.Drawing.Point(0, 48)
            Me.Account_Typeitem.Name = "Account_Typeitem"
            Me.Account_Typeitem.Size = New System.Drawing.Size(280, 24)
            Me.Account_Typeitem.Text = "Type"
            Me.Account_Typeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Typeitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'xuc_Account_Name
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Account_Name"
            Me.Size = New System.Drawing.Size(300, 355)
            CType(Me.Account_Mobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notesitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Mobileitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Codeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Descriptionitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Nameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Addressitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Typeitem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Account_Mobile As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Account_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Account_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Account_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Account_Address As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Account_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Notesitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Mobileitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IDitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Codeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Descriptionitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Nameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Addressitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Typeitem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace