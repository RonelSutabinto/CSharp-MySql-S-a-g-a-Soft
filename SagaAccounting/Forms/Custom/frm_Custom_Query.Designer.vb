Namespace Custom
    Partial Class frm_Custom_Query
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Custom_Query))
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.BarEditItem_Query_Type = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Query_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Table = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox_Table = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Field1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox_Field1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Field2 = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Field2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem_SQL_Command = New DevExpress.XtraBars.BarCheckItem()
            Me.btn_Execute = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Custom = New DevExpress.XtraBars.Bar()
            Me.btn_Custom = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.check_Initialize = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Reload = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Select_Show = New DevExpress.XtraEditors.CheckEdit()
            Me.DockPanel_Custom_Queries = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl_Queries = New DevExpress.XtraGrid.GridControl()
            Me.gridView_Queries = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuery_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustom_Query = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuery_Desciption = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemcheckEdit_Check_SQL_Command = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.repositoryItemTextEdit_Data_Old = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit_Data_New = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
            Me.queryString = New DevExpress.XtraEditors.MemoEdit()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Query_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox_Table, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox_Field1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Field2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Select_Show.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel_Custom_Queries.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl2.SuspendLayout()
            CType(Me.gridControl_Queries, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_Queries, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemcheckEdit_Check_SQL_Command, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit_Data_Old, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit_Data_New, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl.Panel1.SuspendLayout()
            CType(Me.splitContainerControl.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl.Panel2.SuspendLayout()
            Me.splitContainerControl.SuspendLayout()
            CType(Me.queryString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.Bar_Custom})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Initialize, Me.btn_Preview, Me.BarEditItem_Table, Me.BarEditItem_Field1, Me.btn_Execute, Me.btn_Generate, Me.barCheckItem_SQL_Command, Me.btn_Save, Me.BarEditItem_Query_Type, Me.btn_Stop, Me.btn_Custom, Me.BarEditItem_Field2})
            Me.barManager.MaxItemId = 25
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox_Table, Me.repositoryItemComboBox_Field1, Me.repositoryItemcheckEdit_Check_SQL_Command, Me.repositoryItemTextEdit_Data_Old, Me.repositoryItemTextEdit_Data_New, Me.RepositoryItemComboBox_Query_Type, Me.RepositoryItemComboBox_Field2})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(52, 176)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Query_Type, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 2
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 2
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 9
            Me.btn_Reload.ImageOptions.LargeImageIndex = 9
            Me.btn_Reload.Name = "btn_Reload"
            '
            'BarEditItem_Query_Type
            '
            Me.BarEditItem_Query_Type.Caption = "Type"
            Me.BarEditItem_Query_Type.Edit = Me.RepositoryItemComboBox_Query_Type
            Me.BarEditItem_Query_Type.EditWidth = 100
            Me.BarEditItem_Query_Type.Id = 21
            Me.BarEditItem_Query_Type.Name = "BarEditItem_Query_Type"
            '
            'RepositoryItemComboBox_Query_Type
            '
            Me.RepositoryItemComboBox_Query_Type.AutoHeight = False
            Me.RepositoryItemComboBox_Query_Type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Query_Type.Items.AddRange(New Object() {"SELECT", "UPDATE", "DELETE"})
            Me.RepositoryItemComboBox_Query_Type.Name = "RepositoryItemComboBox_Query_Type"
            Me.RepositoryItemComboBox_Query_Type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 19
            Me.btn_Save.ImageOptions.ImageIndex = 10
            Me.btn_Save.ImageOptions.LargeImageIndex = 10
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 8
            Me.btn_Preview.ImageOptions.ImageIndex = 0
            Me.btn_Preview.ImageOptions.LargeImageIndex = 0
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 1
            Me.btn_Close.ImageOptions.LargeImageIndex = 1
            Me.btn_Close.Name = "btn_Close"
            '
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(86, 168)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Table, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Field1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Field2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem_SQL_Command), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Execute), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.bar2.Offset = 14
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Table
            '
            Me.BarEditItem_Table.Caption = "Tables"
            Me.BarEditItem_Table.Edit = Me.repositoryItemComboBox_Table
            Me.BarEditItem_Table.EditWidth = 150
            Me.BarEditItem_Table.Id = 10
            Me.BarEditItem_Table.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Table.ImageOptions.Image"), System.Drawing.Image)
            Me.BarEditItem_Table.ImageOptions.ImageIndex = 3
            Me.BarEditItem_Table.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Table.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.BarEditItem_Table.ImageOptions.LargeImageIndex = 3
            Me.BarEditItem_Table.Name = "BarEditItem_Table"
            '
            'repositoryItemComboBox_Table
            '
            Me.repositoryItemComboBox_Table.AutoHeight = False
            Me.repositoryItemComboBox_Table.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox_Table.Name = "repositoryItemComboBox_Table"
            Me.repositoryItemComboBox_Table.Sorted = True
            Me.repositoryItemComboBox_Table.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Field1
            '
            Me.BarEditItem_Field1.Caption = "Field 1"
            Me.BarEditItem_Field1.Edit = Me.repositoryItemComboBox_Field1
            Me.BarEditItem_Field1.EditWidth = 100
            Me.BarEditItem_Field1.Id = 11
            Me.BarEditItem_Field1.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Field1.ImageOptions.Image"), System.Drawing.Image)
            Me.BarEditItem_Field1.ImageOptions.ImageIndex = 4
            Me.BarEditItem_Field1.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Field1.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.BarEditItem_Field1.ImageOptions.LargeImageIndex = 4
            Me.BarEditItem_Field1.Name = "BarEditItem_Field1"
            '
            'repositoryItemComboBox_Field1
            '
            Me.repositoryItemComboBox_Field1.AutoHeight = False
            Me.repositoryItemComboBox_Field1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox_Field1.Name = "repositoryItemComboBox_Field1"
            '
            'BarEditItem_Field2
            '
            Me.BarEditItem_Field2.Caption = "Field 2"
            Me.BarEditItem_Field2.Edit = Me.RepositoryItemComboBox_Field2
            Me.BarEditItem_Field2.EditWidth = 100
            Me.BarEditItem_Field2.Id = 24
            Me.BarEditItem_Field2.Name = "BarEditItem_Field2"
            '
            'RepositoryItemComboBox_Field2
            '
            Me.RepositoryItemComboBox_Field2.AutoHeight = False
            Me.RepositoryItemComboBox_Field2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Field2.Name = "RepositoryItemComboBox_Field2"
            '
            'btn_Generate
            '
            Me.btn_Generate.Caption = "&Generate"
            Me.btn_Generate.Id = 17
            Me.btn_Generate.ImageOptions.ImageIndex = 7
            Me.btn_Generate.ImageOptions.LargeImageIndex = 7
            Me.btn_Generate.Name = "btn_Generate"
            '
            'barCheckItem_SQL_Command
            '
            Me.barCheckItem_SQL_Command.Caption = "S&QL Command"
            Me.barCheckItem_SQL_Command.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.barCheckItem_SQL_Command.Id = 18
            Me.barCheckItem_SQL_Command.ImageOptions.ImageIndex = 6
            Me.barCheckItem_SQL_Command.Name = "barCheckItem_SQL_Command"
            '
            'btn_Execute
            '
            Me.btn_Execute.Caption = "Execu&te"
            Me.btn_Execute.Id = 12
            Me.btn_Execute.ImageOptions.ImageIndex = 5
            Me.btn_Execute.ImageOptions.LargeImageIndex = 5
            Me.btn_Execute.Name = "btn_Execute"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 22
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar_Custom
            '
            Me.Bar_Custom.BarName = "Custom"
            Me.Bar_Custom.DockCol = 1
            Me.Bar_Custom.DockRow = 1
            Me.Bar_Custom.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Custom.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Custom)})
            Me.Bar_Custom.Text = "Custom"
            '
            'btn_Custom
            '
            Me.btn_Custom.Caption = "Custom1"
            Me.btn_Custom.Id = 23
            Me.btn_Custom.Name = "btn_Custom"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(725, 41)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 479)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(725, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(725, 41)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel_Custom_Queries})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'hideContainerRight
            '
            Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerRight.Controls.Add(Me.dockPanel1)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(704, 41)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(21, 438)
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel1.ID = New System.Guid("8ef16e86-26c4-4622-8006-e329195b9db3")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel1.SavedIndex = 0
            Me.dockPanel1.Size = New System.Drawing.Size(200, 357)
            Me.dockPanel1.Text = "Options"
            Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.panelControl1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 30)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(193, 324)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.check_Initialize)
            Me.panelControl1.Controls.Add(Me.check_Reload)
            Me.panelControl1.Controls.Add(Me.check_Select_Show)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(193, 324)
            Me.panelControl1.TabIndex = 0
            '
            'check_Initialize
            '
            Me.check_Initialize.Location = New System.Drawing.Point(5, 5)
            Me.check_Initialize.Name = "check_Initialize"
            Me.check_Initialize.Properties.AutoWidth = True
            Me.check_Initialize.Properties.Caption = "Auto Initialize"
            Me.check_Initialize.Size = New System.Drawing.Size(88, 20)
            Me.check_Initialize.TabIndex = 3
            '
            'check_Reload
            '
            Me.check_Reload.Location = New System.Drawing.Point(5, 31)
            Me.check_Reload.Name = "check_Reload"
            Me.check_Reload.Properties.AutoWidth = True
            Me.check_Reload.Properties.Caption = "Auto Reload"
            Me.check_Reload.Size = New System.Drawing.Size(82, 20)
            Me.check_Reload.TabIndex = 4
            '
            'check_Select_Show
            '
            Me.check_Select_Show.Location = New System.Drawing.Point(5, 57)
            Me.check_Select_Show.Name = "check_Select_Show"
            Me.check_Select_Show.Properties.AutoWidth = True
            Me.check_Select_Show.Properties.Caption = "Show on select"
            Me.check_Select_Show.Size = New System.Drawing.Size(95, 20)
            Me.check_Select_Show.TabIndex = 5
            '
            'DockPanel_Custom_Queries
            '
            Me.DockPanel_Custom_Queries.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel_Custom_Queries.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.DockPanel_Custom_Queries.ID = New System.Guid("72da41a6-7e24-42d4-be7b-3359c1fe8796")
            Me.DockPanel_Custom_Queries.Location = New System.Drawing.Point(0, 279)
            Me.DockPanel_Custom_Queries.Name = "DockPanel_Custom_Queries"
            Me.DockPanel_Custom_Queries.Options.ShowCloseButton = False
            Me.DockPanel_Custom_Queries.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel_Custom_Queries.Size = New System.Drawing.Size(704, 200)
            Me.DockPanel_Custom_Queries.Text = "Custom Queries"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.PanelControl2)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(698, 170)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'PanelControl2
            '
            Me.PanelControl2.Controls.Add(Me.gridControl_Queries)
            Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl2.Name = "PanelControl2"
            Me.PanelControl2.Size = New System.Drawing.Size(698, 170)
            Me.PanelControl2.TabIndex = 0
            '
            'gridControl_Queries
            '
            Me.gridControl_Queries.DataMember = "acc_Custom_Queries"
            Me.gridControl_Queries.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_Queries.Location = New System.Drawing.Point(2, 2)
            Me.gridControl_Queries.MainView = Me.gridView_Queries
            Me.gridControl_Queries.Name = "gridControl_Queries"
            Me.gridControl_Queries.Size = New System.Drawing.Size(694, 166)
            Me.gridControl_Queries.TabIndex = 2
            Me.gridControl_Queries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_Queries})
            '
            'gridView_Queries
            '
            Me.gridView_Queries.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colQuery_Type, Me.colCustom_Query, Me.colQuery_Desciption})
            Me.gridView_Queries.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridView_Queries.gridControl = Me.gridControl_Queries
            Me.gridView_Queries.Name = "gridView_Queries"
            Me.gridView_Queries.OptionsBehavior.AllowIncrementalSearch = True
            Me.gridView_Queries.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView_Queries.OptionsBehavior.Editable = False
            Me.gridView_Queries.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.gridView_Queries.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView_Queries.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.gridView_Queries.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
            Me.gridView_Queries.OptionsView.ColumnAutoWidth = False
            Me.gridView_Queries.OptionsView.ShowFooter = True
            Me.gridView_Queries.OptionsView.ShowGroupedColumns = True
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colQuery_Type
            '
            Me.colQuery_Type.Caption = "Type"
            Me.colQuery_Type.FieldName = "Query_Type"
            Me.colQuery_Type.Name = "colQuery_Type"
            Me.colQuery_Type.Visible = True
            Me.colQuery_Type.VisibleIndex = 1
            '
            'colCustom_Query
            '
            Me.colCustom_Query.Caption = "Query"
            Me.colCustom_Query.FieldName = "Custom_Query"
            Me.colCustom_Query.Name = "colCustom_Query"
            Me.colCustom_Query.Visible = True
            Me.colCustom_Query.VisibleIndex = 2
            '
            'colQuery_Desciption
            '
            Me.colQuery_Desciption.Caption = "Description"
            Me.colQuery_Desciption.FieldName = "Query_Desciption"
            Me.colQuery_Desciption.Name = "colQuery_Desciption"
            Me.colQuery_Desciption.Visible = True
            Me.colQuery_Desciption.VisibleIndex = 3
            '
            'repositoryItemcheckEdit_Check_SQL_Command
            '
            Me.repositoryItemcheckEdit_Check_SQL_Command.AutoHeight = False
            Me.repositoryItemcheckEdit_Check_SQL_Command.Name = "repositoryItemcheckEdit_Check_SQL_Command"
            '
            'repositoryItemTextEdit_Data_Old
            '
            Me.repositoryItemTextEdit_Data_Old.AutoHeight = False
            Me.repositoryItemTextEdit_Data_Old.Name = "repositoryItemTextEdit_Data_Old"
            '
            'repositoryItemTextEdit_Data_New
            '
            Me.repositoryItemTextEdit_Data_New.AutoHeight = False
            Me.repositoryItemTextEdit_Data_New.Name = "repositoryItemTextEdit_Data_New"
            '
            'splitContainerControl
            '
            Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl.Horizontal = False
            Me.splitContainerControl.Location = New System.Drawing.Point(0, 41)
            Me.splitContainerControl.Name = "splitContainerControl"
            '
            'splitContainerControl.Panel1
            '
            Me.splitContainerControl.Panel1.Controls.Add(Me.queryString)
            Me.splitContainerControl.Panel1.Text = "Panel1"
            '
            'splitContainerControl.Panel2
            '
            Me.splitContainerControl.Panel2.Controls.Add(Me.gridControl)
            Me.splitContainerControl.Panel2.Text = "Panel2"
            Me.splitContainerControl.Size = New System.Drawing.Size(704, 238)
            Me.splitContainerControl.SplitterPosition = 47
            Me.splitContainerControl.TabIndex = 6
            Me.splitContainerControl.Text = "splitContainerControl"
            '
            'queryString
            '
            Me.queryString.Dock = System.Windows.Forms.DockStyle.Fill
            Me.queryString.Location = New System.Drawing.Point(0, 0)
            Me.queryString.MenuManager = Me.barManager
            Me.queryString.Name = "queryString"
            Me.queryString.Size = New System.Drawing.Size(704, 47)
            Me.queryString.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(704, 181)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'frm_Custom_Query
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(725, 479)
            Me.Controls.Add(Me.splitContainerControl)
            Me.Controls.Add(Me.DockPanel_Custom_Queries)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.KeyPreview = True
            Me.Name = "frm_Custom_Query"
            Me.Text = "Database Custom Query"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Query_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox_Table, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox_Field1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Field2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Select_Show.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel_Custom_Queries.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl2.ResumeLayout(False)
            CType(Me.gridControl_Queries, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_Queries, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemcheckEdit_Check_SQL_Command, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit_Data_Old, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit_Data_New, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl.Panel2.ResumeLayout(False)
            CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl.ResumeLayout(False)
            CType(Me.queryString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Private bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
        Private check_Initialize As DevExpress.XtraEditors.CheckEdit
        Private check_Reload As DevExpress.XtraEditors.CheckEdit
        Private check_Select_Show As DevExpress.XtraEditors.CheckEdit
        Private splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents queryString As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents BarEditItem_Table As DevExpress.XtraBars.BarEditItem
        Private repositoryItemComboBox_Table As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private BarEditItem_Field1 As DevExpress.XtraBars.BarEditItem
        Private repositoryItemComboBox_Field1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Execute As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private repositoryItemcheckEdit_Check_SQL_Command As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Private repositoryItemTextEdit_Data_Old As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit_Data_New As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
        Private barCheckItem_SQL_Command As DevExpress.XtraBars.BarCheckItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents DockPanel_Custom_Queries As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents gridControl_Queries As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_Queries As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents BarEditItem_Query_Type As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Query_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustom_Query As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuery_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colQuery_Desciption As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Custom As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Custom As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Field2 As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Field2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    End Class
End Namespace