<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_Master_Entry
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.Parts_Number = New DevExpress.XtraEditors.TextEdit()
        Me.Parts_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Model_Code = New DevExpress.XtraEditors.TextEdit()
        Me.Model_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Descriptions = New DevExpress.XtraEditors.MemoEdit()
        Me.SRP = New DevExpress.XtraEditors.CalcEdit()
        Me.Cost_WoVAT = New DevExpress.XtraEditors.CalcEdit()
        Me.Cost_WVAT = New DevExpress.XtraEditors.CalcEdit()
        Me.Quantity = New DevExpress.XtraEditors.SpinEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Brand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Category = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parts_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parts_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Model_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Model_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Descriptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_WoVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Controls.Add(Me.Parts_Number)
        Me.LayoutControl.Controls.Add(Me.Parts_Name)
        Me.LayoutControl.Controls.Add(Me.Model_Code)
        Me.LayoutControl.Controls.Add(Me.Model_Name)
        Me.LayoutControl.Controls.Add(Me.Descriptions)
        Me.LayoutControl.Controls.Add(Me.SRP)
        Me.LayoutControl.Controls.Add(Me.Cost_WoVAT)
        Me.LayoutControl.Controls.Add(Me.Cost_WVAT)
        Me.LayoutControl.Controls.Add(Me.Quantity)
        Me.LayoutControl.Controls.Add(Me.Brand)
        Me.LayoutControl.Controls.Add(Me.Category)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(322, 447)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(80, 12)
        Me.ID.Name = "ID"
        
        Me.ID.Size = New System.Drawing.Size(230, 20)
        Me.ID.StyleController = Me.layoutControl
        Me.ID.TabIndex = 0
        '
        'Parts_Number
        '
        Me.Parts_Number.Location = New System.Drawing.Point(80, 36)
        Me.Parts_Number.Name = "Parts_Number"
        Me.Parts_Number.Size = New System.Drawing.Size(230, 20)
        Me.Parts_Number.StyleController = Me.layoutControl
        Me.Parts_Number.TabIndex = 1
        '
        'Parts_Name
        '
        Me.Parts_Name.Location = New System.Drawing.Point(80, 60)
        Me.Parts_Name.Name = "Parts_Name"
        Me.Parts_Name.Size = New System.Drawing.Size(230, 20)
        Me.Parts_Name.StyleController = Me.layoutControl
        Me.Parts_Name.TabIndex = 2
        '
        'Model_Code
        '
        Me.Model_Code.Location = New System.Drawing.Point(80, 132)
        Me.Model_Code.Name = "Model_Code"
        Me.Model_Code.Size = New System.Drawing.Size(230, 20)
        Me.Model_Code.StyleController = Me.layoutControl
        Me.Model_Code.TabIndex = 5
        '
        'Model_Name
        '
        Me.Model_Name.Location = New System.Drawing.Point(80, 156)
        Me.Model_Name.Name = "Model_Name"
        Me.Model_Name.Size = New System.Drawing.Size(230, 20)
        Me.Model_Name.StyleController = Me.layoutControl
        Me.Model_Name.TabIndex = 6
        '
        'Descriptions
        '
        Me.Descriptions.Location = New System.Drawing.Point(80, 180)
        Me.Descriptions.Name = "Descriptions"
        Me.Descriptions.Size = New System.Drawing.Size(230, 46)
        Me.Descriptions.StyleController = Me.layoutControl
        Me.Descriptions.TabIndex = 7
        '
        'SRP
        '
        Me.SRP.Location = New System.Drawing.Point(80, 230)
        Me.SRP.Name = "SRP"
        Me.SRP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SRP.Properties.DisplayFormat.FormatString = "n2"
        Me.SRP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SRP.Properties.EditFormat.FormatString = "n2"
        Me.SRP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SRP.Properties.Mask.EditMask = "n2"
        Me.SRP.Size = New System.Drawing.Size(230, 20)
        Me.SRP.StyleController = Me.layoutControl
        Me.SRP.TabIndex = 8
        '
        'Cost_WoVAT
        '
        Me.Cost_WoVAT.Location = New System.Drawing.Point(80, 254)
        Me.Cost_WoVAT.Name = "Cost_WoVAT"
        Me.Cost_WoVAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cost_WoVAT.Properties.DisplayFormat.FormatString = "n2"
        Me.Cost_WoVAT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cost_WoVAT.Properties.EditFormat.FormatString = "n2"
        Me.Cost_WoVAT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cost_WoVAT.Properties.Mask.EditMask = "n2"
        Me.Cost_WoVAT.Size = New System.Drawing.Size(230, 20)
        Me.Cost_WoVAT.StyleController = Me.layoutControl
        Me.Cost_WoVAT.TabIndex = 9
        '
        'Cost_WVAT
        '
        Me.Cost_WVAT.Location = New System.Drawing.Point(80, 278)
        Me.Cost_WVAT.Name = "Cost_WVAT"
        Me.Cost_WVAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cost_WVAT.Properties.DisplayFormat.FormatString = "n2"
        Me.Cost_WVAT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cost_WVAT.Properties.EditFormat.FormatString = "n2"
        Me.Cost_WVAT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cost_WVAT.Properties.Mask.EditMask = "n2"
        Me.Cost_WVAT.Size = New System.Drawing.Size(230, 20)
        Me.Cost_WVAT.StyleController = Me.layoutControl
        Me.Cost_WVAT.TabIndex = 10
        '
        'Quantity
        '
        Me.Quantity.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Quantity.Location = New System.Drawing.Point(80, 302)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Quantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Quantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Quantity.Properties.NullText = "0"
        Me.Quantity.Properties.ReadOnly = True
        Me.Quantity.Size = New System.Drawing.Size(230, 20)
        Me.Quantity.StyleController = Me.layoutControl
        Me.Quantity.TabIndex = 11
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(322, 447)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(65, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 314)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(302, 113)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Parts_Number
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem2.Text = "Parts Number"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Parts_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem3.Text = "Parts Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Brand
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem4.Text = "Brand"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Category
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem5.Text = "Category"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Model_Code
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem6.Text = "Model Code"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Model_Name
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem7.Text = "Model Name"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Descriptions
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(0, 50)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(133, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(302, 50)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Descriptions"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.Cost_WVAT
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 266)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem11.Text = "Cost WVAT"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Quantity
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 290)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem12.Text = "Quantity"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Cost_WoVAT
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 242)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem8.Text = "Cost WoVAT"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SRP
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 218)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(302, 24)
        Me.LayoutControlItem9.Text = "SRP"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(65, 13)
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(80, 84)
        Me.Brand.Name = "Brand"
        Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Brand.Properties.Items.AddRange(New Object() {"KAWASAKI", "HONDA", "SUZUKI", "YAMAHA", "TVS", "VESPA", "BMW"})
        Me.Brand.Size = New System.Drawing.Size(230, 20)
        Me.Brand.StyleController = Me.layoutControl
        Me.Brand.TabIndex = 3
        '
        'Category
        '
        Me.Category.Location = New System.Drawing.Point(80, 108)
        Me.Category.Name = "Category"
        Me.Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Category.Properties.Items.AddRange(New Object() {"SPARE PARTS", "LUBRICANTS", "APARRELS", "FREEBIES", "MERCHANDISE"})
        Me.Category.Size = New System.Drawing.Size(230, 20)
        Me.Category.StyleController = Me.layoutControl
        Me.Category.TabIndex = 4
        '
        'xuc_Master_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_Master_Entry"
        Me.Size = New System.Drawing.Size(322, 447)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parts_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parts_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Model_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Model_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Descriptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_WoVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Parts_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Parts_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Model_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Model_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Descriptions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SRP As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Cost_WoVAT As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Cost_WVAT As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Quantity As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Brand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Category As DevExpress.XtraEditors.ComboBoxEdit
End Class
