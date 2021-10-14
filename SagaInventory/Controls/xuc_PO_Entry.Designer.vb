<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_PO_Entry
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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Branch = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Entry_Date = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Parts_Number = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Parts_Name = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Cost_WVAT = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PO_Number = New DevExpress.XtraEditors.LookUpEdit()
        Me.SRP = New DevExpress.XtraEditors.CalcEdit()
        Me.QTY = New DevExpress.XtraEditors.CalcEdit()
        Me.Total = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entry_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parts_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parts_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PO_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QTY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Controls.Add(Me.Branch)
        Me.LayoutControl.Controls.Add(Me.Entry_Date)
        Me.LayoutControl.Controls.Add(Me.Parts_Number)
        Me.LayoutControl.Controls.Add(Me.Parts_Name)
        Me.LayoutControl.Controls.Add(Me.Cost_WVAT)
        Me.LayoutControl.Controls.Add(Me.PO_Number)
        Me.LayoutControl.Controls.Add(Me.SRP)
        Me.LayoutControl.Controls.Add(Me.QTY)
        Me.LayoutControl.Controls.Add(Me.Total)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(287, 416)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(287, 416)
        Me.Root.TextVisible = False
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(89, 12)
        Me.ID.Name = "ID"
        
        Me.ID.Size = New System.Drawing.Size(186, 20)
        Me.ID.StyleController = Me.layoutControl
        Me.ID.TabIndex = 0
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(65, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 240)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(267, 156)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PO_Number
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem2.Text = "PO Number"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
        '
        'Branch
        '
        Me.Branch.Location = New System.Drawing.Point(89, 60)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(186, 20)
        Me.Branch.StyleController = Me.layoutControl
        Me.Branch.TabIndex = 2
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Branch
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem3.Text = "Branch"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(65, 13)
        '
        'Entry_Date
        '
        Me.Entry_Date.Location = New System.Drawing.Point(89, 84)
        Me.Entry_Date.Name = "Entry_Date"
        Me.Entry_Date.Size = New System.Drawing.Size(186, 20)
        Me.Entry_Date.StyleController = Me.layoutControl
        Me.Entry_Date.TabIndex = 3
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Entry_Date
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem4.Text = "Date"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(65, 13)
        '
        'Parts_Number
        '
        Me.Parts_Number.Location = New System.Drawing.Point(89, 108)
        Me.Parts_Number.Name = "Parts_Number"
        Me.Parts_Number.Size = New System.Drawing.Size(186, 20)
        Me.Parts_Number.StyleController = Me.layoutControl
        Me.Parts_Number.TabIndex = 4
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Parts_Number
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem5.Text = "Parts Number"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(65, 13)
        '
        'Parts_Name
        '
        Me.Parts_Name.Location = New System.Drawing.Point(89, 132)
        Me.Parts_Name.Name = "Parts_Name"
        Me.Parts_Name.Size = New System.Drawing.Size(186, 20)
        Me.Parts_Name.StyleController = Me.layoutControl
        Me.Parts_Name.TabIndex = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Parts_Name
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem6.Text = "Parts Name"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(65, 13)
        '
        'Cost_WVAT
        '
        Me.Cost_WVAT.Location = New System.Drawing.Point(89, 156)
        Me.Cost_WVAT.Name = "Cost_WVAT"
        Me.Cost_WVAT.Size = New System.Drawing.Size(186, 20)
        Me.Cost_WVAT.StyleController = Me.layoutControl
        Me.Cost_WVAT.TabIndex = 6
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Cost_WVAT
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem7.Text = "Cost WVAT"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SRP
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem8.Text = "SRP"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.QTY
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem9.Text = "QTY"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Total
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem10.Text = "TOTAL"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(65, 13)
        '
        'PO_Number
        '
        Me.PO_Number.Location = New System.Drawing.Point(89, 36)
        Me.PO_Number.Name = "PO_Number"
        Me.PO_Number.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PO_Number.Properties.NullText = ""
        Me.PO_Number.Size = New System.Drawing.Size(186, 20)
        Me.PO_Number.StyleController = Me.layoutControl
        Me.PO_Number.TabIndex = 1
        '
        'SRP
        '
        Me.SRP.Location = New System.Drawing.Point(89, 180)
        Me.SRP.Name = "SRP"
        Me.SRP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SRP.Properties.DisplayFormat.FormatString = "n2"
        Me.SRP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SRP.Properties.EditFormat.FormatString = "n2"
        Me.SRP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SRP.Properties.Mask.EditMask = "n2"
        Me.SRP.Size = New System.Drawing.Size(186, 20)
        Me.SRP.StyleController = Me.layoutControl
        Me.SRP.TabIndex = 7
        '
        'QTY
        '
        Me.QTY.Location = New System.Drawing.Point(89, 204)
        Me.QTY.Name = "QTY"
        Me.QTY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QTY.Properties.DisplayFormat.FormatString = "n2"
        Me.QTY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QTY.Properties.EditFormat.FormatString = "n2"
        Me.QTY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QTY.Properties.Mask.EditMask = "n2"
        Me.QTY.Size = New System.Drawing.Size(186, 20)
        Me.QTY.StyleController = Me.layoutControl
        Me.QTY.TabIndex = 8
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(89, 228)
        Me.Total.Name = "Total"
        Me.Total.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Total.Properties.DisplayFormat.FormatString = "n2"
        Me.Total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.Properties.EditFormat.FormatString = "n2"
        Me.Total.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.Properties.Mask.EditMask = "n2"
        Me.Total.Properties.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(186, 20)
        Me.Total.StyleController = Me.layoutControl
        Me.Total.TabIndex = 9
        '
        'xuc_PO_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_PO_Entry"
        Me.Size = New System.Drawing.Size(287, 416)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entry_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parts_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parts_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_WVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PO_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QTY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Branch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Entry_Date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Parts_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Parts_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cost_WVAT As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PO_Number As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SRP As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents QTY As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Total As DevExpress.XtraEditors.CalcEdit
End Class
