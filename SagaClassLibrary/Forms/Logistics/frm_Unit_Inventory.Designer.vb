Namespace Forms.Logistics
    Partial Class frm_Unit_Inventory
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Unit_Inventory))
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Multiple_Existing = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Physical_Count = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_All_MC_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Syncronize = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Syncronize = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.toggle_Syncronize = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Add_To_PO = New DevExpress.XtraBars.BarButtonItem()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Unit_Inventory = New SagaClassLibrary.Controls.Logistics.xuc_Unit_Inventory()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colprevID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIs_Verified = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIfExist = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTranscode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPoNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCodeFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEditBranch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVendor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateReceived = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWHCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWHCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInventoryStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Color = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVATAmt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Syncronize, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEditBranch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar_Journal})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.barEditItem_Branch, Me.BarEditItem_Search, Me.btn_Multiple_Existing, Me.btn_Journal_Entries, Me.btn_Journal, Me.btn_Verify, Me.btn_Stop, Me.btn_Physical_Count, Me.btn_Update, Me.btn_Generate, Me.btn_Syncronize, Me.btn_All_MC_Units, Me.toggle_Syncronize, Me.btn_Add_To_PO})
            Me.barManager.MaxItemId = 25
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Syncronize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 172
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 6
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "Generate"
            Me.btn_Generate.Id = 20
            Me.btn_Generate.Name = "btn_Generate"
            '
            'btn_Reload
            '
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'PopupMenu_Reload
            '
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Multiple_Existing), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Physical_Count), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_All_MC_Units)})
            Me.PopupMenu_Reload.Manager = Me.barManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Multiple_Existing
            '
            Me.btn_Multiple_Existing.Caption = "Multiple Existing"
            Me.btn_Multiple_Existing.Id = 13
            Me.btn_Multiple_Existing.ImageOptions.Image = CType(resources.GetObject("btn_Multiple_Existing.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Multiple_Existing.ImageOptions.LargeImage = CType(resources.GetObject("btn_Multiple_Existing.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Multiple_Existing.Name = "btn_Multiple_Existing"
            '
            'btn_Physical_Count
            '
            Me.btn_Physical_Count.Caption = "Physical Count"
            Me.btn_Physical_Count.Id = 18
            Me.btn_Physical_Count.ImageOptions.Image = CType(resources.GetObject("btn_Physical_Count.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Physical_Count.ImageOptions.LargeImage = CType(resources.GetObject("btn_Physical_Count.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Physical_Count.Name = "btn_Physical_Count"
            '
            'btn_All_MC_Units
            '
            Me.btn_All_MC_Units.Caption = "All MC Units"
            Me.btn_All_MC_Units.Id = 22
            Me.btn_All_MC_Units.ImageOptions.Image = CType(resources.GetObject("btn_All_MC_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_All_MC_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_All_MC_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_All_MC_Units.Name = "btn_All_MC_Units"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 8
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
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 19
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Syncronize
            '
            Me.btn_Syncronize.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Syncronize.Caption = "Syncronize"
            Me.btn_Syncronize.DropDownControl = Me.PopupMenu_Syncronize
            Me.btn_Syncronize.Id = 21
            Me.btn_Syncronize.ImageOptions.Image = CType(resources.GetObject("btn_Syncronize.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Syncronize.ImageOptions.LargeImage = CType(resources.GetObject("btn_Syncronize.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Syncronize.Name = "btn_Syncronize"
            '
            'PopupMenu_Syncronize
            '
            Me.PopupMenu_Syncronize.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggle_Syncronize)})
            Me.PopupMenu_Syncronize.Manager = Me.barManager
            Me.PopupMenu_Syncronize.Name = "PopupMenu_Syncronize"
            '
            'toggle_Syncronize
            '
            Me.toggle_Syncronize.Caption = "Syncronize by Model"
            Me.toggle_Syncronize.Id = 23
            Me.toggle_Syncronize.Name = "toggle_Syncronize"
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
            Me.bar2.FloatLocation = New System.Drawing.Point(79, 169)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 9
            Me.barEditItem_Branch.ImageOptions.ImageIndex = 7
            Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 7
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 11
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 0
            Me.Bar_Journal.DockRow = 1
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar_Journal.Text = "Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 14
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 15
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 16
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 17
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(890, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 553)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(890, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 508)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(890, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 508)
            '
            'btn_Add_To_PO
            '
            Me.btn_Add_To_PO.Caption = "Add to P.O."
            Me.btn_Add_To_PO.Id = 24
            Me.btn_Add_To_PO.ImageOptions.Image = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Add_To_PO.ImageOptions.LargeImage = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Add_To_PO.Name = "btn_Add_To_PO"
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("7f39575b-54ae-4d88-a399-f353a55cbbc7")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 400)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 508)
            Me.dockPanel1.Text = "Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Unit_Inventory)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 479)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Unit_Inventory
            '
            Me.xuc_Unit_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Unit_Inventory.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Unit_Inventory.Name = "xuc_Unit_Inventory"
            Me.xuc_Unit_Inventory.Size = New System.Drawing.Size(293, 479)
            Me.xuc_Unit_Inventory.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("0b3cf33c-8bb4-464b-ad74-1bdf10caa9a1")
            Me.dockPanel2.Location = New System.Drawing.Point(610, 45)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(280, 508)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 479)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.xuc_Settings)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(273, 479)
            Me.panelControl1.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 475)
            Me.xuc_Settings.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(300, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEditBranch})
            Me.gridControl.Size = New System.Drawing.Size(310, 508)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colprevID, Me.colIsJournal, Me.colIs_Verified, Me.colIfExist, Me.colTranscode, Me.colPoNo, Me.colRefNo, Me.colBranchCodeFrom, Me.colBranchCode, Me.colVendor, Me.colDateReceived, Me.colWHCategory, Me.colWHCode, Me.colInventoryStatus, Me.colCode, Me.colModel_Code, Me.colBrand, Me.colModel, Me.Color, Me.colDescription, Me.colEngineNo, Me.colChassisNo, Me.colKeyNo, Me.colUnitCost, Me.colVATAmt, Me.colTotalCost, Me.colUnitPrice, Me.colTransactedBy, Me.colTransactionDate, Me.colApproved_By, Me.colApproved_Date, Me.colRemarks, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountName, Me.colNote})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colprevID
            '
            Me.colprevID.Caption = "Prev ID"
            Me.colprevID.FieldName = "prevID"
            Me.colprevID.Name = "colprevID"
            Me.colprevID.Visible = True
            Me.colprevID.VisibleIndex = 1
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 2
            '
            'colIs_Verified
            '
            Me.colIs_Verified.FieldName = "Is_Verified"
            Me.colIs_Verified.Name = "colIs_Verified"
            Me.colIs_Verified.Visible = True
            Me.colIs_Verified.VisibleIndex = 3
            '
            'colIfExist
            '
            Me.colIfExist.Caption = "Exist"
            Me.colIfExist.FieldName = "IfExist"
            Me.colIfExist.Name = "colIfExist"
            Me.colIfExist.Visible = True
            Me.colIfExist.VisibleIndex = 4
            '
            'colTranscode
            '
            Me.colTranscode.Caption = "Transaction Code"
            Me.colTranscode.FieldName = "Transcode"
            Me.colTranscode.Name = "colTranscode"
            Me.colTranscode.Visible = True
            Me.colTranscode.VisibleIndex = 5
            '
            'colPoNo
            '
            Me.colPoNo.Caption = "Purchare Order"
            Me.colPoNo.FieldName = "PoNo"
            Me.colPoNo.Name = "colPoNo"
            Me.colPoNo.Visible = True
            Me.colPoNo.VisibleIndex = 6
            '
            'colRefNo
            '
            Me.colRefNo.Caption = "Reference"
            Me.colRefNo.FieldName = "RefNo"
            Me.colRefNo.Name = "colRefNo"
            Me.colRefNo.Visible = True
            Me.colRefNo.VisibleIndex = 7
            '
            'colBranchCodeFrom
            '
            Me.colBranchCodeFrom.Caption = "Branch From"
            Me.colBranchCodeFrom.ColumnEdit = Me.RepositoryItemLookUpEditBranch
            Me.colBranchCodeFrom.FieldName = "BranchCodeFrom"
            Me.colBranchCodeFrom.Name = "colBranchCodeFrom"
            Me.colBranchCodeFrom.Visible = True
            Me.colBranchCodeFrom.VisibleIndex = 8
            '
            'RepositoryItemLookUpEditBranch
            '
            Me.RepositoryItemLookUpEditBranch.AutoHeight = False
            Me.RepositoryItemLookUpEditBranch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEditBranch.Name = "RepositoryItemLookUpEditBranch"
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch To"
            Me.colBranchCode.ColumnEdit = Me.RepositoryItemLookUpEditBranch
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 9
            '
            'colVendor
            '
            Me.colVendor.Caption = "Vendor"
            Me.colVendor.FieldName = "Vendor"
            Me.colVendor.Name = "colVendor"
            Me.colVendor.Visible = True
            Me.colVendor.VisibleIndex = 10
            '
            'colDateReceived
            '
            Me.colDateReceived.Caption = "Received Date"
            Me.colDateReceived.FieldName = "DateReceived"
            Me.colDateReceived.Name = "colDateReceived"
            Me.colDateReceived.Visible = True
            Me.colDateReceived.VisibleIndex = 11
            '
            'colWHCategory
            '
            Me.colWHCategory.Caption = "Category"
            Me.colWHCategory.FieldName = "WHCategory"
            Me.colWHCategory.Name = "colWHCategory"
            Me.colWHCategory.Visible = True
            Me.colWHCategory.VisibleIndex = 12
            '
            'colWHCode
            '
            Me.colWHCode.Caption = "Warehouse"
            Me.colWHCode.FieldName = "WHCode"
            Me.colWHCode.Name = "colWHCode"
            Me.colWHCode.Visible = True
            Me.colWHCode.VisibleIndex = 13
            '
            'colInventoryStatus
            '
            Me.colInventoryStatus.Caption = "Inventory Status"
            Me.colInventoryStatus.FieldName = "InventoryStatus"
            Me.colInventoryStatus.Name = "colInventoryStatus"
            Me.colInventoryStatus.Visible = True
            Me.colInventoryStatus.VisibleIndex = 14
            '
            'colCode
            '
            Me.colCode.Caption = "Unit ID"
            Me.colCode.FieldName = "Code"
            Me.colCode.Name = "colCode"
            Me.colCode.Visible = True
            Me.colCode.VisibleIndex = 15
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 16
            '
            'colBrand
            '
            Me.colBrand.Caption = "Brand"
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 17
            '
            'colModel
            '
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 18
            '
            'Color
            '
            Me.Color.Caption = "Color"
            Me.Color.FieldName = "Color"
            Me.Color.Name = "Color"
            Me.Color.Visible = True
            Me.Color.VisibleIndex = 19
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 20
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 21
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 22
            '
            'colKeyNo
            '
            Me.colKeyNo.Caption = "Key"
            Me.colKeyNo.FieldName = "KeyNo"
            Me.colKeyNo.Name = "colKeyNo"
            Me.colKeyNo.Visible = True
            Me.colKeyNo.VisibleIndex = 23
            '
            'colUnitCost
            '
            Me.colUnitCost.Caption = "Unit Cost"
            Me.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitCost.FieldName = "UnitCost"
            Me.colUnitCost.Name = "colUnitCost"
            Me.colUnitCost.Visible = True
            Me.colUnitCost.VisibleIndex = 24
            '
            'colVATAmt
            '
            Me.colVATAmt.Caption = "VAT"
            Me.colVATAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVATAmt.FieldName = "VATAmt"
            Me.colVATAmt.Name = "colVATAmt"
            Me.colVATAmt.Visible = True
            Me.colVATAmt.VisibleIndex = 25
            '
            'colTotalCost
            '
            Me.colTotalCost.Caption = "Total Cost"
            Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalCost.FieldName = "TotalCost"
            Me.colTotalCost.Name = "colTotalCost"
            Me.colTotalCost.Visible = True
            Me.colTotalCost.VisibleIndex = 26
            '
            'colUnitPrice
            '
            Me.colUnitPrice.Caption = "Price"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 27
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Transacted By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 28
            '
            'colTransactionDate
            '
            Me.colTransactionDate.Caption = "Transacted"
            Me.colTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 29
            '
            'colApproved_By
            '
            Me.colApproved_By.Caption = "Approver"
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 30
            '
            'colApproved_Date
            '
            Me.colApproved_Date.Caption = "Approved_Date"
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 31
            '
            'colRemarks
            '
            Me.colRemarks.Caption = "Remarks"
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 32
            '
            'colAccountNumber
            '
            Me.colAccountNumber.Caption = "Account Number"
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 33
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 34
            '
            'colAccountName
            '
            Me.colAccountName.Caption = "Account Name"
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 35
            '
            'colNote
            '
            Me.colNote.Caption = "Note"
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 36
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Syncronize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add_To_PO), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'frm_Unit_Inventory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(890, 553)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Unit_Inventory"
            Me.Text = "Product Inventory"
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Syncronize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEditBranch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVendor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTranscode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateReceived As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPoNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colWHCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colWHCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInventoryStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIfExist As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKeyNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnitCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVATAmt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colprevID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Public barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEditBranch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Public WithEvents xuc_Unit_Inventory As Controls.Logistics.xuc_Unit_Inventory
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Multiple_Existing As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCodeFrom As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Physical_Count As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Syncronize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Syncronize As DevExpress.XtraBars.PopupMenu
        Public WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Public WithEvents toggle_Syncronize As DevExpress.XtraBars.BarToggleSwitchItem
        Public WithEvents btn_All_MC_Units As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIs_Verified As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Add_To_PO As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace