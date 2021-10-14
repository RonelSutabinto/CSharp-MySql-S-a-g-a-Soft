<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_iREP_Units
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
        Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Import = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
        Me.Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
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
        Me.Xuc_iREP_Units = New SagaInventory.xuc_iREP_Units()
        Me.GridList = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VATAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BrCodeAcct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LedgerSet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpecificNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Principal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Interest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OutstandingBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrevID = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Import, Me.btn_Approval, Me.Branch, Me.btn_Close, Me.btn_Initialize})
        Me.BarManager.MaxItemId = 5
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch})
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Import), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.Branch, "", False, True, True, 201), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar1.Text = "Tools"
        '
        'btn_Initialize
        '
        Me.btn_Initialize.Caption = "Initialize"
        Me.btn_Initialize.Id = 4
        Me.btn_Initialize.Name = "btn_Initialize"
        '
        'btn_Import
        '
        Me.btn_Import.Caption = "Import"
        Me.btn_Import.Id = 0
        Me.btn_Import.Name = "btn_Import"
        '
        'btn_Approval
        '
        Me.btn_Approval.Caption = "Send"
        Me.btn_Approval.Id = 1
        Me.btn_Approval.Name = "btn_Approval"
        '
        'Branch
        '
        Me.Branch.Caption = "Branch"
        Me.Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
        Me.Branch.Id = 2
        Me.Branch.Name = "Branch"
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 3
        Me.btn_Close.Name = "btn_Close"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(686, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 367)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(686, 20)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 347)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(686, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 347)
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
        Me.hideContainerRight.Location = New System.Drawing.Point(665, 20)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(21, 347)
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("8680d1ab-4fd6-42cc-9413-f13762dc8ec9")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.Size = New System.Drawing.Size(200, 347)
        Me.DockPanel2.Text = "Settings"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 318)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(270, 318)
        Me.Xuc_Settings.TabIndex = 0
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("bc2c6164-b0c1-4956-b075-469cdd2425e5")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(256, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(256, 347)
        Me.DockPanel1.Text = "Informations"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_iREP_Units)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(249, 318)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_iREP_Units
        '
        Me.Xuc_iREP_Units.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_iREP_Units.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_iREP_Units.Name = "Xuc_iREP_Units"
        Me.Xuc_iREP_Units.Size = New System.Drawing.Size(249, 318)
        Me.Xuc_iREP_Units.TabIndex = 0
        '
        'GridList
        '
        Me.GridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GridList.Location = New System.Drawing.Point(256, 20)
        Me.GridList.MainView = Me.gridView
        Me.GridList.Name = "GridList"
        Me.GridList.Size = New System.Drawing.Size(409, 347)
        Me.GridList.TabIndex = 100
        Me.GridList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Code, Me.Model, Me.Description, Me.Color, Me.Brand, Me.EngineNo, Me.ChassisNo, Me.KeyNo, Me.UnitCost, Me.VATAmt, Me.TotalCost, Me.UnitPrice, Me.AccountName, Me.BrCodeAcct, Me.AccountNumber, Me.LedgerSet, Me.SpecificNotes, Me.Principal, Me.Interest, Me.OutstandingBal, Me.DP, Me.PMT, Me.PrevID})
        Me.gridView.GridControl = Me.GridList
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gridView.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridView.OptionsMenu.ShowFooterItem = True
        Me.gridView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.gridView.OptionsView.ColumnAutoWidth = False
        Me.gridView.OptionsView.ShowFooter = True
        '
        'Code
        '
        Me.Code.Caption = "Code"
        Me.Code.FieldName = "Code"
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 1
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 2
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.FieldName = "Color"
        Me.Color.Name = "Color"
        Me.Color.Visible = True
        Me.Color.VisibleIndex = 3
        '
        'Brand
        '
        Me.Brand.Caption = "Brand"
        Me.Brand.FieldName = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 4
        '
        'EngineNo
        '
        Me.EngineNo.Caption = "EngineNo"
        Me.EngineNo.FieldName = "EngineNo"
        Me.EngineNo.Name = "EngineNo"
        Me.EngineNo.Visible = True
        Me.EngineNo.VisibleIndex = 5
        '
        'ChassisNo
        '
        Me.ChassisNo.Caption = "ChassisNo"
        Me.ChassisNo.FieldName = "ChassisNo"
        Me.ChassisNo.Name = "ChassisNo"
        Me.ChassisNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ChassisNo", "{0}")})
        Me.ChassisNo.Visible = True
        Me.ChassisNo.VisibleIndex = 6
        '
        'KeyNo
        '
        Me.KeyNo.Caption = "KeyNo"
        Me.KeyNo.FieldName = "KeyNo"
        Me.KeyNo.Name = "KeyNo"
        Me.KeyNo.Visible = True
        Me.KeyNo.VisibleIndex = 7
        '
        'UnitCost
        '
        Me.UnitCost.Caption = "UnitCost"
        Me.UnitCost.FieldName = "UnitCost"
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:0.##}")})
        Me.UnitCost.Visible = True
        Me.UnitCost.VisibleIndex = 8
        '
        'VATAmt
        '
        Me.VATAmt.Caption = "VATAmt"
        Me.VATAmt.FieldName = "VATAmt"
        Me.VATAmt.Name = "VATAmt"
        Me.VATAmt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VATAmt", "{0:0.##}")})
        Me.VATAmt.Visible = True
        Me.VATAmt.VisibleIndex = 9
        '
        'TotalCost
        '
        Me.TotalCost.Caption = "TotalCost"
        Me.TotalCost.FieldName = "TotalCost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:0.##}")})
        Me.TotalCost.Visible = True
        Me.TotalCost.VisibleIndex = 10
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "UnitPrice"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:0.##}")})
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 11
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 12
        '
        'BrCodeAcct
        '
        Me.BrCodeAcct.Caption = "BrCodeAcct"
        Me.BrCodeAcct.FieldName = "BrCodeAcct"
        Me.BrCodeAcct.Name = "BrCodeAcct"
        Me.BrCodeAcct.Visible = True
        Me.BrCodeAcct.VisibleIndex = 13
        '
        'AccountNumber
        '
        Me.AccountNumber.Caption = "AccountNumber"
        Me.AccountNumber.FieldName = "AccountNumber"
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 14
        '
        'LedgerSet
        '
        Me.LedgerSet.Caption = "LedgerSet"
        Me.LedgerSet.FieldName = "LedgerSet"
        Me.LedgerSet.Name = "LedgerSet"
        Me.LedgerSet.Visible = True
        Me.LedgerSet.VisibleIndex = 15
        '
        'SpecificNotes
        '
        Me.SpecificNotes.Caption = "SpecificNotes"
        Me.SpecificNotes.FieldName = "SpecificNotes"
        Me.SpecificNotes.Name = "SpecificNotes"
        Me.SpecificNotes.Visible = True
        Me.SpecificNotes.VisibleIndex = 16
        '
        'Principal
        '
        Me.Principal.Caption = "Principal"
        Me.Principal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Principal.FieldName = "Principal"
        Me.Principal.Name = "Principal"
        Me.Principal.Visible = True
        Me.Principal.VisibleIndex = 17
        '
        'Interest
        '
        Me.Interest.Caption = "Interest"
        Me.Interest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Interest.FieldName = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.Visible = True
        Me.Interest.VisibleIndex = 18
        '
        'OutstandingBal
        '
        Me.OutstandingBal.Caption = "OutstandingBal"
        Me.OutstandingBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OutstandingBal.FieldName = "OutstandingBal"
        Me.OutstandingBal.Name = "OutstandingBal"
        Me.OutstandingBal.Visible = True
        Me.OutstandingBal.VisibleIndex = 19
        '
        'DP
        '
        Me.DP.Caption = "DP"
        Me.DP.FieldName = "DP"
        Me.DP.Name = "DP"
        Me.DP.Visible = True
        Me.DP.VisibleIndex = 20
        '
        'PMT
        '
        Me.PMT.Caption = "M/A"
        Me.PMT.FieldName = "PMT"
        Me.PMT.Name = "PMT"
        Me.PMT.Visible = True
        Me.PMT.VisibleIndex = 21
        '
        'PrevID
        '
        Me.PrevID.Caption = "PrevID"
        Me.PrevID.FieldName = "PrevID"
        Me.PrevID.Name = "PrevID"
        Me.PrevID.Visible = True
        Me.PrevID.VisibleIndex = 22
        '
        'frm_iREP_Units
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 387)
        Me.Controls.Add(Me.GridList)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_iREP_Units"
        Me.Text = "frm_iREP_Units"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents xuc_iREP_Units As xuc_iREP_Units
    Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents GridList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EngineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChassisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VATAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BrCodeAcct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedgerSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecificNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Principal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Interest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OutstandingBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrevID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Import As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
End Class
