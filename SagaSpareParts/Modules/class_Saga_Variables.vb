Imports MyClassLibrary.Classes

Namespace Modules
    Public Module class_Saga_Variables
        Public bIsLogged_In As Boolean
        Public bLogin As Boolean
        Public bMainFormLoaded As Boolean

        'User privileges
        Public sBranchCode As String

        'Public sUserName As String
        Public isAccounting As Boolean

        Public isAudit As Boolean
        Public isLogistics As Boolean
        Public isHR As Boolean

        Public sCorporation As String
        Public dsAgents As DataSet = New DataSet()
        Public dsBranches As DataSet = New DataSet()
        Public dsAEs As DataSet = New DataSet()
        Public dsModels As DataSet = New DataSet()
        Public dsCOA As DataSet = New DataSet()

        Public dtStart As DateTime
        Public dtEnd As DateTime

        Public corporation As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public corporation_All As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public branch As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public iBranchRowCount As Integer
        Public agent As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public ae As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public employee As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public engine As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public engineReceived As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public mc As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public coaAll As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public coaSummary As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public coaDetail As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public coaBank As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public bank As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public check As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public forliquidation As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public liquidation As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public user As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public budget As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public journal_Profile As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public petty_cash_Profile As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()

        Public unitStatus As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public brand As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public brandSupplier As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public mcModel As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public mcColor As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public purchaseOrder As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public partsnumber As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public invoices As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public trans_Category As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public partsnumbers As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public SPA_Request As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public inclusion As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public mcUnit As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public assetItem As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()

        Public SPA_purchaseOrder As DevExpress.XtraEditors.LookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Public iUnliquidated As Integer

        Public Sub Initialize_Corporation()
            class_Database.BindData(class_Database.ICSConnection, corporation, "SELECT * FROM acc_Corporations WHERE IsCustom <> 1", "acc_Corporations")
        End Sub

        Public Sub Initialize_Corporation_All()
            class_Database.BindData(class_Database.ICSConnection, corporation_All, "SELECT Code, Name, Full_Name FROM acc_Corporations", "acc_Corporations")
        End Sub

        Public Sub Initialize_Branch()
            iBranchRowCount = class_Database.Get_Data(class_Database.ICSConnection, "SELECT COUNT(*) AS COUNT FROM BranchParameters", "COUNT")
            class_Database.BindData(class_Database.ICSConnection, branch, "SELECT BranchCode, Pre_Code, Branch, DatabaseDate, Address FROM BranchParameters ORDER BY BranchCode", "BranchParameters")
        End Sub

        Public Sub Initialize_Agent(ByVal sBrCode As String)
            class_Database.BindData(class_Database.ICSConnection, agent, $"SELECT * FROM Agent WHERE BranchCode LIKE '{sBrCode}' ORDER BY AgentCode", "Agent")
        End Sub

        Public Sub Initialize_AE(ByVal sBrCode As String)
            class_Database.BindData(class_Database.ICSConnection, ae, $"SELECT * FROM AccountExecutives WHERE BranchCode LIKE '{sBrCode}' ORDER BY AccountExecutive", "AccountExecutives")
        End Sub

        Public Sub Initialize_MC()
            class_Database.BindData(class_Database.ICSConnection, mc, "SELECT id, branddesc, modeldesc FROM maint_model ORDER BY modeldesc", "maint_model")
        End Sub

        Public Sub Initialize_COA()
            class_Database.BindData(class_Database.ICSConnection, coaAll, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Summary()
            class_Database.BindData(class_Database.ICSConnection, coaSummary, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'SUMMARY' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Detail()
            class_Database.BindData(class_Database.ICSConnection, coaDetail, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'DETAIL' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Bank()
            class_Database.BindData(class_Database.ICSConnection, coaBank, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary_Name, COA_Name, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'DETAIL' AND COA_Code LIKE '10101%' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_Bank()
            class_Database.BindData(class_Database.ICSConnection, bank, "SELECT ID, Bank_Code, Bank_Account, Bank_Name, Account_Name FROM acc_Banks", "acc_Banks")
        End Sub

        Public Sub Initialize_Check(Optional ByVal sCOACode As String = "")
            If sCOACode IsNot Nothing AndAlso sCOACode.StartsWith("10101") Then
                class_Database.BindData(class_Database.ICSConnection, check, $"SELECT ID, Check_Number, Bank_Account, Reference, Check_Amount, Check_Payee, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' ORDER BY ID", "view_Checks")
            End If
        End Sub

        Public Sub Initialize_Budgets()
            class_Database.BindData(class_Database.ICSConnection, budget, $"SELECT * FROM acc_Budgets ORDER BY ID", "acc_Budgets")
        End Sub

        Public Sub Initialize_For_Liquidation()
            class_Database.BindData(class_Database.ICSConnection, forliquidation, $"SELECT * FROM view_Vouchers WHERE IsForLiquidation = '1' ORDER BY ID", "view_Vouchers") ' AND IsLiquidated <> '1' AND Liquidation_Date_Expiry <= CONVERT(VARCHAR(10), '{Date.Now}', 23)
        End Sub

        Public Sub Initialize_Liquidation()
            class_Database.BindData(class_Database.ICSConnection, liquidation, $"SELECT DISTINCT Journal_Reference, MIN(ID) AS ID, MIN(Posting_Date) AS Posting_Date, MIN(Account_Name) AS Account_Name, SUM(Journal_Credit) AS Journal_Credit, MIN(Journal_Description) AS Journal_Description FROM acc_Journal_Entries WHERE Journal_Type LIKE 'JOURNAL_ENTRY' AND Journal_Profile LIKE '%LIQUID%' GROUP BY Journal_Reference ORDER BY ID", "acc_Journal_Entries")
        End Sub

        Public Sub Initialize_Employee(Optional sBrCode As String = "000", Optional ByVal bSplash As Boolean = False)
            If sBrCode.Equals("000") Then
                class_Database.BindData(class_Database.ICSConnection, employee, "SELECT ID, Employee_Code, Employee_Name, Employee_Position, Engine FROM acc_Employees", "acc_Employees", bSplash)
            Else
                class_Database.BindData(class_Database.ICSConnection, employee, $"SELECT ID, Employee_Code, Employee_Name, Employee_Position, Engine, Employee_Branch FROM acc_Employees WHERE Employee_Branch LIKE '{sBrCode}'", "acc_Employees", bSplash)
            End If
        End Sub

        Public Sub Initialize_Engine_Chassis()
            class_Database.BindData(class_Database.ICSConnection, engine, "SELECT id, IfExist, engineno, chassisno, brand, description FROM item_Details WHERE IfExist = 1 AND whCode LIKE 'TEQ'", "item_Details")
        End Sub

        Public Sub Initialize_Engine_Received()
            class_Database.BindData(class_Database.ICSConnection, engineReceived, "SELECT id, engineno, chassisno, brand, model, color FROM item_Details WHERE SourceEvent LIKE 'RECEIVING' AND inventoryStatus LIKE 'APPROVED' ORDER BY id", "item_Details")
        End Sub

        Public Sub Initialize_Users()
            class_Database.BindData(class_Database.ICSConnection, user, "SELECT ID, username, fullname FROM Users", "Users")
        End Sub

        Public Sub Initialize_Unit_Status()
            class_Database.BindData(class_Database.ICSConnection, unitStatus, $"SELECT * FROM maint_whcategory", "maint_whcategory")
        End Sub

        Public Sub Initialize_Brands()
            class_Database.BindData(class_Database.ICSConnection, brand, $"SELECT * FROM view_Brand_Suppliers", "view_Brand_Suppliers")
        End Sub

        Public Sub Initialize_Brand_Suppliers()
            class_Database.BindData(class_Database.ICSConnection, brandSupplier, $"SELECT * FROM acc_Account_Names WHERE Account_Type LIKE 'BRAND_SUPPLIER'", "acc_Account_Names")
        End Sub

        Public Sub Initialize_MC_Models(ByVal bAll As Boolean, Optional ByVal sBrand As String = "HONDA", Optional ByVal bWithFactoryCode As Boolean = False)
            If bAll Then
                class_Database.BindData(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model ORDER BY modeldesc", "maint_model")
            Else
                If bWithFactoryCode Then
                    class_Database.BindData(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model WHERE branddesc LIKE '{sBrand}' AND Model_Code IS NOT NULL ORDER BY modeldesc", "maint_model")
                Else
                    class_Database.BindData(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model WHERE branddesc LIKE '{sBrand}' ORDER BY modeldesc", "maint_model")
                End If
            End If

        End Sub

        Public Sub Initialize_Model_Colors()
            class_Database.BindData(class_Database.ICSConnection, mcColor, $"SELECT * FROM maint_itemcolor", "maint_itemcolor")
        End Sub

        Public Sub Initialize_Purchase_Orders()
            class_Database.BindData(class_Database.ICSConnection, purchaseOrder, $"SELECT * FROM view_Purchase_Orders WHERE IsApproved = 1 ORDER BY ID", "view_Purchase_Orders")
        End Sub

        Public Sub Initialize_SPA_Purchase_Orders()
            class_Database.BindData(class_Database.SPAConnection, SPA_purchaseOrder, $"SELECT * FROM Spare_Parts_Purchase_Order WHERE IsApproved = 1 ORDER BY ID", "Spare_Parts_Purchase_Order")
        End Sub

        Public Sub Initialize_MC_Units(ByVal sBrCode As String, ByVal sUnitStatus As String, ByVal iExist As Integer)
            class_Database.BindData(class_Database.ICSConnection, mcUnit, $"SELECT * FROM item_Details WHERE IfExist LIKE '{iExist}' AND branchcode LIKE '{sBrCode}' AND whCode LIKE '{sUnitStatus}'", "item_Details")
        End Sub

        Public Sub Initialize_Trans_Categories(ByVal sCategory As String)
            class_Database.BindData(class_Database.SPAConnection, trans_Category, $"SELECT * FROM SPA_AccountCodes WHERE IsCommand LIKE '{sCategory}'", "SPA_AccountCodes")
        End Sub
        Public Sub Initialize_Invoice(ByVal iID As String)
            class_Database.BindData(class_Database.SPAConnection, invoices, $"SELECT * FROM SPA_Invoices WHERE Trans_ID LIKE '{iID}'", "SPA_Invoices")
        End Sub

        Public Sub Initialize_Part_Number(ByVal sBrand As String)
            class_Database.BindData(class_Database.ICSConnection, partsnumber, $"SELECT * FROM Spare_Parts_Master WHERE Brand LIKE '{sBrand}'", "Spare_Parts_Master")
        End Sub

        Public Sub Initialize_SPA_Requests(ByVal sBrCode As String)
            class_Database.BindData(class_Database.SPAConnection, SPA_Request, $"SELECT * FROM Spare_Parts_Request WHERE Request_Status LIKE 'Approved' And Branch_Code LIKE '{sBrCode}'", "Spare_Parts_Request")
        End Sub

        Public Sub Initialize_Part_Numbers(ByVal sBranchCode As String)
            class_Database.BindData(class_Database.SPAConnection, partsnumbers, $"SELECT * FROM SPA_Inventory WHERE Quantity > 0 AND InventoryStatus LIKE '{"APPROVED"}' OR InventoryStatus LIKE '{"Approved"}' AND ReceivingBranch LIKE '{sBranchCode}' ORDER BY SRP, Quantity DESC", "SPA_Inventory")
        End Sub

        Public Sub Initialize_Inclusions()
            class_Database.BindData(class_Database.ICSConnection, inclusion, $"SELECT * FROM inv_Inclusions", "inv_Inclusions")
        End Sub

        Public Sub Initialize_Asset_Items()
            class_Database.BindData(class_Database.ICSConnection, assetItem, $"SELECT * FROM inv_Asset_Items", "inv_Asset_Items") 'WHERE Asset_Code NOT LIKE '{sCode}'
        End Sub

        Public Sub Initialize_Journal_Profiles()
            class_Database.BindData(class_Database.ICSConnection, journal_Profile, "SELECT ID, Profile_Code, Journal_Type, Friendly_Name, Profile_Description, Profile_Type FROM acc_Journal_Profiles WHERE Profile_Type LIKE 'PETTY_CASH' ORDER BY Friendly_Name", "acc_Journal_Profiles")
        End Sub

    End Module
End Namespace