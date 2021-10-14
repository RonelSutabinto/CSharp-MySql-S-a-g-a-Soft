Imports SagaSpareParts.Controls

Namespace SagaSpareParts
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_SPA_Receiving_Orders_Costing
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SPA_Receiving_Orders_Costing))
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Reload_All = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Modified = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Deleted = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Honda = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Kawasaki = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Suzuki = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Costing = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar2 = New DevExpress.XtraBars.Bar()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.Bar4 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.BarEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.Bar_Orders = New DevExpress.XtraBars.Bar()
            Me.btn_Reload_Unit_Orders = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unit_Order_Add = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unit_Order_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Modify_Orders = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Total_Received = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete_Unit_Items = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Recount = New DevExpress.XtraBars.BarButtonItem()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_SPA_Receive_Order = New xuc_SPA_Receive_Order()
            Me.DockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.gridControl_SKU_Items = New DevExpress.XtraGrid.GridControl()
            Me.gridView_SKU_Items = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID_SKU_Item = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParts_Number2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParts_Name2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemSpinEdit_Receive_QTY = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colPrev_Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCost2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSRP2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscountPCT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscountAMT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSKU_Description2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactedby = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDateCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChecker = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xuc_Receive_Order = New xuc_SPA_Receive_Order()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Units = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_From = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDispatched_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colError_Counter = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.PopupMenu_Unit_Orders = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.PopupMenu_Unit_Items = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel4.SuspendLayout()
            Me.DockPanel4_Container.SuspendLayout()
            CType(Me.gridControl_SKU_Items, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_SKU_Items, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_Receive_QTY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Unit_Items, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.BarManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel4})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.DockPanel2)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(1098, 45)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 429)
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba")
            Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.SavedIndex = 1
            Me.DockPanel2.Size = New System.Drawing.Size(200, 429)
            Me.DockPanel2.Text = "Settings"
            Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 400)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 400)
            Me.xuc_Settings.TabIndex = 0
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3, Me.Bar4, Me.Bar_Orders})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Reload, Me.btn_New, Me.btn_Save, Me.btn_Delete, Me.btn_Close, Me.btn_Preview, Me.btn_Unit_Order_Add, Me.btn_Unit_Order_Preview, Me.btn_Reload_Unit_Orders, Me.btn_Modify_Orders, Me.btn_Reload_Modified, Me.btn_Reload_All, Me.btn_Reload_Deleted, Me.btn_Approve, Me.btn_Total_Received, Me.btn_Save_Unit_Items, Me.btn_Reload_Unit_Items, Me.btn_Preview_Unit_Items, Me.btn_Delete_Unit_Items, Me.btn_Approval, Me.btn_DisApprove, Me.BarEditItem_Date_Start, Me.BarEditItem_Date_End, Me.btn_Costing, Me.btn_Recount, Me.btn_Honda, Me.btn_Suzuki, Me.btn_Kawasaki})
            Me.BarManager.MainMenu = Me.Bar2
            Me.BarManager.MaxItemId = 38
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
            Me.BarManager.StatusBar = Me.Bar3
            '
            'Bar1
            '
            Me.Bar1.BarName = "Actions"
            Me.Bar1.DockCol = 2
            Me.Bar1.DockRow = 1
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar1.Offset = 87
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
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Honda), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Kawasaki), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Suzuki), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Costing)})
            Me.PopupMenu_Preview.Manager = Me.BarManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Honda
            '
            Me.btn_Honda.Caption = "Preview Costing Report - HONDA"
            Me.btn_Honda.Id = 35
            Me.btn_Honda.ImageOptions.Image = CType(resources.GetObject("btn_Honda.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Honda.ImageOptions.LargeImage = CType(resources.GetObject("btn_Honda.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Honda.Name = "btn_Honda"
            '
            'btn_Kawasaki
            '
            Me.btn_Kawasaki.Caption = "Preview Costing Report - KAWASAKI"
            Me.btn_Kawasaki.Id = 37
            Me.btn_Kawasaki.ImageOptions.Image = CType(resources.GetObject("btn_Kawasaki.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Kawasaki.ImageOptions.LargeImage = CType(resources.GetObject("btn_Kawasaki.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Kawasaki.Name = "btn_Kawasaki"
            '
            'btn_Suzuki
            '
            Me.btn_Suzuki.Caption = "Preview Costing Report - SUZUKI"
            Me.btn_Suzuki.Id = 36
            Me.btn_Suzuki.ImageOptions.Image = CType(resources.GetObject("btn_Suzuki.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Suzuki.ImageOptions.LargeImage = CType(resources.GetObject("btn_Suzuki.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Suzuki.Name = "btn_Suzuki"
            '
            'btn_Costing
            '
            Me.btn_Costing.Caption = "Preview Costing Report - YAMAHA"
            Me.btn_Costing.Id = 33
            Me.btn_Costing.ImageOptions.Image = CType(resources.GetObject("btn_Costing.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Costing.ImageOptions.LargeImage = CType(resources.GetObject("btn_Costing.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Costing.Name = "btn_Costing"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 4
            Me.btn_New.Name = "btn_New"
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
            Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Search, "", False, True, True, 121), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_Start, "", False, True, True, 127), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_End, "", False, True, True, 130)})
            Me.Bar4.Text = "Parameters"
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
            'BarEditItem_Date_Start
            '
            Me.BarEditItem_Date_Start.Caption = "Date Start"
            Me.BarEditItem_Date_Start.Edit = Me.RepositoryItemDateEdit1
            Me.BarEditItem_Date_Start.Id = 31
            Me.BarEditItem_Date_Start.Name = "BarEditItem_Date_Start"
            '
            'RepositoryItemDateEdit1
            '
            Me.RepositoryItemDateEdit1.AutoHeight = False
            Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
            '
            'BarEditItem_Date_End
            '
            Me.BarEditItem_Date_End.Caption = "Date End"
            Me.BarEditItem_Date_End.Edit = Me.RepositoryItemDateEdit2
            Me.BarEditItem_Date_End.Id = 32
            Me.BarEditItem_Date_End.Name = "BarEditItem_Date_End"
            '
            'RepositoryItemDateEdit2
            '
            Me.RepositoryItemDateEdit2.AutoHeight = False
            Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
            '
            'Bar_Orders
            '
            Me.Bar_Orders.BarName = "Orders"
            Me.Bar_Orders.DockCol = 0
            Me.Bar_Orders.DockRow = 1
            Me.Bar_Orders.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Preview)})
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
            'btn_Unit_Order_Add
            '
            Me.btn_Unit_Order_Add.Caption = "Add Unit Order"
            Me.btn_Unit_Order_Add.Id = 14
            Me.btn_Unit_Order_Add.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Order_Add.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Order_Add.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Order_Add.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Order_Add.Name = "btn_Unit_Order_Add"
            '
            'btn_Unit_Order_Preview
            '
            Me.btn_Unit_Order_Preview.Caption = "Purchase Order"
            Me.btn_Unit_Order_Preview.Id = 15
            Me.btn_Unit_Order_Preview.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Order_Preview.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Order_Preview.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Order_Preview.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Order_Preview.Name = "btn_Unit_Order_Preview"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(1119, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 474)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(1119, 20)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1119, 45)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
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
            'btn_Total_Received
            '
            Me.btn_Total_Received.Caption = "Total Received"
            Me.btn_Total_Received.Id = 24
            Me.btn_Total_Received.Name = "btn_Total_Received"
            '
            'btn_Save_Unit_Items
            '
            Me.btn_Save_Unit_Items.Caption = "Save"
            Me.btn_Save_Unit_Items.Id = 25
            Me.btn_Save_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Save_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Save_Unit_Items.Name = "btn_Save_Unit_Items"
            '
            'btn_Reload_Unit_Items
            '
            Me.btn_Reload_Unit_Items.Caption = "Reload"
            Me.btn_Reload_Unit_Items.Id = 26
            Me.btn_Reload_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Unit_Items.Name = "btn_Reload_Unit_Items"
            '
            'btn_Preview_Unit_Items
            '
            Me.btn_Preview_Unit_Items.Caption = "Preview Received Units"
            Me.btn_Preview_Unit_Items.Id = 27
            Me.btn_Preview_Unit_Items.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Unit_Items.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Unit_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Unit_Items.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Unit_Items.Name = "btn_Preview_Unit_Items"
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
            'btn_Recount
            '
            Me.btn_Recount.Caption = "Recount"
            Me.btn_Recount.Id = 34
            Me.btn_Recount.ImageOptions.Image = CType(resources.GetObject("btn_Recount.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Recount.ImageOptions.LargeImage = CType(resources.GetObject("btn_Recount.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Recount.Name = "btn_Recount"
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("c4f0a519-4d96-443d-8b06-14937c864a67")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(286, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(286, 429)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_SPA_Receive_Order)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 400)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_SPA_Receive_Order
            '
            Me.xuc_SPA_Receive_Order.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_SPA_Receive_Order.Location = New System.Drawing.Point(0, 0)
            Me.xuc_SPA_Receive_Order.Name = "xuc_SPA_Receive_Order"
            Me.xuc_SPA_Receive_Order.Size = New System.Drawing.Size(279, 400)
            Me.xuc_SPA_Receive_Order.TabIndex = 0
            '
            'DockPanel4
            '
            Me.DockPanel4.Controls.Add(Me.DockPanel4_Container)
            Me.DockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.DockPanel4.FloatVertical = True
            Me.DockPanel4.ID = New System.Guid("cc3bc70e-9103-4a8e-af0b-ec58fccaea09")
            Me.DockPanel4.Location = New System.Drawing.Point(286, 274)
            Me.DockPanel4.Name = "DockPanel4"
            Me.DockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel4.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.DockPanel4.SavedIndex = 1
            Me.DockPanel4.Size = New System.Drawing.Size(812, 200)
            Me.DockPanel4.Text = "SKU Items"
            '
            'DockPanel4_Container
            '
            Me.DockPanel4_Container.Controls.Add(Me.gridControl_SKU_Items)
            Me.DockPanel4_Container.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel4_Container.Name = "DockPanel4_Container"
            Me.DockPanel4_Container.Size = New System.Drawing.Size(806, 170)
            Me.DockPanel4_Container.TabIndex = 0
            '
            'gridControl_SKU_Items
            '
            Me.gridControl_SKU_Items.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_SKU_Items.Location = New System.Drawing.Point(0, 0)
            Me.gridControl_SKU_Items.MainView = Me.gridView_SKU_Items
            Me.gridControl_SKU_Items.Name = "gridControl_SKU_Items"
            Me.gridControl_SKU_Items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit_Receive_QTY})
            Me.gridControl_SKU_Items.Size = New System.Drawing.Size(806, 170)
            Me.gridControl_SKU_Items.TabIndex = 15
            Me.gridControl_SKU_Items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_SKU_Items})
            '
            'gridView_SKU_Items
            '
            Me.gridView_SKU_Items.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_SKU_Item, Me.colParts_Number2, Me.colParts_Name2, Me.colCategory2, Me.colQuantity, Me.colPrev_Quantity, Me.colCost2, Me.colTotalCost, Me.colSRP2, Me.colDiscountPCT, Me.colDiscountAMT, Me.colSKU_Description2, Me.colNotes3, Me.colTransactedby, Me.colTransactionDate, Me.colDateCheck, Me.colChecker})
            Me.gridView_SKU_Items.GridControl = Me.gridControl_SKU_Items
            Me.gridView_SKU_Items.Name = "gridView_SKU_Items"
            Me.gridView_SKU_Items.OptionsView.ColumnAutoWidth = False
            '
            'colID_SKU_Item
            '
            Me.colID_SKU_Item.FieldName = "id"
            Me.colID_SKU_Item.Name = "colID_SKU_Item"
            Me.colID_SKU_Item.Visible = True
            Me.colID_SKU_Item.VisibleIndex = 0
            '
            'colParts_Number2
            '
            Me.colParts_Number2.FieldName = "PartsNumber"
            Me.colParts_Number2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colParts_Number2.Name = "colParts_Number2"
            Me.colParts_Number2.Visible = True
            Me.colParts_Number2.VisibleIndex = 1
            '
            'colParts_Name2
            '
            Me.colParts_Name2.FieldName = "PartsName"
            Me.colParts_Name2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colParts_Name2.Name = "colParts_Name2"
            Me.colParts_Name2.Visible = True
            Me.colParts_Name2.VisibleIndex = 2
            '
            'colCategory2
            '
            Me.colCategory2.FieldName = "Category"
            Me.colCategory2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colCategory2.Name = "colCategory2"
            Me.colCategory2.Visible = True
            Me.colCategory2.VisibleIndex = 3
            '
            'colQuantity
            '
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.ColumnEdit = Me.RepositoryItemSpinEdit_Receive_QTY
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 4
            '
            'RepositoryItemSpinEdit_Receive_QTY
            '
            Me.RepositoryItemSpinEdit_Receive_QTY.AutoHeight = False
            Me.RepositoryItemSpinEdit_Receive_QTY.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemSpinEdit_Receive_QTY.Name = "RepositoryItemSpinEdit_Receive_QTY"
            '
            'colPrev_Quantity
            '
            Me.colPrev_Quantity.Caption = "Quantity Received"
            Me.colPrev_Quantity.FieldName = "Prev_Quantity"
            Me.colPrev_Quantity.Name = "colPrev_Quantity"
            Me.colPrev_Quantity.Visible = True
            Me.colPrev_Quantity.VisibleIndex = 5
            '
            'colCost2
            '
            Me.colCost2.Caption = "Cost"
            Me.colCost2.FieldName = "SPCostWOVAT"
            Me.colCost2.Name = "colCost2"
            Me.colCost2.Visible = True
            Me.colCost2.VisibleIndex = 6
            '
            'colTotalCost
            '
            Me.colTotalCost.FieldName = "TotalCostWOVAT"
            Me.colTotalCost.Name = "colTotalCost"
            Me.colTotalCost.Visible = True
            Me.colTotalCost.VisibleIndex = 7
            '
            'colSRP2
            '
            Me.colSRP2.FieldName = "SRP"
            Me.colSRP2.Name = "colSRP2"
            Me.colSRP2.Visible = True
            Me.colSRP2.VisibleIndex = 8
            '
            'colDiscountPCT
            '
            Me.colDiscountPCT.FieldName = "DiscountPCT"
            Me.colDiscountPCT.Name = "colDiscountPCT"
            Me.colDiscountPCT.Visible = True
            Me.colDiscountPCT.VisibleIndex = 9
            '
            'colDiscountAMT
            '
            Me.colDiscountAMT.FieldName = "DiscountAMT"
            Me.colDiscountAMT.Name = "colDiscountAMT"
            Me.colDiscountAMT.Visible = True
            Me.colDiscountAMT.VisibleIndex = 10
            '
            'colSKU_Description2
            '
            Me.colSKU_Description2.FieldName = "Remarks"
            Me.colSKU_Description2.Name = "colSKU_Description2"
            Me.colSKU_Description2.Visible = True
            Me.colSKU_Description2.VisibleIndex = 11
            '
            'colNotes3
            '
            Me.colNotes3.FieldName = "Note"
            Me.colNotes3.Name = "colNotes3"
            Me.colNotes3.Visible = True
            Me.colNotes3.VisibleIndex = 12
            '
            'colTransactedby
            '
            Me.colTransactedby.FieldName = "Transactedby"
            Me.colTransactedby.Name = "colTransactedby"
            Me.colTransactedby.Visible = True
            Me.colTransactedby.VisibleIndex = 13
            '
            'colTransactionDate
            '
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.OptionsColumn.AllowEdit = False
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 14
            '
            'colDateCheck
            '
            Me.colDateCheck.FieldName = "DateCheck"
            Me.colDateCheck.Name = "colDateCheck"
            Me.colDateCheck.Visible = True
            Me.colDateCheck.VisibleIndex = 15
            '
            'colChecker
            '
            Me.colChecker.FieldName = "Checker"
            Me.colChecker.Name = "colChecker"
            Me.colChecker.OptionsColumn.AllowEdit = False
            Me.colChecker.Visible = True
            Me.colChecker.VisibleIndex = 16
            '
            'xuc_Receive_Order
            '
            Me.xuc_Receive_Order.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Receive_Order.Name = "xuc_Receive_Order"
            Me.xuc_Receive_Order.Size = New System.Drawing.Size(285, 380)
            Me.xuc_Receive_Order.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.DataMember = "acc_Tickets"
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(286, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit})
            Me.gridControl.Size = New System.Drawing.Size(812, 229)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colStatus, Me.colTransaction_Type, Me.colTransaction_Code, Me.colReference, Me.colOrder_Code, Me.colTotal_Units, Me.colSupplier, Me.colBranch_From, Me.colDispatched_Date, Me.colApproved_By, Me.colApproved_Date, Me.colBranch_Code, Me.colUnit_Status, Me.colDescription, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colError_Counter})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "id"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "Inventory_Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 1
            '
            'colTransaction_Type
            '
            Me.colTransaction_Type.Caption = "Type"
            Me.colTransaction_Type.FieldName = "Transaction_Type"
            Me.colTransaction_Type.Name = "colTransaction_Type"
            Me.colTransaction_Type.Visible = True
            Me.colTransaction_Type.VisibleIndex = 2
            '
            'colTransaction_Code
            '
            Me.colTransaction_Code.Caption = "Transaction Code"
            Me.colTransaction_Code.ColumnEdit = Me.RepositoryItemHyperLinkEdit
            Me.colTransaction_Code.FieldName = "Transaction_Code"
            Me.colTransaction_Code.Name = "colTransaction_Code"
            Me.colTransaction_Code.Visible = True
            Me.colTransaction_Code.VisibleIndex = 3
            '
            'RepositoryItemHyperLinkEdit
            '
            Me.RepositoryItemHyperLinkEdit.AutoHeight = False
            Me.RepositoryItemHyperLinkEdit.Name = "RepositoryItemHyperLinkEdit"
            '
            'colReference
            '
            Me.colReference.Caption = "Reference"
            Me.colReference.ColumnEdit = Me.RepositoryItemHyperLinkEdit
            Me.colReference.FieldName = "Reference"
            Me.colReference.Name = "colReference"
            Me.colReference.Visible = True
            Me.colReference.VisibleIndex = 4
            '
            'colOrder_Code
            '
            Me.colOrder_Code.Caption = "P. O. Number"
            Me.colOrder_Code.ColumnEdit = Me.RepositoryItemHyperLinkEdit
            Me.colOrder_Code.FieldName = "Order_Code"
            Me.colOrder_Code.Name = "colOrder_Code"
            Me.colOrder_Code.Visible = True
            Me.colOrder_Code.VisibleIndex = 5
            '
            'colTotal_Units
            '
            Me.colTotal_Units.Caption = "Total Units"
            Me.colTotal_Units.FieldName = "SKU_Count"
            Me.colTotal_Units.Name = "colTotal_Units"
            Me.colTotal_Units.Visible = True
            Me.colTotal_Units.VisibleIndex = 6
            '
            'colSupplier
            '
            Me.colSupplier.Caption = "Supplier"
            Me.colSupplier.FieldName = "Supplier_Name"
            Me.colSupplier.Name = "colSupplier"
            Me.colSupplier.Visible = True
            Me.colSupplier.VisibleIndex = 7
            '
            'colBranch_From
            '
            Me.colBranch_From.Caption = "Branch From"
            Me.colBranch_From.FieldName = "Supplier_Name"
            Me.colBranch_From.Name = "colBranch_From"
            Me.colBranch_From.Visible = True
            Me.colBranch_From.VisibleIndex = 8
            '
            'colDispatched_Date
            '
            Me.colDispatched_Date.Caption = "Dispatched Date"
            Me.colDispatched_Date.FieldName = "Received_Date"
            Me.colDispatched_Date.Name = "colDispatched_Date"
            Me.colDispatched_Date.Visible = True
            Me.colDispatched_Date.VisibleIndex = 9
            '
            'colApproved_By
            '
            Me.colApproved_By.Caption = "Approved By"
            Me.colApproved_By.FieldName = "approver"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 10
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "dateapproved"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 11
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch To"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 12
            '
            'colUnit_Status
            '
            Me.colUnit_Status.Caption = "Unit Status"
            Me.colUnit_Status.FieldName = "SKU_Category"
            Me.colUnit_Status.Name = "colUnit_Status"
            Me.colUnit_Status.Visible = True
            Me.colUnit_Status.VisibleIndex = 13
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "SKU_Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 14
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 15
            '
            'colAdded_By
            '
            Me.colAdded_By.Caption = "Added By"
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 16
            '
            'colAdded_Date
            '
            Me.colAdded_Date.Caption = "Added Date"
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 17
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 18
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 19
            '
            'colError_Counter
            '
            Me.colError_Counter.FieldName = "Error_Counter"
            Me.colError_Counter.Name = "colError_Counter"
            Me.colError_Counter.Visible = True
            Me.colError_Counter.VisibleIndex = 20
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Unit_Items), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'PopupMenu_Unit_Orders
            '
            Me.PopupMenu_Unit_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Total_Received), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Order_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu_Unit_Orders.Manager = Me.BarManager
            Me.PopupMenu_Unit_Orders.Name = "PopupMenu_Unit_Orders"
            '
            'PopupMenu_Unit_Items
            '
            Me.PopupMenu_Unit_Items.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Unit_Items), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Unit_Items), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Unit_Items, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Recount), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete_Unit_Items), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu_Unit_Items.Manager = Me.BarManager
            Me.PopupMenu_Unit_Items.Name = "PopupMenu_Unit_Items"
            '
            'frm_SPA_Receiving_Orders_Costing
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1119, 494)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.DockPanel4)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_SPA_Receiving_Orders_Costing"
            Me.Text = "frm_SPA_Receiving_Orders"
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel4.ResumeLayout(False)
            Me.DockPanel4_Container.ResumeLayout(False)
            CType(Me.gridControl_SKU_Items, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_SKU_Items, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_Receive_QTY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Unit_Orders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Unit_Items, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents Bar_Orders As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload_Unit_Orders As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unit_Order_Add As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unit_Order_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Modify_Orders As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Reload_Modified As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_All As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_Deleted As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Friend WithEvents xuc_Receive_Order As xuc_SPA_Receive_Order
        Friend WithEvents colTransaction_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Units As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Friend WithEvents colBranch_From As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDispatched_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSupplier As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DockPanel4 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents btn_Total_Received As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Unit_Orders As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Save_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Unit_Items As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Reload_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete_Unit_Items As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colError_Counter As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_SPA_Receive_Order As xuc_SPA_Receive_Order
        Friend WithEvents BarEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_Date_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents gridControl_SKU_Items As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_SKU_Items As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID_SKU_Item As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colParts_Number2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colParts_Name2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategory2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCost2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSRP2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSKU_Description2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactedby As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDateCheck As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChecker As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_Receive_QTY As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents colPrev_Quantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Costing As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Recount As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Honda As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Kawasaki As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Suzuki As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colDiscountPCT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscountAMT As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace