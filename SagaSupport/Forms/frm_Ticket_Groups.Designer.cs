using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaSupport.Forms
{
    [DesignerGenerated()]
    public partial class frm_Ticket_Groups : DevExpress.XtraEditors.XtraForm
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
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Preview = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarEditItem_Branch = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarEditItem_Search = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemSearchControl_Search = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xuc_Settings = new MyClassLibrary.Controls.Settings.xuc_Settings();
            this.TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colTicket_Group = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTicket_Group_Sub = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTicket_Group_Code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTicket_Description = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNotes = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAdded_By = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAdded_Date = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModified_By = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModified_Date = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPersonnel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).BeginInit();
            this.DockPanel1.SuspendLayout();
            this.DockPanel1_Container.SuspendLayout();
            this.DockPanel2.SuspendLayout();
            this.DockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeList)).BeginInit();
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
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.DockManager = this.DockManager;
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Initialize,
            this.BarEditItem_Branch,
            this.BarEditItem_Search,
            this.btn_Reload,
            this.btn_New,
            this.btn_Save,
            this.btn_Delete,
            this.btn_Close,
            this.btn_Preview});
            this.BarManager.MaxItemId = 10;
            this.BarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit_Branch,
            this.RepositoryItemSearchControl_Search});
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Actions";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Preview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
            this.Bar1.Text = "Actions";
            // 
            // btn_Initialize
            // 
            this.btn_Initialize.Caption = "Initialize";
            this.btn_Initialize.Id = 0;
            this.btn_Initialize.Name = "btn_Initialize";
            this.btn_Initialize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Initialize_ItemClick);
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
            this.btn_Preview.Caption = "Preview";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 472);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 20);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // BarEditItem_Branch
            // 
            this.BarEditItem_Branch.Caption = "Branch";
            this.BarEditItem_Branch.Edit = this.RepositoryItemLookUpEdit_Branch;
            this.BarEditItem_Branch.Id = 1;
            this.BarEditItem_Branch.Name = "BarEditItem_Branch";
            // 
            // RepositoryItemLookUpEdit_Branch
            // 
            this.RepositoryItemLookUpEdit_Branch.AutoHeight = false;
            this.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch";
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
            // DockPanel1
            // 
            this.DockPanel1.Controls.Add(this.DockPanel1_Container);
            this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.DockPanel1.ID = new System.Guid("22c6d810-d8ce-4804-b3d8-0bba42e000c2");
            this.DockPanel1.Location = new System.Drawing.Point(0, 20);
            this.DockPanel1.Name = "DockPanel1";
            this.DockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.DockPanel1.Size = new System.Drawing.Size(200, 452);
            this.DockPanel1.Text = "Information";
            // 
            // DockPanel1_Container
            // 
            this.DockPanel1_Container.Controls.Add(this.xuc_Ticket_Group);
            this.DockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.DockPanel1_Container.Name = "DockPanel1_Container";
            this.DockPanel1_Container.Size = new System.Drawing.Size(193, 423);
            this.DockPanel1_Container.TabIndex = 0;
            // 
            // xuc_Ticket_Group
            // 
            this.xuc_Ticket_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Ticket_Group.Location = new System.Drawing.Point(0, 0);
            this.xuc_Ticket_Group.Name = "xuc_Ticket_Group";
            this.xuc_Ticket_Group.Size = new System.Drawing.Size(193, 423);
            this.xuc_Ticket_Group.TabIndex = 0;
            // 
            // DockPanel2
            // 
            this.DockPanel2.Controls.Add(this.DockPanel2_Container);
            this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DockPanel2.ID = new System.Guid("26eb8324-b60d-4581-85c5-7545dc980b9b");
            this.DockPanel2.Location = new System.Drawing.Point(598, 20);
            this.DockPanel2.Name = "DockPanel2";
            this.DockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.DockPanel2.Size = new System.Drawing.Size(200, 452);
            this.DockPanel2.Text = "Settings";
            // 
            // DockPanel2_Container
            // 
            this.DockPanel2_Container.Controls.Add(this.xuc_Settings);
            this.DockPanel2_Container.Location = new System.Drawing.Point(4, 26);
            this.DockPanel2_Container.Name = "DockPanel2_Container";
            this.DockPanel2_Container.Size = new System.Drawing.Size(193, 423);
            this.DockPanel2_Container.TabIndex = 0;
            // 
            // xuc_Settings
            // 
            this.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuc_Settings.Location = new System.Drawing.Point(0, 0);
            this.xuc_Settings.Name = "xuc_Settings";
            this.xuc_Settings.Size = new System.Drawing.Size(193, 423);
            this.xuc_Settings.TabIndex = 0;
            // 
            // TreeList
            // 
            this.TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTicket_Group,
            this.colTicket_Group_Sub,
            this.colID,
            this.colTicket_Group_Code,
            this.colTicket_Description,
            this.colPersonnel,
            this.colNotes,
            this.colAdded_By,
            this.colAdded_Date,
            this.colModified_By,
            this.colModified_Date});
            this.TreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeList.Location = new System.Drawing.Point(200, 20);
            this.TreeList.Name = "TreeList";
            this.TreeList.OptionsView.AutoWidth = false;
            this.TreeList.Size = new System.Drawing.Size(398, 452);
            this.TreeList.TabIndex = 2;
            this.TreeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_FocusedNodeChanged);
            // 
            // colTicket_Group
            // 
            this.colTicket_Group.FieldName = "Ticket_Group";
            this.colTicket_Group.Name = "colTicket_Group";
            this.colTicket_Group.Visible = true;
            this.colTicket_Group.VisibleIndex = 0;
            // 
            // colTicket_Group_Sub
            // 
            this.colTicket_Group_Sub.FieldName = "Ticket_Group_Sub";
            this.colTicket_Group_Sub.Name = "colTicket_Group_Sub";
            this.colTicket_Group_Sub.Visible = true;
            this.colTicket_Group_Sub.VisibleIndex = 2;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            // 
            // colTicket_Group_Code
            // 
            this.colTicket_Group_Code.FieldName = "Ticket_Group_Code";
            this.colTicket_Group_Code.Name = "colTicket_Group_Code";
            this.colTicket_Group_Code.Visible = true;
            this.colTicket_Group_Code.VisibleIndex = 3;
            // 
            // colTicket_Description
            // 
            this.colTicket_Description.FieldName = "Ticket_Description";
            this.colTicket_Description.Name = "colTicket_Description";
            this.colTicket_Description.Visible = true;
            this.colTicket_Description.VisibleIndex = 4;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 6;
            // 
            // colAdded_By
            // 
            this.colAdded_By.FieldName = "Added_By";
            this.colAdded_By.Name = "colAdded_By";
            this.colAdded_By.Visible = true;
            this.colAdded_By.VisibleIndex = 7;
            // 
            // colAdded_Date
            // 
            this.colAdded_Date.FieldName = "Added_Date";
            this.colAdded_Date.Name = "colAdded_Date";
            this.colAdded_Date.Visible = true;
            this.colAdded_Date.VisibleIndex = 8;
            // 
            // colModified_By
            // 
            this.colModified_By.FieldName = "Modified_By";
            this.colModified_By.Name = "colModified_By";
            this.colModified_By.Visible = true;
            this.colModified_By.VisibleIndex = 9;
            // 
            // colModified_Date
            // 
            this.colModified_Date.FieldName = "Modified_Date";
            this.colModified_Date.Name = "colModified_Date";
            this.colModified_Date.Visible = true;
            this.colModified_Date.VisibleIndex = 10;
            // 
            // colPersonnel
            // 
            this.colPersonnel.FieldName = "Personnel";
            this.colPersonnel.Name = "colPersonnel";
            this.colPersonnel.Visible = true;
            this.colPersonnel.VisibleIndex = 5;
            // 
            // frm_Ticket_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 472);
            this.Controls.Add(this.TreeList);
            this.Controls.Add(this.DockPanel2);
            this.Controls.Add(this.DockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Ticket_Groups";
            this.Text = "frm_Ticket_Groups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Tickets_FormClosing);
            this.Load += new System.EventHandler(this.frm_Ticket_Groups_Load);
            this.Shown += new System.EventHandler(this.frm_Tickets_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemSearchControl_Search)).EndInit();
            this.DockPanel1.ResumeLayout(false);
            this.DockPanel1_Container.ResumeLayout(false);
            this.DockPanel2.ResumeLayout(false);
            this.DockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal DevExpress.XtraBars.Docking.DockManager DockManager;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel2;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel2_Container;
        internal MyClassLibrary.Controls.Settings.xuc_Settings xuc_Settings;
        internal DevExpress.XtraBars.Docking.DockPanel DockPanel1;
        internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
        internal DevExpress.XtraTreeList.TreeList TreeList;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarManager BarManager;
        internal DevExpress.XtraBars.Bar Bar1;
        internal DevExpress.XtraBars.BarButtonItem btn_Initialize;
        internal DevExpress.XtraBars.BarButtonItem btn_Reload;
        internal DevExpress.XtraBars.BarButtonItem btn_Preview;
        internal DevExpress.XtraBars.BarButtonItem btn_New;
        internal DevExpress.XtraBars.BarButtonItem btn_Save;
        internal DevExpress.XtraBars.BarButtonItem btn_Delete;
        internal DevExpress.XtraBars.BarButtonItem btn_Close;
        internal DevExpress.XtraBars.BarEditItem BarEditItem_Branch;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit_Branch;
        internal DevExpress.XtraBars.BarEditItem BarEditItem_Search;
        internal DevExpress.XtraEditors.Repository.RepositoryItemSearchControl RepositoryItemSearchControl_Search;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal Controls.xuc_Ticket_Group xuc_Ticket_Group;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Group_Code;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Group;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Group_Sub;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colNotes;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colAdded_By;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colAdded_Date;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colModified_By;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colModified_Date;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Description;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPersonnel;
    }
}