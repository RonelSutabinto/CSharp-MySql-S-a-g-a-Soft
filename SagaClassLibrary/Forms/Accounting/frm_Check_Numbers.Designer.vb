Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Check_Numbers
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
            Me.btn_Link = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Cancel = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Check = New SagaClassLibrary.Controls.Accounting.xuc_Check()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.EntityInstantFeedbackSource = New DevExpress.Data.Linq.EntityInstantFeedbackSource()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Account = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colVoucher_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Payee = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Amount_Words = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsIssued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIssued_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsCancelled = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Link, Me.btn_Cancel, Me.btn_Journal_Entries, Me.btn_Update, Me.btn_Stop})
            Me.barManager.MaxItemId = 15
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Link), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Cancel), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 115
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
            'btn_Link
            '
            Me.btn_Link.Caption = "Link"
            Me.btn_Link.Id = 10
            Me.btn_Link.ImageOptions.ImageIndex = 8
            Me.btn_Link.ImageOptions.LargeImageIndex = 8
            Me.btn_Link.Name = "btn_Link"
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
            Me.btn_Update.Id = 13
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 14
            Me.btn_Stop.Name = "btn_Stop"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Caption = "Cancel"
            Me.btn_Cancel.Id = 11
            Me.btn_Cancel.ImageOptions.ImageIndex = 9
            Me.btn_Cancel.ImageOptions.LargeImageIndex = 9
            Me.btn_Cancel.Name = "btn_Cancel"
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
            Me.BarEditItem_Search.Caption = "Search"
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
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 12
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("5b9cf509-7f1e-4c23-bae5-015aa109b87d")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(350, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(350, 548)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Check)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(343, 519)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Check
            '
            Me.xuc_Check.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Check.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Check.Name = "xuc_Check"
            Me.xuc_Check.Size = New System.Drawing.Size(343, 519)
            Me.xuc_Check.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("5d815f11-ffd0-481b-bc4a-3256009ee65e")
            Me.DockPanel2.Location = New System.Drawing.Point(618, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 548)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 519)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 519)
            Me.xuc_Settings.TabIndex = 0
            '
            'GridControl
            '
            Me.GridControl.DataSource = Me.EntityInstantFeedbackSource
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(350, 20)
            Me.GridControl.MainView = Me.gridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA, Me.RepositoryItemLookUpEdit_Corporation})
            Me.GridControl.Size = New System.Drawing.Size(268, 548)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'EntityInstantFeedbackSource
            '
            Me.EntityInstantFeedbackSource.DefaultSorting = "ID ASC"
            Me.EntityInstantFeedbackSource.DesignTimeElementType = GetType(SagaClassLibrary.view_Checks)
            Me.EntityInstantFeedbackSource.KeyExpression = "Check_Code"
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCheck_Code, Me.colCorporation, Me.colCheck_Number, Me.colBank_Account, Me.colBank_Name, Me.colAccount_Name, Me.colCOA_Code, Me.colVoucher_Code, Me.colReference, Me.colCheck_Payee, Me.colCheck_Amount, Me.colCheck_Amount_Words, Me.colIsIssued, Me.colIssued_Date, Me.colIsCancelled, Me.colCheck_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date})
            Me.gridView.GridControl = Me.GridControl
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
            'colCheck_Code
            '
            Me.colCheck_Code.Caption = "Check Code"
            Me.colCheck_Code.FieldName = "Check_Code"
            Me.colCheck_Code.Name = "colCheck_Code"
            Me.colCheck_Code.Visible = True
            Me.colCheck_Code.VisibleIndex = 1
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
            'colCheck_Number
            '
            Me.colCheck_Number.Caption = "Check Number"
            Me.colCheck_Number.FieldName = "Check_Number"
            Me.colCheck_Number.Name = "colCheck_Number"
            Me.colCheck_Number.Visible = True
            Me.colCheck_Number.VisibleIndex = 3
            '
            'colBank_Account
            '
            Me.colBank_Account.Caption = "Bank Account"
            Me.colBank_Account.FieldName = "Bank_Account"
            Me.colBank_Account.Name = "colBank_Account"
            Me.colBank_Account.Visible = True
            Me.colBank_Account.VisibleIndex = 4
            '
            'colBank_Name
            '
            Me.colBank_Name.Caption = "Bank Name"
            Me.colBank_Name.FieldName = "Bank_Name"
            Me.colBank_Name.Name = "colBank_Name"
            Me.colBank_Name.Visible = True
            Me.colBank_Name.VisibleIndex = 5
            '
            'colAccount_Name
            '
            Me.colAccount_Name.Caption = "Account Name"
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 6
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Account Title"
            Me.colCOA_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 7
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colVoucher_Code
            '
            Me.colVoucher_Code.Caption = "Voucher"
            Me.colVoucher_Code.FieldName = "Voucher_Code"
            Me.colVoucher_Code.Name = "colVoucher_Code"
            Me.colVoucher_Code.Visible = True
            Me.colVoucher_Code.VisibleIndex = 8
            '
            'colReference
            '
            Me.colReference.Caption = "Reference"
            Me.colReference.FieldName = "Reference"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 9
            '
            'colCheck_Payee
            '
            Me.colCheck_Payee.Caption = "Payee"
            Me.colCheck_Payee.FieldName = "Check_Payee"
            Me.colCheck_Payee.Name = "colCheck_Payee"
            Me.colCheck_Payee.Visible = True
            Me.colCheck_Payee.VisibleIndex = 10
            '
            'colCheck_Amount
            '
            Me.colCheck_Amount.Caption = "Amount"
            Me.colCheck_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCheck_Amount.FieldName = "Check_Amount"
            Me.colCheck_Amount.Name = "colCheck_Amount"
            Me.colCheck_Amount.Visible = True
            Me.colCheck_Amount.VisibleIndex = 11
            '
            'colCheck_Amount_Words
            '
            Me.colCheck_Amount_Words.Caption = "Amount in Words"
            Me.colCheck_Amount_Words.FieldName = "Check_Amount_Words"
            Me.colCheck_Amount_Words.Name = "colCheck_Amount_Words"
            Me.colCheck_Amount_Words.Visible = True
            Me.colCheck_Amount_Words.VisibleIndex = 12
            '
            'colIsIssued
            '
            Me.colIsIssued.Caption = "Issued"
            Me.colIsIssued.FieldName = "IsIssued"
            Me.colIsIssued.Name = "colIsIssued"
            Me.colIsIssued.Visible = True
            Me.colIsIssued.VisibleIndex = 13
            '
            'colIssued_Date
            '
            Me.colIssued_Date.Caption = "Issued Date"
            Me.colIssued_Date.FieldName = "Issued_Date"
            Me.colIssued_Date.Name = "colIssued_Date"
            Me.colIssued_Date.Visible = True
            Me.colIssued_Date.VisibleIndex = 14
            '
            'colIsCancelled
            '
            Me.colIsCancelled.Caption = "Cancelled"
            Me.colIsCancelled.FieldName = "IsCancelled"
            Me.colIsCancelled.Name = "colIsCancelled"
            Me.colIsCancelled.Visible = True
            Me.colIsCancelled.VisibleIndex = 15
            '
            'colCheck_Description
            '
            Me.colCheck_Description.Caption = "Description"
            Me.colCheck_Description.FieldName = "Check_Description"
            Me.colCheck_Description.Name = "colCheck_Description"
            Me.colCheck_Description.Visible = True
            Me.colCheck_Description.VisibleIndex = 16
            '
            'colNotes
            '
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
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Link, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'frm_Check_Numbers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 568)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Check_Numbers"
            Me.Text = "Check Numbers"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Check As Controls.Accounting.xuc_Check
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
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
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Account As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Payee As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Amount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Amount_Words As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIssued_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsCancelled As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsIssued As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Link As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Cancel As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colVoucher_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace