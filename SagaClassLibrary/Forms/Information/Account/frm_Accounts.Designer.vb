Namespace Forms.Information.Account
    Partial Class frm_Accounts
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Accounts))
            Me.xuc_Accounts = New Controls.Information.Account.xuc_Accounts()
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
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            me.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
            Me.ToggleClosedAccounts = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.BarEditItem_Date_Granted = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemDateEdit_Date_Granted = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerBottom = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Grid_Ledger = New Controls.Information.Account.xuc_Grid_Ledger()
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Account = New Controls.Information.Account.xuc_Account()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.check_Ledger_Show = New DevExpress.XtraEditors.CheckEdit()
            Me.check_form_Account = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.barCheckItem_Closed_Accounts = New DevExpress.XtraBars.BarCheckItem()
            Me.repositoryItemcheckEdit_Accounts_Closed = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_SMS = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit_Date_Granted, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerBottom.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            Me.hideContainerLeft.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.check_Ledger_Show.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_form_Account.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemcheckEdit_Accounts_Closed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xuc_Accounts
            '
            Me.xuc_Accounts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Accounts.Location = New System.Drawing.Point(21, 45)
            Me.xuc_Accounts.Name = "xuc_Accounts"
            Me.xuc_Accounts.Size = New System.Drawing.Size(626, 484)
            Me.xuc_Accounts.TabIndex = 0
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3, Me.Bar4})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Preview, Me.barEditItem_Branch, Me.btn_Journal, Me.btn_Stop, Me.BarEditItem_Date_Granted, Me.barCheckItem_Closed_Accounts, Me.ToggleClosedAccounts, Me.btn_SMS})
            Me.barManager.MaxItemId = 20
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.repositoryItemLookUpEdit_Branch, Me.repositoryItemcheckEdit_Accounts_Closed, Me.repositoryItemDateEdit_Date_Granted})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(-1427, -110)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 364
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleClosedAccounts), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Date_Granted)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 11
            Me.barEditItem_Branch.ImageOptions.ImageIndex = 7
            Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 7
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "&Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 7
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 8
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'ToggleClosedAccounts
            '
            Me.ToggleClosedAccounts.Caption = "Closed Accounts"
            Me.ToggleClosedAccounts.Id = 18
            Me.ToggleClosedAccounts.ImageOptions.Image = CType(resources.GetObject("ToggleClosedAccounts.ImageOptions.Image"), System.Drawing.Image)
            Me.ToggleClosedAccounts.ImageOptions.ImageIndex = 9
            Me.ToggleClosedAccounts.ImageOptions.LargeImage = CType(resources.GetObject("ToggleClosedAccounts.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.ToggleClosedAccounts.ImageOptions.LargeImageIndex = 9
            Me.ToggleClosedAccounts.Name = "ToggleClosedAccounts"
            '
            'BarEditItem_Date_Granted
            '
            Me.BarEditItem_Date_Granted.Caption = "Released"
            Me.BarEditItem_Date_Granted.Edit = Me.repositoryItemDateEdit_Date_Granted
            Me.BarEditItem_Date_Granted.Id = 16
            Me.BarEditItem_Date_Granted.Name = "BarEditItem_Date_Granted"
            '
            'repositoryItemDateEdit_Date_Granted
            '
            Me.repositoryItemDateEdit_Date_Granted.AutoHeight = False
            Me.repositoryItemDateEdit_Date_Granted.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit_Date_Granted.DisplayFormat.FormatString = "MMM dd, yyyy"
            Me.repositoryItemDateEdit_Date_Granted.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.repositoryItemDateEdit_Date_Granted.EditFormat.FormatString = "MMM dd, yyyy"
            Me.repositoryItemDateEdit_Date_Granted.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.repositoryItemDateEdit_Date_Granted.Mask.BeepOnError = True
            Me.repositoryItemDateEdit_Date_Granted.Mask.EditMask = "MMM dd, yyyy"
            Me.repositoryItemDateEdit_Date_Granted.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemDateEdit_Date_Granted.Name = "repositoryItemDateEdit_Date_Granted"
            '
            'bar3
            '
            Me.bar3.BarName = "Journal"
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 1
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.bar3.Text = "Journal"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 14
            Me.btn_Journal.ImageOptions.ImageIndex = 10
            Me.btn_Journal.ImageOptions.LargeImageIndex = 10
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Sto&p"
            Me.btn_Stop.Id = 15
            Me.btn_Stop.ImageOptions.ImageIndex = 11
            Me.btn_Stop.ImageOptions.LargeImageIndex = 11
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(879, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 550)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(879, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 505)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(879, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 505)
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerBottom, Me.hideContainerLeft})
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'hideContainerBottom
            '
            Me.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerBottom.Controls.Add(Me.dockPanel4)
            Me.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.hideContainerBottom.Location = New System.Drawing.Point(21, 529)
            Me.hideContainerBottom.Name = "hideContainerBottom"
            Me.hideContainerBottom.Size = New System.Drawing.Size(858, 21)
            '
            'dockPanel4
            '
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel4.FloatVertical = True
            Me.dockPanel4.ID = New System.Guid("7de6be12-21db-4b2f-9195-f75e2e94962e")
            Me.dockPanel4.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel4.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel4.SavedIndex = 0
            Me.dockPanel4.Size = New System.Drawing.Size(722, 200)
            Me.dockPanel4.Text = "Ledger"
            Me.dockPanel4.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel4_Container
            '
            Me.dockPanel4_Container.Controls.Add(Me.xuc_Grid_Ledger)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(4, 24)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(714, 172)
            Me.dockPanel4_Container.TabIndex = 0
            '
            'xuc_Grid_Ledger
            '
            Me.xuc_Grid_Ledger.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Ledger.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Ledger.Name = "xuc_Grid_Ledger"
            Me.xuc_Grid_Ledger.Size = New System.Drawing.Size(714, 172)
            Me.xuc_Grid_Ledger.TabIndex = 0
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.dockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 45)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 505)
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("a54679a4-0121-42ec-87e0-2a7235ab01d2")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(623, 200)
            Me.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.SavedIndex = 0
            Me.dockPanel1.Size = New System.Drawing.Size(623, 370)
            Me.dockPanel1.Text = "Account Information"
            Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Account)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(616, 341)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Account
            '
            Me.xuc_Account.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.xuc_Account.Appearance.Options.UseForeColor = True
            Me.xuc_Account.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account.Name = "xuc_Account"
            Me.xuc_Account.Size = New System.Drawing.Size(616, 341)
            Me.xuc_Account.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("a2acc8f0-2f38-4426-a422-3c56e0f62951")
            Me.dockPanel2.Location = New System.Drawing.Point(647, 45)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(232, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(232, 484)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(225, 455)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.TabPane1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(225, 455)
            Me.panelControl1.TabIndex = 8
            '
            'TabPane1
            '
            Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
            Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
            Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabPane1.Location = New System.Drawing.Point(2, 2)
            Me.TabPane1.Name = "TabPane1"
            Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
            Me.TabPane1.RegularSize = New System.Drawing.Size(221, 451)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(221, 451)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Settings"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(221, 422)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(221, 422)
            Me.xuc_Settings.TabIndex = 0
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(221, 422)
            '
            'LayoutControl1
            '
            Me.layoutControl.Controls.Add(Me.check_Ledger_Show)
            Me.layoutControl.Controls.Add(Me.check_form_Account)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "LayoutControl1"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(221, 422)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'check_Ledger_Show
            '
            Me.check_Ledger_Show.Location = New System.Drawing.Point(12, 36)
            Me.check_Ledger_Show.MenuManager = Me.barManager
            Me.check_Ledger_Show.Name = "check_Ledger_Show"
            Me.check_Ledger_Show.Properties.AutoWidth = True
            Me.check_Ledger_Show.Properties.Caption = "Show Ledger"
            Me.check_Ledger_Show.Size = New System.Drawing.Size(85, 20)
            Me.check_Ledger_Show.StyleController = Me.layoutControl
            Me.check_Ledger_Show.TabIndex = 1
            '
            'check_form_Account
            '
            Me.check_form_Account.Location = New System.Drawing.Point(12, 12)
            Me.check_form_Account.MenuManager = Me.barManager
            Me.check_form_Account.Name = "check_form_Account"
            Me.check_form_Account.Properties.AutoWidth = True
            Me.check_form_Account.Properties.Caption = "Account Form"
            Me.check_form_Account.Size = New System.Drawing.Size(89, 20)
            Me.check_form_Account.StyleController = Me.layoutControl
            Me.check_form_Account.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(221, 422)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.check_form_Account
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(201, 24)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(201, 354)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.check_Ledger_Show
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(201, 24)
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'barCheckItem_Closed_Accounts
            '
            Me.barCheckItem_Closed_Accounts.Caption = "Closed Accounts"
            Me.barCheckItem_Closed_Accounts.Id = 17
            Me.barCheckItem_Closed_Accounts.ImageOptions.ImageIndex = 9
            Me.barCheckItem_Closed_Accounts.Name = "barCheckItem_Closed_Accounts"
            '
            'repositoryItemcheckEdit_Accounts_Closed
            '
            Me.repositoryItemcheckEdit_Accounts_Closed.AutoHeight = False
            Me.repositoryItemcheckEdit_Accounts_Closed.Name = "repositoryItemcheckEdit_Accounts_Closed"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Custom 5"
            Me.Bar4.DockCol = 1
            Me.Bar4.DockRow = 1
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SMS)})
            Me.Bar4.Offset = 110
            Me.Bar4.Text = "Custom 5"
            '
            'btn_SMS
            '
            Me.btn_SMS.Caption = "Send SMS"
            Me.btn_SMS.Id = 19
            Me.btn_SMS.Name = "btn_SMS"
            '
            'frm_Accounts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(879, 550)
            Me.Controls.Add(Me.xuc_Accounts)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.hideContainerBottom)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Accounts"
            Me.Text = "Accounts List"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit_Date_Granted, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerBottom.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            Me.hideContainerLeft.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.check_Ledger_Show.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_form_Account.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemcheckEdit_Accounts_Closed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
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
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private xuc_Account As Controls.Information.Account.xuc_Account
        Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private check_form_Account As DevExpress.XtraEditors.CheckEdit
        Private check_Ledger_Show As DevExpress.XtraEditors.CheckEdit
        Private hideContainerBottom As DevExpress.XtraBars.Docking.AutoHideContainer
        Private xuc_Grid_Ledger As Controls.Information.Account.xuc_Grid_Ledger
        Private hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Private barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private repositoryItemcheckEdit_Accounts_Closed As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Private bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Private BarEditItem_Date_Granted As DevExpress.XtraBars.BarEditItem
        Private repositoryItemDateEdit_Date_Granted As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents barCheckItem_Closed_Accounts As DevExpress.XtraBars.BarCheckItem
        Friend WithEvents xuc_Accounts As Controls.Information.Account.xuc_Accounts
        Friend WithEvents ToggleClosedAccounts As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_SMS As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
