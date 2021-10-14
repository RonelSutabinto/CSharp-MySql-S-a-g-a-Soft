Namespace Controls.Information.Account
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Grid_Ledger
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
            Me.colSequenceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInitiatingBranch = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMnemonic = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colErrorCorrectTag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBeginningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCredit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOverPaid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutsBal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
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
            Me.gridControl.Size = New System.Drawing.Size(469, 329)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSequenceNumber, Me.colInitiatingBranch, Me.colAccountNumber, Me.colLedgerSetNumber, Me.colTransCode, Me.colPostingDate, Me.colTransactionDate, Me.colLedgerType, Me.colMnemonic, Me.colErrorCorrectTag, Me.colORNumber, Me.colBeginningBalance, Me.colDebit, Me.colCredit, Me.colTotalAmount, Me.colOverPaid, Me.colEndingBalance, Me.colOutsBal, Me.colNote, Me.colTransactedBy})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colSequenceNumber
            '
            Me.colSequenceNumber.Caption = "ID"
            Me.colSequenceNumber.FieldName = "SequenceNumber"
            Me.colSequenceNumber.Name = "colSequenceNumber"
            Me.colSequenceNumber.Visible = True
            Me.colSequenceNumber.VisibleIndex = 0
            '
            'colInitiatingBranch
            '
            Me.colInitiatingBranch.Caption = "Branch Paid"
            Me.colInitiatingBranch.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
            Me.colInitiatingBranch.FieldName = "InitiatingBranch"
            Me.colInitiatingBranch.Name = "colInitiatingBranch"
            Me.colInitiatingBranch.Visible = True
            Me.colInitiatingBranch.VisibleIndex = 1
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'colAccountNumber
            '
            Me.colAccountNumber.Caption = "Account"
            Me.colAccountNumber.FieldName = "AccountNumber"
            Me.colAccountNumber.Name = "colAccountNumber"
            Me.colAccountNumber.Visible = True
            Me.colAccountNumber.VisibleIndex = 2
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 3
            '
            'colTransCode
            '
            Me.colTransCode.Caption = "Transaction"
            Me.colTransCode.FieldName = "TransCode"
            Me.colTransCode.Name = "colTransCode"
            Me.colTransCode.Visible = True
            Me.colTransCode.VisibleIndex = 4
            '
            'colPostingDate
            '
            Me.colPostingDate.Caption = "Posted"
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 5
            '
            'colTransactionDate
            '
            Me.colTransactionDate.Caption = "Transacted"
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 6
            '
            'colLedgerType
            '
            Me.colLedgerType.Caption = "Pay Type"
            Me.colLedgerType.FieldName = "LedgerType"
            Me.colLedgerType.Name = "colLedgerType"
            Me.colLedgerType.Visible = True
            Me.colLedgerType.VisibleIndex = 7
            '
            'colMnemonic
            '
            Me.colMnemonic.Caption = "Mnemonic"
            Me.colMnemonic.FieldName = "Mnemonic"
            Me.colMnemonic.Name = "colMnemonic"
            Me.colMnemonic.Visible = True
            Me.colMnemonic.VisibleIndex = 8
            '
            'colErrorCorrectTag
            '
            Me.colErrorCorrectTag.Caption = "Error"
            Me.colErrorCorrectTag.FieldName = "ErrorCorrectTag"
            Me.colErrorCorrectTag.Name = "colErrorCorrectTag"
            Me.colErrorCorrectTag.Visible = True
            Me.colErrorCorrectTag.VisibleIndex = 9
            '
            'colORNumber
            '
            Me.colORNumber.Caption = "OR Number"
            Me.colORNumber.FieldName = "ORNumber"
            Me.colORNumber.Name = "colORNumber"
            Me.colORNumber.Visible = True
            Me.colORNumber.VisibleIndex = 10
            '
            'colBeginningBalance
            '
            Me.colBeginningBalance.Caption = "Balance 1"
            Me.colBeginningBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginningBalance.FieldName = "BeginningBalance"
            Me.colBeginningBalance.Name = "colBeginningBalance"
            Me.colBeginningBalance.Visible = True
            Me.colBeginningBalance.VisibleIndex = 11
            '
            'colDebit
            '
            Me.colDebit.Caption = "Debit"
            Me.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDebit.FieldName = "Debit"
            Me.colDebit.Name = "colDebit"
            Me.colDebit.Visible = True
            Me.colDebit.VisibleIndex = 12
            '
            'colCredit
            '
            Me.colCredit.Caption = "Credit"
            Me.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCredit.FieldName = "Credit"
            Me.colCredit.Name = "colCredit"
            Me.colCredit.Visible = True
            Me.colCredit.VisibleIndex = 13
            '
            'colTotalAmount
            '
            Me.colTotalAmount.Caption = "Total"
            Me.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalAmount.FieldName = "TotalAmount"
            Me.colTotalAmount.Name = "colTotalAmount"
            Me.colTotalAmount.Visible = True
            Me.colTotalAmount.VisibleIndex = 14
            '
            'colOverPaid
            '
            Me.colOverPaid.Caption = "Advance"
            Me.colOverPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOverPaid.FieldName = "OverPaid"
            Me.colOverPaid.Name = "colOverPaid"
            Me.colOverPaid.Visible = True
            Me.colOverPaid.VisibleIndex = 15
            '
            'colEndingBalance
            '
            Me.colEndingBalance.Caption = "Balance 2"
            Me.colEndingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEndingBalance.FieldName = "EndingBalance"
            Me.colEndingBalance.Name = "colEndingBalance"
            Me.colEndingBalance.Visible = True
            Me.colEndingBalance.VisibleIndex = 16
            '
            'colOutsBal
            '
            Me.colOutsBal.Caption = "Balance 3"
            Me.colOutsBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutsBal.FieldName = "OutsBal"
            Me.colOutsBal.Name = "colOutsBal"
            Me.colOutsBal.Visible = True
            Me.colOutsBal.VisibleIndex = 17
            '
            'colNote
            '
            Me.colNote.Caption = "Notes"
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 18
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Added By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 19
            '
            'barManager
            '
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Journal_Entries, Me.btn_Generate})
            Me.barManager.MaxItemId = 12
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(469, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 329)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(469, 0)
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
            Me.barDockControlRight.Location = New System.Drawing.Point(469, 0)
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
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 8
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 2
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 2
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "Generate"
            Me.btn_Generate.Id = 11
            Me.btn_Generate.Name = "btn_Generate"
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'xuc_Grid_Ledger
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Grid_Ledger"
            Me.Size = New System.Drawing.Size(469, 329)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents colSequenceNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInitiatingBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMnemonic As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colORNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCredit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOverPaid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndingBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colErrorCorrectTag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLedgerType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colOutsBal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
