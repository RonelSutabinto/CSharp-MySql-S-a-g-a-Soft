Imports MyClassLibrary.Classes
Public Class xuc_iREP_Units
    Inherits DevExpress.XtraEditors.XtraUserControl

    Friend ModelCode, BranchCode, KeyNo, sBranchCode, Classification As String
    Friend Ledgerset, PrevID As Integer

    Friend Price, AOC, DP As Double

    Friend Sub Load_iRepo()
        With Customer_Name.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Branch Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Customer Name"),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNumber", "Account Number", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerSetNumber", "LedgerSet", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model_Code", "Model Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHCode", "WH Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChassisNo", "Chassis Number", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMT", "MA", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrincipalBalance", "Principal Balance", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InterestBalance", "Interest Balance", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OutstandingBalance", "Outstanding Balance", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Inventory ID"),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KeyNo", "Key Number", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DP", "DP Equity", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AOC", "AOC", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EngineNo", "Engine Number"),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WHCategory", "Warehouse Category"),
            New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateReceived", "Date Invactive REPO", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

            class_Database.Bind_Data(class_Database.ICSConnection, Customer_Name, $"SELECT * FROM vw_iREPO_Units where IfExist = '1' AND WHCode = 'IREP' ORDER BY AccountName", "vw_iREPO_Units")

            .DisplayMember = "AccountName"
            .ValueMember = "AccountName"
            .NullValuePrompt = "Select Customer Name..."
        End With
        Customer_Name.ShowPopup()
    End Sub

    Private Sub Customer_Name_EditValueChanged(sender As Object, e As EventArgs) Handles Customer_Name.EditValueChanged

        Account_Number.EditValue = Customer_Name.GetColumnValue("AccountNumber")
        Brand.EditValue = Customer_Name.GetColumnValue("Brand")
        Model.EditValue = Customer_Name.GetColumnValue("Model")
        Color.EditValue = Customer_Name.GetColumnValue("Color")
        Engine_Number.EditValue = Customer_Name.GetColumnValue("EngineNo")
        Chassis_Number.EditValue = Customer_Name.GetColumnValue("ChassisNo")
        Description.EditValue = Customer_Name.GetColumnValue("Description")
        Principal.EditValue = Customer_Name.GetColumnValue("PrincipalBalance")
        Interest.EditValue = Customer_Name.GetColumnValue("InterestBalance")
        Outs_Balance.EditValue = Customer_Name.GetColumnValue("OutstandingBalance")
        BranchCode = Customer_Name.GetColumnValue("branchcode")
        Ledgerset = Customer_Name.GetColumnValue("LedgerSetNumber")
        PrevID = Customer_Name.GetColumnValue("ID")
        MA.EditValue = Customer_Name.GetColumnValue("PMT")
        DP = Customer_Name.GetColumnValue("DP")
        'AOC = Customer_Name.GetColumnValue("AOC")
        DP_Equity.EditValue = DP - AOC
        Classification = "IREP"

        Try
            ModelCode = Customer_Name.GetColumnValue("Model_Code")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try

        Try
            KeyNo = Customer_Name.GetColumnValue("KeyNo")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub DP_Equity_EditValueChanged(sender As Object, e As EventArgs) Handles DP_Equity.EditValueChanged
        If DP_Equity.EditValue < "0" Then
            DP_Equity.EditValue = DP
        End If
    End Sub
End Class
