<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_SPA_Master
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.Part_Number = New DevExpress.XtraEditors.TextEdit()
        Me.Part_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Brand = New DevExpress.XtraEditors.LookUpEdit()
        Me.Category = New DevExpress.XtraEditors.LookUpEdit()
        Me.SRP = New DevExpress.XtraEditors.CalcEdit()
        Me.Cost_WoVAT = New DevExpress.XtraEditors.CalcEdit()
        Me.Cost_WVAT = New DevExpress.XtraEditors.CalcEdit()
        Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Part_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Part_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_WoVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ID)
        Me.LayoutControl1.Controls.Add(Me.Part_Number)
        Me.LayoutControl1.Controls.Add(Me.Part_Name)
        Me.LayoutControl1.Controls.Add(Me.Brand)
        Me.LayoutControl1.Controls.Add(Me.Category)
        Me.LayoutControl1.Controls.Add(Me.SRP)
        Me.LayoutControl1.Controls.Add(Me.Cost_WoVAT)
        Me.LayoutControl1.Controls.Add(Me.Cost_WVAT)
        Me.LayoutControl1.Controls.Add(Me.Posting_Date)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(185, 251)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(85, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(88, 20)
        Me.ID.StyleController = Me.LayoutControl1
        Me.ID.TabIndex = 4
        '
        'Part_Number
        '
        Me.Part_Number.Location = New System.Drawing.Point(85, 36)
        Me.Part_Number.Name = "Part_Number"
        Me.Part_Number.Size = New System.Drawing.Size(88, 20)
        Me.Part_Number.StyleController = Me.LayoutControl1
        Me.Part_Number.TabIndex = 5
        '
        'Part_Name
        '
        Me.Part_Name.Location = New System.Drawing.Point(85, 60)
        Me.Part_Name.Name = "Part_Name"
        Me.Part_Name.Size = New System.Drawing.Size(88, 20)
        Me.Part_Name.StyleController = Me.LayoutControl1
        Me.Part_Name.TabIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(185, 251)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(61, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 216)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(165, 15)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Part_Number
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem2.Text = "Part Number"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Part_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem3.Text = "Part Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Brand
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem4.Text = "Brand"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Category
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem5.Text = "Category"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SRP
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem6.Text = "SRP"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Cost_WoVAT
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem7.Text = "Cost WoVAT"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Cost_WVAT
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem8.Text = "Cost WVAT"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Posting_Date
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem9.Text = "Posting Date"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(61, 13)
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(85, 84)
        Me.Brand.Name = "Brand"
        Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Brand.Properties.NullText = ""
        Me.Brand.Size = New System.Drawing.Size(88, 20)
        Me.Brand.StyleController = Me.LayoutControl1
        Me.Brand.TabIndex = 7
        '
        'Category
        '
        Me.Category.Location = New System.Drawing.Point(85, 108)
        Me.Category.Name = "Category"
        Me.Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Category.Properties.NullText = ""
        Me.Category.Size = New System.Drawing.Size(88, 20)
        Me.Category.StyleController = Me.LayoutControl1
        Me.Category.TabIndex = 8
        '
        'SRP
        '
        Me.SRP.Location = New System.Drawing.Point(85, 132)
        Me.SRP.Name = "SRP"
        Me.SRP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SRP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SRP.Size = New System.Drawing.Size(88, 20)
        Me.SRP.StyleController = Me.LayoutControl1
        Me.SRP.TabIndex = 9
        '
        'Cost_WoVAT
        '
        Me.Cost_WoVAT.Location = New System.Drawing.Point(85, 156)
        Me.Cost_WoVAT.Name = "Cost_WoVAT"
        Me.Cost_WoVAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cost_WoVAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Cost_WoVAT.Size = New System.Drawing.Size(88, 20)
        Me.Cost_WoVAT.StyleController = Me.LayoutControl1
        Me.Cost_WoVAT.TabIndex = 10
        '
        'Cost_WVAT
        '
        Me.Cost_WVAT.Location = New System.Drawing.Point(85, 180)
        Me.Cost_WVAT.Name = "Cost_WVAT"
        Me.Cost_WVAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cost_WVAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Cost_WVAT.Size = New System.Drawing.Size(88, 20)
        Me.Cost_WVAT.StyleController = Me.LayoutControl1
        Me.Cost_WVAT.TabIndex = 11
        '
        'Posting_Date
        '
        Me.Posting_Date.EditValue = Nothing
        Me.Posting_Date.Location = New System.Drawing.Point(85, 204)
        Me.Posting_Date.Name = "Posting_Date"
        Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.DisplayFormat.FormatString = ""
        Me.Posting_Date.Properties.EditFormat.FormatString = ""
        Me.Posting_Date.Properties.Mask.EditMask = ""
        Me.Posting_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Posting_Date.Size = New System.Drawing.Size(88, 20)
        Me.Posting_Date.StyleController = Me.LayoutControl1
        Me.Posting_Date.TabIndex = 12
        '
        'xuc_SPA_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xuc_SPA_Master"
        Me.Size = New System.Drawing.Size(185, 251)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Part_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Part_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_WoVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Part_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Part_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Brand As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Category As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SRP As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Cost_WoVAT As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Cost_WVAT As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Posting_Date As DevExpress.XtraEditors.DateEdit
End Class
