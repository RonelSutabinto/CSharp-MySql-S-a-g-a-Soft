
namespace SagaAssets.Forms
{
	partial class frm_Stack_Consume
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
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.xuc_Stack_Consume = new SagaAssets.Controls.xuc_Stack_Consume();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.btn_New = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Close = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btn_Save_New = new DevExpress.XtraBars.BarButtonItem();
			this.btn_Save_Close = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenu_Save = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Save)).BeginInit();
			this.SuspendLayout();
			// 
			// xuc_Stack_Consume
			// 
			this.xuc_Stack_Consume.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xuc_Stack_Consume.Location = new System.Drawing.Point(0, 20);
			this.xuc_Stack_Consume.Name = "xuc_Stack_Consume";
			this.xuc_Stack_Consume.Size = new System.Drawing.Size(298, 248);
			this.xuc_Stack_Consume.TabIndex = 6;
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_New,
            this.btn_Save,
            this.btn_Close,
            this.btn_Save_New,
            this.btn_Save_Close});
			this.barManager.MaxItemId = 10;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Close, true)});
			this.bar1.Text = "Tools";
			// 
			// btn_New
			// 
			this.btn_New.Caption = "New";
			this.btn_New.Id = 1;
			this.btn_New.Name = "btn_New";
			// 
			// btn_Save
			// 
			this.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.btn_Save.Caption = "Save";
			this.btn_Save.DropDownControl = this.popupMenu_Save;
			this.btn_Save.Id = 2;
			this.btn_Save.Name = "btn_Save";
			// 
			// btn_Close
			// 
			this.btn_Close.Caption = "Close";
			this.btn_Close.Id = 4;
			this.btn_Close.Name = "btn_Close";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(298, 20);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 268);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(298, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 248);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(298, 20);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 248);
			// 
			// btn_Save_New
			// 
			this.btn_Save_New.Caption = "Save and New";
			this.btn_Save_New.Id = 6;
			this.btn_Save_New.Name = "btn_Save_New";
			// 
			// btn_Save_Close
			// 
			this.btn_Save_Close.Caption = "Save and Close";
			this.btn_Save_Close.Id = 7;
			this.btn_Save_Close.Name = "btn_Save_Close";
			// 
			// popupMenu_Save
			// 
			this.popupMenu_Save.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save_Close)});
			this.popupMenu_Save.Manager = this.barManager;
			this.popupMenu_Save.Name = "popupMenu_Save";
			// 
			// frm_Stack_Consume
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 268);
			this.Controls.Add(this.xuc_Stack_Consume);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frm_Stack_Consume";
			this.Text = "Stock / Consume Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Stack_Consume_FormClosing);
			this.Load += new System.EventHandler(this.frm_Stack_Consume_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu_Save)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal Controls.xuc_Stack_Consume xuc_Stack_Consume;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem btn_New;
		private DevExpress.XtraBars.BarButtonItem btn_Save;
		private DevExpress.XtraBars.BarButtonItem btn_Close;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btn_Save_New;
		private DevExpress.XtraBars.BarButtonItem btn_Save_Close;
		private DevExpress.XtraBars.PopupMenu popupMenu_Save;
	}
}