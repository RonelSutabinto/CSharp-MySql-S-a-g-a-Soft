Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_List
    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, BtnCancel)
        'class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me)
    End Function

    Private Sub IS_Inventory_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "For Approval" Then
            mg_ShowForApprovalTransactions()
        ElseIf Me.Text = "For Transport" Then
            ShowInTransitTransactions()
        ElseIf Me.Text = "Approved" Then
            ShowApprovedTransactions()
        ElseIf Me.Text = "Disapproved" Then
            mg_ShowDisapprovedTransactions()
        ElseIf Me.Text = "PENDING" Then
            mg_ShowpendingTransactions()
        End If

    End Sub

    Private Sub IS_Inventory_List_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Sub mg_ShowForApprovalTransactionsRangeDate()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamDateBegin", DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", DateEnd.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowForApprovalTransactionsRangeDate")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowForApprovalTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowForApprovalTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowpendingTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowPendingTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowDisapprovedTransactionsRangeDate()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamDateBegin", DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", DateEnd.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowDisapprovedTransactionsRangeDate")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowDisapprovedTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowDisapprovedTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub ShowApprovedTransactionsRangeDate()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamDateBegin", DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", DateEnd.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApprovedTransactionsRangeDate")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                Loop
            End If
        End Using
    End Sub

    Sub ShowApprovedTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamMaker", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApprovedTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                Loop
            End If
        End Using
    End Sub

    Sub ShowInTransitTransactionsRangeDate()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamDateBegin", DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", DateEnd.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "ShowInTransitTransactionsRangeDate")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                Loop
            End If
        End Using
    End Sub

    Sub ShowInTransitTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamApprover", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInTransitTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                Loop
            End If
        End Using
    End Sub

    Sub ShowApplicationDisapproved()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()
        IS_SALES_Release.lv_Freebie.Items.Clear()
        IS_SALES_Release.ClearFields()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_accountno.Text),
            New SqlParameter("@ParamDateGranted", dateGrant2.Text),
            New SqlParameter("@ParamBranchCode", txt_branchCode.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApplication")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_SALES_Release.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_SALES_Release.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_SALES_Release.txt_address.Text = myDataReader("AccountAddress").ToString()
                IS_SALES_Release.txt_cifKey.Text = myDataReader("cifKey").ToString()
                IS_SALES_Release.receivedDate.Value = myDataReader("DateGranted").ToString()
                IS_SALES_Release.txt_code.Text = myDataReader("code").ToString()
                IS_SALES_Release.txt_id.Text = myDataReader("id").ToString()
                IS_SALES_Release.txt_model.Text = myDataReader("model").ToString()
                IS_SALES_Release.txt_color.Text = myDataReader("color").ToString()
                IS_SALES_Release.txt_brand.Text = myDataReader("brand").ToString()
                IS_SALES_Release.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                IS_SALES_Release.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                IS_SALES_Release.txt_engineNo.Text = myDataReader("engineno").ToString()
                IS_SALES_Release.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                IS_SALES_Release.txt_orno.Text = myDataReader("ORNo").ToString()

                IS_SALES_Release.txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "####0.00")
                IS_SALES_Release.txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "####0.00")
                IS_SALES_Release.txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "####0.00")
                IS_SALES_Release.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "####0.00")

                IS_SALES_Release.txt_aecode.Text = myDataReader("AccountExecutive").ToString()

                IS_SALES_Release.txt_PrevOwner.Text = myDataReader("PrevAccountName").ToString()
                IS_SALES_Release.txt_PrevBranchCode.Text = myDataReader("PrevBranchCode").ToString()
                IS_SALES_Release.txt_PrevAccountNumber.Text = myDataReader("PrevAccountNumber").ToString()
                IS_SALES_Release.txt_LedgerSetNumber.Text = myDataReader("PrevLedgerSetNumber").ToString()
            End If
        End Using
    End Sub

    Sub ShowApplicationForApproval()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_accountno.Text),
            New SqlParameter("@ParamDateGranted", dateGrant2.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchCode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApplication")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_SALES_Release_View.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_SALES_Release_View.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_SALES_Release_View.txt_LedSet.Text = myDataReader("LedgerSetNumber").ToString()
                IS_SALES_Release_View.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_SALES_Release_View.txt_address.Text = myDataReader("AccountAddress").ToString()
                IS_SALES_Release_View.txt_cifKey.Text = myDataReader("cifKey").ToString()
                IS_SALES_Release_View.receivedDate.Value = myDataReader("DateGranted").ToString()
                IS_SALES_Release_View.cmb_warehouse.Text = myDataReader("whCode").ToString()
                IS_SALES_Release_View.txt_code.Text = myDataReader("code").ToString()
                IS_SALES_Release_View.txt_id.Text = myDataReader("id").ToString()
                IS_SALES_Release_View.txt_model.Text = myDataReader("model").ToString()
                IS_SALES_Release_View.txt_color.Text = myDataReader("color").ToString()
                IS_SALES_Release_View.txt_brand.Text = myDataReader("brand").ToString()
                IS_SALES_Release_View.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                IS_SALES_Release_View.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                IS_SALES_Release_View.txt_engineNo.Text = myDataReader("engineno").ToString()
                IS_SALES_Release_View.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                IS_SALES_Release_View.txt_orno.Text = myDataReader("ORNo").ToString()
                IS_SALES_Release_View.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                IS_SALES_Release_View.txt_COD.Text = myDataReader("COD").ToString()
                IS_SALES_Release_View.txt_LCP.Text = myDataReader("LCP").ToString()
                IS_SALES_Release_View.txt_DP.Text = myDataReader("DP").ToString()

                IS_SALES_Release_View.txt_rebates.Text = myDataReader("Rebates").ToString()
                IS_SALES_Release_View.txt_aoc.Text = myDataReader("aoc").ToString()

                IS_SALES_Release_View.txt_FinancedAmt.Text = myDataReader("FinancedAmt").ToString()
                IS_SALES_Release_View.txt_aecode.Text = myDataReader("AccountExecutive").ToString()
                IS_SALES_Release_View.txt_terms.Text = myDataReader("Terms").ToString()
                IS_SALES_Release_View.txt_intrate.Text = myDataReader("InterestRate").ToString()
                IS_SALES_Release_View.cmbTag.Text = myDataReader("Tag").ToString()

                IS_SALES_Release_View.txt_CRNo.Text = myDataReader("CRNo").ToString()

                IS_SALES_Release_View.pmtPrin.Text = Format(Val(myDataReader.Item("PrincipalPMT").ToString()), "#,##0.00")
                IS_SALES_Release_View.pmtINT.Text = Format(Val(myDataReader.Item("InterestPMT").ToString()), "#,##0.00")
                IS_SALES_Release_View.pmtTot.Text = Format(Val(myDataReader.Item("PMT").ToString()), "#,##0.00")

                IS_SALES_Release_View.BalPrin.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "#,#00.00")
                IS_SALES_Release_View.BalINT.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "#,#00.00")
                IS_SALES_Release_View.BalTot.Text = Format(Val(myDataReader.Item("OutStandingBalance").ToString()), "#,#00.00")

                IS_SALES_Release_View.txt_PrevOwner.Text = myDataReader("PrevAccountName").ToString()
                IS_SALES_Release_View.txt_PrevBranchCode.Text = myDataReader("PrevBranchCode").ToString()
                IS_SALES_Release_View.txt_PrevAccountNumber.Text = myDataReader("PrevAccountNumber").ToString()
                IS_SALES_Release_View.txt_LedgerSetNumber.Text = myDataReader("PrevLedgerSetNumber").ToString()
                IS_SALES_Release_View.txt_DiscAmt.Text = myDataReader("DiscAmt").ToString()
                IS_SALES_Release_View.txt_AgentCode.Text = myDataReader("AgentCode").ToString()
                IS_SALES_Release_View.txt_AgentName.Text = myDataReader("AgentName").ToString()
                IS_SALES_Release_View.txt_AEName.Text = myDataReader("AEName").ToString()
            End If
        End Using
    End Sub

    Sub searchInventory_ForTransport()
        LViewList.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE approver LIKE '" & MainMenu.App_User_Name.Caption & "' AND inventoryStatus LIKE '" & Me.Text & "' ORDER BY dateReceived desc")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub searchInventory()
        LViewList.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE transactedby LIKE '" & MainMenu.App_User_Name.Caption & "' AND inventoryStatus LIKE '" & Me.Text & "' ORDER BY dateReceived desc")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                    li.SubItems.Add("INVENTORY")
                    li.SubItems.Add(Format(myDataReader.Item("datereceived"), "MM/dd/yyyy"))
                Loop
            End If
        End Using
    End Sub

    Sub Load_item_master()
        IS_Inventory_Receiving_View.LViewItems.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE transactedby LIKE '" & MainMenu.App_User_Name.Caption & "' AND refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_Inventory_Receiving_View.lbl_vendor.Text = myDataReader("vendor").ToString()
                IS_Inventory_Receiving_View.txt_refno.Text = myDataReader("refno").ToString()
                IS_Inventory_Receiving_View.txt_TransCode.Text = myDataReader("transcode").ToString()
                IS_Inventory_Receiving_View.txt_pono.Text = myDataReader("pono").ToString()
                IS_Inventory_Receiving_View.receivedDate.Value = myDataReader("datereceived").ToString()
                IS_Inventory_Receiving_View.txt_invenStat.Text = myDataReader("inventorystatus").ToString()
                IS_Inventory_Receiving_View.txt_approver.Text = myDataReader("approver").ToString()
                IS_Inventory_Receiving_View.cmb_warehouse.Text = myDataReader("whcategory").ToString()
                IS_Inventory_Receiving_View.txt_whcode.Text = myDataReader("whcode").ToString()
                IS_Inventory_Receiving_View.lbl_count.Text = myDataReader("itemcnt").ToString()
                IS_Inventory_Receiving_View.lbl_tot_unit.Text = myDataReader("totalUnitCost").ToString()
                IS_Inventory_Receiving_View.lbl_totVatAmt.Text = myDataReader("totalVATAmt").ToString()
                IS_Inventory_Receiving_View.lbl_grandTotal.Text = myDataReader("GrandTotalUnitCost").ToString()
                IS_Inventory_Receiving_View.lbl_totUnitPrice.Text = myDataReader("TotalUnitPrice").ToString()

                IS_Inventory_Receiving_View.txt_remarks.Text = myDataReader("remarks").ToString()
                IS_Inventory_Receiving_View.txt_notes.Text = myDataReader("note").ToString()
            End If
        End Using
    End Sub

    Sub Load_item_masterApprover()
        IS_Inventory_Receiving_View.LViewItems.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "' AND inventoryStatus LIKE '" & LViewList.SelectedItems.Item(0).SubItems(4).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_Inventory_Receiving_View.lbl_vendor.Text = myDataReader("vendor").ToString()
                IS_Inventory_Receiving_View.txt_refno.Text = myDataReader("refno").ToString()
                IS_Inventory_Receiving_View.txt_TransCode.Text = myDataReader("transcode").ToString()
                IS_Inventory_Receiving_View.txt_pono.Text = myDataReader("pono").ToString()
                IS_Inventory_Receiving_View.receivedDate.Value = myDataReader("datereceived").ToString()
                IS_Inventory_Receiving_View.txt_invenStat.Text = myDataReader("inventorystatus").ToString()
                IS_Inventory_Receiving_View.txt_approver.Text = myDataReader("approver").ToString()
                IS_Inventory_Receiving_View.cmb_warehouse.Text = myDataReader("whcategory").ToString()
                IS_Inventory_Receiving_View.txt_whcode.Text = myDataReader("whcode").ToString()
                IS_Inventory_Receiving_View.lbl_count.Text = myDataReader("itemcnt").ToString()
                IS_Inventory_Receiving_View.lbl_tot_unit.Text = myDataReader("totalUnitCost").ToString()
                IS_Inventory_Receiving_View.lbl_totVatAmt.Text = myDataReader("totalVATAmt").ToString()
                IS_Inventory_Receiving_View.lbl_grandTotal.Text = myDataReader("GrandTotalUnitCost").ToString()
                IS_Inventory_Receiving_View.lbl_totUnitPrice.Text = myDataReader("TotalUnitPrice").ToString()
                IS_Inventory_Receiving_View.txt_sender.Text = myDataReader("transactedby").ToString()
                IS_Inventory_Receiving_View.txt_originatingBranch.Text = myDataReader("BranchCode").ToString()
                IS_Inventory_Receiving_View.txt_remarks.Text = myDataReader("remarks").ToString()
                IS_Inventory_Receiving_View.txt_notes.Text = myDataReader("note").ToString()
            End If
        End Using
    End Sub

    Sub Load_item_masterApprover_For_Transport()
        IS_Inventory_Receiving_View.LViewItems.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE approver LIKE '" & MainMenu.App_User_Name.Caption & "' AND refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "' AND inventoryStatus LIKE '" & LViewList.SelectedItems.Item(0).SubItems(4).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_Inventory_Outgoing_View.lbl_vendor.Text = myDataReader("vendor").ToString()
                IS_Inventory_Outgoing_View.txt_refno.Text = myDataReader("refno").ToString()
                IS_Inventory_Outgoing_View.txt_TransCode.Text = myDataReader("transcode").ToString()
                IS_Inventory_Outgoing_View.txt_pono.Text = myDataReader("pono").ToString()
                IS_Inventory_Outgoing_View.receivedDate.Value = myDataReader("datereceived").ToString()
                IS_Inventory_Outgoing_View.txt_invenStat.Text = myDataReader("inventorystatus").ToString()
                IS_Inventory_Outgoing_View.lbl_vendorCode.Text = myDataReader("VendorCode").ToString()
                IS_Inventory_Outgoing_View.cmb_warehouse.Text = myDataReader("whcategory").ToString()
                IS_Inventory_Outgoing_View.txt_whcode.Text = myDataReader("whcode").ToString()
                IS_Inventory_Outgoing_View.lbl_count.Text = myDataReader("itemcnt").ToString()
                IS_Inventory_Outgoing_View.lbl_tot_unit.Text = myDataReader("totalUnitCost").ToString()
                IS_Inventory_Outgoing_View.lbl_totVatAmt.Text = myDataReader("totalVATAmt").ToString()
                IS_Inventory_Outgoing_View.lbl_grandTotal.Text = myDataReader("GrandTotalUnitCost").ToString()
                IS_Inventory_Outgoing_View.lbl_totUnitPrice.Text = myDataReader("TotalUnitPrice").ToString()
                IS_Inventory_Outgoing_View.txt_sender.Text = myDataReader("transactedby").ToString()
                IS_Inventory_Outgoing_View.txt_originatingBranch.Text = myDataReader("BranchCode").ToString()
                IS_Inventory_Outgoing_View.lbl_approver.Text = myDataReader("approver").ToString()
                IS_Inventory_Outgoing_View.txt_remarks.Text = myDataReader("remarks").ToString()
                IS_Inventory_Outgoing_View.txt_notes.Text = myDataReader("note").ToString()

                IS_Inventory_Outgoing_View.Text = "For Transport"
            End If
        End Using
    End Sub

    Sub Load_item_detailsApprover_For_Transport()
        IS_Inventory_Outgoing_View.LViewItems.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Inventory_Outgoing_View.LViewItems.Items.Add(myDataReader("code").ToString())
                    li.SubItems.Add(myDataReader("model").ToString())
                    li.SubItems.Add(myDataReader("description").ToString())
                    li.SubItems.Add(myDataReader("color").ToString())
                    li.SubItems.Add(myDataReader("brand").ToString())
                    li.SubItems.Add(myDataReader("engineno").ToString())
                    li.SubItems.Add(myDataReader("chassisno").ToString())
                    li.SubItems.Add(myDataReader("unitcost").ToString())
                    li.SubItems.Add(myDataReader("vatamt").ToString())
                    li.SubItems.Add(myDataReader("totalcost").ToString())
                    li.SubItems.Add(myDataReader("unitprice").ToString())
                    li.SubItems.Add(myDataReader("keyno").ToString())
                    li.SubItems.Add(myDataReader("PrevID").ToString())
                Loop
            End If
        End Using
        'class_Database.mySQLConnection.Close()
    End Sub

    Sub Load_item_detailsApprover()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Inventory_Receiving_View.LViewItems.Items.Add(myDataReader("code").ToString())
                    li.SubItems.Add(myDataReader("model").ToString())
                    li.SubItems.Add(myDataReader("description").ToString())
                    li.SubItems.Add(myDataReader("color").ToString())
                    li.SubItems.Add(myDataReader("brand").ToString())
                    li.SubItems.Add(myDataReader("chassisno").ToString())
                    li.SubItems.Add(myDataReader("engineno").ToString())
                    li.SubItems.Add(myDataReader("unitcost").ToString())
                    li.SubItems.Add(myDataReader("vatamt").ToString())
                    li.SubItems.Add(myDataReader("totalcost").ToString())
                    li.SubItems.Add(myDataReader("unitprice").ToString())
                    li.SubItems.Add(myDataReader("keyno").ToString())
                    li.SubItems.Add(myDataReader("note").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub Load_item_details()
        'class_Database.mySQLConnection.Open()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Inventory_Receiving_View.LViewItems.Items.Add(myDataReader("code").ToString())
                    li.SubItems.Add(myDataReader("model").ToString())
                    li.SubItems.Add(myDataReader("description").ToString())
                    li.SubItems.Add(myDataReader("color").ToString())
                    li.SubItems.Add(myDataReader("brand").ToString())
                    li.SubItems.Add(myDataReader("chassisno").ToString())
                    li.SubItems.Add(myDataReader("engineno").ToString())
                    li.SubItems.Add(myDataReader("unitcost").ToString())
                    li.SubItems.Add(myDataReader("vatamt").ToString())
                    li.SubItems.Add(myDataReader("totalcost").ToString())
                    li.SubItems.Add(myDataReader("unitprice").ToString())
                    li.SubItems.Add(myDataReader("keyno").ToString())
                    li.SubItems.Add(myDataReader("note").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub LViewList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewList.DoubleClick
        If Me.Text = "For Approval" Then
            If LViewList.SelectedItems.Item(0).SubItems(6).Text = "INVENTORY" Then
                Load_item_masterApprover()
                Load_item_detailsApprover()
                IS_Inventory_Receiving_View.cmd_approved.Visible = True
                IS_Inventory_Receiving_View.cmd_disapproved.Visible = True
                IS_Inventory_Receiving_View.cmd_print.Visible = False

                Me.Close()
                IS_Inventory_Receiving_View.ShowDialog()
            ElseIf LViewList.SelectedItems.Item(0).SubItems(6).Text = "SALE" Then
                txt_accountno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
                dateGrant2.Text = LViewList.SelectedItems.Item(0).SubItems(7).Text
                txt_ledset.Text = LViewList.SelectedItems.Item(0).SubItems(8).Text
                txt_branchCode.Text = LViewList.SelectedItems.Item(0).SubItems(9).Text
                ShowApplicationForApproval()
                mg_ShowFreebieForApprovalSALES()
                IS_Inventory_Receiving_View.cmd_print.Visible = False
                IS_SALES_Release_View.cmd_approved.Visible = True
                IS_SALES_Release_View.cmd_disapproved.Visible = True
                Me.Close()
                IS_SALES_Release_View.ShowDialog()
            End If

        ElseIf Me.Text = "Disapproved" Then

            If LViewList.SelectedItems.Item(0).SubItems(6).Text = "INVENTORY" Then
                If LViewList.SelectedItems.Item(0).SubItems(5).Text = "OUTGOING" Then
                    IS_Inventory_Outgoing.Text = "DISAPPROVED"
                    Load_item_master_edit_Outgoing()
                    Load_item_details_edit_Outgoing()
                    IS_Inventory_Outgoing.txt_invenStat.Text = "For Transport"

                    IS_Inventory_Outgoing.txt_receiver.Enabled = False
                    Me.Close()
                    IS_Inventory_Outgoing.MdiParent = MainMenu
                    IS_Inventory_Outgoing.Show()
                    IS_Inventory_Outgoing.Focus()
                Else
                    Load_item_master_edit()
                    Load_item_details_edit()
                    LViewEvent()
                    Me.Close()
                    IS_Inventory_Receiving.Text = "Disapproved"

                    IS_Inventory_Receiving.MdiParent = MainMenu
                    IS_Inventory_Receiving.Show()
                    IS_Inventory_Receiving.Focus()

                End If
            ElseIf LViewList.SelectedItems.Item(0).SubItems(6).Text = "SALE" Then
                IS_SALES_Release.Text = "Disapproved"
                txt_accountno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
                dateGrant2.Text = LViewList.SelectedItems.Item(0).SubItems(7).Text
                txt_ledset.Text = LViewList.SelectedItems.Item(0).SubItems(8).Text
                txt_branchCode.Text = LViewList.SelectedItems.Item(0).SubItems(9).Text
                Me.Close()
                ShowApplicationDisapproved()
                IS_SALES_Release.ShowDialog()
            End If

        ElseIf Me.Text = "Approved" Then
            Load_item_master()
            Load_item_details()
            IS_Inventory_Receiving_View.txt_rptTitle.Text = "SAGA INVENTORY - RECEIVING"
            IS_Inventory_Receiving_View.cmd_print.Location = New Point(13, 441)
            IS_Inventory_Receiving_View.cmd_print.Visible = True

            IS_SALES_Release_View.cmd_approved.Visible = False
            IS_SALES_Release_View.cmd_disapproved.Visible = False
            IS_Inventory_Receiving_View.ShowDialog()

        ElseIf Me.Text = "For Transport" Then
            Load_item_masterApprover_For_Transport()
            Load_item_detailsApprover_For_Transport()
            IS_Inventory_Outgoing_View.cmb_warehouse.Enabled = False
            IS_Inventory_Outgoing_View.txt_whcode.Enabled = False
            IS_Inventory_Outgoing_View.cmd_approved.Visible = True
            IS_Inventory_Outgoing_View.cmd_disapproved.Visible = True

            IS_Inventory_Outgoing_View.txt_rptTitle.Text = "SAGA INVENTORY - TRANSPORT"
            IS_Inventory_Outgoing_View.Text = "For Transport"
            IS_Inventory_Outgoing_View.ShowDialog()
            Me.Close()

        ElseIf Me.Text = "PENDING" Then
            If LViewList.SelectedItems.Item(0).SubItems(6).Text = "INVENTORY" Then
                Load_item_masterApprover()
                Load_item_detailsApprover()
                IS_Inventory_Receiving_View.ShowDialog()
            ElseIf LViewList.SelectedItems.Item(0).SubItems(6).Text = "SALE" Then
                txt_accountno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
                dateGrant2.Text = LViewList.SelectedItems.Item(0).SubItems(7).Text
                txt_ledset.Text = LViewList.SelectedItems.Item(0).SubItems(8).Text
                txt_branchCode.Text = LViewList.SelectedItems.Item(0).SubItems(9).Text
                ShowApplicationForApproval()
                IS_SALES_Release_View.ShowDialog()
            End If
        End If
    End Sub

    Sub Load_item_master_edit_Outgoing()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE transactedby LIKE '" & MainMenu.App_User_Name.Caption & "' AND  refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "'  and POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_Inventory_Outgoing.lbl_vendor.Text = myDataReader("vendor").ToString()
                IS_Inventory_Receiving.lbl_vendor.Properties.NullText = myDataReader("vendor").ToString()
                IS_Inventory_Receiving.lbl_vendor.EditValue = myDataReader("VendorCode").ToString()

                IS_Inventory_Outgoing.txt_TransCode.Text = myDataReader("transcode").ToString()

                IS_Inventory_Outgoing.receivedDate.EditValue = myDataReader("datereceived").ToString()
                IS_Inventory_Outgoing.txt_invenStat.Text = "For Approval"
                IS_Inventory_Outgoing.txt_approver.Text = myDataReader("approver").ToString()
                IS_Inventory_Outgoing.cmb_warehouse.Text = myDataReader("whcategory").ToString()
                IS_Inventory_Outgoing.cmb_warehouse.Properties.NullText = myDataReader("whcategory").ToString()
                IS_Inventory_Outgoing.cmb_warehouse.EditValue = myDataReader("whcode").ToString()
                IS_Inventory_Outgoing.lbl_vendor.EditValue = myDataReader("VendorCode").ToString()
                IS_Inventory_Outgoing.txt_remarks.Text = myDataReader("remarks").ToString()
                IS_Inventory_Outgoing.txt_notes.Text = myDataReader("note").ToString()

                IS_Inventory_Outgoing.txt_refno.Text = myDataReader("refno").ToString()
                IS_Inventory_Outgoing.txt_pono.Text = myDataReader("pono").ToString()
            End If
        End Using
    End Sub

    Sub Load_item_master_edit()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE transactedby LIKE '" & MainMenu.App_User_Name.Caption & "' AND  refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                IS_Inventory_Receiving.lbl_vendor.Properties.NullText = myDataReader("vendor").ToString()
                IS_Inventory_Receiving.lbl_vendor.EditValue = myDataReader("VendorCode").ToString()
                IS_Inventory_Receiving.lbl_vendor.Text = myDataReader("vendor").ToString()
                IS_Inventory_Receiving.txt_refno.Text = myDataReader("refno").ToString()
                IS_Inventory_Receiving.txt_TransCode.Text = myDataReader("transcode").ToString()
                IS_Inventory_Receiving.txt_pono.Text = myDataReader("pono").ToString()
                IS_Inventory_Receiving.receivedDate.EditValue = myDataReader("datereceived").ToString()
                IS_Inventory_Receiving.txt_invenStat.Text = "For Approval"
                IS_Inventory_Receiving.txt_approver.Text = myDataReader("approver").ToString()
                IS_Inventory_Receiving.txt_remarks.Text = myDataReader("remarks").ToString()
                IS_Inventory_Receiving.txt_notes.Text = myDataReader("note").ToString()
                IS_Inventory_Receiving.txt_whcode.Text = myDataReader("whcategory").ToString()
                IS_Inventory_Receiving.txt_whcode.Properties.NullText = myDataReader("whcategory").ToString()
                IS_Inventory_Receiving.txt_whcode.EditValue = myDataReader("whcode").ToString()
            End If
        End Using
        IS_Inventory_Receiving.DockItems.Visible = False
    End Sub

    Sub Load_item_details_edit_Outgoing()
        Initialize_GridList_Outgoing()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim dr As DataRow = dt_Outgoing.NewRow
                    dr(0) = myDataReader("id").ToString() 'id
                    dr(1) = myDataReader("code").ToString() ' code
                    dr(2) = myDataReader("model").ToString() 'model
                    dr(3) = myDataReader("model").ToString() & " - " & myDataReader("color").ToString()   'description
                    dr(4) = myDataReader("color").ToString() ' color
                    dr(5) = myDataReader("Brand").ToString() ' brand
                    dr(6) = myDataReader("engineno").ToString() ' engineno
                    dr(7) = myDataReader("chassisno").ToString() ' chassisno
                    dr(8) = myDataReader("keyno").ToString() 'keyno
                    dr(9) = myDataReader("unitcost").ToString() ' unitcost
                    dr(10) = myDataReader("vatamt").ToString() ' vatamt
                    dr(11) = myDataReader("totalcost").ToString() ' totalcost
                    dr(12) = myDataReader("unitprice").ToString() 'unitprice
                    dr(13) = myDataReader("note").ToString() ' Accountname
                    dr(14) = myDataReader("BranchCodeAcct").ToString() ' BrCodeAcct
                    dr(15) = myDataReader("AccountNumber").ToString() ' Accountnumber
                    dr(16) = myDataReader("LedgerSetNumber").ToString() ' ledgerset
                    dr(17) = myDataReader("OtherNotes").ToString() ' spec
                    dr(18) = myDataReader("previd").ToString() ' previd

                    dt_Outgoing.Rows.Add(dr)
                    IS_Inventory_Outgoing.GridControl.DataSource = dt_Outgoing
                Loop
            End If
        End Using
    End Sub

    Public dt_Outgoing As DataTable
    Public dt_Receiving As DataTable

    Sub Load_item_details_edit()
        Initialize_GridList()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE refno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(0).Text & "' AND POno LIKE '" & LViewList.SelectedItems.Item(0).SubItems(2).Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim dr As DataRow = dt_Receiving.NewRow
                    dr(0) = myDataReader("code").ToString()
                    dr(1) = myDataReader("Model").ToString()
                    dr(2) = myDataReader("Model").ToString() & " - " & myDataReader("color").ToString()
                    dr(3) = myDataReader("color").ToString()
                    dr(4) = myDataReader("brand").ToString()
                    dr(5) = myDataReader("engineno").ToString()
                    dr(6) = myDataReader("chassisno").ToString()
                    dr(7) = myDataReader("keyno").ToString()
                    dr(8) = myDataReader("unitcost").ToString()
                    dr(9) = myDataReader("vatamt").ToString()
                    dr(10) = myDataReader("totalcost").ToString()
                    dr(11) = myDataReader("unitprice").ToString()
                    dr(12) = myDataReader("note").ToString()
                    dr(13) = myDataReader("BranchCodeAcct").ToString()
                    dr(14) = myDataReader("AccountNumber").ToString()
                    dr(15) = myDataReader("LedgerSetNumber").ToString()
                    dr(16) = myDataReader("OtherNotes").ToString()

                    dt_Receiving.Rows.Add(dr)
                    IS_Inventory_Receiving.GridList.DataSource = dt_Receiving
                Loop
            End If
        End Using
    End Sub

    Sub Initialize_GridList()
        dt_Receiving = New DataTable
        dt_Receiving.Columns.Add("Code")
        dt_Receiving.Columns.Add("Model")
        dt_Receiving.Columns.Add("Description")
        dt_Receiving.Columns.Add("Color")
        dt_Receiving.Columns.Add("Brand")
        dt_Receiving.Columns.Add("EngineNo")
        dt_Receiving.Columns.Add("ChassisNo")
        dt_Receiving.Columns.Add("KeyNo")
        dt_Receiving.Columns.Add("UnitCost")
        dt_Receiving.Columns.Add("VATAmt")
        dt_Receiving.Columns.Add("TotalCost")
        dt_Receiving.Columns.Add("UnitPrice")
        dt_Receiving.Columns.Add("AccountName")
        dt_Receiving.Columns.Add("BrCodeAcct")
        dt_Receiving.Columns.Add("AccountNumber")
        dt_Receiving.Columns.Add("LedgerSet")
        dt_Receiving.Columns.Add("SpecificNotes")

        IS_Inventory_Receiving.GridList.DataSource = dt_Receiving
    End Sub

    Sub Initialize_GridList_Outgoing()
        dt_Outgoing = New DataTable
        dt_Outgoing.Columns.Add("id")
        dt_Outgoing.Columns.Add("Code")
        dt_Outgoing.Columns.Add("Model")
        dt_Outgoing.Columns.Add("Description")
        dt_Outgoing.Columns.Add("Color")
        dt_Outgoing.Columns.Add("Brand")
        dt_Outgoing.Columns.Add("EngineNo")
        dt_Outgoing.Columns.Add("ChassisNo")
        dt_Outgoing.Columns.Add("KeyNo")
        dt_Outgoing.Columns.Add("UnitCost")
        dt_Outgoing.Columns.Add("VATAmt")
        dt_Outgoing.Columns.Add("TotalCost")
        dt_Outgoing.Columns.Add("UnitPrice")
        dt_Outgoing.Columns.Add("AccountName")
        dt_Outgoing.Columns.Add("BrCodeAcct")
        dt_Outgoing.Columns.Add("AccountNumber")
        dt_Outgoing.Columns.Add("LedgerSet")
        dt_Outgoing.Columns.Add("SpecificNotes")
        dt_Outgoing.Columns.Add("PrevID")

        IS_Inventory_Outgoing.GridControl.DataSource = dt_Outgoing
    End Sub

    Private Sub cmd_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_find.Click
        If Me.Text = "For Approval" Then
            mg_ShowForApprovalTransactionsRangeDate()
        ElseIf Me.Text = "For Transport" Then
            ShowInTransitTransactionsRangeDate()
        ElseIf Me.Text = "Approved" Then
            ShowApprovedTransactionsRangeDate()
        ElseIf Me.Text = "Disapproved" Then
            mg_ShowDisapprovedTransactionsRangeDate()
        End If
    End Sub

    Sub mg_ShowFreebieForApprovalSALES()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_accountno.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamDateGranted", dateGrant2.Text)
        }

        IS_SALES_Release_View.lv_Freebie.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowFeebieApplication")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_SALES_Release_View.lv_Freebie.Items.Add(myDataReader.Item("FreebieID").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("BegQty").ToString())
                    li.SubItems.Add(myDataReader.Item("DrQty").ToString())
                    li.SubItems.Add(myDataReader.Item("CrQty").ToString())
                    li.SubItems.Add(myDataReader.Item("EndQty").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Transactedby").ToString)
                    li.SubItems.Add(myDataReader.Item("TransStatus").ToString)
                Loop
            End If
        End Using
        'class_Database.mySQLConnection.Close()
    End Sub

    Public Sub LViewEvent()
        'Dim TotalunitCost As Double = 0
        'Dim TotalVATAmt As Double = 0
        'Dim GrandTotal As Double = 0
        'Dim TotalUnitPrice As Double
        'Dim TotalCount As Double = 0

        'Dim TempNode As ListViewItem
        'Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        ''  If IS_Inventory_item_add.eventForm.Text = "Receiving" Then
        'For Each TempNode In IS_Inventory_Receiving.LViewItems.Items
        '    If Double.TryParse(TempNode.SubItems.Item(7).Text, TempUnitCost) Then
        '        TotalunitCost += TempUnitCost
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(8).Text, TempVATAmt) Then
        '        TotalVATAmt += TempVATAmt
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(9).Text, TempGrandTotal) Then
        '        GrandTotal += TempGrandTotal
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(10).Text, TempUnitPrice) Then
        '        TotalUnitPrice += TempUnitPrice
        '    End If
        '    TotalCount = TotalCount + 1
        'Next
        'IS_Inventory_Receiving.lbl_tot_unit.Text = Format(TotalunitCost, "###.##")
        'IS_Inventory_Receiving.lbl_totVatAmt.Text = Format(TotalVATAmt, "###.##")
        'IS_Inventory_Receiving.lbl_grandTotal.Text = Format(GrandTotal, "###.##")
        'IS_Inventory_Receiving.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "###.##")
        'IS_Inventory_Receiving.lbl_count.Text = TotalCount
    End Sub

End Class