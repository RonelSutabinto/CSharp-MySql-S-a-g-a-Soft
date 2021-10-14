using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaSupport.Controls
{
    public partial class xuc_Ticket_Group
    {
        internal xuc_Ticket_Group()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Variables.Initialize_Users();
            class_Saga_Procedures.Initialize_User(Personnel);
            class_Database.Fill_Edit(class_Database.ICSConnection, Ticket_Group, "acc_Ticket_Groups", "Ticket_Group_Sub");
            Ticket_Group.Select();
        }

        internal void Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Ticket", "Create New Ticket", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClear);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Group_Code, "acc_Ticket_Groups", "Ticket_Group_Code", "TICKET-GROUP-");
            Ticket_Group.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Ticket_Group_Code", sCode), 
                new SqlParameter("@Action_Type", "RETRIEVE") 
            };
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Group_Procedures"))
            {
                try
                {
                    Ticket_Group_Code.EditValue = sCode;
                    if (myDataReader != null && myDataReader.HasRows)
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Ticket_Group_Code.Text = myDataReader["Ticket_Group_Code"].ToString();
                        Ticket_Group.Text = myDataReader["Ticket_Group"].ToString();
                        Ticket_Group_Sub.Text = myDataReader["Ticket_Group_Sub"].ToString();
                        Ticket_Description.Text = myDataReader["Ticket_Description"].ToString();
                        Personnel.Text = myDataReader["Personnel"].ToString();
                        Notes.Text = myDataReader["Notes"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    return class_Procedures.Show_Error(ex);
                }
            }

            return false;
        }

        internal bool Control_Save()
        {
            if (!class_Database.Data_Save_Ask(class_Database.ICSConnection, "Ticket Group", $"SELECT ID FROM acc_Ticket_Groups WHERE ID LIKE '{ID.EditValue}'", bReplaceIfExisting: true))
                return false;
            if (class_Procedures.isEmpty(Ticket_Group_Code))
                return false;
            if (class_Procedures.isEmpty(Ticket_Group))
                return false;
            if (class_Procedures.isEmpty(Ticket_Group_Sub))
                return false;

            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Group_Code, "acc_Ticket_Groups", "Ticket_Group_Code", "TICKET-GROUP-");

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue), 
                new SqlParameter("@Ticket_Group_Code", Ticket_Group_Code.Text.Trim()), 
                new SqlParameter("@Ticket_Group", Ticket_Group.Text.Trim()), 
                new SqlParameter("@Ticket_Group_Sub", Ticket_Group_Sub.Text.Trim()), 
                new SqlParameter("@Ticket_Description", Ticket_Description.Text.Trim()),
                new SqlParameter("@Personnel", Personnel.Text.Trim()), 
                new SqlParameter("@Notes", Notes.Text.Trim()), 
                new SqlParameter("@Added_By", class_Variables.sUserName), 
                new SqlParameter("@Modified_By", class_Variables.sUserName), 
                new SqlParameter("@Action_Type", "SAVE") 
            };
            
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Group_Procedures", "System Ticket", Ticket_Group_Code.Text.Trim());
        }

        internal bool Control_Delete()
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue), 
                new SqlParameter("@Action_Type", "DELETE") 
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Group_Procedures", "Delete System Ticket", true));
        }

        private void Ticket_Group_Code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    {
                        class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Ticket_Group_Code, "acc_Ticket_Groups", "Ticket_Group_Code", "TICKET-GROUP-");
                        break;
                    }
            }
        }

        private void Ticket_Group_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    {
                        break;
                    }
            }
        }

        private void Personnel_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    {
                        Personnel.EditValue = string.Empty;
                        break;
                    }
            }
        }
    }
}