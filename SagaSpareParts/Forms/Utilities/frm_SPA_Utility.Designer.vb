<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SPA_Utility
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
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Utility = New xuc_Utility()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiving_Branch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSPCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBinBox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassification = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_New, Me.btn_Save, Me.btn_Reload, Me.btn_Delete, Me.btn_Close, Me.BarEditItem_Branch, Me.BarEditItem_Search, Me.btn_Preview})
        Me.BarManager.MaxItemId = 8
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 1
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar1.Offset = 193
        Me.Bar1.Text = "Tools"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 0
        Me.btn_New.Name = "btn_New"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 1
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Id = 2
        Me.btn_Reload.Name = "btn_Reload"
        '
        'btn_Delete
        '
        Me.btn_Delete.Caption = "Delete"
        Me.btn_Delete.Id = 3
        Me.btn_Delete.Name = "btn_Delete"
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 7
        Me.btn_Preview.Name = "btn_Preview"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 4
        Me.btn_Close.Name = "btn_Close"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Branch, "", False, True, True, 141)})
        Me.Bar2.Text = "Custom 3"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Caption = "Branch"
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
        Me.BarEditItem_Branch.Id = 5
        Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.DockCol = 2
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Search, "", False, True, True, 162)})
        Me.Bar3.Offset = 434
        Me.Bar3.Text = "Custom 4"
        '
        'BarEditItem_Search
        '
        Me.BarEditItem_Search.Caption = "BarEditItem1"
        Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
        Me.BarEditItem_Search.Id = 6
        Me.BarEditItem_Search.Name = "BarEditItem_Search"
        '
        'RepositoryItemSearchControl_Search
        '
        Me.RepositoryItemSearchControl_Search.AutoHeight = False
        Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(806, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 434)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(806, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 414)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(806, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 414)
        '
        'DockManager
        '
        Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.DockPanel2)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(785, 20)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(21, 414)
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("12b6d1fe-b9e9-4c0f-b43d-3fd0bf95ae22")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(241, 200)
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.Size = New System.Drawing.Size(241, 414)
        Me.DockPanel2.Text = "Settings"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(234, 385)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(270, 385)
        Me.Xuc_Settings.TabIndex = 0
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("23fe184f-e77c-4c07-ae1b-9a8e63cd3cd2")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(298, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(298, 414)
        Me.DockPanel1.Text = "Informations"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_Utility)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(291, 385)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_Utility
        '
        Me.Xuc_Utility.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Utility.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Utility.Name = "Xuc_Utility"
        Me.Xuc_Utility.Size = New System.Drawing.Size(291, 385)
        Me.Xuc_Utility.TabIndex = 0
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(298, 20)
        Me.GridControl.MainView = Me.gridView
        Me.GridControl.MenuManager = Me.BarManager
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(487, 414)
        Me.GridControl.TabIndex = 6
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBranchCode, Me.colPartsNumber, Me.colPartsName, Me.colPONo, Me.colBrand, Me.colBranch_Code, Me.colReceiving_Branch, Me.colCategory, Me.colSRP, Me.colQuantity, Me.colSPCostWOVAT, Me.colTotalCostWOVAT, Me.colBinBox, Me.colClassification})
        Me.gridView.GridControl = Me.GridControl
        Me.gridView.Name = "gridView"
        '
        'colID
        '
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colBranchCode
        '
        Me.colBranchCode.Caption = "BranchCode"
        Me.colBranchCode.FieldName = "ReceivingBranch"
        Me.colBranchCode.Name = "colBranchCode"
        Me.colBranchCode.Visible = True
        Me.colBranchCode.VisibleIndex = 1
        '
        'colPartsNumber
        '
        Me.colPartsNumber.FieldName = "PartsNumber"
        Me.colPartsNumber.Name = "colPartsNumber"
        Me.colPartsNumber.Visible = True
        Me.colPartsNumber.VisibleIndex = 2
        '
        'colPartsName
        '
        Me.colPartsName.FieldName = "PartsName"
        Me.colPartsName.Name = "colPartsName"
        Me.colPartsName.Visible = True
        Me.colPartsName.VisibleIndex = 3
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 5
        '
        'colBranch_Code
        '
        Me.colBranch_Code.FieldName = "BranchCode"
        Me.colBranch_Code.Name = "colBranch_Code"
        Me.colBranch_Code.Visible = True
        Me.colBranch_Code.VisibleIndex = 6
        '
        'colReceiving_Branch
        '
        Me.colReceiving_Branch.FieldName = "ReceivingBranch"
        Me.colReceiving_Branch.Name = "colReceiving_Branch"
        Me.colReceiving_Branch.Visible = True
        Me.colReceiving_Branch.VisibleIndex = 7
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 8
        '
        'colSRP
        '
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 9
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 10
        '
        'colSPCostWOVAT
        '
        Me.colSPCostWOVAT.FieldName = "SPCostWOVAT"
        Me.colSPCostWOVAT.Name = "colSPCostWOVAT"
        Me.colSPCostWOVAT.Visible = True
        Me.colSPCostWOVAT.VisibleIndex = 11
        '
        'colTotalCostWOVAT
        '
        Me.colTotalCostWOVAT.FieldName = "TotalCostWOVAT"
        Me.colTotalCostWOVAT.Name = "colTotalCostWOVAT"
        Me.colTotalCostWOVAT.Visible = True
        Me.colTotalCostWOVAT.VisibleIndex = 12
        '
        'colBinBox
        '
        Me.colBinBox.FieldName = "BinBox"
        Me.colBinBox.Name = "colBinBox"
        Me.colBinBox.Visible = True
        Me.colBinBox.VisibleIndex = 13
        '
        'colClassification
        '
        Me.colClassification.FieldName = "SPA_Classification"
        Me.colClassification.Name = "colClassification"
        Me.colClassification.Visible = True
        Me.colClassification.VisibleIndex = 14
        '
        'colPONo
        '
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.Name = "colPONo"
        Me.colPONo.Visible = True
        Me.colPONo.VisibleIndex = 4
        '
        'frm_SPA_Utility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 434)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_SPA_Utility"
        Me.Text = "frm_SPA_Utility"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBinBox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xuc_Utility As xuc_Utility
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiving_Branch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents colClassification As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
End Class
