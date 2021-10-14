Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Bank_Accounts
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
        'It can be modified using the Windows Form Designer.  
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
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_bank = New SagaClassLibrary.Controls.Accounting.xuc_Bank()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.PropertygridControl1 = New DevExpress.XtraVerticalGrid.PropertygridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Account = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colBank_BRSTN = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Manager = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Tel_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.EntityInstantFeedbackSource = New DevExpress.Data.Linq.EntityInstantFeedbackSource()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.PropertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
            Me.AdornerUIManager = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.PropertygridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
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
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search})
            Me.barManager.MaxItemId = 10
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
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
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(333, 191)
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
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(898, 20)
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
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(898, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("60e67d01-7752-498f-9699-a9d55a2cdfc2")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(286, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(286, 548)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_bank)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 519)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_bank
            '
            Me.xuc_bank.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_bank.Location = New System.Drawing.Point(0, 0)
            Me.xuc_bank.Name = "xuc_bank"
            Me.xuc_bank.Size = New System.Drawing.Size(279, 519)
            Me.xuc_bank.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("5c881983-9b45-465c-a41a-e25896b9060b")
            Me.DockPanel2.Location = New System.Drawing.Point(618, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 548)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 519)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'TabPane1
            '
            Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
            Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
            Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabPane1.Location = New System.Drawing.Point(0, 0)
            Me.TabPane1.Name = "TabPane1"
            Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
            Me.TabPane1.RegularSize = New System.Drawing.Size(273, 519)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(273, 519)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Settings"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(273, 490)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 490)
            Me.xuc_Settings.TabIndex = 0
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.PropertygridControl1)
            Me.TabNavigationPage2.Controls.Add(Me.PropertyDescriptionControl1)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(213, 423)
            '
            'PropertygridControl1
            '
            Me.PropertygridControl1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PropertygridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PropertygridControl1.Location = New System.Drawing.Point(0, 0)
            Me.PropertygridControl1.MenuManager = Me.barManager
            Me.PropertygridControl1.Name = "PropertygridControl1"
            Me.PropertygridControl1.SelectedObject = Me.gridView
            Me.PropertygridControl1.Size = New System.Drawing.Size(213, 316)
            Me.PropertygridControl1.TabIndex = 0
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBank_Code, Me.colCorporation, Me.colBank_Account, Me.colAccount_Name, Me.colBank_Name, Me.colCOA_Code, Me.colBank_BRSTN, Me.colBank_Manager, Me.colBank_Address, Me.colBank_Tel_Number, Me.colBank_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colBank_Code
            '
            Me.colBank_Code.Caption = "Bank Code"
            Me.colBank_Code.FieldName = "Bank_Code"
            Me.colBank_Code.Name = "colBank_Code"
            Me.colBank_Code.Visible = True
            Me.colBank_Code.VisibleIndex = 1
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Corporation"
            Me.colCorporation.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            '
            'colBank_Account
            '
            Me.colBank_Account.Caption = "Bank Account"
            Me.colBank_Account.FieldName = "Bank_Account"
            Me.colBank_Account.Name = "colBank_Account"
            Me.colBank_Account.Visible = True
            Me.colBank_Account.VisibleIndex = 3
            '
            'colAccount_Name
            '
            Me.colAccount_Name.Caption = "Account Name"
            Me.colAccount_Name.CustomizationCaption = "Account Name"
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 7
            '
            'colBank_Name
            '
            Me.colBank_Name.Caption = "Bank Name"
            Me.colBank_Name.FieldName = "Bank_Name"
            Me.colBank_Name.Name = "colBank_Name"
            Me.colBank_Name.Visible = True
            Me.colBank_Name.VisibleIndex = 5
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Account Title"
            Me.colCOA_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 6
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colBank_BRSTN
            '
            Me.colBank_BRSTN.Caption = "BRSTN"
            Me.colBank_BRSTN.FieldName = "Bank_BRSTN"
            Me.colBank_BRSTN.Name = "colBank_BRSTN"
            Me.colBank_BRSTN.Visible = True
            Me.colBank_BRSTN.VisibleIndex = 4
            '
            'colBank_Manager
            '
            Me.colBank_Manager.Caption = "Manager"
            Me.colBank_Manager.FieldName = "Bank_Manager"
            Me.colBank_Manager.Name = "colBank_Manager"
            Me.colBank_Manager.Visible = True
            Me.colBank_Manager.VisibleIndex = 8
            '
            'colBank_Address
            '
            Me.colBank_Address.Caption = "Address"
            Me.colBank_Address.FieldName = "Bank_Address"
            Me.colBank_Address.Name = "colBank_Address"
            Me.colBank_Address.Visible = True
            Me.colBank_Address.VisibleIndex = 9
            '
            'colBank_Tel_Number
            '
            Me.colBank_Tel_Number.Caption = "Telephone"
            Me.colBank_Tel_Number.FieldName = "Bank_Tel_Number"
            Me.colBank_Tel_Number.Name = "colBank_Tel_Number"
            Me.colBank_Tel_Number.Visible = True
            Me.colBank_Tel_Number.VisibleIndex = 10
            '
            'colBank_Description
            '
            Me.colBank_Description.Caption = "Description"
            Me.colBank_Description.FieldName = "Bank_Description"
            Me.colBank_Description.Name = "colBank_Description"
            Me.colBank_Description.Visible = True
            Me.colBank_Description.VisibleIndex = 11
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 12
            '
            'colAdded_By
            '
            Me.colAdded_By.Caption = "Added By"
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 13
            '
            'colAdded_Date
            '
            Me.colAdded_Date.Caption = "Added Date"
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 14
            '
            'colModified_By
            '
            Me.colModified_By.Caption = "Modified By"
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 15
            '
            'colModified_Date
            '
            Me.colModified_Date.Caption = "Modified Date"
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 16
            '
            'gridControl
            '
            Me.gridControl.DataSource = Me.EntityInstantFeedbackSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(286, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA, Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(332, 548)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'EntityInstantFeedbackSource
            '
            Me.EntityInstantFeedbackSource.DefaultSorting = "ID ASC"
            Me.EntityInstantFeedbackSource.DesignTimeElementType = GetType(SagaClassLibrary.acc_Banks)
            Me.EntityInstantFeedbackSource.KeyExpression = "ID"
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'PropertyDescriptionControl1
            '
            Me.PropertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PropertyDescriptionControl1.Location = New System.Drawing.Point(0, 316)
            Me.PropertyDescriptionControl1.Name = "PropertyDescriptionControl1"
            Me.PropertyDescriptionControl1.PropertyGrid = Me.PropertygridControl1
            Me.PropertyDescriptionControl1.Size = New System.Drawing.Size(213, 107)
            Me.PropertyDescriptionControl1.TabIndex = 2
            Me.PropertyDescriptionControl1.TabStop = False
            '
            'AdornerUIManager
            '
            Me.AdornerUIManager.Owner = Me
            '
            'frm_Bank_Accounts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 568)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Bank_Accounts"
            Me.Text = "Bank Accounts"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.PropertygridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents xuc_bank As Controls.Accounting.xuc_Bank
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Account As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Manager As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Tel_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents EntityInstantFeedbackSource As DevExpress.Data.Linq.EntityInstantFeedbackSource
        Friend WithEvents colBank_BRSTN As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents PropertygridControl1 As DevExpress.XtraVerticalGrid.PropertygridControl
        Friend WithEvents PropertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents AdornerUIManager As DevExpress.Utils.VisualEffects.AdornerUIManager
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace