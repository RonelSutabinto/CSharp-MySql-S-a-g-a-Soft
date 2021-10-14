Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Aging
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, dockManager, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, barManager)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Aging_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Registry_Values_Get()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)
    End Sub

    Private Sub Registry_Values_Get()

    End Sub

    Private Sub Registry_Values_Set()

    End Sub

    Private Function Form_Close() As Boolean
        Registry_Values_Set()
        Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, True)
    End Function

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub frm_Aging_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
    End Sub

    Private Sub Data_Load()

        If check_Load_All.Checked Then
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM view_Accounts AND AccountStatus NOT LIKE 'Closed'", "view_Accounts")
        Else
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Accounts WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}' AND AccountStatus NOT LIKE 'Closed'", "view_Accounts")
        End If
    End Sub

    Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then

            Select Case e.Column.Name
                Case "colCIFKey"
                    If gridView.GetFocusedRowCellDisplayText(colCIFKey) Is "0" Then Exit Select
                    class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedgerSetNumber)), gridView.GetFocusedRowCellDisplayText(colAccountName), True)

                Case "colAccountNumber"
                    class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedgerSetNumber)), gridView.GetFocusedRowCellDisplayText(colAccountName), True)

                Case "colAgentCode"
                    class_Saga_Procedures.Show_Agent(e.CellValue.ToString)

                Case "colAccountExecutive"
                    class_Saga_Procedures.Show_Account_Executive(e.CellValue.ToString)

                Case "colModel"
                    class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                Case "colEngineNo"
                    class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                Case "colChassisNo"
                    class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                Case "colTransactedBy"
                    class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                Case Else
                    If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

            End Select
        End If
    End Sub

    Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load()
    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_Generate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
        Dim iDD, iTerms, iMonthsToBePaid As Integer
        Dim dMonthly, dOB, dOBTarget, dOBActual, dOBTotal As Decimal, dAdvanced As Decimal = 0, dODue As Decimal = 0, dDue0 As Decimal = 0, dDue1 As Decimal = 0, dDue2 As Decimal = 0

        If gridView.DataRowCount > 0 Then
            class_Procedures.splash_Show("Generating Customer Aging")

            For i As Integer = 0 To gridView.DataRowCount - 1

                Try
                    iDD = convert.todatetime(gridView.GetRowCellValue(i, colFirstPayDate)).Day
                    gridView.SetRowCellValue(i, colDueDate, iDD)
                    dMonthly = convert.todecimal(gridView.GetRowCellValue(i, colPMT))
                    iTerms = Convert.ToInt32(gridView.GetRowCellValue(i, colTerms))

                    If convert.todatetime(gridView.GetRowCellValue(i, colMaturityDate)) <= Date.Today Then
                        iMonthsToBePaid = iTerms
                    Else
                        iMonthsToBePaid = class_Functions.GetMonthDifference(convert.todatetime(gridView.GetRowCellValue(i, colFirstPayDate)), Date.Today)
                    End If

                    If convert.todatetime(gridView.GetRowCellValue(i, colFirstPayDate)).Day.Equals(convert.todatetime(gridView.GetRowCellValue(i, colLastMvmtDate)).Day) Then
                    End If

                    dOBTotal = dMonthly * iTerms
                    dOBTarget = dMonthly * iMonthsToBePaid
                    dOB = convert.todecimal(gridView.GetRowCellValue(i, colOutstandingBalance))
                    dOBActual = (dOBTotal - dOB)

                    If dOB > 0 Then

                        If dOBActual >= dOBTarget Then

                            If dOB <= dMonthly Then

                                If convert.todatetime(gridView.GetRowCellValue(i, colMaturityDate)) <= Date.Today Then
                                    gridView.SetRowCellValue(i, colOverDue, dOB)
                                Else
                                    gridView.SetRowCellValue(i, colDue0, dOB)
                                    gridView.SetRowCellValue(i, colDue1, dOB)
                                End If

                                gridView.SetRowCellValue(i, colBalance, dOB)
                            Else
                                dDue0 = 0
                                dDue1 = 0
                                dDue2 = 0
                                dAdvanced = (dOBActual - dOBTarget)
                                gridView.SetRowCellValue(i, colDue0, dMonthly)
                                dDue0 = dMonthly
                                If dAdvanced > 0 Then gridView.SetRowCellValue(i, colAdvanced, dAdvanced)

                                If dAdvanced <= dMonthly Then
                                    dDue1 = dMonthly - dAdvanced
                                    gridView.SetRowCellValue(i, colDue1, dDue1)
                                    dAdvanced = 0
                                Else
                                    dDue1 = dMonthly
                                    gridView.SetRowCellValue(i, colDue1, dMonthly)
                                    dAdvanced -= dMonthly
                                End If

                                If dAdvanced >= dMonthly Then
                                    gridView.SetRowCellValue(i, colDue2, dMonthly)
                                    dDue2 = dMonthly
                                    dAdvanced -= dMonthly
                                Else

                                    If dOB <= dMonthly Then
                                        gridView.SetRowCellValue(i, colDue2, 0)
                                    Else
                                        dDue2 = dMonthly - dAdvanced
                                        gridView.SetRowCellValue(i, colDue2, dMonthly - dAdvanced)
                                    End If
                                End If

                                gridView.SetRowCellValue(i, colBalance, dOB - (dDue1 + dDue2))
                            End If
                        ElseIf dOBActual.Equals(0) Then
                            dDue0 = 0
                            dDue1 = dMonthly
                            dDue2 = dMonthly
                            gridView.SetRowCellValue(i, colBalance, dOB - (dODue + dDue1 + dDue2))
                        Else
                            dDue0 = 0
                            dDue1 = 0
                            dDue2 = 0
                            dODue = dOBTarget - dOBActual

                            If dODue <= dMonthly Then
                                gridView.SetRowCellValue(i, colOverDue, dODue)
                                gridView.SetRowCellValue(i, colBalance, dOB)
                            Else
                                gridView.SetRowCellValue(i, colOverDue, dODue)

                                If Not iMonthsToBePaid.Equals(iTerms) Then

                                    If True Then
                                        gridView.SetRowCellValue(i, colDue1, (dMonthly))
                                        dDue1 = dMonthly

                                        If iMonthsToBePaid.Equals(iTerms - 1) Then

                                            If (dOB - dODue) - dMonthly > dMonthly Then
                                                gridView.SetRowCellValue(i, colDue2, (dMonthly))
                                                dDue2 = dMonthly
                                            End If
                                        Else
                                            gridView.SetRowCellValue(i, colDue2, (dMonthly))
                                        End If
                                    End If
                                End If

                                gridView.SetRowCellValue(i, colBalance, (dODue + dDue1 + dDue2))
                            End If
                        End If
                    End If
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            Next

            class_Procedures.splash_Close()
        End If

        gridView.BestFitColumns()
    End Sub

End Class