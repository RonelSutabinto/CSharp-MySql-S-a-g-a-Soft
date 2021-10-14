Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Controls.Logistics
    Public Class xuc_Purchase_Order_Units
        Private _brand As String
        Friend Property Brand() As String
            Get
                Return _brand
            End Get
            Set(ByVal value As String)
                _brand = value
            End Set
        End Property

        Private _allbrands
        Friend Property AllBrand As Boolean
            Get
                Return _allbrands
            End Get
            Set(value As Boolean)
                _allbrands = value
            End Set
        End Property

        Private _ordercode As String
        Friend Property OrderCode() As String
            Get
                Return _ordercode
            End Get

            Set(value As String)
                _ordercode = value
            End Set
        End Property

        Private _status As String
        Friend Property Status() As String
            Get
                Return _status
            End Get

            Set(value As String)
                _status = value
            End Set
        End Property

        Private _freightcost As Decimal
        Friend Property FreightCost() As Decimal
            Get
                Return _freightcost
            End Get

            Set(value As Decimal)
                _freightcost = value
            End Set
        End Property

        Private _perunit As Boolean
        Friend Property PerUnit() As Boolean
            Get
                Return _perunit
            End Get

            Set(value As Boolean)
                _perunit = value
            End Set
        End Property

        Dim sBrCode, sModelCode, sModelName, sColor, sDescription As String
        Dim iQuantity As Integer
        Dim dUnitCost As Decimal
        Dim dFreight As Decimal = 0

        Public Sub New()
            InitializeComponent()

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

            sBrCode = class_Saga_Variables.sBranchCode
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)
        End Sub

        Friend Sub Load_MC_Orders()
            Try
                Dim bEditable As Boolean = Status.Equals("PENDING") Or Status.Equals("DISAPPROVED")

                btn_Initialize.Enabled = bEditable
                btn_New.Enabled = bEditable
                btn_Preview.Enabled = bEditable
                btn_Save.Enabled = bEditable
                btn_Delete.Enabled = bEditable

                class_Saga_Variables.Initialize_MC_Models(AllBrand, Brand, True)
                class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Model_Code)
                class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Model, "modeldesc")

                class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Model_Code, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
                class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Model, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
                class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Color, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)

                class_Procedures.Initialize_gridView(gridView, bEditable, bEditable)

                colUnit_Cost.Visible = Not bEditable
                colTotal_Cost.Visible = Not bEditable
                colFreight_Cost.Visible = Not bEditable
                colFreight_Cost_Total.Visible = Not bEditable
                colGrand_Total.Visible = Not bEditable
                colFreight_Cost_Received.Visible = Not bEditable
                colTotal_Cost_Received.Visible = Not bEditable
                colDue_Date.Visible = Not bEditable
                colTotal_Cost_Remaining.Visible = Not bEditable

                Dim parametersPO As SqlParameter() = {
                    New SqlParameter("@Order_Code", OrderCode),
                    New SqlParameter("Action_Type", "LOAD_PO_UNITS")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, parametersPO, gridControl, gridView, "inv_Purchase_Order_Procedures", "inv_Purchase_Order_Units")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Model_Code"
                        class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                    Case "Unit_Received"
                        Dim sBrCode As String = gridView.GetFocusedRowCellValue(colBranch_Code)
                        Dim sModelCode As String = gridView.GetFocusedRowCellDisplayText(colModel_Code)
                        class_Saga_Procedures.Show_Unit_Inventory($"SELECT * FROM item_Details WHERE POno LIKE '{OrderCode}' AND branchcode LIKE '{sBrCode}' AND Model_Code LIKE '{sModelCode}'", $"{OrderCode} {sModelCode}")

                    Case Else
                        If e.CellValue IsNot Nothing Then
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        End If
                End Select
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
            With gridView
                Select Case e.KeyCode
                    Case Keys.Insert
                        .AddNewRow()

                    Case Keys.Delete
                        If Status.Equals("PENDING") AndAlso class_Saga_Variables.isLogistics Then
                            Try
                                Dim sqlParameters As SqlParameter() = {
                                    New SqlParameter("@ID", .GetFocusedRowCellValue(colID)),
                                    New SqlParameter("@Action_Type", "DELETE_UNIT_ORDER")
                                }

                                If class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Delete Order Unit", True) Then
                                    .DeleteSelectedRows()
                                End If
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If
                End Select
            End With
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub RepositoryItemLookUpEdit_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Branch.EditValueChanged
            Try
                sBrCode = CType(sender, BaseEdit).EditValue.ToString
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Model_Code_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Model_Code.EditValueChanged
            Try
                sModelCode = CType(sender, BaseEdit).EditValue.ToString
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Model_Code_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Model_Code.Validating
            Try
                Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)

                sModelName = editor.GetColumnValue("modeldesc")
                gridView.SetFocusedRowCellValue(colModel_Name, sModelName)

                sColor = editor.GetColumnValue("Color")
                gridView.SetFocusedRowCellValue(colUnit_Color, sColor)

                sDescription = editor.GetColumnValue("Description")
                gridView.SetFocusedRowCellValue(colUnit_Description, sDescription)

                dUnitCost = Convert.ToDecimal(editor.GetColumnValue("Unit_Cost"))
                gridView.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Model_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Model.EditValueChanged
            Try
                sModelName = CType(sender, BaseEdit).EditValue.ToString
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Model_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Model.Validating
            Try
                Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                sModelCode = editor.GetColumnValue("Model_Code")
                gridView.SetFocusedRowCellValue(colModel_Code, sModelCode)

                sColor = editor.GetColumnValue("Color")
                gridView.SetFocusedRowCellValue(colUnit_Color, sColor)

                sDescription = editor.GetColumnValue("Description")
                gridView.SetFocusedRowCellValue(colUnit_Description, sDescription)

                dUnitCost = Convert.ToDecimal(editor.GetColumnValue("Unit_Cost"))
                gridView.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
            Try
                iQuantity = CType(sender, BaseEdit).EditValue
            Catch ex As Exception
            End Try
        End Sub

        Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
            Try
                With gridView
                    Select Case e.Column.Name
                        Case "colQuantity", "colFreight_Cost2"
                            Dim dTotalCost As Decimal = .GetFocusedRowCellValue(colUnit_Cost) * .GetFocusedRowCellValue(colQuantity)
                            Dim dGrandTotal As Decimal = (.GetFocusedRowCellValue(colUnit_Cost) + .GetFocusedRowCellValue(colFreight_Cost)) * .GetFocusedRowCellValue(colQuantity)
                            .SetRowCellValue(e.RowHandle, colTotal_Cost, dTotalCost)
                            .SetRowCellValue(e.RowHandle, colGrand_Total, dGrandTotal)

                        Case "colUnit_Cost"
                            dUnitCost = .GetFocusedRowCellValue(colUnit_Cost)
                    End Select
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub gridView_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
            Dim view As Grid.GridView = TryCast(sender, Grid.GridView)

            view.SetRowCellValue(e.RowHandle, colBranch_Code, sBrCode)
            view.SetRowCellValue(e.RowHandle, colModel_Code, sModelCode)
            view.SetRowCellValue(e.RowHandle, colModel_Name, sModelName)
            view.SetRowCellValue(e.RowHandle, colUnit_Color, sColor)
            view.SetRowCellValue(e.RowHandle, colUnit_Cost, dUnitCost)
            view.SetRowCellValue(e.RowHandle, colFreight_Cost, dFreight)
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_MC_Orders()
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            gridView.AddNewRow()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Save_Item_Orders()
        End Sub

        Friend Sub Save_Item_Orders()
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim iID, iQty As Integer

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        Try
                            If .GetRowCellValue(i, colID).Equals(Nothing) Then Return

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Unit Order update", "updated") Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Try
                                iID = .GetRowCellValue(iRowHandle, colID)
                            Catch ex As Exception
                                iID = 0
                            End Try

                            Try
                                iQty = .GetRowCellValue(iRowHandle, colQuantity)
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                                Continue For
                            End Try

                            Dim UnitParameters As SqlParameter() = {
                                New SqlParameter("@ID", iID),
                                New SqlParameter("@Order_Code", OrderCode),
                                New SqlParameter("@Branch_Code", .GetRowCellValue(iRowHandle, colBranch_Code)),
                                New SqlParameter("@Model_Code", .GetRowCellValue(iRowHandle, colModel_Code)),
                                New SqlParameter("@Quantity", .GetRowCellValue(iRowHandle, colQuantity)),
                                New SqlParameter("@Unit_Cost", .GetRowCellValue(iRowHandle, colUnit_Cost)),
                                New SqlParameter("@Freight_Cost", FreightCost),
                                New SqlParameter("@Is_Per_Unit", PerUnit),
                                New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, colNotes)),
                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Action_Type", "SAVE_ITEM")
                            }

                            class_Database.Procedure_Save(class_Database.ICSConnection, UnitParameters, "inv_Purchase_Order_Procedures", "Purchase Item Unit")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next

                    Dim sqlParameters As SqlParameter()

                    If OrderCode.Contains("MCREQ") Then
                        sqlParameters = {
                            New SqlParameter("@Request_Code", OrderCode),
                            New SqlParameter("@Action_Type", "UPDATE_QUANTITY")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_MC_Request_Procedures", "Update MC Request Quantity")
                    Else
                        sqlParameters = {
                            New SqlParameter("@Order_Code", OrderCode),
                            New SqlParameter("@Action_Type", "UPDATE")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Update Purchase Order Profile")
                    End If

                    If Not class_Database.DBError Then
                        Load_MC_Orders()
                    End If
                End If
            End With
        End Sub

        Private Sub btn_Re_Count_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Re_Count.ItemClick
            MC_Order_Recount()
        End Sub

        Friend Sub MC_Order_Recount()
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer

                    class_Database.Data_Update(class_Database.ICSConnection, $"Update item_Details SET Is_Verified = 0 WHERE PONo LIKE '{OrderCode}'")

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Unit Order recount", "recounted") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@Order_Code", OrderCode),
                                New SqlParameter("@Branch_Code", .GetRowCellValue(iRowHandle, colBranch_Code)),
                                New SqlParameter("@Model_Code", .GetRowCellDisplayText(iRowHandle, colModel_Code)),
                                New SqlParameter("@Action_Type", "RECOUNT_UNITS")
                            }
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Recount Purchase Order")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next

                    Dim ParametersPO As SqlParameter() = {
                        New SqlParameter("@Order_Code", OrderCode),
                        New SqlParameter("@Action_Type", "RECOUNT_PO")
                    }
                    class_Database.Procedure_Save(class_Database.ICSConnection, ParametersPO, "inv_Purchase_Order_Procedures", "Recount Purchase Order")

                    Load_MC_Orders()
                End If
            End With
        End Sub
    End Class
End Namespace