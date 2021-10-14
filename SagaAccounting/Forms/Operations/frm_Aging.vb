Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Operations

    Public Class frm_Aging

        Sub New()
            'If Me.xuc_bank Is Nothing Then
            '    Me.xuc_bank = New Controls.Accounting.xuc_Bank()
            'End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Aging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
        End Sub

        Private Sub frm_Aging_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            BarEditItem_Corporation.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")
            barEditItem_Branch.EditValue = class_Tools.RegKeyGet(Me.Name, barEditItem_Branch.Name, "000")
            BarEditItem_Status.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Status.Name, "Overdue")
            BarEditItem_Date.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date.Name, Date.Today.ToString)
            BarEditItem_60_Days.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_60_Days.Name, ">")
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, barEditItem_Branch.Name, barEditItem_Branch.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Status.Name, BarEditItem_Status.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Date.Name, BarEditItem_Date.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, BarEditItem_60_Days.Name, BarEditItem_60_Days.EditValue.ToString)

            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Aging_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            'Old Aging Procedure
            'Dim sqlParameters As SqlParameter() = {
            '    New SqlParameter("@ParamCORP", BarEditItem_Corporation.EditValue.ToString),
            '    New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue.ToString),
            '    New SqlParameter("@ParamAECode", BarEditItem_AE.EditValue.ToString),
            '    New SqlParameter("@ParamAcctStatus", BarEditItem_Status.EditValue.ToString),
            '    New SqlParameter("@ParamPostingDate", convert.todatetime(BarEditItem_Date.EditValue))
            '}

            'class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "mg_Generate_Aging", "Collection Aging")

            'New Aging Procedure
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue.ToString),
                    New SqlParameter("@ParamCutOffDate", convert.todatetime(BarEditItem_Date.EditValue))
                }

                If BarEditItem_60_Days.EditValue.ToString.Equals("<") Then
                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "mg_Generate_AgedAccountsL60D", "Aging < 60 Days")
                Else
                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "mg_Generate_AgedAccountsG60D", "Aging > 60 Days")
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

            'Show Unadjusted Accounts
            'Dim sViewQuery As String
            'If barEditItem_Branch.EditValue.ToString.Equals("000") Then
            '    sViewQuery = $"SELECT * FROM View_Amortization_Schedule WHERE CORP LIKE '{BarEditItem_Corporation.EditValue}'"
            'Else
            '    sViewQuery = $"SELECT * FROM View_Amortization_Schedule WHERE CORP LIKE '{BarEditItem_Corporation.EditValue}' AND Branch LIKE '{barEditItem_Branch.EditValue}'"
            'End If
            'class_Database.BindData(class_Database.ICSConnection, gridControl, gridView, sViewQuery)
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                'With xuc_bank
                '    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                '    .Bank_Description.Text = gridView.GetFocusedRowCellDisplayText(colBank_Description)
                '    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                'End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 And gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.F2
                        'Me.xuc_bank.Select()

                End Select
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If (.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                    Select Case e.Column.FieldName
                        Case "AccountNumber"
                            Dim sBrCode As String = .GetFocusedRowCellDisplayText("BranchCode")
                            Dim sAccount As String = .GetFocusedRowCellDisplayText("AccountNumber")
                            Dim iLedger As Integer = Convert.ToInt32(.GetFocusedRowCellValue("LedgerSetNumber"))
                            Dim sName As String = .GetFocusedRowCellDisplayText("AccountName")
                            class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccount, iLedger, sName, True)
                            If xuc_Settings.Toggle_Load_All.IsOn Then
                                class_Saga_Procedures.Show_Amortization(sBrCode, sAccount, iLedger)
                            End If
                    End Select
                End If
            End With
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
            class_Saga_Variables.Initialize_AE(barEditItem_Branch.EditValue.ToString)
            class_Saga_Procedures.Initialize_AE(BarEditItem_AE, RepositoryItemLookUpEdit_AE)
        End Sub

    End Class

End Namespace