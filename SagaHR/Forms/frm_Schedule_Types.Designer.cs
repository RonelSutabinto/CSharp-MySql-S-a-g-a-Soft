using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Forms
{
    [DesignerGenerated()]
    public partial class frm_Schedule_Types : DevExpress.XtraEditors.XtraForm
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
        // It can be Modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSchedule_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSchedule_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSchedule_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSchedule_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdded_By = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdded_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModified_By = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModified_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Preview = new DevExpress.XtraBars.BarButtonItem();
			this.btn_New = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
			this.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
			this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Schedule_Type = new SagaHR.Controls.xuc_Schedule_Type();
			this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.gridControl_Schedule = new DevExpress.XtraGrid.GridControl();
			this.gridView_Schedule = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID_Schedule = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWeek_Day = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemComboBox_Day = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.colAM_In = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTimeSpanEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
			this.colAM_Out = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPM_In = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPM_Out = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription_Schedule = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes_Schedule = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).BeginInit();
			this.DockPanel2.SuspendLayout();
			this.DockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
			this.PanelControl1.SuspendLayout();
			this.DockPanel1.SuspendLayout();
			this.DockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl)).BeginInit();
			this.PanelControl.SuspendLayout();
			this.dockPanel3.SuspendLayout();
			this.dockPanel3_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Schedule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Schedule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_Day)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl
			// 
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(250, 20);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(368, 298);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSchedule_Code,
            this.colSchedule_Status,
            this.colSchedule_Name,
            this.colSchedule_Description,
            this.colNotes,
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
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			// 
			// colSchedule_Code
			// 
			this.colSchedule_Code.Caption = "Code";
			this.colSchedule_Code.FieldName = "Schedule_Code";
			this.colSchedule_Code.Name = "colSchedule_Code";
			this.colSchedule_Code.Visible = true;
			this.colSchedule_Code.VisibleIndex = 1;
			// 
			// colSchedule_Status
			// 
			this.colSchedule_Status.Caption = "Status";
			this.colSchedule_Status.FieldName = "Schedule_Status";
			this.colSchedule_Status.Name = "colSchedule_Status";
			this.colSchedule_Status.Visible = true;
			this.colSchedule_Status.VisibleIndex = 2;
			// 
			// colSchedule_Name
			// 
			this.colSchedule_Name.Caption = "Name";
			this.colSchedule_Name.FieldName = "Schedule_Name";
			this.colSchedule_Name.Name = "colSchedule_Name";
			this.colSchedule_Name.Visible = true;
			this.colSchedule_Name.VisibleIndex = 3;
			// 
			// colSchedule_Description
			// 
			this.colSchedule_Description.Caption = "Description";
			this.colSchedule_Description.FieldName = "Schedule_Description";
			this.colSchedule_Description.Name = "colSchedule_Description";
			this.colSchedule_Description.Visible = true;
			this.colSchedule_Description.VisibleIndex = 4;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 5;
			// 
			// colAdded_By
			// 
			this.colAdded_By.FieldName = "Added_By";
			this.colAdded_By.Name = "colAdded_By";
			this.colAdded_By.Visible = true;
			this.colAdded_By.VisibleIndex = 6;
			// 
			// colAdded_Date
			// 
			this.colAdded_Date.FieldName = "Added_Date";
			this.colAdded_Date.Name = "colAdded_Date";
			this.colAdded_Date.Visible = true;
			this.colAdded_Date.VisibleIndex = 7;
			// 
			// colModified_By
			// 
			this.colModified_By.FieldName = "Modified_By";
			this.colModified_By.Name = "colModified_By";
			this.colModified_By.Visible = true;
			this.colModified_By.VisibleIndex = 8;
			// 
			// colModified_Date
			// 
			this.colModified_Date.FieldName = "Modified_Date";
			this.colModified_Date.Name = "colModified_Date";
			this.colModified_Date.Visible = true;
			this.colModified_Date.VisibleIndex = 9;
			// 
			// DockManager
			// 
			this.DockManager.DockingOptions.ShowCloseButton = false;
			this.DockManager.Form = this;
			this.DockManager.MenuManager = this.barManager;
			this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel2,
            this.DockPanel1,
            this.dockPanel3});
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
            "DevExpress.XtraBars.TabFormControl"});
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.DockManager = this.DockManager;
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Reload,
            this.btn_Close,
            this.btn_New,
            this.btn_Delete,
            this.btn_Save,
            this.btn_Preview,
            this.btn_Initialize,
            this.BarEditItem_Search});
			this.barManager.MaxItemId = 13;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemSearchControl_Search});
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 1;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.FloatLocation = new System.Drawing.Point(306, 170);
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.bar1.Offset = 112;
			this.bar1.Text = "Tools";
			// 
			// btn_Initialize
			// 
			this.btn_Initialize.Caption = "Initialize";
			this.btn_Initialize.Id = 8;
			this.btn_Initialize.ImageOptions.ImageIndex = 6;
			this.btn_Initialize.ImageOptions.LargeImageIndex = 6;
			this.btn_Initialize.Name = "btn_Initialize";
			this.btn_Initialize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Initialize_ItemClick);
			// 
			// btn_Reload
			// 
			this.btn_Reload.Caption = "Reload";
			this.btn_Reload.Id = 0;
			this.btn_Reload.ImageOptions.ImageIndex = 0;
			this.btn_Reload.ImageOptions.LargeImageIndex = 0;
			this.btn_Reload.Name = "btn_Reload";
			this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
			// 
			// btn_Preview
			// 
			this.btn_Preview.Caption = "Preview";
			this.btn_Preview.Id = 7;
			this.btn_Preview.ImageOptions.ImageIndex = 4;
			this.btn_Preview.ImageOptions.LargeImageIndex = 4;
			this.btn_Preview.Name = "btn_Preview";
			this.btn_Preview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Preview_ItemClick);
			// 
			// btn_New
			// 
			this.btn_New.Caption = "New";
			this.btn_New.Id = 2;
			this.btn_New.ImageOptions.ImageIndex = 1;
			this.btn_New.ImageOptions.LargeImageIndex = 1;
			this.btn_New.Name = "btn_New";
			this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
			// 
			// btn_Save
			// 
			this.btn_Save.Caption = "Save";
			this.btn_Save.Id = 4;
			this.btn_Save.ImageOptions.ImageIndex = 2;
			this.btn_Save.ImageOptions.LargeImageIndex = 2;
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Caption = "Delete";
			this.btn_Delete.Id = 3;
			this.btn_Delete.ImageOptions.ImageIndex = 3;
			this.btn_Delete.ImageOptions.LargeImageIndex = 3;
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
			// 
			// btn_Close
			// 
			this.btn_Close.Caption = "Close";
			this.btn_Close.Id = 1;
			this.btn_Close.ImageOptions.ImageIndex = 5;
			this.btn_Close.ImageOptions.LargeImageIndex = 5;
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Close_ItemClick);
			// 
			// bar2
			// 
			this.bar2.BarName = "Options";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarEditItem_Search, true)});
			this.bar2.Text = "Options";
			// 
			// BarEditItem_Search
			// 
			this.BarEditItem_Search.Edit = this.RepositoryItemSearchControl_Search;
			this.BarEditItem_Search.Id = 9;
			this.BarEditItem_Search.ImageOptions.ImageIndex = 7;
			this.BarEditItem_Search.ImageOptions.LargeImageIndex = 7;
			this.BarEditItem_Search.Name = "BarEditItem_Search";
			// 
			// RepositoryItemSearchControl_Search
			// 
			this.RepositoryItemSearchControl_Search.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
			this.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search";
			this.RepositoryItemSearchControl_Search.ShowClearButton = false;
			this.RepositoryItemSearchControl_Search.ShowSearchButton = false;
			this.RepositoryItemSearchControl_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RepositoryItemSearchControl_Search_KeyDown);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(898, 20);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(898, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 548);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(898, 20);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 548);
			// 
			// DockPanel2
			// 
			this.DockPanel2.Controls.Add(this.DockPanel2_Container);
			this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.DockPanel2.ID = new System.Guid("0bdaaf02-be17-4771-a971-fe3cc7c6e8b6");
			this.DockPanel2.Location = new System.Drawing.Point(618, 20);
			this.DockPanel2.Name = "DockPanel2";
			this.DockPanel2.OriginalSize = new System.Drawing.Size(280, 200);
			this.DockPanel2.Size = new System.Drawing.Size(280, 548);
			this.DockPanel2.Text = "Settings";
			// 
			// DockPanel2_Container
			// 
			this.DockPanel2_Container.Controls.Add(this.PanelControl1);
			this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
			this.DockPanel2_Container.Name = "DockPanel2_Container";
			this.DockPanel2_Container.Size = new System.Drawing.Size(273, 519);
			this.DockPanel2_Container.TabIndex = 0;
			// 
			// PanelControl1
			// 
			this.PanelControl1.Controls.Add(this.xuc_Settings);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(273, 519);
			this.PanelControl1.TabIndex = 0;
			// 
			// xuc_Settings
			// 
			this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Settings.Location = new System.Drawing.Point(2, 2);
			this.xuc_Settings.MinimumSize = new System.Drawing.Size(270, 0);
			this.xuc_Settings.Name = "xuc_Settings";
			this.xuc_Settings.Size = new System.Drawing.Size(270, 515);
			this.xuc_Settings.TabIndex = 0;
			// 
			// DockPanel1
			// 
			this.DockPanel1.Controls.Add(this.DockPanel1_Container);
			this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.DockPanel1.ID = new System.Guid("bb3d47b8-c719-45f7-aee3-8d7fe50f1b0a");
			this.DockPanel1.Location = new System.Drawing.Point(0, 20);
			this.DockPanel1.Name = "DockPanel1";
			this.DockPanel1.OriginalSize = new System.Drawing.Size(250, 200);
			this.DockPanel1.Size = new System.Drawing.Size(250, 548);
			this.DockPanel1.Text = "Information";
			// 
			// DockPanel1_Container
			// 
			this.DockPanel1_Container.Controls.Add(this.PanelControl);
			this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
			this.DockPanel1_Container.Name = "DockPanel1_Container";
			this.DockPanel1_Container.Size = new System.Drawing.Size(243, 519);
			this.DockPanel1_Container.TabIndex = 0;
			// 
			// PanelControl
			// 
			this.PanelControl.Controls.Add(this.xuc_Schedule_Type);
			this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl.Location = new System.Drawing.Point(0, 0);
			this.PanelControl.Name = "PanelControl";
			this.PanelControl.Size = new System.Drawing.Size(243, 519);
			this.PanelControl.TabIndex = 0;
			// 
			// xuc_Schedule_Type
			// 
			this.xuc_Schedule_Type.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Schedule_Type.Location = new System.Drawing.Point(2, 2);
			this.xuc_Schedule_Type.Name = "xuc_Schedule_Type";
			this.xuc_Schedule_Type.Size = new System.Drawing.Size(239, 515);
			this.xuc_Schedule_Type.TabIndex = 0;
			// 
			// dockPanel3
			// 
			this.dockPanel3.Controls.Add(this.dockPanel3_Container);
			this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
			this.dockPanel3.ID = new System.Guid("4fa15b6c-a76f-48fa-b9b4-70837ea1a08c");
			this.dockPanel3.Location = new System.Drawing.Point(250, 318);
			this.dockPanel3.Name = "dockPanel3";
			this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 250);
			this.dockPanel3.Size = new System.Drawing.Size(368, 250);
			this.dockPanel3.Text = "Schedule";
			// 
			// dockPanel3_Container
			// 
			this.dockPanel3_Container.Controls.Add(this.gridControl_Schedule);
			this.dockPanel3_Container.Location = new System.Drawing.Point(3, 27);
			this.dockPanel3_Container.Name = "dockPanel3_Container";
			this.dockPanel3_Container.Size = new System.Drawing.Size(362, 220);
			this.dockPanel3_Container.TabIndex = 0;
			// 
			// gridControl_Schedule
			// 
			this.gridControl_Schedule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl_Schedule.Location = new System.Drawing.Point(0, 0);
			this.gridControl_Schedule.MainView = this.gridView_Schedule;
			this.gridControl_Schedule.MenuManager = this.barManager;
			this.gridControl_Schedule.Name = "gridControl_Schedule";
			this.gridControl_Schedule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox_Day,
            this.repositoryItemTimeSpanEdit});
			this.gridControl_Schedule.Size = new System.Drawing.Size(362, 220);
			this.gridControl_Schedule.TabIndex = 0;
			this.gridControl_Schedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Schedule});
			// 
			// gridView_Schedule
			// 
			this.gridView_Schedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Schedule,
            this.colWeek_Day,
            this.colAM_In,
            this.colAM_Out,
            this.colPM_In,
            this.colPM_Out,
            this.colDescription_Schedule,
            this.colNotes_Schedule});
			this.gridView_Schedule.GridControl = this.gridControl_Schedule;
			this.gridView_Schedule.Name = "gridView_Schedule";
			this.gridView_Schedule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Schedule_KeyDown);
			// 
			// colID_Schedule
			// 
			this.colID_Schedule.FieldName = "ID";
			this.colID_Schedule.Name = "colID_Schedule";
			this.colID_Schedule.Visible = true;
			this.colID_Schedule.VisibleIndex = 0;
			// 
			// colWeek_Day
			// 
			this.colWeek_Day.ColumnEdit = this.repositoryItemComboBox_Day;
			this.colWeek_Day.FieldName = "Week_Day";
			this.colWeek_Day.Name = "colWeek_Day";
			this.colWeek_Day.Visible = true;
			this.colWeek_Day.VisibleIndex = 1;
			// 
			// repositoryItemComboBox_Day
			// 
			this.repositoryItemComboBox_Day.BeepOnError = true;
			this.repositoryItemComboBox_Day.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemComboBox_Day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
			this.repositoryItemComboBox_Day.Name = "repositoryItemComboBox_Day";
			this.repositoryItemComboBox_Day.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// colAM_In
			// 
			this.colAM_In.ColumnEdit = this.repositoryItemTimeSpanEdit;
			this.colAM_In.FieldName = "AM_In";
			this.colAM_In.Name = "colAM_In";
			this.colAM_In.Visible = true;
			this.colAM_In.VisibleIndex = 2;
			// 
			// repositoryItemTimeSpanEdit
			// 
			this.repositoryItemTimeSpanEdit.AutoHeight = false;
			this.repositoryItemTimeSpanEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemTimeSpanEdit.Name = "repositoryItemTimeSpanEdit";
			// 
			// colAM_Out
			// 
			this.colAM_Out.ColumnEdit = this.repositoryItemTimeSpanEdit;
			this.colAM_Out.FieldName = "AM_Out";
			this.colAM_Out.Name = "colAM_Out";
			this.colAM_Out.Visible = true;
			this.colAM_Out.VisibleIndex = 3;
			// 
			// colPM_In
			// 
			this.colPM_In.ColumnEdit = this.repositoryItemTimeSpanEdit;
			this.colPM_In.FieldName = "PM_In";
			this.colPM_In.Name = "colPM_In";
			this.colPM_In.Visible = true;
			this.colPM_In.VisibleIndex = 4;
			// 
			// colPM_Out
			// 
			this.colPM_Out.ColumnEdit = this.repositoryItemTimeSpanEdit;
			this.colPM_Out.FieldName = "PM_Out";
			this.colPM_Out.Name = "colPM_Out";
			this.colPM_Out.Visible = true;
			this.colPM_Out.VisibleIndex = 5;
			// 
			// colDescription_Schedule
			// 
			this.colDescription_Schedule.FieldName = "Schedule_Description";
			this.colDescription_Schedule.Name = "colDescription_Schedule";
			this.colDescription_Schedule.Visible = true;
			this.colDescription_Schedule.VisibleIndex = 6;
			// 
			// colNotes_Schedule
			// 
			this.colNotes_Schedule.FieldName = "Notes";
			this.colNotes_Schedule.Name = "colNotes_Schedule";
			this.colNotes_Schedule.Visible = true;
			this.colNotes_Schedule.VisibleIndex = 7;
			// 
			// frm_Schedule_Types
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 568);
			this.Controls.Add(this.gridControl);
			this.Controls.Add(this.dockPanel3);
			this.Controls.Add(this.DockPanel1);
			this.Controls.Add(this.DockPanel2);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frm_Schedule_Types";
			this.Text = "Employees";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Schedule_Types_FormClosing);
			this.Load += new System.EventHandler(this.frm_Schedule_Types_Load);
			this.Shown += new System.EventHandler(this.frm_Schedule_Types_Shown);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).EndInit();
			this.DockPanel2.ResumeLayout(false);
			this.DockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.DockPanel1.ResumeLayout(false);
			this.DockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl)).EndInit();
			this.PanelControl.ResumeLayout(false);
			this.dockPanel3.ResumeLayout(false);
			this.dockPanel3_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Schedule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Schedule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_Day)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        internal DevExpress.XtraBars.Docking.DockManager DockManager;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel2;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel2_Container;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel1;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
        internal DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarManager barManager;
        internal DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Preview;
        private DevExpress.XtraBars.BarButtonItem btn_New;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Close;
        internal DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Initialize;
        internal DevExpress.XtraBars.BarEditItem BarEditItem_Search;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl RepositoryItemSearchControl_Search;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal DevExpress.XtraEditors.PanelControl PanelControl;
        internal DevExpress.XtraGrid.Columns.GridColumn colID;
        internal DevExpress.XtraGrid.Columns.GridColumn colSchedule_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colSchedule_Name;
        internal DevExpress.XtraGrid.Columns.GridColumn colSchedule_Description;
        internal DevExpress.XtraGrid.Columns.GridColumn colNotes;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        internal Controls.xuc_Schedule_Type xuc_Schedule_Type;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraGrid.Columns.GridColumn colSchedule_Status;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
		private DevExpress.XtraGrid.GridControl gridControl_Schedule;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView_Schedule;
		private DevExpress.XtraGrid.Columns.GridColumn colWeek_Day;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_Day;
		private DevExpress.XtraGrid.Columns.GridColumn colAM_In;
		private DevExpress.XtraGrid.Columns.GridColumn colAM_Out;
		private DevExpress.XtraGrid.Columns.GridColumn colPM_In;
		private DevExpress.XtraGrid.Columns.GridColumn colPM_Out;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription_Schedule;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes_Schedule;
		private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit;
		private DevExpress.XtraGrid.Columns.GridColumn colID_Schedule;
	}
}