using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;

namespace SagaSupport.Controls
{
    [DesignerGenerated()]
    public partial class xuc_Ticket_Group : DevExpress.XtraEditors.XtraUserControl
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
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.ID = new DevExpress.XtraEditors.TextEdit();
            this.Ticket_Group_Sub = new DevExpress.XtraEditors.TextEdit();
            this.Notes = new DevExpress.XtraEditors.MemoEdit();
            this.Ticket_Group_Code = new DevExpress.XtraEditors.ButtonEdit();
            this.Ticket_Description = new DevExpress.XtraEditors.MemoEdit();
            this.Ticket_Group = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Personnel = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group_Sub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personnel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControl1
            // 
            this.layoutControl.Controls.Add(this.ID);
            this.layoutControl.Controls.Add(this.Ticket_Group_Sub);
            this.layoutControl.Controls.Add(this.Notes);
            this.layoutControl.Controls.Add(this.Ticket_Group_Code);
            this.layoutControl.Controls.Add(this.Ticket_Description);
            this.layoutControl.Controls.Add(this.Ticket_Group);
            this.layoutControl.Controls.Add(this.Personnel);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "LayoutControl1";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(227, 238);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "LayoutControl1";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(77, 12);
            this.ID.Name = "ID";
            this.ID.Properties.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(138, 20);
            this.ID.StyleController = this.layoutControl;
            this.ID.TabIndex = 0;
            // 
            // Ticket_Group_Sub
            // 
            this.Ticket_Group_Sub.Location = new System.Drawing.Point(77, 84);
            this.Ticket_Group_Sub.Name = "Ticket_Group_Sub";
            this.Ticket_Group_Sub.Size = new System.Drawing.Size(138, 20);
            this.Ticket_Group_Sub.StyleController = this.layoutControl;
            this.Ticket_Group_Sub.TabIndex = 3;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(77, 182);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(138, 44);
            this.Notes.StyleController = this.layoutControl;
            this.Notes.TabIndex = 6;
            // 
            // Ticket_Group_Code
            // 
            this.Ticket_Group_Code.Location = new System.Drawing.Point(77, 36);
            this.Ticket_Group_Code.Name = "Ticket_Group_Code";
            this.Ticket_Group_Code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Ticket_Group_Code.Properties.ReadOnly = true;
            this.Ticket_Group_Code.Size = new System.Drawing.Size(138, 20);
            this.Ticket_Group_Code.StyleController = this.layoutControl;
            this.Ticket_Group_Code.TabIndex = 1;
            this.Ticket_Group_Code.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Ticket_Group_Code_ButtonClick);
            // 
            // Ticket_Description
            // 
            this.Ticket_Description.Location = new System.Drawing.Point(77, 108);
            this.Ticket_Description.Name = "Ticket_Description";
            this.Ticket_Description.Size = new System.Drawing.Size(138, 46);
            this.Ticket_Description.StyleController = this.layoutControl;
            this.Ticket_Description.TabIndex = 4;
            // 
            // Ticket_Group
            // 
            this.Ticket_Group.Location = new System.Drawing.Point(77, 60);
            this.Ticket_Group.Name = "Ticket_Group";
            this.Ticket_Group.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, true, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Ticket_Group.Size = new System.Drawing.Size(138, 20);
            this.Ticket_Group.StyleController = this.layoutControl;
            this.Ticket_Group.TabIndex = 2;
            this.Ticket_Group.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Ticket_Group_ButtonClick);
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
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(227, 238);
            this.Root.TextVisible = false;
            // 
            // LayoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "LayoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // LayoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Ticket_Group;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "LayoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem2.Text = "Group";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // LayoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Ticket_Group_Sub;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "LayoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem3.Text = "Sub-Group";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
            // 
            // LayoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Notes;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem4.Name = "LayoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(207, 48);
            this.layoutControlItem4.Text = "Notes";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(53, 13);
            // 
            // LayoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Ticket_Group_Code;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "LayoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem5.Text = "Code";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(53, 13);
            // 
            // LayoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Ticket_Description;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 50);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(76, 50);
            this.layoutControlItem6.Name = "LayoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(207, 50);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Description";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.Personnel;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem7.Text = "Personnel";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(53, 13);
            // 
            // Personnel
            // 
            this.Personnel.Location = new System.Drawing.Point(77, 158);
            this.Personnel.Name = "Personnel";
            this.Personnel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, true, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Personnel.Properties.NullText = "";
            this.Personnel.Properties.PopupSizeable = false;
            this.Personnel.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Personnel_Properties_ButtonClick);
            this.Personnel.Size = new System.Drawing.Size(138, 20);
            this.Personnel.StyleController = this.layoutControl;
            this.Personnel.TabIndex = 5;
            // 
            // xuc_Ticket_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "xuc_Ticket_Group";
            this.Size = new System.Drawing.Size(227, 238);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group_Sub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_Group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personnel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        internal DevExpress.XtraLayout.LayoutControl layoutControl;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraEditors.TextEdit ID;
        internal DevExpress.XtraEditors.TextEdit Ticket_Group_Sub;
        internal DevExpress.XtraEditors.MemoEdit Notes;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        internal DevExpress.XtraEditors.ButtonEdit Ticket_Group_Code;
        internal DevExpress.XtraEditors.MemoEdit Ticket_Description;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        internal DevExpress.XtraEditors.ComboBoxEdit Ticket_Group;
        internal DevExpress.XtraEditors.LookUpEdit Personnel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}