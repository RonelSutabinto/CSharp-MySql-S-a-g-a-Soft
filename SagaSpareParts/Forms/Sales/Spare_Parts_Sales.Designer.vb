<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Spare_Parts_Sales
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
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Post = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockDetails = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Spare_Parts_Details = New Xuc_Spare_Parts_Details()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Spare_Parts_Sales1 = New Xuc_Spare_Parts_Sales()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.RepositoryItemLookUpEdit_Parts_Number = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridList = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrossTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Discount_PCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiscountSRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrevID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartsName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerLeft.SuspendLayout()
        Me.DockDetails.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Post, Me.Btn_Preview, Me.Btn_Add})
        Me.BarManager.MaxItemId = 6
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1, Me.RepositoryItemLookUpEdit_Parts_Number})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(111, 137)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Add), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Post), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview)})
        Me.Bar1.Text = "Tools"
        '
        'Btn_Add
        '
        Me.Btn_Add.Caption = "Add"
        Me.Btn_Add.Id = 4
        Me.Btn_Add.Name = "Btn_Add"
        '
        'Btn_Post
        '
        Me.Btn_Post.Caption = "Post"
        Me.Btn_Post.Id = 0
        Me.Btn_Post.Name = "Btn_Post"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.Id = 1
        Me.Btn_Preview.Name = "Btn_Preview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(760, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 388)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(760, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 368)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(760, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 368)
        '
        'DockManager
        '
        Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hideContainerLeft.Controls.Add(Me.DockDetails)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 20)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(21, 368)
        '
        'DockDetails
        '
        Me.DockDetails.Controls.Add(Me.DockPanel2_Container)
        Me.DockDetails.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockDetails.ID = New System.Guid("21ddd89e-5eac-43eb-aaba-a15b5cbe0a4e")
        Me.DockDetails.Location = New System.Drawing.Point(0, 0)
        Me.DockDetails.Name = "DockDetails"
        Me.DockDetails.OriginalSize = New System.Drawing.Size(334, 200)
        Me.DockDetails.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockDetails.SavedIndex = 1
        Me.DockDetails.Size = New System.Drawing.Size(334, 368)
        Me.DockDetails.Text = "Details"
        Me.DockDetails.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Spare_Parts_Details)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(327, 339)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Spare_Parts_Details
        '
        Me.Xuc_Spare_Parts_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Spare_Parts_Details.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Spare_Parts_Details.Name = "Xuc_Spare_Parts_Details"
        Me.Xuc_Spare_Parts_Details.Size = New System.Drawing.Size(327, 339)
        Me.Xuc_Spare_Parts_Details.TabIndex = 0
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("994b4af0-9a9f-4a8c-802a-65a523d89a22")
        Me.DockPanel1.Location = New System.Drawing.Point(21, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(311, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(311, 368)
        Me.DockPanel1.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_Spare_Parts_Sales1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(304, 339)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_Spare_Parts_Sales1
        '
        Me.Xuc_Spare_Parts_Sales1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Spare_Parts_Sales1.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Spare_Parts_Sales1.Name = "Xuc_Spare_Parts_Sales1"
        Me.Xuc_Spare_Parts_Sales1.Size = New System.Drawing.Size(304, 339)
        Me.Xuc_Spare_Parts_Sales1.TabIndex = 0
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'RepositoryItemLookUpEdit_Parts_Number
        '
        Me.RepositoryItemLookUpEdit_Parts_Number.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Parts_Number.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Parts_Number.Name = "RepositoryItemLookUpEdit_Parts_Number"
        '
        'GridList
        '
        Me.GridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GridList.Location = New System.Drawing.Point(332, 20)
        Me.GridList.MainView = Me.GridView
        Me.GridList.Name = "GridList"
        Me.GridList.Size = New System.Drawing.Size(428, 368)
        Me.GridList.TabIndex = 100
        Me.GridList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.Quantity, Me.Unit, Me.Description, Me.UnitPrice, Me.GrossTotal, Me.Discount, Me.Discount_PCT, Me.DiscountSRP, Me.SubTotal, Me.PrevID, Me.PartsNumber, Me.PartsName})
        Me.GridView.GridControl = Me.GridList
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsMenu.ShowFooterItem = True
        Me.GridView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        '
        'BranchCode
        '
        Me.BranchCode.Caption = "Branch Code"
        Me.BranchCode.FieldName = "BranchCode"
        Me.BranchCode.Name = "BranchCode"
        Me.BranchCode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ChassisNo", "{0}")})
        Me.BranchCode.Visible = True
        Me.BranchCode.VisibleIndex = 0
        '
        'Quantity
        '
        Me.Quantity.Caption = "Quantity"
        Me.Quantity.FieldName = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Visible = True
        Me.Quantity.VisibleIndex = 1
        '
        'Unit
        '
        Me.Unit.Caption = "Unit"
        Me.Unit.FieldName = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.Visible = True
        Me.Unit.VisibleIndex = 2
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 3
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "Unit Price"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:0.##}")})
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 4
        '
        'GrossTotal
        '
        Me.GrossTotal.Caption = "Gross Total"
        Me.GrossTotal.FieldName = "GrossTotal"
        Me.GrossTotal.Name = "GrossTotal"
        Me.GrossTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:0.##}")})
        Me.GrossTotal.Visible = True
        Me.GrossTotal.VisibleIndex = 6
        '
        'Discount
        '
        Me.Discount.Caption = "Discount"
        Me.Discount.FieldName = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Discount", "{0:0.##}")})
        Me.Discount.Visible = True
        Me.Discount.VisibleIndex = 5
        '
        'Discount_PCT
        '
        Me.Discount_PCT.Caption = "Discount Percentage"
        Me.Discount_PCT.FieldName = "Discount_PCT"
        Me.Discount_PCT.Name = "Discount_PCT"
        Me.Discount_PCT.Visible = True
        Me.Discount_PCT.VisibleIndex = 8
        '
        'DiscountSRP
        '
        Me.DiscountSRP.Caption = "Discount SRP"
        Me.DiscountSRP.FieldName = "DiscountSRP"
        Me.DiscountSRP.Name = "DiscountSRP"
        Me.DiscountSRP.Visible = True
        Me.DiscountSRP.VisibleIndex = 9
        '
        'SubTotal
        '
        Me.SubTotal.Caption = "Sub Total"
        Me.SubTotal.FieldName = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:0.##}")})
        Me.SubTotal.Visible = True
        Me.SubTotal.VisibleIndex = 7
        '
        'PrevID
        '
        Me.PrevID.Caption = "PrevID"
        Me.PrevID.FieldName = "PrevID"
        Me.PrevID.Name = "PrevID"
        Me.PrevID.Visible = True
        Me.PrevID.VisibleIndex = 10
        '
        'PartsNumber
        '
        Me.PartsNumber.Caption = "PartsNumber"
        Me.PartsNumber.FieldName = "PartsNumber"
        Me.PartsNumber.Name = "PartsNumber"
        Me.PartsNumber.Visible = True
        Me.PartsNumber.VisibleIndex = 11
        '
        'PartsName
        '
        Me.PartsName.Caption = "PartsName"
        Me.PartsName.FieldName = "PartsName"
        Me.PartsName.Name = "PartsName"
        Me.PartsName.Visible = True
        Me.PartsName.VisibleIndex = 12
        '
        'Spare_Parts_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 388)
        Me.Controls.Add(Me.GridList)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Spare_Parts_Sales"
        Me.Text = "Spare Parts Sales"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerLeft.ResumeLayout(False)
        Me.DockDetails.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Parts_Number, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Btn_Post As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents RepositoryItemLookUpEdit_Parts_Number As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Xuc_Spare_Parts_Sales1 As Xuc_Spare_Parts_Sales
    Friend WithEvents GridList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrossTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Discount_PCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DiscountSRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrevID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockDetails As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Xuc_Spare_Parts_Details As Xuc_Spare_Parts_Details
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents Btn_Add As DevExpress.XtraBars.BarButtonItem
End Class
