Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Public Class Xuc_SPA_Purchase_Orders
    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()
        class_Saga_Variables.Initialize_Brands()
        class_Saga_Procedures.Initialize_Brand(Brand)
        Brand.Select()
    End Sub

    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Purchase Order", "Initialize new Purchase Order", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        ID.Text = "0"
        If Not class_Procedures.isEmpty(Brand) Then
            If bOrderModify Then
                Dim sOrderCode() As String = Order_Code.Text.Split("-")
                Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{sOrderCode(0)}-{sOrderCode(1)}-{sOrderCode(2)}-")
            Else
                Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{class_Saga_Variables.sBranchCode}{Brand.Text.Trim}-", 2)
            End If
            Order_Date.Select()
        Else
            Brand.Select()
        End If
    End Sub

    Friend Function Control_Retrieve(ByVal sID As String) As Boolean

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "RETRIEVE")}

        Using MyDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, "op_Spare_Parts_Purchase_Order_Procedures", Parameters)
            ID.Text = sID
            If MyDataReader IsNot Nothing AndAlso MyDataReader.HasRows Then
                Try
                    MyDataReader.Read()
                    Order_Code.Text = MyDataReader("Order_Code").ToString
                    Brand.Text = MyDataReader("Brand_Name").ToString
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
        If class_Procedures.isEmpty(Brand) Then Return False

        Dim sOrderCode() As String = Order_Code.Text.Trim.Split("-")
        Dim sNotes As String = String.Empty
        If sOrderCode.Length > 3 Then
            'If class_Procedures.isEmpty(Notes) Then Return False
            sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        End If

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Order_Code", Order_Code.Text),
                                            New SqlParameter("@Brand_Name", Brand.EditValue),
                                            New SqlParameter("@Supplier_Name", Brand.GetColumnValue("Account_Code")),
                                            New SqlParameter("@Order_Date", Order_Date.EditValue),
                                            New SqlParameter("@Order_Description", Description.Text.Trim),
                                            New SqlParameter("@Notes", sNotes),
                                            New SqlParameter("@Added_By", class_Variables.sUserName),
                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "SAVE")}

        Return class_Database.Procedure_Save(class_Database.ICSConnection, "Purchase Order", "op_Spare_Parts_Purchase_Order_Procedures", Parameters, Order_Code.Text)
    End Function

    Friend Function Control_Modify(ByVal iID As Integer) As Boolean

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                            New SqlParameter("@Action_Type", "MODIFY")}

        Return CBool(class_Database.Procedure_Execute(class_Database.ICSConnection, "Modify Purchase Order", "op_Spare_Parts_Purchase_Order_Procedures", Parameters, True))
    End Function

    Friend Function Control_Delete() As Boolean

        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "DELETE")}

        Return CBool(class_Database.Procedure_Execute(class_Database.ICSConnection, "Delete Purchase Order", "op_Spare_Parts_Purchase_Order_Procedures", Parameters, True))
    End Function

    Private Sub Brand_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Brand.EditValueChanged
        If Not Brand.EditValue Is Nothing Then
            Supplier_Name.Text = Brand.GetColumnValue("Account_Name")
        End If
    End Sub

    Private Sub Supplier_Name_EditValueChanged(sender As Object, e As EventArgs) Handles Supplier_Name.EditValueChanged
        Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{class_Saga_Variables.sBranchCode}{Brand.Text.Trim}-", 2)
    End Sub
End Class

