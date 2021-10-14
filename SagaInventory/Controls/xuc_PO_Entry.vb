Imports SagaClassLibrary.classes

Public Class xuc_PO_Entry
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(Branch)
    End Sub

End Class