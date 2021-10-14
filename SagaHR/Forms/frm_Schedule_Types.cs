using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Schedule_Types
    {
        public frm_Schedule_Types()
        {
            if (xuc_Schedule_Type is null)
            {
                xuc_Schedule_Type = new Controls.xuc_Schedule_Type();
            }

            InitializeComponent();
            var BtnCancel = new SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Schedule_Type.layoutControl, xuc_Settings);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Schedule_Type.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Schedule_Types_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Schedule_Types_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Schedule_Type.Control_Initialize();
            
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load("LOAD");
        }

        private void frm_Schedule_Types_FormClosing(object sender, FormClosingEventArgs e)
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
            xuc_Schedule_Type.Control_Initialize();
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
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "hr_Schedule_Procedures", "hr_Schedule_Types");
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
                xuc_Schedule_Type.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
                xuc_Schedule_Type.Schedule_Code.Text = gridView.GetFocusedRowCellDisplayText(colSchedule_Code);
                xuc_Schedule_Type.Schedule_Name.Text = gridView.GetFocusedRowCellDisplayText(colSchedule_Name);
                xuc_Schedule_Type.Schedule_Description.Text = gridView.GetFocusedRowCellDisplayText(colSchedule_Description);
                xuc_Schedule_Type.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);

                Load_Schedules();
            }
        }

        private void Load_Schedules()
        {
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl_Schedule, gridView_Schedule, $"SELECT * FROM hr_Schedules WHERE Schedule_Code LIKE '{gridView.GetFocusedRowCellDisplayText(colSchedule_Code)}' ORDER BY ID", "hr_Schedules");
            class_Procedures.Initialize_gridView(gridView_Schedule, true, true);
        }

        private void Update_Data_Row()
        {
            gridView.SetFocusedRowCellValue(colSchedule_Name, xuc_Schedule_Type.Schedule_Name.Text);
            gridView.SetFocusedRowCellValue(colSchedule_Description, xuc_Schedule_Type.Schedule_Description.Text);
            gridView.SetFocusedRowCellValue(colNotes, xuc_Schedule_Type.Notes.Text);
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (xuc_Settings.Toggle_Select.IsOn)
                Data_Show();
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
                            xuc_Schedule_Type.Select();
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
                            xuc_Schedule_Type.Select();
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
            xuc_Schedule_Type.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            class_Database.DBError = false;
            
            if (xuc_Schedule_Type.Control_Save())
            {
                int iRowHandle;
                int iRowHandleOld = 0;

                for (int i = 0, loopTo = gridView_Schedule.DataRowCount - 1; i <= loopTo; i++)
                {
                    iRowHandle = i;
                    int iID;
                    try
                    {
                        iID = (int)gridView_Schedule.GetRowCellValue(iRowHandle, colID_Schedule);
                    }
                    catch (Exception)
                    {
                        iID = 0;
                    }

                    try
                    {
                        string sScheduleCode = (string)gridView.GetFocusedRowCellValue(colSchedule_Code);

                        SqlParameter[] sqlParameters = new[] {
                        new SqlParameter("@ID", iID),
                        new SqlParameter("@Schedule_Code", sScheduleCode),
                        new SqlParameter("@Week_Day", gridView_Schedule.GetRowCellDisplayText(iRowHandle, colWeek_Day)),
                        new SqlParameter("@AM_In", gridView_Schedule.GetRowCellValue(iRowHandle, colAM_In)),
                        new SqlParameter("@AM_Out", gridView_Schedule.GetRowCellValue(iRowHandle, colAM_Out)),
                        new SqlParameter("@PM_In", gridView_Schedule.GetRowCellValue(iRowHandle, colPM_In)),
                        new SqlParameter("@PM_Out", gridView_Schedule.GetRowCellValue(iRowHandle, colPM_Out)),
                        new SqlParameter("@Schedule_Description", gridView_Schedule.GetRowCellDisplayText(iRowHandle, colDescription_Schedule)),
                        new SqlParameter("@Notes", gridView_Schedule.GetRowCellDisplayText(iRowHandle, colNotes_Schedule)),
                        new SqlParameter("@Added_By", class_Variables.sUserName),
                        new SqlParameter("@Modified_By", class_Variables.sUserName),
                        new SqlParameter("@Action_Type", "SAVE_SCHEDULE")
                    };
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Schedule_Procedures", "Schedule");
                    }
                    catch (Exception ex)
                    {
                        class_Procedures.Show_Error(ex);
                    }

                    if (class_Functions.gridView_Loop(this.gridView_Schedule, iRowHandleOld, iRowHandle, "Schedules", "saved/updated", false))
                        iRowHandleOld = iRowHandle;
                    else
                        return;
                }

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
            if (xuc_Schedule_Type.Control_Delete())
                gridView.DeleteRow(gridView.FocusedRowHandle);
        }

		private void gridView_Schedule_KeyDown(object sender, KeyEventArgs e)
		{
            if (gridView_Schedule.DataRowCount > 0 & gridView_Schedule.SelectedRowsCount > 0)
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        {
                            class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM hr_Schedules WHERE ID LIKE '{gridView_Schedule.GetFocusedRowCellValue(colID_Schedule)}'", "Schedule");
                            break;
                        }
                }
            }
        }
	}
}