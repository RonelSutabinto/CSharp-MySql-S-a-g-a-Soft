Imports BranchAccounting.Modules
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms
    Public Class frm_Collection
        Friend bLoopStop As Boolean

        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

            Dim repositoryBranch = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(repositoryBranch)
            colBranch_Code.ColumnEdit = repositoryBranch
            colIBP_Branch_Code.ColumnEdit = repositoryBranch
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            class_Saga_Database.bLoopStop = True

            class_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btn_Journal.Enabled = class_Saga_Variables.isCashier
            btn_Update.Enabled = class_Saga_Variables.isCashier

            BarEditItem_Corporation.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            colCorp.ColumnEdit = RepositoryItemLookUpEdit_Corporation
        End Sub

        Private Sub frm_Collection_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Load_Data()
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Show_Journal_Entries()

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "LOAD_SEARCH")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Collection_Procedures", "TransactionPayments")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
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

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_Data()
        End Sub

        Private Sub Load_Data()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Collection_Procedures", "Payment Collection", True)
        End Sub

        Friend Function IsValidated(ByVal iRow As Integer) As Boolean
            Dim sPayType As String
            Dim dDebit, dCredit, dPrincipal, dInterest, dVAT, dNoVAT, dRebate, dPenalty As Decimal
            Dim dAmountPaid, dIBAmountPaid As Decimal
            Dim dtPosted, dtIBPosted As Date

            sPayType = gridView.GetRowCellDisplayText(iRow, colPayment_Code)

            Select Case sPayType
                Case "APAY"
                    dPrincipal = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colPrincipal))
                    dInterest = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colInterest))

                    dRebate = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colRebates))
                    dPenalty = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colPenalty))

                    Try
                        dVAT = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colVAT))
                    Catch ex As Exception
                        dVAT = 0
                    End Try

                    Try
                        dNoVAT = Convert.ToDecimal(gridView.GetRowCellValue(iRow, colNoVAT))
                    Catch ex As Exception
                        dNoVAT = 0
                    End Try

                    dAmountPaid = Convert.ToDecimal(gridView.GetRowCellDisplayText(iRow, colAmount_Paid))
                    Try
                        dIBAmountPaid = Convert.ToDecimal(gridView.GetRowCellDisplayText(iRow, colIBP_Amount_Paid))
                    Catch ex As Exception
                        dIBAmountPaid = 0
                    End Try

                    dtPosted = Convert.ToDateTime(gridView.GetRowCellValue(iRow, colPosting_Date))
                    Try
                        dtIBPosted = Convert.ToDateTime(gridView.GetRowCellValue(iRow, colIBP_Posting_Date))
                    Catch ex As Exception
                        dtIBPosted = dtPosted
                    End Try

                    If Not dtPosted.Equals(dtIBPosted) Then
                        'gridView.SetRowCellValue(iRow, colNote, $"*IBC vs. Non-Cash Posting Dates are not equal.")
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "*IBC vs. Non-Cash Posting Dates are not equal.", "Inter-Branch Error", True)
                        Return False
                    End If

                    If Not dAmountPaid.Equals(dIBAmountPaid) Then
                        'gridView.SetRowCellValue(iRow, colNote, $"*IBC vs. Non-Cash Amounts are not equal.")
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "*IBC vs. Non-Cash Amounts are not equal.", "Inter-Branch Error", True)
                        Return False
                    End If

                    dDebit = dAmountPaid + dInterest + dRebate
                    dCredit = dPrincipal + dInterest + dVAT + dNoVAT + dPenalty

                    If Not dDebit.Equals(dCredit) Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"*[Paid Amount + Interest + Rebate] = {dDebit:N2}{Environment.NewLine}is not equal with{Environment.NewLine}[Principal] + [Interest] + [VAT] + [NoVAT] + [Penalty] = {dCredit:N2}", "Payment Collection Error", True)
                        Return False
                    End If
            End Select
            Return True
        End Function

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            Payment_Update()
        End Sub

        Friend Sub Payment_Update()
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Collection Payment(s) Update", "Execute Collection Payment(s) update") Then Return

                    Dim iTableID As Integer
                    Dim dPaid, dInterest, dPrincipal, dVATOld, dNoVATOld, dVAT, dNoVAT, dRebate, dPenalty As Double

                    Dim sNote, sNoteOld As String

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False

                    .ClearSelection()
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Update Payments", "updated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        iTableID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID))

                        dPrincipal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colPrincipal))
                        dInterest = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colInterest))
                        dRebate = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colRebates))
                        dPenalty = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colPenalty))

                        Try
                            dVATOld = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colVAT))
                        Catch ex As Exception
                            dVATOld = 0
                        End Try

                        Try
                            dNoVATOld = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colNoVAT))
                        Catch ex As Exception
                            dNoVATOld = 0
                        End Try

                        If Not IsValidated(iRowHandle) AndAlso dInterest > 0 Then
                            dVAT = class_Functions.calculate_VAT(dInterest)
                            dNoVAT = class_Functions.calculate_no_VAT(dInterest)

                            sNoteOld = .GetRowCellDisplayText(iRowHandle, colNotes)
                            sNote = $"UPDATED VAT: {dVATOld}->{dVAT} & Non-VAT: {dNoVATOld}->{dNoVAT} [{Date.Today.ToShortDateString} {DateTime.Now.ToLongTimeString}]"

                            dPaid = (dPrincipal + dInterest + dPenalty) - dRebate
                            .SetRowCellValue(iRowHandle, colAmount_Paid, $"{dPaid}")
                            .SetRowCellValue(iRowHandle, colVAT, $"{dVAT}")
                            .SetRowCellValue(iRowHandle, colNoVAT, $"{dNoVAT}")

                            If sNoteOld.Contains(sNote) Then
                                .SetRowCellValue(iRowHandle, colNotes, $"{sNoteOld.Trim}")
                            Else
                                .SetRowCellValue(iRowHandle, colNotes, $"{sNoteOld} {sNote.Trim}")
                            End If

                            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE TransactionPayments SET AmountPaid = @AmountPaid, VAT = @VAT, AmntNetOfVat = @AmntNetOfVat WHERE ID LIKE '{iTableID}'", MySQLConnection)
                                    MyCommand.Parameters.Add("@AmountPaid", SqlDbType.Money).Value = dPaid
                                    MyCommand.Parameters.Add("@VAT", SqlDbType.Money).Value = dVAT
                                    MyCommand.Parameters.Add("@AmntNetOfVat", SqlDbType.Money).Value = dNoVAT

                                    Try
                                        MySQLConnection.Open()
                                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                                            Call .SetRowCellValue(iRowHandle, colNotes, sNote)
                                        End If
                                    Catch ex As Exception
                                        class_Procedures.Show_Error(ex)
                                    End Try
                                End Using
                            End Using
                        End If
                    Next
                End If
            End With
        End Sub

        Friend Sub Show_Journal_Entries()
            If gridView.SelectedRowsCount > 0 Then
                If gridView.GetFocusedRowCellDisplayText(colPayment_Code).Contains("DP") Or gridView.GetFocusedRowCellDisplayText(colPayment_Code).Contains("COD") Then
                    Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colEngine))
                Else
                    Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colOR_Code))
                End If
            End If
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Show_Journal_Entries()
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Database.bLoopStop = True
        End Sub

        Private Sub btn_Validate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick
            Dim sPayType, sReference, sORNumber As String
            bLoopStop = False
            If gridView.DataRowCount > 0 Then
                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount

                    If bLoopStop Then
                        gridView.SetRowCellValue(i, colNotes, "Collection Validation stopped by the user.")
                        class_Procedures.Loop_Stop_Message("Collections", "validated")
                        Return
                    End If

                    If gridView.GetRowCellDisplayText(i, colPayment_Code).Equals("DP") Then Continue For

                    sPayType = gridView.GetRowCellDisplayText(i, colPayment_Code)

                    If sPayType.Contains("PAY") Then
                        sReference = gridView.GetRowCellDisplayText(i, colReference)
                        sORNumber = gridView.GetRowCellDisplayText(i, colOR_Code)

                        If sReference.Contains(" ") Then
                            gridView.SetRowCellValue(i, colNotes, $"*Reference contains blanks(_) and/or in wrong format.")
                            gridView.SelectRow(i)
                        End If

                        If sORNumber.Contains(" ") Then
                            gridView.SetRowCellValue(i, colNotes, $"*OR Code-Number contains blanks(_) and/or in wrong format.")
                            gridView.SelectRow(i)
                        End If
                    End If

                    If Not IsValidated(i) Then
                        gridView.SelectRow(i)
                        gridView.FocusedRowHandle = i
                        gridView.MakeRowVisible(i)
                        Application.DoEvents()
                    End If
                Next

                If gridView.SelectedRowsCount > 0 Then class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"There are {gridView.SelectedRowsCount} invalid payment entries found.{Environment.NewLine}Please check OR Number and/or Amount figures.")
            End If
        End Sub

        Private Sub btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Collections Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sPayType As String = .GetRowCellDisplayText(iRowHandle, colPayment_Code)

                        If sPayType.Contains("PAY") AndAlso Not IsValidated(iRowHandle) Then Continue For

                        If sPayType.Equals("APAY") Then
                            If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIBP_Is_Journal)) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "The Branch who received the payment collection amount should execute Journal Entries first before the Local Branch.", "Inter-Branch Journal Error", True)
                                Continue For
                            End If
                        End If

                        If class_Saga_Database.Journal_Entry_Save("COLLECTION", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), .GetRowCellValue(iRowHandle, colPosting_Date)) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry successfully executed.")
                        End If
                    Next

                    Show_Journal_Entries()
                    btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Collections Journal verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "COLLECTION") Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Payment Collection [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, colReference)}{Environment.NewLine}was successfully verified.")
                        End If
                    Next

                    .BestFitColumns()
                    Show_Journal_Entries()
                    btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

    End Class

End Namespace