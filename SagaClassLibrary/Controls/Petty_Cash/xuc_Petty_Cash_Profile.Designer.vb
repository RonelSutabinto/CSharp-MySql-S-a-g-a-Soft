Namespace Controls.Petty_Cash
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Petty_Cash_Profile
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
            Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Petty_Cash_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Category_Ceiling = New DevExpress.XtraEditors.CalcEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Profile_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Petty_Cash_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Category_Ceiling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Profile_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Petty_Cash_Code)
            Me.layoutControl.Controls.Add(Me.Category_Ceiling)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Branch_Code)
            Me.layoutControl.Controls.Add(Me.Profile_Code)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(250, 200)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(57, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(66, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Petty_Cash_Code
            '
            Me.Petty_Cash_Code.Location = New System.Drawing.Point(172, 12)
            Me.Petty_Cash_Code.Name = "Petty_Cash_Code"
            Me.Petty_Cash_Code.Size = New System.Drawing.Size(66, 20)
            Me.Petty_Cash_Code.StyleController = Me.layoutControl
            Me.Petty_Cash_Code.TabIndex = 1
            '
            'Category_Ceiling
            '
            Me.Category_Ceiling.Location = New System.Drawing.Point(57, 84)
            Me.Category_Ceiling.Name = "Category_Ceiling"
            Me.Category_Ceiling.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Category_Ceiling.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Category_Ceiling.Size = New System.Drawing.Size(181, 20)
            Me.Category_Ceiling.StyleController = Me.layoutControl
            Me.Category_Ceiling.TabIndex = 4
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(57, 108)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(181, 80)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 6
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(57, 36)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Properties.NullText = ""
            Me.Branch_Code.Properties.PopupSizeable = False
            Me.Branch_Code.Size = New System.Drawing.Size(181, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 2
            '
            'Profile_Code
            '
            Me.Profile_Code.Location = New System.Drawing.Point(57, 60)
            Me.Profile_Code.Name = "Profile_Code"
            Me.Profile_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Profile_Code.Properties.NullText = ""
            Me.Profile_Code.Properties.PopupSizeable = False
            Me.Profile_Code.Size = New System.Drawing.Size(181, 20)
            Me.Profile_Code.StyleController = Me.layoutControl
            Me.Profile_Code.TabIndex = 3
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(250, 200)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(115, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(33, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Petty_Cash_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(115, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(115, 24)
            Me.LayoutControlItem2.Text = "Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(33, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Profile_Code
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem3.Text = "Profile"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(33, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Category_Ceiling
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem5.Text = "Ceiling"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(33, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Notes
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(230, 84)
            Me.LayoutControlItem8.Text = "Notes"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(33, 13)
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.Branch_Code
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem11.Text = "Branch"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(33, 13)
            '
            'xuc_Petty_Cash_Profile
            '
            Me.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Petty_Cash_Profile"
            Me.Size = New System.Drawing.Size(250, 200)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Petty_Cash_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Category_Ceiling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Profile_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Petty_Cash_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Category_Ceiling As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Profile_Code As DevExpress.XtraEditors.LookUpEdit
    End Class
End Namespace