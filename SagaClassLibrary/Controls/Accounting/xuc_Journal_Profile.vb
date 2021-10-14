Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Accounting

    Public Class xuc_Journal_Profile
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Corporation(Profile_Corporation, True)
            class_Saga_Procedures.Initialize_COA(COA_Code, eCOA_Type.COA_All)
            class_Database.Fill_Edit(class_Database.ICSConnection, Payment_Code, "AccountCodes", "Mnemonic")
            class_Database.Fill_Edit(class_Database.ICSConnection, Journal_Type, "acc_Journal_Entries", "Journal_Type")
            class_Database.Fill_Edit(class_Database.ICSConnection, Profile_Name, "acc_Journal_Entries", "Journal_Profile")
            Payment_Code.ReadOnly = False
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Journal Profile", "Initialize new Journal Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Profile_Code, "acc_Journal_Profiles", "Profile_Code", "PROFILE-")
            Payment_Code.ReadOnly = False
            Profile_Corporation.Select()
        End Sub

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Payment_Code) Then Return False
            If class_Procedures.isEmpty(Profile_Corporation) Then Return False
            If class_Procedures.isEmpty(Journal_Type) Then Return False
            If class_Procedures.isEmpty(Profile_Name) Then Return False
            If class_Procedures.isEmpty(Friendly_Name) Then Return False
            If class_Procedures.isEmpty(COA_Code) Then Return False
            If class_Procedures.isEmpty(Balance_Type) Then Return False

            Try
                If ID.EditValue.Equals("0") Then
                    class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Profile_Code, "inv_MC_Requests", "Profile_Code", "PROFILE-")
                End If

                Dim sqlParameters = New SqlParameter() {
                    New SqlParameter("@ID", ID.EditValue),
                    New SqlParameter("@Profile_Code", Profile_Code.EditValue),
                    New SqlParameter("@Payment_Code", Payment_Code.Text.Trim.ToUpper),
                    New SqlParameter("@Profile_Corporation", Profile_Corporation.EditValue),
                    New SqlParameter("@Profile_Type", Profile_Type.Text),
                    New SqlParameter("@Journal_Type", Journal_Type.Text.Trim.ToUpper),
                    New SqlParameter("@Profile_Name", Profile_Name.Text.Trim.ToUpper),
                    New SqlParameter("@Friendly_Name", Friendly_Name.Text.Trim.ToUpper),
                    New SqlParameter("@COA_Code", COA_Code.EditValue),
                    New SqlParameter("@Custom_COA", Convert.ToBoolean(Custom_COA.EditValue)),
                    New SqlParameter("@Profile_VAT", Convert.ToBoolean(Profile_VAT.EditValue)),
                    New SqlParameter("@Profile_Description", Profile_Description.Text.Trim),
                    New SqlParameter("@Balance_Type", Balance_Type.Text),
                    New SqlParameter("@Notes", Notes.Text.Trim),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SAVE")
                }

                Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Profile_Procedures", "Journal Profile", Friendly_Name.Text)
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            End Try
        End Function

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM acc_Journal_Profiles WHERE Profile_Code LIKE '{sCode}' OR Profile_Name LIKE '{sCode}'")
                Profile_Name.Text = sCode
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Profile_Corporation.EditValue = myDataReader("Profile_Corporation").ToString
                        Profile_Code.Text = myDataReader("Profile_Code").ToString
                        Profile_Type.Text = myDataReader("Profile_Type").ToString
                        Friendly_Name.Text = myDataReader("Friendly_Name").ToString
                        Payment_Code.Text = myDataReader("Payment_Code").ToString
                        Journal_Type.Text = myDataReader("Journal_Type").ToString
                        Balance_Type.Text = myDataReader("Balance_Type").ToString
                        Profile_Description.Text = myDataReader("Profile_Description").ToString
                        COA_Code.EditValue = myDataReader("COA_Code").ToString
                        Custom_COA.EditValue = Convert.ToBoolean(myDataReader("Custom_COA"))
                        Profile_VAT.EditValue = Convert.ToBoolean(myDataReader("Profile_VAT"))
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Private Sub Payment_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Payment_Code.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If Payment_Code.EditValue.ToString.Length > 0 Then
                        Dim sPaymentCodeNew As String = class_Functions.Show_Input_Box("Input New Payment Code", "New Payment Code", Payment_Code.Text.Trim).ToUpper
                        If class_Procedures.actionAsk("Update Transaction Code", "udpate Transaction Code") Then
                            If sPaymentCodeNew.Length > 0 AndAlso class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_profiles SET Payment_Code = '{sPaymentCodeNew}' WHERE Payment_Code LIKE '{Payment_Code.Text.Trim}'", True) Then
                                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionPettyCash SET ExpDetailsMnemonic = '{sPaymentCodeNew}' WHERE ExpDetailsMnemonic LIKE '{Payment_Code.Text.Trim}'", True)
                            End If
                        End If
                    End If
            End Select
        End Sub

        'Friend Function Control_Delete() As Boolean
        '    Return class_Database.Data_Delete_Ask(class_database.ICSConnection, $"FROM acc_Journal_Profiles WHERE Profile_Name LIKE '{Profile_Name.Text}'", $"Journal Profile {Profile_Name.Text}")
        'End Function
    End Class

End Namespace