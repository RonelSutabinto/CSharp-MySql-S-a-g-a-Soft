<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_CashieringTransactionsMgmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_CashieringTransactionsMgmt))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmd_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.InvoicesPane = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btn_Del_In = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Mod_In = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Save_In = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_New_In = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_TransactionDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TransactedBy2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TID2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Invoice = New DevExpress.XtraEditors.TextEdit()
        Me.TransactionsDockPane = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btn_Del_Tr = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Mod_Tr = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_SAVE_Tr = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_NEW_Tr = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TransDesc = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Mnemonic = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TargetFrm = New DevExpress.XtraEditors.TextEdit()
        Me.txt_IsCommand = New DevExpress.XtraEditors.TextEdit()
        Me.txt_FrmTxt = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DateUpdated = New DevExpress.XtraEditors.DateEdit()
        Me.txt_DateAdded = New DevExpress.XtraEditors.DateEdit()
        Me.txt_TransactedBy = New DevExpress.XtraEditors.TextEdit()
        Me.GCCashieringTrans = New DevExpress.XtraGrid.GridControl()
        Me.GViewCashieringTrans = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GViewInvoices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_InvoiceID = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.InvoicesPane.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.txt_TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransactionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransactedBy2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TID2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Invoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionsDockPane.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txt_TID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Mnemonic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TargetFrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IsCommand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FrmTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateUpdated.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateUpdated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateAdded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransactedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCashieringTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewCashieringTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InvoiceID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmd_Reload})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmd_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmd_Reload
        '
        Me.cmd_Reload.Caption = "RELOAD"
        Me.cmd_Reload.Id = 1
        Me.cmd_Reload.ImageOptions.Image = CType(resources.GetObject("cmd_Reload.ImageOptions.Image"), System.Drawing.Image)
        Me.cmd_Reload.ImageOptions.LargeImage = CType(resources.GetObject("cmd_Reload.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmd_Reload.Name = "cmd_Reload"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 461)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 437)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 437)
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.TransactionsDockPane)
        Me.hideContainerRight.Controls.Add(Me.InvoicesPane)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(763, 24)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(21, 437)
        '
        'InvoicesPane
        '
        Me.InvoicesPane.Controls.Add(Me.DockPanel2_Container)
        Me.InvoicesPane.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.InvoicesPane.ID = New System.Guid("c9028d99-020a-4091-80d4-a97082d70509")
        Me.InvoicesPane.Location = New System.Drawing.Point(0, 0)
        Me.InvoicesPane.Name = "InvoicesPane"
        Me.InvoicesPane.OriginalSize = New System.Drawing.Size(281, 200)
        Me.InvoicesPane.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.InvoicesPane.SavedIndex = 0
        Me.InvoicesPane.Size = New System.Drawing.Size(281, 437)
        Me.InvoicesPane.Text = "Invoices"
        Me.InvoicesPane.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl16)
        Me.DockPanel2_Container.Controls.Add(Me.btn_Del_In)
        Me.DockPanel2_Container.Controls.Add(Me.txt_InvoiceID)
        Me.DockPanel2_Container.Controls.Add(Me.btn_Mod_In)
        Me.DockPanel2_Container.Controls.Add(Me.btn_Save_In)
        Me.DockPanel2_Container.Controls.Add(Me.btn_New_In)
        Me.DockPanel2_Container.Controls.Add(Me.txt_TransactionDate)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl15)
        Me.DockPanel2_Container.Controls.Add(Me.txt_TransactedBy2)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl14)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl13)
        Me.DockPanel2_Container.Controls.Add(Me.txt_TID2)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl12)
        Me.DockPanel2_Container.Controls.Add(Me.txt_Invoice)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(272, 410)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'btn_Del_In
        '
        Me.btn_Del_In.ImageOptions.Image = CType(resources.GetObject("btn_Del_In.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Del_In.Location = New System.Drawing.Point(146, 201)
        Me.btn_Del_In.Name = "btn_Del_In"
        Me.btn_Del_In.Size = New System.Drawing.Size(124, 24)
        Me.btn_Del_In.TabIndex = 32
        Me.btn_Del_In.Text = "DELETE"
        '
        'btn_Mod_In
        '
        Me.btn_Mod_In.ImageOptions.Image = CType(resources.GetObject("btn_Mod_In.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Mod_In.Location = New System.Drawing.Point(10, 201)
        Me.btn_Mod_In.Name = "btn_Mod_In"
        Me.btn_Mod_In.Size = New System.Drawing.Size(130, 24)
        Me.btn_Mod_In.TabIndex = 33
        Me.btn_Mod_In.Text = "UPDATE"
        '
        'btn_Save_In
        '
        Me.btn_Save_In.ImageOptions.Image = CType(resources.GetObject("btn_Save_In.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Save_In.Location = New System.Drawing.Point(146, 171)
        Me.btn_Save_In.Name = "btn_Save_In"
        Me.btn_Save_In.Size = New System.Drawing.Size(124, 24)
        Me.btn_Save_In.TabIndex = 31
        Me.btn_Save_In.Text = "SAVE"
        '
        'btn_New_In
        '
        Me.btn_New_In.ImageOptions.Image = CType(resources.GetObject("btn_New_In.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New_In.Location = New System.Drawing.Point(8, 171)
        Me.btn_New_In.Name = "btn_New_In"
        Me.btn_New_In.Size = New System.Drawing.Size(132, 24)
        Me.btn_New_In.TabIndex = 30
        Me.btn_New_In.Text = "NEW"
        '
        'txt_TransactionDate
        '
        Me.txt_TransactionDate.EditValue = Nothing
        Me.txt_TransactionDate.Location = New System.Drawing.Point(104, 134)
        Me.txt_TransactionDate.MenuManager = Me.BarManager1
        Me.txt_TransactionDate.Name = "txt_TransactionDate"
        Me.txt_TransactionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TransactionDate.Size = New System.Drawing.Size(167, 22)
        Me.txt_TransactionDate.TabIndex = 12
        '
        'LabelControl15
        '
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(10, 110)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl15.TabIndex = 26
        Me.LabelControl15.Text = "TransactedBy"
        '
        'txt_TransactedBy2
        '
        Me.txt_TransactedBy2.Location = New System.Drawing.Point(104, 107)
        Me.txt_TransactedBy2.MenuManager = Me.BarManager1
        Me.txt_TransactedBy2.Name = "txt_TransactedBy2"
        Me.txt_TransactedBy2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_TransactedBy2.Size = New System.Drawing.Size(167, 22)
        Me.txt_TransactedBy2.TabIndex = 11
        '
        'LabelControl14
        '
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(10, 137)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl14.TabIndex = 24
        Me.LabelControl14.Text = "TransactionDate"
        '
        'LabelControl13
        '
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(10, 82)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl13.TabIndex = 22
        Me.LabelControl13.Text = "TID"
        '
        'txt_TID2
        '
        Me.txt_TID2.Location = New System.Drawing.Point(104, 79)
        Me.txt_TID2.MenuManager = Me.BarManager1
        Me.txt_TID2.Name = "txt_TID2"
        Me.txt_TID2.Size = New System.Drawing.Size(167, 22)
        Me.txt_TID2.TabIndex = 10
        '
        'LabelControl12
        '
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(10, 54)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl12.TabIndex = 20
        Me.LabelControl12.Text = "Invoice"
        '
        'txt_Invoice
        '
        Me.txt_Invoice.Location = New System.Drawing.Point(104, 51)
        Me.txt_Invoice.MenuManager = Me.BarManager1
        Me.txt_Invoice.Name = "txt_Invoice"
        Me.txt_Invoice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Invoice.Size = New System.Drawing.Size(167, 22)
        Me.txt_Invoice.TabIndex = 9
        '
        'TransactionsDockPane
        '
        Me.TransactionsDockPane.Controls.Add(Me.DockPanel1_Container)
        Me.TransactionsDockPane.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.TransactionsDockPane.ID = New System.Guid("a09f67e9-73ce-46d3-9d28-9fae4ae316be")
        Me.TransactionsDockPane.Location = New System.Drawing.Point(0, 0)
        Me.TransactionsDockPane.Name = "TransactionsDockPane"
        Me.TransactionsDockPane.OriginalSize = New System.Drawing.Size(282, 200)
        Me.TransactionsDockPane.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.TransactionsDockPane.SavedIndex = 0
        Me.TransactionsDockPane.Size = New System.Drawing.Size(282, 437)
        Me.TransactionsDockPane.Text = "Transactions"
        Me.TransactionsDockPane.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.btn_Del_Tr)
        Me.DockPanel1_Container.Controls.Add(Me.btn_Mod_Tr)
        Me.DockPanel1_Container.Controls.Add(Me.btn_SAVE_Tr)
        Me.DockPanel1_Container.Controls.Add(Me.btn_NEW_Tr)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl11)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl8)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl6)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.txt_TID)
        Me.DockPanel1_Container.Controls.Add(Me.txt_TransDesc)
        Me.DockPanel1_Container.Controls.Add(Me.txt_Mnemonic)
        Me.DockPanel1_Container.Controls.Add(Me.txt_TargetFrm)
        Me.DockPanel1_Container.Controls.Add(Me.txt_IsCommand)
        Me.DockPanel1_Container.Controls.Add(Me.txt_FrmTxt)
        Me.DockPanel1_Container.Controls.Add(Me.txt_DateUpdated)
        Me.DockPanel1_Container.Controls.Add(Me.txt_DateAdded)
        Me.DockPanel1_Container.Controls.Add(Me.txt_TransactedBy)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(273, 410)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'btn_Del_Tr
        '
        Me.btn_Del_Tr.ImageOptions.Image = CType(resources.GetObject("btn_Del_Tr.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Del_Tr.Location = New System.Drawing.Point(143, 302)
        Me.btn_Del_Tr.Name = "btn_Del_Tr"
        Me.btn_Del_Tr.Size = New System.Drawing.Size(123, 24)
        Me.btn_Del_Tr.TabIndex = 29
        Me.btn_Del_Tr.Text = "DELETE"
        '
        'btn_Mod_Tr
        '
        Me.btn_Mod_Tr.ImageOptions.Image = CType(resources.GetObject("btn_Mod_Tr.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Mod_Tr.Location = New System.Drawing.Point(9, 302)
        Me.btn_Mod_Tr.Name = "btn_Mod_Tr"
        Me.btn_Mod_Tr.Size = New System.Drawing.Size(127, 24)
        Me.btn_Mod_Tr.TabIndex = 29
        Me.btn_Mod_Tr.Text = "UPDATE"
        '
        'btn_SAVE_Tr
        '
        Me.btn_SAVE_Tr.ImageOptions.Image = CType(resources.GetObject("btn_SAVE_Tr.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SAVE_Tr.Location = New System.Drawing.Point(143, 272)
        Me.btn_SAVE_Tr.Name = "btn_SAVE_Tr"
        Me.btn_SAVE_Tr.Size = New System.Drawing.Size(123, 24)
        Me.btn_SAVE_Tr.TabIndex = 28
        Me.btn_SAVE_Tr.Text = "SAVE"
        '
        'btn_NEW_Tr
        '
        Me.btn_NEW_Tr.ImageOptions.Image = CType(resources.GetObject("btn_NEW_Tr.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_NEW_Tr.Location = New System.Drawing.Point(9, 272)
        Me.btn_NEW_Tr.Name = "btn_NEW_Tr"
        Me.btn_NEW_Tr.Size = New System.Drawing.Size(127, 24)
        Me.btn_NEW_Tr.TabIndex = 27
        Me.btn_NEW_Tr.Text = "NEW"
        '
        'LabelControl11
        '
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(3, 231)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "DateUpdated"
        '
        'LabelControl8
        '
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(3, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Transaction"
        '
        'LabelControl2
        '
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(3, 202)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "DateAdded"
        '
        'LabelControl3
        '
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(3, 178)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 15)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "TransactedBy"
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(3, 146)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl4.TabIndex = 21
        Me.LabelControl4.Text = "Form Text Title"
        '
        'LabelControl5
        '
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(3, 118)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(99, 15)
        Me.LabelControl5.TabIndex = 22
        Me.LabelControl5.Text = "IsCommand"
        '
        'LabelControl6
        '
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(3, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "Target Inq Form"
        '
        'LabelControl7
        '
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(3, 66)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 15)
        Me.LabelControl7.TabIndex = 24
        Me.LabelControl7.Text = "Mnemonic"
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "TID"
        '
        'txt_TID
        '
        Me.txt_TID.EditValue = "1"
        Me.txt_TID.Location = New System.Drawing.Point(123, 3)
        Me.txt_TID.MenuManager = Me.BarManager1
        Me.txt_TID.Name = "txt_TID"
        Me.txt_TID.Size = New System.Drawing.Size(131, 22)
        Me.txt_TID.TabIndex = 0
        '
        'txt_TransDesc
        '
        Me.txt_TransDesc.Location = New System.Drawing.Point(123, 31)
        Me.txt_TransDesc.MenuManager = Me.BarManager1
        Me.txt_TransDesc.Name = "txt_TransDesc"
        Me.txt_TransDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TransDesc.Size = New System.Drawing.Size(131, 22)
        Me.txt_TransDesc.TabIndex = 1
        '
        'txt_Mnemonic
        '
        Me.txt_Mnemonic.Location = New System.Drawing.Point(123, 59)
        Me.txt_Mnemonic.MenuManager = Me.BarManager1
        Me.txt_Mnemonic.Name = "txt_Mnemonic"
        Me.txt_Mnemonic.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_Mnemonic.Size = New System.Drawing.Size(131, 22)
        Me.txt_Mnemonic.TabIndex = 2
        '
        'txt_TargetFrm
        '
        Me.txt_TargetFrm.Location = New System.Drawing.Point(123, 87)
        Me.txt_TargetFrm.MenuManager = Me.BarManager1
        Me.txt_TargetFrm.Name = "txt_TargetFrm"
        Me.txt_TargetFrm.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TargetFrm.Size = New System.Drawing.Size(131, 22)
        Me.txt_TargetFrm.TabIndex = 3
        '
        'txt_IsCommand
        '
        Me.txt_IsCommand.Location = New System.Drawing.Point(123, 115)
        Me.txt_IsCommand.MenuManager = Me.BarManager1
        Me.txt_IsCommand.Name = "txt_IsCommand"
        Me.txt_IsCommand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IsCommand.Size = New System.Drawing.Size(131, 22)
        Me.txt_IsCommand.TabIndex = 4
        '
        'txt_FrmTxt
        '
        Me.txt_FrmTxt.Location = New System.Drawing.Point(123, 143)
        Me.txt_FrmTxt.MenuManager = Me.BarManager1
        Me.txt_FrmTxt.Name = "txt_FrmTxt"
        Me.txt_FrmTxt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FrmTxt.Size = New System.Drawing.Size(131, 22)
        Me.txt_FrmTxt.TabIndex = 5
        '
        'txt_DateUpdated
        '
        Me.txt_DateUpdated.EditValue = Nothing
        Me.txt_DateUpdated.Location = New System.Drawing.Point(123, 227)
        Me.txt_DateUpdated.MenuManager = Me.BarManager1
        Me.txt_DateUpdated.Name = "txt_DateUpdated"
        Me.txt_DateUpdated.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DateUpdated.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DateUpdated.Size = New System.Drawing.Size(131, 22)
        Me.txt_DateUpdated.TabIndex = 8
        '
        'txt_DateAdded
        '
        Me.txt_DateAdded.EditValue = Nothing
        Me.txt_DateAdded.Location = New System.Drawing.Point(123, 199)
        Me.txt_DateAdded.MenuManager = Me.BarManager1
        Me.txt_DateAdded.Name = "txt_DateAdded"
        Me.txt_DateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DateAdded.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_DateAdded.Size = New System.Drawing.Size(131, 22)
        Me.txt_DateAdded.TabIndex = 7
        '
        'txt_TransactedBy
        '
        Me.txt_TransactedBy.Location = New System.Drawing.Point(123, 171)
        Me.txt_TransactedBy.MenuManager = Me.BarManager1
        Me.txt_TransactedBy.Name = "txt_TransactedBy"
        Me.txt_TransactedBy.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_TransactedBy.Size = New System.Drawing.Size(131, 22)
        Me.txt_TransactedBy.TabIndex = 6
        '
        'GCCashieringTrans
        '
        Me.GCCashieringTrans.Location = New System.Drawing.Point(12, 12)
        Me.GCCashieringTrans.MainView = Me.GViewCashieringTrans
        Me.GCCashieringTrans.MenuManager = Me.BarManager1
        Me.GCCashieringTrans.Name = "GCCashieringTrans"
        Me.GCCashieringTrans.Size = New System.Drawing.Size(739, 235)
        Me.GCCashieringTrans.TabIndex = 4
        Me.GCCashieringTrans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewCashieringTrans})
        '
        'GViewCashieringTrans
        '
        Me.GViewCashieringTrans.GridControl = Me.GCCashieringTrans
        Me.GViewCashieringTrans.Name = "GViewCashieringTrans"
        Me.GViewCashieringTrans.OptionsBehavior.Editable = False
        Me.GViewCashieringTrans.OptionsView.ColumnAutoWidth = False
        Me.GViewCashieringTrans.OptionsView.ShowGroupPanel = False
        '
        'GCInvoices
        '
        Me.GCInvoices.Location = New System.Drawing.Point(12, 253)
        Me.GCInvoices.MainView = Me.GViewInvoices
        Me.GCInvoices.MenuManager = Me.BarManager1
        Me.GCInvoices.Name = "GCInvoices"
        Me.GCInvoices.Size = New System.Drawing.Size(739, 172)
        Me.GCInvoices.TabIndex = 6
        Me.GCInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewInvoices})
        '
        'GViewInvoices
        '
        Me.GViewInvoices.GridControl = Me.GCInvoices
        Me.GViewInvoices.Name = "GViewInvoices"
        Me.GViewInvoices.OptionsBehavior.Editable = False
        Me.GViewInvoices.OptionsView.ShowGroupPanel = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GCInvoices)
        Me.LayoutControl1.Controls.Add(Me.GCCashieringTrans)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(763, 437)
        Me.LayoutControl1.TabIndex = 11
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.SimpleSeparator1, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(763, 437)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GCCashieringTrans
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(743, 239)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 239)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(462, 2)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GCInvoices
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(743, 176)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(3, 202)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "DateAdded"
        '
        'LabelControl10
        '
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(3, 202)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "DateAdded"
        '
        'LabelControl16
        '
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.Location = New System.Drawing.Point(9, 26)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl16.TabIndex = 22
        Me.LabelControl16.Text = "Invoice ID"
        '
        'txt_InvoiceID
        '
        Me.txt_InvoiceID.Location = New System.Drawing.Point(103, 23)
        Me.txt_InvoiceID.MenuManager = Me.BarManager1
        Me.txt_InvoiceID.Name = "txt_InvoiceID"
        Me.txt_InvoiceID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_InvoiceID.Size = New System.Drawing.Size(167, 22)
        Me.txt_InvoiceID.TabIndex = 21
        '
        'Admin_CashieringTransactionsMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin_CashieringTransactionsMgmt"
        Me.Text = "Cashiering Transaction Management"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.InvoicesPane.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.txt_TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransactionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransactedBy2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TID2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Invoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionsDockPane.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.txt_TID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Mnemonic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TargetFrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IsCommand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FrmTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateUpdated.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateUpdated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateAdded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransactedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCashieringTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewCashieringTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InvoiceID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmd_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GCCashieringTrans As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewCashieringTrans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewInvoices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txt_TID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Mnemonic As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TransDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TargetFrm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_IsCommand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_FrmTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TransactedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_DateUpdated As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents InvoicesPane As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents TransactionsDockPane As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents txt_TransactionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TransactedBy2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TID2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Invoice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Del_Tr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Mod_Tr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_SAVE_Tr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_NEW_Tr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Del_In As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Mod_In As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Save_In As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_New_In As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_InvoiceID As DevExpress.XtraEditors.TextEdit
End Class
