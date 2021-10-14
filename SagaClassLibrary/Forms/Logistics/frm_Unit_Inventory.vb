Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics

    Public Class frm_Unit_Inventory
        Inherits DevExpress.XtraEditors.XtraForm

        Dim bLoopStop As Boolean
        Dim sSearch As String

        Public Sub New()
            If Me.xuc_Unit_Inventory Is Nothing Then
                Me.xuc_Unit_Inventory = New Controls.Logistics.xuc_Unit_Inventory()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Unit_Inventory.layoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            btn_Delete.Enabled = class_Saga_Variables.isLogistics
            btn_Multiple_Existing.Enabled = class_Saga_Variables.isLogistics
            btn_All_MC_Units.Enabled = class_Saga_Variables.isLogistics
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Unit_Inventory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEditBranch)
            class_Saga_Procedures.Initialize_Branch(xuc_Unit_Inventory.Branch_From)

            barEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
            barEditItem_Branch.Enabled = class_Saga_Variables.isLogistics

            btn_All_MC_Units.Enabled = class_Saga_Variables.isLogistics
            Bar_Journal.Visible = class_Saga_Variables.isAccounting
            toggle_Syncronize.Enabled = class_Saga_Variables.isLogistics

            xuc_Unit_Inventory.If_Exist.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Reference.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Branch_From.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Branch_To.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Brand.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Model.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Color.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Description.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Category.ReadOnly = Not class_Saga_Variables.isLogistics
            xuc_Unit_Inventory.Inventory_Status.ReadOnly = Not class_Saga_Variables.isLogistics
        End Sub

        Private Sub frm_Unit_Inventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Unit_Inventory.Control_Initialize()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Unit_Inventory.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Unit_Inventory_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Unit_Inventory.Control_Initialize()
        End Sub

        Private Sub Data_Load(Optional ByVal sBranch As String = "000")
            If BarEditItem_Search.EditValue Is Nothing Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", sBranch),
                    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "LOAD_INVENTORY")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")
            Else
                sSearch = BarEditItem_Search.EditValue.ToString
                If sSearch.Length > 0 Then
                    Load_Search(BarEditItem_Search.EditValue.ToString.Trim)
                End If
            End If

            gridView.ClearGrouping()
            colID.SortIndex = 0
        End Sub

        'Friend Sub Load_Search(ByVal sSearch As String)
        '    If sSearch.Length > 2 Then
        '        Dim sqlParameters As SqlParameter() = {
        '            New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
        '            New SqlParameter("@Search", sSearch),
        '            New SqlParameter("@Action_Type", "LOAD_INV_SEARCH")
        '        }
        '        class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")

        '        gridView.ClearSorting()
        '        gridView.ClearGrouping()
        '        colID.SortIndex = 0
        '    End If
        'End Sub

        Friend Sub Load_Search(ByVal sSearch As String, Optional ByVal bReference As Boolean = False)
            If sSearch.Length > 2 Then
                Dim sActionType As String
                If bReference Then
                    sActionType = "LOAD_REFERENCE"
                Else
                    sActionType = "LOAD_INV_SEARCH"
                End If

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", sActionType)
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")

                gridView.ClearSorting()
                gridView.ClearGrouping()
                colID.SortIndex = 0
            End If
        End Sub

        Friend Sub Load_Query(ByVal sQuery As String)
            gridView.ClearGrouping()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQuery, "item_Details")
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load(barEditItem_Branch.EditValue.ToString)
        End Sub

        Private Sub btn_All_MC_Units_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_All_MC_Units.ItemClick
            gridView.ClearGrouping()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_MC_UNITS")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")
        End Sub

        Private Sub btn_Existing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Multiple_Existing.ItemClick
            gridView.ClearGrouping()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_MULTIPLE")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")
        End Sub

        Private Sub btn_Physical_Count_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Physical_Count.ItemClick
            gridView.ClearGrouping()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                New SqlParameter("@Action_Type", "LOAD_EXISTING")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Details")

            colBranchCode.GroupIndex = 0
            colWHCode.GroupIndex = 1
            colID.BestFit()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Unit_Inventory.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load(barEditItem_Branch.EditValue.ToString)
                'Update_Data_Row()
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Unit_Inventory
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .If_Exist.IsOn = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIfExist))
                    .Transaction_Code.Text = gridView.GetFocusedRowCellDisplayText(colTranscode)
                    .Purchase_Order.Text = gridView.GetFocusedRowCellDisplayText(colPoNo)
                    .Reference.Text = gridView.GetFocusedRowCellDisplayText(colRefNo)
                    .Branch_From.EditValue = gridView.GetFocusedRowCellValue(colBranchCodeFrom)
                    .Branch_To.EditValue = gridView.GetFocusedRowCellValue(colBranchCode)
                    .Category.EditValue = gridView.GetFocusedRowCellDisplayText(colWHCode)
                    .Model_Code.EditValue = gridView.GetFocusedRowCellValue(colModel_Code)
                    .Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand)
                    .Model.Text = gridView.GetFocusedRowCellDisplayText(colModel)
                    .Color.Text = gridView.GetFocusedRowCellDisplayText(Color)
                    .Engine.Text = gridView.GetFocusedRowCellDisplayText(colEngineNo)
                    .Chassis.Text = gridView.GetFocusedRowCellDisplayText(colChassisNo)
                    .Description.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                    .Inventory_Status.Text = gridView.GetFocusedRowCellDisplayText(colInventoryStatus)
                    .Remarks.Text = gridView.GetFocusedRowCellDisplayText(colRemarks)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNote)
                    .Unit_Price.Value = gridView.GetFocusedRowCellValue(colUnitPrice)
                End With
            End If
        End Sub

        Private Sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
            Data_Show()
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView.MouseDown
            If (gridView.RowCount > 0) AndAlso e.Button.Equals(MouseButtons.Right) Then
                btn_Add_To_PO.Enabled = class_Saga_Variables.isLogistics
                btn_Journal_Entries.Enabled = class_Saga_Variables.isAccounting
                btn_Journal.Enabled = class_Saga_Variables.isAccounting
                btn_Verify.Enabled = class_Saga_Variables.isAccounting
                btn_Stop.Enabled = class_Saga_Variables.isAccounting

                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If (.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                    Select Case e.Column.Name
                        Case "colprevID"
                            If class_Saga_Variables.isLogistics Then
                                Dim iID As Integer = Convert.ToInt32(.GetRowCellValue(.FocusedRowHandle, colID))
                                If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET prevID = '{iID}' WHERE id LIKE '{iID}'") Then
                                    .SetRowCellValue(.FocusedRowHandle, colprevID, iID)
                                End If
                            End If

                        Case "colIfExist"
                            If class_Saga_Variables.isLogistics Then
                                Dim iExist As Integer = Convert.ToInt32(Not Convert.ToBoolean(.GetRowCellValue(.FocusedRowHandle, colIfExist)))
                                If iExist < 0 Then iExist = 1
                                Dim iID As Integer = Convert.ToInt32(.GetRowCellValue(.FocusedRowHandle, colID))
                                If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET IfExist = {iExist} WHERE id LIKE '{iID}'") Then
                                    gridView.SetRowCellValue(.FocusedRowHandle, colIfExist, iExist)
                                End If
                            End If

                        Case "colAccountNumber", "colLedgerSetNumber"
                            If class_Saga_Variables.isAccounting Then
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, .GetRowCellDisplayText(.FocusedRowHandle, colAccountNumber), .GetRowCellDisplayText(.FocusedRowHandle, colLedgerSetNumber), .GetRowCellDisplayText(.FocusedRowHandle, colAccountName))
                            End If

                        Case "colTranscode", "colPoNo", "colRefNo", "colChassisNo"
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        Case "colCode"
                            If class_Saga_Variables.isLogistics Then
                                class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)
                            End If

                        Case "colModel_Code"
                            Try
                                Dim sModelCode As String = e.CellValue.ToString

                                If sModelCode.Length > 0 Then
                                    If class_Saga_Variables.isLogistics Then
                                        class_Saga_Procedures.Show_Unit_Model(sModelCode)
                                    End If
                                Else
                                    Dim sDescription As String = gridView.GetFocusedRowCellDisplayText(colDescription)
                                    Dim sModelCodeNew As String = class_Functions.Show_Input_Box("Input New Model Code", "New Model Code", String.Empty)

                                    If sModelCodeNew.Length = 0 Then Return

                                    If class_Saga_Variables.isLogistics AndAlso class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Model_Code FROM maint_model WHERE Model_Code LIKE '{sModelCodeNew}'") Then
                                        class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE item_Details SET Model_Code = '{sModelCodeNew}' WHERE Description LIKE '{sDescription}'", True, "New Model Code", "update New Model Code")
                                    End If
                                End If
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try

                        Case "colEngineNo"
                            If class_Saga_Variables.isAccounting Then
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Engine, e.CellValue.ToString, 1)
                            End If

                        Case "colTransactedBy"
                            If class_Variables.isAdministrator Then
                                class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)
                            End If

                        Case Else
                            Data_Show()

                            If e.CellValue Is Nothing Then
                                Return
                            Else
                                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                            End If
                    End Select
                End If
            End With
        End Sub

        Private Sub generate_MC_History(ByVal bAsk As Boolean)
            With gridView
                If .DataRowCount > 0 Then
                    If bAsk AndAlso Not class_Procedures.actionAsk("Generate", "Generate Existing Units", "You might generate a wrong Existing Units") Then Return

                    .ClearSorting()
                    .ClearGrouping()

                    colID.SortIndex = 0

                    Dim iID As Integer
                    Dim iIDPrev As Integer
                    Dim sEngine = .GetRowCellDisplayText(0, colEngineNo)

                    For i As Integer = 0 To .DataRowCount - 1
                        .FocusedRowHandle = i

                        Dim sStatus As String = .GetRowCellDisplayText(i, colInventoryStatus)

                        If Not sStatus.Equals("APPROVED") And Not sStatus.Equals("Approved") Then Continue For

                        Dim sEngineTemp As String = .GetRowCellDisplayText(i, colEngineNo)

                        If sEngineTemp.Length > 0 AndAlso Not sEngine.Equals(sEngineTemp) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "You cannot Generate with different Engine.", "Generation Error", True)
                            Return
                        End If

                        iID = Convert.ToInt32(.GetRowCellValue(i, colID))
                        If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET prevID = '{iIDPrev}' WHERE id LIKE '{iID}'") Then
                            .SetRowCellValue(i, colprevID, iIDPrev)
                            iIDPrev = iID
                        End If

                        'If i < .RowCount - 1 Then
                        '    If Convert.ToInt32(gridView.GetRowCellValue(i, colIfExist)).Equals(1) Then
                        '        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET IfExist = 0 WHERE id LIKE '{iID}'")
                        '        .SetRowCellValue(i, colIfExist, 0)
                        '    End If
                        'End If
                    Next

                    class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET ID = '{ .GetRowCellValue(.FocusedRowHandle, colprevID)}' WHERE EngineNO LIKE '{sEngine}' AND OutstandingBalance > 0 AND AccountStatus NOT LIKE 'Closed'")
                End If
            End With
        End Sub

        Private Sub btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            generate_MC_History(True)
        End Sub

        Private Sub btn_Syncronize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Syncronize.ItemClick
            If xuc_Unit_Inventory.Control_Syncronize(toggle_Syncronize.Checked, gridView.GetFocusedRowCellDisplayText(colModel), gridView.GetFocusedRowCellDisplayText(Color)) Then
                Data_Load(barEditItem_Branch.EditValue.ToString)
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Unit_Inventory.Control_Delete() AndAlso Me.xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load(barEditItem_Branch.EditValue.ToString)
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.Delete
                        If xuc_Unit_Inventory.Control_Delete() AndAlso Me.xuc_Settings.Toggle_Auto_Reload.IsOn Then
                            Data_Load(barEditItem_Branch.EditValue.ToString)
                        End If
                End Select
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            If Not class_Procedures.actionAsk("Update Unit Cost and VAT Amounts", "take a while") Then Return
            With gridView
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                If xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()
                class_Database.DBError = False
                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Item Update", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "note") Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Using frm As New frm_Unit_Inventory()
                        frm.Show()
                        frm.Hide()
                        frm.BarEditItem_Search.EditValue = .GetRowCellDisplayText(iRowHandle, colChassisNo)
                        frm.Data_Load()
                        frm.generate_MC_History(False)
                    End Using

                    'class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET IfExist = { .GetRowCellValue(iRowHandle, colIfExist)} WHERE id LIKE '{ .GetRowCellValue(iRowHandle, colID)}'")

                    'Dim iTableID As Integer = Convert.ToInt32(.GetRowCellValue(iRowHandle, colid))
                    'Dim sEngine As String = .GetRowCellDisplayText(iRowHandle, colEngineNo)
                    'Dim sWhCode As String = .GetRowCellDisplayText(iRowHandle, colwhCode)

                    'Dim dUnitCost, dVAT, dTotalCost As Decimal

                    'Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT TOP 1 unitcost, vatamt, totalcost, EngineNo FROM item_Details WHERE EngineNo LIKE '{sEngine}' ORDER BY unitcost DESC")
                    '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    '        Try
                    '            myDataReader.Read()
                    '            dUnitCost = convert.todecimal(myDataReader("unitcost"))
                    '            dVAT = convert.todecimal(myDataReader("vatamt"))
                    '            dTotalCost = convert.todecimal(myDataReader("totalcost"))
                    '        Catch ex As Exception
                    '            class_Procedures.Show_Error(ex)
                    '        End Try
                    '    End If
                    'End Using

                    'If dUnitCost > 0 AndAlso class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET unitcost = '{dUnitCost}', vatamt = '{dVAT}', totalcost = '{dTotalCost}' WHERE id LIKE '{iTableID}'") Then
                    '    .SetRowCellValue(iRowHandle, colunitcost, dUnitCost)
                    '    .SetRowCellValue(iRowHandle, colvatamt, dVAT)
                    '    .SetRowCellValue(iRowHandle, coltotalcost, dTotalCost)
                    'End If

                    'Dim sPostedBy As String = Nothing
                    'Dim sTransactedBy As String = Nothing
                    'Dim dtApproved As DateTime
                    'Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colRefNo)
                    'Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT RefNo, OriginatingMaker, approver, dateReceived FROM item_Master WHERE RefNo LIKE '{sReference}'")
                    '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    '        Try
                    '            myDataReader.Read()
                    '            sPostedBy = myDataReader("OriginatingMaker").ToString
                    '            sTransactedBy = myDataReader("approver").ToString
                    '            dtApproved = convert.todatetime(myDataReader("dateReceived"))
                    '        Catch ex As Exception
                    '            class_Procedures.Show_Error(ex)
                    '        End Try
                    '    End If
                    'End Using

                    'If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET transactedby = '{sPostedBy}', Approved_By = '{sTransactedBy}', Approved_Date = '{dtApproved}' WHERE id LIKE '{iTableID}'") Then
                    '    .SetRowCellValue(iRowHandle, coltransactedby, sPostedBy)
                    '    .SetRowCellValue(iRowHandle, colApproved_By, sTransactedBy)
                    '    .SetRowCellValue(iRowHandle, colApproved_Date, dtApproved)
                    'End If

                    'Select Case sWhCode
                    '    Case "NEW"

                    '    Case "DEP", "REP"
                    '        Dim sAccountNumber As String = Nothing
                    '        Dim sAccountName As String = Nothing
                    '        Dim iLedger As Integer

                    '        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT TOP 1 sequenceNo, AccountNumber, LedgerSetNumber, AccountName, EngineNo, FirstPayDate FROM CustAccount WHERE EngineNo LIKE '{sEngine}' AND FirstPayDate < '{dtApproved}' ORDER BY sequenceNo DESC")
                    '            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    '                Try
                    '                    myDataReader.Read()
                    '                    sAccountNumber = myDataReader("AccountNumber").ToString
                    '                    iLedger = myDataReader("LedgerSetNumber").ToString
                    '                    sAccountName = myDataReader("AccountName").ToString
                    '                Catch ex As Exception
                    '                    class_Procedures.Show_Error(ex)
                    '                End Try
                    '            End If
                    '        End Using

                    '        If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET AccountNumber = '{sAccountNumber}', LedgerSetNumber = '{iLedger}', AccountName = '{sAccountName}' WHERE id LIKE '{iTableID}'") Then
                    '            .SetRowCellValue(iRowHandle, colAccountNumber, sAccountNumber)
                    '            .SetRowCellValue(iRowHandle, colLedgerSetNumber, iLedger)
                    '            .SetRowCellValue(iRowHandle, colAccountName, sAccountName)
                    '        End If
                    'End Select
                Next
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colEngineNo), gridView.GetFocusedRowCellValue(colID))
        End Sub

        Private Sub btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            Journal_Execute()
        End Sub

        Friend Sub Journal_Execute(Optional ByVal bAsk As Boolean = True, Optional ByVal bShowJournal As Boolean = True)
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If bAsk AndAlso Not class_Procedures.actionAsk("Execute Journal entry/entries", "take a while") Then Return

                    Dim dtPostingDate As Date
                    Dim dUnitCost, dTotalCost As Decimal
                    Dim sBranchFrom, sBranchTo, sEngine, sWhCode As String

                    Dim iTableID, iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If xuc_Settings.Toggle_Select.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Item Journal", "executed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        iTableID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID))
                        dtPostingDate = .GetRowCellValue(iRowHandle, colApproved_Date)

                        sBranchFrom = .GetRowCellValue(iRowHandle, colBranchCodeFrom)
                        sBranchTo = .GetRowCellValue(iRowHandle, colBranchCode)
                        sEngine = .GetRowCellDisplayText(iRowHandle, colEngineNo)

                        dUnitCost = Convert.ToDecimal(.GetRowCellDisplayText(iRowHandle, colUnitCost))
                        dTotalCost = Convert.ToDecimal(.GetRowCellDisplayText(iRowHandle, colTotalCost))

                        sWhCode = .GetRowCellDisplayText(iRowHandle, colWHCode)

                        Select Case sWhCode
                            Case "NEW"
                                If dUnitCost <= 0 Then
                                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Unable to execute Journal Entry because unit cost is [0(zero)].")
                                    Continue For
                                End If

                                If dTotalCost <= 0 Then
                                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Unable to execute Journal Entry because total cost is [0(zero)].")
                                    Continue For
                                End If

                                If sBranchFrom.Equals(sBranchTo) Then
                                    If class_Saga_Database.Journal_Entry_Save("RECEIVING", iTableID, dtPostingDate) Then
                                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Item Unit [Receiving]:{Environment.NewLine}{sEngine}{Environment.NewLine}was successfully executed.")
                                    End If
                                Else
                                    If class_Saga_Database.Journal_Entry_Save("TRANSFER", iTableID, dtPostingDate) Then
                                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Item Unit [Transfer]:{Environment.NewLine}{sEngine}{Environment.NewLine}was successfully executed.")
                                    End If
                                End If

                            Case "DEP"
                                If Not .GetRowCellDisplayText(iRowHandle, colAccountNumber).Equals(String.Empty) Then
                                    If class_Saga_Database.Journal_Entry_Save("DEPOSIT", iTableID, dtPostingDate) Then
                                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Item Unit [Deposit]:{Environment.NewLine}{sEngine}{Environment.NewLine}was successfully executed.")
                                    End If
                                Else
                                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Account Number and Account Name should be updated before executing Journal.", "Account not Updated")
                                    bShowJournal = False
                                End If

                            Case "REP"
                                If sBranchFrom.Equals(String.Empty) Then Continue For
                                If sBranchFrom.Equals(sBranchTo) Then
                                    If Not .GetRowCellDisplayText(iRowHandle, colAccountNumber).Equals(String.Empty) Then
                                        If class_Saga_Database.Journal_Entry_Save("REPOSSESS", iTableID, dtPostingDate) Then
                                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Item Unit [Repossess]:{Environment.NewLine}{sEngine}{Environment.NewLine}was successfully executed.")
                                        End If
                                    Else
                                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Account Number and Account Name should be updated before executing Journal.", "Account not Updated")
                                        bShowJournal = False
                                    End If
                                Else
                                    If class_Saga_Database.Journal_Entry_Save("TRANSFER", iTableID, dtPostingDate) Then
                                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Item Unit [Repossess]:{Environment.NewLine}{sEngine}{Environment.NewLine}was successfully executed.")
                                    End If
                                End If
                        End Select

                        class_Saga_Database.Verify_Transaction("item_Details", gridView, colNote, iRowHandle, iTableID, sEngine, dTotalCost)
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colEngineNo), .GetFocusedRowCellValue(colID))
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"updating IsJournal Transactions of the selected Collections")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If
                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "RECEIVING_UNIT")
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colEngineNo), gridView.GetFocusedRowCellValue(colID))
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub btn_Add_To_PO_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Add_To_PO.ItemClick
            Dim sOrderCode As String = gridView.GetFocusedRowCellValue(colPoNo)
            Dim sBranchCode As String = gridView.GetFocusedRowCellValue(colBranchCode)
            Dim sModelCode As String = gridView.GetFocusedRowCellValue(colModel_Code)

            class_Saga_Database.Add_To_PO(sOrderCode, sBranchCode, sModelCode)
        End Sub
    End Class

End Namespace