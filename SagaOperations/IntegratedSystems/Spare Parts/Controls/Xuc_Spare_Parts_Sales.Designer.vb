<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Xuc_Spare_Parts_Sales
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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Address = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SI_Number = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CR_Number = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Terms = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vatable = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Transaction_Category = New DevExpress.XtraEditors.LookUpEdit()
        Me.Invoices = New DevExpress.XtraEditors.LookUpEdit()
        Me.Customer_Name = New DevExpress.XtraEditors.LookUpEdit()
        Me.Transaction_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Note = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SI_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CR_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vatable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Vatable)
        Me.LayoutControl1.Controls.Add(Me.Address)
        Me.LayoutControl1.Controls.Add(Me.SI_Number)
        Me.LayoutControl1.Controls.Add(Me.CR_Number)
        Me.LayoutControl1.Controls.Add(Me.Terms)
        Me.LayoutControl1.Controls.Add(Me.Transaction_Category)
        Me.LayoutControl1.Controls.Add(Me.Invoices)
        Me.LayoutControl1.Controls.Add(Me.Customer_Name)
        Me.LayoutControl1.Controls.Add(Me.Transaction_Date)
        Me.LayoutControl1.Controls.Add(Me.Note)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(383, 361)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(383, 361)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Transaction_Category
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem1.Text = "Transaction Category"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Invoices
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem2.Text = "Invoices"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Customer_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem3.Text = "Customer Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(109, 13)
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(133, 84)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(238, 20)
        Me.Address.StyleController = Me.LayoutControl1
        Me.Address.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Address
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem4.Text = "Address"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(109, 13)
        '
        'SI_Number
        '
        Me.SI_Number.Location = New System.Drawing.Point(133, 108)
        Me.SI_Number.Name = "SI_Number"
        Me.SI_Number.Size = New System.Drawing.Size(238, 20)
        Me.SI_Number.StyleController = Me.LayoutControl1
        Me.SI_Number.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SI_Number
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem5.Text = "SI Number"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(109, 13)
        '
        'CR_Number
        '
        Me.CR_Number.Location = New System.Drawing.Point(133, 132)
        Me.CR_Number.Name = "CR_Number"
        Me.CR_Number.Size = New System.Drawing.Size(238, 20)
        Me.CR_Number.StyleController = Me.LayoutControl1
        Me.CR_Number.TabIndex = 9
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CR_Number
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem6.Text = "CR Number"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(109, 13)
        '
        'Terms
        '
        Me.Terms.Location = New System.Drawing.Point(133, 156)
        Me.Terms.Name = "Terms"
        Me.Terms.Size = New System.Drawing.Size(238, 20)
        Me.Terms.StyleController = Me.LayoutControl1
        Me.Terms.TabIndex = 10
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Terms
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem7.Text = "Terms"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Transaction_Date
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem8.Text = "Date"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(109, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Note
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(363, 126)
        Me.LayoutControlItem9.Text = "Note"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(109, 13)
        '
        'Vatable
        '
        Me.Vatable.EditValue = True
        Me.Vatable.Location = New System.Drawing.Point(12, 204)
        Me.Vatable.Name = "Vatable"
        Me.Vatable.Properties.OffText = "NonVAT"
        Me.Vatable.Properties.OnText = "VAT"
        Me.Vatable.Size = New System.Drawing.Size(359, 19)
        Me.Vatable.StyleController = Me.LayoutControl1
        Me.Vatable.TabIndex = 13
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Vatable
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(363, 23)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'Transaction_Category
        '
        Me.Transaction_Category.Location = New System.Drawing.Point(133, 12)
        Me.Transaction_Category.Name = "Transaction_Category"
        Me.Transaction_Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Category.Properties.NullText = ""
        Me.Transaction_Category.Size = New System.Drawing.Size(238, 20)
        Me.Transaction_Category.StyleController = Me.LayoutControl1
        Me.Transaction_Category.TabIndex = 4
        '
        'Invoices
        '
        Me.Invoices.Location = New System.Drawing.Point(133, 36)
        Me.Invoices.Name = "Invoices"
        Me.Invoices.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Invoices.Properties.NullText = ""
        Me.Invoices.Size = New System.Drawing.Size(238, 20)
        Me.Invoices.StyleController = Me.LayoutControl1
        Me.Invoices.TabIndex = 5
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(133, 60)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Customer_Name.Properties.NullText = ""
        Me.Customer_Name.Size = New System.Drawing.Size(238, 20)
        Me.Customer_Name.StyleController = Me.LayoutControl1
        Me.Customer_Name.TabIndex = 6
        '
        'Transaction_Date
        '
        Me.Transaction_Date.EditValue = Nothing
        Me.Transaction_Date.Location = New System.Drawing.Point(133, 180)
        Me.Transaction_Date.Name = "Transaction_Date"
        Me.Transaction_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Date.Properties.DisplayFormat.FormatString = ""
        Me.Transaction_Date.Properties.EditFormat.FormatString = ""
        Me.Transaction_Date.Properties.Mask.EditMask = ""
        Me.Transaction_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Transaction_Date.Size = New System.Drawing.Size(238, 20)
        Me.Transaction_Date.StyleController = Me.LayoutControl1
        Me.Transaction_Date.TabIndex = 11
        '
        'Note
        '
        Me.Note.Location = New System.Drawing.Point(12, 243)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(359, 106)
        Me.Note.StyleController = Me.LayoutControl1
        Me.Note.TabIndex = 12
        '
        'Xuc_Spare_Parts_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Xuc_Spare_Parts_Sales"
        Me.Size = New System.Drawing.Size(383, 361)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SI_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CR_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vatable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SI_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CR_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Terms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Vatable As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Transaction_Category As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Invoices As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Customer_Name As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Transaction_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Note As DevExpress.XtraEditors.MemoEdit
End Class
