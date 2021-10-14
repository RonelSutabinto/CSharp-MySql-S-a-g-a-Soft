Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Check
        Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Bank(Bank_Account)
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Check Profile", "Initialize new Check Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            Check_Code.Text = class_Database.Get_ID(class_Database.ICSConnection, "acc_Checks", "CHECK", 5)
            Check_Number.Select()
        End Sub

        Friend Function Control_Ready() As Boolean
            If class_Procedures.isEmpty(Check_Code) Then Return False
            If class_Procedures.isEmpty(Check_Number) Then Return False
            If class_Procedures.isEmpty(Bank_Account) Then Return False
            Return True
        End Function

        Friend Function Control_Retrieve(ByVal sCheckNumber As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Check_Number", sCheckNumber),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Check_Procedures")
                Try
                    Check_Number.Text = sCheckNumber
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Check_Code.Text = myDataReader("Check_Code").ToString
                        Bank_Account.EditValue = myDataReader("Bank_Account").ToString
                        Reference.Text = myDataReader("Reference").ToString
                        Check_Payee.Text = myDataReader("Check_Payee").ToString
                        Check_Amount.Value = convert.todecimal(myDataReader("Check_Amount"))
                        Check_Amount_Words.Text = myDataReader("Check_Amount_Words").ToString
                        Issued_Date.EditValue = myDataReader("Issued_Date")
                        IsCancelled.EditValue = myDataReader("IsCancelled")
                        Check_Description.Text = myDataReader("Check_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    End If
                    Return True
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If Not Control_Ready() Then Return False

            class_Procedures.splash_Show("Saving Check Profile")
            Try
                Using context As New AccEntities
                    'If ID.EditValue.Equals("0") Then
                    If ID.EditValue.Equals(0) Then
                        If Not class_Procedures.actionAsk("Add New Check(s)", $"add {Checks.Value} {Bank_Account.Text} check pages", $"You are adding check numbers {Check_Number.Text.Trim} to {Convert.ToInt32(Check_Number.Text.Trim) + Checks.Value - 1}") Then Return False

                        Dim iID As Integer = class_Database.Get_Last_ID(class_Database.ICSConnection, "acc_Checks")
                            Dim iCheck As Integer = Convert.ToInt32(Check_Number.Text)
                            For i As Integer = 1 To Convert.ToInt32(Checks.Value)
                                iID += 1
                                Dim check As New acc_Checks With {
                                    .Check_Code = $"CHECK{iID}",
                                    .Check_Number = iCheck.ToString,
                                    .Bank_Account = Bank_Account.EditValue.ToString,
                                    .Added_By = class_Variables.sUserName,
                                    .Added_Date = Date.Today
                                }
                                context.acc_Checks.Add(check)
                                iCheck += 1
                            Next
                            context.SaveChanges()
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"New Check Number", "Check Number")
                        Else
                            If Not class_Database.Data_Save_Ask("Check Profile") Then Return False

                        If context.Database.ExecuteSqlCommand($"UPDATE acc_Checks 
                            SET Reference = @Reference,
                                Check_Payee = @Check_Payee,
                                Check_Amount = @Check_Amount,
                                Check_Amount_Words = @Check_Amount_Words,
                                Issued_Date = @Issued_Date,
                                IsCancelled = @IsCancelled,
                                Check_Description = @Check_Description,
                                Notes = @Notes,
                                Modified_By = @Modified_By,
                                Modified_Date = @Modified_Date
                                WHERE Check_Number LIKE '{Check_Number.Text.Trim}'",
                                New SqlParameter("@Reference", Reference.Text.Trim),
                                New SqlParameter("@Check_Payee", Check_Payee.Text.Trim),
                                New SqlParameter("@Check_Amount", Check_Amount.Value),
                                New SqlParameter("@Check_Amount_Words", Check_Amount_Words.Text.Trim),
                                New SqlParameter("@Issued_Date", Issued_Date.EditValue),
                                New SqlParameter("@IsCancelled", IsCancelled.EditValue),
                                New SqlParameter("@Check_Description", Check_Description.Text.Trim),
                                New SqlParameter("@Notes", Notes.Text.Trim),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Modified_Date", DateTime.Now)) > 0 Then
                            context.SaveChanges()
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, $"Check Number", "Check Number")
                        End If
                    End If
                End Using
                Return True
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
            Return False
        End Function

        Friend Function Control_Check_Issue(ByVal sCheckNumber As String, ByVal sPayee As String, ByVal dAmount As Decimal, ByVal bIssued As Boolean, ByVal dtIssued As DateTime, Optional ByVal sDescription As String = "", Optional ByVal sNotes As String = "") As Boolean

            Try
                Using context As New AccEntities
                    If context.Database.ExecuteSqlCommand($"UPDATE acc_Checks 
                        SET Check_Payee = @Check_Payee,
                            Check_Amount = @Check_Amount,
                            Check_Amount_Words = @Check_Amount_Words,
                            IsIssued = @IsIssued,
                            Issued_Date = @Issued_Date,
                            Check_Description = @Check_Description,
                            Notes = @Notes,
                            Modified_By = @Modified_By,
                            Modified_Date = @Modified_Date
                            WHERE Check_Number LIKE '{sCheckNumber.Trim}'",
                            New SqlParameter("@Check_Payee", sPayee.Trim),
                            New SqlParameter("@Check_Amount", dAmount),
                            New SqlParameter("@Check_Amount_Words", class_Functions.AmountToWords(dAmount.ToString)),
                            New SqlParameter("@IsIssued", bIssued),
                            New SqlParameter("@Issued_Date", dtIssued),
                            New SqlParameter("@Check_Description", sDescription.Trim),
                            New SqlParameter("@Notes", sNotes.Trim),
                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                            New SqlParameter("@Modified_Date", DateTime.Now)) > 0 Then
                        context.SaveChanges()
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Update, $"Issue Check Number", "Issue Check Number")
                    End If
                End Using
                Return True
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
            Return False
        End Function

        Friend Function Control_Check_Update(ByVal sCheckNumber As String, ByVal sReference As String, ByVal sPayee As String, ByVal dAmount As Decimal, Optional ByVal sDescription As String = "", Optional ByVal sNotes As String = "") As Boolean

            Try
                Using context As New AccEntities
                    If context.Database.ExecuteSqlCommand($"UPDATE acc_Checks 
                        SET Reference = @Reference,
                            Check_Payee = @Check_Payee,
                            Check_Amount = @Check_Amount,
                            Check_Amount_Words = @Check_Amount_Words,
                            Check_Description = @Check_Description,
                            Notes = @Notes,
                            Modified_By = @Modified_By,
                            Modified_Date = @Modified_Date
                            WHERE Check_Number LIKE '{sCheckNumber.Trim}'",
                            New SqlParameter("@Reference", sReference.Trim),
                            New SqlParameter("@Check_Payee", sPayee.Trim),
                            New SqlParameter("@Check_Amount", dAmount),
                            New SqlParameter("@Check_Amount_Words", class_Functions.AmountToWords(dAmount.ToString)),
                            New SqlParameter("@Check_Description", sDescription.Trim),
                            New SqlParameter("@Notes", sNotes.Trim),
                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                            New SqlParameter("@Modified_Date", DateTime.Now)) > 0 Then
                        context.SaveChanges()
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Update, $"Update Check Number", "Update Check Number")
                    End If
                End Using
                Return True
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
            Return False
        End Function

        Friend Function Control_Check_Cancel() As Boolean

            If Control_Ready() AndAlso class_Procedures.actionAsk("Check Cancellation", "Cancel this Check", "You might cancel the wrong check", "You can still UNDO this operation by update") Then
                Reference.Text = "CANCELLED"
                IsCancelled.EditValue = True
                Try
                    Using context As New AccEntities
                        If context.Database.ExecuteSqlCommand($"UPDATE acc_Checks 
                            SET Reference = @Reference,
                                IsIssued = @IsIssued,
                                IsCancelled = @IsCancelled,
                                Check_Description = @Check_Description,
                                Modified_By = @Modified_By,
                                Modified_Date = @Modified_Date
                                WHERE Check_Number LIKE '{Check_Number.Text.Trim}'",
                                New SqlParameter("@Reference", Reference.Text.Trim),
                                New SqlParameter("@IsIssued", 0),
                                New SqlParameter("@IsCancelled", 1),
                                New SqlParameter("@Check_Description", class_Functions.Show_Input_Box("Input reason to cancel", "Description", Check_Description.Text).Trim),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Modified_Date", DateTime.Now)) > 0 Then
                            context.SaveChanges()
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, $"Cancel Check Number", "Cancel Check Number")
                        End If
                    End Using
                    Return True
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                Finally
                    class_Procedures.splash_Close()
                End Try
            End If
            Return False
        End Function

        Private Sub Check_Payee_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Check_Payee.KeyDown
            Select Case e.KeyValue
                Case Keys.F4
                    Check_Payee.ShowPopup()
            End Select
        End Sub

        Private Sub Check_Payee_BeforePopup(sender As Object, e As EventArgs) Handles Check_Payee.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Check_Payee_Popup(sender As Object, e As EventArgs) Handles Check_Payee.Popup
            xuc_Account_Search.searchMode = Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            xuc_Account_Search.Load_Search(Check_Payee.Text)
        End Sub

        Private Sub Check_Payee_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Check_Payee.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Get_Searched_Name()
        End Sub

        Private Sub Get_Searched_Name()
            Check_Payee.Text = xuc_Account_Search.AccountName
            Check_Payee.Select()
        End Sub

        Private Sub Check_Amount_EditValueChanged(sender As Object, e As EventArgs) Handles Check_Amount.EditValueChanged
            Check_Amount_Words.Text = class_Functions.AmountToWords(Check_Amount.Value)
        End Sub

    End Class

End Namespace