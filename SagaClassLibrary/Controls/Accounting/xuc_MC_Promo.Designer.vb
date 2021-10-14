Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_MC_Promo
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
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Promo_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Promo_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Promo_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Promo_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Brand = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.COA_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Discount = New DevExpress.XtraEditors.CalcEdit()
            Me.Promo_Start = New DevExpress.XtraEditors.DateEdit()
            Me.Promo_End = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_Start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Promo_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Promo_Code)
            Me.layoutControl.Controls.Add(Me.Promo_Type)
            Me.layoutControl.Controls.Add(Me.Promo_Name)
            Me.layoutControl.Controls.Add(Me.Promo_Description)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Brand)
            Me.layoutControl.Controls.Add(Me.COA_Code)
            Me.layoutControl.Controls.Add(Me.Discount)
            Me.layoutControl.Controls.Add(Me.Promo_Start)
            Me.layoutControl.Controls.Add(Me.Promo_End)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(300, 350)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(71, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Promo_Code
            '
            Me.Promo_Code.Location = New System.Drawing.Point(217, 12)
            Me.Promo_Code.Name = "Promo_Code"
            Me.Promo_Code.Size = New System.Drawing.Size(71, 20)
            Me.Promo_Code.StyleController = Me.layoutControl
            Me.Promo_Code.TabIndex = 1
            '
            'Promo_Type
            '
            Me.Promo_Type.Location = New System.Drawing.Point(77, 36)
            Me.Promo_Type.Name = "Promo_Type"
            Me.Promo_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Promo_Type.Size = New System.Drawing.Size(211, 20)
            Me.Promo_Type.StyleController = Me.layoutControl
            Me.Promo_Type.TabIndex = 2
            '
            'Promo_Name
            '
            Me.Promo_Name.Location = New System.Drawing.Point(77, 180)
            Me.Promo_Name.Name = "Promo_Name"
            Me.Promo_Name.Size = New System.Drawing.Size(211, 20)
            Me.Promo_Name.StyleController = Me.layoutControl
            Me.Promo_Name.TabIndex = 8
            '
            'Promo_Description
            '
            Me.Promo_Description.Location = New System.Drawing.Point(77, 204)
            Me.Promo_Description.Name = "Promo_Description"
            Me.Promo_Description.Size = New System.Drawing.Size(211, 22)
            Me.Promo_Description.StyleController = Me.layoutControl
            Me.Promo_Description.TabIndex = 9
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(77, 240)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(211, 98)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 10
            '
            'Brand
            '
            Me.Brand.Location = New System.Drawing.Point(77, 60)
            Me.Brand.Name = "Brand"
            Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Brand.Size = New System.Drawing.Size(211, 20)
            Me.Brand.StyleController = Me.layoutControl
            Me.Brand.TabIndex = 3
            '
            'COA_Code
            '
            Me.COA_Code.Location = New System.Drawing.Point(77, 84)
            Me.COA_Code.Name = "COA_Code"
            Me.COA_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.COA_Code.Properties.NullText = ""
            Me.COA_Code.Properties.PopupSizeable = False
            Me.COA_Code.Size = New System.Drawing.Size(211, 20)
            Me.COA_Code.StyleController = Me.layoutControl
            Me.COA_Code.TabIndex = 4
            '
            'Discount
            '
            Me.Discount.Location = New System.Drawing.Point(77, 108)
            Me.Discount.Name = "Discount"
            Me.Discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Discount.Size = New System.Drawing.Size(211, 20)
            Me.Discount.StyleController = Me.layoutControl
            Me.Discount.TabIndex = 5
            '
            'Promo_Start
            '
            Me.Promo_Start.EditValue = Nothing
            Me.Promo_Start.Location = New System.Drawing.Point(77, 132)
            Me.Promo_Start.Name = "Promo_Start"
            Me.Promo_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Promo_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Promo_Start.Size = New System.Drawing.Size(211, 20)
            Me.Promo_Start.StyleController = Me.layoutControl
            Me.Promo_Start.TabIndex = 6
            '
            'Promo_End
            '
            Me.Promo_End.EditValue = Nothing
            Me.Promo_End.Location = New System.Drawing.Point(77, 156)
            Me.Promo_End.Name = "Promo_End"
            Me.Promo_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Promo_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Promo_End.Size = New System.Drawing.Size(211, 20)
            Me.Promo_End.StyleController = Me.layoutControl
            Me.Promo_End.TabIndex = 7
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.SplitterItem1, Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem7})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(300, 350)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(140, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Promo_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(140, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(140, 24)
            Me.LayoutControlItem2.Text = "Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Promo_Type
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem3.Text = "Type"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Promo_Name
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 168)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem4.Text = "Name"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Promo_Description
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 192)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(280, 26)
            Me.LayoutControlItem5.Text = "Description"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Notes
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 228)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(280, 102)
            Me.LayoutControlItem6.Text = "Notes"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Brand
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem7.Text = "Brand"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.COA_Code
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem8.Text = "Account"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Discount
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem9.Text = "Discount"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Promo_Start
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem10.Text = "Date Start"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.Promo_End
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem11.Text = "Date End"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(53, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 218)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(280, 10)
            '
            'xuc_MC_Promo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_MC_Promo"
            Me.Size = New System.Drawing.Size(300, 350)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_Start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Promo_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Promo_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Promo_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Promo_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Promo_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Brand As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents COA_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Discount As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Promo_Start As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Promo_End As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace