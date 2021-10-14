
namespace SagaHR.Controls
{
    partial class xuc_Schedule_Type
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
			this.Schedule_Code = new DevExpress.XtraEditors.TextEdit();
			this.Schedule_Description = new DevExpress.XtraEditors.MemoEdit();
			this.Notes = new DevExpress.XtraEditors.MemoEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
			this.Schedule_Name = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Code.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Description.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.ID);
			this.layoutControl.Controls.Add(this.Schedule_Code);
			this.layoutControl.Controls.Add(this.Schedule_Description);
			this.layoutControl.Controls.Add(this.Notes);
			this.layoutControl.Controls.Add(this.Schedule_Name);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(551, 0, 650, 400);
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(200, 200);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "layoutControl";
			// 
			// ID
			// 
			this.ID.Location = new System.Drawing.Point(77, 12);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(111, 20);
			this.ID.StyleController = this.layoutControl;
			this.ID.TabIndex = 0;
			// 
			// Schedule_Code
			// 
			this.Schedule_Code.Location = new System.Drawing.Point(77, 36);
			this.Schedule_Code.Name = "Schedule_Code";
			this.Schedule_Code.Size = new System.Drawing.Size(111, 20);
			this.Schedule_Code.StyleController = this.layoutControl;
			this.Schedule_Code.TabIndex = 1;
			// 
			// Schedule_Description
			// 
			this.Schedule_Description.Location = new System.Drawing.Point(77, 84);
			this.Schedule_Description.Name = "Schedule_Description";
			this.Schedule_Description.Size = new System.Drawing.Size(111, 46);
			this.Schedule_Description.StyleController = this.layoutControl;
			this.Schedule_Description.TabIndex = 3;
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.splitterItem1,
            this.layoutControlItem3});
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
			this.layoutControlItem2.Control = this.Schedule_Code;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(180, 24);
			this.layoutControlItem2.Text = "Code";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.Schedule_Description;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(180, 50);
			this.layoutControlItem5.Text = "Description";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.Notes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 132);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(180, 48);
			this.layoutControlItem6.Text = "Notes";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(53, 13);
			// 
			// splitterItem1
			// 
			this.splitterItem1.AllowHotTrack = true;
			this.splitterItem1.Location = new System.Drawing.Point(0, 122);
			this.splitterItem1.Name = "splitterItem1";
			this.splitterItem1.Size = new System.Drawing.Size(180, 10);
			// 
			// Schedule_Name
			// 
			this.Schedule_Name.Location = new System.Drawing.Point(77, 60);
			this.Schedule_Name.Name = "Schedule_Name";
			this.Schedule_Name.Size = new System.Drawing.Size(111, 20);
			this.Schedule_Name.StyleController = this.layoutControl;
			this.Schedule_Name.TabIndex = 2;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Schedule_Name;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(180, 24);
			this.layoutControlItem3.Text = "Name";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
			// 
			// xuc_Schedule_Type
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Name = "xuc_Schedule_Type";
			this.Size = new System.Drawing.Size(200, 200);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Code.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Description.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Schedule_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraEditors.TextEdit ID;
        internal DevExpress.XtraEditors.TextEdit Schedule_Code;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.XtraEditors.MemoEdit Schedule_Description;
        internal DevExpress.XtraEditors.MemoEdit Notes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
		internal DevExpress.XtraEditors.TextEdit Schedule_Name;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}
