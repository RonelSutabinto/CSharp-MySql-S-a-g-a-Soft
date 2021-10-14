Partial Public Class Form_Main
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Request_Motorcycle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Request_Stocks = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Request_Payment = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Requests = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinPaletteRibbonGalleryBarItem = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btn_Change_User = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem_Username = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Position = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_App_Version = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Server_IP = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem_Local_IP = New DevExpress.XtraBars.BarStaticItem()
        Me.btn_SPA_Transfer = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SPA_Receiving = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SPA_Purchase_Order = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SRF = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButton_Sales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_CustDeposit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_CustDep_Report = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_ErrorCorrect = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButton_Print_Details = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.xuc_Printing_Detail = New SagaClassLibrary.Controls.Persons.xuc_Printing_Detail()
        Me.BarButtonItem_Inv_Management = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_SubDealer = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_Sales_Summary = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_SPA_Collection = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_Freebies = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_Modify_SRP = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_SPA_Master = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Branch_PO = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_Costing = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_Import = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_PDC = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_PDC1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Today = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Day = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Month = New DevExpress.XtraBars.BarButtonItem()
        Me.barEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
        Me.repository_Date_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.barEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
        Me.repository_Date_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarButtonItem_SPA_Costing = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage_IT_Support = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_SpareParts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup_Request = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.AdornerUIManager = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer1.SuspendLayout()
        CType(Me.repository_Date_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repository_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.btn_Request_Motorcycle, Me.btn_Request_Stocks, Me.btn_Request_Payment, Me.btn_Requests, Me.SkinRibbonGalleryBarItem, Me.SkinPaletteRibbonGalleryBarItem, Me.BarEditItem_Branch, Me.BarEditItem_Corporation, Me.btn_Change_User, Me.BarStaticItem_Username, Me.BarStaticItem_Position, Me.BarStaticItem_App_Version, Me.BarStaticItem_Server_IP, Me.BarStaticItem_Local_IP, Me.btn_SPA_Transfer, Me.btn_SPA_Receiving, Me.btn_SPA_Purchase_Order, Me.btn_SRF, Me.BarButton_Sales, Me.BarButtonItem_CustDeposit, Me.BarButtonItem_CustDep_Report, Me.BarButtonItem_ErrorCorrect, Me.BarButton_Print_Details, Me.BarButtonItem_Inv_Management, Me.BarButtonItem_SubDealer, Me.BarButtonItem_Sales_Summary, Me.BarButtonItem_SPA_Collection, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem_Freebies, Me.BarButtonItem_Modify_SRP, Me.BarButtonItem_SPA_Master, Me.btn_Branch_PO, Me.BarButtonItem_Costing, Me.BarButtonItem_Import, Me.btn_PDC, Me.btn_PDC1, Me.btn_Today, Me.btn_Day, Me.btn_Month, Me.barEditItem_Date_Start, Me.barEditItem_Date_End, Me.BarButtonItem_SPA_Costing})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 45
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btn_Change_User)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_IT_Support, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage1})
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.SkinRibbonGalleryBarItem)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.SkinPaletteRibbonGalleryBarItem)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.BarEditItem_Corporation)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.BarEditItem_Branch)
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemComboBox_Corporation, Me.RepositoryItemDateEdit1, Me.repository_Date_Start, Me.repository_Date_End, Me.RepositoryItemLookUpEdit1})
        Me.ribbonControl.Size = New System.Drawing.Size(954, 158)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btn_Request_Motorcycle
        '
        Me.btn_Request_Motorcycle.Caption = "Motorcycle"
        Me.btn_Request_Motorcycle.Id = 1
        Me.btn_Request_Motorcycle.Name = "btn_Request_Motorcycle"
        '
        'btn_Request_Stocks
        '
        Me.btn_Request_Stocks.Caption = "Stocks"
        Me.btn_Request_Stocks.Id = 2
        Me.btn_Request_Stocks.Name = "btn_Request_Stocks"
        '
        'btn_Request_Payment
        '
        Me.btn_Request_Payment.Caption = "Payment"
        Me.btn_Request_Payment.Id = 3
        Me.btn_Request_Payment.Name = "btn_Request_Payment"
        '
        'btn_Requests
        '
        Me.btn_Requests.Caption = "Requests"
        Me.btn_Requests.Id = 4
        Me.btn_Requests.Name = "btn_Requests"
        '
        'SkinRibbonGalleryBarItem
        '
        Me.SkinRibbonGalleryBarItem.Caption = "Skins"
        Me.SkinRibbonGalleryBarItem.Id = 5
        Me.SkinRibbonGalleryBarItem.Name = "SkinRibbonGalleryBarItem"
        '
        'SkinPaletteRibbonGalleryBarItem
        '
        Me.SkinPaletteRibbonGalleryBarItem.Caption = "Skin Palettes"
        Me.SkinPaletteRibbonGalleryBarItem.Id = 6
        Me.SkinPaletteRibbonGalleryBarItem.Name = "SkinPaletteRibbonGalleryBarItem"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Caption = "Branch"
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
        Me.BarEditItem_Branch.Id = 7
        Me.BarEditItem_Branch.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Branch.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem_Branch.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Branch.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
        '
        'RepositoryItemLookUpEdit_Branch
        '
        Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
        '
        'BarEditItem_Corporation
        '
        Me.BarEditItem_Corporation.Caption = "Corporation"
        Me.BarEditItem_Corporation.Edit = Me.RepositoryItemComboBox_Corporation
        Me.BarEditItem_Corporation.Id = 10
        Me.BarEditItem_Corporation.ImageOptions.Image = CType(resources.GetObject("BarEditItem_Corporation.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem_Corporation.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem_Corporation.ImageOptions.LargeImage"), System.Drawing.Image)
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
        'btn_Change_User
        '
        Me.btn_Change_User.Caption = "Change User"
        Me.btn_Change_User.Id = 1
        Me.btn_Change_User.ImageOptions.Image = CType(resources.GetObject("btn_Change_User.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Change_User.ImageOptions.LargeImage = CType(resources.GetObject("btn_Change_User.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Change_User.Name = "btn_Change_User"
        '
        'BarStaticItem_Username
        '
        Me.BarStaticItem_Username.Caption = "Username"
        Me.BarStaticItem_Username.Id = 4
        Me.BarStaticItem_Username.Name = "BarStaticItem_Username"
        '
        'BarStaticItem_Position
        '
        Me.BarStaticItem_Position.Caption = "Position"
        Me.BarStaticItem_Position.Id = 5
        Me.BarStaticItem_Position.Name = "BarStaticItem_Position"
        '
        'BarStaticItem_App_Version
        '
        Me.BarStaticItem_App_Version.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem_App_Version.Caption = "1.0.0.0"
        Me.BarStaticItem_App_Version.Id = 6
        Me.BarStaticItem_App_Version.Name = "BarStaticItem_App_Version"
        '
        'BarStaticItem_Server_IP
        '
        Me.BarStaticItem_Server_IP.Caption = "Server IP"
        Me.BarStaticItem_Server_IP.Id = 7
        Me.BarStaticItem_Server_IP.Name = "BarStaticItem_Server_IP"
        '
        'BarStaticItem_Local_IP
        '
        Me.BarStaticItem_Local_IP.Caption = "Local IP"
        Me.BarStaticItem_Local_IP.Id = 8
        Me.BarStaticItem_Local_IP.Name = "BarStaticItem_Local_IP"
        '
        'btn_SPA_Transfer
        '
        Me.btn_SPA_Transfer.Caption = "Transfer"
        Me.btn_SPA_Transfer.Id = 9
        Me.btn_SPA_Transfer.ImageOptions.Image = CType(resources.GetObject("btn_SPA_Transfer.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SPA_Transfer.ImageOptions.LargeImage = CType(resources.GetObject("btn_SPA_Transfer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SPA_Transfer.Name = "btn_SPA_Transfer"
        '
        'btn_SPA_Receiving
        '
        Me.btn_SPA_Receiving.Caption = "Receiving"
        Me.btn_SPA_Receiving.Id = 10
        Me.btn_SPA_Receiving.ImageOptions.Image = CType(resources.GetObject("btn_SPA_Receiving.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SPA_Receiving.ImageOptions.LargeImage = CType(resources.GetObject("btn_SPA_Receiving.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SPA_Receiving.Name = "btn_SPA_Receiving"
        '
        'btn_SPA_Purchase_Order
        '
        Me.btn_SPA_Purchase_Order.Caption = "Purchase Orders"
        Me.btn_SPA_Purchase_Order.Id = 11
        Me.btn_SPA_Purchase_Order.ImageOptions.Image = CType(resources.GetObject("btn_SPA_Purchase_Order.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SPA_Purchase_Order.ImageOptions.LargeImage = CType(resources.GetObject("btn_SPA_Purchase_Order.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SPA_Purchase_Order.Name = "btn_SPA_Purchase_Order"
        '
        'btn_SRF
        '
        Me.btn_SRF.Caption = "SRF"
        Me.btn_SRF.Id = 12
        Me.btn_SRF.ImageOptions.Image = CType(resources.GetObject("btn_SRF.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SRF.ImageOptions.LargeImage = CType(resources.GetObject("btn_SRF.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SRF.Name = "btn_SRF"
        '
        'BarButton_Sales
        '
        Me.BarButton_Sales.Caption = "Sales"
        Me.BarButton_Sales.Hint = "SALES"
        Me.BarButton_Sales.Id = 13
        Me.BarButton_Sales.ImageOptions.Image = CType(resources.GetObject("BarButton_Sales.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButton_Sales.ImageOptions.LargeImage = CType(resources.GetObject("BarButton_Sales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButton_Sales.Name = "BarButton_Sales"
        '
        'BarButtonItem_CustDeposit
        '
        Me.BarButtonItem_CustDeposit.Caption = "Cutomer Deposit"
        Me.BarButtonItem_CustDeposit.Id = 14
        Me.BarButtonItem_CustDeposit.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_CustDeposit.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_CustDeposit.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_CustDeposit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_CustDeposit.Name = "BarButtonItem_CustDeposit"
        '
        'BarButtonItem_CustDep_Report
        '
        Me.BarButtonItem_CustDep_Report.Caption = "CustDep Due Report"
        Me.BarButtonItem_CustDep_Report.Id = 15
        Me.BarButtonItem_CustDep_Report.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_CustDep_Report.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_CustDep_Report.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_CustDep_Report.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_CustDep_Report.Name = "BarButtonItem_CustDep_Report"
        '
        'BarButtonItem_ErrorCorrect
        '
        Me.BarButtonItem_ErrorCorrect.Caption = "Error Correct Sales"
        Me.BarButtonItem_ErrorCorrect.Id = 16
        Me.BarButtonItem_ErrorCorrect.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_ErrorCorrect.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_ErrorCorrect.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_ErrorCorrect.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_ErrorCorrect.Name = "BarButtonItem_ErrorCorrect"
        '
        'BarButton_Print_Details
        '
        Me.BarButton_Print_Details.ActAsDropDown = True
        Me.BarButton_Print_Details.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButton_Print_Details.Caption = "Print Details"
        Me.BarButton_Print_Details.DropDownControl = Me.PopupControlContainer1
        Me.BarButton_Print_Details.Id = 18
        Me.BarButton_Print_Details.ImageOptions.Image = CType(resources.GetObject("BarButton_Print_Details.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButton_Print_Details.ImageOptions.LargeImage = CType(resources.GetObject("BarButton_Print_Details.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButton_Print_Details.Name = "BarButton_Print_Details"
        '
        'PopupControlContainer1
        '
        Me.PopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer1.Controls.Add(Me.xuc_Printing_Detail)
        Me.PopupControlContainer1.Location = New System.Drawing.Point(431, 173)
        Me.PopupControlContainer1.Name = "PopupControlContainer1"
        Me.PopupControlContainer1.Ribbon = Me.ribbonControl
        Me.PopupControlContainer1.Size = New System.Drawing.Size(278, 258)
        Me.PopupControlContainer1.TabIndex = 3
        Me.PopupControlContainer1.Visible = False
        '
        'xuc_Printing_Detail
        '
        Me.xuc_Printing_Detail.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.xuc_Printing_Detail.Appearance.Options.UseBackColor = True
        Me.xuc_Printing_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xuc_Printing_Detail.Location = New System.Drawing.Point(0, 0)
        Me.xuc_Printing_Detail.MinimumSize = New System.Drawing.Size(200, 80)
        Me.xuc_Printing_Detail.Name = "xuc_Printing_Detail"
        Me.xuc_Printing_Detail.Size = New System.Drawing.Size(278, 258)
        Me.xuc_Printing_Detail.TabIndex = 0
        '
        'BarButtonItem_Inv_Management
        '
        Me.BarButtonItem_Inv_Management.Caption = "Inventory Management"
        Me.BarButtonItem_Inv_Management.Id = 19
        Me.BarButtonItem_Inv_Management.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Inv_Management.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Inv_Management.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Inv_Management.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Inv_Management.Name = "BarButtonItem_Inv_Management"
        '
        'BarButtonItem_SubDealer
        '
        Me.BarButtonItem_SubDealer.Caption = "Sub-Dealer Management"
        Me.BarButtonItem_SubDealer.Id = 20
        Me.BarButtonItem_SubDealer.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_SubDealer.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_SubDealer.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_SubDealer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_SubDealer.Name = "BarButtonItem_SubDealer"
        '
        'BarButtonItem_Sales_Summary
        '
        Me.BarButtonItem_Sales_Summary.Caption = "Sales Summary"
        Me.BarButtonItem_Sales_Summary.Id = 21
        Me.BarButtonItem_Sales_Summary.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Sales_Summary.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Sales_Summary.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Sales_Summary.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Sales_Summary.Name = "BarButtonItem_Sales_Summary"
        '
        'BarButtonItem_SPA_Collection
        '
        Me.BarButtonItem_SPA_Collection.Caption = "Collection"
        Me.BarButtonItem_SPA_Collection.Id = 24
        Me.BarButtonItem_SPA_Collection.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_SPA_Collection.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Collection.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_SPA_Collection.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Collection.Name = "BarButtonItem_SPA_Collection"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "For Approval"
        Me.BarButtonItem12.Id = 25
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "In Trans"
        Me.BarButtonItem13.Id = 26
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "BarButtonItem14"
        Me.BarButtonItem14.Id = 27
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem_Freebies
        '
        Me.BarButtonItem_Freebies.Caption = "Freebies"
        Me.BarButtonItem_Freebies.Id = 28
        Me.BarButtonItem_Freebies.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Freebies.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Freebies.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Freebies.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Freebies.Name = "BarButtonItem_Freebies"
        '
        'BarButtonItem_Modify_SRP
        '
        Me.BarButtonItem_Modify_SRP.Caption = "Modify SRP"
        Me.BarButtonItem_Modify_SRP.Id = 29
        Me.BarButtonItem_Modify_SRP.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Modify_SRP.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Modify_SRP.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Modify_SRP.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Modify_SRP.Name = "BarButtonItem_Modify_SRP"
        '
        'BarButtonItem_SPA_Master
        '
        Me.BarButtonItem_SPA_Master.Caption = "Spare Parts Master"
        Me.BarButtonItem_SPA_Master.Id = 30
        Me.BarButtonItem_SPA_Master.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_SPA_Master.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Master.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_SPA_Master.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Master.Name = "BarButtonItem_SPA_Master"
        '
        'btn_Branch_PO
        '
        Me.btn_Branch_PO.Caption = "Order Slip"
        Me.btn_Branch_PO.Hint = "Branch Purchase Order"
        Me.btn_Branch_PO.Id = 31
        Me.btn_Branch_PO.ImageOptions.Image = CType(resources.GetObject("btn_Branch_PO.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Branch_PO.ImageOptions.LargeImage = CType(resources.GetObject("btn_Branch_PO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Branch_PO.Name = "btn_Branch_PO"
        '
        'BarButtonItem_Costing
        '
        Me.BarButtonItem_Costing.Caption = "Costing"
        Me.BarButtonItem_Costing.Id = 32
        Me.BarButtonItem_Costing.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Costing.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Costing.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Costing.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Costing.Name = "BarButtonItem_Costing"
        '
        'BarButtonItem_Import
        '
        Me.BarButtonItem_Import.Caption = "Import SKU's"
        Me.BarButtonItem_Import.Id = 33
        Me.BarButtonItem_Import.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_Import.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_Import.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_Import.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_Import.Name = "BarButtonItem_Import"
        '
        'btn_PDC
        '
        Me.btn_PDC.Caption = "PDC"
        Me.btn_PDC.Hint = "Post Dated Check"
        Me.btn_PDC.Id = 34
        Me.btn_PDC.Name = "btn_PDC"
        '
        'btn_PDC1
        '
        Me.btn_PDC1.Caption = "Post Dated Check"
        Me.btn_PDC1.Hint = "POST DATED CHECK"
        Me.btn_PDC1.Id = 35
        Me.btn_PDC1.ImageOptions.Image = CType(resources.GetObject("btn_PDC1.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_PDC1.ImageOptions.LargeImage = CType(resources.GetObject("btn_PDC1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_PDC1.Name = "btn_PDC1"
        '
        'btn_Today
        '
        Me.btn_Today.Caption = "Day"
        Me.btn_Today.Id = 36
        Me.btn_Today.ImageOptions.Image = CType(resources.GetObject("btn_Today.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Today.ImageOptions.LargeImage = CType(resources.GetObject("btn_Today.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Today.Name = "btn_Today"
        Me.btn_Today.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Day
        '
        Me.btn_Day.Caption = "Today"
        Me.btn_Day.Id = 37
        Me.btn_Day.ImageOptions.Image = CType(resources.GetObject("btn_Day.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Day.ImageOptions.LargeImage = CType(resources.GetObject("btn_Day.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Day.Name = "btn_Day"
        Me.btn_Day.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Month
        '
        Me.btn_Month.Caption = "Month"
        Me.btn_Month.Id = 38
        Me.btn_Month.ImageOptions.Image = CType(resources.GetObject("btn_Month.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Month.ImageOptions.LargeImage = CType(resources.GetObject("btn_Month.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Month.Name = "btn_Month"
        Me.btn_Month.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'barEditItem_Date_Start
        '
        Me.barEditItem_Date_Start.Caption = "Date Start"
        Me.barEditItem_Date_Start.Edit = Me.repository_Date_Start
        Me.barEditItem_Date_Start.EditWidth = 120
        Me.barEditItem_Date_Start.Id = 40
        Me.barEditItem_Date_Start.ImageOptions.Image = CType(resources.GetObject("barEditItem_Date_Start.ImageOptions.Image"), System.Drawing.Image)
        Me.barEditItem_Date_Start.ImageOptions.LargeImage = CType(resources.GetObject("barEditItem_Date_Start.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barEditItem_Date_Start.Name = "barEditItem_Date_Start"
        '
        'repository_Date_Start
        '
        Me.repository_Date_Start.AutoHeight = False
        Me.repository_Date_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_Start.Name = "repository_Date_Start"
        '
        'barEditItem_Date_End
        '
        Me.barEditItem_Date_End.Caption = "Date End  "
        Me.barEditItem_Date_End.Edit = Me.repository_Date_End
        Me.barEditItem_Date_End.EditWidth = 120
        Me.barEditItem_Date_End.Id = 41
        Me.barEditItem_Date_End.ImageOptions.Image = CType(resources.GetObject("barEditItem_Date_End.ImageOptions.Image"), System.Drawing.Image)
        Me.barEditItem_Date_End.ImageOptions.LargeImage = CType(resources.GetObject("barEditItem_Date_End.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.barEditItem_Date_End.Name = "barEditItem_Date_End"
        '
        'repository_Date_End
        '
        Me.repository_Date_End.AutoHeight = False
        Me.repository_Date_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repository_Date_End.Name = "repository_Date_End"
        '
        'BarButtonItem_SPA_Costing
        '
        Me.BarButtonItem_SPA_Costing.Caption = "SPA Receiving Costing"
        Me.BarButtonItem_SPA_Costing.Id = 43
        Me.BarButtonItem_SPA_Costing.ImageOptions.Image = CType(resources.GetObject("BarButtonItem_SPA_Costing.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Costing.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem_SPA_Costing.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem_SPA_Costing.Name = "BarButtonItem_SPA_Costing"
        '
        'RibbonPage_IT_Support
        '
        Me.RibbonPage_IT_Support.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_SpareParts, Me.RibbonPageGroup_Request, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage_IT_Support.Name = "RibbonPage_IT_Support"
        Me.RibbonPage_IT_Support.Text = "Transactions"
        '
        'RibbonPageGroup_SpareParts
        '
        Me.RibbonPageGroup_SpareParts.ItemLinks.Add(Me.btn_SPA_Purchase_Order, True)
        Me.RibbonPageGroup_SpareParts.ItemLinks.Add(Me.btn_SPA_Receiving)
        Me.RibbonPageGroup_SpareParts.ItemLinks.Add(Me.btn_SPA_Transfer)
        Me.RibbonPageGroup_SpareParts.ItemLinks.Add(Me.btn_SRF, True)
        Me.RibbonPageGroup_SpareParts.ItemLinks.Add(Me.btn_Branch_PO)
        Me.RibbonPageGroup_SpareParts.Name = "RibbonPageGroup_SpareParts"
        Me.RibbonPageGroup_SpareParts.Text = "Spare Parts"
        '
        'RibbonPageGroup_Request
        '
        Me.RibbonPageGroup_Request.AllowTextClipping = False
        Me.RibbonPageGroup_Request.ItemLinks.Add(Me.BarButton_Sales)
        Me.RibbonPageGroup_Request.ItemLinks.Add(Me.BarButtonItem_ErrorCorrect)
        Me.RibbonPageGroup_Request.ItemLinks.Add(Me.BarButtonItem_CustDeposit, True)
        Me.RibbonPageGroup_Request.ItemLinks.Add(Me.BarButtonItem_CustDep_Report)
        Me.RibbonPageGroup_Request.Name = "RibbonPageGroup_Request"
        Me.RibbonPageGroup_Request.Text = "Sales"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem_SPA_Collection)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Collection"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem_SPA_Costing)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Accounting"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup7})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Utilities"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_Inv_Management)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_SubDealer)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_Modify_SRP)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_SPA_Master)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_Costing)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_Import)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Spare Parts"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem_Freebies)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Freebies"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Reports"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem_Sales_Summary)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_PDC1)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Reports"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "User"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.barEditItem_Date_Start)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.barEditItem_Date_End)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_Today, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_Day)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_Month)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Parameters"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButton_Print_Details)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Printing Details"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Username)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Position)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_App_Version)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Server_IP)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_Local_IP)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 358)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(954, 24)
        '
        'XtraTabbedMdiManager
        '
        Me.XtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.XtraTabbedMdiManager.MdiParent = Me
        '
        'AdornerUIManager
        '
        Me.AdornerUIManager.Owner = Me
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "PDC"
        Me.BarButtonItem2.Id = 34
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 382)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.PopupControlContainer1)
        Me.Controls.Add(Me.ribbonControl)
        Me.IconOptions.Icon = CType(resources.GetObject("Form_Main.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.LargeImage = CType(resources.GetObject("Form_Main.IconOptions.LargeImage"), System.Drawing.Image)
        Me.IsMdiContainer = True
        Me.Name = "Form_Main"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Saga System Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer1.ResumeLayout(False)
        CType(Me.repository_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repository_Date_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdornerUIManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btn_Request_Motorcycle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Request_Stocks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Request_Payment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Requests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents SkinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btn_Change_User As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem_Username As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Position As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_App_Version As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Server_IP As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem_Local_IP As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPage_IT_Support As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_SpareParts As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_SPA_Transfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SPA_Receiving As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SPA_Purchase_Order As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SRF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup_Request As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButton_Sales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_CustDeposit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_CustDep_Report As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_ErrorCorrect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_Print_Details As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents xuc_Printing_Detail As SagaClassLibrary.Controls.Persons.xuc_Printing_Detail
    Friend WithEvents BarButtonItem_Inv_Management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_SubDealer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem_Sales_Summary As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem_SPA_Collection As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_Freebies As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_Modify_SRP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_SPA_Master As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents AdornerUIManager As DevExpress.Utils.VisualEffects.AdornerUIManager
    Friend WithEvents btn_Branch_PO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_Costing As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_Import As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_PDC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_PDC1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Today As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Day As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Month As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repository_Date_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barEditItem_Date_End As DevExpress.XtraBars.BarEditItem
    Friend WithEvents repository_Date_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarButtonItem_SPA_Costing As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
