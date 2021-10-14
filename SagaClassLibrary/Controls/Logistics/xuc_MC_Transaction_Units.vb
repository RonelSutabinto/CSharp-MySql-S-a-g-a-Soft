Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Controls.Logistics
    Public Class xuc_MC_Transaction_Units
        Private _transactiontype As String
        Friend Property TransactionType() As String
            Get
                Return _transactiontype
            End Get
            Set(value As String)
                _transactiontype = value
            End Set
        End Property

        Private _transactioncode
        Friend Property TransactionCode() As String
            Get
                Return _transactioncode
            End Get
            Set(value As String)
                _transactioncode = value
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

        Private _reference As String
        Friend Property Reference() As String
            Get
                Return _reference
            End Get
            Set(value As String)
                _reference = value
            End Set
        End Property

        Private _brand As String
        Friend Property Brand() As String
            Get
                Return _brand
            End Get
            Set(value As String)
                _brand = value
            End Set
        End Property

        Private _branchfrom As String
        Friend Property BranchFrom() As String
            Get
                Return _branchfrom
            End Get
            Set(value As String)
                _branchfrom = value
            End Set
        End Property

        Private _branchfromname As String
        Friend Property BranchFromName() As String
            Get
                Return _branchfromname
            End Get
            Set(value As String)
                _branchfromname = value
            End Set
        End Property

        Private _branchto As String
        Friend Property BranchTo() As String
            Get
                Return _branchto
            End Get
            Set(value As String)
                _branchto = value
            End Set
        End Property

        Private _branchtoname As String
        Friend Property BranchToName() As String
            Get
                Return _branchtoname
            End Get
            Set(value As String)
                _branchtoname = value
            End Set
        End Property

        Private _whcode As String
        Friend Property WHCode() As String
            Get
                Return _whcode
            End Get
            Set(value As String)
                _whcode = value
            End Set
        End Property

        Private _whcategory As String
        Friend Property WHCategory() As String
            Get
                Return _whcategory
            End Get
            Set(value As String)
                _whcategory = value
            End Set
        End Property

        Private _receivedDate As Date
        Friend Property ReceivedDate As Date
            Get
                Return _receivedDate
            End Get
            Set(value As Date)
                _receivedDate = value
            End Set
        End Property

        Private _transactiondate As Date
        Friend Property TransactionDate As Date
            Get
                Return _transactiondate
            End Get
            Set(value As Date)
                _transactiondate = value
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

        Friend sBrand, sModelCode, sModelName, sColor, sEngine, sChassis, sDescription As String
        Private dUnitCost As Decimal

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)

            class_Procedures.Initialize_gridView(gridView)

            btn_Preview_Units.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            'Control_Initialize()
            Me.Initialize_MC_Units(BranchTo)
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            gridView.AddNewRow()
        End Sub

        Private Sub gridView_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
            Dim view As Grid.GridView = TryCast(sender, Grid.GridView)

            view.SetRowCellValue(e.RowHandle, colBranch_Code, BranchTo)
            view.SetRowCellValue(e.RowHandle, colEngine, sEngine)
            view.SetRowCellValue(e.RowHandle, colChassis, sChassis)
            view.SetRowCellValue(e.RowHandle, colBrand, sBrand)
            view.SetRowCellValue(e.RowHandle, colModel_Code, sModelCode)
            view.SetRowCellValue(e.RowHandle, colModel, sModelName)
            view.SetRowCellValue(e.RowHandle, colColor, sColor)
            view.SetRowCellValue(e.RowHandle, colDescription, sDescription)

            view.BestFitColumns()
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)

                'btn_Delete.Enabled = Not sStatus.Contains("APPROV") Or Not sStatus.Contains("RECEIVED") Or Not sStatus.Contains("TRANSPORT")
                btn_Save.Enabled = (sStatus.Contains("APPROV") AndAlso class_Saga_Variables.isAccounting) Or (Not sStatus.Contains("APPROV") Or Not sStatus.Contains("Approved") Or Not sStatus.Contains("RECEIVED") Or Not sStatus.Contains("TRANSPORT"))

                btn_New_Unit_Model.Enabled = TransactionType.Equals("RECEIVING")
                btn_Add_To_PO.Enabled = class_Saga_Variables.isLogistics AndAlso TransactionType.Equals("RECEIVING")

                PopupMenu.ShowPopup(Control.MousePosition)
                btn_Preview_Units.Caption = $"Preview MC UNIT {TransactionType}"
            End If
        End Sub

        Friend Sub Initialize_MC_Units(Optional ByVal sCode As String = "000")
            gridView.OptionsBehavior.Editable = Status.Equals("PENDING") Or Status.Equals("DISAPPROVED")
            If gridView.OptionsBehavior.Editable Then
                colModel_Code.OptionsColumn.AllowEdit = TransactionType.Equals("RECEIVING")
                colModel_Code.ColumnEdit = Nothing

                Select Case TransactionType
                    Case "RECEIVING"
                        'class_Saga_Variables.Initialize_MC_PO_Units(BranchFromName)

                        If Not Status.Equals("APPROVED") Then
                            class_Saga_Variables.Initialize_MC_Models(False, Brand, True)
                            colModel_Code.ColumnEdit = RepositoryItemLookUpEdit_Model_Code
                            class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Model_Code)
                        End If

                    Case "TRANSFER", "CONVERT"
                        class_Saga_Variables.Initialize_MC_Units(sCode, True)

                    Case "DEPOSIT"
                        class_Saga_Variables.Initialize_MC_Units(sCode, False)
                End Select

                class_Saga_Procedures.Initialize_MC_Units(RepositoryItemLookUpEdit_Engine, "EngineNo")
                colEngine.ColumnEdit = RepositoryItemLookUpEdit_Engine

                class_Saga_Procedures.Initialize_MC_Units(RepositoryItemLookUpEdit_Chassis, "ChassisNo")
                colChassis.ColumnEdit = RepositoryItemLookUpEdit_Chassis
            End If
        End Sub

        Friend Sub Load_MC_Request_Units(ByVal sRequestCode As String)
            class_Procedures.Initialize_gridView(gridView)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Request_Code", sRequestCode),
                New SqlParameter("Action_Type", "LOAD_REQUEST_UNITS")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Request_Procedures", "inv_MC_Request_Units")
        End Sub

        Friend Sub Load_MC_Units()
            Dim bEditable As Boolean = Status.Equals("PENDING") Or Status.Equals("DISAPPROVED") 'Or Status.Equals("FOR TRANSPORT")

            btn_Initialize.Enabled = bEditable
            btn_New.Enabled = bEditable
            btn_Preview.Enabled = bEditable
            btn_Save.Enabled = bEditable
            btn_Delete.Enabled = bEditable

            btn_Preview_Units.Enabled = Not bEditable
            btn_Preview_Unit_Costing.Enabled = Not bEditable

            class_Procedures.Initialize_gridView(gridView, gridView.OptionsBehavior.Editable)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Transaction_Code", TransactionCode),
                New SqlParameter("@Reference", Reference),
                New SqlParameter("Action_Type", "LOAD_UNITS")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")

            If Not gridView.OptionsBehavior.Editable Then
                colEngine.ColumnEdit = Nothing
                colChassis.ColumnEdit = Nothing
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_MC_Units()
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If e.Clicks.Equals(2) AndAlso .DataRowCount > 0 Then
                    Dim sStatus As String = .GetFocusedRowCellDisplayText(colStatus)

                    Select Case e.Column.FieldName
                        Case "Model_Code"
                            class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                        Case "EngineNo", "ChassisNo", "KeyNo", "Inclusions", "Remarks", "Note"
                            .OptionsBehavior.Editable = class_Saga_Variables.isLogistics AndAlso (sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED"))
                            If e.Column.FieldName.Equals("EngineNo") AndAlso Not .OptionsBehavior.Editable Then
                                class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString,, True)
                            End If

                        Case "UnitCost", "TotalCost"
                            .OptionsBehavior.Editable = class_Saga_Variables.isAccounting AndAlso (sStatus.Equals("APPROVED") Or sStatus.Equals("Approved"))

                        Case Else
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
            With gridView
                Select Case e.KeyCode
                    Case Keys.Delete
                        Delete_Unit_Items()
                End Select
            End With
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

                sBrand = Brand
                gridView.SetFocusedRowCellValue(colBrand, Brand)

                sModelName = editor.GetColumnValue("modeldesc")
                gridView.SetFocusedRowCellValue(colModel, sModelName)

                sColor = editor.GetColumnValue("Color")
                gridView.SetFocusedRowCellValue(colColor, sColor)

                sDescription = editor.GetColumnValue("Description")
                gridView.SetFocusedRowCellValue(colDescription, sDescription)

                dUnitCost = Convert.ToDecimal(editor.GetColumnValue("Unit_Cost"))
                gridView.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Engine_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Engine.Validating
            If Not TransactionType.Equals("RECEIVING") Then
                Try
                    Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                    gridView.SetFocusedRowCellValue(colChassis, editor.GetColumnValue("ChassisNo"))
                    gridView.SetFocusedRowCellValue(colModel_Code, editor.GetColumnValue("Model_Code"))
                    gridView.SetFocusedRowCellValue(colBrand, editor.GetColumnValue("Brand"))
                    gridView.SetFocusedRowCellValue(colModel, editor.GetColumnValue("Model"))
                    gridView.SetFocusedRowCellValue(colColor, editor.GetColumnValue("Color"))
                    gridView.SetFocusedRowCellValue(colDescription, editor.GetColumnValue("Description"))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub RepositoryItemLookUpEdit_Chassis_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Chassis.Validating
            If Not TransactionType.Equals("RECEIVING") Then
                Try
                    Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                    gridView.SetFocusedRowCellValue(colEngine, editor.GetColumnValue("EngineNo"))
                    gridView.SetFocusedRowCellValue(colModel_Code, editor.GetColumnValue("Model_Code"))
                    gridView.SetFocusedRowCellValue(colBrand, editor.GetColumnValue("Brand"))
                    gridView.SetFocusedRowCellValue(colModel, editor.GetColumnValue("Model"))
                    gridView.SetFocusedRowCellValue(colColor, editor.GetColumnValue("Color"))
                    gridView.SetFocusedRowCellValue(colDescription, editor.GetColumnValue("Description"))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub RepositoryItemCalcEdit_Unit_Cost_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemCalcEdit_Unit_Item_Cost.Validating
            If TransactionType.Equals("RECEIVING") Then
                Try
                    Dim editor As DevExpress.XtraEditors.CalcEdit = CType(sender, DevExpress.XtraEditors.CalcEdit)
                    gridView.SetFocusedRowCellValue(colVAT, editor.Value * 0.12)
                    gridView.SetFocusedRowCellValue(colTotal_Cost, editor.Value + (editor.Value * 0.12))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub RepositoryItemCalcEdit_Unit_Item_Total_Cost_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemCalcEdit_Unit_Item_Total_Cost.Validating
            If TransactionType.Equals("RECEIVING") Then
                Try
                    Dim editor As DevExpress.XtraEditors.CalcEdit = CType(sender, DevExpress.XtraEditors.CalcEdit)
                    gridView.SetFocusedRowCellValue(colUnit_Cost, editor.Value / 1.12)
                    gridView.SetFocusedRowCellValue(colVAT, editor.Value - (editor.Value / 1.12))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Friend Sub Generate_MC_Units(ByVal sModelCode As String, ByVal iQuantity As Integer, ByVal iReceived As Integer)
            BranchFrom = class_Saga_Variables.sBranchCode
            Me.sModelCode = sModelCode

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Model_Code", sModelCode),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        sBrand = myDataReader("branddesc").ToString
                        sEngine = myDataReader("EnginePrefix").ToString
                        sChassis = myDataReader("ChassisPrefix").ToString
                        sColor = myDataReader("Custom_Color").ToString
                        sModelName = myDataReader("modeldesc").ToString
                        sDescription = $"{myDataReader("branddesc")} {myDataReader("modeldesc")} {myDataReader("Custom_Color")}"
                    Catch ex As Exception

                    End Try
                End If
            End Using

            Dim iRemaining As Integer = iQuantity - iReceived

            Dim iUnits As Integer = class_Functions.Show_Input_Box("Input number of Units to Receive", "Receive Unit", iRemaining)
            'temporary suspended in order to accomodate all the receiving mc units without restrictions
            'If iUnits <= 0 OrElse iUnits > iRemaining Then
            '    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Invalid Number.{Environment.NewLine}Please input actual units received between 1 to {iRemaining}", "Number Error", True)
            '    Return
            'End If

            For i As Integer = 1 To iUnits
                gridView.AddNewRow()
            Next
        End Sub

        Private Sub btn_Add_To_PO_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Add_To_PO.ItemClick
            class_Saga_Database.Add_To_PO(OrderCode, gridView.GetFocusedRowCellValue(colBranch_Code), gridView.GetFocusedRowCellValue(colModel_Code))
        End Sub

        Private Sub btn_New_Unit_Model_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Unit_Model.ItemClick
            class_Saga_Procedures.Show_Unit_Model(String.Empty)
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Save_MC_Units()
        End Sub

        Friend Sub Save_MC_Units()
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        Dim iID As Integer
                        Try
                            iID = .GetRowCellValue(iRowHandle, colID)
                        Catch ex As Exception
                            iID = 0
                        End Try

                        If iID = 0 AndAlso TransactionType.Equals("RECEIVING") AndAlso class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT EngineNo FROM item_Details WHERE EngineNo LIKE '{ .GetRowCellValue(iRowHandle, colEngine)}'") Then
                            Dim sError As String = "Engine already exist!"
                            .SetRowCellValue(iRowHandle, colDescription, sError)
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sError, "Engine Error")
                            .BestFitColumns()
                            Continue For
                        End If

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "MC Unit Save/Update", "saved/updated") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@ID", iID),
                                New SqlParameter("@Transaction_Type", TransactionType),
                                New SqlParameter("@Transaction_Code", TransactionCode),
                                New SqlParameter("@Order_Code", OrderCode),
                                New SqlParameter("@Reference", Reference),
                                New SqlParameter("@Transaction_Date", TransactionDate),
                                New SqlParameter("@Received_Date", TransactionDate),
                                New SqlParameter("@Supplier_Code", BranchFrom),
                                New SqlParameter("@Supplier_Name", BranchFromName),
                                New SqlParameter("@Branch_Code", .GetRowCellValue(iRowHandle, colBranch_Code)),
                                New SqlParameter("@Model_Code", .GetRowCellValue(iRowHandle, colModel_Code)),
                                New SqlParameter("@Engine", .GetRowCellValue(iRowHandle, colEngine)),
                                New SqlParameter("@Chassis", .GetRowCellValue(iRowHandle, colChassis)),
                                New SqlParameter("@Key_Number", .GetRowCellValue(iRowHandle, colKeyNumber)),
                                New SqlParameter("@Inclusions", .GetRowCellValue(iRowHandle, colInclusions)),
                                New SqlParameter("@Unit_Cost", .GetRowCellValue(iRowHandle, colUnit_Cost)),
                                New SqlParameter("@Unit_VAT", .GetRowCellValue(iRowHandle, colVAT)),
                                New SqlParameter("@Unit_Total_Cost", .GetRowCellValue(iRowHandle, colTotal_Cost)),
                                New SqlParameter("@Unit_Status", WHCode),
                                New SqlParameter("@Unit_Category", WHCategory),
                                New SqlParameter("@Remarks", .GetRowCellDisplayText(iRowHandle, colRemarks)),
                                New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, colNotes)),
                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Action_Type", TransactionType)
                            }
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "MC Unit Save/Update")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next

                    Dim parametersTotal As SqlParameter() = {
                            New SqlParameter("@Transaction_Code", TransactionCode),
                            New SqlParameter("@Reference", Reference),
                            New SqlParameter("@Action_Type", "UPDATE_TOTAL")
                        }
                    class_Database.Procedure_Save(class_Database.ICSConnection, parametersTotal, "inv_Receive_Transfer_Procedures", "Update Total")

                    If Not class_Database.DBError Then
                        Load_MC_Units()
                    End If
                End If
            End With
        End Sub

        Private Sub Delete_Unit_Items()
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Delete Unit Items", "Delete selected unit items", "You might delete wrong unit items") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Unit Item Delete", "deleted") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Try
                            Try
                                iID = .GetRowCellValue(iRowHandle, colID)
                            Catch ex As Exception
                                Continue For
                            End Try

                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@ID", iID),
                                New SqlParameter("@Action_Type", "UNIT_DELETE")
                            }

                            class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Delete Unit Item")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next
                    .DeleteSelectedRows()
                End If
            End With
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Delete_Unit_Items()
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Update.ItemClick
            Select Case TransactionType
                Case "DEPOSIT"
                    MC_Unit_Actions("DEPOSIT_MC_UNIT")
            End Select
        End Sub

        Friend Sub MC_Unit_Actions(ByVal sActionType As String)
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "MC Unit action", "updated") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@ID", .GetRowCellValue(iRowHandle, colID)),
                                New SqlParameter("@Engine", .GetRowCellDisplayText(iRowHandle, colEngine)),
                                New SqlParameter("@Action_Type", sActionType)
                            }
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "MC Unit Command")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next
                End If
            End With
        End Sub

        Friend Sub Control_Preview_Units()
            Try
                Select Case TransactionType
                    Case "RECEIVING"
                        Dim xRpt As New Reports.Logistics.xrpt_Receive_Units()

                        With xRpt
                            .PaperKind = System.Drawing.Printing.PaperKind.Custom
                            .PageWidth = 850
                            .PageHeight = 1300

                            Dim sBrand() = BranchFromName.Split(" ")
                            .Brand.Text = sBrand(0)
                            .Dealer.Text = BranchFromName
                            .Dealer_Address.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Account_Code, Account_Address FROM acc_Account_Names WHERE Account_Code LIKE '{BranchFrom}'", "Account_Address")

                            .Transaction_Code.Text = TransactionCode
                            .Transaction_Date.Text = $"{TransactionDate:MMMM dd, yyyy}"

                            .Order_Code.Text = OrderCode

                            Dim dtOrderDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Order_Code, Order_Date FROM inv_Purchase_Orders WHERE Order_Code LIKE '{OrderCode}'", "Order_Date"))
                            .Order_Date.Text = dtOrderDate.ToString("MMMM dd, yyyy")

                            .Reference.Text = Reference
                            .Received_Date.Text = $"{ReceivedDate:MMMM dd, yyyy}"
                        End With

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Transaction_Code", TransactionCode),
                            New SqlParameter("@Reference", Reference),
                            New SqlParameter("@Action_Type", "LOAD_UNITS")
                        }
                        class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Receive_Transfer_Procedures", "item_Details")

                    Case "TRANSFER", "OUTGOING"
                        Dim xRpt As New Reports.Logistics.xrpt_Transfer_Units()

                        With xRpt
                            .PaperKind = System.Drawing.Printing.PaperKind.Custom
                            .PageWidth = 850
                            .PageHeight = 1300

                            If BranchFrom.Equals("000") Then
                                .Document_Title.Text = "MC TRANSMITTAL REPORT"
                            Else
                                .Document_Title.Text = "MC INTER-BRANCH TRANSFER"
                            End If

                            .Transaction_Code.Text = TransactionCode
                            .Reference.Text = Reference
                            .Branch_From_To.Text = $"{BranchFromName} - {BranchToName}"

                            .Transaction_Date.Text = $"{TransactionDate:MMMM dd, yyyy}"
                            .WareHouse_Category.Text = WHCategory

                            .Confirmed_Personnel.Text = class_Saga_Database.get_Branch_Manager(gridView.GetFocusedRowCellValue(colBranch_Code))
                        End With

                        Dim sqlParameters As SqlParameter() = {
                           New SqlParameter("@Transaction_Code", TransactionCode),
                           New SqlParameter("@Reference", Reference),
                           New SqlParameter("@Action_Type", "LOAD_UNITS")
                       }
                        class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Receive_Transfer_Procedures", "item_Details")

                    Case "DEPOSIT"
                        Dim xRpt As New Reports.Logistics.xrpt_Transfer_Units()

                        With xRpt
                            .PaperKind = System.Drawing.Printing.PaperKind.Custom
                            .PageWidth = 850
                            .PageHeight = 1300

                            .Document_Title.Text = "MC DEPOSIT REPORT"

                            .Transaction_Code.Text = TransactionCode
                            .Reference.Text = Reference
                            .Branch_From_To.Text = $"{BranchFromName}"

                            .Transaction_Date.Text = $"{TransactionDate:MMMM dd, yyyy}"
                            .WareHouse_Category.Text = WHCategory

                            .Delivered_By.Visible = False
                            .Delivered_Line.Visible = False

                            .Received_By.Visible = False
                            .Received_Line.Visible = False

                            .Confirmed_By.Visible = False
                            .Confirmed_Personnel.Visible = False
                            .Confirmed_Position.Visible = False

                            .Remarks_Line1.Visible = False
                            .Remarks_Line2.Visible = False
                            .Remarks_Line3.Visible = False
                            .Remarks_Notes.Visible = False

                            .Acknowledged_By.Visible = False
                        End With

                        Dim sqlParameters As SqlParameter() = {
                           New SqlParameter("@Transaction_Code", TransactionCode),
                           New SqlParameter("@Reference", Reference),
                           New SqlParameter("@Action_Type", "LOAD_UNITS")
                       }
                        class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Receive_Transfer_Procedures", "item_Details")
                End Select
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Preview_Units_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Preview_Units.ItemClick
            Control_Preview_Units()
        End Sub

        Friend Sub Control_Preview_Costing()
            Try
                Dim xRpt As New Reports.Logistics.xrpt_Unit_Costing()
                class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Inventory WHERE Transcode LIKE '{TransactionCode}' AND RefNo LIKE '{Reference}'", "view_Inventory")

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    Dim sBrand() = BranchFromName.Split(" ")
                    .Brand.Text = sBrand(0)
                    .Dealer.Text = BranchFromName
                    .Dealer_Address.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Account_Code, Account_Address FROM acc_Account_Names WHERE Account_Code LIKE '{BranchFrom}'", "Account_Address")

                    .Transaction_Code.Text = TransactionCode
                    .Transaction_Date.Text = $"{TransactionDate:MMMM dd, yyyy}"

                    .Order_Code.Text = OrderCode

                    .Reference.Text = Reference
                    .Received_Date.Text = $"{ReceivedDate:MMMM dd, yyyy}"

                    Dim dtOrderDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Order_Code, Order_Date FROM inv_Purchase_Orders WHERE Order_Code LIKE '{OrderCode}'", "Order_Date"))
                    .Order_Date.Text = dtOrderDate.ToString("MMMM dd, yyyy")
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Friend Sub btn_Preview_Unit_Costing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Preview_Unit_Costing.ItemClick
            Control_Preview_Costing()
        End Sub
    End Class
End Namespace