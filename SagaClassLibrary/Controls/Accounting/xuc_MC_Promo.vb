Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Accounting
    Public Class xuc_MC_Promo
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Control_Initialize()
            class_Saga_Procedures.Initialize_COA(COA_Code, eCOA_Type.COA_All)
            class_Database.Fill_Edit(class_Database.ICSConnection, Promo_Type, "acc_MC_Promotions", "Promo_Type")
            class_Database.Fill_Edit(class_Database.ICSConnection, Brand, "acc_MC_Promotions", "Brand")
            Promo_Code.Select()
        End Sub

        Public Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Promo Profile", "Initialize new Promo Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Promo_Code, "acc_MC_Promotions", "Promo_Code", "PROMO-")
            Promo_Type.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Promotion_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Promo_Code.Text = myDataReader("Promo_Code").ToString
                        Promo_Type.Text = myDataReader("Promo_Type").ToString
                        Brand.Text = myDataReader("Brand").ToString
                        COA_Code.EditValue = myDataReader("COA_Code").ToString
                        Promo_Start.EditValue = Convert.ToDateTime(myDataReader("Promo_Start"))
                        Promo_End.EditValue = Convert.ToDateTime(myDataReader("Promo_End"))
                        Discount.Value = convert.todecimal(myDataReader("Discount"))
                        Promo_Name.Text = myDataReader("Promo_Name").ToString
                        Promo_Description.Text = myDataReader("Promo_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Promo_Code) Then Return False
            If class_Procedures.isEmpty(Promo_Type) Then Return False
            If class_Procedures.isEmpty(Discount) Then Return False
            If class_Procedures.isEmpty(Promo_Name) Then Return False

            If ID.EditValue.Equals(0) Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Promo_Code, "acc_MC_Promotions", "Promo_Code", "PROMO-")
            End If

            Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", ID.EditValue),
            New SqlParameter("@Promo_Code", Promo_Code.Text),
            New SqlParameter("@Promo_Type", Promo_Type.Text.Trim),
            New SqlParameter("@Brand", Brand.Text.Trim),
            New SqlParameter("@COA_Code", COA_Code.EditValue),
            New SqlParameter("@Promo_Start", Promo_Start.EditValue),
            New SqlParameter("@Promo_End", Promo_End.EditValue),
            New SqlParameter("@Discount", Discount.EditValue),
            New SqlParameter("@Promo_Name", Promo_Name.Text.Trim),
            New SqlParameter("@Promo_Description", Promo_Description.Text.Trim),
            New SqlParameter("@Notes", Notes.Text.Trim),
            New SqlParameter("@Added_By", class_Variables.sUserName),
            New SqlParameter("@Modified_By", class_Variables.sUserName),
            New SqlParameter("@Action_Type", "SAVE")
        }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Promotion_Procedures", "MC Promo Profile", Promo_Name.Text.Trim)
        End Function

        Private Sub COA_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles COA_Code.ButtonClick
            If e.Button.Index.Equals(1) Then
                COA_Code.EditValue = String.Empty
            End If
        End Sub

        'Friend Function Control_Delete() As Boolean
        '    Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM Promo WHERE PromoCode LIKE '{Promo_Code.Text}'", $"Promo Profile: {Promo_Name.Text}")
        'End Function
    End Class
End Namespace