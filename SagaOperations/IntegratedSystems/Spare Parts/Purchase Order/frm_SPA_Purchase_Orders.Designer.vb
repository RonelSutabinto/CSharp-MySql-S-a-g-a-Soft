<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SPA_Purchase_Orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SPA_Purchase_Orders))
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reset = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Btn_Reload_All = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reload_Modified = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reload_Deleted = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Btn_Unit_Order_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.Bar_Orders = New DevExpress.XtraBars.Bar()
        Me.Btn_Unit_Order_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Unit_Order_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Btn_Modify_Orders = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Approve = New DevExpress.XtraBars.BarButtonItem()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_SPA_Purchase_Orders = New SagaOperations.Xuc_SPA_Purchase_Orders()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl_Items = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Items = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_Category = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colParts_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Parts_Number = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colParts_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit_Part_Name = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit_SRP = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colNet_Profit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit_Net_Profit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colTotal_Cost2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit_Total_Cost2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotal_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit_Total_SRP = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colUnit_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_By2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_Date2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_By2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_Date2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrder_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Brand_Code = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colOrder_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost_GrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP_GrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNet_Profit_GrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrand_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Remaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrder_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrder_Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit_Part_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit_SRP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit_Net_Profit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit_Total_Cost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit_Total_SRP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager
        '
        Me.DockManager.DockingOptions.ShowCloseButton = False
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
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
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Initialize, Me.BarEditItem_Search, Me.Btn_Reload, Me.Btn_New, Me.Btn_Save, Me.Btn_Delete, Me.Btn_Close, Me.Btn_Preview, Me.Btn_Reset, Me.Btn_Unit_Order_Add, Me.Btn_Unit_Order_Preview, Me.Btn_Unit_Order_Reload, Me.Btn_Modify_Orders, Me.Btn_Reload_Modified, Me.Btn_Reload_All, Me.Btn_Reload_Deleted, Me.Btn_Approve})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 24
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Actions"
        Me.Bar1.DockCol = 2
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reset), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
        Me.Bar1.Offset = 87
        Me.Bar1.Text = "Actions"
        '
        'Btn_Initialize
        '
        Me.Btn_Initialize.Caption = "Initialize"
        Me.Btn_Initialize.Id = 0
        Me.Btn_Initialize.Name = "Btn_Initialize"
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Caption = "Reset"
        Me.Btn_Reset.Id = 9
        Me.Btn_Reset.Name = "Btn_Reset"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.Btn_Reload.Caption = "Reload"
        Me.Btn_Reload.DropDownControl = Me.PopupMenu_Reload
        Me.Btn_Reload.Id = 3
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'PopupMenu_Reload
        '
        Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload_All), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload_Modified), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload_Deleted)})
        Me.PopupMenu_Reload.Manager = Me.BarManager
        Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
        '
        'Btn_Reload_All
        '
        Me.Btn_Reload_All.Caption = "Load All"
        Me.Btn_Reload_All.Id = 21
        Me.Btn_Reload_All.ImageOptions.Image = CType(resources.GetObject("Btn_Reload_All.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Reload_All.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Reload_All.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Reload_All.Name = "Btn_Reload_All"
        '
        'Btn_Reload_Modified
        '
        Me.Btn_Reload_Modified.Caption = "Modified"
        Me.Btn_Reload_Modified.Id = 20
        Me.Btn_Reload_Modified.ImageOptions.Image = CType(resources.GetObject("Btn_Reload_Modified.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Reload_Modified.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Reload_Modified.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Reload_Modified.Name = "Btn_Reload_Modified"
        '
        'Btn_Reload_Deleted
        '
        Me.Btn_Reload_Deleted.Caption = "Deleted"
        Me.Btn_Reload_Deleted.Id = 22
        Me.Btn_Reload_Deleted.ImageOptions.Image = CType(resources.GetObject("Btn_Reload_Deleted.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Reload_Deleted.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Reload_Deleted.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Reload_Deleted.Name = "Btn_Reload_Deleted"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.DropDownControl = Me.PopupMenu_Preview
        Me.Btn_Preview.Id = 8
        Me.Btn_Preview.Name = "Btn_Preview"
        '
        'PopupMenu_Preview
        '
        Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Preview)})
        Me.PopupMenu_Preview.Manager = Me.BarManager
        Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
        '
        'Btn_Unit_Order_Preview
        '
        Me.Btn_Unit_Order_Preview.Caption = "Purchase Order"
        Me.Btn_Unit_Order_Preview.Id = 15
        Me.Btn_Unit_Order_Preview.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Preview.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Preview.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Preview.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Preview.Name = "Btn_Unit_Order_Preview"
        '
        'Btn_New
        '
        Me.Btn_New.Caption = "New"
        Me.Btn_New.Id = 4
        Me.Btn_New.Name = "Btn_New"
        '
        'Btn_Save
        '
        Me.Btn_Save.Caption = "Save"
        Me.Btn_Save.Id = 5
        Me.Btn_Save.Name = "Btn_Save"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Caption = "Delete"
        Me.Btn_Delete.Id = 6
        Me.Btn_Delete.Name = "Btn_Delete"
        '
        'Btn_Close
        '
        Me.Btn_Close.Caption = "Close"
        Me.Btn_Close.Id = 7
        Me.Btn_Close.Name = "Btn_Close"
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
        'Bar_Orders
        '
        Me.Bar_Orders.BarName = "Orders"
        Me.Bar_Orders.DockCol = 0
        Me.Bar_Orders.DockRow = 1
        Me.Bar_Orders.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Preview)})
        Me.Bar_Orders.Text = "Orders"
        '
        'Btn_Unit_Order_Reload
        '
        Me.Btn_Unit_Order_Reload.Caption = "Reload Unit Orders"
        Me.Btn_Unit_Order_Reload.Id = 16
        Me.Btn_Unit_Order_Reload.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Reload.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Reload.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Reload.Name = "Btn_Unit_Order_Reload"
        '
        'Btn_Unit_Order_Add
        '
        Me.Btn_Unit_Order_Add.Caption = "Add Unit Order"
        Me.Btn_Unit_Order_Add.Id = 14
        Me.Btn_Unit_Order_Add.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Add.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Add.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Add.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Add.Name = "Btn_Unit_Order_Add"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(889, 45)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 491)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(889, 20)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 446)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(889, 45)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 446)
        '
        'Btn_Modify_Orders
        '
        Me.Btn_Modify_Orders.Caption = "Modify Orders"
        Me.Btn_Modify_Orders.Id = 19
        Me.Btn_Modify_Orders.ImageOptions.Image = CType(resources.GetObject("Btn_Modify_Orders.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Modify_Orders.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Modify_Orders.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Modify_Orders.Name = "Btn_Modify_Orders"
        '
        'Btn_Approve
        '
        Me.Btn_Approve.Caption = "Approve"
        Me.Btn_Approve.Id = 23
        Me.Btn_Approve.Name = "Btn_Approve"
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("c4f0a519-4d96-443d-8b06-14937c864a67")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(286, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(286, 446)
        Me.DockPanel1.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_SPA_Purchase_Orders)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 417)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_SPA_Purchase_Orders
        '
        Me.Xuc_SPA_Purchase_Orders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_SPA_Purchase_Orders.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_SPA_Purchase_Orders.Name = "Xuc_SPA_Purchase_Orders"
        Me.Xuc_SPA_Purchase_Orders.Size = New System.Drawing.Size(279, 417)
        Me.Xuc_SPA_Purchase_Orders.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba")
        Me.DockPanel2.Location = New System.Drawing.Point(689, 45)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(200, 446)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 417)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(193, 417)
        Me.Xuc_Settings.TabIndex = 0
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel3.ID = New System.Guid("21bc6ef0-e942-4840-bdb9-47f86922a12c")
        Me.DockPanel3.Location = New System.Drawing.Point(286, 230)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 261)
        Me.DockPanel3.Size = New System.Drawing.Size(403, 261)
        Me.DockPanel3.Text = "Unit Orders"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.GridControl_Items)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(397, 231)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'GridControl_Items
        '
        Me.GridControl_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_Items.Location = New System.Drawing.Point(0, 0)
        Me.GridControl_Items.MainView = Me.GridView_Items
        Me.GridControl_Items.Name = "GridControl_Items"
        Me.GridControl_Items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit_Quantity, Me.RepositoryItemLookUpEdit_Parts_Number, Me.RepositoryItemCalcEdit_SRP, Me.RepositoryItemCalcEdit_Total_SRP, Me.RepositoryItemCalcEdit_Net_Profit, Me.RepositoryItemTextEdit_Total_Cost2, Me.RepositoryItemTextEdit_Part_Name, Me.RepositoryItemComboBox_Category})
        Me.GridControl_Items.Size = New System.Drawing.Size(397, 231)
        Me.GridControl_Items.TabIndex = 15
        Me.GridControl_Items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Items})
        '
        'GridView_Items
        '
        Me.GridView_Items.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colCategory, Me.colParts_Number, Me.colParts_Name, Me.colQuantity, Me.colUnit_Cost, Me.colSRP, Me.colNet_Profit, Me.colTotal_Cost2, Me.colTotal_SRP, Me.colUnit_Description, Me.colNotes2, Me.colAdded_By2, Me.colAdded_Date2, Me.colModified_By2, Me.colModified_Date2})
        Me.GridView_Items.GridControl = Me.GridControl_Items
        Me.GridView_Items.Name = "GridView_Items"
        Me.GridView_Items.OptionsView.ColumnAutoWidth = False
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        Me.colID2.Visible = True
        Me.colID2.VisibleIndex = 0
        '
        'colCategory
        '
        Me.colCategory.Caption = "Category"
        Me.colCategory.ColumnEdit = Me.RepositoryItemComboBox_Category
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 1
        '
        'RepositoryItemComboBox_Category
        '
        Me.RepositoryItemComboBox_Category.AutoHeight = False
        Me.RepositoryItemComboBox_Category.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_Category.Items.AddRange(New Object() {"SPARE PARTS", "LUBRICANTS", "APPARELS", "MERCHANDISE", "FREEBIES"})
        Me.RepositoryItemComboBox_Category.Name = "RepositoryItemComboBox_Category"
        '
        'colParts_Number
        '
        Me.colParts_Number.ColumnEdit = Me.RepositoryItemLookUpEdit_Parts_Number
        Me.colParts_Number.FieldName = "Parts_Number"
        Me.colParts_Number.Name = "colParts_Number"
        Me.colParts_Number.Visible = True
        Me.colParts_Number.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit_Parts_Number
        '
        Me.RepositoryItemLookUpEdit_Parts_Number.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Parts_Number.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Parts_Number.Name = "RepositoryItemLookUpEdit_Parts_Number"
        '
        'colParts_Name
        '
        Me.colParts_Name.ColumnEdit = Me.RepositoryItemTextEdit_Part_Name
        Me.colParts_Name.FieldName = "Parts_Name"
        Me.colParts_Name.Name = "colParts_Name"
        Me.colParts_Name.Visible = True
        Me.colParts_Name.VisibleIndex = 3
        '
        'RepositoryItemTextEdit_Part_Name
        '
        Me.RepositoryItemTextEdit_Part_Name.AutoHeight = False
        Me.RepositoryItemTextEdit_Part_Name.Name = "RepositoryItemTextEdit_Part_Name"
        '
        'colQuantity
        '
        Me.colQuantity.ColumnEdit = Me.RepositoryItemSpinEdit_Quantity
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0}")})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 4
        '
        'RepositoryItemSpinEdit_Quantity
        '
        Me.RepositoryItemSpinEdit_Quantity.AutoHeight = False
        Me.RepositoryItemSpinEdit_Quantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit_Quantity.Name = "RepositoryItemSpinEdit_Quantity"
        '
        'colUnit_Cost
        '
        Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnit_Cost.FieldName = "Cost"
        Me.colUnit_Cost.Name = "colUnit_Cost"
        Me.colUnit_Cost.Visible = True
        Me.colUnit_Cost.VisibleIndex = 5
        '
        'colSRP
        '
        Me.colSRP.ColumnEdit = Me.RepositoryItemCalcEdit_SRP
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 8
        '
        'RepositoryItemCalcEdit_SRP
        '
        Me.RepositoryItemCalcEdit_SRP.AutoHeight = False
        Me.RepositoryItemCalcEdit_SRP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit_SRP.Name = "RepositoryItemCalcEdit_SRP"
        '
        'colNet_Profit
        '
        Me.colNet_Profit.ColumnEdit = Me.RepositoryItemCalcEdit_Net_Profit
        Me.colNet_Profit.FieldName = "Net_Profit"
        Me.colNet_Profit.Name = "colNet_Profit"
        Me.colNet_Profit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Net_Profit", "{0:0.##}")})
        Me.colNet_Profit.Visible = True
        Me.colNet_Profit.VisibleIndex = 7
        '
        'RepositoryItemCalcEdit_Net_Profit
        '
        Me.RepositoryItemCalcEdit_Net_Profit.AutoHeight = False
        Me.RepositoryItemCalcEdit_Net_Profit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit_Net_Profit.Name = "RepositoryItemCalcEdit_Net_Profit"
        '
        'colTotal_Cost2
        '
        Me.colTotal_Cost2.ColumnEdit = Me.RepositoryItemTextEdit_Total_Cost2
        Me.colTotal_Cost2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal_Cost2.FieldName = "Total_Cost"
        Me.colTotal_Cost2.Name = "colTotal_Cost2"
        Me.colTotal_Cost2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total_Cost", "{0:0.##}")})
        Me.colTotal_Cost2.Visible = True
        Me.colTotal_Cost2.VisibleIndex = 6
        '
        'RepositoryItemTextEdit_Total_Cost2
        '
        Me.RepositoryItemTextEdit_Total_Cost2.AutoHeight = False
        Me.RepositoryItemTextEdit_Total_Cost2.Name = "RepositoryItemTextEdit_Total_Cost2"
        '
        'colTotal_SRP
        '
        Me.colTotal_SRP.ColumnEdit = Me.RepositoryItemCalcEdit_Total_SRP
        Me.colTotal_SRP.FieldName = "Total_SRP"
        Me.colTotal_SRP.Name = "colTotal_SRP"
        Me.colTotal_SRP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total_SRP", "{0:0.##}")})
        Me.colTotal_SRP.Visible = True
        Me.colTotal_SRP.VisibleIndex = 10
        '
        'RepositoryItemCalcEdit_Total_SRP
        '
        Me.RepositoryItemCalcEdit_Total_SRP.AutoHeight = False
        Me.RepositoryItemCalcEdit_Total_SRP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit_Total_SRP.Name = "RepositoryItemCalcEdit_Total_SRP"
        '
        'colUnit_Description
        '
        Me.colUnit_Description.FieldName = "Unit_Description"
        Me.colUnit_Description.Name = "colUnit_Description"
        Me.colUnit_Description.Visible = True
        Me.colUnit_Description.VisibleIndex = 9
        '
        'colNotes2
        '
        Me.colNotes2.FieldName = "Notes"
        Me.colNotes2.Name = "colNotes2"
        Me.colNotes2.Visible = True
        Me.colNotes2.VisibleIndex = 11
        '
        'colAdded_By2
        '
        Me.colAdded_By2.FieldName = "Added_By"
        Me.colAdded_By2.Name = "colAdded_By2"
        Me.colAdded_By2.Visible = True
        Me.colAdded_By2.VisibleIndex = 12
        '
        'colAdded_Date2
        '
        Me.colAdded_Date2.FieldName = "Added_Date"
        Me.colAdded_Date2.Name = "colAdded_Date2"
        Me.colAdded_Date2.OptionsColumn.AllowEdit = False
        Me.colAdded_Date2.Visible = True
        Me.colAdded_Date2.VisibleIndex = 13
        '
        'colModified_By2
        '
        Me.colModified_By2.FieldName = "Modified_By"
        Me.colModified_By2.Name = "colModified_By2"
        Me.colModified_By2.Visible = True
        Me.colModified_By2.VisibleIndex = 14
        '
        'colModified_Date2
        '
        Me.colModified_Date2.FieldName = "Modified_Date"
        Me.colModified_Date2.Name = "colModified_Date2"
        Me.colModified_Date2.OptionsColumn.AllowEdit = False
        Me.colModified_Date2.Visible = True
        Me.colModified_Date2.VisibleIndex = 15
        '
        'GridControl
        '
        Me.GridControl.DataMember = "acc_Tickets"
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(286, 45)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Brand_Code})
        Me.GridControl.Size = New System.Drawing.Size(403, 185)
        Me.GridControl.TabIndex = 6
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsApproved, Me.colOrder_Type, Me.colOrder_Code, Me.colBrand_Code, Me.colOrder_Date, Me.colTotal_Quantity, Me.colCost_GrandTotal, Me.colSRP_GrandTotal, Me.colNet_Profit_GrandTotal, Me.colGrand_Total, Me.colTotal_Received, Me.colTotal_Remaining, Me.colOrder_Description, Me.colNotes, Me.colOrder_Status, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsView.ColumnAutoWidth = False
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
        'colOrder_Type
        '
        Me.colOrder_Type.FieldName = "Order_Type"
        Me.colOrder_Type.Name = "colOrder_Type"
        Me.colOrder_Type.Visible = True
        Me.colOrder_Type.VisibleIndex = 2
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
        Me.colBrand_Code.VisibleIndex = 4
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
        Me.colOrder_Date.VisibleIndex = 5
        '
        'colTotal_Quantity
        '
        Me.colTotal_Quantity.FieldName = "Total_Quantity"
        Me.colTotal_Quantity.Name = "colTotal_Quantity"
        Me.colTotal_Quantity.Visible = True
        Me.colTotal_Quantity.VisibleIndex = 6
        '
        'colCost_GrandTotal
        '
        Me.colCost_GrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCost_GrandTotal.FieldName = "Cost_GrandTotal"
        Me.colCost_GrandTotal.Name = "colCost_GrandTotal"
        Me.colCost_GrandTotal.Visible = True
        Me.colCost_GrandTotal.VisibleIndex = 7
        '
        'colSRP_GrandTotal
        '
        Me.colSRP_GrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSRP_GrandTotal.FieldName = "SRP_GrandTotal"
        Me.colSRP_GrandTotal.Name = "colSRP_GrandTotal"
        Me.colSRP_GrandTotal.Visible = True
        Me.colSRP_GrandTotal.VisibleIndex = 8
        '
        'colNet_Profit_GrandTotal
        '
        Me.colNet_Profit_GrandTotal.Caption = "Net_Profit_GrandTotal"
        Me.colNet_Profit_GrandTotal.DisplayFormat.FormatString = "N2"
        Me.colNet_Profit_GrandTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNet_Profit_GrandTotal.GroupFormat.FormatString = "N2"
        Me.colNet_Profit_GrandTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNet_Profit_GrandTotal.Name = "colNet_Profit_GrandTotal"
        Me.colNet_Profit_GrandTotal.Visible = True
        Me.colNet_Profit_GrandTotal.VisibleIndex = 9
        '
        'colGrand_Total
        '
        Me.colGrand_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrand_Total.FieldName = "Grand_Total"
        Me.colGrand_Total.Name = "colGrand_Total"
        Me.colGrand_Total.Visible = True
        Me.colGrand_Total.VisibleIndex = 10
        '
        'colTotal_Received
        '
        Me.colTotal_Received.FieldName = "Total_Received"
        Me.colTotal_Received.Name = "colTotal_Received"
        Me.colTotal_Received.Visible = True
        Me.colTotal_Received.VisibleIndex = 11
        '
        'colTotal_Remaining
        '
        Me.colTotal_Remaining.FieldName = "Total_Remaining"
        Me.colTotal_Remaining.Name = "colTotal_Remaining"
        Me.colTotal_Remaining.Visible = True
        Me.colTotal_Remaining.VisibleIndex = 12
        '
        'colOrder_Description
        '
        Me.colOrder_Description.Caption = "Description"
        Me.colOrder_Description.FieldName = "Order_Description"
        Me.colOrder_Description.Name = "colOrder_Description"
        Me.colOrder_Description.Visible = True
        Me.colOrder_Description.VisibleIndex = 13
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 14
        '
        'colOrder_Status
        '
        Me.colOrder_Status.Caption = "Status"
        Me.colOrder_Status.FieldName = "Order_Status"
        Me.colOrder_Status.Name = "colOrder_Status"
        Me.colOrder_Status.Visible = True
        Me.colOrder_Status.VisibleIndex = 15
        '
        'colAdded_By
        '
        Me.colAdded_By.FieldName = "Added_By"
        Me.colAdded_By.Name = "colAdded_By"
        Me.colAdded_By.Visible = True
        Me.colAdded_By.VisibleIndex = 16
        '
        'colAdded_Date
        '
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
        'colApproved_By
        '
        Me.colApproved_By.FieldName = "Approved_By"
        Me.colApproved_By.Name = "colApproved_By"
        Me.colApproved_By.Visible = True
        Me.colApproved_By.VisibleIndex = 20
        '
        'colApproved_Date
        '
        Me.colApproved_Date.FieldName = "Approved_Date"
        Me.colApproved_Date.Name = "colApproved_Date"
        Me.colApproved_Date.Visible = True
        Me.colApproved_Date.VisibleIndex = 21
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Modify_Orders, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'frm_SPA_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 511)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.DockPanel3)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_SPA_Purchase_Orders"
        Me.Text = "frm_Purchase_Orders"
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit_Part_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit_SRP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit_Net_Profit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit_Total_Cost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit_Total_SRP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents Btn_Unit_Order_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Unit_Order_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Unit_Order_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents colTotal_Quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_Brand_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSRP_GrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Btn_Modify_Orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Btn_Reload_Modified As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reload_All As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reload_Deleted As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Approve As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
    Friend WithEvents colCost_GrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Remaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Xuc_SPA_Purchase_Orders As Xuc_SPA_Purchase_Orders
    Friend WithEvents GridControl_Items As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Items As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParts_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_Parts_Number As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colParts_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Cost2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_SRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit_SRP As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit_Net_Profit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemTextEdit_Total_Cost2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCalcEdit_Total_SRP As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colNet_Profit_GrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNet_Profit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit_Part_Name As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox_Category As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
