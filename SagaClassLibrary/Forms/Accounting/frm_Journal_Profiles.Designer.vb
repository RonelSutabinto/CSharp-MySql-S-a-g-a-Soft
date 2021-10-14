Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Journal_Profiles
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
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
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.repositoryItemComboBox_Account_Code = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.repositoryItemLookUpEdit_Accounts = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Journal_Profile = New SagaClassLibrary.Controls.Accounting.xuc_Journal_Profile()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.EntityInstantFeedbackSource = New DevExpress.Data.Linq.EntityInstantFeedbackSource()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPayment_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Corporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colJournal_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustom_COA = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_VAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBalance_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFriendly_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Delete, Me.BarEditItem_Search})
            Me.barManager.MaxItemId = 15
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox_Account_Code, Me.repositoryItemLookUpEdit_Accounts, Me.RepositoryItemSearchControl_Search})
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
            Me.bar1.Offset = 111
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
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search, True)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 14
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(829, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 489)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(829, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 469)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(829, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 469)
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
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("75240ef6-aa99-4912-821d-204977a28076")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(300, 469)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Journal_Profile)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(293, 440)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Journal_Profile
            '
            Me.xuc_Journal_Profile.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Journal_Profile.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Journal_Profile.Name = "xuc_Journal_Profile"
            Me.xuc_Journal_Profile.Size = New System.Drawing.Size(293, 440)
            Me.xuc_Journal_Profile.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("e62ffa4c-1a82-47aa-802a-eb68914fec45")
            Me.DockPanel2.Location = New System.Drawing.Point(609, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(220, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 469)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.PanelControl1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(213, 440)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.xuc_Settings)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(213, 440)
            Me.PanelControl1.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(209, 436)
            Me.xuc_Settings.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.DataSource = Me.EntityInstantFeedbackSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(300, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(309, 469)
            Me.gridControl.TabIndex = 5
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'EntityInstantFeedbackSource
            '
            Me.EntityInstantFeedbackSource.DefaultSorting = "ID ASC"
            Me.EntityInstantFeedbackSource.DesignTimeElementType = GetType(SagaClassLibrary.view_Journal_Profiles)
            Me.EntityInstantFeedbackSource.KeyExpression = "Profile_Code"
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colProfile_Code, Me.colProfile_Type, Me.colPayment_Code, Me.colProfile_Corporation, Me.colJournal_Type, Me.colProfile_Name, Me.colFriendly_Name, Me.colCOA_Code, Me.colCOA_Name, Me.colCustom_COA, Me.colProfile_VAT, Me.colBalance_Type, Me.colProfile_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date})
            Me.gridView.gridControl = Me.gridControl
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
            'colProfile_Code
            '
            Me.colProfile_Code.Caption = "Profile Code"
            Me.colProfile_Code.FieldName = "Profile_Code"
            Me.colProfile_Code.Name = "colProfile_Code"
            Me.colProfile_Code.Visible = True
            Me.colProfile_Code.VisibleIndex = 1
            '
            'colProfile_Type
            '
            Me.colProfile_Type.FieldName = "Profile_Type"
            Me.colProfile_Type.Name = "colProfile_Type"
            Me.colProfile_Type.Visible = True
            Me.colProfile_Type.VisibleIndex = 2
            '
            'colPayment_Code
            '
            Me.colPayment_Code.Caption = "Payment Code"
            Me.colPayment_Code.FieldName = "Payment_Code"
            Me.colPayment_Code.Name = "colPayment_Code"
            Me.colPayment_Code.Visible = True
            Me.colPayment_Code.VisibleIndex = 3
            '
            'colProfile_Corporation
            '
            Me.colProfile_Corporation.Caption = "Corporation"
            Me.colProfile_Corporation.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colProfile_Corporation.FieldName = "Profile_Corporation"
            Me.colProfile_Corporation.Name = "colProfile_Corporation"
            Me.colProfile_Corporation.Visible = True
            Me.colProfile_Corporation.VisibleIndex = 4
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'colJournal_Type
            '
            Me.colJournal_Type.Caption = "Journal Type"
            Me.colJournal_Type.FieldName = "Journal_Type"
            Me.colJournal_Type.Name = "colJournal_Type"
            Me.colJournal_Type.Visible = True
            Me.colJournal_Type.VisibleIndex = 5
            '
            'colProfile_Name
            '
            Me.colProfile_Name.Caption = "Name"
            Me.colProfile_Name.FieldName = "Profile_Name"
            Me.colProfile_Name.Name = "colProfile_Name"
            Me.colProfile_Name.Visible = True
            Me.colProfile_Name.VisibleIndex = 6
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "COA Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 8
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "COA Name"
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 9
            '
            'colCustom_COA
            '
            Me.colCustom_COA.Caption = "Custom Account"
            Me.colCustom_COA.FieldName = "Custom_COA"
            Me.colCustom_COA.Name = "colCustom_COA"
            Me.colCustom_COA.Visible = True
            Me.colCustom_COA.VisibleIndex = 10
            '
            'colProfile_VAT
            '
            Me.colProfile_VAT.Caption = "VAT"
            Me.colProfile_VAT.FieldName = "Profile_VAT"
            Me.colProfile_VAT.Name = "colProfile_VAT"
            Me.colProfile_VAT.Visible = True
            Me.colProfile_VAT.VisibleIndex = 11
            '
            'colBalance_Type
            '
            Me.colBalance_Type.Caption = "Normal"
            Me.colBalance_Type.FieldName = "Balance_Type"
            Me.colBalance_Type.Name = "colBalance_Type"
            Me.colBalance_Type.Visible = True
            Me.colBalance_Type.VisibleIndex = 12
            '
            'colProfile_Description
            '
            Me.colProfile_Description.Caption = "Description"
            Me.colProfile_Description.FieldName = "Profile_Description"
            Me.colProfile_Description.Name = "colProfile_Description"
            Me.colProfile_Description.Visible = True
            Me.colProfile_Description.VisibleIndex = 13
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 14
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 15
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 16
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 17
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 18
            '
            'colFriendly_Name
            '
            Me.colFriendly_Name.FieldName = "Friendly_Name"
            Me.colFriendly_Name.Name = "colFriendly_Name"
            Me.colFriendly_Name.Visible = True
            Me.colFriendly_Name.VisibleIndex = 7
            '
            'frm_Journal_Profiles
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(829, 489)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Journal_Profiles"
            Me.Text = "Journal Profiles"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents repositoryItemLookUpEdit_Accounts As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents repositoryItemComboBox_Account_Code As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents xuc_Journal_Profile As Controls.Accounting.xuc_Journal_Profile
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProfile_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProfile_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBalance_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProfile_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPayment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProfile_VAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProfile_Corporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustom_COA As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents EntityInstantFeedbackSource As DevExpress.Data.Linq.EntityInstantFeedbackSource
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colProfile_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colFriendly_Name As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace