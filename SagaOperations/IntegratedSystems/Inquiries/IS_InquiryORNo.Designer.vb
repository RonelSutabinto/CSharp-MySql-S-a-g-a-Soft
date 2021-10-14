<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class IS_InquiryORNo
    Inherits DevExpress.XtraEditors.XtraForm
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
    '''
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_InquiryORNo))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.txt_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.txt_InitiatingBr = New System.Windows.Forms.TextBox()
        Me.txt_Mnemonic = New System.Windows.Forms.TextBox()
        Me.txt_BrCode = New System.Windows.Forms.TextBox()
        Me.txt_TransactedBy = New System.Windows.Forms.TextBox()
        Me.txt_AccountNumber = New System.Windows.Forms.TextBox()
        Me.txt_Ledset = New System.Windows.Forms.TextBox()
        Me.txt_Invoices = New System.Windows.Forms.TextBox()
        Me.txt_PostingDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_Transactions = New System.Windows.Forms.TextBox()
        Me.txt_AmountPaid = New System.Windows.Forms.TextBox()
        Me.txt_Descriptions = New System.Windows.Forms.TextBox()
        Me.txt_AccountName = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GVRefNo = New DevExpress.XtraGrid.GridControl()
        Me.GViewRefNo = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.txt_Search})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Menu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.txt_Search, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Menu"
        '
        'txt_Search
        '
        Me.txt_Search.Caption = "SEARCH"
        Me.txt_Search.Edit = Me.RepositoryItemSearchControl1
        Me.txt_Search.EditWidth = 200
        Me.txt_Search.Id = 0
        Me.txt_Search.Name = "txt_Search"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1185, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 647)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1185, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 621)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1185, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 621)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel2.ID = New System.Guid("f8b6d17d-448a-445a-81df-ff87e7dee08d")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(308, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(308, 621)
        Me.DockPanel2.Text = "DETAILS"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel2_Container.Controls.Add(Me.Label15)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(301, 593)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txt_RefNo)
        Me.LayoutControl1.Controls.Add(Me.txt_InitiatingBr)
        Me.LayoutControl1.Controls.Add(Me.txt_Mnemonic)
        Me.LayoutControl1.Controls.Add(Me.txt_BrCode)
        Me.LayoutControl1.Controls.Add(Me.txt_TransactedBy)
        Me.LayoutControl1.Controls.Add(Me.txt_AccountNumber)
        Me.LayoutControl1.Controls.Add(Me.txt_Ledset)
        Me.LayoutControl1.Controls.Add(Me.txt_Invoices)
        Me.LayoutControl1.Controls.Add(Me.txt_PostingDate)
        Me.LayoutControl1.Controls.Add(Me.txt_Transactions)
        Me.LayoutControl1.Controls.Add(Me.txt_AmountPaid)
        Me.LayoutControl1.Controls.Add(Me.txt_Descriptions)
        Me.LayoutControl1.Controls.Add(Me.txt_AccountName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(58, 203, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(301, 593)
        Me.LayoutControl1.TabIndex = 19
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txt_RefNo
        '
        Me.txt_RefNo.Location = New System.Drawing.Point(114, 12)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.Size = New System.Drawing.Size(175, 20)
        Me.txt_RefNo.TabIndex = 0
        '
        'txt_InitiatingBr
        '
        Me.txt_InitiatingBr.Location = New System.Drawing.Point(114, 36)
        Me.txt_InitiatingBr.Name = "txt_InitiatingBr"
        Me.txt_InitiatingBr.Size = New System.Drawing.Size(175, 20)
        Me.txt_InitiatingBr.TabIndex = 16
        '
        'txt_Mnemonic
        '
        Me.txt_Mnemonic.Location = New System.Drawing.Point(114, 180)
        Me.txt_Mnemonic.Name = "txt_Mnemonic"
        Me.txt_Mnemonic.Size = New System.Drawing.Size(175, 20)
        Me.txt_Mnemonic.TabIndex = 16
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Location = New System.Drawing.Point(114, 60)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.Size = New System.Drawing.Size(175, 20)
        Me.txt_BrCode.TabIndex = 16
        '
        'txt_TransactedBy
        '
        Me.txt_TransactedBy.Location = New System.Drawing.Point(114, 300)
        Me.txt_TransactedBy.Name = "txt_TransactedBy"
        Me.txt_TransactedBy.Size = New System.Drawing.Size(175, 20)
        Me.txt_TransactedBy.TabIndex = 16
        '
        'txt_AccountNumber
        '
        Me.txt_AccountNumber.Location = New System.Drawing.Point(114, 84)
        Me.txt_AccountNumber.Name = "txt_AccountNumber"
        Me.txt_AccountNumber.Size = New System.Drawing.Size(175, 20)
        Me.txt_AccountNumber.TabIndex = 16
        '
        'txt_Ledset
        '
        Me.txt_Ledset.Location = New System.Drawing.Point(114, 108)
        Me.txt_Ledset.Name = "txt_Ledset"
        Me.txt_Ledset.Size = New System.Drawing.Size(175, 20)
        Me.txt_Ledset.TabIndex = 16
        '
        'txt_Invoices
        '
        Me.txt_Invoices.Location = New System.Drawing.Point(114, 156)
        Me.txt_Invoices.Name = "txt_Invoices"
        Me.txt_Invoices.Size = New System.Drawing.Size(175, 20)
        Me.txt_Invoices.TabIndex = 16
        '
        'txt_PostingDate
        '
        Me.txt_PostingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_PostingDate.Location = New System.Drawing.Point(114, 204)
        Me.txt_PostingDate.Name = "txt_PostingDate"
        Me.txt_PostingDate.Size = New System.Drawing.Size(175, 23)
        Me.txt_PostingDate.TabIndex = 18
        '
        'txt_Transactions
        '
        Me.txt_Transactions.Location = New System.Drawing.Point(114, 228)
        Me.txt_Transactions.Name = "txt_Transactions"
        Me.txt_Transactions.Size = New System.Drawing.Size(175, 20)
        Me.txt_Transactions.TabIndex = 16
        '
        'txt_AmountPaid
        '
        Me.txt_AmountPaid.Location = New System.Drawing.Point(114, 276)
        Me.txt_AmountPaid.Name = "txt_AmountPaid"
        Me.txt_AmountPaid.Size = New System.Drawing.Size(175, 20)
        Me.txt_AmountPaid.TabIndex = 16
        '
        'txt_Descriptions
        '
        Me.txt_Descriptions.Location = New System.Drawing.Point(114, 252)
        Me.txt_Descriptions.Name = "txt_Descriptions"
        Me.txt_Descriptions.Size = New System.Drawing.Size(175, 20)
        Me.txt_Descriptions.TabIndex = 16
        '
        'txt_AccountName
        '
        Me.txt_AccountName.Location = New System.Drawing.Point(114, 132)
        Me.txt_AccountName.Name = "txt_AccountName"
        Me.txt_AccountName.Size = New System.Drawing.Size(175, 20)
        Me.txt_AccountName.TabIndex = 16
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.LayoutControlItem13, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(301, 593)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_RefNo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem1.Text = "Reference Number"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_InitiatingBr
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem2.Text = "Initiating Branch"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_BrCode
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem3.Text = "BranchCode"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_AccountNumber
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem4.Text = "AccountNumber"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txt_Invoices
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem5.Text = "Invoices"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_PostingDate
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem6.Text = "PostingDate"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_Transactions
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem7.Text = "Transactions"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txt_Descriptions
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 240)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem8.Text = "Descriptions"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txt_AmountPaid
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 264)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem10.Text = "AmountPaid"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txt_TransactedBy
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 288)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem12.Text = "TransactedBy"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txt_Ledset
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem11.Text = "LedgerSetNumber"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(99, 15)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 312)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(281, 261)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txt_Mnemonic
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem13.Text = "Mnemonic"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txt_AccountName
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(281, 24)
        Me.LayoutControlItem9.Text = "Customer"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(99, 15)
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(345, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 23)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Reference No"
        '
        'GVRefNo
        '
        Me.GVRefNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVRefNo.Location = New System.Drawing.Point(308, 26)
        Me.GVRefNo.MainView = Me.GViewRefNo
        Me.GVRefNo.MenuManager = Me.BarManager1
        Me.GVRefNo.Name = "GVRefNo"
        Me.GVRefNo.Size = New System.Drawing.Size(877, 621)
        Me.GVRefNo.TabIndex = 9
        Me.GVRefNo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewRefNo})
        '
        'GViewRefNo
        '
        Me.GViewRefNo.GridControl = Me.GVRefNo
        Me.GViewRefNo.Name = "GViewRefNo"
        Me.GViewRefNo.OptionsBehavior.Editable = False
        Me.GViewRefNo.OptionsView.ColumnAutoWidth = False
        '
        'IS_InquiryORNo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1185, 647)
        Me.Controls.Add(Me.GVRefNo)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_InquiryORNo"
        Me.Text = "OR / Reference Number Inquiry"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents txt_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents GVRefNo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewRefNo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_TransactedBy As TextBox
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents txt_Mnemonic As TextBox
    Friend WithEvents txt_Ledset As TextBox
    Friend WithEvents txt_AmountPaid As TextBox
    Friend WithEvents txt_AccountNumber As TextBox
    Friend WithEvents txt_AccountName As TextBox
    Friend WithEvents txt_Descriptions As TextBox
    Friend WithEvents txt_Transactions As TextBox
    Friend WithEvents txt_BrCode As TextBox
    Friend WithEvents txt_PostingDate As DateTimePicker
    Friend WithEvents txt_Invoices As TextBox
    Friend WithEvents txt_InitiatingBr As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
