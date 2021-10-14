﻿Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Check_Numbers
        Private bLoopStop As Boolean
        Sub New()
            If xuc_Check Is Nothing Then
                xuc_Check = New Controls.Accounting.xuc_Check()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Check.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            AddHandler EntityInstantFeedbackSource.GetQueryable, AddressOf EntityInstantFeedbackSource_GetQueryable
            AddHandler EntityInstantFeedbackSource.DismissQueryable, AddressOf EntityInstantFeedbackSource_DismissQueryable
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Sub EntityInstantFeedbackSource_GetQueryable(sender As Object, e As DevExpress.Data.Linq.GetQueryableEventArgs)
            ' Instantiate a new DataContext
            Dim dataContext As AccEntities = New AccEntities()
            ' Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.view_Checks
            ' Assign the DataContext to the Tag property,
            ' to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Sub EntityInstantFeedbackSource_DismissQueryable(sender As Object, e As DevExpress.Data.Linq.GetQueryableEventArgs)
            ' Dispose of the DataContext
            CType(e.Tag, AccEntities).Dispose()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Check_Numbers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)
            class_Saga_Procedures.Initialize_Bank(xuc_Check.Bank_Account)
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_Detail)

            btn_Link.Enabled = class_Saga_Variables.isAccounting
            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Cancel.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Check.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Check_Numbers_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick

            xuc_Check.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

            Data_Load()
        End Sub

        Private Sub Data_Load()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_checks WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}'", "view_checks")
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_checks WHERE Check_Number LIKE '%{sSearch}%' OR Voucher_Code LIKE '%{sSearch}%' OR Reference LIKE '%{sSearch}%' OR Check_Payee LIKE '%{sSearch}%' OR Check_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "view_checks")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Check
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Check_Code.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Code)
                    .Check_Number.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Number)
                    .Bank_Account.EditValue = gridView.GetFocusedRowCellDisplayText(colBank_Account)
                    .Reference.Text = gridView.GetFocusedRowCellDisplayText(colReference)
                    .Check_Payee.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Payee)
                    .Check_Description.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Description)
                    .Check_Amount_Words.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Amount_Words)
                    .IsCancelled.EditValue = gridView.GetFocusedRowCellValue(colIsCancelled)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                    Try
                        .Check_Amount.Value = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colCheck_Amount))
                        .Issued_Date.EditValue = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colIssued_Date))
                    Catch ex As Exception
                        .Check_Amount.Value = 0
                        .Issued_Date.EditValue = Date.Today
                        'class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, class_procedures.xform, $"{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    End Try
                End With
            End If
        End Sub

        Private Sub Update_Data_Row()
            With gridView
                .SetFocusedRowCellValue(colReference, xuc_Check.Reference.Text)
                .SetFocusedRowCellValue(colCheck_Payee, xuc_Check.Check_Payee.Text)
                .SetFocusedRowCellValue(colCheck_Amount, xuc_Check.Check_Amount.Value)
                .SetFocusedRowCellValue(colCheck_Amount_Words, xuc_Check.Check_Amount_Words.Text)
                .SetFocusedRowCellValue(colIssued_Date, xuc_Check.Issued_Date.EditValue)
                .SetFocusedRowCellValue(colIsCancelled, xuc_Check.IsCancelled.EditValue)
                .SetFocusedRowCellValue(colCheck_Description, xuc_Check.Check_Description.Text)
                .SetFocusedRowCellValue(colNotes, xuc_Check.Notes.Text)
            End With
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Journal_Entries()
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), 0,, gridView.GetFocusedRowCellDisplayText(colCheck_Payee), gridView.GetFocusedRowCellDisplayText(colCheck_Description), gridView.GetFocusedRowCellDisplayText(colCheck_Number))
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then

                Select Case e.Column.Name
                    Case "colBank_Account"
                        class_Saga_Procedures.Show_Bank(e.CellValue.ToString)

                    Case "colVoucher_Code"
                        class_Saga_Procedures.Show_Voucher(e.CellValue.ToString)

                    Case "colReference"
                        Journal_Entries()

                    Case "colCheck_Payee"
                        Try
                            class_Saga_Procedures.Show_Account_Name(e.CellValue.ToString)
                        Catch ex As Exception
                        End Try

                    Case Else
                        Data_Show()
                End Select
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.F2
                        xuc_Check.Select()
                End Select
            End If
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Check.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Link_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Link.ItemClick

            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM acc_Vouchers WHERE Voucher_Check LIKE '{xuc_Check.Check_Number.Text}'")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        With xuc_Check
                            .Reference.Text = myDataReader("Voucher_Reference").ToString
                            .Check_Payee.Text = myDataReader("Voucher_Name").ToString
                            .Check_Amount.EditValue = Convert.ToDecimal(myDataReader("Voucher_Debit"))
                            .Issued_Date.EditValue = Convert.ToDateTime(myDataReader("Voucher_Date_Posted"))
                            .Check_Description.Text = myDataReader("Voucher_Description").ToString
                            .Notes.Text = myDataReader("Notes").ToString
                        End With
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Check Number has no voucher transaction(s)")
                End If
            End Using
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Check.Control_Save() Then Update_Data_Row()
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            If Not class_Procedures.actionAsk($"Check Amount", "Update check amount and amount words") Then Return

            With gridView
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False
                .ClearSelection()

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Check Update", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Try
                        Dim dCredit As Decimal = .GetRowCellValue(iRowHandle, colCheck_Amount)
                        If dCredit > 0 Then
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@Check_Number", .GetRowCellDisplayText(iRowHandle, colCheck_Number)),
                                New SqlParameter("@Check_Amount", dCredit),
                                New SqlParameter("@Check_Amount_Words", class_Functions.AmountToWords(dCredit)),
                                New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, colNotes)),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Action_Type", "UPDATE_AMOUNT")
                            }
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Check_Procedures", "Check Amount")
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                Next
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Cancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cancel.ItemClick
            If xuc_Check.Control_Check_Cancel() Then Update_Data_Row()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick

        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Journal_Entries()
        End Sub

    End Class

End Namespace