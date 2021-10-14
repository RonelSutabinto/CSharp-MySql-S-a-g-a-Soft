<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Sales
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
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.xuc_Sales = New Xuc_Sales()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
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
        Me.colDiscount_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGross_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNet_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTrans_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoices = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSI_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPricing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItem_Count = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount_Paid = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_PartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager
        '
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_New, Me.btn_Save, Me.btn_Print, Me.btn_Close, Me.BarEditItem_Date_Start, Me.BarEditItem_Date_End, Me.btn_Reload, Me.btn_Add})
        Me.BarManager.MaxItemId = 8
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar1.Text = "Tools"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 0
        Me.btn_New.Name = "btn_New"
        '
        'btn_Add
        '
        Me.btn_Add.Caption = "Add"
        Me.btn_Add.Id = 7
        Me.btn_Add.Name = "btn_Add"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 1
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Print
        '
        Me.btn_Print.Caption = "Print"
        Me.btn_Print.Id = 2
        Me.btn_Print.Name = "btn_Print"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 3
        Me.btn_Close.Name = "btn_Close"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 1
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_Start, "", False, True, True, 134), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_End, "", False, True, True, 128), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload)})
        Me.Bar2.Offset = 175
        Me.Bar2.Text = "Custom 3"
        '
        'BarEditItem_Date_Start
        '
        Me.BarEditItem_Date_Start.Caption = "Date Start"
        Me.BarEditItem_Date_Start.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem_Date_Start.Id = 4
        Me.BarEditItem_Date_Start.Name = "BarEditItem_Date_Start"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarEditItem_Date_End
        '
        Me.BarEditItem_Date_End.Caption = "Date End"
        Me.BarEditItem_Date_End.Edit = Me.RepositoryItemDateEdit2
        Me.BarEditItem_Date_End.Id = 5
        Me.BarEditItem_Date_End.Name = "BarEditItem_Date_End"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Id = 6
        Me.btn_Reload.Name = "btn_Reload"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(864, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 393)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(864, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 373)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(864, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 373)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("1c85d90c-7896-4e39-809f-e446e92c8a15")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(298, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(298, 373)
        Me.DockPanel1.Text = "Informations"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.xuc_Sales)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(291, 344)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'xuc_Sales
        '
        Me.xuc_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Sales.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Sales.Name = "xuc_Sales"
        Me.xuc_Sales.Size = New System.Drawing.Size(291, 344)
        Me.xuc_Sales.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("c0cb923d-cdfa-44e2-859e-90a15501cecc")
        Me.DockPanel2.Location = New System.Drawing.Point(657, 20)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(207, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(207, 373)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(200, 344)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'xuc_Settings
        '
        Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
        Me.xuc_Settings.Name = "xuc_Settings"
        Me.xuc_Settings.Size = New System.Drawing.Size(270, 344)
        Me.xuc_Settings.TabIndex = 0
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel3.FloatVertical = True
        Me.DockPanel3.ID = New System.Guid("25f79deb-f701-4ae5-82f3-fcdf020ef51d")
        Me.DockPanel3.Location = New System.Drawing.Point(298, 193)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Size = New System.Drawing.Size(359, 200)
        Me.DockPanel3.Text = "Details"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.gridControl_List)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(353, 170)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'gridControl_List
        '
        Me.gridControl_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl_List.Location = New System.Drawing.Point(0, 0)
        Me.gridControl_List.MainView = Me.gridView_List
        Me.gridControl_List.MenuManager = Me.BarManager
        Me.gridControl_List.Name = "gridControl_List"
        Me.gridControl_List.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_PartNumber})
        Me.gridControl_List.Size = New System.Drawing.Size(353, 170)
        Me.gridControl_List.TabIndex = 7
        Me.gridControl_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_List})
        '
        'gridView_List
        '
        Me.gridView_List.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_List, Me.colBatch_Id, Me.colPartsNumber, Me.colPartsName, Me.colBrand, Me.colCategory, Me.colQuantity, Me.colDiscount_SRP, Me.colSRP, Me.colGross_Total, Me.colNet_Total, Me.colCost})
        Me.gridView_List.GridControl = Me.gridControl_List
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
        Me.colBatch_Id.FieldName = "Prev_Id"
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
        Me.colBrand.Caption = "Brand"
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 4
        '
        'colCategory
        '
        Me.colCategory.Caption = "Category"
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
        'colDiscount_SRP
        '
        Me.colDiscount_SRP.FieldName = "Discount_SRP"
        Me.colDiscount_SRP.Name = "colDiscount_SRP"
        Me.colDiscount_SRP.Visible = True
        Me.colDiscount_SRP.VisibleIndex = 7
        '
        'colSRP
        '
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 8
        '
        'colGross_Total
        '
        Me.colGross_Total.FieldName = "Gross_Total"
        Me.colGross_Total.Name = "colGross_Total"
        Me.colGross_Total.Visible = True
        Me.colGross_Total.VisibleIndex = 9
        '
        'colNet_Total
        '
        Me.colNet_Total.FieldName = "Net_Total"
        Me.colNet_Total.Name = "colNet_Total"
        Me.colNet_Total.Visible = True
        Me.colNet_Total.VisibleIndex = 10
        '
        'colCost
        '
        Me.colCost.FieldName = "Cost"
        Me.colCost.Name = "colCost"
        Me.colCost.Visible = True
        Me.colCost.VisibleIndex = 11
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(298, 20)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.BarManager
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(359, 173)
        Me.gridControl.TabIndex = 6
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBranch_Code, Me.colTrans_Category, Me.colInvoices, Me.colCustomer_Name, Me.colAddress, Me.colSI_Number, Me.colTerms, Me.colPostingDate, Me.colPricing, Me.colNotes, Me.colItem_Count, Me.colAmount_Paid})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colBranch_Code
        '
        Me.colBranch_Code.FieldName = "Branch_Code"
        Me.colBranch_Code.Name = "colBranch_Code"
        Me.colBranch_Code.Visible = True
        Me.colBranch_Code.VisibleIndex = 1
        '
        'colTrans_Category
        '
        Me.colTrans_Category.FieldName = "Trans_Category"
        Me.colTrans_Category.Name = "colTrans_Category"
        Me.colTrans_Category.Visible = True
        Me.colTrans_Category.VisibleIndex = 2
        '
        'colInvoices
        '
        Me.colInvoices.FieldName = "Invoices"
        Me.colInvoices.Name = "colInvoices"
        Me.colInvoices.Visible = True
        Me.colInvoices.VisibleIndex = 3
        '
        'colCustomer_Name
        '
        Me.colCustomer_Name.FieldName = "Customer_Name"
        Me.colCustomer_Name.Name = "colCustomer_Name"
        Me.colCustomer_Name.Visible = True
        Me.colCustomer_Name.VisibleIndex = 4
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 5
        '
        'colSI_Number
        '
        Me.colSI_Number.FieldName = "SI_Number"
        Me.colSI_Number.Name = "colSI_Number"
        Me.colSI_Number.Visible = True
        Me.colSI_Number.VisibleIndex = 6
        '
        'colTerms
        '
        Me.colTerms.FieldName = "Terms"
        Me.colTerms.Name = "colTerms"
        Me.colTerms.Visible = True
        Me.colTerms.VisibleIndex = 7
        '
        'colPostingDate
        '
        Me.colPostingDate.FieldName = "PostingDate"
        Me.colPostingDate.Name = "colPostingDate"
        Me.colPostingDate.Visible = True
        Me.colPostingDate.VisibleIndex = 8
        '
        'colPricing
        '
        Me.colPricing.FieldName = "Pricing"
        Me.colPricing.Name = "colPricing"
        Me.colPricing.Visible = True
        Me.colPricing.VisibleIndex = 9
        '
        'colNotes
        '
        Me.colNotes.Caption = "Notes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 10
        '
        'colItem_Count
        '
        Me.colItem_Count.FieldName = "Item_Count"
        Me.colItem_Count.Name = "colItem_Count"
        Me.colItem_Count.Visible = True
        Me.colItem_Count.VisibleIndex = 11
        '
        'colAmount_Paid
        '
        Me.colAmount_Paid.FieldName = "Amount_Paid"
        Me.colAmount_Paid.Name = "colAmount_Paid"
        Me.colAmount_Paid.Visible = True
        Me.colAmount_Paid.VisibleIndex = 12
        '
        'frm_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 393)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.DockPanel3)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_Sales"
        Me.Text = "frm_Sales"
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_PartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xuc_Sales As Xuc_Sales
    Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents gridControl_List As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView_List As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount_SRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGross_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNet_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatch_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrans_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoices As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSI_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItem_Count As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount_Paid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem_Date_End As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPricing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_PartNumber As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
End Class
