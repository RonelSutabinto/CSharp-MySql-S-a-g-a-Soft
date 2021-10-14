Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Custom

    Public Class frm_Error_Reports
        Private bLoopStop As Boolean

        Sub New()
            If Me.xuc_Error_Report Is Nothing Then
                Me.xuc_Error_Report = New Controls.Custom.xuc_Error_Report()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Error_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_Error_Report.Branch_Code)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub frm_Error_Reports_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            gridView.SaveLayoutToRegistry(Me.Name)
            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Error_Reports_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            'xuc_bank.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

            Data_Load()
        End Sub

        Private Sub Data_Load()
            'Dim sAction As String
            If xuc_Settings.Toggle_Load_All.IsOn Then
                'sAction = "LOAD_ALL"
                If barEditItem_Branch.EditValue.ToString.Equals("000") Then
                    class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM acc_Error_Reports", "acc_Error_Reports")
                Else
                    class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Error_Reports WHERE Branch_Code LIKE '{barEditItem_Branch.EditValue}'", "acc_Error_Reports")
                End If
            Else
                'sAction = "LOAD"
                If barEditItem_Branch.EditValue.ToString.Equals("000") Then
                    class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Error_Reports WHERE Transaction_Date >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) AND Transaction_Date <= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23)", "acc_Error_Reports")
                Else
                    class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Error_Reports WHERE Transaction_Date >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) AND Transaction_Date <= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23) AND Branch_Code LIKE '{barEditItem_Branch.EditValue}'", "acc_Error_Reports")
                End If
            End If

            'Dim sqlParameters As SqlParameter() = {
            '    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
            '    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
            '    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
            '    New SqlParameter("@Action_Type", sAction)
            '}

            'class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Error_Report_Procedures", "acc_Error_Reports")
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

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then

                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Banks WHERE Bank_Name LIKE '%{sSearch}%' OR Bank_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "acc_Banks")
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Error_Report
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Branch_Code.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Code)
                    .Error_Type.Text = gridView.GetFocusedRowCellDisplayText(colError_Type)
                    .Transaction_Reference.Text = gridView.GetFocusedRowCellDisplayText(colTransaction_Reference)
                    .Error_Description.Text = gridView.GetFocusedRowCellDisplayText(colError_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If .DataRowCount > 0 And e.Clicks.Equals(2) Then
                    Select Case e.Column.FieldName
                        Case "Transaction_Reference"
                            Select Case .GetFocusedRowCellDisplayText("Error_Type")
                                Case "JOURNAL"
                                    class_Saga_Procedures.Show_Journal_Entries_Reference(e.CellValue.ToString)
                            End Select
                    End Select
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                End If
            End With
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 And gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.F2
                        'Me.xuc_bank.Select()

                    Case Keys.Delete
                        Delete_Error_Reports()
                End Select
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            'xuc_bank.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            'If xuc_bank.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
            '    btn_Reload_ItemClick(sender, e)
            'Else
            '    Update_Data_Row()
            'End If
        End Sub

        Private Sub Delete_Error_Reports()
            With gridView
                If Not class_Procedures.actionAsk("Delete Error Report(s)", "delete selected Error Report(s)", "You might delete wrong Error Report(s)") Then Return

                class_Procedures.splash_Show("Deleting Journal Transaction(s)")

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete Error Report(s)", "deleted", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn, True) Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@ID", .GetRowCellDisplayText(iRowHandle, "ID")),
                        New SqlParameter("@Action_Type", "DELETE")
                    }

                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Error_Report_Procedures", "Delete Error Report")
                Next

                .DeleteSelectedRows()
                class_Procedures.splash_Close()
                Return
            End With
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Delete_Error_Reports()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

    End Class

End Namespace