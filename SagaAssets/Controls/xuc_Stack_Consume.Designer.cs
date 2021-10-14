
namespace SagaAssets.Controls
{
	partial class xuc_Stack_Consume
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.ID = new DevExpress.XtraEditors.TextEdit();
			this.Entry_Type = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Quantity = new DevExpress.XtraEditors.SpinEdit();
			this.Entry_Description = new DevExpress.XtraEditors.MemoEdit();
			this.Notes = new DevExpress.XtraEditors.MemoEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Entry_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Quantity.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Entry_Description.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.ID);
			this.layoutControl.Controls.Add(this.Entry_Type);
			this.layoutControl.Controls.Add(this.Quantity);
			this.layoutControl.Controls.Add(this.Entry_Description);
			this.layoutControl.Controls.Add(this.Notes);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(200, 200);
			this.layoutControl.TabIndex = 1;
			this.layoutControl.Text = "layoutControl1";
			// 
			// ID
			// 
			this.ID.Location = new System.Drawing.Point(77, 12);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(111, 20);
			this.ID.StyleController = this.layoutControl;
			this.ID.TabIndex = 0;
			// 
			// Entry_Type
			// 
			this.Entry_Type.Location = new System.Drawing.Point(77, 36);
			this.Entry_Type.Name = "Entry_Type";
			this.Entry_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Entry_Type.Properties.Items.AddRange(new object[] {
            "CONSUME",
            "STACK"});
			this.Entry_Type.Properties.Sorted = true;
			this.Entry_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Entry_Type.Size = new System.Drawing.Size(111, 20);
			this.Entry_Type.StyleController = this.layoutControl;
			this.Entry_Type.TabIndex = 1;
			// 
			// Quantity
			// 
			this.Quantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.Quantity.Location = new System.Drawing.Point(77, 60);
			this.Quantity.Name = "Quantity";
			this.Quantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Quantity.Size = new System.Drawing.Size(111, 20);
			this.Quantity.StyleController = this.layoutControl;
			this.Quantity.TabIndex = 2;
			// 
			// Entry_Description
			// 
			this.Entry_Description.Location = new System.Drawing.Point(77, 84);
			this.Entry_Description.Name = "Entry_Description";
			this.Entry_Description.Size = new System.Drawing.Size(111, 46);
			this.Entry_Description.StyleController = this.layoutControl;
			this.Entry_Description.TabIndex = 3;
			// 
			// Notes
			// 
			this.Notes.Location = new System.Drawing.Point(77, 144);
			this.Notes.Name = "Notes";
			this.Notes.Size = new System.Drawing.Size(111, 44);
			this.Notes.StyleController = this.layoutControl;
			this.Notes.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.splitterItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(200, 200);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.ID;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(180, 24);
			this.layoutControlItem1.Text = "ID";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Entry_Type;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(180, 24);
			this.layoutControlItem2.Text = "Type";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Quantity;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(180, 24);
			this.layoutControlItem3.Text = "Quantity";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Entry_Description;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(180, 50);
			this.layoutControlItem4.Text = "Description";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.Notes;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 132);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(180, 48);
			this.layoutControlItem5.Text = "Notes";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
			// 
			// splitterItem1
			// 
			this.splitterItem1.AllowHotTrack = true;
			this.splitterItem1.Location = new System.Drawing.Point(0, 122);
			this.splitterItem1.Name = "splitterItem1";
			this.splitterItem1.Size = new System.Drawing.Size(180, 10);
			// 
			// xuc_Stack_Consume
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Name = "xuc_Stack_Consume";
			this.Size = new System.Drawing.Size(200, 200);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Entry_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Quantity.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Entry_Description.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraEditors.TextEdit ID;
		internal DevExpress.XtraEditors.ComboBoxEdit Entry_Type;
		private DevExpress.XtraEditors.SpinEdit Quantity;
		private DevExpress.XtraEditors.MemoEdit Entry_Description;
		private DevExpress.XtraEditors.MemoEdit Notes;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.SplitterItem splitterItem1;
	}
}
