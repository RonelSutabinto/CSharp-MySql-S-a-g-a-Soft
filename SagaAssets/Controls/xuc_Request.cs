using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaAssets.Controls
{
    public partial class xuc_Request : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Request()
        {
            InitializeComponent();
        }

        public void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Branch(Branch_Code);

            class_Saga_Variables.Initialize_Employee();
            class_Saga_Procedures.Initialize_Employee(Requested_By);
            Requested_By.EditValue = class_Variables.sUserName;

            class_Database.Fill_Edit(class_Database.ICSConnection, Department, "inv_Requests", "Department");
            class_Database.Fill_Edit(class_Database.ICSConnection, Category, "inv_Requests", "Category");
            class_Database.Fill_Edit(class_Database.ICSConnection, Request_Type, "inv_Requests", "Request_Type");
        }

        public bool Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Request", "Create New Request", "You might lose unsaved data")) return false;
            class_Procedures.Initialize_Controls(this, bClear, true);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "inv_Requests", "Request_Code", "REQUEST-");
            Requested_By.Select();
            return true;
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Request_Code", sCode), 
                new SqlParameter("@Action_Type", "RETRIEVE") 
            };
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Request_Procedures"))
            {
                try
                {
                    Request_Code.EditValue = sCode;
                    if (myDataReader != null && myDataReader.HasRows)
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Request_Code.Text = myDataReader["Request_Code"].ToString();
                        Branch_Code.EditValue = myDataReader["Branch_Code"].ToString();
                        Department.Text = myDataReader["Department"].ToString();
                        Requested_By.EditValue = myDataReader["Requested_By"].ToString();
                        Category.Text = myDataReader["Category"].ToString();
                        Request_Type.Text = myDataReader["Request_Code"].ToString();
                        Urgency.Text = myDataReader["Urgency"].ToString();
                        Amount.Value = Convert.ToDecimal(myDataReader["Amount"]);
                        Quantity.Value = Convert.ToInt16(myDataReader["Quantity"]);
                        Request_Name.Text = myDataReader["Request_Name"].ToString();
                        Request_Description.Text = myDataReader["Request_Description"].ToString();
                        Reason.Text = myDataReader["Reason"].ToString();
                        Technical_Report.Text = myDataReader["Technical_Report"].ToString();
                        Recommendation.Text = myDataReader["Recommendation"].ToString();
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

        internal bool Control_Save()
        {
            if (class_Procedures.isEmpty(Category))
                return false;
            if (class_Procedures.isEmpty(Request_Type))
                return false;
            if (class_Procedures.isEmpty(Request_Name))
                return false;

            if (ID.EditValue.Equals(0))
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "inv_Requests", "Request_Code", "REQUEST-");

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Request_Code", Request_Code.Text),
                new SqlParameter("@Branch_Code", Branch_Code.EditValue),
                new SqlParameter("@Department", Department.Text.Trim().ToUpper()),
                new SqlParameter("@Requested_By", Requested_By.EditValue),
                new SqlParameter("@Category", Category.Text.Trim().ToUpper()),
                new SqlParameter("@Request_Type", Request_Type.Text.Trim().ToUpper()),
                new SqlParameter("@Urgency", Urgency.Text),
                new SqlParameter("@Amount", Amount.Value),
                new SqlParameter("@Quantity", Quantity.Value),
                new SqlParameter("@Request_Name", Request_Name.Text.Trim().ToUpper()),
                new SqlParameter("@Request_Description", Request_Description.Text.Trim()),
                new SqlParameter("@Reason", Reason.Text.Trim()),
                new SqlParameter("@Technical_Report", Technical_Report.Text.Trim()),
                new SqlParameter("@Recommendation", Recommendation.Text.Trim()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE")
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Request_Procedures", "System Request", Request_Name.Text.Trim());
        }

        internal void Control_Preview_System_Request()
        {
            var xrpt_Request = new SagaAssets.Reports.xrpt_System_Request();
            class_Database.Bind_Report(class_Database.ICSConnection, xrpt_Request, $"SELECT * FROM inv_Requests WHERE ID LIKE '{ID.EditValue}'", "inv_Requests");

            try
            {
                xrpt_Request.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                xrpt_Request.PageWidth = 850;
                xrpt_Request.PageHeight = 1100;

                xrpt_Request.Requested_By.Text = Requested_By.Text;

                xrpt_Request.Product_Version.Text = $"{class_Functions.Product_Name_Version()} - IT Department";
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
        }

        internal void Control_Preview_Technical_Report()
        {
            var xrpt_Report = new SagaAssets.Reports.xrpt_Technical_Report();
            class_Database.Bind_Report(class_Database.ICSConnection, xrpt_Report, $"SELECT * FROM inv_Requests WHERE ID LIKE '{ID.EditValue}'", "inv_Requests");

            try
            {
                xrpt_Report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                xrpt_Report.PageWidth = 850;
                xrpt_Report.PageHeight = 1300;

                xrpt_Report.Requested_By.Text = Requested_By.Text;

                xrpt_Report.Product_Version.Text = $"{class_Functions.Product_Name_Version()} - IT Department";
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
        }

        internal bool Control_Delete()
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Action_Type", "DELETE")
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Request_Procedures", "Delete System Request", true));
        }
    }
}
