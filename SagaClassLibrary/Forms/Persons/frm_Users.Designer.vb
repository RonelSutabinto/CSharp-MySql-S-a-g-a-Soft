Namespace Forms.Persons
    Partial Class frm_Users
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Users))
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
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar_User = New DevExpress.XtraBars.Bar()
            Me.btn_Receive_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Password_Reset = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Deactivate = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_User = New SagaClassLibrary.Controls.Persons.xuc_User()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.check_Password_Save = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colbranchcode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colusername = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.coldesignation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployee_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMI = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colfullname = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsOnline = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLast_Login = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMachineName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAppName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAppVersion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIP_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIP_Local = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsSuperUser = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsApprover = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsMaintenance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLogistics = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsInventory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsInventorySP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsAudit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsAccounting = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsCashier = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsBookkeeper = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsReceptionist = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colISNewAccounts = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsRelease = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsCollection = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsReports = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsBetaTester = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReset_Pass = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.colIP_Location = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.check_Password_Save.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar_User})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Password_Reset, Me.btn_Deactivate, Me.btn_Receive_Update})
            Me.barManager.MaxItemId = 13
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 2
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(124, 135)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 114
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 9
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 7
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar_User
            '
            Me.Bar_User.BarName = "User"
            Me.Bar_User.DockCol = 1
            Me.Bar_User.DockRow = 0
            Me.Bar_User.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_User.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Receive_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Password_Reset), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Deactivate)})
            Me.Bar_User.Offset = 110
            Me.Bar_User.Text = "User"
            '
            'btn_Receive_Update
            '
            Me.btn_Receive_Update.Caption = "Receive Update"
            Me.btn_Receive_Update.Id = 12
            Me.btn_Receive_Update.ImageOptions.Image = CType(resources.GetObject("btn_Receive_Update.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Receive_Update.ImageOptions.LargeImage = CType(resources.GetObject("btn_Receive_Update.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Receive_Update.Name = "btn_Receive_Update"
            '
            'btn_Password_Reset
            '
            Me.btn_Password_Reset.Caption = "Reset Password"
            Me.btn_Password_Reset.Id = 10
            Me.btn_Password_Reset.ImageOptions.ImageIndex = 8
            Me.btn_Password_Reset.ImageOptions.LargeImageIndex = 8
            Me.btn_Password_Reset.Name = "btn_Password_Reset"
            '
            'btn_Deactivate
            '
            Me.btn_Deactivate.Caption = "Deactivate"
            Me.btn_Deactivate.Id = 11
            Me.btn_Deactivate.ImageOptions.Image = CType(resources.GetObject("btn_Deactivate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Deactivate.ImageOptions.LargeImage = CType(resources.GetObject("btn_Deactivate.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Deactivate.Name = "btn_Deactivate"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(898, 24)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 514)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(898, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 490)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(898, 24)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 490)
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.FloatSize = New System.Drawing.Size(250, 300)
            Me.dockPanel1.ID = New System.Guid("537b326f-385d-4e56-bc31-e47314c728d4")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 24)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(321, 400)
            Me.dockPanel1.Size = New System.Drawing.Size(321, 490)
            Me.dockPanel1.Text = "User Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_User)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(314, 461)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_User
            '
            Me.xuc_User.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_User.Location = New System.Drawing.Point(0, 0)
            Me.xuc_User.Name = "xuc_User"
            Me.xuc_User.Size = New System.Drawing.Size(314, 461)
            Me.xuc_User.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("c617c5a3-6cfb-4b2a-bb3f-8d731425f8c3")
            Me.dockPanel2.Location = New System.Drawing.Point(628, 24)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(270, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(270, 490)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(263, 461)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.TabPane1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(263, 461)
            Me.panelControl1.TabIndex = 0
            '
            'TabPane1
            '
            Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
            Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
            Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabPane1.Location = New System.Drawing.Point(2, 2)
            Me.TabPane1.Name = "TabPane1"
            Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
            Me.TabPane1.RegularSize = New System.Drawing.Size(259, 457)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(259, 457)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(259, 424)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 424)
            Me.xuc_Settings.TabIndex = 1
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(187, 427)
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.check_Password_Save)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(187, 427)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'check_Password_Save
            '
            Me.check_Password_Save.Location = New System.Drawing.Point(12, 12)
            Me.check_Password_Save.MenuManager = Me.barManager
            Me.check_Password_Save.Name = "check_Password_Save"
            Me.check_Password_Save.Properties.AutoWidth = True
            Me.check_Password_Save.Properties.Caption = "Save password"
            Me.check_Password_Save.Size = New System.Drawing.Size(96, 20)
            Me.check_Password_Save.StyleController = Me.layoutControl
            Me.check_Password_Save.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(187, 427)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.check_Password_Save
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(167, 407)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(321, 24)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(307, 490)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsActive, Me.colCorporation, Me.colbranchcode, Me.colusername, Me.coldesignation, Me.colEmployee_Code, Me.colFName, Me.colMI, Me.colLName, Me.colfullname, Me.colIsOnline, Me.colLast_Login, Me.colMachineName, Me.colAppName, Me.colAppVersion, Me.colIP_Address, Me.colIP_Local, Me.colIsSuperUser, Me.colIsAdmin, Me.colIsApprover, Me.colIsMaintenance, Me.colIsLogistics, Me.colIsInventory, Me.colIsInventorySP, Me.colIsAudit, Me.colIsAccounting, Me.colIsCashier, Me.colIsBookkeeper, Me.colIsReceptionist, Me.colISNewAccounts, Me.colIsRelease, Me.colIsCollection, Me.colIsReports, Me.colIsUpdate, Me.colIsBetaTester, Me.colReset_Pass, Me.colIP_Location})
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
            'colIsActive
            '
            Me.colIsActive.FieldName = "IsActive"
            Me.colIsActive.Name = "colIsActive"
            Me.colIsActive.Visible = True
            Me.colIsActive.VisibleIndex = 1
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Corporation"
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            '
            'colbranchcode
            '
            Me.colbranchcode.Caption = "Branch"
            Me.colbranchcode.FieldName = "branchcode"
            Me.colbranchcode.Name = "colbranchcode"
            Me.colbranchcode.Visible = True
            Me.colbranchcode.VisibleIndex = 3
            '
            'colusername
            '
            Me.colusername.Caption = "User Name"
            Me.colusername.FieldName = "username"
            Me.colusername.Name = "colusername"
            Me.colusername.Visible = True
            Me.colusername.VisibleIndex = 4
            '
            'coldesignation
            '
            Me.coldesignation.Caption = "Designation"
            Me.coldesignation.FieldName = "designation"
            Me.coldesignation.Name = "coldesignation"
            Me.coldesignation.Visible = True
            Me.coldesignation.VisibleIndex = 5
            '
            'colEmployee_Code
            '
            Me.colEmployee_Code.Caption = "Employee"
            Me.colEmployee_Code.FieldName = "Employee_Code"
            Me.colEmployee_Code.Name = "colEmployee_Code"
            Me.colEmployee_Code.Visible = True
            Me.colEmployee_Code.VisibleIndex = 6
            '
            'colFName
            '
            Me.colFName.Caption = "First Name"
            Me.colFName.FieldName = "FName"
            Me.colFName.Name = "colFName"
            Me.colFName.Visible = True
            Me.colFName.VisibleIndex = 7
            '
            'colMI
            '
            Me.colMI.Caption = "MI"
            Me.colMI.FieldName = "MI"
            Me.colMI.Name = "colMI"
            Me.colMI.Visible = True
            Me.colMI.VisibleIndex = 8
            '
            'colLName
            '
            Me.colLName.Caption = "Last Name"
            Me.colLName.FieldName = "LName"
            Me.colLName.Name = "colLName"
            Me.colLName.Visible = True
            Me.colLName.VisibleIndex = 9
            '
            'colfullname
            '
            Me.colfullname.Caption = "Full Name"
            Me.colfullname.FieldName = "fullname"
            Me.colfullname.Name = "colfullname"
            Me.colfullname.Visible = True
            Me.colfullname.VisibleIndex = 10
            '
            'colIsOnline
            '
            Me.colIsOnline.Caption = "Online"
            Me.colIsOnline.FieldName = "IsOnline"
            Me.colIsOnline.Name = "colIsOnline"
            Me.colIsOnline.Visible = True
            Me.colIsOnline.VisibleIndex = 11
            '
            'colLast_Login
            '
            Me.colLast_Login.AppearanceCell.Options.UseTextOptions = True
            Me.colLast_Login.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.colLast_Login.Caption = "Last Login"
            Me.colLast_Login.DisplayFormat.FormatString = "MMM dd, yyyy hh:mm:ss tt"
            Me.colLast_Login.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.colLast_Login.FieldName = "Last_Login"
            Me.colLast_Login.Name = "colLast_Login"
            Me.colLast_Login.Visible = True
            Me.colLast_Login.VisibleIndex = 12
            '
            'colMachineName
            '
            Me.colMachineName.FieldName = "MachineName"
            Me.colMachineName.Name = "colMachineName"
            Me.colMachineName.Visible = True
            Me.colMachineName.VisibleIndex = 13
            '
            'colAppName
            '
            Me.colAppName.Caption = "Application"
            Me.colAppName.FieldName = "AppName"
            Me.colAppName.Name = "colAppName"
            Me.colAppName.Visible = True
            Me.colAppName.VisibleIndex = 14
            '
            'colAppVersion
            '
            Me.colAppVersion.Caption = "Version"
            Me.colAppVersion.FieldName = "AppVersion"
            Me.colAppVersion.Name = "colAppVersion"
            Me.colAppVersion.Visible = True
            Me.colAppVersion.VisibleIndex = 15
            '
            'colIP_Address
            '
            Me.colIP_Address.Caption = "IP Address"
            Me.colIP_Address.FieldName = "IP_Address"
            Me.colIP_Address.Name = "colIP_Address"
            Me.colIP_Address.Visible = True
            Me.colIP_Address.VisibleIndex = 16
            '
            'colIP_Local
            '
            Me.colIP_Local.Caption = "IP Local"
            Me.colIP_Local.FieldName = "IP_Local"
            Me.colIP_Local.Name = "colIP_Local"
            Me.colIP_Local.Visible = True
            Me.colIP_Local.VisibleIndex = 17
            '
            'colIsSuperUser
            '
            Me.colIsSuperUser.Caption = "Super User"
            Me.colIsSuperUser.FieldName = "IsSuperUser"
            Me.colIsSuperUser.Name = "colIsSuperUser"
            Me.colIsSuperUser.Visible = True
            Me.colIsSuperUser.VisibleIndex = 18
            '
            'colIsAdmin
            '
            Me.colIsAdmin.Caption = "Admin"
            Me.colIsAdmin.FieldName = "IsAdmin"
            Me.colIsAdmin.Name = "colIsAdmin"
            Me.colIsAdmin.Visible = True
            Me.colIsAdmin.VisibleIndex = 19
            '
            'colIsApprover
            '
            Me.colIsApprover.Caption = "Approver"
            Me.colIsApprover.FieldName = "IsApprover"
            Me.colIsApprover.Name = "colIsApprover"
            Me.colIsApprover.Visible = True
            Me.colIsApprover.VisibleIndex = 20
            '
            'colIsMaintenance
            '
            Me.colIsMaintenance.Caption = "Maintenance"
            Me.colIsMaintenance.FieldName = "IsMaintenance"
            Me.colIsMaintenance.Name = "colIsMaintenance"
            Me.colIsMaintenance.Visible = True
            Me.colIsMaintenance.VisibleIndex = 21
            '
            'colIsLogistics
            '
            Me.colIsLogistics.Caption = "Logistics"
            Me.colIsLogistics.FieldName = "IsLogistics"
            Me.colIsLogistics.Name = "colIsLogistics"
            Me.colIsLogistics.Visible = True
            Me.colIsLogistics.VisibleIndex = 22
            '
            'colIsInventory
            '
            Me.colIsInventory.Caption = "Inventory"
            Me.colIsInventory.FieldName = "IsInventory"
            Me.colIsInventory.Name = "colIsInventory"
            Me.colIsInventory.Visible = True
            Me.colIsInventory.VisibleIndex = 23
            '
            'colIsInventorySP
            '
            Me.colIsInventorySP.Caption = "Spare Parts"
            Me.colIsInventorySP.FieldName = "IsInventorySP"
            Me.colIsInventorySP.Name = "colIsInventorySP"
            Me.colIsInventorySP.Visible = True
            Me.colIsInventorySP.VisibleIndex = 24
            '
            'colIsAudit
            '
            Me.colIsAudit.Caption = "Audit"
            Me.colIsAudit.FieldName = "IsAudit"
            Me.colIsAudit.Name = "colIsAudit"
            Me.colIsAudit.Visible = True
            Me.colIsAudit.VisibleIndex = 25
            '
            'colIsAccounting
            '
            Me.colIsAccounting.Caption = "Accounting"
            Me.colIsAccounting.FieldName = "IsAccounting"
            Me.colIsAccounting.Name = "colIsAccounting"
            Me.colIsAccounting.Visible = True
            Me.colIsAccounting.VisibleIndex = 26
            '
            'colIsCashier
            '
            Me.colIsCashier.Caption = "Cashier"
            Me.colIsCashier.FieldName = "IsCashier"
            Me.colIsCashier.Name = "colIsCashier"
            Me.colIsCashier.Visible = True
            Me.colIsCashier.VisibleIndex = 27
            '
            'colIsBookkeeper
            '
            Me.colIsBookkeeper.Caption = "Bookkeeper"
            Me.colIsBookkeeper.FieldName = "IsBookkeeper"
            Me.colIsBookkeeper.Name = "colIsBookkeeper"
            Me.colIsBookkeeper.Visible = True
            Me.colIsBookkeeper.VisibleIndex = 28
            '
            'colIsReceptionist
            '
            Me.colIsReceptionist.Caption = "Receptionist"
            Me.colIsReceptionist.FieldName = "IsReceptionist"
            Me.colIsReceptionist.Name = "colIsReceptionist"
            Me.colIsReceptionist.Visible = True
            Me.colIsReceptionist.VisibleIndex = 29
            '
            'colISNewAccounts
            '
            Me.colISNewAccounts.Caption = "New Accounts"
            Me.colISNewAccounts.FieldName = "ISNewAccounts"
            Me.colISNewAccounts.Name = "colISNewAccounts"
            Me.colISNewAccounts.Visible = True
            Me.colISNewAccounts.VisibleIndex = 30
            '
            'colIsRelease
            '
            Me.colIsRelease.Caption = "Release"
            Me.colIsRelease.FieldName = "IsRelease"
            Me.colIsRelease.Name = "colIsRelease"
            Me.colIsRelease.Visible = True
            Me.colIsRelease.VisibleIndex = 31
            '
            'colIsCollection
            '
            Me.colIsCollection.Caption = "Collection"
            Me.colIsCollection.FieldName = "IsCollection"
            Me.colIsCollection.Name = "colIsCollection"
            Me.colIsCollection.Visible = True
            Me.colIsCollection.VisibleIndex = 32
            '
            'colIsReports
            '
            Me.colIsReports.Caption = "Reports"
            Me.colIsReports.FieldName = "IsReports"
            Me.colIsReports.Name = "colIsReports"
            Me.colIsReports.Visible = True
            Me.colIsReports.VisibleIndex = 33
            '
            'colIsUpdate
            '
            Me.colIsUpdate.FieldName = "IsUpdate"
            Me.colIsUpdate.Name = "colIsUpdate"
            Me.colIsUpdate.Visible = True
            Me.colIsUpdate.VisibleIndex = 34
            '
            'colIsBetaTester
            '
            Me.colIsBetaTester.FieldName = "IsBetaTester"
            Me.colIsBetaTester.Name = "colIsBetaTester"
            Me.colIsBetaTester.Visible = True
            Me.colIsBetaTester.VisibleIndex = 35
            '
            'colReset_Pass
            '
            Me.colReset_Pass.Caption = "Reset Password"
            Me.colReset_Pass.FieldName = "Reset_Pass"
            Me.colReset_Pass.Name = "colReset_Pass"
            Me.colReset_Pass.Visible = True
            Me.colReset_Pass.VisibleIndex = 36
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Receive_Update, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Password_Reset, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Deactivate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'colIP_Location
            '
            Me.colIP_Location.Caption = "IP Address Location"
            Me.colIP_Location.FieldName = "IP_Location"
            Me.colIP_Location.Name = "colIP_Location"
            Me.colIP_Location.Visible = True
            Me.colIP_Location.VisibleIndex = 37
            '
            'frm_Users
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 514)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Users"
            Me.ShowMdiChildCaptionInParentTitle = True
            Me.Text = "Application Users"
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.check_Password_Save.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colusername As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents coldesignation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEmployee_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colbranchcode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsSuperUser As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsAdmin As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsApprover As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsMaintenance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLogistics As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsInventory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsInventorySP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsAccounting As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsBookkeeper As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsAudit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colISNewAccounts As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsRelease As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsCollection As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsCashier As DevExpress.XtraGrid.Columns.GridColumn
        Private check_Password_Save As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents colLast_Login As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAppVersion As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIP_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsReceptionist As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsReports As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMachineName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Bar_User As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Password_Reset As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colReset_Pass As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsOnline As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIP_Local As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_User As Controls.Persons.xuc_User
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents colFName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMI As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colfullname As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAppName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Deactivate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsUpdate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Receive_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsBetaTester As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIP_Location As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace