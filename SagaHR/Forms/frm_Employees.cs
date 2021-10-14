using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SagaHR.Forms
{
	public partial class frm_Employees
	{
		public frm_Employees()
		{
			if (xuc_Employee is null)
			{
				xuc_Employee = new Controls.xuc_Employee();
			}

			InitializeComponent();
			var BtnCancel = new SimpleButton();
			BtnCancel.Click += BtnCancel_Click;
			class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Employee.layoutControl, xuc_Settings);
			SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
		}

		private bool Form_Close()
		{
			return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Employee.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Form_Close();
		}

		private void frm_Employees_Load(object sender, EventArgs e)
		{
			SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_Branch(xuc_Employee.Employee_Branch);
			SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch);
		}

		private void frm_Employees_Shown(object sender, EventArgs e)
		{
			if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
				xuc_Employee.Control_Initialize();
			if (xuc_Settings.Toggle_Auto_Reload.IsOn)
				Data_Load();
		}

		private void frm_Employees_FormClosing(object sender, FormClosingEventArgs e)
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
			xuc_Employee.Control_Initialize();
		}

		private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Data_Load();
		}

		private void Data_Load()
		{
			if (xuc_Settings.Toggle_Load_All.IsOn)
			{
				class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM acc_Employees", "acc_Employees");
			}
			else if (!class_Procedures.isEmpty(xuc_Employee.Employee_Branch))
			{
				class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Employees WHERE Employee_Branch LIKE '{xuc_Employee.Employee_Branch.EditValue}'", "acc_Employees");
			}
			else
			{
				return;
			}
		}

		private void Load_Search(string sSearch)
		{
			if (sSearch.Length > 2)
			{
				class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Employees WHERE Employee_Name LIKE '%{sSearch}%'", "acc_Employees");
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

		private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridView.DataRowCount > 0)
			{
				string sCode, sServiceLength;
				class_Procedures.splash_Show("Updating Employees");
				for (int i = 0, loopTo = gridView.DataRowCount - 1; i <= loopTo; i++)
				{
					var Age = new DateDifference(Convert.ToDateTime(gridView.GetRowCellValue(i, colEmployee_Date_Birth)), DateTime.Today);
					var ServiceLength = new DateDifference(Convert.ToDateTime(gridView.GetRowCellValue(i, colEmployee_Date_Hired)), DateTime.Today);
					sCode = gridView.GetRowCellDisplayText(i, colEmployee_Code);
					sServiceLength = $"{ServiceLength.Years} Years and {ServiceLength.Months} Months";
					xuc_Employee.Control_Update(sCode, Age.Years, sServiceLength);
					gridView.SetRowCellValue(i, colEmployee_Age, Age.Years);
					gridView.SetRowCellValue(i, colEmployee_Service_Length, sServiceLength);
					if (xuc_Settings.Toggle_Live_Looping.IsOn)
					{
						gridView.FocusedRowHandle = i;
						gridView.MakeRowVisible(i);
						Application.DoEvents();
					}
				}

				gridView.BestFitColumns();
				class_Procedures.splash_Close();
			}
		}

		private void Data_Show()
		{
			if (gridView.RowCount > 0)
			{
				xuc_Employee.ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID);
				xuc_Employee.Employee_Code.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Code);
				xuc_Employee.Employee_ID.EditValue = gridView.GetFocusedRowCellDisplayText(colEmployee_ID);
				xuc_Employee.Employment_Status.Text = gridView.GetFocusedRowCellDisplayText(colEmployment_Status);
				xuc_Employee.Employee_Name.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Name);
				xuc_Employee.Employee_Address.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Address);
				xuc_Employee.Employee_Contact.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Contact);
				xuc_Employee.Employee_Date_Birth.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Date_Birth);
				xuc_Employee.Employee_Birth_Place.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Birth_Place);
				xuc_Employee.Employee_Civil_Status.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Civil_Status);
				xuc_Employee.Employee_Corporation.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Corporation);
				xuc_Employee.Employee_Branch.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Branch);
				xuc_Employee.Employee_Department.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Department);
				xuc_Employee.Employee_Position.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Position);
				xuc_Employee.Employee_Pay_Level.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Pay_Level);
				xuc_Employee.Employee_Pay_Class.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Pay_Class);
				xuc_Employee.Employee_Status.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Status);
				xuc_Employee.Employee_Date_Hired.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Date_Hired);
				xuc_Employee.Employee_Date_Probationary.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Date_Probationary);
				xuc_Employee.Employee_Date_Regular.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Date_Regular);
				xuc_Employee.Employee_TIN.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_TIN);
				xuc_Employee.Employee_SSS.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_SSS);
				xuc_Employee.Employee_PHIC.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_PHIC);
				xuc_Employee.Employee_PAG_IBIG.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_PAG_IBIG);
				xuc_Employee.Employee_Attainment.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Attainment);
				xuc_Employee.Employee_Course.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Course);
				xuc_Employee.Employee_Name_Spouse.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Name_Spouse);
				xuc_Employee.Employee_Children.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Children);
				xuc_Employee.Employee_Driver_License.Text = gridView.GetFocusedRowCellDisplayText(colEmployee_Driver_License);
				xuc_Employee.Engine.EditValue = gridView.GetFocusedRowCellDisplayText(colEngine);
				xuc_Employee.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
			}
		}

		private void Update_Data_Row()
		{
			if (gridView.RowCount > 0)
			{
				gridView.SetFocusedRowCellValue(colEmployee_ID, xuc_Employee.Employee_ID.EditValue);
				gridView.SetFocusedRowCellValue(colEmployment_Status, xuc_Employee.Employment_Status.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Name, xuc_Employee.Employee_Name.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Address, xuc_Employee.Employee_Address.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Contact, xuc_Employee.Employee_Contact.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Date_Birth, xuc_Employee.Employee_Date_Birth.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Birth_Place, xuc_Employee.Employee_Birth_Place.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Civil_Status, xuc_Employee.Employee_Civil_Status.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Corporation, xuc_Employee.Employee_Corporation.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Branch, xuc_Employee.Employee_Branch.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Position, xuc_Employee.Employee_Position.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Department, xuc_Employee.Employee_Department.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Pay_Level, xuc_Employee.Employee_Pay_Level.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Pay_Class, xuc_Employee.Employee_Pay_Class.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Status, xuc_Employee.Employee_Status.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Date_Hired, xuc_Employee.Employee_Date_Hired.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Date_Probationary, xuc_Employee.Employee_Date_Probationary.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Date_Regular, xuc_Employee.Employee_Date_Regular.Text);
				gridView.SetFocusedRowCellValue(colEmployee_TIN, xuc_Employee.Employee_TIN.Text);
				gridView.SetFocusedRowCellValue(colEmployee_SSS, xuc_Employee.Employee_SSS.Text);
				gridView.SetFocusedRowCellValue(colEmployee_PHIC, xuc_Employee.Employee_PHIC.Text);
				gridView.SetFocusedRowCellValue(colEmployee_PAG_IBIG, xuc_Employee.Employee_PAG_IBIG.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Attainment, xuc_Employee.Employee_Attainment.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Course, xuc_Employee.Employee_Course.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Name_Spouse, xuc_Employee.Employee_Name_Spouse.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Children, xuc_Employee.Employee_Children.Text);
				gridView.SetFocusedRowCellValue(colEmployee_Driver_License, xuc_Employee.Employee_Driver_License.Text);
				gridView.SetFocusedRowCellValue(colEngine, xuc_Employee.Engine.EditValue);
				gridView.SetFocusedRowCellValue(colNotes, xuc_Employee.Notes.Text);
			}
		}

		private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (xuc_Settings.Toggle_Select.IsOn)
				Data_Show();
		}

		private void gridView_MouseDown(object sender, MouseEventArgs e)
		{
			if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
			{
				btn_Setup_Salary.Enabled = gridView.GetFocusedRowCellDisplayText(colEmployment_Status).Equals("ACTIVE");
				btn_Generate_Paychecks.Enabled = gridView.GetFocusedRowCellDisplayText(colEmployment_Status).Equals("ACTIVE");
				popupMenu.ShowPopup(MousePosition);
			}
		}

		private void gridView_KeyDown(object sender, KeyEventArgs e)
		{
			if (gridView.DataRowCount > 0 & gridView.SelectedRowsCount > 0)
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
							xuc_Employee.Select();
							break;
						}
				}
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
							xuc_Employee.Select();
							break;
						}
					// class_Saga_Procedures.Show_Employee(e.CellValue.ToString)

					case "colEmployee_Code":
						{
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

		private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			xuc_Employee.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
		}

		private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (xuc_Employee.Control_Save())
			{
				if (xuc_Settings.Toggle_Auto_Reload.IsOn)
				{
					Data_Load();
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
			if (xuc_Employee.Control_Delete())
				gridView.DeleteRow(gridView.FocusedRowHandle);
		}

		private void btn_SMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			// Class_SMS.Show_Sender(gridView, "acc_Employees", "Employee_Name", "Employee_Contact", "Notes")
		}

		private void btn_Setup_Salary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (gridView.SelectedRowsCount > 0)
			{
				int iRowHandle, iRowHandleOld = 0;
				var selectedRows = gridView.GetSelectedRows();

				if (xuc_Settings.Toggle_Clear_Selection.IsOn)
					gridView.ClearSelection();

				for (int i = 0, loopTo = selectedRows.Length - 1; i <= loopTo; i++)
				{
					iRowHandle = selectedRows[i];
					try
					{
						if (gridView.GetRowCellDisplayText(iRowHandle, colEmployment_Status).Equals("ACTIVE"))
						{
							SqlParameter[] sqlParameters = new[] {
								new SqlParameter("@Salary_Code", class_Database.Get_Last_ID(class_Database.ICSConnection, "hr_Salaries", "Salary_Code", "SALARY-")),
								new SqlParameter("@Branch_Code", gridView.GetRowCellValue(iRowHandle, colEmployee_Branch)),
								new SqlParameter("@Employee_Code", gridView.GetRowCellDisplayText(iRowHandle, colEmployee_Code)),
								new SqlParameter("@Salary_Category", gridView.GetRowCellDisplayText(iRowHandle, colEmployee_Pay_Level)),
								new SqlParameter("@Salary_Type", gridView.GetRowCellDisplayText(iRowHandle, colEmployee_Pay_Class)),
								new SqlParameter("@Added_By", class_Variables.sUserName),
								new SqlParameter("@Action_Type", "SETUP_SALARY")
							};
							class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Salary_Procedures", "Salary Profile");
						}
					}
					catch (Exception ex)
					{
						class_Procedures.Show_Error(ex);
					}

					if (class_Functions.gridView_Loop(this.gridView, iRowHandleOld, iRowHandle, "Employee Salaries", "initialized/generated", false))
					{
						iRowHandleOld = iRowHandle;
					}
					else
					{
						return;
					}
				}
			}
		}
	}
}