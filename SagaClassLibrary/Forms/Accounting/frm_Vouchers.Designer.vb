Namespace Forms.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Vouchers
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
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Vouchers))
            Me.xuc_Voucher = New SagaClassLibrary.Controls.Accounting.xuc_Voucher()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Generate_Cash_Advances = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Cash_Advances = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_Liquidated = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload_UnLiquidated = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Unliquidated = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_UnLiquidated_Employee = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_UnLiquidated_LTO = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close_Voucher = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Lock_Unlock = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Cancel = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.btn_Pending = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_COA_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEdit_Unclosed_Advances = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Display_All_Checks = New DevExpress.XtraEditors.CheckEdit()
            Me.check_New_Wizard = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Auto_Expire = New DevExpress.XtraEditors.CheckEdit()
            Me.Days_Expiry = New DevExpress.XtraEditors.SpinEdit()
            Me.check_Save_Journal_Entries = New DevExpress.XtraEditors.CheckEdit()
            Me.check_New_Data_Row = New DevExpress.XtraEditors.CheckEdit()
            Me.check_Generate_Cash_Advances = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Journal_Entries = New SagaClassLibrary.Controls.Accounting.xuc_Journal_Entries()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.repositoryItemComboBox_Account_Code = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.repositoryItemLookUpEdit_Accounts = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colVoucher_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Branch = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Profile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Date_Posted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Approver = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colVoucher_Check = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsBudget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsForLiquidation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLTO = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colExpense_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Date_Return = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Days = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Date_Expiry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLiquidated = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsOverDue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOverDue_Days = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidated_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJustification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.PopupMenu_New = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_New_Wizard = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPane1.SuspendLayout()
            Me.TabNavigationPage1.SuspendLayout()
            Me.TabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.checkEdit_Unclosed_Advances.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Display_All_Checks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_New_Wizard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Auto_Expire.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Days_Expiry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Save_Journal_Entries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_New_Data_Row.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.check_Generate_Cash_Advances.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel3.SuspendLayout()
            Me.DockPanel3_Container.SuspendLayout()
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xuc_Voucher
            '
            Me.xuc_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Voucher.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Voucher.Name = "xuc_Voucher"
            Me.xuc_Voucher.Size = New System.Drawing.Size(393, 494)
            Me.xuc_Voucher.TabIndex = 0
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Delete, Me.BarEditItem_Search, Me.btn_Journal_Entries, Me.btn_Validate, Me.btn_Cancel, Me.btn_Update, Me.btn_COA_Ledger, Me.btn_Pending, Me.btn_Stop, Me.btn_Close_Voucher, Me.btn_Verify, Me.btn_Unliquidated, Me.btn_UnLiquidated_Employee, Me.btn_Reload_Liquidated, Me.btn_Reload_UnLiquidated, Me.btn_Cash_Advances, Me.btn_UnLiquidated_LTO, Me.btn_Lock_Unlock, Me.btn_Generate_Cash_Advances, Me.btn_New_Wizard})
            Me.barManager.MaxItemId = 35
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox_Account_Code, Me.repositoryItemLookUpEdit_Branch, Me.repositoryItemLookUpEdit_Accounts, Me.RepositoryItemSearchControl_Search})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(85, 178)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close_Voucher), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock_Unlock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Cancel), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 6
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.DropDownControl = Me.PopupMenu_Reload
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'PopupMenu_Reload
            '
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate_Cash_Advances), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Cash_Advances, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_Liquidated), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload_UnLiquidated)})
            Me.PopupMenu_Reload.Manager = Me.barManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Generate_Cash_Advances
            '
            Me.btn_Generate_Cash_Advances.Caption = "Generate Cash Advances"
            Me.btn_Generate_Cash_Advances.Id = 33
            Me.btn_Generate_Cash_Advances.ImageOptions.Image = CType(resources.GetObject("btn_Generate_Cash_Advances.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Generate_Cash_Advances.ImageOptions.LargeImage = CType(resources.GetObject("btn_Generate_Cash_Advances.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Generate_Cash_Advances.Name = "btn_Generate_Cash_Advances"
            '
            'btn_Cash_Advances
            '
            Me.btn_Cash_Advances.Caption = "Cash Advances"
            Me.btn_Cash_Advances.Id = 29
            Me.btn_Cash_Advances.ImageOptions.Image = CType(resources.GetObject("btn_Cash_Advances.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Cash_Advances.ImageOptions.LargeImage = CType(resources.GetObject("btn_Cash_Advances.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Cash_Advances.Name = "btn_Cash_Advances"
            '
            'btn_Reload_Liquidated
            '
            Me.btn_Reload_Liquidated.Caption = "Liquidated"
            Me.btn_Reload_Liquidated.Id = 27
            Me.btn_Reload_Liquidated.ImageOptions.Image = CType(resources.GetObject("btn_Reload_Liquidated.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_Liquidated.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_Liquidated.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_Liquidated.Name = "btn_Reload_Liquidated"
            '
            'btn_Reload_UnLiquidated
            '
            Me.btn_Reload_UnLiquidated.Caption = "Unliquidated"
            Me.btn_Reload_UnLiquidated.Id = 28
            Me.btn_Reload_UnLiquidated.ImageOptions.Image = CType(resources.GetObject("btn_Reload_UnLiquidated.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Reload_UnLiquidated.ImageOptions.LargeImage = CType(resources.GetObject("btn_Reload_UnLiquidated.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Reload_UnLiquidated.Name = "btn_Reload_UnLiquidated"
            '
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
            Me.btn_Preview.Id = 8
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'PopupMenu_Preview
            '
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate_Cash_Advances), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unliquidated), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_UnLiquidated_Employee), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_UnLiquidated_LTO)})
            Me.PopupMenu_Preview.Manager = Me.barManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Unliquidated
            '
            Me.btn_Unliquidated.Caption = "Unliquidated"
            Me.btn_Unliquidated.Id = 25
            Me.btn_Unliquidated.ImageOptions.Image = CType(resources.GetObject("btn_Unliquidated.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unliquidated.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unliquidated.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unliquidated.Name = "btn_Unliquidated"
            '
            'btn_UnLiquidated_Employee
            '
            Me.btn_UnLiquidated_Employee.Caption = "Unliquidated - Employees"
            Me.btn_UnLiquidated_Employee.Id = 26
            Me.btn_UnLiquidated_Employee.ImageOptions.Image = CType(resources.GetObject("btn_UnLiquidated_Employee.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_UnLiquidated_Employee.ImageOptions.LargeImage = CType(resources.GetObject("btn_UnLiquidated_Employee.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_UnLiquidated_Employee.Name = "btn_UnLiquidated_Employee"
            '
            'btn_UnLiquidated_LTO
            '
            Me.btn_UnLiquidated_LTO.Caption = "Unliquidated - LTO"
            Me.btn_UnLiquidated_LTO.Id = 31
            Me.btn_UnLiquidated_LTO.ImageOptions.Image = CType(resources.GetObject("btn_UnLiquidated_LTO.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_UnLiquidated_LTO.ImageOptions.LargeImage = CType(resources.GetObject("btn_UnLiquidated_LTO.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_UnLiquidated_LTO.Name = "btn_UnLiquidated_LTO"
            '
            'btn_New
            '
            Me.btn_New.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_New.Caption = "New"
            Me.btn_New.DropDownControl = Me.PopupMenu_New
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 18
            Me.btn_Update.ImageOptions.ImageIndex = 11
            Me.btn_Update.ImageOptions.LargeImageIndex = 11
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Close_Voucher
            '
            Me.btn_Close_Voucher.Caption = "Close Voucher"
            Me.btn_Close_Voucher.Id = 23
            Me.btn_Close_Voucher.ImageOptions.Image = CType(resources.GetObject("btn_Close_Voucher.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Close_Voucher.ImageOptions.LargeImage = CType(resources.GetObject("btn_Close_Voucher.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Close_Voucher.Name = "btn_Close_Voucher"
            Me.btn_Close_Voucher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 9
            Me.btn_Delete.ImageOptions.ImageIndex = 3
            Me.btn_Delete.ImageOptions.LargeImageIndex = 3
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Lock_Unlock
            '
            Me.btn_Lock_Unlock.Caption = "Lock/Unlock"
            Me.btn_Lock_Unlock.Id = 32
            Me.btn_Lock_Unlock.ImageOptions.Image = CType(resources.GetObject("btn_Lock_Unlock.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Lock_Unlock.ImageOptions.LargeImage = CType(resources.GetObject("btn_Lock_Unlock.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Lock_Unlock.Name = "btn_Lock_Unlock"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Caption = "&Cancel"
            Me.btn_Cancel.Id = 17
            Me.btn_Cancel.ImageOptions.ImageIndex = 10
            Me.btn_Cancel.ImageOptions.LargeImageIndex = 10
            Me.btn_Cancel.Name = "btn_Cancel"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.ImageOptions.LargeImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'bar2
            '
            Me.bar2.BarName = "Options"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 1
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Pending), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop)})
            Me.bar2.Text = "Options"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 14
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 12
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 12
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'btn_Pending
            '
            Me.btn_Pending.Caption = "Pending"
            Me.btn_Pending.Id = 20
            Me.btn_Pending.ImageOptions.ImageIndex = 14
            Me.btn_Pending.ImageOptions.LargeImageIndex = 14
            Me.btn_Pending.Name = "btn_Pending"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 15
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 8
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 8
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_COA_Ledger
            '
            Me.btn_COA_Ledger.Caption = "Ledger"
            Me.btn_COA_Ledger.Id = 19
            Me.btn_COA_Ledger.ImageOptions.ImageIndex = 13
            Me.btn_COA_Ledger.ImageOptions.LargeImageIndex = 13
            Me.btn_COA_Ledger.Name = "btn_COA_Ledger"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Vali&dation"
            Me.btn_Validate.Id = 16
            Me.btn_Validate.ImageOptions.ImageIndex = 9
            Me.btn_Validate.ImageOptions.LargeImageIndex = 9
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 21
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(998, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 568)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(998, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 523)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(998, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 523)
            '
            'DockManager
            '
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2, Me.DockPanel3})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("85298635-a649-467f-ad17-3a61eafed3ff")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.Options.ShowCloseButton = False
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(400, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(400, 523)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Voucher)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(393, 494)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("ff731a5e-9ecb-44a5-9f71-4c66f85061da")
            Me.DockPanel2.Location = New System.Drawing.Point(728, 45)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.Options.ShowCloseButton = False
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(270, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(270, 523)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(263, 494)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'TabPane1
            '
            Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
            Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
            Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabPane1.Location = New System.Drawing.Point(0, 0)
            Me.TabPane1.Name = "TabPane1"
            Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
            Me.TabPane1.RegularSize = New System.Drawing.Size(263, 494)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(263, 494)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "Settings"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(263, 461)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 461)
            Me.xuc_Settings.TabIndex = 1
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(263, 461)
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.checkEdit_Unclosed_Advances)
            Me.LayoutControl.Controls.Add(Me.Check_Display_All_Checks)
            Me.LayoutControl.Controls.Add(Me.check_New_Wizard)
            Me.LayoutControl.Controls.Add(Me.check_Auto_Expire)
            Me.LayoutControl.Controls.Add(Me.Days_Expiry)
            Me.LayoutControl.Controls.Add(Me.check_Save_Journal_Entries)
            Me.LayoutControl.Controls.Add(Me.check_New_Data_Row)
            Me.LayoutControl.Controls.Add(Me.check_Generate_Cash_Advances)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(886, 334, 650, 400)
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(263, 461)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'checkEdit_Unclosed_Advances
            '
            Me.checkEdit_Unclosed_Advances.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit_Unclosed_Advances.MenuManager = Me.barManager
            Me.checkEdit_Unclosed_Advances.Name = "checkEdit_Unclosed_Advances"
            Me.checkEdit_Unclosed_Advances.Properties.Caption = "Show Unclosed Advances"
            Me.checkEdit_Unclosed_Advances.Size = New System.Drawing.Size(239, 20)
            Me.checkEdit_Unclosed_Advances.StyleController = Me.layoutControl
            Me.checkEdit_Unclosed_Advances.TabIndex = 0
            '
            'Check_Display_All_Checks
            '
            Me.Check_Display_All_Checks.Location = New System.Drawing.Point(12, 36)
            Me.Check_Display_All_Checks.MenuManager = Me.barManager
            Me.Check_Display_All_Checks.Name = "Check_Display_All_Checks"
            Me.Check_Display_All_Checks.Properties.Caption = "Display all checks"
            Me.Check_Display_All_Checks.Size = New System.Drawing.Size(239, 20)
            Me.Check_Display_All_Checks.StyleController = Me.layoutControl
            Me.Check_Display_All_Checks.TabIndex = 1
            '
            'check_New_Wizard
            '
            Me.check_New_Wizard.Location = New System.Drawing.Point(12, 60)
            Me.check_New_Wizard.MenuManager = Me.barManager
            Me.check_New_Wizard.Name = "check_New_Wizard"
            Me.check_New_Wizard.Properties.Caption = "New Wizard"
            Me.check_New_Wizard.Size = New System.Drawing.Size(239, 20)
            Me.check_New_Wizard.StyleController = Me.layoutControl
            Me.check_New_Wizard.TabIndex = 2
            '
            'check_Auto_Expire
            '
            Me.check_Auto_Expire.Location = New System.Drawing.Point(12, 132)
            Me.check_Auto_Expire.MenuManager = Me.barManager
            Me.check_Auto_Expire.Name = "check_Auto_Expire"
            Me.check_Auto_Expire.Properties.Caption = "Auto Expire"
            Me.check_Auto_Expire.Size = New System.Drawing.Size(239, 20)
            Me.check_Auto_Expire.StyleController = Me.layoutControl
            Me.check_Auto_Expire.TabIndex = 5
            '
            'Days_Expiry
            '
            Me.Days_Expiry.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.Days_Expiry.Location = New System.Drawing.Point(92, 156)
            Me.Days_Expiry.MenuManager = Me.barManager
            Me.Days_Expiry.Name = "Days_Expiry"
            Me.Days_Expiry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Days_Expiry.Properties.Mask.BeepOnError = True
            Me.Days_Expiry.Properties.Mask.EditMask = "n0"
            Me.Days_Expiry.Size = New System.Drawing.Size(159, 20)
            Me.Days_Expiry.StyleController = Me.layoutControl
            Me.Days_Expiry.TabIndex = 6
            '
            'check_Save_Journal_Entries
            '
            Me.check_Save_Journal_Entries.Location = New System.Drawing.Point(12, 108)
            Me.check_Save_Journal_Entries.Name = "check_Save_Journal_Entries"
            Me.check_Save_Journal_Entries.Properties.AutoWidth = True
            Me.check_Save_Journal_Entries.Properties.Caption = "Save - Show Journal Entries"
            Me.check_Save_Journal_Entries.Size = New System.Drawing.Size(157, 20)
            Me.check_Save_Journal_Entries.StyleController = Me.layoutControl
            Me.check_Save_Journal_Entries.TabIndex = 4
            '
            'check_New_Data_Row
            '
            Me.check_New_Data_Row.Location = New System.Drawing.Point(12, 84)
            Me.check_New_Data_Row.Name = "check_New_Data_Row"
            Me.check_New_Data_Row.Properties.AutoWidth = True
            Me.check_New_Data_Row.Properties.Caption = "New - Create new datarow"
            Me.check_New_Data_Row.Size = New System.Drawing.Size(153, 20)
            Me.check_New_Data_Row.StyleController = Me.layoutControl
            Me.check_New_Data_Row.TabIndex = 3
            '
            'check_Generate_Cash_Advances
            '
            Me.check_Generate_Cash_Advances.Location = New System.Drawing.Point(12, 180)
            Me.check_Generate_Cash_Advances.MenuManager = Me.barManager
            Me.check_Generate_Cash_Advances.Name = "check_Generate_Cash_Advances"
            Me.check_Generate_Cash_Advances.Properties.Caption = "Generate Cash Advances before Print"
            Me.check_Generate_Cash_Advances.Size = New System.Drawing.Size(239, 20)
            Me.check_Generate_Cash_Advances.StyleController = Me.layoutControl
            Me.check_Generate_Cash_Advances.TabIndex = 7
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(263, 461)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.check_New_Data_Row
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.check_Save_Journal_Entries
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem6.TextVisible = False
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Days_Expiry
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem7.Text = "Expire in Days"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.check_Auto_Expire
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem8.TextVisible = False
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.check_New_Wizard
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem9.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Check_Display_All_Checks
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.checkEdit_Unclosed_Advances
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.check_Generate_Cash_Advances
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 168)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(243, 273)
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextVisible = False
            '
            'DockPanel3
            '
            Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
            Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.DockPanel3.ID = New System.Guid("06e72df7-7359-4a32-ac79-fdf7f995e4b6")
            Me.DockPanel3.Location = New System.Drawing.Point(400, 368)
            Me.DockPanel3.Name = "DockPanel3"
            Me.DockPanel3.Options.ShowCloseButton = False
            Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
            Me.DockPanel3.Size = New System.Drawing.Size(328, 200)
            Me.DockPanel3.Text = "Liquidation Entries"
            '
            'DockPanel3_Container
            '
            Me.DockPanel3_Container.Controls.Add(Me.xuc_Journal_Entries)
            Me.DockPanel3_Container.Location = New System.Drawing.Point(3, 27)
            Me.DockPanel3_Container.Name = "DockPanel3_Container"
            Me.DockPanel3_Container.Size = New System.Drawing.Size(322, 170)
            Me.DockPanel3_Container.TabIndex = 0
            '
            'xuc_Journal_Entries
            '
            Me.xuc_Journal_Entries.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Journal_Entries.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Journal_Entries.Name = "xuc_Journal_Entries"
            Me.xuc_Journal_Entries.Size = New System.Drawing.Size(322, 170)
            Me.xuc_Journal_Entries.TabIndex = 0
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 24
            Me.btn_Verify.Name = "btn_Verify"
            '
            'repositoryItemComboBox_Account_Code
            '
            Me.repositoryItemComboBox_Account_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox_Account_Code.Name = "repositoryItemComboBox_Account_Code"
            Me.repositoryItemComboBox_Account_Code.Sorted = True
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'repositoryItemLookUpEdit_Accounts
            '
            Me.repositoryItemLookUpEdit_Accounts.AutoHeight = False
            Me.repositoryItemLookUpEdit_Accounts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Accounts.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Code", "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Reference", "Reference"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Account_Name", "Name")})
            Me.repositoryItemLookUpEdit_Accounts.DisplayMember = "Account_Name"
            Me.repositoryItemLookUpEdit_Accounts.DropDownRows = 20
            Me.repositoryItemLookUpEdit_Accounts.Name = "repositoryItemLookUpEdit_Accounts"
            Me.repositoryItemLookUpEdit_Accounts.NullText = "SELECT Account..."
            Me.repositoryItemLookUpEdit_Accounts.ValueMember = "Account_Code"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(400, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_COA, Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(328, 323)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colVoucher_Code, Me.colCorporation, Me.colVoucher_Reference, Me.colVoucher_Branch, Me.colVoucher_Profile, Me.colJournal_Reference, Me.colAccount_Code, Me.colAccount_Name, Me.colVoucher_Date_Posted, Me.colVoucher_Approver, Me.colVoucher_Description, Me.colVoucher_Debit, Me.colVoucher_Credit, Me.colCheck_Amount, Me.colLiquidation_Total, Me.colCOA_Code, Me.colVoucher_Check, Me.colNotes, Me.colIsBudget, Me.colBudget_Name, Me.colIsForLiquidation, Me.colIsLTO, Me.colExpense_Type, Me.colLiquidation_Description, Me.colLiquidation_Date_Return, Me.colLiquidation_Days, Me.colLiquidation_Date_Expiry, Me.colIsLiquidated, Me.colIsOverDue, Me.colOverDue_Days, Me.colLiquidated_By, Me.colLiquidation_Date, Me.colJustification, Me.colJournal_Description, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colIsLocked, Me.colLocked_By, Me.colLocked_Date})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
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
            'colVoucher_Code
            '
            Me.colVoucher_Code.Caption = "Code"
            Me.colVoucher_Code.FieldName = "Voucher_Code"
            Me.colVoucher_Code.Name = "colVoucher_Code"
            Me.colVoucher_Code.Visible = True
            Me.colVoucher_Code.VisibleIndex = 2
            '
            'colCorporation
            '
            Me.colCorporation.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 3
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'colVoucher_Reference
            '
            Me.colVoucher_Reference.Caption = "Reference"
            Me.colVoucher_Reference.FieldName = "Voucher_Reference"
            Me.colVoucher_Reference.Name = "colVoucher_Reference"
            Me.colVoucher_Reference.Visible = True
            Me.colVoucher_Reference.VisibleIndex = 4
            '
            'colVoucher_Branch
            '
            Me.colVoucher_Branch.Caption = "Branch"
            Me.colVoucher_Branch.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
            Me.colVoucher_Branch.FieldName = "Voucher_Branch"
            Me.colVoucher_Branch.Name = "colVoucher_Branch"
            Me.colVoucher_Branch.Visible = True
            Me.colVoucher_Branch.VisibleIndex = 5
            '
            'colVoucher_Profile
            '
            Me.colVoucher_Profile.Caption = "Profile"
            Me.colVoucher_Profile.FieldName = "Voucher_Profile"
            Me.colVoucher_Profile.Name = "colVoucher_Profile"
            Me.colVoucher_Profile.Visible = True
            Me.colVoucher_Profile.VisibleIndex = 6
            '
            'colJournal_Reference
            '
            Me.colJournal_Reference.Caption = "Liquidation"
            Me.colJournal_Reference.FieldName = "Journal_Reference"
            Me.colJournal_Reference.Name = "colJournal_Reference"
            Me.colJournal_Reference.Visible = True
            Me.colJournal_Reference.VisibleIndex = 7
            '
            'colAccount_Code
            '
            Me.colAccount_Code.Caption = "Account Code"
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 8
            '
            'colAccount_Name
            '
            Me.colAccount_Name.Caption = "Account Name"
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 9
            '
            'colVoucher_Date_Posted
            '
            Me.colVoucher_Date_Posted.Caption = "Transaction"
            Me.colVoucher_Date_Posted.FieldName = "Voucher_Date_Posted"
            Me.colVoucher_Date_Posted.Name = "colVoucher_Date_Posted"
            Me.colVoucher_Date_Posted.Visible = True
            Me.colVoucher_Date_Posted.VisibleIndex = 10
            '
            'colVoucher_Approver
            '
            Me.colVoucher_Approver.Caption = "Approver"
            Me.colVoucher_Approver.FieldName = "Voucher_Approver"
            Me.colVoucher_Approver.Name = "colVoucher_Approver"
            Me.colVoucher_Approver.Visible = True
            Me.colVoucher_Approver.VisibleIndex = 11
            '
            'colVoucher_Description
            '
            Me.colVoucher_Description.Caption = "Remarks"
            Me.colVoucher_Description.FieldName = "Voucher_Description"
            Me.colVoucher_Description.Name = "colVoucher_Description"
            Me.colVoucher_Description.Visible = True
            Me.colVoucher_Description.VisibleIndex = 12
            '
            'colVoucher_Debit
            '
            Me.colVoucher_Debit.Caption = "Debit"
            Me.colVoucher_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVoucher_Debit.FieldName = "Voucher_Debit"
            Me.colVoucher_Debit.Name = "colVoucher_Debit"
            Me.colVoucher_Debit.Visible = True
            Me.colVoucher_Debit.VisibleIndex = 13
            '
            'colVoucher_Credit
            '
            Me.colVoucher_Credit.Caption = "Credit"
            Me.colVoucher_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVoucher_Credit.FieldName = "Voucher_Credit"
            Me.colVoucher_Credit.Name = "colVoucher_Credit"
            Me.colVoucher_Credit.Visible = True
            Me.colVoucher_Credit.VisibleIndex = 14
            '
            'colCheck_Amount
            '
            Me.colCheck_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCheck_Amount.FieldName = "Check_Amount"
            Me.colCheck_Amount.Name = "colCheck_Amount"
            Me.colCheck_Amount.Visible = True
            Me.colCheck_Amount.VisibleIndex = 15
            '
            'colLiquidation_Total
            '
            Me.colLiquidation_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLiquidation_Total.FieldName = "Liquidation_Total"
            Me.colLiquidation_Total.Name = "colLiquidation_Total"
            Me.colLiquidation_Total.Visible = True
            Me.colLiquidation_Total.VisibleIndex = 16
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Account Title"
            Me.colCOA_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 17
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colVoucher_Check
            '
            Me.colVoucher_Check.Caption = "Check Number"
            Me.colVoucher_Check.FieldName = "Voucher_Check"
            Me.colVoucher_Check.Name = "colVoucher_Check"
            Me.colVoucher_Check.Visible = True
            Me.colVoucher_Check.VisibleIndex = 18
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 19
            '
            'colIsBudget
            '
            Me.colIsBudget.FieldName = "IsBudget"
            Me.colIsBudget.Name = "colIsBudget"
            Me.colIsBudget.Visible = True
            Me.colIsBudget.VisibleIndex = 20
            '
            'colBudget_Name
            '
            Me.colBudget_Name.FieldName = "Budget_Name"
            Me.colBudget_Name.Name = "colBudget_Name"
            Me.colBudget_Name.Visible = True
            Me.colBudget_Name.VisibleIndex = 21
            '
            'colIsForLiquidation
            '
            Me.colIsForLiquidation.Caption = "For Liquidation"
            Me.colIsForLiquidation.FieldName = "IsForLiquidation"
            Me.colIsForLiquidation.Name = "colIsForLiquidation"
            Me.colIsForLiquidation.Visible = True
            Me.colIsForLiquidation.VisibleIndex = 22
            '
            'colIsLTO
            '
            Me.colIsLTO.FieldName = "IsLTO"
            Me.colIsLTO.Name = "colIsLTO"
            Me.colIsLTO.Visible = True
            Me.colIsLTO.VisibleIndex = 23
            '
            'colExpense_Type
            '
            Me.colExpense_Type.FieldName = "Expense_Type"
            Me.colExpense_Type.Name = "colExpense_Type"
            Me.colExpense_Type.Visible = True
            Me.colExpense_Type.VisibleIndex = 24
            '
            'colLiquidation_Description
            '
            Me.colLiquidation_Description.FieldName = "Liquidation_Description"
            Me.colLiquidation_Description.Name = "colLiquidation_Description"
            Me.colLiquidation_Description.Visible = True
            Me.colLiquidation_Description.VisibleIndex = 25
            '
            'colLiquidation_Date_Return
            '
            Me.colLiquidation_Date_Return.Caption = "Return Date"
            Me.colLiquidation_Date_Return.FieldName = "Liquidation_Date_Return"
            Me.colLiquidation_Date_Return.Name = "colLiquidation_Date_Return"
            Me.colLiquidation_Date_Return.Visible = True
            Me.colLiquidation_Date_Return.VisibleIndex = 26
            '
            'colLiquidation_Days
            '
            Me.colLiquidation_Days.Caption = "Days"
            Me.colLiquidation_Days.FieldName = "Liquidation_Days"
            Me.colLiquidation_Days.Name = "colLiquidation_Days"
            Me.colLiquidation_Days.Visible = True
            Me.colLiquidation_Days.VisibleIndex = 27
            '
            'colLiquidation_Date_Expiry
            '
            Me.colLiquidation_Date_Expiry.Caption = "Date Expiry"
            Me.colLiquidation_Date_Expiry.FieldName = "Liquidation_Date_Expiry"
            Me.colLiquidation_Date_Expiry.Name = "colLiquidation_Date_Expiry"
            Me.colLiquidation_Date_Expiry.Visible = True
            Me.colLiquidation_Date_Expiry.VisibleIndex = 28
            '
            'colIsLiquidated
            '
            Me.colIsLiquidated.FieldName = "IsLiquidated"
            Me.colIsLiquidated.Name = "colIsLiquidated"
            Me.colIsLiquidated.Visible = True
            Me.colIsLiquidated.VisibleIndex = 29
            '
            'colIsOverDue
            '
            Me.colIsOverDue.FieldName = "IsOverDue"
            Me.colIsOverDue.Name = "colIsOverDue"
            Me.colIsOverDue.Visible = True
            Me.colIsOverDue.VisibleIndex = 30
            '
            'colOverDue_Days
            '
            Me.colOverDue_Days.FieldName = "OverDue_Days"
            Me.colOverDue_Days.Name = "colOverDue_Days"
            Me.colOverDue_Days.Visible = True
            Me.colOverDue_Days.VisibleIndex = 31
            '
            'colLiquidated_By
            '
            Me.colLiquidated_By.FieldName = "Liquidated_By"
            Me.colLiquidated_By.Name = "colLiquidated_By"
            Me.colLiquidated_By.Visible = True
            Me.colLiquidated_By.VisibleIndex = 32
            '
            'colLiquidation_Date
            '
            Me.colLiquidation_Date.FieldName = "Liquidation_Date"
            Me.colLiquidation_Date.Name = "colLiquidation_Date"
            Me.colLiquidation_Date.Visible = True
            Me.colLiquidation_Date.VisibleIndex = 33
            '
            'colJustification
            '
            Me.colJustification.FieldName = "Justification"
            Me.colJustification.Name = "colJustification"
            Me.colJustification.Visible = True
            Me.colJustification.VisibleIndex = 34
            '
            'colJournal_Description
            '
            Me.colJournal_Description.FieldName = "Journal_Description"
            Me.colJournal_Description.Name = "colJournal_Description"
            Me.colJournal_Description.Visible = True
            Me.colJournal_Description.VisibleIndex = 35
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 36
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 37
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 38
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 39
            '
            'colIsLocked
            '
            Me.colIsLocked.FieldName = "IsLocked"
            Me.colIsLocked.Name = "colIsLocked"
            Me.colIsLocked.Visible = True
            Me.colIsLocked.VisibleIndex = 40
            '
            'colLocked_By
            '
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 41
            '
            'colLocked_Date
            '
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 42
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock_Unlock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close_Voucher), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Cancel), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'PopupMenu_New
            '
            Me.PopupMenu_New.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New_Wizard)})
            Me.PopupMenu_New.Manager = Me.barManager
            Me.PopupMenu_New.Name = "PopupMenu_New"
            '
            'btn_New_Wizard
            '
            Me.btn_New_Wizard.Caption = "New Wizard"
            Me.btn_New_Wizard.Id = 34
            Me.btn_New_Wizard.Name = "btn_New_Wizard"
            '
            'frm_Vouchers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(998, 568)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel3)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Vouchers"
            Me.Text = "Vouchers List"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPane1.ResumeLayout(False)
            Me.TabNavigationPage1.ResumeLayout(False)
            Me.TabNavigationPage2.ResumeLayout(False)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.checkEdit_Unclosed_Advances.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Display_All_Checks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_New_Wizard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Auto_Expire.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Days_Expiry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Save_Journal_Entries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_New_Data_Row.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.check_Generate_Cash_Advances.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel3.ResumeLayout(False)
            Me.DockPanel3_Container.ResumeLayout(False)
            CType(Me.repositoryItemComboBox_Account_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_New, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar2 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents repositoryItemComboBox_Account_Code As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents repositoryItemLookUpEdit_Accounts As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Profile As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Check As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colVoucher_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Voucher As Controls.Accounting.xuc_Voucher
        Friend WithEvents colVoucher_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Branch As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents check_Save_Journal_Entries As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents check_New_Data_Row As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents colVoucher_Date_Posted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Cancel As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsForLiquidation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colExpense_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Days As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Date_Expiry As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Days_Expiry As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents colIsLiquidated As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents check_Auto_Expire As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_COA_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents check_New_Wizard As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Pending As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents Check_Display_All_Checks As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colVoucher_Approver As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Date_Return As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidated_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Close_Voucher As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents checkEdit_Unclosed_Advances As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Unliquidated As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_UnLiquidated_Employee As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsBudget As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBudget_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Journal_Entries As Controls.Accounting.xuc_Journal_Entries
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Reload_Liquidated As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload_UnLiquidated As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colLiquidation_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJustification As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Cash_Advances As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsOverDue As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOverDue_Days As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_UnLiquidated_LTO As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsLTO As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Lock_Unlock As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colCheck_Amount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Generate_Cash_Advances As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents check_Generate_Cash_Advances As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents PopupMenu_New As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_New_Wizard As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace