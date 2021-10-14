<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_COA_Balances
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
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        
        Me.colCOA_Statement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Level = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEditCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOA_Normal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance_Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBeginning_Balance_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBeginning_Balance_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnding_Balance_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnding_Balance_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLedger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barManager = New DevExpress.XtraBars.BarManager()
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager()
        Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        
        CType(Me.RepositoryItemLookUpEditCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 29)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEditCOA})
        Me.gridControl.Size = New System.Drawing.Size(467, 325)
        Me.gridControl.TabIndex = 0
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCOA_Code, Me.colCOA_Statement, Me.colCOA_Level, Me.colCOA_Type, Me.colCOA_Summary, Me.colCOA_Name, Me.colCOA_Desc, Me.colCOA_Normal, Me.colBalance_Date, Me.colBalance_Status, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colCorporation, Me.colBeginning_Balance_Debit, Me.colBeginning_Balance_Credit, Me.colTotal_Debit, Me.colTotal_Credit, Me.colEnding_Balance_Debit, Me.colEnding_Balance_Credit, Me.colBalance_Type, Me.colIsLedger, Me.colIsLocked, Me.colLocked_By, Me.colLocked_Date})
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
        'colCOA_Code
        '
        Me.colCOA_Code.FieldName = "COA_Code"
        Me.colCOA_Code.Name = "colCOA_Code"
        Me.colCOA_Code.Visible = True
        Me.colCOA_Code.VisibleIndex = 1
        '
        'colCOA_Statement
        '
        Me.colCOA_Statement.FieldName = "COA_Statement"
        Me.colCOA_Statement.Name = "colCOA_Statement"
        Me.colCOA_Statement.Visible = True
        Me.colCOA_Statement.VisibleIndex = 2
        '
        'colCOA_Level
        '
        Me.colCOA_Level.FieldName = "COA_Level"
        Me.colCOA_Level.Name = "colCOA_Level"
        Me.colCOA_Level.Visible = True
        Me.colCOA_Level.VisibleIndex = 3
        '
        'colCOA_Type
        '
        Me.colCOA_Type.FieldName = "COA_Type"
        Me.colCOA_Type.Name = "colCOA_Type"
        Me.colCOA_Type.Visible = True
        Me.colCOA_Type.VisibleIndex = 4
        '
        'colCOA_Summary
        '
        Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEditCOA
        Me.colCOA_Summary.FieldName = "COA_Summary"
        Me.colCOA_Summary.Name = "colCOA_Summary"
        Me.colCOA_Summary.Visible = True
        Me.colCOA_Summary.VisibleIndex = 5
        '
        'RepositoryItemLookUpEditCOA
        '
        Me.RepositoryItemLookUpEditCOA.AutoHeight = False
        Me.RepositoryItemLookUpEditCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEditCOA.Name = "RepositoryItemLookUpEditCOA"
        '
        'colCOA_Name
        '
        Me.colCOA_Name.Caption = "colCOA_Name"
        Me.colCOA_Name.FieldName = "COA_Name"
        Me.colCOA_Name.Name = "colCOA_Name"
        Me.colCOA_Name.Visible = True
        Me.colCOA_Name.VisibleIndex = 6
        '
        'colCOA_Desc
        '
        Me.colCOA_Desc.FieldName = "COA_Desc"
        Me.colCOA_Desc.Name = "colCOA_Desc"
        Me.colCOA_Desc.Visible = True
        Me.colCOA_Desc.VisibleIndex = 7
        '
        'colCOA_Normal
        '
        Me.colCOA_Normal.FieldName = "COA_Normal"
        Me.colCOA_Normal.Name = "colCOA_Normal"
        Me.colCOA_Normal.Visible = True
        Me.colCOA_Normal.VisibleIndex = 8
        '
        'colBalance_Date
        '
        Me.colBalance_Date.FieldName = "Balance_Date"
        Me.colBalance_Date.Name = "colBalance_Date"
        Me.colBalance_Date.Visible = True
        Me.colBalance_Date.VisibleIndex = 9
        '
        'colBalance_Status
        '
        Me.colBalance_Status.FieldName = "Balance_Status"
        Me.colBalance_Status.Name = "colBalance_Status"
        Me.colBalance_Status.Visible = True
        Me.colBalance_Status.VisibleIndex = 11
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 12
        '
        'colAdded_By
        '
        Me.colAdded_By.FieldName = "Added_By"
        Me.colAdded_By.Name = "colAdded_By"
        Me.colAdded_By.Visible = True
        Me.colAdded_By.VisibleIndex = 13
        '
        'colAdded_Date
        '
        Me.colAdded_Date.FieldName = "Added_Date"
        Me.colAdded_Date.Name = "colAdded_Date"
        Me.colAdded_Date.Visible = True
        Me.colAdded_Date.VisibleIndex = 14
        '
        'colModified_By
        '
        Me.colModified_By.FieldName = "Modified_By"
        Me.colModified_By.Name = "colModified_By"
        Me.colModified_By.Visible = True
        Me.colModified_By.VisibleIndex = 15
        '
        'colModified_Date
        '
        Me.colModified_Date.FieldName = "Modified_Date"
        Me.colModified_Date.Name = "colModified_Date"
        Me.colModified_Date.Visible = True
        Me.colModified_Date.VisibleIndex = 16
        '
        'colApproved_By
        '
        Me.colApproved_By.FieldName = "Approved_By"
        Me.colApproved_By.Name = "colApproved_By"
        Me.colApproved_By.Visible = True
        Me.colApproved_By.VisibleIndex = 17
        '
        'colApproved_Date
        '
        Me.colApproved_Date.FieldName = "Approved_Date"
        Me.colApproved_Date.Name = "colApproved_Date"
        Me.colApproved_Date.Visible = True
        Me.colApproved_Date.VisibleIndex = 18
        '
        'colCorporation
        '
        Me.colCorporation.FieldName = "Corporation"
        Me.colCorporation.Name = "colCorporation"
        Me.colCorporation.Visible = True
        Me.colCorporation.VisibleIndex = 19
        '
        'colBeginning_Balance_Debit
        '
        Me.colBeginning_Balance_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBeginning_Balance_Debit.FieldName = "Beginning_Balance_Debit"
        Me.colBeginning_Balance_Debit.Name = "colBeginning_Balance_Debit"
        Me.colBeginning_Balance_Debit.Visible = True
        Me.colBeginning_Balance_Debit.VisibleIndex = 20
        '
        'colBeginning_Balance_Credit
        '
        Me.colBeginning_Balance_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBeginning_Balance_Credit.FieldName = "Beginning_Balance_Credit"
        Me.colBeginning_Balance_Credit.Name = "colBeginning_Balance_Credit"
        Me.colBeginning_Balance_Credit.Visible = True
        Me.colBeginning_Balance_Credit.VisibleIndex = 21
        '
        'colTotal_Debit
        '
        Me.colTotal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal_Debit.FieldName = "Total_Debit"
        Me.colTotal_Debit.Name = "colTotal_Debit"
        Me.colTotal_Debit.Visible = True
        Me.colTotal_Debit.VisibleIndex = 22
        '
        'colTotal_Credit
        '
        Me.colTotal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal_Credit.FieldName = "Total_Credit"
        Me.colTotal_Credit.Name = "colTotal_Credit"
        Me.colTotal_Credit.Visible = True
        Me.colTotal_Credit.VisibleIndex = 23
        '
        'colEnding_Balance_Debit
        '
        Me.colEnding_Balance_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEnding_Balance_Debit.FieldName = "Ending_Balance_Debit"
        Me.colEnding_Balance_Debit.Name = "colEnding_Balance_Debit"
        Me.colEnding_Balance_Debit.Visible = True
        Me.colEnding_Balance_Debit.VisibleIndex = 24
        '
        'colEnding_Balance_Credit
        '
        Me.colEnding_Balance_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEnding_Balance_Credit.FieldName = "Ending_Balance_Credit"
        Me.colEnding_Balance_Credit.Name = "colEnding_Balance_Credit"
        Me.colEnding_Balance_Credit.Visible = True
        Me.colEnding_Balance_Credit.VisibleIndex = 25
        '
        'colBalance_Type
        '
        Me.colBalance_Type.FieldName = "Balance_Type"
        Me.colBalance_Type.Name = "colBalance_Type"
        Me.colBalance_Type.Visible = True
        Me.colBalance_Type.VisibleIndex = 26
        '
        'colIsLedger
        '
        Me.colIsLedger.FieldName = "IsLedger"
        Me.colIsLedger.Name = "colIsLedger"
        Me.colIsLedger.Visible = True
        Me.colIsLedger.VisibleIndex = 27
        '
        'colIsLocked
        '
        Me.colIsLocked.FieldName = "IsLocked"
        Me.colIsLocked.Name = "colIsLocked"
        Me.colIsLocked.Visible = True
        Me.colIsLocked.VisibleIndex = 28
        '
        'colLocked_By
        '
        Me.colLocked_By.FieldName = "Locked_By"
        Me.colLocked_By.Name = "colLocked_By"
        Me.colLocked_By.Visible = True
        Me.colLocked_By.VisibleIndex = 29
        '
        'colLocked_Date
        '
        Me.colLocked_Date.FieldName = "Locked_Date"
        Me.colLocked_Date.Name = "colLocked_Date"
        Me.colLocked_Date.Visible = True
        Me.colLocked_Date.VisibleIndex = 30
        '
        'barManager
        '
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.DockManager = Me.DockManager
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Delete, Me.btn_Initialize, Me.btn_Preview, Me.btn_Journal, Me.btn_Stop, Me.btn_Journal_Entries, Me.btn_Verify})
        Me.barManager.MaxItemId = 18
        Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.FloatLocation = New System.Drawing.Point(193, 135)
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(467, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 354)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(467, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 325)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(467, 29)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 325)
        '
        'DockManager
        '
        Me.DockManager.MenuManager = Me.barManager
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'btn_Journal
        '
        Me.btn_Journal.Caption = "Journal"
        Me.btn_Journal.Id = 10
        Me.btn_Journal.ImageOptions.ImageIndex = 7
        Me.btn_Journal.ImageOptions.LargeImageIndex = 7
        Me.btn_Journal.Name = "btn_Journal"
        '
        'btn_Stop
        '
        Me.btn_Stop.Caption = "Stop"
        Me.btn_Stop.Id = 11
        Me.btn_Stop.ImageOptions.ImageIndex = 8
        Me.btn_Stop.ImageOptions.LargeImageIndex = 8
        Me.btn_Stop.Name = "btn_Stop"
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
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
        Me.PopupMenu.Manager = Me.barManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'frm_COA_Balances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 354)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_COA_Balances"
        Me.Text = "Balances"
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        
        CType(Me.RepositoryItemLookUpEditCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Statement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Level As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOA_Normal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance_Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginning_Balance_Debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeginning_Balance_Credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnding_Balance_Debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnding_Balance_Credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLedger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents RepositoryItemLookUpEditCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
    
End Class
