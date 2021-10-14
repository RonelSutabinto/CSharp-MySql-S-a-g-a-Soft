Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Grid_Journal_References
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
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Grid_Journal_References))
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTable_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colJournal_Entries = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.BarEditItem_List_Mode = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch})
            Me.gridControl.Size = New System.Drawing.Size(503, 359)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTable_ID, Me.colBranch_Code, Me.colJournal_Entries, Me.colJournal_Reference, Me.colJournal_Type, Me.colJournal_Debit, Me.colJournal_Credit, Me.colJournal_Status, Me.colAccount_Code, Me.colAccount_Name, Me.colPosting_Date, Me.colAdded_By, Me.colJournal_Description})
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
            'colTable_ID
            '
            Me.colTable_ID.Caption = "Table ID"
            Me.colTable_ID.FieldName = "Table_ID"
            Me.colTable_ID.Name = "colTable_ID"
            Me.colTable_ID.Visible = True
            Me.colTable_ID.VisibleIndex = 1
            '
            'colBranch_Code
            '
            Me.colBranch_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Branch
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 2
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'colJournal_Entries
            '
            Me.colJournal_Entries.Caption = "Journal_Entries"
            Me.colJournal_Entries.FieldName = "Journal_Entries"
            Me.colJournal_Entries.Name = "colJournal_Entries"
            Me.colJournal_Entries.Visible = True
            Me.colJournal_Entries.VisibleIndex = 3
            '
            'colJournal_Reference
            '
            Me.colJournal_Reference.FieldName = "Journal_Reference"
            Me.colJournal_Reference.Name = "colJournal_Reference"
            Me.colJournal_Reference.Visible = True
            Me.colJournal_Reference.VisibleIndex = 4
            '
            'colJournal_Type
            '
            Me.colJournal_Type.FieldName = "Journal_Type"
            Me.colJournal_Type.Name = "colJournal_Type"
            Me.colJournal_Type.Visible = True
            Me.colJournal_Type.VisibleIndex = 5
            '
            'colJournal_Debit
            '
            Me.colJournal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Debit.FieldName = "Journal_Debit"
            Me.colJournal_Debit.Name = "colJournal_Debit"
            Me.colJournal_Debit.Visible = True
            Me.colJournal_Debit.VisibleIndex = 6
            '
            'colJournal_Credit
            '
            Me.colJournal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Credit.FieldName = "Journal_Credit"
            Me.colJournal_Credit.Name = "colJournal_Credit"
            Me.colJournal_Credit.Visible = True
            Me.colJournal_Credit.VisibleIndex = 7
            '
            'colJournal_Status
            '
            Me.colJournal_Status.FieldName = "Journal_Status"
            Me.colJournal_Status.Name = "colJournal_Status"
            Me.colJournal_Status.Visible = True
            Me.colJournal_Status.VisibleIndex = 8
            '
            'colAccount_Code
            '
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 9
            '
            'colAccount_Name
            '
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 10
            '
            'colPosting_Date
            '
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 11
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 12
            '
            'colJournal_Description
            '
            Me.colJournal_Description.FieldName = "Journal_Description"
            Me.colJournal_Description.Name = "colJournal_Description"
            Me.colJournal_Description.Visible = True
            Me.colJournal_Description.VisibleIndex = 13
            '
            'BarManager
            '
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Validate, Me.btn_Verify, Me.BarEditItem_List_Mode, Me.btn_Batch_Transactions, Me.btn_Journal_Entries})
            Me.BarManager.MaxItemId = 6
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1})
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(503, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 359)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(503, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 359)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(503, 0)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 359)
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.Image = CType(resources.GetObject("btn_Reload.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Validate"
            Me.btn_Validate.Id = 1
            Me.btn_Validate.ImageOptions.Image = CType(resources.GetObject("btn_Validate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Validate.ImageOptions.ImageIndex = 1
            Me.btn_Validate.ImageOptions.LargeImage = CType(resources.GetObject("btn_Validate.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Validate.ImageOptions.LargeImageIndex = 1
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 2
            Me.btn_Verify.ImageOptions.Image = CType(resources.GetObject("btn_Verify.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Verify.ImageOptions.LargeImage = CType(resources.GetObject("btn_Verify.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Verify.Name = "btn_Verify"
            '
            'BarEditItem_List_Mode
            '
            Me.BarEditItem_List_Mode.Caption = "Date Range"
            Me.BarEditItem_List_Mode.Edit = Me.RepositoryItemToggleSwitch1
            Me.BarEditItem_List_Mode.Id = 3
            Me.BarEditItem_List_Mode.Name = "BarEditItem_List_Mode"
            Me.BarEditItem_List_Mode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'RepositoryItemToggleSwitch1
            '
            Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
            Me.RepositoryItemToggleSwitch1.OffText = "Month"
            Me.RepositoryItemToggleSwitch1.OnText = "Date Range"
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Batch Transactions"
            Me.btn_Batch_Transactions.Id = 4
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Batch_Transactions)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 5
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'xuc_Grid_Journal_References
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Grid_Journal_References"
            Me.Size = New System.Drawing.Size(503, 359)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn

        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colJournal_Entries As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colTable_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarEditItem_List_Mode As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colJournal_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace