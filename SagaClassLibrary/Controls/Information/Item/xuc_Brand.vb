Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Information.Item

    Public Class xuc_Brand
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Brand(Account_Code, "Account_Code", "Account_Name")
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Brand Profile", "Initialize new Brand Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Brand_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Brand_Code.Text = myDataReader("Brand_Code").ToString
                        Account_Code.EditValue = myDataReader("Supplier_Code").ToString
                        Brand_Name.Text = myDataReader("branddesc").ToString
                        Brand_Description.Text = myDataReader("Brand_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Brand_Code) Then Return False
            If class_Procedures.isEmpty(Brand_Name) Then Return False
            'If class_Procedures.isEmpty(Supplier_Code) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Brand_Code", Brand_Code.EditValue.ToString.Trim.ToUpper),
                New SqlParameter("@Supplier_Code", Account_Code.EditValue),
                New SqlParameter("@Brand_Name", Brand_Name.Text.Trim.ToUpper),
                New SqlParameter("@Brand_Description", Brand_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Brand_Procedures", "Brand Profile", Brand_Name.Text.Trim)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Brand_Procedures", "Delete Color Description", True))
        End Function

        Private Sub Account_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Account_Code.EditValueChanged
            Supplier_Contact.Text = Account_Code.GetColumnValue("Account_Mobile")
            Supplier_Address.Text = Account_Code.GetColumnValue("Account_Address")
        End Sub

    End Class

End Namespace