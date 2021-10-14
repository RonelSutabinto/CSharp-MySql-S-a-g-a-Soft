Partial Friend Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.lookUp_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.barSubItemNavigation = New DevExpress.XtraBars.BarSubItem()
        Me.btn_Server_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Initialize_Controls = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_User_Change = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_User_Lock = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Quit = New DevExpress.XtraBars.BarButtonItem()
        Me.employeesBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.customersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Suppliers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Customers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Spare_Parts = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Spare_Part_Sales = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SPA_Inventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Spare_Part_Costing = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Users = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Server_Connection = New DevExpress.XtraBars.BarButtonItem()
        Me.popup_Connection = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.btn_Connection_Connect = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Connection_Test = New DevExpress.XtraEditors.SimpleButton()
        Me.xuc_SQL_Connection = New MyClassLibrary.Controls.Security.xuc_SQL_Connection()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btn_Server_Ping = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_User_Login = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Server_IP_Access = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_User_Name = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar_User_Position = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar_IP_Server = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar_IP_Local = New DevExpress.XtraBars.BarStaticItem()
        Me.btn_Server_Ping_Monitor = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Agents = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Info_Centers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Branches = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Customer_Migration = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Customer_Accounts = New DevExpress.XtraBars.BarButtonItem()
        Me.popup_Account_Search = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.xuc_Accounts = New SagaClassLibrary.Controls.Information.Account.xuc_Accounts()
        Me.search_Name = New DevExpress.XtraEditors.SearchControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btn_Account_Executives = New DevExpress.XtraBars.BarButtonItem()
        Me.BarToggleSwitchItem_Splash_Wait = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_Models = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_Unit_Version = New DevExpress.XtraBars.BarStaticItem()
        Me.BarToggleSwitchItem_Continous = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.barEdit_Host = New DevExpress.XtraBars.BarEditItem()
        Me.repositoryItem_Host = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarToggleSwitchItem_Host = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_Collections = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Releases = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Release = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_MC_Sale_New = New DevExpress.XtraBars.BarButtonItem()
        Me.barEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
        Me.repository_Date_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.barEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
        Me.repository_Date_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_Monitoring_Payments = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Trial_Balance = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Receivables = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Inventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Chart_Of_Accounts = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.BarToggleSwitchItem_Auto_Update = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_Password_Change = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Account_Applications = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Aging = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Query = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Report_Designer = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Report_Designer_Ribbon = New DevExpress.XtraBars.BarButtonItem()
        Me.barMdiChildrenListItem = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.btn_Journal_Profiles = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Month = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Day = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Today = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Vouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Voucher = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Voucher_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Account_Names = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Employees = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Credit_Memo = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Item_Colors = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Printing_Detail = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupControlContainer_Printing_Detail = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.xuc_Printing_Detail = New SagaClassLibrary.Controls.Persons.xuc_Printing_Detail()
        Me.BarToggleSwitchItem_Notification = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_Banks = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Check_Numbers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Adjustments = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Chat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemPopupContainerEdit_Search = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.PopupContainerControl_Search = New DevExpress.XtraEditors.PopupContainerControl()
        Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
        Me.btn_Repossesed = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Brands = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SMS_Configuration = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupContainerControl_SMS_Config = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.btn_SMS_Sender = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Dashboard_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Add_Items = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Add_New = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_New_Check = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New_Expense = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New_COA = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New_Account_Name = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New_Journal_Entry = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New_Voucher = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Backup = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Budgets = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Journal_Vouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Petty_Cash = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Petty_Cash = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Petty_Cash_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Error_Report = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Petty_Cash_Profiles = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Ticket_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Tickets = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Ticket = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Ticket_Groups = New DevExpress.XtraBars.BarButtonItem()
        Me.BarToggleSwitchItem_Check_Errors = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_Purchase_Orders = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Purchase_Order = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Wizard_New_Purchase_Order = New DevExpress.XtraBars.BarButtonItem()
        Me.BarToggleSwitchItem_Stack_Trace_Error = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.btn_MC_Transactions = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Receiving_Transfer = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Wizard_New_MC_Transaction = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Inclusions = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Inclusion_Inventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Asset_Items = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Assets = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Asset_New = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinDropDownButtonItem = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.SkinPaletteDropDownButonItem = New DevExpress.XtraBars.SkinPaletteDropDownButtonItem()
        Me.SkinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinPaletteRibbonGalleryBarItem = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        Me.btn_Payment_Requests = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_Payment_Request = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Payment_Request = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Promotion_Discounts = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_System_Requests = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_System_Request = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_System_Request = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Transmittals = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Unit_Invoices = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Salaries = New DevExpress.XtraBars.BarButtonItem()
        Me.Annual_Leave = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Leave_Absences = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Attendance = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Payroll = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Pay_Checks = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Helps = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MC_Requests = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu_MC_Request = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_Wizard_New_MC_Request = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Schedule_Types = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Schedules = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Date_Branch = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Date_Cut_Off = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Branch_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarToggleSwitchItem_Edit_Advanced_Mode = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.RibbonPageCategory_Accounting = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage_Accounting = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Accounting_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Books = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Sales = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Dashboards = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_Customers = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Management_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Customer_Management = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Customer_Sales = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_Spare_Parts = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Management = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Inventory = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage_Logistics = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_Logistics_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Logistic_Management = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Logistics_Inventory = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageCategory2 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage_Audit = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Audit_Parameters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Records = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Operations = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageCategory_HR = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage_HRM = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_HR_Management = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_User = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Support = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_SMS = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Account_Options = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_System = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup_Server_Options = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Application = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_Administration = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Asset_Management = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup_Personnel = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Accounting = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Database = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.repositoryItemPopupContainerEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemtoggle_Balance_Type = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.xtraTabbedMdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.ribbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.AdornerUIManager = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUp_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popup_Connection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popup_Connection.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popup_Account_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popup_Account_Search.SuspendLayout()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl.SuspendLayout()
        CType(Me.search_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItem_Host, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Release, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupControlContainer_Printing_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer_Printing_Detail.SuspendLayout()
        CType(Me.RepositoryItemPopupContainerEdit_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_Search.SuspendLayout()
        CType(Me.PopupContainerControl_SMS_Config, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Add_New, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Petty_Cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Purchase_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Receiving_Transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Assets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_Payment_Request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_System_Request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_MC_Request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemtoggle_Balance_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'ribbonControl
        '
        Me.ribbonControl.AutoSizeItems = True
        Me.ribbonControl.CaptionBarItemLinks.Add(Me.barEditItem_Branch)
        Me.ribbonControl.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("System", New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")), New DevExpress.XtraBars.BarManagerCategory("Application", New System.Guid("a38898a3-92f8-4b95-afda-22474c583a20")), New DevExpress.XtraBars.BarManagerCategory("User", New System.Guid("42c98492-2ea6-41e8-9182-4c403ed63178")), New DevExpress.XtraBars.BarManagerCategory("Accounting", New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")), New DevExpress.XtraBars.BarManagerCategory("Administration", New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")), New DevExpress.XtraBars.BarManagerCategory("Spare Parts", New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15"))})
        Me.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.imageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barEditItem_Branch, Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.BarEditItem_Corporation, Me.barSubItemNavigation, Me.employeesBarButtonItem, Me.customersBarButtonItem, Me.btn_Suppliers, Me.btn_Customers, Me.btn_Spare_Parts, Me.btn_Spare_Part_Sales, Me.btn_SPA_Inventory, Me.btn_Spare_Part_Costing, Me.btn_User_Change, Me.btn_User_Lock, Me.btn_Quit, Me.btn_Users, Me.btn_Server_Connection, Me.btn_Server_Ping, Me.btn_User_Login, Me.btn_Server_IP_Access, Me.Bar_User_Name, Me.Bar_User_Position, Me.Bar_IP_Server, Me.Bar_IP_Local, Me.btn_Server_Ping_Monitor, Me.btn_Agents, Me.btn_Info_Centers, Me.btn_Branches, Me.btn_Server_Refresh, Me.btn_Customer_Migration, Me.btn_Customer_Accounts, Me.btn_Initialize_Controls, Me.btn_Account_Executives, Me.BarToggleSwitchItem_Splash_Wait, Me.btn_Models, Me.btn_Update, Me.Bar_Unit_Version, Me.BarToggleSwitchItem_Continous, Me.barEdit_Host, Me.BarToggleSwitchItem_Host, Me.btn_Collections, Me.btn_Releases, Me.barEditItem_Date_Start, Me.barEditItem_Date_End, Me.btn_Monitoring_Payments, Me.btn_Trial_Balance, Me.btn_Receivables, Me.btn_Inventory, Me.btn_Chart_Of_Accounts, Me.btn_Journal_Entries, Me.BarToggleSwitchItem_Auto_Update, Me.btn_Password_Change, Me.btn_Account_Applications, Me.btn_Aging, Me.btn_Query, Me.btn_Report_Designer, Me.btn_Report_Designer_Ribbon, Me.barMdiChildrenListItem, Me.btn_Journal_Profiles, Me.btn_Month, Me.btn_Day, Me.btn_Today, Me.btn_Vouchers, Me.btn_Account_Names, Me.btn_Employees, Me.btn_Credit_Memo, Me.btn_Item_Colors, Me.btn_Printing_Detail, Me.BarToggleSwitchItem_Notification, Me.btn_Banks, Me.btn_Check_Numbers, Me.btn_Adjustments, Me.btn_Chat, Me.BarEditItem_Search, Me.btn_Repossesed, Me.btn_Brands, Me.btn_SMS_Configuration, Me.btn_SMS_Sender, Me.btn_Dashboard_Journal_Entries, Me.btn_Add_Items, Me.btn_New_Check, Me.btn_New_COA, Me.btn_New_Account_Name, Me.btn_New_Voucher, Me.btn_New_Journal_Entry, Me.btn_Backup, Me.btn_Budgets, Me.btn_Journal_Vouchers, Me.btn_Petty_Cash, Me.btn_Error_Report, Me.btn_Petty_Cash_Profiles, Me.btn_Ticket_New, Me.btn_Tickets, Me.btn_Ticket_Groups, Me.btn_Petty_Cash_New, Me.BarToggleSwitchItem_Check_Errors, Me.btn_New_Expense, Me.btn_Purchase_Orders, Me.BarToggleSwitchItem_Stack_Trace_Error, Me.btn_MC_Transactions, Me.btn_Inclusions, Me.btn_Inclusion_Inventory, Me.btn_Asset_Items, Me.SkinDropDownButtonItem, Me.SkinPaletteDropDownButonItem, Me.btn_Asset_New, Me.SkinRibbonGalleryBarItem, Me.SkinPaletteRibbonGalleryBarItem, Me.btn_Payment_Requests, Me.btn_Payment_Request, Me.btn_Promotion_Discounts, Me.btn_System_Requests, Me.btn_System_Request, Me.btn_Transmittals, Me.btn_Unit_Invoices, Me.btn_Salaries, Me.Annual_Leave, Me.btn_Leave_Absences, Me.btn_Attendance, Me.btn_Payroll, Me.btn_Pay_Checks, Me.btn_Helps, Me.btn_MC_Requests, Me.btn_Schedule_Types, Me.btn_Schedules, Me.btn_Date_Branch, Me.btn_Date_Cut_Off, Me.btn_Voucher_New, Me.btn_Branch_Reload, Me.btn_Wizard_New_MC_Request, Me.btn_Wizard_New_Purchase_Order, Me.btn_Wizard_New_MC_Transaction, Me.BarToggleSwitchItem_Edit_Advanced_Mode, Me.btn_MC_Sale_New})
        Me.ribbonControl.LargeImages = Me.imageCollection
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 101
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.OptionsCustomizationForm.FormIcon = CType(resources.GetObject("resource.FormIcon"), System.Drawing.Icon)
        Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory_Accounting, Me.RibbonPageCategory1, Me.RibbonPageCategory2, Me.RibbonPageCategory_HR})
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_Add_Items)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.BarEditItem_Search)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_User_Login)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_User_Change)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_User_Lock)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_Chat)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_Quit, True)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_User, Me.RibbonPage_System, Me.RibbonPage_Administration})
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.SkinDropDownButtonItem)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.SkinPaletteDropDownButonItem)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Server_Refresh)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Initialize_Controls)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Ticket_New)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Add_Items)
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookUp_Branch, Me.repositoryItem_Host, Me.repository_Date_Start, Me.repository_Date_End, Me.repositoryItemPopupContainerEdit, Me.RepositoryItemComboBox_Corporation, Me.RepositoryItemPopupContainerEdit_Search, Me.RepositoryItemtoggle_Balance_Type})
        Me.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.Size = New System.Drawing.Size(1177, 158)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'barEditItem_Branch
        '
        Me.barEditItem_Branch.Caption = "Branch "
        Me.barEditItem_Branch.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.barEditItem_Branch.Edit = Me.lookUp_Branch
        Me.barEditItem_Branch.EditWidth = 150
        Me.barEditItem_Branch.Id = 91
        Me.barEditItem_Branch.ImageOptions.Image = CType(resources.GetObject("barEditItem_Branch.ImageOptions.Image"), System.Drawing.Image)
        Me.barEditItem_Branch.ImageOptions.ImageIndex = 25
        Me.barEditItem_Branch.ImageOptions.LargeImage = CType(resources.GetObject("barEditItem_Branch.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barEditItem_Branch.ImageOptions.LargeImageIndex = 25
        Me.barEditItem_Branch.Name = "barEditItem_Branch"
        '
        'lookUp_Branch
        '
        Me.lookUp_Branch.AutoHeight = False
        Me.lookUp_Branch.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookUp_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUp_Branch.DisplayMember = "Branch"
        Me.lookUp_Branch.Name = "lookUp_Branch"
        Me.lookUp_Branch.NullText = ""
        Me.lookUp_Branch.ValueMember = "BranchCode"
        '
        'imageCollection
        '
        Me.imageCollection.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection.Images.SetKeyName(0, "bocontact_32x32.png")
        Me.imageCollection.Images.SetKeyName(1, "bodepartment_32x32.png")
        Me.imageCollection.Images.SetKeyName(2, "boproductgroup_32x32.png")
        Me.imageCollection.Images.SetKeyName(3, "boorderitem_32x32.png")
        Me.imageCollection.Images.SetKeyName(4, "bosale_32x32.png")
        Me.imageCollection.Images.SetKeyName(5, "bosaleitem_32x32.png")
        Me.imageCollection.Images.SetKeyName(6, "grandtotalspivottable_32x32.png")
        Me.imageCollection.Images.SetKeyName(7, "repeatallitemlabelspivottable_32x32.png")
        Me.imageCollection.Images.SetKeyName(8, "reportlayoutpivottable_32x32.png")
        Me.imageCollection.Images.SetKeyName(9, "bouser_32x32.png")
        Me.imageCollection.Images.SetKeyName(10, "convert_32x32.png")
        Me.imageCollection.Images.SetKeyName(11, "clear_32x32.png")
        Me.imageCollection.Images.SetKeyName(12, "close_32x32.png")
        Me.imageCollection.Images.SetKeyName(13, "bodetails_32x32.png")
        Me.imageCollection.Images.SetKeyName(14, "bopermission_32x32.png")
        Me.imageCollection.Images.SetKeyName(15, "country_32x32.png")
        Me.imageCollection.Images.SetKeyName(16, "hyperlink_32x32.png")
        Me.imageCollection.Images.SetKeyName(17, "assignto_32x32.png")
        Me.imageCollection.Images.SetKeyName(18, "assigntome_32x32.png")
        Me.imageCollection.Images.SetKeyName(19, "morefunctions_32x32.png")
        Me.imageCollection.Images.SetKeyName(20, "freezepanes_32x32.png")
        Me.imageCollection.Images.SetKeyName(21, "calculationoptions_32x32.png")
        Me.imageCollection.Images.SetKeyName(22, "radio_32x32.png")
        Me.imageCollection.Images.SetKeyName(23, "web_32x32.png")
        Me.imageCollection.Images.SetKeyName(24, "borole_32x32.png")
        Me.imageCollection.Images.SetKeyName(25, "treeview_32x32.png")
        Me.imageCollection.Images.SetKeyName(26, "autoexpand_32x32.png")
        Me.imageCollection.InsertGalleryImage("satellite_32x32.png", "images/miscellaneous/satellite_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/satellite_32x32.png"), 27)
        Me.imageCollection.Images.SetKeyName(27, "satellite_32x32.png")
        Me.imageCollection.Images.SetKeyName(28, "language_32x32.png")
        Me.imageCollection.InsertGalleryImage("groupbyresource_32x32.png", "images/scheduling/groupbyresource_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/groupbyresource_32x32.png"), 29)
        Me.imageCollection.Images.SetKeyName(29, "groupbyresource_32x32.png")
        Me.imageCollection.InsertGalleryImage("reviewallowuserstoeditranges_32x32.png", "images/spreadsheet/reviewallowuserstoeditranges_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/reviewallowuserstoeditranges_32x32.png"), 30)
        Me.imageCollection.Images.SetKeyName(30, "reviewallowuserstoeditranges_32x32.png")
        Me.imageCollection.InsertGalleryImage("initialstate_32x32.png", "images/dashboards/initialstate_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/dashboards/initialstate_32x32.png"), 31)
        Me.imageCollection.Images.SetKeyName(31, "initialstate_32x32.png")
        Me.imageCollection.Images.SetKeyName(32, "team_32x32.png")
        Me.imageCollection.InsertGalleryImage("costanalysis_32x32.png", "devav/actions/costanalysis_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/costanalysis_32x32.png"), 33)
        Me.imageCollection.Images.SetKeyName(33, "costanalysis_32x32.png")
        Me.imageCollection.InsertGalleryImage("textthatcontains_32x32.png", "images/conditional%20formatting/textthatcontains_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/textthatcontains_32x32.png"), 34)
        Me.imageCollection.Images.SetKeyName(34, "textthatcontains_32x32.png")
        Me.imageCollection.InsertGalleryImage("top_32x32.png", "images/conditional%20formatting/top_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/top_32x32.png"), 35)
        Me.imageCollection.Images.SetKeyName(35, "top_32x32.png")
        Me.imageCollection.Images.SetKeyName(36, "engineering_32x32.png")
        Me.imageCollection.InsertGalleryImage("bottom10%25_32x32.png", "images/conditional%20formatting/bottom10%25_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/bottom10%25_32x32.png"), 37)
        Me.imageCollection.Images.SetKeyName(37, "bottom10%25_32x32.png")
        Me.imageCollection.InsertGalleryImage("aboveaverage_32x32.png", "images/conditional%20formatting/aboveaverage_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/aboveaverage_32x32.png"), 38)
        Me.imageCollection.Images.SetKeyName(38, "aboveaverage_32x32.png")
        Me.imageCollection.InsertGalleryImage("salesperiodyear_32x32.png", "devav/sales/salesperiodyear_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/sales/salesperiodyear_32x32.png"), 39)
        Me.imageCollection.Images.SetKeyName(39, "salesperiodyear_32x32.png")
        Me.imageCollection.InsertGalleryImage("salesanalysis_32x32.png", "devav/sales/salesanalysis_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/sales/salesanalysis_32x32.png"), 40)
        Me.imageCollection.Images.SetKeyName(40, "salesanalysis_32x32.png")
        Me.imageCollection.InsertGalleryImage("statistical_32x32.png", "images/function%20library/statistical_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/statistical_32x32.png"), 41)
        Me.imageCollection.Images.SetKeyName(41, "statistical_32x32.png")
        Me.imageCollection.InsertGalleryImage("financial_32x32.png", "images/function%20library/financial_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/financial_32x32.png"), 42)
        Me.imageCollection.Images.SetKeyName(42, "financial_32x32.png")
        Me.imageCollection.InsertGalleryImage("highlightfield_32x32.png", "office2013/format/highlightfield_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/format/highlightfield_32x32.png"), 43)
        Me.imageCollection.Images.SetKeyName(43, "highlightfield_32x32.png")
        Me.imageCollection.Images.SetKeyName(44, "encrypt_32x32.png")
        Me.imageCollection.InsertGalleryImage("newtablestyle_32x32.png", "images/actions/newtablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_32x32.png"), 45)
        Me.imageCollection.Images.SetKeyName(45, "newtablestyle_32x32.png")
        Me.imageCollection.InsertGalleryImage("showworktimeonly_32x32.png", "images/scheduling/showworktimeonly_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/showworktimeonly_32x32.png"), 46)
        Me.imageCollection.Images.SetKeyName(46, "showworktimeonly_32x32.png")
        Me.imageCollection.InsertGalleryImage("kpi_32x32.png", "images/chart/kpi_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/kpi_32x32.png"), 47)
        Me.imageCollection.Images.SetKeyName(47, "kpi_32x32.png")
        Me.imageCollection.InsertGalleryImage("editdatasource_32x32.png", "images/data/editdatasource_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/editdatasource_32x32.png"), 48)
        Me.imageCollection.Images.SetKeyName(48, "editdatasource_32x32.png")
        Me.imageCollection.InsertGalleryImage("printarea_32x32.png", "images/print/printarea_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/printarea_32x32.png"), 49)
        Me.imageCollection.Images.SetKeyName(49, "printarea_32x32.png")
        Me.imageCollection.InsertGalleryImage("designreport_32x32.png", "images/reports/designreport_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/designreport_32x32.png"), 50)
        Me.imageCollection.Images.SetKeyName(50, "designreport_32x32.png")
        Me.imageCollection.Images.SetKeyName(51, "delete_hyperlink_32x32.png")
        Me.imageCollection.Images.SetKeyName(52, "carousel_32x32.png")
        Me.imageCollection.Images.SetKeyName(53, "newcomment_32x32.png")
        Me.imageCollection.InsertGalleryImage("bookmark_32x32.png", "images/content/bookmark_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/bookmark_32x32.png"), 54)
        Me.imageCollection.Images.SetKeyName(54, "bookmark_32x32.png")
        Me.imageCollection.InsertGalleryImage("dayview_16x16.png", "images/scheduling/dayview_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/dayview_16x16.png"), 55)
        Me.imageCollection.Images.SetKeyName(55, "dayview_16x16.png")
        Me.imageCollection.InsertGalleryImage("weekview_16x16.png", "images/scheduling/weekview_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/weekview_16x16.png"), 56)
        Me.imageCollection.Images.SetKeyName(56, "weekview_16x16.png")
        Me.imageCollection.InsertGalleryImage("monthview_16x16.png", "images/scheduling/monthview_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/monthview_16x16.png"), 57)
        Me.imageCollection.Images.SetKeyName(57, "monthview_16x16.png")
        Me.imageCollection.InsertGalleryImage("today_16x16.png", "images/scheduling/today_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/today_16x16.png"), 58)
        Me.imageCollection.Images.SetKeyName(58, "today_16x16.png")
        Me.imageCollection.InsertGalleryImage("cube_32x32.png", "images/function%20library/cube_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/cube_32x32.png"), 59)
        Me.imageCollection.Images.SetKeyName(59, "cube_32x32.png")
        Me.imageCollection.InsertGalleryImage("text_32x32.png", "images/function%20library/text_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/text_32x32.png"), 60)
        Me.imageCollection.Images.SetKeyName(60, "text_32x32.png")
        Me.imageCollection.InsertGalleryImage("usergroup_32x32.png", "images/people/usergroup_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/usergroup_32x32.png"), 61)
        Me.imageCollection.Images.SetKeyName(61, "usergroup_32x32.png")
        Me.imageCollection.InsertGalleryImage("editrangepermission_32x32.png", "images/richedit/editrangepermission_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/richedit/editrangepermission_32x32.png"), 62)
        Me.imageCollection.Images.SetKeyName(62, "editrangepermission_32x32.png")
        Me.imageCollection.InsertGalleryImage("colorlegend_32x32.png", "images/chart/colorlegend_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/colorlegend_32x32.png"), 63)
        Me.imageCollection.Images.SetKeyName(63, "colorlegend_32x32.png")
        Me.imageCollection.InsertGalleryImage("web_32x32.png", "images/function%20library/web_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/web_32x32.png"), 64)
        Me.imageCollection.Images.SetKeyName(64, "web_32x32.png")
        Me.imageCollection.Images.SetKeyName(65, "printlayoutview_32x32.png")
        '
        'BarEditItem_Corporation
        '
        Me.BarEditItem_Corporation.Caption = "Corporation"
        Me.BarEditItem_Corporation.Edit = Me.RepositoryItemComboBox_Corporation
        Me.BarEditItem_Corporation.EditWidth = 60
        Me.BarEditItem_Corporation.Id = 19
        Me.BarEditItem_Corporation.ImageOptions.ImageIndex = 64
        Me.BarEditItem_Corporation.ImageOptions.LargeImageIndex = 64
        Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
        '
        'RepositoryItemComboBox_Corporation
        '
        Me.RepositoryItemComboBox_Corporation.AutoHeight = False
        Me.RepositoryItemComboBox_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_Corporation.Items.AddRange(New Object() {"SFC", "SMC"})
        Me.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation"
        Me.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'barSubItemNavigation
        '
        Me.barSubItemNavigation.Id = 81
        Me.barSubItemNavigation.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Server_Refresh), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize_Controls, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_User_Change, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_User_Lock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Quit)})
        Me.barSubItemNavigation.Name = "barSubItemNavigation"
        '
        'btn_Server_Refresh
        '
        Me.btn_Server_Refresh.Caption = "Refresh Connection"
        Me.btn_Server_Refresh.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Server_Refresh.Id = 85
        Me.btn_Server_Refresh.ImageOptions.ImageIndex = 27
        Me.btn_Server_Refresh.ImageOptions.LargeImageIndex = 27
        Me.btn_Server_Refresh.Name = "btn_Server_Refresh"
        '
        'btn_Initialize_Controls
        '
        Me.btn_Initialize_Controls.Caption = "Initialize"
        Me.btn_Initialize_Controls.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Initialize_Controls.Id = 90
        Me.btn_Initialize_Controls.ImageOptions.ImageIndex = 31
        Me.btn_Initialize_Controls.ImageOptions.LargeImageIndex = 31
        Me.btn_Initialize_Controls.Name = "btn_Initialize_Controls"
        '
        'btn_User_Change
        '
        Me.btn_User_Change.Caption = "Switch Account"
        Me.btn_User_Change.CategoryGuid = New System.Guid("42c98492-2ea6-41e8-9182-4c403ed63178")
        Me.btn_User_Change.Id = 57
        Me.btn_User_Change.ImageOptions.Image = CType(resources.GetObject("btn_User_Change.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_User_Change.ImageOptions.ImageIndex = 18
        Me.btn_User_Change.ImageOptions.LargeImage = CType(resources.GetObject("btn_User_Change.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_User_Change.ImageOptions.LargeImageIndex = 18
        Me.btn_User_Change.Name = "btn_User_Change"
        '
        'btn_User_Lock
        '
        Me.btn_User_Lock.Caption = "Lock"
        Me.btn_User_Lock.CategoryGuid = New System.Guid("42c98492-2ea6-41e8-9182-4c403ed63178")
        Me.btn_User_Lock.Id = 58
        Me.btn_User_Lock.ImageOptions.Image = CType(resources.GetObject("btn_User_Lock.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_User_Lock.ImageOptions.ImageIndex = 14
        Me.btn_User_Lock.ImageOptions.LargeImage = CType(resources.GetObject("btn_User_Lock.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_User_Lock.ImageOptions.LargeImageIndex = 14
        Me.btn_User_Lock.Name = "btn_User_Lock"
        '
        'btn_Quit
        '
        Me.btn_Quit.Caption = "Quit"
        Me.btn_Quit.CategoryGuid = New System.Guid("42c98492-2ea6-41e8-9182-4c403ed63178")
        Me.btn_Quit.Id = 59
        Me.btn_Quit.ImageOptions.Image = CType(resources.GetObject("btn_Quit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Quit.ImageOptions.ImageIndex = 12
        Me.btn_Quit.ImageOptions.LargeImage = CType(resources.GetObject("btn_Quit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Quit.ImageOptions.LargeImageIndex = 12
        Me.btn_Quit.Name = "btn_Quit"
        '
        'employeesBarButtonItem
        '
        Me.employeesBarButtonItem.Id = 82
        Me.employeesBarButtonItem.Name = "employeesBarButtonItem"
        '
        'customersBarButtonItem
        '
        Me.customersBarButtonItem.Id = 83
        Me.customersBarButtonItem.Name = "customersBarButtonItem"
        '
        'btn_Suppliers
        '
        Me.btn_Suppliers.Caption = "Suppliers"
        Me.btn_Suppliers.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_Suppliers.Id = 48
        Me.btn_Suppliers.ImageOptions.ImageIndex = 0
        Me.btn_Suppliers.ImageOptions.LargeImageIndex = 0
        Me.btn_Suppliers.Name = "btn_Suppliers"
        '
        'btn_Customers
        '
        Me.btn_Customers.Caption = "Customers"
        Me.btn_Customers.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_Customers.Id = 49
        Me.btn_Customers.ImageOptions.ImageIndex = 61
        Me.btn_Customers.ImageOptions.LargeImageIndex = 61
        Me.btn_Customers.Name = "btn_Customers"
        '
        'btn_Spare_Parts
        '
        Me.btn_Spare_Parts.Caption = "Spare Parts"
        Me.btn_Spare_Parts.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_Spare_Parts.Id = 50
        Me.btn_Spare_Parts.ImageOptions.ImageIndex = 2
        Me.btn_Spare_Parts.ImageOptions.LargeImageIndex = 2
        Me.btn_Spare_Parts.Name = "btn_Spare_Parts"
        '
        'btn_Spare_Part_Sales
        '
        Me.btn_Spare_Part_Sales.Caption = "Sales"
        Me.btn_Spare_Part_Sales.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_Spare_Part_Sales.Id = 51
        Me.btn_Spare_Part_Sales.ImageOptions.ImageIndex = 5
        Me.btn_Spare_Part_Sales.ImageOptions.LargeImageIndex = 5
        Me.btn_Spare_Part_Sales.Name = "btn_Spare_Part_Sales"
        '
        'btn_SPA_Inventory
        '
        Me.btn_SPA_Inventory.Caption = "Inventory"
        Me.btn_SPA_Inventory.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_SPA_Inventory.Id = 52
        Me.btn_SPA_Inventory.ImageOptions.ImageIndex = 3
        Me.btn_SPA_Inventory.ImageOptions.LargeImageIndex = 3
        Me.btn_SPA_Inventory.Name = "btn_SPA_Inventory"
        '
        'btn_Spare_Part_Costing
        '
        Me.btn_Spare_Part_Costing.Caption = "Costing"
        Me.btn_Spare_Part_Costing.CategoryGuid = New System.Guid("bfd326ca-f49a-49f7-ad15-e96ee8da1d15")
        Me.btn_Spare_Part_Costing.Id = 53
        Me.btn_Spare_Part_Costing.ImageOptions.ImageIndex = 4
        Me.btn_Spare_Part_Costing.ImageOptions.LargeImageIndex = 4
        Me.btn_Spare_Part_Costing.Name = "btn_Spare_Part_Costing"
        '
        'btn_Users
        '
        Me.btn_Users.Caption = "Users"
        Me.btn_Users.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Users.Id = 61
        Me.btn_Users.ImageOptions.ImageIndex = 9
        Me.btn_Users.ImageOptions.LargeImageIndex = 9
        Me.btn_Users.Name = "btn_Users"
        '
        'btn_Server_Connection
        '
        Me.btn_Server_Connection.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Server_Connection.Caption = "Server Connection"
        Me.btn_Server_Connection.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Server_Connection.DropDownControl = Me.popup_Connection
        Me.btn_Server_Connection.Id = 65
        Me.btn_Server_Connection.ImageOptions.ImageIndex = 16
        Me.btn_Server_Connection.ImageOptions.LargeImageIndex = 16
        Me.btn_Server_Connection.Name = "btn_Server_Connection"
        '
        'popup_Connection
        '
        Me.popup_Connection.AutoSize = True
        Me.popup_Connection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popup_Connection.Controls.Add(Me.LayoutControl3)
        Me.popup_Connection.Location = New System.Drawing.Point(12, 168)
        Me.popup_Connection.Name = "popup_Connection"
        Me.popup_Connection.Ribbon = Me.ribbonControl
        Me.popup_Connection.ShowCloseButton = True
        Me.popup_Connection.ShowSizeGrip = True
        Me.popup_Connection.Size = New System.Drawing.Size(400, 450)
        Me.popup_Connection.TabIndex = 6
        Me.popup_Connection.Visible = False
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.btn_Connection_Connect)
        Me.LayoutControl3.Controls.Add(Me.btn_Connection_Test)
        Me.LayoutControl3.Controls.Add(Me.xuc_SQL_Connection)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(374, 283, 650, 400)
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(400, 450)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'btn_Connection_Connect
        '
        Me.btn_Connection_Connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Connection_Connect.ImageOptions.Image = CType(resources.GetObject("btn_Connection_Connect.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Connection_Connect.Location = New System.Drawing.Point(300, 416)
        Me.btn_Connection_Connect.Name = "btn_Connection_Connect"
        Me.btn_Connection_Connect.Size = New System.Drawing.Size(88, 22)
        Me.btn_Connection_Connect.StyleController = Me.LayoutControl3
        Me.btn_Connection_Connect.TabIndex = 1
        Me.btn_Connection_Connect.Text = "Co&nnect"
        '
        'btn_Connection_Test
        '
        Me.btn_Connection_Test.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Connection_Test.ImageOptions.Image = CType(resources.GetObject("btn_Connection_Test.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Connection_Test.Location = New System.Drawing.Point(166, 416)
        Me.btn_Connection_Test.Name = "btn_Connection_Test"
        Me.btn_Connection_Test.Size = New System.Drawing.Size(130, 22)
        Me.btn_Connection_Test.StyleController = Me.LayoutControl3
        Me.btn_Connection_Test.TabIndex = 0
        Me.btn_Connection_Test.Text = "&Test"
        '
        'xuc_SQL_Connection
        '
        Me.xuc_SQL_Connection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xuc_SQL_Connection.Location = New System.Drawing.Point(12, 12)
        Me.xuc_SQL_Connection.Name = "xuc_SQL_Connection"
        Me.xuc_SQL_Connection.Size = New System.Drawing.Size(376, 400)
        Me.xuc_SQL_Connection.TabIndex = 0
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem7})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(400, 450)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.xuc_SQL_Connection
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(380, 404)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btn_Connection_Test
        Me.LayoutControlItem6.Location = New System.Drawing.Point(154, 404)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 404)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(154, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btn_Connection_Connect
        Me.LayoutControlItem7.Location = New System.Drawing.Point(288, 404)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'btn_Server_Ping
        '
        Me.btn_Server_Ping.Caption = "Server Ping"
        Me.btn_Server_Ping.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Server_Ping.Id = 66
        Me.btn_Server_Ping.ImageOptions.ImageIndex = 15
        Me.btn_Server_Ping.ImageOptions.LargeImageIndex = 15
        Me.btn_Server_Ping.Name = "btn_Server_Ping"
        '
        'btn_User_Login
        '
        Me.btn_User_Login.Caption = "Login"
        Me.btn_User_Login.CategoryGuid = New System.Guid("42c98492-2ea6-41e8-9182-4c403ed63178")
        Me.btn_User_Login.Id = 67
        Me.btn_User_Login.ImageOptions.Image = CType(resources.GetObject("btn_User_Login.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_User_Login.ImageOptions.ImageIndex = 17
        Me.btn_User_Login.ImageOptions.LargeImage = CType(resources.GetObject("btn_User_Login.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_User_Login.ImageOptions.LargeImageIndex = 17
        Me.btn_User_Login.Name = "btn_User_Login"
        '
        'btn_Server_IP_Access
        '
        Me.btn_Server_IP_Access.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Server_IP_Access.Caption = "IP Access"
        Me.btn_Server_IP_Access.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Server_IP_Access.Id = 68
        Me.btn_Server_IP_Access.ImageOptions.ImageIndex = 28
        Me.btn_Server_IP_Access.ImageOptions.LargeImageIndex = 28
        Me.btn_Server_IP_Access.Name = "btn_Server_IP_Access"
        '
        'Bar_User_Name
        '
        Me.Bar_User_Name.Caption = "User"
        Me.Bar_User_Name.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.Bar_User_Name.Id = 71
        Me.Bar_User_Name.Name = "Bar_User_Name"
        '
        'Bar_User_Position
        '
        Me.Bar_User_Position.Caption = "Position"
        Me.Bar_User_Position.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.Bar_User_Position.Id = 72
        Me.Bar_User_Position.Name = "Bar_User_Position"
        '
        'Bar_IP_Server
        '
        Me.Bar_IP_Server.Caption = "Server IP Address"
        Me.Bar_IP_Server.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.Bar_IP_Server.Id = 73
        Me.Bar_IP_Server.ItemAppearance.Hovered.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bar_IP_Server.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.Bar_IP_Server.Name = "Bar_IP_Server"
        '
        'Bar_IP_Local
        '
        Me.Bar_IP_Local.Caption = "Local IP Address"
        Me.Bar_IP_Local.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.Bar_IP_Local.Id = 74
        Me.Bar_IP_Local.ItemAppearance.Hovered.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bar_IP_Local.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.Bar_IP_Local.Name = "Bar_IP_Local"
        '
        'btn_Server_Ping_Monitor
        '
        Me.btn_Server_Ping_Monitor.Caption = "Ping"
        Me.btn_Server_Ping_Monitor.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Server_Ping_Monitor.Id = 75
        Me.btn_Server_Ping_Monitor.ImageOptions.ImageIndex = 22
        Me.btn_Server_Ping_Monitor.ImageOptions.LargeImageIndex = 22
        Me.btn_Server_Ping_Monitor.Name = "btn_Server_Ping_Monitor"
        '
        'btn_Agents
        '
        Me.btn_Agents.Caption = "Agents"
        Me.btn_Agents.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Agents.Id = 78
        Me.btn_Agents.ImageOptions.ImageIndex = 24
        Me.btn_Agents.ImageOptions.LargeImageIndex = 24
        Me.btn_Agents.Name = "btn_Agents"
        '
        'btn_Info_Centers
        '
        Me.btn_Info_Centers.Caption = "Info Centers"
        Me.btn_Info_Centers.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Info_Centers.Id = 79
        Me.btn_Info_Centers.ImageOptions.ImageIndex = 26
        Me.btn_Info_Centers.ImageOptions.LargeImageIndex = 26
        Me.btn_Info_Centers.Name = "btn_Info_Centers"
        '
        'btn_Branches
        '
        Me.btn_Branches.Caption = "Branches"
        Me.btn_Branches.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Branches.Id = 80
        Me.btn_Branches.ImageOptions.ImageIndex = 25
        Me.btn_Branches.ImageOptions.LargeImageIndex = 25
        Me.btn_Branches.Name = "btn_Branches"
        '
        'btn_Customer_Migration
        '
        Me.btn_Customer_Migration.Caption = "Migration"
        Me.btn_Customer_Migration.Id = 87
        Me.btn_Customer_Migration.ImageOptions.ImageIndex = 29
        Me.btn_Customer_Migration.ImageOptions.LargeImageIndex = 29
        Me.btn_Customer_Migration.Name = "btn_Customer_Migration"
        '
        'btn_Customer_Accounts
        '
        Me.btn_Customer_Accounts.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Customer_Accounts.Caption = "Accounts"
        Me.btn_Customer_Accounts.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Customer_Accounts.DropDownControl = Me.popup_Account_Search
        Me.btn_Customer_Accounts.Id = 89
        Me.btn_Customer_Accounts.ImageOptions.Image = CType(resources.GetObject("btn_Customer_Accounts.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Customer_Accounts.ImageOptions.ImageIndex = 30
        Me.btn_Customer_Accounts.ImageOptions.LargeImage = CType(resources.GetObject("btn_Customer_Accounts.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Customer_Accounts.ImageOptions.LargeImageIndex = 30
        Me.btn_Customer_Accounts.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                Or System.Windows.Forms.Keys.A))
        Me.btn_Customer_Accounts.Name = "btn_Customer_Accounts"
        '
        'popup_Account_Search
        '
        Me.popup_Account_Search.AutoSize = True
        Me.popup_Account_Search.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popup_Account_Search.Controls.Add(Me.layoutControl)
        Me.popup_Account_Search.Location = New System.Drawing.Point(418, 168)
        Me.popup_Account_Search.Name = "popup_Account_Search"
        Me.popup_Account_Search.Ribbon = Me.ribbonControl
        Me.popup_Account_Search.ShowSizeGrip = True
        Me.popup_Account_Search.Size = New System.Drawing.Size(295, 162)
        Me.popup_Account_Search.TabIndex = 12
        Me.popup_Account_Search.Visible = False
        '
        'layoutControl
        '
        Me.layoutControl.Controls.Add(Me.xuc_Accounts)
        Me.layoutControl.Controls.Add(Me.search_Name)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.Root = Me.Root
        Me.layoutControl.Size = New System.Drawing.Size(295, 162)
        Me.layoutControl.TabIndex = 0
        Me.layoutControl.Text = "LayoutControl1"
        '
        'xuc_Accounts
        '
        Me.xuc_Accounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xuc_Accounts.Location = New System.Drawing.Point(12, 36)
        Me.xuc_Accounts.Name = "xuc_Accounts"
        Me.xuc_Accounts.Size = New System.Drawing.Size(271, 114)
        Me.xuc_Accounts.TabIndex = 4
        '
        'search_Name
        '
        Me.search_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_Name.EditValue = ""
        Me.search_Name.Location = New System.Drawing.Point(57, 12)
        Me.search_Name.Name = "search_Name"
        Me.search_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.search_Name.Size = New System.Drawing.Size(226, 20)
        Me.search_Name.StyleController = Me.layoutControl
        Me.search_Name.TabIndex = 3
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(295, 162)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.search_Name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem1.Text = "Search"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(33, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.xuc_Accounts
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(275, 118)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'btn_Account_Executives
        '
        Me.btn_Account_Executives.Caption = "Account Executives"
        Me.btn_Account_Executives.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Account_Executives.Id = 93
        Me.btn_Account_Executives.ImageOptions.ImageIndex = 32
        Me.btn_Account_Executives.ImageOptions.LargeImageIndex = 32
        Me.btn_Account_Executives.Name = "btn_Account_Executives"
        '
        'BarToggleSwitchItem_Splash_Wait
        '
        Me.BarToggleSwitchItem_Splash_Wait.Caption = "Splash and Wait"
        Me.BarToggleSwitchItem_Splash_Wait.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.BarToggleSwitchItem_Splash_Wait.Id = 99
        Me.BarToggleSwitchItem_Splash_Wait.Name = "BarToggleSwitchItem_Splash_Wait"
        '
        'btn_Models
        '
        Me.btn_Models.Caption = "Models"
        Me.btn_Models.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Models.Id = 103
        Me.btn_Models.ImageOptions.Image = CType(resources.GetObject("btn_Models.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Models.ImageOptions.ImageIndex = 33
        Me.btn_Models.ImageOptions.LargeImage = CType(resources.GetObject("btn_Models.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Models.ImageOptions.LargeImageIndex = 33
        Me.btn_Models.Name = "btn_Models"
        '
        'btn_Update
        '
        Me.btn_Update.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btn_Update.Caption = "Check Update"
        Me.btn_Update.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.btn_Update.Id = 104
        Me.btn_Update.ItemAppearance.Hovered.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Update.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.btn_Update.Name = "btn_Update"
        '
        'Bar_Unit_Version
        '
        Me.Bar_Unit_Version.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.Bar_Unit_Version.Caption = "Product Version"
        Me.Bar_Unit_Version.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.Bar_Unit_Version.Id = 105
        Me.Bar_Unit_Version.Name = "Bar_Unit_Version"
        '
        'BarToggleSwitchItem_Continous
        '
        Me.BarToggleSwitchItem_Continous.Caption = "Continous"
        Me.BarToggleSwitchItem_Continous.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.BarToggleSwitchItem_Continous.Id = 1
        Me.BarToggleSwitchItem_Continous.Name = "BarToggleSwitchItem_Continous"
        '
        'barEdit_Host
        '
        Me.barEdit_Host.Caption = "Host"
        Me.barEdit_Host.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.barEdit_Host.Edit = Me.repositoryItem_Host
        Me.barEdit_Host.EditValue = "1.1.1.1"
        Me.barEdit_Host.Id = 2
        Me.barEdit_Host.Name = "barEdit_Host"
        '
        'repositoryItem_Host
        '
        Me.repositoryItem_Host.AutoHeight = False
        Me.repositoryItem_Host.Name = "repositoryItem_Host"
        '
        'BarToggleSwitchItem_Host
        '
        Me.BarToggleSwitchItem_Host.Caption = "Ping Host"
        Me.BarToggleSwitchItem_Host.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.BarToggleSwitchItem_Host.Id = 3
        Me.BarToggleSwitchItem_Host.Name = "BarToggleSwitchItem_Host"
        '
        'btn_Collections
        '
        Me.btn_Collections.Caption = "Collections"
        Me.btn_Collections.CategoryGuid = New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")
        Me.btn_Collections.Id = 4
        Me.btn_Collections.ImageOptions.Image = CType(resources.GetObject("btn_Collections.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Collections.ImageOptions.LargeImage = CType(resources.GetObject("btn_Collections.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Collections.Name = "btn_Collections"
        '
        'btn_Releases
        '
        Me.btn_Releases.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Releases.Caption = "Releases"
        Me.btn_Releases.CategoryGuid = New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")
        Me.btn_Releases.DropDownControl = Me.PopupMenu_Release
        Me.btn_Releases.Id = 5
        Me.btn_Releases.ImageOptions.Image = CType(resources.GetObject("btn_Releases.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Releases.ImageOptions.ImageIndex = 34
        Me.btn_Releases.ImageOptions.LargeImage = CType(resources.GetObject("btn_Releases.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Releases.ImageOptions.LargeImageIndex = 34
        Me.btn_Releases.Name = "btn_Releases"
        '
        'PopupMenu_Release
        '
        Me.PopupMenu_Release.ItemLinks.Add(Me.btn_MC_Sale_New)
        Me.PopupMenu_Release.Name = "PopupMenu_Release"
        Me.PopupMenu_Release.Ribbon = Me.ribbonControl
        '
        'btn_MC_Sale_New
        '
        Me.btn_MC_Sale_New.Caption = "New MC Sale"
        Me.btn_MC_Sale_New.Id = 100
        Me.btn_MC_Sale_New.ImageOptions.Image = CType(resources.GetObject("btn_MC_Sale_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_MC_Sale_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Sale_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_MC_Sale_New.Name = "btn_MC_Sale_New"
        '
        'barEditItem_Date_Start
        '
        Me.barEditItem_Date_Start.Caption = "Date Start"
        Me.barEditItem_Date_Start.CategoryGuid = New System.Guid("a38898a3-92f8-4b95-afda-22474c583a20")
        Me.barEditItem_Date_Start.Edit = Me.repository_Date_Start
        Me.barEditItem_Date_Start.EditWidth = 120
        Me.barEditItem_Date_Start.Id = 6
        Me.barEditItem_Date_Start.ImageOptions.Image = CType(resources.GetObject("barEditItem_Date_Start.ImageOptions.Image"), System.Drawing.Image)
        Me.barEditItem_Date_Start.ImageOptions.ImageIndex = 58
        Me.barEditItem_Date_Start.ImageOptions.LargeImage = CType(resources.GetObject("barEditItem_Date_Start.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barEditItem_Date_Start.ImageOptions.LargeImageIndex = 58
        Me.barEditItem_Date_Start.Name = "barEditItem_Date_Start"
        '
        'repository_Date_Start
        '
        Me.repository_Date_Start.Appearance.Options.UseTextOptions = True
        Me.repository_Date_Start.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.repository_Date_Start.AutoHeight = False
        Me.repository_Date_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_Start.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.repository_Date_Start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repository_Date_Start.EditFormat.FormatString = "MMM dd, yyyy"
        Me.repository_Date_Start.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repository_Date_Start.Mask.EditMask = "MMM dd, yyyy"
        Me.repository_Date_Start.Mask.UseMaskAsDisplayFormat = True
        Me.repository_Date_Start.Name = "repository_Date_Start"
        '
        'barEditItem_Date_End
        '
        Me.barEditItem_Date_End.Caption = "Date End"
        Me.barEditItem_Date_End.CategoryGuid = New System.Guid("a38898a3-92f8-4b95-afda-22474c583a20")
        Me.barEditItem_Date_End.Edit = Me.repository_Date_End
        Me.barEditItem_Date_End.EditWidth = 120
        Me.barEditItem_Date_End.Id = 7
        Me.barEditItem_Date_End.ImageOptions.Image = CType(resources.GetObject("barEditItem_Date_End.ImageOptions.Image"), System.Drawing.Image)
        Me.barEditItem_Date_End.ImageOptions.ImageIndex = 58
        Me.barEditItem_Date_End.ImageOptions.LargeImage = CType(resources.GetObject("barEditItem_Date_End.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barEditItem_Date_End.ImageOptions.LargeImageIndex = 58
        Me.barEditItem_Date_End.Name = "barEditItem_Date_End"
        '
        'repository_Date_End
        '
        Me.repository_Date_End.Appearance.Options.UseTextOptions = True
        Me.repository_Date_End.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.repository_Date_End.AutoHeight = False
        Me.repository_Date_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_End.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.repository_Date_End.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repository_Date_End.EditFormat.FormatString = "MMM dd, yyyy"
        Me.repository_Date_End.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repository_Date_End.Mask.EditMask = "MMM dd, yyyy"
        Me.repository_Date_End.Mask.UseMaskAsDisplayFormat = True
        Me.repository_Date_End.Name = "repository_Date_End"
        '
        'btn_Monitoring_Payments
        '
        Me.btn_Monitoring_Payments.Caption = "Payments"
        Me.btn_Monitoring_Payments.CategoryGuid = New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")
        Me.btn_Monitoring_Payments.Id = 8
        Me.btn_Monitoring_Payments.ImageOptions.ImageIndex = 33
        Me.btn_Monitoring_Payments.ImageOptions.LargeImageIndex = 33
        Me.btn_Monitoring_Payments.Name = "btn_Monitoring_Payments"
        '
        'btn_Trial_Balance
        '
        Me.btn_Trial_Balance.Caption = "Trial Balance"
        Me.btn_Trial_Balance.CategoryGuid = New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")
        Me.btn_Trial_Balance.Id = 11
        Me.btn_Trial_Balance.ImageOptions.ImageIndex = 41
        Me.btn_Trial_Balance.ImageOptions.LargeImageIndex = 41
        Me.btn_Trial_Balance.Name = "btn_Trial_Balance"
        '
        'btn_Receivables
        '
        Me.btn_Receivables.Caption = "Receivables"
        Me.btn_Receivables.CategoryGuid = New System.Guid("133427a2-36a2-425b-b231-8b8de398fbfb")
        Me.btn_Receivables.Id = 12
        Me.btn_Receivables.ImageOptions.ImageIndex = 37
        Me.btn_Receivables.ImageOptions.LargeImageIndex = 37
        Me.btn_Receivables.Name = "btn_Receivables"
        '
        'btn_Inventory
        '
        Me.btn_Inventory.Caption = "MC Units/Items Inventory"
        Me.btn_Inventory.CategoryGuid = New System.Guid("1fce2cd1-0b8d-4317-a72b-dc5689748bf2")
        Me.btn_Inventory.Id = 15
        Me.btn_Inventory.ImageOptions.Image = CType(resources.GetObject("btn_Inventory.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Inventory.ImageOptions.ImageIndex = 40
        Me.btn_Inventory.ImageOptions.LargeImage = CType(resources.GetObject("btn_Inventory.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Inventory.ImageOptions.LargeImageIndex = 40
        Me.btn_Inventory.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                Or System.Windows.Forms.Keys.I))
        Me.btn_Inventory.Name = "btn_Inventory"
        '
        'btn_Chart_Of_Accounts
        '
        Me.btn_Chart_Of_Accounts.Caption = "Chart of Accounts"
        Me.btn_Chart_Of_Accounts.Id = 1
        Me.btn_Chart_Of_Accounts.ImageOptions.ImageIndex = 36
        Me.btn_Chart_Of_Accounts.ImageOptions.LargeImageIndex = 36
        Me.btn_Chart_Of_Accounts.Name = "btn_Chart_Of_Accounts"
        '
        'btn_Journal_Entries
        '
        Me.btn_Journal_Entries.Caption = "Journal Entries"
        Me.btn_Journal_Entries.Id = 2
        Me.btn_Journal_Entries.ImageOptions.Image = CType(resources.GetObject("btn_Journal_Entries.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Journal_Entries.ImageOptions.ImageIndex = 42
        Me.btn_Journal_Entries.ImageOptions.LargeImage = CType(resources.GetObject("btn_Journal_Entries.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 42
        Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
        '
        'BarToggleSwitchItem_Auto_Update
        '
        Me.BarToggleSwitchItem_Auto_Update.Caption = "Auto Update"
        Me.BarToggleSwitchItem_Auto_Update.Id = 4
        Me.BarToggleSwitchItem_Auto_Update.Name = "BarToggleSwitchItem_Auto_Update"
        '
        'btn_Password_Change
        '
        Me.btn_Password_Change.Caption = "Change Password"
        Me.btn_Password_Change.Id = 8
        Me.btn_Password_Change.ImageOptions.ImageIndex = 43
        Me.btn_Password_Change.ImageOptions.LargeImageIndex = 43
        Me.btn_Password_Change.Name = "btn_Password_Change"
        '
        'btn_Account_Applications
        '
        Me.btn_Account_Applications.Caption = "Approval"
        Me.btn_Account_Applications.Id = 13
        Me.btn_Account_Applications.ImageOptions.ImageIndex = 13
        Me.btn_Account_Applications.ImageOptions.LargeImageIndex = 13
        Me.btn_Account_Applications.Name = "btn_Account_Applications"
        '
        'btn_Aging
        '
        Me.btn_Aging.Caption = "Aging"
        Me.btn_Aging.Id = 20
        Me.btn_Aging.ImageOptions.ImageIndex = 46
        Me.btn_Aging.ImageOptions.LargeImageIndex = 46
        Me.btn_Aging.Name = "btn_Aging"
        '
        'btn_Query
        '
        Me.btn_Query.Caption = "Custom Query"
        Me.btn_Query.Id = 22
        Me.btn_Query.ImageOptions.ImageIndex = 48
        Me.btn_Query.ImageOptions.LargeImageIndex = 48
        Me.btn_Query.Name = "btn_Query"
        '
        'btn_Report_Designer
        '
        Me.btn_Report_Designer.Caption = "Report Designer 1"
        Me.btn_Report_Designer.Id = 1
        Me.btn_Report_Designer.ImageOptions.ImageIndex = 49
        Me.btn_Report_Designer.ImageOptions.LargeImageIndex = 49
        Me.btn_Report_Designer.Name = "btn_Report_Designer"
        '
        'btn_Report_Designer_Ribbon
        '
        Me.btn_Report_Designer_Ribbon.Caption = "Report Designer 2"
        Me.btn_Report_Designer_Ribbon.Id = 2
        Me.btn_Report_Designer_Ribbon.ImageOptions.ImageIndex = 50
        Me.btn_Report_Designer_Ribbon.ImageOptions.LargeImageIndex = 50
        Me.btn_Report_Designer_Ribbon.Name = "btn_Report_Designer_Ribbon"
        '
        'barMdiChildrenListItem
        '
        Me.barMdiChildrenListItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barMdiChildrenListItem.Caption = "Recent Forms"
        Me.barMdiChildrenListItem.Id = 4
        Me.barMdiChildrenListItem.ImageOptions.ImageIndex = 52
        Me.barMdiChildrenListItem.ImageOptions.LargeImageIndex = 52
        Me.barMdiChildrenListItem.Name = "barMdiChildrenListItem"
        '
        'btn_Journal_Profiles
        '
        Me.btn_Journal_Profiles.Caption = "Journal Profiles"
        Me.btn_Journal_Profiles.Id = 7
        Me.btn_Journal_Profiles.ImageOptions.ImageIndex = 54
        Me.btn_Journal_Profiles.ImageOptions.LargeImageIndex = 54
        Me.btn_Journal_Profiles.Name = "btn_Journal_Profiles"
        '
        'btn_Month
        '
        Me.btn_Month.Caption = "Month"
        Me.btn_Month.Id = 8
        Me.btn_Month.ImageOptions.Image = CType(resources.GetObject("btn_Month.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Month.ImageOptions.ImageIndex = 57
        Me.btn_Month.ImageOptions.LargeImage = CType(resources.GetObject("btn_Month.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Month.ImageOptions.LargeImageIndex = 57
        Me.btn_Month.Name = "btn_Month"
        Me.btn_Month.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Day
        '
        Me.btn_Day.Caption = "Day"
        Me.btn_Day.Id = 10
        Me.btn_Day.ImageOptions.Image = CType(resources.GetObject("btn_Day.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Day.ImageOptions.ImageIndex = 55
        Me.btn_Day.ImageOptions.LargeImage = CType(resources.GetObject("btn_Day.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Day.ImageOptions.LargeImageIndex = 55
        Me.btn_Day.Name = "btn_Day"
        Me.btn_Day.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Today
        '
        Me.btn_Today.Caption = "Today"
        Me.btn_Today.Id = 11
        Me.btn_Today.ImageOptions.Image = CType(resources.GetObject("btn_Today.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Today.ImageOptions.ImageIndex = 58
        Me.btn_Today.ImageOptions.LargeImage = CType(resources.GetObject("btn_Today.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Today.ImageOptions.LargeImageIndex = 58
        Me.btn_Today.Name = "btn_Today"
        Me.btn_Today.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Vouchers
        '
        Me.btn_Vouchers.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Vouchers.Caption = "Cash/Check Vouchers"
        Me.btn_Vouchers.DropDownControl = Me.PopupMenu_Voucher
        Me.btn_Vouchers.Id = 12
        Me.btn_Vouchers.ImageOptions.Image = CType(resources.GetObject("btn_Vouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Vouchers.ImageOptions.ImageIndex = 59
        Me.btn_Vouchers.ImageOptions.LargeImage = CType(resources.GetObject("btn_Vouchers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Vouchers.ImageOptions.LargeImageIndex = 59
        Me.btn_Vouchers.Name = "btn_Vouchers"
        '
        'PopupMenu_Voucher
        '
        Me.PopupMenu_Voucher.ItemLinks.Add(Me.btn_Voucher_New)
        Me.PopupMenu_Voucher.Name = "PopupMenu_Voucher"
        Me.PopupMenu_Voucher.Ribbon = Me.ribbonControl
        '
        'btn_Voucher_New
        '
        Me.btn_Voucher_New.Caption = "New Voucher"
        Me.btn_Voucher_New.Id = 94
        Me.btn_Voucher_New.ImageOptions.Image = CType(resources.GetObject("btn_Voucher_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Voucher_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_Voucher_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Voucher_New.Name = "btn_Voucher_New"
        '
        'btn_Account_Names
        '
        Me.btn_Account_Names.Caption = "Account Names"
        Me.btn_Account_Names.Id = 13
        Me.btn_Account_Names.ImageOptions.ImageIndex = 60
        Me.btn_Account_Names.ImageOptions.LargeImageIndex = 60
        Me.btn_Account_Names.Name = "btn_Account_Names"
        '
        'btn_Employees
        '
        Me.btn_Employees.Caption = "Employees"
        Me.btn_Employees.Id = 16
        Me.btn_Employees.ImageOptions.ImageIndex = 1
        Me.btn_Employees.ImageOptions.LargeImageIndex = 1
        Me.btn_Employees.Name = "btn_Employees"
        '
        'btn_Credit_Memo
        '
        Me.btn_Credit_Memo.Caption = "Credit Memo"
        Me.btn_Credit_Memo.Id = 17
        Me.btn_Credit_Memo.ImageOptions.Image = CType(resources.GetObject("btn_Credit_Memo.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Credit_Memo.ImageOptions.ImageIndex = 62
        Me.btn_Credit_Memo.ImageOptions.LargeImage = CType(resources.GetObject("btn_Credit_Memo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Credit_Memo.ImageOptions.LargeImageIndex = 62
        Me.btn_Credit_Memo.Name = "btn_Credit_Memo"
        '
        'btn_Item_Colors
        '
        Me.btn_Item_Colors.Caption = "Colors"
        Me.btn_Item_Colors.Id = 18
        Me.btn_Item_Colors.ImageOptions.Image = CType(resources.GetObject("btn_Item_Colors.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Item_Colors.ImageOptions.ImageIndex = 63
        Me.btn_Item_Colors.ImageOptions.LargeImage = CType(resources.GetObject("btn_Item_Colors.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Item_Colors.ImageOptions.LargeImageIndex = 63
        Me.btn_Item_Colors.Name = "btn_Item_Colors"
        '
        'btn_Printing_Detail
        '
        Me.btn_Printing_Detail.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Printing_Detail.Caption = "Printing Detail"
        Me.btn_Printing_Detail.DropDownControl = Me.PopupControlContainer_Printing_Detail
        Me.btn_Printing_Detail.Id = 22
        Me.btn_Printing_Detail.ImageOptions.ImageIndex = 65
        Me.btn_Printing_Detail.ImageOptions.LargeImageIndex = 65
        Me.btn_Printing_Detail.Name = "btn_Printing_Detail"
        '
        'PopupControlContainer_Printing_Detail
        '
        Me.PopupControlContainer_Printing_Detail.AutoSize = True
        Me.PopupControlContainer_Printing_Detail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer_Printing_Detail.Controls.Add(Me.xuc_Printing_Detail)
        Me.PopupControlContainer_Printing_Detail.Location = New System.Drawing.Point(430, 336)
        Me.PopupControlContainer_Printing_Detail.Name = "PopupControlContainer_Printing_Detail"
        Me.PopupControlContainer_Printing_Detail.Ribbon = Me.ribbonControl
        Me.PopupControlContainer_Printing_Detail.ShowCloseButton = True
        Me.PopupControlContainer_Printing_Detail.ShowSizeGrip = True
        Me.PopupControlContainer_Printing_Detail.Size = New System.Drawing.Size(236, 122)
        Me.PopupControlContainer_Printing_Detail.TabIndex = 18
        Me.PopupControlContainer_Printing_Detail.Visible = False
        '
        'xuc_Printing_Detail
        '
        Me.xuc_Printing_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Printing_Detail.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Printing_Detail.MinimumSize = New System.Drawing.Size(200, 80)
        Me.xuc_Printing_Detail.Name = "xuc_Printing_Detail"
        Me.xuc_Printing_Detail.Size = New System.Drawing.Size(236, 122)
        Me.xuc_Printing_Detail.TabIndex = 0
        '
        'BarToggleSwitchItem_Notification
        '
        Me.BarToggleSwitchItem_Notification.Caption = "Notifications"
        Me.BarToggleSwitchItem_Notification.Id = 23
        Me.BarToggleSwitchItem_Notification.Name = "BarToggleSwitchItem_Notification"
        '
        'btn_Banks
        '
        Me.btn_Banks.Caption = "Banks"
        Me.btn_Banks.Id = 24
        Me.btn_Banks.ImageOptions.Image = CType(resources.GetObject("btn_Banks.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Banks.ImageOptions.ImageIndex = 23
        Me.btn_Banks.ImageOptions.LargeImage = CType(resources.GetObject("btn_Banks.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Banks.ImageOptions.LargeImageIndex = 23
        Me.btn_Banks.Name = "btn_Banks"
        '
        'btn_Check_Numbers
        '
        Me.btn_Check_Numbers.Caption = "Checks"
        Me.btn_Check_Numbers.Id = 25
        Me.btn_Check_Numbers.ImageOptions.Image = CType(resources.GetObject("btn_Check_Numbers.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Check_Numbers.ImageOptions.ImageIndex = 19
        Me.btn_Check_Numbers.ImageOptions.LargeImage = CType(resources.GetObject("btn_Check_Numbers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Check_Numbers.ImageOptions.LargeImageIndex = 19
        Me.btn_Check_Numbers.Name = "btn_Check_Numbers"
        '
        'btn_Adjustments
        '
        Me.btn_Adjustments.Caption = "Additionals Deductions"
        Me.btn_Adjustments.Id = 26
        Me.btn_Adjustments.ImageOptions.Image = CType(resources.GetObject("btn_Adjustments.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Adjustments.ImageOptions.ImageIndex = 21
        Me.btn_Adjustments.ImageOptions.LargeImage = CType(resources.GetObject("btn_Adjustments.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Adjustments.ImageOptions.LargeImageIndex = 21
        Me.btn_Adjustments.Name = "btn_Adjustments"
        '
        'btn_Chat
        '
        Me.btn_Chat.Caption = "Chat"
        Me.btn_Chat.Id = 27
        Me.btn_Chat.ImageOptions.Image = CType(resources.GetObject("btn_Chat.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Chat.ImageOptions.ImageIndex = 53
        Me.btn_Chat.ImageOptions.LargeImage = CType(resources.GetObject("btn_Chat.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Chat.ImageOptions.LargeImageIndex = 53
        Me.btn_Chat.Name = "btn_Chat"
        '
        'BarEditItem_Search
        '
        Me.BarEditItem_Search.Caption = "Search"
        Me.BarEditItem_Search.Edit = Me.RepositoryItemPopupContainerEdit_Search
        Me.BarEditItem_Search.EditWidth = 200
        Me.BarEditItem_Search.Id = 30
        Me.BarEditItem_Search.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarEditItem_Search.Name = "BarEditItem_Search"
        '
        'RepositoryItemPopupContainerEdit_Search
        '
        Me.RepositoryItemPopupContainerEdit_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit_Search.CloseOnLostFocus = False
        Me.RepositoryItemPopupContainerEdit_Search.CloseOnOuterMouseClick = False
        Me.RepositoryItemPopupContainerEdit_Search.Name = "RepositoryItemPopupContainerEdit_Search"
        Me.RepositoryItemPopupContainerEdit_Search.PopupControl = Me.PopupContainerControl_Search
        Me.RepositoryItemPopupContainerEdit_Search.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'PopupContainerControl_Search
        '
        Me.PopupContainerControl_Search.Controls.Add(Me.xuc_Account_Search)
        Me.PopupContainerControl_Search.Location = New System.Drawing.Point(719, 164)
        Me.PopupContainerControl_Search.Name = "PopupContainerControl_Search"
        Me.PopupContainerControl_Search.Size = New System.Drawing.Size(266, 166)
        Me.PopupContainerControl_Search.TabIndex = 26
        '
        'xuc_Account_Search
        '
        Me.xuc_Account_Search.AccountName = Nothing
        Me.xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
        Me.xuc_Account_Search.Code = Nothing
        Me.xuc_Account_Search.Code2 = Nothing
        Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Account_Search.ID = 0
        Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Account_Search.Name = "xuc_Account_Search"
        Me.xuc_Account_Search.Others = Nothing
        Me.xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
        Me.xuc_Account_Search.Size = New System.Drawing.Size(266, 166)
        Me.xuc_Account_Search.TabIndex = 22
        Me.xuc_Account_Search.Type = Nothing
        '
        'btn_Repossesed
        '
        Me.btn_Repossesed.Caption = "Depo To Repo"
        Me.btn_Repossesed.Id = 31
        Me.btn_Repossesed.ImageOptions.Image = CType(resources.GetObject("btn_Repossesed.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Repossesed.ImageOptions.LargeImage = CType(resources.GetObject("btn_Repossesed.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Repossesed.Name = "btn_Repossesed"
        '
        'btn_Brands
        '
        Me.btn_Brands.Caption = "Brand"
        Me.btn_Brands.Id = 32
        Me.btn_Brands.ImageOptions.Image = CType(resources.GetObject("btn_Brands.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Brands.ImageOptions.LargeImage = CType(resources.GetObject("btn_Brands.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Brands.Name = "btn_Brands"
        '
        'btn_SMS_Configuration
        '
        Me.btn_SMS_Configuration.ActAsDropDown = True
        Me.btn_SMS_Configuration.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_SMS_Configuration.Caption = "SMS Config"
        Me.btn_SMS_Configuration.DropDownControl = Me.PopupContainerControl_SMS_Config
        Me.btn_SMS_Configuration.Id = 33
        Me.btn_SMS_Configuration.ImageOptions.Image = CType(resources.GetObject("btn_SMS_Configuration.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SMS_Configuration.ImageOptions.LargeImage = CType(resources.GetObject("btn_SMS_Configuration.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SMS_Configuration.Name = "btn_SMS_Configuration"
        '
        'PopupContainerControl_SMS_Config
        '
        Me.PopupContainerControl_SMS_Config.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupContainerControl_SMS_Config.Location = New System.Drawing.Point(719, 336)
        Me.PopupContainerControl_SMS_Config.Name = "PopupContainerControl_SMS_Config"
        Me.PopupContainerControl_SMS_Config.ShowSizeGrip = True
        Me.PopupContainerControl_SMS_Config.Size = New System.Drawing.Size(236, 153)
        Me.PopupContainerControl_SMS_Config.TabIndex = 30
        Me.PopupContainerControl_SMS_Config.Visible = False
        '
        'btn_SMS_Sender
        '
        Me.btn_SMS_Sender.Caption = "Sender"
        Me.btn_SMS_Sender.Id = 34
        Me.btn_SMS_Sender.ImageOptions.Image = CType(resources.GetObject("btn_SMS_Sender.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SMS_Sender.ImageOptions.LargeImage = CType(resources.GetObject("btn_SMS_Sender.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SMS_Sender.Name = "btn_SMS_Sender"
        '
        'btn_Dashboard_Journal_Entries
        '
        Me.btn_Dashboard_Journal_Entries.Caption = "Journal Entries"
        Me.btn_Dashboard_Journal_Entries.Id = 35
        Me.btn_Dashboard_Journal_Entries.ImageOptions.Image = CType(resources.GetObject("btn_Dashboard_Journal_Entries.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Dashboard_Journal_Entries.ImageOptions.LargeImage = CType(resources.GetObject("btn_Dashboard_Journal_Entries.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Dashboard_Journal_Entries.Name = "btn_Dashboard_Journal_Entries"
        '
        'btn_Add_Items
        '
        Me.btn_Add_Items.ActAsDropDown = True
        Me.btn_Add_Items.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Add_Items.Caption = "Add Items"
        Me.btn_Add_Items.DropDownControl = Me.PopupMenu_Add_New
        Me.btn_Add_Items.Hint = "Add New Items"
        Me.btn_Add_Items.Id = 36
        Me.btn_Add_Items.ImageOptions.Image = CType(resources.GetObject("btn_Add_Items.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Add_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Add_Items.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Add_Items.Name = "btn_Add_Items"
        Me.btn_Add_Items.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'PopupMenu_Add_New
        '
        Me.PopupMenu_Add_New.ItemLinks.Add(Me.btn_New_Check)
        Me.PopupMenu_Add_New.ItemLinks.Add(Me.btn_New_Expense)
        Me.PopupMenu_Add_New.ItemLinks.Add(Me.btn_New_COA)
        Me.PopupMenu_Add_New.ItemLinks.Add(Me.btn_New_Account_Name)
        Me.PopupMenu_Add_New.ItemLinks.Add(Me.btn_New_Journal_Entry)
        Me.PopupMenu_Add_New.Name = "PopupMenu_Add_New"
        Me.PopupMenu_Add_New.Ribbon = Me.ribbonControl
        '
        'btn_New_Check
        '
        Me.btn_New_Check.Caption = "New Check(s)"
        Me.btn_New_Check.Id = 37
        Me.btn_New_Check.ImageOptions.Image = CType(resources.GetObject("btn_New_Check.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_Check.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Check.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_Check.Name = "btn_New_Check"
        '
        'btn_New_Expense
        '
        Me.btn_New_Expense.Caption = "New Expense"
        Me.btn_New_Expense.Id = 61
        Me.btn_New_Expense.ImageOptions.Image = CType(resources.GetObject("btn_New_Expense.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_Expense.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Expense.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_Expense.Name = "btn_New_Expense"
        '
        'btn_New_COA
        '
        Me.btn_New_COA.Caption = "New Chart of Account"
        Me.btn_New_COA.Id = 38
        Me.btn_New_COA.ImageOptions.Image = CType(resources.GetObject("btn_New_COA.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_COA.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_COA.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_COA.Name = "btn_New_COA"
        '
        'btn_New_Account_Name
        '
        Me.btn_New_Account_Name.Caption = "New Account Name"
        Me.btn_New_Account_Name.Id = 39
        Me.btn_New_Account_Name.ImageOptions.Image = CType(resources.GetObject("btn_New_Account_Name.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_Account_Name.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Account_Name.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_Account_Name.Name = "btn_New_Account_Name"
        '
        'btn_New_Journal_Entry
        '
        Me.btn_New_Journal_Entry.Caption = "New Journal Entry"
        Me.btn_New_Journal_Entry.Id = 42
        Me.btn_New_Journal_Entry.ImageOptions.Image = CType(resources.GetObject("btn_New_Journal_Entry.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_Journal_Entry.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Journal_Entry.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_Journal_Entry.Name = "btn_New_Journal_Entry"
        '
        'btn_New_Voucher
        '
        Me.btn_New_Voucher.Caption = "New Cash/Check Voucher"
        Me.btn_New_Voucher.Id = 41
        Me.btn_New_Voucher.ImageOptions.Image = CType(resources.GetObject("btn_New_Voucher.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_Voucher.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Voucher.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New_Voucher.Name = "btn_New_Voucher"
        '
        'btn_Backup
        '
        Me.btn_Backup.Caption = "Backup"
        Me.btn_Backup.Id = 44
        Me.btn_Backup.ImageOptions.Image = CType(resources.GetObject("btn_Backup.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Backup.ImageOptions.LargeImage = CType(resources.GetObject("btn_Backup.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Backup.Name = "btn_Backup"
        '
        'btn_Budgets
        '
        Me.btn_Budgets.Caption = "Budgets"
        Me.btn_Budgets.Id = 46
        Me.btn_Budgets.ImageOptions.Image = CType(resources.GetObject("btn_Budgets.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Budgets.ImageOptions.LargeImage = CType(resources.GetObject("btn_Budgets.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Budgets.Name = "btn_Budgets"
        '
        'btn_Journal_Vouchers
        '
        Me.btn_Journal_Vouchers.Caption = "Journal Vouchers"
        Me.btn_Journal_Vouchers.Id = 49
        Me.btn_Journal_Vouchers.ImageOptions.Image = CType(resources.GetObject("btn_Journal_Vouchers.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Journal_Vouchers.ImageOptions.LargeImage = CType(resources.GetObject("btn_Journal_Vouchers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Journal_Vouchers.Name = "btn_Journal_Vouchers"
        '
        'btn_Petty_Cash
        '
        Me.btn_Petty_Cash.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Petty_Cash.Caption = "Petty Cash"
        Me.btn_Petty_Cash.DropDownControl = Me.PopupMenu_Petty_Cash
        Me.btn_Petty_Cash.Id = 51
        Me.btn_Petty_Cash.ImageOptions.Image = CType(resources.GetObject("btn_Petty_Cash.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Petty_Cash.ImageOptions.LargeImage = CType(resources.GetObject("btn_Petty_Cash.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Petty_Cash.Name = "btn_Petty_Cash"
        '
        'PopupMenu_Petty_Cash
        '
        Me.PopupMenu_Petty_Cash.ItemLinks.Add(Me.btn_Petty_Cash_New)
        Me.PopupMenu_Petty_Cash.Name = "PopupMenu_Petty_Cash"
        Me.PopupMenu_Petty_Cash.Ribbon = Me.ribbonControl
        '
        'btn_Petty_Cash_New
        '
        Me.btn_Petty_Cash_New.Caption = "New Expense"
        Me.btn_Petty_Cash_New.Id = 59
        Me.btn_Petty_Cash_New.ImageOptions.Image = CType(resources.GetObject("btn_Petty_Cash_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Petty_Cash_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_Petty_Cash_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Petty_Cash_New.Name = "btn_Petty_Cash_New"
        '
        'btn_Error_Report
        '
        Me.btn_Error_Report.Caption = "Error Report"
        Me.btn_Error_Report.Id = 52
        Me.btn_Error_Report.ImageOptions.Image = CType(resources.GetObject("btn_Error_Report.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Error_Report.ImageOptions.LargeImage = CType(resources.GetObject("btn_Error_Report.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Error_Report.Name = "btn_Error_Report"
        '
        'btn_Petty_Cash_Profiles
        '
        Me.btn_Petty_Cash_Profiles.Caption = "Petty Cash Profiles"
        Me.btn_Petty_Cash_Profiles.Id = 54
        Me.btn_Petty_Cash_Profiles.ImageOptions.Image = CType(resources.GetObject("btn_Petty_Cash_Profiles.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Petty_Cash_Profiles.ImageOptions.LargeImage = CType(resources.GetObject("btn_Petty_Cash_Profiles.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Petty_Cash_Profiles.Name = "btn_Petty_Cash_Profiles"
        '
        'btn_Ticket_New
        '
        Me.btn_Ticket_New.Caption = "New Ticket / Incident"
        Me.btn_Ticket_New.Id = 55
        Me.btn_Ticket_New.ImageOptions.Image = CType(resources.GetObject("btn_Ticket_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Ticket_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_Ticket_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Ticket_New.Name = "btn_Ticket_New"
        '
        'btn_Tickets
        '
        Me.btn_Tickets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Tickets.Caption = "Incidents / Tickets"
        Me.btn_Tickets.DropDownControl = Me.PopupMenu_Ticket
        Me.btn_Tickets.Id = 56
        Me.btn_Tickets.ImageOptions.Image = CType(resources.GetObject("btn_Tickets.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Tickets.ImageOptions.LargeImage = CType(resources.GetObject("btn_Tickets.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Tickets.Name = "btn_Tickets"
        '
        'PopupMenu_Ticket
        '
        Me.PopupMenu_Ticket.ItemLinks.Add(Me.btn_Ticket_New)
        Me.PopupMenu_Ticket.Name = "PopupMenu_Ticket"
        Me.PopupMenu_Ticket.Ribbon = Me.ribbonControl
        '
        'btn_Ticket_Groups
        '
        Me.btn_Ticket_Groups.Caption = "Ticket Groups"
        Me.btn_Ticket_Groups.Id = 57
        Me.btn_Ticket_Groups.ImageOptions.Image = CType(resources.GetObject("btn_Ticket_Groups.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Ticket_Groups.ImageOptions.LargeImage = CType(resources.GetObject("btn_Ticket_Groups.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Ticket_Groups.Name = "btn_Ticket_Groups"
        '
        'BarToggleSwitchItem_Check_Errors
        '
        Me.BarToggleSwitchItem_Check_Errors.Caption = "Check Errors"
        Me.BarToggleSwitchItem_Check_Errors.Id = 60
        Me.BarToggleSwitchItem_Check_Errors.Name = "BarToggleSwitchItem_Check_Errors"
        '
        'btn_Purchase_Orders
        '
        Me.btn_Purchase_Orders.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Purchase_Orders.Caption = "Purchase Orders"
        Me.btn_Purchase_Orders.DropDownControl = Me.PopupMenu_Purchase_Order
        Me.btn_Purchase_Orders.Id = 62
        Me.btn_Purchase_Orders.ImageOptions.Image = CType(resources.GetObject("btn_Purchase_Orders.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Purchase_Orders.ImageOptions.LargeImage = CType(resources.GetObject("btn_Purchase_Orders.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Purchase_Orders.Name = "btn_Purchase_Orders"
        '
        'PopupMenu_Purchase_Order
        '
        Me.PopupMenu_Purchase_Order.ItemLinks.Add(Me.btn_Wizard_New_Purchase_Order)
        Me.PopupMenu_Purchase_Order.Name = "PopupMenu_Purchase_Order"
        Me.PopupMenu_Purchase_Order.Ribbon = Me.ribbonControl
        '
        'btn_Wizard_New_Purchase_Order
        '
        Me.btn_Wizard_New_Purchase_Order.Caption = "New Purchase Order"
        Me.btn_Wizard_New_Purchase_Order.Id = 97
        Me.btn_Wizard_New_Purchase_Order.ImageOptions.Image = CType(resources.GetObject("btn_Wizard_New_Purchase_Order.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Wizard_New_Purchase_Order.ImageOptions.LargeImage = CType(resources.GetObject("btn_Wizard_New_Purchase_Order.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Wizard_New_Purchase_Order.Name = "btn_Wizard_New_Purchase_Order"
        '
        'BarToggleSwitchItem_Stack_Trace_Error
        '
        Me.BarToggleSwitchItem_Stack_Trace_Error.Caption = "Stack Trace Error"
        Me.BarToggleSwitchItem_Stack_Trace_Error.Id = 63
        Me.BarToggleSwitchItem_Stack_Trace_Error.Name = "BarToggleSwitchItem_Stack_Trace_Error"
        '
        'btn_MC_Transactions
        '
        Me.btn_MC_Transactions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_MC_Transactions.Caption = "MC Units/Items Transactions"
        Me.btn_MC_Transactions.DropDownControl = Me.PopupMenu_Receiving_Transfer
        Me.btn_MC_Transactions.Id = 64
        Me.btn_MC_Transactions.ImageOptions.Image = CType(resources.GetObject("btn_MC_Transactions.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_MC_Transactions.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Transactions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_MC_Transactions.Name = "btn_MC_Transactions"
        '
        'PopupMenu_Receiving_Transfer
        '
        Me.PopupMenu_Receiving_Transfer.ItemLinks.Add(Me.btn_Wizard_New_MC_Transaction)
        Me.PopupMenu_Receiving_Transfer.Name = "PopupMenu_Receiving_Transfer"
        Me.PopupMenu_Receiving_Transfer.Ribbon = Me.ribbonControl
        '
        'btn_Wizard_New_MC_Transaction
        '
        Me.btn_Wizard_New_MC_Transaction.Caption = "New MC Transaction"
        Me.btn_Wizard_New_MC_Transaction.Id = 98
        Me.btn_Wizard_New_MC_Transaction.ImageOptions.Image = CType(resources.GetObject("btn_Wizard_New_MC_Transaction.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Wizard_New_MC_Transaction.ImageOptions.LargeImage = CType(resources.GetObject("btn_Wizard_New_MC_Transaction.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Wizard_New_MC_Transaction.Name = "btn_Wizard_New_MC_Transaction"
        '
        'btn_Inclusions
        '
        Me.btn_Inclusions.Caption = "Inclusions"
        Me.btn_Inclusions.Id = 65
        Me.btn_Inclusions.ImageOptions.Image = CType(resources.GetObject("btn_Inclusions.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Inclusions.ImageOptions.LargeImage = CType(resources.GetObject("btn_Inclusions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Inclusions.Name = "btn_Inclusions"
        '
        'btn_Inclusion_Inventory
        '
        Me.btn_Inclusion_Inventory.Caption = "Inclusion Inventory"
        Me.btn_Inclusion_Inventory.Id = 66
        Me.btn_Inclusion_Inventory.ImageOptions.Image = CType(resources.GetObject("btn_Inclusion_Inventory.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Inclusion_Inventory.ImageOptions.LargeImage = CType(resources.GetObject("btn_Inclusion_Inventory.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Inclusion_Inventory.Name = "btn_Inclusion_Inventory"
        '
        'btn_Asset_Items
        '
        Me.btn_Asset_Items.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Asset_Items.Caption = "Asset Items"
        Me.btn_Asset_Items.DropDownControl = Me.PopupMenu_Assets
        Me.btn_Asset_Items.Id = 67
        Me.btn_Asset_Items.ImageOptions.Image = CType(resources.GetObject("btn_Asset_Items.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Asset_Items.ImageOptions.LargeImage = CType(resources.GetObject("btn_Asset_Items.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Asset_Items.Name = "btn_Asset_Items"
        '
        'PopupMenu_Assets
        '
        Me.PopupMenu_Assets.ItemLinks.Add(Me.btn_Asset_New)
        Me.PopupMenu_Assets.Name = "PopupMenu_Assets"
        Me.PopupMenu_Assets.Ribbon = Me.ribbonControl
        '
        'btn_Asset_New
        '
        Me.btn_Asset_New.Caption = "New Asset Item"
        Me.btn_Asset_New.Id = 71
        Me.btn_Asset_New.ImageOptions.Image = CType(resources.GetObject("btn_Asset_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Asset_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_Asset_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Asset_New.Name = "btn_Asset_New"
        '
        'SkinDropDownButtonItem
        '
        Me.SkinDropDownButtonItem.Id = 69
        Me.SkinDropDownButtonItem.Name = "SkinDropDownButtonItem"
        '
        'SkinPaletteDropDownButonItem
        '
        Me.SkinPaletteDropDownButonItem.Id = 70
        Me.SkinPaletteDropDownButonItem.Name = "SkinPaletteDropDownButonItem"
        '
        'SkinRibbonGalleryBarItem
        '
        Me.SkinRibbonGalleryBarItem.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem.Id = 72
        Me.SkinRibbonGalleryBarItem.Name = "SkinRibbonGalleryBarItem"
        '
        'SkinPaletteRibbonGalleryBarItem
        '
        Me.SkinPaletteRibbonGalleryBarItem.Caption = "SkinPaletteRibbonGalleryBarItem1"
        Me.SkinPaletteRibbonGalleryBarItem.Id = 73
        Me.SkinPaletteRibbonGalleryBarItem.Name = "SkinPaletteRibbonGalleryBarItem"
        '
        'btn_Payment_Requests
        '
        Me.btn_Payment_Requests.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Payment_Requests.Caption = "Payment Requests"
        Me.btn_Payment_Requests.DropDownControl = Me.PopupMenu_Payment_Request
        Me.btn_Payment_Requests.Id = 74
        Me.btn_Payment_Requests.ImageOptions.Image = CType(resources.GetObject("btn_Payment_Requests.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Payment_Requests.ImageOptions.LargeImage = CType(resources.GetObject("btn_Payment_Requests.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Payment_Requests.Name = "btn_Payment_Requests"
        '
        'PopupMenu_Payment_Request
        '
        Me.PopupMenu_Payment_Request.ItemLinks.Add(Me.btn_Payment_Request)
        Me.PopupMenu_Payment_Request.Name = "PopupMenu_Payment_Request"
        Me.PopupMenu_Payment_Request.Ribbon = Me.ribbonControl
        '
        'btn_Payment_Request
        '
        Me.btn_Payment_Request.Caption = "Payment Request"
        Me.btn_Payment_Request.Id = 75
        Me.btn_Payment_Request.ImageOptions.Image = CType(resources.GetObject("btn_Payment_Request.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Payment_Request.ImageOptions.LargeImage = CType(resources.GetObject("btn_Payment_Request.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Payment_Request.Name = "btn_Payment_Request"
        '
        'btn_Promotion_Discounts
        '
        Me.btn_Promotion_Discounts.Caption = "Promotions / Discounts"
        Me.btn_Promotion_Discounts.Id = 77
        Me.btn_Promotion_Discounts.ImageOptions.Image = CType(resources.GetObject("btn_Promotion_Discounts.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Promotion_Discounts.ImageOptions.LargeImage = CType(resources.GetObject("btn_Promotion_Discounts.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Promotion_Discounts.Name = "btn_Promotion_Discounts"
        '
        'btn_System_Requests
        '
        Me.btn_System_Requests.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_System_Requests.Caption = "System Requests"
        Me.btn_System_Requests.DropDownControl = Me.PopupMenu_System_Request
        Me.btn_System_Requests.Id = 78
        Me.btn_System_Requests.ImageOptions.Image = CType(resources.GetObject("btn_System_Requests.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_System_Requests.ImageOptions.LargeImage = CType(resources.GetObject("btn_System_Requests.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_System_Requests.Name = "btn_System_Requests"
        '
        'PopupMenu_System_Request
        '
        Me.PopupMenu_System_Request.ItemLinks.Add(Me.btn_System_Request)
        Me.PopupMenu_System_Request.Name = "PopupMenu_System_Request"
        Me.PopupMenu_System_Request.Ribbon = Me.ribbonControl
        '
        'btn_System_Request
        '
        Me.btn_System_Request.Caption = "System Request"
        Me.btn_System_Request.Id = 79
        Me.btn_System_Request.ImageOptions.Image = CType(resources.GetObject("btn_System_Request.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_System_Request.ImageOptions.LargeImage = CType(resources.GetObject("btn_System_Request.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_System_Request.Name = "btn_System_Request"
        '
        'btn_Transmittals
        '
        Me.btn_Transmittals.Caption = "Transmittals"
        Me.btn_Transmittals.Id = 80
        Me.btn_Transmittals.ImageOptions.Image = CType(resources.GetObject("btn_Transmittals.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Transmittals.ImageOptions.LargeImage = CType(resources.GetObject("btn_Transmittals.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Transmittals.Name = "btn_Transmittals"
        '
        'btn_Unit_Invoices
        '
        Me.btn_Unit_Invoices.Caption = "MC Unit Invoices"
        Me.btn_Unit_Invoices.Id = 81
        Me.btn_Unit_Invoices.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Invoices.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Unit_Invoices.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Invoices.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Unit_Invoices.Name = "btn_Unit_Invoices"
        '
        'btn_Salaries
        '
        Me.btn_Salaries.Caption = "Salaries / Allowances"
        Me.btn_Salaries.Id = 82
        Me.btn_Salaries.ImageOptions.Image = CType(resources.GetObject("btn_Salaries.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Salaries.ImageOptions.LargeImage = CType(resources.GetObject("btn_Salaries.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Salaries.Name = "btn_Salaries"
        '
        'Annual_Leave
        '
        Me.Annual_Leave.Caption = "Annual Leave"
        Me.Annual_Leave.Id = 83
        Me.Annual_Leave.ImageOptions.Image = CType(resources.GetObject("Annual_Leave.ImageOptions.Image"), System.Drawing.Image)
        Me.Annual_Leave.ImageOptions.LargeImage = CType(resources.GetObject("Annual_Leave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Annual_Leave.Name = "Annual_Leave"
        '
        'btn_Leave_Absences
        '
        Me.btn_Leave_Absences.Caption = "Leave and Absences"
        Me.btn_Leave_Absences.Id = 84
        Me.btn_Leave_Absences.ImageOptions.Image = CType(resources.GetObject("btn_Leave_Absences.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Leave_Absences.ImageOptions.LargeImage = CType(resources.GetObject("btn_Leave_Absences.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Leave_Absences.Name = "btn_Leave_Absences"
        '
        'btn_Attendance
        '
        Me.btn_Attendance.Caption = "Attendance"
        Me.btn_Attendance.Id = 85
        Me.btn_Attendance.ImageOptions.Image = CType(resources.GetObject("btn_Attendance.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Attendance.ImageOptions.LargeImage = CType(resources.GetObject("btn_Attendance.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Attendance.Name = "btn_Attendance"
        '
        'btn_Payroll
        '
        Me.btn_Payroll.Caption = "Payroll"
        Me.btn_Payroll.Id = 86
        Me.btn_Payroll.ImageOptions.Image = CType(resources.GetObject("btn_Payroll.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Payroll.ImageOptions.LargeImage = CType(resources.GetObject("btn_Payroll.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Payroll.Name = "btn_Payroll"
        '
        'btn_Pay_Checks
        '
        Me.btn_Pay_Checks.Caption = "Pay Checks"
        Me.btn_Pay_Checks.Id = 87
        Me.btn_Pay_Checks.ImageOptions.Image = CType(resources.GetObject("btn_Pay_Checks.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Pay_Checks.ImageOptions.LargeImage = CType(resources.GetObject("btn_Pay_Checks.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Pay_Checks.Name = "btn_Pay_Checks"
        '
        'btn_Helps
        '
        Me.btn_Helps.Caption = "FAQ / Help"
        Me.btn_Helps.Id = 88
        Me.btn_Helps.ImageOptions.Image = CType(resources.GetObject("btn_Helps.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Helps.ImageOptions.LargeImage = CType(resources.GetObject("btn_Helps.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Helps.Name = "btn_Helps"
        '
        'btn_MC_Requests
        '
        Me.btn_MC_Requests.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_MC_Requests.Caption = "Requests / Orders"
        Me.btn_MC_Requests.DropDownControl = Me.PopupMenu_MC_Request
        Me.btn_MC_Requests.Id = 89
        Me.btn_MC_Requests.ImageOptions.Image = CType(resources.GetObject("btn_MC_Requests.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_MC_Requests.ImageOptions.LargeImage = CType(resources.GetObject("btn_MC_Requests.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_MC_Requests.Name = "btn_MC_Requests"
        '
        'PopupMenu_MC_Request
        '
        Me.PopupMenu_MC_Request.ItemLinks.Add(Me.btn_Wizard_New_MC_Request)
        Me.PopupMenu_MC_Request.Name = "PopupMenu_MC_Request"
        Me.PopupMenu_MC_Request.Ribbon = Me.ribbonControl
        '
        'btn_Wizard_New_MC_Request
        '
        Me.btn_Wizard_New_MC_Request.Caption = "New MC Request"
        Me.btn_Wizard_New_MC_Request.Id = 96
        Me.btn_Wizard_New_MC_Request.ImageOptions.Image = CType(resources.GetObject("btn_Wizard_New_MC_Request.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Wizard_New_MC_Request.ImageOptions.LargeImage = CType(resources.GetObject("btn_Wizard_New_MC_Request.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Wizard_New_MC_Request.Name = "btn_Wizard_New_MC_Request"
        '
        'btn_Schedule_Types
        '
        Me.btn_Schedule_Types.Caption = "Schedule Types"
        Me.btn_Schedule_Types.Id = 90
        Me.btn_Schedule_Types.ImageOptions.Image = CType(resources.GetObject("btn_Schedule_Types.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Schedule_Types.ImageOptions.LargeImage = CType(resources.GetObject("btn_Schedule_Types.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Schedule_Types.Name = "btn_Schedule_Types"
        '
        'btn_Schedules
        '
        Me.btn_Schedules.Caption = "Employee Schedules"
        Me.btn_Schedules.Id = 91
        Me.btn_Schedules.ImageOptions.Image = CType(resources.GetObject("btn_Schedules.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Schedules.ImageOptions.LargeImage = CType(resources.GetObject("btn_Schedules.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Schedules.Name = "btn_Schedules"
        '
        'btn_Date_Branch
        '
        Me.btn_Date_Branch.Caption = "Branch Date"
        Me.btn_Date_Branch.Id = 92
        Me.btn_Date_Branch.ImageOptions.Image = CType(resources.GetObject("btn_Date_Branch.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Date_Branch.ImageOptions.LargeImage = CType(resources.GetObject("btn_Date_Branch.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Date_Branch.Name = "btn_Date_Branch"
        Me.btn_Date_Branch.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_Date_Cut_Off
        '
        Me.btn_Date_Cut_Off.Caption = "Cut-Off Date"
        Me.btn_Date_Cut_Off.Id = 93
        Me.btn_Date_Cut_Off.ImageOptions.Image = CType(resources.GetObject("btn_Date_Cut_Off.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Date_Cut_Off.ImageOptions.LargeImage = CType(resources.GetObject("btn_Date_Cut_Off.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Date_Cut_Off.Name = "btn_Date_Cut_Off"
        Me.btn_Date_Cut_Off.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_Branch_Reload
        '
        Me.btn_Branch_Reload.Caption = "Reload Branch"
        Me.btn_Branch_Reload.Id = 95
        Me.btn_Branch_Reload.ImageOptions.Image = CType(resources.GetObject("btn_Branch_Reload.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Branch_Reload.ImageOptions.LargeImage = CType(resources.GetObject("btn_Branch_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Branch_Reload.Name = "btn_Branch_Reload"
        Me.btn_Branch_Reload.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarToggleSwitchItem_Edit_Advanced_Mode
        '
        Me.BarToggleSwitchItem_Edit_Advanced_Mode.Caption = "Edit Advanced Mode"
        Me.BarToggleSwitchItem_Edit_Advanced_Mode.Id = 99
        Me.BarToggleSwitchItem_Edit_Advanced_Mode.Name = "BarToggleSwitchItem_Edit_Advanced_Mode"
        '
        'RibbonPageCategory_Accounting
        '
        Me.RibbonPageCategory_Accounting.Name = "RibbonPageCategory_Accounting"
        Me.RibbonPageCategory_Accounting.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_Accounting, Me.RibbonPage_Customers, Me.RibbonPage_Spare_Parts})
        Me.RibbonPageCategory_Accounting.Text = "Accounting"
        '
        'RibbonPage_Accounting
        '
        Me.RibbonPage_Accounting.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup_Accounting_Parameters, Me.ribbonPageGroup_Books, Me.ribbonPageGroup_Sales, Me.RibbonPageGroup_Dashboards})
        Me.RibbonPage_Accounting.Name = "RibbonPage_Accounting"
        Me.RibbonPage_Accounting.Text = "Accounting"
        '
        'ribbonPageGroup_Accounting_Parameters
        '
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.barEditItem_Branch, True)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Day, True)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Branch_Reload)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Date_Branch)
        Me.ribbonPageGroup_Accounting_Parameters.ItemLinks.Add(Me.btn_Date_Cut_Off)
        Me.ribbonPageGroup_Accounting_Parameters.Name = "ribbonPageGroup_Accounting_Parameters"
        Me.ribbonPageGroup_Accounting_Parameters.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
        Me.ribbonPageGroup_Accounting_Parameters.Text = "Parameters"
        '
        'ribbonPageGroup_Books
        '
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Check_Numbers)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Budgets)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Chart_Of_Accounts, True)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Account_Names)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Vouchers, True)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Journal_Vouchers)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Petty_Cash)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Journal_Entries)
        Me.ribbonPageGroup_Books.ItemLinks.Add(Me.btn_Trial_Balance)
        Me.ribbonPageGroup_Books.Name = "ribbonPageGroup_Books"
        Me.ribbonPageGroup_Books.Text = "Management"
        '
        'ribbonPageGroup_Sales
        '
        Me.ribbonPageGroup_Sales.ItemLinks.Add(Me.btn_Customer_Accounts)
        Me.ribbonPageGroup_Sales.ItemLinks.Add(Me.btn_Releases)
        Me.ribbonPageGroup_Sales.ItemLinks.Add(Me.btn_Collections)
        Me.ribbonPageGroup_Sales.Name = "ribbonPageGroup_Sales"
        Me.ribbonPageGroup_Sales.Text = "Sales"
        '
        'RibbonPageGroup_Dashboards
        '
        Me.RibbonPageGroup_Dashboards.ItemLinks.Add(Me.btn_Dashboard_Journal_Entries)
        Me.RibbonPageGroup_Dashboards.Name = "RibbonPageGroup_Dashboards"
        Me.RibbonPageGroup_Dashboards.Text = "Dashboards"
        '
        'RibbonPage_Customers
        '
        Me.RibbonPage_Customers.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup_Management_Parameters, Me.ribbonPageGroup_Customer_Management, Me.RibbonPageGroup_Customer_Sales})
        Me.RibbonPage_Customers.Name = "RibbonPage_Customers"
        Me.RibbonPage_Customers.Text = "Customers"
        '
        'ribbonPageGroup_Management_Parameters
        '
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.barEditItem_Branch, True)
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.btn_Day)
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.ribbonPageGroup_Management_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.ribbonPageGroup_Management_Parameters.Name = "ribbonPageGroup_Management_Parameters"
        Me.ribbonPageGroup_Management_Parameters.Text = "Parameters"
        '
        'ribbonPageGroup_Customer_Management
        '
        Me.ribbonPageGroup_Customer_Management.ItemLinks.Add(Me.btn_Customer_Migration)
        Me.ribbonPageGroup_Customer_Management.ItemLinks.Add(Me.btn_Customers)
        Me.ribbonPageGroup_Customer_Management.ItemLinks.Add(Me.btn_Customer_Accounts)
        Me.ribbonPageGroup_Customer_Management.ItemLinks.Add(Me.btn_Account_Applications)
        Me.ribbonPageGroup_Customer_Management.Name = "ribbonPageGroup_Customer_Management"
        Me.ribbonPageGroup_Customer_Management.Text = "Management"
        '
        'RibbonPageGroup_Customer_Sales
        '
        Me.RibbonPageGroup_Customer_Sales.ItemLinks.Add(Me.btn_Releases)
        Me.RibbonPageGroup_Customer_Sales.ItemLinks.Add(Me.btn_Collections)
        Me.RibbonPageGroup_Customer_Sales.ItemLinks.Add(Me.btn_Repossesed)
        Me.RibbonPageGroup_Customer_Sales.ItemLinks.Add(Me.btn_Credit_Memo)
        Me.RibbonPageGroup_Customer_Sales.Name = "RibbonPageGroup_Customer_Sales"
        Me.RibbonPageGroup_Customer_Sales.Text = "Sales"
        '
        'RibbonPage_Spare_Parts
        '
        Me.RibbonPage_Spare_Parts.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup_Parameters, Me.ribbonPageGroup_Management, Me.ribbonPageGroup_Inventory})
        Me.RibbonPage_Spare_Parts.Name = "RibbonPage_Spare_Parts"
        Me.RibbonPage_Spare_Parts.Text = "Spare Parts "
        '
        'ribbonPageGroup_Parameters
        '
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.barEditItem_Branch)
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Day)
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.ribbonPageGroup_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.ribbonPageGroup_Parameters.Name = "ribbonPageGroup_Parameters"
        Me.ribbonPageGroup_Parameters.Text = "Parameters"
        '
        'ribbonPageGroup_Management
        '
        Me.ribbonPageGroup_Management.ItemLinks.Add(Me.btn_Suppliers)
        Me.ribbonPageGroup_Management.ItemLinks.Add(Me.btn_Customers)
        Me.ribbonPageGroup_Management.ItemLinks.Add(Me.btn_Spare_Parts)
        Me.ribbonPageGroup_Management.Name = "ribbonPageGroup_Management"
        Me.ribbonPageGroup_Management.Text = "Management"
        '
        'ribbonPageGroup_Inventory
        '
        Me.ribbonPageGroup_Inventory.ItemLinks.Add(Me.btn_Spare_Part_Costing)
        Me.ribbonPageGroup_Inventory.ItemLinks.Add(Me.btn_SPA_Inventory)
        Me.ribbonPageGroup_Inventory.ItemLinks.Add(Me.btn_Spare_Part_Sales)
        Me.ribbonPageGroup_Inventory.Name = "ribbonPageGroup_Inventory"
        Me.ribbonPageGroup_Inventory.Text = "Inventory"
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_Logistics})
        Me.RibbonPageCategory1.Text = "Logistics"
        '
        'RibbonPage_Logistics
        '
        Me.RibbonPage_Logistics.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_Logistics_Parameters, Me.RibbonPageGroup_Logistic_Management, Me.RibbonPageGroup_Logistics_Inventory})
        Me.RibbonPage_Logistics.Name = "RibbonPage_Logistics"
        Me.RibbonPage_Logistics.Text = "Logistics"
        '
        'RibbonPageGroup_Logistics_Parameters
        '
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.barEditItem_Branch)
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.btn_Day)
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.RibbonPageGroup_Logistics_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.RibbonPageGroup_Logistics_Parameters.Name = "RibbonPageGroup_Logistics_Parameters"
        Me.RibbonPageGroup_Logistics_Parameters.Text = "Parameters"
        '
        'RibbonPageGroup_Logistic_Management
        '
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Brands)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Models)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Item_Colors)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Inclusions)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_MC_Requests, True)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Purchase_Orders)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_Unit_Invoices)
        Me.RibbonPageGroup_Logistic_Management.ItemLinks.Add(Me.btn_MC_Transactions)
        Me.RibbonPageGroup_Logistic_Management.Name = "RibbonPageGroup_Logistic_Management"
        Me.RibbonPageGroup_Logistic_Management.Text = "Management"
        '
        'RibbonPageGroup_Logistics_Inventory
        '
        Me.RibbonPageGroup_Logistics_Inventory.ItemLinks.Add(Me.btn_Inclusion_Inventory)
        Me.RibbonPageGroup_Logistics_Inventory.ItemLinks.Add(Me.btn_Inventory)
        Me.RibbonPageGroup_Logistics_Inventory.Name = "RibbonPageGroup_Logistics_Inventory"
        Me.RibbonPageGroup_Logistics_Inventory.Text = "Inventory"
        '
        'RibbonPageCategory2
        '
        Me.RibbonPageCategory2.Name = "RibbonPageCategory2"
        Me.RibbonPageCategory2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_Audit})
        Me.RibbonPageCategory2.Text = "Audit"
        '
        'RibbonPage_Audit
        '
        Me.RibbonPage_Audit.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup_Audit_Parameters, Me.ribbonPageGroup_Records, Me.RibbonPageGroup_Operations})
        Me.RibbonPage_Audit.Name = "RibbonPage_Audit"
        Me.RibbonPage_Audit.Text = "Audit"
        '
        'ribbonPageGroup_Audit_Parameters
        '
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.barEditItem_Branch, True)
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.btn_Day)
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.btn_Today)
        Me.ribbonPageGroup_Audit_Parameters.ItemLinks.Add(Me.btn_Month)
        Me.ribbonPageGroup_Audit_Parameters.Name = "ribbonPageGroup_Audit_Parameters"
        Me.ribbonPageGroup_Audit_Parameters.Text = "Parameters"
        '
        'ribbonPageGroup_Records
        '
        Me.ribbonPageGroup_Records.ItemLinks.Add(Me.btn_Asset_Items)
        Me.ribbonPageGroup_Records.ItemLinks.Add(Me.btn_Customer_Accounts)
        Me.ribbonPageGroup_Records.ItemLinks.Add(Me.btn_Petty_Cash)
        Me.ribbonPageGroup_Records.ItemLinks.Add(Me.btn_Aging)
        Me.ribbonPageGroup_Records.Name = "ribbonPageGroup_Records"
        Me.ribbonPageGroup_Records.Text = "Records"
        '
        'RibbonPageGroup_Operations
        '
        Me.RibbonPageGroup_Operations.ItemLinks.Add(Me.btn_Error_Report, True)
        Me.RibbonPageGroup_Operations.Name = "RibbonPageGroup_Operations"
        Me.RibbonPageGroup_Operations.Text = "Operations"
        '
        'RibbonPageCategory_HR
        '
        Me.RibbonPageCategory_HR.Name = "RibbonPageCategory_HR"
        Me.RibbonPageCategory_HR.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_HRM})
        Me.RibbonPageCategory_HR.Text = "Human Resource"
        '
        'RibbonPage_HRM
        '
        Me.RibbonPage_HRM.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_HR_Management, Me.RibbonPageGroup1})
        Me.RibbonPage_HRM.Name = "RibbonPage_HRM"
        Me.RibbonPage_HRM.Text = "Human Resource"
        '
        'RibbonPageGroup_HR_Management
        '
        Me.RibbonPageGroup_HR_Management.ItemLinks.Add(Me.btn_Employees)
        Me.RibbonPageGroup_HR_Management.ItemLinks.Add(Me.btn_Adjustments)
        Me.RibbonPageGroup_HR_Management.ItemLinks.Add(Me.btn_Salaries)
        Me.RibbonPageGroup_HR_Management.ItemLinks.Add(Me.btn_Schedule_Types, True)
        Me.RibbonPageGroup_HR_Management.ItemLinks.Add(Me.btn_Schedules)
        Me.RibbonPageGroup_HR_Management.Name = "RibbonPageGroup_HR_Management"
        Me.RibbonPageGroup_HR_Management.Text = "Management"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.Annual_Leave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_Leave_Absences, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_Attendance)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_Payroll, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_Pay_Checks)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Records"
        '
        'RibbonPage_User
        '
        Me.RibbonPage_User.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup, Me.RibbonPageGroup_Support, Me.RibbonPageGroup_SMS, Me.ribbonPageGroup_Account_Options})
        Me.RibbonPage_User.Name = "RibbonPage_User"
        Me.RibbonPage_User.Text = "User "
        '
        'ribbonPageGroup
        '
        Me.ribbonPageGroup.AllowTextClipping = False
        Me.ribbonPageGroup.ItemLinks.Add(Me.SkinRibbonGalleryBarItem)
        Me.ribbonPageGroup.ItemLinks.Add(Me.SkinPaletteRibbonGalleryBarItem)
        Me.ribbonPageGroup.Name = "ribbonPageGroup"
        Me.ribbonPageGroup.Text = "Theme"
        '
        'RibbonPageGroup_Support
        '
        Me.RibbonPageGroup_Support.ItemLinks.Add(Me.btn_Helps)
        Me.RibbonPageGroup_Support.ItemLinks.Add(Me.btn_Tickets)
        Me.RibbonPageGroup_Support.ItemLinks.Add(Me.btn_Payment_Requests, True)
        Me.RibbonPageGroup_Support.ItemLinks.Add(Me.btn_System_Requests)
        Me.RibbonPageGroup_Support.ItemLinks.Add(Me.btn_Transmittals)
        Me.RibbonPageGroup_Support.Name = "RibbonPageGroup_Support"
        Me.RibbonPageGroup_Support.Text = "Support"
        '
        'RibbonPageGroup_SMS
        '
        Me.RibbonPageGroup_SMS.ItemLinks.Add(Me.btn_SMS_Configuration)
        Me.RibbonPageGroup_SMS.ItemLinks.Add(Me.btn_SMS_Sender)
        Me.RibbonPageGroup_SMS.Name = "RibbonPageGroup_SMS"
        Me.RibbonPageGroup_SMS.Text = "SMS"
        '
        'ribbonPageGroup_Account_Options
        '
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_Printing_Detail, True)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_Password_Change)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_Chat, True)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_User_Login)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_User_Change)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_User_Lock)
        Me.ribbonPageGroup_Account_Options.ItemLinks.Add(Me.btn_Quit, True)
        Me.ribbonPageGroup_Account_Options.Name = "ribbonPageGroup_Account_Options"
        Me.ribbonPageGroup_Account_Options.Text = "Account Options"
        '
        'RibbonPage_System
        '
        Me.RibbonPage_System.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup_Server_Options, Me.ribbonPageGroup_Application})
        Me.RibbonPage_System.Name = "RibbonPage_System"
        Me.RibbonPage_System.Text = "System  "
        '
        'ribbonPageGroup_Server_Options
        '
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.btn_Server_Connection)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.btn_Server_Refresh)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.btn_Server_Ping, True)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.btn_Server_Ping_Monitor)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.BarToggleSwitchItem_Continous)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.BarToggleSwitchItem_Host)
        Me.ribbonPageGroup_Server_Options.ItemLinks.Add(Me.barEdit_Host)
        Me.ribbonPageGroup_Server_Options.Name = "ribbonPageGroup_Server_Options"
        Me.ribbonPageGroup_Server_Options.Text = "Server Options"
        '
        'ribbonPageGroup_Application
        '
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Auto_Update)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Splash_Wait)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Notification)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Edit_Advanced_Mode)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Check_Errors)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.BarToggleSwitchItem_Stack_Trace_Error)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.btn_Initialize_Controls, True)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.btn_Report_Designer, True)
        Me.ribbonPageGroup_Application.ItemLinks.Add(Me.btn_Report_Designer_Ribbon)
        Me.ribbonPageGroup_Application.Name = "ribbonPageGroup_Application"
        Me.ribbonPageGroup_Application.Text = "Application"
        '
        'RibbonPage_Administration
        '
        Me.RibbonPage_Administration.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup9, Me.RibbonPageGroup_Asset_Management, Me.ribbonPageGroup_Personnel, Me.RibbonPageGroup_Accounting, Me.RibbonPageGroup_Database})
        Me.RibbonPage_Administration.Name = "RibbonPage_Administration"
        Me.RibbonPage_Administration.Text = "Administration  "
        '
        'ribbonPageGroup9
        '
        Me.ribbonPageGroup9.ItemLinks.Add(Me.btn_Server_IP_Access)
        Me.ribbonPageGroup9.ItemLinks.Add(Me.btn_Branches)
        Me.ribbonPageGroup9.ItemLinks.Add(Me.btn_Info_Centers)
        Me.ribbonPageGroup9.ItemLinks.Add(Me.btn_Ticket_Groups)
        Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
        Me.ribbonPageGroup9.Text = "Application"
        '
        'RibbonPageGroup_Asset_Management
        '
        Me.RibbonPageGroup_Asset_Management.ItemLinks.Add(Me.btn_System_Requests)
        Me.RibbonPageGroup_Asset_Management.ItemLinks.Add(Me.btn_Asset_Items)
        Me.RibbonPageGroup_Asset_Management.Name = "RibbonPageGroup_Asset_Management"
        Me.RibbonPageGroup_Asset_Management.Text = "Assets"
        '
        'ribbonPageGroup_Personnel
        '
        Me.ribbonPageGroup_Personnel.ItemLinks.Add(Me.btn_Users)
        Me.ribbonPageGroup_Personnel.ItemLinks.Add(Me.btn_Account_Executives)
        Me.ribbonPageGroup_Personnel.ItemLinks.Add(Me.btn_Agents)
        Me.ribbonPageGroup_Personnel.ItemLinks.Add(Me.btn_Customers)
        Me.ribbonPageGroup_Personnel.Name = "ribbonPageGroup_Personnel"
        Me.ribbonPageGroup_Personnel.Text = "Personnel"
        '
        'RibbonPageGroup_Accounting
        '
        Me.RibbonPageGroup_Accounting.ItemLinks.Add(Me.btn_Banks)
        Me.RibbonPageGroup_Accounting.ItemLinks.Add(Me.btn_Journal_Profiles)
        Me.RibbonPageGroup_Accounting.ItemLinks.Add(Me.btn_Petty_Cash_Profiles)
        Me.RibbonPageGroup_Accounting.ItemLinks.Add(Me.btn_Promotion_Discounts)
        Me.RibbonPageGroup_Accounting.Name = "RibbonPageGroup_Accounting"
        Me.RibbonPageGroup_Accounting.Text = "Accounting"
        '
        'RibbonPageGroup_Database
        '
        Me.RibbonPageGroup_Database.ItemLinks.Add(Me.btn_Query)
        Me.RibbonPageGroup_Database.ItemLinks.Add(Me.btn_Backup)
        Me.RibbonPageGroup_Database.Name = "RibbonPageGroup_Database"
        Me.RibbonPageGroup_Database.Text = "Database"
        '
        'repositoryItemPopupContainerEdit
        '
        Me.repositoryItemPopupContainerEdit.AutoHeight = False
        Me.repositoryItemPopupContainerEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemPopupContainerEdit.Name = "repositoryItemPopupContainerEdit"
        '
        'RepositoryItemtoggle_Balance_Type
        '
        Me.RepositoryItemtoggle_Balance_Type.AutoHeight = False
        Me.RepositoryItemtoggle_Balance_Type.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemtoggle_Balance_Type.Name = "RepositoryItemtoggle_Balance_Type"
        Me.RepositoryItemtoggle_Balance_Type.OffText = "Monthly"
        Me.RepositoryItemtoggle_Balance_Type.OnText = "Daily"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.btn_Server_Refresh)
        Me.ribbonStatusBar.ItemLinks.Add(Me.barStaticItem1)
        Me.ribbonStatusBar.ItemLinks.Add(Me.barMdiChildrenListItem)
        Me.ribbonStatusBar.ItemLinks.Add(Me.BarEditItem_Corporation, True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Bar_User_Name, False, "", "", True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Bar_User_Position)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Bar_IP_Server, False, "", "", True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Bar_IP_Local, False, "", "", True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.btn_Update)
        Me.ribbonStatusBar.ItemLinks.Add(Me.Bar_Unit_Version)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 611)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1177, 24)
        '
        'barStaticItem1
        '
        Me.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.barStaticItem1.Caption = "Developed by: SAGA IT Department"
        Me.barStaticItem1.CategoryGuid = New System.Guid("8f5e6527-696e-436b-af39-7230ff55a3ac")
        Me.barStaticItem1.Id = 69
        Me.barStaticItem1.Name = "barStaticItem1"
        '
        'xtraTabbedMdiManager
        '
        Me.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.xtraTabbedMdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager.HeaderButtons = CType((((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.[Next]) _
            Or DevExpress.XtraTab.TabButtons.Close) _
            Or DevExpress.XtraTab.TabButtons.[Default]), DevExpress.XtraTab.TabButtons)
        Me.xtraTabbedMdiManager.MdiParent = Me
        '
        'ribbonPageGroup13
        '
        Me.ribbonPageGroup13.Name = "ribbonPageGroup13"
        '
        'DockManager
        '
        Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager.Form = Me
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.DockPanel1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(1156, 158)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(21, 453)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("00f2e86a-61f2-4941-ac8f-fa27b45f0adf")
        Me.DockPanel1.Location = New System.Drawing.Point(885, 158)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(300, 447)
        Me.DockPanel1.Text = "Chat Box"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(293, 418)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'BackgroundWorker
        '
        '
        'AdornerUIManager
        '
        Me.AdornerUIManager.Owner = Me
        '
        'frm_Main
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 635)
        Me.Controls.Add(Me.PopupContainerControl_SMS_Config)
        Me.Controls.Add(Me.PopupContainerControl_Search)
        Me.Controls.Add(Me.PopupControlContainer_Printing_Detail)
        Me.Controls.Add(Me.popup_Account_Search)
        Me.Controls.Add(Me.popup_Connection)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.HelpButton = True
        Me.IconOptions.Icon = CType(resources.GetObject("frm_Main.IconOptions.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Saga Finance"
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUp_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popup_Connection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popup_Connection.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popup_Account_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popup_Account_Search.ResumeLayout(False)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl.ResumeLayout(False)
        CType(Me.search_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItem_Host, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Release, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupControlContainer_Printing_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer_Printing_Detail.ResumeLayout(False)
        CType(Me.RepositoryItemPopupContainerEdit_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_Search.ResumeLayout(False)
        CType(Me.PopupContainerControl_SMS_Config, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Add_New, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Petty_Cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Ticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Purchase_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Receiving_Transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Assets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_Payment_Request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_System_Request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_MC_Request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemtoggle_Balance_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private RibbonPage_User As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private employeesBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private customersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private barSubItemNavigation As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btn_Suppliers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Customers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Spare_Parts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Spare_Part_Sales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SPA_Inventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Spare_Part_Costing As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_Spare_Parts As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Management As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup_Inventory As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private imageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents btn_User_Change As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_User_Lock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Quit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonPageGroup_Account_Options As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Users As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_System As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Server_Options As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Server_Connection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Server_Ping As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_User_Login As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Server_IP_Access As DevExpress.XtraBars.BarButtonItem
    Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar_User_Name As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar_User_Position As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar_IP_Server As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar_IP_Local As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btn_Server_Ping_Monitor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Agents As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Info_Centers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Branches As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_Administration As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Personnel As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private xtraTabbedMdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btn_Server_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Customer_Migration As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_Customers As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Customer_Management As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Customer_Accounts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Initialize_Controls As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonPageGroup_Application As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend lookUp_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Account_Executives As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarToggleSwitchItem_Splash_Wait As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_Models As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_Accounting As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar_Unit_Version As DevExpress.XtraBars.BarStaticItem
    Private BarToggleSwitchItem_Continous As DevExpress.XtraBars.BarToggleSwitchItem
    Private barEdit_Host As DevExpress.XtraBars.BarEditItem
    Private repositoryItem_Host As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private BarToggleSwitchItem_Host As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_Collections As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Releases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonPageGroup_Sales As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Monitoring_Payments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
    Friend WithEvents barEditItem_Date_End As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repository_Date_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repository_Date_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ribbonPageGroup_Accounting_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup_Audit_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribbonPageGroup_Management_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btn_Trial_Balance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonPageGroup_Books As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Receivables As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Inventory As DevExpress.XtraBars.BarButtonItem
    Private popup_Account_Search As DevExpress.XtraBars.PopupControlContainer
    Private repositoryItemPopupContainerEdit As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Private BarToggleSwitchItem_Auto_Update As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_Password_Change As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Account_Applications As DevExpress.XtraBars.BarButtonItem
    Private dashboardViewer As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents btn_Aging As DevExpress.XtraBars.BarButtonItem
    Private RibbonPage_Audit As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribbonPageGroup_Records As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Dashboard_Main As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Query As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Report_Designer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Report_Designer_Ribbon As DevExpress.XtraBars.BarButtonItem
    Private barMdiChildrenListItem As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents btn_Chart_Of_Accounts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xuc_Accounts As SagaClassLibrary.Controls.Information.Account.xuc_Accounts
    Friend WithEvents btn_Journal_Profiles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Month As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Day As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Today As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Vouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popup_Connection As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents btn_Connection_Connect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Connection_Test As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xuc_SQL_Connection As MyClassLibrary.Controls.Security.xuc_SQL_Connection
    Friend WithEvents btn_Account_Names As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Employees As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage_HRM As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_HR_Management As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Credit_Memo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage_Logistics As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_Logistic_Management As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Item_Colors As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPageGroup_Logistics_Parameters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup_Logistics_Inventory As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup_Customer_Sales As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_Printing_Detail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupControlContainer_Printing_Detail As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents xuc_Printing_Detail As SagaClassLibrary.Controls.Persons.xuc_Printing_Detail
    Friend WithEvents BarToggleSwitchItem_Notification As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents RibbonPageGroup_Database As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Banks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Check_Numbers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Adjustments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Chat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents xuc_Account_Search As SagaClassLibrary.Controls.Information.Account.xuc_Account_Search
    Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemPopupContainerEdit_Search As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents PopupContainerControl_Search As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents btn_Repossesed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Brands As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SMS_Configuration As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_SMS As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_SMS_Sender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupContainerControl_SMS_Config As DevExpress.XtraBars.PopupControlContainer
    'Friend WithEvents CtlSMSConfig As LC_SMS_3_3.ctlSMSConfig
    Friend WithEvents btn_Dashboard_Journal_Entries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Dashboards As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Add_Items As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Add_New As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_New_Check As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New_COA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New_Account_Name As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New_Voucher As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New_Journal_Entry As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Backup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdornerUIManager As DevExpress.Utils.VisualEffects.AdornerUIManager
    Friend WithEvents btn_Budgets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemtoggle_Balance_Type As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents btn_Journal_Vouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents search_Name As DevExpress.XtraEditors.SearchControl
    Friend WithEvents btn_Petty_Cash As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Error_Report As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Operations As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Petty_Cash_Profiles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Ticket_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Tickets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Support As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Ticket_Groups As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Accounting As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Petty_Cash_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarToggleSwitchItem_Check_Errors As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_New_Expense As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Purchase_Orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarToggleSwitchItem_Stack_Trace_Error As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents btn_MC_Transactions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Inclusions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Inclusion_Inventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Asset_Management As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Asset_Items As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinDropDownButtonItem As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents SkinPaletteDropDownButonItem As DevExpress.XtraBars.SkinPaletteDropDownButtonItem
    Friend WithEvents PopupMenu_Petty_Cash As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenu_Assets As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Asset_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
    Friend WithEvents btn_Payment_Requests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Payment_Request As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Payment_Request As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Promotion_Discounts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_System_Requests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_System_Request As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_System_Request As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Ticket As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Transmittals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Unit_Invoices As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageCategory_Accounting As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory_HR As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory2 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents btn_Salaries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Annual_Leave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Leave_Absences As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Attendance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Payroll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Pay_Checks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Helps As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MC_Requests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Schedule_Types As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Schedules As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Date_Branch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Date_Cut_Off As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Voucher As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Voucher_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Branch_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_MC_Request As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Wizard_New_MC_Request As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Purchase_Order As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Wizard_New_Purchase_Order As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu_Receiving_Transfer As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_Wizard_New_MC_Transaction As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarToggleSwitchItem_Edit_Advanced_Mode As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents PopupMenu_Release As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_MC_Sale_New As DevExpress.XtraBars.BarButtonItem
End Class

