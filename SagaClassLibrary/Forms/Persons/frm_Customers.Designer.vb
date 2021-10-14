Namespace Forms.Persons
    Partial Class frm_Customers
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Customers))
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Account = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.btn_SMS_Blast = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Customer = New SagaClassLibrary.Controls.Persons.xuc_Customer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Accounts = New SagaClassLibrary.Controls.Information.Account.xuc_Accounts()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSeqID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIFKey = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBday = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOccupation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBusinessName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBusAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSpouseName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSpouseBday = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSpouseContact = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSpouseOccupation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSpouseOccupAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2, Me.dockPanel3})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
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
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Account, Me.btn_SMS_Blast, Me.barEditItem_Branch})
            Me.barManager.MaxItemId = 14
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 3
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
            Me.bar1.Offset = 61
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
            Me.bar2.DockCol = 1
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Caption = "Branch"
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 13
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 10
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 7
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
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Account)})
            Me.bar3.Offset = 115
            Me.bar3.Text = "Journal"
            '
            'btn_Account
            '
            Me.btn_Account.Caption = "Account"
            Me.btn_Account.Id = 11
            Me.btn_Account.ImageOptions.ImageIndex = 8
            Me.btn_Account.ImageOptions.LargeImageIndex = 8
            Me.btn_Account.Name = "btn_Account"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Custom 5"
            Me.Bar4.DockCol = 0
            Me.Bar4.DockRow = 0
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.FloatLocation = New System.Drawing.Point(52, 155)
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SMS_Blast)})
            Me.Bar4.Text = "Custom 5"
            '
            'btn_SMS_Blast
            '
            Me.btn_SMS_Blast.Caption = "SMS Blast"
            Me.btn_SMS_Blast.Id = 12
            Me.btn_SMS_Blast.ImageOptions.Image = CType(resources.GetObject("btn_SMS_Blast.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_SMS_Blast.ImageOptions.LargeImage = CType(resources.GetObject("btn_SMS_Blast.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_SMS_Blast.Name = "btn_SMS_Blast"
            Me.btn_SMS_Blast.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(846, 24)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 518)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(846, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 494)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(846, 24)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 494)
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.FloatSize = New System.Drawing.Size(350, 500)
            Me.dockPanel1.ID = New System.Guid("537b326f-385d-4e56-bc31-e47314c728d4")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 24)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(350, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(350, 494)
            Me.dockPanel1.Text = "Customer Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Customer)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(343, 465)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Customer
            '
            Me.xuc_Customer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Customer.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Customer.Name = "xuc_Customer"
            Me.xuc_Customer.Size = New System.Drawing.Size(343, 465)
            Me.xuc_Customer.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("c617c5a3-6cfb-4b2a-bb3f-8d731425f8c3")
            Me.dockPanel2.Location = New System.Drawing.Point(646, 24)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 494)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(193, 465)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.xuc_Settings)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(193, 465)
            Me.panelControl1.TabIndex = 3
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(189, 461)
            Me.xuc_Settings.TabIndex = 0
            '
            'dockPanel3
            '
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel3.ID = New System.Guid("b09d2757-743a-4fb0-8a5f-9e088ee26b7d")
            Me.dockPanel3.Location = New System.Drawing.Point(350, 348)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.Options.ShowCloseButton = False
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(200, 170)
            Me.dockPanel3.Size = New System.Drawing.Size(296, 170)
            Me.dockPanel3.Text = "Ledgers"
            '
            'dockPanel3_Container
            '
            Me.dockPanel3_Container.Controls.Add(Me.xuc_Accounts)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(3, 27)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(290, 140)
            Me.dockPanel3_Container.TabIndex = 0
            '
            'xuc_Accounts
            '
            Me.xuc_Accounts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Accounts.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Accounts.Name = "xuc_Accounts"
            Me.xuc_Accounts.Size = New System.Drawing.Size(290, 140)
            Me.xuc_Accounts.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(350, 24)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(296, 324)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeqID, Me.colBranchCode, Me.colCIFKey, Me.colFullName, Me.colBday, Me.colGender, Me.colMStatus, Me.colAddress, Me.colOccupation, Me.colContactNumber, Me.colBusinessName, Me.colBusAddress, Me.colSpouseName, Me.colSpouseBday, Me.colSpouseContact, Me.colSpouseOccupation, Me.colSpouseOccupAddress})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colSeqID
            '
            Me.colSeqID.Caption = "ID"
            Me.colSeqID.FieldName = "SeqID"
            Me.colSeqID.Name = "colSeqID"
            Me.colSeqID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SeqID", "{N1}")})
            Me.colSeqID.Visible = True
            Me.colSeqID.VisibleIndex = 0
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 1
            '
            'colCIFKey
            '
            Me.colCIFKey.Caption = "CIF Key"
            Me.colCIFKey.FieldName = "CIFKey"
            Me.colCIFKey.Name = "colCIFKey"
            Me.colCIFKey.Visible = True
            Me.colCIFKey.VisibleIndex = 2
            '
            'colFullName
            '
            Me.colFullName.Caption = "Costumer Name"
            Me.colFullName.FieldName = "FullName"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 3
            '
            'colBday
            '
            Me.colBday.Caption = "Birthday"
            Me.colBday.FieldName = "Bday"
            Me.colBday.Name = "colBday"
            Me.colBday.Visible = True
            Me.colBday.VisibleIndex = 4
            '
            'colGender
            '
            Me.colGender.Caption = "Gender"
            Me.colGender.FieldName = "Gender"
            Me.colGender.Name = "colGender"
            Me.colGender.Visible = True
            Me.colGender.VisibleIndex = 5
            '
            'colMStatus
            '
            Me.colMStatus.Caption = "Marital"
            Me.colMStatus.FieldName = "MStatus"
            Me.colMStatus.Name = "colMStatus"
            Me.colMStatus.Visible = True
            Me.colMStatus.VisibleIndex = 6
            '
            'colAddress
            '
            Me.colAddress.Caption = "Address"
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 7
            '
            'colOccupation
            '
            Me.colOccupation.Caption = "Occupation"
            Me.colOccupation.FieldName = "Occupation"
            Me.colOccupation.Name = "colOccupation"
            Me.colOccupation.Visible = True
            Me.colOccupation.VisibleIndex = 8
            '
            'colContactNumber
            '
            Me.colContactNumber.Caption = "Contact Number"
            Me.colContactNumber.FieldName = "ContactNumber"
            Me.colContactNumber.Name = "colContactNumber"
            Me.colContactNumber.Visible = True
            Me.colContactNumber.VisibleIndex = 9
            '
            'colBusinessName
            '
            Me.colBusinessName.Caption = "Business Name"
            Me.colBusinessName.FieldName = "BusinessName"
            Me.colBusinessName.Name = "colBusinessName"
            Me.colBusinessName.Visible = True
            Me.colBusinessName.VisibleIndex = 10
            '
            'colBusAddress
            '
            Me.colBusAddress.Caption = "Business Address"
            Me.colBusAddress.FieldName = "BusAddress"
            Me.colBusAddress.Name = "colBusAddress"
            Me.colBusAddress.Visible = True
            Me.colBusAddress.VisibleIndex = 11
            '
            'colSpouseName
            '
            Me.colSpouseName.Caption = "Spouse Name"
            Me.colSpouseName.FieldName = "SpouseFName"
            Me.colSpouseName.Name = "colSpouseName"
            Me.colSpouseName.Visible = True
            Me.colSpouseName.VisibleIndex = 12
            '
            'colSpouseBday
            '
            Me.colSpouseBday.Caption = "Birthday"
            Me.colSpouseBday.FieldName = "SpouseBday"
            Me.colSpouseBday.Name = "colSpouseBday"
            Me.colSpouseBday.Visible = True
            Me.colSpouseBday.VisibleIndex = 14
            '
            'colSpouseContact
            '
            Me.colSpouseContact.Caption = "Contact Number"
            Me.colSpouseContact.Name = "colSpouseContact"
            Me.colSpouseContact.Visible = True
            Me.colSpouseContact.VisibleIndex = 13
            '
            'colSpouseOccupation
            '
            Me.colSpouseOccupation.Caption = "Occupation"
            Me.colSpouseOccupation.FieldName = "SpouseOccupation"
            Me.colSpouseOccupation.Name = "colSpouseOccupation"
            Me.colSpouseOccupation.Visible = True
            Me.colSpouseOccupation.VisibleIndex = 15
            '
            'colSpouseOccupAddress
            '
            Me.colSpouseOccupAddress.Caption = "Business Address"
            Me.colSpouseOccupAddress.FieldName = "SpouseOccupAddress"
            Me.colSpouseOccupAddress.Name = "colSpouseOccupAddress"
            Me.colSpouseOccupAddress.Visible = True
            Me.colSpouseOccupAddress.VisibleIndex = 16
            '
            'frm_Customers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(846, 518)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel3)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Customers"
            Me.ShowMdiChildCaptionInParentTitle = True
            Me.Text = "Customers List"
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
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
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colSeqID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIFKey As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBday As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGender As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOccupation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colContactNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBusinessName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBusAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSpouseBday As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSpouseOccupation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSpouseOccupAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSpouseName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSpouseContact As DevExpress.XtraGrid.Columns.GridColumn
        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private bar3 As DevExpress.XtraBars.Bar
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents btn_Account As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_SMS_Blast As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents xuc_Customer As Controls.Persons.xuc_Customer
        Friend WithEvents xuc_Accounts As Controls.Information.Account.xuc_Accounts
    End Class
End Namespace