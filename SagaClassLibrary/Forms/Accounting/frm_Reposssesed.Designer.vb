Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Reposssesed
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
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.BarToggleSwitchItem_Custom_Posting_Date = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.BarEditItem_Posting_Date = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Posting_Date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_Reason = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemTextEdit_Reason = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Account_Ledger = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Ledger()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSequenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMnemonic = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colErrorCorrectTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReferenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBeginningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCredit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutsBal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar3, Me.Bar4})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Journal, Me.btn_Stop, Me.barEditItem_Branch, Me.btn_Journal_Entries, Me.btn_Verify, Me.BarToggleSwitchItem_Custom_Posting_Date, Me.BarEditItem_Posting_Date, Me.BarEditItem_Reason})
            Me.barManager.MaxItemId = 18
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemDateEdit_Posting_Date, Me.RepositoryItemTextEdit_Reason})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(193, 135)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch, True)})
            Me.bar2.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 12
            Me.barEditItem_Branch.ImageOptions.ImageIndex = 9
            Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 9
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
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
            'Bar4
            '
            Me.Bar4.BarName = "Posting Date"
            Me.Bar4.DockCol = 0
            Me.Bar4.DockRow = 2
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarToggleSwitchItem_Custom_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Reason)})
            Me.Bar4.Text = "Posting Date"
            '
            'BarToggleSwitchItem_Custom_Posting_Date
            '
            Me.BarToggleSwitchItem_Custom_Posting_Date.Caption = "Custom Posting Date"
            Me.BarToggleSwitchItem_Custom_Posting_Date.Id = 15
            Me.BarToggleSwitchItem_Custom_Posting_Date.Name = "BarToggleSwitchItem_Custom_Posting_Date"
            '
            'BarEditItem_Posting_Date
            '
            Me.BarEditItem_Posting_Date.Caption = "Posting Date"
            Me.BarEditItem_Posting_Date.Edit = Me.RepositoryItemDateEdit_Posting_Date
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
            Me.barDockControlTop.Size = New System.Drawing.Size(860, 62)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 535)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(860, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 473)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(860, 62)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 473)
            '
            'DockManager
            '
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("7eb7fa0b-859a-4f98-822b-e6bb6aa559f0")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 62)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(250, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(250, 473)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Account_Ledger)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(243, 444)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Account_Ledger
            '
            Me.xuc_Account_Ledger.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Ledger.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Ledger.Name = "xuc_Account_Ledger"
            Me.xuc_Account_Ledger.Size = New System.Drawing.Size(243, 444)
            Me.xuc_Account_Ledger.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("59adb004-a0f5-4d0c-918c-de03be5fa91d")
            Me.DockPanel2.Location = New System.Drawing.Point(580, 62)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 473)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 444)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 444)
            Me.xuc_Settings.TabIndex = 0
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(250, 62)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(330, 473)
            Me.gridControl.TabIndex = 17
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsJournal, Me.colSequenceNumber, Me.colBranchCode, Me.colCORP, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountName, Me.colBrand, Me.colEngineNo, Me.colwhCode, Me.colSaleType, Me.colTransCode, Me.colPostingDate, Me.colTransactionDate, Me.colLedgerType, Me.colMnemonic, Me.colErrorCorrectTag, Me.colReferenceNumber, Me.colORNumber, Me.colBeginningBalance, Me.colDebit, Me.colCredit, Me.colTotalAmount, Me.colEndingBalance, Me.colOutsBal, Me.colRemarks, Me.colNote, Me.colTransactedBy})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 0
            '
            'colSequenceNumber
            '
            Me.colSequenceNumber.Caption = "ID"
            Me.colSequenceNumber.FieldName = "SequenceNumber"
            Me.colSequenceNumber.Name = "colSequenceNumber"
            Me.colSequenceNumber.Visible = True
            Me.colSequenceNumber.VisibleIndex = 1
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 2
            '
            'colCORP
            '
            Me.colCORP.Caption = "Corporation"
            Me.colCORP.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colCORP.FieldName = "CORP"
            Me.colCORP.Name = "colCORP"
            Me.colCORP.Visible = True
            Me.colCORP.VisibleIndex = 3
            '
            'colAccountNumber
            '
            Me.colAccountNumber.Caption = "Account"
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 4
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 5
            '
            'colAccountName
            '
            Me.colAccountName.Caption = "Account Name"
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 6
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 7
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 8
            '
            'colwhCode
            '
            Me.colwhCode.Caption = "Warehouse"
            Me.colwhCode.FieldName = "whCode"
            Me.colwhCode.Name = "colwhCode"
            Me.colwhCode.Visible = True
            Me.colwhCode.VisibleIndex = 9
            '
            'colSaleType
            '
            Me.colSaleType.Caption = "Sale Type"
            Me.colSaleType.FieldName = "SaleType"
            Me.colSaleType.Name = "colSaleType"
            Me.colSaleType.Visible = True
            Me.colSaleType.VisibleIndex = 10
            '
            'colTransCode
            '
            Me.colTransCode.Caption = "Transaction"
            Me.colTransCode.FieldName = "TransCode"
            Me.colTransCode.Name = "colTransCode"
            Me.colTransCode.Visible = True
            Me.colTransCode.VisibleIndex = 11
            '
            'colPostingDate
            '
            Me.colPostingDate.Caption = "Posted"
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 12
            '
            'colTransactionDate
            '
            Me.colTransactionDate.Caption = "Transacted"
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 13
            '
            'colLedgerType
            '
            Me.colLedgerType.Caption = "Ledger Type"
            Me.colLedgerType.FieldName = "LedgerType"
            Me.colLedgerType.Name = "colLedgerType"
            Me.colLedgerType.Visible = True
            Me.colLedgerType.VisibleIndex = 14
            '
            'colMnemonic
            '
            Me.colMnemonic.Caption = "Mnemonic"
            Me.colMnemonic.FieldName = "Mnemonic"
            Me.colMnemonic.Name = "colMnemonic"
            Me.colMnemonic.Visible = True
            Me.colMnemonic.VisibleIndex = 15
            '
            'colErrorCorrectTag
            '
            Me.colErrorCorrectTag.Caption = "Error"
            Me.colErrorCorrectTag.FieldName = "ErrorCorrectTag"
            Me.colErrorCorrectTag.Name = "colErrorCorrectTag"
            Me.colErrorCorrectTag.Visible = True
            Me.colErrorCorrectTag.VisibleIndex = 16
            '
            'colReferenceNumber
            '
            Me.colReferenceNumber.Caption = "Reference"
            Me.colReferenceNumber.FieldName = "ReferenceNumber"
            Me.colReferenceNumber.Name = "colReferenceNumber"
            Me.colReferenceNumber.Visible = True
            Me.colReferenceNumber.VisibleIndex = 17
            '
            'colORNumber
            '
            Me.colORNumber.Caption = "OR Number"
            Me.colORNumber.FieldName = "ORNumber"
            Me.colORNumber.Name = "colORNumber"
            Me.colORNumber.Visible = True
            Me.colORNumber.VisibleIndex = 18
            '
            'colBeginningBalance
            '
            Me.colBeginningBalance.Caption = "Balance 1"
            Me.colBeginningBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginningBalance.FieldName = "BeginningBalance"
            Me.colBeginningBalance.Name = "colBeginningBalance"
            Me.colBeginningBalance.Visible = True
            Me.colBeginningBalance.VisibleIndex = 19
            '
            'colDebit
            '
            Me.colDebit.Caption = "Debit"
            Me.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDebit.FieldName = "Debit"
            Me.colDebit.Name = "colDebit"
            Me.colDebit.Visible = True
            Me.colDebit.VisibleIndex = 20
            '
            'colCredit
            '
            Me.colCredit.Caption = "Credit"
            Me.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCredit.FieldName = "Credit"
            Me.colCredit.Name = "colCredit"
            Me.colCredit.Visible = True
            Me.colCredit.VisibleIndex = 21
            '
            'colTotalAmount
            '
            Me.colTotalAmount.Caption = "Total"
            Me.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalAmount.FieldName = "TotalAmount"
            Me.colTotalAmount.Name = "colTotalAmount"
            Me.colTotalAmount.Visible = True
            Me.colTotalAmount.VisibleIndex = 22
            '
            'colEndingBalance
            '
            Me.colEndingBalance.Caption = "Balance 2"
            Me.colEndingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEndingBalance.FieldName = "EndingBalance"
            Me.colEndingBalance.Name = "colEndingBalance"
            Me.colEndingBalance.Visible = True
            Me.colEndingBalance.VisibleIndex = 23
            '
            'colOutsBal
            '
            Me.colOutsBal.Caption = "Balance 3"
            Me.colOutsBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutsBal.FieldName = "OutsBal"
            Me.colOutsBal.Name = "colOutsBal"
            Me.colOutsBal.Visible = True
            Me.colOutsBal.VisibleIndex = 24
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 25
            '
            'colNote
            '
            Me.colNote.Caption = "Notes"
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 26
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Added By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 27
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'frm_Reposssesed
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(860, 535)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Reposssesed"
            Me.Text = "Reposssesed (DEPO to REPO)"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Reason, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents BarToggleSwitchItem_Custom_Posting_Date As DevExpress.XtraBars.BarToggleSwitchItem
        Friend WithEvents BarEditItem_Posting_Date As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Posting_Date As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_Reason As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemTextEdit_Reason As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents xuc_Account_Ledger As Controls.Information.Account.xuc_Account_Ledger
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colSequenceNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMnemonic As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colErrorCorrectTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBeginningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCredit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndingBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutsBal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReferenceNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace