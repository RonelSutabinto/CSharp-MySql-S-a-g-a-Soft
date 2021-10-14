using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace SagaAssets.Controls
{
    public partial class xuc_Transmittal : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Transmittal()
        {
            InitializeComponent();
        }

        public void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Branch(Branch_From);
            class_Saga_Procedures.Initialize_Branch(Branch_To);

            class_Saga_Variables.Initialize_Employee();
            class_Saga_Procedures.Initialize_Employee(Prepared_By);
            class_Saga_Procedures.Initialize_Employee(Receiver);
            Prepared_By.EditValue = class_Variables.sUserName;

            class_Database.Fill_Edit(class_Database.ICSConnection, Transmittal_Type, "inv_Transmittals", "Transmittal_Type");
            class_Database.Fill_Edit(class_Database.ICSConnection, Courier, "inv_Transmittals", "Courier");
        }

        public bool Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Transmittal", "Create New Transmittal", "You might lose unsaved data")) return false;
            class_Procedures.Initialize_Controls(this, bClear);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Transmittal_Code, "inv_Transmittals", "Transmittal_Code", "TRANSMITTAL-");
            Transmittal_Type.Select();
            return true;
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Transmittal_Code", sCode), 
                new SqlParameter("@Action_Type", "RETRIEVE") 
            };
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Transmittal_Procedures"))
            {
                try
                {
                    Transmittal_Code.EditValue = sCode;
                    if (myDataReader != null && myDataReader.HasRows)
                    {
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Transmittal_Code.Text = myDataReader["Transmittal_Code"].ToString();
                        Transmittal_Type.Text = myDataReader["Transmittal_Code"].ToString();
                        Branch_From.EditValue = myDataReader["Branch_From"].ToString();
                        Branch_To.EditValue = myDataReader["Branch_To"].ToString();
                        Prepared_By.EditValue = myDataReader["Prepared_By"].ToString();
                        Receiver.EditValue = myDataReader["Receiver"].ToString();
                        Courier.Text = myDataReader["Courier"].ToString();
                        Transmittal_Name.Text = myDataReader["Transmittal_Name"].ToString();
                        Transmittal_Description.Text = myDataReader["Transmittal_Description"].ToString();
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
            if (class_Procedures.isEmpty(Transmittal_Type))
                return false;
            if (class_Procedures.isEmpty(Courier))
                return false;
            if (class_Procedures.isEmpty(Transmittal_Name))
                return false;
            if (class_Procedures.isEmpty(Transmittal_Description))
                return false;

            if (ID.EditValue.Equals(0))
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Transmittal_Code, "inv_Transmittals", "Transmittal_Code", "TRANSMITTAL-");

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Transmittal_Code", Transmittal_Code.Text),
                new SqlParameter("@Branch_From", Branch_From.EditValue),
                new SqlParameter("@Branch_To", Branch_To.EditValue),
                new SqlParameter("@Prepared_By", Prepared_By.EditValue),
                new SqlParameter("@Courier", Courier.Text.Trim().ToUpper()),
                new SqlParameter("@Receiver", Receiver.EditValue),
                new SqlParameter("@Transmittal_Type", Transmittal_Type.Text.Trim().ToUpper()),
                new SqlParameter("@Transmittal_Name", Transmittal_Name.Text.Trim().ToUpper()),
                new SqlParameter("@Transmittal_Description", Transmittal_Description.Text.Trim()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE")
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Transmittal_Procedures", "System Transmittal", Transmittal_Name.Text.Trim());
        }

        internal void Control_Preview_System_Transmittal()
        {
            var xrpt_Transmittal = new SagaAssets.Reports.xrpt_System_Transmittal();
            class_Database.Bind_Report(class_Database.ICSConnection, xrpt_Transmittal, $"SELECT * FROM inv_Transmittals WHERE ID LIKE '{ID.EditValue}'", "inv_Transmittals");

            try
            {
                xrpt_Transmittal.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                xrpt_Transmittal.PageWidth = 850;
                xrpt_Transmittal.PageHeight = 1100;

                xrpt_Transmittal.Product_Version.Text = $"{class_Functions.Product_Name_Version()} - IT Branch_To";
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
        }

        internal void Control_Preview_Technical_Report()
        {
            var xrpt_Report = new SagaAssets.Reports.xrpt_Technical_Report();
            class_Database.Bind_Report(class_Database.ICSConnection, xrpt_Report, $"SELECT * FROM inv_Transmittals WHERE ID LIKE '{ID.EditValue}'", "inv_Transmittals");

            try
            {
                xrpt_Report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                xrpt_Report.PageWidth = 850;
                xrpt_Report.PageHeight = 1100;

                xrpt_Report.Product_Version.Text = $"{class_Functions.Product_Name_Version()} - IT Branch_To";
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
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Transmittal_Procedures", "Delete System Transmittal", true));
        }
    }
}
