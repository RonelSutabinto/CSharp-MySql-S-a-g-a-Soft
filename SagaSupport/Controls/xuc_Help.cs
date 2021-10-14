using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using SagaSupport.Classes;

namespace SagaSupport.Controls
{
	public partial class xuc_Help : DevExpress.XtraEditors.XtraUserControl
	{
		public xuc_Help()
		{
			InitializeComponent();
		}

		internal void Control_Initialize()
		{
			class_Database.Fill_Edit(class_Database.ICSConnection, Help_Category, "it_Helps", "Help_Category");
			class_Database.Fill_Edit(class_Database.ICSConnection, Help_Type, "it_Helps", "Help_Type");

			class_Support_Procedures.Initialize_Ticket_Groups(Help_Group, treeListLookUpEditTreeList);

			Solution.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
		}

		internal void Control_New(bool bAsk = false, bool bClearNew = true)
		{
			if (bAsk && !class_Procedures.actionAsk("New Help Profile", "Initialize new Help Profile", "You might lose unsaved data"))
				return;
			class_Procedures.Initialize_Controls(this, bClearNew);
			class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Help_Code, "it_Helps", "Help_Code", "HELP-");
			Help_Category.Select();
		}

		internal bool Control_Retrieve(string sCode)
		{
			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@Help_Code", sCode),
				new SqlParameter("@Action_Type", "RETRIEVE")
			};

			using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "it_Help_Procedures"))
			{
				if (myDataReader != null && myDataReader.HasRows)
				{
					try
					{
						myDataReader.Read();
						ID.EditValue = myDataReader["ID"].ToString();
						Help_Code.EditValue = myDataReader["Help_Code"].ToString();
						Help_Category.EditValue = myDataReader["Help_Category"].ToString();
						Help_Type.EditValue = myDataReader["Help_Type"].ToString();
						Name_Subject.Text = myDataReader["Name_Subject"].ToString();
						Help_Description.EditValue = myDataReader["Help_Description"].ToString();
						Solution.RtfText = myDataReader["Solution"].ToString();
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
			if (!class_Variables.isAdministrator)
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Only the Application Software Administrator can save/update.", "Error: Unauthorized User", true);
				return false;
			}

			if (class_Procedures.isEmpty(Help_Code)) return false;
			if (class_Procedures.isEmpty(Help_Type)) return false;
			if (class_Procedures.isEmpty(Name_Subject)) return false;

			if (ID.EditValue.Equals(0))
			{
				class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Help_Code, "it_Helps", "Help_Code", "HELP-");
			}

			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@ID", ID.EditValue),
				new SqlParameter("@Help_Code", Help_Code.EditValue),
				new SqlParameter("@Help_Category", Help_Category.EditValue),
				new SqlParameter("@Help_Type", Help_Type.EditValue),
				new SqlParameter("@Help_Group", Help_Group.EditValue),
				new SqlParameter("@Name_Subject", Name_Subject.Text.Trim()),
				new SqlParameter("@Help_Description", Help_Description.Text.Trim()),
				new SqlParameter("@Solution", Solution.RtfText),
				new SqlParameter("@Notes", Notes.Text.Trim()),
				new SqlParameter("@Added_By", class_Variables.sUserName),
				new SqlParameter("@Modified_By", class_Variables.sUserName),
				new SqlParameter("@Action_Type", "SAVE")
			};
			return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "it_Help_Procedures", "Help Profile", Name_Subject.Text.Trim());
		}

		internal bool Control_Delete()
		{
			if (class_Variables.isAdministrator)
			{
				return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM it_Helps WHERE ID LIKE '{ID.EditValue}'", $"Help Profile: {Name_Subject.Text}");
			}
			else
			{ 
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Only the Application Software Administrator can save/update.", "Error: Unauthorized User", true);
				return false;
			}
		}

		internal void Edit_Solution()
		{
			using (var frm = new SagaSupport.Forms.frm_Editor())
			{
				frm.Solution.RtfText = Solution.RtfText;

				var result = frm.ShowDialog();

				if (result == System.Windows.Forms.DialogResult.Cancel)
				{
					Solution.RtfText = class_Support_Variables.editorText;
				}
			}
		}
	}
}
