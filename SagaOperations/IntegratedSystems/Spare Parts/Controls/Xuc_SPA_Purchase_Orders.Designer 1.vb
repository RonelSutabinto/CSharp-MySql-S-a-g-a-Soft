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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.Supplier_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Order_Code = New DevExpress.XtraEditors.TextEdit()
        Me.Description = New DevExpress.XtraEditors.MemoEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Brand = New DevExpress.XtraEditors.LookUpEdit()
        Me.Order_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ID)
        Me.LayoutControl1.Controls.Add(Me.Supplier_Name)
        Me.LayoutControl1.Controls.Add(Me.Order_Code)
        Me.LayoutControl1.Controls.Add(Me.Description)
        Me.LayoutControl1.Controls.Add(Me.Notes)
        Me.LayoutControl1.Controls.Add(Me.Brand)
        Me.LayoutControl1.Controls.Add(Me.Order_Date)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(342, 463)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(90, 12)
        Me.ID.Name = "ID"
        Me.ID.Properties.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(240, 20)
        Me.ID.StyleController = Me.LayoutControl1
        Me.ID.TabIndex = 0
        '
        'Supplier_Name
        '
        Me.Supplier_Name.Location = New System.Drawing.Point(90, 60)
        Me.Supplier_Name.Name = "Supplier_Name"
        Me.Supplier_Name.Properties.ReadOnly = True
        Me.Supplier_Name.Size = New System.Drawing.Size(240, 20)
        Me.Supplier_Name.StyleController = Me.LayoutControl1
        Me.Supplier_Name.TabIndex = 2
        '
        'Order_Code
        '
        Me.Order_Code.Location = New System.Drawing.Point(90, 84)
        Me.Order_Code.Name = "Order_Code"
        Me.Order_Code.Properties.ReadOnly = True
        Me.Order_Code.Size = New System.Drawing.Size(240, 20)
        Me.Order_Code.StyleController = Me.LayoutControl1
        Me.Order_Code.TabIndex = 3
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(90, 132)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(240, 57)
        Me.Description.StyleController = Me.LayoutControl1
        Me.Description.TabIndex = 5
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(90, 193)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(240, 258)
        Me.Notes.StyleController = Me.LayoutControl1
        Me.Notes.TabIndex = 6
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(90, 36)
        Me.Brand.Name = "Brand"
        Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Brand.Properties.NullText = ""
        Me.Brand.Size = New System.Drawing.Size(240, 20)
        Me.Brand.StyleController = Me.LayoutControl1
        Me.Brand.TabIndex = 1
        '
        'Order_Date
        '
        Me.Order_Date.EditValue = Nothing
        Me.Order_Date.Location = New System.Drawing.Point(90, 108)
        Me.Order_Date.Name = "Order_Date"
        Me.Order_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.DisplayFormat.FormatString = ""
        Me.Order_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.EditFormat.FormatString = ""
        Me.Order_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.Mask.EditMask = ""
        Me.Order_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Order_Date.Size = New System.Drawing.Size(240, 20)
        Me.Order_Date.StyleController = Me.LayoutControl1
        Me.Order_Date.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
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
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Brand
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem2.Text = "Brand"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Supplier_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem3.Text = "Supplier Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Order_Code
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem4.Text = "Order Code"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Order_Date
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(322, 24)
        Me.LayoutControlItem5.Text = "Order Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Description
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 61)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(101, 61)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(322, 61)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Description"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Notes
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 181)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(101, 20)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(322, 262)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Notes"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(75, 13)
        '
        'Xuc_SPA_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Xuc_SPA_Purchase_Orders"
        Me.Size = New System.Drawing.Size(342, 463)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Supplier_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Order_Code As DevExpress.XtraEditors.TextEdit
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
End Class
