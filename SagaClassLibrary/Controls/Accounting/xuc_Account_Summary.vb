Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Account_Summary
        Friend bBranchOnly, bLoopStop As Boolean
        Friend sBrCode As String = "000"
        Friend eDateType As eLoad_Type

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Control_Data_Load()
        End Sub

        Friend Function Control_Data_Load() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "PROOF_SHEET_ALL")
            }
            Return class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
        End Function

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then

                Select Case e.Column.Name
                    Case "colCOA_Code"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case "colCOA_Name"
                        class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))

                    Case "colJournal_Debit"
                        class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, sBrCode, "AND Journal_Debit > 0")

                    Case "colJournal_Credit"
                        class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, sBrCode, "AND Journal_Credit > 0")
                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If e.Button.Equals(MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Friend Sub btn_Trial_Balance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Trial_Balance.ItemClick
            Summary_To_Trial_Balance()
        End Sub

        Friend Sub Summary_To_Trial_Balance(Optional ByVal bLiveLooping As Boolean = True)
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    .ClearSelection()
                    bLoopStop = False

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balance", "updated", bLoopStop, bLiveLooping) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sCOACode As String = .GetRowCellDisplayText(iRowHandle, colCOA_Code)
                        Dim dTotalDebit As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colJournal_Debit))
                        Dim dTotalCredit As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colJournal_Credit))

                        class_Saga_Database.Balance_Save("UPDATE_TOTAL", "DETAIL", eDateType, sBrCode, sCOACode, class_Saga_Variables.dtStart, False, 0, 0, dTotalDebit, dTotalCredit)
                    Next
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Account Trial Balance were successfully updated.", "Account Summary Update")
                End If
            End With
        End Sub

        Private Sub btn_Ledger_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ledger.ItemClick
            class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
            'If gridView.RowCount > 0 Then
            '    Dim xRpt As Reports.Accounting.xrpt_Proof_Sheet = New Reports.Accounting.xrpt_Proof_Sheet()
            '    class_Database.Bind_Report(class_Database.ICSConnection, xRpt, sQuery, "view_Journal_Entries")
            '    Try
            '        With xRpt
            '            .PaperKind = System.Drawing.Printing.PaperKind.Custom
            '            .PageWidth = 850
            '            .PageHeight = 1300

            '            .XrLabel_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)
            '            .XrTableCell_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)

            '            .Branch_Name.Text = class_Saga_Database.get_Branch_Name(sBrCode)
            '            .Transaction_Date.Text = class_Saga_Variables.dtStart.ToString("MMMM dd, yyyy")
            '        End With
            '    Catch ex As Exception
            '        class_Procedures.Show_Error(ex)
            '    End Try
            'End If
        End Sub

    End Class

End Namespace