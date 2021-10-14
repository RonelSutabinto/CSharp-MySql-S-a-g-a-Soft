Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Custom

    Partial Class frm_Custom_Query
        Inherits DevExpress.XtraEditors.XtraForm

        Private iRows As Integer
        Private bLoopStop As Boolean

        Friend Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            gridView_Queries.SaveLayoutToRegistry("Custom Query")
            splitContainerControl.SaveLayoutToRegistry("Custom Query")

            class_Tools.RegKeySet(Me.Name, BarEditItem_Table.Name, BarEditItem_Table.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Query_Type.Name, BarEditItem_Query_Type.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, queryString.Name, queryString.Text)

            Return class_Procedures.Form_Close(Me, barManager, dockManager, True)
        End Function

        Private Sub frm_Query_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            gridView_Queries.RestoreLayoutFromRegistry("Custom Query")
            splitContainerControl.RestoreLayoutFromRegistry("Custom Query")
        End Sub

        Private Sub frm_Custom_Query_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Initialize_Tables()

            BarEditItem_Table.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Table.Name, String.Empty)
            BarEditItem_Query_Type.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Query_Type.Name, "SELECT")
            queryString.Text = class_Tools.RegKeyGet(Me.Name, queryString.Name, String.Empty)
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Query_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Initialize_Tables()
        End Sub

        Private Sub Initialize_Tables()
            iRows = 0
            Dim ds As Data.DataSet = New Data.DataSet()
            Dim sda As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM sys.tables", class_Database.ICSConnection)
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Try
                    MySQLConnection.Open()
                    sda.Fill(ds)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                Finally

                End Try
            End Using
            With repositoryItemComboBox_Table
                .Items.Clear()
                For Each dt As DataTable In ds.Tables
                    For Each dr As DataRow In dt.Rows
                        .Items.Add(dr(0).ToString)
                        iRows += 1
                    Next
                Next
                .DropDownRows = iRows
                .PopupSizeable = True
            End With
        End Sub

        Private Sub repositoryItemComboBox_Tables_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BarEditItem_Table.EditValueChanged
            iRows = 0
            Dim ds As Data.DataSet = New Data.DataSet()
            Dim sda As SqlDataAdapter = New SqlDataAdapter($"SELECT * FROM syscolumns WHERE id = OBJECT_ID('{BarEditItem_Table.EditValue}')", class_Database.ICSConnection)
            Try
                sda.Fill(ds)
                repositoryItemComboBox_Field1.Items.Clear()
                RepositoryItemComboBox_Field2.Items.Clear()
                For Each dt As DataTable In ds.Tables
                    For Each dr As DataRow In dt.Rows
                        repositoryItemComboBox_Field1.Items.Add(dr(0).ToString)
                        RepositoryItemComboBox_Field2.Items.Add(dr(0).ToString)
                        iRows += 1
                    Next
                Next
                repositoryItemComboBox_Field1.DropDownRows = iRows
                RepositoryItemComboBox_Field2.DropDownRows = iRows

                repositoryItemComboBox_Field1.PopupSizeable = True
                RepositoryItemComboBox_Field2.PopupSizeable = True

                class_Tools.RegKeySet(Me.Name, BarEditItem_Table.Name, BarEditItem_Table.EditValue.ToString)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Generate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            Dim sTable As String = Nothing
            Dim sField1 As String = Nothing
            Dim sField2 As String = Nothing

            Try
                sTable = BarEditItem_Table.EditValue.ToString
                sField1 = BarEditItem_Field1.EditValue.ToString
                sField2 = BarEditItem_Field2.EditValue.ToString

                If barCheckItem_SQL_Command.Checked Then
                    Select Case BarEditItem_Query_Type.EditValue.ToString
                        Case "SELECT"
                            queryString.Text = $"SELECT TOP 1000 * FROM {sTable} WHERE {sField1} LIKE '' AND {sField2} LIKE ''"
                        Case "UPDATE"
                            queryString.Text = $"UPDATE {sTable} SET {sField1} = '' WHERE {sField2} LIKE ''"
                        Case "DELETE"
                            queryString.Text = $"DELETE FROM {sTable} WHERE {sField1} LIKE ''"
                    End Select
                Else
                    queryString.Text = $"SELECT TOP 1000 * FROM {sTable} WHERE {sField1} LIKE ''"
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
                If barCheckItem_SQL_Command.Checked Then
                    Select Case BarEditItem_Query_Type.EditValue.ToString
                        Case "SELECT"
                            queryString.Text = $"SELECT TOP 1000 * FROM {sTable} WHERE LIKE ''"
                        Case "UPDATE"
                            queryString.Text = $"UPDATE SET = '' WHERE LIKE ''"
                        Case "DELETE"
                            queryString.Text = $"DELETE FROM WHERE LIKE ''"
                    End Select
                Else
                    queryString.Text = $"SELECT TOP 1000 * FROM {sTable}"
                End If
            End Try
        End Sub

        Private Sub Execute_Query()

            If barCheckItem_SQL_Command.Checked Then
                class_Database.Query_Execute(class_Database.ICSConnection, queryString.Text, True, "Execute Custom Query Command", "Custom Query Command")
            Else
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, queryString.Text)
            End If
            class_Procedures.Initialize_gridView(gridView)
        End Sub

        Private Sub btn_Execute_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Execute.ItemClick
            Execute_Query()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub List_Load()

            class_Database.Bind_Data(class_Database.ICSConnection, gridControl_Queries, gridView_Queries, "SELECT * FROM acc_Custom_Queries", "acc_Custom_Queries")
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            List_Load()
        End Sub

        Private Function query_Save() As Boolean

            If class_Procedures.isEmpty(queryString) Then Return False
            If Not class_Database.Data_Save_Ask(queryString.Text) Then Return False
            class_Procedures.splash_Show("Saving Custom Query")
            Dim sQuery As String = $"SELECT * FROM acc_Custom_Queries WHERE Custom_Query LIKE '{queryString.Text}'"
            If Not class_Database.IsDataExist(class_Database.ICSConnection, sQuery) Then
                Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                    Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                        MyCommand.CommandText = "INSERT INTO acc_Custom_Queries (Query_Type, Custom_Query) VALUES (@Query_Type, @Custom_Query)"
                        MyCommand.Parameters.Add("@Query_Type", SqlDbType.VarChar).Value = BarEditItem_Query_Type.EditValue.ToString
                        MyCommand.Parameters.Add("@Custom_Query", SqlDbType.VarChar).Value = queryString.Text
                        Try
                            MySQLConnection.Open()
                            If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Custom Query")
                                List_Load()
                                Return True
                            End If
                        Catch ex As Exception
                            Return class_Procedures.Show_Error(ex)
                        Finally
                            class_Procedures.splash_Close()
                        End Try
                    End Using
                End Using
            End If
            Return False
        End Function

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            query_Save()
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                Select Case e.Column.FieldName
                    Case "EngineNo", "ChassisNo"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .DataRowCount > 0 Then
                    Select Case e.KeyValue
                        Case Keys.Enter

                        Case Keys.Delete
                            If .SelectedRowsCount > 1 Then
                                If Not class_Procedures.actionAsk("Delete/Remove", "Delete/Remove data records", "You might delete/remove wrong data") Then Return

                                Dim sIDField As String = class_Functions.Show_Input_Box($"Input Table:{BarEditItem_Table.EditValue} ID Field Name", $"{BarEditItem_Table.EditValue} ID Field Name", "ID")

                                class_Procedures.splash_Show("Saving Trial Balances")

                                Dim dtStart As Date = class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)
                                Dim dtEnd As Date = class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)

                                Dim iRowHandle, iRowHandleOld As Integer
                                Dim selectedRows As Integer() = .GetSelectedRows()

                                bLoopStop = False
                                For i As Integer = 0 To selectedRows.Length - 1
                                    iRowHandle = selectedRows(i)

                                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Custom Query List", "deleted", bLoopStop, True, True) Then
                                        iRowHandleOld = iRowHandle
                                    Else Return
                                    End If

                                    Try
                                        class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM {BarEditItem_Table.EditValue} WHERE {sIDField} LIKE '{ .GetRowCellDisplayText(iRowHandle, sIDField)}'")
                                    Catch ex As Exception
                                        Return
                                    End Try
                                Next

                                .BestFitColumns()
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Trial Balances has been successfully updated.")
                                class_Procedures.splash_Close()
                            Else
                                Dim sIDField As String = class_Functions.Show_Input_Box($"Input Table:{BarEditItem_Table.EditValue} ID Field Name", $"{BarEditItem_Table.EditValue} ID Field Name", "ID")
                                Try
                                    Dim sTable As String = BarEditItem_Table.EditValue.ToString
                                    Dim sID As String = .GetFocusedRowCellDisplayText(sIDField)
                                    class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM {sTable} WHERE {sIDField} LIKE '{sID}'", $"{sTable} Record [ID:{sID}]", True, "Added_By")
                                Catch ex As Exception
                                    Return
                                End Try
                            End If
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_Queries_DoubleClick(sender As Object, e As EventArgs) Handles gridView_Queries.DoubleClick
            If gridView_Queries.DataRowCount > 0 Then
                queryString.Text = gridView_Queries.GetFocusedRowCellDisplayText(colCustom_Query)
                BarEditItem_Query_Type.EditValue = gridView_Queries.GetFocusedRowCellDisplayText(colQuery_Type)
            End If
        End Sub

        Private Sub gridView_Queries_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView_Queries.KeyDown
            Select Case e.KeyValue
                Case Keys.Delete
                    If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Custom_Queries WHERE ID LIKE '{gridView_Queries.GetFocusedRowCellValue(colID)}'", "Custom Query") Then gridView_Queries.DeleteSelectedRows()
            End Select
        End Sub

        Private Sub btn_Custom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Custom.ItemClick
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Trial Balance", "Trial Balance(s) Migrate", "Execute Trial Balances") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balances", "migrated", bLoopStop, True, True) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sCorporation As String = .GetRowCellDisplayText(iRowHandle, "Corporation")
                        Dim sCOACode As String = .GetRowCellDisplayText(iRowHandle, "COA_Code")

                        Dim dtStart As Date = convert.todatetime(.GetRowCellValue(iRowHandle, "Date_Range_Start"))
                        Dim dtEnd As Date = convert.todatetime(.GetRowCellValue(iRowHandle, "Date_Range_End"))

                        Dim dBeginningBalanceDebit As Decimal
                        Try
                            dBeginningBalanceDebit = convert.todecimal(.GetRowCellValue(iRowHandle, "Beginning_Balance_Debit"))
                        Catch ex As Exception
                            dBeginningBalanceDebit = 0
                        End Try

                        Dim dBeginningBalanceCredit As Decimal
                        Try
                            dBeginningBalanceCredit = convert.todecimal(.GetRowCellValue(iRowHandle, "Beginning_Balance_Credit"))
                        Catch ex As Exception
                            dBeginningBalanceCredit = 0
                        End Try

                        Dim dTotalDebit As Decimal
                        Try
                            dTotalDebit = convert.todecimal(.GetRowCellValue(iRowHandle, "Total_Debit"))
                        Catch ex As Exception
                            dTotalDebit = 0
                        End Try

                        Dim dTotalCredit As Decimal
                        Try
                            dTotalCredit = convert.todecimal(.GetRowCellValue(iRowHandle, "Total_Credit"))
                        Catch ex As Exception
                            dTotalCredit = 0
                        End Try

                        Dim dEndingBalanceDebit As Decimal
                        Try
                            dEndingBalanceDebit = convert.todecimal(.GetRowCellValue(iRowHandle, "Ending_Balance_Debit"))
                        Catch ex As Exception
                            dEndingBalanceDebit = 0
                        End Try

                        Dim dEndingBalanceCredit As Decimal
                        Try
                            dEndingBalanceCredit = convert.todecimal(.GetRowCellValue(iRowHandle, "Ending_Balance_Credit"))
                        Catch ex As Exception
                            dEndingBalanceCredit = 0
                        End Try

                        Dim sNotes As String = .GetRowCellDisplayText(iRowHandle, "Notes")

                        'class_Saga_Database.Balance_Save(1"DETAIL", sCOACode, dBeginningBalanceDebit, dBeginningBalanceCredit, dTotalDebit, dTotalCredit, dEndingBalanceDebit, dEndingBalanceCredit, 0, 0, 0, 0, dtStart, dtEnd, sNotes)
                    Next
                End If
            End With
        End Sub

    End Class

End Namespace