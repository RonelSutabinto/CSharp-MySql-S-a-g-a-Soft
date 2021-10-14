Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Budgets
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Budgets))
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.btn_Add_Debit = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Budget = New SagaClassLibrary.Controls.Accounting.xuc_Budget()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.gridControl_Ledger = New DevExpress.XtraGrid.GridControl()
            Me.gridView_Ledger = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.ID_Ledger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Beginning = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Ending = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger_Added_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger_Added_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger_Modified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger_Modified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            Me.DockPanel3.SuspendLayout()
            Me.DockPanel3_Container.SuspendLayout()
            CType(Me.gridControl_Ledger, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_Ledger, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar3})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Add_Debit})
            Me.barManager.MaxItemId = 11
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 61
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 8
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
            Me.btn_Preview.Id = 7
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
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
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(333, 191)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 9
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 7
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Custom 4"
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 1
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add_Debit)})
            Me.Bar3.Text = "Custom 4"
            '
            'btn_Add_Debit
            '
            Me.btn_Add_Debit.Caption = "Add Debit"
            Me.btn_Add_Debit.Id = 10
            Me.btn_Add_Debit.ImageOptions.Image = CType(resources.GetObject("btn_Add_Debit.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Add_Debit.ImageOptions.LargeImage = CType(resources.GetObject("btn_Add_Debit.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Add_Debit.Name = "btn_Add_Debit"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(894, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 550)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(894, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 505)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(894, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 505)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("1b83ff20-3292-4f5e-93d0-344f01856ba1")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(291, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(291, 505)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Budget)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(284, 476)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Budget
            '
            Me.xuc_Budget.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Budget.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Budget.Name = "xuc_Budget"
            Me.xuc_Budget.Size = New System.Drawing.Size(284, 476)
            Me.xuc_Budget.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("28045089-1752-435a-8634-f7976ab6b5ec")
            Me.DockPanel2.Location = New System.Drawing.Point(694, 45)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 505)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 476)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(193, 476)
            Me.xuc_Settings.TabIndex = 0
            '
            'DockPanel3
            '
            Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
            Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.DockPanel3.ID = New System.Guid("46f09e39-2b4f-4d2a-a96f-4f088e2b4bff")
            Me.DockPanel3.Location = New System.Drawing.Point(291, 350)
            Me.DockPanel3.Name = "DockPanel3"
            Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel3.Size = New System.Drawing.Size(403, 200)
            Me.DockPanel3.Text = "Ledger"
            '
            'DockPanel3_Container
            '
            Me.DockPanel3_Container.Controls.Add(Me.gridControl_Ledger)
            Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel3_Container.Name = "DockPanel3_Container"
            Me.DockPanel3_Container.Size = New System.Drawing.Size(397, 170)
            Me.DockPanel3_Container.TabIndex = 0
            '
            'gridControl_Ledger
            '
            Me.gridControl_Ledger.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_Ledger.Location = New System.Drawing.Point(0, 0)
            Me.gridControl_Ledger.MainView = Me.gridView_Ledger
            Me.gridControl_Ledger.Name = "gridControl_Ledger"
            Me.gridControl_Ledger.Size = New System.Drawing.Size(397, 170)
            Me.gridControl_Ledger.TabIndex = 11
            Me.gridControl_Ledger.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_Ledger})
            '
            'gridView_Ledger
            '
            Me.gridView_Ledger.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID_Ledger, Me.colVoucher_Code, Me.colVoucher_Reference, Me.colBudget_Beginning, Me.colBudget_Debit, Me.colBudget_Credit, Me.colBudget_Ending, Me.colLedger_Description, Me.colLedger_Added_By, Me.colLedger_Added_Date, Me.colLedger_Modified_By, Me.colLedger_Modified_Date})
            Me.gridView_Ledger.gridControl = Me.gridControl_Ledger
            Me.gridView_Ledger.Name = "gridView_Ledger"
            Me.gridView_Ledger.OptionsView.ColumnAutoWidth = False
            '
            'ID_Ledger
            '
            Me.ID_Ledger.FieldName = "ID"
            Me.ID_Ledger.Name = "ID_Ledger"
            Me.ID_Ledger.Visible = True
            Me.ID_Ledger.VisibleIndex = 0
            '
            'colVoucher_Code
            '
            Me.colVoucher_Code.FieldName = "Voucher_Code"
            Me.colVoucher_Code.Name = "colVoucher_Code"
            Me.colVoucher_Code.Visible = True
            Me.colVoucher_Code.VisibleIndex = 1
            '
            'colBudget_Beginning
            '
            Me.colBudget_Beginning.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Beginning.FieldName = "Budget_Beginning"
            Me.colBudget_Beginning.Name = "colBudget_Beginning"
            Me.colBudget_Beginning.Visible = True
            Me.colBudget_Beginning.VisibleIndex = 3
            '
            'colBudget_Debit
            '
            Me.colBudget_Debit.Caption = "Debit"
            Me.colBudget_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Debit.FieldName = "Budget_Debit"
            Me.colBudget_Debit.Name = "colBudget_Debit"
            Me.colBudget_Debit.Visible = True
            Me.colBudget_Debit.VisibleIndex = 4
            '
            'colBudget_Credit
            '
            Me.colBudget_Credit.Caption = "Credit"
            Me.colBudget_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Credit.FieldName = "Budget_Credit"
            Me.colBudget_Credit.Name = "colBudget_Credit"
            Me.colBudget_Credit.Visible = True
            Me.colBudget_Credit.VisibleIndex = 5
            '
            'colBudget_Ending
            '
            Me.colBudget_Ending.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Ending.FieldName = "Budget_Ending"
            Me.colBudget_Ending.Name = "colBudget_Ending"
            Me.colBudget_Ending.Visible = True
            Me.colBudget_Ending.VisibleIndex = 6
            '
            'colLedger_Description
            '
            Me.colLedger_Description.Caption = "Description"
            Me.colLedger_Description.FieldName = "Ledger_Description"
            Me.colLedger_Description.Name = "colLedger_Description"
            Me.colLedger_Description.Visible = True
            Me.colLedger_Description.VisibleIndex = 7
            '
            'colLedger_Added_By
            '
            Me.colLedger_Added_By.Caption = "Added By"
            Me.colLedger_Added_By.FieldName = "Added_By"
            Me.colLedger_Added_By.Name = "colLedger_Added_By"
            Me.colLedger_Added_By.Visible = True
            Me.colLedger_Added_By.VisibleIndex = 8
            '
            'colLedger_Added_Date
            '
            Me.colLedger_Added_Date.Caption = "Added Date"
            Me.colLedger_Added_Date.FieldName = "Added_Date"
            Me.colLedger_Added_Date.Name = "colLedger_Added_Date"
            Me.colLedger_Added_Date.Visible = True
            Me.colLedger_Added_Date.VisibleIndex = 9
            '
            'colLedger_Modified_By
            '
            Me.colLedger_Modified_By.Caption = "Modified By"
            Me.colLedger_Modified_By.FieldName = "Modified_By"
            Me.colLedger_Modified_By.Name = "colLedger_Modified_By"
            Me.colLedger_Modified_By.Visible = True
            Me.colLedger_Modified_By.VisibleIndex = 10
            '
            'colLedger_Modified_Date
            '
            Me.colLedger_Modified_Date.Caption = "Modified Date"
            Me.colLedger_Modified_Date.FieldName = "Modified_Date"
            Me.colLedger_Modified_Date.Name = "colLedger_Modified_Date"
            Me.colLedger_Modified_Date.Visible = True
            Me.colLedger_Modified_Date.VisibleIndex = 11
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(291, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(403, 305)
            Me.gridControl.TabIndex = 3
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBudget_Code, Me.colBudget_Name, Me.colBudget_Amount, Me.colBudget_Balance, Me.colBudget_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date})
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
            'colBudget_Code
            '
            Me.colBudget_Code.FieldName = "Budget_Code"
            Me.colBudget_Code.Name = "colBudget_Code"
            Me.colBudget_Code.Visible = True
            Me.colBudget_Code.VisibleIndex = 1
            '
            'colBudget_Name
            '
            Me.colBudget_Name.FieldName = "Budget_Name"
            Me.colBudget_Name.Name = "colBudget_Name"
            Me.colBudget_Name.Visible = True
            Me.colBudget_Name.VisibleIndex = 2
            '
            'colBudget_Amount
            '
            Me.colBudget_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Amount.FieldName = "Budget_Amount"
            Me.colBudget_Amount.Name = "colBudget_Amount"
            Me.colBudget_Amount.Visible = True
            Me.colBudget_Amount.VisibleIndex = 3
            '
            'colBudget_Balance
            '
            Me.colBudget_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget_Balance.FieldName = "Budget_Balance"
            Me.colBudget_Balance.Name = "colBudget_Balance"
            Me.colBudget_Balance.Visible = True
            Me.colBudget_Balance.VisibleIndex = 4
            '
            'colBudget_Description
            '
            Me.colBudget_Description.FieldName = "Budget_Description"
            Me.colBudget_Description.Name = "colBudget_Description"
            Me.colBudget_Description.Visible = True
            Me.colBudget_Description.VisibleIndex = 5
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 6
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 7
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 8
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 9
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 10
            '
            'colVoucher_Reference
            '
            Me.colVoucher_Reference.FieldName = "Voucher_Reference"
            Me.colVoucher_Reference.Name = "colVoucher_Reference"
            Me.colVoucher_Reference.Visible = True
            Me.colVoucher_Reference.VisibleIndex = 2
            '
            'frm_Budgets
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(894, 550)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel3)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Budgets"
            Me.Text = "Budgets"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            Me.DockPanel3.ResumeLayout(False)
            Me.DockPanel3_Container.ResumeLayout(False)
            CType(Me.gridControl_Ledger, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_Ledger, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Budget As Controls.Accounting.xuc_Budget
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Amount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridControl_Ledger As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_Ledger As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ID_Ledger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger_Added_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger_Added_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger_Modified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger_Modified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Add_Debit As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colBudget_Beginning As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Ending As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Reference As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace