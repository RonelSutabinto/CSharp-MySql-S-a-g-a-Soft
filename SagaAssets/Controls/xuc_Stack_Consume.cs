using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagaAssets.Controls
{
	public partial class xuc_Stack_Consume : DevExpress.XtraEditors.XtraUserControl
	{
		public xuc_Stack_Consume()
		{
			InitializeComponent();
		}

        public void Control_Initialize()
        {

        }

        public bool Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Entry", "Create New Entry", "You might lose unsaved data")) return false;
            class_Procedures.Initialize_Controls(this, bClear, true);
            Entry_Type.Select();
            return true;
        }

		internal bool Control_Retrieve(int iID)
		{
			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", iID),
				new SqlParameter("@Action_Type", "RETRIEVE")
			};
			using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Entry_Procedures"))
			{
				try
				{
					if (myDataReader != null && myDataReader.HasRows)
					{
						myDataReader.Read();
						ID.EditValue = myDataReader["ID"].ToString();
						Entry_Type.Text = myDataReader["Entry_Type"].ToString();
						Quantity.Value = Convert.ToInt32(myDataReader["Quantity"]);
						Entry_Description.Text = myDataReader["Entry_Description"].ToString();
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
			if (class_Procedures.isEmpty(Entry_Type))
				return false;
			if (class_Procedures.isEmpty(Quantity))
				return false;
			if (class_Procedures.isEmpty(Entry_Description))
				return false;

			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", ID.EditValue),
				new SqlParameter("@Entry_Type", Entry_Type.Text),
				new SqlParameter("@Quantity", Quantity.Value),
				new SqlParameter("@Entry_Description", Entry_Description.Text.Trim()),
				new SqlParameter("@Notes", Notes.Text.Trim()),
				new SqlParameter("@Added_By", class_Variables.sUserName),
				new SqlParameter("@Modified_By", class_Variables.sUserName),
				new SqlParameter("@Action_Type", "SAVE")
			};
			return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Entry_Procedures", "System Entry", Entry_Description.Text.Trim());
		}

		internal bool Control_Delete()
		{
			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", ID.EditValue),
				new SqlParameter("@Action_Type", "DELETE")
			};
			return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Entry_Procedures", "Delete System Entry", true));
		}
	}
}
