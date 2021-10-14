Namespace Forms.Information.Account
    Partial Class frm_Account_Applications
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
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
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            me.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Account_Application = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Application()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIFKey = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateGranted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMaturityDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastMvmtDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountExecutive = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinancedAmt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApprover = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateOutApprover = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgentCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCRNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutStandingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel2, Me.dockPanel1})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
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
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.barEditItem_Branch})
            Me.barManager.MaxItemId = 11
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.repositoryItemLookUpEdit_Branch})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 117
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 10
            Me.barEditItem_Branch.ImageOptions.ImageIndex = 7
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(814, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 483)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(814, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 463)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(814, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 463)
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("eefd8776-37f7-4f3b-bdaa-54761a1c75df")
            Me.dockPanel2.Location = New System.Drawing.Point(614, 20)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 463)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(193, 434)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.xuc_Settings)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(193, 434)
            Me.panelControl1.TabIndex = 9
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(189, 430)
            Me.xuc_Settings.TabIndex = 0
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("d59d3024-1a38-424e-ab28-944f6fc9cde0")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 463)
            Me.dockPanel1.Text = "Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Account_Application)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 434)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Account_Application
            '
            Me.xuc_Account_Application.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Application.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Application.Name = "xuc_Account_Application"
            Me.xuc_Account_Application.Size = New System.Drawing.Size(293, 434)
            Me.xuc_Account_Application.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(300, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch})
            Me.gridControl.Size = New System.Drawing.Size(314, 463)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colBranchCode, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colCIFKey, Me.colAccountName, Me.colAccountAddress, Me.colStatus, Me.colwhCode, Me.colCode, Me.colBrand, Me.colModel, Me.colColor, Me.colKeyNo, Me.colEngineNo, Me.colChassisNo, Me.colSaleType, Me.colDateGranted, Me.colMaturityDate, Me.colFirstPayDate, Me.colLastMvmtDate, Me.colInterestRate, Me.colAccountExecutive, Me.colCOD, Me.colLCP, Me.colDP, Me.colAOC, Me.colFinancedAmt, Me.colTerms, Me.colPMT, Me.colPrincipalBalance, Me.colInterestBalance, Me.colRemarks, Me.colORNo, Me.colApprover, Me.colDateOutApprover, Me.colTransactedBy, Me.colTag, Me.colAgentCode, Me.colRebates, Me.colCRNo, Me.colPrincipalPMT, Me.colInterestPMT, Me.colOutStandingBalance})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colBranchCode
            '
            Me.colBranchCode.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 1
            '
            'colAccountNumber
            '
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 2
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 3
            '
            'colCIFKey
            '
            Me.colCIFKey.FieldName = "CIFKey"
            Me.colCIFKey.Name = "colCIFKey"
            Me.colCIFKey.Visible = True
            Me.colCIFKey.VisibleIndex = 4
            '
            'colAccountName
            '
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 5
            '
            'colAccountAddress
            '
            Me.colAccountAddress.FieldName = "AccountAddress"
            Me.colAccountAddress.Name = "colAccountAddress"
            Me.colAccountAddress.Visible = True
            Me.colAccountAddress.VisibleIndex = 6
            '
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 7
            '
            'colwhCode
            '
            Me.colwhCode.Caption = "Warehouse"
            Me.colwhCode.FieldName = "whCode"
            Me.colwhCode.Name = "colwhCode"
            Me.colwhCode.Visible = True
            Me.colwhCode.VisibleIndex = 8
            '
            'colCode
            '
            Me.colCode.FieldName = "Code"
            Me.colCode.Name = "colCode"
            Me.colCode.Visible = True
            Me.colCode.VisibleIndex = 9
            '
            'colBrand
            '
            Me.colBrand.Caption = "Brand"
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 10
            '
            'colModel
            '
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 11
            '
            'colColor
            '
            Me.colColor.Caption = "Color"
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 12
            '
            'colKeyNo
            '
            Me.colKeyNo.Caption = "Key"
            Me.colKeyNo.FieldName = "KeyNo"
            Me.colKeyNo.Name = "colKeyNo"
            Me.colKeyNo.Visible = True
            Me.colKeyNo.VisibleIndex = 13
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 14
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 15
            '
            'colSaleType
            '
            Me.colSaleType.FieldName = "SaleType"
            Me.colSaleType.Name = "colSaleType"
            Me.colSaleType.Visible = True
            Me.colSaleType.VisibleIndex = 16
            '
            'colDateGranted
            '
            Me.colDateGranted.Caption = "Granted"
            Me.colDateGranted.FieldName = "DateGranted"
            Me.colDateGranted.Name = "colDateGranted"
            Me.colDateGranted.Visible = True
            Me.colDateGranted.VisibleIndex = 17
            '
            'colMaturityDate
            '
            Me.colMaturityDate.Caption = "Maturity"
            Me.colMaturityDate.FieldName = "MaturityDate"
            Me.colMaturityDate.Name = "colMaturityDate"
            Me.colMaturityDate.Visible = True
            Me.colMaturityDate.VisibleIndex = 18
            '
            'colFirstPayDate
            '
            Me.colFirstPayDate.Caption = "First Payment"
            Me.colFirstPayDate.FieldName = "FirstPayDate"
            Me.colFirstPayDate.Name = "colFirstPayDate"
            Me.colFirstPayDate.Visible = True
            Me.colFirstPayDate.VisibleIndex = 19
            '
            'colLastMvmtDate
            '
            Me.colLastMvmtDate.Caption = "Updated"
            Me.colLastMvmtDate.FieldName = "LastMvmtDate"
            Me.colLastMvmtDate.Name = "colLastMvmtDate"
            Me.colLastMvmtDate.Visible = True
            Me.colLastMvmtDate.VisibleIndex = 31
            '
            'colInterestRate
            '
            Me.colInterestRate.FieldName = "InterestRate"
            Me.colInterestRate.Name = "colInterestRate"
            Me.colInterestRate.Visible = True
            Me.colInterestRate.VisibleIndex = 20
            '
            'colAccountExecutive
            '
            Me.colAccountExecutive.FieldName = "AccountExecutive"
            Me.colAccountExecutive.Name = "colAccountExecutive"
            Me.colAccountExecutive.Visible = True
            Me.colAccountExecutive.VisibleIndex = 21
            '
            'colCOD
            '
            Me.colCOD.Caption = "COD"
            Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCOD.FieldName = "COD"
            Me.colCOD.Name = "colCOD"
            Me.colCOD.Visible = True
            Me.colCOD.VisibleIndex = 22
            '
            'colLCP
            '
            Me.colLCP.Caption = "LCP"
            Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLCP.FieldName = "LCP"
            Me.colLCP.Name = "colLCP"
            Me.colLCP.Visible = True
            Me.colLCP.VisibleIndex = 23
            '
            'colDP
            '
            Me.colDP.Caption = "Down Payment"
            Me.colDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDP.FieldName = "DP"
            Me.colDP.Name = "colDP"
            Me.colDP.Visible = True
            Me.colDP.VisibleIndex = 24
            '
            'colAOC
            '
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 25
            '
            'colFinancedAmt
            '
            Me.colFinancedAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFinancedAmt.FieldName = "FinancedAmt"
            Me.colFinancedAmt.Name = "colFinancedAmt"
            Me.colFinancedAmt.Visible = True
            Me.colFinancedAmt.VisibleIndex = 26
            '
            'colTerms
            '
            Me.colTerms.FieldName = "Terms"
            Me.colTerms.Name = "colTerms"
            Me.colTerms.Visible = True
            Me.colTerms.VisibleIndex = 27
            '
            'colPMT
            '
            Me.colPMT.Caption = "Amortization"
            Me.colPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPMT.FieldName = "PMT"
            Me.colPMT.Name = "colPMT"
            Me.colPMT.Visible = True
            Me.colPMT.VisibleIndex = 28
            '
            'colPrincipalBalance
            '
            Me.colPrincipalBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalBalance.FieldName = "PrincipalBalance"
            Me.colPrincipalBalance.Name = "colPrincipalBalance"
            Me.colPrincipalBalance.Visible = True
            Me.colPrincipalBalance.VisibleIndex = 29
            '
            'colInterestBalance
            '
            Me.colInterestBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestBalance.FieldName = "InterestBalance"
            Me.colInterestBalance.Name = "colInterestBalance"
            Me.colInterestBalance.Visible = True
            Me.colInterestBalance.VisibleIndex = 30
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 32
            '
            'colid
            '
            Me.colid.Caption = "ID"
            Me.colid.FieldName = "id"
            Me.colid.Name = "colid"
            Me.colid.Visible = True
            Me.colid.VisibleIndex = 0
            '
            'colORNo
            '
            Me.colORNo.FieldName = "ORNo"
            Me.colORNo.Name = "colORNo"
            Me.colORNo.Visible = True
            Me.colORNo.VisibleIndex = 33
            '
            'colApprover
            '
            Me.colApprover.FieldName = "Approver"
            Me.colApprover.Name = "colApprover"
            Me.colApprover.Visible = True
            Me.colApprover.VisibleIndex = 34
            '
            'colDateOutApprover
            '
            Me.colDateOutApprover.Caption = "Approved"
            Me.colDateOutApprover.FieldName = "DateOutApprover"
            Me.colDateOutApprover.Name = "colDateOutApprover"
            Me.colDateOutApprover.Visible = True
            Me.colDateOutApprover.VisibleIndex = 35
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Added By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 36
            '
            'colTag
            '
            Me.colTag.FieldName = "Tag"
            Me.colTag.Name = "colTag"
            Me.colTag.Visible = True
            Me.colTag.VisibleIndex = 37
            '
            'colAgentCode
            '
            Me.colAgentCode.FieldName = "AgentCode"
            Me.colAgentCode.Name = "colAgentCode"
            Me.colAgentCode.Visible = True
            Me.colAgentCode.VisibleIndex = 38
            '
            'colRebates
            '
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 39
            '
            'colCRNo
            '
            Me.colCRNo.FieldName = "CRNo"
            Me.colCRNo.Name = "colCRNo"
            Me.colCRNo.Visible = True
            Me.colCRNo.VisibleIndex = 40
            '
            'colPrincipalPMT
            '
            Me.colPrincipalPMT.Caption = "Principal"
            Me.colPrincipalPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalPMT.FieldName = "PrincipalPMT"
            Me.colPrincipalPMT.Name = "colPrincipalPMT"
            Me.colPrincipalPMT.Visible = True
            Me.colPrincipalPMT.VisibleIndex = 41
            '
            'colInterestPMT
            '
            Me.colInterestPMT.Caption = "Interest"
            Me.colInterestPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestPMT.FieldName = "InterestPMT"
            Me.colInterestPMT.Name = "colInterestPMT"
            Me.colInterestPMT.Visible = True
            Me.colInterestPMT.VisibleIndex = 42
            '
            'colOutStandingBalance
            '
            Me.colOutStandingBalance.Caption = "Outstanding Balance"
            Me.colOutStandingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutStandingBalance.FieldName = "OutStandingBalance"
            Me.colOutStandingBalance.Name = "colOutStandingBalance"
            Me.colOutStandingBalance.Visible = True
            Me.colOutStandingBalance.VisibleIndex = 43
            '
            'frm_Account_Applications
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(814, 483)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Account_Applications"
            Me.Text = "Account Applications"
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
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
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIFKey As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKeyNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateGranted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMaturityDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFirstPayDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountExecutive As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFinancedAmt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLastMvmtDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApprover As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateOutApprover As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgentCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCRNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutStandingBalance As DevExpress.XtraGrid.Columns.GridColumn
        Private xuc_Account_Application As Controls.Information.Account.xuc_Account_Application
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    End Class

End Namespace