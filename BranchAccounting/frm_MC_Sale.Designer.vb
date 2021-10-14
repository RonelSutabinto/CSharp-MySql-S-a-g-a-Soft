Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_MC_Sale
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Journal = New DevExpress.XtraBars.Bar()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Parameters = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAE_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAE_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngine = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassis = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKey_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRelease_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSale_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAssume_Tag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinanced = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Rate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal_Monthly = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Monthly = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmortization = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutstanding_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Granted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Updated = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_First_Payment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Maturity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSI_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCR_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Branch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Account_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Ledger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Journal, Me.Bar_Parameters})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.DockManager = Me.DockManager
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Close, Me.btn_Journal, Me.btn_Journal_Entries, Me.btn_Stop, Me.BarEditItem_Search, Me.btn_Verify})
            Me.BarManager.MaxItemId = 14
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 2
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar_Actions.Offset = 307
            Me.Bar_Actions.Text = "Actions"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 1
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 2
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar_Journal
            '
            Me.Bar_Journal.BarName = "Journal"
            Me.Bar_Journal.DockCol = 1
            Me.Bar_Journal.DockRow = 0
            Me.Bar_Journal.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Journal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar_Journal.Offset = 95
            Me.Bar_Journal.Text = "Journal"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 3
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 4
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 5
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Bar_Parameters
            '
            Me.Bar_Parameters.BarName = "Parameters"
            Me.Bar_Parameters.DockCol = 0
            Me.Bar_Parameters.DockRow = 0
            Me.Bar_Parameters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Parameters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search)})
            Me.Bar_Parameters.Text = "Parameters"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(613, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 506)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(613, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 486)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(613, 20)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 486)
            '
            'DockManager
            '
            Me.DockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.BarManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 20)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(21, 486)
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("829d6ce3-d792-482f-9dbd-af6bd12126fb")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(200, 331)
            Me.DockPanel1.Text = "Information"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 302)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("61818e42-0ab3-4dd1-8237-c10a91c5e29e")
            Me.DockPanel2.Location = New System.Drawing.Point(333, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 486)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 457)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 457)
            Me.xuc_Settings.TabIndex = 0
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 12
            Me.btn_Verify.Name = "btn_Verify"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(21, 20)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(312, 486)
            Me.gridControl.TabIndex = 17
            Me.gridControl.UseEmbeddedNavigator = True
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colCorporation, Me.colBranch_Code, Me.colCustomer_Code, Me.colAccount_Code, Me.colLedger, Me.colCustomer_Name, Me.colCustomer_Address, Me.colAgent_Code, Me.colAgent_Type, Me.colAgent_Name, Me.colAE_Code, Me.colAE_Name, Me.colModel_ID, Me.colModel_Code, Me.colBrand, Me.colModel, Me.colColor, Me.colEngine, Me.colChassis, Me.colKey_Code, Me.colUnit_Cost, Me.colVAT, Me.colTotal_Cost, Me.colUnit_Status, Me.colRelease_Type, Me.colSale_Type, Me.colAssume_Tag, Me.colAccount_Status, Me.colCOD, Me.colLCP, Me.colFinanced, Me.colDP, Me.colAOC, Me.colRebates, Me.colDiscount_ID, Me.colDiscount, Me.colDiscount_Name, Me.colTerms, Me.colInterest_Rate, Me.colPrincipal_Monthly, Me.colInterest_Monthly, Me.colAmortization, Me.colPrincipal_Balance, Me.colInterest_Balance, Me.colOutstanding_Balance, Me.colDate_Granted, Me.colDate_Updated, Me.colDate_First_Payment, Me.colDate_Maturity, Me.colSI_Code, Me.colCR_Code, Me.colPrev_Branch_Code, Me.colPrev_Account_Code, Me.colPrev_Ledger, Me.colPrev_Name, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colNotes})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colCorporation
            '
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 3
            '
            'colCustomer_Code
            '
            Me.colCustomer_Code.FieldName = "Customer_Code"
            Me.colCustomer_Code.Name = "colCustomer_Code"
            Me.colCustomer_Code.Visible = True
            Me.colCustomer_Code.VisibleIndex = 4
            '
            'colAccount_Code
            '
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 5
            '
            'colLedger
            '
            Me.colLedger.FieldName = "Ledger"
            Me.colLedger.Name = "colLedger"
            Me.colLedger.Visible = True
            Me.colLedger.VisibleIndex = 6
            '
            'colCustomer_Name
            '
            Me.colCustomer_Name.FieldName = "Customer_Name"
            Me.colCustomer_Name.Name = "colCustomer_Name"
            Me.colCustomer_Name.Visible = True
            Me.colCustomer_Name.VisibleIndex = 7
            '
            'colCustomer_Address
            '
            Me.colCustomer_Address.FieldName = "Customer_Address"
            Me.colCustomer_Address.Name = "colCustomer_Address"
            Me.colCustomer_Address.Visible = True
            Me.colCustomer_Address.VisibleIndex = 8
            '
            'colAgent_Code
            '
            Me.colAgent_Code.FieldName = "Agent_Code"
            Me.colAgent_Code.Name = "colAgent_Code"
            Me.colAgent_Code.Visible = True
            Me.colAgent_Code.VisibleIndex = 9
            '
            'colAgent_Type
            '
            Me.colAgent_Type.FieldName = "Agent_Type"
            Me.colAgent_Type.Name = "colAgent_Type"
            Me.colAgent_Type.Visible = True
            Me.colAgent_Type.VisibleIndex = 10
            '
            'colAgent_Name
            '
            Me.colAgent_Name.FieldName = "Agent_Name"
            Me.colAgent_Name.Name = "colAgent_Name"
            Me.colAgent_Name.Visible = True
            Me.colAgent_Name.VisibleIndex = 11
            '
            'colAE_Code
            '
            Me.colAE_Code.FieldName = "AE_Code"
            Me.colAE_Code.Name = "colAE_Code"
            Me.colAE_Code.Visible = True
            Me.colAE_Code.VisibleIndex = 12
            '
            'colAE_Name
            '
            Me.colAE_Name.FieldName = "AE_Name"
            Me.colAE_Name.Name = "colAE_Name"
            Me.colAE_Name.Visible = True
            Me.colAE_Name.VisibleIndex = 13
            '
            'colModel_ID
            '
            Me.colModel_ID.FieldName = "Model_ID"
            Me.colModel_ID.Name = "colModel_ID"
            Me.colModel_ID.Visible = True
            Me.colModel_ID.VisibleIndex = 14
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 15
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 16
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 17
            '
            'colColor
            '
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 18
            '
            'colEngine
            '
            Me.colEngine.FieldName = "Engine"
            Me.colEngine.Name = "colEngine"
            Me.colEngine.Visible = True
            Me.colEngine.VisibleIndex = 19
            '
            'colChassis
            '
            Me.colChassis.FieldName = "Chassis"
            Me.colChassis.Name = "colChassis"
            Me.colChassis.Visible = True
            Me.colChassis.VisibleIndex = 20
            '
            'colKey_Code
            '
            Me.colKey_Code.FieldName = "Key_Code"
            Me.colKey_Code.Name = "colKey_Code"
            Me.colKey_Code.Visible = True
            Me.colKey_Code.VisibleIndex = 21
            '
            'colUnit_Cost
            '
            Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_Cost.FieldName = "Unit_Cost"
            Me.colUnit_Cost.Name = "colUnit_Cost"
            Me.colUnit_Cost.Visible = True
            Me.colUnit_Cost.VisibleIndex = 22
            '
            'colVAT
            '
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VAT"
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 23
            '
            'colTotal_Cost
            '
            Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost.FieldName = "Total_Cost"
            Me.colTotal_Cost.Name = "colTotal_Cost"
            Me.colTotal_Cost.Visible = True
            Me.colTotal_Cost.VisibleIndex = 24
            '
            'colUnit_Status
            '
            Me.colUnit_Status.FieldName = "Unit_Status"
            Me.colUnit_Status.Name = "colUnit_Status"
            Me.colUnit_Status.Visible = True
            Me.colUnit_Status.VisibleIndex = 25
            '
            'colRelease_Type
            '
            Me.colRelease_Type.FieldName = "Release_Type"
            Me.colRelease_Type.Name = "colRelease_Type"
            Me.colRelease_Type.Visible = True
            Me.colRelease_Type.VisibleIndex = 26
            '
            'colSale_Type
            '
            Me.colSale_Type.FieldName = "Sale_Type"
            Me.colSale_Type.Name = "colSale_Type"
            Me.colSale_Type.Visible = True
            Me.colSale_Type.VisibleIndex = 27
            '
            'colAssume_Tag
            '
            Me.colAssume_Tag.FieldName = "Assume_Tag"
            Me.colAssume_Tag.Name = "colAssume_Tag"
            Me.colAssume_Tag.Visible = True
            Me.colAssume_Tag.VisibleIndex = 28
            '
            'colAccount_Status
            '
            Me.colAccount_Status.FieldName = "Account_Status"
            Me.colAccount_Status.Name = "colAccount_Status"
            Me.colAccount_Status.Visible = True
            Me.colAccount_Status.VisibleIndex = 29
            '
            'colCOD
            '
            Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCOD.FieldName = "COD"
            Me.colCOD.Name = "colCOD"
            Me.colCOD.Visible = True
            Me.colCOD.VisibleIndex = 30
            '
            'colLCP
            '
            Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLCP.FieldName = "LCP"
            Me.colLCP.Name = "colLCP"
            Me.colLCP.Visible = True
            Me.colLCP.VisibleIndex = 31
            '
            'colFinanced
            '
            Me.colFinanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFinanced.FieldName = "Financed"
            Me.colFinanced.Name = "colFinanced"
            Me.colFinanced.Visible = True
            Me.colFinanced.VisibleIndex = 32
            '
            'colDP
            '
            Me.colDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDP.FieldName = "DP"
            Me.colDP.Name = "colDP"
            Me.colDP.Visible = True
            Me.colDP.VisibleIndex = 33
            '
            'colAOC
            '
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 34
            '
            'colRebates
            '
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 35
            '
            'colDiscount_ID
            '
            Me.colDiscount_ID.FieldName = "Disc_ID"
            Me.colDiscount_ID.Name = "colDiscount_ID"
            Me.colDiscount_ID.Visible = True
            Me.colDiscount_ID.VisibleIndex = 36
            '
            'colDiscount
            '
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 37
            '
            'colDiscount_Name
            '
            Me.colDiscount_Name.FieldName = "Discount_Name"
            Me.colDiscount_Name.Name = "colDiscount_Name"
            Me.colDiscount_Name.Visible = True
            Me.colDiscount_Name.VisibleIndex = 38
            '
            'colTerms
            '
            Me.colTerms.FieldName = "Terms"
            Me.colTerms.Name = "colTerms"
            Me.colTerms.Visible = True
            Me.colTerms.VisibleIndex = 39
            '
            'colInterest_Rate
            '
            Me.colInterest_Rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Rate.FieldName = "Interest_Rate"
            Me.colInterest_Rate.Name = "colInterest_Rate"
            Me.colInterest_Rate.Visible = True
            Me.colInterest_Rate.VisibleIndex = 40
            '
            'colPrincipal_Monthly
            '
            Me.colPrincipal_Monthly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal_Monthly.FieldName = "Principal_Monthly"
            Me.colPrincipal_Monthly.Name = "colPrincipal_Monthly"
            Me.colPrincipal_Monthly.Visible = True
            Me.colPrincipal_Monthly.VisibleIndex = 41
            '
            'colInterest_Monthly
            '
            Me.colInterest_Monthly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Monthly.FieldName = "Interest_Monthly"
            Me.colInterest_Monthly.Name = "colInterest_Monthly"
            Me.colInterest_Monthly.Visible = True
            Me.colInterest_Monthly.VisibleIndex = 42
            '
            'colAmortization
            '
            Me.colAmortization.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmortization.FieldName = "Amortization"
            Me.colAmortization.Name = "colAmortization"
            Me.colAmortization.Visible = True
            Me.colAmortization.VisibleIndex = 43
            '
            'colPrincipal_Balance
            '
            Me.colPrincipal_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal_Balance.FieldName = "Principal_Balance"
            Me.colPrincipal_Balance.Name = "colPrincipal_Balance"
            Me.colPrincipal_Balance.Visible = True
            Me.colPrincipal_Balance.VisibleIndex = 44
            '
            'colInterest_Balance
            '
            Me.colInterest_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Balance.FieldName = "Interest_Balance"
            Me.colInterest_Balance.Name = "colInterest_Balance"
            Me.colInterest_Balance.Visible = True
            Me.colInterest_Balance.VisibleIndex = 45
            '
            'colOutstanding_Balance
            '
            Me.colOutstanding_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutstanding_Balance.FieldName = "Outstanding_Balance"
            Me.colOutstanding_Balance.Name = "colOutstanding_Balance"
            Me.colOutstanding_Balance.Visible = True
            Me.colOutstanding_Balance.VisibleIndex = 46
            '
            'colDate_Granted
            '
            Me.colDate_Granted.FieldName = "Date_Granted"
            Me.colDate_Granted.Name = "colDate_Granted"
            Me.colDate_Granted.Visible = True
            Me.colDate_Granted.VisibleIndex = 47
            '
            'colDate_Updated
            '
            Me.colDate_Updated.FieldName = "Date_Updated"
            Me.colDate_Updated.Name = "colDate_Updated"
            Me.colDate_Updated.Visible = True
            Me.colDate_Updated.VisibleIndex = 48
            '
            'colDate_First_Payment
            '
            Me.colDate_First_Payment.FieldName = "Date_First_Payment"
            Me.colDate_First_Payment.Name = "colDate_First_Payment"
            Me.colDate_First_Payment.Visible = True
            Me.colDate_First_Payment.VisibleIndex = 49
            '
            'colDate_Maturity
            '
            Me.colDate_Maturity.FieldName = "Date_Maturity"
            Me.colDate_Maturity.Name = "colDate_Maturity"
            Me.colDate_Maturity.Visible = True
            Me.colDate_Maturity.VisibleIndex = 50
            '
            'colSI_Code
            '
            Me.colSI_Code.FieldName = "SI_Code"
            Me.colSI_Code.Name = "colSI_Code"
            Me.colSI_Code.Visible = True
            Me.colSI_Code.VisibleIndex = 51
            '
            'colCR_Code
            '
            Me.colCR_Code.FieldName = "CR_Code"
            Me.colCR_Code.Name = "colCR_Code"
            Me.colCR_Code.Visible = True
            Me.colCR_Code.VisibleIndex = 52
            '
            'colPrev_Branch_Code
            '
            Me.colPrev_Branch_Code.Caption = "Prev_Branch"
            Me.colPrev_Branch_Code.FieldName = "Prev_Branch_Code"
            Me.colPrev_Branch_Code.Name = "colPrev_Branch_Code"
            Me.colPrev_Branch_Code.Visible = True
            Me.colPrev_Branch_Code.VisibleIndex = 53
            '
            'colPrev_Account_Code
            '
            Me.colPrev_Account_Code.FieldName = "Prev_Account_Code"
            Me.colPrev_Account_Code.Name = "colPrev_Account_Code"
            Me.colPrev_Account_Code.Visible = True
            Me.colPrev_Account_Code.VisibleIndex = 54
            '
            'colPrev_Ledger
            '
            Me.colPrev_Ledger.FieldName = "Prev_Ledger"
            Me.colPrev_Ledger.Name = "colPrev_Ledger"
            Me.colPrev_Ledger.Visible = True
            Me.colPrev_Ledger.VisibleIndex = 55
            '
            'colPrev_Name
            '
            Me.colPrev_Name.Caption = "Prev Customer Name"
            Me.colPrev_Name.FieldName = "Prev_Name"
            Me.colPrev_Name.Name = "colPrev_Name"
            Me.colPrev_Name.Visible = True
            Me.colPrev_Name.VisibleIndex = 56
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 57
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 58
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 59
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 60
            '
            'colApproved_By
            '
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 61
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 62
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 63
            '
            'frm_MC_Sale
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(613, 506)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_MC_Sale"
            Me.Text = "frm_MC_Sale"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Journal As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAE_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAE_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngine As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassis As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKey_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRelease_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSale_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAssume_Tag As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFinanced As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Rate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal_Monthly As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Monthly As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmortization As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutstanding_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Granted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Updated As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_First_Payment As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Maturity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSI_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCR_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Branch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Account_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Ledger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace