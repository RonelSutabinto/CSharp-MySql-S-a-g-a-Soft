using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MyClassLibrary.Controls.Settings
{
    [DesignerGenerated()]
    public partial class xuc_Settings : DevExpress.XtraEditors.XtraUserControl
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
			this.MemoEdit_Notes = new DevExpress.XtraEditors.MemoEdit();
			this.Toggle_Auto_Reload = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Load_All = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Select = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Live_Looping = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Clear_Selection = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Auto_Initialize = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Clear_On_Action = new DevExpress.XtraEditors.ToggleSwitch();
			this.Toggle_Accept_Tab_Return = new DevExpress.XtraEditors.ToggleSwitch();
			this.Check_Save_Restore_Layout = new DevExpress.XtraEditors.CheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MemoEdit_Notes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Auto_Reload.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Load_All.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Select.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Live_Looping.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Clear_Selection.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Auto_Initialize.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Clear_On_Action.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Accept_Tab_Return.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Check_Save_Restore_Layout.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// LayoutControl1
			// 
			this.layoutControl.Controls.Add(this.MemoEdit_Notes);
			this.layoutControl.Controls.Add(this.Toggle_Auto_Reload);
			this.layoutControl.Controls.Add(this.Toggle_Load_All);
			this.layoutControl.Controls.Add(this.Toggle_Select);
			this.layoutControl.Controls.Add(this.Toggle_Live_Looping);
			this.layoutControl.Controls.Add(this.Toggle_Clear_Selection);
			this.layoutControl.Controls.Add(this.Toggle_Auto_Initialize);
			this.layoutControl.Controls.Add(this.Toggle_Clear_On_Action);
			this.layoutControl.Controls.Add(this.Toggle_Accept_Tab_Return);
			this.layoutControl.Controls.Add(this.Check_Save_Restore_Layout);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "LayoutControl1";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(270, 300);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "LayoutControl1";
			// 
			// MemoEdit_Notes
			// 
			this.MemoEdit_Notes.Location = new System.Drawing.Point(24, 87);
			this.MemoEdit_Notes.Name = "MemoEdit_Notes";
			this.MemoEdit_Notes.Size = new System.Drawing.Size(222, 189);
			this.MemoEdit_Notes.StyleController = this.layoutControl;
			this.MemoEdit_Notes.TabIndex = 10;
			// 
			// Toggle_Auto_Reload
			// 
			this.Toggle_Auto_Reload.EditValue = true;
			this.Toggle_Auto_Reload.Location = new System.Drawing.Point(108, 47);
			this.Toggle_Auto_Reload.Name = "Toggle_Auto_Reload";
			this.Toggle_Auto_Reload.Properties.OffText = "Manual";
			this.Toggle_Auto_Reload.Properties.OnText = "Automatic";
			this.Toggle_Auto_Reload.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Auto_Reload.StyleController = this.layoutControl;
			this.Toggle_Auto_Reload.TabIndex = 0;
			// 
			// Toggle_Load_All
			// 
			this.Toggle_Load_All.Location = new System.Drawing.Point(108, 70);
			this.Toggle_Load_All.Name = "Toggle_Load_All";
			this.Toggle_Load_All.Properties.OffText = "Few/Pending";
			this.Toggle_Load_All.Properties.OnText = "All/Everything";
			this.Toggle_Load_All.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Load_All.StyleController = this.layoutControl;
			this.Toggle_Load_All.TabIndex = 1;
			// 
			// Toggle_Select
			// 
			this.Toggle_Select.EditValue = true;
			this.Toggle_Select.Location = new System.Drawing.Point(108, 93);
			this.Toggle_Select.Name = "Toggle_Select";
			this.Toggle_Select.Properties.OffText = "Ignored";
			this.Toggle_Select.Properties.OnText = "Show Data";
			this.Toggle_Select.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Select.StyleController = this.layoutControl;
			this.Toggle_Select.TabIndex = 2;
			// 
			// Toggle_Live_Looping
			// 
			this.Toggle_Live_Looping.EditValue = true;
			this.Toggle_Live_Looping.Location = new System.Drawing.Point(108, 116);
			this.Toggle_Live_Looping.Name = "Toggle_Live_Looping";
			this.Toggle_Live_Looping.Properties.OffText = "No Animation";
			this.Toggle_Live_Looping.Properties.OnText = "Animate";
			this.Toggle_Live_Looping.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Live_Looping.StyleController = this.layoutControl;
			this.Toggle_Live_Looping.TabIndex = 4;
			// 
			// Toggle_Clear_Selection
			// 
			this.Toggle_Clear_Selection.Location = new System.Drawing.Point(108, 139);
			this.Toggle_Clear_Selection.Name = "Toggle_Clear_Selection";
			this.Toggle_Clear_Selection.Properties.OffText = "Do Nothing";
			this.Toggle_Clear_Selection.Properties.OnText = "Clear Selection";
			this.Toggle_Clear_Selection.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Clear_Selection.StyleController = this.layoutControl;
			this.Toggle_Clear_Selection.TabIndex = 5;
			// 
			// Toggle_Auto_Initialize
			// 
			this.Toggle_Auto_Initialize.EditValue = true;
			this.Toggle_Auto_Initialize.Location = new System.Drawing.Point(108, 47);
			this.Toggle_Auto_Initialize.Name = "Toggle_Auto_Initialize";
			this.Toggle_Auto_Initialize.Properties.OffText = "Off";
			this.Toggle_Auto_Initialize.Properties.OnText = "Automatic";
			this.Toggle_Auto_Initialize.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Auto_Initialize.StyleController = this.layoutControl;
			this.Toggle_Auto_Initialize.TabIndex = 6;
			// 
			// Toggle_Clear_On_Action
			// 
			this.Toggle_Clear_On_Action.EditValue = true;
			this.Toggle_Clear_On_Action.Location = new System.Drawing.Point(108, 70);
			this.Toggle_Clear_On_Action.Name = "Toggle_Clear_On_Action";
			this.Toggle_Clear_On_Action.Properties.OffText = "Off";
			this.Toggle_Clear_On_Action.Properties.OnText = "On";
			this.Toggle_Clear_On_Action.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Clear_On_Action.StyleController = this.layoutControl;
			this.Toggle_Clear_On_Action.TabIndex = 7;
			// 
			// Toggle_Accept_Tab_Return
			// 
			this.Toggle_Accept_Tab_Return.Location = new System.Drawing.Point(108, 93);
			this.Toggle_Accept_Tab_Return.Name = "Toggle_Accept_Tab_Return";
			this.Toggle_Accept_Tab_Return.Properties.OffText = "Next Input";
			this.Toggle_Accept_Tab_Return.Properties.OnText = "Accept";
			this.Toggle_Accept_Tab_Return.Size = new System.Drawing.Size(138, 19);
			this.Toggle_Accept_Tab_Return.StyleController = this.layoutControl;
			this.Toggle_Accept_Tab_Return.TabIndex = 8;
			this.Toggle_Accept_Tab_Return.Toggled += new System.EventHandler(this.Toggle_Accept_Tab_Return_Toggled);
			// 
			// Check_Save_Restore_Layout
			// 
			this.Check_Save_Restore_Layout.EditValue = true;
			this.Check_Save_Restore_Layout.Location = new System.Drawing.Point(24, 47);
			this.Check_Save_Restore_Layout.Name = "Check_Save_Restore_Layout";
			this.Check_Save_Restore_Layout.Properties.Caption = "Save / Restore Layout";
			this.Check_Save_Restore_Layout.Size = new System.Drawing.Size(222, 20);
			this.Check_Save_Restore_Layout.StyleController = this.layoutControl;
			this.Check_Save_Restore_Layout.TabIndex = 9;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(270, 300);
			this.Root.TextVisible = false;
			// 
			// tabbedControlGroup1
			// 
			this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.tabbedControlGroup1.Name = "tabbedControlGroup1";
			this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
			this.tabbedControlGroup1.Size = new System.Drawing.Size(250, 280);
			this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup6});
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem9});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(226, 233);
			this.layoutControlGroup4.Text = "Information";
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 69);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(226, 164);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// LayoutControlItem1
			// 
			this.layoutControlItem1.Control = this.Toggle_Auto_Initialize;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "LayoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem1.Text = "Initialize";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
			// 
			// LayoutControlItem5
			// 
			this.layoutControlItem5.Control = this.Toggle_Clear_On_Action;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 23);
			this.layoutControlItem5.Name = "LayoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem5.Text = "Clear Data";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.Toggle_Accept_Tab_Return;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 46);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem9.Text = "Tab and Enter";
			this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlGroup5
			// 
			this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem10});
			this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup5.Name = "layoutControlGroup5";
			this.layoutControlGroup5.Size = new System.Drawing.Size(226, 233);
			this.layoutControlGroup5.Text = "Grid";
			// 
			// LayoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Toggle_Auto_Reload;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "LayoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem2.Text = "Reload";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
			// 
			// LayoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Toggle_Load_All;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 23);
			this.layoutControlItem3.Name = "LayoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem3.Text = "Data Load";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
			// 
			// LayoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Toggle_Select;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 46);
			this.layoutControlItem4.Name = "LayoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem4.Text = "On Select";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
			// 
			// LayoutControlItem7
			// 
			this.layoutControlItem7.Control = this.Toggle_Live_Looping;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 69);
			this.layoutControlItem7.Name = "LayoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(226, 23);
			this.layoutControlItem7.Text = "Live Looping";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 13);
			// 
			// LayoutControlItem10
			// 
			this.layoutControlItem10.Control = this.Toggle_Clear_Selection;
			this.layoutControlItem10.Location = new System.Drawing.Point(0, 92);
			this.layoutControlItem10.Name = "LayoutControlItem10";
			this.layoutControlItem10.Size = new System.Drawing.Size(226, 141);
			this.layoutControlItem10.Text = "Before Loop";
			this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlGroup6
			// 
			this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem6});
			this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup6.Name = "layoutControlGroup6";
			this.layoutControlGroup6.Size = new System.Drawing.Size(226, 233);
			this.layoutControlGroup6.Text = "Form";
			// 
			// LayoutControlItem8
			// 
			this.layoutControlItem8.Control = this.Check_Save_Restore_Layout;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem8.Name = "LayoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(226, 24);
			this.layoutControlItem8.Text = "Save Layout";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// LayoutControlItem6
			// 
			this.layoutControlItem6.Control = this.MemoEdit_Notes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem6.Name = "LayoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(226, 209);
			this.layoutControlItem6.Text = "Notes";
			this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 13);
			// 
			// xuc_Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.MinimumSize = new System.Drawing.Size(270, 0);
			this.Name = "xuc_Settings";
			this.Size = new System.Drawing.Size(270, 300);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MemoEdit_Notes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Auto_Reload.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Load_All.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Select.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Live_Looping.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Clear_Selection.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Auto_Initialize.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Clear_On_Action.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toggle_Accept_Tab_Return.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Check_Save_Restore_Layout.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

        }
        #endregion

        internal DevExpress.XtraLayout.LayoutControl layoutControl;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        public DevExpress.XtraEditors.MemoEdit MemoEdit_Notes;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Auto_Reload;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Load_All;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Select;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Live_Looping;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Clear_Selection;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Auto_Initialize;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Clear_On_Action;
        public DevExpress.XtraEditors.ToggleSwitch Toggle_Accept_Tab_Return;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        public DevExpress.XtraEditors.CheckEdit Check_Save_Restore_Layout;
		private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
	}
}