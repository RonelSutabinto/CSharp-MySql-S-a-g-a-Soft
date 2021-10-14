Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.SPA

    Public Class frm_SPA_Sales_Accounting
        Private bLoopStop As Boolean

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, gridView, BtnCancel)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_SPA_Sales_Accounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)

            Try
                gridView.Columns("BranchCode").ColumnEdit = RepositoryItemLookUpEdit_Branch
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, gridView, True)
        End Function

        Private Sub frm_Spare_Parts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Friend Sub Data_Load(ByVal sBrCode As String, ByVal dtPosting As Date, ByVal iTableID As Integer, ByVal sORNumber As String)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamBranchCode", sBrCode),
                New SqlParameter("@ParamDateBegin", dtPosting),
                New SqlParameter("@ParamDateEnd", dtPosting),
                New SqlParameter("@Action_Type", "ACCOUNTING")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "SPA_Sales_Report", "SPA Sales")

            If iTableID > 0 Then
                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount - 1
                    If Convert.ToInt32(gridView.GetRowCellValue(i, "ID")).Equals(iTableID) Or gridView.GetRowCellDisplayText(i, "Reference").Equals(sORNumber) Then
                        gridView.SelectRow(i)
                        gridView.MakeRowVisible(i)
                        Exit For
                    End If
                Next
            Else
                gridView.MoveLastVisible()
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colPartNumber"

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            Dim sOldORNumber As String = gridView.GetFocusedRowCellDisplayText("Reference")
            Dim sNewORNumber As String = class_Functions.Show_Input_Box("Input new OR Number", "New OR Number", sOldORNumber).ToUpper
            If class_Procedures.actionAsk("SPA Sale", "SPA Sales Update", "You might update a wrong SPA Sale") Then
                class_Database.Data_Update(class_Database.SPAConnection, $"UPDATE Transaction_Collection SET SINo = '{sNewORNumber}' WHERE SINo LIKE '{sOldORNumber}'", True)
                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sNewORNumber}' WHERE Journal_Reference LIKE '{sOldORNumber}'", True)
            End If
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not class_Procedures.actionAsk("Journal Execution", "Execute SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return


                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Entry_Save("SPA_SALE", .GetRowCellValue(iRowHandle, "ID"), .GetRowCellValue(iRowHandle, "PostingDate")) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Sales]:{Environment.NewLine}{ .GetFocusedRowCellDisplayText("Reference")}{Environment.NewLine}was successfully executed.")
                        End If
                    Next
                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText("Reference"), .GetFocusedRowCellValue("ID"))
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            If gridView.SelectedRowsCount > 0 Then
                class_Database.Initialize_Connection()
                class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Reference"), gridView.GetFocusedRowCellValue("ID"))
            End If
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    'Dim sReference As String = Nothing

                    If Not class_Procedures.actionAsk("Verification", "Verify SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return


                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Verify(iRowHandle, "SPA_SALE") Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, "Reference")}{Environment.NewLine}was successfully verified.")
                        End If
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText("Reference"), .GetFocusedRowCellValue("ID"))
                End If
            End With
        End Sub

    End Class

End Namespace