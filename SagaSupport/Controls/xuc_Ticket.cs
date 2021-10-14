using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using SagaSupport.Classes;

namespace SagaSupport.Controls
{
    public partial class xuc_Ticket : DevExpress.XtraEditors.XtraUserControl
    {
        internal xuc_Ticket()
        {
            InitializeComponent();
        }

        public void Control_Initialize(bool bLoadAssets = false)
        {
            class_Saga_Procedures.Initialize_Branch(Branch_Code);
            Branch_Code.Enabled = class_Saga_Variables.sBranchCode.Equals("000");

            class_Saga_Variables.Initialize_Users();
            class_Saga_Procedures.Initialize_User(Created_By);
            class_Saga_Procedures.Initialize_User(Assigned_To);
            class_Saga_Procedures.Initialize_User(Added_By);
            class_Saga_Procedures.Initialize_User(Modified_By);
            class_Saga_Procedures.Initialize_User(Opened_By);
            class_Saga_Procedures.Initialize_User(Closed_By);
            class_Saga_Procedures.Initialize_User(Deleted_By);
            Created_By.EditValue = class_Variables.sUserName;

            class_Support_Procedures.Initialize_Ticket_Groups(Ticket_Group, treeListLookUpEditTreeList);

            if (bLoadAssets) class_Support_Procedures.Initialize_Assets(Asset_Code);

            class_Database.Fill_Edit(class_Database.ICSConnection, Communication_Type, "acc_Tickets", "Communication_Type");

            layoutControlGroup_Support.Visibility = class_Saga_Variables.sBranchCode.Equals("000") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        public bool Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Ticket", "Create New Ticket", "You might lose unsaved data")) return false;
            class_Procedures.Initialize_Controls(this, bClear);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Code, "acc_Tickets", "Ticket_Code", "TICKET-");
            Incident_Date.EditValue = DateTime.Today;
            Ticket_Group.Select();
            return true;
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Ticket_Code", sCode), 
                new SqlParameter("@Action_Type", "RETRIEVE") 
            };
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Procedures"))
            {
                try
                {
                    Ticket_Code.EditValue = sCode;
                    if (myDataReader != null && myDataReader.HasRows)
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Branch_Code.EditValue = myDataReader["Branch_Code"].ToString();
                        Created_By.EditValue = myDataReader["Created_By"].ToString();
                        Assigned_To.EditValue = myDataReader["Assigned_To"].ToString();
                        Added_By.EditValue = myDataReader["Added_By"].ToString();
                        Modified_By.EditValue = myDataReader["Modified_By"].ToString();
                        Opened_By.EditValue = myDataReader["Opened_By"].ToString();
                        Closed_By.EditValue = myDataReader["Closed_By"].ToString();
                        Deleted_By.EditValue = myDataReader["Deleted_By"].ToString();
                        Ticket_Status.Text = myDataReader["Ticket_Status"].ToString();
                        Ticket_Code.Text = myDataReader["Ticket_Code"].ToString();
                        Report_Type.Text = myDataReader["Ticket_Code"].ToString();
                        Communication_Type.Text = myDataReader["Communication_Type"].ToString();
                        Incident_Date.EditValue = (DateTime)myDataReader["Incident_Date"];
                        Ticket_Impact.Text = myDataReader["Ticket_Impact"].ToString();
                        Ticket_Urgency.Text = myDataReader["Ticket_Urgency"].ToString();
                        Asset_Code.EditValue = myDataReader["Asset_Code"].ToString();
                        Ticket_Name.Text = myDataReader["Ticket_Name"].ToString();
                        Ticket_Description.Text = myDataReader["Ticket_Description"].ToString();
                        Ticket_Attachment.RtfText = myDataReader["Ticket_Attachment"].ToString();
                        Ticket_Solution.Text = myDataReader["Ticket_Solution"].ToString();
                        IsRecurrent.IsOn = Convert.ToBoolean(myDataReader["IsRecurrent"]);
                        Defect_Type.Text = myDataReader["Defect_Type"].ToString();
                        Notes.Text = myDataReader["Notes"].ToString();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return class_Procedures.Show_Error(ex);
                }
            }

            return false;
        }

        internal void Edit_Ticket()
        {
            using (var frm = new SagaSupport.Forms.frm_Editor())
            {
                frm.Solution.RtfText = Ticket_Attachment.RtfText;

                var result = frm.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Ticket_Attachment.RtfText = class_Support_Variables.editorText;
                }
            }
        }

        internal bool Control_Save()
        {
            if (class_Procedures.isEmpty(Branch_Code)) return false;
            if (class_Procedures.isEmpty(Created_By)) return false;
            if (class_Procedures.isEmpty(Ticket_Group)) return false;
            if (class_Procedures.isEmpty(Communication_Type)) return false;
            if (class_Procedures.isEmpty(Incident_Date)) return false;
            if (class_Procedures.isEmpty(Ticket_Name)) return false;
            if (class_Procedures.isEmpty(Ticket_Description)) return false;
            
            if (Assigned_To.EditValue is null)
                Assigned_To.EditValue = string.Empty;

            if (ID.EditValue.Equals(0))
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Code, "acc_Tickets", "Ticket_Code", "TICKET-");

            SqlParameter[] sqlParameters = new[] { 
                new SqlParameter("@ID", ID.EditValue), 
                new SqlParameter("@Branch_Code", Branch_Code.EditValue), 
                new SqlParameter("@Created_By", Created_By.EditValue.ToString()), 
                new SqlParameter("@Assigned_To", Assigned_To.EditValue.ToString()), 
                new SqlParameter("@Ticket_Code", Ticket_Code.Text), 
                new SqlParameter("@Ticket_Group", Ticket_Group.Text), 
                new SqlParameter("@Report_Type", Report_Type.Text), 
                new SqlParameter("@Communication_Type", Communication_Type.Text),
                new SqlParameter("@Incident_Date", Incident_Date.EditValue), 
                new SqlParameter("@Ticket_Impact", Ticket_Impact.Text), 
                new SqlParameter("@Ticket_Urgency", Ticket_Urgency.Text), 
                new SqlParameter("@Defect_Type", Defect_Type.Text),
                new SqlParameter("@Asset_Code", Asset_Code.EditValue),
                new SqlParameter("@Ticket_Name", Ticket_Name.Text.Trim()), 
                new SqlParameter("@Ticket_Description", Ticket_Description.Text),
                new SqlParameter("@Ticket_Attachment", Ticket_Attachment.RtfText),
                new SqlParameter("@Ticket_Solution", Ticket_Solution.Text.Trim()),
                new SqlParameter("@IsRecurrent", IsRecurrent.IsOn), 
                new SqlParameter("@Notes", Notes.Text.Trim()), 
                new SqlParameter("@Added_By", class_Variables.sUserName), 
                new SqlParameter("@Modified_By", class_Variables.sUserName), 
                new SqlParameter("@Action_Type", "SAVE") 
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Procedures", "System Ticket", Ticket_Code.Text.Trim());
        }

        internal bool Control_Delete()
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Modified_By", class_Variables.sUserName), 
                new SqlParameter("@Ticket_Solution", class_Functions.Show_Input_Box("Input reason why you want to delete this Ticket", "Delete Ticket", string.Empty)), 
                new SqlParameter("@Action_Type", "DELETE") 
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Procedures", "Delete System Ticket", true));
        }

        private void Ticket_Code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    {
                        class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Code, "acc_Tickets", "Ticket_Code", "TICKET-");
                        break;
                    }
            }
        }

        internal void Copy_To_Clipboard()
        {
            class_Procedures.Copy_Clipboard($"ID: {ID.Text}{Environment.NewLine}" +
                $"Code: {Ticket_Code.Text}{Environment.NewLine}" +
                $"Branch: {Branch_Code.Text}{Environment.NewLine}" +
                $"Created By: {Created_By.Text}{Environment.NewLine}" +
                $"Type: {Report_Type.Text}{Environment.NewLine}" +
                $"Group: {Ticket_Group.Text}{Environment.NewLine}" +
                $"Date: {Incident_Date.Text}{Environment.NewLine}" +
                $"Subject: {Ticket_Name.Text.Trim()}{Environment.NewLine}" +
                $"Description: {Ticket_Description.Text.Trim()}{Environment.NewLine}"
                );
        }
    }
}