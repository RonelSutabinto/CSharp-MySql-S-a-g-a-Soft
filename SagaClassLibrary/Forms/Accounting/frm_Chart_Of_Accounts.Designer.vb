Namespace Forms.Accounting
    Partial Class frm_Chart_Of_Accounts
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Chart_Of_Accounts))
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.gridControlCOA = New DevExpress.XtraGrid.GridControl()
            Me.gridViewCOA = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colLevelNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSummaryAccount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Migrate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Convert_Summary = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Another_Entry = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Insert = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.btn_Expand = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Collapse = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_COA_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.BarEditItem_Date_Type = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Date_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.toggle_Balance_Type = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.btn_Trial_Balance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Summary = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Lock = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Account_Code_Re_Assign = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_FS = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemtoggle_Balance_Date_Type = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Chart_Of_Account = New SagaClassLibrary.Controls.Accounting.xuc_Chart_Of_Account()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.toggle_Auto_Expand = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Statement = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Level = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFS_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Desc = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Normal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsFS = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLedger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Running = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Limit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.colCOA_Name1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colFS_Name1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Code1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Summary1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCorporation1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Statement1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Type1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Level1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Desc1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Normal1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIsFS1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIsLedger1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Date1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Running1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Limit1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colNotes1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAdded_By1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAdded_Date1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colModified_By1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colModified_Date1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIsLocked1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colLocked_By1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colLocked_Date1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colID1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.gridControlCOA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridViewCOA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Date_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Balance_Date_Type, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.toggle_Auto_Expand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            Me.XtraTabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.dockPanel3)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(977, 45)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 523)
            '
            'dockPanel3
            '
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel3.ID = New System.Guid("e8bf2a07-5157-4d5f-a478-d20355f9305d")
            Me.dockPanel3.Location = New System.Drawing.Point(530, 45)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(400, 200)
            Me.dockPanel3.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel3.SavedIndex = 1
            Me.dockPanel3.Size = New System.Drawing.Size(400, 491)
            Me.dockPanel3.Text = "Sample"
            Me.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel3_Container
            '
            Me.dockPanel3_Container.Controls.Add(Me.panelControl2)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(393, 462)
            Me.dockPanel3_Container.TabIndex = 0
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.gridControlCOA)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(393, 462)
            Me.panelControl2.TabIndex = 0
            '
            'gridControlCOA
            '
            Me.gridControlCOA.DataMember = "ChartOfAccounts"
            Me.gridControlCOA.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControlCOA.Location = New System.Drawing.Point(2, 2)
            Me.gridControlCOA.MainView = Me.gridViewCOA
            Me.gridControlCOA.Name = "gridControlCOA"
            Me.gridControlCOA.Size = New System.Drawing.Size(389, 458)
            Me.gridControlCOA.TabIndex = 1
            Me.gridControlCOA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCOA})
            '
            'gridViewCOA
            '
            Me.gridViewCOA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLevelNumber, Me.colAccountCode, Me.colSummaryAccount, Me.colAccountType, Me.colDescription})
            Me.gridViewCOA.GridControl = Me.gridControlCOA
            Me.gridViewCOA.Name = "gridViewCOA"
            Me.gridViewCOA.OptionsView.ColumnAutoWidth = False
            '
            'colLevelNumber
            '
            Me.colLevelNumber.FieldName = "LevelNumber"
            Me.colLevelNumber.Name = "colLevelNumber"
            Me.colLevelNumber.Visible = True
            Me.colLevelNumber.VisibleIndex = 0
            '
            'colAccountCode
            '
            Me.colAccountCode.FieldName = "AccountCode"
            Me.colAccountCode.Name = "colAccountCode"
            Me.colAccountCode.Visible = True
            Me.colAccountCode.VisibleIndex = 1
            '
            'colSummaryAccount
            '
            Me.colSummaryAccount.FieldName = "SummaryAccount"
            Me.colSummaryAccount.Name = "colSummaryAccount"
            Me.colSummaryAccount.Visible = True
            Me.colSummaryAccount.VisibleIndex = 2
            '
            'colAccountType
            '
            Me.colAccountType.FieldName = "AccountType"
            Me.colAccountType.Name = "colAccountType"
            Me.colAccountType.Visible = True
            Me.colAccountType.VisibleIndex = 3
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 4
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.Bar3, Me.Bar2, Me.Bar4})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Summary, Me.btn_Delete, Me.btn_Convert_Summary, Me.btn_Another_Entry, Me.btn_Insert, Me.btn_Expand, Me.btn_Collapse, Me.btn_COA_Ledger, Me.btn_Lock, Me.btn_Trial_Balance, Me.btn_Migrate, Me.btn_Account_Code_Re_Assign, Me.BarEditItem_Date_Type, Me.toggle_Balance_Type, Me.btn_Stop, Me.btn_FS, Me.btn_Update})
            Me.barManager.MaxItemId = 38
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemtoggle_Balance_Date_Type, Me.RepositoryItemComboBox_Date_Type})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Commands"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(574, 200)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 474
            Me.bar1.Text = "Commands"
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
            Me.btn_Update.Id = 37
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 10
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
            'Bar3
            '
            Me.Bar3.BarName = "Actions"
            Me.Bar3.DockCol = 1
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Migrate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Convert_Summary), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Another_Entry), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Insert)})
            Me.Bar3.Text = "Actions"
            '
            'btn_Migrate
            '
            Me.btn_Migrate.Caption = "Migrate To Account"
            Me.btn_Migrate.Id = 26
            Me.btn_Migrate.ImageOptions.Image = CType(resources.GetObject("btn_Migrate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Migrate.ImageOptions.LargeImage = CType(resources.GetObject("btn_Migrate.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Migrate.Name = "btn_Migrate"
            Me.btn_Migrate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'btn_Convert_Summary
            '
            Me.btn_Convert_Summary.Caption = "Convert to Summary"
            Me.btn_Convert_Summary.Id = 11
            Me.btn_Convert_Summary.ImageOptions.ImageIndex = 7
            Me.btn_Convert_Summary.ImageOptions.LargeImageIndex = 7
            Me.btn_Convert_Summary.Name = "btn_Convert_Summary"
            '
            'btn_Another_Entry
            '
            Me.btn_Another_Entry.Caption = "Another Entry"
            Me.btn_Another_Entry.Id = 13
            Me.btn_Another_Entry.ImageOptions.ImageIndex = 1
            Me.btn_Another_Entry.ImageOptions.LargeImageIndex = 1
            Me.btn_Another_Entry.Name = "btn_Another_Entry"
            '
            'btn_Insert
            '
            Me.btn_Insert.Caption = "Insert"
            Me.btn_Insert.Id = 14
            Me.btn_Insert.ImageOptions.ImageIndex = 8
            Me.btn_Insert.ImageOptions.LargeImageIndex = 8
            Me.btn_Insert.Name = "btn_Insert"
            '
            'Bar2
            '
            Me.Bar2.BarName = "TreeList"
            Me.Bar2.DockCol = 0
            Me.Bar2.DockRow = 1
            Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Expand), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Collapse)})
            Me.Bar2.Text = "TreeList"
            '
            'btn_Expand
            '
            Me.btn_Expand.Caption = "Expand"
            Me.btn_Expand.Id = 18
            Me.btn_Expand.ImageOptions.ImageIndex = 9
            Me.btn_Expand.ImageOptions.LargeImageIndex = 9
            Me.btn_Expand.Name = "btn_Expand"
            '
            'btn_Collapse
            '
            Me.btn_Collapse.Caption = "Collapse"
            Me.btn_Collapse.Id = 19
            Me.btn_Collapse.ImageOptions.ImageIndex = 10
            Me.btn_Collapse.ImageOptions.LargeImageIndex = 10
            Me.btn_Collapse.Name = "btn_Collapse"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Trial Balance"
            Me.Bar4.DockCol = 0
            Me.Bar4.DockRow = 0
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Date_Type), New DevExpress.XtraBars.LinkPersistInfo(Me.toggle_Balance_Type), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Trial_Balance), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar4.Text = "Trial Balance"
            '
            'btn_COA_Ledger
            '
            Me.btn_COA_Ledger.Caption = "Ledger"
            Me.btn_COA_Ledger.Id = 20
            Me.btn_COA_Ledger.ImageOptions.ImageIndex = 11
            Me.btn_COA_Ledger.ImageOptions.LargeImageIndex = 11
            Me.btn_COA_Ledger.Name = "btn_COA_Ledger"
            '
            'BarEditItem_Date_Type
            '
            Me.BarEditItem_Date_Type.Caption = "Date Type"
            Me.BarEditItem_Date_Type.Edit = Me.RepositoryItemComboBox_Date_Type
            Me.BarEditItem_Date_Type.EditWidth = 100
            Me.BarEditItem_Date_Type.Id = 30
            Me.BarEditItem_Date_Type.Name = "BarEditItem_Date_Type"
            Me.BarEditItem_Date_Type.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'RepositoryItemComboBox_Date_Type
            '
            Me.RepositoryItemComboBox_Date_Type.AutoHeight = False
            Me.RepositoryItemComboBox_Date_Type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Date_Type.Items.AddRange(New Object() {"DAILY", "MONTHLY", "RANGE"})
            Me.RepositoryItemComboBox_Date_Type.Name = "RepositoryItemComboBox_Date_Type"
            Me.RepositoryItemComboBox_Date_Type.Sorted = True
            Me.RepositoryItemComboBox_Date_Type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'toggle_Balance_Type
            '
            Me.toggle_Balance_Type.Caption = "Summary Mode"
            Me.toggle_Balance_Type.Id = 34
            Me.toggle_Balance_Type.Name = "toggle_Balance_Type"
            '
            'btn_Trial_Balance
            '
            Me.btn_Trial_Balance.Caption = "Trial Balance"
            Me.btn_Trial_Balance.Id = 22
            Me.btn_Trial_Balance.Name = "btn_Trial_Balance"
            Me.btn_Trial_Balance.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 35
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(998, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 568)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(998, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 523)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(998, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 523)
            '
            'btn_Summary
            '
            Me.btn_Summary.Caption = "Su&mmary"
            Me.btn_Summary.Id = 9
            Me.btn_Summary.ImageOptions.ImageIndex = 7
            Me.btn_Summary.ImageOptions.LargeImageIndex = 7
            Me.btn_Summary.Name = "btn_Summary"
            '
            'btn_Lock
            '
            Me.btn_Lock.Caption = "Lock/Unlock"
            Me.btn_Lock.Id = 21
            Me.btn_Lock.Name = "btn_Lock"
            '
            'btn_Account_Code_Re_Assign
            '
            Me.btn_Account_Code_Re_Assign.Caption = "Re-Assign Account Code"
            Me.btn_Account_Code_Re_Assign.Id = 27
            Me.btn_Account_Code_Re_Assign.ImageOptions.Image = CType(resources.GetObject("btn_Account_Code_Re_Assign.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Account_Code_Re_Assign.ImageOptions.LargeImage = CType(resources.GetObject("btn_Account_Code_Re_Assign.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Account_Code_Re_Assign.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), (System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
            Me.btn_Account_Code_Re_Assign.Name = "btn_Account_Code_Re_Assign"
            '
            'btn_FS
            '
            Me.btn_FS.Caption = "Show/UnShow to FS"
            Me.btn_FS.Id = 36
            Me.btn_FS.ImageOptions.Image = CType(resources.GetObject("btn_FS.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_FS.ImageOptions.LargeImage = CType(resources.GetObject("btn_FS.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_FS.Name = "btn_FS"
            '
            'RepositoryItemtoggle_Balance_Date_Type
            '
            Me.RepositoryItemtoggle_Balance_Date_Type.AutoHeight = False
            Me.RepositoryItemtoggle_Balance_Date_Type.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Balance_Date_Type.Name = "RepositoryItemtoggle_Balance_Date_Type"
            Me.RepositoryItemtoggle_Balance_Date_Type.OffText = "Monthly"
            Me.RepositoryItemtoggle_Balance_Date_Type.OnText = "Daily"
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("040e7ade-c3f0-4952-947c-99b01f414605")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 523)
            Me.dockPanel1.Text = "Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Chart_Of_Account)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 494)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Chart_Of_Account
            '
            Me.xuc_Chart_Of_Account.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Chart_Of_Account.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Chart_Of_Account.Name = "xuc_Chart_Of_Account"
            Me.xuc_Chart_Of_Account.Size = New System.Drawing.Size(293, 494)
            Me.xuc_Chart_Of_Account.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("5e770df8-d0d4-47bb-95a1-90992549f383")
            Me.dockPanel2.Location = New System.Drawing.Point(697, 45)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(280, 523)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 494)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.TabPane1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(273, 494)
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
            Me.TabPane1.RegularSize = New System.Drawing.Size(269, 490)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(269, 490)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(269, 457)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 457)
            Me.xuc_Settings.TabIndex = 0
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(187, 418)
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.toggle_Auto_Expand)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(187, 418)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'toggle_Auto_Expand
            '
            Me.toggle_Auto_Expand.Location = New System.Drawing.Point(86, 12)
            Me.toggle_Auto_Expand.MenuManager = Me.barManager
            Me.toggle_Auto_Expand.Name = "toggle_Auto_Expand"
            Me.toggle_Auto_Expand.Properties.OffText = "Off"
            Me.toggle_Auto_Expand.Properties.OnText = "On"
            Me.toggle_Auto_Expand.Size = New System.Drawing.Size(89, 18)
            Me.toggle_Auto_Expand.StyleController = Me.layoutControl
            Me.toggle_Auto_Expand.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(187, 418)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.toggle_Auto_Expand
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(167, 22)
            Me.LayoutControlItem1.Text = "Auto Expand"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(62, 13)
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 22)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(167, 376)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA})
            Me.gridControl.Size = New System.Drawing.Size(395, 498)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCOA_Code, Me.colCorporation, Me.colCOA_Statement, Me.colCOA_Level, Me.colCOA_Type, Me.colCOA_Summary, Me.colCOA_Name, Me.colFS_Name, Me.colCOA_Desc, Me.colCOA_Normal, Me.colIsFS, Me.colIsLedger, Me.colBalance, Me.colBalance_Date, Me.colBalance_Running, Me.colBalance_Limit, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colIsLocked, Me.colLocked_By, Me.colLocked_Date})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            Me.gridView.OptionsView.ShowFooter = True
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 1
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Default"
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            '
            'colCOA_Statement
            '
            Me.colCOA_Statement.Caption = "Account Statement"
            Me.colCOA_Statement.FieldName = "COA_Statement"
            Me.colCOA_Statement.Name = "colCOA_Statement"
            Me.colCOA_Statement.Visible = True
            Me.colCOA_Statement.VisibleIndex = 3
            '
            'colCOA_Level
            '
            Me.colCOA_Level.Caption = "Level"
            Me.colCOA_Level.FieldName = "COA_Level"
            Me.colCOA_Level.Name = "colCOA_Level"
            Me.colCOA_Level.Visible = True
            Me.colCOA_Level.VisibleIndex = 4
            '
            'colCOA_Type
            '
            Me.colCOA_Type.Caption = "Type"
            Me.colCOA_Type.FieldName = "COA_Type"
            Me.colCOA_Type.Name = "colCOA_Type"
            Me.colCOA_Type.Visible = True
            Me.colCOA_Type.VisibleIndex = 5
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.Caption = "Summary"
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 6
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "Title / Name"
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 7
            '
            'colFS_Name
            '
            Me.colFS_Name.FieldName = "FS_Name"
            Me.colFS_Name.Name = "colFS_Name"
            Me.colFS_Name.Visible = True
            Me.colFS_Name.VisibleIndex = 8
            '
            'colCOA_Desc
            '
            Me.colCOA_Desc.Caption = "Description"
            Me.colCOA_Desc.FieldName = "COA_Desc"
            Me.colCOA_Desc.Name = "colCOA_Desc"
            Me.colCOA_Desc.Visible = True
            Me.colCOA_Desc.VisibleIndex = 9
            '
            'colCOA_Normal
            '
            Me.colCOA_Normal.Caption = "Normal"
            Me.colCOA_Normal.FieldName = "COA_Normal"
            Me.colCOA_Normal.Name = "colCOA_Normal"
            Me.colCOA_Normal.Visible = True
            Me.colCOA_Normal.VisibleIndex = 10
            '
            'colIsFS
            '
            Me.colIsFS.Caption = "Is FS"
            Me.colIsFS.FieldName = "IsFS"
            Me.colIsFS.Name = "colIsFS"
            Me.colIsFS.Visible = True
            Me.colIsFS.VisibleIndex = 11
            '
            'colIsLedger
            '
            Me.colIsLedger.FieldName = "IsLedger"
            Me.colIsLedger.Name = "colIsLedger"
            Me.colIsLedger.Visible = True
            Me.colIsLedger.VisibleIndex = 12
            '
            'colBalance
            '
            Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance.FieldName = "Balance"
            Me.colBalance.Name = "colBalance"
            Me.colBalance.Visible = True
            Me.colBalance.VisibleIndex = 13
            '
            'colBalance_Date
            '
            Me.colBalance_Date.FieldName = "Balance_Date"
            Me.colBalance_Date.Name = "colBalance_Date"
            Me.colBalance_Date.Visible = True
            Me.colBalance_Date.VisibleIndex = 14
            '
            'colBalance_Running
            '
            Me.colBalance_Running.Caption = "Running"
            Me.colBalance_Running.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Running.FieldName = "Balance_Running"
            Me.colBalance_Running.Name = "colBalance_Running"
            Me.colBalance_Running.Visible = True
            Me.colBalance_Running.VisibleIndex = 15
            '
            'colBalance_Limit
            '
            Me.colBalance_Limit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Limit.FieldName = "Balance_Limit"
            Me.colBalance_Limit.Name = "colBalance_Limit"
            Me.colBalance_Limit.Visible = True
            Me.colBalance_Limit.VisibleIndex = 16
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 17
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 18
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 19
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 20
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 21
            '
            'colIsLocked
            '
            Me.colIsLocked.Caption = "Locked"
            Me.colIsLocked.FieldName = "IsLocked"
            Me.colIsLocked.Name = "colIsLocked"
            Me.colIsLocked.Visible = True
            Me.colIsLocked.VisibleIndex = 22
            '
            'colLocked_By
            '
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 23
            '
            'colLocked_Date
            '
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 24
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Trial_Balance), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Expand, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Collapse), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FS, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Account_Code_Re_Assign), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Migrate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Convert_Summary), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Insert), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'treeList
            '
            Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCOA_Name1, Me.colFS_Name1, Me.colCOA_Code1, Me.colCOA_Summary1, Me.colCorporation1, Me.colCOA_Statement1, Me.colCOA_Type1, Me.colCOA_Level1, Me.colCOA_Desc1, Me.colCOA_Normal1, Me.colIsFS1, Me.colIsLedger1, Me.colBalance1, Me.colBalance_Date1, Me.colBalance_Running1, Me.colBalance_Limit1, Me.colNotes1, Me.colAdded_By1, Me.colAdded_Date1, Me.colModified_By1, Me.colModified_Date1, Me.colIsLocked1, Me.colLocked_By1, Me.colLocked_Date1, Me.colID1})
            Me.treeList.CustomizationFormBounds = New System.Drawing.Rectangle(0, 272, 250, 205)
            Me.treeList.DataSource = GetType(System.Void)
            Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList.Location = New System.Drawing.Point(0, 0)
            Me.treeList.MenuManager = Me.barManager
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsView.AutoWidth = False
            Me.treeList.Size = New System.Drawing.Size(395, 498)
            Me.treeList.TabIndex = 0
            '
            'colCOA_Name1
            '
            Me.colCOA_Name1.Caption = "Account Name"
            Me.colCOA_Name1.FieldName = "COA_Name"
            Me.colCOA_Name1.Name = "colCOA_Name1"
            Me.colCOA_Name1.Visible = True
            Me.colCOA_Name1.VisibleIndex = 0
            '
            'colFS_Name1
            '
            Me.colFS_Name1.FieldName = "FS_Name"
            Me.colFS_Name1.Name = "colFS_Name1"
            Me.colFS_Name1.Visible = True
            Me.colFS_Name1.VisibleIndex = 1
            '
            'colCOA_Code1
            '
            Me.colCOA_Code1.Caption = "Code"
            Me.colCOA_Code1.FieldName = "COA_Code"
            Me.colCOA_Code1.Name = "colCOA_Code1"
            Me.colCOA_Code1.Visible = True
            Me.colCOA_Code1.VisibleIndex = 2
            '
            'colCOA_Summary1
            '
            Me.colCOA_Summary1.Caption = "Summary"
            Me.colCOA_Summary1.FieldName = "COA_Summary"
            Me.colCOA_Summary1.Name = "colCOA_Summary1"
            Me.colCOA_Summary1.Visible = True
            Me.colCOA_Summary1.VisibleIndex = 3
            '
            'colCorporation1
            '
            Me.colCorporation1.Caption = "Default"
            Me.colCorporation1.FieldName = "Corporation"
            Me.colCorporation1.Name = "colCorporation1"
            Me.colCorporation1.Visible = True
            Me.colCorporation1.VisibleIndex = 4
            '
            'colCOA_Statement1
            '
            Me.colCOA_Statement1.Caption = "Statement"
            Me.colCOA_Statement1.FieldName = "COA_Statement"
            Me.colCOA_Statement1.Name = "colCOA_Statement1"
            Me.colCOA_Statement1.Visible = True
            Me.colCOA_Statement1.VisibleIndex = 5
            '
            'colCOA_Type1
            '
            Me.colCOA_Type1.Caption = "Type"
            Me.colCOA_Type1.FieldName = "COA_Type"
            Me.colCOA_Type1.Name = "colCOA_Type1"
            Me.colCOA_Type1.Visible = True
            Me.colCOA_Type1.VisibleIndex = 6
            '
            'colCOA_Level1
            '
            Me.colCOA_Level1.Caption = "Level"
            Me.colCOA_Level1.FieldName = "COA_Level"
            Me.colCOA_Level1.Name = "colCOA_Level1"
            Me.colCOA_Level1.Visible = True
            Me.colCOA_Level1.VisibleIndex = 7
            '
            'colCOA_Desc1
            '
            Me.colCOA_Desc1.Caption = "Description"
            Me.colCOA_Desc1.FieldName = "COA_Desc"
            Me.colCOA_Desc1.Name = "colCOA_Desc1"
            Me.colCOA_Desc1.Visible = True
            Me.colCOA_Desc1.VisibleIndex = 8
            '
            'colCOA_Normal1
            '
            Me.colCOA_Normal1.Caption = "Normal"
            Me.colCOA_Normal1.FieldName = "COA_Normal"
            Me.colCOA_Normal1.Name = "colCOA_Normal1"
            Me.colCOA_Normal1.Visible = True
            Me.colCOA_Normal1.VisibleIndex = 9
            '
            'colIsFS1
            '
            Me.colIsFS1.Caption = "Is FS"
            Me.colIsFS1.FieldName = "IsFS"
            Me.colIsFS1.Name = "colIsFS1"
            Me.colIsFS1.Visible = True
            Me.colIsFS1.VisibleIndex = 10
            '
            'colIsLedger1
            '
            Me.colIsLedger1.FieldName = "IsLedger"
            Me.colIsLedger1.Name = "colIsLedger1"
            Me.colIsLedger1.Visible = True
            Me.colIsLedger1.VisibleIndex = 11
            '
            'colBalance1
            '
            Me.colBalance1.FieldName = "Balance"
            Me.colBalance1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance1.Name = "colBalance1"
            Me.colBalance1.Visible = True
            Me.colBalance1.VisibleIndex = 12
            '
            'colBalance_Date1
            '
            Me.colBalance_Date1.FieldName = "Balance_Date"
            Me.colBalance_Date1.Name = "colBalance_Date1"
            Me.colBalance_Date1.Visible = True
            Me.colBalance_Date1.VisibleIndex = 13
            '
            'colBalance_Running1
            '
            Me.colBalance_Running1.FieldName = "Balance_Running"
            Me.colBalance_Running1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Running1.Name = "colBalance_Running1"
            Me.colBalance_Running1.Visible = True
            Me.colBalance_Running1.VisibleIndex = 14
            '
            'colBalance_Limit1
            '
            Me.colBalance_Limit1.FieldName = "Balance_Limit"
            Me.colBalance_Limit1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Limit1.Name = "colBalance_Limit1"
            Me.colBalance_Limit1.Visible = True
            Me.colBalance_Limit1.VisibleIndex = 15
            '
            'colNotes1
            '
            Me.colNotes1.Caption = "Notes"
            Me.colNotes1.FieldName = "Notes"
            Me.colNotes1.Name = "colNotes1"
            Me.colNotes1.Visible = True
            Me.colNotes1.VisibleIndex = 16
            '
            'colAdded_By1
            '
            Me.colAdded_By1.Caption = "Added By"
            Me.colAdded_By1.FieldName = "Added_By"
            Me.colAdded_By1.Name = "colAdded_By1"
            Me.colAdded_By1.Visible = True
            Me.colAdded_By1.VisibleIndex = 17
            '
            'colAdded_Date1
            '
            Me.colAdded_Date1.Caption = "Added"
            Me.colAdded_Date1.FieldName = "Added_Date"
            Me.colAdded_Date1.Format.FormatString = "MMM dd, yyyy"
            Me.colAdded_Date1.Name = "colAdded_Date1"
            Me.colAdded_Date1.Visible = True
            Me.colAdded_Date1.VisibleIndex = 18
            '
            'colModified_By1
            '
            Me.colModified_By1.Caption = "Modified By"
            Me.colModified_By1.FieldName = "Modified_By"
            Me.colModified_By1.Name = "colModified_By1"
            Me.colModified_By1.Visible = True
            Me.colModified_By1.VisibleIndex = 19
            '
            'colModified_Date1
            '
            Me.colModified_Date1.Caption = "Modified"
            Me.colModified_Date1.FieldName = "Modified_Date"
            Me.colModified_Date1.Format.FormatString = "MMM dd, yyyy"
            Me.colModified_Date1.Name = "colModified_Date1"
            Me.colModified_Date1.Visible = True
            Me.colModified_Date1.VisibleIndex = 20
            '
            'colIsLocked1
            '
            Me.colIsLocked1.Caption = "Locked"
            Me.colIsLocked1.FieldName = "IsLocked"
            Me.colIsLocked1.Name = "colIsLocked1"
            Me.colIsLocked1.Visible = True
            Me.colIsLocked1.VisibleIndex = 21
            '
            'colLocked_By1
            '
            Me.colLocked_By1.FieldName = "Locked_By"
            Me.colLocked_By1.Name = "colLocked_By1"
            Me.colLocked_By1.Visible = True
            Me.colLocked_By1.VisibleIndex = 22
            '
            'colLocked_Date1
            '
            Me.colLocked_Date1.FieldName = "Locked_Date"
            Me.colLocked_Date1.Name = "colLocked_Date1"
            Me.colLocked_Date1.Visible = True
            Me.colLocked_Date1.VisibleIndex = 23
            '
            'colID1
            '
            Me.colID1.Caption = "ID"
            Me.colID1.FieldName = "ID"
            Me.colID1.Name = "colID1"
            Me.colID1.Visible = True
            Me.colID1.VisibleIndex = 24
            '
            'XtraTabControl
            '
            Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl.Location = New System.Drawing.Point(300, 45)
            Me.XtraTabControl.Name = "XtraTabControl"
            Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
            Me.XtraTabControl.Size = New System.Drawing.Size(397, 523)
            Me.XtraTabControl.TabIndex = 14
            Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.Controls.Add(Me.treeList)
            Me.XtraTabPage1.Name = "XtraTabPage1"
            Me.XtraTabPage1.Size = New System.Drawing.Size(395, 498)
            Me.XtraTabPage1.Text = "Tree List"
            '
            'XtraTabPage2
            '
            Me.XtraTabPage2.Controls.Add(Me.gridControl)
            Me.XtraTabPage2.Name = "XtraTabPage2"
            Me.XtraTabPage2.Size = New System.Drawing.Size(395, 498)
            Me.XtraTabPage2.Text = "Grid View"
            '
            'frm_Chart_Of_Accounts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(998, 568)
            Me.Controls.Add(Me.XtraTabControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Chart_Of_Accounts"
            Me.Text = "Chart Of Accounts"
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.gridControlCOA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridViewCOA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Date_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Balance_Date_Type, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.toggle_Auto_Expand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            Me.XtraTabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Level As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Normal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Desc As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Statement As DevExpress.XtraGrid.Columns.GridColumn
        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents gridControlCOA As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridViewCOA As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colLevelNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSummaryAccount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Summary As DevExpress.XtraBars.BarButtonItem
        Private popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colCOA_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents treeList As DevExpress.XtraTreeList.TreeList
        Friend WithEvents colCOA_Statement1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Level1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Type1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Name1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Desc1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Normal1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colNotes1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colAdded_By1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colAdded_Date1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colModified_By1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colModified_Date1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCorporation1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Convert_Summary As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Another_Entry As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Chart_Of_Account As Controls.Accounting.xuc_Chart_Of_Account
        Friend WithEvents btn_Insert As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Expand As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Collapse As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_COA_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents colCOA_Code1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Summary1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLocked1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colLocked_By1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colLocked_Date1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents btn_Lock As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Trial_Balance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsLedger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLedger1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents btn_Migrate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Account_Code_Re_Assign As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents toggle_Auto_Expand As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents colID1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemtoggle_Balance_Date_Type As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents BarEditItem_Date_Type As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Date_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents colBalance1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance_Date1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Running As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Limit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Running1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance_Limit1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents toggle_Balance_Type As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsFS As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsFS1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colFS_Name1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colFS_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_FS As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
