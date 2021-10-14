Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class xuc_Master_Entry
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()

        class_Saga_Variables.Initialize_Employee()
        'class_Saga_Procedures.Initialize_Employee(Employee_Name)
    End Sub

    Friend Function Control_Save() As Boolean

        If class_Procedures.isEmpty(Parts_Name) Then Return False
        If class_Procedures.isEmpty(Parts_Number) Then Return False
        If class_Procedures.isEmpty(SRP) Then Return False
        If class_Procedures.isEmpty(Cost_WoVAT) Then Return False
        If class_Procedures.isEmpty(Cost_WVAT) Then Return False
        If class_Procedures.isEmpty(Descriptions) Then Return False

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Parts_ID", ID.EditValue),
            New SqlParameter("@Parts_Number", Parts_Number.EditValue.ToString),
            New SqlParameter("@Parts_Name", Parts_Name.EditValue.ToString),
            New SqlParameter("@Parts_Brand", Brand.Text),
            New SqlParameter("@Parts_Category", Category.Text),
            New SqlParameter("@Parts_Model_Code", Model_Code.Text),
            New SqlParameter("@Parts_Model_Name", Model_Name.Text),
            New SqlParameter("@Parts_Note", Descriptions.Text),
            New SqlParameter("@Parts_SRP", SRP.Text),
            New SqlParameter("@Parts_Price_WoVAT", Cost_WoVAT.Text.Trim),
            New SqlParameter("@Parts_Price_WVAT", Cost_WVAT.Text.Trim),
            New SqlParameter("@Parts_Quantity", Quantity.Text.Trim),
            New SqlParameter("@Parts_Transacted_By", class_Variables.sUserName),
            New SqlParameter("Action_Type", "SAVE")
        }
        Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "spa_Master_Procedures", "Spare Parts Master List", Parts_Number.EditValue.ToString)
    End Function

End Class