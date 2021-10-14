using System.Diagnostics;

namespace SagaAssets.Forms
{
    public partial class frm_Assets : DevExpress.XtraEditors.XtraForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Assets));
			this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
			this.barEditItem_Search = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Preview = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenu_Preview = new DevExpress.XtraBars.PopupMenu(this.components);
			this.btn_Preview_Asset_Item = new DevExpress.XtraBars.BarButtonItem();
			this.btn_New = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.xuc_Asset = new SagaAssets.Controls.xuc_Asset();
			this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGroup_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Asset_Items = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colBranch_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSub_Category = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStorage_Location = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Condition = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMade_In = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Details = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVendor_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVendor_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPurchased_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice_Value = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWarranty_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrent_Value = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrent_Custodian = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Employees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colAsset_Type = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAsset_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSystem_Request_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPayment_Request_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanvas_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLiquiation_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransmittal_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdded_By = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdded_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModified_By = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModified_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl_Search)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).BeginInit();
			this.dockPanel1.SuspendLayout();
			this.dockPanel1_Container.SuspendLayout();
			this.dockPanel2.SuspendLayout();
			this.dockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Asset_Items)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Branch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Employees)).BeginInit();
			this.SuspendLayout();
			// 
			// dockManager
			// 
			this.dockManager.DockingOptions.ShowCloseButton = false;
			this.dockManager.Form = this;
			this.dockManager.MenuManager = this.barManager;
			this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel2});
			this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.DockManager = this.dockManager;
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Initialize,
            this.btn_Reload,
            this.btn_Preview,
            this.btn_Save,
            this.btn_Delete,
            this.btn_Close,
            this.btn_New,
            this.btn_Preview_Asset_Item,
            this.barEditItem_Search});
			this.barManager.MainMenu = this.bar2;
			this.barManager.MaxItemId = 9;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl_Search});
			this.barManager.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 1;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem_Search, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.bar1.Text = "Tools";
			// 
			// btn_Initialize
			// 
			this.btn_Initialize.Caption = "Intialize";
			this.btn_Initialize.Id = 0;
			this.btn_Initialize.Name = "btn_Initialize";
			this.btn_Initialize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Initialize_ItemClick);
			// 
			// barEditItem_Search
			// 
			this.barEditItem_Search.Caption = "barEditItem_Search";
			this.barEditItem_Search.Edit = this.repositoryItemSearchControl_Search;
			this.barEditItem_Search.Id = 8;
			this.barEditItem_Search.Name = "barEditItem_Search";
			// 
			// repositoryItemSearchControl_Search
			// 
			this.repositoryItemSearchControl_Search.AutoHeight = false;
			this.repositoryItemSearchControl_Search.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.repositoryItemSearchControl_Search.Name = "repositoryItemSearchControl_Search";
			// 
			// btn_Reload
			// 
			this.btn_Reload.Caption = "Reload";
			this.btn_Reload.Id = 1;
			this.btn_Reload.Name = "btn_Reload";
			this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
			// 
			// btn_Preview
			// 
			this.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.btn_Preview.Caption = "Preview";
			this.btn_Preview.DropDownControl = this.popupMenu_Preview;
			this.btn_Preview.Id = 2;
			this.btn_Preview.Name = "btn_Preview";
			this.btn_Preview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_ItemClick);
			// 
			// popupMenu_Preview
			// 
			this.popupMenu_Preview.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview_Asset_Item)});
			this.popupMenu_Preview.Manager = this.barManager;
			this.popupMenu_Preview.Name = "popupMenu_Preview";
			// 
			// btn_Preview_Asset_Item
			// 
			this.btn_Preview_Asset_Item.Caption = "Preview Asset Item";
			this.btn_Preview_Asset_Item.Id = 7;
			this.btn_Preview_Asset_Item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Preview_Asset_Item.ImageOptions.Image")));
			this.btn_Preview_Asset_Item.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Preview_Asset_Item.ImageOptions.LargeImage")));
			this.btn_Preview_Asset_Item.Name = "btn_Preview_Asset_Item";
			this.btn_Preview_Asset_Item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_Asset_Item_ItemClick);
			// 
			// btn_New
			// 
			this.btn_New.Caption = "New";
			this.btn_New.Id = 6;
			this.btn_New.Name = "btn_New";
			this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
			// 
			// btn_Save
			// 
			this.btn_Save.Caption = "Save";
			this.btn_Save.Id = 3;
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Caption = "Delete";
			this.btn_Delete.Id = 4;
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
			// 
			// btn_Close
			// 
			this.btn_Close.Caption = "Close";
			this.btn_Close.Id = 5;
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Close_ItemClick);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			this.bar2.Visible = false;
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			this.bar3.Visible = false;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(898, 41);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(898, 20);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 557);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(898, 41);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 557);
			// 
			// dockPanel1
			// 
			this.dockPanel1.Controls.Add(this.dockPanel1_Container);
			this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.dockPanel1.ID = new System.Guid("59252775-b154-40ce-8eb8-d9a7728426e7");
			this.dockPanel1.Location = new System.Drawing.Point(0, 41);
			this.dockPanel1.Name = "dockPanel1";
			this.dockPanel1.OriginalSize = new System.Drawing.Size(342, 200);
			this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.dockPanel1.SavedIndex = 0;
			this.dockPanel1.Size = new System.Drawing.Size(342, 557);
			this.dockPanel1.Text = "Information";
			// 
			// dockPanel1_Container
			// 
			this.dockPanel1_Container.Controls.Add(this.xuc_Asset);
			this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
			this.dockPanel1_Container.Name = "dockPanel1_Container";
			this.dockPanel1_Container.Size = new System.Drawing.Size(335, 528);
			this.dockPanel1_Container.TabIndex = 0;
			// 
			// xuc_Asset
			// 
			this.xuc_Asset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Asset.Location = new System.Drawing.Point(0, 0);
			this.xuc_Asset.Name = "xuc_Asset";
			this.xuc_Asset.Size = new System.Drawing.Size(335, 528);
			this.xuc_Asset.TabIndex = 0;
			// 
			// dockPanel2
			// 
			this.dockPanel2.Controls.Add(this.dockPanel2_Container);
			this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.dockPanel2.ID = new System.Guid("eea745f0-0163-462d-9027-1377b4f6890f");
			this.dockPanel2.Location = new System.Drawing.Point(628, 41);
			this.dockPanel2.Name = "dockPanel2";
			this.dockPanel2.OriginalSize = new System.Drawing.Size(270, 200);
			this.dockPanel2.Size = new System.Drawing.Size(270, 557);
			this.dockPanel2.Text = "Settings";
			// 
			// dockPanel2_Container
			// 
			this.dockPanel2_Container.Controls.Add(this.xuc_Settings);
			this.dockPanel2_Container.Location = new System.Drawing.Point(4, 26);
			this.dockPanel2_Container.Name = "dockPanel2_Container";
			this.dockPanel2_Container.Size = new System.Drawing.Size(263, 528);
			this.dockPanel2_Container.TabIndex = 0;
			// 
			// xuc_Settings
			// 
			this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Settings.Location = new System.Drawing.Point(0, 0);
			this.xuc_Settings.MinimumSize = new System.Drawing.Size(270, 0);
			this.xuc_Settings.Name = "xuc_Settings";
			this.xuc_Settings.Size = new System.Drawing.Size(270, 528);
			this.xuc_Settings.TabIndex = 0;
			// 
			// gridControl
			// 
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(342, 41);
			this.gridControl.MainView = this.gridView;
			this.gridControl.MenuManager = this.barManager;
			this.gridControl.Name = "gridControl";
			this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_Employees,
            this.repositoryItemLookUpEdit_Asset_Items,
            this.repositoryItemLookUpEdit_Branch});
			this.gridControl.Size = new System.Drawing.Size(286, 557);
			this.gridControl.TabIndex = 6;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAsset_Code,
            this.colGroup_Code,
            this.colBranch_Code,
            this.colDepartment,
            this.colCategory,
            this.colSub_Category,
            this.colStorage_Location,
            this.colAsset_Condition,
            this.colAsset_Name,
            this.colAsset_Description,
            this.colMade_In,
            this.colManufacturer,
            this.colBrand,
            this.colModel,
            this.colColor,
            this.colAsset_Details,
            this.colVendor_Name,
            this.colVendor_Description,
            this.colPurchased_Date,
            this.colPrice_Value,
            this.colWarranty_Date,
            this.colCurrent_Value,
            this.colCurrent_Custodian,
            this.colAsset_Type,
            this.colAsset_Status,
            this.colNotes,
            this.colSystem_Request_Code,
            this.colPayment_Request_Code,
            this.colCanvas_Code,
            this.colLiquiation_Code,
            this.colTransmittal_Code,
            this.colAdded_By,
            this.colAdded_Date,
            this.colModified_By,
            this.colModified_Date});
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsView.ColumnAutoWidth = false;
			this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
			this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
			this.gridView.PrintInitialize += new DevExpress.XtraGrid.Views.Base.PrintInitializeEventHandler(this.gridView_PrintInitialize);
			this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
			this.gridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseDown);
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			// 
			// colAsset_Code
			// 
			this.colAsset_Code.FieldName = "Asset_Code";
			this.colAsset_Code.Name = "colAsset_Code";
			this.colAsset_Code.Visible = true;
			this.colAsset_Code.VisibleIndex = 1;
			// 
			// colGroup_Code
			// 
			this.colGroup_Code.Caption = "Group";
			this.colGroup_Code.ColumnEdit = this.repositoryItemLookUpEdit_Asset_Items;
			this.colGroup_Code.FieldName = "Group_Code";
			this.colGroup_Code.Name = "colGroup_Code";
			this.colGroup_Code.Visible = true;
			this.colGroup_Code.VisibleIndex = 2;
			// 
			// repositoryItemLookUpEdit_Asset_Items
			// 
			this.repositoryItemLookUpEdit_Asset_Items.AutoHeight = false;
			this.repositoryItemLookUpEdit_Asset_Items.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Asset_Items.Name = "repositoryItemLookUpEdit_Asset_Items";
			// 
			// colBranch_Code
			// 
			this.colBranch_Code.Caption = "Branch";
			this.colBranch_Code.ColumnEdit = this.repositoryItemLookUpEdit_Branch;
			this.colBranch_Code.FieldName = "Branch_Code";
			this.colBranch_Code.Name = "colBranch_Code";
			this.colBranch_Code.Visible = true;
			this.colBranch_Code.VisibleIndex = 3;
			// 
			// repositoryItemLookUpEdit_Branch
			// 
			this.repositoryItemLookUpEdit_Branch.AutoHeight = false;
			this.repositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch";
			// 
			// colDepartment
			// 
			this.colDepartment.FieldName = "Department";
			this.colDepartment.Name = "colDepartment";
			this.colDepartment.Visible = true;
			this.colDepartment.VisibleIndex = 4;
			// 
			// colCategory
			// 
			this.colCategory.FieldName = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.Visible = true;
			this.colCategory.VisibleIndex = 5;
			// 
			// colSub_Category
			// 
			this.colSub_Category.FieldName = "Sub_Category";
			this.colSub_Category.Name = "colSub_Category";
			this.colSub_Category.Visible = true;
			this.colSub_Category.VisibleIndex = 6;
			// 
			// colStorage_Location
			// 
			this.colStorage_Location.FieldName = "Storage_Location";
			this.colStorage_Location.Name = "colStorage_Location";
			this.colStorage_Location.Visible = true;
			this.colStorage_Location.VisibleIndex = 7;
			// 
			// colAsset_Condition
			// 
			this.colAsset_Condition.FieldName = "Asset_Condition";
			this.colAsset_Condition.Name = "colAsset_Condition";
			this.colAsset_Condition.Visible = true;
			this.colAsset_Condition.VisibleIndex = 8;
			// 
			// colAsset_Name
			// 
			this.colAsset_Name.FieldName = "Asset_Name";
			this.colAsset_Name.Name = "colAsset_Name";
			this.colAsset_Name.Visible = true;
			this.colAsset_Name.VisibleIndex = 9;
			// 
			// colAsset_Description
			// 
			this.colAsset_Description.FieldName = "Asset_Description";
			this.colAsset_Description.Name = "colAsset_Description";
			this.colAsset_Description.Visible = true;
			this.colAsset_Description.VisibleIndex = 10;
			// 
			// colMade_In
			// 
			this.colMade_In.FieldName = "Made_In";
			this.colMade_In.Name = "colMade_In";
			this.colMade_In.Visible = true;
			this.colMade_In.VisibleIndex = 11;
			// 
			// colManufacturer
			// 
			this.colManufacturer.FieldName = "Manufacturer";
			this.colManufacturer.Name = "colManufacturer";
			this.colManufacturer.Visible = true;
			this.colManufacturer.VisibleIndex = 12;
			// 
			// colBrand
			// 
			this.colBrand.FieldName = "Brand";
			this.colBrand.Name = "colBrand";
			this.colBrand.Visible = true;
			this.colBrand.VisibleIndex = 13;
			// 
			// colModel
			// 
			this.colModel.FieldName = "Model";
			this.colModel.Name = "colModel";
			this.colModel.Visible = true;
			this.colModel.VisibleIndex = 14;
			// 
			// colColor
			// 
			this.colColor.FieldName = "Color";
			this.colColor.Name = "colColor";
			this.colColor.Visible = true;
			this.colColor.VisibleIndex = 15;
			// 
			// colAsset_Details
			// 
			this.colAsset_Details.FieldName = "Asset_Details";
			this.colAsset_Details.Name = "colAsset_Details";
			this.colAsset_Details.Visible = true;
			this.colAsset_Details.VisibleIndex = 16;
			// 
			// colVendor_Name
			// 
			this.colVendor_Name.FieldName = "Vendor_Name";
			this.colVendor_Name.Name = "colVendor_Name";
			this.colVendor_Name.Visible = true;
			this.colVendor_Name.VisibleIndex = 17;
			// 
			// colVendor_Description
			// 
			this.colVendor_Description.FieldName = "Vendor_Description";
			this.colVendor_Description.Name = "colVendor_Description";
			this.colVendor_Description.Visible = true;
			this.colVendor_Description.VisibleIndex = 18;
			// 
			// colPurchased_Date
			// 
			this.colPurchased_Date.FieldName = "Purchased_Date";
			this.colPurchased_Date.Name = "colPurchased_Date";
			this.colPurchased_Date.Visible = true;
			this.colPurchased_Date.VisibleIndex = 19;
			// 
			// colPrice_Value
			// 
			this.colPrice_Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPrice_Value.FieldName = "Price_Value";
			this.colPrice_Value.Name = "colPrice_Value";
			this.colPrice_Value.Visible = true;
			this.colPrice_Value.VisibleIndex = 20;
			// 
			// colWarranty_Date
			// 
			this.colWarranty_Date.FieldName = "Warranty_Date";
			this.colWarranty_Date.Name = "colWarranty_Date";
			this.colWarranty_Date.Visible = true;
			this.colWarranty_Date.VisibleIndex = 21;
			// 
			// colCurrent_Value
			// 
			this.colCurrent_Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCurrent_Value.FieldName = "Current_Value";
			this.colCurrent_Value.Name = "colCurrent_Value";
			this.colCurrent_Value.Visible = true;
			this.colCurrent_Value.VisibleIndex = 22;
			// 
			// colCurrent_Custodian
			// 
			this.colCurrent_Custodian.ColumnEdit = this.repositoryItemLookUpEdit_Employees;
			this.colCurrent_Custodian.FieldName = "Current_Custodian";
			this.colCurrent_Custodian.Name = "colCurrent_Custodian";
			this.colCurrent_Custodian.Visible = true;
			this.colCurrent_Custodian.VisibleIndex = 23;
			// 
			// repositoryItemLookUpEdit_Employees
			// 
			this.repositoryItemLookUpEdit_Employees.AutoHeight = false;
			this.repositoryItemLookUpEdit_Employees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Employees.Name = "repositoryItemLookUpEdit_Employees";
			// 
			// colAsset_Type
			// 
			this.colAsset_Type.FieldName = "Asset_Type";
			this.colAsset_Type.Name = "colAsset_Type";
			this.colAsset_Type.Visible = true;
			this.colAsset_Type.VisibleIndex = 24;
			// 
			// colAsset_Status
			// 
			this.colAsset_Status.FieldName = "Asset_Status";
			this.colAsset_Status.Name = "colAsset_Status";
			this.colAsset_Status.Visible = true;
			this.colAsset_Status.VisibleIndex = 25;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 26;
			// 
			// colSystem_Request_Code
			// 
			this.colSystem_Request_Code.FieldName = "System_Request_Code";
			this.colSystem_Request_Code.Name = "colSystem_Request_Code";
			this.colSystem_Request_Code.Visible = true;
			this.colSystem_Request_Code.VisibleIndex = 27;
			// 
			// colPayment_Request_Code
			// 
			this.colPayment_Request_Code.FieldName = " Payment_Request_Code";
			this.colPayment_Request_Code.Name = "colPayment_Request_Code";
			this.colPayment_Request_Code.Visible = true;
			this.colPayment_Request_Code.VisibleIndex = 28;
			// 
			// colCanvas_Code
			// 
			this.colCanvas_Code.FieldName = "Canvas_Code";
			this.colCanvas_Code.Name = "colCanvas_Code";
			this.colCanvas_Code.Visible = true;
			this.colCanvas_Code.VisibleIndex = 29;
			// 
			// colLiquiation_Code
			// 
			this.colLiquiation_Code.FieldName = "Liquiation_Code";
			this.colLiquiation_Code.Name = "colLiquiation_Code";
			this.colLiquiation_Code.Visible = true;
			this.colLiquiation_Code.VisibleIndex = 30;
			// 
			// colTransmittal_Code
			// 
			this.colTransmittal_Code.FieldName = "Transmittal_Code";
			this.colTransmittal_Code.Name = "colTransmittal_Code";
			this.colTransmittal_Code.Visible = true;
			this.colTransmittal_Code.VisibleIndex = 31;
			// 
			// colAdded_By
			// 
			this.colAdded_By.FieldName = "Added_By";
			this.colAdded_By.Name = "colAdded_By";
			this.colAdded_By.Visible = true;
			this.colAdded_By.VisibleIndex = 32;
			// 
			// colAdded_Date
			// 
			this.colAdded_Date.FieldName = "Added_Date";
			this.colAdded_Date.Name = "colAdded_Date";
			this.colAdded_Date.Visible = true;
			this.colAdded_Date.VisibleIndex = 33;
			// 
			// colModified_By
			// 
			this.colModified_By.FieldName = "Modified_By";
			this.colModified_By.Name = "colModified_By";
			this.colModified_By.Visible = true;
			this.colModified_By.VisibleIndex = 34;
			// 
			// colModified_Date
			// 
			this.colModified_Date.FieldName = "Modified_Date";
			this.colModified_Date.Name = "colModified_Date";
			this.colModified_Date.Visible = true;
			this.colModified_Date.VisibleIndex = 35;
			// 
			// frm_Assets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 618);
			this.Controls.Add(this.gridControl);
			this.Controls.Add(this.dockPanel2);
			this.Controls.Add(this.dockPanel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frm_Assets";
			this.Text = "frm_Assets";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Assets_FormClosing);
			this.Load += new System.EventHandler(this.frm_Assets_Load);
			this.Shown += new System.EventHandler(this.frm_Assets_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl_Search)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).EndInit();
			this.dockPanel1.ResumeLayout(false);
			this.dockPanel1_Container.ResumeLayout(false);
			this.dockPanel2.ResumeLayout(false);
			this.dockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Asset_Items)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Branch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Employees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarButtonItem btn_Initialize;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Preview;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Close;
        private Controls.xuc_Asset xuc_Asset;
        private DevExpress.XtraBars.BarButtonItem btn_New;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colStorage_Location;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Condition;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colMade_In;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Details;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchased_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colWarranty_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrent_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        private DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        private DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colAsset_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrent_Custodian;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Employees;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_Code;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Asset_Items;
        private DevExpress.XtraGrid.Columns.GridColumn colSub_Category;
        private DevExpress.XtraBars.PopupMenu popupMenu_Preview;
        private DevExpress.XtraBars.BarButtonItem btn_Preview_Asset_Item;
		private DevExpress.XtraGrid.Columns.GridColumn colSystem_Request_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colPayment_Request_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colCanvas_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colLiquiation_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colBranch_Code;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Branch;
		private DevExpress.XtraBars.BarEditItem barEditItem_Search;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl_Search;
	}
}