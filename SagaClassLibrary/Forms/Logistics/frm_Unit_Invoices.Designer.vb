Namespace Forms.Logistics
    Partial Class frm_Unit_Invoices
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
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
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.Xuc_Unit_Invoice = New SagaClassLibrary.Controls.Logistics.xuc_Unit_Invoice()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDue_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Color = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRemaining_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoice_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIs_Deleted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Preview})
            Me.barManager.MaxItemId = 13
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 101
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 0
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 0
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 1
            Me.btn_Reload.ImageOptions.LargeImageIndex = 1
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 10
            Me.btn_Preview.ImageOptions.ImageIndex = 5
            Me.btn_Preview.ImageOptions.LargeImageIndex = 5
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 2
            Me.btn_New.ImageOptions.LargeImageIndex = 2
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 3
            Me.btn_Save.ImageOptions.LargeImageIndex = 3
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 4
            Me.btn_Delete.ImageOptions.LargeImageIndex = 4
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 6
            Me.btn_Close.ImageOptions.LargeImageIndex = 6
            Me.btn_Close.Name = "btn_Close"
            '
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 6
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 7
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            Me.RepositoryItemSearchControl_Search.Sorted = True
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(861, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 507)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(861, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(861, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
            '
            'dockManager
            '
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("eacf0590-8dc3-4b60-81f2-c8f6a0029b5f")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(250, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(250, 487)
            Me.dockPanel1.Text = "Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.Xuc_Unit_Invoice)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(243, 458)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'Xuc_Unit_Invoice
            '
            Me.Xuc_Unit_Invoice.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Xuc_Unit_Invoice.Location = New System.Drawing.Point(0, 0)
            Me.Xuc_Unit_Invoice.Name = "Xuc_Unit_Invoice"
            Me.Xuc_Unit_Invoice.Size = New System.Drawing.Size(243, 458)
            Me.Xuc_Unit_Invoice.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("76ea4b49-8c9e-4811-9d85-1573d4752e91")
            Me.dockPanel2.Location = New System.Drawing.Point(581, 20)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(280, 487)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 458)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.AutoSize = True
            Me.panelControl1.Controls.Add(Me.xuc_Settings)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(273, 458)
            Me.panelControl1.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 454)
            Me.xuc_Settings.TabIndex = 0
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(250, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.barManager
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(331, 487)
            Me.gridControl.TabIndex = 9
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInvoice_Status, Me.colInvoice_Code, Me.colBrand_Code, Me.colOrder_Code, Me.colInvoice_Number, Me.colInvoice_Date, Me.colDue_Date, Me.colModel_Code, Me.colModel_Name, Me.colModel_Color, Me.colQuantity, Me.colInvoice_Amount, Me.colRemaining_Balance, Me.colFreight_Cost, Me.colInvoice_Description, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colIs_Deleted, Me.colDeleted_By, Me.colDeleted_Date})
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
            'colInvoice_Status
            '
            Me.colInvoice_Status.Caption = "Status"
            Me.colInvoice_Status.FieldName = "Invoice_Status"
            Me.colInvoice_Status.Name = "colInvoice_Status"
            Me.colInvoice_Status.Visible = True
            Me.colInvoice_Status.VisibleIndex = 1
            '
            'colInvoice_Code
            '
            Me.colInvoice_Code.FieldName = "Invoice_Code"
            Me.colInvoice_Code.Name = "colInvoice_Code"
            Me.colInvoice_Code.Visible = True
            Me.colInvoice_Code.VisibleIndex = 2
            '
            'colBrand_Code
            '
            Me.colBrand_Code.Caption = "Brand / Dealer"
            Me.colBrand_Code.FieldName = "Brand_Code"
            Me.colBrand_Code.Name = "colBrand_Code"
            Me.colBrand_Code.Visible = True
            Me.colBrand_Code.VisibleIndex = 3
            '
            'colInvoice_Number
            '
            Me.colInvoice_Number.FieldName = "Invoice_Number"
            Me.colInvoice_Number.Name = "colInvoice_Number"
            Me.colInvoice_Number.Visible = True
            Me.colInvoice_Number.VisibleIndex = 5
            '
            'colInvoice_Date
            '
            Me.colInvoice_Date.FieldName = "Due_Date"
            Me.colInvoice_Date.Name = "colInvoice_Date"
            Me.colInvoice_Date.Visible = True
            Me.colInvoice_Date.VisibleIndex = 6
            '
            'colDue_Date
            '
            Me.colDue_Date.FieldName = "Due_Date"
            Me.colDue_Date.Name = "colDue_Date"
            Me.colDue_Date.Visible = True
            Me.colDue_Date.VisibleIndex = 7
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 8
            '
            'colModel_Name
            '
            Me.colModel_Name.Caption = "Model"
            Me.colModel_Name.FieldName = "Model_Name"
            Me.colModel_Name.Name = "colModel_Name"
            Me.colModel_Name.Visible = True
            Me.colModel_Name.VisibleIndex = 9
            '
            'colModel_Color
            '
            Me.colModel_Color.Caption = "Color"
            Me.colModel_Color.FieldName = "Model_Color"
            Me.colModel_Color.Name = "colModel_Color"
            Me.colModel_Color.Visible = True
            Me.colModel_Color.VisibleIndex = 10
            '
            'colQuantity
            '
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 11
            '
            'colInvoice_Amount
            '
            Me.colInvoice_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInvoice_Amount.FieldName = "Invoice_Amount"
            Me.colInvoice_Amount.Name = "colInvoice_Amount"
            Me.colInvoice_Amount.Visible = True
            Me.colInvoice_Amount.VisibleIndex = 12
            '
            'colRemaining_Balance
            '
            Me.colRemaining_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRemaining_Balance.FieldName = "Remaining_Balance"
            Me.colRemaining_Balance.Name = "colRemaining_Balance"
            Me.colRemaining_Balance.Visible = True
            Me.colRemaining_Balance.VisibleIndex = 13
            '
            'colFreight_Cost
            '
            Me.colFreight_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost.FieldName = "Freight_Cost"
            Me.colFreight_Cost.Name = "colFreight_Cost"
            Me.colFreight_Cost.Visible = True
            Me.colFreight_Cost.VisibleIndex = 14
            '
            'colInvoice_Description
            '
            Me.colInvoice_Description.Caption = "Description"
            Me.colInvoice_Description.FieldName = "Invoice_Description"
            Me.colInvoice_Description.Name = "colInvoice_Description"
            Me.colInvoice_Description.Visible = True
            Me.colInvoice_Description.VisibleIndex = 15
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 16
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 17
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 18
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 19
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 20
            '
            'colIs_Deleted
            '
            Me.colIs_Deleted.FieldName = "Is_Deleted"
            Me.colIs_Deleted.Name = "colIs_Deleted"
            Me.colIs_Deleted.Visible = True
            Me.colIs_Deleted.VisibleIndex = 21
            '
            'colDeleted_By
            '
            Me.colDeleted_By.FieldName = "Deleted_By"
            Me.colDeleted_By.Name = "colDeleted_By"
            Me.colDeleted_By.Visible = True
            Me.colDeleted_By.VisibleIndex = 22
            '
            'colDeleted_Date
            '
            Me.colDeleted_Date.FieldName = "Deleted_Date"
            Me.colDeleted_Date.Name = "colDeleted_Date"
            Me.colDeleted_Date.Visible = True
            Me.colDeleted_Date.VisibleIndex = 23
            '
            'colOrder_Code
            '
            Me.colOrder_Code.FieldName = "Order_Code"
            Me.colOrder_Code.Name = "colOrder_Code"
            Me.colOrder_Code.Visible = True
            Me.colOrder_Code.VisibleIndex = 4
            '
            'frm_Unit_Invoices
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(861, 507)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Unit_Invoices"
            Me.Text = "Item Costing"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.dockPanel2_Container.PerformLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private popupMenu As DevExpress.XtraBars.PopupMenu
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents xuc_Unit_Invoice As Controls.Logistics.xuc_Unit_Invoice
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDue_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Amount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemaining_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInvoice_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIs_Deleted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Color As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Code As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace