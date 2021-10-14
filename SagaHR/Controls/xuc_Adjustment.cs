using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using SagaClassLibrary.Classes;

namespace SagaHR.Controls
{
    public partial class xuc_Adjustment : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Adjustment()
        {
            InitializeComponent();
        }

        internal void Control_Initialize()
        {
            class_Saga_Variables.Initialize_COA();
            class_Saga_Procedures.Initialize_COA(COA_Code, class_Saga_Variables.eCOA_Type.COA_All);
        }

        internal void Control_New(bool bAsk = false, bool bClearNew = true)
        {
            if (bAsk && !class_Procedures.actionAsk("New Adjustment Profile", "Initialize new Adjustment Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClearNew);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Adjust_Code, "hr_Adjustments", "Adjust_Code", "ADJUST-");
            Adjust_Category.Select();
        }

        internal bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Adjust_Code", sCode),
                new SqlParameter("@Action_Type", "RETRIEVE")
            };
            
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures"))
            {
                try
                {
                    myDataReader.Read();
                    ID.EditValue = myDataReader["ID"].ToString();
                    Adjust_Category.EditValue = myDataReader["Adjust_Category"].ToString();
                    Adjust_Type.EditValue = myDataReader["Adjust_Type"].ToString();
                    Is_15th.Checked = Convert.ToBoolean(myDataReader["Is_15th"]);
                    Is_30th.Checked = Convert.ToBoolean(myDataReader["Is_30th"]);
                    Adjust_Name.EditValue = myDataReader["Adjust_Name"].ToString();
                    Amount.EditValue = Convert.ToDecimal(myDataReader["Amount"]);
                    COA_Code.EditValue = myDataReader["COA_Code"].ToString();
                    Adjust_Description.EditValue = myDataReader["Adjust_Description"].ToString();
                    Notes.Text = myDataReader["Notes"].ToString();
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
            if (class_Procedures.isEmpty(Adjust_Category))
                return false;
            if (class_Procedures.isEmpty(Adjust_Type))
                return false;
            if (class_Procedures.isEmpty(Adjust_Name))
                return false;

            if (ID.EditValue.Equals(0))
            {
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Adjust_Code, "hr_Adjustments", "Adjust_Code", "ADJUST-");
            }

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Adjust_Code", Adjust_Code.EditValue),
                new SqlParameter("@Adjust_Category", Adjust_Category.EditValue),
                new SqlParameter("@Adjust_Type", Adjust_Type.EditValue),
                new SqlParameter("@Is_15th", Is_15th.Checked),
                new SqlParameter("@Is_30th", Is_30th.Checked),
                new SqlParameter("@Adjust_Name", Adjust_Name.Text.Trim()),
                new SqlParameter("@Amount", Amount.Value),
                new SqlParameter("@COA_Code", COA_Code.EditValue),
                new SqlParameter("@Adjust_Description", Adjust_Description.Text.Trim()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE")
            };
            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Adjustment Profile", Adjust_Name.Text.Trim());
        }

        internal bool Control_Delete()
        {
            return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Adjustments WHERE ID LIKE '{ID.EditValue}'", $"Adjustment Profile: {Adjust_Name.Text}");
        }
    }
}
