using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Controls
{
    public partial class xuc_Employee
    {
        public xuc_Employee()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Branch(Employee_Branch);
            class_Saga_Procedures.Initialize_Engine_Chassis(Engine);
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Civil_Status, "acc_Employees", "Employee_Civil_Status");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Department, "acc_Employees", "Employee_Department");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Position, "acc_Employees", "Employee_Position");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Pay_Level, "acc_Employees", "Employee_Pay_Level");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Pay_Class, "acc_Employees", "Employee_Pay_Class");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Status, "acc_Employees", "Employee_Status");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employment_Status, "acc_Employees", "Employment_Status");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Attainment, "acc_Employees", "Employee_Attainment");
            class_Database.Fill_Edit(class_Database.ICSConnection, Employee_Course, "acc_Employees", "Employee_Course");
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Employee Profile", "Initialize new Employee Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Employee_Code, "acc_Employees", "Employee_Code", "EMPLOYEE-");
            Employee_ID.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
			SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Employee_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };

            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Employee_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Employee_Code.Text = myDataReader["Employee_Code"].ToString();
                        Employee_ID.EditValue = myDataReader["Employee_ID"].ToString();
                        Employee_Name.Text = myDataReader["Employee_Name"].ToString();
                        Employee_Address.Text = myDataReader["Employee_Address"].ToString();
                        Employee_Contact.Text = myDataReader["Employee_Contact"].ToString();
                        Employee_Date_Birth.EditValue = Convert.ToDateTime(myDataReader["Employee_Date_Birth"]);
                        Employee_Birth_Place.Text = myDataReader["Employee_Birth_Place"].ToString();
                        Employee_Civil_Status.Text = myDataReader["Employee_Civil_Status"].ToString();
                        Employee_Corporation.EditValue = myDataReader["Employee_Corporation"].ToString();
                        Employee_Branch.EditValue = myDataReader["Employee_Branch"].ToString();
                        Employee_Department.Text = myDataReader["Employee_Department"].ToString();
                        Employee_Position.Text = myDataReader["Employee_Position"].ToString();
                        Employee_Pay_Level.Text = myDataReader["Employee_Pay_Level"].ToString();
                        Employee_Pay_Class.Text = myDataReader["Employee_Pay_Class"].ToString();
                        Employee_Status.Text = myDataReader["Employee_Status"].ToString();
                        Employee_Date_Hired.EditValue = Convert.ToDateTime(myDataReader["Employee_Date_Hired"]);
                        Employee_Date_Probationary.EditValue = Convert.ToDateTime(myDataReader["Employee_Date_Probationary"]);
                        Employee_Date_Regular.EditValue = Convert.ToDateTime(myDataReader["Employee_Date_Regular"]);
                        Employee_TIN.Text = myDataReader["Employee_TIN"].ToString();
                        Employee_SSS.Text = myDataReader["Employee_SSS"].ToString();
                        Employee_PHIC.Text = myDataReader["Employee_PHIC"].ToString();
                        Employee_PAG_IBIG.Text = myDataReader["Employee_PAG_IBIG"].ToString();
                        Employee_Attainment.Text = myDataReader["Employee_Attainment"].ToString();
                        Employee_Course.Text = myDataReader["Employee_Course"].ToString();
                        Employee_Name_Spouse.Text = myDataReader["Employee_Name_Spouse"].ToString();
                        Employee_Children.Text = myDataReader["Employee_Children"].ToString();
                        Employee_Driver_License.Text = myDataReader["Employee_Driver_License"].ToString();
                        Engine.EditValue = myDataReader["Engine"].ToString();
                        Employment_Status.Text = myDataReader["Employment_Status"].ToString();
                        Departed_Date.EditValue = Convert.ToDateTime(myDataReader["Employment_Status"]);
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
            if (class_Procedures.isEmpty(Employee_Code))
                return false;
            if (class_Procedures.isEmpty(Employee_ID))
                return false;
            if (class_Procedures.isEmpty(Employee_Corporation))
                return false;
            if (class_Procedures.isEmpty(Employee_Branch))
                return false;
            if (class_Procedures.isEmpty(Employee_Name))
                return false;
            if (!class_Database.Data_Save_Ask(Employee_Name.Text))
                return false;
            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Employee_Code, "acc_Employees", "Employee_Code", "EMPLOYEE-");
            }

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue), 
                new SqlParameter("@Employee_Code", Employee_Code.Text), 
                new SqlParameter("@Employee_ID", Employee_ID.Text.Trim()), 
                new SqlParameter("@Employee_Name", Employee_Name.Text.Trim()), 
                new SqlParameter("@Employee_Address", Employee_Address.Text.Trim()), 
                new SqlParameter("@Employee_Contact", Employee_Contact.Text.Trim()), 
                new SqlParameter("@Employee_Date_Birth", Employee_Date_Birth.EditValue), 
                new SqlParameter("@Employee_Birth_Place", Employee_Birth_Place.Text.Trim()), 
                new SqlParameter("@Employee_Civil_Status", Employee_Civil_Status.Text), 
                new SqlParameter("@Employee_Corporation", Employee_Corporation.EditValue.ToString()), 
                new SqlParameter("@Employee_Branch", Employee_Branch.EditValue.ToString()), 
                new SqlParameter("@Employee_Department", Employee_Department.Text.Trim()), 
                new SqlParameter("@Employee_Position", Employee_Position.Text.Trim()), 
                new SqlParameter("@Employee_Pay_Level", Employee_Pay_Level.Text.Trim()), 
                new SqlParameter("@Employee_Pay_Class", Employee_Pay_Class.Text.Trim()), 
                new SqlParameter("@Employee_Status", Employee_Status.Text.Trim()), 
                new SqlParameter("@Employee_Date_Hired", Employee_Date_Hired.EditValue), 
                new SqlParameter("@Employee_Date_Probationary", Employee_Date_Probationary.EditValue), 
                new SqlParameter("@Employee_Date_Regular", Employee_Date_Regular.EditValue), 
                new SqlParameter("@Employee_TIN", Employee_TIN.Text.Trim()), 
                new SqlParameter("@Employee_SSS", Employee_SSS.Text.Trim()), 
                new SqlParameter("@Employee_PHIC", Employee_PHIC.Text.Trim()), 
                new SqlParameter("@Employee_PAG_IBIG", Employee_PAG_IBIG.Text.Trim()), 
                new SqlParameter("@Employee_Attainment", Employee_Attainment.Text.Trim()), 
                new SqlParameter("@Employee_Course", Employee_Course.Text.Trim()), 
                new SqlParameter("@Employee_Name_Spouse", Employee_Name_Spouse.Text.Trim()), 
                new SqlParameter("@Employee_Children", Employee_Children.Text.Trim()), 
                new SqlParameter("@Employee_Driver_License", Employee_Driver_License.Text.Trim()), 
                new SqlParameter("@Engine", Engine.EditValue), 
                new SqlParameter("@Employment_Status", Employment_Status.Text), 
                new SqlParameter("@Departed_Date", Departed_Date.EditValue), 
                new SqlParameter("@Notes", Notes.Text.Trim()), 
                new SqlParameter("@Added_By", class_Variables.sUserName), 
                new SqlParameter("@Modified_By", class_Variables.sUserName), 
                new SqlParameter("@Action_Type", "SAVE") 
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Employee_Procedures", "Employee Profile", Employee_Name.Text.Trim());
        }

        internal void Control_Update(string sCode, int iAge, string sServiceLength)
        {
            if (sCode.Equals(string.Empty))
                return;
            using (var MySQLConnection = new SqlConnection(class_Database.ICSConnection))
            {
                using (var MyCommand = new SqlCommand("acc_Employee_Update", MySQLConnection) { CommandType = CommandType.StoredProcedure })
                {
                    MyCommand.Parameters.Add("@Employee_Code", SqlDbType.VarChar).Value = sCode;
                    MyCommand.Parameters.Add("@Employee_Age", SqlDbType.Int).Value = iAge;
                    MyCommand.Parameters.Add("@Employee_Service_Length", SqlDbType.VarChar).Value = sServiceLength;
                    try
                    {
                        MySQLConnection.Open();
                        if (Convert.ToBoolean(MyCommand.ExecuteNonQuery()))
                        {
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Employee Profile");
                        }
                    }
                    catch (Exception ex)
                    {
                        class_Procedures.Show_Error(ex);
                    }
                }
            }
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM Employees WHERE Employee_Code LIKE '{Employee_Code.Text}'", $"Employee Profile: {Employee_Name.Text}");
        }

        private void Employee_Date_Probationaryitem_DoubleClick(object sender, EventArgs e)
        {
            Employee_Date_Probationary.EditValue = Employee_Date_Hired.EditValue;
        }

        private void Employee_Date_Regularitem_Click(object sender, EventArgs e)
        {
            Employee_Date_Regular.EditValue = Employee_Date_Probationary.EditValue;
        }
    }
}