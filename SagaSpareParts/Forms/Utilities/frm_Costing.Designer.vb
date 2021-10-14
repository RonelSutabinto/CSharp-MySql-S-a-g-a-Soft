<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Costing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Costing))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Honda = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Yamaha = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Kawasaki = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Suzuki = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_SearchParts = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_SearchParts = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSPCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSPCostWVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalLess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalDiscountAMT = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_SearchParts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Save, Me.btn_Preview, Me.btn_Close, Me.btn_Honda, Me.btn_Yamaha, Me.btn_Kawasaki, Me.btn_Suzuki, Me.BarEditItem_SearchParts})
        Me.BarManager.MaxItemId = 9
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_SearchParts})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar1.Text = "Tools"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 1
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Preview
        '
        Me.btn_Preview.ActAsDropDown = True
        Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Preview.Caption = "SPA Costing Report"
        Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
        Me.btn_Preview.Id = 2
        Me.btn_Preview.Name = "btn_Preview"
        '
        'PopupMenu_Preview
        '
        Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Honda), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Yamaha), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Kawasaki), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Suzuki)})
        Me.PopupMenu_Preview.Manager = Me.BarManager
        Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
        '
        'btn_Honda
        '
        Me.btn_Honda.Caption = "SPA Costing Report - HONDA"
        Me.btn_Honda.Id = 4
        Me.btn_Honda.ImageOptions.Image = CType(resources.GetObject("btn_Honda.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Honda.ImageOptions.LargeImage = CType(resources.GetObject("btn_Honda.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Honda.Name = "btn_Honda"
        '
        'btn_Yamaha
        '
        Me.btn_Yamaha.Caption = "SPA Costing Report - YAMAHA"
        Me.btn_Yamaha.Id = 5
        Me.btn_Yamaha.ImageOptions.Image = CType(resources.GetObject("btn_Yamaha.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Yamaha.ImageOptions.LargeImage = CType(resources.GetObject("btn_Yamaha.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Yamaha.Name = "btn_Yamaha"
        '
        'btn_Kawasaki
        '
        Me.btn_Kawasaki.Caption = "SPA Costing Report - KAWASAKI"
        Me.btn_Kawasaki.Id = 6
        Me.btn_Kawasaki.ImageOptions.Image = CType(resources.GetObject("btn_Kawasaki.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Kawasaki.ImageOptions.LargeImage = CType(resources.GetObject("btn_Kawasaki.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Kawasaki.Name = "btn_Kawasaki"
        '
        'btn_Suzuki
        '
        Me.btn_Suzuki.Caption = "SPA Costing Report - SUZUKI"
        Me.btn_Suzuki.Id = 7
        Me.btn_Suzuki.ImageOptions.Image = CType(resources.GetObject("btn_Suzuki.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Suzuki.ImageOptions.LargeImage = CType(resources.GetObject("btn_Suzuki.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Suzuki.Name = "btn_Suzuki"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 3
        Me.btn_Close.Name = "btn_Close"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 1
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_SearchParts, "", False, True, True, 148)})
        Me.Bar2.Offset = 256
        Me.Bar2.Text = "Custom 3"
        '
        'BarEditItem_SearchParts
        '
        Me.BarEditItem_SearchParts.Caption = "Search Reference"
        Me.BarEditItem_SearchParts.Edit = Me.RepositoryItemSearchControl_SearchParts
        Me.BarEditItem_SearchParts.Hint = "SEARCH REFERENCE"
        Me.BarEditItem_SearchParts.Id = 8
        Me.BarEditItem_SearchParts.Name = "BarEditItem_SearchParts"
        '
        'RepositoryItemSearchControl_SearchParts
        '
        Me.RepositoryItemSearchControl_SearchParts.AutoHeight = False
        Me.RepositoryItemSearchControl_SearchParts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl_SearchParts.Name = "RepositoryItemSearchControl_SearchParts"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(740, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 401)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(740, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 381)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(740, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 381)
        '
        'DockManager
        '
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("d22ac12d-03cc-47a8-b4bd-52c059224a7c")
        Me.DockPanel2.Location = New System.Drawing.Point(540, 20)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(200, 381)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 352)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(270, 352)
        Me.Xuc_Settings.TabIndex = 0
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 20)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.BarManager
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(540, 381)
        Me.gridControl.TabIndex = 6
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPartsNumber, Me.colPartsName, Me.colBrand, Me.colCategory, Me.colQuantity, Me.colSRP, Me.colSPCostWOVAT, Me.colSPCostWVAT, Me.colReceivingBranch, Me.colSubTotal, Me.colTotalLess, Me.colGrandTotal, Me.colTotalCostWOVAT, Me.colTotalDiscountAMT})
        Me.gridView.gridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        '
        'colID
        '
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colPartsNumber
        '
        Me.colPartsNumber.FieldName = "PartsNumber"
        Me.colPartsNumber.Name = "colPartsNumber"
        Me.colPartsNumber.Visible = True
        Me.colPartsNumber.VisibleIndex = 1
        '
        'colPartsName
        '
        Me.colPartsName.FieldName = "PartsName"
        Me.colPartsName.Name = "colPartsName"
        Me.colPartsName.Visible = True
        Me.colPartsName.VisibleIndex = 2
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 3
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 4
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
        Me.colQuantity.FieldName = "Prev_Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 5
        '
        'colSRP
        '
        Me.colSRP.FieldName = "SRP"
        Me.colSRP.Name = "colSRP"
        Me.colSRP.Visible = True
        Me.colSRP.VisibleIndex = 6
        '
        'colSPCostWOVAT
        '
        Me.colSPCostWOVAT.FieldName = "SPCostWOVAT"
        Me.colSPCostWOVAT.Name = "colSPCostWOVAT"
        Me.colSPCostWOVAT.Visible = True
        Me.colSPCostWOVAT.VisibleIndex = 7
        '
        'colSPCostWVAT
        '
        Me.colSPCostWVAT.FieldName = "SPCostWVAT"
        Me.colSPCostWVAT.Name = "colSPCostWVAT"
        Me.colSPCostWVAT.Visible = True
        Me.colSPCostWVAT.VisibleIndex = 8
        '
        'colReceivingBranch
        '
        Me.colReceivingBranch.Caption = "Branch Code"
        Me.colReceivingBranch.FieldName = "ReceivingBranch"
        Me.colReceivingBranch.Name = "colReceivingBranch"
        Me.colReceivingBranch.Visible = True
        Me.colReceivingBranch.VisibleIndex = 9
        '
        'colSubTotal
        '
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 10
        '
        'colTotalLess
        '
        Me.colTotalLess.FieldName = "TotalLess"
        Me.colTotalLess.Name = "colTotalLess"
        Me.colTotalLess.Visible = True
        Me.colTotalLess.VisibleIndex = 11
        '
        'colGrandTotal
        '
        Me.colGrandTotal.FieldName = "GrandTotal"
        Me.colGrandTotal.Name = "colGrandTotal"
        Me.colGrandTotal.Visible = True
        Me.colGrandTotal.VisibleIndex = 12
        '
        'colTotalCostWOVAT
        '
        Me.colTotalCostWOVAT.FieldName = "TotalCostWOVAT"
        Me.colTotalCostWOVAT.Name = "colTotalCostWOVAT"
        Me.colTotalCostWOVAT.Visible = True
        Me.colTotalCostWOVAT.VisibleIndex = 13
        '
        'colTotalDiscountAMT
        '
        Me.colTotalDiscountAMT.FieldName = "TotalDiscountAMT"
        Me.colTotalDiscountAMT.Name = "colTotalDiscountAMT"
        Me.colTotalDiscountAMT.Visible = True
        Me.colTotalDiscountAMT.VisibleIndex = 14
        '
        'frm_Costing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 401)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_Costing"
        Me.Text = "frm_Costing"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_SearchParts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPCostWVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalLess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDiscountAMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Honda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Yamaha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Kawasaki As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Suzuki As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_SearchParts As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_SearchParts As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
End Class
