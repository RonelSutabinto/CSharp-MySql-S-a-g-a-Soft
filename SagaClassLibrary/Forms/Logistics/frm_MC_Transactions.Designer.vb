Namespace Forms.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_MC_Transactions
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MC_Transactions))
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Load = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Load_All = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Preview_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview_Unit_Costing = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_New = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_New_Wizard = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar_Units = New DevExpress.XtraBars.Bar()
            Me.btn_MC_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New_Row = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Orders = New DevExpress.XtraBars.Bar()
            Me.btn_Reload_Unit_Orders = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Recount = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Transport = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Receive = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Confirm = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Purchase_Order = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Add_To_PO = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_MC_Transaction = New SagaClassLibrary.Controls.Logistics.xuc_MC_Transaction()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_MC_Transaction_Units = New SagaClassLibrary.Controls.Logistics.xuc_MC_Transaction_Units()
            Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Purchase_Order_Units = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.DockPanel5 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel5_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.gridControl_Invoices = New DevExpress.XtraGrid.GridControl()
            Me.gridView_Invoices = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Code_Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Name_Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Color_Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity_Invoice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colisUpdated = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Units = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_From = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Unit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_VAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGrand_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDue_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReceived_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWHCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colError_Counter = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.PopupMenu_Unit_Orders = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.StepProgressBar = New DevExpress.XtraEditors.StepProgressBar()
            Me.StepProgressBarItemApproval = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItemTransport = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItemReceived = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.StepProgressBarItemConfirmed = New DevExpress.XtraEditors.StepProgressBarItem()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Load, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.DockPanel4.SuspendLayout()
            Me.DockPanel4_Container.SuspendLayout()
            Me.DockPanel3.SuspendLayout()
            Me.DockPanel3_Container.SuspendLayout()
            Me.DockPanel5.SuspendLayout()
            Me.DockPanel5_Container.SuspendLayout()
            CType(Me.gridControl_Invoices, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_Invoices, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StepProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.BarManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.panelContainer1})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3, Me.Bar4, Me.Bar_Units, Me.Bar_Journal, Me.Bar_Orders})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Reload, Me.btn_New, Me.btn_Save, Me.btn_Delete, Me.btn_Close, Me.btn_Preview, Me.btn_Reload_Unit_Orders, Me.btn_Approve, Me.btn_Generate, Me.btn_Save_Unit_Items, Me.btn_Reload_Unit_Items, Me.btn_Preview_Units, Me.btn_Delete_Unit_Items, Me.btn_Approval, Me.btn_DisApprove, Me.btn_Transport, Me.btn_Receive, Me.btn_Confirm, Me.btn_New_Row, Me.barEditItem_Branch, Me.btn_Reload_Purchase_Order, Me.btn_Recount, Me.btn_Preview_Unit_Costing, Me.btn_Journal, Me.btn_Journal_Entries, Me.btn_Stop, Me.btn_Verify, Me.btn_Update, Me.btn_Add_To_PO, Me.btn_MC_Units, Me.btn_New_Wizard, Me.btn_Load_All})
            Me.BarManager.MaxItemId = 51
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
            Me.BarManager.StatusBar = Me.Bar3
            '
            'Bar1
            '
            Me.Bar1.BarName = "Actions"
            Me.Bar1.DockCol = 1
            Me.Bar1.DockRow = 0
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar1.Offset = 160
            Me.Bar1.Text = "Actions"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 0
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Load
            Me.btn_Reload.Id = 3
            Me.btn_Reload.Name = "btn_Reload"
            '
            'PopupMenu_Load
            '
            Me.PopupMenu_Load.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_All)})
            Me.PopupMenu_Load.Manager = Me.BarManager
            Me.PopupMenu_Load.Name = "PopupMenu_Load"
            '
            'btn_Load_All
            '
            Me.btn_Load_All.Caption = "Load All"
            Me.btn_Load_All.Id = 50
            Me.btn_Load_All.ImageOptions.Image = CType(resources.GetObject("btn_Load_All.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_All.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_All.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_All.Name = "btn_Load_All"
            '
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
            Me.btn_Preview.Id = 8
            Me.btn_Preview.Name = "btn_Preview"
            '
            'PopupMenu_Preview
            '
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Units), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Unit_Costing)})
            Me.PopupMenu_Preview.Manager = Me.BarManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Preview_Units
            '
            Me.btn_Preview_Units.Caption = "Preview Unit Items"
            Me.btn_Preview_Units.Id = 27
            Me.btn_Preview_Units.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Units.Name = "btn_Preview_Units"
            '
            'btn_Preview_Unit_Costing
            '
            Me.btn_Preview_Unit_Costing.Caption = "Preview Unit Costing"
            Me.btn_Preview_Unit_Costing.Id = 41
            Me.btn_Preview_Unit_Costing.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Unit_Costing.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Unit_Costing.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Unit_Costing.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Unit_Costing.Name = "btn_Preview_Unit_Costing"
            '
            'btn_New
            '
            Me.btn_New.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_New.Caption = "New"
            Me.btn_New.DropDownControl = Me.PopupMenu_New
            Me.btn_New.Id = 4
            Me.btn_New.Name = "btn_New"
            '
            'PopupMenu_New
            '
            Me.PopupMenu_New.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New_Wizard)})
            Me.PopupMenu_New.Manager = Me.BarManager
            Me.PopupMenu_New.Name = "PopupMenu_New"
            '
            'btn_New_Wizard
            '
            Me.btn_New_Wizard.Caption = "New Receive/Transfer/Deposit Wizard"
            Me.btn_New_Wizard.Id = 49
            Me.btn_New_Wizard.Name = "btn_New_Wizard"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 5
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 6
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 7
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Status bar"
            Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.Bar3.DockCol = 0
            Me.Bar3.DockRow = 0
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.Bar3.OptionsBar.AllowQuickCustomization = False
            Me.Bar3.OptionsBar.DrawDragBorder = False
            Me.Bar3.OptionsBar.UseWholeRow = True
            Me.Bar3.Text = "Status bar"
            Me.Bar3.Visible = False
            '
            'Bar4
            '
            Me.Bar4.BarName = "Parameters"
            Me.Bar4.DockCol = 0
            Me.Bar4.DockRow = 0
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.Bar4.Text = "Parameters"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Caption = "Branch"
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 35
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "BarEditItem1"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 2
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar_Units
            '
            Me.Bar_Units.BarName = "Units"
            Me.Bar_Units.DockCol = 2
            Me.Bar_Units.DockRow = 1
            Me.Bar_Units.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Units.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MC_Units), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New_Row), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Unit_Items)})
            Me.Bar_Units.Offset = 270
            Me.Bar_Units.Text = "Units"
            '
            'btn_MC_Units
            '
            Me.btn_MC_Units.Caption = "MC Units"
            Me.btn_MC_Units.Id = 48
            Me.btn_MC_Units.ImageOptions.Image = CType(resources.GetObject("btn_MC_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_MC_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_MC_Units.Name = "btn_MC_Units"
            '
            'btn_New_Row
            '
            Me.btn_New_Row.Caption = "Insert New Unit"
            Me.btn_New_Row.Id = 34
            Me.btn_New_Row.ImageOptions.Image = CType(resources.GetObject("btn_New_Row.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_New_Row.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Row.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_New_Row.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
            Me.btn_New_Row.Name = "btn_New_Row"
            '
            'btn_Save_Unit_Items
            '
            Me.btn_Save_Unit_Items.Caption = "Save Units"
            Me.btn_Save_Unit_Items.Id = 25
            Me.btn_Save_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Save_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Unit_Items.Name = "btn_Save_Unit_Items"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 0
            Me.Bar_Journal.DockRow = 1
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar_Journal.Text = "Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 43
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 42
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 45
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 44
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar_Orders
            '
            Me.Bar_Orders.BarName = "Orders"
            Me.Bar_Orders.DockCol = 1
            Me.Bar_Orders.DockRow = 1
            Me.Bar_Orders.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount)})
            Me.Bar_Orders.Offset = 253
            Me.Bar_Orders.Text = "Orders"
            '
            'btn_Reload_Unit_Orders
            '
            Me.btn_Reload_Unit_Orders.Caption = "Reload Unit Orders"
            Me.btn_Reload_Unit_Orders.Id = 16
            Me.btn_Reload_Unit_Orders.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Unit_Orders.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Unit_Orders.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Unit_Orders.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Unit_Orders.Name = "btn_Reload_Unit_Orders"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "Generate"
            Me.btn_Generate.Id = 24
            Me.btn_Generate.ImageOptions.Image = CType(resources.GetObject("btn_Generate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Generate.ImageOptions.LargeImage = CType(resources.GetObject("btn_Generate.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Generate.Name = "btn_Generate"
            '
            'btn_Recount
            '
            Me.btn_Recount.Caption = "Recount"
            Me.btn_Recount.Id = 39
            Me.btn_Recount.ImageOptions.Image = CType(resources.GetObject("btn_Recount.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Recount.ImageOptions.LargeImage = CType(resources.GetObject("btn_Recount.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Recount.Name = "btn_Recount"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(898, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 548)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(898, 20)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 503)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(898, 45)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 503)
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 23
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Reload_Unit_Items
            '
            Me.btn_Reload_Unit_Items.Caption = "Reload Unit Items"
            Me.btn_Reload_Unit_Items.Id = 26
            Me.btn_Reload_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Unit_Items.Name = "btn_Reload_Unit_Items"
            '
            'btn_Delete_Unit_Items
            '
            Me.btn_Delete_Unit_Items.Caption = "Delete"
            Me.btn_Delete_Unit_Items.Id = 28
            Me.btn_Delete_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Delete_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Delete_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Delete_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Delete_Unit_Items.Name = "btn_Delete_Unit_Items"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "For Approval"
            Me.btn_Approval.Id = 29
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "Disapprove"
            Me.btn_DisApprove.Id = 30
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'btn_Transport
            '
            Me.btn_Transport.Caption = "For Transport"
            Me.btn_Transport.Id = 31
            Me.btn_Transport.ImageOptions.Image = CType(resources.GetObject("btn_Transport.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Transport.ImageOptions.LargeImage = CType(resources.GetObject("btn_Transport.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Transport.Name = "btn_Transport"
            '
            'btn_Receive
            '
            Me.btn_Receive.Caption = "Receive"
            Me.btn_Receive.Id = 32
            Me.btn_Receive.ImageOptions.Image = CType(resources.GetObject("btn_Receive.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Receive.ImageOptions.LargeImage = CType(resources.GetObject("btn_Receive.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Receive.Name = "btn_Receive"
            '
            'btn_Confirm
            '
            Me.btn_Confirm.Caption = "Confirm / Approve"
            Me.btn_Confirm.Id = 33
            Me.btn_Confirm.ImageOptions.Image = CType(resources.GetObject("btn_Confirm.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Confirm.ImageOptions.LargeImage = CType(resources.GetObject("btn_Confirm.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Confirm.Name = "btn_Confirm"
            '
            'btn_Reload_Purchase_Order
            '
            Me.btn_Reload_Purchase_Order.Caption = "Load Purchase Order"
            Me.btn_Reload_Purchase_Order.Id = 38
            Me.btn_Reload_Purchase_Order.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Purchase_Order.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Purchase_Order.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Purchase_Order.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Purchase_Order.Name = "btn_Reload_Purchase_Order"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 46
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Add_To_PO
            '
            Me.btn_Add_To_PO.Caption = "Add to P.O."
            Me.btn_Add_To_PO.Id = 47
            Me.btn_Add_To_PO.ImageOptions.Image = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Add_To_PO.ImageOptions.LargeImage = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Add_To_PO.Name = "btn_Add_To_PO"
            '
            'RepositoryItemDateEdit1
            '
            Me.RepositoryItemDateEdit1.AutoHeight = False
            Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
            '
            'RepositoryItemDateEdit2
            '
            Me.RepositoryItemDateEdit2.AutoHeight = False
            Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("c4f0a519-4d96-443d-8b06-14937c864a67")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(286, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(286, 503)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_MC_Transaction)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 474)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_MC_Transaction
            '
            Me.xuc_MC_Transaction.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_MC_Transaction.Location = New System.Drawing.Point(0, 0)
            Me.xuc_MC_Transaction.Name = "xuc_MC_Transaction"
            Me.xuc_MC_Transaction.Size = New System.Drawing.Size(279, 474)
            Me.xuc_MC_Transaction.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba")
            Me.DockPanel2.Location = New System.Drawing.Point(618, 45)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 503)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 474)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 474)
            Me.xuc_Settings.TabIndex = 0
            '
            'panelContainer1
            '
            Me.panelContainer1.ActiveChild = Me.DockPanel4
            Me.panelContainer1.Controls.Add(Me.DockPanel3)
            Me.panelContainer1.Controls.Add(Me.DockPanel5)
            Me.panelContainer1.Controls.Add(Me.DockPanel4)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.panelContainer1.ID = New System.Guid("b2e15568-e343-44b2-a582-1e42457b94b2")
            Me.panelContainer1.Location = New System.Drawing.Point(286, 354)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 194)
            Me.panelContainer1.Size = New System.Drawing.Size(332, 194)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            '
            'DockPanel4
            '
            Me.DockPanel4.Controls.Add(Me.DockPanel4_Container)
            Me.DockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.DockPanel4.FloatVertical = True
            Me.DockPanel4.ID = New System.Guid("cc3bc70e-9103-4a8e-af0b-ec58fccaea09")
            Me.DockPanel4.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel4.Name = "DockPanel4"
            Me.DockPanel4.OriginalSize = New System.Drawing.Size(310, 138)
            Me.DockPanel4.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel4.Text = "MC Transaction Units/Items"
            '
            'DockPanel4_Container
            '
            Me.DockPanel4_Container.Controls.Add(Me.xuc_MC_Transaction_Units)
            Me.DockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel4_Container.Name = "DockPanel4_Container"
            Me.DockPanel4_Container.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel4_Container.TabIndex = 0
            '
            'xuc_MC_Transaction_Units
            '
            Me.xuc_MC_Transaction_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_MC_Transaction_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_MC_Transaction_Units.Name = "xuc_MC_Transaction_Units"
            Me.xuc_MC_Transaction_Units.Size = New System.Drawing.Size(326, 138)
            Me.xuc_MC_Transaction_Units.TabIndex = 0
            '
            'DockPanel3
            '
            Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
            Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.DockPanel3.ID = New System.Guid("21bc6ef0-e942-4840-bdb9-47f86922a12c")
            Me.DockPanel3.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel3.Name = "DockPanel3"
            Me.DockPanel3.OriginalSize = New System.Drawing.Size(310, 138)
            Me.DockPanel3.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel3.Text = "Purchase Order"
            '
            'DockPanel3_Container
            '
            Me.DockPanel3_Container.Controls.Add(Me.xuc_Purchase_Order_Units)
            Me.DockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel3_Container.Name = "DockPanel3_Container"
            Me.DockPanel3_Container.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel3_Container.TabIndex = 0
            '
            'xuc_Purchase_Order_Units
            '
            Me.xuc_Purchase_Order_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Purchase_Order_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Purchase_Order_Units.Name = "xuc_Purchase_Order_Units"
            Me.xuc_Purchase_Order_Units.Size = New System.Drawing.Size(326, 138)
            Me.xuc_Purchase_Order_Units.TabIndex = 0
            '
            'DockPanel5
            '
            Me.DockPanel5.Controls.Add(Me.DockPanel5_Container)
            Me.DockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.DockPanel5.FloatVertical = True
            Me.DockPanel5.ID = New System.Guid("ba7a8421-118d-410b-a038-bf1423867a2c")
            Me.DockPanel5.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel5.Name = "DockPanel5"
            Me.DockPanel5.OriginalSize = New System.Drawing.Size(310, 138)
            Me.DockPanel5.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel5.Text = "Invoices"
            '
            'DockPanel5_Container
            '
            Me.DockPanel5_Container.Controls.Add(Me.gridControl_Invoices)
            Me.DockPanel5_Container.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel5_Container.Name = "DockPanel5_Container"
            Me.DockPanel5_Container.Size = New System.Drawing.Size(326, 138)
            Me.DockPanel5_Container.TabIndex = 0
            '
            'gridControl_Invoices
            '
            Me.gridControl_Invoices.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_Invoices.Location = New System.Drawing.Point(0, 0)
            Me.gridControl_Invoices.MainView = Me.gridView_Invoices
            Me.gridControl_Invoices.MenuManager = Me.BarManager
            Me.gridControl_Invoices.Name = "gridControl_Invoices"
            Me.gridControl_Invoices.Size = New System.Drawing.Size(326, 138)
            Me.gridControl_Invoices.TabIndex = 1
            Me.gridControl_Invoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_Invoices})
            '
            'gridView_Invoices
            '
            Me.gridView_Invoices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Invoice, Me.colInvoice_Status, Me.colOrder_Code_Invoice, Me.colInvoice_Number, Me.colModel_Code, Me.colModel_Name_Invoice, Me.colModel_Color_Invoice, Me.colQuantity_Invoice, Me.colInvoice_Description})
            Me.gridView_Invoices.GridControl = Me.gridControl_Invoices
            Me.gridView_Invoices.Name = "gridView_Invoices"
            '
            'colID_Invoice
            '
            Me.colID_Invoice.FieldName = "ID"
            Me.colID_Invoice.Name = "colID_Invoice"
            Me.colID_Invoice.Visible = True
            Me.colID_Invoice.VisibleIndex = 0
            '
            'colInvoice_Status
            '
            Me.colInvoice_Status.FieldName = "Invoice_Status"
            Me.colInvoice_Status.Name = "colInvoice_Status"
            Me.colInvoice_Status.Visible = True
            Me.colInvoice_Status.VisibleIndex = 1
            '
            'colOrder_Code_Invoice
            '
            Me.colOrder_Code_Invoice.FieldName = "Order_Code"
            Me.colOrder_Code_Invoice.Name = "colOrder_Code_Invoice"
            Me.colOrder_Code_Invoice.Visible = True
            Me.colOrder_Code_Invoice.VisibleIndex = 2
            '
            'colInvoice_Number
            '
            Me.colInvoice_Number.FieldName = "Invoice_Number"
            Me.colInvoice_Number.Name = "colInvoice_Number"
            Me.colInvoice_Number.Visible = True
            Me.colInvoice_Number.VisibleIndex = 3
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 4
            '
            'colModel_Name_Invoice
            '
            Me.colModel_Name_Invoice.FieldName = "Model_Name"
            Me.colModel_Name_Invoice.Name = "colModel_Name_Invoice"
            Me.colModel_Name_Invoice.Visible = True
            Me.colModel_Name_Invoice.VisibleIndex = 5
            '
            'colModel_Color_Invoice
            '
            Me.colModel_Color_Invoice.FieldName = "Model_Color"
            Me.colModel_Color_Invoice.Name = "colModel_Color_Invoice"
            Me.colModel_Color_Invoice.Visible = True
            Me.colModel_Color_Invoice.VisibleIndex = 6
            '
            'colQuantity_Invoice
            '
            Me.colQuantity_Invoice.FieldName = "Quantity"
            Me.colQuantity_Invoice.Name = "colQuantity_Invoice"
            Me.colQuantity_Invoice.Visible = True
            Me.colQuantity_Invoice.VisibleIndex = 7
            '
            'colInvoice_Description
            '
            Me.colInvoice_Description.FieldName = "Invoice_Description"
            Me.colInvoice_Description.Name = "colInvoice_Description"
            Me.colInvoice_Description.Visible = True
            Me.colInvoice_Description.VisibleIndex = 8
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(286, 135)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(332, 219)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colStatus, Me.colIsJournal, Me.colisUpdated, Me.colTransaction_Type, Me.colTransaction_Code, Me.colReference, Me.colOrder_Code, Me.colTotal_Units, Me.colSupplier, Me.colBranch_From, Me.colBranch_Code, Me.colFreight_Cost, Me.colTotal_Unit_Cost, Me.colTotal_VAT, Me.colGrand_Total, Me.colDue_Date, Me.colReceived_Date, Me.colTransaction_Date, Me.colApproved_By, Me.colApproved_Date, Me.colUnit_Status, Me.colWHCategory, Me.colDescription, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colError_Counter})
            Me.gridView.GridControl = Me.gridControl
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
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "InventoryStatus"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 1
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 2
            '
            'colisUpdated
            '
            Me.colisUpdated.Caption = "Updated"
            Me.colisUpdated.FieldName = "isUpdated"
            Me.colisUpdated.Name = "colisUpdated"
            Me.colisUpdated.Visible = True
            Me.colisUpdated.VisibleIndex = 3
            '
            'colTransaction_Type
            '
            Me.colTransaction_Type.Caption = "Type"
            Me.colTransaction_Type.FieldName = "SourceEvent"
            Me.colTransaction_Type.Name = "colTransaction_Type"
            Me.colTransaction_Type.Visible = True
            Me.colTransaction_Type.VisibleIndex = 4
            '
            'colTransaction_Code
            '
            Me.colTransaction_Code.Caption = "Transaction Code"
            Me.colTransaction_Code.FieldName = "TransCode"
            Me.colTransaction_Code.Name = "colTransaction_Code"
            Me.colTransaction_Code.Visible = True
            Me.colTransaction_Code.VisibleIndex = 5
            '
            'colReference
            '
            Me.colReference.Caption = "Reference"
            Me.colReference.FieldName = "RefNo"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 6
            '
            'colOrder_Code
            '
            Me.colOrder_Code.Caption = "P. O. Number"
            Me.colOrder_Code.FieldName = "PoNo"
            Me.colOrder_Code.Name = "colOrder_Code"
            Me.colOrder_Code.Visible = True
            Me.colOrder_Code.VisibleIndex = 7
            '
            'colTotal_Units
            '
            Me.colTotal_Units.Caption = "Total Units"
            Me.colTotal_Units.FieldName = "ItemCnt"
            Me.colTotal_Units.Name = "colTotal_Units"
            Me.colTotal_Units.Visible = True
            Me.colTotal_Units.VisibleIndex = 8
            '
            'colSupplier
            '
            Me.colSupplier.Caption = "Supplier"
            Me.colSupplier.FieldName = "Vendor"
            Me.colSupplier.Name = "colSupplier"
            Me.colSupplier.Visible = True
            Me.colSupplier.VisibleIndex = 9
            '
            'colBranch_From
            '
            Me.colBranch_From.Caption = "Branch From"
            Me.colBranch_From.FieldName = "VendorCode"
            Me.colBranch_From.Name = "colBranch_From"
            Me.colBranch_From.Visible = True
            Me.colBranch_From.VisibleIndex = 10
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch To"
            Me.colBranch_Code.FieldName = "BranchCode"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 11
            '
            'colFreight_Cost
            '
            Me.colFreight_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost.FieldName = "Freight_Cost"
            Me.colFreight_Cost.Name = "colFreight_Cost"
            Me.colFreight_Cost.Visible = True
            Me.colFreight_Cost.VisibleIndex = 12
            '
            'colTotal_Unit_Cost
            '
            Me.colTotal_Unit_Cost.Caption = "Total Cost"
            Me.colTotal_Unit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Unit_Cost.FieldName = "TotalUnitCost"
            Me.colTotal_Unit_Cost.Name = "colTotal_Unit_Cost"
            Me.colTotal_Unit_Cost.Visible = True
            Me.colTotal_Unit_Cost.VisibleIndex = 13
            '
            'colTotal_VAT
            '
            Me.colTotal_VAT.Caption = "Total VAT"
            Me.colTotal_VAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_VAT.FieldName = "TotalVATAmt"
            Me.colTotal_VAT.Name = "colTotal_VAT"
            Me.colTotal_VAT.Visible = True
            Me.colTotal_VAT.VisibleIndex = 14
            '
            'colGrand_Total
            '
            Me.colGrand_Total.Caption = "Grand Total"
            Me.colGrand_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colGrand_Total.FieldName = "GrandTotalUnitCost"
            Me.colGrand_Total.Name = "colGrand_Total"
            Me.colGrand_Total.Visible = True
            Me.colGrand_Total.VisibleIndex = 15
            '
            'colDue_Date
            '
            Me.colDue_Date.FieldName = "Due_Date"
            Me.colDue_Date.Name = "colDue_Date"
            Me.colDue_Date.Visible = True
            Me.colDue_Date.VisibleIndex = 16
            '
            'colReceived_Date
            '
            Me.colReceived_Date.Caption = "Received Date"
            Me.colReceived_Date.FieldName = "DateReceived"
            Me.colReceived_Date.Name = "colReceived_Date"
            Me.colReceived_Date.Visible = True
            Me.colReceived_Date.VisibleIndex = 17
            '
            'colTransaction_Date
            '
            Me.colTransaction_Date.Caption = "Transaction Date"
            Me.colTransaction_Date.FieldName = "TransactionDate"
            Me.colTransaction_Date.Name = "colTransaction_Date"
            Me.colTransaction_Date.Visible = True
            Me.colTransaction_Date.VisibleIndex = 18
            '
            'colApproved_By
            '
            Me.colApproved_By.Caption = "Approved By"
            Me.colApproved_By.FieldName = "Approver"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 19
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "DateApproved"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 20
            '
            'colUnit_Status
            '
            Me.colUnit_Status.Caption = "Unit Status"
            Me.colUnit_Status.FieldName = "WHCode"
            Me.colUnit_Status.Name = "colUnit_Status"
            Me.colUnit_Status.Visible = True
            Me.colUnit_Status.VisibleIndex = 21
            '
            'colWHCategory
            '
            Me.colWHCategory.Caption = "Category"
            Me.colWHCategory.FieldName = "WHCategory"
            Me.colWHCategory.Name = "colWHCategory"
            Me.colWHCategory.Visible = True
            Me.colWHCategory.VisibleIndex = 22
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Remarks"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 23
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Note"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 24
            '
            'colAdded_By
            '
            Me.colAdded_By.Caption = "Added By"
            Me.colAdded_By.FieldName = "TransactedBy"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 25
            '
            'colAdded_Date
            '
            Me.colAdded_Date.Caption = "Added Date"
            Me.colAdded_Date.FieldName = "TransactionDate"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 26
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 27
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 28
            '
            'colError_Counter
            '
            Me.colError_Counter.FieldName = "Error_Counter"
            Me.colError_Counter.Name = "colError_Counter"
            Me.colError_Counter.Visible = True
            Me.colError_Counter.VisibleIndex = 29
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Items), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Transport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Receive), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Confirm), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'PopupMenu_Unit_Orders
            '
            Me.PopupMenu_Unit_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu_Unit_Orders.Manager = Me.BarManager
            Me.PopupMenu_Unit_Orders.Name = "PopupMenu_Unit_Orders"
            '
            'Bar2
            '
            Me.Bar2.BarName = "Custom 7"
            Me.Bar2.DockCol = 1
            Me.Bar2.DockRow = 1
            Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar2.FloatLocation = New System.Drawing.Point(511, 204)
            Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders)})
            Me.Bar2.Offset = 234
            Me.Bar2.Text = "Custom 7"
            '
            'StepProgressBar
            '
            Me.StepProgressBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItemApproval)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItemTransport)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItemReceived)
            Me.StepProgressBar.Items.Add(Me.StepProgressBarItemConfirmed)
            Me.StepProgressBar.Location = New System.Drawing.Point(286, 45)
            Me.StepProgressBar.Name = "StepProgressBar"
            Me.StepProgressBar.Size = New System.Drawing.Size(332, 90)
            Me.StepProgressBar.TabIndex = 14
            '
            'StepProgressBarItemApproval
            '
            Me.StepProgressBarItemApproval.ContentBlock2.Caption = "Approval"
            Me.StepProgressBarItemApproval.ContentBlock2.Description = "Sent to Approval"
            Me.StepProgressBarItemApproval.Name = "StepProgressBarItemApproval"
            Me.StepProgressBarItemApproval.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemApproval.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItemApproval.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemApproval.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItemTransport
            '
            Me.StepProgressBarItemTransport.ContentBlock2.Caption = "Transport"
            Me.StepProgressBarItemTransport.ContentBlock2.Description = "Sent for Transport"
            Me.StepProgressBarItemTransport.Name = "StepProgressBarItemTransport"
            Me.StepProgressBarItemTransport.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemTransport.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItemTransport.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemTransport.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItemReceived
            '
            Me.StepProgressBarItemReceived.ContentBlock2.Caption = "Received"
            Me.StepProgressBarItemReceived.ContentBlock2.Description = "Received by Branch"
            Me.StepProgressBarItemReceived.Name = "StepProgressBarItemReceived"
            Me.StepProgressBarItemReceived.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemReceived.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItemReceived.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemReceived.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'StepProgressBarItemConfirmed
            '
            Me.StepProgressBarItemConfirmed.ContentBlock2.Caption = "Confirmed"
            Me.StepProgressBarItemConfirmed.ContentBlock2.Description = "Received and Confirmed"
            Me.StepProgressBarItemConfirmed.Name = "StepProgressBarItemConfirmed"
            Me.StepProgressBarItemConfirmed.Options.Indicator.ActiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemConfirmed.Options.Indicator.ActiveStateImageOptions.Image"), System.Drawing.Image)
            Me.StepProgressBarItemConfirmed.Options.Indicator.InactiveStateImageOptions.Image = CType(resources.GetObject("StepProgressBarItemConfirmed.Options.Indicator.InactiveStateImageOptions.Image"), System.Drawing.Image)
            '
            'frm_MC_Transactions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 568)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.StepProgressBar)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_MC_Transactions"
            Me.Text = "frm_MC_Transactions"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Load, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.DockPanel4.ResumeLayout(False)
            Me.DockPanel4_Container.ResumeLayout(False)
            Me.DockPanel3.ResumeLayout(False)
            Me.DockPanel3_Container.ResumeLayout(False)
            Me.DockPanel5.ResumeLayout(False)
            Me.DockPanel5_Container.ResumeLayout(False)
            CType(Me.gridControl_Invoices, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_Invoices, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StepProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Public WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents Bar_Units As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload_Unit_Orders As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Public WithEvents xuc_MC_Transaction As Controls.Logistics.xuc_MC_Transaction
        Friend WithEvents colTransaction_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Units As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_From As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDue_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSupplier As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReceived_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel4 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Unit_Orders As DevExpress.XtraBars.PopupMenu
        Public WithEvents btn_Save_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview_Units As DevExpress.XtraBars.BarButtonItem
        Public WithEvents btn_Delete_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colError_Counter As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Transport As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Receive As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Confirm As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New_Row As DevExpress.XtraBars.BarButtonItem
        Public WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents btn_Reload_Purchase_Order As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Recount As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colisUpdated As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Unit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_VAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Preview_Unit_Costing As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents gridControl_Invoices As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_Invoices As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Name_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Color_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuantity_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DockPanel5 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel5_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents colInvoice_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Code_Invoice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Add_To_PO As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_MC_Transaction_Units As Controls.Logistics.xuc_MC_Transaction_Units
        Friend WithEvents btn_MC_Units As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_New As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_New_Wizard As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Purchase_Order_Units As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents Bar_Orders As DevExpress.XtraBars.Bar
        Friend WithEvents colWHCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu_Load As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Load_All As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents StepProgressBar As DevExpress.XtraEditors.StepProgressBar
        Friend WithEvents StepProgressBarItemApproval As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItemTransport As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItemReceived As DevExpress.XtraEditors.StepProgressBarItem
        Friend WithEvents StepProgressBarItemConfirmed As DevExpress.XtraEditors.StepProgressBarItem
    End Class
End Namespace