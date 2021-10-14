<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Xuc_Sales
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
        Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
        Me.Xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.Xuc_Account_Search()
        Me.SI_Number = New DevExpress.XtraEditors.TextEdit()
        Me.Address = New DevExpress.XtraEditors.TextEdit()
        Me.Transaction_Category = New DevExpress.XtraEditors.LookUpEdit()
        Me.Invoices = New DevExpress.XtraEditors.LookUpEdit()
        Me.Customer_Name = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Terms = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Pricing = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl.SuspendLayout()
        CType(Me.SI_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoices.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pricing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.PopupContainerControl)
        Me.LayoutControl.Controls.Add(Me.SI_Number)
        Me.LayoutControl.Controls.Add(Me.Address)
        Me.LayoutControl.Controls.Add(Me.Transaction_Category)
        Me.LayoutControl.Controls.Add(Me.Invoices)
        Me.LayoutControl.Controls.Add(Me.Customer_Name)
        Me.LayoutControl.Controls.Add(Me.Terms)
        Me.LayoutControl.Controls.Add(Me.Posting_Date)
        Me.LayoutControl.Controls.Add(Me.Notes)
        Me.LayoutControl.Controls.Add(Me.Pricing)
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(298, 486)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'PopupContainerControl
        '
        Me.PopupContainerControl.Controls.Add(Me.Xuc_Account_Search)
        Me.PopupContainerControl.Location = New System.Drawing.Point(86, 275)
        Me.PopupContainerControl.Name = "PopupContainerControl"
        Me.PopupContainerControl.Size = New System.Drawing.Size(200, 100)
        Me.PopupContainerControl.TabIndex = 16
        '
        'Xuc_Account_Search
        '
        Me.Xuc_Account_Search.AccountName = Nothing
        Me.Xuc_Account_Search.Code = Nothing
        Me.Xuc_Account_Search.Code2 = Nothing
        Me.Xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Account_Search.ID = 0
        Me.Xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Account_Search.Name = "Xuc_Account_Search"
        Me.Xuc_Account_Search.Others = Nothing
        Me.Xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.Xuc_Account_Search.Search_Mode.searchGlobal
        Me.Xuc_Account_Search.Size = New System.Drawing.Size(200, 100)
        Me.Xuc_Account_Search.TabIndex = 16
        Me.Xuc_Account_Search.Type = Nothing
        '
        'SI_Number
        '
        Me.SI_Number.Location = New System.Drawing.Point(128, 132)
        Me.SI_Number.Name = "SI_Number"
        Me.SI_Number.Size = New System.Drawing.Size(158, 20)
        Me.SI_Number.TabIndex = 3
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(128, 108)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(158, 20)
        Me.Address.TabIndex = 4
        '
        'Transaction_Category
        '
        Me.Transaction_Category.Location = New System.Drawing.Point(128, 36)
        Me.Transaction_Category.Name = "Transaction_Category"
        Me.Transaction_Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Category.Properties.NullText = ""
        Me.Transaction_Category.Size = New System.Drawing.Size(158, 20)
        Me.Transaction_Category.TabIndex = 0
        '
        'Invoices
        '
        Me.Invoices.Location = New System.Drawing.Point(128, 60)
        Me.Invoices.Name = "Invoices"
        Me.Invoices.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Invoices.Properties.NullText = ""
        Me.Invoices.Size = New System.Drawing.Size(158, 20)
        Me.Invoices.TabIndex = 1
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(128, 84)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Customer_Name.Properties.PopupControl = Me.PopupContainerControl
        Me.Customer_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Customer_Name.Size = New System.Drawing.Size(158, 20)
        Me.Customer_Name.TabIndex = 2
        '
        'Terms
        '
        Me.Terms.Location = New System.Drawing.Point(128, 156)
        Me.Terms.Name = "Terms"
        Me.Terms.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Terms.Properties.Items.AddRange(New Object() {"30", "45", "60"})
        Me.Terms.Size = New System.Drawing.Size(158, 20)
        Me.Terms.TabIndex = 5
        '
        'Posting_Date
        '
        Me.Posting_Date.EditValue = Nothing
        Me.Posting_Date.Location = New System.Drawing.Point(128, 180)
        Me.Posting_Date.Name = "Posting_Date"
        Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.DisplayFormat.FormatString = ""
        Me.Posting_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Posting_Date.Properties.EditFormat.FormatString = ""
        Me.Posting_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Posting_Date.Properties.Mask.EditMask = ""
        Me.Posting_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Posting_Date.Size = New System.Drawing.Size(158, 20)
        Me.Posting_Date.TabIndex = 6
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(128, 228)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(158, 246)
        Me.Notes.TabIndex = 8
        '
        'Pricing
        '
        Me.Pricing.Location = New System.Drawing.Point(128, 204)
        Me.Pricing.Name = "Pricing"
        Me.Pricing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Pricing.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.Pricing.Size = New System.Drawing.Size(158, 20)
        Me.Pricing.TabIndex = 7
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(128, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(158, 20)
        Me.ID.TabIndex = 17
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem10})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(298, 486)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Transaction_Category
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem1.Text = "Transaction Category"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Invoices
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem2.Text = "Invoices"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Customer_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem3.Text = "Customer Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SI_Number
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem4.Text = "SI Number"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Terms
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem6.Text = "Terms"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Posting_Date
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem7.Text = "Date"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Notes
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(278, 250)
        Me.LayoutControlItem8.Text = "Note"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Pricing
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem9.Text = "Pricing"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Address
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem5.Text = "Address"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.ID
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem10.Text = "ID"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(104, 13)
        '
        'Xuc_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "Xuc_Sales"
        Me.Size = New System.Drawing.Size(298, 486)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl.ResumeLayout(False)
        CType(Me.SI_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoices.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pricing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SI_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Transaction_Category As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Invoices As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Customer_Name As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Terms As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Posting_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Pricing As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents xuc_Account_Search As SagaClassLibrary.Controls.Information.Account.Xuc_Account_Search
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
End Class
