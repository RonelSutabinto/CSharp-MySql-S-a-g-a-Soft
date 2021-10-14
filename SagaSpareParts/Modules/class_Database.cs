using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyClassLibrary.Classes
{
    public static class class_Database
    {
        private static string sID_Code;
        public static string SqlServerType;
        public static string SqlServer;
        public static string SqlPort;
        public static string SqlDatabase;
        public static string SqlUser;
        public static string SqlPassword;
        public static int SqlTimeOut;
        public static bool bIsLocal;
        public static bool bLoopStop;
        public static bool DBError;
        public static string sError;
        public static string ICSConnection;
        public static string SPAConnection;
        public static string ICSConnectionTemp;
        public static string connectionStringAccEntity, connectionStringHREntity;
        public static string sUpdateLink;
        public static SqlConnection mySQLConnection = new SqlConnection();
        public static SqlConnection spaSQLConnection = new SqlConnection();
        public static SqlDataAdapter myDataAdapter = new SqlDataAdapter();
        public static string sValueNew;

        public static void Initialize_Connection()
        {
            SqlServerType = class_Tools.RegKeyGet("Server Connection", "Type", "localhost");
            bIsLocal = class_Tools.RegKeyGet("Server Connection", "isLocal", true);
            SqlServer = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Server", Environment.MachineName), Environment.MachineName);
            SqlDatabase = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Database", string.Empty), string.Empty);
            SqlUser = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "User Name", string.Empty), string.Empty);
            SqlPassword = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Password", string.Empty), string.Empty);
            SqlTimeOut = class_Tools.RegKeyGet("Server Connection", "Timeout", 15);
            sUpdateLink = $"http://{SqlServer}/AutoUpdate/{Application.ProductName}/";
            ICSConnection = $"Data Source={SqlServer}; Initial Catalog={SqlDatabase}; Persist Security Info=True; Connect Timeout={SqlTimeOut}; User ID={SqlUser}; Password={SqlPassword};";
            ICSConnectionTemp = $"Data Source={class_Functions.maskString(SqlServer, 2, 2)};{Environment.NewLine} Initial Catalog={class_Functions.maskString(SqlDatabase, 1, 1)};{Environment.NewLine} Persist Security Info=True;{Environment.NewLine} Connect Timeout={SqlTimeOut};{Environment.NewLine} User ID={class_Functions.maskString(SqlUser, 1, 1)};{Environment.NewLine} Password={class_Functions.maskString(SqlPassword, 0, 0)};";
            // MyBase.New({MyClassLibrary.Classes.connectionStringAccEntity})
            connectionStringAccEntity = $"metadata=res://*/Models.Model_Accounting.csdl|res://*/Models.Model_Accounting.ssdl|res://*/Models.Model_Accounting.msl;provider=System.Data.SqlClient;provider connection string='{ICSConnection}; multipleactiveresultsets=True; application name=EntityFramework;'";
            connectionStringHREntity = $"metadata=res://*/Models.Model_HR.csdl|res://*/Models.Model_HR.ssdl|res://*/Models.Model_HR.msl; provider=System.Data.SqlClient; provider connection string='{ICSConnection}; multipleactiveresultsets=True; application name=EntityFramework;'";
            SPAConnection = $"Data Source={SqlServer}; Initial Catalog=Spare_Parts; Persist Security Info=True; Connect Timeout={SqlTimeOut}; User ID={SqlUser}; Password={SqlPassword};";
        }

        public static bool OpenDB(string sConnection, bool bSplash = false)
        {
            if (!bIsLocal && !class_Connections.is_Network_Adapter_OK())
                return false;
            try
            {
                if (bSplash)
                    class_Procedures.splash_Show("connecting to SQL Server Database", bForceShow: bSplash);
                CloseDB();
                mySQLConnection.ConnectionString = sConnection;
                mySQLConnection.Open();
                DBError = false;
                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close(true);
            }
        }

        public static void CloseDB()
        {
            if (mySQLConnection.State.Equals(ConnectionState.Open))
            {
                mySQLConnection.Close();
            }
        }

        public static bool Procedure_BindData(string sConnection, SqlParameter[] Parameters, GridControl GridControl, GridView GridView, string sProcedureName, string sTable)
        {
            var MySQLConnection = new SqlConnection(sConnection);
            using (SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure })
            {
                MyCommand.Parameters.AddRange(Parameters);
                int iRow = GridView.FocusedRowHandle;
                try
                {
                    GridView.LoadingPanelVisible = true;
                    class_Procedures.splash_Show($"loading {sTable}", bForceShow: true);
                    var da = new SqlDataAdapter(MyCommand);
                    var ds = new DataSet();
                    MySQLConnection.Open();
                    ds.Clear();
                    da.Fill(ds, sTable);
                    GridControl.DataMember = sTable;
                    GridControl.DataSource = ds;
                    return true;
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                finally
                {
                    GridView.BestFitColumns();
                    if (iRow.Equals(0))
                    {
                        GridView.MoveFirst();
                    }
                    else
                    {
                        GridView.ClearSelection();
                        GridView.SelectRow(iRow);
                        GridView.MakeRowVisible(iRow);
                    }

                    GridView.LoadingPanelVisible = false;
                    class_Procedures.splash_Close(true);
                }
            }

            return false;
        }

        public static bool Procedure_BindData(string sConnection, SqlParameter[] Parameters, XtraReport xRpt, string sProcedureName, string sTable)
        {
            var MySQLConnection = new SqlConnection(sConnection);
            using (SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure })
            {
                MyCommand.Parameters.AddRange(Parameters);
                try
                {
                    class_Procedures.splash_Show($"loading {sTable}", bForceShow: true);
                    var da = new SqlDataAdapter(MyCommand);
                    var ds = new DataSet();
                    MySQLConnection.Open();
                    ds.Clear();
                    da.Fill(ds, sTable);
                    xRpt.DataMember = sTable;
                    xRpt.DataSource = ds;
                    var rpTool = new ReportPrintTool(xRpt);
                    rpTool.ShowRibbonPreview();
                    return true;
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                finally
                {
                    class_Procedures.splash_Close(true);
                }
            }

            return false;
        }

        public static SqlDataReader Procedure_Retrieve(string sConnection, SqlParameter[] Parameters, string sProcedureName, bool bSplash = false)
        {
            var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure };
            MyCommand.Parameters.AddRange(Parameters);
            try
            {
                class_Procedures.splash_Show("Executing Information", bForceShow: bSplash);
                MySQLConnection.Open();
                return MyCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
                return null;
            }
            finally
            {
                class_Procedures.splash_Close(bSplash);
            }
        }

        public static bool Procedure_Retrieve(string sConnection, SqlParameter[] Parameters, GridControl GridControl, GridView GridView, string sProcedureName, string sTitle = "", bool bForceShow = false)
        {
            var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure };
            MyCommand.Parameters.AddRange(Parameters);
            int iRow = GridView.FocusedRowHandle;
            try
            {
                class_Procedures.splash_Show($"Retrieving {sTitle}", bForceShow: class_Variables.bSplash || bForceShow);
                GridView.LoadingPanelVisible = true;
                MySQLConnection.Open();
                var dr = MyCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    GridControl.DataSource = dr;
                    return true;
                }
                else
                {
                    GridControl.DataSource = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                GridView.BestFitColumns();
                if (iRow.Equals(0))
                {
                    GridView.MoveFirst();
                }
                else
                {
                    GridView.ClearSelection();
                    GridView.SelectRow(iRow);
                    GridView.MakeRowVisible(iRow);
                    GridView.FocusedRowHandle = iRow;
                }

                GridView.LoadingPanelVisible = false;
                class_Procedures.splash_Close(class_Variables.bSplash || bForceShow);
            }
        }

        public static bool Procedure_Save(string sConnection, SqlParameter[] Parameters, string sProcedureName, string sTitle, string sCode = "")
        {
            if (sCode.Length > 0 && !Data_Save_Ask(sCode))
                return false;
            using var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure };
            MyCommand.Parameters.AddRange(Parameters);
            try
            {
                class_Procedures.splash_Show($"Saving/Updating {sTitle}", bForceShow: true);
                MySQLConnection.Open();
                int iRows = MyCommand.ExecuteNonQuery();
                if (sCode.Length > 0 || class_Variables.bNotifications)
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"Executing {sTitle}{Environment.NewLine}{iRows + 1} row(s) affected.");
                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close(true);
            }
        }

        public static int Procedure_Execute(string sConnection, SqlParameter[] Parameters, string sProcedureName, string sTitle, bool bAsk = false)
        {
            if (bAsk && !Query_Execute_Ask(sTitle))
                return 0;
            using var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sProcedureName, MySQLConnection) { CommandType = CommandType.StoredProcedure };
            MyCommand.Parameters.AddRange(Parameters);
            try
            {
                class_Procedures.splash_Show($"Executing {sTitle}", bForceShow: true);
                MySQLConnection.Open();
                int iRows = MyCommand.ExecuteNonQuery();
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Executing {sTitle}{Environment.NewLine}{iRows} row(s) affected.");
                return iRows;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                class_Procedures.splash_Close(true);
            }
        }

        public static DataSet SetDataset(string sConnection, DataSet ds, string sQuery, string sTable, bool bSplash = false)
        {
            FillData(sConnection, ds, myDataAdapter, sQuery, sTable, bSplash);
            return ds;
        }

        public static SqlDataReader SetSqlDataReader(string sConnection, string sQuery)
        {
            var MySQLConnection = new SqlConnection(sConnection);
            SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                return MyCommand.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                // DO NOT close the connection
            }
        }

        public static void FillData(string sConnection, DataSet ds, SqlDataAdapter da, string sQuery, string sTable, bool bSplash = false)
        {
            var watch = new Stopwatch();
            watch.Start();
            using (SqlConnection MySQLConnection = new SqlConnection(sConnection))
            {
                da.SelectCommand = new SqlCommand(sQuery, MySQLConnection);
                ds.Clear();
                try
                {
                    class_Procedures.splash_Show($"loading {sTable}", bForceShow: bSplash);
                    MySQLConnection.Open();
                    da.Fill(ds, sTable);
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                finally
                {
                    class_Procedures.splash_Close(bSplash);
                }
            }

            watch.Stop();
            if (class_Variables.bNotifications)
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Loading time: {watch.ElapsedMilliseconds} milliseconds", $"{sTable}");
        }

        public static BindingSource BindSource(string sConnection, DataSet ds, string sQuery, string sTable, bool bSplash = false)
        {
            try
            {
                FillData(sConnection, ds, myDataAdapter, sQuery, sTable, bSplash);
                var bs = new BindingSource()
                {
                    DataSource = ds,
                    DataMember = sTable
                };
                return bs;
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }

            return null;
        }

        public static SqlDataSource BindToData(string sQuery)
        {
            var connectionParameters = new MySqlConnectionParameters(SqlServer, SqlDatabase, SqlUser, SqlPassword, (int)MsSqlAuthorizationType.SqlServer);
            var ds = new SqlDataSource(connectionParameters);
            var query = new CustomSqlQuery()
            {
                Name = "customQuery",
                Sql = sQuery
            };
            ds.Queries.Add(query);
            try
            {
                ds.RebuildResultSchema();
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }

            return ds;
        }

        public static bool BindData(string sConnection, GridControl gridControl, GridView gridView, string sQuery, string sTable)
        {
            var iRow = default(int);
            try
            {
                gridView.LoadingPanelVisible = true;
                if (gridView.SelectedRowsCount > 0)
                {
                    iRow = gridView.FocusedRowHandle;
                }
                else
                {
                    iRow = 0;
                }

                using (DataSet ds = new DataSet())
                {
                    gridControl.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                gridView.BestFitColumns();
                if (iRow.Equals(0))
                {
                    gridView.MoveFirst();
                }
                else
                {
                    gridView.ClearSelection();
                    gridView.SelectRow(iRow);
                    gridView.MakeRowVisible(iRow);
                }

                gridView.LoadingPanelVisible = false;
            }
        }

        public static bool BindData(string sConnection, GridControl gridControl, GridView gridView, string sQuery, bool bClearColumns = true)
        {
            gridView.LoadingPanelVisible = true;
            if (bClearColumns)
                gridView.Columns.Clear();
            gridControl.DataSource = null;
            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            try
            {
                // Do not display splash to avoid popup disappearance
                MySQLConnection.Open();
                using (SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection))
                {
                    using var dr = MyCommand.ExecuteReader();
                    gridControl.DataSource = dr;
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                if (gridView.DataRowCount < 5000)
                    gridView.BestFitColumns();
                gridView.LoadingPanelVisible = false;
            }
        }

        public static bool BindData(string sConnection, RepositoryItem repositoryItem, GridView gridView, string sQuery, string sTable)
        {
            try
            {
                gridView.LoadingPanelVisible = true;
                using (var ds = new DataSet())
                {
                    if (repositoryItem is RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit)
                    {
                        repositoryItemSearchLookUpEdit.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    }
                    else if (repositoryItem is RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit)
                    {
                        repositoryItemGridLookUpEdit.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    }

                    gridView.BestFitColumns();
                    gridView.LoadingPanelVisible = false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, RepositoryItem repositoryItem, string sQuery, string sTable)
        {
            try
            {
                using (var ds = new DataSet())
                {
                    if (repositoryItem is RepositoryItemLookUpEdit repositoryItemLookUpEdit)
                    {
                        repositoryItemLookUpEdit.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    }
                    else if (repositoryItem is RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit)
                    {
                        repositoryItemSearchLookUpEdit.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    }
                    else if (repositoryItem is RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit)
                    {
                        repositoryItemGridLookUpEdit.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, BaseEdit baseEdit, string sQuery, string sTable, bool bSplash = false)
        {
            try
            {
                using (DataSet ds = new DataSet())
                {
                    if (baseEdit is LookUpEdit lookUpEdit)
                    {
                        lookUpEdit.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash);
                        lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                        lookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    }
                    else if (baseEdit is SearchLookUpEdit searchLookUpEdit)
                    {
                        searchLookUpEdit.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash);
                        searchLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                        searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    }
                    else if (baseEdit is TreeListLookUpEdit treeListLookUpEdit)
                    {
                        treeListLookUpEdit.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash);
                        treeListLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                        treeListLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, DevExpress.XtraTreeList.TreeList treeList, string sQuery, string sTable)
        {
            try
            {
                using (var ds = new DataSet())
                {
                    treeList.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    treeList.BestFitColumns();
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, TreeListLookUpEdit treeList, string sQuery, string sTable)
        {
            try
            {
                using (var ds = new DataSet())
                {
                    treeList.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, DevExpress.XtraVerticalGrid.VGridControl gc, string sQuery, string sTable)
        {
            try
            {
                using (var ds = new DataSet())
                {
                    gc.DataSource = BindSource(sConnection, ds, sQuery, sTable);
                    gc.BestFit();
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, XtraReport xRpt, string sQuery, string sTable)
        {
            try
            {
                class_Procedures.splash_Show("Executing Report Query");
                using (var ds = new DataSet())
                {
                    xRpt.DataSource = SetDataset(sConnection, ds, sQuery, sTable);
                    xRpt.DataMember = sTable;
                }

                var rpTool = new ReportPrintTool(xRpt);
                rpTool.ShowRibbonPreview();
                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close();
            }
        }

        public static bool BindData(string sConnection, TokenEdit token, string sQuery, string sTable, bool bSplash = false)
        {
            try
            {
                using (var ds = new DataSet())
                {
                    token.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash);
                    token.Properties.DisplayMember = "Check_Number";
                    token.Properties.ValueMember = "Check_Number";
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
        }

        public static bool BindData(string sConnection, Dashboard dashBoard, DashboardObjectDataSource tableAdapter, string sQuery, string sTable)
        {
            try
            {
                class_Procedures.splash_Show("Executing Report Query");
                using (DataSet ds = new DataSet())
                {
                    tableAdapter.DataSource = SetDataset(sConnection, ds, sQuery, sTable);
                    tableAdapter.DataMember = sTable;
                }

                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close();
            }
        }

        public static bool IsDataExist(string sConnection, string sQuery)
        {
            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                class_Procedures.splash_Show("Checking if Data exist");
                MySQLConnection.Open();
                using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                return MyDataReader.HasRows;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close();
            }
        }

        public static void Fill_Edit(string sConnection, BaseEdit baseEdit, string sTable, string sDistinctField, bool bSorted = true, bool bClear = true, bool bCustomQuery = false, string sCustomQuery = "")
        {
            int iCount = 0;
            string sQuery;
            if (bCustomQuery)
            {
                sQuery = sCustomQuery;
            }
            else
            {
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} ORDER BY {sDistinctField} ASC";
            }

            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                class_Procedures.splash_Show($"loading {sDistinctField}", bForceShow: true);
                using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                if (baseEdit is ComboBoxEdit comboBoxEdit)
                {
                    if (bClear)
                        comboBoxEdit.Properties.Items.Clear();
                    if (MyDataReader.HasRows)
                    {
                        while (MyDataReader.Read())
                        {
                            comboBoxEdit.Properties.Items.Add(MyDataReader[sDistinctField]);
                            iCount += 1;
                        }
                        comboBoxEdit.Properties.Sorted = bSorted;
                        comboBoxEdit.Properties.DropDownRows = iCount;
                    }
                }
                else if (baseEdit is TokenEdit tokenEdit)
                {
                    if (MyDataReader.HasRows)
                    {
                        tokenEdit.Properties.BeginUpdate();
                        while (MyDataReader.Read())
                            tokenEdit.Properties.Tokens.AddToken(MyDataReader[sDistinctField]);
                        tokenEdit.Properties.EndUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close(true);
            }
        }

        public static int Fill_Edit(string sConnection, RepositoryItemComboBox comboBox, string sTable, string sDistinctField, bool bClear = true, bool bWhereCondition = false, string sWhereValue = "")
        {
            int iReturn = 0;
            string sQuery;
            if (bWhereCondition)
            {
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} WHERE {sDistinctField} LIKE '{sWhereValue}' ORDER BY {sDistinctField} ASC";
            }
            else
            {
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} ORDER BY {sDistinctField} ASC";
            }

            class_Procedures.splash_Show($"loading {sTable}");
            using (var MySQLConnection = new SqlConnection(sConnection))
            {
                using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
                try
                {
                    MySQLConnection.Open();
                    using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                    if (bClear)
                        comboBox.Items.Clear();
                    if (MyDataReader.HasRows)
                    {
                        while (MyDataReader.Read())
                        {
                            comboBox.Items.Add(MyDataReader[sDistinctField]);
                            iReturn += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                finally
                {
                    class_Procedures.splash_Close();
                }
            }

            return iReturn;
        }

        public static int Fill_Edit(string sConnection, ComboBoxEdit comboBox, string sTable, string sWhereField, string sDistinctField, string sLikeValue)
        {
            int iReturn = 0;
            string sQuery = $"SELECT DISTINCT {sDistinctField}, {sWhereField} FROM {sTable} WHERE {sWhereField} LIKE '{sLikeValue}' ORDER BY {sDistinctField} ASC";
            class_Procedures.splash_Show($"loading {sTable}");
            using (var MySQLConnection = new SqlConnection(sConnection))
            {
                using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
                try
                {
                    MySQLConnection.Open();
                    using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                    comboBox.Properties.Items.Clear();
                    if (MyDataReader.HasRows)
                    {
                        while (MyDataReader.Read())
                        {
                            comboBox.Properties.Items.Add(MyDataReader[sDistinctField]);
                            iReturn += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                finally
                {
                    class_Procedures.splash_Close();
                }
            }

            return iReturn;
        }

        public static int Get_Last_ID(string sConnection, string sTable, string sIDField = "ID")
        {
            string sQuery = $"SELECT TOP(1) {sIDField} FROM {sTable} ORDER BY {sIDField} DESC";
            using (var MySQLConnection = new SqlConnection(sConnection))
            {
                using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
                try
                {
                    MySQLConnection.Open();
                    using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                    MyDataReader.Read();
                    if (MyDataReader.HasRows)
                    {
                        return Convert.ToInt32(MyDataReader[$"{sIDField}"]) + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
            }

            return 0;
        }

        public static string Get_Last_ID(string sConnection, string sTable, string sIDField, string sWhereCodeField, string sWherePreCodeValue, int iDash = 0)
        {
            string sQuery = $"SELECT TOP(1) {sIDField}, {sWhereCodeField} FROM {sTable} WHERE {sWhereCodeField} LIKE '{sWherePreCodeValue}%' ORDER BY {sIDField} DESC";
            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                MyDataReader.Read();
                if (MyDataReader.HasRows)
                {
                    if (iDash > 0)
                    {
                        string sCode = $"{sWherePreCodeValue}{MyDataReader[$"{sWhereCodeField}"].ToString().Remove(0, sWherePreCodeValue.Length)}";
                        var sNumber = sCode.Split('-');
                        return $"{sWherePreCodeValue}{Convert.ToInt32(sNumber[iDash]) + 1}";
                    }
                    else
                    {
                        return $"{sWherePreCodeValue}{Convert.ToInt32(MyDataReader[$"{sWhereCodeField}"].ToString().Remove(0, sWherePreCodeValue.Length)) + 1}";
                    }
                }
                else
                {
                    return $"{sWherePreCodeValue}{1}";
                }
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
                return null;
            }
        }

        public static string Get_Last_ID(string sConnection, string sTable, string sWhereCodeField, string sWherePreCodeValue, int iPreChars, string sAndSQL = "")
        {
            // Must be sorted by ID and not by field
            string sQuery = $"SELECT TOP(1) {sWhereCodeField}=CAST(RIGHT({sWhereCodeField}, LEN({sWhereCodeField})-{iPreChars}) AS int) FROM {sTable} WHERE {sWhereCodeField} LIKE '{sWherePreCodeValue}%' {sAndSQL} ORDER BY {sWhereCodeField} DESC";
            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                MyDataReader.Read();
                if (MyDataReader.HasRows)
                {
                    return $"{sWherePreCodeValue}{Convert.ToInt32(MyDataReader[$"{sWhereCodeField}"]) + 1}";
                }
                // Return $"{sWherePreCodeValue}{CInt(MyDataReader($"{sWhereCodeField}").ToString.Remove(0, sWherePreCodeValue.Length)) + 1}"
                else
                {
                    return $"{sWherePreCodeValue}{1}";
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string Get_ID(string sConnection, string sTable, string sPreCode, int iZeros, string sIDField = "ID")
        {
            int iCode = Get_Last_ID(sConnection, sTable, sIDField);
            int iLength = iCode.ToString().Length;
            if (iLength > iZeros)
                iZeros = iLength;
            string sZeros = new string('0', iZeros);
            string sTmpCode = $"{sPreCode}{sZeros}";
            sID_Code = sTmpCode.Remove(sTmpCode.Length - iLength);
            sID_Code = sID_Code.Insert(sTmpCode.Length - iLength, iCode.ToString());
            return sID_Code;
        }

        public static object Get_Data(string sConnection, string sQuery, string sField)
        {
            using (SqlConnection MySQLConnection = new SqlConnection(sConnection))
            {
                using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
                try
                {
                    MySQLConnection.Open();
                    using SqlDataReader MyDataReader = MyCommand.ExecuteReader();
                    MyDataReader.Read();
                    if (MyDataReader.HasRows)
                    {
                        return MyDataReader[sField];
                    }
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                    return null;
                }
            }

            return null;
        }

        public static decimal Get_Data(string sConnection, string sQuery, string sFieldDebit, string sFieldCredit)
        {
            class_Procedures.splash_Show($"Getting {sFieldDebit} + {sFieldCredit}");
            using var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                using var MyDataReader = MyCommand.ExecuteReader();
                MyDataReader.Read();
                if (MyDataReader.HasRows)
                {
                    try
                    {
                        return Convert.ToDecimal(MyDataReader[sFieldDebit]) + Convert.ToDecimal(MyDataReader[sFieldCredit]);
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                class_Procedures.splash_Close();
            }
            return 0;
        }

        public static bool Data_Update(string sConnection, string sUpdateQuery, bool bForce = false)
        {
            using SqlConnection MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sUpdateQuery, MySQLConnection);
            try
            {
                class_Procedures.splash_Show($"Updating Data", bForceShow: bForce);
                MySQLConnection.Open();
                int iRows = MyCommand.ExecuteNonQuery();
                if (class_Variables.bNotifications | bForce)
                {
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"[{sUpdateQuery}]{Environment.NewLine}{iRows} Record(s) has been successfully executed.");
                }

                return Convert.ToBoolean(iRows);
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close(bForce);
            }
        }

        public static bool Data_Replace(string sConnection, string sTitle, string sTable, string sField, string sFieldValueOld, string sFieldValueNew)
        {
            return Query_Execute(sConnection, $"UPDATE {sTable} SET {sField} = '{sFieldValueNew}' WHERE {sField} LIKE '{sFieldValueOld}'", true, $"Replace {sTitle}", $"Replace {sTitle}");
        }

        public static bool Data_Is_Locked(string sConnection, string sTitle, string sTable, string sCodeField, string sCodeValue)
        {
            if (IsDataExist(sConnection, $"SELECT {sCodeField}, IsLocked FROM {sTable} WHERE {sCodeField} LIKE '{sCodeValue}' AND IsLocked LIKE '1'"))
            {
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"This {sTitle} was locked by Admin.{Environment.NewLine}Editing/Updating/Deleting is not allowed.{Environment.NewLine}Please contact Administrator.", "Unauthorized Edit/Update/Delete", true);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Data_Save_Ask(string sTransaction)
        {
            var myResult = XtraMessageBox.Show($"Do you want to save/update/replace this {sTransaction}?{Environment.NewLine}{Environment.NewLine}Note: You might save/update a wrong data/information or this might overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify and update your transactions.", $"Save / Update {sTransaction}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Data_Save_Ask(string sConnection, string sTransaction, string sQuery, bool bWarningIfExisting = true, bool bReplaceIfExisting = false)
        {
            if (IsDataExist(sConnection, sQuery))
            {
                System.Media.SystemSounds.Exclamation.Play();
                if (bWarningIfExisting)
                {
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"{sTransaction} was already existing.{Environment.NewLine}Please abort if you are not certain for this update", "Update Warning - Record Existing", true);
                }

                if (bReplaceIfExisting)
                {
                    sQuery = $"The [{sTransaction}] was already existing.{Environment.NewLine}Do you still want to update?{Environment.NewLine}{Environment.NewLine}Note: This action will overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify to avoid data loss on your transaction(s).";
                }
                else
                {
                    sQuery = $"The [{sTransaction}] was already existing.{Environment.NewLine}You cannot proceed!{Environment.NewLine}{Environment.NewLine}Note: This action surely overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify to avoid data loss on your transaction(s).";
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{sQuery}{Environment.NewLine}{Environment.NewLine}Please contact your Administrator.", "Already Existing!", true);
                    return false;
                }
            }
            else
            {
                sQuery = $"Do you want to save this {sTransaction}?{Environment.NewLine}{Environment.NewLine}Note: This action might overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify and update your transactions.";
            }

            var myResult = XtraMessageBox.Show(sQuery, $"Save/Update/Replace {sTransaction}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Query_Execute(string sConnection, string sQuery, bool bAsk = false, string sTitle = "", string sTransaction = "")
        {
            if (!class_Variables.isAdministrator)
            {
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Cannot execute query due to user level protection.{Environment.NewLine}Please contact your Administrator.");
                return false;
            }

            if (bAsk)
            {
                if (!Query_Execute_Ask(sTransaction, sQuery))
                {
                    return false;
                }
            }

            class_Procedures.splash_Show($"Executing Query/Command", bForceShow: true);
            using var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                int iRows = MyCommand.ExecuteNonQuery();
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"{iRows} Transaction(s) has been executed.", sTitle);
                return true;
            }
            catch (Exception ex)
            {
                return class_Procedures.Show_Error(ex);
            }
            finally
            {
                class_Procedures.splash_Close(true);
            }
        }

        public static bool Query_Execute_Ask(string sTitle, string sQuery = "")
        {
            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to Execute [{sTitle}] that might affect data records.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Execute SQL Query Command", true);
            if (XtraMessageBox.Show($"Do you want to execute this:{Environment.NewLine}{sTitle} {sQuery}?{Environment.NewLine}{Environment.NewLine}Note: You can't UNDO this operation.", $"{sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Data_Delete_Ask(string sConnection, string sFromSQL, string sTitle, bool bDeleteOwnedDataOnly = false, string sOwnerField = "")
        {
            if (IsDataExist(sConnection, $"SELECT * {sFromSQL}"))
            {
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to Delete/Remove:{Environment.NewLine}{sTitle}.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Delete/Remove", true);
                var myResult = XtraMessageBox.Show($"Do you want To delete this {sTitle}?{Environment.NewLine}{Environment.NewLine}Note You can't UNDO this operation.{Environment.NewLine}{Environment.NewLine}Reminder: Please review and verify before you proceed.", $"Delete {sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    class_Procedures.splash_Show(sTitle);
                    string sQuery;
                    if (class_Variables.isAdministrator)
                    {
                        sQuery = $"DELETE {sFromSQL}";
                    }
                    else if (bDeleteOwnedDataOnly)
                    {
                        sQuery = $"DELETE {sFromSQL} AND {sOwnerField} LIKE '{class_Variables.sUserName}'";
                    }
                    else
                    {
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cannot Delete {sTitle} due to it's protection level. {Environment.NewLine}Please contact your Administrator.", "Data Protection Detected");
                        return false;
                    }

                    using var MySQLConnection = new SqlConnection(sConnection);
                    using SqlCommand MyCommand = new SqlCommand(sQuery, MySQLConnection);
                    try
                    {
                        MySQLConnection.Open();
                        if (Convert.ToInt32(MyCommand.ExecuteScalar()) > 1)
                        {
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Delete, sTitle);
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return class_Procedures.Show_Error(ex);
                    }
                    finally
                    {
                        class_Procedures.splash_Close();
                    }
                }
            }

            return false;
        }

        public static bool Data_Delete_Quick(string sConnection, string sFromSQL, bool bDeleteOwnedDataOnly = false, string sOwnerField = "")
        {
            string sDeleteQuery;
            if (class_Variables.isAdministrator)
            {
                sDeleteQuery = $"DELETE {sFromSQL}";
            }
            else if (bDeleteOwnedDataOnly)
            {
                sDeleteQuery = $"DELETE {sFromSQL} AND {sOwnerField} LIKE '{class_Variables.sUserName}'";
            }
            else
            {
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cannot Delete Data due to it's protection level.{Environment.NewLine}Please contact your Administrator.");
                return false;
            }

            using var MySQLConnection = new SqlConnection(sConnection);
            using SqlCommand MyCommand = new SqlCommand(sDeleteQuery, MySQLConnection);
            try
            {
                MySQLConnection.Open();
                if (Convert.ToInt32(MyCommand.ExecuteScalar()) > 0 && class_Variables.bNotifications)
                {
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"[{sDeleteQuery}] has been successfully executed.");
                }

                return true;
            }
            catch (Exception ex)
            {


                return class_Procedures.Show_Error(ex);
            }
        }
    }
}