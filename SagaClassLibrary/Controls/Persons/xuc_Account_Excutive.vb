Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Persons

    Public Class xuc_Account_Executive
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Saga_Procedures.Initialize_Employee(AE_Name)

            'class_Saga_Variables.Initialize_Engine_TEQ()
            class_Saga_Procedures.Initialize_Engine_Chassis(Engine)
            AE_Code.ReadOnly = False
            AE_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As Integer) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_AE_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        AE_Code.EditValue = myDataReader("AccountExecutive").ToString
                        Branch_Code.EditValue = myDataReader("BranchCode").ToString
                        AE_Name.Text = myDataReader("OfficerName").ToString
                        Engine.Text = myDataReader("Engine").ToString
                        Chassis.Text = myDataReader("Chassis").ToString
                        Plate_Number.Text = myDataReader("Plate_Number").ToString
                        CTC_Number.Text = myDataReader("CTC_Number").ToString
                        CTC_Date.Text = myDataReader("CTC_Date").ToString
                        CTC_Place.Text = myDataReader("CTC_Place").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Account Executive Profile", "Initialize new Account Executive Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            AE_Code.Select()
        End Sub

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(AE_Code) Then Return False
            If class_Procedures.isEmpty(AE_Name) Then Return False
            If class_Procedures.isEmpty(CTC_Number) Then Return False
            If class_Procedures.isEmpty(CTC_Place) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@AE_Code", AE_Code.Text),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@AE_Name", AE_Name.Text.Trim),
                New SqlParameter("@Engine", Engine.EditValue.ToString),
                New SqlParameter("@Chassis", Chassis.Text.Trim),
                New SqlParameter("@Plate_Number", Plate_Number.Text.Trim),
                New SqlParameter("@CTC_Number", CTC_Number.Text.Trim),
                New SqlParameter("@CTC_Date", CTC_Date.EditValue),
                New SqlParameter("@CTC_Place", CTC_Place.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_AE_Procedures", "Account Executive Profile", AE_Name.Text.Trim) Then
                Dim iID As Integer = Engine.GetColumnValue("id")
                Dim sEmployeeCode As String = AE_Name.GetColumnValue("Employee_Code")

                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET AccountNumber = '{sEmployeeCode}', AccountName = '{AE_Name.Text}' WHERE id LIKE '{iID}'")
                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Employees SET Engine = '{Engine.EditValue}' WHERE Employee_Code LIKE '{sEmployeeCode}'")

                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Account Executive Profile")
                Return True
            Else
                Return False
            End If
        End Function

        Friend Function Control_Delete() As Boolean
            Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM AccountExecutives WHERE AccountExecutive LIKE '{AE_Code.Text}'", $"Account Executive :{AE_Name.Text}")
        End Function

        Private Sub Engine_EditValueChanged(sender As Object, e As EventArgs) Handles Engine.EditValueChanged
            Chassis.Text = Engine.GetColumnValue("ChassisNo")
        End Sub

    End Class

End Namespace