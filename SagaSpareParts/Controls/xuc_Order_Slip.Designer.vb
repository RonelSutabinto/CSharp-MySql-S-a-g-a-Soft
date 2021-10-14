<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_Order_Slip
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
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Order_C0de = New DevExpress.XtraEditors.TextEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Description = New DevExpress.XtraEditors.MemoEdit()
        Me.Order_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Brand = New DevExpress.XtraEditors.LookUpEdit()
        Me.Requested_Branch = New DevExpress.XtraEditors.LookUpEdit()
        Me.SubDealer_Name = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.Order_C0de.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Requested_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubDealer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Controls.Add(Me.Order_C0de)
        Me.LayoutControl.Controls.Add(Me.Notes)
        Me.LayoutControl.Controls.Add(Me.Description)
        Me.LayoutControl.Controls.Add(Me.Order_Date)
        Me.LayoutControl.Controls.Add(Me.Brand)
        Me.LayoutControl.Controls.Add(Me.Requested_Branch)
        Me.LayoutControl.Controls.Add(Me.SubDealer_Name)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(194, 283)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(112, 12)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(70, 20)
        Me.ID.TabIndex = 4
        '
        'Order_C0de
        '
        Me.Order_C0de.Location = New System.Drawing.Point(112, 108)
        Me.Order_C0de.Name = "Order_C0de"
        Me.Order_C0de.Properties.BeepOnError = False
        Me.Order_C0de.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.SimpleMaskManager))
        Me.Order_C0de.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True")
        Me.Order_C0de.Size = New System.Drawing.Size(70, 20)
        Me.Order_C0de.StyleController = Me.layoutControl
        Me.Order_C0de.TabIndex = 7
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(112, 211)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(70, 60)
        Me.Notes.StyleController = Me.layoutControl
        Me.Notes.TabIndex = 10
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(112, 156)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(70, 51)
        Me.Description.StyleController = Me.layoutControl
        Me.Description.TabIndex = 9
        '
        'Order_Date
        '
        Me.Order_Date.EditValue = Nothing
        Me.Order_Date.Location = New System.Drawing.Point(112, 132)
        Me.Order_Date.Name = "Order_Date"
        Me.Order_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Order_Date.Properties.DisplayFormat.FormatString = ""
        Me.Order_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.EditFormat.FormatString = ""
        Me.Order_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Order_Date.Properties.MaskSettings.Set("mask", "")
        Me.Order_Date.Size = New System.Drawing.Size(70, 20)
        Me.Order_Date.StyleController = Me.layoutControl
        Me.Order_Date.TabIndex = 8
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(112, 60)
        Me.Brand.Name = "Brand"
        Me.Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Brand.Properties.NullText = ""
        Me.Brand.Size = New System.Drawing.Size(70, 20)
        Me.Brand.StyleController = Me.layoutControl
        Me.Brand.TabIndex = 6
        '
        'Requested_Branch
        '
        Me.Requested_Branch.Location = New System.Drawing.Point(112, 36)
        Me.Requested_Branch.Name = "Requested_Branch"
        Me.Requested_Branch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Requested_Branch.Properties.NullText = ""
        Me.Requested_Branch.Size = New System.Drawing.Size(70, 20)
        Me.Requested_Branch.StyleController = Me.layoutControl
        Me.Requested_Branch.TabIndex = 5
        '
        'SubDealer_Name
        '
        Me.SubDealer_Name.Location = New System.Drawing.Point(112, 84)
        Me.SubDealer_Name.Name = "SubDealer_Name"
        Me.SubDealer_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubDealer_Name.Properties.NullText = ""
        Me.SubDealer_Name.Size = New System.Drawing.Size(70, 20)
        Me.SubDealer_Name.StyleController = Me.layoutControl
        Me.SubDealer_Name.TabIndex = 11
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(194, 283)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Requested_Branch
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem2.Text = "Requested Branch"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Brand
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem3.Text = "Brand"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Order_C0de
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem4.Text = "Order Code"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Order_Date
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem5.Text = "Order Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Description
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 55)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(114, 55)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(174, 55)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Description"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Notes
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 199)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(174, 64)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Notes"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SubDealer_Name
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem8.Text = "Sub-Dealer"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(88, 13)
        '
        'xuc_Order_Slip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_Order_Slip"
        Me.Size = New System.Drawing.Size(194, 283)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.Order_C0de.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Requested_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubDealer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As TextBox
    Friend WithEvents Order_C0de As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Order_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Brand As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Requested_Branch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SubDealer_Name As DevExpress.XtraEditors.LookUpEdit
End Class
