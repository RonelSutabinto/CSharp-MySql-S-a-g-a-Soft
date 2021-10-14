Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Public Class xuc_Freebies
    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()
        class_Saga_Procedures.Initialize_Branch(Branch)
        Branch.Select()
        Posting_Date.EditValue = Date.Now()
    End Sub

    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Freebies Form", "Initialize new Freebies Form", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        FreebieID.Text = "0"
    End Sub

    'Friend Function Control_Retrieve(ByVal sID As String) As Boolean
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", FreebieID.Text),
    '                                        New SqlParameter("@Action_Type", "RETRIEVE")}

    '    Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures")
    '        FreebieID.Text = sID
    '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
    '            Try
    '                myDataReader.Read()
    '                Reference.Text = myDataReader("Reference").ToString
    '                SRF_Number.Text = myDataReader("SRF").ToString
    '                Transaction_Date.EditValue = CDate(myDataReader("Transaction_Date"))
    '                Description.Text = myDataReader("Order_Description").ToString
    '                Notes.Text = myDataReader("Notes").ToString
    '                Return True
    '            Catch ex As Exception
    '                Return class_Procedures.Show_Error(ex)
    '            End Try
    '        End If
    '    End Using
    '    Return False
    'End Function

    'Friend Function Control_Save() As Boolean
    '    If class_Saga_Variables.sBranchCode.Equals(Branch_From) Then Return False
    '    If class_Procedures.isEmpty(Reference) Then Return False
    '    If class_Procedures.isEmpty(SRF_Number) Then Return False

    '    Dim sOrderCode() As String = Reference.Text.Split("-")
    '    Dim sNotes As String = String.Empty
    '    If sOrderCode.Length > 3 Then
    '        'If class_Procedures.isEmpty(Notes) Then Return False
    '        sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

    '    End If

    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
    '                                        New SqlParameter("@Branch_Code", Branch_From.EditValue),
    '                                        New SqlParameter("@Reference", Reference.EditValue),
    '                                        New SqlParameter("@SRF_Number", SRF_Number.EditValue),
    '                                        New SqlParameter("@Branch_From", class_Saga_Variables.sBranchCode),
    '                                        New SqlParameter("@Request_Description", Description.Text.Trim),
    '                                        New SqlParameter("@Notes", sNotes),
    '                                        New SqlParameter("@Added_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Action_Type", "SAVE")}

    '    Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Spare Parts Request", Reference.Text)
    'End Function

    Friend Function Control_Modify(ByVal iID As Integer) As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                            New SqlParameter("@Action_Type", "MODIFY")}

        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Modify Spare Parts Request", True))
    End Function

    Friend Function Control_Delete() As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", FreebieID.Text),
                                            New SqlParameter("@Action_Type", "DELETE")}

        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Delete Spare Parts Request", True))
    End Function

End Class
