Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm_MC_Sale
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
            Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.Btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Parameters = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.BarEditItem_Start = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_End = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.Btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colsequenceNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReleaseType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIFKey = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountExecutive = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOfficerName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgentCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgentName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colunitcost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colvatamt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.coltotalcost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscAmt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinancedAmt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCRNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateGranted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMaturityDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastMvmtDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIntRatePerAnnum = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutstandingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrevID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrevBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrevAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrevAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Journal, Me.Bar_Parameters})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Reload, Me.Btn_Preview, Me.Btn_Close, Me.Btn_Journal, Me.Btn_Journal_Entries, Me.Btn_Stop, Me.BarEditItem_Branch, Me.BarEditItem_Search, Me.BarEditItem_Start, Me.BarEditItem_End, Me.BarEditItem_Corporation, Me.Btn_Verify})
            Me.BarManager.MaxItemId = 13
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemDateEdit_Start, Me.RepositoryItemDateEdit_End, Me.RepositoryItemComboBox_Corporation})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.Bar_Actions.Text = "Actions"
            '
            'Btn_Reload
            '
            Me.Btn_Reload.Caption = "Reload"
            Me.Btn_Reload.Id = 0
            Me.Btn_Reload.Name = "Btn_Reload"
            '
            'Btn_Preview
            '
            Me.Btn_Preview.Caption = "Preview"
            Me.Btn_Preview.Id = 1
            Me.Btn_Preview.Name = "Btn_Preview"
            '
            'Btn_Close
            '
            Me.Btn_Close.Caption = "Close"
            Me.Btn_Close.Id = 2
            Me.Btn_Close.Name = "Btn_Close"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 0
            Me.Bar_Journal.DockRow = 1
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop, True)})
            Me.Bar_Journal.Text = "Journal"
            '
            'Btn_Journal
            '
            Me.Btn_Journal.Caption = "Journal"
            Me.Btn_Journal.Id = 3
            Me.Btn_Journal.Name = "Btn_Journal"
            '
            'Btn_Journal_Entries
            '
            Me.Btn_Journal_Entries.Caption = "Journal Entries"
            Me.Btn_Journal_Entries.Id = 4
            Me.Btn_Journal_Entries.Name = "Btn_Journal_Entries"
            '
            'Btn_Stop
            '
            Me.Btn_Stop.Caption = "Stop"
            Me.Btn_Stop.Id = 5
            Me.Btn_Stop.Name = "Btn_Stop"
            '
            'Bar_Parameters
            '
            Me.Bar_Parameters.BarName = "Parameters"
            Me.Bar_Parameters.DockCol = 0
            Me.Bar_Parameters.DockRow = 0
            Me.Bar_Parameters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Parameters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Start), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_End)})
            Me.Bar_Parameters.Text = "Parameters"
            '
            'BarEditItem_Corporation
            '
            Me.BarEditItem_Corporation.Caption = "Corporation"
            Me.BarEditItem_Corporation.Edit = Me.RepositoryItemComboBox_Corporation
            Me.BarEditItem_Corporation.Id = 11
            Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
            '
            'RepositoryItemComboBox_Corporation
            '
            Me.RepositoryItemComboBox_Corporation.AutoHeight = False
            Me.RepositoryItemComboBox_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Corporation.Items.AddRange(New Object() {"SFC", "SMC"})
            Me.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation"
            Me.RepositoryItemComboBox_Corporation.Sorted = True
            Me.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Branch
            '
            Me.BarEditItem_Branch.Caption = "Branch"
            Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.BarEditItem_Branch.Id = 7
            Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
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
            Me.BarEditItem_Search.Id = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'BarEditItem_Start
            '
            Me.BarEditItem_Start.Caption = "Start"
            Me.BarEditItem_Start.Edit = Me.RepositoryItemDateEdit_Start
            Me.BarEditItem_Start.Id = 9
            Me.BarEditItem_Start.Name = "BarEditItem_Start"
            '
            'RepositoryItemDateEdit_Start
            '
            Me.RepositoryItemDateEdit_Start.AutoHeight = False
            Me.RepositoryItemDateEdit_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.Name = "RepositoryItemDateEdit_Start"
            '
            'BarEditItem_End
            '
            Me.BarEditItem_End.Caption = "End"
            Me.BarEditItem_End.Edit = Me.RepositoryItemDateEdit_End
            Me.BarEditItem_End.Id = 10
            Me.BarEditItem_End.Name = "BarEditItem_End"
            '
            'RepositoryItemDateEdit_End
            '
            Me.RepositoryItemDateEdit_End.AutoHeight = False
            Me.RepositoryItemDateEdit_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.Name = "RepositoryItemDateEdit_End"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(763, 41)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 433)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(763, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 392)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(763, 41)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 392)
            '
            'Btn_Verify
            '
            Me.Btn_Verify.Caption = "Verify"
            Me.Btn_Verify.Id = 12
            Me.Btn_Verify.Name = "Btn_Verify"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'GridControl
            '
            Me.GridControl.DataMember = "Query"
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 41)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
            Me.GridControl.Size = New System.Drawing.Size(763, 392)
            Me.GridControl.TabIndex = 10
            Me.GridControl.UseEmbeddedNavigator = True
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsequenceNo, Me.colIsJournal, Me.colBranchCode, Me.colCORP, Me.colReleaseType, Me.colwhCode, Me.colSaleType, Me.colTag, Me.colCIFKey, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountStatus, Me.colAccountName, Me.colAccountAddress, Me.colAccountExecutive, Me.colOfficerName, Me.colAgentCode, Me.colAgentName, Me.colCode, Me.colBrand, Me.colModel, Me.colColor, Me.colKeyNo, Me.colEngineNo, Me.colChassisNo, Me.colunitcost, Me.colvatamt, Me.coltotalcost, Me.colCOD, Me.colLCP, Me.colDiscAmt, Me.colFinancedAmt, Me.colDP, Me.colAOC, Me.colCRNo, Me.colORNo, Me.colTerms, Me.colInterestRate, Me.colDateGranted, Me.colMaturityDate, Me.colFirstPayDate, Me.colLastMvmtDate, Me.colIntRatePerAnnum, Me.colPrincipalPMT, Me.colInterestPMT, Me.colPMT, Me.colRebates, Me.colPrincipalBalance, Me.colInterestBalance, Me.colOutstandingBalance, Me.colTransactedBy, Me.colRemarks, Me.colPrevID, Me.colPrevBranchCode, Me.colPrevAccountNumber, Me.colPrevAccountName})
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            Me.GridView.OptionsView.ColumnAutoWidth = False
            '
            'colsequenceNo
            '
            Me.colsequenceNo.Caption = "ID"
            Me.colsequenceNo.FieldName = "sequenceNo"
            Me.colsequenceNo.Name = "colsequenceNo"
            Me.colsequenceNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sequenceNo", "{N1}")})
            Me.colsequenceNo.Visible = True
            Me.colsequenceNo.VisibleIndex = 0
            '
            'colIsJournal
            '
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.ColumnEdit = Me.RepositoryItemLookUpEdit1
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 2
            '
            'RepositoryItemLookUpEdit1
            '
            Me.RepositoryItemLookUpEdit1.AutoHeight = False
            Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
            '
            'colCORP
            '
            Me.colCORP.Caption = "Corporation"
            Me.colCORP.FieldName = "CORP"
            Me.colCORP.Name = "colCORP"
            Me.colCORP.Visible = True
            Me.colCORP.VisibleIndex = 3
            '
            'colReleaseType
            '
            Me.colReleaseType.Caption = "Release Type"
            Me.colReleaseType.FieldName = "ReleaseType"
            Me.colReleaseType.Name = "colReleaseType"
            Me.colReleaseType.Visible = True
            Me.colReleaseType.VisibleIndex = 4
            '
            'colwhCode
            '
            Me.colwhCode.Caption = "Warehouse"
            Me.colwhCode.FieldName = "whCode"
            Me.colwhCode.Name = "colwhCode"
            Me.colwhCode.Visible = True
            Me.colwhCode.VisibleIndex = 5
            '
            'colSaleType
            '
            Me.colSaleType.Caption = "Sale Type"
            Me.colSaleType.FieldName = "SaleType"
            Me.colSaleType.Name = "colSaleType"
            Me.colSaleType.Visible = True
            Me.colSaleType.VisibleIndex = 6
            '
            'colTag
            '
            Me.colTag.Caption = "Tag"
            Me.colTag.FieldName = "Tag"
            Me.colTag.Name = "colTag"
            Me.colTag.Visible = True
            Me.colTag.VisibleIndex = 7
            '
            'colCIFKey
            '
            Me.colCIFKey.Caption = "CIF Key"
            Me.colCIFKey.FieldName = "CIFKey"
            Me.colCIFKey.Name = "colCIFKey"
            Me.colCIFKey.Visible = True
            Me.colCIFKey.VisibleIndex = 8
            '
            'colAccountNumber
            '
            Me.colAccountNumber.Caption = "Account"
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 9
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 10
            '
            'colAccountStatus
            '
            Me.colAccountStatus.Caption = "Status"
            Me.colAccountStatus.FieldName = "AccountStatus"
            Me.colAccountStatus.Name = "colAccountStatus"
            Me.colAccountStatus.Visible = True
            Me.colAccountStatus.VisibleIndex = 11
            '
            'colAccountName
            '
            Me.colAccountName.Caption = "Name"
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 12
            '
            'colAccountAddress
            '
            Me.colAccountAddress.Caption = "Address"
            Me.colAccountAddress.FieldName = "AccountAddress"
            Me.colAccountAddress.Name = "colAccountAddress"
            Me.colAccountAddress.Visible = True
            Me.colAccountAddress.VisibleIndex = 13
            '
            'colAccountExecutive
            '
            Me.colAccountExecutive.Caption = "Account Executive"
            Me.colAccountExecutive.FieldName = "AccountExecutive"
            Me.colAccountExecutive.Name = "colAccountExecutive"
            Me.colAccountExecutive.Visible = True
            Me.colAccountExecutive.VisibleIndex = 14
            '
            'colOfficerName
            '
            Me.colOfficerName.Caption = "Officer Name"
            Me.colOfficerName.FieldName = "OfficerName"
            Me.colOfficerName.Name = "colOfficerName"
            Me.colOfficerName.Visible = True
            Me.colOfficerName.VisibleIndex = 15
            '
            'colAgentCode
            '
            Me.colAgentCode.Caption = "Agent Code"
            Me.colAgentCode.FieldName = "AgentCode"
            Me.colAgentCode.Name = "colAgentCode"
            Me.colAgentCode.Visible = True
            Me.colAgentCode.VisibleIndex = 16
            '
            'colAgentName
            '
            Me.colAgentName.Caption = "Agent Name"
            Me.colAgentName.FieldName = "AgentName"
            Me.colAgentName.Name = "colAgentName"
            Me.colAgentName.Visible = True
            Me.colAgentName.VisibleIndex = 17
            '
            'colCode
            '
            Me.colCode.Caption = "Product Code"
            Me.colCode.FieldName = "Code"
            Me.colCode.Name = "colCode"
            Me.colCode.Visible = True
            Me.colCode.VisibleIndex = 18
            '
            'colBrand
            '
            Me.colBrand.Caption = "Brand"
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 19
            '
            'colModel
            '
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 20
            '
            'colColor
            '
            Me.colColor.Caption = "Color"
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 21
            '
            'colKeyNo
            '
            Me.colKeyNo.Caption = "Key"
            Me.colKeyNo.FieldName = "KeyNo"
            Me.colKeyNo.Name = "colKeyNo"
            Me.colKeyNo.Visible = True
            Me.colKeyNo.VisibleIndex = 22
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 23
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 24
            '
            'colunitcost
            '
            Me.colunitcost.Caption = "Unit Cost"
            Me.colunitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colunitcost.FieldName = "unitcost"
            Me.colunitcost.Name = "colunitcost"
            Me.colunitcost.Visible = True
            Me.colunitcost.VisibleIndex = 25
            '
            'colvatamt
            '
            Me.colvatamt.Caption = "VAT"
            Me.colvatamt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colvatamt.FieldName = "vatamt"
            Me.colvatamt.Name = "colvatamt"
            Me.colvatamt.Visible = True
            Me.colvatamt.VisibleIndex = 26
            '
            'coltotalcost
            '
            Me.coltotalcost.Caption = "Total Cost"
            Me.coltotalcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.coltotalcost.FieldName = "totalcost"
            Me.coltotalcost.Name = "coltotalcost"
            Me.coltotalcost.Visible = True
            Me.coltotalcost.VisibleIndex = 27
            '
            'colCOD
            '
            Me.colCOD.Caption = "COD"
            Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCOD.FieldName = "COD"
            Me.colCOD.Name = "colCOD"
            Me.colCOD.Visible = True
            Me.colCOD.VisibleIndex = 28
            '
            'colLCP
            '
            Me.colLCP.Caption = "LCP"
            Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLCP.FieldName = "LCP"
            Me.colLCP.Name = "colLCP"
            Me.colLCP.Visible = True
            Me.colLCP.VisibleIndex = 29
            '
            'colDiscAmt
            '
            Me.colDiscAmt.Caption = "Discount"
            Me.colDiscAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscAmt.FieldName = "DiscAmt"
            Me.colDiscAmt.Name = "colDiscAmt"
            Me.colDiscAmt.Visible = True
            Me.colDiscAmt.VisibleIndex = 30
            '
            'colFinancedAmt
            '
            Me.colFinancedAmt.Caption = "Finance"
            Me.colFinancedAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFinancedAmt.FieldName = "FinancedAmt"
            Me.colFinancedAmt.Name = "colFinancedAmt"
            Me.colFinancedAmt.Visible = True
            Me.colFinancedAmt.VisibleIndex = 31
            '
            'colDP
            '
            Me.colDP.Caption = "Down Payment"
            Me.colDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDP.FieldName = "DP"
            Me.colDP.Name = "colDP"
            Me.colDP.Visible = True
            Me.colDP.VisibleIndex = 32
            '
            'colAOC
            '
            Me.colAOC.Caption = "AOC"
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 33
            '
            'colCRNo
            '
            Me.colCRNo.Caption = "CR Number"
            Me.colCRNo.FieldName = "CRNo"
            Me.colCRNo.Name = "colCRNo"
            Me.colCRNo.Visible = True
            Me.colCRNo.VisibleIndex = 34
            '
            'colORNo
            '
            Me.colORNo.Caption = "OR Number"
            Me.colORNo.FieldName = "ORNo"
            Me.colORNo.Name = "colORNo"
            Me.colORNo.Visible = True
            Me.colORNo.VisibleIndex = 35
            '
            'colTerms
            '
            Me.colTerms.Caption = "Terms"
            Me.colTerms.FieldName = "Terms"
            Me.colTerms.Name = "colTerms"
            Me.colTerms.Visible = True
            Me.colTerms.VisibleIndex = 36
            '
            'colInterestRate
            '
            Me.colInterestRate.Caption = "Rate"
            Me.colInterestRate.FieldName = "InterestRate"
            Me.colInterestRate.Name = "colInterestRate"
            Me.colInterestRate.Visible = True
            Me.colInterestRate.VisibleIndex = 37
            '
            'colDateGranted
            '
            Me.colDateGranted.Caption = "Granted"
            Me.colDateGranted.FieldName = "DateGranted"
            Me.colDateGranted.Name = "colDateGranted"
            Me.colDateGranted.Visible = True
            Me.colDateGranted.VisibleIndex = 38
            '
            'colMaturityDate
            '
            Me.colMaturityDate.Caption = "Maturity"
            Me.colMaturityDate.FieldName = "MaturityDate"
            Me.colMaturityDate.Name = "colMaturityDate"
            Me.colMaturityDate.Visible = True
            Me.colMaturityDate.VisibleIndex = 39
            '
            'colFirstPayDate
            '
            Me.colFirstPayDate.Caption = "First Payment"
            Me.colFirstPayDate.FieldName = "FirstPayDate"
            Me.colFirstPayDate.Name = "colFirstPayDate"
            Me.colFirstPayDate.Visible = True
            Me.colFirstPayDate.VisibleIndex = 40
            '
            'colLastMvmtDate
            '
            Me.colLastMvmtDate.Caption = "Last Update"
            Me.colLastMvmtDate.FieldName = "LastMvmtDate"
            Me.colLastMvmtDate.Name = "colLastMvmtDate"
            Me.colLastMvmtDate.Visible = True
            Me.colLastMvmtDate.VisibleIndex = 41
            '
            'colIntRatePerAnnum
            '
            Me.colIntRatePerAnnum.Caption = "Rate per Annum"
            Me.colIntRatePerAnnum.FieldName = "IntRatePerAnnum"
            Me.colIntRatePerAnnum.Name = "colIntRatePerAnnum"
            Me.colIntRatePerAnnum.Visible = True
            Me.colIntRatePerAnnum.VisibleIndex = 42
            '
            'colPrincipalPMT
            '
            Me.colPrincipalPMT.Caption = "Monthly Principal"
            Me.colPrincipalPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalPMT.FieldName = "PrincipalPMT"
            Me.colPrincipalPMT.Name = "colPrincipalPMT"
            Me.colPrincipalPMT.Visible = True
            Me.colPrincipalPMT.VisibleIndex = 43
            '
            'colInterestPMT
            '
            Me.colInterestPMT.Caption = "Monthly Interest"
            Me.colInterestPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestPMT.FieldName = "InterestPMT"
            Me.colInterestPMT.Name = "colInterestPMT"
            Me.colInterestPMT.Visible = True
            Me.colInterestPMT.VisibleIndex = 44
            '
            'colPMT
            '
            Me.colPMT.Caption = "Amortization"
            Me.colPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPMT.FieldName = "PMT"
            Me.colPMT.Name = "colPMT"
            Me.colPMT.Visible = True
            Me.colPMT.VisibleIndex = 45
            '
            'colRebates
            '
            Me.colRebates.Caption = "Rebate"
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 46
            '
            'colPrincipalBalance
            '
            Me.colPrincipalBalance.Caption = "Principal"
            Me.colPrincipalBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalBalance.FieldName = "PrincipalBalance"
            Me.colPrincipalBalance.Name = "colPrincipalBalance"
            Me.colPrincipalBalance.Visible = True
            Me.colPrincipalBalance.VisibleIndex = 47
            '
            'colInterestBalance
            '
            Me.colInterestBalance.Caption = "Interest"
            Me.colInterestBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestBalance.FieldName = "InterestBalance"
            Me.colInterestBalance.Name = "colInterestBalance"
            Me.colInterestBalance.Visible = True
            Me.colInterestBalance.VisibleIndex = 48
            '
            'colOutstandingBalance
            '
            Me.colOutstandingBalance.Caption = "Balance"
            Me.colOutstandingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutstandingBalance.FieldName = "OutstandingBalance"
            Me.colOutstandingBalance.Name = "colOutstandingBalance"
            Me.colOutstandingBalance.Visible = True
            Me.colOutstandingBalance.VisibleIndex = 49
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Added By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 50
            '
            'colRemarks
            '
            Me.colRemarks.Caption = "Notes"
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 51
            '
            'colPrevID
            '
            Me.colPrevID.Caption = "Inventory ID"
            Me.colPrevID.FieldName = "id"
            Me.colPrevID.Name = "colPrevID"
            Me.colPrevID.Visible = True
            Me.colPrevID.VisibleIndex = 52
            '
            'colPrevBranchCode
            '
            Me.colPrevBranchCode.Caption = "Previous Branch"
            Me.colPrevBranchCode.ColumnEdit = Me.RepositoryItemLookUpEdit1
            Me.colPrevBranchCode.FieldName = "PrevBranchCode"
            Me.colPrevBranchCode.Name = "colPrevBranchCode"
            Me.colPrevBranchCode.Visible = True
            Me.colPrevBranchCode.VisibleIndex = 53
            '
            'colPrevAccountNumber
            '
            Me.colPrevAccountNumber.Caption = "Previous Account"
            Me.colPrevAccountNumber.FieldName = "PrevAccountNumber"
            Me.colPrevAccountNumber.Name = "colPrevAccountNumber"
            Me.colPrevAccountNumber.Visible = True
            Me.colPrevAccountNumber.VisibleIndex = 54
            '
            'colPrevAccountName
            '
            Me.colPrevAccountName.Caption = "Previous Owner"
            Me.colPrevAccountName.FieldName = "PrevAccountName"
            Me.colPrevAccountName.Name = "colPrevAccountName"
            Me.colPrevAccountName.Visible = True
            Me.colPrevAccountName.VisibleIndex = 55
            '
            'XtraForm_MC_Sale
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(763, 433)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm_MC_Sale"
            Me.Text = "XtraForm_MC_Sale"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents BarEditItem_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents Btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colsequenceNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReleaseType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIFKey As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountExecutive As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOfficerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgentCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgentName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKeyNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colunitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colvatamt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents coltotalcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscAmt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFinancedAmt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCRNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateGranted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMaturityDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFirstPayDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLastMvmtDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIntRatePerAnnum As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutstandingBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrevID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrevBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrevAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrevAccountName As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace