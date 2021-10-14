Imports SagaClassLibrary.classes
Imports wSClassLib.myModules

Public Class MC_AcctDetailedRemarks
    private sub MC_AcctDetailedRemarks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)
        Initialize_AcctStatus()
        Initialize_AcctStatus(BarEditItem_AccountStatus, RepositoryItemLookUpEdit1)
    End Sub
End Class