Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports MyClassLibrary.Classes.class_Procedures
Imports SagaClassLibrary.Classes
Imports SagaSpareParts.Forms
Imports SagaSpareParts.SagaSpareParts

Partial Public Class Form_Main

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, BtnCancel)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        main_Close()
    End Sub

    Private Function main_Close() As Boolean
        If class_Procedures.Form_Close(Me, True) Then
            Application.Exit()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Database.Initialize_Connection()

        Me.Text = class_Functions.Product_Name_Version
        BarEditItem_Corporation.EditValue = class_Saga_Variables.sCorporation

        class_Saga_Variables.sBranchCode = class_Tools.RegKeyGet(Me.Name, BarEditItem_Branch.Name, "000")
        barEditItem_Date_Start.EditValue = class_Tools.RegKeyGet(Me.Name, barEditItem_Date_Start.Name, DateTime.Today.ToString("MMMM dd, yyyy"))
        barEditItem_Date_End.EditValue = class_Tools.RegKeyGet(Me.Name, barEditItem_Date_End.Name, DateTime.Today.ToString("MMMM dd, yyyy"))
    End Sub

    Private Sub Form_Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Text = class_Functions.Product_Name_Version
        BarStaticItem_App_Version.Caption = Application.ProductVersion

        BarStaticItem_Username.Caption = $"User: {class_Variables.sUserName}"
        BarStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}"
        BarStaticItem_Server_IP.Caption = $"Server IP: {class_Database.SqlServer}"
        BarStaticItem_Local_IP.Caption = $"Local IP: {class_Variables.sLocal_IP}"

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)
        BarEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
        BarEditItem_Branch.Enabled = BarEditItem_Branch.EditValue.Equals("000")
        class_Saga_Variables.Initialize_Users()
        Initialize_Badges()
        btn_SPA_Purchase_Order.Enabled = BarEditItem_Branch.EditValue.Equals("000")
        btn_SPA_Receiving.Enabled = BarEditItem_Branch.EditValue.Equals("000") Or BarEditItem_Branch.EditValue.Equals("001") Or BarEditItem_Branch.EditValue.Equals("006") Or BarEditItem_Branch.EditValue.Equals("008") Or BarEditItem_Branch.EditValue.Equals("014") Or BarEditItem_Branch.EditValue.Equals("016") Or BarEditItem_Branch.EditValue.Equals("018")
    End Sub
    Private Sub Initialize_Badges()
        Dim iCount As Integer

        iCount += Create_Badge(AdornerUIManager, btn_SPA_Purchase_Order, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, get_Approved_PO)

        'iCount += Create_Badge(AdornerUIManager, btn_SPA_Receiving, DevExpress.Utils.VisualEffects.BadgePaintStyle.Critical, class_Saga_Database.get_Approved_Received)

        'iCount += Create_Badge(AdornerUIManager, btn_SPA_Transfer, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Approved_Transfers(class_Saga_Variables.sBranchCode))

        'iCount += Create_Badge(AdornerUIManager, btn_SRF, DevExpress.Utils.VisualEffects.BadgePaintStyle.Warning, class_Saga_Database.get_Approved_SRF)
    End Sub
    Private Sub Form_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not main_Close() Then e.Cancel = True
    End Sub

    Private Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String, Optional ByVal bChild As Boolean = True)
        class_Procedures.splash_Show(sTitle, , True, xFormMode.xForm)
        Try
            xFrm.Icon = Me.Icon
            xFrm.Text = sTitle
            If bChild Then xFrm.MdiParent = Me
            xFrm.Show()
        Catch ex As Exception

        End Try
        class_Procedures.splash_Close(True)
    End Sub

    Private Sub BarEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem_Branch.EditValueChanged
        class_Saga_Variables.sBranchCode = BarEditItem_Branch.EditValue.ToString
        class_Tools.RegKeySet(Me.Name, BarEditItem_Branch.Name, class_Saga_Variables.sBranchCode)
        Initialize_Badges()
    End Sub

    Private Sub btn_Change_User_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Change_User.ItemClick
        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'")
        If class_Saga_Procedures.Show_Login("Change User") Then
            Initialize_User_Privileges()
        End If
    End Sub

    Friend Sub Initialize_User_Privileges()
        BarEditItem_Corporation.EditValue = class_Saga_Variables.sCorporation
        BarEditItem_Corporation.Enabled = False

        BarStaticItem_Username.Caption = $"User: {class_Variables.sUserName}"
        BarStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}"
    End Sub

    Private Sub btn_Requests_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Requests.ItemClick
        'Dim xxfrm = New Forms.Frm_Requests
        'Show_Form(xxfrm, "System Requests")
    End Sub

    Private Sub Show_Request(ByVal sType As String)
        'Dim xxfrm = New Forms.Frm_Request
        'Show_Form(xxfrm, $"Request - New {sType}", False)

        'xxfrm.Bar_Actions.Visible = True
        'xxfrm.Bar_Approval.Visible = False

        'xxfrm.Xuc_Request.Request_Type.Text = sType
        'xxfrm.Xuc_Request.Control_Initialize()
        'xxfrm.Xuc_Request.Control_New(False)
    End Sub

    Private Sub btn_Request_Motorcycle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Request_Motorcycle.ItemClick
        Show_Request("MOTORCYCLE")
    End Sub

    Private Sub btn_Request_Stocks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Request_Stocks.ItemClick
        Show_Request("STOCKS")
    End Sub

    Private Sub btn_Request_Payment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Request_Payment.ItemClick
        Show_Request("PAYMENT")
    End Sub

    Private Sub btn_SPA_Purchase_Order_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SPA_Purchase_Order.ItemClick
        Dim xxfrm = New frm_SPA_Purchase_Orders
        Show_Form(xxfrm, "Spare Parts Purchase Orders")
    End Sub

    Private Sub btn_SPA_Receiving_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SPA_Receiving.ItemClick
        Dim xxfrm = New frm_SPA_Receiving_Orders
        Show_Form(xxfrm, "Spare Parts Receiving Orders")
    End Sub

    Private Sub btn_SPA_Transfer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SPA_Transfer.ItemClick
        Dim xxfrm = New frm_SPA_Transfers
        Show_Form(xxfrm, "Spare Parts Transfer")
    End Sub

    Private Sub btn_SRF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SRF.ItemClick
        Dim xxfrm = New frm_SPA_SRF
        Show_Form(xxfrm, "Stock Replinishment Form")
    End Sub

    Private Sub BarButton_Sales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButton_Sales.ItemClick
        Dim xfrm As SPA_Sales = New SPA_Sales()
        class_Procedures.Show_Form(Me, xfrm, "SALES", False)
    End Sub

    Private Sub BarButtonItem_ErrorCorrect_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_ErrorCorrect.ItemClick
        Dim xfrm As SPA_ErrorCorrect = New SPA_ErrorCorrect()
        class_Procedures.Show_Form(Me, xfrm, "Error Correct", False)
    End Sub

    Private Sub BarButtonItem_CustDeposit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_CustDeposit.ItemClick
        Dim xfrm As SPA_CustDep = New SPA_CustDep()
        class_Procedures.Show_Form(Me, xfrm, "Custemer Deposit", False)
    End Sub

    Private Sub BarButtonItem_CustDep_Report_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_CustDep_Report.ItemClick
        Dim xfrm As SPA_ShowDueCustDep = New SPA_ShowDueCustDep()
        class_Procedures.Show_Form(Me, xfrm, "Custemer Deposit Due Reports")
    End Sub

    Private Sub BarButtonItem_SPA_Collection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_SPA_Collection.ItemClick
        Dim xfrm As SPA_Search_Sales_Inquiry = New SPA_Search_Sales_Inquiry()
        class_Procedures.Show_Form(Me, xfrm, "Search Sales Collection", False)
    End Sub

    Private Sub BarButtonItem_Inv_Management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_Inv_Management.ItemClick
        Dim xfrm As frm_SPA_Utility = New frm_SPA_Utility()
        class_Procedures.Show_Form(Me, xfrm, "Modify Spare Parts")
    End Sub

    Private Sub BarButtonItem_SubDealer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_SubDealer.ItemClick
        'Dim xfrm As frm_SubDealer = New frm_SubDealer()
        'class_Procedures.Show_Form(Me, xfrm, "Sub Dealer Management")
    End Sub

    Private Sub BarButtonItem_Sales_Summary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_Sales_Summary.ItemClick
        Dim xfrm As frm_SPA_Sales = New frm_SPA_Sales()
        class_Procedures.Show_Form(Me, xfrm, "Sales Summary")
    End Sub

    Private Sub BarButtonItem_Costing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_Costing.ItemClick
        Dim xfrm As frm_Costing = New frm_Costing()
        class_Procedures.Show_Form(Me, xfrm, "Costing Inventory")
    End Sub

    Private Sub BarButtonItem_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_Import.ItemClick
        Dim xfrm As frm_SPA_Import = New frm_SPA_Import()
        class_Procedures.Show_Form(Me, xfrm, "Import Inventory")
    End Sub

    Private Sub btn_PDC1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PDC1.ItemClick
        Dim xfrm As Forms.Cashiering.frm_PDC = New Cashiering.frm_PDC()
        class_Procedures.Show_Form(Me, xfrm, "Sub-Dealer Post Dated Check")
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

    Private Sub barEditItem_Date_Start_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barEditItem_Date_Start.ItemClick
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
    End Sub

    Private Sub barEditItem_Date_Start_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barEditItem_Date_Start.ItemDoubleClick
        Dim dtStart As Date
        Dim iDays As Integer = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iDays = -1

        dtStart = Convert.ToDateTime(barEditItem_Date_Start.EditValue).AddDays(iDays)
        If dtStart.DayOfWeek = DayOfWeek.Sunday Then dtStart = dtStart.AddDays(iDays)

        barEditItem_Date_Start.EditValue = dtStart
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(dtStart)
    End Sub

    Private Sub barEditItem_Date_End_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barEditItem_Date_End.ItemDoubleClick
        barEditItem_Date_End.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_End.EditValue))
    End Sub

    Private Sub btn_Today_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Today.ItemClick
        barEditItem_Date_Start.EditValue = Date.Today
        barEditItem_Date_End.EditValue = Date.Today
    End Sub

    Private Sub set_Month()
        barEditItem_Date_Start.EditValue = class_Functions.FirstDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
        barEditItem_Date_End.EditValue = class_Functions.LastDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue))
    End Sub

    Private Sub btn_Day_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Day.ItemClick
        barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Month.ItemClick
        set_Month()
    End Sub

    Private Sub btn_Day_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Day.ItemDoubleClick
        barEditItem_Date_Start.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
        barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue
    End Sub

    Private Sub btn_Month_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Month.ItemDoubleClick
        Dim iMonths As Int16 = 1

        If My.Computer.Keyboard.ShiftKeyDown Then iMonths = -1

        barEditItem_Date_Start.EditValue = Convert.ToDateTime(barEditItem_Date_Start.EditValue).AddMonths(iMonths)
        set_Month()
    End Sub

    Private Sub BarEditItem_Branch_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Branch.ItemDoubleClick
        Dim dtAssign As Date

        If My.Computer.Keyboard.ShiftKeyDown Then
            dtAssign = Date.Today
        Else
            dtAssign = class_Saga_Variables.dtStart
        End If

        If Not class_Database.Data_Save_Ask($"Set Branch Date to {dtAssign.ToShortDateString}") Then Return

        If BarEditItem_Branch.EditValue.Equals("000") Then
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET DatabaseDate = '{dtAssign}'")
        Else
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE BranchParameters SET DatabaseDate = '{dtAssign}' WHERE BranchCode LIKE '{BarEditItem_Branch.EditValue}'")
        End If

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch, True)
    End Sub

    Private Sub btn_Branch_PO_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Branch_PO.ItemClick
        Dim xfrm As frm_SPA_Order_Slip = New frm_SPA_Order_Slip()
        class_Procedures.Show_Form(Me, xfrm, "Order Slip")
    End Sub

    Private Sub BarButtonItem_SPA_Costing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem_SPA_Costing.ItemClick
        Dim xfrm As frm_SPA_Receiving_Orders_Costing = New frm_SPA_Receiving_Orders_Costing()
        class_Procedures.Show_Form(Me, xfrm, "SPA Receiving Costing")
    End Sub

    Private Sub BarButtonItem_Freebies_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem_Freebies.ItemClick
        Dim xfrm As frm_CustFreebie = New frm_CustFreebie()
        class_Procedures.Show_Form(Me, xfrm, "Motorcycle Freebies")
    End Sub

    Private Sub BarButtonItem_SPA_Master_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem_SPA_Master.ItemClick
        Dim xfrm As frm_SPA_Master = New frm_SPA_Master()
        class_Procedures.Show_Form(Me, xfrm, "Spare Parts Master")
    End Sub
End Class