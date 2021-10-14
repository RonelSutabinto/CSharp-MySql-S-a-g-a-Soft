Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTreeList.Columns
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Trial_Balance_Tree
        Friend sBrCode As String = "000"
        Friend bPreviousBalance, bEditBalance As Boolean
        Friend eDateType As eLoad_Type

        Sub New()
            InitializeComponent()
        End Sub

        Private Sub treeList_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList.MouseDown
            If treeList.AllNodesCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            treeList.ShowRibbonPrintPreview()
        End Sub

        Private Sub treeList_KeyDown(sender As Object, e As KeyEventArgs) Handles treeList.KeyDown
            If treeList.VisibleNodesCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Enter
                        Select Case treeList.FocusedColumn.Name
                            Case "colBeginning_Balance_Debit"
                                Update_Balance(colBeginning_Balance_Debit)

                            Case "colBeginning_Balance_Credit"
                                Update_Balance(colBeginning_Balance_Credit)

                            Case "colAdjustment"
                                Update_Balance(colBalance_Sheet)

                            Case Else
                        End Select

                    Case Keys.Delete
                        If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Balances WHERE ID LIKE '{treeList.FocusedNode(colID)}'", "Delete Balance Entry") Then
                            treeList.DeleteNode(treeList.FocusedNode)
                        End If
                End Select
            End If
        End Sub

        Private Sub treeList_RowCellClick(sender As Object, e As DevExpress.XtraTreeList.RowCellClickEventArgs) Handles treeList.RowCellClick
            If treeList.VisibleNodesCount > 0 AndAlso e.Clicks.Equals(2) Then
                Try

                    Select Case treeList.FocusedColumn.Name
                        Case "colCOA_Code"
                            class_Saga_Procedures.Show_COA(treeList.GetFocusedRowCellDisplayText(colCOA_Code))

                        Case "colCOA_Name"
                            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, treeList.GetFocusedRowCellDisplayText(colCOA_Code), treeList.GetFocusedRowCellDisplayText(colCOA_Name))

                        Case "colCOA_Summary"
                            class_Saga_Procedures.Show_COA(treeList.GetFocusedRowCellDisplayText(colCOA_Summary))

                        Case "colBeginning_Balance_Debit"
                            Update_Balance(colBeginning_Balance_Debit)

                        Case "colBeginning_Balance_Credit"
                            Update_Balance(colBeginning_Balance_Credit)

                        Case "colTotal_Debit"
                            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, treeList.GetFocusedRowCellDisplayText(colCOA_Code), treeList.GetFocusedRowCellDisplayText(colCOA_Name),,, sBrCode, "AND Journal_Debit > 0")

                        Case "colTotal_Credit"
                            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, treeList.GetFocusedRowCellDisplayText(colCOA_Code), treeList.GetFocusedRowCellDisplayText(colCOA_Name),,, sBrCode, "AND Journal_Credit > 0")

                        Case "colAdjustment_Debit"
                            Update_Balance(colBalance_Sheet)

                        Case "colAdjustment_Credit"
                            'Update_Balance(col)

                        Case "colNotes"
                            treeList.SetFocusedRowCellValue(colNotes, class_Saga_Database.Balance_Notes_Save(Convert.ToInt32(treeList.GetFocusedRowCellDisplayText(colID)), class_Functions.Show_Input_Box($"Set Note(s) for this Balance", "Set Note(s)", e.CellValue.ToString)))
                            colNotes.BestFit()

                        Case Else
                            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    End Select
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Sub Update_Balance(ByVal gvColumn As TreeListColumn)
            If bEditBalance Then
                Dim sBalanceField As String = gvColumn.FieldName
                Dim dDefault, dBalance As Decimal
                Try
                    dDefault = Convert.ToDecimal(treeList.GetFocusedRowCellValue(gvColumn))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                    dDefault = 0
                End Try

                Try
                    dBalance = Convert.ToDecimal(class_Functions.Show_Input_Box($"Set {gvColumn.Caption} for {class_Saga_Variables.dtStart.ToLongDateString}", sBalanceField, dDefault))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                    dBalance = 0
                End Try

                treeList.SetFocusedRowCellValue(gvColumn, class_Saga_Database.Balance_Save(treeList.GetFocusedRowCellDisplayText(colID), sBalanceField, dDefault, dBalance))
            End If
        End Sub

        Private Sub btn_Expand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Expand.ItemClick
            treeList.ExpandAll()
        End Sub

        Private Sub btn_Collapse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Collapse.ItemClick
            treeList.CollapseAll()
        End Sub

        Private Sub treeList_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraTreeList.CustomColumnDisplayTextEventArgs) Handles treeList.CustomColumnDisplayText
            'Select Case e.Column.FieldName
            '    Case "Beginning_Balance_Debit", "Beginning_Balance_Credit", "Total_Debit", "Total_Credit", "Ending_Balance_Debit", "Ending_Balance_Credit"
            '        Try
            '            If Convert.ToDecimal(e.Value).Equals(0) Then
            '                e.DisplayText = String.Empty
            '            End If
            '        Catch ex As Exception
            '            class_Procedures.Show_Error(ex)
            '        End Try
            'End Select
        End Sub

        Private Sub btn_COA_Ledger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_COA_Ledger.ItemClick
            class_Saga_Procedures.Show_COA_Ledger(treeList.GetFocusedRowCellDisplayText(colCOA_Code), treeList.GetFocusedRowCellDisplayText(colCOA_Name))
        End Sub

        Friend Sub preview_Trial_Balance()
            Dim xrpt As New Reports.Accounting.xrpt_FS
            xrpt.Document_Title.Text = "T R I A L  B A L A N C E"
            colBalance_Sheet.Visible = True
            colIncome_Statement.Visible = True
            xrpt.PrintableComponentContainer.PrintableComponent = treeList
            xrpt.PrintableComponentContainer.WindowControlOptions.DrawMethod = WinControlDrawMethod.UseWMPrint
            xrpt.PrintableComponentContainer.WindowControlOptions.PrintMode = WinControlPrintMode.Default
            xrpt.ShowRibbonPreview
        End Sub

        Friend Sub preview_Balance_Sheet()
            'Dim xrpt As New Reports.Accounting.xrpt_FS
            Dim xRpt As New Reports.Accounting.xrpt_Balance_Sheet()
            xRpt.Document_Title.Text = "STATEMENT OF FINANCIAL POSITION"
            xRpt.As_Of_Month.Text = $"As of {class_Saga_Variables.dtEnd:MMMM yyyy}"
            'Dim filterString As String = "[COA_Code] Begins with '1' OR [COA_Code] Begins with '2' OR [COA_Code] Begins with '3'"
            'treeList.Columns("COA_Code").FilterInfo = New TreeListColumnFilterInfo(filterString)
            'colBalance_Sheet.Visible = True
            'colIncome_Statement.Visible = False
            'xrpt.PrintableComponentContainer.PrintableComponent = treeList
            'xrpt.PrintableComponentContainer.WindowControlOptions.DrawMethod = WinControlDrawMethod.UseWMPrint
            'xrpt.PrintableComponentContainer.WindowControlOptions.PrintMode = WinControlPrintMode.Default
            'xrpt.ShowRibbonPreview

            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300
            End With

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD_BALANCE_SHEET")
            }
            class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "acc_Balance_Procedures", "acc_Balances")
        End Sub

        Friend Sub preview_Income_Statement()
            Dim xRpt As New Reports.Accounting.xrpt_Balance_Sheet()
            xRpt.Document_Title.Text = "STATEMENT OF FINANCIAL PERFORMANCE"
            xRpt.As_Of_Month.Text = $"For the month ended {class_Saga_Variables.dtEnd:MMMM yyyy}"

            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300
            End With

            Dim parameterIncEx As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "UPDATE_NET_INCOME")
            }
            class_Database.Procedure_Save(class_Database.ICSConnection, parameterIncEx, "acc_Balance_Procedures", "Update Net Income")

            Dim parameterFS As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD_INCOME_EXPENSE")
            }
            class_Database.Procedure_Bind_Report(class_Database.ICSConnection, parameterFS, xRpt, "acc_Balance_Procedures", "acc_Balances")
        End Sub

        Friend Sub preview_Financial_Position()
            Dim xRpt As New Reports.Accounting.xrpt_Financial_Position()
            With xRpt
                .XrLabel_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)
                .As_Of_Month.Text = $"For the month ended {class_Saga_Variables.dtEnd:MMMM yyyy}"
                .As_Of_Date.Text = $"{class_Saga_Variables.dtEnd:MMMM dd, yyyy}"

                If class_Saga_Variables.sCorporation.Equals("SMC") Then
                    .Installment_Receivable.Text = "INSTALLMENT SALES RECEIVABLE"
                    .Retirement_Fund.Text = "RETIREMENT FUND / MC LEASING"
                End If

                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300

                .Total_Assets.Text = Get_Total_Balance("1").ToString("N2")
                .Total_Cash_On_Hand.Text = Get_Total_Balance("10102").ToString("N2")
                .Total_Cash_In_Bank.Text = Get_Total_Balance("10101").ToString("N2")
                .Total_Revolving_Fund.Text = Get_Total_Balance("10103").ToString("N2")
                .Total_Shortages.Text = Get_Total_Balance("10707").ToString("N2")

                .Total_Accounts_Receivable.Text = Get_Total_Balance("104").ToString("N2")

                'If class_Saga_Variables.sCorporation.Equals("SMC") Then
                '    Dim dCODFinance As Decimal = Get_Total_Balance("10403")
                '    Dim dOverages As Decimal = Get_Total_Balance("20908") * 2
                '    .Total_AR_COD_Finance.Text = (dCODFinance - dOverages).ToString("N2")
                'Else
                '    .Total_AR_COD_Finance.Text = Get_Total_Balance("10403").ToString("N2")
                'End If

                .Total_AR_COD_Finance.Text = Get_Total_Balance("10403").ToString("N2")

                .Total_AR_ECOD.Text = Get_Total_Balance("10405").ToString("N2")
                .Total_AR_TCOD.Text = Get_Total_Balance("10406").ToString("N2")
                .Total_AR_SPA.Text = Get_Total_Balance("10404").ToString("N2")
                .Total_AR_Merchandise.Text = Get_Total_Balance("10407").ToString("N2")
                .Total_AR_Finance.Text = Get_Total_Balance("10401").ToString("N2")
                .Total_AR_Others.Text = (Get_Total_Balance("10414") + Get_Total_Balance("10418") + Get_Total_Balance("10423")).ToString("N2")

                .Total_Advances_To_Officers.Text = Get_Total_Balance("10412").ToString("N2")
                .Total_Advances_To_Employees.Text = Get_Total_Balance("10411").ToString("N2")

                .Total_Installment_Receivable.Text = Get_Total_Balance("102").ToString("N2")
                .Total_Ins_Rec_New_Principal.Text = (Get_Total_Balance("10201") + Get_Total_Balance("10205")).ToString("N2")
                .Total_Ins_Rec_New_Interest.Text = (Get_Total_Balance("10202") + Get_Total_Balance("10206")).ToString("N2")
                .Total_Ins_Rec_Repo_Principal.Text = Get_Total_Balance("10209").ToString("N2")
                .Total_Ins_Rec_Repo_Interest.Text = Get_Total_Balance("10210").ToString("N2")

                .Total_Allowance_For_Doubtful_Accounts.Text = Get_Total_Balance("10217").ToString("N2")
                .Total_Retirement_Fund_MC_Leasing.Text = Get_Total_Balance("10419").ToString("N2")
                .Total_Creditable_WithHolding_Tax.Text = Get_Total_Balance("10701").ToString("N2")
                .Total_Input_VAT.Text = Get_Total_Balance("10702").ToString("N2")

                .Total_Inventories.Text = Get_Total_Balance("103").ToString("N2")
                .Total_Inv_Merchandise.Text = Get_Total_Balance("10316").ToString("N2")
                .Total_Inv_Motor_Vehicle.Text = Get_Total_Balance("10306").ToString("N2")
                .Total_Inv_MC_New.Text = Get_Total_Balance("10301").ToString("N2")
                .Total_Inv_MC_Repo.Text = Get_Total_Balance("10304").ToString("N2")
                .Total_Inv_In_Transit.Text = Get_Total_Balance("10302").ToString("N2")
                .Total_Inv_MC_In_Transit_Inter_Branch.Text = Get_Total_Balance("10303").ToString("N2")

                .Total_Inv_SPA.Text = Get_Total_Balance("10307").ToString("N2")
                .Total_Inv_Apparels.Text = Get_Total_Balance("10314").ToString("N2")
                .Total_Inv_Freebies.Text = Get_Total_Balance("10315").ToString("N2")

                .Total_Prepaid_Expenses.Text = Get_Total_Balance("108").ToString("N2")
                .Total_Refundable_Deposits.Text = Get_Total_Balance("109").ToString("N2")
                .Total_Unused_Office_Supplies.Text = Get_Total_Balance("10706").ToString("N2")
                .Total_Investment_Moto_Brew.Text = Get_Total_Balance("10710").ToString("N2")
                .Total_Acquired_Assets.Text = Get_Total_Balance("106").ToString("N2")

                .Total_Property_Equipment.Text = Get_Total_Balance("105").ToString("N2")
                .Total_Land.Text = Get_Total_Balance("10501").ToString("N2")
                .Total_Building.Text = Get_Total_Balance("10503").ToString("N2")
                .Total_Furniture_Fixtures.Text = Get_Total_Balance("10507").ToString("N2")
                .Total_Office_Equipment.Text = Get_Total_Balance("10511").ToString("N2")
                .Total_Transportation_Equipment.Text = Get_Total_Balance("10506").ToString("N2")
                .Total_Tools_And_Other_Equipment.Text = Get_Total_Balance("10509").ToString("N2")
                .Total_Information_Technology.Text = Get_Total_Balance("10510").ToString("N2")
                .Total_Leasehold_Improvements.Text = Get_Total_Balance("10505").ToString("N2")
                .Total_Shop_Equipment.Text = Get_Total_Balance("10508").ToString("N2")

                .Total_Liabilities.Text = Get_Total_Balance("2").ToString("N2")
                .Total_Loans_Payable.Text = Get_Total_Balance("206").ToString("N2")

                .Total_AP_Traders.Text = Get_Total_Balance("201").ToString("N2")

                .Label_AP_Officers_Employees.Visible = class_Saga_Variables.sCorporation.Equals("SFC")
                .Total_AP_Officers_Employees.Visible = class_Saga_Variables.sCorporation.Equals("SFC")

                .Label_Overage.Visible = class_Saga_Variables.sCorporation.Equals("SFC")
                .Total_Overage.Visible = class_Saga_Variables.sCorporation.Equals("SFC")

                If class_Saga_Variables.sCorporation.Equals("SFC") Then
                    .Total_AP_Officers_Employees.Text = Get_Total_Balance("20916").ToString("N2")
                    .Total_AP_Others.Text = (Get_Total_Balance("205") - Get_Total_Balance("20916")).ToString("N2")

                    .Total_Overage.Text = Get_Total_Balance("20908").ToString("N2")
                Else
                    .Total_AP_Others.Text = Get_Total_Balance("205").ToString("N2")
                End If

                .Total_Retirement_Fund_Payable.Text = Get_Total_Balance("20909").ToString("N2")
                .Total_Dividend_Payable.Text = Get_Total_Balance("20917").ToString("N2")
                .Total_WithHolding_Tax_Payable.Text = Get_Total_Balance("20907").ToString("N2")
                .Total_Output_VAT_Payable.Text = Get_Total_Balance("20915").ToString("N2")
                .Total_Customers_Deposit.Text = Get_Total_Balance("20901").ToString("N2")

                .Total_Unearned_Financing_Income.Text = Get_Total_Balance("208").ToString("N2")

                .Total_Capital.Text = (Get_Total_Balance("3") + (Get_Total_Balance("4") - Get_Total_Balance("5"))).ToString("N2")
                .Total_Subscribed_Capital_Stock.Text = Get_Total_Balance("301").ToString("N2")
                .Total_Retained_Earnings.Text = Get_Total_Balance("302").ToString("N2")

                .Total_Net_Income_Loss.Text = (Get_Total_Balance("4") - Get_Total_Balance("5")).ToString("N2")
                .Total_Liabilities_Capital.Text = (Get_Total_Balance("2") + Convert.ToDecimal(.Total_Capital.Text)).ToString("N2")
            End With

            Dim parameter As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "UPDATE_VAT")
            }
            class_Database.Procedure_Save(class_Database.ICSConnection, parameter, "acc_Balance_Procedures", "Update Input/Output VAT")

            Dim parameter2 As SqlParameter() = {
                New SqlParameter("@Action_Type", "UPDATE_VAT")
            }
            class_Database.Procedure_Bind_Report(class_Database.ICSConnection, parameter2, xRpt, "acc_Balance_Procedures", "acc_Balances")
        End Sub

        Friend Sub preview_Financial_Performance()
            Dim xRpt As New Reports.Accounting.xrpt_Financial_Performance()
            With xRpt
                .XrLabel_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)
                .As_Of_Month.Text = $"For the month ended {class_Saga_Variables.dtEnd:MMMM yyyy}"
                .As_Of_Date.Text = $"{class_Saga_Variables.dtEnd:MMMM dd, yyyy}"

                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300

                .Total_Cash_Sales.Text = Get_Total_Balance("40101").ToString("N2")
                .Total_Installment_Sales.Text = Get_Total_Balance("4010201").ToString("N2")
                .Total_Credit_Sales.Text = Get_Total_Balance("40103").ToString("N2")
                .Total_Sales_Discount.Text = Get_Total_Balance("4010202").ToString("N2")
                .Total_Sales.Text = Get_Total_Balance("401").ToString("N2")

                .Total_Earned_Financing_Income.Text = Get_Total_Balance("404").ToString("N2")
                .Total_Interest_Income_From_Banks.Text = Get_Total_Balance("41002").ToString("N2")
                .Total_Dealers_Incentives.Text = (Get_Total_Balance("405") + Get_Total_Balance("406")).ToString("N2")
                .Total_Shop_Service_Income.Text = Get_Total_Balance("407").ToString("N2")
                .Total_Other_Income.Text = Get_Total_Balance("410").ToString("N2")

                .Total_Income.Text = (Get_Total_Balance("4") - Get_Total_Balance("401")).ToString("N2")

                .Total_Gross_Income.Text = (Convert.ToDecimal(.Total_Sales.Text) + Convert.ToDecimal(.Total_Income.Text)).ToString("N2")
                .Total_Expenses.Text = (Get_Total_Balance("5")).ToString("N2") 'Get_Total_Balance("4")
                .Total_Net_Income.Text = (Get_Total_Balance("4") - Get_Total_Balance("5")).ToString("N2") '(Convert.ToDecimal(.Total_Gross_Income.Text) - Convert.ToDecimal(.Total_Expenses.Text)).ToString("N2")
            End With

            Dim parameterFS As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD_FS_PERFORMANCE")
            }
            class_Database.Procedure_Bind_Report(class_Database.ICSConnection, parameterFS, xRpt, "acc_Balance_Procedures", "acc_Balances")
        End Sub

        Private Function Get_Total_Balance(ByVal sCOACode As String, Optional ByVal bSummaryCode As Boolean = False) As Decimal
            Dim sActionType As String

            If bSummaryCode Then
                sActionType = "GET_BALANCE_SUMMARY"
            Else
                sActionType = "GET_BALANCE_TOTAL"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@COA_Code", sCOACode),
                New SqlParameter("@Action_Type", sActionType)
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Select Case Convert.ToInt32(sCOACode.Substring(0, 1))
                            Case 1, 2, 3
                                Return Convert.ToDecimal(myDataReader("Balance_Sheet"))

                            Case 4, 5
                                Return Convert.ToDecimal(myDataReader("Income_Statement"))
                        End Select
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return 0
        End Function
    End Class

End Namespace