<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Xuc_SPA_Purchase_Orders
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
        Me.Supplier_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Description = New DevExpress.XtraEditors.MemoEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Brand = New DevExpress.XtraEditors.LookUpEdit()
        Me.Order_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Order_Type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Order_C0de = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_C0de.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Controls.Add(Me.Supplier_Name)
        Me.LayoutControl.Controls.Add(Me.Description)
        Me.LayoutControl.Controls.Add(Me.Notes)
        Me.LayoutControl.Controls.Add(Me.Brand)
        Me.LayoutControl.Controls.Add(Me.Order_Date)
        Me.LayoutControl.Controls.Add(Me.Order_Type)
        Me.LayoutControl.Controls.Add(Me.Order_C0de)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(342, 463)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(92, 12)
        Me.ID.Name = "ID"
        Me.ID.Properties.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(238, 20)
        Me.ID.StyleController = Me.layoutControl
        Me.ID.TabIndex = 0
        '
        'Supplier_Name
        '
        Me.Supplier_Name.Location = New System.Drawing.Point(92, 84)
        Me.Supplier_Name.Name = "Supplier_Name"
        Me.Supplier_Name.Properties.ReadOnly = True
        Me.Supplier_Name.Size = New System.Drawing.Size(238, 20)
        Me.Supplier_Name.StyleController = Me.layoutControl
        Me.Supplier_Name.TabIndex = 3
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(92, 156)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(238, 57)
        Me.Description.StyleController = Me.layoutControl
        Me.Description.TabIndex = 6
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(92, 217)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(238, 234)
        Me.Notes.StyleController = Me.layoutControl
        Me.Notes.TabIndex = 7
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(92, 60)
        Me.Brand.Name = "Brand"
        Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Brand.Properties.NullText = ""
        Me.Brand.Size = New System.Drawing.Size(238, 20)
        Me.Brand.StyleController = Me.layoutControl
        Me.Brand.TabIndex = 2
        '
        'Order_Date
        '
        Me.Order_Date.EditValue = Nothing
        Me.Order_Date.Location = New System.Drawing.Point(92, 132)
        Me.Order_Date.Name = "Order_Date"
        Me.Order_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.DisplayFormat.FormatString = ""
        Me.Order_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.EditFormat.FormatString = ""
        Me.Order_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.Mask.EditMask = ""
        Me.Order_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Order_Date.Size = New System.Drawing.Size(238, 20)
        Me.Order_Date.StyleController = Me.layoutControl
        Me.Order_Date.TabIndex = 5
        '
        'Order_Type
        '
        Me.Order_Type.Location = New System.Drawing.Point(92, 36)
        Me.Order_Type.Name = "Order_Type"
        Me.Order_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Type.Properties.Items.AddRange(New Object() {"RETAIL", "SUB-DEALER"})
        Me.Order_Type.Size = New System.Drawing.Size(238, 20)
        Me.Order_Type.StyleController = Me.layoutControl
        Me.Order_Type.TabIndex = 1
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(342, 463)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Brand
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem2.Text = "Brand"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Supplier_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem3.Text = "Supplier Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Order_C0de
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem4.Text = "Order Code"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Order_Date
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem5.Text = "Order Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Description
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 61)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(101, 61)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(322, 61)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Description"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Notes
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 205)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(101, 20)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(322, 238)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Notes"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Order_Type
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem8.Text = "Order Type"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 13)
        '
        'Order_C0de
        '
        Me.Order_C0de.Location = New System.Drawing.Point(92, 108)
        Me.Order_C0de.Name = "Order_C0de"
        Me.Order_C0de.Properties.BeepOnError = False
        Me.Order_C0de.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_C0de.Properties.NullText = ""
        Me.Order_C0de.Size = New System.Drawing.Size(238, 20)
        Me.Order_C0de.StyleController = Me.layoutControl
        Me.Order_C0de.TabIndex = 4
        '
        'Xuc_SPA_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "Xuc_SPA_Purchase_Orders"
        Me.Size = New System.Drawing.Size(342, 463)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_C0de.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Supplier_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Brand As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Order_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Order_Type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Order_C0de As DevExpress.XtraEditors.LookUpEdit
End Class
