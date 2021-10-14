Namespace Forms.Operations
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Aging
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
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_AE = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_AE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Status = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Status = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Date = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.BarEditItem_60_Days = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_60_Days = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_AE, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Status, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Date, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_60_Days, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
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
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_Preview, Me.btn_Initialize, Me.barEditItem_Branch, Me.BarEditItem_AE, Me.BarEditItem_Corporation, Me.BarEditItem_Status, Me.BarEditItem_Date, Me.BarEditItem_60_Days})
            Me.barManager.MaxItemId = 16
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_AE, Me.RepositoryItemLookUpEdit_Corporation, Me.RepositoryItemComboBox_Status, Me.RepositoryItemDateEdit_Date, Me.RepositoryItemComboBox_60_Days})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 1
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(306, 170)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 61
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
            Me.bar2.FloatLocation = New System.Drawing.Point(333, 191)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_AE), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Status), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_60_Days)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Corporation
            '
            Me.BarEditItem_Corporation.Caption = "Corporation"
            Me.BarEditItem_Corporation.Edit = Me.RepositoryItemLookUpEdit_Corporation
            Me.BarEditItem_Corporation.Id = 12
            Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Caption = "BarEditItem1"
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 10
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_AE
            '
            Me.BarEditItem_AE.Caption = "Area"
            Me.BarEditItem_AE.Edit = Me.RepositoryItemLookUpEdit_AE
            Me.BarEditItem_AE.Id = 11
            Me.BarEditItem_AE.Name = "BarEditItem_AE"
            '
            'RepositoryItemLookUpEdit_AE
            '
            Me.RepositoryItemLookUpEdit_AE.AutoHeight = False
            Me.RepositoryItemLookUpEdit_AE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_AE.Name = "RepositoryItemLookUpEdit_AE"
            '
            'BarEditItem_Status
            '
            Me.BarEditItem_Status.Caption = "Status"
            Me.BarEditItem_Status.Edit = Me.RepositoryItemComboBox_Status
            Me.BarEditItem_Status.EditWidth = 100
            Me.BarEditItem_Status.Id = 13
            Me.BarEditItem_Status.Name = "BarEditItem_Status"
            '
            'RepositoryItemComboBox_Status
            '
            Me.RepositoryItemComboBox_Status.AutoHeight = False
            Me.RepositoryItemComboBox_Status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Status.Items.AddRange(New Object() {"Current", "DEP", "Overdue"})
            Me.RepositoryItemComboBox_Status.Name = "RepositoryItemComboBox_Status"
            Me.RepositoryItemComboBox_Status.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Date
            '
            Me.BarEditItem_Date.Caption = "Date"
            Me.BarEditItem_Date.Edit = Me.RepositoryItemDateEdit_Date
            Me.BarEditItem_Date.EditWidth = 100
            Me.BarEditItem_Date.Id = 14
            Me.BarEditItem_Date.Name = "BarEditItem_Date"
            '
            'RepositoryItemDateEdit_Date
            '
            Me.RepositoryItemDateEdit_Date.AutoHeight = False
            Me.RepositoryItemDateEdit_Date.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Date.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Date.Name = "RepositoryItemDateEdit_Date"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'BarEditItem_60_Days
            '
            Me.BarEditItem_60_Days.Caption = "60 Days"
            Me.BarEditItem_60_Days.Edit = Me.RepositoryItemComboBox_60_Days
            Me.BarEditItem_60_Days.Id = 15
            Me.BarEditItem_60_Days.Name = "BarEditItem_60_Days"
            '
            'RepositoryItemComboBox_60_Days
            '
            Me.RepositoryItemComboBox_60_Days.AutoHeight = False
            Me.RepositoryItemComboBox_60_Days.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_60_Days.Items.AddRange(New Object() {">", "<"})
            Me.RepositoryItemComboBox_60_Days.Name = "RepositoryItemComboBox_60_Days"
            Me.RepositoryItemComboBox_60_Days.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(798, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(798, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 448)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(798, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 448)
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 20)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 448)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("b9f4ded7-d431-4100-b665-db417d11fbdd")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(200, 448)
            Me.DockPanel1.Text = "Information"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 419)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("8f50d8b8-2a5c-4269-97f2-dcccf3d77dbe")
            Me.DockPanel2.Location = New System.Drawing.Point(598, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 448)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 419)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(193, 419)
            Me.xuc_Settings.TabIndex = 0
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(21, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(577, 448)
            Me.gridControl.TabIndex = 7
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'frm_Aging
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(798, 468)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Aging"
            Me.Text = "frm_Aging"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_AE, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Status, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Date, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_60_Days, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents BarEditItem_AE As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_AE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents BarEditItem_Status As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Status As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents BarEditItem_Date As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Date As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_60_Days As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_60_Days As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    End Class
End Namespace