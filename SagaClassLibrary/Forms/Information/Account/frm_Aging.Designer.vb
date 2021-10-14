Partial Class frm_Aging
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.barManager = New DevExpress.XtraBars.BarManager()
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dockManager = New DevExpress.XtraBars.Docking.DockManager()
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.check_Initialize = New DevExpress.XtraEditors.CheckEdit()
        Me.check_Load_All = New DevExpress.XtraEditors.CheckEdit()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsequenceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReleaseType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIFKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountExecutive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinancedAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterestRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateGranted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaturityDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastMvmtDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntRatePerAnnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrincipalPMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterestPMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrincipalBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterestBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOutstandingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDue0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdvanced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDue2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.dockPanel1.SuspendLayout()
        Me.dockPanel1_Container.SuspendLayout()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        
        Me.SuspendLayout()
        '
        'barManager
        '
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.DockManager = Me.dockManager
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Preview, Me.btn_Generate, Me.barEditItem_Branch})
        Me.barManager.MaxItemId = 13
        Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.repositoryItemLookUpEdit_Branch})
        Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 1
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.FloatLocation = New System.Drawing.Point(-1424, -112)
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.bar1.Offset = 179
        Me.bar1.Text = "Tools"
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
        Me.btn_Preview.Id = 9
        Me.btn_Preview.ImageOptions.ImageIndex = 4
        Me.btn_Preview.ImageOptions.LargeImageIndex = 4
        Me.btn_Preview.Name = "btn_Preview"
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
        Me.bar2.FloatLocation = New System.Drawing.Point(127, 173)
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate)})
        Me.bar2.Text = "Options"
        '
        'btn_Initialize
        '
        Me.btn_Initialize.Caption = "Initialize"
        Me.btn_Initialize.Id = 5
        Me.btn_Initialize.ImageOptions.ImageIndex = 6
        Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
        Me.btn_Initialize.Name = "btn_Initialize"
        '
        'barEditItem_Branch
        '
        Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
        Me.barEditItem_Branch.Id = 12
        Me.barEditItem_Branch.ImageOptions.ImageIndex = 8
        Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 8
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
        Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
        Me.BarEditItem_Search.Id = 7
        Me.BarEditItem_Search.Name = "BarEditItem_Search"
        '
        'RepositoryItemSearchControl_Search
        '
        Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
        '
        'btn_Generate
        '
        Me.btn_Generate.Caption = "Generate"
        Me.btn_Generate.Id = 10
        Me.btn_Generate.ImageOptions.ImageIndex = 7
        Me.btn_Generate.ImageOptions.LargeImageIndex = 7
        Me.btn_Generate.Name = "btn_Generate"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(548, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 366)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(548, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 337)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(548, 29)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 337)
        '
        'dockManager
        '
        Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.dockManager.Form = Me
        Me.dockManager.MenuManager = Me.barManager
        Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.dockPanel1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(528, 29)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(20, 337)
        '
        'dockPanel1
        '
        Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
        Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockPanel1.ID = New System.Guid("ba1c9afa-9ccd-477c-969e-7f924fe8b284")
        Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.dockPanel1.Name = "dockPanel1"
        Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockPanel1.SavedIndex = 0
        Me.dockPanel1.Size = New System.Drawing.Size(200, 338)
        Me.dockPanel1.Text = "Options"
        Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'dockPanel1_Container
        '
        Me.dockPanel1_Container.Controls.Add(Me.panelControl1)
        Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 30)
        Me.dockPanel1_Container.Name = "dockPanel1_Container"
        Me.dockPanel1_Container.Size = New System.Drawing.Size(193, 305)
        Me.dockPanel1_Container.TabIndex = 0
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.check_Initialize)
        Me.panelControl1.Controls.Add(Me.check_Load_All)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelControl1.Location = New System.Drawing.Point(0, 0)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(193, 305)
        Me.panelControl1.TabIndex = 0
        '
        'check_Initialize
        '
        Me.check_Initialize.Location = New System.Drawing.Point(5, 5)
        Me.check_Initialize.MenuManager = Me.barManager
        Me.check_Initialize.Name = "check_Initialize"
        Me.check_Initialize.Properties.AutoWidth = True
        Me.check_Initialize.Properties.Caption = "Auto Initialize"
        Me.check_Initialize.Size = New System.Drawing.Size(87, 19)
        Me.check_Initialize.TabIndex = 0
        '
        'check_Load_All
        '
        Me.check_Load_All.Location = New System.Drawing.Point(5, 31)
        Me.check_Load_All.MenuManager = Me.barManager
        Me.check_Load_All.Name = "check_Load_All"
        Me.check_Load_All.Properties.AutoWidth = True
        Me.check_Load_All.Properties.Caption = "Load All"
        Me.check_Load_All.Size = New System.Drawing.Size(59, 19)
        Me.check_Load_All.TabIndex = 1
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 29)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {})
        Me.gridControl.Size = New System.Drawing.Size(528, 337)
        Me.gridControl.TabIndex = 0
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsequenceNo, Me.colCORP, Me.colReleaseType, Me.colBranchCode, Me.colBranch, Me.colCIFKey, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountStatus, Me.colAccountName, Me.colAccountAddress, Me.colAccountExecutive, Me.colOfficerName, Me.colAgentCode, Me.colAgentName, Me.colCode, Me.colBrand, Me.colModel, Me.colColor, Me.colKeyNo, Me.colEngineNo, Me.colChassisNo, Me.colwhCode, Me.colSaleType, Me.colCOD, Me.colLCP, Me.colFinancedAmt, Me.colDP, Me.colAOC, Me.colTerms, Me.colInterestRate, Me.colDateGranted, Me.colMaturityDate, Me.colFirstPayDate, Me.colLastMvmtDate, Me.colIntRatePerAnnum, Me.colPrincipalPMT, Me.colInterestPMT, Me.colPMT, Me.colRebates, Me.colPrincipalBalance, Me.colInterestBalance, Me.colOutstandingBalance, Me.colTransactedBy, Me.colDueDate, Me.colDue0, Me.colAdvanced, Me.colOverDue, Me.colDue1, Me.colDue2, Me.colBalance})
        Me.gridView.gridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsView.ColumnAutoWidth = False
        '
        'colsequenceNo
        '
        Me.colsequenceNo.Caption = "ID"
        Me.colsequenceNo.FieldName = "sequenceNo"
        Me.colsequenceNo.Name = "colsequenceNo"
        Me.colsequenceNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sequenceNo", "{N1}")})
        Me.colsequenceNo.Visible = True
        Me.colsequenceNo.VisibleIndex = 0
        '
        'colCORP
        '
        Me.colCORP.Caption = "Corporation"
        Me.colCORP.FieldName = "CORP"
        Me.colCORP.Name = "colCORP"
        Me.colCORP.Visible = True
        Me.colCORP.VisibleIndex = 1
        '
        'colReleaseType
        '
        Me.colReleaseType.Caption = "Release Type"
        Me.colReleaseType.FieldName = "ReleaseType"
        Me.colReleaseType.Name = "colReleaseType"
        Me.colReleaseType.Visible = True
        Me.colReleaseType.VisibleIndex = 2
        '
        'colBranchCode
        '
        Me.colBranchCode.Caption = "Branch"
        Me.colBranchCode.FieldName = "BranchCode"
        Me.colBranchCode.Name = "colBranchCode"
        Me.colBranchCode.Visible = True
        Me.colBranchCode.VisibleIndex = 3
        '
        'colBranch
        '
        Me.colBranch.Caption = "Branch"
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 4
        '
        'colCIFKey
        '
        Me.colCIFKey.Caption = "CIF Key"
        Me.colCIFKey.FieldName = "CIFKey"
        Me.colCIFKey.Name = "colCIFKey"
        Me.colCIFKey.Visible = True
        Me.colCIFKey.VisibleIndex = 5
        '
        'colAccountNumber
        '
        Me.colAccountNumber.Caption = "Account"
        Me.colAccountNumber.FieldName = "AccountNumber"
        Me.colAccountNumber.Name = "colAccountNumber"
        Me.colAccountNumber.Visible = True
        Me.colAccountNumber.VisibleIndex = 6
        '
        'colLedgerSetNumber
        '
        Me.colLedgerSetNumber.Caption = "Ledger"
        Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
        Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
        Me.colLedgerSetNumber.Visible = True
        Me.colLedgerSetNumber.VisibleIndex = 7
        '
        'colAccountStatus
        '
        Me.colAccountStatus.Caption = "Status"
        Me.colAccountStatus.FieldName = "AccountStatus"
        Me.colAccountStatus.Name = "colAccountStatus"
        Me.colAccountStatus.Visible = True
        Me.colAccountStatus.VisibleIndex = 8
        '
        'colAccountName
        '
        Me.colAccountName.Caption = "Name"
        Me.colAccountName.FieldName = "AccountName"
        Me.colAccountName.Name = "colAccountName"
        Me.colAccountName.Visible = True
        Me.colAccountName.VisibleIndex = 9
        '
        'colAccountAddress
        '
        Me.colAccountAddress.Caption = "Address"
        Me.colAccountAddress.FieldName = "AccountAddress"
        Me.colAccountAddress.Name = "colAccountAddress"
        Me.colAccountAddress.Visible = True
        Me.colAccountAddress.VisibleIndex = 10
        '
        'colAccountExecutive
        '
        Me.colAccountExecutive.Caption = "AE Code"
        Me.colAccountExecutive.FieldName = "AccountExecutive"
        Me.colAccountExecutive.Name = "colAccountExecutive"
        Me.colAccountExecutive.Visible = True
        Me.colAccountExecutive.VisibleIndex = 11
        '
        'colOfficerName
        '
        Me.colOfficerName.Caption = "Officer Name"
        Me.colOfficerName.FieldName = "OfficerName"
        Me.colOfficerName.Name = "colOfficerName"
        Me.colOfficerName.Visible = True
        Me.colOfficerName.VisibleIndex = 12
        '
        'colAgentCode
        '
        Me.colAgentCode.Caption = "Agent Code"
        Me.colAgentCode.FieldName = "AgentCode"
        Me.colAgentCode.Name = "colAgentCode"
        Me.colAgentCode.Visible = True
        Me.colAgentCode.VisibleIndex = 13
        '
        'colAgentName
        '
        Me.colAgentName.Caption = "Agent Name"
        Me.colAgentName.FieldName = "AgentName"
        Me.colAgentName.Name = "colAgentName"
        Me.colAgentName.Visible = True
        Me.colAgentName.VisibleIndex = 14
        '
        'colCode
        '
        Me.colCode.Caption = "Product Code"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 15
        '
        'colBrand
        '
        Me.colBrand.Caption = "Brand"
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 16
        '
        'colModel
        '
        Me.colModel.Caption = "Model"
        Me.colModel.FieldName = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.Visible = True
        Me.colModel.VisibleIndex = 17
        '
        'colColor
        '
        Me.colColor.Caption = "Color"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 18
        '
        'colKeyNo
        '
        Me.colKeyNo.Caption = "Key"
        Me.colKeyNo.FieldName = "KeyNo"
        Me.colKeyNo.Name = "colKeyNo"
        Me.colKeyNo.Visible = True
        Me.colKeyNo.VisibleIndex = 19
        '
        'colEngineNo
        '
        Me.colEngineNo.Caption = "Engine"
        Me.colEngineNo.FieldName = "EngineNo"
        Me.colEngineNo.Name = "colEngineNo"
        Me.colEngineNo.Visible = True
        Me.colEngineNo.VisibleIndex = 20
        '
        'colChassisNo
        '
        Me.colChassisNo.Caption = "Chassis"
        Me.colChassisNo.FieldName = "ChassisNo"
        Me.colChassisNo.Name = "colChassisNo"
        Me.colChassisNo.Visible = True
        Me.colChassisNo.VisibleIndex = 21
        '
        'colwhCode
        '
        Me.colwhCode.Caption = "Warehouse"
        Me.colwhCode.FieldName = "whCode"
        Me.colwhCode.Name = "colwhCode"
        Me.colwhCode.Visible = True
        Me.colwhCode.VisibleIndex = 22
        '
        'colSaleType
        '
        Me.colSaleType.Caption = "Type"
        Me.colSaleType.FieldName = "SaleType"
        Me.colSaleType.Name = "colSaleType"
        Me.colSaleType.Visible = True
        Me.colSaleType.VisibleIndex = 23
        '
        'colCOD
        '
        Me.colCOD.Caption = "COD"
        Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCOD.FieldName = "COD"
        Me.colCOD.Name = "colCOD"
        Me.colCOD.Visible = True
        Me.colCOD.VisibleIndex = 24
        '
        'colLCP
        '
        Me.colLCP.Caption = "LCP"
        Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLCP.FieldName = "LCP"
        Me.colLCP.Name = "colLCP"
        Me.colLCP.Visible = True
        Me.colLCP.VisibleIndex = 25
        '
        'colFinancedAmt
        '
        Me.colFinancedAmt.Caption = "SFC"
        Me.colFinancedAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFinancedAmt.FieldName = "FinancedAmt"
        Me.colFinancedAmt.Name = "colFinancedAmt"
        Me.colFinancedAmt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FinancedAmt", "SUM={0:N2}")})
        Me.colFinancedAmt.Visible = True
        Me.colFinancedAmt.VisibleIndex = 26
        '
        'colDP
        '
        Me.colDP.Caption = "Down Payment"
        Me.colDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDP.FieldName = "DP"
        Me.colDP.Name = "colDP"
        Me.colDP.Visible = True
        Me.colDP.VisibleIndex = 27
        '
        'colAOC
        '
        Me.colAOC.Caption = "AOC"
        Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAOC.FieldName = "AOC"
        Me.colAOC.Name = "colAOC"
        Me.colAOC.Visible = True
        Me.colAOC.VisibleIndex = 28
        '
        'colTerms
        '
        Me.colTerms.AppearanceCell.Options.UseTextOptions = True
        Me.colTerms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTerms.Caption = "Terms"
        Me.colTerms.FieldName = "Terms"
        Me.colTerms.Name = "colTerms"
        Me.colTerms.Visible = True
        Me.colTerms.VisibleIndex = 29
        '
        'colInterestRate
        '
        Me.colInterestRate.Caption = "Rate"
        Me.colInterestRate.FieldName = "InterestRate"
        Me.colInterestRate.Name = "colInterestRate"
        Me.colInterestRate.Visible = True
        Me.colInterestRate.VisibleIndex = 30
        '
        'colDateGranted
        '
        Me.colDateGranted.Caption = "Granted"
        Me.colDateGranted.FieldName = "DateGranted"
        Me.colDateGranted.Name = "colDateGranted"
        Me.colDateGranted.Visible = True
        Me.colDateGranted.VisibleIndex = 31
        '
        'colMaturityDate
        '
        Me.colMaturityDate.Caption = "Maturity"
        Me.colMaturityDate.FieldName = "MaturityDate"
        Me.colMaturityDate.Name = "colMaturityDate"
        Me.colMaturityDate.Visible = True
        Me.colMaturityDate.VisibleIndex = 32
        '
        'colFirstPayDate
        '
        Me.colFirstPayDate.Caption = "First Payment"
        Me.colFirstPayDate.FieldName = "FirstPayDate"
        Me.colFirstPayDate.Name = "colFirstPayDate"
        Me.colFirstPayDate.Visible = True
        Me.colFirstPayDate.VisibleIndex = 33
        '
        'colLastMvmtDate
        '
        Me.colLastMvmtDate.Caption = "Last Update"
        Me.colLastMvmtDate.FieldName = "LastMvmtDate"
        Me.colLastMvmtDate.Name = "colLastMvmtDate"
        Me.colLastMvmtDate.Visible = True
        Me.colLastMvmtDate.VisibleIndex = 34
        '
        'colIntRatePerAnnum
        '
        Me.colIntRatePerAnnum.Caption = "Rate per Annum"
        Me.colIntRatePerAnnum.FieldName = "IntRatePerAnnum"
        Me.colIntRatePerAnnum.Name = "colIntRatePerAnnum"
        Me.colIntRatePerAnnum.Visible = True
        Me.colIntRatePerAnnum.VisibleIndex = 35
        '
        'colPrincipalPMT
        '
        Me.colPrincipalPMT.Caption = "Monthly Principal"
        Me.colPrincipalPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrincipalPMT.FieldName = "PrincipalPMT"
        Me.colPrincipalPMT.Name = "colPrincipalPMT"
        Me.colPrincipalPMT.Visible = True
        Me.colPrincipalPMT.VisibleIndex = 36
        '
        'colInterestPMT
        '
        Me.colInterestPMT.Caption = "Monthly Interest"
        Me.colInterestPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInterestPMT.FieldName = "InterestPMT"
        Me.colInterestPMT.Name = "colInterestPMT"
        Me.colInterestPMT.Visible = True
        Me.colInterestPMT.VisibleIndex = 37
        '
        'colPMT
        '
        Me.colPMT.Caption = "Monthly"
        Me.colPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPMT.FieldName = "PMT"
        Me.colPMT.Name = "colPMT"
        Me.colPMT.Visible = True
        Me.colPMT.VisibleIndex = 38
        '
        'colRebates
        '
        Me.colRebates.Caption = "Rebate"
        Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRebates.FieldName = "Rebates"
        Me.colRebates.Name = "colRebates"
        Me.colRebates.Visible = True
        Me.colRebates.VisibleIndex = 39
        '
        'colPrincipalBalance
        '
        Me.colPrincipalBalance.Caption = "Principal"
        Me.colPrincipalBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrincipalBalance.FieldName = "PrincipalBalance"
        Me.colPrincipalBalance.Name = "colPrincipalBalance"
        Me.colPrincipalBalance.Visible = True
        Me.colPrincipalBalance.VisibleIndex = 40
        '
        'colInterestBalance
        '
        Me.colInterestBalance.Caption = "Interest"
        Me.colInterestBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInterestBalance.FieldName = "InterestBalance"
        Me.colInterestBalance.Name = "colInterestBalance"
        Me.colInterestBalance.Visible = True
        Me.colInterestBalance.VisibleIndex = 41
        '
        'colOutstandingBalance
        '
        Me.colOutstandingBalance.Caption = "Outstanding Balance"
        Me.colOutstandingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOutstandingBalance.FieldName = "OutstandingBalance"
        Me.colOutstandingBalance.Name = "colOutstandingBalance"
        Me.colOutstandingBalance.Visible = True
        Me.colOutstandingBalance.VisibleIndex = 42
        '
        'colTransactedBy
        '
        Me.colTransactedBy.Caption = "Added By"
        Me.colTransactedBy.FieldName = "TransactedBy"
        Me.colTransactedBy.Name = "colTransactedBy"
        Me.colTransactedBy.Visible = True
        Me.colTransactedBy.VisibleIndex = 43
        '
        'colDueDate
        '
        Me.colDueDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDueDate.Caption = "Due Date"
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 44
        '
        'colDue0
        '
        Me.colDue0.Caption = "Current Month"
        Me.colDue0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDue0.FieldName = "Due0"
        Me.colDue0.Name = "colDue0"
        Me.colDue0.Visible = True
        Me.colDue0.VisibleIndex = 45
        '
        'colAdvanced
        '
        Me.colAdvanced.Caption = "Advanced"
        Me.colAdvanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAdvanced.FieldName = "Advance"
        Me.colAdvanced.Name = "colAdvanced"
        Me.colAdvanced.Visible = True
        Me.colAdvanced.VisibleIndex = 46
        '
        'colOverDue
        '
        Me.colOverDue.Caption = "Over Due"
        Me.colOverDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOverDue.FieldName = "OverDue"
        Me.colOverDue.Name = "colOverDue"
        Me.colOverDue.Visible = True
        Me.colOverDue.VisibleIndex = 47
        '
        'colDue1
        '
        Me.colDue1.Caption = "Next Month"
        Me.colDue1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDue1.FieldName = "Due1"
        Me.colDue1.Name = "colDue1"
        Me.colDue1.Visible = True
        Me.colDue1.VisibleIndex = 48
        '
        'colDue2
        '
        Me.colDue2.Caption = "Next (2) Months"
        Me.colDue2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDue2.FieldName = "Due2"
        Me.colDue2.Name = "colDue2"
        Me.colDue2.Visible = True
        Me.colDue2.VisibleIndex = 49
        '
        'colBalance
        '
        Me.colBalance.Caption = "Balance"
        Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 50
        '
        'frm_Aging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 366)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_Aging"
        Me.Text = "Aging Form"
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.dockPanel1.ResumeLayout(False)
        Me.dockPanel1_Container.ResumeLayout(False)
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private barManager As DevExpress.XtraBars.BarManager
    Private bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Private bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Private BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsequenceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReleaseType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIFKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountExecutive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinancedAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterestRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateGranted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaturityDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstPayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastMvmtDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntRatePerAnnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrincipalPMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterestPMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrincipalBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterestBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutstandingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDue0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdvanced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDue2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Private barEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private dockManager As DevExpress.XtraBars.Docking.DockManager
    Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private check_Initialize As DevExpress.XtraEditors.CheckEdit
    Private check_Load_All As DevExpress.XtraEditors.CheckEdit
    Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
End Class

