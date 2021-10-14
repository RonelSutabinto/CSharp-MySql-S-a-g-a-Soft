Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class xuc_Utility
    Public sBranchCode As String
    Friend Sub Control_Initialize()
        If class_Saga_Variables.sBranchCode.Equals("000") Then
            PartsNumber.ReadOnly = False
            PartsName.ReadOnly = False
            SRP.ReadOnly = False
            SPCostWOVAT.ReadOnly = False
            Quantity.ReadOnly = False
            BinBox.ReadOnly = False
            Brand.ReadOnly = False
            Category.ReadOnly = False
        Else
            PartsNumber.ReadOnly = True
            PartsName.ReadOnly = False
            SRP.ReadOnly = True
            SPCostWOVAT.ReadOnly = True
            Quantity.ReadOnly = True
            Brand.ReadOnly = True
            Category.ReadOnly = True
        End If
    End Sub
    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Post Dated Check", "Initialize new Post Dated Check", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        ID.Text = "0"
        BinBox.Select()
    End Sub

    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(PartsNumber) Then Return False
        If class_Procedures.isEmpty(PartsName) Then Return False
        If class_Procedures.isEmpty(SRP) Then Return False
        If class_Procedures.isEmpty(SPCostWOVAT) Then Return False

        ' Dim sOrderCode() As String = Order_Code.Text.Trim.Split("-")
        Dim sNotes As String = String.Empty
        'If sOrderCode.Length > 5 Then
        '    'If class_Procedures.isEmpty(Notes) Then Return False
        '    sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        'End If

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Id", ID.Text),
                                            New SqlParameter("@BranchCode", sBranchCode),
                                            New SqlParameter("@PartsNumber", PartsNumber.Text.ToString.ToUpper),
                                            New SqlParameter("@PartsName", PartsName.Text.ToString.ToUpper),
                                            New SqlParameter("@Brand", Brand.EditValue),
                                            New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                                            New SqlParameter("@Receiving_Branch", Receiving_Branch.EditValue),
                                            New SqlParameter("@Category", Category.EditValue),
                                            New SqlParameter("@SRP", SRP.EditValue),
                                            New SqlParameter("@SPCostWOVAT", SPCostWOVAT.EditValue),
                                            New SqlParameter("@Quantity", Quantity.EditValue),
                                            New SqlParameter("@BinBox", BinBox.Text.ToString.ToUpper),
                                            New SqlParameter("@Classification", Classification.EditValue),
                                            New SqlParameter("@Action_Type", "SAVE_ITEM")}

        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Modification_Procedures", "Spare Parts Modification", PartsNumber.Text)
    End Function
    Friend Function Control_Delete() As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Id", ID.Text),
                                            New SqlParameter("@PartsNumber", PartsNumber.Text.ToString),
                                            New SqlParameter("@BranchCode", Receiving_Branch.Text.ToString),
                                            New SqlParameter("@Action_Type", "DELETE_ITEM")}

        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Modification_Procedures", "Spare Parts Modification", PartsNumber.Text)
    End Function
End Class
