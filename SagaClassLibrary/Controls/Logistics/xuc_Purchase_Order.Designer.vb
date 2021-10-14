Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Purchase_Order
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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Order_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Order_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Order_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Brand_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Supplier_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Freight_Cost = New DevExpress.XtraEditors.CalcEdit()
            Me.Is_Per_Unit = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Due_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Purchase_Order_Code = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Order_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Brand_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Freight_Cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Is_Per_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Purchase_Order_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Order_Code)
            Me.layoutControl.Controls.Add(Me.Order_Date)
            Me.layoutControl.Controls.Add(Me.Order_Description)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Brand_Code)
            Me.layoutControl.Controls.Add(Me.Supplier_Name)
            Me.layoutControl.Controls.Add(Me.Freight_Cost)
            Me.layoutControl.Controls.Add(Me.Is_Per_Unit)
            Me.layoutControl.Controls.Add(Me.Due_Date)
            Me.layoutControl.Controls.Add(Me.Purchase_Order_Code)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(250, 350)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(87, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(151, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Order_Code
            '
            Me.Order_Code.Location = New System.Drawing.Point(87, 84)
            Me.Order_Code.Name = "Order_Code"
            Me.Order_Code.Properties.ReadOnly = True
            Me.Order_Code.Size = New System.Drawing.Size(151, 20)
            Me.Order_Code.StyleController = Me.layoutControl
            Me.Order_Code.TabIndex = 3
            '
            'Order_Date
            '
            Me.Order_Date.EditValue = Nothing
            Me.Order_Date.Location = New System.Drawing.Point(87, 132)
            Me.Order_Date.Name = "Order_Date"
            Me.Order_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Order_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Order_Date.Properties.DisplayFormat.FormatString = ""
            Me.Order_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Order_Date.Properties.EditFormat.FormatString = ""
            Me.Order_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Order_Date.Properties.Mask.EditMask = ""
            Me.Order_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Order_Date.Size = New System.Drawing.Size(151, 20)
            Me.Order_Date.StyleController = Me.layoutControl
            Me.Order_Date.TabIndex = 5
            '
            'Order_Description
            '
            Me.Order_Description.Location = New System.Drawing.Point(87, 226)
            Me.Order_Description.Name = "Order_Description"
            Me.Order_Description.Size = New System.Drawing.Size(151, 37)
            Me.Order_Description.StyleController = Me.layoutControl
            Me.Order_Description.TabIndex = 9
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(87, 277)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(151, 61)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 10
            '
            'Brand_Code
            '
            Me.Brand_Code.Location = New System.Drawing.Point(87, 36)
            Me.Brand_Code.Name = "Brand_Code"
            Me.Brand_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Brand_Code.Properties.NullText = ""
            Me.Brand_Code.Size = New System.Drawing.Size(151, 20)
            Me.Brand_Code.StyleController = Me.layoutControl
            Me.Brand_Code.TabIndex = 1
            '
            'Supplier_Name
            '
            Me.Supplier_Name.Location = New System.Drawing.Point(87, 60)
            Me.Supplier_Name.Name = "Supplier_Name"
            Me.Supplier_Name.Properties.ReadOnly = True
            Me.Supplier_Name.Size = New System.Drawing.Size(151, 20)
            Me.Supplier_Name.StyleController = Me.layoutControl
            Me.Supplier_Name.TabIndex = 2
            '
            'Freight_Cost
            '
            Me.Freight_Cost.Location = New System.Drawing.Point(87, 156)
            Me.Freight_Cost.Name = "Freight_Cost"
            Me.Freight_Cost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Freight_Cost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Freight_Cost.Size = New System.Drawing.Size(151, 20)
            Me.Freight_Cost.StyleController = Me.layoutControl
            Me.Freight_Cost.TabIndex = 6
            '
            'Is_Per_Unit
            '
            Me.Is_Per_Unit.Location = New System.Drawing.Point(87, 180)
            Me.Is_Per_Unit.Name = "Is_Per_Unit"
            Me.Is_Per_Unit.Properties.OffText = "Delivery"
            Me.Is_Per_Unit.Properties.OnText = "Per Unit"
            Me.Is_Per_Unit.Size = New System.Drawing.Size(151, 18)
            Me.Is_Per_Unit.StyleController = Me.layoutControl
            Me.Is_Per_Unit.TabIndex = 7
            '
            'Due_Date
            '
            Me.Due_Date.EditValue = Nothing
            Me.Due_Date.Location = New System.Drawing.Point(87, 202)
            Me.Due_Date.Name = "Due_Date"
            Me.Due_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Date.Properties.DisplayFormat.FormatString = ""
            Me.Due_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Due_Date.Properties.EditFormat.FormatString = ""
            Me.Due_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Due_Date.Properties.MaskSettings.Set("mask", "")
            Me.Due_Date.Size = New System.Drawing.Size(151, 20)
            Me.Due_Date.StyleController = Me.layoutControl
            Me.Due_Date.TabIndex = 8
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.SplitterItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(250, 350)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Order_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem2.Text = "Order Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Order_Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 214)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(230, 41)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 265)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(230, 65)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Order_Date
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem3.Text = "Order Date"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Freight_Cost
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem8.Text = "Freight Cost"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Brand_Code
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem6.Text = "Brand"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Supplier_Name
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem7.Text = "Supplier"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(63, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 255)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(230, 10)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Is_Per_Unit
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 168)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(230, 22)
            Me.LayoutControlItem9.Text = "Costing Type"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(63, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Due_Date
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 190)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem10.Text = "Due Date"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(63, 13)
            '
            'Purchase_Order_Code
            '
            Me.Purchase_Order_Code.Location = New System.Drawing.Point(87, 108)
            Me.Purchase_Order_Code.Name = "Purchase_Order_Code"
            Me.Purchase_Order_Code.Size = New System.Drawing.Size(151, 20)
            Me.Purchase_Order_Code.StyleController = Me.layoutControl
            Me.Purchase_Order_Code.TabIndex = 4
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.Purchase_Order_Code
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem11.Text = "P.O. Code"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(63, 13)
            '
            'xuc_Purchase_Order
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Purchase_Order"
            Me.Size = New System.Drawing.Size(250, 350)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Order_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Brand_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Freight_Cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Is_Per_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Purchase_Order_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Order_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Order_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Order_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Brand_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Supplier_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Freight_Cost As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Friend WithEvents Is_Per_Unit As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Due_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Purchase_Order_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace