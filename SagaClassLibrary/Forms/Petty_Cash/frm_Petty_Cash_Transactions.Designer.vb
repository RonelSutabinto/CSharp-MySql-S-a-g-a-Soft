Namespace Forms.Petty_Cash

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Petty_Cash_Transactions
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Petty_Cash_Transactions))
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Reload = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Load_All = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Load_Reference = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Load_Engine = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Preview = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Preview_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Expense_Pending = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Expense_Reference = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Payment_Request = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.bar_Options = New DevExpress.XtraBars.Bar()
            Me.barEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.Voucher_Reference = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Voucher_Reference = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.btn_Liquidation_For = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Expense = New SagaClassLibrary.Controls.Petty_Cash.xuc_Expense()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.toggle_For_Approval_Show_Mode = New DevExpress.XtraEditors.ToggleSwitch()
            Me.toggle_Load_Reference = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btn_Liquidate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Replenish = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsReplenished = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPayment_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPTCCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colExpense = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVendor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNoVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRecipient = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeleted_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidated_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidated_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReplenished_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReplenished_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Voucher_Reference, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.layoutControl.SuspendLayout()
            CType(Me.toggle_For_Approval_Show_Mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Load_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar_Options, Me.Bar_Actions})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.DockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Preview, Me.btn_Initialize, Me.BarEditItem_Search, Me.barEditItem_Branch, Me.btn_Liquidate, Me.btn_Approve, Me.btn_Journal, Me.btn_Journal_Entries, Me.btn_Verify, Me.btn_Approval, Me.btn_Liquidation_For, Me.btn_Payment_Request, Me.btn_Expense_Pending, Me.btn_Preview_Approval, Me.Voucher_Reference, Me.btn_Load_Reference, Me.btn_Expense_Reference, Me.btn_Replenish, Me.btn_Stop, Me.btn_DisApprove, Me.btn_Update, Me.btn_Load_Engine, Me.btn_Load_All, Me.btn_Save})
            Me.barManager.MaxItemId = 34
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_Voucher_Reference})
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(351, 206)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Offset = 11
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 8
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
            Me.PopupMenu_Reload.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_All), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_Reference), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Load_Engine)})
            Me.PopupMenu_Reload.Manager = Me.barManager
            Me.PopupMenu_Reload.Name = "PopupMenu_Reload"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "FOR APPROVAL"
            Me.btn_Approval.Id = 17
            Me.btn_Approval.ImageOptions.Image = CType(resources.GetObject("btn_Approval.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Approval.ImageOptions.LargeImage = CType(resources.GetObject("btn_Approval.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_Load_All
            '
            Me.btn_Load_All.Caption = "Load All"
            Me.btn_Load_All.Id = 32
            Me.btn_Load_All.ImageOptions.Image = CType(resources.GetObject("btn_Load_All.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_All.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_All.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_All.Name = "btn_Load_All"
            '
            'btn_Load_Reference
            '
            Me.btn_Load_Reference.Caption = "Load Reference"
            Me.btn_Load_Reference.Id = 23
            Me.btn_Load_Reference.ImageOptions.Image = CType(resources.GetObject("btn_Load_Reference.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_Reference.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_Reference.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_Reference.Name = "btn_Load_Reference"
            '
            'btn_Load_Engine
            '
            Me.btn_Load_Engine.Caption = "Load Expenses with Engine"
            Me.btn_Load_Engine.Id = 30
            Me.btn_Load_Engine.ImageOptions.Image = CType(resources.GetObject("btn_Load_Engine.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Load_Engine.ImageOptions.LargeImage = CType(resources.GetObject("btn_Load_Engine.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Load_Engine.Name = "btn_Load_Engine"
            '
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.DropDownControl = Me.PopupMenu_Preview
            Me.btn_Preview.Id = 7
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'PopupMenu_Preview
            '
            Me.PopupMenu_Preview.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Expense_Pending), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Expense_Reference), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Payment_Request)})
            Me.PopupMenu_Preview.Manager = Me.barManager
            Me.PopupMenu_Preview.Name = "PopupMenu_Preview"
            '
            'btn_Preview_Approval
            '
            Me.btn_Preview_Approval.Caption = "FOR APPROVAL"
            Me.btn_Preview_Approval.Id = 21
            Me.btn_Preview_Approval.Name = "btn_Preview_Approval"
            '
            'btn_Expense_Pending
            '
            Me.btn_Expense_Pending.Caption = "Expense Summary - Pending"
            Me.btn_Expense_Pending.Id = 20
            Me.btn_Expense_Pending.Name = "btn_Expense_Pending"
            '
            'btn_Expense_Reference
            '
            Me.btn_Expense_Reference.Caption = "Expense Summary - Reference"
            Me.btn_Expense_Reference.Id = 25
            Me.btn_Expense_Reference.Name = "btn_Expense_Reference"
            '
            'btn_Payment_Request
            '
            Me.btn_Payment_Request.Caption = "Payment Request"
            Me.btn_Payment_Request.Id = 19
            Me.btn_Payment_Request.Name = "btn_Payment_Request"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 33
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 29
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 3
            Me.btn_Delete.ImageOptions.LargeImageIndex = 3
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.ImageOptions.LargeImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'bar_Options
            '
            Me.bar_Options.BarName = "Options"
            Me.bar_Options.DockCol = 1
            Me.bar_Options.DockRow = 1
            Me.bar_Options.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar_Options.FloatLocation = New System.Drawing.Point(333, 191)
            Me.bar_Options.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.Voucher_Reference)})
            Me.bar_Options.Offset = 418
            Me.bar_Options.Text = "Options"
            '
            'barEditItem_Branch
            '
            Me.barEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.barEditItem_Branch.Id = 10
            Me.barEditItem_Branch.Name = "barEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 9
            Me.BarEditItem_Search.ImageOptions.ImageIndex = 7
            Me.BarEditItem_Search.ImageOptions.LargeImageIndex = 7
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'Voucher_Reference
            '
            Me.Voucher_Reference.AutoFillWidth = True
            Me.Voucher_Reference.Caption = "Reference"
            Me.Voucher_Reference.Edit = Me.RepositoryItemLookUpEdit_Voucher_Reference
            Me.Voucher_Reference.Id = 22
            Me.Voucher_Reference.Name = "Voucher_Reference"
            '
            'RepositoryItemLookUpEdit_Voucher_Reference
            '
            Me.RepositoryItemLookUpEdit_Voucher_Reference.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Voucher_Reference.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.RepositoryItemLookUpEdit_Voucher_Reference.Name = "RepositoryItemLookUpEdit_Voucher_Reference"
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 0
            Me.Bar_Actions.DockRow = 1
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Liquidation_For, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True)})
            Me.Bar_Actions.Text = "Actions"
            '
            'btn_Liquidation_For
            '
            Me.btn_Liquidation_For.Caption = "For Liquidation"
            Me.btn_Liquidation_For.Id = 18
            Me.btn_Liquidation_For.ImageOptions.Image = CType(resources.GetObject("btn_Liquidation_For.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Liquidation_For.ImageOptions.LargeImage = CType(resources.GetObject("btn_Liquidation_For.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Liquidation_For.Name = "btn_Liquidation_For"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 14
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Stop"
            Me.btn_Stop.Id = 27
            Me.btn_Stop.Name = "btn_Stop"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(965, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 538)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(965, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 493)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(965, 45)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 493)
            '
            'DockManager
            '
            Me.DockManager.DockingOptions.ShowCloseButton = False
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.barManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("8b9fb166-5f38-4c47-9de5-c22d34068e47")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 45)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(360, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(360, 493)
            Me.DockPanel1.Text = "Information"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_Expense)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(353, 464)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_Expense
            '
            Me.xuc_Expense.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.xuc_Expense.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.xuc_Expense.Appearance.Options.UseBackColor = True
            Me.xuc_Expense.Appearance.Options.UseFont = True
            Me.xuc_Expense.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Expense.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Expense.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xuc_Expense.Name = "xuc_Expense"
            Me.xuc_Expense.Size = New System.Drawing.Size(353, 464)
            Me.xuc_Expense.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("9132a4e9-54f6-4db9-ade5-b1ba24638f5f")
            Me.DockPanel2.Location = New System.Drawing.Point(685, 45)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(280, 493)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.TabPane1)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(273, 464)
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
            Me.TabPane1.RegularSize = New System.Drawing.Size(273, 464)
            Me.TabPane1.SelectedPage = Me.TabNavigationPage1
            Me.TabPane1.Size = New System.Drawing.Size(273, 464)
            Me.TabPane1.TabIndex = 0
            Me.TabPane1.Text = "TabPane1"
            '
            'TabNavigationPage1
            '
            Me.TabNavigationPage1.Caption = "Form"
            Me.TabNavigationPage1.Controls.Add(Me.xuc_Settings)
            Me.TabNavigationPage1.Name = "TabNavigationPage1"
            Me.TabNavigationPage1.Size = New System.Drawing.Size(273, 431)
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(273, 431)
            Me.xuc_Settings.TabIndex = 0
            '
            'TabNavigationPage2
            '
            Me.TabNavigationPage2.Caption = "Custom"
            Me.TabNavigationPage2.Controls.Add(Me.layoutControl)
            Me.TabNavigationPage2.Name = "TabNavigationPage2"
            Me.TabNavigationPage2.Size = New System.Drawing.Size(273, 431)
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.toggle_For_Approval_Show_Mode)
            Me.layoutControl.Controls.Add(Me.toggle_Load_Reference)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(273, 431)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'toggle_For_Approval_Show_Mode
            '
            Me.toggle_For_Approval_Show_Mode.Location = New System.Drawing.Point(106, 12)
            Me.toggle_For_Approval_Show_Mode.MenuManager = Me.barManager
            Me.toggle_For_Approval_Show_Mode.Name = "toggle_For_Approval_Show_Mode"
            Me.toggle_For_Approval_Show_Mode.Properties.OffText = "List"
            Me.toggle_For_Approval_Show_Mode.Properties.OnText = "Window"
            Me.toggle_For_Approval_Show_Mode.Size = New System.Drawing.Size(155, 18)
            Me.toggle_For_Approval_Show_Mode.StyleController = Me.layoutControl
            Me.toggle_For_Approval_Show_Mode.TabIndex = 4
            '
            'toggle_Load_Reference
            '
            Me.toggle_Load_Reference.Location = New System.Drawing.Point(106, 34)
            Me.toggle_Load_Reference.MenuManager = Me.barManager
            Me.toggle_Load_Reference.Name = "toggle_Load_Reference"
            Me.toggle_Load_Reference.Properties.OffText = "Load Current"
            Me.toggle_Load_Reference.Properties.OnText = "Load Reference"
            Me.toggle_Load_Reference.Size = New System.Drawing.Size(155, 18)
            Me.toggle_Load_Reference.StyleController = Me.layoutControl
            Me.toggle_Load_Reference.TabIndex = 5
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(273, 431)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.toggle_For_Approval_Show_Mode
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(253, 22)
            Me.LayoutControlItem1.Text = "For Approvals"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.toggle_Load_Reference
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 22)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(253, 389)
            Me.LayoutControlItem2.Text = "Select Reference"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
            '
            'btn_Liquidate
            '
            Me.btn_Liquidate.Caption = "Liquidate"
            Me.btn_Liquidate.Id = 11
            Me.btn_Liquidate.ImageOptions.Image = CType(resources.GetObject("btn_Liquidate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Liquidate.ImageOptions.LargeImage = CType(resources.GetObject("btn_Liquidate.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Liquidate.Name = "btn_Liquidate"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 12
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 13
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 15
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Replenish
            '
            Me.btn_Replenish.Caption = "Replenish"
            Me.btn_Replenish.Id = 26
            Me.btn_Replenish.ImageOptions.Image = CType(resources.GetObject("btn_Replenish.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Replenish.ImageOptions.LargeImage = CType(resources.GetObject("btn_Replenish.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Replenish.Name = "btn_Replenish"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "Disapprove"
            Me.btn_DisApprove.Id = 28
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Liquidation_For, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Liquidate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Replenish), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(360, 45)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Corporation})
            Me.gridControl.Size = New System.Drawing.Size(325, 493)
            Me.gridControl.TabIndex = 13
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colIsReplenished, Me.colProfile_Code, Me.colStatus, Me.colCorporation, Me.colBranch_Code, Me.colPostingDate, Me.colPayment_Code, Me.colPTCCategory, Me.colExpense, Me.colAmount, Me.colReceipt, Me.colVendor, Me.colVAT, Me.colNoVAT, Me.colAccountName, Me.colRecipient, Me.colDescription, Me.colNotes, Me.colModel_Code, Me.colEngineNo, Me.colChassisNo, Me.colUnit_Description, Me.colIsDeleted, Me.colDeleted_By, Me.colDeleted_Date, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colLiquidated_By, Me.colLiquidated_Date, Me.colReplenished_By, Me.colReplenished_Date})
            Me.gridView.GridControl = Me.gridControl
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
            'colIsReplenished
            '
            Me.colIsReplenished.FieldName = "IsReplenished"
            Me.colIsReplenished.Name = "colIsReplenished"
            Me.colIsReplenished.Visible = True
            Me.colIsReplenished.VisibleIndex = 2
            '
            'colProfile_Code
            '
            Me.colProfile_Code.FieldName = "Profile_Code"
            Me.colProfile_Code.Name = "colProfile_Code"
            Me.colProfile_Code.Visible = True
            Me.colProfile_Code.VisibleIndex = 3
            '
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "TransStatus"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 4
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Corporation"
            Me.colCorporation.ColumnEdit = Me.RepositoryItemLookUpEdit_Corporation
            Me.colCorporation.FieldName = "Corp"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 5
            '
            'RepositoryItemLookUpEdit_Corporation
            '
            Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "BranchCode"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 6
            '
            'colPostingDate
            '
            Me.colPostingDate.Caption = "Transaction Date"
            Me.colPostingDate.FieldName = "PostingDate"
            Me.colPostingDate.Name = "colPostingDate"
            Me.colPostingDate.Visible = True
            Me.colPostingDate.VisibleIndex = 7
            '
            'colPayment_Code
            '
            Me.colPayment_Code.Caption = "Expense Code"
            Me.colPayment_Code.FieldName = "Payment_Code"
            Me.colPayment_Code.Name = "colPayment_Code"
            Me.colPayment_Code.Visible = True
            Me.colPayment_Code.VisibleIndex = 8
            '
            'colPTCCategory
            '
            Me.colPTCCategory.Caption = "Category"
            Me.colPTCCategory.FieldName = "PTCCategory"
            Me.colPTCCategory.Name = "colPTCCategory"
            Me.colPTCCategory.Visible = True
            Me.colPTCCategory.VisibleIndex = 9
            '
            'colExpense
            '
            Me.colExpense.Caption = "Expense"
            Me.colExpense.FieldName = "ExpDetails"
            Me.colExpense.Name = "colExpense"
            Me.colExpense.Visible = True
            Me.colExpense.VisibleIndex = 10
            '
            'colAmount
            '
            Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmount.FieldName = "AmountPaid"
            Me.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmount.Name = "colAmount"
            Me.colAmount.Visible = True
            Me.colAmount.VisibleIndex = 11
            '
            'colReceipt
            '
            Me.colReceipt.Caption = "Receipt Number"
            Me.colReceipt.FieldName = "ORNo"
            Me.colReceipt.Name = "colReceipt"
            Me.colReceipt.Visible = True
            Me.colReceipt.VisibleIndex = 12
            '
            'colVendor
            '
            Me.colVendor.FieldName = "Vendor"
            Me.colVendor.Name = "colVendor"
            Me.colVendor.Visible = True
            Me.colVendor.VisibleIndex = 13
            '
            'colVAT
            '
            Me.colVAT.Caption = "VAT"
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VATAmt"
            Me.colVAT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 14
            '
            'colNoVAT
            '
            Me.colNoVAT.Caption = "No VAT"
            Me.colNoVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNoVAT.FieldName = "AmntNetofVAT"
            Me.colNoVAT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNoVAT.Name = "colNoVAT"
            Me.colNoVAT.Visible = True
            Me.colNoVAT.VisibleIndex = 15
            '
            'colAccountName
            '
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 16
            '
            'colRecipient
            '
            Me.colRecipient.FieldName = "Recipient"
            Me.colRecipient.Name = "colRecipient"
            Me.colRecipient.Visible = True
            Me.colRecipient.VisibleIndex = 17
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Particulars"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 18
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 19
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 20
            '
            'colEngineNo
            '
            Me.colEngineNo.Caption = "Engine"
            Me.colEngineNo.FieldName = "EngineNo"
            Me.colEngineNo.Name = "colEngineNo"
            Me.colEngineNo.Visible = True
            Me.colEngineNo.VisibleIndex = 21
            '
            'colChassisNo
            '
            Me.colChassisNo.Caption = "Chassis"
            Me.colChassisNo.FieldName = "ChassisNo"
            Me.colChassisNo.Name = "colChassisNo"
            Me.colChassisNo.Visible = True
            Me.colChassisNo.VisibleIndex = 22
            '
            'colUnit_Description
            '
            Me.colUnit_Description.Caption = "Unit_Description"
            Me.colUnit_Description.FieldName = "Unit_Description"
            Me.colUnit_Description.Name = "colUnit_Description"
            Me.colUnit_Description.Visible = True
            Me.colUnit_Description.VisibleIndex = 23
            '
            'colIsDeleted
            '
            Me.colIsDeleted.FieldName = "IsDeleted"
            Me.colIsDeleted.Name = "colIsDeleted"
            Me.colIsDeleted.Visible = True
            Me.colIsDeleted.VisibleIndex = 24
            '
            'colDeleted_By
            '
            Me.colDeleted_By.FieldName = "Deleted_By"
            Me.colDeleted_By.Name = "colDeleted_By"
            Me.colDeleted_By.Visible = True
            Me.colDeleted_By.VisibleIndex = 25
            '
            'colDeleted_Date
            '
            Me.colDeleted_Date.FieldName = "Deleted_Date"
            Me.colDeleted_Date.Name = "colDeleted_Date"
            Me.colDeleted_Date.Visible = True
            Me.colDeleted_Date.VisibleIndex = 26
            '
            'colAdded_By
            '
            Me.colAdded_By.Caption = "Added By"
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 27
            '
            'colAdded_Date
            '
            Me.colAdded_Date.Caption = "Added Date"
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 28
            '
            'colModified_By
            '
            Me.colModified_By.Caption = "Modified By"
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 29
            '
            'colModified_Date
            '
            Me.colModified_Date.Caption = "Modified Date"
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 30
            '
            'colApproved_By
            '
            Me.colApproved_By.Caption = "Approved By"
            Me.colApproved_By.FieldName = "Approver"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 31
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "ApprovedDate"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 32
            '
            'colLiquidated_By
            '
            Me.colLiquidated_By.FieldName = "Liquidated_By"
            Me.colLiquidated_By.Name = "colLiquidated_By"
            Me.colLiquidated_By.Visible = True
            Me.colLiquidated_By.VisibleIndex = 33
            '
            'colLiquidated_Date
            '
            Me.colLiquidated_Date.FieldName = "Liquidated_Date"
            Me.colLiquidated_Date.Name = "colLiquidated_Date"
            Me.colLiquidated_Date.Visible = True
            Me.colLiquidated_Date.VisibleIndex = 34
            '
            'colReplenished_By
            '
            Me.colReplenished_By.FieldName = "Replenished_By"
            Me.colReplenished_By.Name = "colReplenished_By"
            Me.colReplenished_By.Visible = True
            Me.colReplenished_By.VisibleIndex = 35
            '
            'colReplenished_Date
            '
            Me.colReplenished_Date.FieldName = "Replenished_Date"
            Me.colReplenished_Date.Name = "colReplenished_Date"
            Me.colReplenished_Date.Visible = True
            Me.colReplenished_Date.VisibleIndex = 36
            '
            'frm_Petty_Cash_Transactions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(965, 538)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Petty_Cash_Transactions"
            Me.Text = "frm_Petty_Cash_Transactions"
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Reload, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Preview, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Voucher_Reference, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.layoutControl.ResumeLayout(False)
            CType(Me.toggle_For_Approval_Show_Mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Load_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents bar_Options As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents barEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Liquidate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents PopupMenu_Reload As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPostingDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPayment_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPTCCategory As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colExpense As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVendor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNoVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRecipient As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngineNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsDeleted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDeleted_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Liquidation_For As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colLiquidated_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidated_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PopupMenu_Preview As DevExpress.XtraBars.PopupMenu
        Public WithEvents btn_Payment_Request As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Expense_Pending As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Voucher_Reference As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Voucher_Reference As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Load_Reference As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Expense_Reference As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colProfile_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Expense As Controls.Petty_Cash.xuc_Expense
        Friend WithEvents btn_Replenish As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colIsReplenished As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
        Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents toggle_For_Approval_Show_Mode As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassisNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Load_Engine As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Load_All As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colReplenished_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colReplenished_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents toggle_Load_Reference As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace