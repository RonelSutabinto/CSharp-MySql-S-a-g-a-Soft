Namespace Controls.Information.Item
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Brand
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
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Brand_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Supplier_Address = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Brand_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Supplier_Contact = New DevExpress.XtraEditors.TextEdit()
            Me.Account_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Brand_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Brand_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Supplier_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Brand_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Supplier_Contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Brand_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Brand_Name)
            Me.LayoutControl.Controls.Add(Me.Supplier_Address)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Controls.Add(Me.Brand_Description)
            Me.LayoutControl.Controls.Add(Me.Supplier_Contact)
            Me.LayoutControl.Controls.Add(Me.Account_Code)
            Me.LayoutControl.Controls.Add(Me.Brand_Code)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(200, 300)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(111, 20)
            Me.ID.StyleController = Me.LayoutControl
            Me.ID.TabIndex = 0
            '
            'Brand_Name
            '
            Me.Brand_Name.Location = New System.Drawing.Point(77, 60)
            Me.Brand_Name.Name = "Brand_Name"
            Me.Brand_Name.Size = New System.Drawing.Size(111, 20)
            Me.Brand_Name.StyleController = Me.LayoutControl
            Me.Brand_Name.TabIndex = 2
            '
            'Supplier_Address
            '
            Me.Supplier_Address.Location = New System.Drawing.Point(77, 108)
            Me.Supplier_Address.Name = "Supplier_Address"
            Me.Supplier_Address.Properties.ReadOnly = True
            Me.Supplier_Address.Size = New System.Drawing.Size(111, 46)
            Me.Supplier_Address.StyleController = Me.LayoutControl
            Me.Supplier_Address.TabIndex = 4
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(77, 252)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(111, 36)
            Me.Notes.StyleController = Me.LayoutControl
            Me.Notes.TabIndex = 7
            '
            'Brand_Description
            '
            Me.Brand_Description.Location = New System.Drawing.Point(77, 192)
            Me.Brand_Description.Name = "Brand_Description"
            Me.Brand_Description.Size = New System.Drawing.Size(111, 46)
            Me.Brand_Description.StyleController = Me.LayoutControl
            Me.Brand_Description.TabIndex = 6
            '
            'Supplier_Contact
            '
            Me.Supplier_Contact.Location = New System.Drawing.Point(77, 168)
            Me.Supplier_Contact.Name = "Supplier_Contact"
            Me.Supplier_Contact.Properties.ReadOnly = True
            Me.Supplier_Contact.Size = New System.Drawing.Size(111, 20)
            Me.Supplier_Contact.StyleController = Me.LayoutControl
            Me.Supplier_Contact.TabIndex = 5
            '
            'Account_Code
            '
            Me.Account_Code.Location = New System.Drawing.Point(77, 84)
            Me.Account_Code.Name = "Account_Code"
            Me.Account_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Account_Code.Properties.NullText = ""
            Me.Account_Code.Size = New System.Drawing.Size(111, 20)
            Me.Account_Code.StyleController = Me.LayoutControl
            Me.Account_Code.TabIndex = 3
            '
            'Brand_Code
            '
            Me.Brand_Code.Location = New System.Drawing.Point(77, 36)
            Me.Brand_Code.Name = "Brand_Code"
            Me.Brand_Code.Properties.ReadOnly = True
            Me.Brand_Code.Size = New System.Drawing.Size(111, 20)
            Me.Brand_Code.StyleController = Me.LayoutControl
            Me.Brand_Code.TabIndex = 1
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.SplitterItem1, Me.SplitterItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(200, 300)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Brand_Name
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem2.Text = "Brand"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Account_Code
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem3.Text = "Supplier"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Supplier_Address
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(180, 50)
            Me.LayoutControlItem4.Text = "Address"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 240)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(180, 40)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Brand_Description
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 180)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(180, 50)
            Me.LayoutControlItem6.Text = "Description"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Supplier_Contact
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 156)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem7.Text = "Contact"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Brand_Code
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem8.Text = "Code"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(53, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 230)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(180, 10)
            '
            'SplitterItem2
            '
            Me.SplitterItem2.AllowHotTrack = True
            Me.SplitterItem2.Location = New System.Drawing.Point(0, 146)
            Me.SplitterItem2.Name = "SplitterItem2"
            Me.SplitterItem2.Size = New System.Drawing.Size(180, 10)
            '
            'xuc_Brand
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Brand"
            Me.Size = New System.Drawing.Size(200, 300)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Brand_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Supplier_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Brand_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Supplier_Contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Brand_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Brand_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Supplier_Address As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Brand_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Supplier_Contact As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Brand_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace