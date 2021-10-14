Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Controls.Logistics
    Public Class xuc_MC_Request
        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            WHCode.ReadOnly = False
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            With Branch_Code
                .EditValue = class_Saga_Variables.sBranchCode
                .ReadOnly = Not class_Saga_Variables.sBranchCode.Equals("000")
            End With

            class_Saga_Procedures.Initialize_Branch(Supplier_Code)
            class_Saga_Procedures.Initialize_Warehouse(WHCode)
            Supplier_Code.Select()
        End Sub

        Friend Function Control_New(ByVal bAsk As Boolean, Optional ByVal bClear As Boolean = False) As Boolean
            If bAsk AndAlso Not class_Procedures.actionAsk("New MC Request", "Initialize new MC Request", "You might lose unsaved data") Then Return False
            class_Procedures.Initialize_Controls(Me, bClear)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "inv_MC_Requests", "Request_Code", "MCREQ-")
            WHCode.ReadOnly = False
            Branch_Code.EditValue = class_Saga_Variables.sBranchCode
            Supplier_Code.Select()
            Return True
        End Function

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Request_Code", sCode),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_MC_Request_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Request_Code.Text = myDataReader("Request_Code").ToString
                        Supplier_Code.EditValue = myDataReader("Supplier_Code").ToString
                        Branch_Code.EditValue = myDataReader("Branch_Code").ToString
                        WHCode.EditValue = myDataReader("WHCode").ToString
                        Request_Description.Text = myDataReader("Request_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Validated() As Boolean
            If class_Procedures.isEmpty(Request_Code) Then Return False
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(WHCode) Then Return False
            If class_Procedures.isEmpty(Request_Description) Then Return False

            Return True
        End Function

        Friend Function Control_Save(Optional ByVal bAsk As Boolean = False) As Boolean
            If Not Control_Validated() Then Return False

            If Supplier_Code.EditValue.Equals(Branch_Code.EditValue) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Supplier and Branch cannot be the same.", "Invalid Supplier/Branch", True)
                Supplier_Code.Select()
                Return False
            End If

            If ID.EditValue.Equals("0") Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Request_Code, "inv_MC_Requests", "Request_Code", "MCREQ-")
            End If

            If bAsk AndAlso Not class_Procedures.actionAsk("Receive/Transfer", "Save Receiving/Transafer Transaction") Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Request_Code", Request_Code.EditValue),
                New SqlParameter("@Supplier_Code", Supplier_Code.EditValue),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@WHCode", WHCode.EditValue),
                New SqlParameter("@Request_Description", Request_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_MC_Request_Procedures", "MC Request", Request_Code.Text.Trim)
        End Function

        Friend Function Control_Delete(ByVal iID As Integer) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_MC_Request_Procedures", "Delete MC Request", True))
        End Function

        Friend Sub Control_Preview()
            If class_Procedures.isEmpty(Request_Code) Then Return

            Dim xRpt As New Reports.Logistics.xrpt_MC_Requests()
            'class_Database.BindData(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Purchase_Order_Units WHERE Transaction_Code LIKE '{Request_Code.Text.Trim}' ORDER BY Model_Name", "view_Purchase_Order_Units")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageHeight = 1100
                    .PageWidth = 850

                    .Branch_From_To.Text = $"{Supplier_Code.Text} - {Branch_Code.Text}"
                    '.Request_Code.Text = Request_Code.Text
                    '.Transaction_Date.Text = Date.Today.ToString("MMMM dd, yyyy")
                    '.WHCode.Text = WHCode.Text
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Request_Code", Request_Code.Text),
                    New SqlParameter("@Action_Type", "LOAD_MC_UNITS")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Request_Procedures", "inv_Purchase_Order_Units")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub
    End Class
End Namespace
