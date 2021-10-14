using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace SagaHR.Controls
{
    public partial class xuc_Payroll : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Payroll()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Corporation(Corporation);
            class_Saga_Procedures.Initialize_Branch(Branch_Code);
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Payroll Profile", "Initialize new Payroll Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Payroll_Code, "hr_Payroll", "Payroll_Code", "PAYROLL-");
            Corporation.Select();
        }
        
        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Payroll_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };

            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "hr_Payroll_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Payroll_Code.EditValue = myDataReader["Payroll_Code"].ToString();
                        Corporation.EditValue = myDataReader["Corporation"].ToString();
                        Branch_Code.EditValue = myDataReader["Branch_Code"].ToString();
                        Pay_Day.EditValue = Convert.ToInt16(myDataReader["Pay_Day"]);
                        Date_Start.EditValue = Convert.ToDateTime(myDataReader["Date_Start"]);
                        Date_End.EditValue = Convert.ToDateTime(myDataReader["Date_End"]);
                        Pay_Date.EditValue = Convert.ToDateTime(myDataReader["Pay_Date"]);
                        Payroll_Name.Text = myDataReader["Payroll_Name"].ToString();
                        Payroll_Description.EditValue = myDataReader["Payroll_Description"].ToString();
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
            if (class_Procedures.isEmpty(Payroll_Code))
                return false;
            if (class_Procedures.isEmpty(Branch_Code))
                return false;
            if (class_Procedures.isEmpty(Payroll_Name))
                return false;

            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Payroll_Code, "hr_Payroll", "Payroll_Code", "PAYROLL-");
            }

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Payroll_Code", Payroll_Code.EditValue),
                new SqlParameter("@Corporation", Corporation.EditValue),
                new SqlParameter("@Branch_Code", Branch_Code.EditValue),
                new SqlParameter("@Pay_Day", Pay_Day.EditValue),
                new SqlParameter("@Date_Start", Date_Start.EditValue),
                new SqlParameter("@Date_End", Date_End.EditValue),
                new SqlParameter("@Pay_Date", Pay_Date.EditValue),
                new SqlParameter("@Payroll_Name", Payroll_Name.Text.Trim()),
                new SqlParameter("@Payroll_Description", Payroll_Description.Text.Trim()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE")
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Payroll_Procedures", "Payroll Profile", Payroll_Name.Text.Trim());
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Payroll WHERE ID LIKE '{ID.EditValue}'", $"Payroll Profile: {Payroll_Name.Text}");
        }
    }
}
