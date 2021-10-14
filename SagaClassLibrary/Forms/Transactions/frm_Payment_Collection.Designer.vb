Namespace Forms.Transactions
    Partial Public Class frm_Payment_Collection
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Payment_Collection))
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
            Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.toggle_Depo_Status = New DevExpress.XtraEditors.ToggleSwitch()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu_Save = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Save_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Schedule = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Payments = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.toggle_Collection_Type = New DevExpress.XtraEditors.ToggleSwitch()
            Me.toggle_Payment_Mode = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Total = New DevExpress.XtraEditors.CalcEdit()
            Me.Due_Total = New DevExpress.XtraEditors.CalcEdit()
            Me.PopupContainerControl_Accounts = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search_Accounts = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.Penalty = New DevExpress.XtraEditors.CalcEdit()
            Me.Due_Penalty = New DevExpress.XtraEditors.CalcEdit()
            Me.Balance_Total = New DevExpress.XtraEditors.CalcEdit()
            Me.Balance_Interest = New DevExpress.XtraEditors.CalcEdit()
            Me.Balance_Principal = New DevExpress.XtraEditors.CalcEdit()
            Me.Monthly_Amortization = New DevExpress.XtraEditors.CalcEdit()
            Me.Monthly_Interest = New DevExpress.XtraEditors.CalcEdit()
            Me.Monthly_Principal = New DevExpress.XtraEditors.CalcEdit()
            Me.Due_Interest = New DevExpress.XtraEditors.CalcEdit()
            Me.Due_Principal = New DevExpress.XtraEditors.CalcEdit()
            Me.Rebates = New DevExpress.XtraEditors.CalcEdit()
            Me.Interest = New DevExpress.XtraEditors.CalcEdit()
            Me.Principal = New DevExpress.XtraEditors.CalcEdit()
            Me.Customer_Name = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.Ledger = New DevExpress.XtraEditors.TextEdit()
            Me.Customer_Address = New DevExpress.XtraEditors.TextEdit()
            Me.Unit_Description = New DevExpress.XtraEditors.TextEdit()
            Me.Amount_Paid = New DevExpress.XtraEditors.CalcEdit()
            Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Engine = New DevExpress.XtraEditors.TextEdit()
            Me.Chassis = New DevExpress.XtraEditors.TextEdit()
            Me.Account_Code = New DevExpress.XtraEditors.ButtonEdit()
            Me.AE_Code = New DevExpress.XtraEditors.TextEdit()
            Me.IBP_Reference = New DevExpress.XtraEditors.LookUpEdit()
            Me.Reference = New DevExpress.XtraEditors.ButtonEdit()
            Me.First_Payment = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControl_Total_Due = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TabbedControlGroup2 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
            Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.toggle_Depo_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Collection_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Payment_Mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupContainerControl_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl_Accounts.SuspendLayout()
            CType(Me.Penalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Penalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Balance_Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Balance_Interest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Balance_Principal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Monthly_Amortization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Monthly_Interest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Monthly_Principal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Interest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Due_Principal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Rebates.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Interest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Principal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Ledger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Customer_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Unit_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Amount_Paid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Chassis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AE_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IBP_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.First_Payment.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.First_Payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl_Total_Due, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabbedControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.toggle_Depo_Status)
            Me.layoutControl.Controls.Add(Me.toggle_Collection_Type)
            Me.layoutControl.Controls.Add(Me.toggle_Payment_Mode)
            Me.layoutControl.Controls.Add(Me.Total)
            Me.layoutControl.Controls.Add(Me.Due_Total)
            Me.layoutControl.Controls.Add(Me.PopupContainerControl_Accounts)
            Me.layoutControl.Controls.Add(Me.Penalty)
            Me.layoutControl.Controls.Add(Me.Due_Penalty)
            Me.layoutControl.Controls.Add(Me.Balance_Total)
            Me.layoutControl.Controls.Add(Me.Balance_Interest)
            Me.layoutControl.Controls.Add(Me.Balance_Principal)
            Me.layoutControl.Controls.Add(Me.Monthly_Amortization)
            Me.layoutControl.Controls.Add(Me.Monthly_Interest)
            Me.layoutControl.Controls.Add(Me.Monthly_Principal)
            Me.layoutControl.Controls.Add(Me.Due_Interest)
            Me.layoutControl.Controls.Add(Me.Due_Principal)
            Me.layoutControl.Controls.Add(Me.Rebates)
            Me.layoutControl.Controls.Add(Me.Interest)
            Me.layoutControl.Controls.Add(Me.Principal)
            Me.layoutControl.Controls.Add(Me.Customer_Name)
            Me.layoutControl.Controls.Add(Me.Ledger)
            Me.layoutControl.Controls.Add(Me.Customer_Address)
            Me.layoutControl.Controls.Add(Me.Unit_Description)
            Me.layoutControl.Controls.Add(Me.Amount_Paid)
            Me.layoutControl.Controls.Add(Me.Posting_Date)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Branch_Code)
            Me.layoutControl.Controls.Add(Me.Engine)
            Me.layoutControl.Controls.Add(Me.Chassis)
            Me.layoutControl.Controls.Add(Me.Account_Code)
            Me.layoutControl.Controls.Add(Me.AE_Code)
            Me.layoutControl.Controls.Add(Me.IBP_Reference)
            Me.layoutControl.Controls.Add(Me.Reference)
            Me.layoutControl.Controls.Add(Me.First_Payment)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 24)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(498, 566)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'toggle_Depo_Status
            '
            Me.toggle_Depo_Status.Enabled = False
            Me.toggle_Depo_Status.Location = New System.Drawing.Point(127, 447)
            Me.toggle_Depo_Status.MenuManager = Me.BarManager
            Me.toggle_Depo_Status.Name = "toggle_Depo_Status"
            Me.toggle_Depo_Status.Properties.OffText = "Deposited"
            Me.toggle_Depo_Status.Properties.OnText = "Pullout"
            Me.toggle_Depo_Status.Size = New System.Drawing.Size(124, 19)
            Me.toggle_Depo_Status.StyleController = Me.layoutControl
            Me.toggle_Depo_Status.TabIndex = 16
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_New, Me.btn_Save, Me.btn_Print, Me.btn_Close, Me.btn_Save_New, Me.btn_Save_Close, Me.btn_Payments, Me.btn_Ledger, Me.btn_Schedule})
            Me.BarManager.MaxItemId = 10
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 0
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Schedule, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Payments), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.Bar_Actions.Text = "Actions"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Save
            '
            Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.DropDownControl = Me.PopupMenu_Save
            Me.btn_Save.Id = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'PopupMenu_Save
            '
            Me.PopupMenu_Save.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save_Close)})
            Me.PopupMenu_Save.Manager = Me.BarManager
            Me.PopupMenu_Save.Name = "PopupMenu_Save"
            '
            'btn_Save_New
            '
            Me.btn_Save_New.Caption = "Save and New"
            Me.btn_Save_New.Id = 5
            Me.btn_Save_New.Name = "btn_Save_New"
            '
            'btn_Save_Close
            '
            Me.btn_Save_Close.Caption = "Save and Close"
            Me.btn_Save_Close.Id = 6
            Me.btn_Save_Close.Name = "btn_Save_Close"
            '
            'btn_Print
            '
            Me.btn_Print.Caption = "Print"
            Me.btn_Print.Id = 3
            Me.btn_Print.Name = "btn_Print"
            '
            'btn_Schedule
            '
            Me.btn_Schedule.Caption = "Schedule"
            Me.btn_Schedule.Id = 9
            Me.btn_Schedule.ImageOptions.Image = CType(resources.GetObject("btn_Schedule.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Schedule.ImageOptions.LargeImage = CType(resources.GetObject("btn_Schedule.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Schedule.Name = "btn_Schedule"
            '
            'btn_Payments
            '
            Me.btn_Payments.Caption = "Payments"
            Me.btn_Payments.Id = 7
            Me.btn_Payments.Name = "btn_Payments"
            '
            'btn_Ledger
            '
            Me.btn_Ledger.Caption = "Ledger"
            Me.btn_Ledger.Id = 8
            Me.btn_Ledger.Name = "btn_Ledger"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 4
            Me.btn_Close.Name = "btn_Close"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(498, 24)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 590)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(498, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(498, 24)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
            '
            'toggle_Collection_Type
            '
            Me.toggle_Collection_Type.Location = New System.Drawing.Point(351, 200)
            Me.toggle_Collection_Type.MenuManager = Me.BarManager
            Me.toggle_Collection_Type.Name = "toggle_Collection_Type"
            Me.toggle_Collection_Type.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.toggle_Collection_Type.Properties.OffText = "Cash"
            Me.toggle_Collection_Type.Properties.OnText = "Non-Cash"
            Me.toggle_Collection_Type.Size = New System.Drawing.Size(123, 19)
            Me.toggle_Collection_Type.StyleController = Me.layoutControl
            Me.toggle_Collection_Type.TabIndex = 9
            '
            'toggle_Payment_Mode
            '
            Me.toggle_Payment_Mode.Location = New System.Drawing.Point(365, 200)
            Me.toggle_Payment_Mode.Name = "toggle_Payment_Mode"
            Me.toggle_Payment_Mode.Properties.OffText = "Normal"
            Me.toggle_Payment_Mode.Properties.OnText = "Full"
            Me.toggle_Payment_Mode.Size = New System.Drawing.Size(109, 19)
            Me.toggle_Payment_Mode.StyleController = Me.layoutControl
            Me.toggle_Payment_Mode.TabIndex = 9
            '
            'Total
            '
            Me.Total.Location = New System.Drawing.Point(370, 351)
            Me.Total.Name = "Total"
            Me.Total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Total.Properties.Appearance.Options.UseFont = True
            Me.Total.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Total.Properties.ReadOnly = True
            Me.Total.Size = New System.Drawing.Size(92, 20)
            Me.Total.StyleController = Me.layoutControl
            Me.Total.TabIndex = 17
            '
            'Due_Total
            '
            Me.Due_Total.Location = New System.Drawing.Point(127, 351)
            Me.Due_Total.Name = "Due_Total"
            Me.Due_Total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Due_Total.Properties.Appearance.Options.UseFont = True
            Me.Due_Total.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Total.Properties.ReadOnly = True
            Me.Due_Total.Size = New System.Drawing.Size(124, 20)
            Me.Due_Total.StyleController = Me.layoutControl
            Me.Due_Total.TabIndex = 12
            '
            'PopupContainerControl_Accounts
            '
            Me.PopupContainerControl_Accounts.Controls.Add(Me.xuc_Account_Search_Accounts)
            Me.PopupContainerControl_Accounts.Location = New System.Drawing.Point(292, 478)
            Me.PopupContainerControl_Accounts.Margin = New System.Windows.Forms.Padding(2)
            Me.PopupContainerControl_Accounts.Name = "PopupContainerControl_Accounts"
            Me.PopupContainerControl_Accounts.Size = New System.Drawing.Size(315, 188)
            Me.PopupContainerControl_Accounts.TabIndex = 88
            '
            'xuc_Account_Search_Accounts
            '
            Me.xuc_Account_Search_Accounts.AccountName = Nothing
            Me.xuc_Account_Search_Accounts.Amount = New Decimal(New Integer() {0, 0, 0, 0})
            Me.xuc_Account_Search_Accounts.Code = Nothing
            Me.xuc_Account_Search_Accounts.Code2 = Nothing
            Me.xuc_Account_Search_Accounts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search_Accounts.ID = 0
            Me.xuc_Account_Search_Accounts.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search_Accounts.Margin = New System.Windows.Forms.Padding(2)
            Me.xuc_Account_Search_Accounts.Name = "xuc_Account_Search_Accounts"
            Me.xuc_Account_Search_Accounts.Others = Nothing
            Me.xuc_Account_Search_Accounts.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            Me.xuc_Account_Search_Accounts.Size = New System.Drawing.Size(315, 188)
            Me.xuc_Account_Search_Accounts.TabIndex = 0
            Me.xuc_Account_Search_Accounts.Type = Nothing
            '
            'Penalty
            '
            Me.Penalty.Location = New System.Drawing.Point(370, 423)
            Me.Penalty.Name = "Penalty"
            Me.Penalty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Penalty.Size = New System.Drawing.Size(92, 20)
            Me.Penalty.StyleController = Me.layoutControl
            Me.Penalty.TabIndex = 20
            '
            'Due_Penalty
            '
            Me.Due_Penalty.Location = New System.Drawing.Point(127, 423)
            Me.Due_Penalty.Name = "Due_Penalty"
            Me.Due_Penalty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Penalty.Properties.ReadOnly = True
            Me.Due_Penalty.Size = New System.Drawing.Size(124, 20)
            Me.Due_Penalty.StyleController = Me.layoutControl
            Me.Due_Penalty.TabIndex = 15
            '
            'Balance_Total
            '
            Me.Balance_Total.Location = New System.Drawing.Point(115, 366)
            Me.Balance_Total.Name = "Balance_Total"
            Me.Balance_Total.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Balance_Total.Properties.ReadOnly = True
            Me.Balance_Total.Size = New System.Drawing.Size(359, 20)
            Me.Balance_Total.StyleController = Me.layoutControl
            Me.Balance_Total.TabIndex = 2
            '
            'Balance_Interest
            '
            Me.Balance_Interest.Location = New System.Drawing.Point(115, 318)
            Me.Balance_Interest.Name = "Balance_Interest"
            Me.Balance_Interest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Balance_Interest.Properties.ReadOnly = True
            Me.Balance_Interest.Size = New System.Drawing.Size(359, 20)
            Me.Balance_Interest.StyleController = Me.layoutControl
            Me.Balance_Interest.TabIndex = 0
            '
            'Balance_Principal
            '
            Me.Balance_Principal.Location = New System.Drawing.Point(115, 342)
            Me.Balance_Principal.Name = "Balance_Principal"
            Me.Balance_Principal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Balance_Principal.Properties.ReadOnly = True
            Me.Balance_Principal.Size = New System.Drawing.Size(359, 20)
            Me.Balance_Principal.StyleController = Me.layoutControl
            Me.Balance_Principal.TabIndex = 1
            '
            'Monthly_Amortization
            '
            Me.Monthly_Amortization.Location = New System.Drawing.Point(115, 366)
            Me.Monthly_Amortization.Name = "Monthly_Amortization"
            Me.Monthly_Amortization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Monthly_Amortization.Properties.ReadOnly = True
            Me.Monthly_Amortization.Size = New System.Drawing.Size(359, 20)
            Me.Monthly_Amortization.StyleController = Me.layoutControl
            Me.Monthly_Amortization.TabIndex = 2
            '
            'Monthly_Interest
            '
            Me.Monthly_Interest.Location = New System.Drawing.Point(115, 318)
            Me.Monthly_Interest.Name = "Monthly_Interest"
            Me.Monthly_Interest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Monthly_Interest.Properties.ReadOnly = True
            Me.Monthly_Interest.Size = New System.Drawing.Size(359, 20)
            Me.Monthly_Interest.StyleController = Me.layoutControl
            Me.Monthly_Interest.TabIndex = 0
            '
            'Monthly_Principal
            '
            Me.Monthly_Principal.Location = New System.Drawing.Point(115, 342)
            Me.Monthly_Principal.Name = "Monthly_Principal"
            Me.Monthly_Principal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Monthly_Principal.Properties.ReadOnly = True
            Me.Monthly_Principal.Size = New System.Drawing.Size(359, 20)
            Me.Monthly_Principal.StyleController = Me.layoutControl
            Me.Monthly_Principal.TabIndex = 1
            '
            'Due_Interest
            '
            Me.Due_Interest.Location = New System.Drawing.Point(127, 375)
            Me.Due_Interest.Name = "Due_Interest"
            Me.Due_Interest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Interest.Properties.ReadOnly = True
            Me.Due_Interest.Size = New System.Drawing.Size(124, 20)
            Me.Due_Interest.StyleController = Me.layoutControl
            Me.Due_Interest.TabIndex = 13
            '
            'Due_Principal
            '
            Me.Due_Principal.Location = New System.Drawing.Point(127, 399)
            Me.Due_Principal.Name = "Due_Principal"
            Me.Due_Principal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Due_Principal.Properties.ReadOnly = True
            Me.Due_Principal.Size = New System.Drawing.Size(124, 20)
            Me.Due_Principal.StyleController = Me.layoutControl
            Me.Due_Principal.TabIndex = 14
            '
            'Rebates
            '
            Me.Rebates.Location = New System.Drawing.Point(370, 447)
            Me.Rebates.Name = "Rebates"
            Me.Rebates.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Rebates.Size = New System.Drawing.Size(92, 20)
            Me.Rebates.StyleController = Me.layoutControl
            Me.Rebates.TabIndex = 21
            '
            'Interest
            '
            Me.Interest.Location = New System.Drawing.Point(370, 375)
            Me.Interest.Name = "Interest"
            Me.Interest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Interest.Size = New System.Drawing.Size(92, 20)
            Me.Interest.StyleController = Me.layoutControl
            Me.Interest.TabIndex = 18
            '
            'Principal
            '
            Me.Principal.Location = New System.Drawing.Point(370, 399)
            Me.Principal.Name = "Principal"
            Me.Principal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Principal.Size = New System.Drawing.Size(92, 20)
            Me.Principal.StyleController = Me.layoutControl
            Me.Principal.TabIndex = 19
            '
            'Customer_Name
            '
            Me.Customer_Name.Location = New System.Drawing.Point(103, 60)
            Me.Customer_Name.Name = "Customer_Name"
            Me.Customer_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Customer_Name.Properties.PopupControl = Me.PopupContainerControl_Accounts
            Me.Customer_Name.Size = New System.Drawing.Size(383, 20)
            Me.Customer_Name.StyleController = Me.layoutControl
            Me.Customer_Name.TabIndex = 3
            '
            'Ledger
            '
            Me.Ledger.Location = New System.Drawing.Point(438, 36)
            Me.Ledger.Name = "Ledger"
            Me.Ledger.Properties.ReadOnly = True
            Me.Ledger.Size = New System.Drawing.Size(48, 20)
            Me.Ledger.StyleController = Me.layoutControl
            Me.Ledger.TabIndex = 2
            '
            'Customer_Address
            '
            Me.Customer_Address.Location = New System.Drawing.Point(103, 84)
            Me.Customer_Address.Name = "Customer_Address"
            Me.Customer_Address.Properties.ReadOnly = True
            Me.Customer_Address.Size = New System.Drawing.Size(291, 20)
            Me.Customer_Address.StyleController = Me.layoutControl
            Me.Customer_Address.TabIndex = 4
            '
            'Unit_Description
            '
            Me.Unit_Description.Location = New System.Drawing.Point(103, 108)
            Me.Unit_Description.Name = "Unit_Description"
            Me.Unit_Description.Properties.ReadOnly = True
            Me.Unit_Description.Size = New System.Drawing.Size(383, 20)
            Me.Unit_Description.StyleController = Me.layoutControl
            Me.Unit_Description.TabIndex = 6
            '
            'Amount_Paid
            '
            Me.Amount_Paid.Location = New System.Drawing.Point(103, 239)
            Me.Amount_Paid.Name = "Amount_Paid"
            Me.Amount_Paid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
            Me.Amount_Paid.Properties.Appearance.Options.UseFont = True
            Me.Amount_Paid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Amount_Paid.Size = New System.Drawing.Size(383, 40)
            Me.Amount_Paid.StyleController = Me.layoutControl
            Me.Amount_Paid.TabIndex = 10
            '
            'Posting_Date
            '
            Me.Posting_Date.EditValue = Nothing
            Me.Posting_Date.Location = New System.Drawing.Point(103, 132)
            Me.Posting_Date.Name = "Posting_Date"
            Me.Posting_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.Posting_Date.Properties.Appearance.Options.UseFont = True
            Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Size = New System.Drawing.Size(383, 26)
            Me.Posting_Date.StyleController = Me.layoutControl
            Me.Posting_Date.TabIndex = 7
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(12, 511)
            Me.Notes.Name = "Notes"
            Me.Notes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Notes.Properties.Appearance.Options.UseFont = True
            Me.Notes.Size = New System.Drawing.Size(474, 43)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 22
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(103, 12)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Properties.NullText = ""
            Me.Branch_Code.Properties.PopupSizeable = False
            Me.Branch_Code.Properties.ReadOnly = True
            Me.Branch_Code.Size = New System.Drawing.Size(383, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 0
            '
            'Engine
            '
            Me.Engine.Location = New System.Drawing.Point(115, 342)
            Me.Engine.Name = "Engine"
            Me.Engine.Properties.ReadOnly = True
            Me.Engine.Size = New System.Drawing.Size(359, 20)
            Me.Engine.StyleController = Me.layoutControl
            Me.Engine.TabIndex = 0
            '
            'Chassis
            '
            Me.Chassis.Location = New System.Drawing.Point(115, 366)
            Me.Chassis.Name = "Chassis"
            Me.Chassis.Properties.ReadOnly = True
            Me.Chassis.Size = New System.Drawing.Size(359, 20)
            Me.Chassis.StyleController = Me.layoutControl
            Me.Chassis.TabIndex = 1
            '
            'Account_Code
            '
            Me.Account_Code.Location = New System.Drawing.Point(103, 36)
            Me.Account_Code.Name = "Account_Code"
            Me.Account_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.Account_Code.Properties.ReadOnly = True
            Me.Account_Code.Size = New System.Drawing.Size(291, 20)
            Me.Account_Code.StyleController = Me.layoutControl
            Me.Account_Code.TabIndex = 1
            '
            'AE_Code
            '
            Me.AE_Code.Location = New System.Drawing.Point(426, 84)
            Me.AE_Code.MenuManager = Me.BarManager
            Me.AE_Code.Name = "AE_Code"
            Me.AE_Code.Properties.ReadOnly = True
            Me.AE_Code.Size = New System.Drawing.Size(60, 20)
            Me.AE_Code.StyleController = Me.layoutControl
            Me.AE_Code.TabIndex = 5
            '
            'IBP_Reference
            '
            Me.IBP_Reference.Location = New System.Drawing.Point(115, 197)
            Me.IBP_Reference.MenuManager = Me.BarManager
            Me.IBP_Reference.Name = "IBP_Reference"
            Me.IBP_Reference.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.IBP_Reference.Properties.Appearance.Options.UseFont = True
            Me.IBP_Reference.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.IBP_Reference.Properties.NullText = ""
            Me.IBP_Reference.Properties.PopupSizeable = False
            Me.IBP_Reference.Properties.ReadOnly = True
            Me.IBP_Reference.Size = New System.Drawing.Size(141, 26)
            Me.IBP_Reference.StyleController = Me.layoutControl
            Me.IBP_Reference.TabIndex = 8
            '
            'Reference
            '
            Me.Reference.Location = New System.Drawing.Point(115, 197)
            Me.Reference.MenuManager = Me.BarManager
            Me.Reference.Name = "Reference"
            Me.Reference.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
            Me.Reference.Properties.Appearance.Options.UseFont = True
            Me.Reference.Properties.BeepOnError = True
            Me.Reference.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Reference.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Reference.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.SimpleMaskManager))
            Me.Reference.Properties.MaskSettings.Set("mask", "LLL-LLL000000")
            Me.Reference.Properties.MaskSettings.Set("saveLiterals", False)
            Me.Reference.Properties.UseMaskAsDisplayFormat = True
            Me.Reference.Size = New System.Drawing.Size(155, 26)
            Me.Reference.StyleController = Me.layoutControl
            Me.Reference.TabIndex = 8
            '
            'First_Payment
            '
            Me.First_Payment.EditValue = Nothing
            Me.First_Payment.Location = New System.Drawing.Point(115, 318)
            Me.First_Payment.MenuManager = Me.BarManager
            Me.First_Payment.Name = "First_Payment"
            Me.First_Payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.First_Payment.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.First_Payment.Properties.ReadOnly = True
            Me.First_Payment.Size = New System.Drawing.Size(359, 20)
            Me.First_Payment.StyleController = Me.layoutControl
            Me.First_Payment.TabIndex = 89
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.TabbedControlGroup1, Me.LayoutControlItem12, Me.LayoutControlItem22, Me.LayoutControlItem7, Me.LayoutControlItem31, Me.TabbedControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(498, 566)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Customer_Name
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(478, 24)
            Me.LayoutControlItem1.Text = "Account Name"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Account_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(386, 24)
            Me.LayoutControlItem2.Text = "Account Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Ledger
            Me.LayoutControlItem3.Location = New System.Drawing.Point(386, 24)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(92, 24)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(92, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(92, 24)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "Ledger"
            Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
            Me.LayoutControlItem3.TextToControlDistance = 5
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Customer_Address
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(386, 24)
            Me.LayoutControlItem4.Text = "Address"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Unit_Description
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(478, 24)
            Me.LayoutControlItem5.Text = "MC Unit"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Amount_Paid
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 227)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(478, 44)
            Me.LayoutControlItem6.Text = "Amount Paid"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(79, 13)
            '
            'TabbedControlGroup1
            '
            Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 271)
            Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
            Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup1
            Me.TabbedControlGroup1.Size = New System.Drawing.Size(478, 212)
            Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6})
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup2})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(454, 165)
            Me.LayoutControlGroup1.Text = "Payment"
            '
            'LayoutControlGroup3
            '
            Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem21, Me.LayoutControlItem24, Me.LayoutControlItem10})
            Me.LayoutControlGroup3.Location = New System.Drawing.Point(243, 0)
            Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
            Me.LayoutControlGroup3.Size = New System.Drawing.Size(211, 165)
            Me.LayoutControlGroup3.Text = "Override"
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.Rebates
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(187, 24)
            Me.LayoutControlItem11.Text = "Rebates"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem13
            '
            Me.LayoutControlItem13.Control = Me.Principal
            Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem13.Name = "LayoutControlItem13"
            Me.LayoutControlItem13.Size = New System.Drawing.Size(187, 24)
            Me.LayoutControlItem13.Text = "Principal"
            Me.LayoutControlItem13.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem21
            '
            Me.LayoutControlItem21.Control = Me.Penalty
            Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem21.Name = "LayoutControlItem21"
            Me.LayoutControlItem21.Size = New System.Drawing.Size(187, 24)
            Me.LayoutControlItem21.Text = "Penalty"
            Me.LayoutControlItem21.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem24
            '
            Me.LayoutControlItem24.Control = Me.Total
            Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem24.Name = "LayoutControlItem24"
            Me.LayoutControlItem24.Size = New System.Drawing.Size(187, 24)
            Me.LayoutControlItem24.Text = "Total"
            Me.LayoutControlItem24.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Interest
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(187, 24)
            Me.LayoutControlItem10.Text = "Interest"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem20, Me.LayoutControl_Total_Due, Me.LayoutControlItem9, Me.LayoutControlItem30})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 165)
            Me.LayoutControlGroup2.Text = "Due"
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Due_Principal
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(219, 24)
            Me.LayoutControlItem8.Text = "Principal"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem20
            '
            Me.LayoutControlItem20.Control = Me.Due_Penalty
            Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem20.Name = "LayoutControlItem20"
            Me.LayoutControlItem20.Size = New System.Drawing.Size(219, 24)
            Me.LayoutControlItem20.Text = "Penalty"
            Me.LayoutControlItem20.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControl_Total_Due
            '
            Me.LayoutControl_Total_Due.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.LayoutControl_Total_Due.AppearanceItemCaption.Options.UseForeColor = True
            Me.LayoutControl_Total_Due.Control = Me.Due_Total
            Me.LayoutControl_Total_Due.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl_Total_Due.Name = "LayoutControl_Total_Due"
            Me.LayoutControl_Total_Due.Size = New System.Drawing.Size(219, 24)
            Me.LayoutControl_Total_Due.Text = "Total Due"
            Me.LayoutControl_Total_Due.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Due_Interest
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(219, 24)
            Me.LayoutControlItem9.Text = "Interest"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem30
            '
            Me.LayoutControlItem30.Control = Me.toggle_Depo_Status
            Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem30.Name = "LayoutControlItem30"
            Me.LayoutControlItem30.Size = New System.Drawing.Size(219, 24)
            Me.LayoutControlItem30.Text = "Deposit Status"
            Me.LayoutControlItem30.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlGroup4
            '
            Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.EmptySpaceItem2, Me.LayoutControlItem16, Me.LayoutControlItem15})
            Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
            Me.LayoutControlGroup4.Size = New System.Drawing.Size(454, 165)
            Me.LayoutControlGroup4.Text = "Amortization"
            '
            'LayoutControlItem14
            '
            Me.LayoutControlItem14.Control = Me.Monthly_Principal
            Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem14.Name = "LayoutControlItem14"
            Me.LayoutControlItem14.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem14.Text = "Principal"
            Me.LayoutControlItem14.TextSize = New System.Drawing.Size(79, 13)
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 72)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(454, 93)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem16
            '
            Me.LayoutControlItem16.Control = Me.Monthly_Amortization
            Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem16.Name = "LayoutControlItem16"
            Me.LayoutControlItem16.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem16.Text = "Monthly"
            Me.LayoutControlItem16.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem15
            '
            Me.LayoutControlItem15.Control = Me.Monthly_Interest
            Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem15.Name = "LayoutControlItem15"
            Me.LayoutControlItem15.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem15.Text = "Interest"
            Me.LayoutControlItem15.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlGroup5
            '
            Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.EmptySpaceItem3, Me.LayoutControlItem19, Me.LayoutControlItem18})
            Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
            Me.LayoutControlGroup5.Size = New System.Drawing.Size(454, 165)
            Me.LayoutControlGroup5.Text = "Balance"
            '
            'LayoutControlItem17
            '
            Me.LayoutControlItem17.Control = Me.Balance_Principal
            Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem17.Name = "LayoutControlItem17"
            Me.LayoutControlItem17.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem17.Text = "Principal"
            Me.LayoutControlItem17.TextSize = New System.Drawing.Size(79, 13)
            '
            'EmptySpaceItem3
            '
            Me.EmptySpaceItem3.AllowHotTrack = False
            Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 72)
            Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
            Me.EmptySpaceItem3.Size = New System.Drawing.Size(454, 93)
            Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem19
            '
            Me.LayoutControlItem19.Control = Me.Balance_Total
            Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem19.Name = "LayoutControlItem19"
            Me.LayoutControlItem19.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem19.Text = "Total"
            Me.LayoutControlItem19.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem18
            '
            Me.LayoutControlItem18.Control = Me.Balance_Interest
            Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem18.Name = "LayoutControlItem18"
            Me.LayoutControlItem18.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem18.Text = "Interest"
            Me.LayoutControlItem18.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlGroup6
            '
            Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem33})
            Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
            Me.LayoutControlGroup6.Size = New System.Drawing.Size(454, 165)
            Me.LayoutControlGroup6.Text = "Others"
            '
            'LayoutControlItem26
            '
            Me.LayoutControlItem26.Control = Me.Engine
            Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem26.Name = "LayoutControlItem26"
            Me.LayoutControlItem26.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem26.Text = "Engine"
            Me.LayoutControlItem26.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem27
            '
            Me.LayoutControlItem27.Control = Me.Chassis
            Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem27.Name = "LayoutControlItem27"
            Me.LayoutControlItem27.Size = New System.Drawing.Size(454, 117)
            Me.LayoutControlItem27.Text = "Chassis"
            Me.LayoutControlItem27.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem33
            '
            Me.LayoutControlItem33.Control = Me.First_Payment
            Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem33.Name = "LayoutControlItem33"
            Me.LayoutControlItem33.Size = New System.Drawing.Size(454, 24)
            Me.LayoutControlItem33.Text = "First Payment"
            Me.LayoutControlItem33.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem12
            '
            Me.LayoutControlItem12.Control = Me.Notes
            Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 483)
            Me.LayoutControlItem12.Name = "LayoutControlItem12"
            Me.LayoutControlItem12.Size = New System.Drawing.Size(478, 63)
            Me.LayoutControlItem12.Text = "Notes"
            Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem12.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem22
            '
            Me.LayoutControlItem22.Control = Me.Branch_Code
            Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem22.Name = "LayoutControlItem22"
            Me.LayoutControlItem22.Size = New System.Drawing.Size(478, 24)
            Me.LayoutControlItem22.Text = "Branch"
            Me.LayoutControlItem22.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Posting_Date
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(478, 30)
            Me.LayoutControlItem7.Text = "Posting Date"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem31
            '
            Me.LayoutControlItem31.Control = Me.AE_Code
            Me.LayoutControlItem31.Location = New System.Drawing.Point(386, 72)
            Me.LayoutControlItem31.Name = "LayoutControlItem31"
            Me.LayoutControlItem31.Size = New System.Drawing.Size(92, 24)
            Me.LayoutControlItem31.Text = "Area"
            Me.LayoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem31.TextSize = New System.Drawing.Size(23, 13)
            Me.LayoutControlItem31.TextToControlDistance = 5
            '
            'TabbedControlGroup2
            '
            Me.TabbedControlGroup2.Location = New System.Drawing.Point(0, 150)
            Me.TabbedControlGroup2.Name = "TabbedControlGroup2"
            Me.TabbedControlGroup2.SelectedTabPage = Me.LayoutControlGroup7
            Me.TabbedControlGroup2.Size = New System.Drawing.Size(478, 77)
            Me.TabbedControlGroup2.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup7, Me.LayoutControlGroup8})
            '
            'LayoutControlGroup7
            '
            Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem29, Me.LayoutControlItem25})
            Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
            Me.LayoutControlGroup7.Size = New System.Drawing.Size(454, 30)
            Me.LayoutControlGroup7.Text = "Local Payment"
            '
            'LayoutControlItem29
            '
            Me.LayoutControlItem29.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LayoutControlItem29.Control = Me.Reference
            Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem29.Name = "LayoutControlItem29"
            Me.LayoutControlItem29.Size = New System.Drawing.Size(250, 30)
            Me.LayoutControlItem29.Text = "OR/Reference"
            Me.LayoutControlItem29.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem25
            '
            Me.LayoutControlItem25.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LayoutControlItem25.Control = Me.toggle_Payment_Mode
            Me.LayoutControlItem25.Location = New System.Drawing.Point(250, 0)
            Me.LayoutControlItem25.Name = "LayoutControlItem25"
            Me.LayoutControlItem25.Size = New System.Drawing.Size(204, 30)
            Me.LayoutControlItem25.Text = "Payment Mode"
            Me.LayoutControlItem25.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlGroup8
            '
            Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.LayoutControlItem28})
            Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
            Me.LayoutControlGroup8.Size = New System.Drawing.Size(454, 30)
            Me.LayoutControlGroup8.Text = "Inter-Branch Payment"
            '
            'LayoutControlItem32
            '
            Me.LayoutControlItem32.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LayoutControlItem32.Control = Me.IBP_Reference
            Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem32.Name = "LayoutControlItem32"
            Me.LayoutControlItem32.Size = New System.Drawing.Size(236, 30)
            Me.LayoutControlItem32.Text = "IBP Reference"
            Me.LayoutControlItem32.TextSize = New System.Drawing.Size(79, 13)
            '
            'LayoutControlItem28
            '
            Me.LayoutControlItem28.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.LayoutControlItem28.Control = Me.toggle_Collection_Type
            Me.LayoutControlItem28.Location = New System.Drawing.Point(236, 0)
            Me.LayoutControlItem28.Name = "LayoutControlItem28"
            Me.LayoutControlItem28.Size = New System.Drawing.Size(218, 30)
            Me.LayoutControlItem28.Text = "Collection Type"
            Me.LayoutControlItem28.TextSize = New System.Drawing.Size(79, 13)
            '
            'PrintDocument
            '
            '
            'PrintPreviewDialog
            '
            Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.PrintPreviewDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
            Me.PrintPreviewDialog.Document = Me.PrintDocument
            Me.PrintPreviewDialog.Enabled = True
            Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
            Me.PrintPreviewDialog.Name = "PrintPreviewDialog1"
            Me.PrintPreviewDialog.Visible = False
            '
            'frm_Payment_Collection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ClientSize = New System.Drawing.Size(498, 590)
            Me.Controls.Add(Me.layoutControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.MaximizeBox = False
            Me.Name = "frm_Payment_Collection"
            Me.Text = "Post Payment"
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.toggle_Depo_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu_Save, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Collection_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Payment_Mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupContainerControl_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl_Accounts.ResumeLayout(False)
            CType(Me.Penalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Penalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Balance_Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Balance_Interest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Balance_Principal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Monthly_Amortization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Monthly_Interest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Monthly_Principal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Interest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Due_Principal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Rebates.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Interest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Principal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Ledger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Customer_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Unit_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Amount_Paid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Chassis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AE_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IBP_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.First_Payment.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.First_Payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl_Total_Due, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabbedControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Customer_Name As DevExpress.XtraEditors.PopupContainerEdit
        Friend WithEvents Ledger As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Customer_Address As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Unit_Description As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Amount_Paid As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Posting_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Interest As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Principal As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Due_Principal As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Rebates As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Due_Interest As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Balance_Total As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Balance_Interest As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Balance_Principal As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Monthly_Amortization As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Monthly_Interest As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Monthly_Principal As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Penalty As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Due_Penalty As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents PopupContainerControl_Accounts As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents xuc_Account_Search_Accounts As Controls.Information.Account.xuc_Account_Search
        Friend WithEvents Total As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Due_Total As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControl_Total_Due As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents toggle_Payment_Mode As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Engine As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Chassis As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu_Save As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents Account_Code As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents btn_Save_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents toggle_Collection_Type As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents toggle_Depo_Status As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents AE_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Payments As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents TabbedControlGroup2 As DevExpress.XtraLayout.TabbedControlGroup
        Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IBP_Reference As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Reference As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents PrintDocument As Drawing.Printing.PrintDocument
        Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
        Friend WithEvents First_Payment As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Schedule As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace