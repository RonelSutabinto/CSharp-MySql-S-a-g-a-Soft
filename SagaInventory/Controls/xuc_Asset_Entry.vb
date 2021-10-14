Imports SagaClassLibrary.classes

Public Class xuc_Asset_Entry
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()

        class_Saga_Variables.Initialize_Employee()
        class_Saga_Procedures.Initialize_Employee(Employee_Name)
    End Sub

    'Friend Function Control_Save() As Boolean
    '    
    '    If class_Procedures.isEmpty(Employee_Name) Then Return False
    '    If class_Procedures.isEmpty(Inventory_No) Then Return False
    '    If class_Procedures.isEmpty(Descriptions) Then Return False
    '    If class_Procedures.isEmpty(Notes) Then Return False

    '    Dim sActionType As String

    '    If ID.EditValue.Equals("0") Then
    '        sActionType = "SAVE"
    '    Else
    '        sActionType = "UPDATE"
    '    End If

    '    Dim sqlParameters As SqlParameter() = {0New SqlParameter("@Branch_Code", Branch_Code.EditValue),
    '                                        New SqlParameter("@Request_Code", Request_Code.EditValue),
    '                                        New SqlParameter("@Request_Type", Request_Type.Text),
    '                                        New SqlParameter("@Request_Brand", Request_Brand.Text.Trim),
    '                                        New SqlParameter("@Request_Name", Request_Name.Text.Trim),
    '                                        New SqlParameter("@Request_Description", Request_Description.Text.Trim),
    '                                        New SqlParameter("@Request_Quantity", Request_Quantity.Value),
    '                                        New SqlParameter("@Request_Amount", Request_Amount.Value),
    '                                        New SqlParameter("@Request_Amount_Total", Request_Amount_Total.Value),
    '                                        New SqlParameter("@Request_Approver", Request_Approver.Text),
    '                                        New SqlParameter("@Request_Status", Request_Status.Text),
    '                                        New SqlParameter("@Notes", Notes.Text.Trim),
    '                                        New SqlParameter("@Added_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Approved_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Approved_Date", DateTime.Now),
    '                                        New SqlParameter("@Action_Type", sActionType)}

    '    Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "System Request", "inv_Request_Procedures", Request_Code.Text.Trim)
    'End Function
End Class