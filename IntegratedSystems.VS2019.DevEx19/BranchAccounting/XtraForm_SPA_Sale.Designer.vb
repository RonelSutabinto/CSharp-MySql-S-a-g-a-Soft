Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm_Spare_Part
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
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
            Me.components = New System.ComponentModel.Container()
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.coltrans_Category = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCRNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoices = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPartNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCostTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountDue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNetProfit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.Btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Parameters = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.BarEditItem_Start = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_End = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.Btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridControl
            '
            Me.GridControl.DataMember = "SPA_Sales_Report"
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 41)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.Size = New System.Drawing.Size(631, 343)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colBranchCode, Me.colCategory, Me.coltrans_Category, Me.colBrand, Me.colReference, Me.colCRNumber, Me.colInvoices, Me.colPartNumber, Me.colCustName, Me.colQuantity, Me.colUnitCost, Me.colCostTotal, Me.colSRP, Me.colDiscount, Me.colSubTotal, Me.colAmountDue, Me.colAmountPaid, Me.colNetProfit, Me.colPostingDate, Me.colTransactedBy, Me.colTransactionDate, Me.colRemarks})
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            Me.GridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colIsJournal
            '
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 2
            '
            'colCategory
            '
            Me.colCategory.Caption = "Category"
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 3
            '
            'coltrans_Category
            '
            Me.coltrans_Category.Caption = "Transaction"
            Me.coltrans_Category.FieldName = "trans_Category"
            Me.coltrans_Category.Name = "coltrans_Category"
            Me.coltrans_Category.Visible = True
            Me.coltrans_Category.VisibleIndex = 4
            '
            'colBrand
            '
            Me.colBrand.Caption = "Brand"
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 5
            '
            'colReference
            '
            Me.colReference.Caption = "Reference"
            Me.colReference.FieldName = "SINo"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 6
            '
            'colCRNumber
            '
            Me.colCRNumber.Caption = "CR Number"
            Me.colCRNumber.FieldName = "CRNumber"
            Me.colCRNumber.Name = "colCRNumber"
            Me.colCRNumber.Visible = True
            Me.colCRNumber.VisibleIndex = 7
            '
            'colInvoices
            '
            Me.colInvoices.Caption = "Type"
            Me.colInvoices.FieldName = "Invoices"
            Me.colInvoices.Name = "colInvoices"
            Me.colInvoices.Visible = True
            Me.colInvoices.VisibleIndex = 8
            '
            'colPartNumber
            '
            Me.colPartNumber.Caption = "Part Number"
            Me.colPartNumber.FieldName = "PartsNumber"
            Me.colPartNumber.Name = "colPartNumber"
            Me.colPartNumber.Visible = True
            Me.colPartNumber.VisibleIndex = 9
            '
            'colCustName
            '
            Me.colCustName.Caption = "Customer Name"
            Me.colCustName.FieldName = "cust_Name"
            Me.colCustName.Name = "colCustName"
            Me.colCustName.Visible = True
            Me.colCustName.VisibleIndex = 10
            '
            'colQuantity
            '
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 11
            '
            'colUnitCost
            '
            Me.colUnitCost.Caption = "Unit Cost"
            Me.colUnitCost.FieldName = "SPCostWoVAT"
            Me.colUnitCost.Name = "colUnitCost"
            Me.colUnitCost.Visible = True
            Me.colUnitCost.VisibleIndex = 12
            '
            'colCostTotal
            '
            Me.colCostTotal.Caption = "Total Cost"
            Me.colCostTotal.FieldName = "CostTotal"
            Me.colCostTotal.Name = "colCostTotal"
            Me.colCostTotal.Visible = True
            Me.colCostTotal.VisibleIndex = 13
            '
            'colSRP
            '
            Me.colSRP.Caption = "Unit Price"
            Me.colSRP.FieldName = "SRP"
            Me.colSRP.Name = "colSRP"
            Me.colSRP.Visible = True
            Me.colSRP.VisibleIndex = 14
            '
            'colDiscount
            '
            Me.colDiscount.Caption = "Discount"
            Me.colDiscount.FieldName = "SalesDiscount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 15
            '
            'colSubTotal
            '
            Me.colSubTotal.Caption = "Price Total"
            Me.colSubTotal.FieldName = "SubTotal"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.Visible = True
            Me.colSubTotal.VisibleIndex = 16
            '
            'colAmountDue
            '
            Me.colAmountDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountDue.FieldName = "GrandTotal"
            Me.colAmountDue.Name = "colAmountDue"
            Me.colAmountDue.Visible = True
            Me.colAmountDue.VisibleIndex = 17
            '
            'colAmountPaid
            '
            Me.colAmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountPaid.FieldName = "AmountPaid"
            Me.colAmountPaid.Name = "colAmountPaid"
            Me.colAmountPaid.Visible = True
            Me.colAmountPaid.VisibleIndex = 18
            '
            'colNetProfit
            '
            Me.colNetProfit.Caption = "Net Profit"
            Me.colNetProfit.FieldName = "NetProfit"
            Me.colNetProfit.Name = "colNetProfit"
            Me.colNetProfit.Visible = True
            Me.colNetProfit.VisibleIndex = 19
            '
            'colPostingDate
            '
            Me.colPostingDate.Caption = "Posting Date"
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 20
            '
            'colTransactedBy
            '
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 21
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 22
            '
            'colRemarks
            '
            Me.colRemarks.Caption = "Remarks"
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 23
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Journal, Me.Bar_Parameters})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Reload, Me.Btn_Preview, Me.Btn_Close, Me.Btn_Journal, Me.Btn_Journal_Entries, Me.Btn_Stop, Me.Btn_Update, Me.BarEditItem_Branch, Me.BarEditItem_Search, Me.BarEditItem_Start, Me.BarEditItem_End, Me.BarEditItem_Corporation, Me.Btn_Validate, Me.Btn_Verify})
            Me.BarManager.MaxItemId = 14
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemDateEdit_Start, Me.RepositoryItemDateEdit_End, Me.RepositoryItemComboBox_Corporation})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.Bar_Actions.Text = "Actions"
            '
            'Btn_Reload
            '
            Me.Btn_Reload.Caption = "Reload"
            Me.Btn_Reload.Id = 0
            Me.Btn_Reload.Name = "Btn_Reload"
            '
            'Btn_Preview
            '
            Me.Btn_Preview.Caption = "Preview"
            Me.Btn_Preview.Id = 1
            Me.Btn_Preview.Name = "Btn_Preview"
            '
            'Btn_Update
            '
            Me.Btn_Update.Caption = "Update"
            Me.Btn_Update.Id = 6
            Me.Btn_Update.Name = "Btn_Update"
            '
            'Btn_Close
            '
            Me.Btn_Close.Caption = "Close"
            Me.Btn_Close.Id = 2
            Me.Btn_Close.Name = "Btn_Close"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 0
            Me.Bar_Journal.DockRow = 1
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop, True)})
            Me.Bar_Journal.Text = "Journal"
            '
            'Btn_Journal
            '
            Me.Btn_Journal.Caption = "Journal"
            Me.Btn_Journal.Id = 3
            Me.Btn_Journal.Name = "Btn_Journal"
            '
            'Btn_Journal_Entries
            '
            Me.Btn_Journal_Entries.Caption = "Journal Entries"
            Me.Btn_Journal_Entries.Id = 4
            Me.Btn_Journal_Entries.Name = "Btn_Journal_Entries"
            '
            'Btn_Stop
            '
            Me.Btn_Stop.Caption = "Stop"
            Me.Btn_Stop.Id = 5
            Me.Btn_Stop.Name = "Btn_Stop"
            '
            'Bar_Parameters
            '
            Me.Bar_Parameters.BarName = "Parameters"
            Me.Bar_Parameters.DockCol = 0
            Me.Bar_Parameters.DockRow = 0
            Me.Bar_Parameters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Parameters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Start), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_End)})
            Me.Bar_Parameters.Text = "Parameters"
            '
            'BarEditItem_Corporation
            '
            Me.BarEditItem_Corporation.Caption = "Corporation"
            Me.BarEditItem_Corporation.Edit = Me.RepositoryItemComboBox_Corporation
            Me.BarEditItem_Corporation.Id = 11
            Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
            '
            'RepositoryItemComboBox_Corporation
            '
            Me.RepositoryItemComboBox_Corporation.AutoHeight = False
            Me.RepositoryItemComboBox_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Corporation.Items.AddRange(New Object() {"SFC", "SMC"})
            Me.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation"
            Me.RepositoryItemComboBox_Corporation.Sorted = True
            Me.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Branch
            '
            Me.BarEditItem_Branch.Caption = "Branch"
            Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.BarEditItem_Branch.Id = 7
            Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'BarEditItem_Start
            '
            Me.BarEditItem_Start.Caption = "Start"
            Me.BarEditItem_Start.Edit = Me.RepositoryItemDateEdit_Start
            Me.BarEditItem_Start.Id = 9
            Me.BarEditItem_Start.Name = "BarEditItem_Start"
            '
            'RepositoryItemDateEdit_Start
            '
            Me.RepositoryItemDateEdit_Start.AutoHeight = False
            Me.RepositoryItemDateEdit_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.Name = "RepositoryItemDateEdit_Start"
            '
            'BarEditItem_End
            '
            Me.BarEditItem_End.Caption = "End"
            Me.BarEditItem_End.Edit = Me.RepositoryItemDateEdit_End
            Me.BarEditItem_End.Id = 10
            Me.BarEditItem_End.Name = "BarEditItem_End"
            '
            'RepositoryItemDateEdit_End
            '
            Me.RepositoryItemDateEdit_End.AutoHeight = False
            Me.RepositoryItemDateEdit_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.Name = "RepositoryItemDateEdit_End"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(631, 41)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 384)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(631, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 343)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(631, 41)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 343)
            '
            'Btn_Validate
            '
            Me.Btn_Validate.Caption = "Validate"
            Me.Btn_Validate.Id = 12
            Me.Btn_Validate.Name = "Btn_Validate"
            '
            'Btn_Verify
            '
            Me.Btn_Verify.Caption = "Verify"
            Me.Btn_Verify.Id = 13
            Me.Btn_Verify.Name = "Btn_Verify"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'XtraForm_Spare_Part
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(631, 384)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm_Spare_Part"
            Me.Text = "SPA Sales"
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPartNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCostTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNetProfit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents coltrans_Category As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSI_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoices As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountPaid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCRNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountDue As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents BarEditItem_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents Btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    End Class
End Namespace