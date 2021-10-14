Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports BranchAccounting.Modules
Imports wSClassLib.myModules

Namespace Forms
    Public Class XtraForm_Collection

        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            Modules.Initialize_Form(Me, GridView, BtnCancel)
            Modules.Initialize_BarManager(Me, BarManager)
        End Sub

        Friend bLoopStop As Boolean

        Private Sub XtraForm_Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub XtraForm_Collection_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Modules.Initialize_Branch()
            Modules.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)

            BarEditItem_Corporation.EditValue = Module_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            BarEditItem_Branch.EditValue = mBrCode
            BarEditItem_Branch.Enabled = False

            BarEditItem_Start.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_Start.Name, Today.ToLongDateString))
            BarEditItem_End.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_End.Name, Today.ToLongDateString))

            GridView.RestoreLayoutFromRegistry(Me.Name)
        End Sub

        Private Sub Btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Start.Name, BarEditItem_Start.EditValue.ToString)
            Module_Tools.RegKeySet(Me.Name, BarEditItem_End.Name, BarEditItem_End.EditValue.ToString)

            Return Modules.Form_Close(Me, BarManager, GridView, True)
        End Function

        Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
            If GridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Show_Journal_Entries()

                End Select
            End If
        End Sub

        Private Sub GridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView.MouseDown, GridControl.MouseDown
            If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim Parameters As SqlParameter() = {New SqlParameter("@Branch_Code", BarEditItem_Branch.EditValue.ToString),
                                                    New SqlParameter("@Search", sSearch),
                                                    New SqlParameter("@Action_Type", "LOAD_SEARCH")}

                Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Collection_Procedures", Parameters)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch Ex As NullReferenceException

                End Try
            End If
        End Sub

        Private Sub BarEditItem_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Start.ItemDoubleClick
            BarEditItem_Start.EditValue = Next_Working_Date(CDate(BarEditItem_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub BarEditItem_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_End.ItemDoubleClick
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
            Modules.Initialize_Printing(e)
        End Sub

        Private Sub Btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
            GridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
            If (GridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                Modules.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub Btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
            Dim Parameters As SqlParameter() = {New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                                                New SqlParameter("@Branch_Code", BarEditItem_Branch.EditValue.ToString),
                                                New SqlParameter("@Date_Start", CDate(BarEditItem_Start.EditValue)),
                                                New SqlParameter("@Date_End", CDate(BarEditItem_End.EditValue)),
                                                New SqlParameter("@Action_Type", "LOAD_BRANCH")}

            Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Collection_Procedures", Parameters)
        End Sub

        Friend Function IsValidated(ByVal iRow As Integer) As Boolean
            Dim sBrand, sPayType As String
            Dim dDebit, dCredit, dPrincipal, dInterest, dVAT, dNoVAT, dRebate, dPenalty As Decimal
            Dim dAmountPaid, dIBAmountPaid As Decimal
            Dim dtPosted, dtIBPosted As Date

            sPayType = GridView.GetRowCellDisplayText(iRow, colRemarks)
            sBrand = GridView.GetRowCellDisplayText(iRow, colBrand)

            If sBrand.Equals("") Then
                GridView.SetRowCellValue(iRow, colNote, "*Brand is missing.")
                Return False
            End If

            Select Case sPayType
                Case "APAY"
                    dAmountPaid = CDec(GridView.GetRowCellDisplayText(iRow, colAmountPaid))
                    dPrincipal = CDec(GridView.GetRowCellValue(iRow, colPrincipal))
                    dInterest = CDec(GridView.GetRowCellValue(iRow, colInterest))

                    dRebate = CDec(GridView.GetRowCellValue(iRow, colRebates))
                    dPenalty = CDec(GridView.GetRowCellValue(iRow, colPEN))

                    Try
                        dVAT = CDec(GridView.GetRowCellValue(iRow, colVAT))
                    Catch Ex As InvalidCastException
                        dVAT = 0
                    End Try

                    Try
                        dNoVAT = CDec(GridView.GetRowCellValue(iRow, colAmntNetOfVat))
                    Catch Ex As InvalidCastException
                        dNoVAT = 0
                    End Try

                    Try
                        dIBAmountPaid = CDec(GridView.GetRowCellDisplayText(iRow, colIBP_AmountReceived))
                    Catch Ex As InvalidCastException
                        dIBAmountPaid = 0
                    End Try

                    dtPosted = CDate(GridView.GetRowCellValue(iRow, colPostingDate))

                    Try
                        dtIBPosted = CDate(GridView.GetRowCellValue(iRow, colIBP_PostingDate))
                    Catch Ex As InvalidCastException
                        dtIBPosted = dtPosted
                    End Try

                    If Not dtPosted.Equals(dtIBPosted) Then
                        'GridView.SetRowCellValue(iRow, colNote, $"*IBC vs. Non-Cash Posting Dates are not equal.")
                        Modules.Set_Message(Modules.MsgMode.Errorr, "*IBP vs. Non-Cash Posting Dates are not equal.", "Inter-Branch Error", True)
                        Return False
                    End If

                    If Not dAmountPaid.Equals(dIBAmountPaid) Then
                        'GridView.SetRowCellValue(iRow, colNote, $"*IBC vs. Non-Cash Amounts are not equal.")
                        Modules.Set_Message(Modules.MsgMode.Errorr, "*IBP vs. Non-Cash Amounts are not equal.", "Inter-Branch Error", True)
                        Return False
                    End If

                    dDebit = dAmountPaid + dInterest + dRebate
                    dCredit = dPrincipal + dInterest + dVAT + dNoVAT + dPenalty

                    If Not dDebit.Equals(dCredit) Then
                        'GridView.SetRowCellValue(iRow, colNote, $"*[Paid Amount + Interest + Rebate] is not equal with [Principal] + [Interest] + [VAT] + [NoVAT] + [Penalty]")
                        Modules.Set_Message(Modules.MsgMode.Errorr, $"*[Paid Amount + Interest + Rebate] is not equal with [Principal] + [Interest] + [VAT] + [NoVAT] + [Penalty]{Environment.NewLine}Please update the transaction and Re-Journal", "Payment Error", True)
                        Return False
                    End If
            End Select
            Return True
        End Function

        Private Sub Btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Update.ItemClick
            Payment_Update()
        End Sub

        Friend Sub Payment_Update()
            With GridView
                If .DataRowCount > 0 Then
                    If Not Modules.actionAsk("Collection Payment(s) Update", "Execute Collection Payment(s) update") Then Return

                    Dim iTableID As Integer
                    Dim dPaid, dInterest, dPrincipal, dVATOld, dNoVATOld, dVAT, dNoVAT, dRebate, dPenalty As Decimal

                    Dim sNote, sNoteOld As String

                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False

                    .ClearSelection()
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Update Payments", "updated", bLoopStop) Then Return

                        iTableID = CInt(.GetRowCellValue(iRowHandle, colID))

                        dPrincipal = CDec(.GetRowCellValue(iRowHandle, colPrincipal))
                        dInterest = CDec(.GetRowCellValue(iRowHandle, colInterest))
                        dRebate = CDec(.GetRowCellValue(iRowHandle, colRebates))
                        dPenalty = CDec(.GetRowCellValue(iRowHandle, colPEN))

                        Try
                            dVATOld = CDec(.GetRowCellValue(iRowHandle, colVAT))
                        Catch Ex As InvalidCastException
                            dVATOld = 0
                        End Try

                        Try
                            dNoVATOld = CDec(.GetRowCellValue(iRowHandle, colAmntNetOfVat))
                        Catch Ex As InvalidCastException
                            dNoVATOld = 0
                        End Try

                        'If dInterest > 0 And dVATOld <= 0 Then
                        If Not IsValidated(iRowHandle) AndAlso dInterest > 0 Then
                            dVAT = Modules.calculate_VAT(dInterest)
                            dNoVAT = Modules.calculate_no_VAT(dInterest)

                            sNoteOld = .GetRowCellDisplayText(iRowHandle, colNote)
                            sNote = $"UPDATED VAT: {dVATOld}->{dVAT} & Non-VAT: {dNoVATOld}->{dNoVAT} [{Date.Today.ToShortDateString} {DateTime.Now.ToLongTimeString}]"

                            dPaid = (dPrincipal + dInterest + dPenalty) - dRebate
                            .SetRowCellValue(iRowHandle, colAmountPaid, $"{dPaid}")
                            .SetRowCellValue(iRowHandle, colVAT, $"{dVAT}")
                            .SetRowCellValue(iRowHandle, colAmntNetOfVat, $"{dNoVAT}")

                            If sNoteOld.Contains(sNote) Then
                                .SetRowCellValue(iRowHandle, colNote, $"{sNoteOld.Trim}")
                            Else
                                .SetRowCellValue(iRowHandle, colNote, $"{sNoteOld} {sNote.Trim}")
                            End If

                            Using MySQLConnection = New SqlConnection(connectSP)
                                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE TransactionPayments SET AmountPaid = @AmountPaid, VAT = @VAT, AmntNetOfVat = @AmntNetOfVat, Note = @Note WHERE ID LIKE '{iTableID}'", MySQLConnection)
                                    MyCommand.Parameters.Add("@AmountPaid", SqlDbType.Money).Value = dPaid
                                    MyCommand.Parameters.Add("@VAT", SqlDbType.Money).Value = dVAT
                                    MyCommand.Parameters.Add("@AmntNetOfVat", SqlDbType.Money).Value = dNoVAT
                                    MyCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sNote

                                    Try
                                        MySQLConnection.Open()
                                        If MyCommand.ExecuteNonQuery() > 0 Then
                                            .SetRowCellValue(iRowHandle, colNote, sNote)
                                        End If
                                    Catch Ex As InvalidOperationException
                                        Modules.Set_Message(Modules.MsgMode.Errorr, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                                    Catch Ex As SqlException
                                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                                    Finally

                                    End Try
                                End Using
                            End Using
                        End If
                    Next
                End If
            End With
        End Sub

        Friend Sub Show_Journal_Entries()
            If GridView.SelectedRowsCount > 0 Then
                If GridView.GetFocusedRowCellDisplayText(colRemarks).Contains("DP") Or GridView.GetFocusedRowCellDisplayText(colRemarks).Contains("COD") Then
                    Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colEngineNo))
                Else
                    Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colORNumber))
                End If
            End If
        End Sub

        Private Sub Btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal_Entries.ItemClick
            Show_Journal_Entries()
        End Sub

        Private Sub Btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Stop.ItemClick
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True
        End Sub

        Private Sub Btn_Validate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Validate.ItemClick
            Dim sPayType, sReference, sORNumber As String
            bLoopStop = False
            If GridView.DataRowCount > 0 Then
                GridView.ClearSelection()
                For i As Integer = 0 To GridView.DataRowCount

                    If bLoopStop Then
                        GridView.SetRowCellValue(i, colNote, "Collection Validation stopped by the user.")
                        Modules.Loop_Stop_Message("Collections", "validated")
                        Return
                    End If

                    If GridView.GetRowCellDisplayText(i, colRemarks).Equals("DP") Then Continue For

                    sPayType = GridView.GetRowCellDisplayText(i, colRemarks)

                    If sPayType.Contains("PAY") Then
                        sReference = GridView.GetRowCellDisplayText(i, colReferenceNumber)
                        sORNumber = GridView.GetRowCellDisplayText(i, colORNumber)

                        If sReference.Contains(" ") Then
                            GridView.SetRowCellValue(i, colNote, $"*Reference contains blanks(_) and/or in wrong format.")
                            GridView.SelectRow(i)
                        End If

                        If sORNumber.Contains(" ") Then
                            GridView.SetRowCellValue(i, colNote, $"*OR Code-Number contains blanks(_) and/or in wrong format.")
                            GridView.SelectRow(i)
                        End If
                    End If

                    If Not IsValidated(i) Then
                        GridView.SelectRow(i)
                        GridView.FocusedRowHandle = i
                        GridView.MakeRowVisible(i)
                        Application.DoEvents()
                    End If
                Next

                If GridView.SelectedRowsCount > 0 Then Modules.Set_Message(Modules.MsgMode.Warning, $"There are {GridView.SelectedRowsCount} invalid payment entries found.{Environment.NewLine}Please check OR Number and/or Amount figures.")
            End If
        End Sub

        Private Sub Btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal.ItemClick
            With GridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Collections Journal", "executed", bLoopStop) Then Return

                        If .GetRowCellDisplayText(iRowHandle, colRemarks).Contains("PAY") AndAlso Not IsValidated(iRowHandle) Then Continue For

                        If Journal_Entry_Save(connectSP, "COLLECTION", CInt(.GetRowCellValue(iRowHandle, colID))) Then
                            Modules.Set_Message(Modules.MsgMode.Info, $"Journal Entry successfully executed.")
                        End If
                    Next

                    Show_Journal_Entries()
                    Btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

        Private Sub Btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Verify.ItemClick
            With GridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Collections Journal verification", "verified", bLoopStop) Then Return

                        Modules.Journal_Verify(connectSP, CInt(.GetRowCellValue(iRowHandle, colID)), "COLLECTION")
                    Next

                    .BestFitColumns()
                    Show_Journal_Entries()
                    Btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub
    End Class
End Namespace