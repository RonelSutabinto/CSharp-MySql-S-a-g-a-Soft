using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MyClassLibrary.Controls.Security
{
    [DesignerGenerated()]
    public partial class xuc_SQL_Connection : DevExpress.XtraEditors.XtraUserControl
    {

        // UserControl overrides dispose to clean up the component list.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xuc_SQL_Connection));
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
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.btn_Default = new DevExpress.XtraEditors.SimpleButton();
			this.btn_Download = new DevExpress.XtraEditors.SimpleButton();
			this.Database_Name = new DevExpress.XtraEditors.TextEdit();
			this.Password = new DevExpress.XtraEditors.TextEdit();
			this.User_Name = new DevExpress.XtraEditors.TextEdit();
			this.Connection_String = new DevExpress.XtraEditors.MemoEdit();
			this.Time_Out = new DevExpress.XtraEditors.SpinEdit();
			this.Server_Name = new DevExpress.XtraEditors.ButtonEdit();
			this.Update_Link = new DevExpress.XtraEditors.MemoEdit();
			this.Server_Type = new DevExpress.XtraEditors.ComboBoxEdit();
			this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
			this.toggle_Update_Type = new DevExpress.XtraEditors.ToggleSwitch();
			this.Remember_Password = new DevExpress.XtraEditors.ToggleSwitch();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.name_Databaseitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.passworditem = new DevExpress.XtraLayout.LayoutControlItem();
			this.name_Useritem = new DevExpress.XtraLayout.LayoutControlItem();
			this.timeOutitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.name_Serveritem = new DevExpress.XtraLayout.LayoutControlItem();
			this.pictureEdit1item = new DevExpress.XtraLayout.LayoutControlItem();
			this.TabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.label = new DevExpress.XtraLayout.SimpleLabelItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.connection_Stringitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.password_Rememberitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Database_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.User_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Connection_String.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Time_Out.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Server_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Update_Link.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Server_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggle_Update_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Remember_Password.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Databaseitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passworditem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Useritem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeOutitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Serveritem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TabbedControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.connection_Stringitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.password_Rememberitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(376, 91);
			this.pictureEdit1.StyleController = this.layoutControl;
			this.pictureEdit1.TabIndex = 0;
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.btn_Default);
			this.layoutControl.Controls.Add(this.btn_Download);
			this.layoutControl.Controls.Add(this.Database_Name);
			this.layoutControl.Controls.Add(this.Password);
			this.layoutControl.Controls.Add(this.User_Name);
			this.layoutControl.Controls.Add(this.Connection_String);
			this.layoutControl.Controls.Add(this.Time_Out);
			this.layoutControl.Controls.Add(this.Server_Name);
			this.layoutControl.Controls.Add(this.pictureEdit1);
			this.layoutControl.Controls.Add(this.Update_Link);
			this.layoutControl.Controls.Add(this.Server_Type);
			this.layoutControl.Controls.Add(this.progressBarControl);
			this.layoutControl.Controls.Add(this.toggle_Update_Type);
			this.layoutControl.Controls.Add(this.Remember_Password);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(651, 159, 650, 400);
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(400, 450);
			this.layoutControl.TabIndex = 0;
			// 
			// btn_Default
			// 
			this.btn_Default.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Default.ImageOptions.Image")));
			this.btn_Default.Location = new System.Drawing.Point(216, 404);
			this.btn_Default.Name = "btn_Default";
			this.btn_Default.Size = new System.Drawing.Size(76, 22);
			this.btn_Default.StyleController = this.layoutControl;
			this.btn_Default.TabIndex = 11;
			this.btn_Default.Text = "Default";
			this.btn_Default.Click += new System.EventHandler(this.btn_Default_Click);
			// 
			// btn_Download
			// 
			this.btn_Download.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Download.ImageOptions.Image")));
			this.btn_Download.Location = new System.Drawing.Point(296, 404);
			this.btn_Download.Name = "btn_Download";
			this.btn_Download.Size = new System.Drawing.Size(80, 22);
			this.btn_Download.StyleController = this.layoutControl;
			this.btn_Download.TabIndex = 12;
			this.btn_Download.Text = "Download";
			this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
			// 
			// Database_Name
			// 
			this.Database_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Database_Name.Location = new System.Drawing.Point(93, 155);
			this.Database_Name.Name = "Database_Name";
			this.Database_Name.Properties.NullText = "(local)";
			this.Database_Name.Properties.UseSystemPasswordChar = true;
			this.Database_Name.Size = new System.Drawing.Size(295, 20);
			this.Database_Name.StyleController = this.layoutControl;
			this.Database_Name.TabIndex = 2;
			// 
			// Password
			// 
			this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Password.Location = new System.Drawing.Point(93, 203);
			this.Password.Name = "Password";
			this.Password.Properties.UseSystemPasswordChar = true;
			this.Password.Size = new System.Drawing.Size(295, 20);
			this.Password.StyleController = this.layoutControl;
			this.Password.TabIndex = 4;
			// 
			// User_Name
			// 
			this.User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.User_Name.Location = new System.Drawing.Point(93, 179);
			this.User_Name.Name = "User_Name";
			this.User_Name.Properties.UseSystemPasswordChar = true;
			this.User_Name.Size = new System.Drawing.Size(295, 20);
			this.User_Name.StyleController = this.layoutControl;
			this.User_Name.TabIndex = 3;
			// 
			// Connection_String
			// 
			this.Connection_String.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Connection_String.Enabled = false;
			this.Connection_String.Location = new System.Drawing.Point(24, 286);
			this.Connection_String.Name = "Connection_String";
			this.Connection_String.Size = new System.Drawing.Size(352, 140);
			this.Connection_String.StyleController = this.layoutControl;
			this.Connection_String.TabIndex = 7;
			// 
			// Time_Out
			// 
			this.Time_Out.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Time_Out.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.Time_Out.Location = new System.Drawing.Point(93, 227);
			this.Time_Out.Name = "Time_Out";
			this.Time_Out.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Time_Out.Size = new System.Drawing.Size(104, 20);
			this.Time_Out.StyleController = this.layoutControl;
			this.Time_Out.TabIndex = 6;
			// 
			// Server_Name
			// 
			this.Server_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Server_Name.Location = new System.Drawing.Point(93, 131);
			this.Server_Name.Name = "Server_Name";
			this.Server_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Ping IP to check if online", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Continous ping command", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.Server_Name.Properties.NullText = "(local)";
			this.Server_Name.Properties.UseSystemPasswordChar = true;
			this.Server_Name.Size = new System.Drawing.Size(295, 20);
			this.Server_Name.StyleController = this.layoutControl;
			this.Server_Name.TabIndex = 1;
			this.Server_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Server_Name_Properties_ButtonClick);
			// 
			// Update_Link
			// 
			this.Update_Link.EditValue = "";
			this.Update_Link.Location = new System.Drawing.Point(24, 286);
			this.Update_Link.Name = "Update_Link";
			this.Update_Link.Properties.NullText = "http://192.168.13.15/AutoUpdate/";
			this.Update_Link.Size = new System.Drawing.Size(352, 75);
			this.Update_Link.StyleController = this.layoutControl;
			this.Update_Link.TabIndex = 8;
			// 
			// Server_Type
			// 
			this.Server_Type.Location = new System.Drawing.Point(93, 107);
			this.Server_Type.Name = "Server_Type";
			this.Server_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Server_Type.Properties.Items.AddRange(new object[] {
            "BACKUP SERVER",
            "LOCAL MACHINE",
            "LOCAL NETWORK",
            "REMOTE IP"});
			this.Server_Type.Properties.Sorted = true;
			this.Server_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Server_Type.Size = new System.Drawing.Size(295, 20);
			this.Server_Type.StyleController = this.layoutControl;
			this.Server_Type.TabIndex = 0;
			this.Server_Type.SelectedIndexChanged += new System.EventHandler(this.Server_Type_SelectedIndexChanged);
			// 
			// progressBarControl
			// 
			this.progressBarControl.Location = new System.Drawing.Point(24, 365);
			this.progressBarControl.Name = "progressBarControl";
			this.progressBarControl.Size = new System.Drawing.Size(352, 18);
			this.progressBarControl.StyleController = this.layoutControl;
			this.progressBarControl.TabIndex = 9;
			this.progressBarControl.Visible = false;
			// 
			// toggle_Update_Type
			// 
			this.toggle_Update_Type.Location = new System.Drawing.Point(105, 404);
			this.toggle_Update_Type.Name = "toggle_Update_Type";
			this.toggle_Update_Type.Properties.OffText = "Basic";
			this.toggle_Update_Type.Properties.OnText = "Full";
			this.toggle_Update_Type.Size = new System.Drawing.Size(107, 18);
			this.toggle_Update_Type.StyleController = this.layoutControl;
			this.toggle_Update_Type.TabIndex = 10;
			this.toggle_Update_Type.Toggled += new System.EventHandler(this.toggle_Update_Type_Toggled);
			// 
			// Remember_Password
			// 
			this.Remember_Password.Location = new System.Drawing.Point(282, 227);
			this.Remember_Password.Name = "Remember_Password";
			this.Remember_Password.Properties.OffText = "Off";
			this.Remember_Password.Properties.OnText = "On";
			this.Remember_Password.Size = new System.Drawing.Size(106, 18);
			this.Remember_Password.StyleController = this.layoutControl;
			this.Remember_Password.TabIndex = 5;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.name_Databaseitem,
            this.passworditem,
            this.name_Useritem,
            this.timeOutitem,
            this.name_Serveritem,
            this.pictureEdit1item,
            this.TabbedControlGroup1,
            this.layoutControlItem3,
            this.password_Rememberitem});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(400, 450);
			this.Root.TextVisible = false;
			// 
			// name_Databaseitem
			// 
			this.name_Databaseitem.Control = this.Database_Name;
			this.name_Databaseitem.Location = new System.Drawing.Point(0, 143);
			this.name_Databaseitem.Name = "name_Databaseitem";
			this.name_Databaseitem.Size = new System.Drawing.Size(380, 24);
			this.name_Databaseitem.Text = "&Database";
			this.name_Databaseitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.name_Databaseitem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// passworditem
			// 
			this.passworditem.Control = this.Password;
			this.passworditem.Location = new System.Drawing.Point(0, 191);
			this.passworditem.Name = "passworditem";
			this.passworditem.Size = new System.Drawing.Size(380, 24);
			this.passworditem.Text = "&Password";
			this.passworditem.TextLocation = DevExpress.Utils.Locations.Left;
			this.passworditem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// name_Useritem
			// 
			this.name_Useritem.Control = this.User_Name;
			this.name_Useritem.Location = new System.Drawing.Point(0, 167);
			this.name_Useritem.Name = "name_Useritem";
			this.name_Useritem.Size = new System.Drawing.Size(380, 24);
			this.name_Useritem.Text = "&User Name";
			this.name_Useritem.TextLocation = DevExpress.Utils.Locations.Left;
			this.name_Useritem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// timeOutitem
			// 
			this.timeOutitem.Control = this.Time_Out;
			this.timeOutitem.Location = new System.Drawing.Point(0, 215);
			this.timeOutitem.Name = "timeOutitem";
			this.timeOutitem.Size = new System.Drawing.Size(189, 24);
			this.timeOutitem.Text = "&Timeout (sec.)";
			this.timeOutitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.timeOutitem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// name_Serveritem
			// 
			this.name_Serveritem.Control = this.Server_Name;
			this.name_Serveritem.Location = new System.Drawing.Point(0, 119);
			this.name_Serveritem.Name = "name_Serveritem";
			this.name_Serveritem.Size = new System.Drawing.Size(380, 24);
			this.name_Serveritem.Text = "&Server Name";
			this.name_Serveritem.TextLocation = DevExpress.Utils.Locations.Left;
			this.name_Serveritem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// pictureEdit1item
			// 
			this.pictureEdit1item.Control = this.pictureEdit1;
			this.pictureEdit1item.Location = new System.Drawing.Point(0, 0);
			this.pictureEdit1item.MaxSize = new System.Drawing.Size(0, 95);
			this.pictureEdit1item.MinSize = new System.Drawing.Size(24, 95);
			this.pictureEdit1item.Name = "pictureEdit1item";
			this.pictureEdit1item.Size = new System.Drawing.Size(380, 95);
			this.pictureEdit1item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.pictureEdit1item.TextSize = new System.Drawing.Size(0, 0);
			this.pictureEdit1item.TextVisible = false;
			// 
			// TabbedControlGroup1
			// 
			this.TabbedControlGroup1.Location = new System.Drawing.Point(0, 239);
			this.TabbedControlGroup1.Name = "TabbedControlGroup1";
			this.TabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
			this.TabbedControlGroup1.Size = new System.Drawing.Size(380, 191);
			this.TabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.label,
            this.layoutControlItem6});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup3.Name = "LayoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(356, 144);
			this.layoutControlGroup3.Text = "Update";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.Update_Link;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "LayoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(356, 79);
			this.layoutControlItem1.Text = "Update Link";
			this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btn_Download;
			this.layoutControlItem2.Location = new System.Drawing.Point(272, 118);
			this.layoutControlItem2.Name = "LayoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(84, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btn_Default;
			this.layoutControlItem4.Location = new System.Drawing.Point(192, 118);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.progressBarControl;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 79);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(356, 22);
			this.layoutControlItem5.Text = "Progress";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// label
			// 
			this.label.AllowHotTrack = false;
			this.label.Location = new System.Drawing.Point(0, 101);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(356, 17);
			this.label.Text = "Update Information";
			this.label.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.label.TextSize = new System.Drawing.Size(94, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.toggle_Update_Type;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 118);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(192, 26);
			this.layoutControlItem6.Text = "Mode";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(69, 13);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.connection_Stringitem});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "LayoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(356, 144);
			this.layoutControlGroup2.Text = "Connection";
			// 
			// connection_Stringitem
			// 
			this.connection_Stringitem.Control = this.Connection_String;
			this.connection_Stringitem.Location = new System.Drawing.Point(0, 0);
			this.connection_Stringitem.Name = "connection_Stringitem";
			this.connection_Stringitem.Size = new System.Drawing.Size(356, 144);
			this.connection_Stringitem.Text = "Connection String";
			this.connection_Stringitem.TextLocation = DevExpress.Utils.Locations.Top;
			this.connection_Stringitem.TextSize = new System.Drawing.Size(0, 0);
			this.connection_Stringitem.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Server_Type;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 95);
			this.layoutControlItem3.Name = "LayoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(380, 24);
			this.layoutControlItem3.Text = "Server &Type";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
			// 
			// password_Rememberitem
			// 
			this.password_Rememberitem.Control = this.Remember_Password;
			this.password_Rememberitem.Location = new System.Drawing.Point(189, 215);
			this.password_Rememberitem.Name = "password_Rememberitem";
			this.password_Rememberitem.Size = new System.Drawing.Size(191, 24);
			this.password_Rememberitem.Text = "Remember";
			this.password_Rememberitem.TextSize = new System.Drawing.Size(69, 13);
			// 
			// ImageCollection
			// 
			this.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection.ImageStream")));
			this.ImageCollection.Images.SetKeyName(0, "home_16x16.png");
			this.ImageCollection.Images.SetKeyName(1, "documentmap_16x16.png");
			this.ImageCollection.Images.SetKeyName(2, "country_16x16.png");
			this.ImageCollection.Images.SetKeyName(3, "publish_16x16.png");
			// 
			// xuc_SQL_Connection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Name = "xuc_SQL_Connection";
			this.Size = new System.Drawing.Size(400, 450);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Database_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.User_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Connection_String.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Time_Out.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Server_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Update_Link.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Server_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggle_Update_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Remember_Password.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Databaseitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passworditem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Useritem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeOutitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.name_Serveritem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TabbedControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.connection_Stringitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.password_Rememberitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).EndInit();
			this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        internal DevExpress.XtraEditors.TextEdit User_Name;
        internal DevExpress.XtraEditors.TextEdit Password;
        internal DevExpress.XtraEditors.TextEdit Database_Name;
        internal DevExpress.XtraEditors.MemoEdit Connection_String;
        internal DevExpress.XtraEditors.SpinEdit Time_Out;
        private DevExpress.XtraEditors.ButtonEdit Server_Name;
        public DevExpress.XtraLayout.LayoutControl layoutControl;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraLayout.LayoutControlItem name_Databaseitem;
        internal DevExpress.XtraLayout.LayoutControlItem passworditem;
        internal DevExpress.XtraLayout.LayoutControlItem name_Useritem;
        internal DevExpress.XtraLayout.LayoutControlItem timeOutitem;
        internal DevExpress.XtraLayout.LayoutControlItem name_Serveritem;
        internal DevExpress.XtraLayout.LayoutControlItem password_Rememberitem;
        internal DevExpress.XtraLayout.LayoutControlItem pictureEdit1item;
        internal DevExpress.XtraEditors.MemoEdit Update_Link;
        internal DevExpress.XtraLayout.TabbedControlGroup TabbedControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        internal DevExpress.XtraLayout.LayoutControlItem connection_Stringitem;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_Download;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.Utils.ImageCollection ImageCollection;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit Server_Type;
        private DevExpress.XtraEditors.SimpleButton btn_Default;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleLabelItem label;
		private DevExpress.XtraEditors.ToggleSwitch toggle_Update_Type;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.ToggleSwitch Remember_Password;
    }
}