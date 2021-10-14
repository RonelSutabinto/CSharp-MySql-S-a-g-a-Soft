Imports System.Data.SqlClient
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Namespace Classes
    Public Module class_Database
        Private sID_Code As String

        Public SqlServerType As String
        Public SqlServer As String
        Public SqlPort As String
        Public SqlDatabase As String
        Public SqlUser As String
        Public SqlPassword As String
        Public SqlTimeOut As Integer
        Public bIsLocal As Boolean

        Public bLoopStop As Boolean
        Public DBError As Boolean
        Public sError As String

        Public ICSConnection As String
        Public SPAConnection As String
        Public ICSConnectionTemp As String
        Public connectionStringAccEntity, connectionStringHREntity As String
        Public sUpdateLink As String

        Public mySQLConnection As SqlConnection = New SqlConnection()
        Public spaSQLConnection As SqlConnection = New SqlConnection()
        Public myDataAdapter As SqlDataAdapter = New SqlDataAdapter()

        Public sValueNew As String

        Public Sub Initialize_Connection()
            SqlServerType = class_Tools.RegKeyGet("Server Connection", "Type", "localhost")
            bIsLocal = class_Tools.RegKeyGet("Server Connection", "isLocal", True)

            SqlServer = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Server", Environment.MachineName), Environment.MachineName)
            SqlDatabase = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Database", String.Empty), String.Empty)
            SqlUser = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "User Name", String.Empty), String.Empty)
            SqlPassword = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Password", String.Empty), String.Empty)
            SqlTimeOut = class_Tools.RegKeyGet("Server Connection", "Timeout", 15)
            sUpdateLink = $"http://{SqlServer}/AutoUpdate/{Application.ProductName}/"

            ICSConnection = $"Data Source={SqlServer}; Initial Catalog={SqlDatabase}; Persist Security Info=True; Connect Timeout={SqlTimeOut}; User ID={SqlUser}; Password={SqlPassword};"
            ICSConnectionTemp = $"Data Source={class_Functions.maskString(SqlServer, 2, 2)};{Environment.NewLine} Initial Catalog={class_Functions.maskString(SqlDatabase, 1, 1)};{Environment.NewLine} Persist Security Info=True;{Environment.NewLine} Connect Timeout={SqlTimeOut};{Environment.NewLine} User ID={class_Functions.maskString(SqlUser, 1, 1)};{Environment.NewLine} Password={class_Functions.maskString(SqlPassword, 0, 0)};"
            'MyBase.New({MyClassLibrary.Classes.connectionStringAccEntity})
            connectionStringAccEntity = $"metadata=res://*/Models.Model_Accounting.csdl|res://*/Models.Model_Accounting.ssdl|res://*/Models.Model_Accounting.msl;provider=System.Data.SqlClient;provider connection string='{ICSConnection}; multipleactiveresultsets=True; application name=EntityFramework;'"
            connectionStringHREntity = $"metadata=res://*/Models.Model_HR.csdl|res://*/Models.Model_HR.ssdl|res://*/Models.Model_HR.msl; provider=System.Data.SqlClient; provider connection string='{ICSConnection}; multipleactiveresultsets=True; application name=EntityFramework;'"

            SPAConnection = $"Data Source={SqlServer}; Initial Catalog=Spare_Parts; Persist Security Info=True; Connect Timeout={SqlTimeOut}; User ID={SqlUser}; Password={SqlPassword};"
        End Sub

        Public Function OpenDB(ByVal sConnection As String, Optional ByVal bSplash As Boolean = False) As Boolean
            'If DBError Then Return False
            If Not bIsLocal AndAlso Not class_Connections.is_Network_Adapter_OK() Then Return False

            Try
                If bSplash Then class_Procedures.splash_Show("connecting to SQL Server Database",, bSplash)
                CloseDB()
                mySQLConnection.ConnectionString = sConnection
                mySQLConnection.Open()
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close(True)
            End Try
        End Function

        Public Sub CloseDB()
            If mySQLConnection.State.Equals(ConnectionState.Open) Then
                mySQLConnection.Close()
            End If
        End Sub

        Public Function Procedure_BindData(ByVal sConnection As String, ByVal GridControl As GridControl, ByVal GridView As GridView, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), ByVal sTable As String) As Boolean

            Dim MySQLConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Dim iRow = GridView.FocusedRowHandle
                Try
                    GridView.LoadingPanelVisible = True
                    class_Procedures.splash_Show($"loading {sTable}",, True)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(MyCommand)
                    Dim ds As DataSet = New DataSet()
                    MySQLConnection.Open()
                    ds.Clear()
                    da.Fill(ds, sTable)
                    GridControl.DataSource = ds
                    Return True
                Catch Ex As Exception
                    class_Procedures.Show_Error(Ex)
                Finally
                    GridView.BestFitColumns()
                    If iRow.Equals(0) Then
                        GridView.MoveFirst()
                    Else
                        GridView.ClearSelection()
                        GridView.SelectRow(iRow)
                        GridView.MakeRowVisible(iRow)
                    End If
                    GridView.LoadingPanelVisible = False
                    class_Procedures.splash_Close(True)
                End Try
            End Using
            Return False
        End Function

        Public Function Procedure_BindData(ByVal sConnection As String, ByVal xRpt As XtraReport, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), ByVal sTable As String) As Boolean

            Dim MySQLConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Try
                    class_Procedures.splash_Show($"loading {sTable}",, True)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(MyCommand)
                    Dim ds As DataSet = New DataSet()
                    MySQLConnection.Open()
                    ds.Clear()
                    da.Fill(ds, sTable)
                    xRpt.DataMember = sTable
                    xRpt.DataSource = ds
                    Dim rpTool As ReportPrintTool = New ReportPrintTool(xRpt)
                    rpTool.ShowRibbonPreview()
                    Return True
                Catch Ex As Exception
                    class_Procedures.Show_Error(Ex)
                Finally
                    class_Procedures.splash_Close(True)
                End Try
            End Using
            Return False
        End Function

        Public Function Procedure_Retrieve(ByVal sConnection As String, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal bSplash As Boolean = False) As SqlDataReader

            Dim MySQLConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Try
                    class_Procedures.splash_Show("Retrieving Data",, bSplash)
                    MySQLConnection.Open()
                    Return MyCommand.ExecuteReader()
                Catch Ex As Exception
                    class_Procedures.Show_Error(Ex)
                    Return Nothing
                Finally
                    class_Procedures.splash_Close(bSplash)
                End Try
            End Using
            Return Nothing
        End Function

        Public Function Procedure_Retrieve(ByVal sConnection As String, ByVal GridControl As GridControl, ByVal GridView As GridView, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal sTitle As String = "") As Boolean

            Dim MySQLConnection As SqlConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Dim iRow = GridView.FocusedRowHandle
                Try
                    class_Procedures.splash_Show($"Retrieving {sTitle}",, class_Variables.bSplash)
                    GridView.LoadingPanelVisible = True

                    MySQLConnection.Open()
                    Dim dr As SqlDataReader = MyCommand.ExecuteReader()
                    If dr.HasRows Then
                        GridControl.DataSource = dr
                        Return True
                    Else
                        GridControl.DataSource = Nothing
                        Return False
                    End If
                Catch Ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                Finally
                    GridView.BestFitColumns()

                    If iRow.Equals(0) Then
                        GridView.MoveFirst()
                    Else
                        GridView.ClearSelection()
                        GridView.SelectRow(iRow)
                        GridView.MakeRowVisible(iRow)
                    End If
                    GridView.LoadingPanelVisible = False
                    class_Procedures.splash_Close(class_Variables.bSplash)
                End Try
            End Using
            Return False
        End Function

        Public Function Procedure_Save(ByVal sConnection As String, ByVal sTitle As String, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal sCode As String = "") As Boolean
            If sCode.Length > 0 AndAlso Not Data_Save_Ask(sCode) Then Return False
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.AddRange(Parameters)
                    Try
                        class_Procedures.splash_Show($"Saving/Updating {sTitle}")
                        MySQLConnection.Open()
                        Dim iRows As Integer = MyCommand.ExecuteNonQuery()
                        If sCode.Length > 0 OrElse class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"Executing {sTitle}{Environment.NewLine}{iRows + 1} row(s) affected.")
                        Return True
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function Procedure_Execute(ByVal sConnection As String, ByVal sTitle As String, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal bAsk As Boolean = False) As Integer
            If bAsk AndAlso Not Query_Execute_Ask(sTitle) Then Return 0
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.AddRange(Parameters)
                    Try
                        class_Procedures.splash_Show($"Executing {sTitle}",, True)
                        MySQLConnection.Open()
                        Dim iRows As Integer = MyCommand.ExecuteNonQuery()
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Executing {sTitle}{Environment.NewLine}{iRows} row(s) affected.")
                        Return iRows
                    Catch Ex As Exception
                        Return 0
                    Finally
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function SetDataset(ByVal sConnection As String, ByVal ds As DataSet, ByVal sQuery As String, ByVal sTable As String) As DataSet
            FillData(sConnection, ds, myDataAdapter, sQuery, sTable)
            Return ds
        End Function

        Public Function SetSqlDataReader(ByVal sConnection As String, ByVal sQuery As String) As SqlDataReader
            Dim MySQLConnection = New SqlConnection(sConnection)
            Dim MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
            Try
                MySQLConnection.Open()
                Return MyCommand.ExecuteReader()
            Catch Ex As Exception
                Return Nothing
            Finally
                'DO NOT close the connection
            End Try
            Return Nothing
        End Function

        Public Sub FillData(ByVal sConnection As String, ByVal ds As DataSet, ByVal da As SqlDataAdapter, ByVal sQuery As String, ByVal sTable As String, Optional ByVal bSplash As Boolean = False)
            Dim watch As New Stopwatch()
            watch.Start()
            Using MySQLConnection = New SqlConnection(sConnection)
                da.SelectCommand = New SqlCommand(sQuery, MySQLConnection)
                ds.Clear()
                Try
                    class_Procedures.splash_Show($"loading {sTable}",, bSplash)
                    MySQLConnection.Open()
                    da.Fill(ds, sTable)
                Catch Ex As Exception
                    class_Procedures.Show_Error(Ex)
                Finally
                    class_Procedures.splash_Close(bSplash)
                End Try
            End Using
            watch.Stop()
            If class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Loading time: {watch.ElapsedMilliseconds} milliseconds", $"{sTable}")
        End Sub

        Public Function BindSource(ByVal sConnection As String, ByVal ds As DataSet, ByVal sQuery As String, ByVal sTable As String, Optional ByVal bSplash As Boolean = False) As BindingSource
            Try
                FillData(sConnection, ds, myDataAdapter, sQuery, sTable, bSplash)
                Dim bs As BindingSource = New BindingSource() With {
                .DataSource = ds,
                .DataMember = sTable
            }
                Return bs
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
            Return Nothing
        End Function

        Public Function BindToData(ByVal sQuery As String) As SqlDataSource
            Dim connectionParameters As MySqlConnectionParameters = New MySqlConnectionParameters(SqlServer, SqlDatabase, SqlUser, SqlPassword, MsSqlAuthorizationType.SqlServer)
            Dim ds As SqlDataSource = New SqlDataSource(connectionParameters)
            Dim query As CustomSqlQuery = New CustomSqlQuery With {
            .Name = "customQuery",
            .Sql = sQuery
        }
            ds.Queries.Add(query)

            Try
                ds.RebuildResultSchema()
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
            Return ds
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal gridControl As GridControl, ByVal gridView As GridView, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Dim iRow As Integer
            With gridView
                Try
                    .LoadingPanelVisible = True

                    If .SelectedRowsCount > 0 Then
                        iRow = .FocusedRowHandle
                    Else
                        iRow = 0
                    End If

                    Using ds As DataSet = New DataSet()
                        gridControl.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                    End Using
                    Return True
                Catch Ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                Finally
                    .BestFitColumns()

                    If iRow.Equals(0) Then
                        .MoveFirst()
                    Else
                        .ClearSelection()
                        .SelectRow(iRow)
                        .MakeRowVisible(iRow)
                    End If

                    .LoadingPanelVisible = False
                End Try
            End With
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal gridControl As GridControl, ByVal gridView As GridView, ByVal sQuery As String, Optional bClearColumns As Boolean = True) As Boolean
            With gridView
                .LoadingPanelVisible = True
                If bClearColumns Then .Columns.Clear()
                gridControl.DataSource = Nothing
                Using MySQLConnection = New SqlConnection(sConnection)
                    Try
                        'Do not display splash to avoid popup disappearance
                        MySQLConnection.Open()
                        Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                            Using dr As SqlDataReader = MyCommand.ExecuteReader()
                                gridControl.DataSource = dr
                            End Using
                        End Using
                        Return True
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    Finally
                        If .DataRowCount < 5000 Then .BestFitColumns()
                        .LoadingPanelVisible = False
                    End Try
                End Using
            End With
            Return False
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal repositoryItem As RepositoryItem, ByVal gridView As GridView, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                With gridView
                    .LoadingPanelVisible = True
                    Using ds As DataSet = New DataSet()
                        If TypeOf repositoryItem Is RepositoryItemSearchLookUpEdit Then
                            CType(repositoryItem, RepositoryItemSearchLookUpEdit).DataSource = BindSource(sConnection, ds, sQuery, sTable)

                        ElseIf TypeOf repositoryItem Is RepositoryItemGridLookUpEdit Then
                            CType(repositoryItem, RepositoryItemGridLookUpEdit).DataSource = BindSource(sConnection, ds, sQuery, sTable)
                        End If
                        .BestFitColumns()
                        .LoadingPanelVisible = False
                    End Using
                    Return True
                End With
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal repositoryItem As RepositoryItem, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    If TypeOf repositoryItem Is RepositoryItemLookUpEdit Then
                        CType(repositoryItem, RepositoryItemLookUpEdit).DataSource = BindSource(sConnection, ds, sQuery, sTable)

                    ElseIf TypeOf repositoryItem Is RepositoryItemSearchLookUpEdit Then
                        CType(repositoryItem, RepositoryItemSearchLookUpEdit).DataSource = BindSource(sConnection, ds, sQuery, sTable)

                    ElseIf TypeOf repositoryItem Is RepositoryItemGridLookUpEdit Then
                        CType(repositoryItem, RepositoryItemGridLookUpEdit).DataSource = BindSource(sConnection, ds, sQuery, sTable)
                    End If
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal baseEdit As BaseEdit, ByVal sQuery As String, ByVal sTable As String, Optional ByVal bSplash As Boolean = False) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    If TypeOf baseEdit Is LookUpEdit Then
                        CType(baseEdit, LookUpEdit).Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash)
                        CType(baseEdit, LookUpEdit).Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        CType(baseEdit, LookUpEdit).Properties.PopupFilterMode = PopupFilterMode.Contains

                    ElseIf TypeOf baseEdit Is SearchLookUpEdit Then
                        CType(baseEdit, SearchLookUpEdit).Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash)
                        CType(baseEdit, SearchLookUpEdit).Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        CType(baseEdit, SearchLookUpEdit).Properties.PopupFilterMode = PopupFilterMode.Contains

                    ElseIf TypeOf baseEdit Is TreeListLookUpEdit Then
                        CType(baseEdit, TreeListLookUpEdit).Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable, bSplash)
                        CType(baseEdit, TreeListLookUpEdit).Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                        CType(baseEdit, TreeListLookUpEdit).Properties.PopupFilterMode = PopupFilterMode.Contains
                    End If
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal treeList As DevExpress.XtraTreeList.TreeList, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    treeList.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                    treeList.BestFitColumns()
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal treeList As TreeListLookUpEdit, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    treeList.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal gc As DevExpress.XtraVerticalGrid.VGridControl, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                Using ds As DataSet = New DataSet()
                    gc.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                    gc.BestFit()
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal xRpt As XtraReport, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                class_Procedures.splash_Show("Executing Report Query")
                Using ds As DataSet = New DataSet()
                    xRpt.DataSource = SetDataset(sConnection, ds, sQuery, sTable)
                    xRpt.DataMember = sTable
                End Using

                Dim rpTool As ReportPrintTool = New ReportPrintTool(xRpt)
                rpTool.ShowRibbonPreview()
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close()
            End Try
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal dashBoard As Dashboard, ByVal tableAdapter As DashboardObjectDataSource, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                class_Procedures.splash_Show("Executing Report Query")
                Using ds As DataSet = New DataSet()
                    tableAdapter.DataSource = SetDataset(sConnection, ds, sQuery, sTable)
                    tableAdapter.DataMember = sTable
                End Using
                Return True
            Catch Ex As Exception
                Return class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close()
            End Try
        End Function

        Public Function IsDataExist(ByVal sConnection As String, ByVal sQuery As String) As Boolean
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        class_Procedures.splash_Show("Checking if Data exist")
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            Return MyDataReader.HasRows
                        End Using
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Sub Fill_Edit(ByVal sConnection As String, ByVal baseEdit As BaseEdit, ByVal sTable As String, ByVal sDistinctField As String, Optional bSorted As Boolean = True, Optional ByVal bClear As Boolean = True, Optional ByVal bCustomQuery As Boolean = False, Optional sCustomQuery As String = "")
            Dim iCount As Integer = 0
            Dim sQuery As String

            If bCustomQuery Then
                sQuery = sCustomQuery
            Else
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} ORDER BY {sDistinctField} ASC"
            End If

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        class_Procedures.splash_Show($"loading {sDistinctField}",, True)
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            If TypeOf baseEdit Is ComboBoxEdit Then
                                If bClear Then CType(baseEdit, ComboBoxEdit).Properties.Items.Clear()
                                If MyDataReader.HasRows Then
                                    While MyDataReader.Read()
                                        CType(baseEdit, ComboBoxEdit).Properties.Items.Add(MyDataReader(sDistinctField))
                                        iCount += 1
                                    End While
                                    CType(baseEdit, ComboBoxEdit).Properties.Sorted = bSorted
                                    CType(baseEdit, ComboBoxEdit).Properties.DropDownRows = iCount
                                End If

                            ElseIf TypeOf baseEdit Is TokenEdit Then
                                If MyDataReader.HasRows Then
                                    CType(baseEdit, TokenEdit).Properties.BeginUpdate()
                                    While MyDataReader.Read()
                                        CType(baseEdit, TokenEdit).Properties.Tokens.AddToken(MyDataReader(sDistinctField))
                                    End While
                                    CType(baseEdit, TokenEdit).Properties.EndUpdate()
                                End If
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End Using
        End Sub

        Public Function Fill_Edit(ByVal sConnection As String, ByVal comboBox As RepositoryItemComboBox, ByVal sTable As String, ByVal sDistinctField As String, Optional ByVal bClear As Boolean = True, Optional ByVal bWhereCondition As Boolean = False, Optional ByVal sWhereValue As String = "") As Integer
            Dim iReturn As Integer = 0
            Dim sQuery As String

            If bWhereCondition Then
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} WHERE {sDistinctField} LIKE '{sWhereValue}' ORDER BY {sDistinctField} ASC"
            Else
                sQuery = $"SELECT DISTINCT {sDistinctField} FROM {sTable} ORDER BY {sDistinctField} ASC"
            End If

            class_Procedures.splash_Show($"loading {sTable}")

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            If bClear Then comboBox.Items.Clear()
                            If MyDataReader.HasRows Then
                                While MyDataReader.Read()
                                    comboBox.Items.Add(MyDataReader(sDistinctField))
                                    iReturn += 1
                                End While
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return iReturn
        End Function

        Public Function Fill_Edit(ByVal sConnection As String, ByVal comboBox As ComboBoxEdit, ByVal sTable As String, ByVal sWhereField As String, ByVal sDistinctField As String, ByVal sLikeValue As String) As Integer
            Dim iReturn As Integer = 0
            Dim sQuery As String = $"SELECT DISTINCT {sDistinctField}, {sWhereField} FROM {sTable} WHERE {sWhereField} LIKE '{sLikeValue}' ORDER BY {sDistinctField} ASC"

            class_Procedures.splash_Show($"loading {sTable}")

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            comboBox.Properties.Items.Clear()
                            If MyDataReader.HasRows Then
                                While MyDataReader.Read()
                                    comboBox.Properties.Items.Add(MyDataReader(sDistinctField))
                                    iReturn += 1
                                End While
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return iReturn
        End Function

        Public Function Get_Last_ID(ByVal sConnection As String, ByVal sTable As String, Optional sIDField As String = "ID") As Integer
            Dim sQuery = $"SELECT TOP(1) {sIDField} FROM {sTable} ORDER BY {sIDField} DESC"
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Return CInt(MyDataReader($"{sIDField}")) + 1
                            Else
                                Return 1
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function Get_Last_ID(ByVal sConnection As String, ByVal sTable As String, ByVal sIDField As String, ByVal sWhereCodeField As String, ByVal sWherePreCodeValue As String, Optional ByVal iDash As Integer = 0) As String
            Dim sQuery = $"SELECT TOP(1) {sIDField}, {sWhereCodeField} FROM {sTable} WHERE {sWhereCodeField} LIKE '{sWherePreCodeValue}%' ORDER BY {sIDField} DESC"
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                If iDash > 0 Then
                                    Dim sCode As String = $"{sWherePreCodeValue}{MyDataReader($"{sWhereCodeField}").ToString.Remove(0, sWherePreCodeValue.Length)}"
                                    Dim sNumber() As String = sCode.Split("-")
                                    Return $"{sWherePreCodeValue}{CInt(sNumber(iDash)) + 1}"
                                Else
                                    Return $"{sWherePreCodeValue}{CInt(MyDataReader($"{sWhereCodeField}").ToString.Remove(0, sWherePreCodeValue.Length)) + 1}"
                                End If
                            Else
                                Return $"{sWherePreCodeValue}{1}"
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                        Return Nothing
                    End Try
                End Using
            End Using
            Return Nothing
        End Function

        Public Function Get_Last_ID(ByVal sConnection As String, ByVal sTable As String, ByVal sWhereCodeField As String, ByVal sWherePreCodeValue As String, ByVal iPreChars As Integer, Optional ByVal sAndSQL As String = "") As String
            'Must be sorted by ID and not by field
            Dim sQuery = $"SELECT TOP(1) {sWhereCodeField}=CAST(RIGHT({sWhereCodeField}, LEN({sWhereCodeField})-{iPreChars}) AS int) FROM {sTable} WHERE {sWhereCodeField} LIKE '{sWherePreCodeValue}%' {sAndSQL} ORDER BY {sWhereCodeField} DESC"
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Return $"{sWherePreCodeValue}{CInt(MyDataReader($"{sWhereCodeField}")) + 1}"
                                'Return $"{sWherePreCodeValue}{CInt(MyDataReader($"{sWhereCodeField}").ToString.Remove(0, sWherePreCodeValue.Length)) + 1}"
                            Else
                                Return $"{sWherePreCodeValue}{1}"
                            End If
                        End Using
                    Catch Ex As Exception
                        Return Nothing
                    End Try
                End Using
            End Using
            Return Nothing
        End Function

        Public Function Get_ID(ByVal sConnection As String, ByVal sTable As String, ByVal sPreCode As String, ByVal iZeros As Integer, Optional ByVal sIDField As String = "ID") As String
            Dim iCode As Integer = Get_Last_ID(sConnection, sTable, sIDField)
            Dim iLength As Integer = iCode.ToString.Length
            If iLength > iZeros Then iZeros = iLength
            Dim sZeros As String = New String("0"c, iZeros)
            Dim sTmpCode As String = $"{sPreCode}{sZeros}"
            sID_Code = sTmpCode.Remove(sTmpCode.Length - iLength)
            sID_Code = sID_Code.Insert(sTmpCode.Length - iLength, iCode.ToString)
            Return sID_Code
        End Function

        Public Function Get_Data(ByVal sConnection As String, ByVal sQuery As String, ByVal sField As String) As Object
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Return MyDataReader(sField)
                            End If
                        End Using
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                        Return Nothing
                    End Try
                End Using
            End Using
            Return Nothing
        End Function

        Public Function Get_Data(ByVal sConnection As String, ByVal sQuery As String, ByVal sFieldDebit As String, ByVal sFieldCredit As String) As Decimal
            Dim dAmount As Decimal = 0
            class_Procedures.splash_Show($"Getting {sFieldDebit} + {sFieldCredit}")
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Try
                                    dAmount = CDec(MyDataReader(sFieldDebit)) + CDec(MyDataReader(sFieldCredit))
                                Catch Ex As Exception
                                    dAmount = 0
                                End Try
                            End If
                        End Using
                        Return dAmount
                    Catch Ex As Exception
                        Return 0
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function Data_Update(ByVal sConnection As String, ByVal sUpdateQuery As String, Optional ByVal bForce As Boolean = False) As Boolean
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sUpdateQuery, MySQLConnection)
                    Try
                        class_Procedures.splash_Show($"Updating Data",, bForce)
                        MySQLConnection.Open()
                        Dim iRows As Integer = MyCommand.ExecuteNonQuery()
                        If class_Variables.bNotifications Or bForce Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"[{sUpdateQuery}]{Environment.NewLine}{iRows} Record(s) has been successfully executed.")
                        End If
                        Return CBool(iRows)
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close(bForce)
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function Data_Replace(ByVal sConnection As String, ByVal sTitle As String, ByVal sTable As String, ByVal sField As String, ByVal sFieldValueOld As String, ByVal sFieldValueNew As String) As Boolean
            Return class_Database.Query_Execute(sConnection, $"UPDATE {sTable} SET {sField} = '{sFieldValueNew}' WHERE {sField} LIKE '{sFieldValueOld}'", True, $"Replace {sTitle}", $"Replace {sTitle}")
        End Function

        Public Function Data_Is_Locked(ByVal sConnection As String, ByVal sTitle As String, ByVal sTable As String, ByVal sCodeField As String, ByVal sCodeValue As String) As Boolean
            If IsDataExist(sConnection, $"SELECT {sCodeField}, IsLocked FROM {sTable} WHERE {sCodeField} LIKE '{sCodeValue}' AND IsLocked LIKE '1'") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"This {sTitle} was locked by Admin.{Environment.NewLine}Editing/Updating/Deleting is not allowed.{Environment.NewLine}Please contact Administrator.", "Unauthorized Edit/Update/Delete", True)
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Data_Save_Ask(ByVal sTransaction As String) As Boolean
            Dim myResult As DialogResult = XtraMessageBox.Show($"Do you want to save/update/replace this {sTransaction}?{Environment.NewLine}{Environment.NewLine}Note: You might save/update a wrong data/information or this might overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify and update your transactions.", $"Save / Update {sTransaction}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If myResult = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Data_Save_Ask(ByVal sConnection As String, ByVal sTransaction As String, ByVal sQuery As String, Optional bWarningIfExisting As Boolean = True, Optional ByVal bReplaceIfExisting As Boolean = False) As Boolean
            If IsDataExist(sConnection, sQuery) Then
                Media.SystemSounds.Exclamation.Play()
                If bWarningIfExisting Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"{sTransaction} was already existing.{Environment.NewLine}Please abort if you are not certain for this update", "Update Warning - Record Existing", True)
                End If

                If bReplaceIfExisting Then
                    sQuery = $"The [{sTransaction}] was already existing.{Environment.NewLine}Do you still want to update?{Environment.NewLine}{Environment.NewLine}Note: This action will overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify to avoid data loss on your transaction(s)."
                Else
                    sQuery = $"The [{sTransaction}] was already existing.{Environment.NewLine}You cannot proceed!{Environment.NewLine}{Environment.NewLine}Note: This action surely overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify to avoid data loss on your transaction(s)."
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"{sQuery}{Environment.NewLine}{Environment.NewLine}Please contact your Administrator.", "Already Existing!", True)
                    Return False
                End If
            Else
                sQuery = $"Do you want to save this {sTransaction}?{Environment.NewLine}{Environment.NewLine}Note: This action might overwrite the existing data.{Environment.NewLine}{Environment.NewLine}Reminder: Please verify and update your transactions."
            End If

            Dim myResult As DialogResult = XtraMessageBox.Show(sQuery, $"Save/Update/Replace {sTransaction}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If myResult = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Query_Execute(ByVal sConnection As String, ByVal sQuery As String, Optional bAsk As Boolean = False, Optional ByVal sTitle As String = "", Optional ByVal sTransaction As String = "") As Boolean
            If Not class_Variables.isAdmin Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Cannot execute query due to user level protection.{Environment.NewLine}Please contact your Administrator.")
                Return False
            End If

            If bAsk Then
                If Not Query_Execute_Ask(sTransaction, sQuery) Then
                    Return False
                End If
            End If

            class_Procedures.splash_Show($"Executing Query/Command", , True)

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Dim iRows As Integer = MyCommand.ExecuteNonQuery()
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"{iRows} Transaction(s) has been executed.", sTitle)
                        Return True
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    Finally
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function Query_Execute_Ask(ByVal sTitle As String, Optional ByVal sQuery As String = "") As Boolean
            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to Execute [{sTitle}] that might affect data records.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Execute SQL Query Command", True)
            If XtraMessageBox.Show($"Do you want to execute this:{Environment.NewLine}{sTitle} {sQuery}?{Environment.NewLine}{Environment.NewLine}Note: You can't UNDO this operation.", $"{sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function Data_Delete_Ask(ByVal sConnection As String, ByVal sFromSQL As String, ByVal sTitle As String, Optional ByVal bDeleteOwnedDataOnly As Boolean = False, Optional ByVal sOwnerField As String = "") As Boolean
            If IsDataExist(sConnection, $"SELECT * {sFromSQL}") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to Delete/Remove:{Environment.NewLine}{sTitle}.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Delete/Remove", True)
                Dim myResult As DialogResult = XtraMessageBox.Show($"Do you want To delete this {sTitle}?{Environment.NewLine}{Environment.NewLine}Note You can't UNDO this operation.{Environment.NewLine}{Environment.NewLine}Reminder: Please review and verify before you proceed.", $"Delete {sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If myResult = DialogResult.Yes Then
                    class_Procedures.splash_Show(sTitle)
                    Dim sQuery As String
                    If class_Variables.isAdmin Then
                        sQuery = $"DELETE {sFromSQL}"
                    ElseIf bDeleteOwnedDataOnly Then
                        sQuery = $"DELETE {sFromSQL} AND {sOwnerField} LIKE '{class_Variables.sUserName}'"
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cannot Delete {sTitle} due to it's protection level. {Environment.NewLine}Please contact your Administrator.", "Data Protection Detected")
                        Return False
                    End If

                    Using MySQLConnection = New SqlConnection(sConnection)
                        Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                            Try
                                MySQLConnection.Open()
                                If CInt(MyCommand.ExecuteScalar()) > 1 Then
                                    class_Procedures.Set_Message(class_Procedures.MsgMode.Delete, sTitle)
                                End If
                                Return True
                            Catch Ex As Exception
                                Return class_Procedures.Show_Error(Ex)
                            Finally
                                class_Procedures.splash_Close()
                            End Try
                        End Using
                    End Using
                End If
            End If
            Return False
        End Function

        Public Function Data_Delete_Quick(ByVal sConnection As String, ByVal sFromSQL As String, Optional ByVal bDeleteOwnedDataOnly As Boolean = False, Optional ByVal sOwnerField As String = "") As Boolean
            Dim sDeleteQuery As String
            If class_Variables.isAdmin Then
                sDeleteQuery = $"DELETE {sFromSQL}"
            ElseIf bDeleteOwnedDataOnly Then
                sDeleteQuery = $"DELETE {sFromSQL} AND {sOwnerField} LIKE '{class_Variables.sUserName}'"
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cannot Delete Data due to it's protection level.{Environment.NewLine}Please contact your Administrator.")
                Return False
            End If

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sDeleteQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        If CInt(MyCommand.ExecuteScalar) > 0 AndAlso class_Variables.bNotifications Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"[{sDeleteQuery}] has been successfully executed.")
                        End If
                        Return True
                    Catch Ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    End Try
                End Using
            End Using
            Return False
        End Function

    End Module
End Namespace