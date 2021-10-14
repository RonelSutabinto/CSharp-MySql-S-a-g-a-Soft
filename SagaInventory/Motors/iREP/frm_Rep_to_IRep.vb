Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Public Class frm_Rep_to_IRep
    Public dt As DataTable
    Dim Ref_Number As String
    Private Sub frm_Rep_to_IRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize_GridList()
        Ref_Number = $"{DateTime.Now:MMddyyyyhhmmss}"
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

        class_Saga_Procedures.Initialize_Branch(Branch, RepositoryItemLookUpEdit_Branch)

        'xuc_MC_Reprice.sBranchCode.Equals("000")
        'If class_Saga_Variables.sBranchCode.Equals("000") Then
        '    Branch.Enabled = True
        'Else
        '    Branch.Enabled = False
        'End If
    End Sub
    Private Sub frm_Rep_to_IRep_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Initialize_GridList()
        Xuc_iREP_Units.Load_iRepo()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Rep_to_IRep_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form_Close()
    End Sub
    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub
    Sub Initialize_GridList()
        dt = New DataTable
        dt.Columns.Add("Code")
        dt.Columns.Add("Model")
        dt.Columns.Add("Description")
        dt.Columns.Add("Color")
        dt.Columns.Add("Brand")
        dt.Columns.Add("EngineNo")
        dt.Columns.Add("ChassisNo")
        dt.Columns.Add("KeyNo")
        dt.Columns.Add("UnitCost")
        dt.Columns.Add("VATAmt")
        dt.Columns.Add("TotalCost")
        dt.Columns.Add("UnitPrice")
        dt.Columns.Add("AccountName")
        dt.Columns.Add("BrCodeAcct")
        dt.Columns.Add("AccountNumber")
        dt.Columns.Add("LedgerSet")
        dt.Columns.Add("SpecificNotes")
        dt.Columns.Add("Principal")
        dt.Columns.Add("Interest")
        dt.Columns.Add("OutstandingBal")
        dt.Columns.Add("DP")
        dt.Columns.Add("PMT")
        dt.Columns.Add("PrevID")

        GridList.DataSource = dt
    End Sub
    Private Sub btn_Send_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
        If class_Procedures.actionAsk("APPROVAL", "Send Depo to Repo for Approval") Then
            Control_Save_to_item_Details()
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "REPO TO IREPO Sent for Approval", "FOR APPROVAL", True)
        End If
        'Dim News As Integer = MessageBox.Show("Are you sure sending this Transactions?", "DEPO TO REPO", MessageBoxButtons.YesNo)
        'If News = DialogResult.No Then
        '    MessageBox.Show("Thanks for not sending the Transactions!", "DEPO TO REPO")
        'Else

        'End If
    End Sub

    Friend Sub Control_Save_to_item_Details()
        For i = 0 To gridView.DataRowCount - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", Ref_Number),
                New SqlParameter("@ParamPOno", Ref_Number),
                New SqlParameter("@Paramtranscode", Ref_Number),
                New SqlParameter("@ParamdateReceived", Date.Now()),
                New SqlParameter("@Paramtransactiondate", Date.Now()),
                New SqlParameter("@ParamApprover", "jsomandam"),
                New SqlParameter("@Paramwhcategory", "REPOSSESSED"),
                New SqlParameter("@Paramwhcode", "REP"),
                New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
                New SqlParameter("@Paramvendor", class_Saga_Database.get_Branch_Name(Branch.EditValue.ToString())),
                New SqlParameter("@ParamVendorCode", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Parambranchcode", "007"),
                New SqlParameter("@ParamModelcode", gridView.GetRowCellValue(i, "Code")),
                New SqlParameter("@Parammodel", gridView.GetRowCellValue(i, "Model")),
                New SqlParameter("@Paramdescription", gridView.GetRowCellValue(i, "Description")),
                New SqlParameter("@Paramcolor", gridView.GetRowCellValue(i, "Color")),
                New SqlParameter("@ParamBrand", gridView.GetRowCellValue(i, "Brand")),
                New SqlParameter("@ParamEngineNo", gridView.GetRowCellValue(i, "EngineNo")),
                New SqlParameter("@ParamChassisNo", gridView.GetRowCellValue(i, "ChassisNo")),
                New SqlParameter("@ParamKeyNo", gridView.GetRowCellValue(i, "KeyNo")),
                New SqlParameter("@ParamUnitCost", gridView.GetRowCellValue(i, "UnitCost")),
                New SqlParameter("@ParamVatAmt", gridView.GetRowCellValue(i, "VATAmt")),
                New SqlParameter("@ParamTotalCost", gridView.GetRowCellValue(i, "TotalCost")),
                New SqlParameter("@ParamUnitPrice", gridView.GetRowCellValue(i, "UnitPrice")),
                New SqlParameter("@ParamAccountName", gridView.GetRowCellValue(i, "AccountName")),
                New SqlParameter("@ParamBrCodeAccount", gridView.GetRowCellValue(i, "BrCodeAcct")),
                New SqlParameter("@ParamAccountNumber", gridView.GetRowCellValue(i, "AccountNumber")),
                New SqlParameter("@ParamLedgerSet", gridView.GetRowCellValue(i, "LedgerSet")),
                New SqlParameter("@ParamSpecificNotes", gridView.GetRowCellValue(i, "SpecificNotes"))
            }
            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_ReceivingItemDetails", "DEPO TO REPO")
        Next
    End Sub
    Private Sub btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
        '  out
        If Xuc_iREP_Units.Customer_Name.EditValue = String.Empty Then
            MsgBox("Please select Customer Name!", vbCritical, "iREP Units")
            Return
        Else
            Inventory_ItemAdd()
        End If
    End Sub

    Sub Inventory_ItemAdd()
        Dim dr As DataRow = dt.NewRow

        dr(0) = Xuc_iREP_Units.ModelCode
        dr(1) = Xuc_iREP_Units.Model.EditValue
        dr(2) = Xuc_iREP_Units.Description.EditValue
        dr(3) = Xuc_iREP_Units.Color.EditValue
        dr(4) = Xuc_iREP_Units.Brand.EditValue
        dr(5) = Xuc_iREP_Units.Engine_Number.EditValue
        dr(6) = Xuc_iREP_Units.Chassis_Number.EditValue
        dr(7) = Xuc_iREP_Units.KeyNo
        dr(8) = Xuc_iREP_Units.Restoration_Cost.EditValue
        dr(9) = "0.00"
        dr(10) = "0.00"
        dr(11) = "0.00"
        dr(12) = Xuc_iREP_Units.Customer_Name.EditValue
        dr(13) = Xuc_iREP_Units.BranchCode
        dr(14) = Xuc_iREP_Units.Account_Number.EditValue
        dr(15) = Xuc_iREP_Units.Ledgerset
        dr(16) = Xuc_iREP_Units.Classification
        dr(17) = Xuc_iREP_Units.Principal.EditValue
        dr(18) = Xuc_iREP_Units.Interest.EditValue
        dr(19) = Xuc_iREP_Units.Outs_Balance.EditValue
        dr(20) = Xuc_iREP_Units.DP_Equity.EditValue
        dr(21) = Xuc_iREP_Units.MA.EditValue
        dr(22) = Xuc_iREP_Units.PrevID

        dt.Rows.Add(dr)
        GridList.DataSource = dt

        If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "SagaSoft") = MsgBoxResult.No Then
            'MC_For_Reprice.DockPanel1.Visible = False
            Return
        End If
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If
    End Sub

    Private Sub Branch_EditValueChanged(sender As Object, e As EventArgs) Handles Branch.EditValueChanged
        Xuc_iREP_Units.sBranchCode = Branch.EditValue.ToString()
    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Xuc_iREP_Units.Load_iRepo()
    End Sub
End Class