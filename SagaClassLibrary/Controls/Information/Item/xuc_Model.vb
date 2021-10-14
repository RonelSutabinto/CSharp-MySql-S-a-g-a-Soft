Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Information.Item

    Public Class xuc_Item
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Database.Fill_Edit(class_Database.ICSConnection, Item_Group, "maint_model", "itemgrp")
            class_Database.Fill_Edit(class_Database.ICSConnection, Product_Type, "maint_model", "Product_Type")
            class_Database.Fill_Edit(class_Database.ICSConnection, Model, "maint_model", "Model")
            class_Database.Fill_Edit(class_Database.ICSConnection, Sub_Model, "maint_model", "modeldesc")
            class_Database.Fill_Edit(class_Database.ICSConnection, Color, "maint_model", "Color")
            class_Database.Fill_Edit(class_Database.ICSConnection, Custom_Color, "maint_model", "Custom_Color")
            class_Saga_Procedures.Initialize_Brand(Brand)
            Model_Code.ReadOnly = False
            Brand.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Item Model", "Initialize new Item Model", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
            Model_Code.ReadOnly = False
            Model_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Model_Code", sCode),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ID.EditValue = myDataReader("id").ToString
                        Model_Status.IsOn = Convert.ToBoolean(myDataReader("Model_Status")).ToString
                        Model_Code.Text = myDataReader("Model_Code").ToString
                        Item_Group.Text = myDataReader("itemgrp").ToString
                        Product_Type.Text = myDataReader("Product_Type").ToString
                        Brand.EditValue = myDataReader("Brand_Code").ToString
                        Model.Text = myDataReader("Model").ToString
                        Sub_Model.Text = myDataReader("modeldesc").ToString
                        Color.Text = myDataReader("Color").ToString
                        Custom_Color.Text = myDataReader("Custom_Color").ToString
                        Description.Text = myDataReader("Description").ToString
                        Engine_Prefix.Text = myDataReader("EnginePrefix").ToString
                        Chassis_Prefix.Text = myDataReader("ChassisPrefix").ToString
                        Unit_Cost.Value = Convert.ToDecimal(myDataReader("Unit_Cost"))
                        Unit_SRP.Value = Convert.ToDecimal(myDataReader("Unit_SRP"))
                        COD.Value = Convert.ToDecimal(myDataReader("COD"))
                        LCP.Value = Convert.ToDecimal(myDataReader("LCP"))
                        AOC.Value = Convert.ToDecimal(myDataReader("AOC"))
                        Down_Payment.Value = Convert.ToDecimal(myDataReader("DownPayment"))
                        Financed.Value = Convert.ToDecimal(myDataReader("Financed"))
                        Rebates.Value = Convert.ToDecimal(myDataReader("Rebates"))
                        Interest_Rate_12.Value = Convert.ToDecimal(myDataReader("InterestRate12"))
                        Monthly_12.Value = Convert.ToDecimal(myDataReader("Monthly12"))
                        Interest_Rate_18.Value = Convert.ToDecimal(myDataReader("InterestRate18"))
                        Monthly_18.Value = Convert.ToDecimal(myDataReader("Monthly18"))
                        Interest_Rate_24.Value = Convert.ToDecimal(myDataReader("InterestRate24"))
                        Monthly_24.Value = Convert.ToDecimal(myDataReader("Monthly24"))
                        Interest_Rate_36.Value = Convert.ToDecimal(myDataReader("InterestRate36"))
                        Monthly_36.Value = Convert.ToDecimal(myDataReader("Monthly36"))
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Model_Code) Then Return False
            If class_Procedures.isEmpty(Item_Group) Then Return False
            If class_Procedures.isEmpty(Product_Type) Then Return False
            If class_Procedures.isEmpty(Brand) Then Return False
            If class_Procedures.isEmpty(Sub_Model) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Model_Status", Model_Status.IsOn),
                New SqlParameter("@Model_Code", Model_Code.Text.Trim),
                New SqlParameter("@Group", Item_Group.Text.Trim.ToUpper),
                New SqlParameter("@Type", Product_Type.Text.Trim.ToUpper),
                New SqlParameter("@Brand_Code", Brand.EditValue),
                New SqlParameter("@Brand", Brand.Text),
                New SqlParameter("@Model", Model.Text.Trim),
                New SqlParameter("@Sub_Model", Sub_Model.Text.Trim),
                New SqlParameter("@Color", Color.Text.Trim.ToUpper),
                New SqlParameter("@Custom_Color", Custom_Color.Text.Trim.ToUpper),
                New SqlParameter("@Description", Description.Text.Trim),
                New SqlParameter("@EnginePrefix", Engine_Prefix.Text.Trim.ToUpper),
                New SqlParameter("@ChassisPrefix", Chassis_Prefix.Text.Trim.ToUpper),
                New SqlParameter("@Unit_Cost", Convert.ToDecimal(Unit_Cost.Value)),
                New SqlParameter("@Unit_SRP", Convert.ToDecimal(Unit_SRP.Value)),
                New SqlParameter("@COD", Convert.ToDecimal(COD.Value)),
                New SqlParameter("@LCP", Convert.ToDecimal(LCP.Value)),
                New SqlParameter("@AOC", Convert.ToDecimal(AOC.Value)),
                New SqlParameter("@DownPayment", Convert.ToDecimal(Down_Payment.Value)),
                New SqlParameter("@Financed", Convert.ToDecimal(Financed.Value)),
                New SqlParameter("@Rebates", Convert.ToDecimal(Rebates.Value)),
                New SqlParameter("@InterestRate12", Convert.ToDecimal(Interest_Rate_12.Value)),
                New SqlParameter("@Monthly12", Convert.ToDecimal(Monthly_12.Value)),
                New SqlParameter("@InterestRate18", Convert.ToDecimal(Interest_Rate_18.Value)),
                New SqlParameter("@Monthly18", Convert.ToDecimal(Monthly_18.Value)),
                New SqlParameter("@InterestRate24", Convert.ToDecimal(Interest_Rate_24.Value)),
                New SqlParameter("@Monthly24", Convert.ToDecimal(Monthly_24.Value)),
                New SqlParameter("@InterestRate36", Convert.ToDecimal(Interest_Rate_36.Value)),
                New SqlParameter("@Monthly36", Convert.ToDecimal(Monthly_36.Value)),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Model Description", Sub_Model.Text.Trim)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Delete Model Description", True))
        End Function

        Private Sub Item_Descriptionitem_DoubleClick(sender As Object, e As EventArgs) Handles Item_Descriptionitem.DoubleClick, btn_Generate.Click
            Description.Text = $"{Brand.Text.Trim} {Sub_Model.Text.Trim} {Custom_Color.Text.Trim}"
            Description.Select()
        End Sub

        Private Sub set_Amortization()
            Dim iRate12 As Single = Convert.ToSingle(Interest_Rate_12.Text)
            Dim iRate18 As Single = Convert.ToSingle(Interest_Rate_18.Text)
            Dim iRate24 As Single = Convert.ToSingle(Interest_Rate_24.Text)
            Dim iRate36 As Single = Convert.ToSingle(Interest_Rate_36.Text)
            Financed.Value = Convert.ToDecimal(LCP.Value) - Convert.ToDecimal(Down_Payment.Value)
            Dim dFinanced As Double = Convert.ToDecimal(Financed.Value)
            Monthly_12.EditValue = Math.Round(((dFinanced * iRate12) + dFinanced) / 12, 0)
            Monthly_18.EditValue = Math.Round(((dFinanced * iRate18) + dFinanced) / 18, 0)
            Monthly_24.EditValue = Math.Round(((dFinanced * iRate24) + dFinanced) / 24, 0)
            Monthly_36.EditValue = Math.Round(((dFinanced * iRate36) + dFinanced) / 36, 0)
        End Sub

        Private Sub Item_LCP_KeyDown(sender As Object, e As KeyEventArgs) Handles LCP.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                set_Amortization()
            End If
        End Sub

        Private Sub Item_Int_Rate_12_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Interest_Rate_12.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                set_Amortization()
            End If
        End Sub

        Private Sub Item_Int_Rate_18_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Interest_Rate_18.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                set_Amortization()
            End If
        End Sub

        Private Sub Item_Int_Rate_24_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Interest_Rate_24.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                set_Amortization()
            End If
        End Sub

        Private Sub Item_Int_Rate_36_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Interest_Rate_36.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                set_Amortization()
            End If
        End Sub

        Private Sub Item_Modelitem_DoubleClick(sender As Object, e As EventArgs) Handles Item_Modelitem.DoubleClick
            Sub_Model.Text = Model.Text.Trim
        End Sub

        Private Sub Item_Sub_Modelitem_DoubleClick(sender As Object, e As EventArgs) Handles Item_Sub_Modelitem.DoubleClick
            Model.Text = Sub_Model.Text.Trim
        End Sub

        Private Sub Model_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Model_Code.ButtonClick
            Select Case e.Button.Index
                Case 0
                    If class_Procedures.isEmpty(Model_Code) Then Return
                    If class_Procedures.isEmpty(Brand) Then Return
                    If class_Procedures.isEmpty(Model) Then Return
                    If class_Procedures.isEmpty(Sub_Model) Then Return
                    If class_Procedures.isEmpty(Color) Then Return
                    If class_Procedures.isEmpty(Custom_Color) Then Return
                    If class_Procedures.isEmpty(Description) Then Return

                    If Not class_Procedures.actionAsk("Update Inventory", "Update unit inventory attributes", "You might update a wrong inventory attributes") Then Return

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@ID", ID.EditValue),
                        New SqlParameter("@Model_Code", Model_Code.Text.Trim),
                        New SqlParameter("@Brand", Brand.Text),
                        New SqlParameter("@Model", Model.Text.Trim),
                        New SqlParameter("@Sub_Model", Sub_Model.Text.Trim),
                        New SqlParameter("@Color", Color.Text.Trim),
                        New SqlParameter("@Custom_Color", Custom_Color.Text.Trim.ToUpper),
                        New SqlParameter("@Description", Description.Text.Trim),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "UPDATE_ATTRIBUTES")
                    }

                    class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Update Inventory attributes", Description.Text.Trim)

                Case 1
                    class_Saga_Procedures.Show_Unit_Inventory(Model_Code.EditValue.ToString)
            End Select
        End Sub

        Private Sub Sub_Model_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Sub_Model.ButtonClick
            If class_Saga_Variables.isAccounting AndAlso e.Button.Index.Equals(1) Then
                If class_Procedures.isEmpty(Sub_Model) Then Return

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Sub_Model", Sub_Model.Text.Trim),
                    New SqlParameter("@Unit_Cost", Convert.ToDecimal(Unit_Cost.Value)),
                    New SqlParameter("@Unit_SRP", Convert.ToDecimal(Unit_SRP.Value)),
                    New SqlParameter("@COD", Convert.ToDecimal(COD.Value)),
                    New SqlParameter("@LCP", Convert.ToDecimal(LCP.Value)),
                    New SqlParameter("@AOC", Convert.ToDecimal(AOC.Value)),
                    New SqlParameter("@DownPayment", Convert.ToDecimal(Down_Payment.Value)),
                    New SqlParameter("@Financed", Convert.ToDecimal(Financed.Value)),
                    New SqlParameter("@Rebates", Convert.ToDecimal(Rebates.Value)),
                    New SqlParameter("@InterestRate12", Convert.ToDecimal(Interest_Rate_12.Value)),
                    New SqlParameter("@Monthly12", Convert.ToDecimal(Monthly_12.Value)),
                    New SqlParameter("@InterestRate18", Convert.ToDecimal(Interest_Rate_18.Value)),
                    New SqlParameter("@Monthly18", Convert.ToDecimal(Monthly_18.Value)),
                    New SqlParameter("@InterestRate24", Convert.ToDecimal(Interest_Rate_24.Value)),
                    New SqlParameter("@Monthly24", Convert.ToDecimal(Monthly_24.Value)),
                    New SqlParameter("@InterestRate36", Convert.ToDecimal(Interest_Rate_36.Value)),
                    New SqlParameter("@Monthly36", Convert.ToDecimal(Monthly_36.Value)),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SYNC_SALE")
                }

                class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Update model sale values", Sub_Model.Text.Trim)
            End If
        End Sub
    End Class

End Namespace