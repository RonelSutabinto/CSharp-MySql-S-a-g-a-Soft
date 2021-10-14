Imports System.Windows.Forms

Namespace Forms.Accounting
    Partial Class frm_Trial_Balance
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Trial_Balance))
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Preview_Balance_Sheet = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview_Income_Statement = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Financial_Position = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Financial_Performance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_COA_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_COA_Balances = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Date_Type = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Date_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.toggle_Balance_Type = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Lock = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Ledger_Beginning_Balance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Trial_Balance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemtoggle_Display_Type = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.RepositoryItemtoggle_Branch_Filter = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RepositoryItemtoggle_Balance_Date_Type = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEdit_Beginning_Balance_Next_Month = New DevExpress.XtraEditors.CheckEdit()
            Me.toggle_Mode_Zero = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Check_Close_Entries = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Beginning_Balance = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Edit_Balances = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit_Reset_On_Initialize = New DevExpress.XtraEditors.CheckEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.StepProgressBar = New DevExpress.XtraEditors.StepProgressBar()
            Me.StepProgressBarItem_Initialize = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItem_Summary_Accounts = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItem_Summary_Trial_Balance = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItem_Trial_Balance_Detail = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItem_Trial_Balance_Summary = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItem_Finished = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.XtraTabPage_Import = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Balance_Import = New SagaClassLibrary.Controls.Accounting.xuc_Balance_Import()
            Me.XtraTabPage_TreeList = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Trial_Balance_Tree = New SagaClassLibrary.Controls.Accounting.xuc_Trial_Balance_Tree()
            Me.XtraTabPage_gridView = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_COA = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Level = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.colBeginning_Balance_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBeginning_Balance_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Range_Start = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Range_End2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Normal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEnding_Balance_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEnding_Balance_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Statement = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Sheet = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIncome_Statement = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.XtraTabPage_Proof_Sheet = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Account_Summary = New SagaClassLibrary.Controls.Accounting.xuc_Account_Summary()
            Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Date_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Display_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Branch_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Balance_Date_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.checkEdit_Beginning_Balance_Next_Month.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Mode_Zero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Close_Entries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Beginning_Balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Edit_Balances.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit_Reset_On_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StepProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_Import.SuspendLayout()
            Me.XtraTabPage_TreeList.SuspendLayout()
            Me.XtraTabPage_gridView.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabPage_Proof_Sheet.SuspendLayout()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl.SuspendLayout()
            Me.hideContainerRight.SuspendLayout()
            Me.SuspendLayout()
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft, Me.hideContainerRight})
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.dockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 45)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 523)
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("ef4d2b7a-cfd8-4387-a350-95260ccc46ec")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 400)
            Me.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.SavedIndex = 0
            Me.dockPanel1.Size = New System.Drawing.Size(300, 406)
            Me.dockPanel1.Text = "Information"
            Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 30)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 373)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar4, Me.Bar3})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_New, Me.btn_Initialize, Me.btn_Preview, Me.btn_Close, Me.btn_Delete, Me.btn_Stop, Me.btn_Update, Me.btn_COA_Ledger, Me.btn_Preview_Income_Statement, Me.btn_Preview_Balance_Sheet, Me.btn_COA_Balances, Me.btn_Generate, Me.btn_Lock, Me.btn_Approval, Me.btn_Approve, Me.barEditItem_Branch, Me.BarEditItem_Date_Type, Me.btn_Ledger_Beginning_Balance, Me.btn_Trial_Balance, Me.toggle_Balance_Type, Me.btn_Financial_Performance, Me.btn_Financial_Position, Me.btn_DisApprove})
            Me.barManager.MaxItemId = 50
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemtoggle_Display_Type, Me.RepositoryItemtoggle_Branch_Filter, Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemTextEdit1, Me.RepositoryItemtoggle_Balance_Date_Type, Me.RepositoryItemComboBox_Date_Type})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Commands"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(372, 153)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.bar1.Offset = 164
            Me.bar1.Text = "Commands"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "Generate"
            Me.btn_Generate.Id = 30
            Me.btn_Generate.Name = "btn_Generate"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "&Update"
            Me.btn_Update.Id = 13
            Me.btn_Update.ImageOptions.ImageIndex = 3
            Me.btn_Update.ImageOptions.LargeImageIndex = 3
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 12
            Me.btn_Stop.ImageOptions.ImageIndex = 4
            Me.btn_Stop.ImageOptions.LargeImageIndex = 4
            Me.btn_Stop.Name = "btn_Stop"
            '
            'bar2
            '
            Me.bar2.BarName = "Actions"
            Me.bar2.DockCol = 2
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar2.Offset = 348
            Me.bar2.Text = "Actions"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 0
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 0
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 5
            Me.btn_Reload.ImageOptions.LargeImageIndex = 5
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 10
            Me.btn_Delete.ImageOptions.ImageIndex = 7
            Me.btn_Delete.ImageOptions.LargeImageIndex = 7
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
            Me.btn_Preview.Id = 8
            Me.btn_Preview.ImageOptions.ImageIndex = 6
            Me.btn_Preview.ImageOptions.LargeImageIndex = 5
            Me.btn_Preview.Name = "btn_Preview"
            '
            'PopupMenu_Preview
            '
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Balance_Sheet), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Income_Statement), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Financial_Position), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Financial_Performance)})
            Me.PopupMenu_Preview.Manager = Me.barManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Preview_Balance_Sheet
            '
            Me.btn_Preview_Balance_Sheet.Caption = "Balance Sheet"
            Me.btn_Preview_Balance_Sheet.Id = 24
            Me.btn_Preview_Balance_Sheet.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Balance_Sheet.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Balance_Sheet.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Balance_Sheet.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Balance_Sheet.Name = "btn_Preview_Balance_Sheet"
            '
            'btn_Preview_Income_Statement
            '
            Me.btn_Preview_Income_Statement.Caption = "Income Statement"
            Me.btn_Preview_Income_Statement.Id = 23
            Me.btn_Preview_Income_Statement.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Income_Statement.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Income_Statement.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Income_Statement.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Income_Statement.Name = "btn_Preview_Income_Statement"
            '
            'btn_Financial_Position
            '
            Me.btn_Financial_Position.Caption = "Financial Position"
            Me.btn_Financial_Position.Id = 46
            Me.btn_Financial_Position.ImageOptions.Image = CType(resources.GetObject("btn_Financial_Position.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Financial_Position.ImageOptions.LargeImage = CType(resources.GetObject("btn_Financial_Position.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Financial_Position.Name = "btn_Financial_Position"
            '
            'btn_Financial_Performance
            '
            Me.btn_Financial_Performance.Caption = "Financial Performance"
            Me.btn_Financial_Performance.Id = 45
            Me.btn_Financial_Performance.ImageOptions.Image = CType(resources.GetObject("btn_Financial_Performance.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Financial_Performance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Financial_Performance.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Financial_Performance.Name = "btn_Financial_Performance"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 9
            Me.btn_Close.ImageOptions.ImageIndex = 8
            Me.btn_Close.ImageOptions.LargeImageIndex = 8
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Account"
            Me.Bar4.DockCol = 0
            Me.Bar4.DockRow = 0
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Balances)})
            Me.Bar4.Text = "Account"
            '
            'btn_COA_Ledger
            '
            Me.btn_COA_Ledger.Caption = "Ledger"
            Me.btn_COA_Ledger.Id = 21
            Me.btn_COA_Ledger.ImageOptions.ImageIndex = 10
            Me.btn_COA_Ledger.ImageOptions.LargeImageIndex = 10
            Me.btn_COA_Ledger.Name = "btn_COA_Ledger"
            '
            'btn_COA_Balances
            '
            Me.btn_COA_Balances.Caption = "Balances"
            Me.btn_COA_Balances.Id = 29
            Me.btn_COA_Balances.ImageOptions.Image = CType(resources.GetObject("btn_COA_Balances.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_COA_Balances.ImageOptions.LargeImage = CType(resources.GetObject("btn_COA_Balances.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_COA_Balances.Name = "btn_COA_Balances"
            Me.btn_COA_Balances.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'Bar3
            '
            Me.Bar3.BarName = "Custom 5"
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Date_Type), New DevExpress.XtraBars.LinkPersistInfo(Me.toggle_Balance_Type)})
            Me.Bar3.Text = "Custom 5"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Caption = "Branch"
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 35
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Date_Type
            '
            Me.BarEditItem_Date_Type.Caption = "Date Type"
            Me.BarEditItem_Date_Type.Edit = Me.RepositoryItemComboBox_Date_Type
            Me.BarEditItem_Date_Type.EditWidth = 100
            Me.BarEditItem_Date_Type.Id = 39
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
            Me.toggle_Balance_Type.Id = 43
            Me.toggle_Balance_Type.Name = "toggle_Balance_Type"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(898, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 568)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(898, 0)
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
            Me.barDockControlRight.Location = New System.Drawing.Point(898, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 523)
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Lock
            '
            Me.btn_Lock.Caption = "Lock"
            Me.btn_Lock.Id = 31
            Me.btn_Lock.Name = "btn_Lock"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "Approval"
            Me.btn_Approval.Id = 32
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 33
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Ledger_Beginning_Balance
            '
            Me.btn_Ledger_Beginning_Balance.Caption = "Set as Ledger Beginning Balance"
            Me.btn_Ledger_Beginning_Balance.Id = 40
            Me.btn_Ledger_Beginning_Balance.ImageOptions.Image = CType(resources.GetObject("btn_Ledger_Beginning_Balance.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Ledger_Beginning_Balance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Ledger_Beginning_Balance.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Ledger_Beginning_Balance.Name = "btn_Ledger_Beginning_Balance"
            '
            'btn_Trial_Balance
            '
            Me.btn_Trial_Balance.Caption = "Trial Balance"
            Me.btn_Trial_Balance.Id = 41
            Me.btn_Trial_Balance.ImageOptions.Image = CType(resources.GetObject("btn_Trial_Balance.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Trial_Balance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Trial_Balance.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Trial_Balance.Name = "btn_Trial_Balance"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "Disapprove"
            Me.btn_DisApprove.Id = 47
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'RepositoryItemtoggle_Display_Type
            '
            Me.RepositoryItemtoggle_Display_Type.AutoHeight = False
            Me.RepositoryItemtoggle_Display_Type.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Display_Type.Name = "RepositoryItemtoggle_Display_Type"
            Me.RepositoryItemtoggle_Display_Type.OffText = "Detail"
            Me.RepositoryItemtoggle_Display_Type.OnText = "Summary"
            '
            'RepositoryItemtoggle_Branch_Filter
            '
            Me.RepositoryItemtoggle_Branch_Filter.AutoHeight = False
            Me.RepositoryItemtoggle_Branch_Filter.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Branch_Filter.Name = "RepositoryItemtoggle_Branch_Filter"
            Me.RepositoryItemtoggle_Branch_Filter.OffText = "Branch+HO"
            Me.RepositoryItemtoggle_Branch_Filter.OnText = "Branch Only"
            '
            'RepositoryItemTextEdit1
            '
            Me.RepositoryItemTextEdit1.AutoHeight = False
            Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
            '
            'RepositoryItemtoggle_Balance_Date_Type
            '
            Me.RepositoryItemtoggle_Balance_Date_Type.AutoHeight = False
            Me.RepositoryItemtoggle_Balance_Date_Type.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Balance_Date_Type.Name = "RepositoryItemtoggle_Balance_Date_Type"
            Me.RepositoryItemtoggle_Balance_Date_Type.OffText = "Monthly"
            Me.RepositoryItemtoggle_Balance_Date_Type.OnText = "Daily"
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("376c8833-97f1-4e47-8513-2ef36021846a")
            Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.SavedIndex = 0
            Me.dockPanel2.Size = New System.Drawing.Size(280, 523)
            Me.dockPanel2.Text = "Settings"
            Me.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 494)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'TabPane1
            '
            Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
            Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
            Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabPane1.Location = New System.Drawing.Point(0, 0)
            Me.TabPane1.Name = "TabPane1"
            Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
            Me.TabPane1.RegularSize = New System.Drawing.Size(273, 494)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(273, 494)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(273, 461)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 461)
            Me.xuc_Settings.TabIndex = 0
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(273, 461)
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.checkEdit_Beginning_Balance_Next_Month)
            Me.layoutControl.Controls.Add(Me.toggle_Mode_Zero)
            Me.layoutControl.Controls.Add(Me.Check_Close_Entries)
            Me.layoutControl.Controls.Add(Me.Check_Beginning_Balance)
            Me.layoutControl.Controls.Add(Me.Check_Edit_Balances)
            Me.layoutControl.Controls.Add(Me.checkEdit_Reset_On_Initialize)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(958, 302, 650, 400)
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(273, 461)
            Me.layoutControl.TabIndex = 0
            '
            'checkEdit_Beginning_Balance_Next_Month
            '
            Me.checkEdit_Beginning_Balance_Next_Month.Location = New System.Drawing.Point(12, 130)
            Me.checkEdit_Beginning_Balance_Next_Month.MenuManager = Me.barManager
            Me.checkEdit_Beginning_Balance_Next_Month.Name = "checkEdit_Beginning_Balance_Next_Month"
            Me.checkEdit_Beginning_Balance_Next_Month.Properties.Caption = "Beginning Balance Next Month"
            Me.checkEdit_Beginning_Balance_Next_Month.Size = New System.Drawing.Size(249, 20)
            Me.checkEdit_Beginning_Balance_Next_Month.StyleController = Me.layoutControl
            Me.checkEdit_Beginning_Balance_Next_Month.TabIndex = 8
            '
            'toggle_Mode_Zero
            '
            Me.toggle_Mode_Zero.Location = New System.Drawing.Point(127, 84)
            Me.toggle_Mode_Zero.MenuManager = Me.barManager
            Me.toggle_Mode_Zero.Name = "toggle_Mode_Zero"
            Me.toggle_Mode_Zero.Properties.OffText = "Save"
            Me.toggle_Mode_Zero.Properties.OnText = "Remove"
            Me.toggle_Mode_Zero.Size = New System.Drawing.Size(134, 18)
            Me.toggle_Mode_Zero.StyleController = Me.layoutControl
            Me.toggle_Mode_Zero.TabIndex = 5
            '
            'Check_Close_Entries
            '
            Me.Check_Close_Entries.Location = New System.Drawing.Point(12, 12)
            Me.Check_Close_Entries.MenuManager = Me.barManager
            Me.Check_Close_Entries.Name = "Check_Close_Entries"
            Me.Check_Close_Entries.Properties.Caption = "Close Entries"
            Me.Check_Close_Entries.Size = New System.Drawing.Size(249, 20)
            Me.Check_Close_Entries.StyleController = Me.layoutControl
            Me.Check_Close_Entries.TabIndex = 0
            '
            'Check_Beginning_Balance
            '
            Me.Check_Beginning_Balance.Location = New System.Drawing.Point(12, 60)
            Me.Check_Beginning_Balance.MenuManager = Me.barManager
            Me.Check_Beginning_Balance.Name = "Check_Beginning_Balance"
            Me.Check_Beginning_Balance.Properties.Caption = "Beginning Balance"
            Me.Check_Beginning_Balance.Size = New System.Drawing.Size(249, 20)
            Me.Check_Beginning_Balance.StyleController = Me.layoutControl
            Me.Check_Beginning_Balance.TabIndex = 3
            '
            'Check_Edit_Balances
            '
            Me.Check_Edit_Balances.Location = New System.Drawing.Point(12, 36)
            Me.Check_Edit_Balances.MenuManager = Me.barManager
            Me.Check_Edit_Balances.Name = "Check_Edit_Balances"
            Me.Check_Edit_Balances.Properties.AutoWidth = True
            Me.Check_Edit_Balances.Properties.Caption = "Edit Balances"
            Me.Check_Edit_Balances.Size = New System.Drawing.Size(86, 20)
            Me.Check_Edit_Balances.StyleController = Me.layoutControl
            Me.Check_Edit_Balances.TabIndex = 2
            '
            'checkEdit_Reset_On_Initialize
            '
            Me.checkEdit_Reset_On_Initialize.Location = New System.Drawing.Point(12, 106)
            Me.checkEdit_Reset_On_Initialize.MenuManager = Me.barManager
            Me.checkEdit_Reset_On_Initialize.Name = "checkEdit_Reset_On_Initialize"
            Me.checkEdit_Reset_On_Initialize.Properties.Caption = "Reset Beginning Balance"
            Me.checkEdit_Reset_On_Initialize.Size = New System.Drawing.Size(249, 20)
            Me.checkEdit_Reset_On_Initialize.StyleController = Me.layoutControl
            Me.checkEdit_Reset_On_Initialize.TabIndex = 7
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem8})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(273, 461)
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 142)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(253, 299)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Check_Beginning_Balance
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(253, 24)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Check_Close_Entries
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(253, 24)
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.toggle_Mode_Zero
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(253, 22)
            Me.LayoutControlItem5.Text = "Zero(0) Update Mode"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(103, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Check_Edit_Balances
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(253, 24)
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.checkEdit_Beginning_Balance_Next_Month
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 118)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(253, 24)
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextVisible = False
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.checkEdit_Reset_On_Initialize
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 94)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(253, 24)
            Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem8.TextVisible = False
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ledger_Beginning_Balance, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Balances), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'Root
            '
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(50, 25)
            '
            'StepProgressBar
            '
            Me.StepProgressBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Initialize)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Summary_Accounts)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Summary_Trial_Balance)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Trial_Balance_Detail)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Trial_Balance_Summary)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItem_Finished)
            Me.StepProgressBar.Location = New System.Drawing.Point(21, 45)
            Me.StepProgressBar.Name = "StepProgressBar"
            Me.StepProgressBar.Size = New System.Drawing.Size(856, 90)
            Me.StepProgressBar.TabIndex = 7
            '
            'StepProgressBarItem_Initialize
            '
            Me.StepProgressBarItem_Initialize.ContentBlock2.Caption = "Initialize"
            Me.StepProgressBarItem_Initialize.ContentBlock2.Description = "Initialize Trial Balance"
            Me.StepProgressBarItem_Initialize.Name = "StepProgressBarItem_Initialize"
            Me.StepProgressBarItem_Initialize.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Initialize.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItem_Initialize.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Initialize.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItem_Summary_Accounts
            '
            Me.StepProgressBarItem_Summary_Accounts.ContentBlock2.Caption = "Summary Accounts"
            Me.StepProgressBarItem_Summary_Accounts.ContentBlock2.Description = "Generate Summary Accounts"
            Me.StepProgressBarItem_Summary_Accounts.Name = "StepProgressBarItem_Summary_Accounts"
            Me.StepProgressBarItem_Summary_Accounts.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Summary_Accounts.Options.Indicator.ActiveStateImageOptions.Im" &
        "age"), System.Drawing.Image)
            Me.StepProgressBarItem_Summary_Accounts.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Summary_Accounts.Options.Indicator.InactiveStateImageOptions." &
        "Image"), System.Drawing.Image)
            '
            'StepProgressBarItem_Summary_Trial_Balance
            '
            Me.StepProgressBarItem_Summary_Trial_Balance.ContentBlock2.Caption = "Update Trial Balance"
            Me.StepProgressBarItem_Summary_Trial_Balance.ContentBlock2.Description = "Update Summary to Trial Balance"
            Me.StepProgressBarItem_Summary_Trial_Balance.Name = "StepProgressBarItem_Summary_Trial_Balance"
            Me.StepProgressBarItem_Summary_Trial_Balance.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Summary_Trial_Balance.Options.Indicator.ActiveStateImageOptio" &
        "ns.Image"), System.Drawing.Image)
            Me.StepProgressBarItem_Summary_Trial_Balance.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Summary_Trial_Balance.Options.Indicator.InactiveStateImageOpt" &
        "ions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItem_Trial_Balance_Detail
            '
            Me.StepProgressBarItem_Trial_Balance_Detail.ContentBlock2.Caption = "Generate Detail"
            Me.StepProgressBarItem_Trial_Balance_Detail.ContentBlock2.Description = "Generate Trial Balance (Detail)"
            Me.StepProgressBarItem_Trial_Balance_Detail.Name = "StepProgressBarItem_Trial_Balance_Detail"
            Me.StepProgressBarItem_Trial_Balance_Detail.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Trial_Balance_Detail.Options.Indicator.ActiveStateImageOption" &
        "s.Image"), System.Drawing.Image)
            Me.StepProgressBarItem_Trial_Balance_Detail.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Trial_Balance_Detail.Options.Indicator.InactiveStateImageOpti" &
        "ons.Image"), System.Drawing.Image)
            '
            'StepProgressBarItem_Trial_Balance_Summary
            '
            Me.StepProgressBarItem_Trial_Balance_Summary.ContentBlock2.Caption = "Generate Summary"
            Me.StepProgressBarItem_Trial_Balance_Summary.ContentBlock2.Description = "Generate Trial Balance (Summary)"
            Me.StepProgressBarItem_Trial_Balance_Summary.Name = "StepProgressBarItem_Trial_Balance_Summary"
            Me.StepProgressBarItem_Trial_Balance_Summary.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Trial_Balance_Summary.Options.Indicator.ActiveStateImageOptio" &
        "ns.Image"), System.Drawing.Image)
            Me.StepProgressBarItem_Trial_Balance_Summary.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Trial_Balance_Summary.Options.Indicator.InactiveStateImageOpt" &
        "ions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItem_Finished
            '
            Me.StepProgressBarItem_Finished.ContentBlock2.Caption = "Finished"
            Me.StepProgressBarItem_Finished.ContentBlock2.Description = "Trial Balance Generated"
            Me.StepProgressBarItem_Finished.Name = "StepProgressBarItem_Finished"
            Me.StepProgressBarItem_Finished.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Finished.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItem_Finished.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItem_Finished.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'XtraTabPage_Import
            '
            Me.XtraTabPage_Import.Controls.Add(Me.xuc_Balance_Import)
            Me.XtraTabPage_Import.Name = "XtraTabPage_Import"
            Me.XtraTabPage_Import.Size = New System.Drawing.Size(595, 408)
            Me.XtraTabPage_Import.Text = "Import"
            '
            'xuc_Balance_Import
            '
            Me.xuc_Balance_Import.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Balance_Import.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Balance_Import.Name = "xuc_Balance_Import"
            Me.xuc_Balance_Import.Size = New System.Drawing.Size(595, 408)
            Me.xuc_Balance_Import.TabIndex = 0
            '
            'XtraTabPage_TreeList
            '
            Me.XtraTabPage_TreeList.Controls.Add(Me.xuc_Trial_Balance_Tree)
            Me.XtraTabPage_TreeList.Name = "XtraTabPage_TreeList"
            Me.XtraTabPage_TreeList.Size = New System.Drawing.Size(595, 408)
            Me.XtraTabPage_TreeList.Text = "Tree List"
            '
            'xuc_Trial_Balance_Tree
            '
            Me.xuc_Trial_Balance_Tree.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Trial_Balance_Tree.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Trial_Balance_Tree.Name = "xuc_Trial_Balance_Tree"
            Me.xuc_Trial_Balance_Tree.Size = New System.Drawing.Size(595, 408)
            Me.xuc_Trial_Balance_Tree.TabIndex = 0
            '
            'XtraTabPage_gridView
            '
            Me.XtraTabPage_gridView.Controls.Add(Me.gridControl)
            Me.XtraTabPage_gridView.Name = "XtraTabPage_gridView"
            Me.XtraTabPage_gridView.Size = New System.Drawing.Size(595, 408)
            Me.XtraTabPage_gridView.Text = "Trial Balance"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.barManager
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit, Me.RepositoryItemLookUpEdit_COA})
            Me.gridControl.Size = New System.Drawing.Size(595, 408)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.GridView1})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_COA, Me.colID, Me.colBranch_Code, Me.colCOA_Summary, Me.colCOA_Code, Me.colCOA_Name, Me.colCOA_Level, Me.colCOA_Type, Me.colDate_Type, Me.colBalance_Date, Me.colBeginning_Balance_Debit, Me.colBeginning_Balance_Credit, Me.colDate_Range_Start, Me.colTotal_Debit, Me.colTotal_Credit, Me.colDate_Range_End2, Me.colCOA_Normal, Me.colEnding_Balance_Debit, Me.colEnding_Balance_Credit, Me.colCOA_Statement, Me.colBalance_Sheet, Me.colIncome_Statement, Me.colBalance_Status, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colIsLocked, Me.colLocked_By, Me.colLocked_Date})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID_COA
            '
            Me.colID_COA.Caption = "ID COA"
            Me.colID_COA.FieldName = "ID_COA"
            Me.colID_COA.Name = "colID_COA"
            Me.colID_COA.Visible = True
            Me.colID_COA.VisibleIndex = 0
            '
            'colID
            '
            Me.colID.Caption = "ID Balance"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 1
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 2
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.Caption = "Summary"
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 3
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 4
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "Account"
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.OptionsColumn.AllowEdit = False
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 5
            '
            'colCOA_Level
            '
            Me.colCOA_Level.Caption = "Level"
            Me.colCOA_Level.FieldName = "COA_Level"
            Me.colCOA_Level.Name = "colCOA_Level"
            Me.colCOA_Level.Visible = True
            Me.colCOA_Level.VisibleIndex = 6
            '
            'colCOA_Type
            '
            Me.colCOA_Type.Caption = "Type"
            Me.colCOA_Type.FieldName = "COA_Type"
            Me.colCOA_Type.Name = "colCOA_Type"
            Me.colCOA_Type.Visible = True
            Me.colCOA_Type.VisibleIndex = 7
            '
            'colDate_Type
            '
            Me.colDate_Type.FieldName = "Date_Type"
            Me.colDate_Type.Name = "colDate_Type"
            Me.colDate_Type.Visible = True
            Me.colDate_Type.VisibleIndex = 8
            '
            'colBalance_Date
            '
            Me.colBalance_Date.Caption = "Date Start"
            Me.colBalance_Date.ColumnEdit = Me.RepositoryItemDateEdit
            Me.colBalance_Date.FieldName = "Balance_Date"
            Me.colBalance_Date.Name = "colBalance_Date"
            Me.colBalance_Date.Visible = True
            Me.colBalance_Date.VisibleIndex = 9
            '
            'RepositoryItemDateEdit
            '
            Me.RepositoryItemDateEdit.AutoHeight = False
            Me.RepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit.Name = "RepositoryItemDateEdit"
            '
            'colBeginning_Balance_Debit
            '
            Me.colBeginning_Balance_Debit.Caption = "Beginning Debit"
            Me.colBeginning_Balance_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginning_Balance_Debit.FieldName = "Beginning_Balance_Debit"
            Me.colBeginning_Balance_Debit.Name = "colBeginning_Balance_Debit"
            Me.colBeginning_Balance_Debit.Visible = True
            Me.colBeginning_Balance_Debit.VisibleIndex = 10
            '
            'colBeginning_Balance_Credit
            '
            Me.colBeginning_Balance_Credit.Caption = "Beginning Credit"
            Me.colBeginning_Balance_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginning_Balance_Credit.FieldName = "Beginning_Balance_Credit"
            Me.colBeginning_Balance_Credit.Name = "colBeginning_Balance_Credit"
            Me.colBeginning_Balance_Credit.Visible = True
            Me.colBeginning_Balance_Credit.VisibleIndex = 11
            '
            'colDate_Range_Start
            '
            Me.colDate_Range_Start.Caption = "Date_Range_Start"
            Me.colDate_Range_Start.FieldName = "Date_Range_Start"
            Me.colDate_Range_Start.Name = "colDate_Range_Start"
            Me.colDate_Range_Start.Visible = True
            Me.colDate_Range_Start.VisibleIndex = 12
            '
            'colTotal_Debit
            '
            Me.colTotal_Debit.Caption = "Total Debit"
            Me.colTotal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Debit.FieldName = "Total_Debit"
            Me.colTotal_Debit.Name = "colTotal_Debit"
            Me.colTotal_Debit.Visible = True
            Me.colTotal_Debit.VisibleIndex = 13
            '
            'colTotal_Credit
            '
            Me.colTotal_Credit.Caption = "Total Credit"
            Me.colTotal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Credit.FieldName = "Total_Credit"
            Me.colTotal_Credit.Name = "colTotal_Credit"
            Me.colTotal_Credit.Visible = True
            Me.colTotal_Credit.VisibleIndex = 14
            '
            'colDate_Range_End2
            '
            Me.colDate_Range_End2.FieldName = "Date_Range_End"
            Me.colDate_Range_End2.Name = "colDate_Range_End2"
            Me.colDate_Range_End2.Visible = True
            Me.colDate_Range_End2.VisibleIndex = 15
            '
            'colCOA_Normal
            '
            Me.colCOA_Normal.Caption = "Normal Balance"
            Me.colCOA_Normal.FieldName = "COA_Normal"
            Me.colCOA_Normal.Name = "colCOA_Normal"
            Me.colCOA_Normal.Visible = True
            Me.colCOA_Normal.VisibleIndex = 16
            '
            'colEnding_Balance_Debit
            '
            Me.colEnding_Balance_Debit.Caption = "Ending Debit"
            Me.colEnding_Balance_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEnding_Balance_Debit.FieldName = "Ending_Balance_Debit"
            Me.colEnding_Balance_Debit.Name = "colEnding_Balance_Debit"
            Me.colEnding_Balance_Debit.Visible = True
            Me.colEnding_Balance_Debit.VisibleIndex = 17
            '
            'colEnding_Balance_Credit
            '
            Me.colEnding_Balance_Credit.Caption = "Ending Credit"
            Me.colEnding_Balance_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEnding_Balance_Credit.FieldName = "Ending_Balance_Credit"
            Me.colEnding_Balance_Credit.Name = "colEnding_Balance_Credit"
            Me.colEnding_Balance_Credit.Visible = True
            Me.colEnding_Balance_Credit.VisibleIndex = 18
            '
            'colCOA_Statement
            '
            Me.colCOA_Statement.Caption = "Statement"
            Me.colCOA_Statement.FieldName = "COA_Statement"
            Me.colCOA_Statement.Name = "colCOA_Statement"
            Me.colCOA_Statement.Visible = True
            Me.colCOA_Statement.VisibleIndex = 19
            '
            'colBalance_Sheet
            '
            Me.colBalance_Sheet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Sheet.FieldName = "Balance_Sheet"
            Me.colBalance_Sheet.Name = "colBalance_Sheet"
            Me.colBalance_Sheet.Visible = True
            Me.colBalance_Sheet.VisibleIndex = 20
            '
            'colIncome_Statement
            '
            Me.colIncome_Statement.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIncome_Statement.FieldName = "Income_Statement"
            Me.colIncome_Statement.Name = "colIncome_Statement"
            Me.colIncome_Statement.Visible = True
            Me.colIncome_Statement.VisibleIndex = 21
            '
            'colBalance_Status
            '
            Me.colBalance_Status.Caption = "Status"
            Me.colBalance_Status.FieldName = "Balance_Status"
            Me.colBalance_Status.Name = "colBalance_Status"
            Me.colBalance_Status.Visible = True
            Me.colBalance_Status.VisibleIndex = 22
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 23
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 24
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 25
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 26
            '
            'colModified_Date
            '
            Me.colModified_Date.Caption = "Date Modified"
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 27
            '
            'colApproved_By
            '
            Me.colApproved_By.Caption = "Approved By"
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 28
            '
            'colApproved_Date
            '
            Me.colApproved_Date.Caption = "Approved Date"
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 29
            '
            'colIsLocked
            '
            Me.colIsLocked.FieldName = "IsLocked"
            Me.colIsLocked.Name = "colIsLocked"
            Me.colIsLocked.Visible = True
            Me.colIsLocked.VisibleIndex = 30
            '
            'colLocked_By
            '
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 31
            '
            'colLocked_Date
            '
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 32
            '
            'GridView1
            '
            Me.GridView1.GridControl = Me.gridControl
            Me.GridView1.Name = "GridView1"
            '
            'XtraTabPage_Proof_Sheet
            '
            Me.XtraTabPage_Proof_Sheet.Controls.Add(Me.xuc_Account_Summary)
            Me.XtraTabPage_Proof_Sheet.Name = "XtraTabPage_Proof_Sheet"
            Me.XtraTabPage_Proof_Sheet.Size = New System.Drawing.Size(854, 408)
            Me.XtraTabPage_Proof_Sheet.Text = "Proof Sheet"
            '
            'xuc_Account_Summary
            '
            Me.xuc_Account_Summary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Summary.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Summary.Name = "xuc_Account_Summary"
            Me.xuc_Account_Summary.Size = New System.Drawing.Size(854, 408)
            Me.xuc_Account_Summary.TabIndex = 0
            '
            'XtraTabControl
            '
            Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl.Location = New System.Drawing.Point(21, 135)
            Me.XtraTabControl.Name = "XtraTabControl"
            Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage_Proof_Sheet
            Me.XtraTabControl.Size = New System.Drawing.Size(856, 433)
            Me.XtraTabControl.TabIndex = 0
            Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_Proof_Sheet, Me.XtraTabPage_gridView, Me.XtraTabPage_TreeList, Me.XtraTabPage_Import})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.dockPanel2)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(877, 45)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 523)
            '
            'frm_Trial_Balance
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 568)
            Me.Controls.Add(Me.XtraTabControl)
            Me.Controls.Add(Me.StepProgressBar)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Trial_Balance"
            Me.Text = "frm_Trial_Balance"
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Date_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Display_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Branch_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Balance_Date_Type, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.checkEdit_Beginning_Balance_Next_Month.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Mode_Zero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Close_Entries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Beginning_Balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Edit_Balances.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit_Reset_On_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StepProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_Import.ResumeLayout(False)
            Me.XtraTabPage_TreeList.ResumeLayout(False)
            Me.XtraTabPage_gridView.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabPage_Proof_Sheet.ResumeLayout(False)
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl.ResumeLayout(False)
            Me.hideContainerRight.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_COA_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Check_Edit_Balances As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Check_Beginning_Balance As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents btn_Preview_Income_Statement As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Preview_Balance_Sheet As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemtoggle_Display_Type As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents btn_COA_Balances As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Check_Close_Entries As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents toggle_Mode_Zero As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents checkEdit_Beginning_Balance_Next_Month As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Lock As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemtoggle_Branch_Filter As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemtoggle_Balance_Date_Type As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents BarEditItem_Date_Type As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Date_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents checkEdit_Reset_On_Initialize As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Ledger_Beginning_Balance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Trial_Balance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents toggle_Balance_Type As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents colDate_Range_End As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Financial_Performance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Financial_Position As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents StepProgressBar As DevExpress.XtraEditors.StepProgressBar
        Friend WithEvents StepProgressBarItem_Summary_Accounts As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItem_Summary_Trial_Balance As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_Proof_Sheet As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents xuc_Account_Summary As Controls.Accounting.xuc_Account_Summary
        Friend WithEvents XtraTabPage_gridView As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID_COA As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Level As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents colBeginning_Balance_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBeginning_Balance_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Range_Start As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Range_End2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Normal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEnding_Balance_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEnding_Balance_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Statement As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Sheet As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIncome_Statement As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents XtraTabPage_TreeList As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents xuc_Trial_Balance_Tree As Controls.Accounting.xuc_Trial_Balance_Tree
        Friend WithEvents XtraTabPage_Import As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents xuc_Balance_Import As Controls.Accounting.xuc_Balance_Import
        Friend WithEvents StepProgressBarItem_Trial_Balance_Detail As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItem_Trial_Balance_Summary As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItem_Finished As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents StepProgressBarItem_Initialize As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    End Class
End Namespace
