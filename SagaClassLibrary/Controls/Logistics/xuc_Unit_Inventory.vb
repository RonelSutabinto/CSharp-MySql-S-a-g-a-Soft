Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Logistics

    Public Class xuc_Unit_Inventory
        Inherits DevExpress.XtraEditors.XtraUserControl

        Dim iModelID As Integer

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_From)
            class_Saga_Procedures.Initialize_Branch(Branch_To)

            class_Saga_Procedures.Initialize_Warehouse(Category)

            class_Saga_Variables.Initialize_MC_Models(True)
            class_Saga_Procedures.Initialize_MC_Model(Model_Code)

            class_Database.Fill_Edit(class_Database.ICSConnection, Brand, "item_Details", "brand")
            class_Database.Fill_Edit(class_Database.ICSConnection, Model, "item_Details", "model")
            class_Database.Fill_Edit(class_Database.ICSConnection, Color, "item_Details", "color")
            class_Database.Fill_Edit(class_Database.ICSConnection, Inventory_Status, "item_Details", "inventoryStatus")

            Engine.ReadOnly = Not class_Saga_Variables.isLogistics
            Chassis.ReadOnly = Not class_Saga_Variables.isLogistics
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Unit Inventory", "Initialize new Unit Inventory", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
        End Sub

        Friend Function Control_Retrieve(ByVal iID As Integer) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Action_Type", "RETRIEVE_INVENTORY")
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ID.EditValue = myDataReader("id").ToString
                        If_Exist.IsOn = Convert.ToBoolean(myDataReader("IfExist"))
                        Transaction_Code.Text = myDataReader("transcode").ToString
                        Purchase_Order.Text = myDataReader("POno").ToString
                        Reference.Text = myDataReader("refno").ToString
                        Branch_From.EditValue = myDataReader("VendorCode").ToString
                        Branch_To.EditValue = myDataReader("branchcode").ToString
                        Category.EditValue = myDataReader("whCode").ToString
                        Model_Code.EditValue = myDataReader("Model_Code").ToString
                        Brand.Text = myDataReader("brand").ToString
                        Model.Text = myDataReader("model").ToString
                        Color.Text = myDataReader("color").ToString
                        Description.Text = myDataReader("description").ToString
                        Engine.Text = myDataReader("EngineNo").ToString
                        Chassis.Text = myDataReader("ChassisNo").ToString
                        Category.Text = myDataReader("inventoryStatus").ToString
                        Unit_Price.Value = Convert.ToDecimal(myDataReader("Remarks"))
                        Remarks.Text = myDataReader("Remarks").ToString
                        Notes.Text = myDataReader("note").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Transaction_Code) Then Return False
            If class_Procedures.isEmpty(Purchase_Order) Then Return False
            If class_Procedures.isEmpty(Reference) Then Return False
            If class_Procedures.isEmpty(Category) Then Return False
            If class_Procedures.isEmpty(Model_Code) Then Return False
            If class_Procedures.isEmpty(Engine) Then Return False
            If class_Procedures.isEmpty(Chassis) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Reference", Reference.Text.Trim.ToUpper),
                New SqlParameter("@Supplier_Code", Branch_From.EditValue),
                New SqlParameter("@Branch_Code", Branch_To.EditValue),
                New SqlParameter("@IfExist", If_Exist.EditValue),
                New SqlParameter("@Unit_Status", Category.EditValue),
                New SqlParameter("@Unit_Category", Category.Text),
                New SqlParameter("@Model_Code", Model_Code.EditValue),
                New SqlParameter("@Engine", Engine.Text.Trim.ToUpper),
                New SqlParameter("@Chassis", Chassis.Text.Trim.ToUpper),
                New SqlParameter("@Unit_Price", Unit_Price.Value),
                New SqlParameter("@Remarks", Remarks.Text),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "UPDATE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Item Inventory Information", ID.EditValue.Trim)
        End Function

        Friend Function Control_Syncronize(ByVal bByModel As Boolean, Optional sModel As String = "", Optional ByVal sColor As String = "") As Boolean
            If class_Procedures.isEmpty(Model_Code) Then Return False
            If class_Procedures.isEmpty(Engine) Then Return False

            If bByModel Then
                Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", Model_Code.GetColumnValue("id")),
                New SqlParameter("@Model_Code", Model_Code.EditValue),
                New SqlParameter("@Model", sModel),
                New SqlParameter("@Color", sColor),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SYNCRONIZE")
            }
                Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Item Inventory Information", Engine.Text.Trim)
            Else
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Model_Code", Model_Code.EditValue),
                    New SqlParameter("@Engine", Engine.Text.Trim.ToUpper),
                    New SqlParameter("@Chassis", Chassis.Text.Trim.ToUpper),
                    New SqlParameter("@Unit_Category", Category.EditValue),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SYNCRONIZE")
                }
                Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Item Inventory Information", Engine.Text.Trim)
            End If
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "UNIT_DELETE")
            }
            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Delete Unit History", True))
        End Function

        Private Sub Unit_Reference_Properties_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Reference.ButtonClick
            Select Case e.Button.Index
                Case 0
                    'class_Saga_Procedures.Show_Logistics_Transports(Reference.Text.Trim)
                Case Else
            End Select
        End Sub

        Private Sub Unit_Engine_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Engine.ButtonClick
            Select Case e.Button.Index
                Case 0
                    class_Saga_Procedures.Show_Unit_Inventory(Engine.Text.Trim)

                Case 1
                    Dim sFieldValueOld As String = Engine.Text.Trim
                    Dim sFieldValueNew As String = class_Functions.Show_Input_Box("Input new Engine Number", "New Engine Number", sFieldValueOld)
                    If class_Database.Data_Replace(class_Database.ICSConnection, "New Engine Number", "item_Details", "EngineNo", sFieldValueOld, sFieldValueNew) Then
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sFieldValueNew}' WHERE Journal_Reference LIKE '{sFieldValueOld}'")
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET EngineNo = '{sFieldValueNew}' WHERE EngineNo LIKE '{sFieldValueOld}'")
                        Engine.Text = sFieldValueNew
                    End If
            End Select
        End Sub

        Private Sub Unit_Chassis_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Chassis.ButtonClick
            Select Case e.Button.Index
                Case 0
                    class_Saga_Procedures.Show_Unit_Inventory(Engine.Text.Trim)

                Case 1
                    Dim sFieldValueOld As String = Chassis.Text.Trim
                    Dim sFieldValueNew As String = class_Functions.Show_Input_Box("Input new Chassis Number", "New Chassis Number", sFieldValueOld)
                    If class_Database.Data_Replace(class_Database.ICSConnection, "New Chassis Number", "item_Details", "ChassisNo", sFieldValueOld, sFieldValueNew) Then
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET ChassisNo = '{sFieldValueNew}' WHERE ChassisNo LIKE '{sFieldValueOld}'")
                        Engine.Text = sFieldValueNew
                    End If
            End Select
        End Sub

        Private Sub Model_Code_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Model_Code.Properties.ButtonClick
            Try
                Select Case e.Button.Index
                    Case 1
                        class_Saga_Procedures.Show_Unit_Model(Model_Code.EditValue)
                End Select
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Model_Code_Validated(sender As Object, e As EventArgs) Handles Model_Code.Validated
            Try
                iModelID = Model_Code.GetColumnValue("id")
                Brand.Text = Model_Code.GetColumnValue("branddesc")
                Model.Text = Model_Code.GetColumnValue("modeldesc")
                Color.Text = Model_Code.GetColumnValue("Custom_Color")
                Description.Text = Model_Code.GetColumnValue("Description")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

        End Sub
    End Class

End Namespace