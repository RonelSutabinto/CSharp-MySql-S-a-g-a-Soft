Namespace Forms.Information.Item
    Partial Class frm_Unit_Models
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.hideContainerBottom = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Item = New SagaClassLibrary.Controls.Information.Item.xuc_Item()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colItem_Group = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProduct_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustom_Color = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEnginePrefix = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDownPayment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinanced = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate12 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMonthly12 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate18 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMonthly18 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate24 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMonthly24 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterestRate36 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMonthly36 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.colModel_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'hideContainerBottom
            '
            Me.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerBottom.Location = New System.Drawing.Point(0, 0)
            Me.hideContainerBottom.Name = "hideContainerBottom"
            Me.hideContainerBottom.Size = New System.Drawing.Size(0, 0)
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Update})
            Me.barManager.MaxItemId = 8
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(52, 141)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
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
            Me.btn_Preview.Id = 6
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
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 7
            Me.btn_Update.Name = "btn_Update"
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
            Me.barDockControlTop.Size = New System.Drawing.Size(898, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 620)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(898, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 600)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(898, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 600)
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("34632612-54b4-4e35-853c-495ff7ee17ba")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 600)
            Me.dockPanel1.Text = "Product Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Item)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 571)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Item
            '
            Me.xuc_Item.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Item.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Item.Name = "xuc_Item"
            Me.xuc_Item.Size = New System.Drawing.Size(293, 571)
            Me.xuc_Item.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("0a339335-45d5-4222-9839-3d4d8e7ae8ee")
            Me.dockPanel2.Location = New System.Drawing.Point(618, 20)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(280, 600)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 571)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.xuc_Settings)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(273, 571)
            Me.panelControl1.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 567)
            Me.xuc_Settings.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(300, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(318, 600)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colModel_Status, Me.colModel_Code, Me.colItem_Group, Me.colProduct_Type, Me.colBrand, Me.colModel, Me.colSubModel, Me.colColor, Me.colCustom_Color, Me.colDescription, Me.colEnginePrefix, Me.colChassisPrefix, Me.colUnit_Cost, Me.colUnit_SRP, Me.colCOD, Me.colAOC, Me.colDownPayment, Me.colLCP, Me.colFinanced, Me.colRebate, Me.colInterestRate12, Me.colMonthly12, Me.colInterestRate18, Me.colMonthly18, Me.colInterestRate24, Me.colMonthly24, Me.colInterestRate36, Me.colMonthly36, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colNotes})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "id"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colModel_Code
            '
            Me.colModel_Code.Caption = "Code"
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 2
            '
            'colItem_Group
            '
            Me.colItem_Group.Caption = "Group"
            Me.colItem_Group.FieldName = "itemgrp"
            Me.colItem_Group.Name = "colItem_Group"
            Me.colItem_Group.Visible = True
            Me.colItem_Group.VisibleIndex = 3
            '
            'colProduct_Type
            '
            Me.colProduct_Type.Caption = "Category"
            Me.colProduct_Type.FieldName = "Product_Type"
            Me.colProduct_Type.Name = "colProduct_Type"
            Me.colProduct_Type.Visible = True
            Me.colProduct_Type.VisibleIndex = 4
            '
            'colBrand
            '
            Me.colBrand.Caption = "Brand"
            Me.colBrand.FieldName = "branddesc"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 5
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 6
            '
            'colSubModel
            '
            Me.colSubModel.Caption = "Sub-Model"
            Me.colSubModel.FieldName = "modeldesc"
            Me.colSubModel.Name = "colSubModel"
            Me.colSubModel.Visible = True
            Me.colSubModel.VisibleIndex = 7
            '
            'colColor
            '
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 8
            '
            'colCustom_Color
            '
            Me.colCustom_Color.FieldName = "Custom_Color"
            Me.colCustom_Color.Name = "colCustom_Color"
            Me.colCustom_Color.Visible = True
            Me.colCustom_Color.VisibleIndex = 9
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 10
            '
            'colEnginePrefix
            '
            Me.colEnginePrefix.Caption = "Engine Prefix"
            Me.colEnginePrefix.FieldName = "EnginePrefix"
            Me.colEnginePrefix.Name = "colEnginePrefix"
            Me.colEnginePrefix.Visible = True
            Me.colEnginePrefix.VisibleIndex = 11
            '
            'colChassisPrefix
            '
            Me.colChassisPrefix.Caption = "Chassis Prefix"
            Me.colChassisPrefix.FieldName = "ChassisPrefix"
            Me.colChassisPrefix.Name = "colChassisPrefix"
            Me.colChassisPrefix.Visible = True
            Me.colChassisPrefix.VisibleIndex = 12
            '
            'colUnit_Cost
            '
            Me.colUnit_Cost.Caption = "Cost"
            Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_Cost.FieldName = "Unit_Cost"
            Me.colUnit_Cost.Name = "colUnit_Cost"
            Me.colUnit_Cost.Visible = True
            Me.colUnit_Cost.VisibleIndex = 13
            '
            'colUnit_SRP
            '
            Me.colUnit_SRP.Caption = "SRP"
            Me.colUnit_SRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_SRP.FieldName = "Unit_SRP"
            Me.colUnit_SRP.Name = "colUnit_SRP"
            Me.colUnit_SRP.Visible = True
            Me.colUnit_SRP.VisibleIndex = 14
            '
            'colCOD
            '
            Me.colCOD.Caption = "COD"
            Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCOD.FieldName = "COD"
            Me.colCOD.Name = "colCOD"
            Me.colCOD.Visible = True
            Me.colCOD.VisibleIndex = 15
            '
            'colAOC
            '
            Me.colAOC.Caption = "AOC"
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 16
            '
            'colDownPayment
            '
            Me.colDownPayment.Caption = "DP"
            Me.colDownPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDownPayment.FieldName = "DownPayment"
            Me.colDownPayment.Name = "colDownPayment"
            Me.colDownPayment.Visible = True
            Me.colDownPayment.VisibleIndex = 17
            '
            'colLCP
            '
            Me.colLCP.Caption = "LCP"
            Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLCP.FieldName = "LCP"
            Me.colLCP.Name = "colLCP"
            Me.colLCP.Visible = True
            Me.colLCP.VisibleIndex = 18
            '
            'colFinanced
            '
            Me.colFinanced.Caption = "Financed"
            Me.colFinanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFinanced.FieldName = "Financed"
            Me.colFinanced.Name = "colFinanced"
            Me.colFinanced.Visible = True
            Me.colFinanced.VisibleIndex = 19
            '
            'colRebate
            '
            Me.colRebate.Caption = "Rebate"
            Me.colRebate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebate.FieldName = "Rebates"
            Me.colRebate.Name = "colRebate"
            Me.colRebate.Visible = True
            Me.colRebate.VisibleIndex = 20
            '
            'colInterestRate12
            '
            Me.colInterestRate12.Caption = "Int. 12"
            Me.colInterestRate12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestRate12.FieldName = "InterestRate12"
            Me.colInterestRate12.Name = "colInterestRate12"
            Me.colInterestRate12.Visible = True
            Me.colInterestRate12.VisibleIndex = 21
            '
            'colMonthly12
            '
            Me.colMonthly12.Caption = "Monthly 12"
            Me.colMonthly12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMonthly12.FieldName = "Monthly12"
            Me.colMonthly12.Name = "colMonthly12"
            Me.colMonthly12.Visible = True
            Me.colMonthly12.VisibleIndex = 22
            '
            'colInterestRate18
            '
            Me.colInterestRate18.Caption = "Int. 18"
            Me.colInterestRate18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestRate18.FieldName = "InterestRate18"
            Me.colInterestRate18.Name = "colInterestRate18"
            Me.colInterestRate18.Visible = True
            Me.colInterestRate18.VisibleIndex = 23
            '
            'colMonthly18
            '
            Me.colMonthly18.Caption = "Monthly 18"
            Me.colMonthly18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMonthly18.FieldName = "Monthly18"
            Me.colMonthly18.Name = "colMonthly18"
            Me.colMonthly18.Visible = True
            Me.colMonthly18.VisibleIndex = 24
            '
            'colInterestRate24
            '
            Me.colInterestRate24.Caption = "Int. 24"
            Me.colInterestRate24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestRate24.FieldName = "InterestRate24"
            Me.colInterestRate24.Name = "colInterestRate24"
            Me.colInterestRate24.Visible = True
            Me.colInterestRate24.VisibleIndex = 25
            '
            'colMonthly24
            '
            Me.colMonthly24.Caption = "Monthly 24"
            Me.colMonthly24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMonthly24.FieldName = "Monthly24"
            Me.colMonthly24.Name = "colMonthly24"
            Me.colMonthly24.Visible = True
            Me.colMonthly24.VisibleIndex = 26
            '
            'colInterestRate36
            '
            Me.colInterestRate36.Caption = "Int. 36"
            Me.colInterestRate36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterestRate36.FieldName = "InterestRate36"
            Me.colInterestRate36.Name = "colInterestRate36"
            Me.colInterestRate36.Visible = True
            Me.colInterestRate36.VisibleIndex = 27
            '
            'colMonthly36
            '
            Me.colMonthly36.Caption = "Monthly 36"
            Me.colMonthly36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMonthly36.FieldName = "Monthly36"
            Me.colMonthly36.Name = "colMonthly36"
            Me.colMonthly36.Visible = True
            Me.colMonthly36.VisibleIndex = 28
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 29
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 30
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 31
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 32
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 33
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'colModel_Status
            '
            Me.colModel_Status.Caption = "Discontinued"
            Me.colModel_Status.FieldName = "Model_Status"
            Me.colModel_Status.Name = "colModel_Status"
            Me.colModel_Status.Visible = True
            Me.colModel_Status.VisibleIndex = 1
            '
            'frm_Unit_Models
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(898, 620)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.hideContainerBottom)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Unit_Models"
            Me.Text = "Products List"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Private hideContainerBottom As DevExpress.XtraBars.Docking.AutoHideContainer
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colItem_Group As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSubModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEnginePrefix As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisPrefix As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDownPayment As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate12 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMonthly12 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate24 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMonthly24 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate36 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMonthly36 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents colFinanced As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Private xuc_Item As Controls.Information.Item.xuc_Item
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colProduct_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_SRP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustom_Color As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterestRate18 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMonthly18 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colModel_Status As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace