Namespace Forms.Accounting
    Partial Class frm_Journal_Entries
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Journal_Entries))
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
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
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Branch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Liquidations = New DevExpress.XtraBars.BarButtonItem()
            Me.BarEditItem_Type = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.btn_Load_Type = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unverified = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Error = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Deleted = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.Toggle_Branch_HO = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.btn_Proof_Sheet = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar_Options = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar6 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Filter = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Filter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.btn_Filter_Load = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Filter_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Filter_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unverify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar5 = New DevExpress.XtraBars.Bar()
            Me.btn_Custom1 = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Dashboard = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Trial_Balance = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Lock = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries2 = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.repositoryItemComboBox_Account_Code = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.repositoryItemLookUpEdit_Accounts = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.RepositoryItemLookUpEdit_Profiles = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.RepositoryItemButtonEdit_Journal_Voucher = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.RepositoryItemtoggle_Any_Date = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.RepositoryItemtoggle_Search_Mode = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.RepositoryItemtoggle_Branch_Filter = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Journal_Entry = New SagaClassLibrary.Controls.Accounting.xuc_Journal_Entry()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.RadioGroup_Verification_Mode = New DevExpress.XtraEditors.RadioGroup()
            Me.RadioGroup_Mode = New DevExpress.XtraEditors.RadioGroup()
            Me.check_Group_Entry = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTable_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Profile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLiquidated = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJustification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransacted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVerified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVerified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Account_Summary = New SagaClassLibrary.Controls.Accounting.xuc_Account_Summary()
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Grid_Journal_References = New SagaClassLibrary.Controls.Accounting.xuc_Grid_Journal_References()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Profiles, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemButtonEdit_Journal_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Any_Date, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Search_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemtoggle_Branch_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.RadioGroup_Verification_Mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioGroup_Mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Group_Entry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            Me.XtraTabPage3.SuspendLayout()
            Me.XtraTabPage2.SuspendLayout()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar_Options, Me.Bar6, Me.Bar3, Me.Bar5})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Close, Me.btn_New, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Delete, Me.barEditItem_Branch, Me.BarEditItem_Search, Me.btn_Validate, Me.btn_Journal_Entries, Me.btn_Custom1, Me.BarEditItem_Filter, Me.btn_Filter_Load, Me.btn_Filter_Save, Me.btn_Filter_Delete, Me.btn_Approval, Me.btn_Stop, Me.btn_Approve, Me.btn_Verify, Me.btn_Trial_Balance, Me.btn_Batch_Transactions, Me.btn_Lock, Me.btn_Journal_Entries2, Me.btn_Unverify, Me.btn_Dashboard, Me.btn_Liquidations, Me.btn_Branch_Transactions, Me.btn_Proof_Sheet, Me.btn_Deleted, Me.BarEditItem_Type, Me.btn_Load_Type, Me.btn_Error, Me.btn_Ledger, Me.btn_Unverified, Me.BarButtonItem1, Me.Toggle_Branch_HO, Me.btn_Reload})
            Me.barManager.MaxItemId = 65
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox_Account_Code, Me.repositoryItemLookUpEdit_Branch, Me.repositoryItemLookUpEdit_Accounts, Me.RepositoryItemLookUpEdit_Profiles, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemComboBox_Filter, Me.RepositoryItemButtonEdit_Journal_Voucher, Me.RepositoryItemtoggle_Any_Date, Me.RepositoryItemtoggle_Search_Mode, Me.RepositoryItemtoggle_Branch_Filter, Me.RepositoryItemComboBox_Type})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Actions"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 171
            Me.bar1.Text = "Actions"
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
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
            Me.btn_Reload.Id = 64
            Me.btn_Reload.Name = "btn_Reload"
            '
            'PopupMenu_Reload
            '
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Branch_Transactions), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Liquidations), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Type, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_Type), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unverified, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Error), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Deleted)})
            Me.PopupMenu_Reload.Manager = Me.barManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Branch_Transactions
            '
            Me.btn_Branch_Transactions.Caption = "Branch Transactions"
            Me.btn_Branch_Transactions.Id = 53
            Me.btn_Branch_Transactions.ImageOptions.Image = CType(resources.GetObject("btn_Branch_Transactions.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Branch_Transactions.ImageOptions.LargeImage = CType(resources.GetObject("btn_Branch_Transactions.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Branch_Transactions.Name = "btn_Branch_Transactions"
            '
            'btn_Liquidations
            '
            Me.btn_Liquidations.Caption = "Liquidations"
            Me.btn_Liquidations.Id = 52
            Me.btn_Liquidations.ImageOptions.Image = CType(resources.GetObject("btn_Liquidations.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Liquidations.ImageOptions.LargeImage = CType(resources.GetObject("btn_Liquidations.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Liquidations.Name = "btn_Liquidations"
            '
            'BarEditItem_Type
            '
            Me.BarEditItem_Type.Caption = "Type"
            Me.BarEditItem_Type.Edit = Me.RepositoryItemComboBox_Type
            Me.BarEditItem_Type.Id = 56
            Me.BarEditItem_Type.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Type.ImageOptions.Image"), System.Drawing.Image)
            Me.BarEditItem_Type.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Type.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.BarEditItem_Type.Name = "BarEditItem_Type"
            '
            'RepositoryItemComboBox_Type
            '
            Me.RepositoryItemComboBox_Type.AutoHeight = False
            Me.RepositoryItemComboBox_Type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Type.Name = "RepositoryItemComboBox_Type"
            Me.RepositoryItemComboBox_Type.Sorted = True
            Me.RepositoryItemComboBox_Type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'btn_Load_Type
            '
            Me.btn_Load_Type.Caption = "Load Type"
            Me.btn_Load_Type.Id = 57
            Me.btn_Load_Type.ImageOptions.Image = CType(resources.GetObject("btn_Load_Type.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_Type.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_Type.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_Type.Name = "btn_Load_Type"
            '
            'btn_Unverified
            '
            Me.btn_Unverified.Caption = "Unverified"
            Me.btn_Unverified.Id = 60
            Me.btn_Unverified.ImageOptions.Image = CType(resources.GetObject("btn_Unverified.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unverified.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unverified.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unverified.Name = "btn_Unverified"
            '
            'btn_Error
            '
            Me.btn_Error.Caption = "Error"
            Me.btn_Error.Id = 58
            Me.btn_Error.ImageOptions.Image = CType(resources.GetObject("btn_Error.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Error.ImageOptions.LargeImage = CType(resources.GetObject("btn_Error.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Error.Name = "btn_Error"
            '
            'btn_Deleted
            '
            Me.btn_Deleted.Caption = "Deleted"
            Me.btn_Deleted.Id = 55
            Me.btn_Deleted.ImageOptions.Image = CType(resources.GetObject("btn_Deleted.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Deleted.ImageOptions.LargeImage = CType(resources.GetObject("btn_Deleted.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Deleted.Name = "btn_Deleted"
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
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
            Me.btn_Preview.Id = 8
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'PopupMenu_Preview
            '
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Toggle_Branch_HO), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Proof_Sheet)})
            Me.PopupMenu_Preview.Manager = Me.barManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'Toggle_Branch_HO
            '
            Me.Toggle_Branch_HO.Caption = "Branch + HO"
            Me.Toggle_Branch_HO.Id = 63
            Me.Toggle_Branch_HO.ImageOptions.Image = CType(resources.GetObject("Toggle_Branch_HO.ImageOptions.Image"), System.Drawing.Image)
            Me.Toggle_Branch_HO.ImageOptions.LargeImage = CType(resources.GetObject("Toggle_Branch_HO.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.Toggle_Branch_HO.Name = "Toggle_Branch_HO"
            '
            'btn_Proof_Sheet
            '
            Me.btn_Proof_Sheet.Caption = "Proof Sheet"
            Me.btn_Proof_Sheet.Id = 54
            Me.btn_Proof_Sheet.ImageOptions.Image = CType(resources.GetObject("btn_Proof_Sheet.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Proof_Sheet.ImageOptions.LargeImage = CType(resources.GetObject("btn_Proof_Sheet.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Proof_Sheet.Name = "btn_Proof_Sheet"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 9
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
            'bar_Options
            '
            Me.bar_Options.BarName = "Options"
            Me.bar_Options.DockCol = 0
            Me.bar_Options.DockRow = 0
            Me.bar_Options.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar_Options.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search, True)})
            Me.bar_Options.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 12
            Me.barEditItem_Branch.ImageOptions.ImageIndex = 9
            Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 9
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
            Me.BarEditItem_Search.Id = 15
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 11
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 11
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar6
            '
            Me.Bar6.BarName = "Filter"
            Me.Bar6.DockCol = 0
            Me.Bar6.DockRow = 1
            Me.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar6.FloatLocation = New System.Drawing.Point(69, 158)
            Me.Bar6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Filter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Load), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Delete)})
            Me.Bar6.Text = "Filter"
            '
            'BarEditItem_Filter
            '
            Me.BarEditItem_Filter.Caption = "Filter"
            Me.BarEditItem_Filter.Edit = Me.RepositoryItemComboBox_Filter
            Me.BarEditItem_Filter.Id = 19
            Me.BarEditItem_Filter.ImageOptions.ImageIndex = 13
            Me.BarEditItem_Filter.ImageOptions.LargeImageIndex = 13
            Me.BarEditItem_Filter.Name = "BarEditItem_Filter"
            '
            'RepositoryItemComboBox_Filter
            '
            Me.RepositoryItemComboBox_Filter.AutoHeight = False
            Me.RepositoryItemComboBox_Filter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Filter.Name = "RepositoryItemComboBox_Filter"
            '
            'btn_Filter_Load
            '
            Me.btn_Filter_Load.Caption = "&Load"
            Me.btn_Filter_Load.Id = 20
            Me.btn_Filter_Load.ImageOptions.ImageIndex = 14
            Me.btn_Filter_Load.ImageOptions.LargeImageIndex = 14
            Me.btn_Filter_Load.Name = "btn_Filter_Load"
            '
            'btn_Filter_Save
            '
            Me.btn_Filter_Save.Caption = "&Save"
            Me.btn_Filter_Save.Id = 21
            Me.btn_Filter_Save.ImageOptions.ImageIndex = 15
            Me.btn_Filter_Save.ImageOptions.LargeImageIndex = 15
            Me.btn_Filter_Save.Name = "btn_Filter_Save"
            '
            'btn_Filter_Delete
            '
            Me.btn_Filter_Delete.Caption = "&Remove"
            Me.btn_Filter_Delete.Id = 22
            Me.btn_Filter_Delete.ImageOptions.ImageIndex = 16
            Me.btn_Filter_Delete.ImageOptions.LargeImageIndex = 16
            Me.btn_Filter_Delete.Name = "btn_Filter_Delete"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Status"
            Me.Bar3.DockCol = 2
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.FloatLocation = New System.Drawing.Point(90, 234)
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unverify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar3.Offset = 114
            Me.Bar3.Text = "Status"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 17
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 10
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 10
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Vali&dation"
            Me.btn_Validate.Id = 16
            Me.btn_Validate.ImageOptions.ImageIndex = 7
            Me.btn_Validate.ImageOptions.LargeImageIndex = 7
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 36
            Me.btn_Verify.ImageOptions.ImageIndex = 27
            Me.btn_Verify.ImageOptions.LargeImageIndex = 27
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Unverify
            '
            Me.btn_Unverify.Caption = "Unverify"
            Me.btn_Unverify.Id = 46
            Me.btn_Unverify.ImageOptions.Image = CType(resources.GetObject("btn_Unverify.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unverify.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unverify.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unverify.Name = "btn_Unverify"
            Me.btn_Unverify.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "For Appr&oval"
            Me.btn_Approval.Id = 23
            Me.btn_Approval.ImageOptions.ImageIndex = 17
            Me.btn_Approval.ImageOptions.LargeImageIndex = 17
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "&Approve"
            Me.btn_Approve.Id = 25
            Me.btn_Approve.ImageOptions.ImageIndex = 18
            Me.btn_Approve.ImageOptions.LargeImageIndex = 18
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "S&top"
            Me.btn_Stop.Id = 24
            Me.btn_Stop.ImageOptions.ImageIndex = 19
            Me.btn_Stop.ImageOptions.LargeImageIndex = 19
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar5
            '
            Me.Bar5.BarName = "Custom"
            Me.Bar5.DockCol = 1
            Me.Bar5.DockRow = 1
            Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Custom1), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Dashboard)})
            Me.Bar5.Text = "Custom"
            '
            'btn_Custom1
            '
            Me.btn_Custom1.Caption = "Custom&1"
            Me.btn_Custom1.Id = 18
            Me.btn_Custom1.ImageOptions.ImageIndex = 12
            Me.btn_Custom1.ImageOptions.LargeImageIndex = 12
            Me.btn_Custom1.Name = "btn_Custom1"
            '
            'btn_Dashboard
            '
            Me.btn_Dashboard.Caption = "Dashboard"
            Me.btn_Dashboard.Id = 47
            Me.btn_Dashboard.Name = "btn_Dashboard"
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
            'btn_Trial_Balance
            '
            Me.btn_Trial_Balance.Caption = "Update Trial Balance"
            Me.btn_Trial_Balance.Id = 37
            Me.btn_Trial_Balance.Name = "btn_Trial_Balance"
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Batch Transactions"
            Me.btn_Batch_Transactions.Id = 38
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'btn_Lock
            '
            Me.btn_Lock.Caption = "Lock"
            Me.btn_Lock.Id = 44
            Me.btn_Lock.Name = "btn_Lock"
            '
            'btn_Journal_Entries2
            '
            Me.btn_Journal_Entries2.Caption = "Journal Entries 2"
            Me.btn_Journal_Entries2.Id = 45
            Me.btn_Journal_Entries2.Name = "btn_Journal_Entries2"
            '
            'btn_Ledger
            '
            Me.btn_Ledger.Caption = "Ledger"
            Me.btn_Ledger.Id = 59
            Me.btn_Ledger.Name = "btn_Ledger"
            '
            'BarButtonItem1
            '
            Me.BarButtonItem1.Caption = "BarButtonItem1"
            Me.BarButtonItem1.Id = 62
            Me.BarButtonItem1.Name = "BarButtonItem1"
            '
            'repositoryItemComboBox_Account_Code
            '
            Me.repositoryItemComboBox_Account_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox_Account_Code.Name = "repositoryItemComboBox_Account_Code"
            Me.repositoryItemComboBox_Account_Code.Sorted = True
            '
            'repositoryItemLookUpEdit_Accounts
            '
            Me.repositoryItemLookUpEdit_Accounts.AutoHeight = False
            Me.repositoryItemLookUpEdit_Accounts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Accounts.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Reference", "Reference"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Name")})
            Me.repositoryItemLookUpEdit_Accounts.DisplayMember = "Account_Name"
            Me.repositoryItemLookUpEdit_Accounts.DropDownRows = 20
            Me.repositoryItemLookUpEdit_Accounts.Name = "repositoryItemLookUpEdit_Accounts"
            Me.repositoryItemLookUpEdit_Accounts.NullText = "SELECT Account..."
            Me.repositoryItemLookUpEdit_Accounts.ValueMember = "Account_Code"
            '
            'RepositoryItemLookUpEdit_Profiles
            '
            Me.RepositoryItemLookUpEdit_Profiles.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
            Me.RepositoryItemLookUpEdit_Profiles.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Profiles.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Code", "COA Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COA_Name", "COA Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Type", "Journal Type"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Name", "Profile Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Description", "Profile Description"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Balance_Type", "Normal"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes", "Notes")})
            Me.RepositoryItemLookUpEdit_Profiles.DisplayMember = "Profile_Name"
            Me.RepositoryItemLookUpEdit_Profiles.DropDownRows = 20
            Me.RepositoryItemLookUpEdit_Profiles.Name = "RepositoryItemLookUpEdit_Profiles"
            Me.RepositoryItemLookUpEdit_Profiles.NullText = "SELECT Profile..."
            Me.RepositoryItemLookUpEdit_Profiles.ValueMember = "Profile_Name"
            '
            'RepositoryItemButtonEdit_Journal_Voucher
            '
            Me.RepositoryItemButtonEdit_Journal_Voucher.AutoHeight = False
            EditorButtonImageOptions1.ImageIndex = 0
            EditorButtonImageOptions2.ImageIndex = 18
            Me.RepositoryItemButtonEdit_Journal_Voucher.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Generate Journal Voucher", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Set Journal Voucher", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.RepositoryItemButtonEdit_Journal_Voucher.Name = "RepositoryItemButtonEdit_Journal_Voucher"
            '
            'RepositoryItemtoggle_Any_Date
            '
            Me.RepositoryItemtoggle_Any_Date.AutoHeight = False
            Me.RepositoryItemtoggle_Any_Date.Name = "RepositoryItemtoggle_Any_Date"
            Me.RepositoryItemtoggle_Any_Date.OffText = "Off"
            Me.RepositoryItemtoggle_Any_Date.OnText = "On"
            '
            'RepositoryItemtoggle_Search_Mode
            '
            Me.RepositoryItemtoggle_Search_Mode.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Search_Mode.Name = "RepositoryItemtoggle_Search_Mode"
            Me.RepositoryItemtoggle_Search_Mode.OffText = "Date Range"
            Me.RepositoryItemtoggle_Search_Mode.OnText = "Global"
            '
            'RepositoryItemtoggle_Branch_Filter
            '
            Me.RepositoryItemtoggle_Branch_Filter.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.RepositoryItemtoggle_Branch_Filter.Name = "RepositoryItemtoggle_Branch_Filter"
            Me.RepositoryItemtoggle_Branch_Filter.OffText = "HO + Branch"
            Me.RepositoryItemtoggle_Branch_Filter.OnText = "Branch Only"
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("5136605d-b61b-46c6-b243-61cce44a3e1a")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(500, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(500, 523)
            Me.dockPanel1.Text = "Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Journal_Entry)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(493, 494)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Journal_Entry
            '
            Me.xuc_Journal_Entry.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Journal_Entry.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Journal_Entry.Name = "xuc_Journal_Entry"
            Me.xuc_Journal_Entry.Size = New System.Drawing.Size(493, 494)
            Me.xuc_Journal_Entry.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("eebd1a75-b4f6-419a-8a60-84b2fe273d0e")
            Me.dockPanel2.Location = New System.Drawing.Point(798, 45)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(200, 523)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(193, 494)
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
            Me.TabPane1.RegularSize = New System.Drawing.Size(193, 494)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(193, 494)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(193, 461)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 461)
            Me.xuc_Settings.TabIndex = 1
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(193, 465)
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.RadioGroup_Verification_Mode)
            Me.LayoutControl.Controls.Add(Me.RadioGroup_Mode)
            Me.LayoutControl.Controls.Add(Me.check_Group_Entry)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(193, 465)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'RadioGroup_Verification_Mode
            '
            Me.RadioGroup_Verification_Mode.Location = New System.Drawing.Point(12, 152)
            Me.RadioGroup_Verification_Mode.MenuManager = Me.barManager
            Me.RadioGroup_Verification_Mode.Name = "RadioGroup_Verification_Mode"
            Me.RadioGroup_Verification_Mode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Table ID"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Reference")})
            Me.RadioGroup_Verification_Mode.Size = New System.Drawing.Size(169, 55)
            Me.RadioGroup_Verification_Mode.StyleController = Me.layoutControl
            Me.RadioGroup_Verification_Mode.TabIndex = 4
            '
            'RadioGroup_Mode
            '
            Me.RadioGroup_Mode.Location = New System.Drawing.Point(12, 52)
            Me.RadioGroup_Mode.MenuManager = Me.barManager
            Me.RadioGroup_Mode.Name = "RadioGroup_Mode"
            Me.RadioGroup_Mode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Checked"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Unchecked")})
            Me.RadioGroup_Mode.Size = New System.Drawing.Size(169, 80)
            Me.RadioGroup_Mode.StyleController = Me.layoutControl
            Me.RadioGroup_Mode.TabIndex = 3
            '
            'check_Group_Entry
            '
            Me.check_Group_Entry.EditValue = True
            Me.check_Group_Entry.Location = New System.Drawing.Point(12, 12)
            Me.check_Group_Entry.Name = "check_Group_Entry"
            Me.check_Group_Entry.Properties.AutoWidth = True
            Me.check_Group_Entry.Properties.Caption = "Group Entry upon save"
            Me.check_Group_Entry.Size = New System.Drawing.Size(134, 20)
            Me.check_Group_Entry.StyleController = Me.layoutControl
            Me.check_Group_Entry.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem4})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(193, 465)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.check_Group_Entry
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 24)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.RadioGroup_Mode
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 100)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(133, 100)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 100)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "Loop Action Mode"
            Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 199)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(173, 246)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.RadioGroup_Verification_Mode
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 124)
            Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 75)
            Me.LayoutControlItem4.MinSize = New System.Drawing.Size(133, 75)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 75)
            Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem4.Text = "Loop Action Mode"
            Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_COA, Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(296, 498)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsVerified, Me.colTable_ID, Me.colJournal_Code, Me.colBranch_Code, Me.colCorporation, Me.colJournal_Reference, Me.colCOA_Code, Me.colCOA_Summary, Me.colCOA_Name, Me.colJournal_Type, Me.colJournal_Profile, Me.colAccount_Code, Me.colAccount_Name, Me.colJournal_Debit, Me.colJournal_Credit, Me.colCheck_Number, Me.colJournal_Description, Me.colIsLiquidated, Me.colVoucher_Reference, Me.colJustification, Me.colJournal_Status, Me.colPosted_By, Me.colPosting_Date, Me.colTransacted_By, Me.colTransaction_Date, Me.colAdded_By, Me.colAdded_Date, Me.colApproved_By, Me.colApproved_Date, Me.colModified_By, Me.colModified_Date, Me.colVerified_By, Me.colVerified_Date, Me.colNotes, Me.colModification, Me.colIsLocked, Me.colLocked_Date, Me.colLocked_By, Me.colIsDeleted, Me.colDeleted_By, Me.colDeleted_Date})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Journal_Debit", Me.colJournal_Debit, "(Debit: SUM={0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Journal_Credit", Me.colJournal_Credit, "(Credit: SUM={0:0.##})")})
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
            'colIsVerified
            '
            Me.colIsVerified.Caption = "Verified"
            Me.colIsVerified.FieldName = "IsVerified"
            Me.colIsVerified.Name = "colIsVerified"
            Me.colIsVerified.Visible = True
            Me.colIsVerified.VisibleIndex = 1
            '
            'colTable_ID
            '
            Me.colTable_ID.Caption = "Table ID"
            Me.colTable_ID.FieldName = "Table_ID"
            Me.colTable_ID.Name = "colTable_ID"
            Me.colTable_ID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Table_ID", "{0}")})
            Me.colTable_ID.Visible = True
            Me.colTable_ID.VisibleIndex = 2
            '
            'colJournal_Code
            '
            Me.colJournal_Code.Caption = "Journal Code"
            Me.colJournal_Code.FieldName = "Journal_Code"
            Me.colJournal_Code.Name = "colJournal_Code"
            Me.colJournal_Code.Visible = True
            Me.colJournal_Code.VisibleIndex = 3
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 4
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Corporation"
            Me.colCorporation.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 5
            '
            'colJournal_Reference
            '
            Me.colJournal_Reference.Caption = "Reference"
            Me.colJournal_Reference.FieldName = "Journal_Reference"
            Me.colJournal_Reference.Name = "colJournal_Reference"
            Me.colJournal_Reference.Visible = True
            Me.colJournal_Reference.VisibleIndex = 6
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Title Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 7
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.Caption = "Summary"
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 8
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "Account Title"
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 9
            '
            'colJournal_Type
            '
            Me.colJournal_Type.Caption = "Type"
            Me.colJournal_Type.FieldName = "Journal_Type"
            Me.colJournal_Type.Name = "colJournal_Type"
            Me.colJournal_Type.Visible = True
            Me.colJournal_Type.VisibleIndex = 10
            '
            'colJournal_Profile
            '
            Me.colJournal_Profile.Caption = "Profile"
            Me.colJournal_Profile.FieldName = "Journal_Profile"
            Me.colJournal_Profile.Name = "colJournal_Profile"
            Me.colJournal_Profile.Visible = True
            Me.colJournal_Profile.VisibleIndex = 11
            '
            'colAccount_Code
            '
            Me.colAccount_Code.Caption = "Account Code"
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 12
            '
            'colAccount_Name
            '
            Me.colAccount_Name.Caption = "Account Name"
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 13
            '
            'colJournal_Debit
            '
            Me.colJournal_Debit.Caption = "Debit"
            Me.colJournal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Debit.FieldName = "Journal_Debit"
            Me.colJournal_Debit.Name = "colJournal_Debit"
            Me.colJournal_Debit.Visible = True
            Me.colJournal_Debit.VisibleIndex = 14
            '
            'colJournal_Credit
            '
            Me.colJournal_Credit.Caption = "Credit"
            Me.colJournal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Credit.FieldName = "Journal_Credit"
            Me.colJournal_Credit.Name = "colJournal_Credit"
            Me.colJournal_Credit.Visible = True
            Me.colJournal_Credit.VisibleIndex = 15
            '
            'colCheck_Number
            '
            Me.colCheck_Number.Caption = "Check Number"
            Me.colCheck_Number.FieldName = "Check_Number"
            Me.colCheck_Number.Name = "colCheck_Number"
            Me.colCheck_Number.Visible = True
            Me.colCheck_Number.VisibleIndex = 16
            '
            'colJournal_Description
            '
            Me.colJournal_Description.Caption = "Description"
            Me.colJournal_Description.FieldName = "Journal_Description"
            Me.colJournal_Description.Name = "colJournal_Description"
            Me.colJournal_Description.Visible = True
            Me.colJournal_Description.VisibleIndex = 17
            '
            'colIsLiquidated
            '
            Me.colIsLiquidated.FieldName = "IsLiquidated"
            Me.colIsLiquidated.Name = "colIsLiquidated"
            Me.colIsLiquidated.Visible = True
            Me.colIsLiquidated.VisibleIndex = 18
            '
            'colVoucher_Reference
            '
            Me.colVoucher_Reference.Caption = "Liquidation"
            Me.colVoucher_Reference.FieldName = "Voucher_Reference"
            Me.colVoucher_Reference.Name = "colVoucher_Reference"
            Me.colVoucher_Reference.Visible = True
            Me.colVoucher_Reference.VisibleIndex = 19
            '
            'colJustification
            '
            Me.colJustification.FieldName = "Justification"
            Me.colJustification.Name = "colJustification"
            Me.colJustification.Visible = True
            Me.colJustification.VisibleIndex = 20
            '
            'colJournal_Status
            '
            Me.colJournal_Status.Caption = "Status"
            Me.colJournal_Status.FieldName = "Journal_Status"
            Me.colJournal_Status.Name = "colJournal_Status"
            Me.colJournal_Status.Visible = True
            Me.colJournal_Status.VisibleIndex = 21
            '
            'colPosted_By
            '
            Me.colPosted_By.Caption = "Posted By"
            Me.colPosted_By.FieldName = "Posted_By"
            Me.colPosted_By.Name = "colPosted_By"
            Me.colPosted_By.Visible = True
            Me.colPosted_By.VisibleIndex = 22
            '
            'colPosting_Date
            '
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 23
            '
            'colTransacted_By
            '
            Me.colTransacted_By.Caption = "Transacted By"
            Me.colTransacted_By.FieldName = "Transacted_By"
            Me.colTransacted_By.Name = "colTransacted_By"
            Me.colTransacted_By.Visible = True
            Me.colTransacted_By.VisibleIndex = 24
            '
            'colTransaction_Date
            '
            Me.colTransaction_Date.FieldName = "Transaction_Date"
            Me.colTransaction_Date.Name = "colTransaction_Date"
            Me.colTransaction_Date.Visible = True
            Me.colTransaction_Date.VisibleIndex = 25
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 26
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 27
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
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 29
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 30
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 31
            '
            'colVerified_By
            '
            Me.colVerified_By.FieldName = "Verified_By"
            Me.colVerified_By.Name = "colVerified_By"
            Me.colVerified_By.Visible = True
            Me.colVerified_By.VisibleIndex = 32
            '
            'colVerified_Date
            '
            Me.colVerified_Date.FieldName = "Verified_Date"
            Me.colVerified_Date.Name = "colVerified_Date"
            Me.colVerified_Date.Visible = True
            Me.colVerified_Date.VisibleIndex = 33
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 34
            '
            'colModification
            '
            Me.colModification.FieldName = "Modification"
            Me.colModification.Name = "colModification"
            Me.colModification.Visible = True
            Me.colModification.VisibleIndex = 35
            '
            'colIsLocked
            '
            Me.colIsLocked.Caption = "Locked"
            Me.colIsLocked.FieldName = "IsLocked"
            Me.colIsLocked.Name = "colIsLocked"
            Me.colIsLocked.Visible = True
            Me.colIsLocked.VisibleIndex = 36
            '
            'colLocked_Date
            '
            Me.colLocked_Date.Caption = "Locked Date"
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 37
            '
            'colLocked_By
            '
            Me.colLocked_By.Caption = "Locked By"
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 38
            '
            'colIsDeleted
            '
            Me.colIsDeleted.FieldName = "IsDeleted"
            Me.colIsDeleted.Name = "colIsDeleted"
            Me.colIsDeleted.Visible = True
            Me.colIsDeleted.VisibleIndex = 39
            '
            'colDeleted_By
            '
            Me.colDeleted_By.FieldName = "Deleted_By"
            Me.colDeleted_By.Name = "colDeleted_By"
            Me.colDeleted_By.Visible = True
            Me.colDeleted_By.VisibleIndex = 40
            '
            'colDeleted_Date
            '
            Me.colDeleted_Date.FieldName = "Deleted_Date"
            Me.colDeleted_Date.Name = "colDeleted_Date"
            Me.colDeleted_Date.Visible = True
            Me.colDeleted_Date.VisibleIndex = 41
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Batch_Transactions), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unverify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Custom1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Trial_Balance), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'XtraTabControl
            '
            Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl.Location = New System.Drawing.Point(500, 45)
            Me.XtraTabControl.Name = "XtraTabControl"
            Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
            Me.XtraTabControl.Size = New System.Drawing.Size(298, 523)
            Me.XtraTabControl.TabIndex = 0
            Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage3, Me.XtraTabPage2})
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.Controls.Add(Me.gridControl)
            Me.XtraTabPage1.Name = "XtraTabPage1"
            Me.XtraTabPage1.Size = New System.Drawing.Size(296, 498)
            Me.XtraTabPage1.Text = "Journal Entries"
            '
            'XtraTabPage3
            '
            Me.XtraTabPage3.Controls.Add(Me.xuc_Account_Summary)
            Me.XtraTabPage3.Name = "XtraTabPage3"
            Me.XtraTabPage3.Size = New System.Drawing.Size(296, 498)
            Me.XtraTabPage3.Text = "Account Titles"
            '
            'xuc_Account_Summary
            '
            Me.xuc_Account_Summary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Summary.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Summary.Name = "xuc_Account_Summary"
            Me.xuc_Account_Summary.Size = New System.Drawing.Size(296, 498)
            Me.xuc_Account_Summary.TabIndex = 0
            '
            'XtraTabPage2
            '
            Me.XtraTabPage2.Controls.Add(Me.xuc_Grid_Journal_References)
            Me.XtraTabPage2.Name = "XtraTabPage2"
            Me.XtraTabPage2.Size = New System.Drawing.Size(296, 498)
            Me.XtraTabPage2.Text = "Group References"
            '
            'xuc_Grid_Journal_References
            '
            Me.xuc_Grid_Journal_References.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Journal_References.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Journal_References.Name = "xuc_Grid_Journal_References"
            Me.xuc_Grid_Journal_References.Size = New System.Drawing.Size(296, 498)
            Me.xuc_Grid_Journal_References.TabIndex = 0
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'frm_Journal_Entries
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(998, 568)
            Me.Controls.Add(Me.XtraTabControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Journal_Entries"
            Me.Text = "Journal Entries"
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Profiles, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemButtonEdit_Journal_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Any_Date, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Search_Mode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemtoggle_Branch_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.RadioGroup_Verification_Mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioGroup_Mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Group_Entry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            Me.XtraTabPage3.ResumeLayout(False)
            Me.XtraTabPage2.ResumeLayout(False)
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Private bar_Options As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemComboBox_Account_Code As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colTable_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents repositoryItemLookUpEdit_Accounts As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Profiles As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colTransacted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colJournal_Profile As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Custom1 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar6 As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Filter As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Filter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Filter_Load As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Filter_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Filter_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colPosted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
        Friend WithEvents RepositoryItemButtonEdit_Journal_Voucher As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Friend WithEvents check_Group_Entry As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents xuc_Grid_Journal_References As Controls.Accounting.xuc_Grid_Journal_References
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Journal_Entry As Controls.Accounting.xuc_Journal_Entry
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Trial_Balance As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents xuc_Account_Summary As Controls.Accounting.xuc_Account_Summary
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RadioGroup_Mode As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents RadioGroup_Verification_Mode As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents RepositoryItemtoggle_Any_Date As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents colCheck_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Lock As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unverify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Dashboard As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemtoggle_Search_Mode As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents RepositoryItemtoggle_Branch_Filter As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents colVoucher_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Liquidations As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Branch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsLiquidated As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJustification As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Proof_Sheet As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Deleted As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsDeleted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVerified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVerified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarEditItem_Type As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Load_Type As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colModification As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Error As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unverified As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Toggle_Branch_HO As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace
