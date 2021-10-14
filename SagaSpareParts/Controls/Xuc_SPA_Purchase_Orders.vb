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
        Order_C0de.ReadOnly = False
        Brand.Select()
    End Sub

    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        Order_C0de.ReadOnly = False
        If bClear AndAlso Not class_Procedures.actionAsk("New Purchase Order", "Initialize new Purchase Order", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        ID.Text = "0"
        Supplier_Name.EditValue = Brand.GetColumnValue("Account_Name")
        Order_C0de.Properties.MaskSettings.Set("mask", $"{Brand.GetColumnValue("Pre_Code")}-LLLLL-0000-000")
        Order_Date.Select()
        'If Not class_Procedures.isEmpty(Brand) Then
        '    If bOrderModify Then
        '        Dim sOrderCode() As String = Order_Code.Text.Split("-")
        '        Order_Code.EditValue = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{sOrderCode(0)}-{sOrderCode(1)}-{sOrderCode(2)}-")
        '    Else
        '        Order_Code.EditValue = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Purchase_Order", "ID", "Order_Code", $"{"PO"}-{Brand.Text.Trim}-", 2)
        '    End If
        'Else
        '    Brand.Select()
        'End If
    End Sub

    Friend Function Control_Retrieve(ByVal sID As String) As Boolean

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", ID.Text),
            New SqlParameter("@Action_Type", "RETRIEVE")
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures")
            ID.Text = sID
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Try
                    myDataReader.Read()
                    Order_C0de.Text = myDataReader("Order_Code").ToString
                    Order_Type.Text = myDataReader("Order_Type").ToString
                    Brand.Text = myDataReader("Brand").ToString
                    Supplier_Name.EditValue = myDataReader("Supplier_Name").ToString
                    Order_Date.EditValue = CDate(myDataReader("Order_Date"))
                    Description.Text = myDataReader("Order_Description").ToString
                    Notes.Text = myDataReader("Notes").ToString
                    Return True
                Catch ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                End Try
            End If
        End Using
        Return False
    End Function

    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(Order_C0de) Then Return False
        If class_Procedures.isEmpty(Brand) Then Return False

        ' Dim sOrderCode() As String = Order_Code.Text.Trim.Split("-")
        Dim sNotes As String = String.Empty
        'If sOrderCode.Length > 5 Then
        '    'If class_Procedures.isEmpty(Notes) Then Return False
        '    sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        'End If

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", ID.Text),
            New SqlParameter("@Order_Type", Order_Type.Text),
            New SqlParameter("@Order_Code", Order_C0de.Text),
            New SqlParameter("@Brand_Name", Brand.Text),
            New SqlParameter("@Brand_Code", Brand.EditValue),
            New SqlParameter("@Supplier_Name", Brand.GetColumnValue("Account_Name")),
            New SqlParameter("@Supplier_Code", Brand.GetColumnValue("Account_Code")),
            New SqlParameter("@Order_Date", Order_Date.EditValue),
            New SqlParameter("@Order_Description", Description.Text.Trim),
            New SqlParameter("@Notes", sNotes),
            New SqlParameter("@Added_By", class_Variables.sUserName),
            New SqlParameter("@Modified_By", class_Variables.sUserName),
            New SqlParameter("@Action_Type", "SAVE")
        }
        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Purchase Order", Order_C0de.Text)
    End Function

    Friend Function Control_Modify(ByVal iID As Integer) As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", iID),
            New SqlParameter("@Action_Type", "MODIFY")
        }
        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Modify Purchase Order", True))
    End Function

    Friend Function Control_Delete() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", ID.Text),
            New SqlParameter("@Action_Type", "DELETE")
        }
        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Delete Purchase Order", True))
    End Function

    Private Sub Brand_EditValueChanged(sender As Object, e As EventArgs) Handles Brand.EditValueChanged
        If Not Brand.EditValue Is Nothing Then
            Dim spa_PO As frm_SPA_Purchase_Orders = New frm_SPA_Purchase_Orders()
            Supplier_Name.Text = CStr(Brand.GetColumnValue("Account_Name"))
            Order_C0de.Properties.MaskSettings.Set("mask", $"{Brand.GetColumnValue("Pre_Code")}-LLLLL-0000-000")
            Initialize_Part_Number(Brand.Text)
            Initialize_Part_Number(spa_PO.RepositoryItemLookUpEdit_Parts_Number)
            Initialize_Order_Slip(Brand.Text)
            Initialize_Order_Slip(Order_C0de)
        End If
    End Sub
End Class

