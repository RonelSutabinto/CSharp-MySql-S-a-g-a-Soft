Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm_Collection
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
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_IsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCORP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colwhCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCIFKey = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMnemonic = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReferenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmntNetOfVat = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPEN = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscAmt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipalPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestPMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_BranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_TransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_TransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_AmountReceived = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_VAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_NoVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Account_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_OR = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colErrorTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ErrorTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Update = New DevExpress.XtraBars.BarButtonItem()
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
            Me.Btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridControl
            '
            Me.GridControl.DataMember = "view_Payment_Transactions"
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 41)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.Size = New System.Drawing.Size(614, 343)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colIBP_IsJournal, Me.colCORP, Me.colwhCode, Me.colSaleType, Me.colAccountStatus, Me.colCIFKey, Me.colBranchCode, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colAccountName, Me.colAccountAddress, Me.colBrand, Me.colModel, Me.colColor, Me.colEngineNo, Me.colChassisNo, Me.colPostingDate, Me.colRemarks, Me.colMnemonic, Me.colReferenceNumber, Me.colORNumber, Me.colTransactionDate, Me.colAmountPaid, Me.colPrincipal, Me.colInterest, Me.colVAT, Me.colAmntNetOfVat, Me.colAOC, Me.colRebates, Me.colPEN, Me.colDiscAmt, Me.colPMT, Me.colPrincipalPMT, Me.colInterestPMT, Me.colNote, Me.colTransactedBy, Me.colIBP_ID, Me.colIBP_BranchCode, Me.colIBP_TransactionDate, Me.colIBP_TransactedBy, Me.colIBP_AmountReceived, Me.colIBP_VAT, Me.colIBP_NoVAT, Me.colDescription, Me.colIBP_Account_Name, Me.colIBP_OR, Me.colIBP_PostingDate, Me.colErrorTag, Me.colIBP_ErrorTag, Me.colTransaction})
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
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colIBP_IsJournal
            '
            Me.colIBP_IsJournal.Caption = "IBP Journal"
            Me.colIBP_IsJournal.FieldName = "IBP_IsJournal"
            Me.colIBP_IsJournal.Name = "colIBP_IsJournal"
            Me.colIBP_IsJournal.Visible = True
            Me.colIBP_IsJournal.VisibleIndex = 2
            '
            'colCORP
            '
            Me.colCORP.Caption = "Corp"
            Me.colCORP.FieldName = "CORP"
            Me.colCORP.Name = "colCORP"
            Me.colCORP.Visible = True
            Me.colCORP.VisibleIndex = 3
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
            'colAccountStatus
            '
            Me.colAccountStatus.Caption = "Status"
            Me.colAccountStatus.FieldName = "AccountStatus"
            Me.colAccountStatus.Name = "colAccountStatus"
            Me.colAccountStatus.Visible = True
            Me.colAccountStatus.VisibleIndex = 6
            '
            'colCIFKey
            '
            Me.colCIFKey.Caption = "CIF"
            Me.colCIFKey.FieldName = "CIFKey"
            Me.colCIFKey.Name = "colCIFKey"
            Me.colCIFKey.Visible = True
            Me.colCIFKey.VisibleIndex = 7
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 8
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
            'colAccountName
            '
            Me.colAccountName.Caption = "Name"
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 11
            '
            'colAccountAddress
            '
            Me.colAccountAddress.Caption = "Address"
            Me.colAccountAddress.FieldName = "AccountAddress"
            Me.colAccountAddress.Name = "colAccountAddress"
            Me.colAccountAddress.Visible = True
            Me.colAccountAddress.VisibleIndex = 12
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 13
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 14
            '
            'colColor
            '
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 15
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 16
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 17
            '
            'colPostingDate
            '
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 18
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 19
            '
            'colMnemonic
            '
            Me.colMnemonic.FieldName = "Mnemonic"
            Me.colMnemonic.Name = "colMnemonic"
            Me.colMnemonic.Visible = True
            Me.colMnemonic.VisibleIndex = 20
            '
            'colReferenceNumber
            '
            Me.colReferenceNumber.Caption = "Reference"
            Me.colReferenceNumber.FieldName = "ReferenceNumber"
            Me.colReferenceNumber.Name = "colReferenceNumber"
            Me.colReferenceNumber.Visible = True
            Me.colReferenceNumber.VisibleIndex = 21
            '
            'colORNumber
            '
            Me.colORNumber.FieldName = "ORNumber"
            Me.colORNumber.Name = "colORNumber"
            Me.colORNumber.Visible = True
            Me.colORNumber.VisibleIndex = 22
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 23
            '
            'colAmountPaid
            '
            Me.colAmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmountPaid.FieldName = "AmountPaid"
            Me.colAmountPaid.Name = "colAmountPaid"
            Me.colAmountPaid.Visible = True
            Me.colAmountPaid.VisibleIndex = 24
            '
            'colPrincipal
            '
            Me.colPrincipal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal.FieldName = "Principal"
            Me.colPrincipal.Name = "colPrincipal"
            Me.colPrincipal.Visible = True
            Me.colPrincipal.VisibleIndex = 25
            '
            'colInterest
            '
            Me.colInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest.FieldName = "Interest"
            Me.colInterest.Name = "colInterest"
            Me.colInterest.Visible = True
            Me.colInterest.VisibleIndex = 26
            '
            'colVAT
            '
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VAT"
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 27
            '
            'colAmntNetOfVat
            '
            Me.colAmntNetOfVat.Caption = "No VAT"
            Me.colAmntNetOfVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmntNetOfVat.FieldName = "AmntNetOfVat"
            Me.colAmntNetOfVat.Name = "colAmntNetOfVat"
            Me.colAmntNetOfVat.Visible = True
            Me.colAmntNetOfVat.VisibleIndex = 28
            '
            'colAOC
            '
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 29
            '
            'colRebates
            '
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 30
            '
            'colPEN
            '
            Me.colPEN.Caption = "Penalty"
            Me.colPEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPEN.FieldName = "PEN"
            Me.colPEN.Name = "colPEN"
            Me.colPEN.Visible = True
            Me.colPEN.VisibleIndex = 31
            '
            'colDiscAmt
            '
            Me.colDiscAmt.Caption = "Discount"
            Me.colDiscAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscAmt.FieldName = "DiscAmt"
            Me.colDiscAmt.Name = "colDiscAmt"
            Me.colDiscAmt.Visible = True
            Me.colDiscAmt.VisibleIndex = 32
            '
            'colPMT
            '
            Me.colPMT.Caption = "Amortization"
            Me.colPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPMT.FieldName = "PMT"
            Me.colPMT.Name = "colPMT"
            Me.colPMT.Visible = True
            Me.colPMT.VisibleIndex = 33
            '
            'colPrincipalPMT
            '
            Me.colPrincipalPMT.Caption = "Principal"
            Me.colPrincipalPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipalPMT.FieldName = "PrincipalPMT"
            Me.colPrincipalPMT.Name = "colPrincipalPMT"
            Me.colPrincipalPMT.Visible = True
            Me.colPrincipalPMT.VisibleIndex = 34
            '
            'colInterestPMT
            '
            Me.colInterestPMT.Caption = "Interest"
            Me.colInterestPMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestPMT.FieldName = "InterestPMT"
            Me.colInterestPMT.Name = "colInterestPMT"
            Me.colInterestPMT.Visible = True
            Me.colInterestPMT.VisibleIndex = 35
            '
            'colNote
            '
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 36
            '
            'colTransactedBy
            '
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 37
            '
            'colIBP_ID
            '
            Me.colIBP_ID.FieldName = "IBP_ID"
            Me.colIBP_ID.Name = "colIBP_ID"
            Me.colIBP_ID.Visible = True
            Me.colIBP_ID.VisibleIndex = 38
            '
            'colIBP_BranchCode
            '
            Me.colIBP_BranchCode.FieldName = "IBP_BranchCode"
            Me.colIBP_BranchCode.Name = "colIBP_BranchCode"
            Me.colIBP_BranchCode.Visible = True
            Me.colIBP_BranchCode.VisibleIndex = 39
            '
            'colIBP_TransactionDate
            '
            Me.colIBP_TransactionDate.FieldName = "IBP_TransactionDate"
            Me.colIBP_TransactionDate.Name = "colIBP_TransactionDate"
            Me.colIBP_TransactionDate.Visible = True
            Me.colIBP_TransactionDate.VisibleIndex = 40
            '
            'colIBP_TransactedBy
            '
            Me.colIBP_TransactedBy.FieldName = "IBP_TransactedBy"
            Me.colIBP_TransactedBy.Name = "colIBP_TransactedBy"
            Me.colIBP_TransactedBy.Visible = True
            Me.colIBP_TransactedBy.VisibleIndex = 41
            '
            'colIBP_AmountReceived
            '
            Me.colIBP_AmountReceived.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIBP_AmountReceived.FieldName = "IBP_AmountReceived"
            Me.colIBP_AmountReceived.Name = "colIBP_AmountReceived"
            Me.colIBP_AmountReceived.Visible = True
            Me.colIBP_AmountReceived.VisibleIndex = 42
            '
            'colIBP_VAT
            '
            Me.colIBP_VAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIBP_VAT.FieldName = "IBP_VAT"
            Me.colIBP_VAT.Name = "colIBP_VAT"
            Me.colIBP_VAT.Visible = True
            Me.colIBP_VAT.VisibleIndex = 43
            '
            'colIBP_NoVAT
            '
            Me.colIBP_NoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIBP_NoVAT.FieldName = "IBP_NoVAT"
            Me.colIBP_NoVAT.Name = "colIBP_NoVAT"
            Me.colIBP_NoVAT.Visible = True
            Me.colIBP_NoVAT.VisibleIndex = 44
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 45
            '
            'colIBP_Account_Name
            '
            Me.colIBP_Account_Name.FieldName = "IBP_Account_Name"
            Me.colIBP_Account_Name.Name = "colIBP_Account_Name"
            Me.colIBP_Account_Name.Visible = True
            Me.colIBP_Account_Name.VisibleIndex = 46
            '
            'colIBP_OR
            '
            Me.colIBP_OR.FieldName = "IBP_OR"
            Me.colIBP_OR.Name = "colIBP_OR"
            Me.colIBP_OR.Visible = True
            Me.colIBP_OR.VisibleIndex = 47
            '
            'colIBP_PostingDate
            '
            Me.colIBP_PostingDate.FieldName = "IBP_PostingDate"
            Me.colIBP_PostingDate.Name = "colIBP_PostingDate"
            Me.colIBP_PostingDate.Visible = True
            Me.colIBP_PostingDate.VisibleIndex = 48
            '
            'colErrorTag
            '
            Me.colErrorTag.FieldName = "ErrorTag"
            Me.colErrorTag.Name = "colErrorTag"
            Me.colErrorTag.Visible = True
            Me.colErrorTag.VisibleIndex = 49
            '
            'colIBP_ErrorTag
            '
            Me.colIBP_ErrorTag.FieldName = "IBP_ErrorTag"
            Me.colIBP_ErrorTag.Name = "colIBP_ErrorTag"
            Me.colIBP_ErrorTag.Visible = True
            Me.colIBP_ErrorTag.VisibleIndex = 50
            '
            'colTransaction
            '
            Me.colTransaction.FieldName = "Transaction"
            Me.colTransaction.Name = "colTransaction"
            Me.colTransaction.Visible = True
            Me.colTransaction.VisibleIndex = 51
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Journal, Me.Bar_Parameters})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Reload, Me.Btn_Preview, Me.Btn_Close, Me.Btn_Journal, Me.Btn_Journal_Entries, Me.Btn_Stop, Me.Btn_Update, Me.BarEditItem_Branch, Me.BarEditItem_Search, Me.BarEditItem_Start, Me.BarEditItem_End, Me.BarEditItem_Corporation, Me.Btn_Validate, Me.Btn_Verify})
            Me.BarManager.MaxItemId = 14
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemDateEdit_Start, Me.RepositoryItemDateEdit_End, Me.RepositoryItemComboBox_Corporation})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
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
            'Btn_Update
            '
            Me.Btn_Update.Caption = "Update"
            Me.Btn_Update.Id = 6
            Me.Btn_Update.Name = "Btn_Update"
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
            Me.barDockControlTop.Size = New System.Drawing.Size(614, 41)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 384)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(614, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 343)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(614, 41)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 343)
            '
            'Btn_Validate
            '
            Me.Btn_Validate.Caption = "Validate"
            Me.Btn_Validate.Id = 12
            Me.Btn_Validate.Name = "Btn_Validate"
            '
            'Btn_Verify
            '
            Me.Btn_Verify.Caption = "Verify"
            Me.Btn_Verify.Id = 13
            Me.Btn_Verify.Name = "Btn_Verify"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'XtraForm_Collection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(614, 384)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm_Collection"
            Me.Text = "Branch Collection"
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCIFKey As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReferenceNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmountPaid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colwhCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipalPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestPMT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmntNetOfVat As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCORP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPEN As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_BranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMnemonic As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_TransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_TransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_AmountReceived As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_VAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_NoVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Account_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_OR As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_PostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSaleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_IsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colErrorTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ErrorTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscAmt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents BarEditItem_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents Btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Verify As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace