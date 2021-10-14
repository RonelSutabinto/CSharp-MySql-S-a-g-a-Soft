Namespace Forms
    Partial Class frm_Spare_Parts
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPartsName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModelCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModelName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.bar4 = New DevExpress.XtraBars.Bar()
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
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.bar5 = New DevExpress.XtraBars.Bar()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Import = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPARTNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPARTNAME = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMODELNAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSRP1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'bar3
            '
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(300, 58)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(307, 425)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colCategory, Me.colBrand, Me.colPartsNumber, Me.colSRP, Me.colPartsName, Me.colModelCode, Me.colModelName, Me.colNote})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colid
            '
            Me.colid.Caption = "ID"
            Me.colid.FieldName = "id"
            Me.colid.Name = "colid"
            Me.colid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", "Count {0:N}")})
            Me.colid.Visible = True
            Me.colid.VisibleIndex = 0
            '
            'colCategory
            '
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 2
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 1
            '
            'colPartsNumber
            '
            Me.colPartsNumber.Caption = "Number"
            Me.colPartsNumber.FieldName = "PartsNumber"
            Me.colPartsNumber.Name = "colPartsNumber"
            Me.colPartsNumber.Visible = True
            Me.colPartsNumber.VisibleIndex = 3
            '
            'colSRP
            '
            Me.colSRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSRP.FieldName = "SRP"
            Me.colSRP.Name = "colSRP"
            Me.colSRP.Visible = True
            Me.colSRP.VisibleIndex = 4
            '
            'colPartsName
            '
            Me.colPartsName.Caption = "Name"
            Me.colPartsName.FieldName = "PartsName"
            Me.colPartsName.Name = "colPartsName"
            Me.colPartsName.Visible = True
            Me.colPartsName.VisibleIndex = 5
            '
            'colModelCode
            '
            Me.colModelCode.Caption = "Model Code(s)"
            Me.colModelCode.FieldName = "ModelCode"
            Me.colModelCode.Name = "colModelCode"
            Me.colModelCode.Visible = True
            Me.colModelCode.VisibleIndex = 6
            '
            'colModelName
            '
            Me.colModelName.Caption = "Model Name"
            Me.colModelName.FieldName = "ModelName"
            Me.colModelName.Name = "colModelName"
            Me.colModelName.Visible = True
            Me.colModelName.VisibleIndex = 7
            '
            'colNote
            '
            Me.colNote.Caption = "Note"
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.Visible = True
            Me.colNote.VisibleIndex = 8
            '
            'bar4
            '
            Me.bar4.BarName = "Journal"
            Me.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar4.DockCol = 0
            Me.bar4.DockRow = 0
            Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar4.OptionsBar.AllowQuickCustomization = False
            Me.bar4.OptionsBar.DrawDragBorder = False
            Me.bar4.OptionsBar.UseWholeRow = True
            Me.bar4.Text = "Journal"
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar5})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.btn_Import, Me.btn_Generate, Me.btn_Stop})
            Me.barManager.MaxItemId = 13
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
            Me.bar1.Offset = 115
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search, True)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 9
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'bar5
            '
            Me.bar5.BarName = "Journal"
            Me.bar5.DockCol = 0
            Me.bar5.DockRow = 1
            Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar5.FloatLocation = New System.Drawing.Point(38, 190)
            Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Import), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.bar5.Text = "Import"
            '
            'btn_Generate
            '
            Me.btn_Generate.Id = 11
            Me.btn_Generate.ImageOptions.ImageIndex = 8
            Me.btn_Generate.ImageOptions.LargeImageIndex = 8
            Me.btn_Generate.Name = "btn_Generate"
            '
            'btn_Import
            '
            Me.btn_Import.Caption = "&Import"
            Me.btn_Import.Id = 10
            Me.btn_Import.ImageOptions.ImageIndex = 7
            Me.btn_Import.ImageOptions.LargeImageIndex = 7
            Me.btn_Import.Name = "btn_Import"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "St&op"
            Me.btn_Stop.Id = 12
            Me.btn_Stop.ImageOptions.ImageIndex = 9
            Me.btn_Stop.ImageOptions.LargeImageIndex = 9
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(828, 58)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 483)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(828, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 425)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(828, 58)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 425)
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.dockPanel3)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(807, 58)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 425)
            '
            'dockPanel3
            '
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel3.ID = New System.Guid("41bdce35-d6f4-4227-8f80-e8f3c106d5ed")
            Me.dockPanel3.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(400, 200)
            Me.dockPanel3.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel3.SavedIndex = 1
            Me.dockPanel3.SavedSizeFactor = 0R
            Me.dockPanel3.Size = New System.Drawing.Size(400, 460)
            Me.dockPanel3.Text = "Importer"
            Me.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel3_Container
            '
            Me.dockPanel3_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(4, 30)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(393, 427)
            Me.dockPanel3_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.gridControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(393, 427)
            Me.panelControl1.TabIndex = 0
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(2, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(389, 423)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUMBER, Me.colPARTNUMBER, Me.colPARTNAME, Me.colMODEL, Me.colMODELNAME1, Me.colSRP1})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridView1.gridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowIncrementalSearch = True
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            '
            'colNUMBER
            '
            Me.colNUMBER.FieldName = "NUMBER"
            Me.colNUMBER.Name = "colNUMBER"
            Me.colNUMBER.Visible = True
            Me.colNUMBER.VisibleIndex = 0
            '
            'colPARTNUMBER
            '
            Me.colPARTNUMBER.FieldName = "PART NUMBER"
            Me.colPARTNUMBER.Name = "colPARTNUMBER"
            Me.colPARTNUMBER.Visible = True
            Me.colPARTNUMBER.VisibleIndex = 1
            '
            'colPARTNAME
            '
            Me.colPARTNAME.FieldName = "PART NAME"
            Me.colPARTNAME.Name = "colPARTNAME"
            Me.colPARTNAME.Visible = True
            Me.colPARTNAME.VisibleIndex = 2
            '
            'colMODEL
            '
            Me.colMODEL.FieldName = "MODEL"
            Me.colMODEL.Name = "colMODEL"
            Me.colMODEL.Visible = True
            Me.colMODEL.VisibleIndex = 3
            '
            'colMODELNAME1
            '
            Me.colMODELNAME1.FieldName = "MODEL NAME"
            Me.colMODELNAME1.Name = "colMODELNAME1"
            Me.colMODELNAME1.Visible = True
            Me.colMODELNAME1.VisibleIndex = 4
            '
            'colSRP1
            '
            Me.colSRP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSRP1.FieldName = "SRP"
            Me.colSRP1.Name = "colSRP1"
            Me.colSRP1.Visible = True
            Me.colSRP1.VisibleIndex = 5
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("5538a9c2-3200-4c9d-9561-7c5d32abc4e6")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 58)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 400)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 425)
            Me.dockPanel1.Text = "Spare Part Information"
            '
            'dockPanel1_Container
            '
            Me.Xuc_Spare_Part = New SagaSpareParts.Controls.Xuc_Spare_Part()
            Me.dockPanel1_Container.Controls.Add(Me.Xuc_Spare_Part)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(291, 398)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'Xuc_Spare_Part
            '
            Me.Xuc_Spare_Part.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Xuc_Spare_Part.Location = New System.Drawing.Point(0, 0)
            Me.Xuc_Spare_Part.Name = "Xuc_Spare_Part"
            Me.Xuc_Spare_Part.Size = New System.Drawing.Size(291, 398)
            Me.Xuc_Spare_Part.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("ef79dc17-2f7a-40e0-bd08-bf12cf0464c0")
            Me.dockPanel2.Location = New System.Drawing.Point(607, 58)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(200, 425)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.Xuc_Settings)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(5, 23)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(191, 398)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'Xuc_Settings
            '
            Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.Xuc_Settings.Name = "Xuc_Settings"
            Me.Xuc_Settings.Size = New System.Drawing.Size(191, 398)
            Me.Xuc_Settings.TabIndex = 0
            '
            'frm_Spare_Parts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(828, 483)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Spare_Parts"
            Me.ShowMdiChildCaptionInParentTitle = True
            Me.Text = "Spare Parts"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private bar3 As DevExpress.XtraBars.Bar
        Private bar4 As DevExpress.XtraBars.Bar
        Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModelCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModelName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Private BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private bar5 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Import As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colNUMBER As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPARTNUMBER As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPARTNAME As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMODEL As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMODELNAME1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSRP1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Private Xuc_Spare_Part As SagaSpareParts.Controls.Xuc_Spare_Part
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace