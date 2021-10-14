Imports MyClassLibrary.Classes

Namespace Classes
    Module class_Operation_Variables
        Public Spare_Parts As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public spCategory As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public partsNumber As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public Sub Initialize_Spare_Parts(ByVal sBranchCode As String)
            class_Database.BindData(class_Database.SPAConnection, Spare_Parts, $"SELECT * FROM SPA_Inventory WHERE ReceivingBranch LIKE '{sBranchCode}' AND Quantity > 0 ORDER BY SRP DESC ", "SPA_Inventory")
        End Sub
    End Module
End Namespace