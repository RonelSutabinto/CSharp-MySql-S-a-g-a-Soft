﻿using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

namespace SagaAssets.Forms
{
    [DesignerGenerated()]
    public partial class frm_Requests : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Requests));
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reset = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Preview = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
            this.Bar4 = new DevExpress.XtraBars.Bar();
            this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.Bar_Action = new DevExpress.XtraBars.Bar();
            this.btn_Request_Open = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Request_Close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Request_Approve = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Suspend = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Re_Open = new DevExpress.XtraBars.BarButtonItem();
            this.Bar_Progress = new DevExpress.XtraBars.Bar();
            this.btn_Progress_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Progress_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Progress_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xuc_Request = new SagaAssets.Controls.xuc_Request();
            this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
            this.DockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridControl_Progress = new DevExpress.XtraGrid.GridControl();
            this.gridView_Progress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequest_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequest_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequest_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrgency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequest_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequest_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechnical_Report = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecommendation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequested_By = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.popupMenu_Preview = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_Preview_System_Request = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Preview_Technical_Report = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
            this.DockPanel1.SuspendLayout();
            this.DockPanel1_Container.SuspendLayout();
            this.DockPanel2.SuspendLayout();
            this.DockPanel2_Container.SuspendLayout();
            this.DockPanel3.SuspendLayout();
            this.DockPanel3_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // DockManager
            // 
            this.DockManager.DockingOptions.ShowCloseButton = false;
            this.DockManager.Form = this;
            this.DockManager.MenuManager = this.BarManager;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel1,
            this.DockPanel2,
            this.DockPanel3});
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
            this.Bar_Action,
            this.Bar_Progress});
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
            this.btn_Request_Open,
            this.btn_Request_Close,
            this.btn_Request_Approve,
            this.btn_Progress_Add,
            this.btn_Progress_Delete,
            this.btn_Progress_Reload,
            this.btn_Suspend,
            this.btn_Re_Open,
            this.btn_Preview_System_Request,
            this.btn_Preview_Technical_Report});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Approve),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Suspend, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Re_Open)});
            this.Bar_Action.Text = "Action";
            // 
            // btn_Request_Open
            // 
            this.btn_Request_Open.Caption = "Open";
            this.btn_Request_Open.Id = 10;
            this.btn_Request_Open.Name = "btn_Request_Open";
            this.btn_Request_Open.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Request_Open_ItemClick);
            // 
            // btn_Request_Close
            // 
            this.btn_Request_Close.Caption = "Close";
            this.btn_Request_Close.Id = 11;
            this.btn_Request_Close.Name = "btn_Request_Close";
            this.btn_Request_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Request_Close_ItemClick);
            // 
            // btn_Request_Approve
            // 
            this.btn_Request_Approve.Caption = "Approve";
            this.btn_Request_Approve.Id = 12;
            this.btn_Request_Approve.Name = "btn_Request_Approve";
            this.btn_Request_Approve.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Request_Approve_ItemClick);
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
            // Bar_Progress
            // 
            this.Bar_Progress.BarName = "Progress";
            this.Bar_Progress.DockCol = 1;
            this.Bar_Progress.DockRow = 1;
            this.Bar_Progress.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar_Progress.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress_Add, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress_Delete)});
            this.Bar_Progress.Offset = 122;
            this.Bar_Progress.Text = "Progress";
            // 
            // btn_Progress_Reload
            // 
            this.btn_Progress_Reload.Caption = "Reload Progress";
            this.btn_Progress_Reload.Id = 16;
            this.btn_Progress_Reload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Reload.ImageOptions.Image")));
            this.btn_Progress_Reload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Reload.ImageOptions.LargeImage")));
            this.btn_Progress_Reload.Name = "btn_Progress_Reload";
            this.btn_Progress_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Progress_Reload_ItemClick);
            // 
            // btn_Progress_Add
            // 
            this.btn_Progress_Add.Caption = "Add Progress";
            this.btn_Progress_Add.Id = 14;
            this.btn_Progress_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Add.ImageOptions.Image")));
            this.btn_Progress_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Add.ImageOptions.LargeImage")));
            this.btn_Progress_Add.Name = "btn_Progress_Add";
            this.btn_Progress_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Progress_Add_ItemClick);
            // 
            // btn_Progress_Delete
            // 
            this.btn_Progress_Delete.Caption = "Delete Progress";
            this.btn_Progress_Delete.Id = 15;
            this.btn_Progress_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Delete.ImageOptions.Image")));
            this.btn_Progress_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Progress_Delete.ImageOptions.LargeImage")));
            this.btn_Progress_Delete.Name = "btn_Progress_Delete";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 476);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 45);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 476);
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
            this.DockPanel1.Size = new System.Drawing.Size(286, 476);
            this.DockPanel1.Text = "Information";
            // 
            // DockPanel1_Container
            // 
            this.DockPanel1_Container.Controls.Add(this.xuc_Request);
            this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.DockPanel1_Container.Name = "DockPanel1_Container";
            this.DockPanel1_Container.Size = new System.Drawing.Size(279, 447);
            this.DockPanel1_Container.TabIndex = 0;
            // 
            // xuc_Request
            // 
            this.xuc_Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Request.Location = new System.Drawing.Point(0, 0);
            this.xuc_Request.Name = "xuc_Request";
            this.xuc_Request.Size = new System.Drawing.Size(279, 447);
            this.xuc_Request.TabIndex = 0;
            // 
            // DockPanel2
            // 
            this.DockPanel2.Controls.Add(this.DockPanel2_Container);
            this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DockPanel2.ID = new System.Guid("2b17aaf5-cd36-45c5-8d54-fc4438d87eba");
            this.DockPanel2.Location = new System.Drawing.Point(674, 45);
            this.DockPanel2.Name = "DockPanel2";
            this.DockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.DockPanel2.Size = new System.Drawing.Size(200, 476);
            this.DockPanel2.Text = "Settings";
            // 
            // DockPanel2_Container
            // 
            this.DockPanel2_Container.Controls.Add(this.xuc_Settings);
            this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
            this.DockPanel2_Container.Name = "DockPanel2_Container";
            this.DockPanel2_Container.Size = new System.Drawing.Size(193, 447);
            this.DockPanel2_Container.TabIndex = 0;
            // 
            // xuc_Settings
            // 
            this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Settings.Location = new System.Drawing.Point(0, 0);
            this.xuc_Settings.Name = "xuc_Settings";
            this.xuc_Settings.Size = new System.Drawing.Size(193, 447);
            this.xuc_Settings.TabIndex = 0;
            // 
            // DockPanel3
            // 
            this.DockPanel3.Controls.Add(this.DockPanel3_Container);
            this.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.DockPanel3.ID = new System.Guid("21bc6ef0-e942-4840-bdb9-47f86922a12c");
            this.DockPanel3.Location = new System.Drawing.Point(286, 321);
            this.DockPanel3.Name = "DockPanel3";
            this.DockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
            this.DockPanel3.Size = new System.Drawing.Size(388, 200);
            this.DockPanel3.Text = "Progress";
            // 
            // DockPanel3_Container
            // 
            this.DockPanel3_Container.Controls.Add(this.gridControl_Progress);
            this.DockPanel3_Container.Location = new System.Drawing.Point(3, 27);
            this.DockPanel3_Container.Name = "DockPanel3_Container";
            this.DockPanel3_Container.Size = new System.Drawing.Size(382, 170);
            this.DockPanel3_Container.TabIndex = 0;
            // 
            // gridControl_Progress
            // 
            this.gridControl_Progress.DataMember = "acc_Requests";
            this.gridControl_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Progress.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Progress.MainView = this.gridView_Progress;
            this.gridControl_Progress.Name = "gridControl_Progress";
            this.gridControl_Progress.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit1});
            this.gridControl_Progress.Size = new System.Drawing.Size(382, 170);
            this.gridControl_Progress.TabIndex = 14;
            this.gridControl_Progress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Progress});
            // 
            // gridView_Progress
            // 
            this.gridView_Progress.GridControl = this.gridControl_Progress;
            this.gridView_Progress.Name = "gridView_Progress";
            this.gridView_Progress.OptionsView.ColumnAutoWidth = false;
            // 
            // RepositoryItemLookUpEdit1
            // 
            this.RepositoryItemLookUpEdit1.AutoHeight = false;
            this.RepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1";
            // 
            // gridControl
            // 
            this.gridControl.DataMember = "acc_Requests";
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(286, 45);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit});
            this.gridControl.Size = new System.Drawing.Size(388, 276);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRequest_Code,
            this.colRequest_Status,
            this.colBranch_Code,
            this.colDepartment,
            this.colCategory,
            this.colRequest_Type,
            this.colUrgency,
            this.colAmount,
            this.colQuantity,
            this.colRequest_Name,
            this.colRequest_Description,
            this.colReason,
            this.colTechnical_Report,
            this.colRecommendation,
            this.colNotes,
            this.colRequested_By,
            this.colAdded_By,
            this.colAdded_Date,
            this.colModified_By,
            this.colModified_Date,
            this.colIsApproved,
            this.colApproved_By,
            this.colApproved_Date,
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
            // colRequest_Code
            // 
            this.colRequest_Code.Caption = "Code";
            this.colRequest_Code.FieldName = "Request_Code";
            this.colRequest_Code.Name = "colRequest_Code";
            this.colRequest_Code.Visible = true;
            this.colRequest_Code.VisibleIndex = 1;
            // 
            // colRequest_Status
            // 
            this.colRequest_Status.FieldName = "Request_Status";
            this.colRequest_Status.Name = "colRequest_Status";
            this.colRequest_Status.Visible = true;
            this.colRequest_Status.VisibleIndex = 2;
            // 
            // colBranch_Code
            // 
            this.colBranch_Code.Caption = "Branch";
            this.colBranch_Code.ColumnEdit = this.RepositoryItemLookUpEdit;
            this.colBranch_Code.FieldName = "Branch_Code";
            this.colBranch_Code.Name = "colBranch_Code";
            this.colBranch_Code.Visible = true;
            this.colBranch_Code.VisibleIndex = 3;
            // 
            // RepositoryItemLookUpEdit
            // 
            this.RepositoryItemLookUpEdit.AutoHeight = false;
            this.RepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit.Name = "RepositoryItemLookUpEdit";
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
            // colRequest_Type
            // 
            this.colRequest_Type.FieldName = "Request_Type";
            this.colRequest_Type.Name = "colRequest_Type";
            this.colRequest_Type.Visible = true;
            this.colRequest_Type.VisibleIndex = 6;
            // 
            // colUrgency
            // 
            this.colUrgency.FieldName = "Urgency";
            this.colUrgency.Name = "colUrgency";
            this.colUrgency.Visible = true;
            this.colUrgency.VisibleIndex = 7;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 9;
            // 
            // colRequest_Name
            // 
            this.colRequest_Name.Caption = "Name / Subject";
            this.colRequest_Name.FieldName = "Request_Name";
            this.colRequest_Name.Name = "colRequest_Name";
            this.colRequest_Name.Visible = true;
            this.colRequest_Name.VisibleIndex = 10;
            // 
            // colRequest_Description
            // 
            this.colRequest_Description.Caption = "Description";
            this.colRequest_Description.FieldName = "Request_Description";
            this.colRequest_Description.Name = "colRequest_Description";
            this.colRequest_Description.Visible = true;
            this.colRequest_Description.VisibleIndex = 11;
            // 
            // colReason
            // 
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 12;
            // 
            // colTechnical_Report
            // 
            this.colTechnical_Report.FieldName = "Technical_Report";
            this.colTechnical_Report.Name = "colTechnical_Report";
            this.colTechnical_Report.Visible = true;
            this.colTechnical_Report.VisibleIndex = 13;
            // 
            // colRecommendation
            // 
            this.colRecommendation.FieldName = "Recommendation";
            this.colRecommendation.Name = "colRecommendation";
            this.colRecommendation.Visible = true;
            this.colRecommendation.VisibleIndex = 14;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 15;
            // 
            // colRequested_By
            // 
            this.colRequested_By.FieldName = "Requested_By";
            this.colRequested_By.Name = "colRequested_By";
            this.colRequested_By.Visible = true;
            this.colRequested_By.VisibleIndex = 16;
            // 
            // colAdded_By
            // 
            this.colAdded_By.FieldName = "Added_By";
            this.colAdded_By.Name = "colAdded_By";
            this.colAdded_By.Visible = true;
            this.colAdded_By.VisibleIndex = 17;
            // 
            // colAdded_Date
            // 
            this.colAdded_Date.FieldName = "Added_Date";
            this.colAdded_Date.Name = "colAdded_Date";
            this.colAdded_Date.Visible = true;
            this.colAdded_Date.VisibleIndex = 18;
            // 
            // colModified_By
            // 
            this.colModified_By.FieldName = "Modified_By";
            this.colModified_By.Name = "colModified_By";
            this.colModified_By.Visible = true;
            this.colModified_By.VisibleIndex = 19;
            // 
            // colModified_Date
            // 
            this.colModified_Date.FieldName = "Modified_Date";
            this.colModified_Date.Name = "colModified_Date";
            this.colModified_Date.Visible = true;
            this.colModified_Date.VisibleIndex = 20;
            // 
            // colIsApproved
            // 
            this.colIsApproved.FieldName = "IsApproved";
            this.colIsApproved.Name = "colIsApproved";
            this.colIsApproved.Visible = true;
            this.colIsApproved.VisibleIndex = 21;
            // 
            // colApproved_By
            // 
            this.colApproved_By.FieldName = "Approved_By";
            this.colApproved_By.Name = "colApproved_By";
            this.colApproved_By.Visible = true;
            this.colApproved_By.VisibleIndex = 22;
            // 
            // colApproved_Date
            // 
            this.colApproved_Date.FieldName = "Approved_Date";
            this.colApproved_Date.Name = "colApproved_Date";
            this.colApproved_Date.Visible = true;
            this.colApproved_Date.VisibleIndex = 23;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.Visible = true;
            this.colIsDeleted.VisibleIndex = 24;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 25;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 26;
            // 
            // PopupMenu
            // 
            this.PopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Request_Approve),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress_Reload, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Suspend, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Re_Open),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
            this.PopupMenu.Manager = this.BarManager;
            this.PopupMenu.Name = "PopupMenu";
            // 
            // popupMenu_Preview
            // 
            this.popupMenu_Preview.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview_System_Request),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview_Technical_Report)});
            this.popupMenu_Preview.Manager = this.BarManager;
            this.popupMenu_Preview.Name = "popupMenu_Preview";
            // 
            // btn_Preview_System_Request
            // 
            this.btn_Preview_System_Request.Caption = "System Request";
            this.btn_Preview_System_Request.Id = 19;
            this.btn_Preview_System_Request.Name = "btn_Preview_System_Request";
            this.btn_Preview_System_Request.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_System_Request_ItemClick);
            // 
            // btn_Preview_Technical_Report
            // 
            this.btn_Preview_Technical_Report.Caption = "Technical Report";
            this.btn_Preview_Technical_Report.Id = 20;
            this.btn_Preview_Technical_Report.Name = "btn_Preview_Technical_Report";
            this.btn_Preview_Technical_Report.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_Technical_Report_ItemClick);
            // 
            // frm_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 521);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.DockPanel3);
            this.Controls.Add(this.DockPanel2);
            this.Controls.Add(this.DockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Requests";
            this.Text = "frm_Requests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Requests_FormClosing);
            this.Load += new System.EventHandler(this.frm_Requests_Load);
            this.Shown += new System.EventHandler(this.frm_Requests_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
            this.DockPanel1.ResumeLayout(false);
            this.DockPanel1_Container.ResumeLayout(false);
            this.DockPanel2.ResumeLayout(false);
            this.DockPanel2_Container.ResumeLayout(false);
            this.DockPanel3.ResumeLayout(false);
            this.DockPanel3_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal DevExpress.XtraBars.Docking.DockManager DockManager;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel2;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel2_Container;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel1;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
        internal Controls.xuc_Request xuc_Request;
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
        internal DevExpress.XtraGrid.Columns.GridColumn colRequest_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colBranch_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colCategory;
        internal DevExpress.XtraGrid.Columns.GridColumn colRequest_Name;
        internal DevExpress.XtraGrid.Columns.GridColumn colRequest_Description;
        internal DevExpress.XtraGrid.Columns.GridColumn colNotes;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colIsApproved;
        internal DevExpress.XtraGrid.Columns.GridColumn colApproved_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colApproved_Date;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit;
        internal DevExpress.XtraGrid.Columns.GridColumn colRequest_Status;
        internal DevExpress.XtraGrid.Columns.GridColumn colReason;
        internal DevExpress.XtraGrid.Columns.GridColumn colRequested_By;
        internal DevExpress.XtraBars.BarButtonItem btn_Request_Open;
        internal DevExpress.XtraBars.BarButtonItem btn_Request_Close;
        internal DevExpress.XtraBars.BarButtonItem btn_Request_Approve;
        internal DevExpress.XtraBars.PopupMenu PopupMenu;
        internal DevExpress.XtraBars.Bar Bar_Action;
        internal DevExpress.XtraGrid.Columns.GridColumn colRequest_Type;
        internal DevExpress.XtraGrid.GridControl gridControl_Progress;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView_Progress;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit1;
        internal DevExpress.XtraBars.Bar Bar_Progress;
        internal DevExpress.XtraBars.BarButtonItem btn_Progress_Reload;
        internal DevExpress.XtraBars.BarButtonItem btn_Progress_Add;
        internal DevExpress.XtraBars.BarButtonItem btn_Progress_Delete;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel3;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel3_Container;
        internal DevExpress.XtraBars.BarButtonItem btn_Suspend;
        internal DevExpress.XtraBars.BarButtonItem btn_Re_Open;
        internal DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        internal DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUrgency;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnical_Report;
        private DevExpress.XtraGrid.Columns.GridColumn colRecommendation;
        private DevExpress.XtraBars.PopupMenu popupMenu_Preview;
        private DevExpress.XtraBars.BarButtonItem btn_Preview_System_Request;
        private DevExpress.XtraBars.BarButtonItem btn_Preview_Technical_Report;
    }
}