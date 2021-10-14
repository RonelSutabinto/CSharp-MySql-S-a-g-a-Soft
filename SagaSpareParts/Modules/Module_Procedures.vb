Imports DevExpress
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Module Module_Procedures
    Friend bLoopStop As Boolean
    Public branch As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()

    Public unitStatus As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public brand As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public brandSupplier As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public mcModel As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public mcColor As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public purchaseOrder As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public inclusion As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public mcUnit As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public assetItem As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public mcPromo As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public mcFreebie As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public partsnumber As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public invoices As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public trans_Category As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public pdc_names As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public partsnumbers As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public SPA_Request As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public CIF As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public customer As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public subdealer As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Public orderslip As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()

    Public SPA_purchaseOrder As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()

    Friend Sub Show_Spare_Part(ByVal sCode As String)
        class_Procedures.splash_Show("Spare Part")
        Dim frm As Forms.frm_SPA = New Forms.frm_SPA() With {
        .Text = $"{ .Text} - {sCode}"
    }

        With frm
            .Show()
            .Xuc_Spare_Part.Control_Initialize()
            .Xuc_Spare_Part.Control_Retrieve(sCode)
        End With

        class_Procedures.splash_Close()
    End Sub

    Public Sub Show_SPA_Sales(ByVal sBrCode As String, ByVal dtStart As Date, ByVal iTableID As Integer, ByVal sORNumber As String, Optional ByVal sAccountName As String = "")
        class_Procedures.splash_Show("Branch Collections")
        Dim frm As Forms.frm_SPA_Sales = New Forms.frm_SPA_Sales() With {
        .Text = $"{sAccountName} {dtStart.ToLongDateString}"
    }
        frm.Show()
        With frm
        End With
        class_Procedures.splash_Close()
    End Sub

    Public Sub Initialize_Tran_Category(ByVal sCategory As String)
        class_Database.Bind_Data(class_Database.SPAConnection, trans_Category, $"SELECT * FROM SPA_AccountCodes WHERE IsCommand LIKE '{sCategory}'", "SPA_AccountCodes")
    End Sub
    Public Sub Initialize_Tran_Category(ByVal trans_Categories As LookUpEdit)
        With trans_Categories.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionID", "ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transactions", "Categories"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mnemonic", "Mnemonic")})

            .DataSource = trans_Category.Properties.DataSource
            .DisplayMember = "Transactions"
            .ValueMember = "Transactions"
            .NullValuePrompt = "Select Transaction Category..."
        End With
    End Sub

    Public Sub Initialize_CIFAccounts(ByVal sBranchCode As String)
        class_Database.Bind_Data(class_Database.ICSConnection, CIF, $"SELECT DISTINCT SeqID, CIFKey, FullName, Address FROM CIFAccounts WHERE BranchCode LIKE '{sBranchCode}'", "BranchCode")
    End Sub
    Public Sub Initialize_CIFAccounts(ByVal CIFAccounts As LookUpEdit)
        With CIFAccounts.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SeqID", "ID", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CIFKey", "CIFKey"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address")})

            .DataSource = CIF.Properties.DataSource
            .DisplayMember = "FullName"
            .ValueMember = "FullName"
            .NullValuePrompt = "Select Full Name..."
        End With
    End Sub
    Public Function get_Approved_PO() As Integer
        Return Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"Select COUNT(*) As COUNT FROM Spare_Parts_Order_Slip WHERE Order_Status Like 'APPROVED'", "COUNT"))
    End Function
    Public Sub Initialize_HeadOffice(ByVal sBranchCode As String)
        class_Database.Bind_Data(class_Database.ICSConnection, branch, $"SELECT * FROM BranchParameters WHERE Branchcode LIKE '{sBranchCode}'", "BranchParameters")
    End Sub
    Public Sub Initialize_HeadOffice(ByVal sBranch As LookUpEdit)
        Dim sBrCode As String

        Try
            sBrCode = sBranch.EditValue.ToString
        Catch ex As Exception
            sBrCode = "000"
        End Try

        Try
            With sBranch.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Number"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Code"),
                                          New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name")})

                .DataSource = branch.Properties.DataSource
                .DisplayMember = "Branch"
                .ValueMember = "BranchCode"
                .NullValuePrompt = "Select Branch..."
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        Finally
            sBranch.EditValue = sBrCode
        End Try
    End Sub

    Public Sub Initialize_Customers(ByVal sBranchCode As String)
        class_Database.Bind_Data(class_Database.ICSConnection, customer, $"SELECT DISTINCT BranchCode, AccountName, AccountNumber, DateGranted, AccountAddress, LedgerSetNumber FROM CustAccount WHERE BranchCode LIKE '{sBranchCode}'", "BranchCode")
    End Sub
    Public Sub Initialize_Customers(ByVal customers As LookUpEdit)
        With customers.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "BranchCode", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Name"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNumber", "Account Number", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateGranted", "Date Granted", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountAddress", "Address"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LedgerSetNumber", "Ledger Set", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default)})

            .DataSource = customer.Properties.DataSource
            .DisplayMember = "AccountName"
            .ValueMember = "AccountName"
            .NullValuePrompt = "Select Full Name..."
        End With
    End Sub
    Public Sub Initialize_SubDealer()
        class_Database.Bind_Data(class_Database.SPAConnection, subdealer, $"SELECT DISTINCT SubName, SubAddress, SubDealer_Code FROM SPA_SubDealers", "SubName")
    End Sub
    Public Sub Initialize_SubDealer(ByVal subdealers As LookUpEdit)
        With subdealers.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubName", "Name"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubDealer_Code", "Code"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubAddress", "Account Number")})

            .DataSource = subdealer.Properties.DataSource
            .DisplayMember = "SubName"
            .ValueMember = "SubName"
            .NullValuePrompt = "Select Sub-Dealer Name..."
        End With
    End Sub
    Public Sub Initialize_Invoice(ByVal iID As String)
        class_Database.Bind_Data(class_Database.SPAConnection, invoices, $"SELECT * FROM SPA_Invoices WHERE Trans_ID LIKE '{iID}'", "SPA_Invoices")
    End Sub

    Public Sub Initialize_Invoices(ByVal invoice As LookUpEdit)
        With invoice.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Invoices", "Invoices"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mnemonic", "Mnemonic")})

            .DataSource = invoices.Properties.DataSource
            .DisplayMember = "Invoices"
            .ValueMember = "Invoices"
            .NullValuePrompt = "Select Invoices..."
        End With
    End Sub

    Public Function Create_Badge(ByVal adornerManager As DevExpress.Utils.VisualEffects.AdornerUIManager, ByVal targetButton As BarButtonItem, ByVal paintStyle As DevExpress.Utils.VisualEffects.BadgePaintStyle, ByVal iCount As Integer) As Integer
        Dim badge = New DevExpress.Utils.VisualEffects.Badge()
        adornerManager.Elements.Add(badge)
        badge.Visible = False
        badge.TargetElement = targetButton
        badge.Properties.PaintStyle = paintStyle
        badge.Properties.Text = iCount.ToString()
        If iCount > 0 Then badge.Visible = True
        Return iCount
    End Function

    Public Function get_Branch_Address(ByVal sBrCode As String) As String
        Return CStr(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Address, BM FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Address"))
    End Function
    Public Function get_Branch_Pre_Code(ByVal sBrCode As String) As String
        Return CStr(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Pre_Code FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Pre_Code"))
    End Function

    Public Sub Initialize_SPA_Requests(ByVal sBrCode As String)
        class_Database.Bind_Data(class_Database.SPAConnection, SPA_Request, $"SELECT * FROM Spare_Parts_Request WHERE (Request_Status LIKE 'Approved' OR Request_Status LIKE 'APPROVED') And Branch_Code LIKE '{sBrCode}'", "Spare_Parts_Request")
    End Sub
    Public Sub Initialize_SPA_Request(ByVal SPA_Req As LookUpEdit)
        With SPA_Req.Properties

            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRF", "SRF Number"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch_From", "Branch From"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Transaction_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

            .DataSource = SPA_Request.Properties.DataSource
            .DisplayMember = "Reference"
            .ValueMember = "Reference"
            .NullValuePrompt = "Select SFR..."
        End With
    End Sub
    Public Sub Initialize_Brands()
        class_Database.Bind_Data(class_Database.ICSConnection, brand, $"SELECT * FROM view_Brand_Suppliers", "view_Brand_Suppliers")
    End Sub
    Public Sub Initialize_Brand(ByVal brand As LookUpEdit)
        With brand.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("branddesc", "Brand"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Account Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Supplier"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Mobile", "Contact Number(s)"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Address", "Address"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Description", "Description")})

            .DataSource = brand.Properties.DataSource
            .DisplayMember = "branddesc"
            .ValueMember = "Brand_Code"
            .NullValuePrompt = "Select Brand..."
        End With
    End Sub
    Public Sub Initialize_Part_Number(ByVal sBrand As String)
        If class_Database.OpenDB(class_Database.SPAConnection) Then
            class_Database.Bind_Data(class_Database.SPAConnection, partsnumber, $"SELECT * FROM vw_Spa_Master WHERE Brand LIKE '{sBrand}'", "vw_Spa_Master")
        End If
    End Sub
    Public Sub Initialize_Part_Number(ByVal partnumber As RepositoryItemLookUpEdit)
        With partnumber
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Code", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Parts Name")})

            .DataSource = partsnumber.Properties.DataSource
            .DisplayMember = "PartsNumber"
            .ValueMember = "PartsNumber"
            .NullValuePrompt = "Select Part Number..."
        End With
    End Sub

    Public Sub Initialize_Order_Slip(ByVal sBrand As String)
        If class_Database.OpenDB(class_Database.SPAConnection) Then
            class_Database.Bind_Data(class_Database.SPAConnection, orderslip, $"SELECT * FROM Spare_Parts_Order_Slip WHERE Brand LIKE '{sBrand}'", "Spare_Parts_Order_Slip")
        End If
    End Sub
    Public Sub Initialize_Order_Slip(ByVal order As RepositoryItemLookUpEdit)
        With order
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Code", "Order Slip", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch_From", "Ordering Branch", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Date", "Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

            .DataSource = orderslip.Properties.DataSource
            .DisplayMember = "Order_Code"
            .ValueMember = "Order_Code"
            .NullValuePrompt = "Select Order Code..."
        End With
    End Sub
    Public Sub Initialize_Order_Slip(ByVal order As LookUpEdit)
        With order.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Code", "Order Slip", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch_From", "Ordering Branch", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Date", "Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far)})

            .DataSource = orderslip.Properties.DataSource
            .DisplayMember = "Order_Code"
            .DropDownRows = 10
            .ValueMember = "Order_Code"
            .NullValuePrompt = "Select Order Code..."
        End With
    End Sub
    Public Sub Initialize_SPA_Purchase_Orders()
        class_Database.Bind_Data(class_Database.SPAConnection, SPA_purchaseOrder, $"SELECT * FROM Spare_Parts_Purchase_Order WHERE IsApproved = 1 ORDER BY ID", "Spare_Parts_Purchase_Order")
    End Sub
    Public Sub Initialize_SPA_Purchase_Orders(ByVal SPA_PO As LookUpEdit)
        With SPA_PO.Properties
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Code", ""),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Supplier_Name", "Supplier"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Date", "P. O. Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QTY_Total", "Quantity"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order_Description", "Description")})

            .DataSource = SPA_purchaseOrder.Properties.DataSource
            .DisplayMember = "Order_Code"
            .ValueMember = "Order_Code"
            .NullValuePrompt = "Select P. O. Number..."
        End With
    End Sub
    Public Sub Initialize_Branch()
        iBranchRowCount = Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, "SELECT COUNT(*) AS COUNT FROM BranchParameters", "COUNT"))
        class_Database.Bind_Data(class_Database.ICSConnection, branch, "SELECT BranchCode, Pre_Code, Branch, DatabaseDate FROM BranchParameters ORDER BY BranchCode", "BranchParameters")
    End Sub
    Public Sub Initialize_Branch(ByVal lue_Branch As LookUpEdit)
        Dim sBrCode As String
        Try
            If lue_Branch.EditValue Is Nothing Then
                sBrCode = class_Saga_Variables.sBranchCode
            Else
                sBrCode = CStr(lue_Branch.EditValue)
            End If
        Catch ex As Exception
            sBrCode = class_Saga_Variables.sBranchCode
            class_Procedures.Show_Error(Ex)
        End Try

        Try
            With lue_Branch.Properties
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name")})

                .DataSource = branch.Properties.DataSource
                .DropDownRows = class_Saga_Variables.iBranchRowCount
                .DisplayMember = "Branch"
                .ValueMember = "BranchCode"
                .TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        Finally
            lue_Branch.EditValue = sBrCode
        End Try
    End Sub

    Public Sub Initialize_Branch(ByVal barItem As BarEditItem, ByVal bRanch As RepositoryItemLookUpEdit, Optional bWithPostingDate As Boolean = False)
        With barItem
            .EditWidth = 170
            .EditValue = class_Saga_Variables.sBranchCode
        End With

        With bRanch
            Try
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name"),
                    New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DatabaseDate", "Posting Date", -1, DevExpress.Utils.FormatType.DateTime, "MMMM dd, yyyy", bWithPostingDate, DevExpress.Utils.HorzAlignment.Far)})

                .DataSource = class_Saga_Variables.branch.Properties.DataSource
                .DisplayMember = "Branch"
                .DropDownRows = class_Saga_Variables.iBranchRowCount
                .ValueMember = "BranchCode"

                class_Procedures.Initialize_RepositoryItem(bRanch, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                barItem.EditValue = class_Saga_Variables.sBranchCode
            End Try
        End With
    End Sub

    Public Sub Initialize_Branch(ByVal lue_Branch As RepositoryItemLookUpEdit)
        Try
            With lue_Branch
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Code"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pre_Code", "Pre-Code"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch Name")})

                .DataSource = class_Saga_Variables.branch.Properties.DataSource
                .DisplayMember = "Branch"
                .DropDownRows = class_Saga_Variables.iBranchRowCount
                .ValueMember = "BranchCode"
                .NullText = Nothing

                class_Procedures.Initialize_RepositoryItem(lue_Branch, XtraEditors.Controls.TextEditStyles.DisableTextEditor)
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub
    Public Sub Initialize_Parts_Numbers(ByVal sBranchCode As String)
        class_Database.Bind_Data(class_Database.SPAConnection, partsnumbers, $"SELECT * FROM SPA_Inventory WHERE Quantity > 0 AND (InventoryStatus LIKE '{"APPROVED"}' OR InventoryStatus LIKE '{"Approved"}') AND ReceivingBranch LIKE '{sBranchCode}' ORDER BY SRP, Quantity DESC", "SPA_Inventory")
    End Sub
    Public Sub Initialize_Parts_Numbers(ByVal partnumbers As RepositoryItemLookUpEdit)
        With partnumbers
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity", -1, DevExpress.Utils.FormatType.Numeric, "d", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPCostWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand", "Brand", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReceivingBranch", "Branch Code"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Part Name")})

            .DataSource = partsnumbers.Properties.DataSource
            .DisplayMember = "PartsNumber"
            .ValueMember = "PartsNumber"
            .NullValuePrompt = "Select Part Number..."
        End With
    End Sub

    Public Sub Initialize_Parts_Numbers1(ByVal partnumbers As RepositoryItemLookUpEdit)
        With partnumbers
            .Columns.Clear()
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsNumber", "Part Number"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Quantity", -1, DevExpress.Utils.FormatType.Numeric, "d", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SPCostWOVAT", "Cost", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReceivingBranch", "Branch Code", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReceivingBranch", "Branch Code"),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRP", "SRP", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartsName", "Part Name")})

            .DataSource = partsnumbers.Properties.DataSource
            .DisplayMember = "id"
            .ValueMember = "id"
            .NullValuePrompt = "Select Part Number ID..."
        End With
    End Sub
End Module