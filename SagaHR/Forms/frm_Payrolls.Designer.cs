using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Forms
{
    [DesignerGenerated()]
    public partial class frm_Payrolls : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Payrolls));
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPayroll_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCorporation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Corporation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colBranch_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colPay_Day = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemtoggle_Pay_Day = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
			this.colDate_Start = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDate_End = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPay_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPayroll_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPayroll_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal_Pay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal_Additionals = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal_Deductions = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal_Net_Pay = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.btn_Generate = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
			this._RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btn_Save_Adjustments = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Delete_Adjustments = new DevExpress.XtraBars.BarButtonItem();
			this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
			this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Payroll = new SagaHR.Controls.xuc_Payroll();
			this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.gridControl_Employees = new DevExpress.XtraGrid.GridControl();
			this.gridView_Employees = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID_Employee = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Employee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSalary_Category = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalary_Type = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalary_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.gridControl_Adjustments = new DevExpress.XtraGrid.GridControl();
			this.gridView_Adjustments = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.col_ID_Adjustment = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdjust_Category = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdjust_Type = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdjust_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemLookUpEdit_Adjustment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCalcEdit_Amount = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
			this.colAdjust_Description = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdjust_Notes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenu_Employee = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenu_Adjustment = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Corporation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Branch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemtoggle_Pay_Day)).BeginInit();
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
			this.panelContainer1.SuspendLayout();
			this.dockPanel3.SuspendLayout();
			this.dockPanel3_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Employees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Employee)).BeginInit();
			this.dockPanel4.SuspendLayout();
			this.dockPanel4_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Adjustments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Adjustments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Adjustment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit_Amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Employee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Adjustment)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl
			// 
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(300, 20);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_Branch,
            this.repositoryItemLookUpEdit_Corporation,
            this.repositoryItemtoggle_Pay_Day});
			this.gridControl.Size = new System.Drawing.Size(618, 297);
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
            this.colPay_Day,
            this.colDate_Start,
            this.colDate_End,
            this.colPay_Date,
            this.colPayroll_Name,
            this.colPayroll_Description,
            this.colNotes,
            this.colTotal_Pay,
            this.colTotal_Additionals,
            this.colTotal_Deductions,
            this.colTotal_Net_Pay,
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
			this.colCorporation.ColumnEdit = this.repositoryItemLookUpEdit_Corporation;
			this.colCorporation.FieldName = "Corporation";
			this.colCorporation.Name = "colCorporation";
			this.colCorporation.Visible = true;
			this.colCorporation.VisibleIndex = 2;
			// 
			// repositoryItemLookUpEdit_Corporation
			// 
			this.repositoryItemLookUpEdit_Corporation.AutoHeight = false;
			this.repositoryItemLookUpEdit_Corporation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Corporation.Name = "repositoryItemLookUpEdit_Corporation";
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
			// colPay_Day
			// 
			this.colPay_Day.ColumnEdit = this.repositoryItemtoggle_Pay_Day;
			this.colPay_Day.FieldName = "Pay_Day";
			this.colPay_Day.Name = "colPay_Day";
			this.colPay_Day.Visible = true;
			this.colPay_Day.VisibleIndex = 4;
			// 
			// repositoryItemtoggle_Pay_Day
			// 
			this.repositoryItemtoggle_Pay_Day.AutoHeight = false;
			this.repositoryItemtoggle_Pay_Day.Name = "repositoryItemtoggle_Pay_Day";
			this.repositoryItemtoggle_Pay_Day.OffText = "15th";
			this.repositoryItemtoggle_Pay_Day.OnText = "30th";
			// 
			// colDate_Start
			// 
			this.colDate_Start.FieldName = "Date_Start";
			this.colDate_Start.Name = "colDate_Start";
			this.colDate_Start.Visible = true;
			this.colDate_Start.VisibleIndex = 5;
			// 
			// colDate_End
			// 
			this.colDate_End.FieldName = "Date_End";
			this.colDate_End.Name = "colDate_End";
			this.colDate_End.Visible = true;
			this.colDate_End.VisibleIndex = 6;
			// 
			// colPay_Date
			// 
			this.colPay_Date.FieldName = "Pay_Date";
			this.colPay_Date.Name = "colPay_Date";
			this.colPay_Date.Visible = true;
			this.colPay_Date.VisibleIndex = 7;
			// 
			// colPayroll_Name
			// 
			this.colPayroll_Name.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPayroll_Name.FieldName = "Payroll_Name";
			this.colPayroll_Name.Name = "colPayroll_Name";
			this.colPayroll_Name.Visible = true;
			this.colPayroll_Name.VisibleIndex = 8;
			// 
			// colPayroll_Description
			// 
			this.colPayroll_Description.Caption = "Description";
			this.colPayroll_Description.FieldName = "Payroll_Description";
			this.colPayroll_Description.Name = "colPayroll_Description";
			this.colPayroll_Description.Visible = true;
			this.colPayroll_Description.VisibleIndex = 9;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 10;
			// 
			// colTotal_Pay
			// 
			this.colTotal_Pay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal_Pay.FieldName = "Total_Pay";
			this.colTotal_Pay.Name = "colTotal_Pay";
			this.colTotal_Pay.Visible = true;
			this.colTotal_Pay.VisibleIndex = 11;
			// 
			// colTotal_Additionals
			// 
			this.colTotal_Additionals.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal_Additionals.FieldName = "Total_Additionals";
			this.colTotal_Additionals.Name = "colTotal_Additionals";
			this.colTotal_Additionals.Visible = true;
			this.colTotal_Additionals.VisibleIndex = 12;
			// 
			// colTotal_Deductions
			// 
			this.colTotal_Deductions.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal_Deductions.FieldName = "Total_Deductions";
			this.colTotal_Deductions.Name = "colTotal_Deductions";
			this.colTotal_Deductions.Visible = true;
			this.colTotal_Deductions.VisibleIndex = 13;
			// 
			// colTotal_Net_Pay
			// 
			this.colTotal_Net_Pay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal_Net_Pay.FieldName = "Total_Net_Pay";
			this.colTotal_Net_Pay.Name = "colTotal_Net_Pay";
			this.colTotal_Net_Pay.Visible = true;
			this.colTotal_Net_Pay.VisibleIndex = 14;
			// 
			// colAdded_By
			// 
			this.colAdded_By.FieldName = "Added_By";
			this.colAdded_By.Name = "colAdded_By";
			this.colAdded_By.Visible = true;
			this.colAdded_By.VisibleIndex = 15;
			// 
			// colAdded_Date
			// 
			this.colAdded_Date.FieldName = "Added_Date";
			this.colAdded_Date.Name = "colAdded_Date";
			this.colAdded_Date.Visible = true;
			this.colAdded_Date.VisibleIndex = 16;
			// 
			// colModified_By
			// 
			this.colModified_By.FieldName = "Modified_By";
			this.colModified_By.Name = "colModified_By";
			this.colModified_By.Visible = true;
			this.colModified_By.VisibleIndex = 17;
			// 
			// colModified_Date
			// 
			this.colModified_Date.FieldName = "Modified_Date";
			this.colModified_Date.Name = "colModified_Date";
			this.colModified_Date.Visible = true;
			this.colModified_Date.VisibleIndex = 18;
			// 
			// DockManager
			// 
			this.DockManager.DockingOptions.ShowCloseButton = false;
			this.DockManager.Form = this;
			this.DockManager.MenuManager = this.barManager;
			this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DockPanel2,
            this.DockPanel1,
            this.panelContainer1});
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
            this.BarEditItem_Search,
            this.btn_Generate,
            this.btn_Save_Adjustments,
            this.btn_Delete_Adjustments});
			this.barManager.MaxItemId = 16;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Generate),
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
			// btn_Generate
			// 
			this.btn_Generate.Caption = "Generate";
			this.btn_Generate.Id = 13;
			this.btn_Generate.Name = "btn_Generate";
			this.btn_Generate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Generate_ItemClick);
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
			this.barDockControlTop.Size = new System.Drawing.Size(1198, 20);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 668);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(1198, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 648);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1198, 20);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 648);
			// 
			// btn_Save_Adjustments
			// 
			this.btn_Save_Adjustments.Caption = "Save Adjustments";
			this.btn_Save_Adjustments.Id = 14;
			this.btn_Save_Adjustments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_Adjustments.ImageOptions.Image")));
			this.btn_Save_Adjustments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Save_Adjustments.ImageOptions.LargeImage")));
			this.btn_Save_Adjustments.Name = "btn_Save_Adjustments";
			this.btn_Save_Adjustments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_Adjustments_ItemClick);
			// 
			// btn_Delete_Adjustments
			// 
			this.btn_Delete_Adjustments.Caption = "Delete Adjustments";
			this.btn_Delete_Adjustments.Id = 15;
			this.btn_Delete_Adjustments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Adjustments.ImageOptions.Image")));
			this.btn_Delete_Adjustments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Adjustments.ImageOptions.LargeImage")));
			this.btn_Delete_Adjustments.Name = "btn_Delete_Adjustments";
			this.btn_Delete_Adjustments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_Adjustments_ItemClick);
			// 
			// DockPanel2
			// 
			this.DockPanel2.Controls.Add(this.DockPanel2_Container);
			this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.DockPanel2.ID = new System.Guid("0bdaaf02-be17-4771-a971-fe3cc7c6e8b6");
			this.DockPanel2.Location = new System.Drawing.Point(918, 20);
			this.DockPanel2.Name = "DockPanel2";
			this.DockPanel2.OriginalSize = new System.Drawing.Size(280, 200);
			this.DockPanel2.Size = new System.Drawing.Size(280, 648);
			this.DockPanel2.Text = "Settings";
			// 
			// DockPanel2_Container
			// 
			this.DockPanel2_Container.Controls.Add(this.PanelControl1);
			this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
			this.DockPanel2_Container.Name = "DockPanel2_Container";
			this.DockPanel2_Container.Size = new System.Drawing.Size(273, 619);
			this.DockPanel2_Container.TabIndex = 0;
			// 
			// PanelControl1
			// 
			this.PanelControl1.Controls.Add(this.xuc_Settings);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(273, 619);
			this.PanelControl1.TabIndex = 0;
			// 
			// xuc_Settings
			// 
			this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Settings.Location = new System.Drawing.Point(2, 2);
			this.xuc_Settings.MinimumSize = new System.Drawing.Size(270, 0);
			this.xuc_Settings.Name = "xuc_Settings";
			this.xuc_Settings.Size = new System.Drawing.Size(270, 615);
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
			this.DockPanel1.Size = new System.Drawing.Size(300, 648);
			this.DockPanel1.Text = "Information";
			// 
			// DockPanel1_Container
			// 
			this.DockPanel1_Container.Controls.Add(this.PanelControl);
			this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
			this.DockPanel1_Container.Name = "DockPanel1_Container";
			this.DockPanel1_Container.Size = new System.Drawing.Size(293, 619);
			this.DockPanel1_Container.TabIndex = 0;
			// 
			// PanelControl
			// 
			this.PanelControl.Controls.Add(this.xuc_Payroll);
			this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl.Location = new System.Drawing.Point(0, 0);
			this.PanelControl.Name = "PanelControl";
			this.PanelControl.Size = new System.Drawing.Size(293, 619);
			this.PanelControl.TabIndex = 0;
			// 
			// xuc_Payroll
			// 
			this.xuc_Payroll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Payroll.Location = new System.Drawing.Point(2, 2);
			this.xuc_Payroll.Name = "xuc_Payroll";
			this.xuc_Payroll.Size = new System.Drawing.Size(289, 615);
			this.xuc_Payroll.TabIndex = 0;
			// 
			// panelContainer1
			// 
			this.panelContainer1.Controls.Add(this.dockPanel3);
			this.panelContainer1.Controls.Add(this.dockPanel4);
			this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
			this.panelContainer1.FloatVertical = true;
			this.panelContainer1.ID = new System.Guid("249ddeb7-3209-4bdf-9ffd-892a7f088880");
			this.panelContainer1.Location = new System.Drawing.Point(300, 317);
			this.panelContainer1.Name = "panelContainer1";
			this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 351);
			this.panelContainer1.Size = new System.Drawing.Size(618, 351);
			this.panelContainer1.Text = "panelContainer1";
			// 
			// dockPanel3
			// 
			this.dockPanel3.Controls.Add(this.dockPanel3_Container);
			this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
			this.dockPanel3.FloatVertical = true;
			this.dockPanel3.ID = new System.Guid("ef911903-dfe4-407c-a542-30fc9dcaa46e");
			this.dockPanel3.Location = new System.Drawing.Point(0, 0);
			this.dockPanel3.Name = "dockPanel3";
			this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
			this.dockPanel3.Size = new System.Drawing.Size(309, 351);
			this.dockPanel3.Text = "Employees";
			// 
			// dockPanel3_Container
			// 
			this.dockPanel3_Container.Controls.Add(this.gridControl_Employees);
			this.dockPanel3_Container.Location = new System.Drawing.Point(3, 27);
			this.dockPanel3_Container.Name = "dockPanel3_Container";
			this.dockPanel3_Container.Size = new System.Drawing.Size(302, 321);
			this.dockPanel3_Container.TabIndex = 0;
			// 
			// gridControl_Employees
			// 
			this.gridControl_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl_Employees.Location = new System.Drawing.Point(0, 0);
			this.gridControl_Employees.MainView = this.gridView_Employees;
			this.gridControl_Employees.Name = "gridControl_Employees";
			this.gridControl_Employees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_Employee});
			this.gridControl_Employees.Size = new System.Drawing.Size(302, 321);
			this.gridControl_Employees.TabIndex = 9;
			this.gridControl_Employees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Employees});
			// 
			// gridView_Employees
			// 
			this.gridView_Employees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Employee,
            this.colEmployee_Code,
            this.colSalary_Category,
            this.colSalary_Type,
            this.colSalary,
            this.colSalary_Description});
			this.gridView_Employees.GridControl = this.gridControl_Employees;
			this.gridView_Employees.Name = "gridView_Employees";
			this.gridView_Employees.OptionsView.ColumnAutoWidth = false;
			this.gridView_Employees.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Employees_FocusedRowChanged);
			this.gridView_Employees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView_Employees_MouseDown);
			// 
			// colID_Employee
			// 
			this.colID_Employee.Caption = "ID";
			this.colID_Employee.FieldName = "ID";
			this.colID_Employee.Name = "colID_Employee";
			this.colID_Employee.Visible = true;
			this.colID_Employee.VisibleIndex = 0;
			// 
			// colEmployee_Code
			// 
			this.colEmployee_Code.Caption = "Employee";
			this.colEmployee_Code.ColumnEdit = this.repositoryItemLookUpEdit_Employee;
			this.colEmployee_Code.FieldName = "Employee_Code";
			this.colEmployee_Code.Name = "colEmployee_Code";
			this.colEmployee_Code.Visible = true;
			this.colEmployee_Code.VisibleIndex = 1;
			// 
			// repositoryItemLookUpEdit_Employee
			// 
			this.repositoryItemLookUpEdit_Employee.AutoHeight = false;
			this.repositoryItemLookUpEdit_Employee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Employee.Name = "repositoryItemLookUpEdit_Employee";
			// 
			// colSalary_Category
			// 
			this.colSalary_Category.Caption = "Category";
			this.colSalary_Category.FieldName = "Salary_Category";
			this.colSalary_Category.Name = "colSalary_Category";
			this.colSalary_Category.Visible = true;
			this.colSalary_Category.VisibleIndex = 2;
			// 
			// colSalary_Type
			// 
			this.colSalary_Type.Caption = "Type";
			this.colSalary_Type.FieldName = "Salary_Type";
			this.colSalary_Type.Name = "colSalary_Type";
			this.colSalary_Type.Visible = true;
			this.colSalary_Type.VisibleIndex = 3;
			// 
			// colSalary
			// 
			this.colSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSalary.FieldName = "Salary";
			this.colSalary.Name = "colSalary";
			this.colSalary.Visible = true;
			this.colSalary.VisibleIndex = 4;
			// 
			// colSalary_Description
			// 
			this.colSalary_Description.Caption = "Description";
			this.colSalary_Description.FieldName = "Salary_Description";
			this.colSalary_Description.Name = "colSalary_Description";
			this.colSalary_Description.Visible = true;
			this.colSalary_Description.VisibleIndex = 5;
			// 
			// dockPanel4
			// 
			this.dockPanel4.Controls.Add(this.dockPanel4_Container);
			this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
			this.dockPanel4.FloatVertical = true;
			this.dockPanel4.ID = new System.Guid("951aa2a2-2a1a-4451-964f-5e104c2c6e23");
			this.dockPanel4.Location = new System.Drawing.Point(309, 0);
			this.dockPanel4.Name = "dockPanel4";
			this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
			this.dockPanel4.Size = new System.Drawing.Size(309, 351);
			this.dockPanel4.Text = "Adjustments";
			// 
			// dockPanel4_Container
			// 
			this.dockPanel4_Container.Controls.Add(this.gridControl_Adjustments);
			this.dockPanel4_Container.Location = new System.Drawing.Point(3, 27);
			this.dockPanel4_Container.Name = "dockPanel4_Container";
			this.dockPanel4_Container.Size = new System.Drawing.Size(303, 321);
			this.dockPanel4_Container.TabIndex = 0;
			// 
			// gridControl_Adjustments
			// 
			this.gridControl_Adjustments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl_Adjustments.Location = new System.Drawing.Point(0, 0);
			this.gridControl_Adjustments.MainView = this.gridView_Adjustments;
			this.gridControl_Adjustments.Name = "gridControl_Adjustments";
			this.gridControl_Adjustments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit_Amount,
            this.repositoryItemLookUpEdit_Adjustment});
			this.gridControl_Adjustments.Size = new System.Drawing.Size(303, 321);
			this.gridControl_Adjustments.TabIndex = 1;
			this.gridControl_Adjustments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Adjustments});
			// 
			// gridView_Adjustments
			// 
			this.gridView_Adjustments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID_Adjustment,
            this.colAdjust_Category,
            this.colAdjust_Type,
            this.colAdjust_Code,
            this.colAmount,
            this.colAdjust_Description,
            this.colAdjust_Notes});
			this.gridView_Adjustments.GridControl = this.gridControl_Adjustments;
			this.gridView_Adjustments.Name = "gridView_Adjustments";
			this.gridView_Adjustments.OptionsView.ColumnAutoWidth = false;
			this.gridView_Adjustments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Adjustments_KeyDown);
			this.gridView_Adjustments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView_Adjustments_MouseDown);
			// 
			// col_ID_Adjustment
			// 
			this.col_ID_Adjustment.Caption = "ID";
			this.col_ID_Adjustment.FieldName = "ID";
			this.col_ID_Adjustment.Name = "col_ID_Adjustment";
			this.col_ID_Adjustment.OptionsColumn.AllowEdit = false;
			this.col_ID_Adjustment.Visible = true;
			this.col_ID_Adjustment.VisibleIndex = 0;
			// 
			// colAdjust_Category
			// 
			this.colAdjust_Category.Caption = "Category";
			this.colAdjust_Category.FieldName = "Adjust_Category";
			this.colAdjust_Category.Name = "colAdjust_Category";
			this.colAdjust_Category.OptionsColumn.AllowEdit = false;
			this.colAdjust_Category.Visible = true;
			this.colAdjust_Category.VisibleIndex = 1;
			// 
			// colAdjust_Type
			// 
			this.colAdjust_Type.Caption = "Type";
			this.colAdjust_Type.FieldName = "Adjust_Type";
			this.colAdjust_Type.Name = "colAdjust_Type";
			this.colAdjust_Type.OptionsColumn.AllowEdit = false;
			this.colAdjust_Type.Visible = true;
			this.colAdjust_Type.VisibleIndex = 2;
			// 
			// colAdjust_Code
			// 
			this.colAdjust_Code.Caption = "Name";
			this.colAdjust_Code.ColumnEdit = this.repositoryItemLookUpEdit_Adjustment;
			this.colAdjust_Code.FieldName = "Adjust_Code";
			this.colAdjust_Code.Name = "colAdjust_Code";
			this.colAdjust_Code.Visible = true;
			this.colAdjust_Code.VisibleIndex = 3;
			// 
			// repositoryItemLookUpEdit_Adjustment
			// 
			this.repositoryItemLookUpEdit_Adjustment.AutoHeight = false;
			this.repositoryItemLookUpEdit_Adjustment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit_Adjustment.Name = "repositoryItemLookUpEdit_Adjustment";
			this.repositoryItemLookUpEdit_Adjustment.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemLookUpEdit_Adjustment_Validating);
			// 
			// colAmount
			// 
			this.colAmount.ColumnEdit = this.repositoryItemCalcEdit_Amount;
			this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colAmount.FieldName = "Amount";
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 4;
			// 
			// repositoryItemCalcEdit_Amount
			// 
			this.repositoryItemCalcEdit_Amount.AutoHeight = false;
			this.repositoryItemCalcEdit_Amount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemCalcEdit_Amount.Name = "repositoryItemCalcEdit_Amount";
			// 
			// colAdjust_Description
			// 
			this.colAdjust_Description.FieldName = "Adjust_Description";
			this.colAdjust_Description.Name = "colAdjust_Description";
			this.colAdjust_Description.Visible = true;
			this.colAdjust_Description.VisibleIndex = 5;
			// 
			// colAdjust_Notes
			// 
			this.colAdjust_Notes.FieldName = "Notes";
			this.colAdjust_Notes.Name = "colAdjust_Notes";
			this.colAdjust_Notes.Visible = true;
			this.colAdjust_Notes.VisibleIndex = 6;
			// 
			// popupMenu
			// 
			this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Generate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.popupMenu.Manager = this.barManager;
			this.popupMenu.Name = "popupMenu";
			// 
			// popupMenu_Employee
			// 
			this.popupMenu_Employee.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Generate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.popupMenu_Employee.Manager = this.barManager;
			this.popupMenu_Employee.Name = "popupMenu_Employee";
			// 
			// popupMenu_Adjustment
			// 
			this.popupMenu_Adjustment.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_Adjustments),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete_Adjustments)});
			this.popupMenu_Adjustment.Manager = this.barManager;
			this.popupMenu_Adjustment.Name = "popupMenu_Adjustment";
			// 
			// frm_Payrolls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 668);
			this.Controls.Add(this.gridControl);
			this.Controls.Add(this.panelContainer1);
			this.Controls.Add(this.DockPanel1);
			this.Controls.Add(this.DockPanel2);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frm_Payrolls";
			this.Text = "Employees";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Payrolls_FormClosing);
			this.Load += new System.EventHandler(this.frm_Payrolls_Load);
			this.Shown += new System.EventHandler(this.frm_Payrolls_Shown);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Corporation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Branch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemtoggle_Pay_Day)).EndInit();
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
			this.panelContainer1.ResumeLayout(false);
			this.dockPanel3.ResumeLayout(false);
			this.dockPanel3_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Employees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Employee)).EndInit();
			this.dockPanel4.ResumeLayout(false);
			this.dockPanel4_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl_Adjustments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView_Adjustments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Adjustment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit_Amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Employee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Adjustment)).EndInit();
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
		private DevExpress.XtraGrid.Columns.GridColumn colTotal_Pay;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal_Additionals;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal_Deductions;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal_Net_Pay;
		private DevExpress.XtraGrid.Columns.GridColumn colPay_Day;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Branch;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Corporation;
		private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemtoggle_Pay_Day;
		private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
		private DevExpress.XtraBars.BarButtonItem btn_Generate;
		private DevExpress.XtraBars.PopupMenu popupMenu;
		internal DevExpress.XtraGrid.GridControl gridControl_Employees;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView_Employees;
		internal DevExpress.XtraGrid.Columns.GridColumn colID_Employee;
		internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Code;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Employee;
		private DevExpress.XtraGrid.Columns.GridColumn colSalary_Category;
		private DevExpress.XtraGrid.Columns.GridColumn colSalary_Type;
		internal DevExpress.XtraGrid.Columns.GridColumn colSalary;
		internal DevExpress.XtraGrid.Columns.GridColumn colSalary_Description;
		internal DevExpress.XtraGrid.GridControl gridControl_Adjustments;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView_Adjustments;
		internal DevExpress.XtraGrid.Columns.GridColumn col_ID_Adjustment;
		internal DevExpress.XtraGrid.Columns.GridColumn colAdjust_Category;
		internal DevExpress.XtraGrid.Columns.GridColumn colAdjust_Type;
		internal DevExpress.XtraGrid.Columns.GridColumn colAdjust_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colAdjust_Description;
		private DevExpress.XtraGrid.Columns.GridColumn colPay_Date;
		private DevExpress.XtraBars.PopupMenu popupMenu_Employee;
		private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit_Amount;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Adjustment;
		private DevExpress.XtraGrid.Columns.GridColumn colAdjust_Notes;
		private DevExpress.XtraBars.BarButtonItem btn_Save_Adjustments;
		private DevExpress.XtraBars.PopupMenu popupMenu_Adjustment;
		private DevExpress.XtraBars.BarButtonItem btn_Delete_Adjustments;
	}
}