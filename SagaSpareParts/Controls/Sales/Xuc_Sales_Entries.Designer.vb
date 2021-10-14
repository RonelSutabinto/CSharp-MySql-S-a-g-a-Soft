<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Xuc_Sales_Entries
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
        Me.gridControl_List = New DevExpress.XtraGrid.GridControl()
        Me.gridView_List = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatch_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_PartNumber = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscount_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGross_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNet_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
        Me.Xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
        Me.SI_Number = New DevExpress.XtraEditors.TextEdit()
        Me.Address = New DevExpress.XtraEditors.TextEdit()
        Me.Transaction_Category = New DevExpress.XtraEditors.LookUpEdit()
        Me.Invoices = New DevExpress.XtraEditors.LookUpEdit()
        Me.Customer_Name = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Terms = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Pricing = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.PDC_Name = New DevExpress.XtraEditors.TextEdit()
        Me.PDC_Code = New DevExpress.XtraEditors.TextEdit()
        Me.Toggle_PDC = New DevExpress.XtraEditors.ToggleSwitch()
        Me.PDC_Amount = New DevExpress.XtraEditors.CalcEdit()
        Me.PDC_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toggle_PDC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.gridControl_List)
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
        Me.LayoutControl.Controls.Add(Me.TextEdit1)
        Me.LayoutControl.Controls.Add(Me.PDC_Name)
        Me.LayoutControl.Controls.Add(Me.PDC_Code)
        Me.LayoutControl.Controls.Add(Me.Toggle_PDC)
        Me.LayoutControl.Controls.Add(Me.PDC_Amount)
        Me.LayoutControl.Controls.Add(Me.PDC_Date)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(693, 486)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'gridControl_List
        '
        Me.gridControl_List.Location = New System.Drawing.Point(12, 256)
        Me.gridControl_List.MainView = Me.gridView_List
        Me.gridControl_List.Name = "gridControl_List"
        Me.gridControl_List.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_PartNumber, Me.RepositoryItemSpinEdit_Quantity})
        Me.gridControl_List.Size = New System.Drawing.Size(669, 194)
        Me.gridControl_List.TabIndex = 18
        Me.gridControl_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_List})
        '
        'gridView_List
        '
        Me.gridView_List.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_List, Me.colBatch_Id, Me.colPartsNumber, Me.colPartsName, Me.colBrand, Me.colCategory, Me.colQuantity, Me.colCost, Me.colDiscount_SRP, Me.colSRP, Me.colGross_Total, Me.colNet_Total})
        Me.gridView_List.gridControl = Me.gridControl_List
        Me.gridView_List.Name = "gridView_List"
        '
        'colID_List
        '
        Me.colID_List.FieldName = "ID"
        Me.colID_List.Name = "colID_List"
        Me.colID_List.Visible = True
        Me.colID_List.VisibleIndex = 0
        '
        'colBatch_Id
        '
        Me.colBatch_Id.Caption = "Batch ID"
        Me.colBatch_Id.ColumnEdit = Me.RepositoryItemLookUpEdit_PartNumber
        Me.colBatch_Id.FieldName = "prev_ID"
        Me.colBatch_Id.Name = "colBatch_Id"
        Me.colBatch_Id.Visible = True
        Me.colBatch_Id.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit_PartNumber
        '
        Me.RepositoryItemLookUpEdit_PartNumber.AutoHeight = False
        Me.RepositoryItemLookUpEdit_PartNumber.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_PartNumber.Name = "RepositoryItemLookUpEdit_PartNumber"
        '
        'colPartsNumber
        '
        Me.colPartsNumber.FieldName = "PartsNumber"
        Me.colPartsNumber.Name = "colPartsNumber"
        Me.colPartsNumber.Visible = True
        Me.colPartsNumber.VisibleIndex = 2
        '
        'colPartsName
        '
        Me.colPartsName.FieldName = "PartsName"
        Me.colPartsName.Name = "colPartsName"
        Me.colPartsName.Visible = True
        Me.colPartsName.VisibleIndex = 3
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 4
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 5
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 6
        '
        'colCost
        '
        Me.colCost.FieldName = "SPCostWOVAT"
        Me.colCost.Name = "colCost"
        Me.colCost.Visible = True
        Me.colCost.VisibleIndex = 7
        '
        'colDiscount_SRP
        '
        Me.colDiscount_SRP.FieldName = "Discount_SRP"
        Me.colDiscount_SRP.Name = "colDiscount_SRP"
        Me.colDiscount_SRP.Visible = True
        Me.colDiscount_SRP.VisibleIndex = 8
        '
        'colSRP
        '
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 9
        '
        'colGross_Total
        '
        Me.colGross_Total.FieldName = "GrossTotal"
        Me.colGross_Total.Name = "colGross_Total"
        Me.colGross_Total.Visible = True
        Me.colGross_Total.VisibleIndex = 10
        '
        'colNet_Total
        '
        Me.colNet_Total.FieldName = "SubTotal"
        Me.colNet_Total.Name = "colNet_Total"
        Me.colNet_Total.Visible = True
        Me.colNet_Total.VisibleIndex = 11
        '
        'RepositoryItemSpinEdit_Quantity
        '
        Me.RepositoryItemSpinEdit_Quantity.AutoHeight = False
        Me.RepositoryItemSpinEdit_Quantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit_Quantity.Name = "RepositoryItemSpinEdit_Quantity"
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
        Me.Xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Xuc_Account_Search.Code = Nothing
        Me.Xuc_Account_Search.Code2 = Nothing
        Me.Xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Account_Search.ID = 0
        Me.Xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Account_Search.Name = "Xuc_Account_Search"
        Me.Xuc_Account_Search.Others = Nothing
        Me.Xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
        Me.Xuc_Account_Search.Size = New System.Drawing.Size(200, 100)
        Me.Xuc_Account_Search.TabIndex = 16
        Me.Xuc_Account_Search.Type = Nothing
        '
        'SI_Number
        '
        Me.SI_Number.Location = New System.Drawing.Point(128, 84)
        Me.SI_Number.Name = "SI_Number"
        Me.SI_Number.Properties.BeepOnError = False
        Me.SI_Number.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.SimpleMaskManager))
        Me.SI_Number.Size = New System.Drawing.Size(216, 20)
        Me.SI_Number.StyleController = Me.layoutControl
        Me.SI_Number.TabIndex = 3
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(128, 60)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(553, 20)
        Me.Address.StyleController = Me.layoutControl
        Me.Address.TabIndex = 4
        '
        'Transaction_Category
        '
        Me.Transaction_Category.Location = New System.Drawing.Point(128, 12)
        Me.Transaction_Category.Name = "Transaction_Category"
        Me.Transaction_Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Category.Properties.NullText = ""
        Me.Transaction_Category.Size = New System.Drawing.Size(216, 20)
        Me.Transaction_Category.StyleController = Me.layoutControl
        Me.Transaction_Category.TabIndex = 0
        '
        'Invoices
        '
        Me.Invoices.Location = New System.Drawing.Point(464, 12)
        Me.Invoices.Name = "Invoices"
        Me.Invoices.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Invoices.Properties.NullText = ""
        Me.Invoices.Size = New System.Drawing.Size(217, 20)
        Me.Invoices.StyleController = Me.layoutControl
        Me.Invoices.TabIndex = 1
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(128, 36)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Customer_Name.Properties.PopupControl = Me.PopupContainerControl
        Me.Customer_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Customer_Name.Size = New System.Drawing.Size(553, 20)
        Me.Customer_Name.StyleController = Me.layoutControl
        Me.Customer_Name.TabIndex = 2
        '
        'Terms
        '
        Me.Terms.Location = New System.Drawing.Point(464, 84)
        Me.Terms.Name = "Terms"
        Me.Terms.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Terms.Properties.Items.AddRange(New Object() {"30", "45", "60"})
        Me.Terms.Size = New System.Drawing.Size(217, 20)
        Me.Terms.StyleController = Me.layoutControl
        Me.Terms.TabIndex = 5
        '
        'Posting_Date
        '
        Me.Posting_Date.EditValue = Nothing
        Me.Posting_Date.Location = New System.Drawing.Point(128, 108)
        Me.Posting_Date.Name = "Posting_Date"
        Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Posting_Date.Properties.DisplayFormat.FormatString = ""
        Me.Posting_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Posting_Date.Properties.EditFormat.FormatString = ""
        Me.Posting_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Posting_Date.Properties.Mask.EditMask = ""
        Me.Posting_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Posting_Date.Size = New System.Drawing.Size(216, 20)
        Me.Posting_Date.StyleController = Me.layoutControl
        Me.Posting_Date.TabIndex = 6
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(128, 226)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(553, 26)
        Me.Notes.StyleController = Me.layoutControl
        Me.Notes.TabIndex = 8
        '
        'Pricing
        '
        Me.Pricing.Location = New System.Drawing.Point(464, 108)
        Me.Pricing.Name = "Pricing"
        Me.Pricing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Pricing.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.Pricing.Size = New System.Drawing.Size(217, 20)
        Me.Pricing.StyleController = Me.layoutControl
        Me.Pricing.TabIndex = 7
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(128, 454)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TextEdit1.Size = New System.Drawing.Size(553, 20)
        Me.TextEdit1.StyleController = Me.layoutControl
        Me.TextEdit1.TabIndex = 19
        '
        'PDC_Name
        '
        Me.PDC_Name.Location = New System.Drawing.Point(128, 154)
        Me.PDC_Name.Name = "PDC_Name"
        Me.PDC_Name.Properties.ReadOnly = True
        Me.PDC_Name.Size = New System.Drawing.Size(553, 20)
        Me.PDC_Name.StyleController = Me.layoutControl
        Me.PDC_Name.TabIndex = 20
        '
        'PDC_Code
        '
        Me.PDC_Code.Location = New System.Drawing.Point(128, 178)
        Me.PDC_Code.Name = "PDC_Code"
        Me.PDC_Code.Properties.ReadOnly = True
        Me.PDC_Code.Size = New System.Drawing.Size(216, 20)
        Me.PDC_Code.StyleController = Me.layoutControl
        Me.PDC_Code.TabIndex = 21
        '
        'Toggle_PDC
        '
        Me.Toggle_PDC.EditValue = Nothing
        Me.Toggle_PDC.Location = New System.Drawing.Point(132, 132)
        Me.Toggle_PDC.Name = "Toggle_PDC"
        Me.Toggle_PDC.Properties.AutoHeight = False
        Me.Toggle_PDC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Toggle_PDC.Properties.OffText = "Without PDC"
        Me.Toggle_PDC.Properties.OnText = "With PDC"
        Me.Toggle_PDC.Properties.ReadOnly = True
        Me.Toggle_PDC.Size = New System.Drawing.Size(549, 18)
        Me.Toggle_PDC.StyleController = Me.layoutControl
        Me.Toggle_PDC.TabIndex = 23
        '
        'PDC_Amount
        '
        Me.PDC_Amount.Location = New System.Drawing.Point(128, 202)
        Me.PDC_Amount.Name = "PDC_Amount"
        Me.PDC_Amount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PDC_Amount.Properties.ReadOnly = True
        Me.PDC_Amount.Size = New System.Drawing.Size(553, 20)
        Me.PDC_Amount.StyleController = Me.layoutControl
        Me.PDC_Amount.TabIndex = 24
        '
        'PDC_Date
        '
        Me.PDC_Date.EditValue = Nothing
        Me.PDC_Date.Location = New System.Drawing.Point(464, 178)
        Me.PDC_Date.Name = "PDC_Date"
        Me.PDC_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PDC_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PDC_Date.Properties.DisplayFormat.FormatString = ""
        Me.PDC_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PDC_Date.Properties.EditFormat.FormatString = ""
        Me.PDC_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PDC_Date.Properties.Mask.EditMask = ""
        Me.PDC_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.PDC_Date.Properties.ReadOnly = True
        Me.PDC_Date.Size = New System.Drawing.Size(217, 20)
        Me.PDC_Date.StyleController = Me.layoutControl
        Me.PDC_Date.TabIndex = 22
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(693, 486)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.gridControl_List
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 244)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(673, 198)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.TextEdit1
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 442)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(673, 24)
        Me.LayoutControlItem12.Text = "Payments"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Notes
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 214)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(673, 30)
        Me.LayoutControlItem8.Text = "Note"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Posting_Date
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem7.Text = "Date"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Pricing
        Me.LayoutControlItem9.Location = New System.Drawing.Point(336, 96)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(337, 24)
        Me.LayoutControlItem9.Text = "Pricing"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SI_Number
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem4.Text = "SI Number"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Terms
        Me.LayoutControlItem6.Location = New System.Drawing.Point(336, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(337, 24)
        Me.LayoutControlItem6.Text = "Terms"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Address
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(673, 24)
        Me.LayoutControlItem5.Text = "Address"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Customer_Name
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(673, 24)
        Me.LayoutControlItem3.Text = "Customer Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Transaction_Category
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem1.Text = "Transaction Category"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Invoices
        Me.LayoutControlItem2.Location = New System.Drawing.Point(336, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(337, 24)
        Me.LayoutControlItem2.Text = "Invoices"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PDC_Name
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(673, 24)
        Me.LayoutControlItem10.Text = "PDC Name"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.PDC_Code
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(336, 24)
        Me.LayoutControlItem13.Text = "PDC Code"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.PDC_Date
        Me.LayoutControlItem14.Location = New System.Drawing.Point(336, 166)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(337, 24)
        Me.LayoutControlItem14.Text = "PDC Date"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Toggle_PDC
        Me.LayoutControlItem15.Location = New System.Drawing.Point(120, 120)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(553, 22)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.PDC_Amount
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(673, 24)
        Me.LayoutControlItem16.Text = "PDC Amount"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(104, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(120, 22)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Xuc_Sales_Entries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "Xuc_Sales_Entries"
        Me.Size = New System.Drawing.Size(693, 486)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toggle_PDC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridControl_List As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView_List As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatch_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_PartNumber As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount_SRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGross_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNet_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents PDC_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PDC_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Toggle_PDC As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PDC_Amount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PDC_Date As DevExpress.XtraEditors.DateEdit
End Class
