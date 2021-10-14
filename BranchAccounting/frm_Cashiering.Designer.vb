Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Cashiering
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
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Parameters = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.coAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPayment_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOR_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount_Paid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNoVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Is_Journal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Branch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Account = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Ledger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Amount_Paid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Posting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Added_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Added_By = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Journal, Me.Bar_Parameters})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.DockManager = Me.DockManager
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Close, Me.btn_Journal, Me.btn_Journal_Entries, Me.btn_Stop, Me.BarEditItem_Search, Me.btn_Verify, Me.BarEditItem_Corporation})
            Me.BarManager.MaxItemId = 14
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Corporation})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 1
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar_Actions.Offset = 172
            Me.Bar_Actions.Text = "Actions"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 1
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 2
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 0
            Me.Bar_Journal.DockRow = 1
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar_Journal.Text = "Journal"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 3
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 4
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 12
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 5
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar_Parameters
            '
            Me.Bar_Parameters.BarName = "Parameters"
            Me.Bar_Parameters.DockCol = 0
            Me.Bar_Parameters.DockRow = 0
            Me.Bar_Parameters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Parameters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.Bar_Parameters.Text = "Parameters"
            '
            'BarEditItem_Corporation
            '
            Me.BarEditItem_Corporation.Caption = "Corporation"
            Me.BarEditItem_Corporation.Edit = Me.RepositoryItemLookUpEdit_Corporation
            Me.BarEditItem_Corporation.Id = 13
            Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(660, 41)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 500)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(660, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 459)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(660, 41)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 459)
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.BarManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 41)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 459)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("6594afc0-5ad7-4c08-ab6c-90e0521074fa")
            Me.DockPanel1.Location = New System.Drawing.Point(21, 41)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(200, 459)
            Me.DockPanel1.Text = "Information"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 430)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("8e8a00fe-2156-4f6e-ae62-5f73dd610c6f")
            Me.DockPanel2.Location = New System.Drawing.Point(390, 41)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(270, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 459)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(263, 430)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 430)
            Me.xuc_Settings.TabIndex = 0
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(21, 41)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(369, 459)
            Me.gridControl.TabIndex = 11
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colBranch_Code, Me.colAccount_Code, Me.coAccount_Name, Me.colAccount_Address, Me.colPayment_Code, Me.colTransaction_Type, Me.colInvoice_Type, Me.colReference, Me.colOR_Code, Me.colAmount_Paid, Me.colVAT, Me.colNoVAT, Me.colDiscount, Me.colTotal, Me.colPosting_Date, Me.colTransactionDate, Me.colTransactedBy, Me.colNotes, Me.colIBP_ID, Me.colIBP_Is_Journal, Me.colIBP_Branch_Code, Me.colIBP_Account, Me.colIBP_Ledger, Me.colIBP_Amount_Paid, Me.colIBP_Posting_Date, Me.colIBP_Added_Date, Me.colIBP_Added_By})
            Me.gridView.GridControl = Me.gridControl
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
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 2
            '
            'colAccount_Code
            '
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 3
            '
            'coAccount_Name
            '
            Me.coAccount_Name.FieldName = "Account_Name"
            Me.coAccount_Name.Name = "coAccount_Name"
            Me.coAccount_Name.Visible = True
            Me.coAccount_Name.VisibleIndex = 4
            '
            'colAccount_Address
            '
            Me.colAccount_Address.FieldName = "Account_Address"
            Me.colAccount_Address.Name = "colAccount_Address"
            Me.colAccount_Address.Visible = True
            Me.colAccount_Address.VisibleIndex = 5
            '
            'colPayment_Code
            '
            Me.colPayment_Code.FieldName = "Payment_Code"
            Me.colPayment_Code.Name = "colPayment_Code"
            Me.colPayment_Code.Visible = True
            Me.colPayment_Code.VisibleIndex = 7
            '
            'colTransaction_Type
            '
            Me.colTransaction_Type.FieldName = "Transaction_Type"
            Me.colTransaction_Type.Name = "colTransaction_Type"
            Me.colTransaction_Type.Visible = True
            Me.colTransaction_Type.VisibleIndex = 8
            '
            'colInvoice_Type
            '
            Me.colInvoice_Type.FieldName = "Invoice_Type"
            Me.colInvoice_Type.Name = "colInvoice_Type"
            Me.colInvoice_Type.Visible = True
            Me.colInvoice_Type.VisibleIndex = 9
            '
            'colReference
            '
            Me.colReference.FieldName = "Reference"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 10
            '
            'colOR_Code
            '
            Me.colOR_Code.FieldName = "OR_Code"
            Me.colOR_Code.Name = "colOR_Code"
            Me.colOR_Code.Visible = True
            Me.colOR_Code.VisibleIndex = 11
            '
            'colAmount_Paid
            '
            Me.colAmount_Paid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmount_Paid.FieldName = "Amount_Paid"
            Me.colAmount_Paid.Name = "colAmount_Paid"
            Me.colAmount_Paid.Visible = True
            Me.colAmount_Paid.VisibleIndex = 12
            '
            'colVAT
            '
            Me.colVAT.Caption = "VAT"
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VAT"
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 13
            '
            'colNoVAT
            '
            Me.colNoVAT.Caption = "Net VAT"
            Me.colNoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNoVAT.FieldName = "NoVAT"
            Me.colNoVAT.Name = "colNoVAT"
            Me.colNoVAT.Visible = True
            Me.colNoVAT.VisibleIndex = 14
            '
            'colDiscount
            '
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 15
            '
            'colTotal
            '
            Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal.FieldName = "Total"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 16
            '
            'colPosting_Date
            '
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 17
            '
            'colTransactionDate
            '
            Me.colTransactionDate.Caption = "Transaction Date"
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 18
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Transacted By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 19
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 20
            '
            'colIBP_ID
            '
            Me.colIBP_ID.FieldName = "IBP_ID"
            Me.colIBP_ID.Name = "colIBP_ID"
            Me.colIBP_ID.Visible = True
            Me.colIBP_ID.VisibleIndex = 21
            '
            'colIBP_Is_Journal
            '
            Me.colIBP_Is_Journal.FieldName = "IBP_Is_Journal"
            Me.colIBP_Is_Journal.Name = "colIBP_Is_Journal"
            Me.colIBP_Is_Journal.Visible = True
            Me.colIBP_Is_Journal.VisibleIndex = 6
            '
            'colIBP_Branch_Code
            '
            Me.colIBP_Branch_Code.FieldName = "IBP_Branch_Code"
            Me.colIBP_Branch_Code.Name = "colIBP_Branch_Code"
            Me.colIBP_Branch_Code.Visible = True
            Me.colIBP_Branch_Code.VisibleIndex = 22
            '
            'colIBP_Account
            '
            Me.colIBP_Account.FieldName = "IBP_Account"
            Me.colIBP_Account.Name = "colIBP_Account"
            Me.colIBP_Account.Visible = True
            Me.colIBP_Account.VisibleIndex = 23
            '
            'colIBP_Ledger
            '
            Me.colIBP_Ledger.FieldName = "IBP_Ledger"
            Me.colIBP_Ledger.Name = "colIBP_Ledger"
            Me.colIBP_Ledger.Visible = True
            Me.colIBP_Ledger.VisibleIndex = 24
            '
            'colIBP_Amount_Paid
            '
            Me.colIBP_Amount_Paid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIBP_Amount_Paid.FieldName = "IBP_Amount_Paid"
            Me.colIBP_Amount_Paid.Name = "colIBP_Amount_Paid"
            Me.colIBP_Amount_Paid.Visible = True
            Me.colIBP_Amount_Paid.VisibleIndex = 25
            '
            'colIBP_Posting_Date
            '
            Me.colIBP_Posting_Date.FieldName = "IBP_Posting_Date"
            Me.colIBP_Posting_Date.Name = "colIBP_Posting_Date"
            Me.colIBP_Posting_Date.Visible = True
            Me.colIBP_Posting_Date.VisibleIndex = 26
            '
            'colIBP_Added_Date
            '
            Me.colIBP_Added_Date.FieldName = "IBP_Added_Date"
            Me.colIBP_Added_Date.Name = "colIBP_Added_Date"
            Me.colIBP_Added_Date.Visible = True
            Me.colIBP_Added_Date.VisibleIndex = 27
            '
            'colIBP_Added_By
            '
            Me.colIBP_Added_By.FieldName = "IBP_Added_By"
            Me.colIBP_Added_By.Name = "colIBP_Added_By"
            Me.colIBP_Added_By.Visible = True
            Me.colIBP_Added_By.VisibleIndex = 28
            '
            'frm_Cashiering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(660, 500)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Cashiering"
            Me.Text = "Branch Cashiering"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents coAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPayment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOR_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNoVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Is_Journal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Branch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Account As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Ledger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Amount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Posting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Added_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Added_By As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace