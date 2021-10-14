using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaSupport.Forms
{
    [DesignerGenerated()]
    public partial class frm_Ticket : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket));
			this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar_Actions = new DevExpress.XtraBars.Bar();
			this.btn_Initialize = new DevExpress.XtraBars.BarButtonItem();
			this.btn_New = new DevExpress.XtraBars.BarButtonItem();
			this.PopupMenu_New = new DevExpress.XtraBars.PopupMenu(this.components);
			this.toggle_Clear = new DevExpress.XtraBars.BarToggleSwitchItem();
			this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
			this.PopupMenu_Save = new DevExpress.XtraBars.PopupMenu(this.components);
			this.btn_Save_New = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save_Close = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save_Open_Close = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btn_Approve = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
			this.Bar_Approval = new DevExpress.XtraBars.Bar();
			this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupMenu_New)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupMenu_Save)).BeginInit();
			this.SuspendLayout();
			// 
			// BarManager
			// 
			this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar_Actions});
			this.BarManager.DockControls.Add(this.barDockControlTop);
			this.BarManager.DockControls.Add(this.barDockControlBottom);
			this.BarManager.DockControls.Add(this.barDockControlLeft);
			this.BarManager.DockControls.Add(this.barDockControlRight);
			this.BarManager.Form = this;
			this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Initialize,
            this.btn_Save,
            this.btn_Close,
            this.btn_Save_New,
            this.btn_Save_Close,
            this.btn_New,
            this.btn_Approve,
            this.btn_Cancel,
            this.btn_Save_Open_Close,
            this.toggle_Clear,
            this.btn_Edit});
			this.BarManager.MaxItemId = 14;
			// 
			// Bar_Actions
			// 
			this.Bar_Actions.BarName = "Actions";
			this.Bar_Actions.DockCol = 0;
			this.Bar_Actions.DockRow = 0;
			this.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar_Actions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Initialize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.Bar_Actions.Text = "Actions";
			// 
			// btn_Initialize
			// 
			this.btn_Initialize.Caption = "Initialize";
			this.btn_Initialize.Id = 0;
			this.btn_Initialize.Name = "btn_Initialize";
			this.btn_Initialize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Initialize_ItemClick);
			// 
			// btn_New
			// 
			this.btn_New.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.btn_New.Caption = "New";
			this.btn_New.DropDownControl = this.PopupMenu_New;
			this.btn_New.Id = 6;
			this.btn_New.Name = "btn_New";
			this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
			// 
			// PopupMenu_New
			// 
			this.PopupMenu_New.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggle_Clear)});
			this.PopupMenu_New.Manager = this.BarManager;
			this.PopupMenu_New.Name = "PopupMenu_New";
			// 
			// toggle_Clear
			// 
			this.toggle_Clear.Caption = "Clear";
			this.toggle_Clear.Id = 12;
			this.toggle_Clear.Name = "toggle_Clear";
			// 
			// btn_Save
			// 
			this.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.btn_Save.Caption = "Save";
			this.btn_Save.DropDownControl = this.PopupMenu_Save;
			this.btn_Save.Id = 1;
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
			// 
			// PopupMenu_Save
			// 
			this.PopupMenu_Save.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_Close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_Open_Close)});
			this.PopupMenu_Save.Manager = this.BarManager;
			this.PopupMenu_Save.Name = "PopupMenu_Save";
			// 
			// btn_Save_New
			// 
			this.btn_Save_New.Caption = "Save and New";
			this.btn_Save_New.Id = 4;
			this.btn_Save_New.Name = "btn_Save_New";
			this.btn_Save_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_New_ItemClick);
			// 
			// btn_Save_Close
			// 
			this.btn_Save_Close.Caption = "Save and Close";
			this.btn_Save_Close.Id = 5;
			this.btn_Save_Close.Name = "btn_Save_Close";
			this.btn_Save_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_Close_ItemClick);
			// 
			// btn_Save_Open_Close
			// 
			this.btn_Save_Open_Close.Caption = "Save, Open and Close";
			this.btn_Save_Open_Close.Id = 11;
			this.btn_Save_Open_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_Open_Close.ImageOptions.Image")));
			this.btn_Save_Open_Close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Save_Open_Close.ImageOptions.LargeImage")));
			this.btn_Save_Open_Close.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
			this.btn_Save_Open_Close.Name = "btn_Save_Open_Close";
			this.btn_Save_Open_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_Open_Close_ItemClick);
			// 
			// btn_Close
			// 
			this.btn_Close.Caption = "Close";
			this.btn_Close.Id = 3;
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Close_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(348, 20);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
			this.barDockControlBottom.Manager = this.BarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(348, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
			this.barDockControlLeft.Manager = this.BarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(348, 20);
			this.barDockControlRight.Manager = this.BarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
			// 
			// btn_Approve
			// 
			this.btn_Approve.Caption = "Approve";
			this.btn_Approve.Id = 8;
			this.btn_Approve.Name = "btn_Approve";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Caption = "Cancel";
			this.btn_Cancel.Id = 10;
			this.btn_Cancel.Name = "btn_Cancel";
			// 
			// xuc_Ticket
			// 
			this.xuc_Ticket.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Ticket.Location = new System.Drawing.Point(0, 20);
			this.xuc_Ticket.Name = "xuc_Ticket";
			this.xuc_Ticket.Size = new System.Drawing.Size(348, 448);
			this.xuc_Ticket.TabIndex = 4;
			// 
			// Bar_Approval
			// 
			this.Bar_Approval.BarName = "Approval";
			this.Bar_Approval.DockCol = 0;
			this.Bar_Approval.DockRow = 2;
			this.Bar_Approval.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar_Approval.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Approve),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.Bar_Approval.Text = "Approval";
			// 
			// btn_Edit
			// 
			this.btn_Edit.Caption = "Edit";
			this.btn_Edit.Id = 13;
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Edit_ItemClick);
			// 
			// frm_Ticket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 468);
			this.Controls.Add(this.xuc_Ticket);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Ticket";
			this.Text = "frm_Ticket";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ticket_FormClosing);
			this.Load += new System.EventHandler(this.frm_Ticket_Load);
			this.Shown += new System.EventHandler(this.frm_Ticket_Shown);
			((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupMenu_New)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PopupMenu_Save)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        internal DevExpress.XtraBars.BarManager BarManager;
        internal DevExpress.XtraBars.Bar Bar_Actions;
        internal DevExpress.XtraBars.BarButtonItem btn_Initialize;
        internal DevExpress.XtraBars.BarButtonItem btn_New;
        internal DevExpress.XtraBars.BarButtonItem btn_Save;
        internal DevExpress.XtraBars.PopupMenu PopupMenu_Save;
        internal DevExpress.XtraBars.BarButtonItem btn_Save_New;
        internal DevExpress.XtraBars.BarButtonItem btn_Save_Close;
        internal DevExpress.XtraBars.BarButtonItem btn_Close;
        internal DevExpress.XtraBars.Bar Bar_Approval;
        internal DevExpress.XtraBars.BarButtonItem btn_Approve;
        internal DevExpress.XtraBars.BarButtonItem btn_Cancel;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        public Controls.xuc_Ticket xuc_Ticket;
        internal DevExpress.XtraBars.BarButtonItem btn_Save_Open_Close;
        internal DevExpress.XtraBars.PopupMenu PopupMenu_New;
        internal DevExpress.XtraBars.BarToggleSwitchItem toggle_Clear;
		private DevExpress.XtraBars.BarButtonItem btn_Edit;
	}
}