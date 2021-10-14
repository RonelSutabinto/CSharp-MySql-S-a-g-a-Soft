Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Xuc_Spare_Parts_Purchase_Order

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()

        class_Saga_Procedures.Initialize_Brand(Brand_Code)
        Brand_Code.Select()
    End Sub

    Friend Sub Control_New(Optional ByVal bClear As Boolean = False)
        '
        'If bClear AndAlso Not class_Procedures.actionAsk("New Purchase Order", "Initialize new Purchase Order", "You might lose unsaved data") Then Return
        'class_Procedures.Initialize_Controls(Me, bClear)
        'ID.Text = "0"
        'Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "acc_Purchase_Orders", "id", "Order_Code", "PO-")
        'Brand_Code.Select()
    End Sub

    Friend Function Control_Retrieve(ByVal sID As String) As Boolean

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "RETRIEVE")}

        Using MyDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, "acc_Purchase_Order_Procedures", Parameters)
            ID.Text = sID
            If MyDataReader IsNot Nothing AndAlso MyDataReader.HasRows Then
                Try
                    MyDataReader.Read()
                    Order_Code.Text = MyDataReader("Order_Code").ToString
                    Brand_Code.Text = MyDataReader("Brand_Code").ToString
                    Order_Date.EditValue = CDate(MyDataReader("Order_Date"))
                    Description.Text = MyDataReader("Order_Description").ToString
                    Notes.Text = MyDataReader("Notes").ToString
                    Return True
                Catch Ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                End Try
            End If
        End Using
        Return False
    End Function

    Friend Function Control_Save() As Boolean

        If class_Procedures.isEmpty(Order_Code) Then Return False
        If class_Procedures.isEmpty(Brand_Code) Then Return False

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Order_Code", Order_Code.Text),
                                            New SqlParameter("@Brand_Code", Brand_Code.EditValue),
                                            New SqlParameter("@Supplier_Code", Brand_Code.GetColumnValue("Account_Code")),
                                            New SqlParameter("@Order_Date", Order_Date.EditValue),
                                            New SqlParameter("@Order_Description", Description.Text.Trim),
                                            New SqlParameter("@Notes", Notes.Text.Trim),
                                            New SqlParameter("@Added_By", class_Variables.sUserName),
                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "SAVE")}

        Return class_Database.Procedure_Save(class_Database.ICSConnection, "Purchase Order", "acc_Purchase_Order_Procedures", Parameters, Order_Code.Text)
    End Function

    Friend Function Control_Delete() As Boolean

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "DELETE")}

        Return CBool(class_Database.Procedure_Execute(class_Database.ICSConnection, "Delete Purchase Order", "acc_Purchase_Order_Procedures", Parameters, True))
    End Function

    Private Sub Brand_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Brand_Code.EditValueChanged
        If Not Brand_Code.EditValue Is Nothing Then
            Supplier_Name.Text = Brand_Code.GetColumnValue("Account_Name")
        End If
    End Sub

End Class