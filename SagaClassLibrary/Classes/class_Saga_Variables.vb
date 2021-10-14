Imports System.Data.SqlClient
Imports MyClassLibrary.Classes

Namespace Classes
    Public Module class_Saga_Variables
        Public bIsLogged_In As Boolean
        Public bLogin As Boolean
        Public bMainFormLoaded As Boolean

        'User privileges
        Public sCorporation As String
        Public sBranchCode As String
        Public dtCutOffDate As Date

        Public isMaintenance, isApprover As Boolean
        Public isAdmin, isCashier, isInventory As Boolean
        Public isHR, isLogistics, isAccounting, isAudit As Boolean
        Public isUpdate, isBetaTester As Boolean

        Public sDLLFiles As String()

        Public dsAgents As DataSet = New DataSet()
        Public dsBranches As DataSet = New DataSet()
        Public dsAEs As DataSet = New DataSet()
        Public dsModels As DataSet = New DataSet()
        Public dsCOA As DataSet = New DataSet()

        Public dtStart As Date
        Public dtEnd As Date

        Public bLoopStop As Boolean

        Public Enum eLoad_Type
            ID
            Account
            Ledger
            CIF
            Engine
            Balance
            Batch
            Range
            Daily
            Monthly
        End Enum

        Public loadType As eLoad_Type

        Public Enum eCOA_Type
            COA_All
            COA_Summary
            COA_Detail
            COA_Bank
        End Enum

        Public Enum eVoucherType
            Check
            Expense
            Journal
        End Enum

        Public Enum eBalanceType
            DETAIL
            SUMMARY
        End Enum

        Public balanceType As eBalanceType

        'Public corporation As  New DevExpress.XtraEditors.LookUpEdit()
        Public corporation_All As New DevExpress.XtraEditors.LookUpEdit()
        Public branch As New DevExpress.XtraEditors.LookUpEdit()
        Public iBranchRowCount As Integer
        Public agent As New DevExpress.XtraEditors.LookUpEdit()
        Public ae As New DevExpress.XtraEditors.LookUpEdit()
        Public employee As New DevExpress.XtraEditors.LookUpEdit()
        Public adjustment As New DevExpress.XtraEditors.LookUpEdit()
        'Public engine As New DevExpress.XtraEditors.LookUpEdit()
        Public engineReceived As New DevExpress.XtraEditors.LookUpEdit()
        Public mc As New DevExpress.XtraEditors.LookUpEdit()
        Public coaAll As New DevExpress.XtraEditors.LookUpEdit()
        Public coaSummary As New DevExpress.XtraEditors.LookUpEdit()
        Public coaDetail As New DevExpress.XtraEditors.LookUpEdit()
        Public coaBank As New DevExpress.XtraEditors.LookUpEdit()
        Public bank As New DevExpress.XtraEditors.LookUpEdit()
        Public check As New DevExpress.XtraEditors.LookUpEdit()
        Public forliquidation As New DevExpress.XtraEditors.LookUpEdit()
        Public liquidation As New DevExpress.XtraEditors.LookUpEdit()
        Public user As New DevExpress.XtraEditors.LookUpEdit()
        Public budget As New DevExpress.XtraEditors.LookUpEdit()
        Public journal_Profile As New DevExpress.XtraEditors.LookUpEdit()
        Public petty_cash_Profile As New DevExpress.XtraEditors.LookUpEdit()

        'Public unitStatus As  New DevExpress.XtraEditors.LookUpEdit()
        Public brand As New DevExpress.XtraEditors.LookUpEdit()
        Public mcModel As New DevExpress.XtraEditors.LookUpEdit()
        Public mcColor As New DevExpress.XtraEditors.LookUpEdit()
        Public purchaseOrder As New DevExpress.XtraEditors.LookUpEdit()
        Public mc_Request As New DevExpress.XtraEditors.LookUpEdit()
        Public inclusion As New DevExpress.XtraEditors.LookUpEdit()
        Public mcUnit As New DevExpress.XtraEditors.LookUpEdit()
        Public assetItem As New DevExpress.XtraEditors.LookUpEdit()
        Public mcPromo As New DevExpress.XtraEditors.LookUpEdit()
        Public mcFreebie As New DevExpress.XtraEditors.LookUpEdit()

        Public systemRequest As New DevExpress.XtraEditors.LookUpEdit()
        Public paymentRequest As New DevExpress.XtraEditors.LookUpEdit()
        Public systemTransmittal As New DevExpress.XtraEditors.LookUpEdit()

        Public iUnliquidated As Integer

        Public Sub Initialize_Branch()
            iBranchRowCount = class_Database.Get_Data(class_Database.ICSConnection, "SELECT COUNT(*) AS COUNT FROM BranchParameters", "COUNT")
            class_Database.Bind_Data(class_Database.ICSConnection, branch, "SELECT * FROM BranchParameters ORDER BY BranchCode", "BranchParameters")
        End Sub

        Public Sub Initialize_Agent(ByVal sBrCode As String)
            class_Database.Bind_Data(class_Database.ICSConnection, agent, $"SELECT * FROM Agent WHERE BranchCode LIKE '{sBrCode}' ORDER BY AgentCode", "Agent")
        End Sub

        Public Sub Initialize_AE(ByVal sBrCode As String)
            class_Database.Bind_Data(class_Database.ICSConnection, ae, $"SELECT * FROM AccountExecutives WHERE BranchCode LIKE '{sBrCode}' ORDER BY AccountExecutive", "AccountExecutives")
        End Sub

        Public Sub Initialize_MC()
            class_Database.Bind_Data(class_Database.ICSConnection, mc, "SELECT id, branddesc, modeldesc FROM maint_model ORDER BY modeldesc", "maint_model")
        End Sub

        Public Sub Initialize_COA()
            class_Database.Bind_Data(class_Database.ICSConnection, coaAll, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Summary()
            class_Database.Bind_Data(class_Database.ICSConnection, coaSummary, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'SUMMARY' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Detail()
            class_Database.Bind_Data(class_Database.ICSConnection, coaDetail, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary, COA_Summary_Name, COA_Name, Balance_Running, Balance_Limit, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'DETAIL' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_COA_Bank()
            class_Database.Bind_Data(class_Database.ICSConnection, coaBank, "SELECT ID, COA_Code, Corporation, COA_Level, COA_Type, COA_Summary_Name, COA_Name, COA_Desc, COA_Normal FROM view_Chart_Of_Accounts WHERE COA_Type LIKE 'DETAIL' AND COA_Code LIKE '10101%' ORDER BY COA_Name", "view_Chart_Of_Accounts")
        End Sub

        Public Sub Initialize_For_Liquidation()
            class_Database.Bind_Data(class_Database.ICSConnection, forliquidation, $"SELECT * FROM view_Vouchers WHERE IsForLiquidation = '1' ORDER BY ID", "view_Vouchers") ' AND IsLiquidated <> '1' AND Liquidation_Date_Expiry <= CONVERT(VARCHAR(10), '{Date.Now}', 23)
        End Sub

        Public Sub Initialize_Employee(Optional sBrCode As String = "000", Optional ByVal bSplash As Boolean = False)
            If sBrCode.Equals("000") Then
                class_Database.Bind_Data(class_Database.ICSConnection, employee, "SELECT ID, Employee_Code, Employee_Name, Employee_Position, Engine FROM acc_Employees", "acc_Employees", bSplash)
            Else
                class_Database.Bind_Data(class_Database.ICSConnection, employee, $"SELECT ID, Employee_Code, Employee_Name, Employee_Position, Engine, Employee_Branch FROM acc_Employees WHERE Employee_Branch LIKE '{sBrCode}' AND Employment_Status LIKE 'ACTIVE'", "acc_Employees", bSplash)
            End If
        End Sub

        Public Sub Initialize_Users()
            class_Database.Bind_Data(class_Database.ICSConnection, user, "SELECT ID, username, fullname FROM Users", "Users")
        End Sub

        Public Sub Initialize_Brands()
            class_Database.Bind_Data(class_Database.ICSConnection, brand, $"SELECT * FROM view_Brand_Suppliers", "view_Brand_Suppliers")
        End Sub

        Public Sub Initialize_MC_Models(ByVal bAllBrands As Boolean, Optional ByVal sBrand As String = "HONDA", Optional ByVal bWithFactoryCode As Boolean = False)
            If bAllBrands Then
                class_Database.Bind_Data(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model ORDER BY modeldesc", "maint_model")
            Else
                If bWithFactoryCode Then
                    class_Database.Bind_Data(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model WHERE branddesc LIKE '{sBrand}' AND Model_Status LIKE '0' AND Model_Code IS NOT NULL ORDER BY modeldesc", "maint_model")
                Else
                    class_Database.Bind_Data(class_Database.ICSConnection, mcModel, $"SELECT * FROM maint_model WHERE branddesc LIKE '{sBrand}' AND Model_Status LIKE '0' ORDER BY modeldesc", "maint_model")
                End If
            End If
        End Sub

        Public Sub Initialize_Model_Colors()
            class_Database.Bind_Data(class_Database.ICSConnection, mcColor, $"SELECT * FROM maint_itemcolor", "maint_itemcolor")
        End Sub

        'Public Sub Initialize_Purchase_Orders(ByVal sBrand As String)
        '    class_Database.Bind_Data(class_Database.ICSConnection, purchaseOrder, $"SELECT * FROM view_Purchase_Orders WHERE Brand_Name LIKE '{sBrand}' AND IsApproved = 1 ORDER BY ID DESC", "view_Purchase_Orders")
        'End Sub

        'Public Sub Initialize_MC_Requests(ByVal sBrFrom As String, ByVal sBrTo As String)
        '    Dim sql As String = "SELECT REQ.ID AS ID, " +
        '                            "REQ.Request_Code As Request_Code, " +
        '                            "BRN.Branch_Local AS Branch, " +
        '                            "REQ.WHCode As WHCode, " +
        '                            "REQ.Quantity AS Quantity, " +
        '                            "REQ.Added_Date As Added_Date, " +
        '                            "REQ.Request_Description AS Request_Description, " +
        '                            "REQ.Notes AS Notes " +
        '                        "FROM inv_MC_Requests As REQ INNER Join BranchParameters As BRN " +
        '                                                    "ON REQ.Branch_Code = BRN.BranchCode " +
        '                        "WHERE Request_Status Like 'APPROVED'  " +
        '                            $"AND Supplier_Code Like '{sBrFrom}'  " +
        '                            $"AND Branch_Code Like '{sBrTo}'  " +
        '                        "ORDER BY ID DESC"

        '    class_Database.Bind_Data(class_Database.ICSConnection, mc_Request, sql, "inv_MC_Requests")
        'End Sub

        Public Sub Initialize_MC_Unit(ByVal sEngine As String)
            class_Database.Bind_Data(class_Database.ICSConnection, mcUnit, $"SELECT * FROM item_Details WHERE EngineNo LIKE '{sEngine}'", "item_Details")
        End Sub

        Public Sub Initialize_MC_Units(ByVal sBrCode As String, ByVal bExist As Boolean)
            If bExist Then
                class_Database.Bind_Data(class_Database.ICSConnection, mcUnit, $"SELECT * FROM item_Details WHERE IfExist LIKE '1' AND branchcode LIKE '{sBrCode}' AND whCode NOT LIKE 'DEP' ORDER BY WHCode", "item_Details")
            Else
                'Dim parameters As SqlParameter() = {
                '    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                '    New SqlParameter("@Action_Type", "LOAD_UNDIPOSITED")
                '}
                Dim sql As String = "SELECT " +
                                    "MAX(MC.ID) As ID, " +
                                    "MAX(MC.WHCode) As WHCode, " +
                                    "MAX(MC.EngineNo) As EngineNo, " +
                                    "MAX(MC.ChassisNo) As ChassisNo, " +
                                    "MAX(MC.Model_Code) As Model_Code, " +
                                    "MAX(MC.Brand) As Brand, " +
                                    "MAX(MC.Model) As Model, " +
                                    "MAX(MC.Color) As Color, " +
                                    "MAX(MC.Description) As Description, " +
                                    "MAX(AC.AccountName) As Note " +
                                $"From item_Details As MC LEFT Join CustAccount As AC On MC.EngineNo = AC.EngineNo " +
                                $"Where AC.BranchCode Like '{sBrCode}' " +
                                    "And AC.AccountStatus Not Like 'DEP' " +
                                    "And AC.OutstandingBalance > 0 " +
                                $"GROUP BY MC.EngineNo"
                class_Database.Bind_Data(class_Database.ICSConnection, mcUnit, sql, "item_Details")
            End If
        End Sub

        Public Sub Initialize_MC_PO_Units(ByVal sOrderCode As String)
            class_Database.Bind_Data(class_Database.ICSConnection, mcUnit, $"SELECT * FROM inv_Purchase_Order_Units WHERE Order_Code LIKE '{sOrderCode}'", "inv_Purchase_Order_Units")
        End Sub

        'Public Sub Initialize_Inclusions()
        '    class_Database.Bind_Data(class_Database.ICSConnection, inclusion, $"SELECT * FROM inv_Inclusions", "inv_Inclusions")
        'End Sub

        Public Sub Initialize_Asset_Items()
            class_Database.Bind_Data(class_Database.ICSConnection, assetItem, $"SELECT * FROM inv_Asset_Items", "inv_Asset_Items")
        End Sub

        'Public Sub Initialize_MC_Promotions()
        '    class_Database.Bind_Data(class_Database.ICSConnection, mcPromo, $"SELECT * FROM acc_MC_Promotions", "acc_MC_Promotions")
        'End Sub

        'Public Sub Initialize_MC_Freebies(ByVal sBrCode As String)
        '    If class_Database.OpenDB(class_Database.SPAConnection) Then
        '        class_Database.Bind_Data(class_Database.SPAConnection, mcFreebie, $"SELECT DISTINCT (PartsNumber), ID, Brand, Category, PartsName, Quantity, SRP FROM Spare_Parts.dbo.SPA_Inventory WHERE Category LIKE 'FREE%' AND ReceivingBranch LIKE '{sBrCode}'", "Spare_Parts.dbo.SPA_Inventory")
        '    End If
        'End Sub

        'Public Sub Initialize_Journal_Profiles()
        '    class_Database.Bind_Data(class_Database.ICSConnection, journal_Profile, "SELECT ID, Profile_Code, Journal_Type, Friendly_Name, Profile_Description, Profile_Type FROM acc_Journal_Profiles WHERE Profile_Type LIKE 'PETTY_CASH' ORDER BY Friendly_Name", "acc_Journal_Profiles")
        'End Sub

        Public Sub Initialize_System_Requests()
            class_Database.Bind_Data(class_Database.ICSConnection, systemRequest, $"SELECT * FROM inv_Requests", "inv_Requests")
        End Sub

        Public Sub Initialize_Payment_Requests()
            class_Database.Bind_Data(class_Database.ICSConnection, systemRequest, $"SELECT * FROM acc_Payment_Requests", "acc_Payment_Requests")
        End Sub

        Public Sub Initialize_System_Transmittals()
            class_Database.Bind_Data(class_Database.ICSConnection, systemRequest, $"SELECT * FROM inv_Transmittals", "inv_Transmittals")
        End Sub
    End Module
End Namespace