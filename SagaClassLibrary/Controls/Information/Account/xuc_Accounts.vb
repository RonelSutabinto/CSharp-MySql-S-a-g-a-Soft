Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Information.Account

    Public Class xuc_Accounts
        Friend bLoopStop, bCustomPosting, bUpdateTableID, bSP, bShowJournalEntries, bVerify As Boolean
        Friend dtCustomDate As Date

        Public ReadOnly Property gridViewID As String
            Get
                Return gridView.GetFocusedRowCellDisplayText(colID)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)

            Dim repositoryCorporation As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Corporation(repositoryCorporation)
            colCorporation.ColumnEdit = repositoryCorporation

            Dim repositoryBranch As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(repositoryBranch)
            colBranch_Code.ColumnEdit = repositoryBranch
            colPrev_Branch_Code.ColumnEdit = repositoryBranch
        End Sub

        Friend Sub Control_Data_Load(ByVal sCustomerCode As String)
            Dim sqlParameters As SqlParameter() = {
               New SqlParameter("@Customer_Code", sCustomerCode),
               New SqlParameter("@Action_Type", "LOAD_CUSTOMER")
           }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Sale_Procedures", "CustAccount")
        End Sub

        Friend Sub Control_Data_Load(ByVal sBrCode As String, Optional ByVal iID As Integer = 0, Optional ByVal sEngine As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Sale_Procedures", "CustAccount")

            If iID > 0 Then
                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount - 1
                    If Convert.ToInt32(gridView.GetRowCellValue(i, colID)).Equals(iID) Or gridView.GetRowCellDisplayText(i, colEngine).Equals(sEngine) Then
                        gridView.SelectRow(i)
                        gridView.MakeRowVisible(i)
                        Exit For
                    End If
                Next
            Else
                gridView.MoveLastVisible()
            End If
        End Sub

        Friend Sub Control_Data_Load(ByVal sBrCode As String, ByVal bAll As Boolean) ', ByVal bClosed As Boolean, ByVal dtDate As DateTime)
            Dim sProcedureName As String
            If bAll Then
                sProcedureName = "LOAD_ALL"
            Else
                sProcedureName = "LOAD_ACTIVE"
            End If

            Dim sqlParameters As SqlParameter() = {
               New SqlParameter("@Branch_Code", sBrCode),
               New SqlParameter("@Action_Type", sProcedureName)
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Sale_Procedures", "CustAccount")
        End Sub

        Public Sub Load_Search(sSearch As String)
            If sSearch.Length > 2 Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "LOAD_SEARCH")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Sale_Procedures", "CustAccount", False)
            End If
            class_Tools.RegKeySet(Me.Name, Me.Name, String.Empty)
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyValue
                Case Keys.Enter
                    class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, gridView.GetFocusedRowCellDisplayText(colAccount_Code), Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedger)))

                Case Keys.F2
                    class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, gridView.GetFocusedRowCellDisplayText(colAccount_Code), Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedger)), gridView.GetFocusedRowCellDisplayText(colCustomer_Name), True)

            End Select
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                btn_Amortization_Schedule.Enabled = class_Saga_Variables.isMaintenance
                btn_Custom.Enabled = class_Saga_Variables.isMaintenance

                Check_Include_Payments.Enabled = class_Saga_Variables.isAccounting
                btn_Journal_Entries2.Enabled = class_Saga_Variables.isAccounting
                btn_Unit_Cost.Enabled = class_Saga_Variables.isAccounting

                btn_Journal.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting
                btn_Journal_Entries.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting
                btn_Verify.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting

                btn_Approve.Enabled = class_Saga_Variables.isApprover AndAlso gridView.GetFocusedRowCellDisplayText(colAccount_Status).Equals("PENDING")
                btn_DisApprove.Enabled = class_Saga_Variables.isApprover AndAlso gridView.GetFocusedRowCellDisplayText(colAccount_Status).Equals("PENDING")

                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Friend Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.DataRowCount > 0) AndAlso e.Clicks.Equals(2) Then
                Select Case e.Column.Name
                    Case "colID"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.ID, e.CellValue.ToString, , gridView.GetFocusedRowCellDisplayText(colCustomer_Name), True)

                    Case "colCustomer_code"
                        If Not gridView.GetFocusedRowCellDisplayText(colCustomer_Code).Equals("0") Then
                            class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.CIF, e.CellValue.ToString)
                        End If

                    Case "colAccount_Code"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedger)), gridView.GetFocusedRowCellDisplayText(colCustomer_Name), True)

                    Case "colPrev_Account_Code"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedger)) - 1, gridView.GetFocusedRowCellDisplayText(colPrev_Name), True)

                    Case "colAgent_Code"
                        class_Saga_Procedures.Show_Agent(e.CellValue.ToString)

                    Case "colAE_Code"
                        class_Saga_Procedures.Show_Account_Executive(e.CellValue.ToString)

                    Case "colModel_Code"
                        class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                    Case "colEngine", "colChassis"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString,, True)

                    Case "colAdded_By"
                        class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                    Case "colContactNumber"
                        'LC_SMS_3_3.Classes.Class_SMS.Show_Sender(gridView.GetFocusedRowCellDisplayText(colCustomer_Name), e.CellValue.ToString)

                End Select
                Try
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Friend Sub Show_Journal_Entries()
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colEngine).Trim, gridView.GetFocusedRowCellValue(colID), $"{gridView.GetFocusedRowCellDisplayText(colAccount_Code)}-{gridView.GetFocusedRowCellDisplayText(colLedger)}", gridView.GetFocusedRowCellDisplayText(colCustomer_Name), gridView.GetFocusedRowCellDisplayText(colNotes))
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick

            Show_Journal_Entries()
        End Sub

        Private Sub btn_Journal_Entries2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries2.ItemClick
            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, gridView.GetFocusedRowCellDisplayText(colAccount_Code), gridView.GetFocusedRowCellDisplayText(colCustomer_Name), gridView.GetFocusedRowCellDisplayText(colEngine))
        End Sub

        Private Sub btn_Unit_Cost_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Cost.ItemClick
            With gridView
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False
                .ClearSelection()

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If Not .GetRowCellDisplayText(iRowHandle, colUnit_Status).Equals("NEW") Then Continue For

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Unit Cost Update", "updated", bLoopStop,,, "Remarks") Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Dim sEngine As String = .GetRowCellDisplayText(iRowHandle, colEngine)
                    Dim dUnitCost, DVAT, dTotalCost As Decimal

                    Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT TOP 1 EngineNo, unitcost, vatamt, totalcost FROM item_Details WHERE EngineNo LIKE '{sEngine}' ORDER BY unitcost DESC")
                        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                            Try
                                myDataReader.Read()
                                dUnitCost = Convert.ToDecimal(myDataReader("unitcost"))
                                DVAT = Convert.ToDecimal(myDataReader("vatamt"))
                                dTotalCost = Convert.ToDecimal(myDataReader("totalcost"))
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If
                    End Using

                    If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET Unit_Cost = '{dUnitCost}', Unit_VAT = '{DVAT}', Unit_Cost_Total = '{dTotalCost}' WHERE EngineNo LIKE '{sEngine}'") Then
                        .SetRowCellValue(iRowHandle, colUnit_Cost, dUnitCost)
                        .SetRowCellValue(iRowHandle, colVAT, DVAT)
                        .SetRowCellValue(iRowHandle, colTotal_Cost, dTotalCost)
                    End If
                Next
            End With
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

        End Sub

        Private Sub btn_Amortization_Schedule_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Amortization_Schedule.ItemClick
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Amortization Schedule", "Re-Generate Amortization Schedule", "This will remove and then regenerate new sets of current Amortization schedules") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Sales Journal", "executed", bLoopStop,,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sBrCode As String = gridView.GetFocusedRowCellValue(colBranch_Code)
                        Dim sAccountNumber As String = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                        Dim iLedger As Integer = Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedger))

                        class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM AmortSched_md WHERE BranchCode LIKE '{sBrCode}' AND AccountNo LIKE '{sAccountNumber}' AND LedgerSetNumber LIKE '{iLedger}'")
                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@ParamInstallNo", Convert.ToInt32(gridView.GetFocusedRowCellValue(colTerms))),
                            New SqlParameter("@ParamBranchCode", sBrCode),
                            New SqlParameter("@ParamAccountNo", sAccountNumber),
                            New SqlParameter("@ParamLedgerSetNumber", iLedger),
                            New SqlParameter("@ParamAmountFinance", Convert.ToDecimal(gridView.GetFocusedRowCellValue(colFinanced))),
                            New SqlParameter("@ParamDateGranted", Convert.ToDateTime(gridView.GetFocusedRowCellValue(colDate_Granted))),
                            New SqlParameter("@ParamInteresRate", Convert.ToDecimal(gridView.GetFocusedRowCellValue(colInterest_Rate)))
                        }

                        class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "mg_create_schedule", "Amortization Schedule")
                    Next
                End If
            End With
        End Sub

        Private Sub btn_Custom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Custom.ItemClick
            With gridView
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False
                .ClearSelection()

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Amortization Update", "updated", bLoopStop,,, "Remarks") Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Dim sAccount = .GetRowCellDisplayText(iRowHandle, colAccount_Code)
                    Dim iLedger = Convert.ToInt32(.GetRowCellValue(iRowHandle, colLedger))

                    If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT AccountNo, LedgerSetNumber, Duedate FROM AmortSched_md WHERE AccountNo LIKE '{sAccount}' AND LedgerSetNumber LIKE '{iLedger}' AND Duedate >= '03/01/2020' AND Duedate <= '05/31/2020'") Then
                        .SetRowCellValue(iRowHandle, colNotes, "Not Adjusted")
                    End If
                Next
            End With
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            Journal_Execute()
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            Stop_Execute()
        End Sub

        Friend Sub Stop_Execute()
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Friend Sub Journal_Execute()
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If bCustomPosting Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to execute/post selected transaction(s) into Journal Entries on {dtCustomDate.ToShortDateString} as Late Posting instead of transaction posting date.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Late Posting Confirmation", True)
                    End If

                    If Not class_Procedures.actionAsk("Customer Accounts", "Execute Account Journal Entries") Then Return
                    class_Procedures.splash_Show("Executing Journal Entries")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Sales Journal", "executed", bLoopStop,,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sAccount As String = .GetRowCellDisplayText(iRowHandle, colAccount_Code)
                        Dim iLedger As Integer = Convert.ToInt32(.GetRowCellValue(iRowHandle, colLedger))
                        Dim sName As String = .GetRowCellDisplayText(iRowHandle, colCustomer_Name)

                        If class_Saga_Database.Journal_Entry_Save("RELEASE", .GetRowCellValue(iRowHandle, colID), .GetRowCellValue(iRowHandle, colDate_Granted)) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry [Release]:{Environment.NewLine}{sAccount}-{iLedger}{Environment.NewLine}{sName}{Environment.NewLine}was successfully executed.")
                        End If
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colEngine), .GetFocusedRowCellValue(colID))
                    .BestFitColumns()
                End If

                class_Procedures.splash_Close()
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Sales Journal", "executed", bLoopStop,,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        .SetRowCellValue(iRowHandle, colIsJournal, class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "RELEASE"))
                    Next
                End If
            End With
        End Sub

        Private Sub Release_Action(ByVal sActionType As String, ByVal sDescription As String, Optional ByVal sNotes As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Account_Code", gridView.GetFocusedRowCellDisplayText(colAccount_Code)),
                New SqlParameter("@Ledger", gridView.GetFocusedRowCellValue(colLedger)),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "[inv_MC_Sale_Procedures]", sDescription, $"{gridView.GetFocusedRowCellDisplayText(colAccount_Code)}-{gridView.GetFocusedRowCellValue(colLedger)}")
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            Release_Action("APPROVE", "Approve MC Sale/Release")
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            Dim sNotes As String = class_Functions.Show_Input_Box("Input reason for disapproval", "Disapprove", String.Empty)
            Release_Action("DISAPPROVE", "Disapprove/Reject MC Sale/Release", sNotes)
        End Sub
    End Class

End Namespace