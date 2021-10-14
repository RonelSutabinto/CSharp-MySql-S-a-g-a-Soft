Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Accounting

    Public Class xuc_Budget

        Friend Sub Control_Initialize()
            'Budget_Code.Text = class_Database.Get_ID(class_Database.ICSConnection, "acc_Budgets", "Budget", 3)
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Budget Profile", "Initialize new Budget Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            Budget_Amount.ReadOnly = False
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Budget_Code, "acc_Budgets", "Budget_Code", "BUDGET-")
            Budget_Name.Select()
        End Sub

        Friend Function Control_Ready() As Boolean
            If class_Procedures.isEmpty(Budget_Code) Then Return False
            If class_Procedures.isEmpty(Budget_Name) Then Return False
            If class_Procedures.isEmpty(Budget_Amount) Then Return False
            Return True
        End Function

        Friend Function Control_Save() As Boolean
            If Not Control_Ready() Or Not class_Database.Data_Save_Ask("Budget Profile") Then Return False
            class_Procedures.splash_Show("Saving Budget Profile")
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@ID", ID.EditValue),
                    New SqlParameter("@Budget_Code", Budget_Code.Text.ToUpper),
                    New SqlParameter("@Budget_Name", Budget_Name.EditValue),
                    New SqlParameter("@Budget_Amount", Budget_Amount.Value),
                    New SqlParameter("@Budget_Description", Budget_Description.EditValue),
                    New SqlParameter("@Notes", Notes.Text),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SAVE")
                }

                If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Budget_Procedures", "Budget Profile", Budget_Name.Text) Then
                    'class_Saga_Variables.Initialize_Budgets()
                    Return True
                End If
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
            Return False
        End Function

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM acc_Budgets WHERE ID LIKE '{sID}'")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Budget_Code.Text = myDataReader("Budget_Code").ToString
                        Budget_Name.Text = myDataReader("Budget_Name").ToString
                        Budget_Amount.EditValue = convert.todecimal(myDataReader("Budget_Amount"))
                        Budget_Description.Text = myDataReader("Budget_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Add_Debit(ByVal sBudgetCode As String, ByVal dDebit As Decimal, ByVal sDescription As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", 0),
                New SqlParameter("@Budget_Code", sBudgetCode),
                New SqlParameter("@Budget_Debit", dDebit),
                New SqlParameter("@Ledger_Description", sDescription),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "ADD_DEBIT")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Budget_Procedures", "Add Debit Ledger", sBudgetCode)
        End Function

        Friend Function Add_Credit(ByVal sBudgetCode As String, ByVal sVoucherCode As String, ByVal sVoucherReference As String, ByVal sDescription As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", 0),
                New SqlParameter("@Budget_Code", sBudgetCode),
                New SqlParameter("@Voucher_Code", sVoucherCode),
                New SqlParameter("@Voucher_Reference", sVoucherReference),
                New SqlParameter("@Ledger_Description", sDescription),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "ADD_CREDIT")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Budget_Procedures", "Add Credit Ledger", sBudgetCode)
        End Function

    End Class

End Namespace