Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports SagaClassLibrary.Forms
Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms

Partial Friend Class frm_Main
    Friend frm As frm_Main

    Sub New()
        If xuc_Account_Search Is Nothing Then
            xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
        End If

        InitializeComponent()

        class_Procedures.frm.Icon = Me.Icon
    End Sub

    Private Sub Form_main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Top = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Top", 50)
        Left = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Left", 50)
        Width = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Width", 800)
        Height = class_Tools.RegKeyGet(Me.Name, $"{Me.Name}_Height", 600)

        Me.Text = class_Functions.Product_Name_Version
        Bar_Unit_Version.Caption = Application.ProductVersion
        BarEditItem_Corporation.EditValue = class_Saga_Variables.sCorporation

        class_Saga_Variables.sBranchCode = class_Tools.RegKeyGet(Me.Name, barEditItem_Branch.Name, "000")
        barEditItem_Date_Start.EditValue = class_Tools.RegKeyGet(Me.Name, barEditItem_Date_Start.Name, Date.Today.ToString("MMMM dd, yyyy"))
        barEditItem_Date_End.EditValue = class_Tools.RegKeyGet(Me.Name, barEditItem_Date_End.Name, Date.Today.ToString("MMMM dd, yyyy"))

        class_Procedures.Initialize_gridView(Me, xuc_Account_Search.gridView)
        class_Procedures.Initialize_gridView(Me, xuc_Accounts.gridView)

        search_Name.Text = class_Tools.RegKeyGet(Me.Name, search_Name.Name, String.Empty)
        BarEditItem_Search.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Search.Name, String.Empty)

        DockManager.RestoreLayoutFromRegistry("Chat")

        BarToggleSwitchItem_Splash_Wait.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Splash_Wait.Name, True)
        BarToggleSwitchItem_Auto_Update.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Auto_Update.Name, False)
        BarToggleSwitchItem_Notification.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Notification.Name, False)
        BarToggleSwitchItem_Edit_Advanced_Mode.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Edit_Advanced_Mode.Name, False)
        BarToggleSwitchItem_Check_Errors.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Check_Errors.Name, False)
        BarToggleSwitchItem_Stack_Trace_Error.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Stack_Trace_Error.Name, False)

        popup_Connection.Width = class_Tools.RegKeyGet(Me.Name, $"{popup_Connection.Name}_Width", 300)
        popup_Connection.Height = class_Tools.RegKeyGet(Me.Name, $"{popup_Connection.Name}_Height", 500)
        popup_Account_Search.Width = class_Tools.RegKeyGet(Me.Name, $"{popup_Account_Search.Name}_Width", 300)
        popup_Account_Search.Height = class_Tools.RegKeyGet(Me.Name, $"{popup_Account_Search.Name}_Height", 200)
        PopupContainerControl_Search.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Search.Name}_Width", 500)
        PopupContainerControl_Search.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Search.Name}_Height", 300)
        PopupContainerControl_SMS_Config.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_SMS_Config.Name}_Width", 500)
        PopupContainerControl_SMS_Config.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_SMS_Config.Name}_Height", 400)
        PopupControlContainer_Printing_Detail.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Width", 300)
        PopupControlContainer_Printing_Detail.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Height", 300)
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Procedures.Initialize_Layout(xuc_Printing_Detail.layoutControl)
        class_Procedures.Initialize_Layout(xuc_SQL_Connection.layoutControl)

        Refresh_Connection()

        If BarToggleSwitchItem_Auto_Update.Checked Then class_Connections.Show_Update(False)

        Dim timer = New System.Timers.Timer With {
            .Interval = 2 * 60 * 1000
        }
        timer.Start()

        AddHandler timer.Elapsed, AddressOf OnTimedEvent

        class_Saga_Variables.bMainFormLoaded = True

        Initialize_Controls()

        If BarToggleSwitchItem_Check_Errors.Checked Then
            Initialize_Badges()
        End If

        BackgroundWorker_Run()
    End Sub

    Private Sub OnTimedEvent(source As Object, e As System.Timers.ElapsedEventArgs)
        class_Connections.Show_Update(False)
    End Sub

    Private Sub BackgroundWorker_Run()
        If Not BackgroundWorker.IsBusy Then
            BackgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        SkinRibbonGalleryBarItem.Enabled = False
        SkinPaletteRibbonGalleryBarItem.Enabled = False
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        SkinRibbonGalleryBarItem.Enabled = True
        SkinPaletteRibbonGalleryBarItem.Enabled = True
    End Sub

    Private Function main_Close(Optional ByVal bAsk As Boolean = True) As Boolean
        class_Saga_Database.bLoopStop = True

        class_Procedures.Set_Skin()

        If WindowState.Equals(FormWindowState.Normal) Then
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Top", Top)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Left", Left)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Width", Width)
            class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Height", Height)
        End If

        class_Tools.RegKeySet(Me.Name, barEditItem_Branch.Name, class_Saga_Variables.sBranchCode)
        class_Tools.RegKeySet(Me.Name, barEditItem_Date_Start.Name, barEditItem_Date_Start.EditValue.ToString)
        class_Tools.RegKeySet(Me.Name, barEditItem_Date_End.Name, barEditItem_Date_End.EditValue.ToString)

        DockManager.SaveLayoutToRegistry("Chat")

        class_Tools.RegKeySet(Me.Name, $"{popup_Connection.Name}_Width", popup_Connection.Width)
        class_Tools.RegKeySet(Me.Name, $"{popup_Connection.Name}_Height", popup_Connection.Height)
        class_Tools.RegKeySet(Me.Name, $"{popup_Account_Search.Name}_Width", popup_Account_Search.Width)
        class_Tools.RegKeySet(Me.Name, $"{popup_Account_Search.Name}_Height", popup_Account_Search.Height)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Search.Name}_Width", PopupContainerControl_Search.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Search.Name}_Height", PopupContainerControl_Search.Height)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_SMS_Config.Name}_Width", PopupContainerControl_SMS_Config.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_SMS_Config.Name}_Height", PopupContainerControl_SMS_Config.Height)
        class_Tools.RegKeySet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Width", PopupControlContainer_Printing_Detail.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupControlContainer_Printing_Detail.Name}_Height", PopupControlContainer_Printing_Detail.Height)

        'CtlSMSConfig.Control_Dispose()

        class_Tools.RegKeySet(Me.Name, "Corporation", class_Saga_Variables.sCorporation)

        Try
            class_Tools.RegKeySet(Me.Name, BarEditItem_Search.Name, BarEditItem_Search.EditValue.ToString)
        Catch ex As Exception

        End Try

        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Splash_Wait.Name, BarToggleSwitchItem_Splash_Wait.Checked)
        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Auto_Update.Name, BarToggleSwitchItem_Auto_Update.Checked)
        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Notification.Name, BarToggleSwitchItem_Notification.Checked)
        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Edit_Advanced_Mode.Name, BarToggleSwitchItem_Edit_Advanced_Mode.Checked)
        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Check_Errors.Name, BarToggleSwitchItem_Check_Errors.Checked)
        class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Stack_Trace_Error.Name, BarToggleSwitchItem_Stack_Trace_Error.Checked)

        Me.xuc_Account_Search.gridView.SaveLayoutToRegistry(xuc_Account_Search.Name)
        Me.xuc_Accounts.gridView.SaveLayoutToRegistry(xuc_Accounts.Name)

        If class_Procedures.Form_Close(Me, bAsk) Then
            If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users Set IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'") Then Application.Exit()
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btn_Quit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Quit.ItemClick
        main_Close()
    End Sub

    Private Sub Form_main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not main_Close() Then e.Cancel = True
    End Sub

    Friend Sub Initialize_User_Privileges()
        Refresh_Connection()

        RibbonPage_Accounting.Visible = False
        RibbonPage_Customers.Visible = False
        RibbonPage_Audit.Visible = False
        RibbonPage_Logistics.Visible = False
        RibbonPage_Spare_Parts.Visible = False
        RibbonPage_HRM.Visible = False
        RibbonPage_Administration.Visible = False

        RibbonPage_Administration.Visible = class_Variables.isAdministrator
        RibbonPage_HRM.Visible = class_Variables.isAdministrator

        RibbonPage_Accounting.Visible = class_Saga_Variables.isAccounting
        RibbonPage_Customers.Visible = class_Saga_Variables.isAccounting
        RibbonPage_Spare_Parts.Visible = class_Saga_Variables.isAccounting

        RibbonPage_Audit.Visible = class_Saga_Variables.isAudit
        RibbonPage_Logistics.Visible = class_Saga_Variables.isLogistics
    End Sub

    Private Sub BarEditItem_Corporation_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BarEditItem_Corporation.EditValueChanged
        'If class_saga_Variables.bMainFormLoaded Then
        '    Dim sCorporationOld As String = BarEditItem_Corporation.EditValue.ToString
        '    If Not class_Saga_Procedures.Show_Login("Change Corporation") Then
        '        BarEditItem_Corporation.EditValue = sCorporationOld
        '    End If
        '    BarEditItem_Corporation.EditValue = class_saga_Variables.sCorporation
        'End If
    End Sub

    Private Sub Initialize_Controls()
        'CtlSMSConfig.Control_Initialize()
        class_Procedures.Initialize_Controls(xuc_Printing_Detail)

        If class_Database.OpenDB(class_Database.ICSConnection) Then
            Me.xuc_SQL_Connection.registry_Load()
            'class_Saga_Variables.Initialize_Corporation()
            'class_Saga_Variables.Initialize_Corporation_All()
            class_Saga_Variables.Initialize_Branch()
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, lookUp_Branch, True)
            class_Saga_Variables.Initialize_Users()
            class_Saga_Variables.Initialize_MC()
            class_Saga_Variables.Initialize_COA()
            class_Saga_Variables.Initialize_COA_Summary()
            class_Saga_Variables.Initialize_COA_Detail()
            class_Saga_Variables.Initialize_COA_Bank()
            class_Saga_Variables.Initialize_Employee()
            'class_Saga_Variables.Initialize_Bank()
            class_Saga_Variables.Initialize_For_Liquidation()
            'class_Saga_Variables.Initialize_Budgets()

            'class_Saga_Variables.Initialize_Unit_Status()
            class_Saga_Variables.Initialize_Brands()
            class_Saga_Variables.Initialize_Model_Colors()
            'class_Saga_Variables.Initialize_Inclusions()

            class_Saga_Variables.Initialize_Asset_Items()
        End If
    End Sub

    Private Sub Initialize_Badges()
        Dim frm As Custom.frm_Error_Display = New Custom.frm_Error_Display() With {
            .MdiParent = Me,
            .Text = "Error Summaries",
            .TopMost = True
        }

        frm.Show()

        Dim iCount, iErrors As Integer

        If class_Saga_Variables.isAccounting Then
            'Checks
            iErrors = class_Saga_Database.get_Check_Errors
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Check_Numbers, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, iErrors)
            frm.Error_Cancelled_Checks.EditValue = iErrors
        End If

        If class_Saga_Variables.isAccounting Then
            'Accounts
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Customer_Accounts, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_Account_Errors)
        End If

        If class_Saga_Variables.isAccounting Then
            'Account Names
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Account_Names, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Blank_Names)
        End If

        If class_Saga_Variables.isAccounting Then
            'Expense
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Petty_Cash, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Expense_Status_Count("FOR APPROVAL"))
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Petty_Cash, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_Expense_Status_Count("FOR LIQUIDATION"))
        End If

        If class_Saga_Variables.isAccounting Then
            'Vouchers
            class_Saga_Variables.iUnliquidated = class_Procedures.Create_Badge(AdornerUIManager, btn_Vouchers, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Unliquidated)
            iCount += class_Saga_Variables.iUnliquidated
        End If

        If class_Saga_Variables.isAccounting Then
            'Sales Releases
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Releases, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_UnJounaled_Transactions("CustAccount", "DateGranted"))
        End If

        If class_Saga_Variables.isAccounting Then
            'Payment Collections
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Collections, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_IBC_Errors)
        End If

        If class_Saga_Variables.isAccounting Then
            'Credit Memo
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Credit_Memo, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_UnJounaled_Transactions("TransactionCM", "PostingDate"))
        End If

        If class_Saga_Variables.isAccounting Then
            'Journal Entries
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Journal_Entries, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_Journal_Unbalanced + class_Saga_Database.get_Journal_Cancelled)
        End If

        If class_Saga_Variables.isAccounting Then
            'Trial Balance
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Trial_Balance, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_Trial_Unbalanced)
        End If

        'Accounting
        class_Procedures.Create_Badge(AdornerUIManager, RibbonPage_Accounting, DevExpress.Utils.VisualEffects.BadgePaintStyle.Default, iCount)

        iCount = 0
        If class_Variables.isAdministrator Then
            'Inventory
            iCount += class_Procedures.Create_Badge(AdornerUIManager, btn_Inventory, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Journal_Unbalanced + class_Saga_Database.get_Multiple_Existing_Inventory)
        End If

        'Logistics
        class_Procedures.Create_Badge(AdornerUIManager, RibbonPage_Logistics, DevExpress.Utils.VisualEffects.BadgePaintStyle.Default, iCount)
    End Sub

    Private Sub btn_Initialize_Controls_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Initialize_Controls.ItemClick
        Initialize_Controls()
        Initialize_Badges()

        BackgroundWorker_Run()

        If class_Database.DBError Then
            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Global Data initialization Is Not complete.{Environment.NewLine}Please check your connection parameters And initialize again.")
        Else
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Global Data initialization is completed.", "Global Data Initialization", True)
        End If
    End Sub

    Private Sub BarToggleSwitchItem_Splash_Wait_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Splash_Wait.CheckedChanged
        class_Variables.bSplash = BarToggleSwitchItem_Splash_Wait.Checked
    End Sub

    Private Sub BarToggleSwitchItem_Notification_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Notification.CheckedChanged
        class_Variables.bNotifications = BarToggleSwitchItem_Notification.Checked
    End Sub

    Private Sub BarToggleSwitchItem_Edit_Advanced_Mode_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Edit_Advanced_Mode.CheckedChanged
        class_Variables.bEditAdvancedMode = BarToggleSwitchItem_Edit_Advanced_Mode.Checked
    End Sub

    Private Sub BarToggleSwitchItem_Stack_Trace_Error_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Stack_Trace_Error.CheckedChanged
        class_Variables.bStackError = BarToggleSwitchItem_Stack_Trace_Error.Checked
    End Sub

    Private Sub btn_Update_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Update.ItemClick
        class_Connections.Show_Update(True, True, True)
    End Sub

    Private Sub Bar_Unit_Version_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles Bar_Unit_Version.ItemDoubleClick
        class_Connections.Show_Update(False, True, True)
    End Sub

    Private Sub Bar_Branch_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditItem_Branch.EditValueChanged
        class_Saga_Variables.sBranchCode = barEditItem_Branch.EditValue.ToString

        Try
            class_Saga_Variables.dtCutOffDate = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Cut_Off_Date FROM BranchParameters WHERE BranchCode LIKE '{class_Saga_Variables.sBranchCode}'", "Cut_Off_Date"))
        Catch ex As Exception

        End Try

        class_Tools.RegKeySet(Me.Name, barEditItem_Branch.Name, class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub barEditItem_Date_Start_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditItem_Date_Start.EditValueChanged
        Try
            class_Saga_Variables.dtStart = Convert.ToDateTime(barEditItem_Date_Start.EditValue)
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub barEditItem_Date_End_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditItem_Date_End.EditValueChanged
        Try
            class_Saga_Variables.dtEnd = Convert.ToDateTime(barEditItem_Date_End.EditValue)
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub barEditItem_Date_Start_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barEditItem_Date_Start.ItemClick
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
    End Sub

    Private Sub barEditItem_Date_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles barEditItem_Date_Start.ItemDoubleClick
        Dim dtStart As Date
        Dim iDays As Integer = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iDays = -1

        dtStart = Convert.ToDateTime(barEditItem_Date_Start.EditValue).AddDays(iDays)
        If dtStart.DayOfWeek = DayOfWeek.Sunday Then dtStart = dtStart.AddDays(iDays)

        barEditItem_Date_Start.EditValue = dtStart
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(dtStart)
    End Sub

    Private Sub barEditItem_Date_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles barEditItem_Date_End.ItemDoubleClick
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_End.EditValue))
    End Sub

    Private Sub btn_Today_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Today.ItemClick
        barEditItem_Date_Start.EditValue = Date.Today
        barEditItem_Date_End.EditValue = Date.Today
    End Sub

    Private Sub set_Month()
        barEditItem_Date_Start.EditValue = class_Functions.FirstDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
        barEditItem_Date_End.EditValue = class_Functions.LastDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
    End Sub

    Private Sub btn_Day_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Day.ItemClick
        barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Month.ItemClick
        set_Month()
    End Sub

    Private Sub btn_Day_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles btn_Day.ItemDoubleClick
        barEditItem_Date_Start.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
        barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles btn_Month.ItemDoubleClick
        Dim iMonths As Int16 = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iMonths = -1

        barEditItem_Date_Start.EditValue = Convert.ToDateTime(barEditItem_Date_Start.EditValue).AddMonths(iMonths)
        set_Month()
    End Sub

    Private Sub Set_Branch_Date()
        Dim dtAssign As Date

        If My.Computer.Keyboard.ShiftKeyDown Then
            dtAssign = Date.Today
        Else
            dtAssign = class_Saga_Variables.dtStart
        End If

        If Not class_Database.Data_Save_Ask($"Set Branch Date to {dtAssign.ToShortDateString}") Then Return

        If barEditItem_Branch.EditValue.Equals("000") Then
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET DatabaseDate = '{dtAssign}'")
        Else
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET DatabaseDate = '{dtAssign}' WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}'")
        End If
        Branch_Reload()
    End Sub

    Private Sub Branch_Reload()
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, lookUp_Branch, True)
    End Sub

    Private Sub Bar_Branch_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles barEditItem_Branch.ItemDoubleClick
        Set_Branch_Date()
    End Sub

    Private Sub btn_Branch_Reload_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Branch_Reload.ItemClick
        Branch_Reload()
    End Sub

    Private Sub btn_Date_Branch_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Date_Branch.ItemClick
        'Set_Branch_Date()
        Dim sBranchBackDateRequestSQL As String

        If Not class_Saga_Variables.sBranchCode.Equals("000") Then
            sBranchBackDateRequestSQL = $"AND BranchCode LIKE '{class_Saga_Variables.sBranchCode}'"
        Else
            sBranchBackDateRequestSQL = String.Empty
        End If

        Dim dtBranchDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, DatabaseDate FROM BranchParameters WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}'", "DatabaseDate"))
        Dim iDays As Integer = (Date.Today - dtBranchDate).Days

        If iDays > 2 Then class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Requested Branch Date has {iDays} days interval.", "Days Interval", True)

        If class_Procedures.actionAsk("Back Date Request", $"Approve Back Date Request", "Please inform Branch Personnel that their Back Date Request has been approved.") Then
            If class_Database.Data_Update(class_Database.ICSConnection,
                                          "UPDATE BranchParameters " +
                                            $"SET Back_Date_Status = 'BACK_DATE_APPROVED', " +
                                            $"DatabaseDate = Back_Date, " +
                                            $"Modified_By = '{class_Variables.sUserName}', " +
                                            $"Modified_Date = '{DateTime.Now}' " +
                                            $"WHERE Back_Date_Status LIKE 'BACK_DATE_REQUEST' {sBranchBackDateRequestSQL}") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Back Date Request has been Approved.{Environment.NewLine}Please inform Branch Personnel that their Back Date Request has been approved.", "Back Date Request", True)
                Branch_Reload()
            End If
        End If
    End Sub

    Private Sub btn_Date_Cut_Off_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Date_Cut_Off.ItemClick
        If Not class_Database.Data_Save_Ask($"Set Branch Cut-Off Date to {class_Saga_Variables.dtStart.ToShortDateString}") Then Return

        If barEditItem_Branch.EditValue.Equals("000") Then
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET Cut_Off_Date = '{class_Saga_Variables.dtEnd}'")
        Else
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET Cut_Off_Date = '{class_Saga_Variables.dtEnd}' WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}'")
        End If

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, lookUp_Branch, True)

        class_Saga_Variables.dtCutOffDate = class_Saga_Variables.dtStart
    End Sub

    Private Sub RepositoryItemPopupContainerEdit_Search_BeforePopup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit_Search.BeforePopup
        PopupContainerControl_Search.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Search}_Width", 500)
        PopupContainerControl_Search.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Search}_Height", 400)
    End Sub

    Private Sub RepositoryItemPopupContainerEdit_Search_Popup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit_Search.Popup
        xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
        xuc_Account_Search.Load_Search((CType(sender, BaseEdit)).Text.Trim)
    End Sub

    Private Sub RepositoryItemPopupContainerEdit_Search_Closed(sender As Object, e As ClosedEventArgs) Handles RepositoryItemPopupContainerEdit_Search.Closed
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Search}_Width", PopupContainerControl_Search.Width)
        class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Search}_Height", PopupContainerControl_Search.Height)

        'BarEditItem_Search.EditValue = xuc_Account_Search.AccountName
    End Sub

    Private Sub btn_Server_Connection_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Server_Connection.ItemClick
        class_Saga_Procedures.Show_Server_Connection("SQL Configuration")
    End Sub

    Private Sub Refresh_Connection()
        BarEditItem_Corporation.EditValue = class_Saga_Variables.sCorporation
        BarEditItem_Corporation.Enabled = False

        Bar_User_Name.Caption = $"User: {class_Variables.sUserName}"
        Bar_User_Position.Caption = $"Position: {class_Variables.sPosition}"
        Bar_IP_Server.Caption = $"Server IP: {class_Functions.maskString(class_Database.SqlServer, 3, 2)}"
        Bar_IP_Local.Caption = $"Local IP: {class_Functions.maskString(class_Variables.sLocal_IP, 3, 2)}"
    End Sub

    Private Sub btn_Server_Refresh_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Server_Refresh.ItemClick
        If class_Saga_Procedures.Refresh_Connection() Then
            Refresh_Connection()
        Else
            Show_Server_Connection()
        End If
    End Sub

    Private Sub btn_Server_Ping_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Server_Ping.ItemClick
        If class_Database.SqlServer IsNot "(local)" Then
            class_Connections.check_Host(class_Database.SqlServer)
        Else
            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "You are Not yet connected to remote server. Please set the connection parameters And test the connection.")
        End If
    End Sub

    Private Sub btn_Server_Ping_Monitor_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Server_Ping_Monitor.ItemClick
        Dim sHost As String

        If BarToggleSwitchItem_Host.Checked Then
            sHost = barEdit_Host.EditValue.ToString
        Else
            sHost = class_Database.SqlServer
        End If

        If BarToggleSwitchItem_Continous.Checked Then
            class_Connections.ping_Host(sHost, True)
        Else
            class_Connections.ping_Host(sHost, False)
        End If
    End Sub

    Private Sub Label_bar_IP_Server_ItemDoubleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles Bar_IP_Server.ItemDoubleClick
        If class_Saga_Procedures.Show_Server_Connection("SQL Configuration") Then
            Refresh_Connection()
        End If
    End Sub

    Private Sub Label_bar_IP_Local_ItemDoubleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles Bar_IP_Local.ItemDoubleClick
        If class_Connections.Initialize_IP(class_Database.SqlServer) Then
            Bar_IP_Local.Caption = $"Local IP: {class_Variables.sLocal_IP}"
            class_Procedures.Copy_Clipboard(class_Variables.sLocal_IP)
        End If
    End Sub

    Private Sub btn_Password_Change_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Password_Change.ItemClick
        class_Saga_Procedures.Show_Password_Change(class_Saga_Variables.sCorporation, class_Variables.sUserName, True)
    End Sub

    Private Sub btn_User_Login_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_User_Login.ItemClick
        If class_Saga_Procedures.Show_Login("Login User") Then
            Initialize_User_Privileges()
        End If
    End Sub

    Private Sub btn_User_Change_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_User_Change.ItemClick, Bar_User_Name.ItemClick
        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'")
        If class_Saga_Procedures.Show_Login("Change User") Then
            Initialize_User_Privileges()
        End If
    End Sub

    Private Sub bar_User_Name_ItemDoubleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles Bar_User_Name.ItemDoubleClick
        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'")
        If class_Saga_Procedures.Show_Login("Change User") Then
            Initialize_User_Privileges()
        End If
    End Sub

    Private Sub btn_User_Lock_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_User_Lock.ItemClick
        class_Saga_Variables.bIsLogged_In = False
        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'")
        class_Saga_Procedures.Show_Login("Unlock User")
    End Sub

    Private Sub btn_Report_Designer_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Report_Designer.ItemClick

    End Sub

    Private Sub btn_Report_Designer_Ribbon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Report_Designer_Ribbon.ItemClick

    End Sub

    Private Sub btn_Connection_Test_Click(sender As Object, e As EventArgs) Handles btn_Connection_Test.Click
        xuc_SQL_Connection.connect_Server_Test()
    End Sub

    Private Sub btn_Connection_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connection_Connect.Click
        xuc_SQL_Connection.connect_Server()
    End Sub

    Private Sub search_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles search_Name.KeyDown
        If search_Name.Text.Length > 2 Then
            Select Case e.KeyCode
                Case Keys.Enter
                    xuc_Accounts.Load_Search(search_Name.Text)
                    search_Name.Select()
            End Select

        End If
    End Sub

    Private Sub search_Name_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles search_Name.ButtonClick
        Select Case e.Button.Index
            Case 1
                xuc_Accounts.Load_Search(search_Name.Text)
                search_Name.Select()
        End Select
    End Sub

    Private Sub btn_New_Account_Name_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Account_Name.ItemClick
        class_Saga_Procedures.Show_Account_Name(String.Empty, True)
    End Sub

    Private Sub btn_New_Check_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Check.ItemClick
        class_Saga_Procedures.Show_Check(String.Empty, True)
    End Sub

    Private Sub btn_New_COA_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_COA.ItemClick
        class_Saga_Procedures.Show_COA(String.Empty, True)
    End Sub

    Private Sub btn_New_Voucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Voucher.ItemClick
        class_Saga_Procedures.Show_Voucher(String.Empty, True,class_saga_variables.eVoucherType.Check, sBranchCode)
    End Sub

    Private Sub btn_New_Expense_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Expense.ItemClick
        class_Saga_Procedures.Show_Voucher(String.Empty, True,class_saga_variables.eVoucherType.Expense, sBranchCode)
    End Sub

    Private Sub btn_New_Journal_Entry_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Journal_Entry.ItemClick
        class_Saga_Procedures.Show_Journal_Entry(String.Empty, True)
    End Sub

    Private Sub btn_Branches_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Branches.ItemClick
        Dim frm As New Management.frm_Branches()
        class_Procedures.Show_Form(Me, frm, "Branches")
    End Sub

    Private Sub btn_Ticket_Groups_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Ticket_Groups.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Ticket_Groups()
        class_Procedures.Show_Form(Me, frm, "Ticket/Incident Group Management")
    End Sub

    Private Sub btn_Ticket_New_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Ticket_New.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Ticket()
        class_Procedures.Show_Form(Me, frm, "New Ticket/Incident Report", False)
        frm.xuc_Ticket.Control_Initialize()
        frm.xuc_Ticket.Control_New(False)
    End Sub

    Private Sub btn_Helps_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Helps.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Helps()
        class_Procedures.Show_Form(Me, frm, "FAQs and Help List")
    End Sub

    Private Sub btn_Tickets_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Tickets.ItemClick
        Dim frm As New SagaSupport.Forms.frm_Tickets()
        class_Procedures.Show_Form(Me, frm, "Tickets/Incidents List")
    End Sub

    Private Sub btn_Payment_Request_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Payment_Request.ItemClick
        Dim frm As New Accounting.frm_Payment_Request()
        class_Procedures.Show_Form(Me, frm, "Payment Request", False)
        frm.xuc_Payment_Request.Control_Initialize()
        frm.xuc_Payment_Request.Control_New(False)
    End Sub

    Private Sub btn_Payment_Requests_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Payment_Requests.ItemClick
        Dim frm As New Accounting.frm_Payment_Requests()
        class_Procedures.Show_Form(Me, frm, "Payment Requests")
    End Sub

    Private Sub btn_System_Requests_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_System_Requests.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Requests()
        class_Procedures.Show_Form(Me, frm, "System Requests")
    End Sub

    Private Sub btn_Transmittals_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Transmittals.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Transmittal()
        class_Procedures.Show_Form(Me, frm, "System Transmittals")
    End Sub

    Private Sub btn_System_Request_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_System_Request.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Request()
        class_Procedures.Show_Form(Me, frm, "System Request", False)
    End Sub

    Private Sub btn_Query_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Query.ItemClick
        Dim frm As New Custom.frm_Custom_Query()
        class_Procedures.Show_Form(Me, frm, "Database Query Form")
    End Sub

    Private Sub btn_Backup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Backup.ItemClick
        Dim saveDialog As New XtraSaveFileDialog
        With saveDialog
            .Title = "Database Backup"
            .Filter = "Backup Files (*.bak)|*.bak"
            .OverwritePrompt = True
            .FileName = Date.Today.ToString("MMM dd yyyy")

            If saveDialog.ShowDialog.Equals(DialogResult.OK) Then
                Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                    Using MyCommand As SqlCommand = New SqlCommand($"BACKUP DATABASE {class_Database.SqlDatabase} TO DISK = N'{ .FileName}' WITH COPY_ONLY", MySQLConnection)
                        Try
                            class_Procedures.splash_Show($"Saving Database",, True)
                            MySQLConnection.Open()
                            MyCommand.ExecuteNonQuery()
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        Finally
                            class_Procedures.splash_Close(True)
                        End Try
                    End Using
                End Using
            End If
        End With
    End Sub

    Private Sub btn_Brands_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Brands.ItemClick
        Dim frm As New Information.Item.frm_Brands()
        class_Procedures.Show_Form(Me, frm, "Brand and Suppliers")
    End Sub

    Private Sub btn_Models_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Models.ItemClick
        Dim frm As New Information.Item.frm_Unit_Models
        class_Procedures.Show_Form(Me, frm, "Unit Models")
    End Sub

    Private Sub btn_Item_Colors_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Item_Colors.ItemClick
        Dim frm As New Information.Item.frm_Unit_Colors()
        class_Procedures.Show_Form(Me, frm, "Unit Colors")
    End Sub

    Private Sub btn_Inclusions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Inclusions.ItemClick
        Dim frm As New Logistics.frm_Inclusions()
        class_Procedures.Show_Form(Me, frm, "Unit Inclusions")
    End Sub

    Private Sub btn_MC_Requests_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MC_Requests.ItemClick
        Dim frm As New Logistics.frm_MC_Requests()
        class_Procedures.Show_Form(Me, frm, "MC Requests and Orders")
    End Sub

    Private Sub btn_Wizard_New_MC_Request_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_MC_Request.ItemClick
        Dim frm As New Logistics.wzFrm_MC_Request()
        class_Procedures.Show_Form(Me, frm, "MC Requests and Orders", False)
    End Sub

    Private Sub btn_Purchase_Orders_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Purchase_Orders.ItemClick
        Dim frm As New Logistics.frm_Purchase_Orders()
        class_Procedures.Show_Form(Me, frm, "Purchase Orders")
    End Sub

    Private Sub btn_Wizard_New_Purchase_Order_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_Purchase_Order.ItemClick
        Dim frm As New Logistics.wzFrm_Purchase_Order()
        class_Procedures.Show_Form(Me, frm, "Purchase Orders", False)
    End Sub

    Private Sub btn_Unit_Invoices_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Unit_Invoices.ItemClick
        Dim frm As New Logistics.frm_Unit_Invoices()
        class_Procedures.Show_Form(Me, frm, "MC Unit Invoices")
    End Sub

    Private Sub btn_MC_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MC_Transactions.ItemClick
        Dim frm As New Logistics.frm_MC_Transactions()
        class_Procedures.Show_Form(Me, frm, "Receiving and Transports")
    End Sub

    Private Sub btn_Wizard_New_MC_Transaction_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Wizard_New_MC_Transaction.ItemClick
        Dim frm As New Logistics.wzFrm_MC_Transaction()
        class_Procedures.Show_Form(Me, frm, "Receiving and Transports", False)
    End Sub

    Private Sub btn_Inclusion_Inventory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Inclusion_Inventory.ItemClick
        Dim frm As New Logistics.frm_Inclusion_Inventory()
        class_Procedures.Show_Form(Me, frm, "Inclusion Inventory")
    End Sub

    Private Sub btn_Spare_Parts_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Spare_Parts.ItemClick
        Dim frm As New SagaSpareParts.Forms.frm_Spare_Parts
        class_Procedures.Show_Form(Me, frm, "Spare Parts")
    End Sub

    Private Sub btn_Spare_Part_Costing_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Spare_Part_Costing.ItemClick
        Dim frm As New SagaSpareParts.Forms.frm_Spare_Parts_Costing
        class_Procedures.Show_Form(Me, frm, "Spare Parts Costing")
    End Sub

    Private Sub btn_SPA_Inventory_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_SPA_Inventory.ItemClick
        Dim frm As New SagaSpareParts.Forms.frm_SPA_Inventory()
        class_Procedures.Show_Form(Me, frm, "Spare Parts Inventory")
    End Sub

    Private Sub btn_Spare_Part_Sales_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Spare_Part_Sales.ItemClick
        'Dim frm As New SPA.frm_SPA_Sales
        'class_Procedures.Show_Form(Me, frm, "SPA Sales")

        Dim frm As New BranchAccounting.Forms.frm_SPA_Sale()
        class_Procedures.Show_Form(Me, frm, "SPA Sales")
    End Sub

    Private Sub btn_Server_IP_Access_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Server_IP_Access.ItemClick
        Dim frm As New frm_IP_Address()
        class_Procedures.Show_Form(Me, frm, "IP Access")
    End Sub

    Private Sub btn_Users_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Users.ItemClick
        Dim frm As New Persons.frm_Users
        class_Procedures.Show_Form(Me, frm, "Application Users")
    End Sub

    Private Sub btn_Account_Executives_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Account_Executives.ItemClick
        Dim frm As New Persons.frm_Account_Executives()
        class_Procedures.Show_Form(Me, frm, "Account Executives")
    End Sub

    Private Sub btn_Agents_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Info_Centers.ItemClick, btn_Agents.ItemClick
        Dim frm As New Persons.frm_Agents()
        class_Procedures.Show_Form(Me, frm, "Information Centers and Agents")
    End Sub

    Private Sub btn_Customer_Migration_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Customer_Migration.ItemClick
        Dim frm As New Information.Account.frm_Account()
        class_Procedures.Show_Form(Me, frm, "Customer Migration Form", False)
    End Sub

    Private Sub btn_Customers_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Customers.ItemClick
        Dim frm As New Persons.frm_Customers
        class_Procedures.Show_Form(Me, frm, "Customers")
    End Sub

    Private Sub btn_Customer_Accounts_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Customer_Accounts.ItemClick
        Dim frm As New Information.Account.frm_Accounts()
        class_Procedures.Show_Form(Me, frm, "Customer Accounts")
    End Sub

    Private Sub btn_Account_Applications_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Account_Applications.ItemClick
        Dim frm As New Information.Account.frm_Account_Applications()
        class_Procedures.Show_Form(Me, frm, "Account Applications")
    End Sub

    Private Sub btn_Aging_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Aging.ItemClick
        Dim frm As New Forms.Operations.frm_Aging()
        class_Procedures.Show_Form(Me, frm, "Account Collection Aging")
    End Sub

    Private Sub btn_Error_Report_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Error_Report.ItemClick
        Dim frm As New SagaClassLibrary.Forms.Custom.frm_Error_Reports()
        class_Procedures.Show_Form(Me, frm, "Error Reports")
    End Sub

    Private Sub btn_Banks_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Banks.ItemClick
        Dim frm As New Accounting.frm_Bank_Accounts()
        class_Procedures.Show_Form(Me, frm, "Bank Accounts")
    End Sub

    Private Sub btn_Check_Numbers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Check_Numbers.ItemClick
        Dim frm As New Accounting.frm_Check_Numbers()
        class_Procedures.Show_Form(Me, frm, "Check Management")
    End Sub

    Private Sub btn_Budgets_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Budgets.ItemClick
        Dim frm As New Accounting.frm_Budgets()
        class_Procedures.Show_Form(Me, frm, "Budgets")
    End Sub

    Private Sub btn_Chart_Of_Accounts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Chart_Of_Accounts.ItemClick
        Dim frm As New Accounting.frm_Chart_Of_Accounts()
        class_Procedures.Show_Form(Me, frm, "Chart of Accounts")
    End Sub

    Private Sub btn_Account_Names_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Account_Names.ItemClick, btn_Suppliers.ItemClick
        Dim frm As New Persons.frm_Account_Names()
        class_Procedures.Show_Form(Me, frm, "Account Names")
    End Sub

    Private Sub btn_Journal_Profiles_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Profiles.ItemClick
        Dim frm As New Accounting.frm_Journal_Profiles()
        class_Procedures.Show_Form(Me, frm, "Journal Profiles")
    End Sub

    Private Sub btn_Vouchers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Vouchers.ItemClick
        Dim frm As New Accounting.frm_Vouchers() With {
            .voucherType =class_saga_variables.eVoucherType.Check
            }
        class_Procedures.Show_Form(Me, frm, "Cash/Check Vouchers")
    End Sub

    Private Sub btn_Voucher_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Voucher_New.ItemClick
        Dim wzform As New Accounting.wzFrm_Cash_Check_Voucher()

        With wzform
            .Show()
        End With
    End Sub

    Private Sub btn_Journal_Vouchers_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Journal_Vouchers.ItemClick
        'Dim frm As New Accounting.frm_Vouchers() With {
        '    .voucherType =class_saga_variables.eVoucherType.Journal
        '    }
        'class_Procedures.Show_Form(Me, frm, "Journal Vouchers")
    End Sub

    Private Sub btn_Journal_Entries_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
        Dim frm As New Accounting.frm_Journal_Entries() With {
        .eLoadType = class_Saga_Variables.eLoad_Type.Range,
        .bInitialize = True
        }
        class_Procedures.Show_Form(Me, frm, "Journal Entries")
    End Sub

    Private Sub btn_Trial_Balance_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Trial_Balance.ItemClick
        Dim frm As New Accounting.frm_Trial_Balance()
        class_Procedures.Show_Form(Me, frm, "Trial Balances")
    End Sub

    Private Sub btn_MC_Sale_New_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_MC_Sale_New.ItemClick
        'Dim frm As New Information.Account.frm_Account()
        'class_Procedures.Show_Form(Me, frm, "New MC Sale", False)
        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.CIF, "NEW",, "New MC Sale", True)
    End Sub

    Private Sub btn_Releases_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Releases.ItemClick
        Dim frm As New Accounting.frm_Releases()
        class_Procedures.Show_Form(Me, frm, "Releases")
    End Sub

    Private Sub btn_Batch_Transactions_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Collections.ItemClick
        Dim frm As New Accounting.frm_Collections()
        class_Procedures.Show_Form(Me, frm, "Date Range Collections")
    End Sub

    Private Sub btn_Promotion_Discounts_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Promotion_Discounts.ItemClick
        Dim frm As New Accounting.frm_MC_Promotions()
        class_Procedures.Show_Form(Me, frm, "Promotions and Discounts Management")
    End Sub

    Private Sub btn_Petty_Cash_Profiles_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Petty_Cash_Profiles.ItemClick
        Dim frm As New Petty_Cash.frm_Petty_Cash_Transactions_Profiles()
        class_Procedures.Show_Form(Me, frm, "Petty Cash Profiles Management")
    End Sub

    Private Sub btn_Petty_Cash_New_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Petty_Cash_New.ItemClick
        Dim frm As New Petty_Cash.frm_Expense_Entry
        class_Procedures.Show_Form(Me, frm, "New Expense", False)
        With frm.xuc_Expense
            .Branch_Code.EditValue = class_Saga_Variables.sBranchCode
            .Control_Initialize()
        End With
    End Sub

    Private Sub btn_Petty_Cash_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Petty_Cash.ItemClick
        Dim frm As New Petty_Cash.frm_Petty_Cash_Transactions()
        class_Procedures.Show_Form(Me, frm, "Petty Cash Transactions")
    End Sub

    Private Sub btn_Credit_Memo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Credit_Memo.ItemClick
        Dim frm As New Accounting.frm_Credit_Memo()
        class_Procedures.Show_Form(Me, frm, "Credit Memo")
    End Sub

    Private Sub btn_Repossesed_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Repossesed.ItemClick
        Dim frm As New Accounting.frm_Reposssesed()
        class_Procedures.Show_Form(Me, frm, "Repossesed (DEPO to REPO)")
    End Sub

    Private Sub btn_Inventory_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Inventory.ItemClick
        Dim frm As New Logistics.frm_Unit_Inventory()
        class_Procedures.Show_Form(Me, frm, "Product Inventory")
    End Sub

    Private Sub btn_SMS_Configuration_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SMS_Configuration.ItemClick
        'Dim frm As New ctlSMSConfig()
        'class_Procedures.Show_Form(Me, frm, "SMS Configuration")
    End Sub

    Private Sub btn_SMS_Sender_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SMS_Sender.ItemClick
        'Dim frm As New LC_SMS_3_3.frmSMS_Sender
        'class_Procedures.Show_Form(Me, frm, "SMS Sender", False)
        'Class_SMS.Show_Sender()
    End Sub

    Private Sub btn_Dashboard_Journal_Entries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Dashboard_Journal_Entries.ItemClick
        'Dim xForm As Dashboard_Viewer()
        'Dim dbViewer = New DashboardViewer

        'dbViewer.DashboardSource = GetType(SagaAccounting.Win_Dashboards.Dashboard_Journal)

        'class_Database.BindData(class_database.ICSConnection, dbViewer.Dashboard, dbViewer.DashboardSource, $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Posting_Date >= {class_Saga_Variables.dtStart} AND Posting_Date <= {class_Saga_Variables.dtEnd}", "view_Journal_Entries")
        'Show_Form(xForm, "Dashboard Designer")
    End Sub

    Private Sub btn_Employees_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Employees.ItemClick
        Dim frm As New SAGAhr.Forms.frm_Employees()
        class_Procedures.Show_Form(Me, frm, "Employees")
    End Sub

    Private Sub btn_Adjustments_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Adjustments.ItemClick
        Dim frm As New SagaHR.Forms.frm_Adjustments()
        class_Procedures.Show_Form(Me, frm, "Additionals and Deductions")
    End Sub

    Private Sub btn_Leave_Absences_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Leave_Absences.ItemClick
        Dim frm As New SagaHR.Forms.frm_Leaves()
        class_Procedures.Show_Form(Me, frm, "Leaves and Absenses")
    End Sub

    Private Sub btn_Salaries_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Salaries.ItemClick
        Dim frm As New SagaHR.Forms.frm_Salaries()
        class_Procedures.Show_Form(Me, frm, "Employee Salaries")
    End Sub

    Private Sub btn_Schedule_Types_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Schedule_Types.ItemClick
        Dim frm As New SagaHR.Forms.frm_Schedule_Types()
        class_Procedures.Show_Form(Me, frm, "Schedule Types")
    End Sub

    Private Sub btn_Schedules_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Schedules.ItemClick
        Dim frm As New SagaHR.Forms.frm_Schedule_Types()
        class_Procedures.Show_Form(Me, frm, "Schedule Types")
    End Sub

    Private Sub btn_Payroll_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Payroll.ItemClick
        Dim frm As New SagaHR.Forms.frm_Payrolls()
        class_Procedures.Show_Form(Me, frm, "Payroll Management")
    End Sub

    Private Sub btn_Pay_Checks_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Pay_Checks.ItemClick
        Dim frm As New SagaHR.Forms.frm_Pay_Checks()
        class_Procedures.Show_Form(Me, frm, "Payroll Pay Checks")
    End Sub

    Private Sub btn_Asset_New_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Asset_New.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Asset()
        class_Procedures.Show_Form(Me, frm, "New Asset Item", False)
        frm.xuc_Asset.Control_New()
    End Sub

    Private Sub btn_Asset_Items_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btn_Asset_Items.ItemClick
        Dim frm As New SagaAssets.Forms.frm_Assets()
        class_Procedures.Show_Form(Me, frm, "Assets Management")
    End Sub

End Class