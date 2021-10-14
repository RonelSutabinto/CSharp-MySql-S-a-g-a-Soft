using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Forms
{
    [DesignerGenerated()]
    public partial class frm_Pay_Checks : DevExpress.XtraEditors.XtraForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayroll_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorporation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayroll_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayroll_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdded_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdded_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this._RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
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
            this.xuc_Payroll = new SagaHR.Controls.xuc_Payroll();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._RepositoryItemSearchControl_Search)).BeginInit();
            this.DockPanel2.SuspendLayout();
            this.DockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            this.DockPanel1.SuspendLayout();
            this.DockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl)).BeginInit();
            this.PanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(300, 20);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit_Branch});
            this.gridControl.Size = new System.Drawing.Size(313, 466);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPayroll_Code,
            this.colCorporation,
            this.colBranch_Code,
            this.colDate_Start,
            this.colDate_End,
            this.colPayroll_Name,
            this.colPayroll_Description,
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
            // colPayroll_Code
            // 
            this.colPayroll_Code.Caption = "Code";
            this.colPayroll_Code.FieldName = "Payroll_Code";
            this.colPayroll_Code.Name = "colPayroll_Code";
            this.colPayroll_Code.Visible = true;
            this.colPayroll_Code.VisibleIndex = 1;
            // 
            // colCorporation
            // 
            this.colCorporation.FieldName = "Corporation";
            this.colCorporation.Name = "colCorporation";
            this.colCorporation.Visible = true;
            this.colCorporation.VisibleIndex = 2;
            // 
            // colBranch_Code
            // 
            this.colBranch_Code.Caption = "Branch";
            this.colBranch_Code.FieldName = "Employee_Code";
            this.colBranch_Code.Name = "colBranch_Code";
            this.colBranch_Code.Visible = true;
            this.colBranch_Code.VisibleIndex = 3;
            // 
            // colDate_Start
            // 
            this.colDate_Start.FieldName = "Date_Start";
            this.colDate_Start.Name = "colDate_Start";
            this.colDate_Start.Visible = true;
            this.colDate_Start.VisibleIndex = 4;
            // 
            // colDate_End
            // 
            this.colDate_End.FieldName = "Date_End";
            this.colDate_End.Name = "colDate_End";
            this.colDate_End.Visible = true;
            this.colDate_End.VisibleIndex = 5;
            // 
            // colPayroll_Name
            // 
            this.colPayroll_Name.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPayroll_Name.FieldName = "Payroll_Name";
            this.colPayroll_Name.Name = "colPayroll_Name";
            this.colPayroll_Name.Visible = true;
            this.colPayroll_Name.VisibleIndex = 6;
            // 
            // colPayroll_Description
            // 
            this.colPayroll_Description.Caption = "Description";
            this.colPayroll_Description.FieldName = "Payroll_Description";
            this.colPayroll_Description.Name = "colPayroll_Description";
            this.colPayroll_Description.Visible = true;
            this.colPayroll_Description.VisibleIndex = 7;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 8;
            // 
            // colAdded_By
            // 
            this.colAdded_By.FieldName = "Added_By";
            this.colAdded_By.Name = "colAdded_By";
            this.colAdded_By.Visible = true;
            this.colAdded_By.VisibleIndex = 9;
            // 
            // colAdded_Date
            // 
            this.colAdded_Date.FieldName = "Added_Date";
            this.colAdded_Date.Name = "colAdded_Date";
            this.colAdded_Date.Visible = true;
            this.colAdded_Date.VisibleIndex = 10;
            // 
            // colModified_By
            // 
            this.colModified_By.FieldName = "Modified_By";
            this.colModified_By.Name = "colModified_By";
            this.colModified_By.Visible = true;
            this.colModified_By.VisibleIndex = 11;
            // 
            // colModified_Date
            // 
            this.colModified_Date.FieldName = "Modified_Date";
            this.colModified_Date.Name = "colModified_Date";
            this.colModified_Date.Visible = true;
            this.colModified_Date.VisibleIndex = 12;
            // 
            // RepositoryItemLookUpEdit_Branch
            // 
            this.RepositoryItemLookUpEdit_Branch.AutoHeight = false;
            this.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch";
            // 
            // DockManager
            // 
            this.DockManager.Form = this;
            this.DockManager.MenuManager = this.barManager;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel2,
            this.DockPanel1});
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
            this._RepositoryItemSearchControl_Search});
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
            this.BarEditItem_Search.Edit = this._RepositoryItemSearchControl_Search;
            this.BarEditItem_Search.Id = 9;
            this.BarEditItem_Search.ImageOptions.ImageIndex = 7;
            this.BarEditItem_Search.ImageOptions.LargeImageIndex = 7;
            this.BarEditItem_Search.Name = "BarEditItem_Search";
            // 
            // _RepositoryItemSearchControl_Search
            // 
            this._RepositoryItemSearchControl_Search.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this._RepositoryItemSearchControl_Search.Name = "_RepositoryItemSearchControl_Search";
            this._RepositoryItemSearchControl_Search.ShowClearButton = false;
            this._RepositoryItemSearchControl_Search.ShowSearchButton = false;
            this._RepositoryItemSearchControl_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RepositoryItemSearchControl_Search_KeyDown);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(893, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(893, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(893, 20);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // DockPanel2
            // 
            this.DockPanel2.Controls.Add(this.DockPanel2_Container);
            this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DockPanel2.ID = new System.Guid("0bdaaf02-be17-4771-a971-fe3cc7c6e8b6");
            this.DockPanel2.Location = new System.Drawing.Point(613, 20);
            this.DockPanel2.Name = "DockPanel2";
            this.DockPanel2.OriginalSize = new System.Drawing.Size(280, 200);
            this.DockPanel2.Size = new System.Drawing.Size(280, 466);
            this.DockPanel2.Text = "Settings";
            // 
            // DockPanel2_Container
            // 
            this.DockPanel2_Container.Controls.Add(this.PanelControl1);
            this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
            this.DockPanel2_Container.Name = "DockPanel2_Container";
            this.DockPanel2_Container.Size = new System.Drawing.Size(273, 437);
            this.DockPanel2_Container.TabIndex = 0;
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.xuc_Settings);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(273, 437);
            this.PanelControl1.TabIndex = 0;
            // 
            // xuc_Settings
            // 
            this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Settings.Location = new System.Drawing.Point(2, 2);
            this.xuc_Settings.MinimumSize = new System.Drawing.Size(270, 0);
            this.xuc_Settings.Name = "xuc_Settings";
            this.xuc_Settings.Size = new System.Drawing.Size(270, 433);
            this.xuc_Settings.TabIndex = 0;
            // 
            // DockPanel1
            // 
            this.DockPanel1.Controls.Add(this.DockPanel1_Container);
            this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.DockPanel1.ID = new System.Guid("bb3d47b8-c719-45f7-aee3-8d7fe50f1b0a");
            this.DockPanel1.Location = new System.Drawing.Point(0, 20);
            this.DockPanel1.Name = "DockPanel1";
            this.DockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
            this.DockPanel1.Size = new System.Drawing.Size(300, 466);
            this.DockPanel1.Text = "Information";
            // 
            // DockPanel1_Container
            // 
            this.DockPanel1_Container.Controls.Add(this.PanelControl);
            this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.DockPanel1_Container.Name = "DockPanel1_Container";
            this.DockPanel1_Container.Size = new System.Drawing.Size(293, 437);
            this.DockPanel1_Container.TabIndex = 0;
            // 
            // PanelControl
            // 
            this.PanelControl.Controls.Add(this.xuc_Payroll);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(293, 437);
            this.PanelControl.TabIndex = 0;
            // 
            // xuc_Payroll
            // 
            this.xuc_Payroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Payroll.Location = new System.Drawing.Point(2, 2);
            this.xuc_Payroll.Name = "xuc_Payroll";
            this.xuc_Payroll.Size = new System.Drawing.Size(289, 433);
            this.xuc_Payroll.TabIndex = 0;
            // 
            // frm_Pay_Checks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 486);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.DockPanel1);
            this.Controls.Add(this.DockPanel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Pay_Checks";
            this.Text = "Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Pay_Checks_FormClosing);
            this.Load += new System.EventHandler(this.frm_Pay_Checks_Load);
            this.Shown += new System.EventHandler(this.frm_Pay_Checks_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._RepositoryItemSearchControl_Search)).EndInit();
            this.DockPanel2.ResumeLayout(false);
            this.DockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.DockPanel1.ResumeLayout(false);
            this.DockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl)).EndInit();
            this.PanelControl.ResumeLayout(false);
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl _RepositoryItemSearchControl_Search;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal DevExpress.XtraEditors.PanelControl PanelControl;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit_Branch;
        internal DevExpress.XtraGrid.Columns.GridColumn colID;
        internal DevExpress.XtraGrid.Columns.GridColumn colPayroll_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colPayroll_Name;
        internal DevExpress.XtraGrid.Columns.GridColumn colPayroll_Description;
        internal DevExpress.XtraGrid.Columns.GridColumn colNotes;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        internal Controls.xuc_Payroll xuc_Payroll;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraGrid.Columns.GridColumn colBranch_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCorporation;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_End;
    }
}