using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace SagaHR.Controls
{
    public partial class xuc_Salary : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Salary()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Branch(Branch_Code);
            class_Saga_Procedures.Initialize_Employee(Employee_Code);
            class_Database.Fill_Edit(class_Database.ICSConnection, Salary_Category, "hr_Salaries", "Salary_Category");
            class_Database.Fill_Edit(class_Database.ICSConnection, Salary_Type, "hr_Salaries", "Salary_Type");
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Salary Profile", "Initialize new Salary Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Salary_Code, "hr_Salaries", "Salary_Code", "SALARY-");
            Employee_Code.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Salary_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };

            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "hr_Salary_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Salary_Code.EditValue = myDataReader["Salary_Code"].ToString();
                        Branch_Code.EditValue = myDataReader["Branch_Code"].ToString();
                        Employee_Code.EditValue = myDataReader["Employee_Code"].ToString();
                        Salary_Category.EditValue = myDataReader["Salary_Category"].ToString();
                        Salary_Type.EditValue = myDataReader["Salary_Type"].ToString();
                        Salary.Value = Convert.ToDecimal(myDataReader["Salary"]);
                        Salary_Description.EditValue = myDataReader["Salary_Description"].ToString();
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
            if (class_Procedures.isEmpty(Salary_Code))
                return false;
            if (class_Procedures.isEmpty(Employee_Code))
                return false;
            if (class_Procedures.isEmpty(Salary))
                return false;

            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Salary_Code, "hr_Salaries", "Salary_Code", "SALARY-");
            }

			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", ID.EditValue),
				new SqlParameter("@Salary_Code", Salary_Code.EditValue),
				new SqlParameter("@Branch_Code", Branch_Code.EditValue),
				new SqlParameter("@Employee_Code", Employee_Code.EditValue),
				new SqlParameter("@Salary_Category", Salary_Category.Text.Trim().ToUpper()),
				new SqlParameter("@Salary_Type", Salary_Type.Text.Trim().ToUpper()),
				new SqlParameter("@Salary", Salary.Value),
				new SqlParameter("@Salary_Description", Salary_Description.Text.Trim()),
				new SqlParameter("@Notes", Notes.Text.Trim()),
				new SqlParameter("@Added_By", class_Variables.sUserName),
				new SqlParameter("@Modified_By", class_Variables.sUserName),
				new SqlParameter("@Action_Type", "SAVE")
			};
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Salary_Procedures", "Salary Profile", Salary.Text.Trim());
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Salaries WHERE ID LIKE '{ID.EditValue}'", $"Salary Profile: {Salary.Text}");
        }
    }
}
