Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Public Class xuc_Order_Slip
    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub Control_Initialize()
        ID.Text = "0"
        class_Saga_Variables.Initialize_Brands()
        class_Saga_Procedures.Initialize_Brand(Brand)
        Initialize_SubDealer()
        Initialize_SubDealer(SubDealer_Name)
        Initialize_HeadOffice("000")
        Initialize_HeadOffice(Requested_Branch)
        Requested_Branch.Select()
        Order_Date.EditValue = Date.Now()
        Requested_Branch.ReadOnly = True
    End Sub

    Friend Sub Control_New(Optional ByVal bClear As Boolean = False, Optional ByVal bOrderModify As Boolean = False)

        If bClear AndAlso Not class_Procedures.actionAsk("New Order Slip", "Initialize new Order Slip", "You might lose unsaved data") Then Return
        class_Procedures.Initialize_Controls(Me, bClear)
        ID.Text = "0"
        Brand.Select()
    End Sub

    Friend Function Control_Retrieve(ByVal sID As String) As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "RETRIEVE")}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Order_Slip_Procedures")
            ID.Text = sID
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Try
                    myDataReader.Read()
                    Order_C0de.Text = myDataReader("Reference").ToString
                    Order_Date.EditValue = CDate(myDataReader("Transaction_Date"))
                    Description.Text = myDataReader("Order_Description").ToString
                    Notes.Text = myDataReader("Notes").ToString
                    Return True
                Catch Ex As Exception
                    Return class_Procedures.Show_Error(Ex)
                End Try
            End If
        End Using
        Return False
    End Function

    Friend Function Control_Save() As Boolean
        If class_Procedures.isEmpty(Order_C0de) Then Return False

        ' Dim sOrderCode() As String = Order_C0de.Text.Split("-")
        Dim sNotes As String = String.Empty
        'If sOrderCode.Length > 3 Then
        '    sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)

        'End If

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Orderid", ID.Text),
                                            New SqlParameter("@Brand", Brand.Text),
                                            New SqlParameter("@Branch_Code", Requested_Branch.EditValue),
                                            New SqlParameter("@Order_Code", Order_C0de.EditValue),
                                            New SqlParameter("@SubDealer_Code", SubDealer_Name.GetColumnValue("SubDealer_Code")),
                                            New SqlParameter("@Order_Date", Order_Date.EditValue),
                                            New SqlParameter("@Branch_From", class_Saga_Variables.sBranchCode),
                                            New SqlParameter("@Order_Description", Description.Text.Trim),
                                            New SqlParameter("@Notes", sNotes),
                                            New SqlParameter("@Added_By", class_Variables.sUserName),
                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "SAVE")}

        Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Order_Slip_Procedures", "Spare Parts Order Slip", Order_C0de.Text)
    End Function

    Friend Function Control_Modify(ByVal iID As Integer) As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                            New SqlParameter("@Action_Type", "MODIFY")}

        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Order_Slip_Procedures", "Modify Spare Parts Order Slip", True))
    End Function

    Friend Function Control_Delete() As Boolean

        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                            New SqlParameter("@Action_Type", "DELETE")}

        Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Order_Slip_Procedures", "Delete Spare Parts Order Slip", True))
    End Function

    Private Sub Brand_EditValueChanged(sender As Object, e As EventArgs) Handles Brand.EditValueChanged
        If Not Brand.EditValue Is Nothing Then
             Dim frm_SRF As frm_SPA_Order_Slip = New frm_SPA_Order_Slip()
            Initialize_Part_Number(Brand.Text)
            Initialize_Part_Number(frm_SRF.RepositoryItemLookUpEdit_Parts_Number)
        End If
    End Sub

    Private Sub SubDealer_Name_EditValueChanged(sender As Object, e As EventArgs) Handles SubDealer_Name.EditValueChanged
        Dim dDate As Date
        Dim sMosYear As String
        dDate = Date.Now()

        sMosYear = dDate.ToString("MMyy")
        Order_C0de.Properties.MaskSettings.Set("mask", $"{Brand.GetColumnValue("Pre_Code")}-{SubDealer_Name.GetColumnValue("SubDealer_Code")}-{sMosYear}-000")
        ' MsgBox(sMosYear)
    End Sub
End Class
