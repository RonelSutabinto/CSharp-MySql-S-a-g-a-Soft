Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Persons

    Public Class xuc_Customer
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Database.Fill_Edit(class_Database.ICSConnection, Marital_Status, "CIFAccounts", "MStatus")
            class_Database.Fill_Edit(class_Database.ICSConnection, Customer_Occupation, "CIFAccounts", "Occupation")
            class_Database.Fill_Edit(class_Database.ICSConnection, Customer_Business_Name, "CIFAccounts", "BusinessName")
            class_Database.Fill_Edit(class_Database.ICSConnection, Spouse_Occupation, "CIFAccounts", "SpouseOccupation")
            Customer_Name.Select()
        End Sub

        Public Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Customer Profile", "Initialize new Customer Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Customer_Code, "CIFAccounts", "CIFKey", "CUSTOMER-", "SeqID")
            Customer_Name.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                 New SqlParameter("@Customer_Code", sCode),
                 New SqlParameter("@Action_Type", "RETRIEVE")
             }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_Customer_Procedures")
                Try
                    Customer_Code.Text = sCode
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Customer_Code.Text = sCode
                        ID.EditValue = myDataReader("SeqID").ToString
                        Branch_Code.EditValue = myDataReader("BranchCode").ToString
                        Customer_Name.Text = myDataReader("fullname").ToString
                        Customer_Address.Text = myDataReader("Address").ToString
                        Customer_Birth_Date.EditValue = Convert.ToDateTime(myDataReader("Bday"))
                        Gender.Text = myDataReader("Gender").ToString
                        Marital_Status.Text = myDataReader("MStatus").ToString
                        Contact_Number.Text = myDataReader("ContactNumber").ToString
                        Customer_Occupation.Text = myDataReader("Occupation").ToString
                        Customer_Business_Name.Text = myDataReader("BusinessName").ToString
                        Customer_Business_Address.Text = myDataReader("BusAddress").ToString
                        Spouse_Name.Text = myDataReader("SpouseFName").ToString
                        Spouse_Birth_Date.EditValue = Convert.ToDateTime(myDataReader("SpouseBday"))
                        Spouse_Occupation.Text = myDataReader("SpouseOccupation").ToString
                        Spouse_Address.Text = myDataReader("SpouseOccupAddress").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Customer_Name.Select()
                        Return True
                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Customer_Code) Then Return False
            If class_Procedures.isEmpty(Customer_Name) Then Return False
            If class_Procedures.isEmpty(Customer_Address) Then Return False
            If class_Procedures.isEmpty(Gender) Then Return False

            If ID.EditValue.Equals(0) Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Customer_Code, "CIFAccounts", "CIFKey", "CUSTOMER-", "SeqID")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Customer_Code", Customer_Code.Text),
                New SqlParameter("@Customer_Name", Customer_Name.Text.Trim.ToUpper),
                New SqlParameter("@Customer_Address", Customer_Address.Text.Trim.ToUpper),
                New SqlParameter("@Gender", Gender.Text.Trim.ToUpper),
                New SqlParameter("@Marital_Status", Marital_Status.Text.Trim.ToUpper),
                New SqlParameter("@Customer_Birth_Date", Customer_Birth_Date.EditValue),
                New SqlParameter("@Customer_Contact_Number", Contact_Number.EditValue),
                New SqlParameter("@Customer_Occupation", Customer_Occupation.Text.Trim.ToUpper),
                New SqlParameter("@Business_Name", Customer_Business_Name.Text.Trim.ToUpper),
                New SqlParameter("@Business_Address", Customer_Business_Address.Text.Trim.ToUpper),
                New SqlParameter("@Spouse_Name", Spouse_Name.Text.Trim.ToUpper),
                New SqlParameter("@Spouse_Contact_Number", Spouse_Contact_Number.EditValue),
                New SqlParameter("@Spouse_Birth_Date", Spouse_Birth_Date.EditValue),
                New SqlParameter("@Spouse_Occupation", Spouse_Occupation.Text.Trim.ToUpper),
                New SqlParameter("@Spouse_Occupation_Address", Spouse_Address.Text.Trim.ToUpper),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Customer_Procedures", "Customer Profile", Customer_Code.Text)
        End Function

        Friend Function Control_Delete() As Boolean
            Return False 'class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM CIFAccounts WHERE SeqID LIKE '{ID.EditValue}'", $"Customer CIF: {Customer_Name.Text}")
        End Function

        Private Sub Customer_Occupation_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Customer_Occupation.ButtonClick
            If e.Button.Index.Equals(1) Then
                Dim sNewOccupation As String = class_Functions.Show_Input_Box("Input New Occupation", "New Occupation", Customer_Occupation.Text.Trim)
                class_Database.Data_Replace(class_Database.ICSConnection, "Update Customer Occupation", "CIFAccounts", "Occupation", Customer_Occupation.Text, sNewOccupation.Trim.ToUpper)
            End If
        End Sub

        Private Sub Customer_Business_Name_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Customer_Business_Name.ButtonClick
            If e.Button.Index.Equals(1) Then
                Dim sNewBusiness As String = class_Functions.Show_Input_Box("Input New Business Name", "New Business Name", Customer_Business_Name.Text.Trim)
                class_Database.Data_Replace(class_Database.ICSConnection, "Update Business Name", "CIFAccounts", "BusinessName", Customer_Business_Name.Text, sNewBusiness.Trim.ToUpper)
            End If
        End Sub

        Private Sub Spouse_Occupation_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Spouse_Occupation.ButtonClick
            If e.Button.Index.Equals(1) Then
                Dim sNewSpouseOccupation As String = class_Functions.Show_Input_Box("Input New Spouse Occupation", "New Spouse Occupation", Spouse_Occupation.Text.Trim)
                class_Database.Data_Replace(class_Database.ICSConnection, "Update Spouse Occupation", "CIFAccounts", "SpouseOccupation", Spouse_Occupation.Text, sNewSpouseOccupation.Trim.ToUpper)
            End If
        End Sub
    End Class

End Namespace