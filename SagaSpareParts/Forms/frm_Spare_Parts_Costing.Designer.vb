Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Spare_Parts_Costing
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
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPartsName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscountPCT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscountAMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPriceWVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPriceWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModelCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModelName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInventoryStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVendor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSPCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSPCostWVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChecker = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApprover = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCurrentApprover = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateApproved = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSourceEvent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchTo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSC_SpareParts = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colprev_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSales_Remarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalLess = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBinBox = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.check_Initialize = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Reload = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Load_All = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Select_Show = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.DockPanel1.SuspendLayout()
            Me.hideContainerRight.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Select_Show.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(21, 29)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {})
            Me.gridControl.Size = New System.Drawing.Size(642, 291)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBranchCode, Me.colPartsNumber, Me.colPartsName, Me.colBrand, Me.colSRP, Me.colDiscountPCT, Me.colDiscountAMT, Me.colPriceWVAT, Me.colPriceWOVAT, Me.colModelCode, Me.colModelName, Me.colNote, Me.colRemarks, Me.colTransactedBy, Me.colTransactionDate, Me.colQuantity, Me.colPostingDate, Me.colInventoryStatus, Me.colVendor, Me.colRefNo, Me.colPONo, Me.colwhCode, Me.colwhCategory, Me.colSPCostWOVAT, Me.colSPCostWVAT, Me.colChecker, Me.colApprover, Me.colCurrentApprover, Me.colDateCheck, Me.colDateApproved, Me.colSourceEvent, Me.colBranchTo, Me.colSC_SpareParts, Me.colprev_ID, Me.colSales_Remarks, Me.colSubTotal, Me.colTotalLess, Me.colGrandTotal, Me.colTotalCostWOVAT, Me.colPrev_Quantity, Me.colCategory, Me.colBinBox})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "id"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colBranchCode
            '
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 1
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
            'colSRP
            '
            Me.colSRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSRP.FieldName = "SRP"
            Me.colSRP.Name = "colSRP"
            Me.colSRP.Visible = True
            Me.colSRP.VisibleIndex = 5
            '
            'colDiscountPCT
            '
            Me.colDiscountPCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscountPCT.FieldName = "DiscountPCT"
            Me.colDiscountPCT.Name = "colDiscountPCT"
            Me.colDiscountPCT.Visible = True
            Me.colDiscountPCT.VisibleIndex = 6
            '
            'colDiscountAMT
            '
            Me.colDiscountAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscountAMT.FieldName = "DiscountAMT"
            Me.colDiscountAMT.Name = "colDiscountAMT"
            Me.colDiscountAMT.Visible = True
            Me.colDiscountAMT.VisibleIndex = 7
            '
            'colPriceWVAT
            '
            Me.colPriceWVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPriceWVAT.FieldName = "PriceWVAT"
            Me.colPriceWVAT.Name = "colPriceWVAT"
            Me.colPriceWVAT.Visible = True
            Me.colPriceWVAT.VisibleIndex = 8
            '
            'colPriceWOVAT
            '
            Me.colPriceWOVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPriceWOVAT.FieldName = "PriceWOVAT"
            Me.colPriceWOVAT.Name = "colPriceWOVAT"
            Me.colPriceWOVAT.Visible = True
            Me.colPriceWOVAT.VisibleIndex = 9
            '
            'colModelCode
            '
            Me.colModelCode.FieldName = "ModelCode"
            Me.colModelCode.Name = "colModelCode"
            Me.colModelCode.Visible = True
            Me.colModelCode.VisibleIndex = 10
            '
            'colModelName
            '
            Me.colModelName.FieldName = "ModelName"
            Me.colModelName.Name = "colModelName"
            Me.colModelName.Visible = True
            Me.colModelName.VisibleIndex = 11
            '
            'colNote
            '
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 12
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 13
            '
            'colTransactedBy
            '
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 14
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 15
            '
            'colQuantity
            '
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 16
            '
            'colPostingDate
            '
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 17
            '
            'colInventoryStatus
            '
            Me.colInventoryStatus.FieldName = "InventoryStatus"
            Me.colInventoryStatus.Name = "colInventoryStatus"
            Me.colInventoryStatus.Visible = True
            Me.colInventoryStatus.VisibleIndex = 18
            '
            'colVendor
            '
            Me.colVendor.FieldName = "Vendor"
            Me.colVendor.Name = "colVendor"
            Me.colVendor.Visible = True
            Me.colVendor.VisibleIndex = 19
            '
            'colRefNo
            '
            Me.colRefNo.FieldName = "RefNo"
            Me.colRefNo.Name = "colRefNo"
            Me.colRefNo.Visible = True
            Me.colRefNo.VisibleIndex = 20
            '
            'colPONo
            '
            Me.colPONo.FieldName = "PONo"
            Me.colPONo.Name = "colPONo"
            Me.colPONo.Visible = True
            Me.colPONo.VisibleIndex = 21
            '
            'colwhCode
            '
            Me.colwhCode.FieldName = "whCode"
            Me.colwhCode.Name = "colwhCode"
            Me.colwhCode.Visible = True
            Me.colwhCode.VisibleIndex = 22
            '
            'colwhCategory
            '
            Me.colwhCategory.FieldName = "whCategory"
            Me.colwhCategory.Name = "colwhCategory"
            Me.colwhCategory.Visible = True
            Me.colwhCategory.VisibleIndex = 23
            '
            'colSPCostWOVAT
            '
            Me.colSPCostWOVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSPCostWOVAT.FieldName = "SPCostWOVAT"
            Me.colSPCostWOVAT.Name = "colSPCostWOVAT"
            Me.colSPCostWOVAT.Visible = True
            Me.colSPCostWOVAT.VisibleIndex = 24
            '
            'colSPCostWVAT
            '
            Me.colSPCostWVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSPCostWVAT.FieldName = "SPCostWVAT"
            Me.colSPCostWVAT.Name = "colSPCostWVAT"
            Me.colSPCostWVAT.Visible = True
            Me.colSPCostWVAT.VisibleIndex = 25
            '
            'colChecker
            '
            Me.colChecker.FieldName = "Checker"
            Me.colChecker.Name = "colChecker"
            Me.colChecker.Visible = True
            Me.colChecker.VisibleIndex = 26
            '
            'colApprover
            '
            Me.colApprover.FieldName = "Approver"
            Me.colApprover.Name = "colApprover"
            Me.colApprover.Visible = True
            Me.colApprover.VisibleIndex = 27
            '
            'colCurrentApprover
            '
            Me.colCurrentApprover.FieldName = "CurrentApprover"
            Me.colCurrentApprover.Name = "colCurrentApprover"
            Me.colCurrentApprover.Visible = True
            Me.colCurrentApprover.VisibleIndex = 28
            '
            'colDateCheck
            '
            Me.colDateCheck.FieldName = "DateCheck"
            Me.colDateCheck.Name = "colDateCheck"
            Me.colDateCheck.Visible = True
            Me.colDateCheck.VisibleIndex = 29
            '
            'colDateApproved
            '
            Me.colDateApproved.FieldName = "DateApproved"
            Me.colDateApproved.Name = "colDateApproved"
            Me.colDateApproved.Visible = True
            Me.colDateApproved.VisibleIndex = 30
            '
            'colSourceEvent
            '
            Me.colSourceEvent.FieldName = "SourceEvent"
            Me.colSourceEvent.Name = "colSourceEvent"
            Me.colSourceEvent.Visible = True
            Me.colSourceEvent.VisibleIndex = 31
            '
            'colBranchTo
            '
            Me.colBranchTo.FieldName = "ReceivingBranch"
            Me.colBranchTo.Name = "colBranchTo"
            Me.colBranchTo.Visible = True
            Me.colBranchTo.VisibleIndex = 32
            '
            'colSC_SpareParts
            '
            Me.colSC_SpareParts.FieldName = "SC_SpareParts"
            Me.colSC_SpareParts.Name = "colSC_SpareParts"
            Me.colSC_SpareParts.Visible = True
            Me.colSC_SpareParts.VisibleIndex = 33
            '
            'colprev_ID
            '
            Me.colprev_ID.FieldName = "prev_ID"
            Me.colprev_ID.Name = "colprev_ID"
            Me.colprev_ID.Visible = True
            Me.colprev_ID.VisibleIndex = 34
            '
            'colSales_Remarks
            '
            Me.colSales_Remarks.FieldName = "Sales_Remarks"
            Me.colSales_Remarks.Name = "colSales_Remarks"
            Me.colSales_Remarks.Visible = True
            Me.colSales_Remarks.VisibleIndex = 35
            '
            'colSubTotal
            '
            Me.colSubTotal.FieldName = "SubTotal"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.Visible = True
            Me.colSubTotal.VisibleIndex = 36
            '
            'colTotalLess
            '
            Me.colTotalLess.FieldName = "TotalLess"
            Me.colTotalLess.Name = "colTotalLess"
            Me.colTotalLess.Visible = True
            Me.colTotalLess.VisibleIndex = 37
            '
            'colGrandTotal
            '
            Me.colGrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colGrandTotal.FieldName = "GrandTotal"
            Me.colGrandTotal.Name = "colGrandTotal"
            Me.colGrandTotal.Visible = True
            Me.colGrandTotal.VisibleIndex = 38
            '
            'colTotalCostWOVAT
            '
            Me.colTotalCostWOVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalCostWOVAT.FieldName = "TotalCostWOVAT"
            Me.colTotalCostWOVAT.Name = "colTotalCostWOVAT"
            Me.colTotalCostWOVAT.Visible = True
            Me.colTotalCostWOVAT.VisibleIndex = 39
            '
            'colPrev_Quantity
            '
            Me.colPrev_Quantity.FieldName = "Prev_Quantity"
            Me.colPrev_Quantity.Name = "colPrev_Quantity"
            Me.colPrev_Quantity.Visible = True
            Me.colPrev_Quantity.VisibleIndex = 40
            '
            'colCategory
            '
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 41
            '
            'colBinBox
            '
            Me.colBinBox.FieldName = "BinBox"
            Me.colBinBox.Name = "colBinBox"
            Me.colBinBox.Visible = True
            Me.colBinBox.VisibleIndex = 42
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.barEditItem_Branch})
            Me.barManager.MaxItemId = 14
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 179
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 8
            Me.btn_Initialize.ImageOptions.ImageIndex = 6
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 7
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 3
            Me.btn_Delete.ImageOptions.LargeImageIndex = 3
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.ImageOptions.LargeImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Caption = "Branch"
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 13
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 9
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(684, 29)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 320)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(684, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 291)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(684, 29)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 291)
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft, Me.hideContainerRight})

            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 29)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 291)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("99937d4d-928b-4bbe-a855-e8d79f944890")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(200, 291)
            Me.DockPanel1.Text = "Information"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(191, 264)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.DockPanel2)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(663, 29)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 291)
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("5a23064f-938a-43ed-b653-6cbf95d9258b")
            Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(142, 200)
            Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.SavedIndex = 0
            Me.DockPanel2.Size = New System.Drawing.Size(142, 264)
            Me.DockPanel2.Text = "Settings"
            Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.PanelControl1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 30)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(135, 231)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.check_Initialize)
            Me.PanelControl1.Controls.Add(Me.check_Reload)
            Me.PanelControl1.Controls.Add(Me.check_Load_All)
            Me.PanelControl1.Controls.Add(Me.check_Select_Show)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(135, 231)
            Me.PanelControl1.TabIndex = 0
            '
            'check_Initialize
            '
            Me.check_Initialize.Location = New System.Drawing.Point(5, 5)
            Me.check_Initialize.MenuManager = Me.barManager
            Me.check_Initialize.Name = "check_Initialize"
            Me.check_Initialize.Properties.AutoWidth = True
            Me.check_Initialize.Properties.Caption = "Auto Initialize"
            Me.check_Initialize.Size = New System.Drawing.Size(93, 19)
            Me.check_Initialize.TabIndex = 0
            '
            'check_Reload
            '
            Me.check_Reload.Location = New System.Drawing.Point(5, 31)
            Me.check_Reload.MenuManager = Me.barManager
            Me.check_Reload.Name = "check_Reload"
            Me.check_Reload.Properties.AutoWidth = True
            Me.check_Reload.Properties.Caption = "Auto Reload"
            Me.check_Reload.Size = New System.Drawing.Size(86, 19)
            Me.check_Reload.TabIndex = 1
            '
            'check_Load_All
            '
            Me.check_Load_All.Location = New System.Drawing.Point(5, 57)
            Me.check_Load_All.MenuManager = Me.barManager
            Me.check_Load_All.Name = "check_Load_All"
            Me.check_Load_All.Properties.AutoWidth = True
            Me.check_Load_All.Properties.Caption = "Load All"
            Me.check_Load_All.Size = New System.Drawing.Size(63, 19)
            Me.check_Load_All.TabIndex = 2
            '
            'check_Select_Show
            '
            Me.check_Select_Show.Location = New System.Drawing.Point(5, 82)
            Me.check_Select_Show.MenuManager = Me.barManager
            Me.check_Select_Show.Name = "check_Select_Show"
            Me.check_Select_Show.Properties.AutoWidth = True
            Me.check_Select_Show.Properties.Caption = "Show on select"
            Me.check_Select_Show.Size = New System.Drawing.Size(100, 19)
            Me.check_Select_Show.TabIndex = 3
            '
            'frm_Spare_Parts_Costing
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(684, 320)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Spare_Parts_Costing"
            Me.Text = "Spare Parts Costing"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.DockPanel1.ResumeLayout(False)
            Me.hideContainerRight.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Select_Show.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscountPCT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscountAMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPriceWVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPriceWOVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModelCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModelName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInventoryStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVendor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSPCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSPCostWVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChecker As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApprover As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCurrentApprover As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateCheck As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateApproved As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSourceEvent As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchTo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSC_SpareParts As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colprev_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSales_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalLess As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGrandTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Quantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBinBox As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents check_Initialize As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents check_Reload As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents check_Load_All As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents check_Select_Show As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        
    End Class
End Namespace