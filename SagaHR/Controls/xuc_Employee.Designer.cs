using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SagaHR.Controls
{
    public partial class xuc_Employee : DevExpress.XtraEditors.XtraUserControl
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

		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be Modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		private void InitializeComponent()
        {
			this.Employee_Position = new DevExpress.XtraEditors.ComboBoxEdit();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.ID = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Civil_Status = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Birth_Place = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Code = new DevExpress.XtraEditors.TextEdit();
			this.Employee_ID = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Date_Birth = new DevExpress.XtraEditors.DateEdit();
			this.Employee_Contact = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Name = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Address = new DevExpress.XtraEditors.MemoEdit();
			this.Notes = new DevExpress.XtraEditors.MemoEdit();
			this.Employee_Department = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Branch = new DevExpress.XtraEditors.LookUpEdit();
			this.Employee_PAG_IBIG = new DevExpress.XtraEditors.TextEdit();
			this.Employee_PHIC = new DevExpress.XtraEditors.TextEdit();
			this.Employee_SSS = new DevExpress.XtraEditors.TextEdit();
			this.Employee_TIN = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Corporation = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Date_Probationary = new DevExpress.XtraEditors.DateEdit();
			this.Employee_Date_Hired = new DevExpress.XtraEditors.DateEdit();
			this.Employee_Pay_Level = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Pay_Class = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Status = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Date_Regular = new DevExpress.XtraEditors.DateEdit();
			this.Employee_Driver_License_Expiry = new DevExpress.XtraEditors.DateEdit();
			this.Employee_Driver_License = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Name_Spouse = new DevExpress.XtraEditors.TextEdit();
			this.Employee_Children = new DevExpress.XtraEditors.MemoEdit();
			this.Employee_Course = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employee_Attainment = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Employment_Status = new DevExpress.XtraEditors.ComboBoxEdit();
			this.Departed_Date = new DevExpress.XtraEditors.DateEdit();
			this.Engine = new DevExpress.XtraEditors.LookUpEdit();
			this.Chassis = new DevExpress.XtraEditors.TextEdit();
			this.Plate_Number = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.XtraTabControl1item = new DevExpress.XtraLayout.TabbedControlGroup();
			this.XtraTabPage1item = new DevExpress.XtraLayout.LayoutControlGroup();
			this.Employee_Civil_Statusitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Birth_Placeitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Codeitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_IDitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Date_Birthitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Contactitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Nameitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Addressitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Notesitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.XtraTabPage2item = new DevExpress.XtraLayout.LayoutControlGroup();
			this.Employee_Departmentitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Branchitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_PAG_IBIGitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_PHICitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_SSSitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_TINitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Corporationitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Positionitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Date_Probationaryitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Date_Hireditem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Pay_Levelitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Pay_Classitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Statusitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Date_Regularitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.XtraTabPage3item = new DevExpress.XtraLayout.LayoutControlGroup();
			this.Employee_Driver_License_Expiryitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Driver_Licenseitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Name_Spouseitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Childrenitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Courseitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.Employee_Attainmentitem = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Position.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Civil_Status.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Birth_Place.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Code.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_ID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birth.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birth.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Contact.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Address.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Department.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Branch.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PAG_IBIG.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PHIC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_SSS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_TIN.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Corporation.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationary.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationary.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hired.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hired.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Level.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Class.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Status.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regular.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regular.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiry.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiry.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name_Spouse.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Children.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Course.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Attainment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employment_Status.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Departed_Date.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Departed_Date.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Engine.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chassis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Plate_Number.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage1item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Civil_Statusitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Birth_Placeitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Codeitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_IDitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birthitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Contactitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Nameitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Addressitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Notesitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage2item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Departmentitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Branchitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PAG_IBIGitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PHICitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_SSSitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_TINitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Corporationitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Positionitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationaryitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hireditem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Levelitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Classitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Statusitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regularitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage3item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiryitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_Licenseitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name_Spouseitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Childrenitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Courseitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Attainmentitem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// Employee_Position
			// 
			this.Employee_Position.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Position.Location = new System.Drawing.Point(123, 119);
			this.Employee_Position.Name = "Employee_Position";
			this.Employee_Position.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Position.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Employee_Position.Size = new System.Drawing.Size(153, 20);
			this.Employee_Position.StyleController = this.layoutControl;
			this.Employee_Position.TabIndex = 3;
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.ID);
			this.layoutControl.Controls.Add(this.Employee_Civil_Status);
			this.layoutControl.Controls.Add(this.Employee_Birth_Place);
			this.layoutControl.Controls.Add(this.Employee_Code);
			this.layoutControl.Controls.Add(this.Employee_ID);
			this.layoutControl.Controls.Add(this.Employee_Date_Birth);
			this.layoutControl.Controls.Add(this.Employee_Contact);
			this.layoutControl.Controls.Add(this.Employee_Name);
			this.layoutControl.Controls.Add(this.Employee_Address);
			this.layoutControl.Controls.Add(this.Notes);
			this.layoutControl.Controls.Add(this.Employee_Department);
			this.layoutControl.Controls.Add(this.Employee_Branch);
			this.layoutControl.Controls.Add(this.Employee_PAG_IBIG);
			this.layoutControl.Controls.Add(this.Employee_PHIC);
			this.layoutControl.Controls.Add(this.Employee_SSS);
			this.layoutControl.Controls.Add(this.Employee_TIN);
			this.layoutControl.Controls.Add(this.Employee_Corporation);
			this.layoutControl.Controls.Add(this.Employee_Position);
			this.layoutControl.Controls.Add(this.Employee_Date_Probationary);
			this.layoutControl.Controls.Add(this.Employee_Date_Hired);
			this.layoutControl.Controls.Add(this.Employee_Pay_Level);
			this.layoutControl.Controls.Add(this.Employee_Pay_Class);
			this.layoutControl.Controls.Add(this.Employee_Status);
			this.layoutControl.Controls.Add(this.Employee_Date_Regular);
			this.layoutControl.Controls.Add(this.Employee_Driver_License_Expiry);
			this.layoutControl.Controls.Add(this.Employee_Driver_License);
			this.layoutControl.Controls.Add(this.Employee_Name_Spouse);
			this.layoutControl.Controls.Add(this.Employee_Children);
			this.layoutControl.Controls.Add(this.Employee_Course);
			this.layoutControl.Controls.Add(this.Employee_Attainment);
			this.layoutControl.Controls.Add(this.Employment_Status);
			this.layoutControl.Controls.Add(this.Departed_Date);
			this.layoutControl.Controls.Add(this.Engine);
			this.layoutControl.Controls.Add(this.Chassis);
			this.layoutControl.Controls.Add(this.Plate_Number);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.layoutControlGroup1;
			this.layoutControl.Size = new System.Drawing.Size(300, 450);
			this.layoutControl.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.Location = new System.Drawing.Point(123, 47);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(153, 20);
			this.ID.StyleController = this.layoutControl;
			this.ID.TabIndex = 0;
			// 
			// Employee_Civil_Status
			// 
			this.Employee_Civil_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Civil_Status.Location = new System.Drawing.Point(123, 263);
			this.Employee_Civil_Status.Name = "Employee_Civil_Status";
			this.Employee_Civil_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Civil_Status.Size = new System.Drawing.Size(153, 20);
			this.Employee_Civil_Status.StyleController = this.layoutControl;
			this.Employee_Civil_Status.TabIndex = 8;
			// 
			// Employee_Birth_Place
			// 
			this.Employee_Birth_Place.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Birth_Place.Location = new System.Drawing.Point(123, 239);
			this.Employee_Birth_Place.Name = "Employee_Birth_Place";
			this.Employee_Birth_Place.Size = new System.Drawing.Size(153, 20);
			this.Employee_Birth_Place.StyleController = this.layoutControl;
			this.Employee_Birth_Place.TabIndex = 7;
			// 
			// Employee_Code
			// 
			this.Employee_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Code.Location = new System.Drawing.Point(123, 71);
			this.Employee_Code.Name = "Employee_Code";
			this.Employee_Code.Properties.ReadOnly = true;
			this.Employee_Code.Size = new System.Drawing.Size(153, 20);
			this.Employee_Code.StyleController = this.layoutControl;
			this.Employee_Code.TabIndex = 1;
			// 
			// Employee_ID
			// 
			this.Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_ID.Location = new System.Drawing.Point(123, 95);
			this.Employee_ID.Name = "Employee_ID";
			this.Employee_ID.Size = new System.Drawing.Size(153, 20);
			this.Employee_ID.StyleController = this.layoutControl;
			this.Employee_ID.TabIndex = 2;
			// 
			// Employee_Date_Birth
			// 
			this.Employee_Date_Birth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Date_Birth.EditValue = new System.DateTime(2021, 2, 6, 0, 0, 0, 0);
			this.Employee_Date_Birth.Location = new System.Drawing.Point(123, 215);
			this.Employee_Date_Birth.Name = "Employee_Date_Birth";
			this.Employee_Date_Birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Birth.Size = new System.Drawing.Size(153, 20);
			this.Employee_Date_Birth.StyleController = this.layoutControl;
			this.Employee_Date_Birth.TabIndex = 6;
			// 
			// Employee_Contact
			// 
			this.Employee_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Contact.Location = new System.Drawing.Point(123, 191);
			this.Employee_Contact.Name = "Employee_Contact";
			this.Employee_Contact.Size = new System.Drawing.Size(153, 20);
			this.Employee_Contact.StyleController = this.layoutControl;
			this.Employee_Contact.TabIndex = 5;
			// 
			// Employee_Name
			// 
			this.Employee_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Name.Location = new System.Drawing.Point(123, 119);
			this.Employee_Name.Name = "Employee_Name";
			this.Employee_Name.Size = new System.Drawing.Size(153, 20);
			this.Employee_Name.StyleController = this.layoutControl;
			this.Employee_Name.TabIndex = 3;
			// 
			// Employee_Address
			// 
			this.Employee_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Address.Location = new System.Drawing.Point(123, 143);
			this.Employee_Address.Name = "Employee_Address";
			this.Employee_Address.Size = new System.Drawing.Size(153, 44);
			this.Employee_Address.StyleController = this.layoutControl;
			this.Employee_Address.TabIndex = 4;
			// 
			// Notes
			// 
			this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Notes.Location = new System.Drawing.Point(123, 287);
			this.Notes.Name = "Notes";
			this.Notes.Size = new System.Drawing.Size(153, 139);
			this.Notes.StyleController = this.layoutControl;
			this.Notes.TabIndex = 9;
			// 
			// Employee_Department
			// 
			this.Employee_Department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Department.Location = new System.Drawing.Point(123, 95);
			this.Employee_Department.Name = "Employee_Department";
			this.Employee_Department.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Department.Size = new System.Drawing.Size(153, 20);
			this.Employee_Department.StyleController = this.layoutControl;
			this.Employee_Department.TabIndex = 2;
			// 
			// Employee_Branch
			// 
			this.Employee_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Branch.Location = new System.Drawing.Point(123, 71);
			this.Employee_Branch.Name = "Employee_Branch";
			this.Employee_Branch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Branch.Size = new System.Drawing.Size(153, 20);
			this.Employee_Branch.StyleController = this.layoutControl;
			this.Employee_Branch.TabIndex = 1;
			// 
			// Employee_PAG_IBIG
			// 
			this.Employee_PAG_IBIG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_PAG_IBIG.Location = new System.Drawing.Point(123, 359);
			this.Employee_PAG_IBIG.Name = "Employee_PAG_IBIG";
			this.Employee_PAG_IBIG.Size = new System.Drawing.Size(153, 20);
			this.Employee_PAG_IBIG.StyleController = this.layoutControl;
			this.Employee_PAG_IBIG.TabIndex = 13;
			// 
			// Employee_PHIC
			// 
			this.Employee_PHIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_PHIC.Location = new System.Drawing.Point(123, 335);
			this.Employee_PHIC.Name = "Employee_PHIC";
			this.Employee_PHIC.Size = new System.Drawing.Size(153, 20);
			this.Employee_PHIC.StyleController = this.layoutControl;
			this.Employee_PHIC.TabIndex = 12;
			// 
			// Employee_SSS
			// 
			this.Employee_SSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_SSS.Location = new System.Drawing.Point(123, 311);
			this.Employee_SSS.Name = "Employee_SSS";
			this.Employee_SSS.Size = new System.Drawing.Size(153, 20);
			this.Employee_SSS.StyleController = this.layoutControl;
			this.Employee_SSS.TabIndex = 11;
			// 
			// Employee_TIN
			// 
			this.Employee_TIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_TIN.Location = new System.Drawing.Point(123, 287);
			this.Employee_TIN.Name = "Employee_TIN";
			this.Employee_TIN.Size = new System.Drawing.Size(153, 20);
			this.Employee_TIN.StyleController = this.layoutControl;
			this.Employee_TIN.TabIndex = 10;
			// 
			// Employee_Corporation
			// 
			this.Employee_Corporation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Corporation.Location = new System.Drawing.Point(123, 47);
			this.Employee_Corporation.Name = "Employee_Corporation";
			this.Employee_Corporation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Corporation.Properties.Items.AddRange(new object[] {
            "SAGA FINANCE",
            "SAGA MOTORS"});
			this.Employee_Corporation.Size = new System.Drawing.Size(153, 20);
			this.Employee_Corporation.StyleController = this.layoutControl;
			this.Employee_Corporation.TabIndex = 0;
			// 
			// Employee_Date_Probationary
			// 
			this.Employee_Date_Probationary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Date_Probationary.EditValue = new System.DateTime(2021, 2, 6, 0, 0, 0, 0);
			this.Employee_Date_Probationary.Location = new System.Drawing.Point(123, 239);
			this.Employee_Date_Probationary.Name = "Employee_Date_Probationary";
			this.Employee_Date_Probationary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Probationary.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Probationary.Size = new System.Drawing.Size(153, 20);
			this.Employee_Date_Probationary.StyleController = this.layoutControl;
			this.Employee_Date_Probationary.TabIndex = 8;
			// 
			// Employee_Date_Hired
			// 
			this.Employee_Date_Hired.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Date_Hired.EditValue = new System.DateTime(2021, 2, 6, 0, 0, 0, 0);
			this.Employee_Date_Hired.Location = new System.Drawing.Point(123, 215);
			this.Employee_Date_Hired.Name = "Employee_Date_Hired";
			this.Employee_Date_Hired.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Hired.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Hired.Size = new System.Drawing.Size(153, 20);
			this.Employee_Date_Hired.StyleController = this.layoutControl;
			this.Employee_Date_Hired.TabIndex = 7;
			// 
			// Employee_Pay_Level
			// 
			this.Employee_Pay_Level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Pay_Level.Location = new System.Drawing.Point(123, 143);
			this.Employee_Pay_Level.Name = "Employee_Pay_Level";
			this.Employee_Pay_Level.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Pay_Level.Size = new System.Drawing.Size(153, 20);
			this.Employee_Pay_Level.StyleController = this.layoutControl;
			this.Employee_Pay_Level.TabIndex = 4;
			// 
			// Employee_Pay_Class
			// 
			this.Employee_Pay_Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Pay_Class.Location = new System.Drawing.Point(123, 167);
			this.Employee_Pay_Class.Name = "Employee_Pay_Class";
			this.Employee_Pay_Class.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Pay_Class.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Employee_Pay_Class.Size = new System.Drawing.Size(153, 20);
			this.Employee_Pay_Class.StyleController = this.layoutControl;
			this.Employee_Pay_Class.TabIndex = 5;
			// 
			// Employee_Status
			// 
			this.Employee_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Status.Location = new System.Drawing.Point(123, 191);
			this.Employee_Status.Name = "Employee_Status";
			this.Employee_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Status.Size = new System.Drawing.Size(153, 20);
			this.Employee_Status.StyleController = this.layoutControl;
			this.Employee_Status.TabIndex = 6;
			// 
			// Employee_Date_Regular
			// 
			this.Employee_Date_Regular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Date_Regular.EditValue = new System.DateTime(2021, 2, 6, 0, 0, 0, 0);
			this.Employee_Date_Regular.Location = new System.Drawing.Point(123, 263);
			this.Employee_Date_Regular.Name = "Employee_Date_Regular";
			this.Employee_Date_Regular.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Regular.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Date_Regular.Size = new System.Drawing.Size(153, 20);
			this.Employee_Date_Regular.StyleController = this.layoutControl;
			this.Employee_Date_Regular.TabIndex = 9;
			// 
			// Employee_Driver_License_Expiry
			// 
			this.Employee_Driver_License_Expiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Driver_License_Expiry.EditValue = new System.DateTime(2021, 2, 6, 0, 0, 0, 0);
			this.Employee_Driver_License_Expiry.Location = new System.Drawing.Point(123, 334);
			this.Employee_Driver_License_Expiry.Name = "Employee_Driver_License_Expiry";
			this.Employee_Driver_License_Expiry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Driver_License_Expiry.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Driver_License_Expiry.Size = new System.Drawing.Size(153, 20);
			this.Employee_Driver_License_Expiry.StyleController = this.layoutControl;
			this.Employee_Driver_License_Expiry.TabIndex = 5;
			// 
			// Employee_Driver_License
			// 
			this.Employee_Driver_License.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Driver_License.Location = new System.Drawing.Point(123, 310);
			this.Employee_Driver_License.Name = "Employee_Driver_License";
			this.Employee_Driver_License.Size = new System.Drawing.Size(153, 20);
			this.Employee_Driver_License.StyleController = this.layoutControl;
			this.Employee_Driver_License.TabIndex = 4;
			// 
			// Employee_Name_Spouse
			// 
			this.Employee_Name_Spouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Name_Spouse.Location = new System.Drawing.Point(123, 95);
			this.Employee_Name_Spouse.Name = "Employee_Name_Spouse";
			this.Employee_Name_Spouse.Size = new System.Drawing.Size(153, 20);
			this.Employee_Name_Spouse.StyleController = this.layoutControl;
			this.Employee_Name_Spouse.TabIndex = 2;
			// 
			// Employee_Children
			// 
			this.Employee_Children.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Children.Location = new System.Drawing.Point(123, 119);
			this.Employee_Children.Name = "Employee_Children";
			this.Employee_Children.Size = new System.Drawing.Size(153, 187);
			this.Employee_Children.StyleController = this.layoutControl;
			this.Employee_Children.TabIndex = 3;
			// 
			// Employee_Course
			// 
			this.Employee_Course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Course.Location = new System.Drawing.Point(123, 71);
			this.Employee_Course.Name = "Employee_Course";
			this.Employee_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Course.Size = new System.Drawing.Size(153, 20);
			this.Employee_Course.StyleController = this.layoutControl;
			this.Employee_Course.TabIndex = 1;
			// 
			// Employee_Attainment
			// 
			this.Employee_Attainment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Employee_Attainment.Location = new System.Drawing.Point(123, 47);
			this.Employee_Attainment.Name = "Employee_Attainment";
			this.Employee_Attainment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employee_Attainment.Size = new System.Drawing.Size(153, 20);
			this.Employee_Attainment.StyleController = this.layoutControl;
			this.Employee_Attainment.TabIndex = 0;
			// 
			// Employment_Status
			// 
			this.Employment_Status.Location = new System.Drawing.Point(123, 47);
			this.Employment_Status.Name = "Employment_Status";
			this.Employment_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Employment_Status.Size = new System.Drawing.Size(153, 20);
			this.Employment_Status.StyleController = this.layoutControl;
			this.Employment_Status.TabIndex = 0;
			// 
			// Departed_Date
			// 
			this.Departed_Date.EditValue = null;
			this.Departed_Date.Location = new System.Drawing.Point(123, 71);
			this.Departed_Date.Name = "Departed_Date";
			this.Departed_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Departed_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Departed_Date.Size = new System.Drawing.Size(153, 20);
			this.Departed_Date.StyleController = this.layoutControl;
			this.Departed_Date.TabIndex = 1;
			// 
			// Engine
			// 
			this.Engine.Location = new System.Drawing.Point(123, 358);
			this.Engine.Name = "Engine";
			this.Engine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.Engine.Properties.NullText = "";
			this.Engine.Size = new System.Drawing.Size(153, 20);
			this.Engine.StyleController = this.layoutControl;
			this.Engine.TabIndex = 6;
			// 
			// Chassis
			// 
			this.Chassis.Location = new System.Drawing.Point(123, 382);
			this.Chassis.Name = "Chassis";
			this.Chassis.Size = new System.Drawing.Size(153, 20);
			this.Chassis.StyleController = this.layoutControl;
			this.Chassis.TabIndex = 7;
			// 
			// Plate_Number
			// 
			this.Plate_Number.Location = new System.Drawing.Point(123, 406);
			this.Plate_Number.Name = "Plate_Number";
			this.Plate_Number.Size = new System.Drawing.Size(153, 20);
			this.Plate_Number.StyleController = this.layoutControl;
			this.Plate_Number.TabIndex = 8;
			// 
			// LayoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.XtraTabControl1item});
			this.layoutControlGroup1.Name = "LayoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(300, 450);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// XtraTabControl1item
			// 
			this.XtraTabControl1item.Location = new System.Drawing.Point(0, 0);
			this.XtraTabControl1item.Name = "XtraTabControl1item";
			this.XtraTabControl1item.SelectedTabPage = this.XtraTabPage1item;
			this.XtraTabControl1item.Size = new System.Drawing.Size(280, 430);
			this.XtraTabControl1item.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.XtraTabPage1item,
            this.XtraTabPage2item,
            this.XtraTabPage3item,
            this.layoutControlGroup2});
			// 
			// XtraTabPage1item
			// 
			this.XtraTabPage1item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Employee_Civil_Statusitem,
            this.Employee_Birth_Placeitem,
            this.Employee_Codeitem,
            this.Employee_IDitem,
            this.Employee_Date_Birthitem,
            this.Employee_Contactitem,
            this.Employee_Nameitem,
            this.Employee_Addressitem,
            this.Notesitem,
            this.layoutControlItem1});
			this.XtraTabPage1item.Location = new System.Drawing.Point(0, 0);
			this.XtraTabPage1item.Name = "XtraTabPage1item";
			this.XtraTabPage1item.Size = new System.Drawing.Size(256, 383);
			this.XtraTabPage1item.Text = "Basic";
			// 
			// Employee_Civil_Statusitem
			// 
			this.Employee_Civil_Statusitem.Control = this.Employee_Civil_Status;
			this.Employee_Civil_Statusitem.Location = new System.Drawing.Point(0, 216);
			this.Employee_Civil_Statusitem.Name = "Employee_Civil_Statusitem";
			this.Employee_Civil_Statusitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Civil_Statusitem.Text = "Civil Status";
			this.Employee_Civil_Statusitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Civil_Statusitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Birth_Placeitem
			// 
			this.Employee_Birth_Placeitem.Control = this.Employee_Birth_Place;
			this.Employee_Birth_Placeitem.Location = new System.Drawing.Point(0, 192);
			this.Employee_Birth_Placeitem.Name = "Employee_Birth_Placeitem";
			this.Employee_Birth_Placeitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Birth_Placeitem.Text = "Birthplace";
			this.Employee_Birth_Placeitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Birth_Placeitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Codeitem
			// 
			this.Employee_Codeitem.Control = this.Employee_Code;
			this.Employee_Codeitem.Location = new System.Drawing.Point(0, 24);
			this.Employee_Codeitem.Name = "Employee_Codeitem";
			this.Employee_Codeitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Codeitem.Text = "Code";
			this.Employee_Codeitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Codeitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_IDitem
			// 
			this.Employee_IDitem.Control = this.Employee_ID;
			this.Employee_IDitem.Location = new System.Drawing.Point(0, 48);
			this.Employee_IDitem.Name = "Employee_IDitem";
			this.Employee_IDitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_IDitem.Text = "ID #";
			this.Employee_IDitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_IDitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Date_Birthitem
			// 
			this.Employee_Date_Birthitem.Control = this.Employee_Date_Birth;
			this.Employee_Date_Birthitem.Location = new System.Drawing.Point(0, 168);
			this.Employee_Date_Birthitem.Name = "Employee_Date_Birthitem";
			this.Employee_Date_Birthitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Date_Birthitem.Text = "Birthdate";
			this.Employee_Date_Birthitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Date_Birthitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Contactitem
			// 
			this.Employee_Contactitem.Control = this.Employee_Contact;
			this.Employee_Contactitem.Location = new System.Drawing.Point(0, 144);
			this.Employee_Contactitem.Name = "Employee_Contactitem";
			this.Employee_Contactitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Contactitem.Text = "Contact #";
			this.Employee_Contactitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Contactitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Nameitem
			// 
			this.Employee_Nameitem.Control = this.Employee_Name;
			this.Employee_Nameitem.Location = new System.Drawing.Point(0, 72);
			this.Employee_Nameitem.Name = "Employee_Nameitem";
			this.Employee_Nameitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Nameitem.Text = "Name";
			this.Employee_Nameitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Nameitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Addressitem
			// 
			this.Employee_Addressitem.Control = this.Employee_Address;
			this.Employee_Addressitem.Location = new System.Drawing.Point(0, 96);
			this.Employee_Addressitem.MaxSize = new System.Drawing.Size(0, 48);
			this.Employee_Addressitem.MinSize = new System.Drawing.Size(104, 48);
			this.Employee_Addressitem.Name = "Employee_Addressitem";
			this.Employee_Addressitem.Size = new System.Drawing.Size(256, 48);
			this.Employee_Addressitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.Employee_Addressitem.Text = "Address";
			this.Employee_Addressitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Addressitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Notesitem
			// 
			this.Notesitem.Control = this.Notes;
			this.Notesitem.Location = new System.Drawing.Point(0, 240);
			this.Notesitem.Name = "Notesitem";
			this.Notesitem.Size = new System.Drawing.Size(256, 143);
			this.Notesitem.Text = "Notes";
			this.Notesitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Notesitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlItem1
			// 
			this.layoutControlItem1.Control = this.ID;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "LayoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(256, 24);
			this.layoutControlItem1.Text = "ID";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
			// 
			// XtraTabPage2item
			// 
			this.XtraTabPage2item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Employee_Departmentitem,
            this.Employee_Branchitem,
            this.Employee_PAG_IBIGitem,
            this.Employee_PHICitem,
            this.Employee_SSSitem,
            this.Employee_TINitem,
            this.Employee_Corporationitem,
            this.Employee_Positionitem,
            this.Employee_Date_Probationaryitem,
            this.Employee_Date_Hireditem,
            this.Employee_Pay_Levelitem,
            this.Employee_Pay_Classitem,
            this.Employee_Statusitem,
            this.Employee_Date_Regularitem});
			this.XtraTabPage2item.Location = new System.Drawing.Point(0, 0);
			this.XtraTabPage2item.Name = "XtraTabPage2item";
			this.XtraTabPage2item.Size = new System.Drawing.Size(256, 383);
			this.XtraTabPage2item.Text = "Employment";
			// 
			// Employee_Departmentitem
			// 
			this.Employee_Departmentitem.Control = this.Employee_Department;
			this.Employee_Departmentitem.Location = new System.Drawing.Point(0, 48);
			this.Employee_Departmentitem.Name = "Employee_Departmentitem";
			this.Employee_Departmentitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Departmentitem.Text = "Department";
			this.Employee_Departmentitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Departmentitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Branchitem
			// 
			this.Employee_Branchitem.Control = this.Employee_Branch;
			this.Employee_Branchitem.Location = new System.Drawing.Point(0, 24);
			this.Employee_Branchitem.Name = "Employee_Branchitem";
			this.Employee_Branchitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Branchitem.Text = "Branch";
			this.Employee_Branchitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Branchitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_PAG_IBIGitem
			// 
			this.Employee_PAG_IBIGitem.Control = this.Employee_PAG_IBIG;
			this.Employee_PAG_IBIGitem.Location = new System.Drawing.Point(0, 312);
			this.Employee_PAG_IBIGitem.Name = "Employee_PAG_IBIGitem";
			this.Employee_PAG_IBIGitem.Size = new System.Drawing.Size(256, 71);
			this.Employee_PAG_IBIGitem.Text = "PAG-IBIG";
			this.Employee_PAG_IBIGitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_PAG_IBIGitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_PHICitem
			// 
			this.Employee_PHICitem.Control = this.Employee_PHIC;
			this.Employee_PHICitem.Location = new System.Drawing.Point(0, 288);
			this.Employee_PHICitem.Name = "Employee_PHICitem";
			this.Employee_PHICitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_PHICitem.Text = "PHIC #";
			this.Employee_PHICitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_PHICitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_SSSitem
			// 
			this.Employee_SSSitem.Control = this.Employee_SSS;
			this.Employee_SSSitem.Location = new System.Drawing.Point(0, 264);
			this.Employee_SSSitem.Name = "Employee_SSSitem";
			this.Employee_SSSitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_SSSitem.Text = "SSS #";
			this.Employee_SSSitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_SSSitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_TINitem
			// 
			this.Employee_TINitem.Control = this.Employee_TIN;
			this.Employee_TINitem.Location = new System.Drawing.Point(0, 240);
			this.Employee_TINitem.Name = "Employee_TINitem";
			this.Employee_TINitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_TINitem.Text = "TIN #";
			this.Employee_TINitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_TINitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Corporationitem
			// 
			this.Employee_Corporationitem.Control = this.Employee_Corporation;
			this.Employee_Corporationitem.Location = new System.Drawing.Point(0, 0);
			this.Employee_Corporationitem.Name = "Employee_Corporationitem";
			this.Employee_Corporationitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Corporationitem.Text = "Corporation";
			this.Employee_Corporationitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Corporationitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Positionitem
			// 
			this.Employee_Positionitem.Control = this.Employee_Position;
			this.Employee_Positionitem.Location = new System.Drawing.Point(0, 72);
			this.Employee_Positionitem.Name = "Employee_Positionitem";
			this.Employee_Positionitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Positionitem.Text = "Position";
			this.Employee_Positionitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Positionitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Date_Probationaryitem
			// 
			this.Employee_Date_Probationaryitem.Control = this.Employee_Date_Probationary;
			this.Employee_Date_Probationaryitem.Location = new System.Drawing.Point(0, 192);
			this.Employee_Date_Probationaryitem.Name = "Employee_Date_Probationaryitem";
			this.Employee_Date_Probationaryitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Date_Probationaryitem.Text = "Probationary";
			this.Employee_Date_Probationaryitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Date_Probationaryitem.TextSize = new System.Drawing.Size(87, 13);
			this.Employee_Date_Probationaryitem.DoubleClick += new System.EventHandler(this.Employee_Date_Probationaryitem_DoubleClick);
			// 
			// Employee_Date_Hireditem
			// 
			this.Employee_Date_Hireditem.Control = this.Employee_Date_Hired;
			this.Employee_Date_Hireditem.Location = new System.Drawing.Point(0, 168);
			this.Employee_Date_Hireditem.Name = "Employee_Date_Hireditem";
			this.Employee_Date_Hireditem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Date_Hireditem.Text = "Date Hired";
			this.Employee_Date_Hireditem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Date_Hireditem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Pay_Levelitem
			// 
			this.Employee_Pay_Levelitem.Control = this.Employee_Pay_Level;
			this.Employee_Pay_Levelitem.Location = new System.Drawing.Point(0, 96);
			this.Employee_Pay_Levelitem.Name = "Employee_Pay_Levelitem";
			this.Employee_Pay_Levelitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Pay_Levelitem.Text = "Pay Level";
			this.Employee_Pay_Levelitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Pay_Levelitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Pay_Classitem
			// 
			this.Employee_Pay_Classitem.Control = this.Employee_Pay_Class;
			this.Employee_Pay_Classitem.Location = new System.Drawing.Point(0, 120);
			this.Employee_Pay_Classitem.Name = "Employee_Pay_Classitem";
			this.Employee_Pay_Classitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Pay_Classitem.Text = "Pay Class";
			this.Employee_Pay_Classitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Pay_Classitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Statusitem
			// 
			this.Employee_Statusitem.Control = this.Employee_Status;
			this.Employee_Statusitem.Location = new System.Drawing.Point(0, 144);
			this.Employee_Statusitem.Name = "Employee_Statusitem";
			this.Employee_Statusitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Statusitem.Text = "Emp. Status";
			this.Employee_Statusitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Statusitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Date_Regularitem
			// 
			this.Employee_Date_Regularitem.Control = this.Employee_Date_Regular;
			this.Employee_Date_Regularitem.Location = new System.Drawing.Point(0, 216);
			this.Employee_Date_Regularitem.Name = "Employee_Date_Regularitem";
			this.Employee_Date_Regularitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Date_Regularitem.Text = "Regularized";
			this.Employee_Date_Regularitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Date_Regularitem.TextSize = new System.Drawing.Size(87, 13);
			this.Employee_Date_Regularitem.DoubleClick += new System.EventHandler(this.Employee_Date_Regularitem_Click);
			// 
			// XtraTabPage3item
			// 
			this.XtraTabPage3item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Employee_Driver_License_Expiryitem,
            this.Employee_Driver_Licenseitem,
            this.Employee_Name_Spouseitem,
            this.Employee_Childrenitem,
            this.Employee_Courseitem,
            this.Employee_Attainmentitem,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.XtraTabPage3item.Location = new System.Drawing.Point(0, 0);
			this.XtraTabPage3item.Name = "XtraTabPage3item";
			this.XtraTabPage3item.Size = new System.Drawing.Size(256, 383);
			this.XtraTabPage3item.Text = "Others";
			// 
			// Employee_Driver_License_Expiryitem
			// 
			this.Employee_Driver_License_Expiryitem.Control = this.Employee_Driver_License_Expiry;
			this.Employee_Driver_License_Expiryitem.Location = new System.Drawing.Point(0, 287);
			this.Employee_Driver_License_Expiryitem.Name = "Employee_Driver_License_Expiryitem";
			this.Employee_Driver_License_Expiryitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Driver_License_Expiryitem.Text = "Date Expiry";
			this.Employee_Driver_License_Expiryitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Driver_License_Expiryitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Driver_Licenseitem
			// 
			this.Employee_Driver_Licenseitem.Control = this.Employee_Driver_License;
			this.Employee_Driver_Licenseitem.Location = new System.Drawing.Point(0, 263);
			this.Employee_Driver_Licenseitem.Name = "Employee_Driver_Licenseitem";
			this.Employee_Driver_Licenseitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Driver_Licenseitem.Text = "Driver\'s License";
			this.Employee_Driver_Licenseitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Driver_Licenseitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Name_Spouseitem
			// 
			this.Employee_Name_Spouseitem.Control = this.Employee_Name_Spouse;
			this.Employee_Name_Spouseitem.Location = new System.Drawing.Point(0, 48);
			this.Employee_Name_Spouseitem.Name = "Employee_Name_Spouseitem";
			this.Employee_Name_Spouseitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Name_Spouseitem.Text = "Spouse Name";
			this.Employee_Name_Spouseitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Name_Spouseitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Childrenitem
			// 
			this.Employee_Childrenitem.Control = this.Employee_Children;
			this.Employee_Childrenitem.Location = new System.Drawing.Point(0, 72);
			this.Employee_Childrenitem.Name = "Employee_Childrenitem";
			this.Employee_Childrenitem.Size = new System.Drawing.Size(256, 191);
			this.Employee_Childrenitem.Text = "Children Name(s)";
			this.Employee_Childrenitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Childrenitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Courseitem
			// 
			this.Employee_Courseitem.Control = this.Employee_Course;
			this.Employee_Courseitem.Location = new System.Drawing.Point(0, 24);
			this.Employee_Courseitem.Name = "Employee_Courseitem";
			this.Employee_Courseitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Courseitem.Text = "Course / Tech.";
			this.Employee_Courseitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Courseitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// Employee_Attainmentitem
			// 
			this.Employee_Attainmentitem.Control = this.Employee_Attainment;
			this.Employee_Attainmentitem.Location = new System.Drawing.Point(0, 0);
			this.Employee_Attainmentitem.Name = "Employee_Attainmentitem";
			this.Employee_Attainmentitem.Size = new System.Drawing.Size(256, 24);
			this.Employee_Attainmentitem.Text = "Edu. Attainment";
			this.Employee_Attainmentitem.TextLocation = DevExpress.Utils.Locations.Left;
			this.Employee_Attainmentitem.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlItem4
			// 
			this.layoutControlItem4.Control = this.Engine;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 311);
			this.layoutControlItem4.Name = "LayoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(256, 24);
			this.layoutControlItem4.Text = "Engine";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlItem5
			// 
			this.layoutControlItem5.Control = this.Chassis;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 335);
			this.layoutControlItem5.Name = "LayoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(256, 24);
			this.layoutControlItem5.Text = "Chassis";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlItem6
			// 
			this.layoutControlItem6.Control = this.Plate_Number;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 359);
			this.layoutControlItem6.Name = "LayoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(256, 24);
			this.layoutControlItem6.Text = "Plate Number";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "LayoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(256, 383);
			this.layoutControlGroup2.Text = "Departure";
			// 
			// LayoutControlItem2
			// 
			this.layoutControlItem2.Control = this.Employment_Status;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "LayoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(256, 24);
			this.layoutControlItem2.Text = "Emp. Status";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
			// 
			// LayoutControlItem3
			// 
			this.layoutControlItem3.Control = this.Departed_Date;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem3.Name = "LayoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(256, 359);
			this.layoutControlItem3.Text = "Departed";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 13);
			// 
			// xuc_Employee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
			this.Name = "xuc_Employee";
			this.Size = new System.Drawing.Size(300, 450);
			((System.ComponentModel.ISupportInitialize)(this.Employee_Position.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Civil_Status.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Birth_Place.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Code.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_ID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birth.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birth.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Contact.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Address.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Notes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Department.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Branch.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PAG_IBIG.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PHIC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_SSS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_TIN.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Corporation.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationary.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationary.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hired.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hired.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Level.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Class.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Status.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regular.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regular.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiry.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiry.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name_Spouse.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Children.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Course.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Attainment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employment_Status.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Departed_Date.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Departed_Date.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Engine.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chassis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Plate_Number.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage1item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Civil_Statusitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Birth_Placeitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Codeitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_IDitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Birthitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Contactitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Nameitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Addressitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Notesitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage2item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Departmentitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Branchitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PAG_IBIGitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_PHICitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_SSSitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_TINitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Corporationitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Positionitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Probationaryitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Hireditem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Levelitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Pay_Classitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Statusitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Date_Regularitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XtraTabPage3item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_License_Expiryitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Driver_Licenseitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Name_Spouseitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Childrenitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Courseitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_Attainmentitem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

        }

        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Position;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Pay_Class;
        internal DevExpress.XtraEditors.DateEdit Employee_Date_Hired;
        internal DevExpress.XtraEditors.DateEdit Employee_Date_Regular;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Status;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Pay_Level;
        internal DevExpress.XtraEditors.DateEdit Employee_Date_Probationary;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Corporation;
        internal DevExpress.XtraEditors.TextEdit Employee_Name_Spouse;
        internal DevExpress.XtraEditors.MemoEdit Employee_Children;
        internal DevExpress.XtraEditors.DateEdit Employee_Driver_License_Expiry;
        internal DevExpress.XtraEditors.TextEdit Employee_Driver_License;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Course;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Attainment;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Civil_Status;
        internal DevExpress.XtraEditors.TextEdit Employee_Birth_Place;
        internal DevExpress.XtraEditors.TextEdit Employee_Code;
        internal DevExpress.XtraEditors.TextEdit Employee_ID;
        internal DevExpress.XtraEditors.DateEdit Employee_Date_Birth;
        internal DevExpress.XtraEditors.TextEdit Employee_Contact;
        internal DevExpress.XtraEditors.TextEdit Employee_Name;
        internal DevExpress.XtraEditors.MemoEdit Employee_Address;
        internal DevExpress.XtraEditors.MemoEdit Notes;
        internal DevExpress.XtraEditors.TextEdit Employee_PAG_IBIG;
        internal DevExpress.XtraEditors.TextEdit Employee_PHIC;
        internal DevExpress.XtraEditors.TextEdit Employee_SSS;
        internal DevExpress.XtraEditors.TextEdit Employee_TIN;
        internal DevExpress.XtraEditors.ComboBoxEdit Employee_Department;
        internal DevExpress.XtraEditors.LookUpEdit Employee_Branch;
        internal DevExpress.XtraLayout.LayoutControl layoutControl;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        internal DevExpress.XtraLayout.TabbedControlGroup XtraTabControl1item;
        internal DevExpress.XtraLayout.LayoutControlGroup XtraTabPage2item;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Departmentitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Branchitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_PAG_IBIGitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_PHICitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_SSSitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_TINitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Corporationitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Positionitem;
        private DevExpress.XtraLayout.LayoutControlItem Employee_Date_Probationaryitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Date_Hireditem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Pay_Levelitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Pay_Classitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Statusitem;
        private DevExpress.XtraLayout.LayoutControlItem Employee_Date_Regularitem;
        internal DevExpress.XtraLayout.LayoutControlGroup XtraTabPage1item;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Civil_Statusitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Birth_Placeitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Codeitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_IDitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Date_Birthitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Contactitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Nameitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Addressitem;
        internal DevExpress.XtraLayout.LayoutControlItem Notesitem;
        internal DevExpress.XtraLayout.LayoutControlGroup XtraTabPage3item;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Driver_License_Expiryitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Driver_Licenseitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Name_Spouseitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Childrenitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Courseitem;
        internal DevExpress.XtraLayout.LayoutControlItem Employee_Attainmentitem;
        internal DevExpress.XtraEditors.TextEdit ID;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        internal DevExpress.XtraEditors.ComboBoxEdit Employment_Status;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        internal DevExpress.XtraEditors.DateEdit Departed_Date;
        internal DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        internal DevExpress.XtraEditors.LookUpEdit Engine;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        internal DevExpress.XtraEditors.TextEdit Chassis;
        internal DevExpress.XtraEditors.TextEdit Plate_Number;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        internal DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}