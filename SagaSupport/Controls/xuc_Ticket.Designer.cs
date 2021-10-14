using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaSupport.Controls
{
    [DesignerGenerated()]
    public partial class xuc_Ticket : DevExpress.XtraEditors.XtraUserControl
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling7 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling10 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling9 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling4 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling5 = new DevExpress.XtraSpellChecker.OptionsSpelling();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.Ticket_Attachment = new DevExpress.XtraRichEdit.RichEditControl();
			this.spellChecker = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
			this.ID = new DevExpress.XtraEditors.TextEdit();
			this.Notes = new DevExpress.XtraEditors.MemoEdit();
			this.Ticket_Name = new DevExpress.XtraEditors.TextEdit();
			this.Ticket_Solution = new DevExpress.XtraEditors.MemoEdit();
			this.Ticket_Status = new DevExpress.XtraEditors.TextEdit();
			this.Ticket_Description = new DevExpress.XtraEditors.MemoEdit();
			this.Ticket_Code = new DevExpress.XtraEditors.ButtonEdit();
			this.Branch_Code = new DevExpress.XtraEditors.LookUpEdit();
			this.Ticket_Group = new DevExpress.XtraEditors.TreeListLookUpEdit();
			this.treeListLookUpEditTreeList = new DevExpress.XtraTreeList.TreeList();
			this.colTicket_Group_Sub = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colTicket_Description = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colNotes = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.Created_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Report_Type = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Communication_Type = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Ticket_Impact = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Ticket_Urgency = new DevExpress.XtraEditors.ComboBoxEdit();
			this.IsRecurrent = new DevExpress.XtraEditors.ToggleSwitch();
			this.Assigned_To = new DevExpress.XtraEditors.LookUpEdit();
			this.Defect_Type = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Added_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Modified_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Opened_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Closed_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Deleted_By = new DevExpress.XtraEditors.LookUpEdit();
			this.Incident_Date = new DevExpress.XtraEditors.DateEdit();
			this.Asset_Code = new DevExpress.XtraEditors.LookUpEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Type = new DevExpress.XtraLayout.LayoutControlItem();
			this.TabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
			this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup_Support = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Impact = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Urgency = new DevExpress.XtraLayout.LayoutControlItem();
			this.EmptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Branch = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Created_By = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem_Group = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Solution.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Status.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Description.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Code.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Branch_Code.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Group.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditTreeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Created_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Report_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Communication_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Impact.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Urgency.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IsRecurrent.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Assigned_To.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Defect_Type.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Added_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Modified_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Opened_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Closed_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Deleted_By.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Incident_Date.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Incident_Date.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Asset_Code.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TabbedControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup_Support)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Impact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Urgency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Branch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Created_By)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.Ticket_Attachment);
			this.layoutControl.Controls.Add(this.ID);
			this.layoutControl.Controls.Add(this.Ticket_Code);
			this.layoutControl.Controls.Add(this.Notes);
			this.layoutControl.Controls.Add(this.Branch_Code);
			this.layoutControl.Controls.Add(this.Ticket_Name);
			this.layoutControl.Controls.Add(this.Ticket_Group);
			this.layoutControl.Controls.Add(this.Ticket_Solution);
			this.layoutControl.Controls.Add(this.Created_By);
			this.layoutControl.Controls.Add(this.Report_Type);
			this.layoutControl.Controls.Add(this.Communication_Type);
			this.layoutControl.Controls.Add(this.Ticket_Impact);
			this.layoutControl.Controls.Add(this.Ticket_Urgency);
			this.layoutControl.Controls.Add(this.IsRecurrent);
			this.layoutControl.Controls.Add(this.Assigned_To);
			this.layoutControl.Controls.Add(this.Defect_Type);
			this.layoutControl.Controls.Add(this.Ticket_Status);
			this.layoutControl.Controls.Add(this.Added_By);
			this.layoutControl.Controls.Add(this.Modified_By);
			this.layoutControl.Controls.Add(this.Opened_By);
			this.layoutControl.Controls.Add(this.Closed_By);
			this.layoutControl.Controls.Add(this.Deleted_By);
			this.layoutControl.Controls.Add(this.Incident_Date);
			this.layoutControl.Controls.Add(this.Ticket_Description);
			this.layoutControl.Controls.Add(this.Asset_Code);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(624, 72, 650, 400);
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(350, 400);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "LayoutControl";
			// 
			// Ticket_Attachment
			// 
			this.Ticket_Attachment.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.Ticket_Attachment.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
			this.Ticket_Attachment.Location = new System.Drawing.Point(24, 243);
			this.Ticket_Attachment.Name = "Ticket_Attachment";
			this.Ticket_Attachment.Size = new System.Drawing.Size(302, 133);
			this.Ticket_Attachment.SpellChecker = this.spellChecker;
			this.spellChecker.SetSpellCheckerOptions(this.Ticket_Attachment, optionsSpelling7);
			this.Ticket_Attachment.TabIndex = 10;
			// 
			// spellChecker
			// 
			this.spellChecker.Culture = new System.Globalization.CultureInfo("en-US");
			this.spellChecker.ParentContainer = null;
			this.spellChecker.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
			// 
			// ID
			// 
			this.ID.Location = new System.Drawing.Point(96, 12);
			this.ID.Name = "ID";
			this.ID.Properties.ReadOnly = true;
			this.spellChecker.SetShowSpellCheckMenu(this.ID, true);
			this.ID.Size = new System.Drawing.Size(77, 20);
			this.spellChecker.SetSpellCheckerOptions(this.ID, optionsSpelling10);
			this.ID.StyleController = this.layoutControl;
			this.ID.TabIndex = 0;
			// 
			// Notes
			// 
			this.Notes.Location = new System.Drawing.Point(24, 167);
			this.Notes.Name = "Notes";
			this.spellChecker.SetShowSpellCheckMenu(this.Notes, true);
			this.Notes.Size = new System.Drawing.Size(302, 209);
			this.spellChecker.SetSpellCheckerOptions(this.Notes, optionsSpelling9);
			this.Notes.StyleController = this.layoutControl;
			this.Notes.TabIndex = 0;
			// 
			// Ticket_Name
			// 
			this.Ticket_Name.Location = new System.Drawing.Point(96, 108);
			this.Ticket_Name.Name = "Ticket_Name";
			this.spellChecker.SetShowSpellCheckMenu(this.Ticket_Name, true);
			this.Ticket_Name.Size = new System.Drawing.Size(242, 20);
			this.spellChecker.SetSpellCheckerOptions(this.Ticket_Name, optionsSpelling2);
			this.Ticket_Name.StyleController = this.layoutControl;
			this.Ticket_Name.TabIndex = 8;
			// 
			// Ticket_Solution
			// 
			this.Ticket_Solution.Location = new System.Drawing.Point(24, 167);
			this.Ticket_Solution.Name = "Ticket_Solution";
			this.spellChecker.SetShowSpellCheckMenu(this.Ticket_Solution, true);
			this.Ticket_Solution.Size = new System.Drawing.Size(302, 209);
			this.spellChecker.SetSpellCheckerOptions(this.Ticket_Solution, optionsSpelling3);
			this.Ticket_Solution.StyleController = this.layoutControl;
			this.Ticket_Solution.TabIndex = 0;
			// 
			// Ticket_Status
			// 
			this.Ticket_Status.Location = new System.Drawing.Point(108, 167);
			this.Ticket_Status.Name = "Ticket_Status";
			this.Ticket_Status.Properties.ReadOnly = true;
			this.spellChecker.SetShowSpellCheckMenu(this.Ticket_Status, true);
			this.Ticket_Status.Size = new System.Drawing.Size(218, 20);
			this.spellChecker.SetSpellCheckerOptions(this.Ticket_Status, optionsSpelling4);
			this.Ticket_Status.StyleController = this.layoutControl;
			this.Ticket_Status.TabIndex = 0;
			// 
			// Ticket_Description
			// 
			this.Ticket_Description.Location = new System.Drawing.Point(24, 167);
			this.Ticket_Description.Name = "Ticket_Description";
			this.spellChecker.SetShowSpellCheckMenu(this.Ticket_Description, true);
			this.Ticket_Description.Size = new System.Drawing.Size(302, 46);
			this.spellChecker.SetSpellCheckerOptions(this.Ticket_Description, optionsSpelling5);
			this.Ticket_Description.StyleController = this.layoutControl;
			this.Ticket_Description.TabIndex = 9;
			// 
			// Ticket_Code
			// 
			this.Ticket_Code.Location = new System.Drawing.Point(261, 12);
			this.Ticket_Code.Name = "Ticket_Code";
			this.Ticket_Code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.Ticket_Code.Properties.ReadOnly = true;
			this.Ticket_Code.Size = new System.Drawing.Size(77, 20);
			this.Ticket_Code.StyleController = this.layoutControl;
			this.Ticket_Code.TabIndex = 1;
			this.Ticket_Code.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Ticket_Code_ButtonClick);
			// 
			// Branch_Code
			// 
			this.Branch_Code.Location = new System.Drawing.Point(96, 36);
			this.Branch_Code.Name = "Branch_Code";
			this.Branch_Code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Branch_Code.Properties.NullText = "";
			this.Branch_Code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.Branch_Code.Size = new System.Drawing.Size(77, 20);
			this.Branch_Code.StyleController = this.layoutControl;
			this.Branch_Code.TabIndex = 2;
			// 
			// Ticket_Group
			// 
			this.Ticket_Group.Location = new System.Drawing.Point(261, 60);
			this.Ticket_Group.Name = "Ticket_Group";
			this.Ticket_Group.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Ticket_Group.Properties.NullText = "";
			this.Ticket_Group.Properties.TreeList = this.treeListLookUpEditTreeList;
			this.Ticket_Group.Size = new System.Drawing.Size(77, 20);
			this.Ticket_Group.StyleController = this.layoutControl;
			this.Ticket_Group.TabIndex = 5;
			// 
			// treeListLookUpEditTreeList
			// 
			this.treeListLookUpEditTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTicket_Group_Sub,
            this.colTicket_Description,
            this.colNotes});
			this.treeListLookUpEditTreeList.Location = new System.Drawing.Point(0, 0);
			this.treeListLookUpEditTreeList.Name = "treeListLookUpEditTreeList";
			this.treeListLookUpEditTreeList.OptionsView.ShowIndentAsRowStyle = true;
			this.treeListLookUpEditTreeList.Size = new System.Drawing.Size(400, 200);
			this.treeListLookUpEditTreeList.TabIndex = 0;
			// 
			// colTicket_Group_Sub
			// 
			this.colTicket_Group_Sub.Caption = "Group";
			this.colTicket_Group_Sub.FieldName = "Ticket_Group_Sub";
			this.colTicket_Group_Sub.Name = "colTicket_Group_Sub";
			this.colTicket_Group_Sub.Visible = true;
			this.colTicket_Group_Sub.VisibleIndex = 0;
			// 
			// colTicket_Description
			// 
			this.colTicket_Description.FieldName = "Ticket_Description";
			this.colTicket_Description.Name = "colTicket_Description";
			this.colTicket_Description.Visible = true;
			this.colTicket_Description.VisibleIndex = 1;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 2;
			// 
			// Created_By
			// 
			this.Created_By.Location = new System.Drawing.Point(261, 36);
			this.Created_By.Name = "Created_By";
			this.Created_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Created_By.Properties.NullText = "";
			this.Created_By.Properties.PopupSizeable = false;
			this.Created_By.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.Created_By.Size = new System.Drawing.Size(77, 20);
			this.Created_By.StyleController = this.layoutControl;
			this.Created_By.TabIndex = 3;
			// 
			// Report_Type
			// 
			this.Report_Type.Location = new System.Drawing.Point(96, 60);
			this.Report_Type.Name = "Report_Type";
			this.Report_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Report_Type.Properties.Items.AddRange(new object[] {
            "ACKNOWLEDGEMENT",
            "BRANCH",
            "DEPARTMENT",
            "INCIDENT",
            "LOGBOOK",
            "OTHERS",
            "PERSONAL",
            "PROJECT",
            "TICKET"});
			this.Report_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Report_Type.Size = new System.Drawing.Size(77, 20);
			this.Report_Type.StyleController = this.layoutControl;
			this.Report_Type.TabIndex = 4;
			// 
			// Communication_Type
			// 
			this.Communication_Type.Location = new System.Drawing.Point(96, 84);
			this.Communication_Type.Name = "Communication_Type";
			this.Communication_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Communication_Type.Size = new System.Drawing.Size(77, 20);
			this.Communication_Type.StyleController = this.layoutControl;
			this.Communication_Type.TabIndex = 6;
			// 
			// Ticket_Impact
			// 
			this.Ticket_Impact.Location = new System.Drawing.Point(108, 189);
			this.Ticket_Impact.Name = "Ticket_Impact";
			this.Ticket_Impact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Ticket_Impact.Properties.Items.AddRange(new object[] {
            "CRITICAL",
            "NORMAL",
            "SUSPENDED"});
			this.Ticket_Impact.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Ticket_Impact.Size = new System.Drawing.Size(218, 20);
			this.Ticket_Impact.StyleController = this.layoutControl;
			this.Ticket_Impact.TabIndex = 1;
			// 
			// Ticket_Urgency
			// 
			this.Ticket_Urgency.Location = new System.Drawing.Point(108, 213);
			this.Ticket_Urgency.Name = "Ticket_Urgency";
			this.Ticket_Urgency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Ticket_Urgency.Properties.Items.AddRange(new object[] {
            "HIGH",
            "MEDIUM",
            "LOW"});
			this.Ticket_Urgency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Ticket_Urgency.Size = new System.Drawing.Size(218, 20);
			this.Ticket_Urgency.StyleController = this.layoutControl;
			this.Ticket_Urgency.TabIndex = 2;
			// 
			// IsRecurrent
			// 
			this.IsRecurrent.EditValue = null;
			this.IsRecurrent.Location = new System.Drawing.Point(108, 167);
			this.IsRecurrent.Name = "IsRecurrent";
			this.IsRecurrent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.IsRecurrent.Properties.OffText = "Situational";
			this.IsRecurrent.Properties.OnText = "Frequent";
			this.IsRecurrent.Size = new System.Drawing.Size(218, 18);
			this.IsRecurrent.StyleController = this.layoutControl;
			this.IsRecurrent.TabIndex = 0;
			// 
			// Assigned_To
			// 
			this.Assigned_To.Location = new System.Drawing.Point(108, 261);
			this.Assigned_To.Name = "Assigned_To";
			this.Assigned_To.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Assigned_To.Properties.NullText = "";
			this.Assigned_To.Size = new System.Drawing.Size(218, 20);
			this.Assigned_To.StyleController = this.layoutControl;
			this.Assigned_To.TabIndex = 4;
			// 
			// Defect_Type
			// 
			this.Defect_Type.Location = new System.Drawing.Point(108, 237);
			this.Defect_Type.Name = "Defect_Type";
			this.Defect_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Defect_Type.Properties.Items.AddRange(new object[] {
            "NOT APPLICABLE",
            "SYSTEM",
            "USER"});
			this.Defect_Type.Properties.Sorted = true;
			this.Defect_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.Defect_Type.Size = new System.Drawing.Size(218, 20);
			this.Defect_Type.StyleController = this.layoutControl;
			this.Defect_Type.TabIndex = 3;
			// 
			// Added_By
			// 
			this.Added_By.Location = new System.Drawing.Point(108, 191);
			this.Added_By.Name = "Added_By";
			this.Added_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Added_By.Properties.NullText = "";
			this.Added_By.Properties.PopupSizeable = false;
			this.Added_By.Properties.ReadOnly = true;
			this.Added_By.Size = new System.Drawing.Size(218, 20);
			this.Added_By.StyleController = this.layoutControl;
			this.Added_By.TabIndex = 1;
			// 
			// Modified_By
			// 
			this.Modified_By.Location = new System.Drawing.Point(108, 215);
			this.Modified_By.Name = "Modified_By";
			this.Modified_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Modified_By.Properties.NullText = "";
			this.Modified_By.Properties.PopupSizeable = false;
			this.Modified_By.Properties.ReadOnly = true;
			this.Modified_By.Size = new System.Drawing.Size(218, 20);
			this.Modified_By.StyleController = this.layoutControl;
			this.Modified_By.TabIndex = 2;
			// 
			// Opened_By
			// 
			this.Opened_By.Location = new System.Drawing.Point(108, 239);
			this.Opened_By.Name = "Opened_By";
			this.Opened_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Opened_By.Properties.NullText = "";
			this.Opened_By.Properties.PopupSizeable = false;
			this.Opened_By.Properties.ReadOnly = true;
			this.Opened_By.Size = new System.Drawing.Size(218, 20);
			this.Opened_By.StyleController = this.layoutControl;
			this.Opened_By.TabIndex = 3;
			// 
			// Closed_By
			// 
			this.Closed_By.Location = new System.Drawing.Point(108, 263);
			this.Closed_By.Name = "Closed_By";
			this.Closed_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Closed_By.Properties.NullText = "";
			this.Closed_By.Properties.PopupSizeable = false;
			this.Closed_By.Properties.ReadOnly = true;
			this.Closed_By.Size = new System.Drawing.Size(218, 20);
			this.Closed_By.StyleController = this.layoutControl;
			this.Closed_By.TabIndex = 4;
			// 
			// Deleted_By
			// 
			this.Deleted_By.Location = new System.Drawing.Point(108, 287);
			this.Deleted_By.Name = "Deleted_By";
			this.Deleted_By.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Deleted_By.Properties.NullText = "";
			this.Deleted_By.Properties.PopupSizeable = false;
			this.Deleted_By.Properties.ReadOnly = true;
			this.Deleted_By.Size = new System.Drawing.Size(218, 20);
			this.Deleted_By.StyleController = this.layoutControl;
			this.Deleted_By.TabIndex = 5;
			// 
			// Incident_Date
			// 
			this.Incident_Date.EditValue = null;
			this.Incident_Date.Location = new System.Drawing.Point(261, 84);
			this.Incident_Date.Name = "Incident_Date";
			this.Incident_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Incident_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Incident_Date.Size = new System.Drawing.Size(77, 20);
			this.Incident_Date.StyleController = this.layoutControl;
			this.Incident_Date.TabIndex = 7;
			// 
			// Asset_Code
			// 
			this.Asset_Code.Location = new System.Drawing.Point(108, 285);
			this.Asset_Code.Name = "Asset_Code";
			this.Asset_Code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Asset_Code.Properties.NullText = "";
			this.Asset_Code.Properties.PopupSizeable = false;
			this.Asset_Code.Size = new System.Drawing.Size(218, 20);
			this.Asset_Code.StyleController = this.layoutControl;
			this.Asset_Code.TabIndex = 5;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem12,
            this.layoutControlItem9,
            this.layoutControlItem_Type,
            this.TabbedControlGroup1,
            this.layoutControlItem_Branch,
            this.layoutControlItem2,
            this.layoutControlItem_Created_By,
            this.layoutControlItem_Group,
            this.layoutControlItem17});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(350, 400);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.ID;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "LayoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem1.Text = "ID";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem12
			// 
			this.layoutControlItem12.Control = this.Ticket_Name;
			this.layoutControlItem12.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem12.Name = "LayoutControlItem12";
			this.layoutControlItem12.Size = new System.Drawing.Size(330, 24);
			this.layoutControlItem12.Text = "Name/Subject";
			this.layoutControlItem12.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.Communication_Type;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem9.Name = "LayoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem9.Text = "Communication";
			this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Type
			// 
			this.layoutControlItem_Type.Control = this.Report_Type;
			this.layoutControlItem_Type.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem_Type.Name = "LayoutControlItem_Type";
			this.layoutControlItem_Type.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem_Type.Text = "Type";
			this.layoutControlItem_Type.TextSize = new System.Drawing.Size(72, 13);
			// 
			// TabbedControlGroup1
			// 
			this.TabbedControlGroup1.Location = new System.Drawing.Point(0, 120);
			this.TabbedControlGroup1.Name = "TabbedControlGroup1";
			this.TabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
			this.TabbedControlGroup1.Size = new System.Drawing.Size(330, 260);
			this.TabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup_Support,
            this.layoutControlGroup4});
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem18,
            this.splitterItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "LayoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(306, 213);
			this.layoutControlGroup1.Text = "Description";
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.Ticket_Description;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(306, 50);
			this.layoutControlItem5.Text = "Description";
			this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem18
			// 
			this.layoutControlItem18.Control = this.Ticket_Attachment;
			this.layoutControlItem18.Location = new System.Drawing.Point(0, 60);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Size = new System.Drawing.Size(306, 153);
			this.layoutControlItem18.Text = "Attachment(s)";
			this.layoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem18.TextSize = new System.Drawing.Size(72, 13);
			// 
			// splitterItem1
			// 
			this.splitterItem1.AllowHotTrack = true;
			this.splitterItem1.Location = new System.Drawing.Point(0, 50);
			this.splitterItem1.Name = "splitterItem1";
			this.splitterItem1.Size = new System.Drawing.Size(306, 10);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "LayoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(306, 213);
			this.layoutControlGroup2.Text = "Solution";
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Ticket_Solution;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem4.Name = "LayoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(306, 213);
			this.layoutControlItem4.Text = "Solution";
			this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup3.Name = "LayoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(306, 213);
			this.layoutControlGroup3.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.Notes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "LayoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(306, 213);
			this.layoutControlItem6.Text = "Notes";
			this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// layoutControlGroup_Support
			// 
			this.layoutControlGroup_Support.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem_Impact,
            this.layoutControlItem_Urgency,
            this.EmptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem19});
			this.layoutControlGroup_Support.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup_Support.Name = "LayoutControlGroup_Support";
			this.layoutControlGroup_Support.Size = new System.Drawing.Size(306, 213);
			this.layoutControlGroup_Support.Text = "Support";
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.IsRecurrent;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "LayoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(306, 22);
			this.layoutControlItem3.Text = "Recurrence";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Impact
			// 
			this.layoutControlItem_Impact.Control = this.Ticket_Impact;
			this.layoutControlItem_Impact.Location = new System.Drawing.Point(0, 22);
			this.layoutControlItem_Impact.Name = "LayoutControlItem_Impact";
			this.layoutControlItem_Impact.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem_Impact.Text = "Impact";
			this.layoutControlItem_Impact.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Urgency
			// 
			this.layoutControlItem_Urgency.Control = this.Ticket_Urgency;
			this.layoutControlItem_Urgency.Location = new System.Drawing.Point(0, 46);
			this.layoutControlItem_Urgency.Name = "LayoutControlItem_Urgency";
			this.layoutControlItem_Urgency.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem_Urgency.Text = "Urgency";
			this.layoutControlItem_Urgency.TextSize = new System.Drawing.Size(72, 13);
			// 
			// EmptySpaceItem1
			// 
			this.EmptySpaceItem1.AllowHotTrack = false;
			this.EmptySpaceItem1.Location = new System.Drawing.Point(0, 142);
			this.EmptySpaceItem1.Name = "EmptySpaceItem1";
			this.EmptySpaceItem1.Size = new System.Drawing.Size(306, 71);
			this.EmptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.Assigned_To;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 94);
			this.layoutControlItem7.Name = "LayoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem7.Text = "Assigned To";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.Defect_Type;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 70);
			this.layoutControlItem8.Name = "LayoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem8.Text = "Deffect";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem19
			// 
			this.layoutControlItem19.Control = this.Asset_Code;
			this.layoutControlItem19.Location = new System.Drawing.Point(0, 118);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem19.Text = "Asset Code";
			this.layoutControlItem19.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup4.Name = "LayoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(306, 213);
			this.layoutControlGroup4.Text = "Others";
			// 
			// layoutControlItem10
			// 
			this.layoutControlItem10.Control = this.Ticket_Status;
			this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem10.Name = "LayoutControlItem10";
			this.layoutControlItem10.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem10.Text = "Status";
			this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem11
			// 
			this.layoutControlItem11.Control = this.Added_By;
			this.layoutControlItem11.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem11.Name = "LayoutControlItem11";
			this.layoutControlItem11.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem11.Text = "Added By";
			this.layoutControlItem11.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem13
			// 
			this.layoutControlItem13.Control = this.Modified_By;
			this.layoutControlItem13.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem13.Name = "LayoutControlItem13";
			this.layoutControlItem13.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem13.Text = "Modified By";
			this.layoutControlItem13.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem14
			// 
			this.layoutControlItem14.Control = this.Opened_By;
			this.layoutControlItem14.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem14.Name = "LayoutControlItem14";
			this.layoutControlItem14.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem14.Text = "Opened By";
			this.layoutControlItem14.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem15
			// 
			this.layoutControlItem15.Control = this.Closed_By;
			this.layoutControlItem15.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem15.Name = "LayoutControlItem15";
			this.layoutControlItem15.Size = new System.Drawing.Size(306, 24);
			this.layoutControlItem15.Text = "Closed By";
			this.layoutControlItem15.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem16
			// 
			this.layoutControlItem16.Control = this.Deleted_By;
			this.layoutControlItem16.Location = new System.Drawing.Point(0, 120);
			this.layoutControlItem16.Name = "LayoutControlItem16";
			this.layoutControlItem16.Size = new System.Drawing.Size(306, 93);
			this.layoutControlItem16.Text = "Deleted By";
			this.layoutControlItem16.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Branch
			// 
			this.layoutControlItem_Branch.Control = this.Branch_Code;
			this.layoutControlItem_Branch.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem_Branch.Name = "LayoutControlItem_Branch";
			this.layoutControlItem_Branch.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem_Branch.Text = "Branch";
			this.layoutControlItem_Branch.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Ticket_Code;
			this.layoutControlItem2.Location = new System.Drawing.Point(165, 0);
			this.layoutControlItem2.Name = "LayoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem2.Text = "Ticket Code";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Created_By
			// 
			this.layoutControlItem_Created_By.Control = this.Created_By;
			this.layoutControlItem_Created_By.Location = new System.Drawing.Point(165, 24);
			this.layoutControlItem_Created_By.Name = "LayoutControlItem_Created_By";
			this.layoutControlItem_Created_By.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem_Created_By.Text = "Reported By";
			this.layoutControlItem_Created_By.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem_Group
			// 
			this.layoutControlItem_Group.Control = this.Ticket_Group;
			this.layoutControlItem_Group.Location = new System.Drawing.Point(165, 48);
			this.layoutControlItem_Group.Name = "LayoutControlItem_Group";
			this.layoutControlItem_Group.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem_Group.Text = "Group";
			this.layoutControlItem_Group.TextSize = new System.Drawing.Size(72, 13);
			// 
			// layoutControlItem17
			// 
			this.layoutControlItem17.Control = this.Incident_Date;
			this.layoutControlItem17.Location = new System.Drawing.Point(165, 72);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Size = new System.Drawing.Size(165, 24);
			this.layoutControlItem17.Text = "Incident Date";
			this.layoutControlItem17.TextSize = new System.Drawing.Size(72, 13);
			// 
			// xuc_Ticket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Name = "xuc_Ticket";
			this.Size = new System.Drawing.Size(350, 400);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Solution.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Status.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Description.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Code.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Branch_Code.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Group.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditTreeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Created_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Report_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Communication_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Impact.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ticket_Urgency.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IsRecurrent.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Assigned_To.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Defect_Type.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Added_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Modified_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Opened_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Closed_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Deleted_By.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Incident_Date.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Incident_Date.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Asset_Code.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TabbedControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup_Support)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Impact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Urgency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Branch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Created_By)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
			this.ResumeLayout(false);

        }

        internal DevExpress.XtraLayout.LayoutControl layoutControl;
        internal DevExpress.XtraEditors.TextEdit ID;
        internal DevExpress.XtraEditors.ButtonEdit Ticket_Code;
        internal DevExpress.XtraEditors.MemoEdit Notes;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Group;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        internal DevExpress.XtraEditors.LookUpEdit Branch_Code;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Branch;
        internal DevExpress.XtraEditors.TextEdit Ticket_Name;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        internal DevExpress.XtraEditors.TreeListLookUpEdit Ticket_Group;
        internal DevExpress.XtraTreeList.TreeList treeListLookUpEditTreeList;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Group_Sub;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colTicket_Description;
        internal DevExpress.XtraTreeList.Columns.TreeListColumn colNotes;
        internal DevExpress.XtraEditors.MemoEdit Ticket_Solution;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        internal DevExpress.XtraEditors.LookUpEdit Created_By;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Created_By;
        internal DevExpress.XtraEditors.ComboBoxEdit Report_Type;
        internal DevExpress.XtraEditors.ComboBoxEdit Communication_Type;
        internal DevExpress.XtraEditors.ComboBoxEdit Ticket_Impact;
        internal DevExpress.XtraEditors.ComboBoxEdit Ticket_Urgency;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Type;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Impact;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Urgency;
        internal DevExpress.XtraEditors.ToggleSwitch IsRecurrent;
        internal DevExpress.XtraLayout.TabbedControlGroup TabbedControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup_Support;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        internal DevExpress.XtraLayout.EmptySpaceItem EmptySpaceItem1;
        internal DevExpress.XtraEditors.LookUpEdit Assigned_To;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        internal DevExpress.XtraEditors.ComboBoxEdit Defect_Type;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        internal DevExpress.XtraEditors.TextEdit Ticket_Status;
        internal DevExpress.XtraEditors.LookUpEdit Added_By;
        internal DevExpress.XtraEditors.LookUpEdit Modified_By;
        internal DevExpress.XtraEditors.LookUpEdit Opened_By;
        internal DevExpress.XtraEditors.LookUpEdit Closed_By;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        internal DevExpress.XtraEditors.LookUpEdit Deleted_By;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        internal DevExpress.XtraEditors.DateEdit Incident_Date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
		private DevExpress.XtraSpellChecker.SpellChecker spellChecker;
		internal DevExpress.XtraRichEdit.RichEditControl Ticket_Attachment;
		internal DevExpress.XtraEditors.MemoEdit Ticket_Description;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
		private DevExpress.XtraLayout.SplitterItem splitterItem1;
		internal DevExpress.XtraEditors.LookUpEdit Asset_Code;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
	}
}