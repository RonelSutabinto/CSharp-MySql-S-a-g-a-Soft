using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SagaSupport
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        /// <summary>
    /// Required designer variable.
    /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarEditItem_Branch = new DevExpress.XtraBars.BarEditItem();
            this.RepositoryItemLookUpEdit_Branch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btn_Change_User = new DevExpress.XtraBars.BarButtonItem();
            this.BarStaticItem_Username = new DevExpress.XtraBars.BarStaticItem();
            this.BarStaticItem_Position = new DevExpress.XtraBars.BarStaticItem();
            this.BarStaticItem_App_Version = new DevExpress.XtraBars.BarStaticItem();
            this.BarStaticItem_Server_IP = new DevExpress.XtraBars.BarStaticItem();
            this.BarStaticItem_Local_IP = new DevExpress.XtraBars.BarStaticItem();
            this.btn_New_Ticket = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Tickets = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ticket_Groups = new DevExpress.XtraBars.BarButtonItem();
            this.SkinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.SkinPaletteDropDownButtonItem = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.btn_New_Request = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Requests = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonPage_IT_Support = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroup_Support = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Request = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RepositoryItemComboBox_Corporation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.RibbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.XtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox_Corporation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.BarEditItem_Branch,
            this.btn_Change_User,
            this.BarStaticItem_Username,
            this.BarStaticItem_Position,
            this.BarStaticItem_App_Version,
            this.BarStaticItem_Server_IP,
            this.BarStaticItem_Local_IP,
            this.btn_New_Ticket,
            this.btn_Tickets,
            this.btn_Ticket_Groups,
            this.SkinDropDownButtonItem,
            this.SkinPaletteDropDownButtonItem,
            this.btn_New_Request,
            this.btn_Requests});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 16;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.btn_Change_User);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonPage_IT_Support});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.SkinDropDownButtonItem);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.SkinPaletteDropDownButtonItem);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.BarEditItem_Branch);
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemLookUpEdit_Branch,
            this.RepositoryItemComboBox_Corporation});
            this.ribbonControl.Size = new System.Drawing.Size(586, 158);
            this.ribbonControl.StatusBar = this.RibbonStatusBar;
            // 
            // BarEditItem_Branch
            // 
            this.BarEditItem_Branch.Caption = "Branch";
            this.BarEditItem_Branch.Edit = this.RepositoryItemLookUpEdit_Branch;
            this.BarEditItem_Branch.Id = 7;
            this.BarEditItem_Branch.Name = "BarEditItem_Branch";
            this.BarEditItem_Branch.EditValueChanged += new System.EventHandler(this.BarEditItem_Branch_EditValueChanged);
            // 
            // RepositoryItemLookUpEdit_Branch
            // 
            this.RepositoryItemLookUpEdit_Branch.AutoHeight = false;
            this.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch";
            // 
            // btn_Change_User
            // 
            this.btn_Change_User.Caption = "Change User";
            this.btn_Change_User.Id = 1;
            this.btn_Change_User.Name = "btn_Change_User";
            this.btn_Change_User.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Change_User_ItemClick);
            // 
            // BarStaticItem_Username
            // 
            this.BarStaticItem_Username.Caption = "Username";
            this.BarStaticItem_Username.Id = 4;
            this.BarStaticItem_Username.Name = "BarStaticItem_Username";
            // 
            // BarStaticItem_Position
            // 
            this.BarStaticItem_Position.Caption = "Position";
            this.BarStaticItem_Position.Id = 5;
            this.BarStaticItem_Position.Name = "BarStaticItem_Position";
            // 
            // BarStaticItem_App_Version
            // 
            this.BarStaticItem_App_Version.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BarStaticItem_App_Version.Caption = "1.0.0.0";
            this.BarStaticItem_App_Version.Id = 6;
            this.BarStaticItem_App_Version.Name = "BarStaticItem_App_Version";
            // 
            // BarStaticItem_Server_IP
            // 
            this.BarStaticItem_Server_IP.Caption = "Server IP";
            this.BarStaticItem_Server_IP.Id = 7;
            this.BarStaticItem_Server_IP.Name = "BarStaticItem_Server_IP";
            // 
            // BarStaticItem_Local_IP
            // 
            this.BarStaticItem_Local_IP.Caption = "Local IP";
            this.BarStaticItem_Local_IP.Id = 8;
            this.BarStaticItem_Local_IP.Name = "BarStaticItem_Local_IP";
            // 
            // btn_New_Ticket
            // 
            this.btn_New_Ticket.Caption = "New Ticket";
            this.btn_New_Ticket.Id = 9;
            this.btn_New_Ticket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New_Ticket.ImageOptions.Image")));
            this.btn_New_Ticket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_New_Ticket.ImageOptions.LargeImage")));
            this.btn_New_Ticket.Name = "btn_New_Ticket";
            this.btn_New_Ticket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_Ticket_ItemClick);
            // 
            // btn_Tickets
            // 
            this.btn_Tickets.Caption = "Tickets";
            this.btn_Tickets.Id = 10;
            this.btn_Tickets.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tickets.ImageOptions.Image")));
            this.btn_Tickets.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Tickets.ImageOptions.LargeImage")));
            this.btn_Tickets.Name = "btn_Tickets";
            this.btn_Tickets.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Tickets_ItemClick);
            // 
            // btn_Ticket_Groups
            // 
            this.btn_Ticket_Groups.Caption = "Ticket Groups";
            this.btn_Ticket_Groups.Id = 11;
            this.btn_Ticket_Groups.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ticket_Groups.ImageOptions.Image")));
            this.btn_Ticket_Groups.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ticket_Groups.ImageOptions.LargeImage")));
            this.btn_Ticket_Groups.Name = "btn_Ticket_Groups";
            this.btn_Ticket_Groups.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ticket_Groups_ItemClick);
            // 
            // SkinDropDownButtonItem
            // 
            this.SkinDropDownButtonItem.Id = 12;
            this.SkinDropDownButtonItem.Name = "SkinDropDownButtonItem";
            // 
            // SkinPaletteDropDownButtonItem
            // 
            this.SkinPaletteDropDownButtonItem.Id = 13;
            this.SkinPaletteDropDownButtonItem.Name = "SkinPaletteDropDownButtonItem";
            // 
            // btn_New_Request
            // 
            this.btn_New_Request.Caption = "New Request";
            this.btn_New_Request.Id = 14;
            this.btn_New_Request.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New_Request.ImageOptions.Image")));
            this.btn_New_Request.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_New_Request.ImageOptions.LargeImage")));
            this.btn_New_Request.Name = "btn_New_Request";
            // 
            // btn_Requests
            // 
            this.btn_Requests.Caption = "Requests";
            this.btn_Requests.Id = 15;
            this.btn_Requests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Requests.ImageOptions.Image")));
            this.btn_Requests.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Requests.ImageOptions.LargeImage")));
            this.btn_Requests.Name = "btn_Requests";
            this.btn_Requests.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Requests_ItemClick);
            // 
            // RibbonPage_IT_Support
            // 
            this.RibbonPage_IT_Support.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroup_Support,
            this.ribbonPageGroup_Request});
            this.RibbonPage_IT_Support.Name = "RibbonPage_IT_Support";
            this.RibbonPage_IT_Support.Text = "IT Support";
            // 
            // RibbonPageGroup_Support
            // 
            this.RibbonPageGroup_Support.ItemLinks.Add(this.btn_Ticket_Groups, true);
            this.RibbonPageGroup_Support.ItemLinks.Add(this.btn_New_Ticket, true);
            this.RibbonPageGroup_Support.ItemLinks.Add(this.btn_Tickets);
            this.RibbonPageGroup_Support.Name = "RibbonPageGroup_Support";
            this.RibbonPageGroup_Support.Text = "Support";
            // 
            // ribbonPageGroup_Request
            // 
            this.ribbonPageGroup_Request.ItemLinks.Add(this.btn_New_Request);
            this.ribbonPageGroup_Request.ItemLinks.Add(this.btn_Requests);
            this.ribbonPageGroup_Request.Name = "ribbonPageGroup_Request";
            this.ribbonPageGroup_Request.Text = "Request";
            // 
            // RepositoryItemComboBox_Corporation
            // 
            this.RepositoryItemComboBox_Corporation.AutoHeight = false;
            this.RepositoryItemComboBox_Corporation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemComboBox_Corporation.Items.AddRange(new object[] {
            "SFC",
            "SMC"});
            this.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation";
            this.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // RibbonStatusBar
            // 
            this.RibbonStatusBar.ItemLinks.Add(this.BarStaticItem_Username);
            this.RibbonStatusBar.ItemLinks.Add(this.BarStaticItem_Position);
            this.RibbonStatusBar.ItemLinks.Add(this.BarStaticItem_App_Version);
            this.RibbonStatusBar.ItemLinks.Add(this.BarStaticItem_Server_IP);
            this.RibbonStatusBar.ItemLinks.Add(this.BarStaticItem_Local_IP);
            this.RibbonStatusBar.Location = new System.Drawing.Point(0, 328);
            this.RibbonStatusBar.Name = "RibbonStatusBar";
            this.RibbonStatusBar.Ribbon = this.ribbonControl;
            this.RibbonStatusBar.Size = new System.Drawing.Size(586, 24);
            // 
            // XtraTabbedMdiManager
            // 
            this.XtraTabbedMdiManager.MdiParent = this;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 352);
            this.Controls.Add(this.RibbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form_Main.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.RibbonStatusBar;
            this.Text = "Saga Support System";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit_Branch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemComboBox_Corporation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        internal DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        internal DevExpress.XtraTabbedMdi.XtraTabbedMdiManager XtraTabbedMdiManager;
        internal DevExpress.XtraBars.BarEditItem BarEditItem_Branch;
        internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit_Branch;
        internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox_Corporation;
        internal DevExpress.XtraBars.BarButtonItem btn_Change_User;
        internal DevExpress.XtraBars.Ribbon.RibbonStatusBar RibbonStatusBar;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem_Username;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem_Position;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem_App_Version;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem_Server_IP;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem_Local_IP;
        internal DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage_IT_Support;
        internal DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup_Support;
        internal DevExpress.XtraBars.BarButtonItem btn_New_Ticket;
        internal DevExpress.XtraBars.BarButtonItem btn_Tickets;
        internal DevExpress.XtraBars.BarButtonItem btn_Ticket_Groups;
        internal DevExpress.XtraBars.SkinDropDownButtonItem SkinDropDownButtonItem;
        internal DevExpress.XtraBars.SkinPaletteDropDownButtonItem SkinPaletteDropDownButtonItem;
        private DevExpress.XtraBars.BarButtonItem btn_New_Request;
        private DevExpress.XtraBars.BarButtonItem btn_Requests;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Request;
    }
}