<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_COA_Ledger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_COA_Ledger))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Load_All = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btn_Beginning_Balance = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.colCOA_Normal = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 20)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA})
        Me.gridControl.Size = New System.Drawing.Size(398, 297)
        Me.gridControl.TabIndex = 1
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colType, Me.colCOA_Summary, Me.colCOA_Code, Me.colCOA_Name, Me.colAccount_Name, Me.colReference, Me.colDebit, Me.colCredit, Me.colPosting_Date, Me.colBalance, Me.colCOA_Normal, Me.colJournal_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colLocked_By, Me.colLocked_Date})
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
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        '
        'colCOA_Summary
        '
        Me.colCOA_Summary.Caption = "Summary"
        Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
        Me.colCOA_Summary.FieldName = "COA_Summary"
        Me.colCOA_Summary.Name = "colCOA_Summary"
        Me.colCOA_Summary.Visible = True
        Me.colCOA_Summary.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit_COA
        '
        Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
        Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
        '
        'colCOA_Code
        '
        Me.colCOA_Code.Caption = "Code"
        Me.colCOA_Code.FieldName = "COA_Code"
        Me.colCOA_Code.Name = "colCOA_Code"
        Me.colCOA_Code.Visible = True
        Me.colCOA_Code.VisibleIndex = 3
        '
        'colCOA_Name
        '
        Me.colCOA_Name.Caption = "Account Title"
        Me.colCOA_Name.FieldName = "COA_Name"
        Me.colCOA_Name.Name = "colCOA_Name"
        Me.colCOA_Name.Visible = True
        Me.colCOA_Name.VisibleIndex = 4
        '
        'colAccount_Name
        '
        Me.colAccount_Name.Caption = "Account Name"
        Me.colAccount_Name.FieldName = "Account_Name"
        Me.colAccount_Name.Name = "colAccount_Name"
        Me.colAccount_Name.Visible = True
        Me.colAccount_Name.VisibleIndex = 5
        '
        'colReference
        '
        Me.colReference.Caption = "Reference"
        Me.colReference.FieldName = "Reference"
        Me.colReference.Name = "colReference"
        Me.colReference.Visible = True
        Me.colReference.VisibleIndex = 6
        '
        'colDebit
        '
        Me.colDebit.Caption = "Debit"
        Me.colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDebit.FieldName = "Debit"
        Me.colDebit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDebit.Name = "colDebit"
        Me.colDebit.Visible = True
        Me.colDebit.VisibleIndex = 7
        '
        'colCredit
        '
        Me.colCredit.Caption = "Credit"
        Me.colCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCredit.FieldName = "Credit"
        Me.colCredit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCredit.Name = "colCredit"
        Me.colCredit.Visible = True
        Me.colCredit.VisibleIndex = 8
        '
        'colPosting_Date
        '
        Me.colPosting_Date.Caption = "Posting Date"
        Me.colPosting_Date.FieldName = "Posting_Date"
        Me.colPosting_Date.Name = "colPosting_Date"
        Me.colPosting_Date.Visible = True
        Me.colPosting_Date.VisibleIndex = 9
        '
        'colBalance
        '
        Me.colBalance.Caption = "Balance"
        Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.Name = "colBalance"
        Me.colBalance.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 10
        '
        'colJournal_Description
        '
        Me.colJournal_Description.Caption = "Description"
        Me.colJournal_Description.FieldName = "Journal_Description"
        Me.colJournal_Description.Name = "colJournal_Description"
        Me.colJournal_Description.Visible = True
        Me.colJournal_Description.VisibleIndex = 12
        '
        'colNotes
        '
        Me.colNotes.Caption = "Notes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 13
        '
        'colAdded_By
        '
        Me.colAdded_By.FieldName = "Added_By"
        Me.colAdded_By.Name = "colAdded_By"
        Me.colAdded_By.Visible = True
        Me.colAdded_By.VisibleIndex = 14
        '
        'colAdded_Date
        '
        Me.colAdded_Date.FieldName = "Added_Date"
        Me.colAdded_Date.Name = "colAdded_Date"
        Me.colAdded_Date.Visible = True
        Me.colAdded_Date.VisibleIndex = 15
        '
        'colModified_By
        '
        Me.colModified_By.FieldName = "Modified_By"
        Me.colModified_By.Name = "colModified_By"
        Me.colModified_By.Visible = True
        Me.colModified_By.VisibleIndex = 16
        '
        'colModified_Date
        '
        Me.colModified_Date.FieldName = "Modified_Date"
        Me.colModified_Date.Name = "colModified_Date"
        Me.colModified_Date.Visible = True
        Me.colModified_Date.VisibleIndex = 17
        '
        'colApproved_By
        '
        Me.colApproved_By.FieldName = "Approved_By"
        Me.colApproved_By.Name = "colApproved_By"
        Me.colApproved_By.Visible = True
        Me.colApproved_By.VisibleIndex = 18
        '
        'colApproved_Date
        '
        Me.colApproved_Date.FieldName = "Approved_Date"
        Me.colApproved_Date.Name = "colApproved_Date"
        Me.colApproved_Date.Visible = True
        Me.colApproved_Date.VisibleIndex = 19
        '
        'colLocked_By
        '
        Me.colLocked_By.FieldName = "Locked_By"
        Me.colLocked_By.Name = "colLocked_By"
        Me.colLocked_By.Visible = True
        Me.colLocked_By.VisibleIndex = 20
        '
        'colLocked_Date
        '
        Me.colLocked_Date.FieldName = "Locked_Date"
        Me.colLocked_Date.Name = "colLocked_Date"
        Me.colLocked_Date.Visible = True
        Me.colLocked_Date.VisibleIndex = 21
        '
        'barManager
        '
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Preview, Me.btn_Generate, Me.btn_Update, Me.btn_Beginning_Balance, Me.btn_Load_All})
        Me.barManager.MaxItemId = 16
        Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.bar1.Text = "Tools"
        '
        'btn_Reload
        '
        Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
        Me.btn_Reload.Id = 0
        Me.btn_Reload.ImageOptions.ImageIndex = 0
        Me.btn_Reload.ImageOptions.LargeImageIndex = 0
        Me.btn_Reload.Name = "btn_Reload"
        '
        'PopupMenu_Reload
        '
        Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_All)})
        Me.PopupMenu_Reload.Manager = Me.barManager
        Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
        '
        'btn_Load_All
        '
        Me.btn_Load_All.Caption = "Load All"
        Me.btn_Load_All.Id = 15
        Me.btn_Load_All.ImageOptions.Image = CType(resources.GetObject("btn_Load_All.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Load_All.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_All.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Load_All.Name = "btn_Load_All"
        '
        'btn_Generate
        '
        Me.btn_Generate.Caption = "Generate"
        Me.btn_Generate.Id = 12
        Me.btn_Generate.Name = "btn_Generate"
        '
        'btn_Update
        '
        Me.btn_Update.Caption = "Update"
        Me.btn_Update.Id = 13
        Me.btn_Update.Name = "btn_Update"
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 7
        Me.btn_Preview.ImageOptions.ImageIndex = 4
        Me.btn_Preview.ImageOptions.LargeImageIndex = 4
        Me.btn_Preview.Name = "btn_Preview"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 1
        Me.btn_Close.ImageOptions.ImageIndex = 5
        Me.btn_Close.ImageOptions.LargeImageIndex = 5
        Me.btn_Close.Name = "btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(398, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 317)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(398, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 297)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(398, 20)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 297)
        '
        'btn_Beginning_Balance
        '
        Me.btn_Beginning_Balance.Caption = "Set as Beginning Balance"
        Me.btn_Beginning_Balance.Id = 14
        Me.btn_Beginning_Balance.ImageOptions.Image = CType(resources.GetObject("btn_Beginning_Balance.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Beginning_Balance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Beginning_Balance.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Beginning_Balance.Name = "btn_Beginning_Balance"
        '
        'RepositoryItemSearchControl_Search
        '
        Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Beginning_Balance, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.PopupMenu.Manager = Me.barManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'colCOA_Normal
        '
        Me.colCOA_Normal.Caption = "Normal"
        Me.colCOA_Normal.FieldName = "COA_Normal"
        Me.colCOA_Normal.Name = "colCOA_Normal"
        Me.colCOA_Normal.Visible = True
        Me.colCOA_Normal.VisibleIndex = 11
        '
        'frm_COA_Ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 317)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_COA_Ledger"
        Me.Text = "Account Ledger / Running Balance"
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Beginning_Balance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Load_All As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCOA_Normal As DevExpress.XtraGrid.Columns.GridColumn
End Class
