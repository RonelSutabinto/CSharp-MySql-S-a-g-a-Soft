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
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
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
        Me.Btn_Unit_Order_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
        Me.RepositoryItemLookUpEdit_Branch2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Category = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colParts_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Parts_Number = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colParts_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCartons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit_Cartons = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit_Rebates = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit_Cost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNet_Profit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Rebates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Brand_Code = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colOrder_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal_Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrand_Total = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit_Cartons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit_Rebates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Initialize, Me.BarEditItem_Search, Me.Btn_Reload, Me.Btn_New, Me.Btn_Save, Me.Btn_Delete, Me.Btn_Close, Me.Btn_Preview, Me.Btn_Reset, Me.Btn_Unit_Order_Add, Me.Btn_Unit_Order_Delete, Me.Btn_Unit_Order_Reload})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 19
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search})
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
        Me.Btn_Reload.Caption = "Reload"
        Me.Btn_Reload.Id = 3
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.Id = 8
        Me.Btn_Preview.Name = "Btn_Preview"
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
        Me.Bar_Orders.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Add, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Delete)})
        Me.Bar_Orders.Text = "Orders"
        '
        'Btn_Unit_Order_Reload
        '
        Me.Btn_Unit_Order_Reload.Caption = "Reload Progress"
        Me.Btn_Unit_Order_Reload.Id = 16
        Me.Btn_Unit_Order_Reload.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Reload.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Reload.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Reload.Name = "Btn_Unit_Order_Reload"
        '
        'Btn_Unit_Order_Add
        '
        Me.Btn_Unit_Order_Add.Caption = "Add Progress"
        Me.Btn_Unit_Order_Add.Id = 14
        Me.Btn_Unit_Order_Add.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Add.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Add.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Add.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Add.Name = "Btn_Unit_Order_Add"
        '
        'Btn_Unit_Order_Delete
        '
        Me.Btn_Unit_Order_Delete.Caption = "Delete Progress"
        Me.Btn_Unit_Order_Delete.Id = 15
        Me.Btn_Unit_Order_Delete.ImageOptions.Image = CType(resources.GetObject("Btn_Unit_Order_Delete.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Unit_Order_Delete.ImageOptions.LargeImage = CType(resources.GetObject("Btn_Unit_Order_Delete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Btn_Unit_Order_Delete.Name = "Btn_Unit_Order_Delete"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(874, 45)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 542)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(874, 20)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 497)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(874, 45)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 497)
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("c4f0a519-4d96-443d-8b06-14937c864a67")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(286, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(286, 497)
        Me.DockPanel1.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_SPA_Purchase_Orders)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(279, 468)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_SPA_Purchase_Orders
        '
        Me.Xuc_SPA_Purchase_Orders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_SPA_Purchase_Orders.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_SPA_Purchase_Orders.Name = "Xuc_SPA_Purchase_Orders"
        Me.Xuc_SPA_Purchase_Orders.Size = New System.Drawing.Size(279, 468)
        Me.Xuc_SPA_Purchase_Orders.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba")
        Me.DockPanel2.Location = New System.Drawing.Point(674, 45)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(200, 497)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 468)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(193, 468)
        Me.Xuc_Settings.TabIndex = 0
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel3.ID = New System.Guid("21bc6ef0-e942-4840-bdb9-47f86922a12c")
        Me.DockPanel3.Location = New System.Drawing.Point(286, 342)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Size = New System.Drawing.Size(388, 200)
        Me.DockPanel3.Text = "Units Orders"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.GridControl_Items)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(382, 170)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'GridControl_Items
        '
        Me.GridControl_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_Items.Location = New System.Drawing.Point(0, 0)
        Me.GridControl_Items.MainView = Me.GridView_Items
        Me.GridControl_Items.Name = "GridControl_Items"
        Me.GridControl_Items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Category, Me.RepositoryItemSpinEdit_Quantity, Me.RepositoryItemCalcEdit_Cost, Me.RepositoryItemLookUpEdit_Parts_Number, Me.RepositoryItemCalcEdit_Rebates, Me.RepositoryItemSpinEdit_Cartons, Me.RepositoryItemComboBox_Type, Me.RepositoryItemLookUpEdit_Branch2})
        Me.GridControl_Items.Size = New System.Drawing.Size(382, 170)
        Me.GridControl_Items.TabIndex = 14
        Me.GridControl_Items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Items})
        '
        'GridView_Items
        '
        Me.GridView_Items.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colType, Me.colCategory, Me.colParts_Number, Me.colParts_Name, Me.colQuantity, Me.colCartons, Me.colRebates, Me.colUnit_Cost, Me.colSRP, Me.colNet_Profit, Me.colTotal_Rebates, Me.colTotal_Cost, Me.colTotal_SRP, Me.colUnit_Description, Me.colNotes2, Me.colAdded_By2, Me.colAdded_Date2, Me.colModified_By2, Me.colModified_Date2})
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
        'RepositoryItemLookUpEdit_Branch2
        '
        Me.RepositoryItemLookUpEdit_Branch2.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch2.Name = "RepositoryItemLookUpEdit_Branch2"
        '
        'colType
        '
        Me.colType.ColumnEdit = Me.RepositoryItemComboBox_Type
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        '
        'RepositoryItemComboBox_Type
        '
        Me.RepositoryItemComboBox_Type.AutoHeight = False
        Me.RepositoryItemComboBox_Type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_Type.Items.AddRange(New Object() {"RETAIL", "SUB-DEALER"})
        Me.RepositoryItemComboBox_Type.Name = "RepositoryItemComboBox_Type"
        '
        'colCategory
        '
        Me.colCategory.Caption = "Category"
        Me.colCategory.ColumnEdit = Me.RepositoryItemLookUpEdit_Category
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit_Category
        '
        Me.RepositoryItemLookUpEdit_Category.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Category.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Category.Name = "RepositoryItemLookUpEdit_Category"
        '
        'colParts_Number
        '
        Me.colParts_Number.ColumnEdit = Me.RepositoryItemLookUpEdit_Parts_Number
        Me.colParts_Number.FieldName = "Parts_Number"
        Me.colParts_Number.Name = "colParts_Number"
        Me.colParts_Number.Visible = True
        Me.colParts_Number.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit_Parts_Number
        '
        Me.RepositoryItemLookUpEdit_Parts_Number.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Parts_Number.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Parts_Number.Name = "RepositoryItemLookUpEdit_Parts_Number"
        '
        'colParts_Name
        '
        Me.colParts_Name.FieldName = "Parts_Name"
        Me.colParts_Name.Name = "colParts_Name"
        Me.colParts_Name.Visible = True
        Me.colParts_Name.VisibleIndex = 4
        '
        'colQuantity
        '
        Me.colQuantity.ColumnEdit = Me.RepositoryItemSpinEdit_Quantity
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 5
        '
        'RepositoryItemSpinEdit_Quantity
        '
        Me.RepositoryItemSpinEdit_Quantity.AutoHeight = False
        Me.RepositoryItemSpinEdit_Quantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit_Quantity.Name = "RepositoryItemSpinEdit_Quantity"
        '
        'colCartons
        '
        Me.colCartons.ColumnEdit = Me.RepositoryItemSpinEdit_Cartons
        Me.colCartons.FieldName = "Cartons"
        Me.colCartons.Name = "colCartons"
        Me.colCartons.Visible = True
        Me.colCartons.VisibleIndex = 6
        '
        'RepositoryItemSpinEdit_Cartons
        '
        Me.RepositoryItemSpinEdit_Cartons.AutoHeight = False
        Me.RepositoryItemSpinEdit_Cartons.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit_Cartons.Name = "RepositoryItemSpinEdit_Cartons"
        '
        'colRebates
        '
        Me.colRebates.ColumnEdit = Me.RepositoryItemCalcEdit_Rebates
        Me.colRebates.FieldName = "Rebates"
        Me.colRebates.Name = "colRebates"
        Me.colRebates.Visible = True
        Me.colRebates.VisibleIndex = 19
        '
        'RepositoryItemCalcEdit_Rebates
        '
        Me.RepositoryItemCalcEdit_Rebates.AutoHeight = False
        Me.RepositoryItemCalcEdit_Rebates.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit_Rebates.Name = "RepositoryItemCalcEdit_Rebates"
        '
        'colUnit_Cost
        '
        Me.colUnit_Cost.ColumnEdit = Me.RepositoryItemCalcEdit_Cost
        Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnit_Cost.FieldName = "Unit_Cost"
        Me.colUnit_Cost.Name = "colUnit_Cost"
        Me.colUnit_Cost.Visible = True
        Me.colUnit_Cost.VisibleIndex = 7
        '
        'RepositoryItemCalcEdit_Cost
        '
        Me.RepositoryItemCalcEdit_Cost.AutoHeight = False
        Me.RepositoryItemCalcEdit_Cost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit_Cost.Name = "RepositoryItemCalcEdit_Cost"
        '
        'colSRP
        '
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 9
        '
        'colNet_Profit
        '
        Me.colNet_Profit.FieldName = "Net_Profit"
        Me.colNet_Profit.Name = "colNet_Profit"
        Me.colNet_Profit.Visible = True
        Me.colNet_Profit.VisibleIndex = 10
        '
        'colTotal_Rebates
        '
        Me.colTotal_Rebates.FieldName = "Total_Rebates"
        Me.colTotal_Rebates.Name = "colTotal_Rebates"
        Me.colTotal_Rebates.Visible = True
        Me.colTotal_Rebates.VisibleIndex = 11
        '
        'colTotal_Cost
        '
        Me.colTotal_Cost.ColumnEdit = Me.RepositoryItemCalcEdit_Cost
        Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal_Cost.FieldName = "Total_Cost"
        Me.colTotal_Cost.Name = "colTotal_Cost"
        Me.colTotal_Cost.Visible = True
        Me.colTotal_Cost.VisibleIndex = 8
        '
        'colTotal_SRP
        '
        Me.colTotal_SRP.FieldName = "Total_SRP"
        Me.colTotal_SRP.Name = "colTotal_SRP"
        Me.colTotal_SRP.Visible = True
        Me.colTotal_SRP.VisibleIndex = 13
        '
        'colUnit_Description
        '
        Me.colUnit_Description.FieldName = "Unit_Description"
        Me.colUnit_Description.Name = "colUnit_Description"
        Me.colUnit_Description.Visible = True
        Me.colUnit_Description.VisibleIndex = 12
        '
        'colNotes2
        '
        Me.colNotes2.FieldName = "Notes"
        Me.colNotes2.Name = "colNotes2"
        Me.colNotes2.Visible = True
        Me.colNotes2.VisibleIndex = 14
        '
        'colAdded_By2
        '
        Me.colAdded_By2.FieldName = "Added_By"
        Me.colAdded_By2.Name = "colAdded_By2"
        Me.colAdded_By2.Visible = True
        Me.colAdded_By2.VisibleIndex = 15
        '
        'colAdded_Date2
        '
        Me.colAdded_Date2.FieldName = "Added_Date"
        Me.colAdded_Date2.Name = "colAdded_Date2"
        Me.colAdded_Date2.OptionsColumn.AllowEdit = False
        Me.colAdded_Date2.Visible = True
        Me.colAdded_Date2.VisibleIndex = 16
        '
        'colModified_By2
        '
        Me.colModified_By2.FieldName = "Modified_By"
        Me.colModified_By2.Name = "colModified_By2"
        Me.colModified_By2.Visible = True
        Me.colModified_By2.VisibleIndex = 17
        '
        'colModified_Date2
        '
        Me.colModified_Date2.FieldName = "Modified_Date"
        Me.colModified_Date2.Name = "colModified_Date2"
        Me.colModified_Date2.OptionsColumn.AllowEdit = False
        Me.colModified_Date2.Visible = True
        Me.colModified_Date2.VisibleIndex = 18
        '
        'GridControl
        '
        Me.GridControl.DataMember = "acc_Tickets"
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(286, 45)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Brand_Code})
        Me.GridControl.Size = New System.Drawing.Size(388, 297)
        Me.GridControl.TabIndex = 6
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsApproved, Me.colOrder_Code, Me.colBrand_Code, Me.colOrder_Date, Me.colTotal_Quantity, Me.colGrand_Total, Me.colOrder_Description, Me.colNotes, Me.colOrder_Status, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date})
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
        'colOrder_Code
        '
        Me.colOrder_Code.FieldName = "Order_Code"
        Me.colOrder_Code.Name = "colOrder_Code"
        Me.colOrder_Code.Visible = True
        Me.colOrder_Code.VisibleIndex = 2
        '
        'colBrand_Code
        '
        Me.colBrand_Code.Caption = "Brand"
        Me.colBrand_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Brand_Code
        Me.colBrand_Code.FieldName = "Brand_Code"
        Me.colBrand_Code.Name = "colBrand_Code"
        Me.colBrand_Code.Visible = True
        Me.colBrand_Code.VisibleIndex = 3
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
        Me.colOrder_Date.VisibleIndex = 4
        '
        'colTotal_Quantity
        '
        Me.colTotal_Quantity.FieldName = "Total_Quantity"
        Me.colTotal_Quantity.Name = "colTotal_Quantity"
        Me.colTotal_Quantity.Visible = True
        Me.colTotal_Quantity.VisibleIndex = 5
        '
        'colGrand_Total
        '
        Me.colGrand_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrand_Total.FieldName = "Grand_Total"
        Me.colGrand_Total.Name = "colGrand_Total"
        Me.colGrand_Total.Visible = True
        Me.colGrand_Total.VisibleIndex = 6
        '
        'colOrder_Description
        '
        Me.colOrder_Description.Caption = "Description"
        Me.colOrder_Description.FieldName = "Order_Description"
        Me.colOrder_Description.Name = "colOrder_Description"
        Me.colOrder_Description.Visible = True
        Me.colOrder_Description.VisibleIndex = 7
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 8
        '
        'colOrder_Status
        '
        Me.colOrder_Status.Caption = "Status"
        Me.colOrder_Status.FieldName = "Order_Status"
        Me.colOrder_Status.Name = "colOrder_Status"
        Me.colOrder_Status.Visible = True
        Me.colOrder_Status.VisibleIndex = 9
        '
        'colAdded_By
        '
        Me.colAdded_By.FieldName = "Added_By"
        Me.colAdded_By.Name = "colAdded_By"
        Me.colAdded_By.Visible = True
        Me.colAdded_By.VisibleIndex = 10
        '
        'colAdded_Date
        '
        Me.colAdded_Date.FieldName = "Added_Date"
        Me.colAdded_Date.Name = "colAdded_Date"
        Me.colAdded_Date.Visible = True
        Me.colAdded_Date.VisibleIndex = 11
        '
        'colModified_By
        '
        Me.colModified_By.FieldName = "Modified_By"
        Me.colModified_By.Name = "colModified_By"
        Me.colModified_By.Visible = True
        Me.colModified_By.VisibleIndex = 12
        '
        'colModified_Date
        '
        Me.colModified_Date.FieldName = "Modified_Date"
        Me.colModified_Date.Name = "colModified_Date"
        Me.colModified_Date.Visible = True
        Me.colModified_Date.VisibleIndex = 13
        '
        'colApproved_By
        '
        Me.colApproved_By.FieldName = "Approved_By"
        Me.colApproved_By.Name = "colApproved_By"
        Me.colApproved_By.Visible = True
        Me.colApproved_By.VisibleIndex = 14
        '
        'colApproved_Date
        '
        Me.colApproved_Date.FieldName = "Approved_Date"
        Me.colApproved_Date.Name = "colApproved_Date"
        Me.colApproved_Date.Visible = True
        Me.colApproved_Date.VisibleIndex = 15
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Unit_Order_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'frm_SPA_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 562)
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
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit_Cartons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit_Rebates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit_Cost, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents GridControl_Items As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Items As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit_Category As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Bar_Orders As DevExpress.XtraBars.Bar
    Friend WithEvents Btn_Unit_Order_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Unit_Order_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Unit_Order_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents colTotal_Quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit_Cost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemSpinEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParts_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_Parts_Number As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_Brand_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Xuc_SPA_Purchase_Orders As Xuc_SPA_Purchase_Orders
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParts_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit_Cartons As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit_Rebates As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNet_Profit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Rebates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_SRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit_Branch2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
