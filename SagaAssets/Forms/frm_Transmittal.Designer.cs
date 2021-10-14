using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

namespace SagaAssets.Forms
{
    [DesignerGenerated()]
    public partial class frm_Transmittal : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Transmittal));
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reset = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Preview = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu_Preview = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_Preview_System_Transmittal = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
            this.Bar4 = new DevExpress.XtraBars.Bar();
            this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.Bar_Action = new DevExpress.XtraBars.Bar();
            this.btn_Transmittal_Open = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Transmittal_Close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Transmittal_Approve = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Suspend = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Re_Open = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xuc_Transmittal = new SagaAssets.Controls.xuc_Transmittal();
            this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransmittal_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransmittal_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_From = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_To = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransmittal_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransmittal_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransmittal_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdded_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdded_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsApproved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproved_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproved_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colIs_Received = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceived_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceived_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
            this.DockPanel1.SuspendLayout();
            this.DockPanel1_Container.SuspendLayout();
            this.DockPanel2.SuspendLayout();
            this.DockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // DockManager
            // 
            this.DockManager.DockingOptions.ShowCloseButton = false;
            this.DockManager.Form = this;
            this.DockManager.MenuManager = this.BarManager;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel1,
            this.DockPanel2});
            this.DockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1,
            this.Bar4,
            this.Bar_Action});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.DockManager = this.DockManager;
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Initialize,
            this.BarEditItem_Search,
            this.btn_Reload,
            this.btn_New,
            this.btn_Save,
            this.btn_Delete,
            this.btn_Close,
            this.btn_Preview,
            this.btn_Reset,
            this.btn_Transmittal_Open,
            this.btn_Transmittal_Close,
            this.btn_Transmittal_Approve,
            this.btn_Suspend,
            this.btn_Re_Open,
            this.btn_Preview_System_Transmittal});
            this.BarManager.MaxItemId = 21;
            this.BarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit_Branch,
            this.RepositoryItemSearchControl_Search});
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Actions";
            this.Bar1.DockCol = 1;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reset),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
            this.Bar1.Offset = 101;
            this.Bar1.Text = "Actions";
            // 
            // btn_Initialize
            // 
            this.btn_Initialize.Caption = "Initialize";
            this.btn_Initialize.Id = 0;
            this.btn_Initialize.Name = "btn_Initialize";
            this.btn_Initialize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Initialize_ItemClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Caption = "Reset";
            this.btn_Reset.Id = 9;
            this.btn_Reset.Name = "btn_Reset";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 3;
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
            // 
            // btn_Preview
            // 
            this.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btn_Preview.Caption = "Preview";
            this.btn_Preview.DropDownControl = this.popupMenu_Preview;
            this.btn_Preview.Id = 8;
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_ItemClick);
            // 
            // popupMenu_Preview
            // 
            this.popupMenu_Preview.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview_System_Transmittal)});
            this.popupMenu_Preview.Manager = this.BarManager;
            this.popupMenu_Preview.Name = "popupMenu_Preview";
            // 
            // btn_Preview_System_Transmittal
            // 
            this.btn_Preview_System_Transmittal.Caption = "System Transmittal";
            this.btn_Preview_System_Transmittal.Id = 19;
            this.btn_Preview_System_Transmittal.Name = "btn_Preview_System_Transmittal";
            this.btn_Preview_System_Transmittal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_System_Transmittal_ItemClick);
            // 
            // btn_New
            // 
            this.btn_New.Caption = "New";
            this.btn_New.Id = 4;
            this.btn_New.Name = "btn_New";
            this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Caption = "Save";
            this.btn_Save.Id = 5;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Delete";
            this.btn_Delete.Id = 6;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Close
            // 
            this.btn_Close.Caption = "Close";
            this.btn_Close.Id = 7;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Close_ItemClick);
            // 
            // Bar4
            // 
            this.Bar4.BarName = "Parameters";
            this.Bar4.DockCol = 0;
            this.Bar4.DockRow = 0;
            this.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarEditItem_Search)});
            this.Bar4.Text = "Parameters";
            // 
            // BarEditItem_Search
            // 
            this.BarEditItem_Search.Caption = "BarEditItem1";
            this.BarEditItem_Search.Edit = this.RepositoryItemSearchControl_Search;
            this.BarEditItem_Search.Id = 2;
            this.BarEditItem_Search.Name = "BarEditItem_Search";
            // 
            // RepositoryItemSearchControl_Search
            // 
            this.RepositoryItemSearchControl_Search.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search";
            // 
            // Bar_Action
            // 
            this.Bar_Action.BarName = "Bar_Action";
            this.Bar_Action.DockCol = 0;
            this.Bar_Action.DockRow = 1;
            this.Bar_Action.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar_Action.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Approve),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Suspend, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Re_Open)});
            this.Bar_Action.Text = "Action";
            // 
            // btn_Transmittal_Open
            // 
            this.btn_Transmittal_Open.Caption = "Open";
            this.btn_Transmittal_Open.Id = 10;
            this.btn_Transmittal_Open.Name = "btn_Transmittal_Open";
            this.btn_Transmittal_Open.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Transmittal_Open_ItemClick);
            // 
            // btn_Transmittal_Close
            // 
            this.btn_Transmittal_Close.Caption = "Close";
            this.btn_Transmittal_Close.Id = 11;
            this.btn_Transmittal_Close.Name = "btn_Transmittal_Close";
            this.btn_Transmittal_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Transmittal_Close_ItemClick);
            // 
            // btn_Transmittal_Approve
            // 
            this.btn_Transmittal_Approve.Caption = "Approve";
            this.btn_Transmittal_Approve.Id = 12;
            this.btn_Transmittal_Approve.Name = "btn_Transmittal_Approve";
            this.btn_Transmittal_Approve.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Transmittal_Approve_ItemClick);
            // 
            // btn_Suspend
            // 
            this.btn_Suspend.Caption = "Suspend";
            this.btn_Suspend.Id = 17;
            this.btn_Suspend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suspend.ImageOptions.Image")));
            this.btn_Suspend.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Suspend.ImageOptions.LargeImage")));
            this.btn_Suspend.Name = "btn_Suspend";
            this.btn_Suspend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Suspend_ItemClick);
            // 
            // btn_Re_Open
            // 
            this.btn_Re_Open.Caption = "Re-Open";
            this.btn_Re_Open.Id = 18;
            this.btn_Re_Open.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Re_Open.ImageOptions.Image")));
            this.btn_Re_Open.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Re_Open.ImageOptions.LargeImage")));
            this.btn_Re_Open.Name = "btn_Re_Open";
            this.btn_Re_Open.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Re_Open_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(874, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 504);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 45);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // RepositoryItemLookUpEdit_Branch
            // 
            this.RepositoryItemLookUpEdit_Branch.AutoHeight = false;
            this.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch";
            // 
            // DockPanel1
            // 
            this.DockPanel1.Controls.Add(this.DockPanel1_Container);
            this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.DockPanel1.ID = new System.Guid("c4f0a519-4d96-443d-8b06-14937c864a67");
            this.DockPanel1.Location = new System.Drawing.Point(0, 45);
            this.DockPanel1.Name = "DockPanel1";
            this.DockPanel1.OriginalSize = new System.Drawing.Size(286, 200);
            this.DockPanel1.Size = new System.Drawing.Size(286, 459);
            this.DockPanel1.Text = "Information";
            // 
            // DockPanel1_Container
            // 
            this.DockPanel1_Container.Controls.Add(this.xuc_Transmittal);
            this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.DockPanel1_Container.Name = "DockPanel1_Container";
            this.DockPanel1_Container.Size = new System.Drawing.Size(279, 430);
            this.DockPanel1_Container.TabIndex = 0;
            // 
            // xuc_Transmittal
            // 
            this.xuc_Transmittal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Transmittal.Location = new System.Drawing.Point(0, 0);
            this.xuc_Transmittal.Name = "xuc_Transmittal";
            this.xuc_Transmittal.Size = new System.Drawing.Size(279, 430);
            this.xuc_Transmittal.TabIndex = 0;
            // 
            // DockPanel2
            // 
            this.DockPanel2.Controls.Add(this.DockPanel2_Container);
            this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DockPanel2.ID = new System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba");
            this.DockPanel2.Location = new System.Drawing.Point(674, 45);
            this.DockPanel2.Name = "DockPanel2";
            this.DockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.DockPanel2.Size = new System.Drawing.Size(200, 459);
            this.DockPanel2.Text = "Settings";
            // 
            // DockPanel2_Container
            // 
            this.DockPanel2_Container.Controls.Add(this.xuc_Settings);
            this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
            this.DockPanel2_Container.Name = "DockPanel2_Container";
            this.DockPanel2_Container.Size = new System.Drawing.Size(193, 430);
            this.DockPanel2_Container.TabIndex = 0;
            // 
            // xuc_Settings
            // 
            this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Settings.Location = new System.Drawing.Point(0, 0);
            this.xuc_Settings.Name = "xuc_Settings";
            this.xuc_Settings.Size = new System.Drawing.Size(193, 430);
            this.xuc_Settings.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.DataMember = "acc_Transmittals";
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(286, 45);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(388, 459);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTransmittal_Code,
            this.colTransmittal_Status,
            this.colBranch_From,
            this.colCourier,
            this.colBranch_To,
            this.colTransmittal_Type,
            this.colTransmittal_Name,
            this.colTransmittal_Description,
            this.colPrepared_By,
            this.colReceiver,
            this.colNotes,
            this.colAdded_By,
            this.colAdded_Date,
            this.colModified_By,
            this.colModified_Date,
            this.colIsApproved,
            this.colApproved_By,
            this.colApproved_Date,
            this.colIs_Received,
            this.colReceived_By,
            this.colReceived_Date,
            this.colIsDeleted,
            this.colDeleted_By,
            this.colDeleted_Date});
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
            // colTransmittal_Code
            // 
            this.colTransmittal_Code.Caption = "Code";
            this.colTransmittal_Code.FieldName = "Transmittal_Code";
            this.colTransmittal_Code.Name = "colTransmittal_Code";
            this.colTransmittal_Code.Visible = true;
            this.colTransmittal_Code.VisibleIndex = 1;
            // 
            // colTransmittal_Status
            // 
            this.colTransmittal_Status.FieldName = "Transmittal_Status";
            this.colTransmittal_Status.Name = "colTransmittal_Status";
            this.colTransmittal_Status.Visible = true;
            this.colTransmittal_Status.VisibleIndex = 2;
            // 
            // colBranch_From
            // 
            this.colBranch_From.FieldName = "Branch_From";
            this.colBranch_From.Name = "colBranch_From";
            this.colBranch_From.Visible = true;
            this.colBranch_From.VisibleIndex = 3;
            // 
            // colCourier
            // 
            this.colCourier.FieldName = "Courier";
            this.colCourier.Name = "colCourier";
            this.colCourier.Visible = true;
            this.colCourier.VisibleIndex = 4;
            // 
            // colBranch_To
            // 
            this.colBranch_To.FieldName = "Branch_To";
            this.colBranch_To.Name = "colBranch_To";
            this.colBranch_To.Visible = true;
            this.colBranch_To.VisibleIndex = 5;
            // 
            // colTransmittal_Type
            // 
            this.colTransmittal_Type.FieldName = "Transmittal_Type";
            this.colTransmittal_Type.Name = "colTransmittal_Type";
            this.colTransmittal_Type.Visible = true;
            this.colTransmittal_Type.VisibleIndex = 6;
            // 
            // colReceiver
            // 
            this.colReceiver.FieldName = "Receiver";
            this.colReceiver.Name = "colReceiver";
            this.colReceiver.Visible = true;
            this.colReceiver.VisibleIndex = 10;
            // 
            // colTransmittal_Name
            // 
            this.colTransmittal_Name.FieldName = "Transmittal_Name";
            this.colTransmittal_Name.Name = "colTransmittal_Name";
            this.colTransmittal_Name.Visible = true;
            this.colTransmittal_Name.VisibleIndex = 7;
            // 
            // colTransmittal_Description
            // 
            this.colTransmittal_Description.Caption = "Description";
            this.colTransmittal_Description.FieldName = "Transmittal_Description";
            this.colTransmittal_Description.Name = "colTransmittal_Description";
            this.colTransmittal_Description.Visible = true;
            this.colTransmittal_Description.VisibleIndex = 8;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 11;
            // 
            // colPrepared_By
            // 
            this.colPrepared_By.FieldName = "Prepared_By";
            this.colPrepared_By.Name = "colPrepared_By";
            this.colPrepared_By.Visible = true;
            this.colPrepared_By.VisibleIndex = 9;
            // 
            // colAdded_By
            // 
            this.colAdded_By.FieldName = "Added_By";
            this.colAdded_By.Name = "colAdded_By";
            this.colAdded_By.Visible = true;
            this.colAdded_By.VisibleIndex = 12;
            // 
            // colAdded_Date
            // 
            this.colAdded_Date.FieldName = "Added_Date";
            this.colAdded_Date.Name = "colAdded_Date";
            this.colAdded_Date.Visible = true;
            this.colAdded_Date.VisibleIndex = 13;
            // 
            // colModified_By
            // 
            this.colModified_By.FieldName = "Modified_By";
            this.colModified_By.Name = "colModified_By";
            this.colModified_By.Visible = true;
            this.colModified_By.VisibleIndex = 14;
            // 
            // colModified_Date
            // 
            this.colModified_Date.FieldName = "Modified_Date";
            this.colModified_Date.Name = "colModified_Date";
            this.colModified_Date.Visible = true;
            this.colModified_Date.VisibleIndex = 15;
            // 
            // colIsApproved
            // 
            this.colIsApproved.FieldName = "IsApproved";
            this.colIsApproved.Name = "colIsApproved";
            this.colIsApproved.Visible = true;
            this.colIsApproved.VisibleIndex = 16;
            // 
            // colApproved_By
            // 
            this.colApproved_By.FieldName = "Approved_By";
            this.colApproved_By.Name = "colApproved_By";
            this.colApproved_By.Visible = true;
            this.colApproved_By.VisibleIndex = 17;
            // 
            // colApproved_Date
            // 
            this.colApproved_Date.FieldName = "Approved_Date";
            this.colApproved_Date.Name = "colApproved_Date";
            this.colApproved_Date.Visible = true;
            this.colApproved_Date.VisibleIndex = 18;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.Visible = true;
            this.colIsDeleted.VisibleIndex = 22;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 23;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 24;
            // 
            // PopupMenu
            // 
            this.PopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Transmittal_Approve),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Suspend, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Re_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
            this.PopupMenu.Manager = this.BarManager;
            this.PopupMenu.Name = "PopupMenu";
            // 
            // colIs_Received
            // 
            this.colIs_Received.FieldName = "Is_Received";
            this.colIs_Received.Name = "colIs_Received";
            this.colIs_Received.Visible = true;
            this.colIs_Received.VisibleIndex = 19;
            // 
            // colReceived_By
            // 
            this.colReceived_By.FieldName = "Received_By";
            this.colReceived_By.Name = "colReceived_By";
            this.colReceived_By.Visible = true;
            this.colReceived_By.VisibleIndex = 20;
            // 
            // colReceived_Date
            // 
            this.colReceived_Date.FieldName = "Received_Date";
            this.colReceived_Date.Name = "colReceived_Date";
            this.colReceived_Date.Visible = true;
            this.colReceived_Date.VisibleIndex = 21;
            // 
            // frm_Transmittal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 504);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.DockPanel2);
            this.Controls.Add(this.DockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Transmittal";
            this.Text = "frm_Transmittals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Transmittals_FormClosing);
            this.Load += new System.EventHandler(this.frm_Transmittals_Load);
            this.Shown += new System.EventHandler(this.frm_Transmittals_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
            this.DockPanel1.ResumeLayout(false);
            this.DockPanel1_Container.ResumeLayout(false);
            this.DockPanel2.ResumeLayout(false);
            this.DockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal DevExpress.XtraBars.Docking.DockManager DockManager;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel2;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel2_Container;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel1;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
        internal Controls.xuc_Transmittal xuc_Transmittal;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarManager BarManager;
        internal DevExpress.XtraBars.Bar Bar1;
        internal DevExpress.XtraBars.BarButtonItem btn_Initialize;
        internal DevExpress.XtraBars.BarButtonItem btn_Reset;
        internal DevExpress.XtraBars.BarButtonItem btn_Reload;
        internal DevExpress.XtraBars.BarButtonItem btn_Preview;
        internal DevExpress.XtraBars.BarButtonItem btn_New;
        internal DevExpress.XtraBars.BarButtonItem btn_Save;
        internal DevExpress.XtraBars.BarButtonItem btn_Delete;
        internal DevExpress.XtraBars.BarButtonItem btn_Close;
        internal DevExpress.XtraBars.Bar Bar4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit_Branch;
        internal DevExpress.XtraBars.BarEditItem BarEditItem_Search;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSearchControl RepositoryItemSearchControl_Search;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        internal DevExpress.XtraGrid.Columns.GridColumn colID;
        internal DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colBranch_From;
        internal DevExpress.XtraGrid.Columns.GridColumn colBranch_To;
        internal DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Name;
        internal DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Description;
        internal DevExpress.XtraGrid.Columns.GridColumn colNotes;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colIsApproved;
        internal DevExpress.XtraGrid.Columns.GridColumn colApproved_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colApproved_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Status;
        internal DevExpress.XtraGrid.Columns.GridColumn colPrepared_By;
        internal DevExpress.XtraBars.BarButtonItem btn_Transmittal_Open;
        internal DevExpress.XtraBars.BarButtonItem btn_Transmittal_Close;
        internal DevExpress.XtraBars.BarButtonItem btn_Transmittal_Approve;
        internal DevExpress.XtraBars.PopupMenu PopupMenu;
        internal DevExpress.XtraBars.Bar Bar_Action;
        internal DevExpress.XtraGrid.Columns.GridColumn colTransmittal_Type;
        internal DevExpress.XtraBars.BarButtonItem btn_Suspend;
        internal DevExpress.XtraBars.BarButtonItem btn_Re_Open;
        internal DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        internal DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiver;
        private DevExpress.XtraGrid.Columns.GridColumn colCourier;
        private DevExpress.XtraBars.PopupMenu popupMenu_Preview;
        private DevExpress.XtraBars.BarButtonItem btn_Preview_System_Transmittal;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Received;
        private DevExpress.XtraGrid.Columns.GridColumn colReceived_By;
        private DevExpress.XtraGrid.Columns.GridColumn colReceived_Date;
    }
}