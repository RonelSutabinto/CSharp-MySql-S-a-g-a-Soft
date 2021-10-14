<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Spare_Parts_Purchase_Orders
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reset = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Spare_Parts_Purchase_Order = New SagaOperations.Xuc_Spare_Parts_Purchase_Order()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl_Items = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Items = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_Category = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colParts_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit_PartsNumber = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colParts_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpare_Parts_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpare_Parts_Decription = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_PartsNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Initialize, Me.BarEditItem_Search, Me.Btn_Reset, Me.Btn_Reload, Me.Btn_Preview, Me.Btn_New, Me.Btn_Save, Me.Btn_Delete, Me.Btn_Close})
        Me.BarManager.MaxItemId = 12
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Search, "", False, True, True, 48)})
        Me.Bar1.Text = "Tools"
        '
        'BarEditItem_Search
        '
        Me.BarEditItem_Search.Caption = "BarEditItem1"
        Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
        Me.BarEditItem_Search.Id = 4
        Me.BarEditItem_Search.Name = "BarEditItem_Search"
        '
        'RepositoryItemSearchControl_Search
        '
        Me.RepositoryItemSearchControl_Search.AutoHeight = False
        Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 1
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reset), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
        Me.Bar2.Offset = 101
        Me.Bar2.Text = "Custom 3"
        '
        'Btn_Initialize
        '
        Me.Btn_Initialize.Caption = "Initialize"
        Me.Btn_Initialize.Id = 3
        Me.Btn_Initialize.Name = "Btn_Initialize"
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Caption = "Reset"
        Me.Btn_Reset.Id = 5
        Me.Btn_Reset.Name = "Btn_Reset"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Caption = "Reload"
        Me.Btn_Reload.Id = 6
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.Id = 7
        Me.Btn_Preview.Name = "Btn_Preview"
        '
        'Btn_New
        '
        Me.Btn_New.Caption = "New"
        Me.Btn_New.Id = 8
        Me.Btn_New.Name = "Btn_New"
        '
        'Btn_Save
        '
        Me.Btn_Save.Caption = "Save"
        Me.Btn_Save.Id = 9
        Me.Btn_Save.Name = "Btn_Save"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Caption = "Delete"
        Me.Btn_Delete.Id = 10
        Me.Btn_Delete.Name = "Btn_Delete"
        '
        'Btn_Close
        '
        Me.Btn_Close.Caption = "Close"
        Me.Btn_Close.Id = 11
        Me.Btn_Close.Name = "Btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(776, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 430)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(776, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 410)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(776, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 410)
        '
        'DockManager
        '
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("aa2fc3d1-8b0e-4825-accc-9de75f52480b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(250, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(250, 410)
        Me.DockPanel1.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_Spare_Parts_Purchase_Order)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(243, 381)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_Spare_Parts_Purchase_Order
        '
        Me.Xuc_Spare_Parts_Purchase_Order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Spare_Parts_Purchase_Order.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Spare_Parts_Purchase_Order.Name = "Xuc_Spare_Parts_Purchase_Order"
        Me.Xuc_Spare_Parts_Purchase_Order.Size = New System.Drawing.Size(243, 381)
        Me.Xuc_Spare_Parts_Purchase_Order.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("da159e74-72a6-4a8b-aaff-4df13dfda9e3")
        Me.DockPanel2.Location = New System.Drawing.Point(546, 20)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(230, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(230, 410)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(223, 381)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(223, 381)
        Me.Xuc_Settings.TabIndex = 0
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel3.ID = New System.Guid("a6d148f5-ad8f-4bbc-8f0b-5e363e3f36c6")
        Me.DockPanel3.Location = New System.Drawing.Point(250, 230)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Size = New System.Drawing.Size(296, 200)
        Me.DockPanel3.Text = "Units Orders"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.GridControl_Items)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(290, 170)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'GridControl_Items
        '
        Me.GridControl_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_Items.Location = New System.Drawing.Point(0, 0)
        Me.GridControl_Items.MainView = Me.GridView_Items
        Me.GridControl_Items.MenuManager = Me.BarManager
        Me.GridControl_Items.Name = "GridControl_Items"
        Me.GridControl_Items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_PartsNumber, Me.RepositoryItemLookUpEdit_Category, Me.RepositoryItemSpinEdit_Quantity})
        Me.GridControl_Items.Size = New System.Drawing.Size(290, 170)
        Me.GridControl_Items.TabIndex = 17
        Me.GridControl_Items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Items})
        '
        'GridView_Items
        '
        Me.GridView_Items.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colCategory, Me.colParts_Number, Me.colParts_Name, Me.colSpare_Parts_Cost, Me.colQuantity, Me.colTotal_Cost, Me.colSpare_Parts_Decription, Me.colNotes2, Me.colAdded_By2, Me.colAdded_Date2, Me.colModified_By2, Me.colModified_Date2})
        Me.GridView_Items.GridControl = Me.GridControl_Items
        Me.GridView_Items.Name = "GridView_Items"
        Me.GridView_Items.OptionsView.ColumnAutoWidth = False
        Me.GridView_Items.OptionsView.ShowFooter = True
        '
        'colID2
        '
        Me.colID2.Caption = "ID2"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        Me.colID2.Visible = True
        Me.colID2.VisibleIndex = 0
        '
        'colCategory
        '
        Me.colCategory.Caption = "Category"
        Me.colCategory.ColumnEdit = Me.RepositoryItemLookUpEdit_Category
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit_Category
        '
        Me.RepositoryItemLookUpEdit_Category.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Category.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Category.Name = "RepositoryItemLookUpEdit_Category"
        '
        'colParts_Number
        '
        Me.colParts_Number.Caption = "PartsNumber"
        Me.colParts_Number.ColumnEdit = Me.RepositoryItemLookUpEdit_PartsNumber
        Me.colParts_Number.FieldName = "Parts_Number"
        Me.colParts_Number.Name = "colParts_Number"
        Me.colParts_Number.Visible = True
        Me.colParts_Number.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit_PartsNumber
        '
        Me.RepositoryItemLookUpEdit_PartsNumber.AutoHeight = False
        Me.RepositoryItemLookUpEdit_PartsNumber.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_PartsNumber.Name = "RepositoryItemLookUpEdit_PartsNumber"
        '
        'colParts_Name
        '
        Me.colParts_Name.Caption = "PartsName"
        Me.colParts_Name.FieldName = "PartsName"
        Me.colParts_Name.Name = "colParts_Name"
        Me.colParts_Name.Visible = True
        Me.colParts_Name.VisibleIndex = 3
        '
        'colSpare_Parts_Cost
        '
        Me.colSpare_Parts_Cost.Caption = "Spare_Parts_Cost"
        Me.colSpare_Parts_Cost.FieldName = "SPCostWoVAT"
        Me.colSpare_Parts_Cost.Name = "colSpare_Parts_Cost"
        Me.colSpare_Parts_Cost.Visible = True
        Me.colSpare_Parts_Cost.VisibleIndex = 4
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
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
        'colTotal_Cost
        '
        Me.colTotal_Cost.Caption = "Total_Cost"
        Me.colTotal_Cost.FieldName = "TotalCost"
        Me.colTotal_Cost.Name = "colTotal_Cost"
        Me.colTotal_Cost.Visible = True
        Me.colTotal_Cost.VisibleIndex = 6
        '
        'colSpare_Parts_Decription
        '
        Me.colSpare_Parts_Decription.Caption = "Spare_Parts_Description"
        Me.colSpare_Parts_Decription.FieldName = "Spare_Parts_Description"
        Me.colSpare_Parts_Decription.Name = "colSpare_Parts_Decription"
        Me.colSpare_Parts_Decription.Visible = True
        Me.colSpare_Parts_Decription.VisibleIndex = 7
        '
        'colNotes2
        '
        Me.colNotes2.Caption = "Notes"
        Me.colNotes2.FieldName = "Notes"
        Me.colNotes2.Name = "colNotes2"
        Me.colNotes2.Visible = True
        Me.colNotes2.VisibleIndex = 8
        '
        'colAdded_By2
        '
        Me.colAdded_By2.Caption = "Added By"
        Me.colAdded_By2.FieldName = "Added_By"
        Me.colAdded_By2.Name = "colAdded_By2"
        Me.colAdded_By2.Visible = True
        Me.colAdded_By2.VisibleIndex = 9
        '
        'colAdded_Date2
        '
        Me.colAdded_Date2.Caption = "Added Date"
        Me.colAdded_Date2.FieldName = "Added_Date"
        Me.colAdded_Date2.Name = "colAdded_Date2"
        Me.colAdded_Date2.Visible = True
        Me.colAdded_Date2.VisibleIndex = 10
        '
        'colModified_By2
        '
        Me.colModified_By2.Caption = "Modified By"
        Me.colModified_By2.FieldName = "Modified_By"
        Me.colModified_By2.Name = "colModified_By2"
        Me.colModified_By2.Visible = True
        Me.colModified_By2.VisibleIndex = 11
        '
        'colModified_Date2
        '
        Me.colModified_Date2.Caption = "Modified Date"
        Me.colModified_Date2.FieldName = "Modified_Date"
        Me.colModified_Date2.Name = "colModified_Date2"
        Me.colModified_Date2.Visible = True
        Me.colModified_Date2.VisibleIndex = 12
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(250, 20)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.MenuManager = Me.BarManager
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Brand_Code})
        Me.GridControl.Size = New System.Drawing.Size(296, 210)
        Me.GridControl.TabIndex = 8
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsApproved, Me.colOrder_Code, Me.colBrand_Code, Me.colOrder_Date, Me.colTotal_Quantity, Me.colGrand_Total, Me.colOrder_Description, Me.colNotes, Me.colOrder_Status, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIsApproved
        '
        Me.colIsApproved.Caption = "Is Approved"
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        Me.colIsApproved.Visible = True
        Me.colIsApproved.VisibleIndex = 1
        '
        'colOrder_Code
        '
        Me.colOrder_Code.Caption = "Order_Code"
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
        Me.colOrder_Date.Caption = "Order_Date"
        Me.colOrder_Date.FieldName = "Order_Date"
        Me.colOrder_Date.Name = "colOrder_Date"
        Me.colOrder_Date.Visible = True
        Me.colOrder_Date.VisibleIndex = 4
        '
        'colTotal_Quantity
        '
        Me.colTotal_Quantity.Caption = "Total_Quantity"
        Me.colTotal_Quantity.FieldName = "Total_Quantity"
        Me.colTotal_Quantity.Name = "colTotal_Quantity"
        Me.colTotal_Quantity.Visible = True
        Me.colTotal_Quantity.VisibleIndex = 5
        '
        'colGrand_Total
        '
        Me.colGrand_Total.Caption = "Grand_Total"
        Me.colGrand_Total.FieldName = "Grand_Total"
        Me.colGrand_Total.Name = "colGrand_Total"
        Me.colGrand_Total.Visible = True
        Me.colGrand_Total.VisibleIndex = 6
        '
        'colOrder_Description
        '
        Me.colOrder_Description.Caption = "Order_Description"
        Me.colOrder_Description.FieldName = "Order_Description"
        Me.colOrder_Description.Name = "colOrder_Description"
        Me.colOrder_Description.Visible = True
        Me.colOrder_Description.VisibleIndex = 7
        '
        'colNotes
        '
        Me.colNotes.Caption = "Notes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 8
        '
        'colOrder_Status
        '
        Me.colOrder_Status.Caption = "Order_Status"
        Me.colOrder_Status.FieldName = "Order_Status"
        Me.colOrder_Status.Name = "colOrder_Status"
        Me.colOrder_Status.Visible = True
        Me.colOrder_Status.VisibleIndex = 9
        '
        'colAdded_By
        '
        Me.colAdded_By.Caption = "Added_By"
        Me.colAdded_By.FieldName = "Added_By"
        Me.colAdded_By.Name = "colAdded_By"
        Me.colAdded_By.Visible = True
        Me.colAdded_By.VisibleIndex = 10
        '
        'colAdded_Date
        '
        Me.colAdded_Date.Caption = "Added_Date"
        Me.colAdded_Date.FieldName = "Added_Date"
        Me.colAdded_Date.Name = "colAdded_Date"
        Me.colAdded_Date.Visible = True
        Me.colAdded_Date.VisibleIndex = 11
        '
        'colModified_By
        '
        Me.colModified_By.Caption = "Modified_By"
        Me.colModified_By.FieldName = "Modified_By"
        Me.colModified_By.Name = "colModified_By"
        Me.colModified_By.Visible = True
        Me.colModified_By.VisibleIndex = 12
        '
        'colModified_Date
        '
        Me.colModified_Date.Caption = "Modified_Date"
        Me.colModified_Date.FieldName = "Modified_Date"
        Me.colModified_Date.Name = "colModified_Date"
        Me.colModified_Date.Visible = True
        Me.colModified_Date.VisibleIndex = 13
        '
        'colApproved_By
        '
        Me.colApproved_By.Caption = "Approved_By"
        Me.colApproved_By.FieldName = "Approve_By"
        Me.colApproved_By.Name = "colApproved_By"
        Me.colApproved_By.Visible = True
        Me.colApproved_By.VisibleIndex = 14
        '
        'colApproved_Date
        '
        Me.colApproved_Date.Caption = "Approved_Date"
        Me.colApproved_Date.FieldName = "Approved_Date"
        Me.colApproved_Date.Name = "colApproved_Date"
        Me.colApproved_Date.Visible = True
        Me.colApproved_Date.VisibleIndex = 15
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'frm_Spare_Parts_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 430)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.DockPanel3)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_Spare_Parts_Purchase_Orders"
        Me.Text = "frm_Spare_Parts_Purchase_Orders"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.GridControl_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_PartsNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Brand_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal_Quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrder_Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl_Items As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Items As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParts_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Xuc_Spare_Parts_Purchase_Order As Xuc_Spare_Parts_Purchase_Order
    Friend WithEvents Xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit_Brand_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit_PartsNumber As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colParts_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit_Category As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSpare_Parts_Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpare_Parts_Decription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdded_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_By2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModified_Date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
End Class
