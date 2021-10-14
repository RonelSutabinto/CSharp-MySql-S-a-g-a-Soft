Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Grid_Cashiering
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
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch})
            Me.gridControl.Size = New System.Drawing.Size(313, 328)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colBranch_Code, Me.colAccount_Code, Me.coAccount_Name, Me.colAccount_Address, Me.colPayment_Code, Me.colTransaction_Type, Me.colInvoice_Type, Me.colReference, Me.colOR_Code, Me.colAmount_Paid, Me.colVAT, Me.colNoVAT, Me.colDiscount, Me.colTotal, Me.colPosting_Date, Me.colTransactionDate, Me.colTransactedBy, Me.colNotes, Me.colIBP_ID, Me.colIBP_Is_Journal, Me.colIBP_Branch_Code, Me.colIBP_Account, Me.colIBP_Ledger, Me.colIBP_Amount_Paid, Me.colIBP_Posting_Date, Me.colIBP_Added_Date, Me.colIBP_Added_By})
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
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'barManager
            '
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Journal, Me.btn_Close, Me.btn_Stop, Me.btn_Journal_Entries, Me.btn_Verify, Me.btn_Update, Me.btn_Batch_Transactions})
            Me.barManager.MaxItemId = 12
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
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 328)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(313, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 328)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(313, 0)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 328)
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
            Me.btn_Journal.ImageOptions.ImageIndex = 3
            Me.btn_Journal.ImageOptions.LargeImageIndex = 3
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 3
            Me.btn_Close.Name = "btn_Close"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 4
            Me.btn_Stop.ImageOptions.ImageIndex = 4
            Me.btn_Stop.ImageOptions.LargeImageIndex = 4
            Me.btn_Stop.Name = "btn_Stop"
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
            Me.btn_Verify.Id = 9
            Me.btn_Verify.ImageOptions.ImageIndex = 5
            Me.btn_Verify.ImageOptions.LargeImageIndex = 5
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 10
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Batch Cashiering"
            Me.btn_Batch_Transactions.Id = 11
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Batch_Transactions), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'xuc_Grid_Cashiering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Grid_Cashiering"
            Me.Size = New System.Drawing.Size(313, 328)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents coAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOR_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPayment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNoVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Posting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Added_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colIBP_Account As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Ledger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Amount_Paid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Branch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Is_Journal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colTransaction_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIBP_Added_By As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace