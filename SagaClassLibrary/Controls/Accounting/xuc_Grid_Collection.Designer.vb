Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Grid_Collection
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSale_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngine = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassis = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPayment_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOR_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount_Paid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPenalty = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNoVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOustanding_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIs_Error = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Is_Journal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Payment_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Branch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Amount_Paid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Posting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Added_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Added_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIBP_Notes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries2 = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal2 = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.DataMember = "TransactionPayments"
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.barManager
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(313, 329)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colCorporation, Me.colBranch_Code, Me.colUnit_Status, Me.colSale_Type, Me.colAccount_Status, Me.colAccount, Me.colLedger, Me.colAccountName, Me.colCustomer_Address, Me.colEngine, Me.colChassis, Me.colPayment_Code, Me.colReference, Me.colOR_Code, Me.colAmount_Paid, Me.colPrincipal, Me.colInterest, Me.colPenalty, Me.colRebates, Me.colVAT, Me.colNoVAT, Me.colAOC, Me.colPrincipal_Balance, Me.colInterest_Balance, Me.colOustanding_Balance, Me.colPosting_Date, Me.colAdded_Date, Me.colAdded_By, Me.colNotes, Me.colIs_Error, Me.colIBP_ID, Me.colIBP_Is_Journal, Me.colIBP_Payment_Code, Me.colIBP_Branch_Code, Me.colIBP_Amount_Paid, Me.colIBP_Posting_Date, Me.colIBP_Added_Date, Me.colIBP_Added_By, Me.colIBP_Notes})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{N1}")})
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
            'colCorporation
            '
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 3
            '
            'colUnit_Status
            '
            Me.colUnit_Status.Caption = "Unit Status"
            Me.colUnit_Status.FieldName = "Unit_Status"
            Me.colUnit_Status.Name = "colUnit_Status"
            Me.colUnit_Status.Visible = True
            Me.colUnit_Status.VisibleIndex = 4
            '
            'colSale_Type
            '
            Me.colSale_Type.FieldName = "Sale_Type"
            Me.colSale_Type.Name = "colSale_Type"
            Me.colSale_Type.Visible = True
            Me.colSale_Type.VisibleIndex = 5
            '
            'colAccount_Status
            '
            Me.colAccount_Status.FieldName = "Account_Status"
            Me.colAccount_Status.Name = "colAccount_Status"
            Me.colAccount_Status.Visible = True
            Me.colAccount_Status.VisibleIndex = 6
            '
            'colAccount
            '
            Me.colAccount.FieldName = "Account"
            Me.colAccount.Name = "colAccount"
            Me.colAccount.Visible = True
            Me.colAccount.VisibleIndex = 7
            '
            'colLedger
            '
            Me.colLedger.FieldName = "Ledger"
            Me.colLedger.Name = "colLedger"
            Me.colLedger.Visible = True
            Me.colLedger.VisibleIndex = 8
            '
            'colAccountName
            '
            Me.colAccountName.FieldName = "Customer_Name"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 9
            '
            'colCustomer_Address
            '
            Me.colCustomer_Address.FieldName = "Customer_Address"
            Me.colCustomer_Address.Name = "colCustomer_Address"
            Me.colCustomer_Address.Visible = True
            Me.colCustomer_Address.VisibleIndex = 10
            '
            'colEngine
            '
            Me.colEngine.FieldName = "Engine"
            Me.colEngine.Name = "colEngine"
            Me.colEngine.Visible = True
            Me.colEngine.VisibleIndex = 11
            '
            'colChassis
            '
            Me.colChassis.FieldName = "Chassis"
            Me.colChassis.Name = "colChassis"
            Me.colChassis.Visible = True
            Me.colChassis.VisibleIndex = 12
            '
            'colPayment_Code
            '
            Me.colPayment_Code.FieldName = "Payment_Code"
            Me.colPayment_Code.Name = "colPayment_Code"
            Me.colPayment_Code.Visible = True
            Me.colPayment_Code.VisibleIndex = 13
            '
            'colReference
            '
            Me.colReference.FieldName = "Reference"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 14
            '
            'colOR_Code
            '
            Me.colOR_Code.Caption = "Official Receipt"
            Me.colOR_Code.FieldName = "OR_Code"
            Me.colOR_Code.Name = "colOR_Code"
            Me.colOR_Code.Visible = True
            Me.colOR_Code.VisibleIndex = 15
            '
            'colAmount_Paid
            '
            Me.colAmount_Paid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmount_Paid.FieldName = "Amount_Paid"
            Me.colAmount_Paid.Name = "colAmount_Paid"
            Me.colAmount_Paid.Visible = True
            Me.colAmount_Paid.VisibleIndex = 16
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
            'colPenalty
            '
            Me.colPenalty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPenalty.FieldName = "Penalty"
            Me.colPenalty.Name = "colPenalty"
            Me.colPenalty.Visible = True
            Me.colPenalty.VisibleIndex = 19
            '
            'colRebates
            '
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 20
            '
            'colVAT
            '
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VAT"
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 21
            '
            'colNoVAT
            '
            Me.colNoVAT.Caption = "Net VAT"
            Me.colNoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNoVAT.FieldName = "NoVAT"
            Me.colNoVAT.Name = "colNoVAT"
            Me.colNoVAT.Visible = True
            Me.colNoVAT.VisibleIndex = 22
            '
            'colAOC
            '
            Me.colAOC.Caption = "AOC"
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 23
            '
            'colPrincipal_Balance
            '
            Me.colPrincipal_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal_Balance.FieldName = "Principal_Balance"
            Me.colPrincipal_Balance.Name = "colPrincipal_Balance"
            Me.colPrincipal_Balance.Visible = True
            Me.colPrincipal_Balance.VisibleIndex = 24
            '
            'colInterest_Balance
            '
            Me.colInterest_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Balance.FieldName = "Interest_Balance"
            Me.colInterest_Balance.Name = "colInterest_Balance"
            Me.colInterest_Balance.Visible = True
            Me.colInterest_Balance.VisibleIndex = 25
            '
            'colOustanding_Balance
            '
            Me.colOustanding_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOustanding_Balance.FieldName = "Oustanding_Balance"
            Me.colOustanding_Balance.Name = "colOustanding_Balance"
            Me.colOustanding_Balance.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.colOustanding_Balance.Visible = True
            Me.colOustanding_Balance.VisibleIndex = 26
            '
            'colPosting_Date
            '
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 27
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 28
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 29
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 30
            '
            'colIs_Error
            '
            Me.colIs_Error.Caption = "Error"
            Me.colIs_Error.FieldName = "Is_Error"
            Me.colIs_Error.Name = "colIs_Error"
            Me.colIs_Error.Visible = True
            Me.colIs_Error.VisibleIndex = 31
            '
            'colIBP_ID
            '
            Me.colIBP_ID.FieldName = "IBP_ID"
            Me.colIBP_ID.Name = "colIBP_ID"
            Me.colIBP_ID.Visible = True
            Me.colIBP_ID.VisibleIndex = 32
            '
            'colIBP_Is_Journal
            '
            Me.colIBP_Is_Journal.FieldName = "IBP_Is_Journal"
            Me.colIBP_Is_Journal.Name = "colIBP_Is_Journal"
            Me.colIBP_Is_Journal.Visible = True
            Me.colIBP_Is_Journal.VisibleIndex = 34
            '
            'colIBP_Payment_Code
            '
            Me.colIBP_Payment_Code.FieldName = "IBP_Payment_Code"
            Me.colIBP_Payment_Code.Name = "colIBP_Payment_Code"
            Me.colIBP_Payment_Code.Visible = True
            Me.colIBP_Payment_Code.VisibleIndex = 33
            '
            'colIBP_Branch_Code
            '
            Me.colIBP_Branch_Code.Caption = "IBP Branch Paid"
            Me.colIBP_Branch_Code.FieldName = "IBP_Branch_Code"
            Me.colIBP_Branch_Code.Name = "colIBP_Branch_Code"
            Me.colIBP_Branch_Code.Visible = True
            Me.colIBP_Branch_Code.VisibleIndex = 35
            '
            'colIBP_Amount_Paid
            '
            Me.colIBP_Amount_Paid.Caption = "IBP Amount Received"
            Me.colIBP_Amount_Paid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIBP_Amount_Paid.FieldName = "IBP_Amount_Paid"
            Me.colIBP_Amount_Paid.Name = "colIBP_Amount_Paid"
            Me.colIBP_Amount_Paid.Visible = True
            Me.colIBP_Amount_Paid.VisibleIndex = 36
            '
            'colIBP_Posting_Date
            '
            Me.colIBP_Posting_Date.FieldName = "IBP_Posting_Date"
            Me.colIBP_Posting_Date.Name = "colIBP_Posting_Date"
            Me.colIBP_Posting_Date.Visible = True
            Me.colIBP_Posting_Date.VisibleIndex = 37
            '
            'colIBP_Added_Date
            '
            Me.colIBP_Added_Date.FieldName = "IBP_Added_Date"
            Me.colIBP_Added_Date.Name = "colIBP_Added_Date"
            Me.colIBP_Added_Date.Visible = True
            Me.colIBP_Added_Date.VisibleIndex = 38
            '
            'colIBP_Added_By
            '
            Me.colIBP_Added_By.FieldName = "IBP_Added_By"
            Me.colIBP_Added_By.Name = "colIBP_Added_By"
            Me.colIBP_Added_By.Visible = True
            Me.colIBP_Added_By.VisibleIndex = 39
            '
            'colIBP_Notes
            '
            Me.colIBP_Notes.FieldName = "IBP_Notes"
            Me.colIBP_Notes.Name = "colIBP_Notes"
            Me.colIBP_Notes.Visible = True
            Me.colIBP_Notes.VisibleIndex = 40
            '
            'barManager
            '
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Journal, Me.btn_Stop, Me.btn_Update, Me.btn_Validate, Me.btn_Journal_Entries, Me.btn_Verify, Me.btn_Batch_Transactions, Me.btn_Delete, Me.btn_Journal_Entries2, Me.btn_Journal2})
            Me.barManager.MaxItemId = 15
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(313, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 329)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(313, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 329)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(313, 0)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 329)
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 1
            Me.btn_Preview.ImageOptions.ImageIndex = 1
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 2
            Me.btn_Journal.ImageOptions.ImageIndex = 6
            Me.btn_Journal.ImageOptions.LargeImageIndex = 6
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 4
            Me.btn_Stop.ImageOptions.ImageIndex = 7
            Me.btn_Stop.ImageOptions.LargeImageIndex = 7
            Me.btn_Stop.Name = "btn_Stop"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "&Update"
            Me.btn_Update.Id = 5
            Me.btn_Update.ImageOptions.ImageIndex = 5
            Me.btn_Update.ImageOptions.LargeImageIndex = 5
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Validate"
            Me.btn_Validate.Id = 6
            Me.btn_Validate.ImageOptions.ImageIndex = 4
            Me.btn_Validate.ImageOptions.LargeImageIndex = 4
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 8
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 2
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 2
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 10
            Me.btn_Verify.ImageOptions.ImageIndex = 8
            Me.btn_Verify.ImageOptions.LargeImageIndex = 8
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Batch Collections"
            Me.btn_Batch_Transactions.Id = 11
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 12
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Journal_Entries2
            '
            Me.btn_Journal_Entries2.Caption = "Journal Entries 2"
            Me.btn_Journal_Entries2.Id = 13
            Me.btn_Journal_Entries2.Name = "btn_Journal_Entries2"
            '
            'btn_Journal2
            '
            Me.btn_Journal2.Caption = "Re-Journal (Cancelled)"
            Me.btn_Journal2.Id = 14
            Me.btn_Journal2.Name = "btn_Journal2"
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Batch_Transactions, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'xuc_Grid_Collection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Grid_Collection"
            Me.Size = New System.Drawing.Size(313, 329)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOR_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend colAccount As DevExpress.XtraGrid.Columns.GridColumn
        Friend colLedger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPayment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend colAmount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
        Friend colInterest As DevExpress.XtraGrid.Columns.GridColumn
        Friend colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend colPenalty As DevExpress.XtraGrid.Columns.GridColumn
        Friend colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend colNoVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend colPrincipal_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend colInterest_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Private popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Payment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Branch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIBP_Added_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Added_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Amount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Notes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Posting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSale_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngine As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Is_Journal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colOustanding_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colCustomer_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassis As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIs_Error As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace