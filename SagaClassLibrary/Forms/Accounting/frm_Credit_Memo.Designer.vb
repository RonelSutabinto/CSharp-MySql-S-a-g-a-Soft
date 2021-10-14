Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Credit_Memo
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
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Custom = New DevExpress.XtraBars.Bar()
            Me.BarToggleSwitchItem_Custom_Posting_Date = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.BarEditItem_Posting_Date = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Posting_Date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_Reason = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemTextEdit_Reason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Journal_Entries2 = New DevExpress.XtraBars.BarButtonItem()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReleaseType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReferenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.DockPanel1.SuspendLayout()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 62)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 474)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("c5dd9fac-6178-4030-9e76-0c97e3e743c9")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(200, 330)
            Me.DockPanel1.Text = "Information"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 30)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 297)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar3, Me.Bar_Custom})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Delete, Me.btn_Initialize, Me.btn_Preview, Me.btn_Journal, Me.btn_Stop, Me.btn_Journal_Entries, Me.btn_Verify, Me.BarEditItem_Posting_Date, Me.BarEditItem_Reason, Me.btn_Journal_Entries2, Me.BarEditItem_Search, Me.BarToggleSwitchItem_Custom_Posting_Date})
            Me.barManager.MaxItemId = 25
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit_Posting_Date, Me.RepositoryItemTextEdit_Reason, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(193, 135)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 116
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
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 19
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            Me.RepositoryItemSearchControl_Search.Sorted = True
            '
            'Bar3
            '
            Me.Bar3.BarName = "Journal"
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.Bar3.Text = "Journal"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 10
            Me.btn_Journal.ImageOptions.ImageIndex = 7
            Me.btn_Journal.ImageOptions.LargeImageIndex = 7
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 13
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 10
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 10
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 14
            Me.btn_Verify.ImageOptions.ImageIndex = 11
            Me.btn_Verify.ImageOptions.LargeImageIndex = 11
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 11
            Me.btn_Stop.ImageOptions.ImageIndex = 8
            Me.btn_Stop.ImageOptions.LargeImageIndex = 8
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar_Custom
            '
            Me.Bar_Custom.BarName = "Custom"
            Me.Bar_Custom.DockCol = 0
            Me.Bar_Custom.DockRow = 2
            Me.Bar_Custom.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Custom.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarToggleSwitchItem_Custom_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Reason)})
            Me.Bar_Custom.Text = "Custom"
            '
            'BarToggleSwitchItem_Custom_Posting_Date
            '
            Me.BarToggleSwitchItem_Custom_Posting_Date.Caption = "Custom Posting"
            Me.BarToggleSwitchItem_Custom_Posting_Date.Id = 23
            Me.BarToggleSwitchItem_Custom_Posting_Date.Name = "BarToggleSwitchItem_Custom_Posting_Date"
            '
            'BarEditItem_Posting_Date
            '
            Me.BarEditItem_Posting_Date.Caption = "Posting Date"
            Me.BarEditItem_Posting_Date.Edit = Me.RepositoryItemDateEdit_Posting_Date
            Me.BarEditItem_Posting_Date.Enabled = False
            Me.BarEditItem_Posting_Date.Id = 16
            Me.BarEditItem_Posting_Date.Name = "BarEditItem_Posting_Date"
            '
            'RepositoryItemDateEdit_Posting_Date
            '
            Me.RepositoryItemDateEdit_Posting_Date.AutoHeight = False
            Me.RepositoryItemDateEdit_Posting_Date.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Posting_Date.Name = "RepositoryItemDateEdit_Posting_Date"
            '
            'BarEditItem_Reason
            '
            Me.BarEditItem_Reason.AutoFillWidth = True
            Me.BarEditItem_Reason.Caption = "Reason for Custom Posting"
            Me.BarEditItem_Reason.Edit = Me.RepositoryItemTextEdit_Reason
            Me.BarEditItem_Reason.Enabled = False
            Me.BarEditItem_Reason.Id = 17
            Me.BarEditItem_Reason.Name = "BarEditItem_Reason"
            '
            'RepositoryItemTextEdit_Reason
            '
            Me.RepositoryItemTextEdit_Reason.AutoHeight = False
            Me.RepositoryItemTextEdit_Reason.Name = "RepositoryItemTextEdit_Reason"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(639, 62)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 536)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(639, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 474)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(639, 62)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
            '
            'btn_Journal_Entries2
            '
            Me.btn_Journal_Entries2.Caption = "Journal Entries 2"
            Me.btn_Journal_Entries2.Id = 18
            Me.btn_Journal_Entries2.Name = "btn_Journal_Entries2"
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("2ae91e61-1c22-49ea-86c1-421b88182666")
            Me.DockPanel2.Location = New System.Drawing.Point(420, 62)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(219, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(219, 474)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.PanelControl1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(212, 445)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.xuc_Settings)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(212, 445)
            Me.PanelControl1.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(208, 441)
            Me.xuc_Settings.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(21, 62)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(399, 474)
            Me.gridControl.TabIndex = 9
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colCORP, Me.colBranchCode, Me.colwhCode, Me.colSaleType, Me.colReleaseType, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountName, Me.colBrand, Me.colModel, Me.colEngineNo, Me.colChassisNo, Me.colReferenceNumber, Me.colORNumber, Me.colAmountPaid, Me.colPrincipal, Me.colInterest, Me.colPrincipalBalance, Me.colInterestBalance, Me.colPostingDate, Me.colTransactionDate, Me.colTransactedBy, Me.colNote})
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
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colCORP
            '
            Me.colCORP.Caption = "Corporation"
            Me.colCORP.FieldName = "CORP"
            Me.colCORP.Name = "colCORP"
            Me.colCORP.Visible = True
            Me.colCORP.VisibleIndex = 2
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 3
            '
            'colwhCode
            '
            Me.colwhCode.Caption = "Warehouse"
            Me.colwhCode.FieldName = "whCode"
            Me.colwhCode.Name = "colwhCode"
            Me.colwhCode.Visible = True
            Me.colwhCode.VisibleIndex = 4
            '
            'colSaleType
            '
            Me.colSaleType.FieldName = "SaleType"
            Me.colSaleType.Name = "colSaleType"
            Me.colSaleType.Visible = True
            Me.colSaleType.VisibleIndex = 5
            '
            'colReleaseType
            '
            Me.colReleaseType.FieldName = "ReleaseType"
            Me.colReleaseType.Name = "colReleaseType"
            Me.colReleaseType.Visible = True
            Me.colReleaseType.VisibleIndex = 6
            '
            'colAccountNumber
            '
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 7
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 8
            '
            'colAccountName
            '
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 9
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 10
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 11
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 12
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 13
            '
            'colReferenceNumber
            '
            Me.colReferenceNumber.Caption = "Reference"
            Me.colReferenceNumber.FieldName = "ReferenceNumber"
            Me.colReferenceNumber.Name = "colReferenceNumber"
            Me.colReferenceNumber.Visible = True
            Me.colReferenceNumber.VisibleIndex = 14
            '
            'colORNumber
            '
            Me.colORNumber.FieldName = "ORNumber"
            Me.colORNumber.Name = "colORNumber"
            Me.colORNumber.Visible = True
            Me.colORNumber.VisibleIndex = 15
            '
            'colAmountPaid
            '
            Me.colAmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountPaid.FieldName = "AmountPaid"
            Me.colAmountPaid.Name = "colAmountPaid"
            Me.colAmountPaid.Visible = True
            Me.colAmountPaid.VisibleIndex = 16
            '
            'colPrincipal
            '
            Me.colPrincipal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal.FieldName = "Principal"
            Me.colPrincipal.Name = "colPrincipal"
            Me.colPrincipal.Visible = True
            Me.colPrincipal.VisibleIndex = 17
            '
            'colInterest
            '
            Me.colInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest.FieldName = "Interest"
            Me.colInterest.Name = "colInterest"
            Me.colInterest.Visible = True
            Me.colInterest.VisibleIndex = 18
            '
            'colPrincipalBalance
            '
            Me.colPrincipalBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalBalance.FieldName = "PrincipalBalance"
            Me.colPrincipalBalance.Name = "colPrincipalBalance"
            Me.colPrincipalBalance.Visible = True
            Me.colPrincipalBalance.VisibleIndex = 19
            '
            'colInterestBalance
            '
            Me.colInterestBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestBalance.FieldName = "InterestBalance"
            Me.colInterestBalance.Name = "colInterestBalance"
            Me.colInterestBalance.Visible = True
            Me.colInterestBalance.VisibleIndex = 20
            '
            'colPostingDate
            '
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 21
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 22
            '
            'colTransactedBy
            '
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 23
            '
            'colNote
            '
            Me.colNote.Caption = "Notes"
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 24
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'frm_Credit_Memo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(639, 536)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Credit_Memo"
            Me.Text = "Credit Memo"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.DockPanel1.ResumeLayout(False)
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReleaseType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReferenceNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountPaid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents Bar_Custom As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Posting_Date As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Posting_Date As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_Reason As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemTextEdit_Reason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents btn_Journal_Entries2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents BarToggleSwitchItem_Custom_Posting_Date As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace