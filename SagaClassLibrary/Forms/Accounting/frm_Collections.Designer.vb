Namespace Forms.Accounting
    Partial Class frm_Collections
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarCheckItem_Corporation = New DevExpress.XtraBars.BarCheckItem()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Filter = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Filter = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.btn_Filter_Load = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Filter_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Filter_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar5 = New DevExpress.XtraBars.Bar()
            Me.BarToggleSwitchItem_Custom_Posting_Date = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.BarEditItem_Posting_Date = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Date_Posting_Custom = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_Reason = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemTextEdit_Reason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.Bar6 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel_Information = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel_Settings = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Check_OR_Number_Update = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Auto_Load_Filter = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Update_Table_ID = New DevExpress.XtraEditors.CheckEdit()
            Me.RadioGroup_Mode = New DevExpress.XtraEditors.RadioGroup()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Grid_Collection = New SagaClassLibrary.Controls.Accounting.xuc_Grid_Collection()
            Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xuc_Grid_Cashiering = New SagaClassLibrary.Controls.Accounting.xuc_Grid_Cashiering()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Date_Posting_Custom, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Date_Posting_Custom.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.dockPanel_Information.SuspendLayout()
            Me.dockPanel_Settings.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.Check_OR_Number_Update.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Auto_Load_Filter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Update_Table_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioGroup_Mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl.SuspendLayout()
            Me.XtraTabPage1.SuspendLayout()
            Me.XtraTabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3, Me.Bar4, Me.Bar5, Me.Bar6})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Batch_Transactions, Me.btn_Preview, Me.barEditItem_Branch, Me.btn_Journal, Me.btn_Stop, Me.btn_Update, Me.btn_Validate, Me.BarEditItem_Search, Me.BarEditItem_Filter, Me.btn_Filter_Load, Me.btn_Filter_Save, Me.btn_Filter_Delete, Me.BarCheckItem_Corporation, Me.btn_Journal_Entries, Me.BarToggleSwitchItem_Custom_Posting_Date, Me.BarEditItem_Posting_Date, Me.BarEditItem_Reason})
            Me.barManager.MaxItemId = 32
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemComboBox_Filter, Me.RepositoryItemDateEdit_Date_Posting_Custom, Me.RepositoryItemTextEdit_Reason, Me.RepositoryItemToggleSwitch1})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 191
            Me.bar1.Text = "Tools"
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
            Me.btn_Reload.ImageOptions.ImageIndex = 1
            Me.btn_Reload.ImageOptions.LargeImageIndex = 1
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "&Preview"
            Me.btn_Preview.Id = 9
            Me.btn_Preview.ImageOptions.ImageIndex = 2
            Me.btn_Preview.ImageOptions.LargeImageIndex = 2
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 5
            Me.btn_Delete.ImageOptions.LargeImageIndex = 5
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 3
            Me.btn_New.ImageOptions.LargeImageIndex = 3
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 4
            Me.btn_Save.ImageOptions.LargeImageIndex = 4
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 6
            Me.btn_Close.ImageOptions.LargeImageIndex = 6
            Me.btn_Close.Name = "btn_Close"
            '
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barEditItem_Branch, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.repositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 10
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'BarCheckItem_Corporation
            '
            Me.BarCheckItem_Corporation.Caption = "Corporation"
            Me.BarCheckItem_Corporation.Id = 23
            Me.BarCheckItem_Corporation.ImageOptions.ImageIndex = 20
            Me.BarCheckItem_Corporation.ImageOptions.LargeImageIndex = 20
            Me.BarCheckItem_Corporation.Name = "BarCheckItem_Corporation"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 16
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 14
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 14
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'bar3
            '
            Me.bar3.BarName = "Journal"
            Me.bar3.DockCol = 2
            Me.bar3.DockRow = 1
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.bar3.Offset = 234
            Me.bar3.Text = "Journal"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 11
            Me.btn_Journal.ImageOptions.ImageIndex = 9
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Id = 24
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 21
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 21
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Validate"
            Me.btn_Validate.Id = 15
            Me.btn_Validate.ImageOptions.ImageIndex = 13
            Me.btn_Validate.ImageOptions.LargeImageIndex = 13
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "&Update"
            Me.btn_Update.Id = 14
            Me.btn_Update.ImageOptions.ImageIndex = 12
            Me.btn_Update.ImageOptions.LargeImageIndex = 12
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 12
            Me.btn_Stop.ImageOptions.ImageIndex = 10
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Filter"
            Me.Bar4.DockCol = 1
            Me.Bar4.DockRow = 1
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Filter), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Load), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Filter_Delete)})
            Me.Bar4.Text = "Filter"
            '
            'BarEditItem_Filter
            '
            Me.BarEditItem_Filter.Caption = "Filter"
            Me.BarEditItem_Filter.Edit = Me.RepositoryItemComboBox_Filter
            Me.BarEditItem_Filter.Id = 18
            Me.BarEditItem_Filter.ImageOptions.ImageIndex = 16
            Me.BarEditItem_Filter.ImageOptions.LargeImageIndex = 16
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
            Me.btn_Filter_Load.Id = 19
            Me.btn_Filter_Load.ImageOptions.ImageIndex = 17
            Me.btn_Filter_Load.ImageOptions.LargeImageIndex = 17
            Me.btn_Filter_Load.Name = "btn_Filter_Load"
            '
            'btn_Filter_Save
            '
            Me.btn_Filter_Save.Caption = "&Save"
            Me.btn_Filter_Save.Id = 20
            Me.btn_Filter_Save.ImageOptions.ImageIndex = 18
            Me.btn_Filter_Save.ImageOptions.LargeImageIndex = 18
            Me.btn_Filter_Save.Name = "btn_Filter_Save"
            '
            'btn_Filter_Delete
            '
            Me.btn_Filter_Delete.Caption = "&Remove"
            Me.btn_Filter_Delete.Id = 21
            Me.btn_Filter_Delete.ImageOptions.ImageIndex = 19
            Me.btn_Filter_Delete.ImageOptions.LargeImageIndex = 19
            Me.btn_Filter_Delete.Name = "btn_Filter_Delete"
            '
            'Bar5
            '
            Me.Bar5.BarName = "Date Posting"
            Me.Bar5.DockCol = 0
            Me.Bar5.DockRow = 2
            Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarToggleSwitchItem_Custom_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Reason)})
            Me.Bar5.Text = "Date Posting"
            '
            'BarToggleSwitchItem_Custom_Posting_Date
            '
            Me.BarToggleSwitchItem_Custom_Posting_Date.Caption = "Custom Posting Date"
            Me.BarToggleSwitchItem_Custom_Posting_Date.Id = 25
            Me.BarToggleSwitchItem_Custom_Posting_Date.Name = "BarToggleSwitchItem_Custom_Posting_Date"
            '
            'BarEditItem_Posting_Date
            '
            Me.BarEditItem_Posting_Date.Caption = "Posting Date"
            Me.BarEditItem_Posting_Date.Edit = Me.RepositoryItemDateEdit_Date_Posting_Custom
            Me.BarEditItem_Posting_Date.Id = 26
            Me.BarEditItem_Posting_Date.Name = "BarEditItem_Posting_Date"
            '
            'RepositoryItemDateEdit_Date_Posting_Custom
            '
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Appearance.Options.UseTextOptions = True
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.RepositoryItemDateEdit_Date_Posting_Custom.AutoHeight = False
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Date_Posting_Custom.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Date_Posting_Custom.DisplayFormat.FormatString = "MMM dd, yyyy"
            Me.RepositoryItemDateEdit_Date_Posting_Custom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit_Date_Posting_Custom.EditFormat.FormatString = "MMM dd, yyyy"
            Me.RepositoryItemDateEdit_Date_Posting_Custom.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Mask.EditMask = "MMM dd, yyyy"
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Mask.UseMaskAsDisplayFormat = True
            Me.RepositoryItemDateEdit_Date_Posting_Custom.Name = "RepositoryItemDateEdit_Date_Posting_Custom"
            '
            'BarEditItem_Reason
            '
            Me.BarEditItem_Reason.AutoFillWidth = True
            Me.BarEditItem_Reason.Caption = "Reason for Custom Date Posting"
            Me.BarEditItem_Reason.Edit = Me.RepositoryItemTextEdit_Reason
            Me.BarEditItem_Reason.Id = 27
            Me.BarEditItem_Reason.Name = "BarEditItem_Reason"
            '
            'RepositoryItemTextEdit_Reason
            '
            Me.RepositoryItemTextEdit_Reason.AutoHeight = False
            Me.RepositoryItemTextEdit_Reason.Name = "RepositoryItemTextEdit_Reason"
            '
            'Bar6
            '
            Me.Bar6.BarName = "Custom 7"
            Me.Bar6.DockCol = 0
            Me.Bar6.DockRow = 1
            Me.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar6.Text = "Custom 7"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(874, 62)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 548)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(874, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 486)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(874, 62)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 486)
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel_Settings})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.dockPanel_Information)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 62)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 486)
            '
            'dockPanel_Information
            '
            Me.dockPanel_Information.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel_Information.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel_Information.ID = New System.Guid("39a0111a-a6df-43e9-9523-1019dc6c9bb4")
            Me.dockPanel_Information.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel_Information.Name = "dockPanel_Information"
            Me.dockPanel_Information.OriginalSize = New System.Drawing.Size(300, 400)
            Me.dockPanel_Information.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel_Information.SavedIndex = 0
            Me.dockPanel_Information.Size = New System.Drawing.Size(300, 456)
            Me.dockPanel_Information.Text = "Information"
            Me.dockPanel_Information.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(291, 429)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'dockPanel_Settings
            '
            Me.dockPanel_Settings.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel_Settings.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel_Settings.ID = New System.Guid("39e91701-00e9-4683-afec-299fa4dc3e0b")
            Me.dockPanel_Settings.Location = New System.Drawing.Point(653, 62)
            Me.dockPanel_Settings.Name = "dockPanel_Settings"
            Me.dockPanel_Settings.OriginalSize = New System.Drawing.Size(221, 200)
            Me.dockPanel_Settings.Size = New System.Drawing.Size(221, 486)
            Me.dockPanel_Settings.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(214, 457)
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
            Me.TabPane1.RegularSize = New System.Drawing.Size(214, 457)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(214, 457)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(214, 428)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(214, 428)
            Me.xuc_Settings.TabIndex = 2
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(214, 428)
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.Check_OR_Number_Update)
            Me.LayoutControl.Controls.Add(Me.Check_Auto_Load_Filter)
            Me.LayoutControl.Controls.Add(Me.Check_Update_Table_ID)
            Me.LayoutControl.Controls.Add(Me.RadioGroup_Mode)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(214, 428)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'Check_OR_Number_Update
            '
            Me.Check_OR_Number_Update.Location = New System.Drawing.Point(12, 160)
            Me.Check_OR_Number_Update.MenuManager = Me.barManager
            Me.Check_OR_Number_Update.Name = "Check_OR_Number_Update"
            Me.Check_OR_Number_Update.Properties.Caption = "OR Number Update"
            Me.Check_OR_Number_Update.Size = New System.Drawing.Size(190, 20)
            Me.Check_OR_Number_Update.StyleController = Me.layoutControl
            Me.Check_OR_Number_Update.TabIndex = 6
            '
            'Check_Auto_Load_Filter
            '
            Me.Check_Auto_Load_Filter.Location = New System.Drawing.Point(12, 12)
            Me.Check_Auto_Load_Filter.MenuManager = Me.barManager
            Me.Check_Auto_Load_Filter.Name = "Check_Auto_Load_Filter"
            Me.Check_Auto_Load_Filter.Properties.Caption = "Auto Load Filter"
            Me.Check_Auto_Load_Filter.Size = New System.Drawing.Size(190, 20)
            Me.Check_Auto_Load_Filter.StyleController = Me.layoutControl
            Me.Check_Auto_Load_Filter.TabIndex = 2
            '
            'Check_Update_Table_ID
            '
            Me.Check_Update_Table_ID.Location = New System.Drawing.Point(12, 136)
            Me.Check_Update_Table_ID.MenuManager = Me.barManager
            Me.Check_Update_Table_ID.Name = "Check_Update_Table_ID"
            Me.Check_Update_Table_ID.Properties.Caption = "Update Table ID"
            Me.Check_Update_Table_ID.Size = New System.Drawing.Size(190, 20)
            Me.Check_Update_Table_ID.StyleController = Me.layoutControl
            Me.Check_Update_Table_ID.TabIndex = 5
            '
            'RadioGroup_Mode
            '
            Me.RadioGroup_Mode.Location = New System.Drawing.Point(12, 52)
            Me.RadioGroup_Mode.MenuManager = Me.barManager
            Me.RadioGroup_Mode.Name = "RadioGroup_Mode"
            Me.RadioGroup_Mode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Checked"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Unchecked")})
            Me.RadioGroup_Mode.Size = New System.Drawing.Size(190, 80)
            Me.RadioGroup_Mode.StyleController = Me.layoutControl
            Me.RadioGroup_Mode.TabIndex = 3
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(214, 428)
            Me.Root.TextVisible = False
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 172)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(194, 236)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.RadioGroup_Mode
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 100)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(133, 100)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(194, 100)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "Loop Action Mode"
            Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Check_Update_Table_ID
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 124)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(194, 24)
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Check_Auto_Load_Filter
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(194, 24)
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Check_OR_Number_Update
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 148)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(194, 24)
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem6.TextVisible = False
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Co&llections"
            Me.btn_Batch_Transactions.Id = 7
            Me.btn_Batch_Transactions.ImageOptions.ImageIndex = 7
            Me.btn_Batch_Transactions.ImageOptions.LargeImageIndex = 7
            Me.btn_Batch_Transactions.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'RepositoryItemToggleSwitch1
            '
            Me.RepositoryItemToggleSwitch1.AutoHeight = False
            Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
            Me.RepositoryItemToggleSwitch1.OffText = "Built-In"
            Me.RepositoryItemToggleSwitch1.OnText = "Stored Procedure"
            '
            'XtraTabControl
            '
            Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl.Location = New System.Drawing.Point(21, 62)
            Me.XtraTabControl.Name = "XtraTabControl"
            Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
            Me.XtraTabControl.Size = New System.Drawing.Size(632, 486)
            Me.XtraTabControl.TabIndex = 0
            Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
            '
            'XtraTabPage1
            '
            Me.XtraTabPage1.Controls.Add(Me.xuc_Grid_Collection)
            Me.XtraTabPage1.Name = "XtraTabPage1"
            Me.XtraTabPage1.Size = New System.Drawing.Size(630, 461)
            Me.XtraTabPage1.Text = "Collections"
            '
            'xuc_Grid_Collection
            '
            Me.xuc_Grid_Collection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Collection.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Collection.Name = "xuc_Grid_Collection"
            Me.xuc_Grid_Collection.Size = New System.Drawing.Size(630, 461)
            Me.xuc_Grid_Collection.TabIndex = 0
            '
            'XtraTabPage2
            '
            Me.XtraTabPage2.Controls.Add(Me.xuc_Grid_Cashiering)
            Me.XtraTabPage2.Name = "XtraTabPage2"
            Me.XtraTabPage2.Size = New System.Drawing.Size(630, 461)
            Me.XtraTabPage2.Text = "Cashiering"
            '
            'xuc_Grid_Cashiering
            '
            Me.xuc_Grid_Cashiering.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Grid_Cashiering.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Grid_Cashiering.Name = "xuc_Grid_Cashiering"
            Me.xuc_Grid_Cashiering.Size = New System.Drawing.Size(630, 461)
            Me.xuc_Grid_Cashiering.TabIndex = 0
            '
            'frm_Collections
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(874, 548)
            Me.Controls.Add(Me.XtraTabControl)
            Me.Controls.Add(Me.dockPanel_Settings)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Collections"
            Me.Text = "Daily Collections"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Date_Posting_Custom.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Date_Posting_Custom, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.dockPanel_Information.ResumeLayout(False)
            Me.dockPanel_Settings.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.Check_OR_Number_Update.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Auto_Load_Filter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Update_Table_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioGroup_Mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl.ResumeLayout(False)
            Me.XtraTabPage1.ResumeLayout(False)
            Me.XtraTabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Private dockPanel_Settings As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel_Information As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend xuc_Grid_Collection As Controls.Accounting.xuc_Grid_Collection
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Filter As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Filter As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Filter_Load As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Filter_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Filter_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Grid_Cashiering As Controls.Accounting.xuc_Grid_Cashiering
        Friend WithEvents BarCheckItem_Corporation As DevExpress.XtraBars.BarCheckItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
        Friend WithEvents BarToggleSwitchItem_Custom_Posting_Date As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents BarEditItem_Posting_Date As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Date_Posting_Custom As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents RadioGroup_Mode As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Check_Update_Table_ID As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Check_Auto_Load_Filter As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents BarEditItem_Reason As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemTextEdit_Reason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents Check_OR_Number_Update As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Bar6 As DevExpress.XtraBars.Bar
        Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    End Class
End Namespace