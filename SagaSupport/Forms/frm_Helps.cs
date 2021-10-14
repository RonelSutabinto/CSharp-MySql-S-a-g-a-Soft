using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SagaSupport.Forms
{
	public partial class frm_Helps
	{
		public frm_Helps()
		{
			if (xuc_Help is null)
			{
				xuc_Help = new SagaSupport.Controls.xuc_Help();
			}

			InitializeComponent();
			var BtnCancel = new SimpleButton();
			BtnCancel.Click += BtnCancel_Click;
			class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Help.layoutControl, xuc_Settings);
			SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
		}

		private bool Form_Close()
		{
			return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Help.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Form_Close();
		}

		private void frm_Helps_Load(object sender, EventArgs e)
		{
			btn_Save.Enabled = class_Variables.isAdministrator;
			btn_Delete.Enabled = class_Variables.isAdministrator;
			xuc_Help.Solution.ReadOnly = !class_Variables.isAdministrator;
		}

		private void frm_Helps_Shown(object sender, EventArgs e)
		{
			if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
				xuc_Help.Control_Initialize();

			if (xuc_Settings.Toggle_Auto_Reload.IsOn)
				Data_Load("LOAD");
		}

		private void frm_Helps_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Form_Close())
				e.Cancel = true;
		}

		private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Form_Close();
		}

		private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			xuc_Help.Control_Initialize();
		}

		private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			xuc_Help.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
		}

		private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			xuc_Help.Edit_Solution();
		}
		private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (xuc_Help.Control_Save())
			{
				if (xuc_Settings.Toggle_Auto_Reload.IsOn)
				{
					Data_Load("LOAD");
				}
				else
				{
					Update_Data_Row();
				}
			}
		}

		private void gridView_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
		{
			class_Procedures.Initialize_Printing(e);
		}

		private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			gridView.ShowRibbonPrintPreview();
		}

		private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (xuc_Help.Control_Delete())
				gridView.DeleteRow(gridView.FocusedRowHandle);
		}

		private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Data_Load("LOAD");
		}

		private void Data_Load(string sActionType, string sSearch = "")
		{
			SqlParameter[] sqlParameters = new[] {
				new SqlParameter("@Search", sSearch),
				new SqlParameter("@Action_Type", sActionType)
			};
			class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "it_Help_Procedures", "it_Helps");
		}

		private void Load_Search(string sSearch)
		{
			if (sSearch.Length > 2)
			{
				Data_Load("SEARCH");
			}
		}

		private void RepositoryItemSearchControl_Search_KeyDown(object sender, KeyEventArgs e)
		{
			if (sender is BaseEdit && e.KeyCode.Equals(Keys.Enter))
			{
				try
				{
					Load_Search(((BaseEdit)sender).Text.Trim());
				}
				catch (Exception ex)
				{
					class_Procedures.Show_Error(ex);
				}
			}
		}

		private void Data_Show()
		{
			if (gridView.RowCount > 0)
			{
				xuc_Help.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
				xuc_Help.Help_Code.Text = gridView.GetFocusedRowCellDisplayText(colHelp_Code);
				xuc_Help.Help_Category.Text = gridView.GetFocusedRowCellDisplayText(colHelp_Category);
				xuc_Help.Help_Type.EditValue = gridView.GetFocusedRowCellValue(colHelp_Type);
				xuc_Help.Help_Group.EditValue = gridView.GetFocusedRowCellValue(colHelp_Group);
				xuc_Help.Name_Subject.Text = gridView.GetFocusedRowCellDisplayText(colName_Subject);
				xuc_Help.Help_Description.Text = gridView.GetFocusedRowCellDisplayText(colHelp_Description);
				xuc_Help.Solution.RtfText = gridView.GetFocusedRowCellDisplayText(colSolution);
				xuc_Help.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
				//xuc_Help.Control_Retrieve(gridView.GetFocusedRowCellDisplayText(colHelp_Code));
			}
		}

		private void Update_Data_Row()
		{
			gridView.SetFocusedRowCellValue(colHelp_Category, xuc_Help.Help_Category.EditValue);
			gridView.SetFocusedRowCellValue(colHelp_Type, xuc_Help.Help_Type.EditValue);
			gridView.SetFocusedRowCellValue(colHelp_Group, xuc_Help.Help_Group.EditValue);
			gridView.SetFocusedRowCellValue(colName_Subject, xuc_Help.Name_Subject.Text);
			gridView.SetFocusedRowCellValue(colHelp_Description, xuc_Help.Help_Description.Text);
			gridView.SetFocusedRowCellValue(colSolution, xuc_Help.Solution.RtfText);
			gridView.SetFocusedRowCellValue(colNotes, xuc_Help.Notes.Text);
		}

		private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (xuc_Settings.Toggle_Select.IsOn)
				Data_Show();
		}

		private void gridView_KeyDown(object sender, KeyEventArgs e)
		{
			if (gridView.DataRowCount > 0 && gridView.SelectedRowsCount > 0)
			{
				switch (e.KeyData)
				{
					case Keys.Enter:
						{
							Data_Show();
							break;
						}

					case Keys.F2:
						{
							xuc_Help.Select();
							break;
						}
				}
			}
		}

		private void gridView_MouseDown(object sender, MouseEventArgs e)
		{
			if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
			{
				popupMenu.ShowPopup(MousePosition);
			}
		}

		private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (gridView.RowCount > 0 && e.Clicks.Equals(2))
			{
				Data_Show();
				switch (e.Column.Name ?? "")
				{
					case "colID":
						{
							xuc_Help.Select();
							break;
						}

					default:
						{
							Data_Show();
							if (e.CellValue is null)
								return;
							else
								class_Procedures.Copy_Clipboard(e.CellValue.ToString());
							break;
						}
				}
			}
		}
	}
}