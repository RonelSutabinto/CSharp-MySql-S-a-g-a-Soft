Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm_Cashiering
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
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_IsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIFNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMnemonic = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReferenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountDue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVat = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmntNetOfVat = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Branch = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_OR = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_TransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colErrorTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ErrorTag = New DevExpress.XtraGrid.Columns.GridColumn()
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
            Me.barDockControlTop.Size = New System.Drawing.Size(636, 58)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 387)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(636, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 329)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(636, 58)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 329)
            '
            'Btn_Verify
            '
            Me.Btn_Verify.Caption = "Verify"
            Me.Btn_Verify.Id = 12
            Me.Btn_Verify.Name = "Btn_Verify"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'GridControl
            '
            Me.GridControl.DataMember = "view_Payment_Cashiering"
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 58)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.MenuManager = Me.BarManager
            Me.GridControl.Name = "GridControl"
            Me.GridControl.Size = New System.Drawing.Size(636, 329)
            Me.GridControl.TabIndex = 4
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colIBP_IsJournal, Me.colCORP, Me.colBranchCode, Me.colCIFNo, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountName, Me.colMnemonic, Me.colRemarks, Me.colReferenceNumber, Me.colORNumber, Me.colAmountDue, Me.colAmountPaid, Me.colVat, Me.colAmntNetOfVat, Me.colTransaction, Me.colDescription, Me.colPostingDate, Me.colTransactionDate, Me.colTransactedBy, Me.colIBP_ID, Me.colIBP_Branch, Me.colIBP_AccountName, Me.colIBP_OR, Me.colIBP_PostingDate, Me.colIBP_TransactionDate, Me.colErrorTag, Me.colIBP_ErrorTag})
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            Me.GridView.OptionsView.ColumnAutoWidth = False
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
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colIBP_IsJournal
            '
            Me.colIBP_IsJournal.FieldName = "IBP_IsJournal"
            Me.colIBP_IsJournal.Name = "colIBP_IsJournal"
            Me.colIBP_IsJournal.Visible = True
            Me.colIBP_IsJournal.VisibleIndex = 2
            '
            'colCORP
            '
            Me.colCORP.Caption = "Corporation"
            Me.colCORP.FieldName = "CORP"
            Me.colCORP.Name = "colCORP"
            Me.colCORP.Visible = True
            Me.colCORP.VisibleIndex = 3
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 4
            '
            'colCIFNo
            '
            Me.colCIFNo.Caption = "CIF"
            Me.colCIFNo.FieldName = "CIFNo"
            Me.colCIFNo.Name = "colCIFNo"
            Me.colCIFNo.Visible = True
            Me.colCIFNo.VisibleIndex = 5
            '
            'colAccountNumber
            '
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 6
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 7
            '
            'colAccountName
            '
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 8
            '
            'colMnemonic
            '
            Me.colMnemonic.FieldName = "Mnemonic"
            Me.colMnemonic.Name = "colMnemonic"
            Me.colMnemonic.Visible = True
            Me.colMnemonic.VisibleIndex = 9
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 10
            '
            'colReferenceNumber
            '
            Me.colReferenceNumber.Caption = "Reference"
            Me.colReferenceNumber.FieldName = "ReferenceNumber"
            Me.colReferenceNumber.Name = "colReferenceNumber"
            Me.colReferenceNumber.Visible = True
            Me.colReferenceNumber.VisibleIndex = 11
            '
            'colORNumber
            '
            Me.colORNumber.FieldName = "ORNumber"
            Me.colORNumber.Name = "colORNumber"
            Me.colORNumber.Visible = True
            Me.colORNumber.VisibleIndex = 12
            '
            'colAmountDue
            '
            Me.colAmountDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountDue.FieldName = "AmountDue"
            Me.colAmountDue.Name = "colAmountDue"
            Me.colAmountDue.Visible = True
            Me.colAmountDue.VisibleIndex = 13
            '
            'colAmountPaid
            '
            Me.colAmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountPaid.FieldName = "AmountPaid"
            Me.colAmountPaid.Name = "colAmountPaid"
            Me.colAmountPaid.Visible = True
            Me.colAmountPaid.VisibleIndex = 14
            '
            'colVat
            '
            Me.colVat.Caption = "VAT"
            Me.colVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVat.FieldName = "Vat"
            Me.colVat.Name = "colVat"
            Me.colVat.Visible = True
            Me.colVat.VisibleIndex = 15
            '
            'colAmntNetOfVat
            '
            Me.colAmntNetOfVat.Caption = "No VAT"
            Me.colAmntNetOfVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmntNetOfVat.FieldName = "AmntNetOfVat"
            Me.colAmntNetOfVat.Name = "colAmntNetOfVat"
            Me.colAmntNetOfVat.Visible = True
            Me.colAmntNetOfVat.VisibleIndex = 16
            '
            'colTransaction
            '
            Me.colTransaction.FieldName = "Transaction"
            Me.colTransaction.Name = "colTransaction"
            Me.colTransaction.Visible = True
            Me.colTransaction.VisibleIndex = 17
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 18
            '
            'colPostingDate
            '
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 19
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 20
            '
            'colTransactedBy
            '
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 21
            '
            'colIBP_ID
            '
            Me.colIBP_ID.FieldName = "IBP_ID"
            Me.colIBP_ID.Name = "colIBP_ID"
            Me.colIBP_ID.Visible = True
            Me.colIBP_ID.VisibleIndex = 22
            '
            'colIBP_Branch
            '
            Me.colIBP_Branch.FieldName = "IBP_Branch"
            Me.colIBP_Branch.Name = "colIBP_Branch"
            Me.colIBP_Branch.Visible = True
            Me.colIBP_Branch.VisibleIndex = 23
            '
            'colIBP_AccountName
            '
            Me.colIBP_AccountName.FieldName = "IBP_AccountName"
            Me.colIBP_AccountName.Name = "colIBP_AccountName"
            Me.colIBP_AccountName.Visible = True
            Me.colIBP_AccountName.VisibleIndex = 24
            '
            'colIBP_OR
            '
            Me.colIBP_OR.FieldName = "IBP_OR"
            Me.colIBP_OR.Name = "colIBP_OR"
            Me.colIBP_OR.Visible = True
            Me.colIBP_OR.VisibleIndex = 25
            '
            'colIBP_PostingDate
            '
            Me.colIBP_PostingDate.FieldName = "IBP_PostingDate"
            Me.colIBP_PostingDate.Name = "colIBP_PostingDate"
            Me.colIBP_PostingDate.Visible = True
            Me.colIBP_PostingDate.VisibleIndex = 26
            '
            'colIBP_TransactionDate
            '
            Me.colIBP_TransactionDate.FieldName = "IBP_TransactionDate"
            Me.colIBP_TransactionDate.Name = "colIBP_TransactionDate"
            Me.colIBP_TransactionDate.Visible = True
            Me.colIBP_TransactionDate.VisibleIndex = 27
            '
            'colErrorTag
            '
            Me.colErrorTag.FieldName = "ErrorTag"
            Me.colErrorTag.Name = "colErrorTag"
            Me.colErrorTag.Visible = True
            Me.colErrorTag.VisibleIndex = 28
            '
            'colIBP_ErrorTag
            '
            Me.colIBP_ErrorTag.FieldName = "IBP_ErrorTag"
            Me.colIBP_ErrorTag.Name = "colIBP_ErrorTag"
            Me.colIBP_ErrorTag.Visible = True
            Me.colIBP_ErrorTag.VisibleIndex = 29
            '
            'XtraForm_Cashiering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(636, 387)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm_Cashiering"
            Me.Text = "Branch Cashiering"
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
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIFNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMnemonic As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVat As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmntNetOfVat As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_OR As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReferenceNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_PostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_TransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountPaid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Branch As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_AccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_IsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colErrorTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ErrorTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountDue As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Btn_Verify As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace