Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Management

    Public Class xuc_Branch
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Employee(Branch_Manager)
            class_Saga_Procedures.Initialize_Employee(Branch_Admin)

            Branch_Code.ReadOnly = False
            Pre_Code.ReadOnly = False
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bask AndAlso Not class_Procedures.actionAsk("New Branch Profile", "Initialize new Branch Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)

            Branch_Code.ReadOnly = False
            Pre_Code.ReadOnly = False

            Branch_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Agent_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Branch_Code.Text = myDataReader("@Branch_Code").ToString
                        Pre_Code.Text = myDataReader("@Pre_Code").ToString
                        Branch_Name.Text = myDataReader("@Branch").ToString
                        Branch_Local.Text = myDataReader("@Branch_Local").ToString
                        Branch_Address.Text = myDataReader("@Address").ToString
                        Branch_Area.SelectedIndex = Convert.ToInt32(myDataReader("@Branch_Area"))
                        Branch_Manager.EditValue = myDataReader("@Branch_Manager").ToString
                        Branch_Admin.EditValue = myDataReader("@Branch_Admin").ToString
                        LTO_Payable.Value = convert.todecimal(myDataReader("@LTO_Payable"))
                        Insurance.Value = convert.todecimal(myDataReader("@Insurance"))
                        Notarial_Fee.Value = convert.todecimal(myDataReader("@Notarial_Fee"))
                        Petty_Cash_Budget.Value = convert.todecimal(myDataReader("@Petty_Cash_Budget"))
                        Petty_Cash_Replenish.Value = convert.todecimal(myDataReader("@Petty_Cash_Replenish"))
                        CTC_Number.Text = myDataReader("@CTC_Number").ToString
                        CTC_Date.EditValue = Convert.ToDateTime(myDataReader("@CTC_Date"))
                        CTC_Place.Text = myDataReader("@CTC_Place").ToString
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

            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Pre_Code) Then Return False
            If class_Procedures.isEmpty(Branch_Name) Then Return False
            If class_Procedures.isEmpty(Branch_Address) Then Return False
            If class_Procedures.isEmpty(Branch_Local) Then Return False
            If class_Procedures.isEmpty(Branch_Area) Then Return False
            If class_Procedures.isEmpty(Branch_Manager) Then Return False

            Dim iArea As Integer
            Try
                iArea = Convert.ToInt32(Branch_Area.EditValue.ToString.Substring(5))
            Catch ex As Exception
                iArea = 0
            End Try

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Branch_Code", Branch_Code.Text.Trim),
                New SqlParameter("@Pre_Code", Pre_Code.Text.Trim.ToUpper),
                New SqlParameter("@Branch", Branch_Name.Text.Trim.ToUpper),
                New SqlParameter("@Branch_Local", Branch_Local.Text.Trim.ToUpper),
                New SqlParameter("@Address", Branch_Address.Text.Trim),
                New SqlParameter("@Branch_Area", iArea),
                New SqlParameter("@Branch_Manager", Branch_Manager.EditValue),
                New SqlParameter("@Branch_Admin", Branch_Admin.EditValue),
                New SqlParameter("@LTO_Payable", LTO_Payable.Value),
                New SqlParameter("@Insurance", Insurance.Value),
                New SqlParameter("@Notarial_Fee", Notarial_Fee.Value),
                New SqlParameter("@Petty_Cash_Budget", Petty_Cash_Budget.Value),
                New SqlParameter("@Petty_Cash_Replenish", Petty_Cash_Replenish.Value),
                New SqlParameter("@CTC_Number", CTC_Number.Text.Trim),
                New SqlParameter("@CTC_Date", CTC_Date.EditValue),
                New SqlParameter("@CTC_Place", CTC_Place.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Branch_Procedures", "Branch Profile", Branch_Name.Text.Trim)
        End Function

    End Class

End Namespace