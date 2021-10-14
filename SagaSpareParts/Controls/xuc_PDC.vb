Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class xuc_PDC
    Public Sub New()
        InitializeComponent()
    End Sub
    Friend Sub Control_Initialize()

    End Sub
    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Post Dated Check", "Initialize new Post Dated Check", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        PDC_Id.Text = "0"
        Bank_Name.Select()
    End Sub
    Friend Function Control_Retrieve(ByVal sID As String) As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", PDC_Id.Text),
                                            New SqlParameter("@Action_Type", "RETRIEVE")}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures")
            PDC_Id.Text = sID
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Try
                    myDataReader.Read()
                    Bank_Name.Text = myDataReader("Bank_Name").ToString
                    Customer_Name.Text = myDataReader("Customer_Name").ToString
                    Customer_Address.Text = myDataReader("Customer_Address").ToString
                    Check_No.EditValue = myDataReader("Check_No").ToString
                    Amount.EditValue = myDataReader("Amount")
                    Due_Date.EditValue = CDate(myDataReader("Due_Date"))
                    SBD_Amount_Due.EditValue = myDataReader("SBD_Amount_Due").ToString
                    SBD_Mat_Date.EditValue = CDate(myDataReader("SBD_Maturity_Date"))
                    PDC_Description.EditValue = myDataReader("PDC_Description").ToString
                    Return True
                Catch ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                End Try
            End If
        End Using
        Return False
    End Function

    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(Bank_Name) Then Return False
        If class_Procedures.isEmpty(Amount) Then Return False

        ' Dim sOrderCode() As String = Order_Code.Text.Trim.Split("-")
        Dim sNotes As String = String.Empty
        'If sOrderCode.Length > 5 Then
        '    'If class_Procedures.isEmpty(Notes) Then Return False
        '    sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        'End If

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@PDC_Id", PDC_Id.Text),
                                            New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                                            New SqlParameter("@Bank_Name", Bank_Name.Text.ToString.ToUpper),
                                            New SqlParameter("@Customer_Name", Customer_Name.EditValue),
                                            New SqlParameter("@Customer_Address", Customer_Address.EditValue),
                                            New SqlParameter("@Check_No", Check_No.EditValue),
                                            New SqlParameter("@Amount", Amount.EditValue),
                                            New SqlParameter("@Due_Date", Due_Date.EditValue),
                                            New SqlParameter("@SBD_Amount_Due", SBD_Amount_Due.EditValue),
                                            New SqlParameter("@SBD_Maturity_Date", SBD_Mat_Date.EditValue),
                                            New SqlParameter("@PDC_Description", PDC_Description.Text.Trim),
                                            New SqlParameter("@PDC_Remarks", Remarks.Text.Trim),
                                            New SqlParameter("@Added_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "SAVE_ITEM")}

        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Post_Dated_Check_Procedures", "POST DATED CHECK", Bank_Name.Text)
    End Function
End Class
