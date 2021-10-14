Imports MyClassLibrary.Classes
Public Class frm_SPA_Import
    Private Sub frm_SPA_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_gridView(Xuc_SPA_Import.gridView)
    End Sub
End Class