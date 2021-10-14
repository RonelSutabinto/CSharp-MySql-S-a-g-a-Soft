Namespace Forms.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Purchase_Orders
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Purchase_Orders))
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reset = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Reload_All = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Modified = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Deleted = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Unit_Order_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Purchase_Order_Received = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Purchase_Order_Monitoring = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Purchase_Order_Summary = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_New = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_New_Wizard = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Bar_Orders = New DevExpress.XtraBars.Bar()
            Me.btn_MC_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unit_Order_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Recount = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unit_Order_Add = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Modify_Orders = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Order_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Purchase_Order = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Purchase_Order_Units = New SagaClassLibrary.Controls.Logistics.xuc_Purchase_Order_Units()
            Me.DockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.gridControl_Summary = New DevExpress.XtraGrid.GridControl()
            Me.gridView_Summary = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Color = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Brand_Code = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colOrder_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDue_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIs_Per_Unit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGrand_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost_Received_PO = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Remaining = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost_Remaining = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.PopupMenu_Unit_Orders = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.colPurchase_Order_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.DockPanel3.SuspendLayout()
            Me.DockPanel3_Container.SuspendLayout()
            Me.DockPanel4.SuspendLayout()
            Me.DockPanel4_Container.SuspendLayout()
            CType(Me.gridControl_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3, Me.Bar4, Me.Bar_Orders})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Reload, Me.btn_New, Me.btn_Save, Me.btn_Delete, Me.btn_Close, Me.btn_Preview, Me.btn_Reset, Me.btn_Unit_Order_Add, Me.btn_Unit_Order_Preview, Me.btn_Unit_Order_Reload, Me.btn_Modify_Orders, Me.btn_Reload_Modified, Me.btn_Reload_All, Me.btn_Reload_Deleted, Me.btn_Approve, Me.btn_Generate, Me.btn_Approval, Me.btn_DisApprove, Me.btn_Recount, Me.btn_Purchase_Order_Summary, Me.btn_Save_Order_Units, Me.btn_Purchase_Order_Received, Me.btn_Purchase_Order_Monitoring, Me.btn_MC_Units, Me.btn_New_Wizard})
            Me.BarManager.MainMenu = Me.Bar2
            Me.BarManager.MaxItemId = 35
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            Me.BarManager.StatusBar = Me.Bar3
            '
            'Bar1
            '
            Me.Bar1.BarName = "Actions"
            Me.Bar1.DockCol = 2
            Me.Bar1.DockRow = 1
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reset), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar1.Offset = 87
            Me.Bar1.Text = "Actions"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 0
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reset
            '
            Me.btn_Reset.Caption = "Reset"
            Me.btn_Reset.Id = 9
            Me.btn_Reset.Name = "btn_Reset"
            '
            'btn_Reload
            '
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
            Me.btn_Reload.Id = 3
            Me.btn_Reload.Name = "btn_Reload"
            '
            'PopupMenu_Reload
            '
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_All), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Modified), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Deleted)})
            Me.PopupMenu_Reload.Manager = Me.BarManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Reload_All
            '
            Me.btn_Reload_All.Caption = "Load All"
            Me.btn_Reload_All.Id = 21
            Me.btn_Reload_All.ImageOptions.Image = CType(resources.GetObject("btn_Reload_All.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_All.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_All.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_All.Name = "btn_Reload_All"
            '
            'btn_Reload_Modified
            '
            Me.btn_Reload_Modified.Caption = "Modified"
            Me.btn_Reload_Modified.Id = 20
            Me.btn_Reload_Modified.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Modified.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Modified.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Modified.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Modified.Name = "btn_Reload_Modified"
            '
            'btn_Reload_Deleted
            '
            Me.btn_Reload_Deleted.Caption = "Deleted"
            Me.btn_Reload_Deleted.Id = 22
            Me.btn_Reload_Deleted.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Deleted.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Deleted.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Deleted.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Deleted.Name = "btn_Reload_Deleted"
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
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Received), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Monitoring), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Summary)})
            Me.PopupMenu_Preview.Manager = Me.BarManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Unit_Order_Preview
            '
            Me.btn_Unit_Order_Preview.Caption = "Purchase Order"
            Me.btn_Unit_Order_Preview.Id = 15
            Me.btn_Unit_Order_Preview.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Order_Preview.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Order_Preview.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Order_Preview.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Order_Preview.Name = "btn_Unit_Order_Preview"
            '
            'btn_Purchase_Order_Received
            '
            Me.btn_Purchase_Order_Received.Caption = "Purchase Order - Received"
            Me.btn_Purchase_Order_Received.Id = 31
            Me.btn_Purchase_Order_Received.ImageOptions.Image = CType(resources.GetObject("btn_Purchase_Order_Received.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Purchase_Order_Received.ImageOptions.LargeImage = CType(resources.GetObject("btn_Purchase_Order_Received.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Purchase_Order_Received.Name = "btn_Purchase_Order_Received"
            '
            'btn_Purchase_Order_Monitoring
            '
            Me.btn_Purchase_Order_Monitoring.Caption = "Purchase Order - Monitoring"
            Me.btn_Purchase_Order_Monitoring.Id = 32
            Me.btn_Purchase_Order_Monitoring.ImageOptions.Image = CType(resources.GetObject("btn_Purchase_Order_Monitoring.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Purchase_Order_Monitoring.ImageOptions.LargeImage = CType(resources.GetObject("btn_Purchase_Order_Monitoring.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Purchase_Order_Monitoring.Name = "btn_Purchase_Order_Monitoring"
            '
            'btn_Purchase_Order_Summary
            '
            Me.btn_Purchase_Order_Summary.Caption = "Purchase Order - Summary"
            Me.btn_Purchase_Order_Summary.Id = 29
            Me.btn_Purchase_Order_Summary.ImageOptions.Image = CType(resources.GetObject("btn_Purchase_Order_Summary.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Purchase_Order_Summary.ImageOptions.LargeImage = CType(resources.GetObject("btn_Purchase_Order_Summary.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Purchase_Order_Summary.Name = "btn_Purchase_Order_Summary"
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
            Me.btn_New_Wizard.Caption = "New Purchase Order Wizard"
            Me.btn_New_Wizard.Id = 34
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
            'Bar2
            '
            Me.Bar2.BarName = "Main menu"
            Me.Bar2.DockCol = 0
            Me.Bar2.DockRow = 0
            Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar2.OptionsBar.MultiLine = True
            Me.Bar2.OptionsBar.UseWholeRow = True
            Me.Bar2.Text = "Main menu"
            Me.Bar2.Visible = False
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
            Me.Bar4.DockCol = 1
            Me.Bar4.DockRow = 1
            Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.Bar4.Text = "Parameters"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 2
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Bar_Orders
            '
            Me.Bar_Orders.BarName = "Orders"
            Me.Bar_Orders.DockCol = 0
            Me.Bar_Orders.DockRow = 1
            Me.Bar_Orders.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MC_Units), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Preview)})
            Me.Bar_Orders.Text = "Orders"
            '
            'btn_MC_Units
            '
            Me.btn_MC_Units.Caption = "MC Units"
            Me.btn_MC_Units.Id = 33
            Me.btn_MC_Units.ImageOptions.Image = CType(resources.GetObject("btn_MC_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_MC_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_MC_Units.Name = "btn_MC_Units"
            '
            'btn_Unit_Order_Reload
            '
            Me.btn_Unit_Order_Reload.Caption = "Reload Unit Orders"
            Me.btn_Unit_Order_Reload.Id = 16
            Me.btn_Unit_Order_Reload.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Order_Reload.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Order_Reload.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Order_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Order_Reload.Name = "btn_Unit_Order_Reload"
            '
            'btn_Recount
            '
            Me.btn_Recount.Caption = "Recount"
            Me.btn_Recount.Id = 28
            Me.btn_Recount.ImageOptions.Image = CType(resources.GetObject("btn_Recount.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Recount.ImageOptions.LargeImage = CType(resources.GetObject("btn_Recount.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Recount.Name = "btn_Recount"
            '
            'btn_Unit_Order_Add
            '
            Me.btn_Unit_Order_Add.Caption = "Add Unit Order"
            Me.btn_Unit_Order_Add.Id = 14
            Me.btn_Unit_Order_Add.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Order_Add.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Order_Add.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Order_Add.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Order_Add.Name = "btn_Unit_Order_Add"
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
            'btn_Modify_Orders
            '
            Me.btn_Modify_Orders.Caption = "Modify Orders"
            Me.btn_Modify_Orders.Id = 19
            Me.btn_Modify_Orders.ImageOptions.Image = CType(resources.GetObject("btn_Modify_Orders.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Modify_Orders.ImageOptions.LargeImage = CType(resources.GetObject("btn_Modify_Orders.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Modify_Orders.Name = "btn_Modify_Orders"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 23
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "Generate"
            Me.btn_Generate.Id = 24
            Me.btn_Generate.Name = "btn_Generate"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "For Approval"
            Me.btn_Approval.Id = 26
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "Disapprove"
            Me.btn_DisApprove.Id = 27
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'btn_Save_Order_Units
            '
            Me.btn_Save_Order_Units.Caption = "Save Order Units"
            Me.btn_Save_Order_Units.Id = 30
            Me.btn_Save_Order_Units.ImageOptions.Image = CType(resources.GetObject("btn_Save_Order_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Order_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Order_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Order_Units.Name = "btn_Save_Order_Units"
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
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Purchase_Order)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 474)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Purchase_Order
            '
            Me.xuc_Purchase_Order.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Purchase_Order.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Purchase_Order.Name = "xuc_Purchase_Order"
            Me.xuc_Purchase_Order.Size = New System.Drawing.Size(279, 474)
            Me.xuc_Purchase_Order.TabIndex = 0
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
            Me.panelContainer1.ActiveChild = Me.DockPanel3
            Me.panelContainer1.Controls.Add(Me.DockPanel3)
            Me.panelContainer1.Controls.Add(Me.DockPanel4)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.panelContainer1.ID = New System.Guid("97ba400c-3942-4da0-88d0-4884d5b151c0")
            Me.panelContainer1.Location = New System.Drawing.Point(286, 348)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(332, 200)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            '
            'DockPanel3
            '
            Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
            Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.DockPanel3.ID = New System.Guid("21bc6ef0-e942-4840-bdb9-47f86922a12c")
            Me.DockPanel3.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel3.Name = "DockPanel3"
            Me.DockPanel3.OriginalSize = New System.Drawing.Size(391, 144)
            Me.DockPanel3.Size = New System.Drawing.Size(326, 144)
            Me.DockPanel3.Text = "Unit Orders"
            '
            'DockPanel3_Container
            '
            Me.DockPanel3_Container.Controls.Add(Me.xuc_Purchase_Order_Units)
            Me.DockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel3_Container.Name = "DockPanel3_Container"
            Me.DockPanel3_Container.Size = New System.Drawing.Size(326, 144)
            Me.DockPanel3_Container.TabIndex = 0
            '
            'xuc_Purchase_Order_Units
            '
            Me.xuc_Purchase_Order_Units.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Purchase_Order_Units.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Purchase_Order_Units.Name = "xuc_Purchase_Order_Units"
            Me.xuc_Purchase_Order_Units.Size = New System.Drawing.Size(326, 144)
            Me.xuc_Purchase_Order_Units.TabIndex = 0
            '
            'DockPanel4
            '
            Me.DockPanel4.Controls.Add(Me.DockPanel4_Container)
            Me.DockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.DockPanel4.FloatVertical = True
            Me.DockPanel4.ID = New System.Guid("be9beb21-3fae-47e9-a7ab-9794f0cbf252")
            Me.DockPanel4.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel4.Name = "DockPanel4"
            Me.DockPanel4.OriginalSize = New System.Drawing.Size(391, 144)
            Me.DockPanel4.Size = New System.Drawing.Size(326, 144)
            Me.DockPanel4.Text = "Summary"
            '
            'DockPanel4_Container
            '
            Me.DockPanel4_Container.Controls.Add(Me.gridControl_Summary)
            Me.DockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel4_Container.Name = "DockPanel4_Container"
            Me.DockPanel4_Container.Size = New System.Drawing.Size(326, 144)
            Me.DockPanel4_Container.TabIndex = 0
            '
            'gridControl_Summary
            '
            Me.gridControl_Summary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_Summary.Location = New System.Drawing.Point(0, 0)
            Me.gridControl_Summary.MainView = Me.gridView_Summary
            Me.gridControl_Summary.Name = "gridControl_Summary"
            Me.gridControl_Summary.Size = New System.Drawing.Size(326, 144)
            Me.gridControl_Summary.TabIndex = 15
            Me.gridControl_Summary.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_Summary})
            '
            'gridView_Summary
            '
            Me.gridView_Summary.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Summary, Me.colBranch_Code, Me.colModel_Code, Me.colModel_Name, Me.colUnit_Color, Me.colUnit_Received, Me.colUnit_Description})
            Me.gridView_Summary.GridControl = Me.gridControl_Summary
            Me.gridView_Summary.Name = "gridView_Summary"
            Me.gridView_Summary.OptionsView.ColumnAutoWidth = False
            '
            'colID_Summary
            '
            Me.colID_Summary.FieldName = "ID"
            Me.colID_Summary.Name = "colID_Summary"
            Me.colID_Summary.Visible = True
            Me.colID_Summary.VisibleIndex = 0
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 1
            '
            'colModel_Code
            '
            Me.colModel_Code.Caption = "Code"
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 2
            '
            'colModel_Name
            '
            Me.colModel_Name.Caption = "Model"
            Me.colModel_Name.FieldName = "Model_Name"
            Me.colModel_Name.Name = "colModel_Name"
            Me.colModel_Name.Visible = True
            Me.colModel_Name.VisibleIndex = 3
            '
            'colUnit_Color
            '
            Me.colUnit_Color.Caption = "Color"
            Me.colUnit_Color.FieldName = "Unit_Color"
            Me.colUnit_Color.Name = "colUnit_Color"
            Me.colUnit_Color.Visible = True
            Me.colUnit_Color.VisibleIndex = 4
            '
            'colUnit_Received
            '
            Me.colUnit_Received.Caption = "Received"
            Me.colUnit_Received.FieldName = "Unit_Received"
            Me.colUnit_Received.Name = "colUnit_Received"
            Me.colUnit_Received.OptionsColumn.AllowEdit = False
            Me.colUnit_Received.Visible = True
            Me.colUnit_Received.VisibleIndex = 5
            '
            'colUnit_Description
            '
            Me.colUnit_Description.Caption = "Description"
            Me.colUnit_Description.FieldName = "Unit_Description"
            Me.colUnit_Description.Name = "colUnit_Description"
            Me.colUnit_Description.Visible = True
            Me.colUnit_Description.VisibleIndex = 6
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(286, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Brand_Code})
            Me.gridControl.Size = New System.Drawing.Size(332, 303)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsApproved, Me.colOrder_Status, Me.colOrder_Code, Me.colPurchase_Order_Code, Me.colBrand_Code, Me.colOrder_Date, Me.colDue_Date, Me.colTotal_Quantity, Me.colTotal_Cost, Me.colFreight_Cost, Me.colIs_Per_Unit, Me.colFreight_Cost_Total, Me.colGrand_Total, Me.colTotal_Received, Me.colFreight_Cost_Received, Me.colTotal_Cost_Received_PO, Me.colTotal_Remaining, Me.colTotal_Cost_Remaining, Me.colOrder_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date})
            Me.gridView.GridControl = Me.gridControl
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
            'colIsApproved
            '
            Me.colIsApproved.FieldName = "IsApproved"
            Me.colIsApproved.Name = "colIsApproved"
            Me.colIsApproved.Visible = True
            Me.colIsApproved.VisibleIndex = 1
            '
            'colOrder_Status
            '
            Me.colOrder_Status.Caption = "Status"
            Me.colOrder_Status.FieldName = "Order_Status"
            Me.colOrder_Status.Name = "colOrder_Status"
            Me.colOrder_Status.Visible = True
            Me.colOrder_Status.VisibleIndex = 2
            '
            'colOrder_Code
            '
            Me.colOrder_Code.FieldName = "Order_Code"
            Me.colOrder_Code.Name = "colOrder_Code"
            Me.colOrder_Code.Visible = True
            Me.colOrder_Code.VisibleIndex = 3
            '
            'colBrand_Code
            '
            Me.colBrand_Code.Caption = "Brand"
            Me.colBrand_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Brand_Code
            Me.colBrand_Code.FieldName = "Brand_Code"
            Me.colBrand_Code.Name = "colBrand_Code"
            Me.colBrand_Code.Visible = True
            Me.colBrand_Code.VisibleIndex = 5
            '
            'RepositoryItemLookUpEdit_Brand_Code
            '
            Me.RepositoryItemLookUpEdit_Brand_Code.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Brand_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Brand_Code.Name = "RepositoryItemLookUpEdit_Brand_Code"
            '
            'colOrder_Date
            '
            Me.colOrder_Date.FieldName = "Order_Date"
            Me.colOrder_Date.Name = "colOrder_Date"
            Me.colOrder_Date.Visible = True
            Me.colOrder_Date.VisibleIndex = 6
            '
            'colDue_Date
            '
            Me.colDue_Date.FieldName = "Due_Date"
            Me.colDue_Date.Name = "colDue_Date"
            Me.colDue_Date.Visible = True
            Me.colDue_Date.VisibleIndex = 7
            '
            'colTotal_Quantity
            '
            Me.colTotal_Quantity.Caption = "Quantity"
            Me.colTotal_Quantity.FieldName = "Total_Quantity"
            Me.colTotal_Quantity.Name = "colTotal_Quantity"
            Me.colTotal_Quantity.Visible = True
            Me.colTotal_Quantity.VisibleIndex = 8
            '
            'colTotal_Cost
            '
            Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost.FieldName = "Total_Cost"
            Me.colTotal_Cost.Name = "colTotal_Cost"
            Me.colTotal_Cost.Visible = True
            Me.colTotal_Cost.VisibleIndex = 9
            '
            'colFreight_Cost
            '
            Me.colFreight_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost.FieldName = "Freight_Cost"
            Me.colFreight_Cost.Name = "colFreight_Cost"
            Me.colFreight_Cost.Visible = True
            Me.colFreight_Cost.VisibleIndex = 10
            '
            'colIs_Per_Unit
            '
            Me.colIs_Per_Unit.FieldName = "Is_Per_Unit"
            Me.colIs_Per_Unit.Name = "colIs_Per_Unit"
            Me.colIs_Per_Unit.Visible = True
            Me.colIs_Per_Unit.VisibleIndex = 11
            '
            'colFreight_Cost_Total
            '
            Me.colFreight_Cost_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost_Total.FieldName = "Freight_Cost_Total"
            Me.colFreight_Cost_Total.Name = "colFreight_Cost_Total"
            Me.colFreight_Cost_Total.Visible = True
            Me.colFreight_Cost_Total.VisibleIndex = 12
            '
            'colGrand_Total
            '
            Me.colGrand_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colGrand_Total.FieldName = "Grand_Total"
            Me.colGrand_Total.Name = "colGrand_Total"
            Me.colGrand_Total.Visible = True
            Me.colGrand_Total.VisibleIndex = 13
            '
            'colTotal_Received
            '
            Me.colTotal_Received.Caption = "Received"
            Me.colTotal_Received.FieldName = "Total_Received"
            Me.colTotal_Received.Name = "colTotal_Received"
            Me.colTotal_Received.Visible = True
            Me.colTotal_Received.VisibleIndex = 14
            '
            'colFreight_Cost_Received
            '
            Me.colFreight_Cost_Received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost_Received.FieldName = "Freight_Cost_Received"
            Me.colFreight_Cost_Received.Name = "colFreight_Cost_Received"
            Me.colFreight_Cost_Received.Visible = True
            Me.colFreight_Cost_Received.VisibleIndex = 15
            '
            'colTotal_Cost_Received_PO
            '
            Me.colTotal_Cost_Received_PO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost_Received_PO.FieldName = "Total_Cost_Received"
            Me.colTotal_Cost_Received_PO.Name = "colTotal_Cost_Received_PO"
            Me.colTotal_Cost_Received_PO.Visible = True
            Me.colTotal_Cost_Received_PO.VisibleIndex = 16
            '
            'colTotal_Remaining
            '
            Me.colTotal_Remaining.Caption = "Remaining"
            Me.colTotal_Remaining.FieldName = "Total_Remaining"
            Me.colTotal_Remaining.Name = "colTotal_Remaining"
            Me.colTotal_Remaining.Visible = True
            Me.colTotal_Remaining.VisibleIndex = 17
            '
            'colTotal_Cost_Remaining
            '
            Me.colTotal_Cost_Remaining.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost_Remaining.FieldName = "Total_Cost_Remaining"
            Me.colTotal_Cost_Remaining.Name = "colTotal_Cost_Remaining"
            Me.colTotal_Cost_Remaining.Visible = True
            Me.colTotal_Cost_Remaining.VisibleIndex = 18
            '
            'colOrder_Description
            '
            Me.colOrder_Description.Caption = "Description"
            Me.colOrder_Description.FieldName = "Order_Description"
            Me.colOrder_Description.Name = "colOrder_Description"
            Me.colOrder_Description.Visible = True
            Me.colOrder_Description.VisibleIndex = 19
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 20
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 21
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 22
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 23
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 24
            '
            'colApproved_By
            '
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 25
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 26
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Received), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Monitoring), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Purchase_Order_Summary), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Modify_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'PopupMenu_Unit_Orders
            '
            Me.PopupMenu_Unit_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Order_Units), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu_Unit_Orders.Manager = Me.BarManager
            Me.PopupMenu_Unit_Orders.Name = "PopupMenu_Unit_Orders"
            '
            'colPurchase_Order_Code
            '
            Me.colPurchase_Order_Code.Caption = "P. O. Code"
            Me.colPurchase_Order_Code.FieldName = "Purchase_Order_Code"
            Me.colPurchase_Order_Code.Name = "colPurchase_Order_Code"
            Me.colPurchase_Order_Code.Visible = True
            Me.colPurchase_Order_Code.VisibleIndex = 4
            '
            'frm_Purchase_Orders
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 568)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Purchase_Orders"
            Me.Text = "frm_Purchase_Orders"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.DockPanel3.ResumeLayout(False)
            Me.DockPanel3_Container.ResumeLayout(False)
            Me.DockPanel4.ResumeLayout(False)
            Me.DockPanel4_Container.ResumeLayout(False)
            CType(Me.gridControl_Summary, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_Summary, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents btn_Reset As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
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
        Friend WithEvents colBrand_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents Bar_Orders As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Unit_Order_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unit_Order_Add As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unit_Order_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents colTotal_Quantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Purchase_Order As Controls.Logistics.xuc_Purchase_Order
        Friend WithEvents colOrder_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Brand_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colFreight_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Modify_Orders As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Reload_Modified As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_All As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_Deleted As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Remaining As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Recount As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Unit_Orders As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Purchase_Order_Summary As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Order_Units As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel4 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl_Summary As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_Summary As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Color As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Purchase_Order_Received As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Purchase_Order_Monitoring As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colTotal_Cost_Received_PO As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost_Remaining As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIs_Per_Unit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDue_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Purchase_Order_Units As Controls.Logistics.xuc_Purchase_Order_Units
        Friend WithEvents btn_MC_Units As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_New As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_New_Wizard As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colPurchase_Order_Code As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace