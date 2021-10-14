using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Forms
{
    [DesignerGenerated()]
    public partial class frm_Employees : DevExpress.XtraEditors.XtraForm
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employees));
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployment_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Address = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Contact = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Date_Birth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Age = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Birth_Place = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Civil_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Corporation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Branch = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colEmployee_Department = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Position = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Pay_Level = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Pay_Class = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Date_Hired = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Date_Probationary = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Date_Regular = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Service_Length = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_TIN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_SSS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_PHIC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_PAG_IBIG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Attainment = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Course = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Name_Spouse = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Children = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Driver_License = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployee_Driver_License_Expiry = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEngine = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.btn_Update = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
			this._RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.btn_SMS = new DevExpress.XtraBars.BarButtonItem();
			this.bar_Payroll = new DevExpress.XtraBars.Bar();
			this.barEditItem_Payroll = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemLookUpEdit_Payroll = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.btn_Generate_Paychecks = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btn_Setup_Salary = new DevExpress.XtraBars.BarButtonItem();
			this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
			this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.PanelControl = new DevExpress.XtraEditors.PanelControl();
			this.xuc_Employee = new SagaHR.Controls.xuc_Employee();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._RepositoryItemSearchControl_Search)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Payroll)).BeginInit();
			this.DockPanel2.SuspendLayout();
			this.DockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
			this.PanelControl1.SuspendLayout();
			this.DockPanel1.SuspendLayout();
			this.DockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl)).BeginInit();
			this.PanelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl
			// 
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(300, 45);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit_Branch});
			this.gridControl.Size = new System.Drawing.Size(311, 476);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployee_Code,
            this.colEmployment_Status,
            this.colEmployee_ID,
            this.colEmployee_Name,
            this.colEmployee_Address,
            this.colEmployee_Contact,
            this.colEmployee_Date_Birth,
            this.colEmployee_Age,
            this.colEmployee_Birth_Place,
            this.colEmployee_Civil_Status,
            this.colEmployee_Corporation,
            this.colEmployee_Branch,
            this.colEmployee_Department,
            this.colEmployee_Position,
            this.colEmployee_Pay_Level,
            this.colEmployee_Pay_Class,
            this.colEmployee_Status,
            this.colEmployee_Date_Hired,
            this.colEmployee_Date_Probationary,
            this.colEmployee_Date_Regular,
            this.colEmployee_Service_Length,
            this.colEmployee_TIN,
            this.colEmployee_SSS,
            this.colEmployee_PHIC,
            this.colEmployee_PAG_IBIG,
            this.colEmployee_Attainment,
            this.colEmployee_Course,
            this.colEmployee_Name_Spouse,
            this.colEmployee_Children,
            this.colEmployee_Driver_License,
            this.colEmployee_Driver_License_Expiry,
            this.colEngine,
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
			// colEmployee_Code
			// 
			this.colEmployee_Code.Caption = "Code";
			this.colEmployee_Code.FieldName = "Employee_Code";
			this.colEmployee_Code.Name = "colEmployee_Code";
			this.colEmployee_Code.Visible = true;
			this.colEmployee_Code.VisibleIndex = 1;
			// 
			// colEmployment_Status
			// 
			this.colEmployment_Status.FieldName = "Employment_Status";
			this.colEmployment_Status.Name = "colEmployment_Status";
			this.colEmployment_Status.Visible = true;
			this.colEmployment_Status.VisibleIndex = 2;
			// 
			// colEmployee_ID
			// 
			this.colEmployee_ID.Caption = "ID #";
			this.colEmployee_ID.FieldName = "Employee_ID";
			this.colEmployee_ID.Name = "colEmployee_ID";
			this.colEmployee_ID.Visible = true;
			this.colEmployee_ID.VisibleIndex = 3;
			// 
			// colEmployee_Name
			// 
			this.colEmployee_Name.Caption = "Name";
			this.colEmployee_Name.FieldName = "Employee_Name";
			this.colEmployee_Name.Name = "colEmployee_Name";
			this.colEmployee_Name.Visible = true;
			this.colEmployee_Name.VisibleIndex = 4;
			// 
			// colEmployee_Address
			// 
			this.colEmployee_Address.Caption = "Address";
			this.colEmployee_Address.FieldName = "Employee_Address";
			this.colEmployee_Address.Name = "colEmployee_Address";
			this.colEmployee_Address.Visible = true;
			this.colEmployee_Address.VisibleIndex = 5;
			// 
			// colEmployee_Contact
			// 
			this.colEmployee_Contact.Caption = "Contact Number(s)";
			this.colEmployee_Contact.FieldName = "Employee_Contact";
			this.colEmployee_Contact.Name = "colEmployee_Contact";
			this.colEmployee_Contact.Visible = true;
			this.colEmployee_Contact.VisibleIndex = 6;
			// 
			// colEmployee_Date_Birth
			// 
			this.colEmployee_Date_Birth.Caption = "Birthdate";
			this.colEmployee_Date_Birth.FieldName = "Employee_Date_Birth";
			this.colEmployee_Date_Birth.Name = "colEmployee_Date_Birth";
			this.colEmployee_Date_Birth.Visible = true;
			this.colEmployee_Date_Birth.VisibleIndex = 7;
			// 
			// colEmployee_Age
			// 
			this.colEmployee_Age.Caption = "Age";
			this.colEmployee_Age.FieldName = "Employee_Age";
			this.colEmployee_Age.Name = "colEmployee_Age";
			this.colEmployee_Age.Visible = true;
			this.colEmployee_Age.VisibleIndex = 8;
			// 
			// colEmployee_Birth_Place
			// 
			this.colEmployee_Birth_Place.Caption = "Birthplace";
			this.colEmployee_Birth_Place.FieldName = "Employee_Birth_Place";
			this.colEmployee_Birth_Place.Name = "colEmployee_Birth_Place";
			this.colEmployee_Birth_Place.Visible = true;
			this.colEmployee_Birth_Place.VisibleIndex = 9;
			// 
			// colEmployee_Civil_Status
			// 
			this.colEmployee_Civil_Status.Caption = "Civil Status";
			this.colEmployee_Civil_Status.FieldName = "Employee_Civil_Status";
			this.colEmployee_Civil_Status.Name = "colEmployee_Civil_Status";
			this.colEmployee_Civil_Status.Visible = true;
			this.colEmployee_Civil_Status.VisibleIndex = 10;
			// 
			// colEmployee_Corporation
			// 
			this.colEmployee_Corporation.Caption = "Corporation";
			this.colEmployee_Corporation.FieldName = "Employee_Corporation";
			this.colEmployee_Corporation.Name = "colEmployee_Corporation";
			this.colEmployee_Corporation.Visible = true;
			this.colEmployee_Corporation.VisibleIndex = 11;
			// 
			// colEmployee_Branch
			// 
			this.colEmployee_Branch.Caption = "Branch";
			this.colEmployee_Branch.ColumnEdit = this.RepositoryItemLookUpEdit_Branch;
			this.colEmployee_Branch.FieldName = "Employee_Branch";
			this.colEmployee_Branch.Name = "colEmployee_Branch";
			this.colEmployee_Branch.Visible = true;
			this.colEmployee_Branch.VisibleIndex = 12;
			// 
			// RepositoryItemLookUpEdit_Branch
			// 
			this.RepositoryItemLookUpEdit_Branch.AutoHeight = false;
			this.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch";
			// 
			// colEmployee_Department
			// 
			this.colEmployee_Department.Caption = "Department";
			this.colEmployee_Department.FieldName = "Employee_Department";
			this.colEmployee_Department.Name = "colEmployee_Department";
			this.colEmployee_Department.Visible = true;
			this.colEmployee_Department.VisibleIndex = 13;
			// 
			// colEmployee_Position
			// 
			this.colEmployee_Position.Caption = "Position";
			this.colEmployee_Position.FieldName = "Employee_Position";
			this.colEmployee_Position.Name = "colEmployee_Position";
			this.colEmployee_Position.Visible = true;
			this.colEmployee_Position.VisibleIndex = 14;
			// 
			// colEmployee_Pay_Level
			// 
			this.colEmployee_Pay_Level.Caption = "Pay Level";
			this.colEmployee_Pay_Level.FieldName = "Employee_Pay_Level";
			this.colEmployee_Pay_Level.Name = "colEmployee_Pay_Level";
			this.colEmployee_Pay_Level.Visible = true;
			this.colEmployee_Pay_Level.VisibleIndex = 15;
			// 
			// colEmployee_Pay_Class
			// 
			this.colEmployee_Pay_Class.Caption = "Pay Classification";
			this.colEmployee_Pay_Class.FieldName = "Employee_Pay_Class";
			this.colEmployee_Pay_Class.Name = "colEmployee_Pay_Class";
			this.colEmployee_Pay_Class.Visible = true;
			this.colEmployee_Pay_Class.VisibleIndex = 16;
			// 
			// colEmployee_Status
			// 
			this.colEmployee_Status.FieldName = "Employee_Status";
			this.colEmployee_Status.Name = "colEmployee_Status";
			this.colEmployee_Status.Visible = true;
			this.colEmployee_Status.VisibleIndex = 17;
			// 
			// colEmployee_Date_Hired
			// 
			this.colEmployee_Date_Hired.Caption = "Date Hired";
			this.colEmployee_Date_Hired.FieldName = "Employee_Date_Hired";
			this.colEmployee_Date_Hired.Name = "colEmployee_Date_Hired";
			this.colEmployee_Date_Hired.Visible = true;
			this.colEmployee_Date_Hired.VisibleIndex = 18;
			// 
			// colEmployee_Date_Probationary
			// 
			this.colEmployee_Date_Probationary.Caption = "Probationary Date";
			this.colEmployee_Date_Probationary.FieldName = "Employee_Date_Probationary";
			this.colEmployee_Date_Probationary.Name = "colEmployee_Date_Probationary";
			this.colEmployee_Date_Probationary.Visible = true;
			this.colEmployee_Date_Probationary.VisibleIndex = 19;
			// 
			// colEmployee_Date_Regular
			// 
			this.colEmployee_Date_Regular.Caption = "Date Regularized";
			this.colEmployee_Date_Regular.FieldName = "Employee_Date_Regular";
			this.colEmployee_Date_Regular.Name = "colEmployee_Date_Regular";
			this.colEmployee_Date_Regular.Visible = true;
			this.colEmployee_Date_Regular.VisibleIndex = 20;
			// 
			// colEmployee_Service_Length
			// 
			this.colEmployee_Service_Length.Caption = "Length of Service";
			this.colEmployee_Service_Length.FieldName = "Employee_Service_Length";
			this.colEmployee_Service_Length.Name = "colEmployee_Service_Length";
			this.colEmployee_Service_Length.Visible = true;
			this.colEmployee_Service_Length.VisibleIndex = 21;
			// 
			// colEmployee_TIN
			// 
			this.colEmployee_TIN.Caption = "TIN";
			this.colEmployee_TIN.FieldName = "Employee_TIN";
			this.colEmployee_TIN.Name = "colEmployee_TIN";
			this.colEmployee_TIN.Visible = true;
			this.colEmployee_TIN.VisibleIndex = 22;
			// 
			// colEmployee_SSS
			// 
			this.colEmployee_SSS.Caption = "SSS";
			this.colEmployee_SSS.FieldName = "Employee_SSS";
			this.colEmployee_SSS.Name = "colEmployee_SSS";
			this.colEmployee_SSS.Visible = true;
			this.colEmployee_SSS.VisibleIndex = 23;
			// 
			// colEmployee_PHIC
			// 
			this.colEmployee_PHIC.Caption = "PHIC";
			this.colEmployee_PHIC.FieldName = "Employee_PHIC";
			this.colEmployee_PHIC.Name = "colEmployee_PHIC";
			this.colEmployee_PHIC.Visible = true;
			this.colEmployee_PHIC.VisibleIndex = 24;
			// 
			// colEmployee_PAG_IBIG
			// 
			this.colEmployee_PAG_IBIG.Caption = "PAG-IBIG";
			this.colEmployee_PAG_IBIG.FieldName = "Employee_PAG_IBIG";
			this.colEmployee_PAG_IBIG.Name = "colEmployee_PAG_IBIG";
			this.colEmployee_PAG_IBIG.Visible = true;
			this.colEmployee_PAG_IBIG.VisibleIndex = 25;
			// 
			// colEmployee_Attainment
			// 
			this.colEmployee_Attainment.Caption = "Higest Edcuational Attainment";
			this.colEmployee_Attainment.FieldName = "Employee_Attainment";
			this.colEmployee_Attainment.Name = "colEmployee_Attainment";
			this.colEmployee_Attainment.Visible = true;
			this.colEmployee_Attainment.VisibleIndex = 26;
			// 
			// colEmployee_Course
			// 
			this.colEmployee_Course.Caption = "Course / Technical Major";
			this.colEmployee_Course.FieldName = "Employee_Course";
			this.colEmployee_Course.Name = "colEmployee_Course";
			this.colEmployee_Course.Visible = true;
			this.colEmployee_Course.VisibleIndex = 27;
			// 
			// colEmployee_Name_Spouse
			// 
			this.colEmployee_Name_Spouse.Caption = "Spouse Name";
			this.colEmployee_Name_Spouse.FieldName = "Employee_Name_Spouse";
			this.colEmployee_Name_Spouse.Name = "colEmployee_Name_Spouse";
			this.colEmployee_Name_Spouse.Visible = true;
			this.colEmployee_Name_Spouse.VisibleIndex = 28;
			// 
			// colEmployee_Children
			// 
			this.colEmployee_Children.Caption = "Children";
			this.colEmployee_Children.FieldName = "Employee_Children";
			this.colEmployee_Children.Name = "colEmployee_Children";
			this.colEmployee_Children.Visible = true;
			this.colEmployee_Children.VisibleIndex = 29;
			// 
			// colEmployee_Driver_License
			// 
			this.colEmployee_Driver_License.Caption = "Driver\'s License";
			this.colEmployee_Driver_License.FieldName = "Employee_Driver_License";
			this.colEmployee_Driver_License.Name = "colEmployee_Driver_License";
			this.colEmployee_Driver_License.Visible = true;
			this.colEmployee_Driver_License.VisibleIndex = 30;
			// 
			// colEmployee_Driver_License_Expiry
			// 
			this.colEmployee_Driver_License_Expiry.Caption = "License Expiry";
			this.colEmployee_Driver_License_Expiry.FieldName = "Employee_Driver_License_Expiry";
			this.colEmployee_Driver_License_Expiry.Name = "colEmployee_Driver_License_Expiry";
			this.colEmployee_Driver_License_Expiry.Visible = true;
			this.colEmployee_Driver_License_Expiry.VisibleIndex = 31;
			// 
			// colEngine
			// 
			this.colEngine.FieldName = "Engine";
			this.colEngine.Name = "colEngine";
			this.colEngine.Visible = true;
			this.colEngine.VisibleIndex = 32;
			// 
			// colNotes
			// 
			this.colNotes.Caption = "Notes / Remarks";
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 33;
			// 
			// colAdded_By
			// 
			this.colAdded_By.FieldName = "Added_By";
			this.colAdded_By.Name = "colAdded_By";
			this.colAdded_By.Visible = true;
			this.colAdded_By.VisibleIndex = 34;
			// 
			// colAdded_Date
			// 
			this.colAdded_Date.FieldName = "Added_Date";
			this.colAdded_Date.Name = "colAdded_Date";
			this.colAdded_Date.Visible = true;
			this.colAdded_Date.VisibleIndex = 35;
			// 
			// colModified_By
			// 
			this.colModified_By.FieldName = "Modified_By";
			this.colModified_By.Name = "colModified_By";
			this.colModified_By.Visible = true;
			this.colModified_By.VisibleIndex = 36;
			// 
			// colModified_Date
			// 
			this.colModified_Date.FieldName = "Modified_Date";
			this.colModified_Date.Name = "colModified_Date";
			this.colModified_Date.Visible = true;
			this.colModified_Date.VisibleIndex = 37;
			// 
			// DockManager
			// 
			this.DockManager.DockingOptions.ShowCloseButton = false;
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
            this.bar2,
            this.Bar3,
            this.bar_Payroll});
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
            this.btn_Update,
            this.btn_SMS,
            this.btn_Setup_Salary,
            this.barEditItem_Payroll,
            this.btn_Generate_Paychecks});
			this.barManager.MaxItemId = 16;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._RepositoryItemSearchControl_Search,
            this.repositoryItemLookUpEdit_Payroll});
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 2;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.FloatLocation = new System.Drawing.Point(306, 170);
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Update),
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
			// btn_Update
			// 
			this.btn_Update.Caption = "Update";
			this.btn_Update.Id = 11;
			this.btn_Update.ImageOptions.ImageIndex = 8;
			this.btn_Update.ImageOptions.LargeImageIndex = 8;
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Update_ItemClick);
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
			this.bar2.DockCol = 1;
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
			// Bar3
			// 
			this.Bar3.BarName = "Custom 4";
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar3.FloatLocation = new System.Drawing.Point(179, 163);
			this.Bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_SMS)});
			this.Bar3.Text = "Custom 4";
			// 
			// btn_SMS
			// 
			this.btn_SMS.Caption = "Send SMS";
			this.btn_SMS.Id = 12;
			this.btn_SMS.Name = "btn_SMS";
			this.btn_SMS.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btn_SMS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SMS_ItemClick);
			// 
			// bar_Payroll
			// 
			this.bar_Payroll.BarName = "Payroll";
			this.bar_Payroll.DockCol = 0;
			this.bar_Payroll.DockRow = 1;
			this.bar_Payroll.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar_Payroll.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem_Payroll),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Generate_Paychecks)});
			this.bar_Payroll.Text = "Payroll";
			// 
			// barEditItem_Payroll
			// 
			this.barEditItem_Payroll.AutoFillWidth = true;
			this.barEditItem_Payroll.Caption = "Payroll";
			this.barEditItem_Payroll.Edit = this.repositoryItemLookUpEdit_Payroll;
			this.barEditItem_Payroll.Id = 14;
			this.barEditItem_Payroll.Name = "barEditItem_Payroll";
			// 
			// repositoryItemLookUpEdit_Payroll
			// 
			this.repositoryItemLookUpEdit_Payroll.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, true, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.repositoryItemLookUpEdit_Payroll.Name = "repositoryItemLookUpEdit_Payroll";
			// 
			// btn_Generate_Paychecks
			// 
			this.btn_Generate_Paychecks.Caption = "Generate Pay Checks";
			this.btn_Generate_Paychecks.Id = 15;
			this.btn_Generate_Paychecks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generate_Paychecks.ImageOptions.Image")));
			this.btn_Generate_Paychecks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Generate_Paychecks.ImageOptions.LargeImage")));
			this.btn_Generate_Paychecks.Name = "btn_Generate_Paychecks";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(891, 45);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(891, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 476);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(891, 45);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 476);
			// 
			// btn_Setup_Salary
			// 
			this.btn_Setup_Salary.Caption = "Setup Salary";
			this.btn_Setup_Salary.Id = 13;
			this.btn_Setup_Salary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setup_Salary.ImageOptions.Image")));
			this.btn_Setup_Salary.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Setup_Salary.ImageOptions.LargeImage")));
			this.btn_Setup_Salary.Name = "btn_Setup_Salary";
			this.btn_Setup_Salary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Setup_Salary_ItemClick);
			// 
			// DockPanel2
			// 
			this.DockPanel2.Controls.Add(this.DockPanel2_Container);
			this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.DockPanel2.ID = new System.Guid("0bdaaf02-be17-4771-a971-fe3cc7c6e8b6");
			this.DockPanel2.Location = new System.Drawing.Point(611, 45);
			this.DockPanel2.Name = "DockPanel2";
			this.DockPanel2.OriginalSize = new System.Drawing.Size(280, 200);
			this.DockPanel2.Size = new System.Drawing.Size(280, 476);
			this.DockPanel2.Text = "Settings";
			// 
			// DockPanel2_Container
			// 
			this.DockPanel2_Container.Controls.Add(this.PanelControl1);
			this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
			this.DockPanel2_Container.Name = "DockPanel2_Container";
			this.DockPanel2_Container.Size = new System.Drawing.Size(273, 447);
			this.DockPanel2_Container.TabIndex = 0;
			// 
			// PanelControl1
			// 
			this.PanelControl1.Controls.Add(this.xuc_Settings);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(273, 447);
			this.PanelControl1.TabIndex = 0;
			// 
			// xuc_Settings
			// 
			this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Settings.Location = new System.Drawing.Point(2, 2);
			this.xuc_Settings.MinimumSize = new System.Drawing.Size(270, 0);
			this.xuc_Settings.Name = "xuc_Settings";
			this.xuc_Settings.Size = new System.Drawing.Size(270, 443);
			this.xuc_Settings.TabIndex = 0;
			// 
			// DockPanel1
			// 
			this.DockPanel1.Controls.Add(this.DockPanel1_Container);
			this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.DockPanel1.ID = new System.Guid("bb3d47b8-c719-45f7-aee3-8d7fe50f1b0a");
			this.DockPanel1.Location = new System.Drawing.Point(0, 45);
			this.DockPanel1.Name = "DockPanel1";
			this.DockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
			this.DockPanel1.Size = new System.Drawing.Size(300, 476);
			this.DockPanel1.Text = "Information";
			// 
			// DockPanel1_Container
			// 
			this.DockPanel1_Container.Controls.Add(this.PanelControl);
			this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
			this.DockPanel1_Container.Name = "DockPanel1_Container";
			this.DockPanel1_Container.Size = new System.Drawing.Size(293, 447);
			this.DockPanel1_Container.TabIndex = 0;
			// 
			// PanelControl
			// 
			this.PanelControl.Controls.Add(this.xuc_Employee);
			this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl.Location = new System.Drawing.Point(0, 0);
			this.PanelControl.Name = "PanelControl";
			this.PanelControl.Size = new System.Drawing.Size(293, 447);
			this.PanelControl.TabIndex = 0;
			// 
			// xuc_Employee
			// 
			this.xuc_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Employee.Location = new System.Drawing.Point(2, 2);
			this.xuc_Employee.Name = "xuc_Employee";
			this.xuc_Employee.Size = new System.Drawing.Size(289, 443);
			this.xuc_Employee.TabIndex = 0;
			// 
			// popupMenu
			// 
			this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Setup_Salary, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Generate_Paychecks),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.popupMenu.Manager = this.barManager;
			this.popupMenu.Name = "popupMenu";
			// 
			// frm_Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 521);
			this.Controls.Add(this.gridControl);
			this.Controls.Add(this.DockPanel1);
			this.Controls.Add(this.DockPanel2);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frm_Employees";
			this.Text = "Employees";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Employees_FormClosing);
			this.Load += new System.EventHandler(this.frm_Employees_Load);
			this.Shown += new System.EventHandler(this.frm_Employees_Shown);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._RepositoryItemSearchControl_Search)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Payroll)).EndInit();
			this.DockPanel2.ResumeLayout(false);
			this.DockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.DockPanel1.ResumeLayout(false);
			this.DockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl)).EndInit();
			this.PanelControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_Update;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit_Branch;
        internal DevExpress.XtraGrid.Columns.GridColumn colID;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Code;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Address;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Contact;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Date_Birth;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Age;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Birth_Place;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Civil_Status;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Corporation;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Branch;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Position;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Pay_Level;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Pay_Class;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Status;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Date_Hired;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Date_Probationary;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Date_Regular;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Service_Length;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_TIN;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_SSS;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_PHIC;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_PAG_IBIG;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Attainment;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Course;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name_Spouse;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Children;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Driver_License;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Driver_License_Expiry;
        internal DevExpress.XtraGrid.Columns.GridColumn colNotes;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colAdded_Date;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        internal DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        internal Controls.xuc_Employee xuc_Employee;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployee_Department;
        internal DevExpress.XtraBars.Bar Bar3;
        private DevExpress.XtraBars.BarButtonItem btn_SMS;
        internal DevExpress.XtraGrid.Columns.GridColumn colEmployment_Status;
        internal DevExpress.XtraGrid.Columns.GridColumn colEngine;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem btn_Setup_Salary;
        private DevExpress.XtraBars.Bar bar_Payroll;
        private DevExpress.XtraBars.BarEditItem barEditItem_Payroll;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Payroll;
        private DevExpress.XtraBars.BarButtonItem btn_Generate_Paychecks;
    }
}