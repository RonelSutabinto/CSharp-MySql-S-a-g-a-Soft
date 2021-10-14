using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace SagaHR.Controls
{
    public partial class xuc_Schedule_Type : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Schedule_Type()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Schedule Type Profile", "Initialize new Schedule Type Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Schedule_Code, "hr_Schedule_Types", "Schedule_Code", "SCHED-");
            Schedule_Name.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Schedule_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };

            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "hr_Schedule_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Schedule_Code.EditValue = myDataReader["Schedule_Code"].ToString();
                        Schedule_Name.Text = myDataReader["Schedule_Name"].ToString();
                        Schedule_Description.Text = myDataReader["Schedule_Description"].ToString();
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

        internal bool Control_Save()
        {
            if (class_Procedures.isEmpty(Schedule_Code))
                return false;
            if (class_Procedures.isEmpty(Schedule_Name))
                return false;

            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Schedule_Code, "hr_Schedule_Types", "Schedule_Code", "SCHED-");
            }

			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", ID.EditValue),
				new SqlParameter("@Schedule_Code", Schedule_Code.EditValue),
				new SqlParameter("@Schedule_Name", Schedule_Name.Text.Trim()),
				new SqlParameter("@Schedule_Description", Schedule_Description.Text.Trim()),
				new SqlParameter("@Notes", Notes.Text.Trim()),
				new SqlParameter("@Added_By", class_Variables.sUserName),
				new SqlParameter("@Modified_By", class_Variables.sUserName),
				new SqlParameter("@Action_Type", "SAVE")
			};
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Schedule_Procedures", "Schedule Type Profile", Schedule_Name.Text.Trim());
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Schedule_Types WHERE ID LIKE '{ID.EditValue}'", $"Schedule Type Profile: {Schedule_Name.Text}");
        }
    }
}
