Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Accounting
    Public Class xuc_Payment_Request
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Database.Fill_Edit(class_Database.ICSConnection, Request_Type, "acc_Payment_Requests", "Request_Type")
            Request_Code.Select()
        End Sub

        Public Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Request Profile", "Initialize new Request Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "acc_Payment_Requests", "Request_Code", "PAY-REQUEST-")
            Request_Type.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Payment_Request_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Request_Code.Text = myDataReader("Request_Code").ToString
                        Branch_Code.EditValue = myDataReader("Branch_Code").ToString
                        Request_Type.Text = myDataReader("Request_Type").ToString
                        Request_Date.EditValue = convert.todatetime(myDataReader("Request_Date"))
                        Request_Amount.EditValue = convert.todecimal(myDataReader("Request_Amount"))
                        Payee_Name.Text = myDataReader("Payee_Name").ToString
                        Payee_Address.Text = myDataReader("Payee_Address").ToString
                        Request_Description.Text = myDataReader("Request_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function


        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Request_Code) Then Return False
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Payee_Name) Then Return False

            If ID.EditValue.Equals(0) Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "acc_Payment_Requests", "Request_Code", "PAY-REQUEST-")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Request_Code", Request_Code.Text.Trim),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Request_Type", Request_Type.Text.Trim),
                New SqlParameter("@Request_Date", Request_Date.EditValue),
                New SqlParameter("@Request_Amount", Request_Amount.EditValue),
                New SqlParameter("@Payee_Name", Payee_Name.Text.Trim),
                New SqlParameter("@Payee_Address", Payee_Address.Text.Trim),
                New SqlParameter("@Request_Description", Request_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Payment_Request_Procedures", "Payment Request", Payee_Name.Text.Trim)
        End Function

        'Friend Function Control_Delete() As Boolean
        '    Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM Request WHERE RequestCode LIKE '{Request_Code.Text}'", $"Request Profile: {Payee_Name.Text}")
        'End Function

        Private Sub Payee_Name_BeforePopup(sender As Object, e As EventArgs) Handles Payee_Name.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Payee_Name_Popup(sender As Object, e As EventArgs) Handles Payee_Name.Popup
            xuc_Account_Search.searchMode = Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search.Load_Search(Payee_Name.Text.Trim)
        End Sub

        Private Sub Payee_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Payee_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Payee_Name.Text = xuc_Account_Search.Code
            Payee_Name.Text = xuc_Account_Search.AccountName
            Payee_Name.Select()
        End Sub
    End Class
End Namespace