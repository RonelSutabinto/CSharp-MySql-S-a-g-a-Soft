using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using SagaClassLibrary.Classes;

namespace SagaHR.Controls
{
    public partial class xuc_Leave : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Leave()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Employee(Employee_Code);
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Leave Profile", "Initialize new Leave Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            Leave_Days.Properties.IsFloatValue = true;
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Leave_Code, "hr_Leaves", "Leave_Code", "LEAVE-");
            Date_Start.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Leave_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };

            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "hr_Leave_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Leave_Code.EditValue = myDataReader["Leave_Code"].ToString();
                        Leave_Category.EditValue = myDataReader["Leave_Category"].ToString();
                        Leave_Type.EditValue = myDataReader["Leave_Type"].ToString();
                        Date_Start.EditValue = Convert.ToDateTime(myDataReader["Date_Start"]);
                        Date_End.EditValue = Convert.ToDateTime(myDataReader["Date_End"]);
                        Leave_Days.Value = Convert.ToInt32(myDataReader["Leave_Days"]);
                        Leave_Name.EditValue = myDataReader["Leave_Name"].ToString();
                        Leave_Description.EditValue = myDataReader["Leave_Description"].ToString();
                        Notes.Text = myDataReader["Notes"].ToString();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return class_Procedures.Show_Error(ex);
                    }
                }
            }

            return false;
        }

        private void Date_Start_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Enter:
                    Date_End.EditValue = Date_Start.EditValue;
                    break;
            }
        }

        internal bool Control_Save()
        {
            if (class_Procedures.isEmpty(Leave_Category))
                return false;
            if (class_Procedures.isEmpty(Leave_Type))
                return false;
            if (class_Procedures.isEmpty(Leave_Days))
                return false;
            if (class_Procedures.isEmpty(Leave_Name))
                return false;
            if (class_Procedures.isEmpty(Leave_Description))
                return false;

            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Leave_Code, "hr_Leaves", "Leave_Code", "LEAVE-");
            }

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Leave_Code", Leave_Code.EditValue),
                new SqlParameter("@Employee_Code", Employee_Code.EditValue),
                new SqlParameter("@Leave_Category", Leave_Category.EditValue),
                new SqlParameter("@Leave_Type", Leave_Type.EditValue),
                new SqlParameter("@Date_Start", Date_Start.EditValue),
                new SqlParameter("@Date_End", Date_End.EditValue),
                new SqlParameter("@Leave_Days", Leave_Days.Value),
                new SqlParameter("@Leave_Name", Leave_Name.Text.Trim()),
                new SqlParameter("@Leave_Description", Leave_Description.Text.Trim()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE")
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Leave_Procedures", "Leave Profile", Leave_Name.Text.Trim());
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Leaves WHERE ID LIKE '{ID.EditValue}'", $"Leave Profile: {Leave_Name.Text}");
        }

		
	}
}
