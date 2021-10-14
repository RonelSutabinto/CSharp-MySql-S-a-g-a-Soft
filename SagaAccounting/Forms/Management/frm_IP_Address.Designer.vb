Partial Class frm_IP_Address
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.dockManager = New DevExpress.XtraBars.Docking.DockManager()
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.check_Initialize = New DevExpress.XtraEditors.CheckEdit()
        Me.barManager = New DevExpress.XtraBars.BarManager()
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.check_Load_All = New DevExpress.XtraEditors.CheckEdit()
        Me.check_Reload = New DevExpress.XtraEditors.CheckEdit()
        Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridColumnBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gridColumnIPAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumnPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xuc_IP_Access = New Controls.Management.xuc_IP_Access()
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.dockPanel2.SuspendLayout()
        Me.dockPanel2_Container.SuspendLayout()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanel1.SuspendLayout()
        Me.dockPanel1_Container.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()
        '
        'dockManager
        '
        Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.dockManager.Form = Me
        Me.dockManager.MenuManager = Me.barManager
        Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1})
        Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.dockPanel2)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(663, 29)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(20, 261)
        '
        'dockPanel2
        '
        Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
        Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockPanel2.ID = New System.Guid("c617c5a3-6cfb-4b2a-bb3f-8d731425f8c3")
        Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
        Me.dockPanel2.Name = "dockPanel2"
        Me.dockPanel2.Options.ShowCloseButton = False
        Me.dockPanel2.OriginalSize = New System.Drawing.Size(150, 200)
        Me.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockPanel2.SavedIndex = 1
        Me.dockPanel2.Size = New System.Drawing.Size(150, 233)
        Me.dockPanel2.Text = "Settings"
        Me.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'dockPanel2_Container
        '
        Me.dockPanel2_Container.Controls.Add(Me.panelControl1)
        Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 30)
        Me.dockPanel2_Container.Name = "dockPanel2_Container"
        Me.dockPanel2_Container.Size = New System.Drawing.Size(143, 200)
        Me.dockPanel2_Container.TabIndex = 0
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.check_Initialize)
        Me.panelControl1.Controls.Add(Me.check_Load_All)
        Me.panelControl1.Controls.Add(Me.check_Reload)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelControl1.Location = New System.Drawing.Point(0, 0)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(143, 200)
        Me.panelControl1.TabIndex = 3
        '
        'check_Initialize
        '
        Me.check_Initialize.Location = New System.Drawing.Point(5, 5)
        Me.check_Initialize.MenuManager = Me.barManager
        Me.check_Initialize.Name = "check_Initialize"
        Me.check_Initialize.Properties.AutoWidth = True
        Me.check_Initialize.Properties.Caption = "Auto Initialize"
        Me.check_Initialize.Size = New System.Drawing.Size(87, 19)
        Me.check_Initialize.TabIndex = 0
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
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview})
        Me.barManager.MaxItemId = 7
        Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.FloatLocation = New System.Drawing.Point(66, 143)
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.bar1.Text = "Tools"
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
        'btn_Initialize
        '
        Me.btn_Initialize.Caption = "Initialize"
        Me.btn_Initialize.Id = 5
        Me.btn_Initialize.ImageOptions.ImageIndex = 6
        Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
        Me.btn_Initialize.Name = "btn_Initialize"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(683, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 290)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(683, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 261)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(683, 29)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 261)
        '
        'check_Load_All
        '
        Me.check_Load_All.Location = New System.Drawing.Point(6, 31)
        Me.check_Load_All.MenuManager = Me.barManager
        Me.check_Load_All.Name = "check_Load_All"
        Me.check_Load_All.Properties.AutoWidth = True
        Me.check_Load_All.Properties.Caption = "Show all"
        Me.check_Load_All.Size = New System.Drawing.Size(61, 19)
        Me.check_Load_All.TabIndex = 1
        '
        'check_Reload
        '
        Me.check_Reload.Location = New System.Drawing.Point(6, 57)
        Me.check_Reload.MenuManager = Me.barManager
        Me.check_Reload.Name = "check_Reload"
        Me.check_Reload.Properties.AutoWidth = True
        Me.check_Reload.Properties.Caption = "Auto Reload"
        Me.check_Reload.Size = New System.Drawing.Size(81, 19)
        Me.check_Reload.TabIndex = 2
        '
        'dockPanel1
        '
        Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
        Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanel1.FloatSize = New System.Drawing.Size(250, 300)
        Me.dockPanel1.ID = New System.Guid("537b326f-385d-4e56-bc31-e47314c728d4")
        Me.dockPanel1.Location = New System.Drawing.Point(0, 29)
        Me.dockPanel1.Name = "dockPanel1"
        Me.dockPanel1.Options.ShowCloseButton = False
        Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 400)
        Me.dockPanel1.Size = New System.Drawing.Size(300, 261)
        Me.dockPanel1.Text = "IP Information"
        '
        'dockPanel1_Container
        '
        Me.dockPanel1_Container.Controls.Add(Me.xuc_IP_Access)
        Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.dockPanel1_Container.Name = "dockPanel1_Container"
        Me.dockPanel1_Container.Size = New System.Drawing.Size(291, 234)
        Me.dockPanel1_Container.TabIndex = 0
        '
        'xuc_IP_Access
        '
        Me.xuc_IP_Access.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_IP_Access.Location = New System.Drawing.Point(0, 0)
        Me.xuc_IP_Access.Name = "xuc_IP_Access"
        Me.xuc_IP_Access.Size = New System.Drawing.Size(291, 234)
        Me.xuc_IP_Access.TabIndex = 0
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(300, 29)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch})
        Me.gridControl.Size = New System.Drawing.Size(363, 261)
        Me.gridControl.TabIndex = 0
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumnBranchCode, Me.gridColumnIPAddress, Me.gridColumnPostingDate})
        Me.gridView.gridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsView.ColumnAutoWidth = False
        '
        'gridColumnBranchCode
        '
        Me.gridColumnBranchCode.Caption = "Branch"
        Me.gridColumnBranchCode.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
        Me.gridColumnBranchCode.FieldName = "BranchCode"
        Me.gridColumnBranchCode.Name = "gridColumnBranchCode"
        Me.gridColumnBranchCode.Visible = True
        Me.gridColumnBranchCode.VisibleIndex = 0
        '
        'repositoryItemLookUpEdit_Branch
        '
        Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
        '
        'gridColumnIPAddress
        '
        Me.gridColumnIPAddress.Caption = "IP Address"
        Me.gridColumnIPAddress.FieldName = "IPAddress"
        Me.gridColumnIPAddress.Name = "gridColumnIPAddress"
        Me.gridColumnIPAddress.Visible = True
        Me.gridColumnIPAddress.VisibleIndex = 1
        '
        'gridColumnPostingDate
        '
        Me.gridColumnPostingDate.Caption = "Added"
        Me.gridColumnPostingDate.FieldName = "PostingDate"
        Me.gridColumnPostingDate.Name = "gridColumnPostingDate"
        Me.gridColumnPostingDate.Visible = True
        Me.gridColumnPostingDate.VisibleIndex = 2
        '
        'frm_IP_Address
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 290)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.dockPanel1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_IP_Address"
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.Text = "IP Addresses List"
        CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.dockPanel2.ResumeLayout(False)
        Me.dockPanel2_Container.ResumeLayout(False)
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.check_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check_Load_All.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check_Reload.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanel1.ResumeLayout(False)
        Me.dockPanel1_Container.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private dockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barManager As DevExpress.XtraBars.BarManager
    Private bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Private xuc_IP_Access As Controls.Management.xuc_IP_Access
    Private gridColumnBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Private gridColumnIPAddress As DevExpress.XtraGrid.Columns.GridColumn
    Private gridColumnPostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Private check_Load_All As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
    Private check_Reload As DevExpress.XtraEditors.CheckEdit
    Private check_Initialize As DevExpress.XtraEditors.CheckEdit
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class

